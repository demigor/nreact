using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact
{
  interface INPatch
  {
    object Apply(object target);
  }

  static class NPatchBuilder
  {
    public static INPatch Make(NElement oldE, ref NElement newE)
    {
      var newList = new[] { newE };
      var result = DiffList(new[] { oldE }, newList);
      newE = newList[0];
      return result;
    }

    static INPatch DiffList(NElement[] olds, NElement[] news)
    {
      if ((olds ?? NElement.EmptyList) == (news ?? NElement.EmptyList))
        return null;

      return new NPatchListBuilder(NFactory.Default, olds, news).SimpleResult;
    }

    public static void ApplyAsync(this INPatch patch, object xamlElement)
    {
      if (patch != null && xamlElement != null)
        NExtensions.UIInvoke(i =>
        {
          NClass.BeginPatching();
          try
          {
            patch.Apply(i);
          }
          finally
          {
            NClass.EndPatching();
          }
        }, xamlElement);
    }
  }

  enum ListChange
  {
    Create,  // new element
    Destroy, // destroy element
    Move,    // from greater index to lesser
    MRemove, // remove to memory
    MInsert, // insert from memory
    Update,  // update properties/nested only
  }

  struct NPatchListBuilder
  {
    NFactory _factory;
    NLinkedList<NListPatch> _result;
    Dictionary<NElement, NListPatch> _cache;

    public NPatchListBuilder(NFactory factory, NElement[] olds, NElement[] news)
    {
      _factory = factory;
      _result = new NLinkedList<NListPatch>();
      _cache = new Dictionary<NElement, NListPatch>(factory);

      var oldC = olds.Length;
      var newC = news.Length;
      var minC = Math.Min(oldC, newC);

      for (var i = 0; i < minC; i++)
      {
        var oldE = olds[i];
        var newE = news[i];

        if (_factory.Equals(oldE, newE))
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
    }

    public INPatch Result
    {
      get
      {
        return _result.Head;
      }
    }

    public INPatch SimpleResult
    {
      get
      {
        var head = _result.Head;
        if (head == null)
          return null;

        if (head.Kind == ListChange.Update && head.Next == null)
          return head.Patch;

        return head;
      }
    }

    void Simplify()
    {
      _result.RemoveWhere(i => (i.Kind == ListChange.Move && i.Idx == i.From && i.Patch == null)
                              || (i.Kind == ListChange.Update && i.Patch == null));
    }

    void ChildUpdate(int idx, NElement item, INPatch diff)
    {
      var op = new NListPatch { Kind = ListChange.Update, Element = item, Idx = idx, Patch = diff };
      _result.Add(op);
    }

    void ChildInsert(int idx, NElement item)
    {
      NListPatch op;

      if (_cache.TryGetValue(item, out op) && op.Kind == ListChange.Destroy)
      {
        _cache.Remove(item);

        var insert = new NListPatch
        {
          Kind = ListChange.MInsert,
          Element = op.Element,
          Idx = idx,
          MLink = op,
          Patch = DiffState(op.Element, ref item)
        };
        op.MLink = insert;
        op.Kind = ListChange.MRemove;
        _result.Add(insert);
      }
      else
      {
        op = new NListPatch { Kind = ListChange.Create, Element = item, Idx = idx };
        _result.Add(op);
        _cache[item] = op;
      }
    }

    void ChildRemove(int idx, NElement item)
    {
      NListPatch op;

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
        op = new NListPatch
        {
          Kind = ListChange.Destroy,
          Element = item,
          Idx = idx
        };
        _result.Add(op);
        _cache[item] = op;
      }
    }

    INPatch DiffState(NElement oldE, ref NElement newE)
    {
      // no patch for components, just replace props
      var c = oldE as NClass;
      if (c != null)
      {
        c.SetProps(newE.GetProps());
        newE = c;
        return null;
      }

      return new NPatchPropsBuilder(_factory, (NXamlElement)oldE, (NXamlElement)newE).Result;
    }
  }

  struct NPatchPropsBuilder
  {
    Type _type;
    NFactory _factory;
    NLinkedList<NPropPatch> _result;

    public NPropPatch Result { get { return _result.Head; } }

    public NPatchPropsBuilder(NFactory factory, NXamlElement oldE, NXamlElement newE)
    {
      _factory = factory;
      _result = default(NLinkedList<NPropPatch>);
      _type = oldE.GetInnerType();

      Diff(oldE.Props, newE.Props);
    }

    void Diff(NDataBag oldData, NDataBag newData)
    {
      for (var i = oldData; i != null; i = i.Next)
      {
        var key = i.Id;
        var remove = true;

        for (var j = newData; j != null; j = j.Next)
          if (j.Id == key)
          {
            remove = false; // found in new
            break;
          }

        if (remove)
          PropRemove(i.Id, i.Value);
      }

      for (var i = newData; i != null; i = i.Next)
      {
        var key = i.Id;
        var add = true;
        var oldValue = default(object);
        var isNew = true;

        for (var j = oldData; j != null; j = j.Next)
        {
          if (j.Id == key) // found in old
          {
            oldValue = j.Value;
            add = !Equals(oldValue, i.Value); // yield if different
            isNew = false;
            break;
          }
        }

        if (add)
          if (isNew)
            PropAdd(i.Id, i.Value);
          else
            PropChange(i.Id, i.Value, oldValue);
      }
    }

    void PropAdd(int id, object newValue)
    {
      var setter = _factory[id, _type];
      if (setter == null) return;

      Set(setter, newValue, id);
    }

    void PropChange(int id, object newValue, object oldValue)
    {
      var setter = _factory[id, _type];
      if (setter == null) return;

      #region Element Check

      var oldE = oldValue as NElement;
      var newE = newValue as NElement;
      if (oldE != null || newE != null)
      {
        if (oldE == null)
          Set(setter, newE, id);
        else if (newE == null)
          Unset(setter, id);
        else
        {
          if (_factory.Equals(oldE, newE)) // same component
          {
            var c = oldE as NClass;
            if (c != null)
            {
              c.SetProps(newE.GetProps());
              newE = c;
              return;
            }
            else
            {
              var patch = new NPatchPropsBuilder(_factory, (NXamlElement)oldE, (NXamlElement)newE).Result;
              if (patch != null)
                Set(setter, patch, id);
            }
          }
          else
          {
            Set(setter, newE, id);
            Finalize(oldE);
          }
        }
        return;
      }

      #endregion

      #region Array Check

      var oldElements = oldValue as NElement[];
      var newElements = newValue as NElement[];
      if (oldElements != null || newElements != null)
      {
        if (oldElements == null)
          Set(setter, newElements, id);
        else if (newElements == null)
          Unset(setter, id);
        else
        {
          var patch = new NPatchListBuilder(_factory, oldElements, newElements).Result;
          if (patch != null)
            Set(setter, patch, id);
        }
        return;
      }

      #endregion

      Set(setter, newValue, id);
    }

    void PropRemove(int id, object oldValue)
    {
      var setter = _factory[id, _type];
      if (setter == null) return;

      Unset(setter, id);

      Finalize(oldValue);
    }

    void Set(NSetter setter, object value, int id)
    {
#if DEBUG
      _result.Add(new NPropPatch(setter, value, id));
#else
      _result.Add(new NPropPatch(setter, value));
#endif
    }

    void Unset(NSetter setter, int id)
    {
#if DEBUG
      _result.Add(new NPropPatch(setter, NDataBag.UnsetValue, id));
#else
      _result.Add(new NPropPatch(setter, NDataBag.UnsetValue));
#endif
    }

    void Finalize(object oldValue)
    {
      var element = oldValue as NElement;
      if (element != null)
      {
        _factory.Destroy(element, null);
        return;
      }

      var elements = oldValue as NElement[];
      if (elements != null)
      {
        for (var i = 0; i < elements.Length; i++)
          _factory.Destroy(elements[i], null);

        return;
      }
    }
  }

  class NListPatch : NLinkedList<NListPatch>.Item, INPatch
  {
    public ListChange Kind;
    public NElement Element;
    public int Idx, From;
    public INPatch Patch;
    public NListPatch MLink;
    public object Memory;

    public object Apply(object xamlElement)
    {
      var result = new List<object> { xamlElement };
      ApplyToList<object>(result);
      return result[0];
    }

    public object ApplyPatch(object xamlElement)
    {
      return Patch != null ? Patch.Apply(xamlElement) : xamlElement;
    }

    public void ApplyToList(IList list)
    {
      var logic = NFactory.Default;

      for (var i = this; i != null; i = i.Next)
      {
        Debug.WriteLine(i);

        switch (i.Kind)
        {
          case ListChange.Update:
            {
              i.ApplyPatch(list[i.Idx]);
            }
            break;

          case ListChange.Create:
            {
              list.Insert(i.Idx, i.ApplyPatch(logic.Create(i.Element)));
            }
            break;

          case ListChange.MInsert:
            {
              list.Insert(i.Idx, i.ApplyPatch(i.MLink.Memory));
            }
            break;

          case ListChange.MRemove:
            {
              i.Memory = list[i.Idx];
              list.RemoveAt(i.Idx);
            }
            break;

          case ListChange.Move:
            {
              var k = list[i.From];
              list.RemoveAt(i.From);
              list.Insert(i.Idx, i.ApplyPatch(k));
            }
            break;

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

    public void ApplyToList<T>(IList<T> list)
    {
      var logic = NFactory.Default;

      for (var i = this; i != null; i = i.Next)
      {
        Debug.WriteLine(i);

        switch (i.Kind)
        {
          case ListChange.Update:
            {
              i.ApplyPatch(list[i.Idx]);
            }
            break;

          case ListChange.Create:
            {
              list.Insert(i.Idx, (T)i.ApplyPatch(logic.Create(i.Element)));
            }
            break;

          case ListChange.MInsert:
            {
              list.Insert(i.Idx, (T)i.ApplyPatch(i.MLink.Memory));
            }
            break;

          case ListChange.MRemove:
            {
              i.Memory = list[i.Idx];
              list.RemoveAt(i.Idx);
            }
            break;

          case ListChange.Move:
            {
              var k = list[i.From];
              list.RemoveAt(i.From);
              list.Insert(i.Idx, (T)i.ApplyPatch(k));
            }
            break;

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

#if DEBUG
    public override string ToString()
    {
      var sb = new StringBuilder();
      var f = true;

      for (var i = this; i != null; i = i.Next)
      {
        if (f) f = false;
        else sb.Append(", ");

        ToString(sb);
      }

      return sb.ToString();
    }

    void ToString(StringBuilder sb)
    {
      switch (Kind)
      {
        case ListChange.Update: sb.AppendFormat("Update: #{0} ({1}) {2}", Idx, Element, Patch); break;
        case ListChange.Create: sb.AppendFormat("Insert: #{0} ({1})", Idx, Element); break;
        case ListChange.Destroy: sb.AppendFormat("Remove: #{0} ({1})", Idx, Element); break;
        case ListChange.Move: sb.AppendFormat("Move: #{0}->#{1} ({2})", From, Idx, Element); break;
        case ListChange.MRemove: sb.AppendFormat("MRemove: #{0} ({1})", Idx, Element); break;
        case ListChange.MInsert: sb.AppendFormat("MInsert: #{0} ({1})", Idx, Element); break;
      }
    }
#endif
  }

  class NPropPatch : NLinkedList<NPropPatch>.Item, INPatch
  {
#if DEBUG
    public readonly object Key;
    public NPropPatch(NSetter setter, object value, int id)
      : this(setter, value)
    {
      Key = NProps.Store.GetKey(id);
    }
#endif
    public NPropPatch(NSetter setter, object value)
    {
      Setter = setter;
      Value = value;
    }

    public readonly NSetter Setter;
    public readonly object Value;

    public object Apply(object target)
    {
      for (var i = this; i != null; i = i.Next)
        i.Setter(target, i.Value);

      return target;
    }

#if DEBUG
    public override string ToString()
    {
      var sb = new StringBuilder();
      var f = true;

      for (var i = this; i != null; i = i.Next)
      {
        if (f) f = false;
        else sb.Append(", ");

        sb.AppendFormat("{0} = {1}", i.Key, i.Value);
      }

      return sb.ToString();
    }
#endif
  }
}
