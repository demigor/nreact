using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

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
    readonly NPatchLogic _logic;
    PropChanger _propHead;
    ListChanger _listHead;

    public NPatch(NPatchLogic logic)
    {
      _logic = logic;
    }

    public static NPatch Diff(NElement oldE, ref NElement newE, NPatchLogic logic)
    {
      var news = new[] { newE };

      try
      {
        return DiffList(new[] { oldE }, news, logic);
      }
      finally
      {
        newE = news[0];
      }
    }

    internal static NPatch DiffList(NElement[] olds, NElement[] news, NPatchLogic logic)
    {
      var result = new NPatch(logic);

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
      _listHead = new NPatchChildDiffer(_logic).Diff(olds, news);
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
              list.Insert(i.Idx, i.ApplyState(_logic.Create(i.Element)));
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
              _logic.Destroy(i.Element, x);
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
        var children = _logic.GetChildren(uiElement);
        if (children != null)
          ApplyList(children);
      }
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

        for (var i = 0; i < minC; i++)
        {
          var oldE = olds[i];
          var newE = news[i];

          if (Equals(oldE, newE))
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

        for (var i = oldC - 1; i >= minC; i--)
          ChildRemove(i, olds[i]);

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
        if (oldE is NComponent)
        {
          oldE.ReplaceProps(newE.Props);
          newE = oldE;
          return null;
        }

        var result = new NPatch(_logic);

        result.DiffProps(oldE, newE);
        result.DiffList(oldE.Children, newE.Children);

        if (result.IsEmpty)
          return null;

        return result;
      }
    }

    struct NPatchPropertyDiffer
    {
      public PropChanger Diff(NElement oldE, NElement newE)
      {
        return null;
      }
    }
  }

  abstract class NPatchLogic : IEqualityComparer<NElement>
  {
    public abstract object Create(NElement element);
    public abstract void Destroy(NElement element, object uiElement);
    public abstract IList GetChildren(object uiElement);

    public bool Equals(NElement x, NElement y)
    {
      return object.Equals(x.Type, y.Type) && object.Equals(x.Key, y.Key);
    }

    public int GetHashCode(NElement obj)
    {
      return obj.Type.GetHashCode() ^ obj.Key.GetHashCode();
    }
  }
}