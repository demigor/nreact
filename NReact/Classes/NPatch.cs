using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows.Controls;
#endif

namespace NReact
{
  enum ListChange
  {
    Create,  // new element
    Destroy, // destroy element
    Move,    // from greater index to lesser
    MRemove, // remove to memory
    MInsert, // insert from memory
    Update,  // update properties/nested only
  }

  class ListChanger : LList<ListChanger>.Item
  {
    public ListChange Kind;
    public int Idx, From;
    public NElement Element;
    public NPatch Patch;
    public ListChanger MLink;
    public object Memory;

    public object ApplyState(object uiElement)
    {
      if (Patch != null)
        Patch.ApplyState(uiElement);

      return uiElement;
    }

#if DEBUG
    public override string ToString()
    {
      switch (Kind)
      {
        case ListChange.Update:
          return string.Format("Update: #{0} ({1})", Idx, Element);

        case ListChange.Create:
          return string.Format("Insert: #{0} ({1})", Idx, Element);

        case ListChange.Destroy:
          return string.Format("Remove: #{0} ({1})", Idx, Element);

        case ListChange.Move:
          return string.Format("Move: #{0}->#{1} ({2})", From, Idx, Element);

        case ListChange.MRemove:
          return string.Format("MRemove: #{0} ({1})", Idx, Element);

        case ListChange.MInsert:
          return string.Format("MInsert: #{0} ({1})", Idx, Element);
      }
      return null;
    }
#endif
  }

  class PropChanger : LList<PropChanger>.Item
  {
    Action<object, object> _setter;
    object _value;

    public PropChanger(Action<object, object> setter, object value)
    {
      _setter = setter;
      _value = value;
    }

    public void Apply(object target)
    {
      _setter(target, _value);
    }
  }

  class NPatch
  {
    PropChanger _propHead;
    ListChanger _listHead;

    public static NPatch Make(NElement oldE, ref NElement newE)
    {
      var news = new[] { newE };

      try
      {
        return Make(new[] { oldE }, news);
      }
      finally
      {
        newE = news[0];
      }
    }

    internal static NPatch Make(NElement[] olds, NElement[] news)
    {
      var result = new NPatch();

      result.DiffList(olds, news);

      if (result.IsEmpty)
        return null;

      return result;
    }

    void DiffProps(NElement oldE, NElement newE)
    {
      _propHead = new NPatchPropertyDiffer().Diff(oldE, newE);
    }

    void DiffList(NElement[] olds, NElement[] news)
    {
      if (olds == NElement._empty && news == NElement._empty) return;

      _listHead = new NPatchChildDiffer().Diff(olds, news);
    }

    public object Apply(object uiElement)
    {
      var result = new List<object> { uiElement };
      ApplyList(result);
      return result[0];
    }

    void ApplyProps(object uiElement)
    {
      for (var i = _propHead; i != null; i = i.Next)
        i.Apply(uiElement);
    }

    internal void ApplyList(IList list)
    {
      var logic = NPatchLogic.Default;

      for (var i = _listHead; i != null; i = i.Next)
      {
        Debug.WriteLine(i);

        switch (i.Kind)
        {
          case ListChange.Update:
            {
              i.ApplyState(list[i.Idx]);
            } break;

          case ListChange.Create:
            {
              list.Insert(i.Idx, i.ApplyState(logic.Create(i.Element)));
            } break;

          case ListChange.MInsert:
            {
              list.Insert(i.Idx, i.ApplyState(i.MLink.Memory));
            } break;

          case ListChange.MRemove:
            {
              i.Memory = list[i.Idx];
              list.RemoveAt(i.Idx);
            } break;

          case ListChange.Move:
            {
              var k = list[i.From];
              list.RemoveAt(i.From);
              list.Insert(i.Idx, i.ApplyState(k));
            } break;

          case ListChange.Destroy:
            {
              var x = list[i.Idx];
              list.RemoveAt(i.Idx);
              logic.Destroy(i.Element, x);
            }
            break;
        }
      }
    }

    internal void ApplyState(object uiElement)
    {
      ApplyProps(uiElement);

      if (_listHead != null)
      {
        var children = NPatchLogic.Default.GetChildren(uiElement);
        if (children != null)
          ApplyList(children);
      }
    }

    public void ApplyAsync(object target)
    {
      NExtensions.UIInvoke(i => Apply(i), target);
    }

    public bool IsEmpty { get { return _listHead == null && _propHead == null; } }

    struct NPatchChildDiffer
    {
      readonly NPatchLogic _logic;
      LList<ListChanger> _children;
      Dictionary<NElement, ListChanger> _cache;

      public NPatchChildDiffer(NPatchLogic logic)
      {
        _logic = logic;
        _cache = new Dictionary<NElement, ListChanger>(logic);
        _children = new LList<ListChanger>();
      }

      public ListChanger Diff(NElement[] olds, NElement[] news)
      {
        var oldC = olds.Length;
        var newC = news.Length;
        var minC = Math.Min(oldC, newC);
        var logic = NPatchLogic.Default;

        for (var i = 0; i < minC; i++)
        {
          var oldE = olds[i];
          var newE = news[i];

          if (logic.Equals(oldE, newE))
          {
            var diff = DiffState(oldE, ref newE);
            if (diff != null)
              ChildUpdate(i, oldE, diff);
            else if (oldE == newE)
              news[i] = oldE; // put updated old component into new array
          }
          else
          {
            ChildRemove(i, oldE);
            ChildInsert(i, newE);
          }
        }

        for (var i = minC; i < oldC; i++)
          ChildRemove(minC, olds[i]);

        for (var i = minC; i < newC; i++)
          ChildInsert(i, news[i]);

        Simplify();

        return _children.Head;
      }

