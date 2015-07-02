using System;
using System.Collections.Generic;
using System.Linq;
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
  abstract class NPatch
  {
    internal NPatch _next;
    public int Index;

    public override string ToString()
    {
      var sb = new StringBuilder();

      ToString(sb);

      return sb.ToString();
    }

    public virtual void ToString(StringBuilder sb, int indent = 0)
    {
      sb.AppendFormat("{0,4}    {1}", Index, new string(' ', indent * 2));
    }

    public static NPatch Patch(NElement oldUI, ref NElement newUI)
    {
      return Patch(0, oldUI, ref newUI).Simplify();
    }

    public static NPatch Patch(int idx, NElement oldUI, ref NElement newUI)
    {
      if (oldUI == null || oldUI.InnerType != newUI.InnerType)
        return Replace(idx, oldUI, newUI);

      var newProps = newUI._props;

      var comp = oldUI as NComponent;
      if (comp != null)
      {
        newUI = oldUI;
        comp.ReplaceProps(newProps);
        return null;
      }

      var result = new NUpdateVisualPatch { Index = idx };

      var diff = NDynamic.Diff(oldUI._props, newProps);

      if (!diff.IsEmpty)
        result.Changes = NSetter.Prepare(oldUI.InnerType, diff);

      var oldXE = oldUI as NXamlElement;
      if (oldXE != null)
        result.PatchChildren(oldXE.Children, ((NXamlElement)newUI).Children);

      return result;
    }

    public static NPatch Remove(int i, NElement e)
    {
      return new NReplaceVisualPatch { Index = i, Old = e };
    }

    public static NPatch Insert(int i, NElement e)
    {
      return new NReplaceVisualPatch { Index = i, New = e };
    }

    public static NPatch Replace(int idx, NElement oldTree, NElement newTree)
    {
      return new NReplaceVisualPatch { Index = idx, Old = oldTree, New = newTree };
    }

    public abstract NPatch Simplify();

    public abstract UIElement Apply(UIElement target);

    public void ApplyAsync(UIElement target)
    {
      NExtensions.UIInvoke(i => Apply(i), target);
    }

    internal bool _removeMark;

    internal void BackwardRemove(UIElementCollection elements)
    {
      if (_next != null)
        _next.BackwardRemove(elements);

      if (_removeMark)
        elements.RemoveAt(Index);
    }
  }

  class NReplaceVisualPatch : NPatch
  {
    public NElement New, Old;

    public override UIElement Apply(UIElement target)
    {
      if (Old != null)
        Old.Unmount();

      if (New != null)
        return NExtensions.CreateTree(New);

      return null;
    }

    public override NPatch Simplify()
    {
      if (_next != null)
        _next = _next.Simplify();

      return Old == null && New == null ? _next : this;
    }

    public override void ToString(StringBuilder sb, int indent = 0)
    {
      base.ToString(sb, indent);

      if (New == null)
      {
        sb.AppendLine("REMOVE " + Old);
      }
      else
      {
        if (Old == null)
          sb.AppendLine("NEW " + New);
        else
          sb.AppendLine("REPLACE " + New + " (" + Old + ")");
      }
    }
  }

  class NUpdateVisualPatch : NPatch
  {
    public NSetter Changes;
    public NPatch _head;

    public override UIElement Apply(UIElement target)
    {
      NSetter.Execute(Changes, target);

      if (_head != null)
      {
        var p = target as Panel;
        if (p != null)
          ApplyNested(p.Children);
      }

      return target;
    }

    void ApplyNested(UIElementCollection elements)
    {
      var ec = elements.Count;

      for (var patch = _head; patch != null; patch = patch._next)
      {
        var elementIdx = patch.Index;
        var oldVisual = elementIdx < ec ? elements[elementIdx] : null;

        var newVisual = patch.Apply(oldVisual);

        if (newVisual == oldVisual) continue;

        if (oldVisual == null)
          elements.Insert(elementIdx, newVisual);
        else if (newVisual != null)
          elements[elementIdx] = newVisual;
        else
          patch._removeMark = true;
      }

      if (_head != null)
        _head.BackwardRemove(elements);
    }

    public override NPatch Simplify()
    {
      if (_next != null)
        _next = _next.Simplify();

      if (_head != null)
        _head = _head.Simplify();

      if (Changes == null && _head == null)
        return _next;

      return this;
    }

    public override void ToString(StringBuilder sb, int indent = 0)
    {
      base.ToString(sb, indent);

      if (Changes != null)
        sb.AppendLine("CHANGE " + Changes);
      else
        sb.AppendLine("NESTED");

      indent++;

      for (var i = _head; i != null; i = i._next)
        i.ToString(sb, indent);
    }

    public void PatchChildren(NElement[] oldChildren, NElement[] newChildren)
    {
      if (oldChildren == newChildren) return;

      var oc = oldChildren.Length;
      var nc = newChildren.Length;

      if (oc == 0 && nc == 0) return;

      var head = default(NPatch);
      var last = default(NPatch);

      var cc = oc < nc ? oc : nc;

      for (var i = 0; i < cc; i++)
      {
        var oldE = oldChildren[i];

        var child = Patch(i, oldE, ref newChildren[i]);
        if (child == null) continue;

        Append(ref head, ref last, child);
      }

      for (var i = oc; i < nc; i++)
        Append(ref head, ref last, Insert(i, newChildren[i]));

      for (var i = nc; i < oc; i++)
        Append(ref head, ref last, Remove(i, oldChildren[i]));

      _head = head;
    }

    static void Append(ref NPatch head, ref NPatch last, NPatch child)
    {
      if (last == null)
        head = child;
      else
        last._next = child;

      last = child;
    }
  }

  class NSetter
  {
    NSetter _next;
    Action<object, object> _setter;
    object _value;

#if DEBUG
    string _dump;
    public override string ToString()
    {
      return _dump;
    }
#endif

    public static NSetter Prepare(Type type, NDynamic props)
    {
      if (props == null)
        return null;

      var head = default(NSetter);
      var last = default(NSetter);

      for (var i = props.Head; i != null; i = i.Next)
      {
        var setter = NFactory.GetSetter(type, i.Name);
        if (setter == null) continue;

        var s = new NSetter
        {
          _setter = setter,
          _value = i.Value
        };

        if (last == null)
          head = s;
        else
          last._next = s;

        last = s;
      }

#if DEBUG
      head._dump = props.ToDebugString();
#endif

      return head;
    }

    public static void Execute(NSetter head, object target)
    {
      for (var i = head; i != null; i = i._next)
        i._setter(target, i._value);
    }
  }
}