      void ChildUpdate(int idx, NElement item, NPatch diff)
      {
        var op = new ListChanger { Kind = ListChange.Update, Element = item, Idx = idx, Patch = diff };
        _children.Add(op);
      }

      void ChildInsert(int idx, NElement item)
      {
        ListChanger op;

        if (_cache.TryGetValue(item, out op) && op.Kind == ListChange.Destroy)
        {
          _cache.Remove(item);

          var insert = new ListChanger
          {
            Kind = ListChange.MInsert,
            Element = op.Element,
            Idx = idx,
            MLink = op,
            Patch = DiffState(op.Element, ref item)
          };
          op.MLink = insert;
          op.Kind = ListChange.MRemove;
          _children.Add(insert);
        }
        else
        {
          op = new ListChanger { Kind = ListChange.Create, Element = item, Idx = idx };
          _children.Add(op);
          _cache[item] = op;
        }
      }

      void ChildRemove(int idx, NElement item)
      {
        ListChanger op;

        if (_cache.TryGetValue(item, out op) && op.Kind == ListChange.Create)
        {
          _cache.Remove(item);

          op.From = idx - 1;  // in this case op (insert) is at exec time always second command (after remove), means we need to correct index
          op.Kind = ListChange.Move;
          op.Patch = DiffState(item, ref op.Element);
          op.Element = item;
        }
        else
        {
          op = new ListChanger
          {
            Kind = ListChange.Destroy,
            Element = item,
            Idx = idx
          };
          _children.Add(op);
          _cache[item] = op;
        }
      }

      void Simplify()
      {
        _children.RemoveWhere(i => (i.Kind == ListChange.Move && i.Idx == i.From && i.Patch == null)
                                || (i.Kind == ListChange.Update && i.Patch == null));
      }

      NPatch DiffState(NElement oldE, ref NElement newE)
      {
        // no patch for components, just replace props
        var c = oldE as NComponent;
        if (c != null)
        {
          c.ReplaceProps(newE.Props);
          newE = oldE;
          return null;
        }

        var result = new NPatch();

        result.DiffProps(oldE, newE);
        result.DiffList(((NXamlElement)oldE).Children, ((NXamlElement)newE).Children);

        if (result.IsEmpty)
          return null;

        return result;
      }
    }

    struct NPatchPropertyDiffer
    {
      LList<PropChanger> _changes;

      public PropChanger Diff(NElement oldE, NElement newE)
      {
        var diff = NDynamic.Diff(oldE._props, newE._props);

        if (diff.IsEmpty)
          return null;

        var type = oldE.InnerType;

        for (var i = diff.Head; i != null; i = i.Next)
        {
          var setter = NFactory.GetSetter(type, i.Name);
          if (setter == null) continue;

          _changes.Add(new PropChanger(setter, i.Value));
        }

#if DEBUG
        //head._dump = props.ToDebugString();
#endif

        return _changes.Head;
      }
    }
  }

  class NPatchLogic : IEqualityComparer<NElement>
  {
    public static NPatchLogic Default = new NPatchLogic();

    public virtual object Create(NElement element)
    {
      return NExtensions.CreateTree(element);
    }

    public virtual void Destroy(NElement element, object uiElement)
    {
      element.Unmount();
    }

    public virtual IList GetChildren(object uiElement)
    {
#if NETFX_CORE
      var e = uiElement as Panel;
      if (e == null) return null;
      return new UIList(e.Children);
#else
      var e = uiElement as Panel;
      if (e == null) return null;
      return e.Children;
#endif
    }

    public bool Equals(NElement x, NElement y)
    {
      return object.Equals(x.InnerType, y.InnerType) && object.Equals(x._id, y._id);
    }

    public int GetHashCode(NElement obj)
    {
      return obj.InnerType.GetHashCode() ^ obj._id.GetHashCode();
    }
  }
#if NETFX_CORE
  class UIList : IList
  {
    UIElementCollection _source;
    public UIList(UIElementCollection source)
    {
      _source = source;
    }

    public void Insert(int index, object value)
    {
      _source.Insert(index, (UIElement)value);
    }

    public void RemoveAt(int index)
    {
      _source.RemoveAt(index);
    }

    public object this[int index]
    {
      get
      {
        return _source[index];
      }
      set
      {
        _source[index] = (UIElement)value;
      }
    }


  #region IList Members

    int IList.Add(object value)
    {
      throw new NotImplementedException();
    }

    void IList.Clear()
    {
      throw new NotImplementedException();
    }

    bool IList.Contains(object value)
    {
      throw new NotImplementedException();
    }

    int IList.IndexOf(object value)
    {
      throw new NotImplementedException();
    }

    bool IList.IsFixedSize
    {
      get { throw new NotImplementedException(); }
    }

    bool IList.IsReadOnly
    {
      get { throw new NotImplementedException(); }
    }

    void IList.Remove(object value)
    {
      throw new NotImplementedException();
    }

    #endregion

  #region ICollection Members

    void ICollection.CopyTo(Array array, int index)
    {
      throw new NotImplementedException();
    }

    int ICollection.Count
    {
      get { throw new NotImplementedException(); }
    }

    bool ICollection.IsSynchronized
    {
      get { throw new NotImplementedException(); }
    }

    object ICollection.SyncRoot
    {
      get { throw new NotImplementedException(); }
    }

    #endregion

  #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    #endregion
  }
#endif
}
