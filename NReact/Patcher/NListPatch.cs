using System;
using System.Collections;
using System.Collections.Generic;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact
{
  enum NListPatchOp { None, Insert, Remove, Move, Patch };

  class NListPatchEntry
  {
    public NListPatchEntry Next;
    public NListPatchOp Op;
    public int iInsert, iRemove, iFinal;
    public NElement Value, Finalizer;
    public NPatch Patch;

    public override string ToString()
    {
      switch (Op)
      {
        case NListPatchOp.Insert: return $" [+|{iInsert}] {Value}";
        case NListPatchOp.Remove: return $" [-|{iRemove}] ({Finalizer})";
        case NListPatchOp.Patch: return $" [={iFinal}] [{Patch}] {Value} ({Finalizer})";
        case NListPatchOp.Move: return $" [{iRemove}->{iInsert}] [{Patch}] {Value} ({Finalizer})";
      }
      return null;
    }
  }

  class NListPatch : NPatch
  {
    NListPatchEntry _head;

    internal NListPatch(NListPatchEntry head)
    {
      _head = head;
    }

    public void Apply(IList target)
    {
      new NIListPatcher(target).Run(_head);
    }

    public void Apply<T>(IList<T> target)
    {
      new NIListPatcher<T>(target).Run(_head);
    }

    public void Apply(UIElementCollection target)
    {
      new NUIElementCollectionPatcher(target).Run(_head);
    }

    public override object Apply(object target)
    {
      var uiCollection = target as UIElementCollection;

      if (uiCollection != null)
        Apply(uiCollection);
      else
        Apply((IList)target);

      return target;
    }

    public override string ToString()
    {
      return "NListPatch: " + string.Concat(Enumerate());
    }

    IEnumerable<NListPatchEntry> Enumerate()
    {
      for (var i = _head; i != null; i = i.Next)
        yield return i;
    }
  }

  abstract class NListPatcher
  {
    public void Run(NListPatchEntry head)
    {
      for (var i = head; i != null; i = i.Next)
      {
        switch (i.Op)
        {
          case NListPatchOp.Insert: DoInsert(i); break;
          case NListPatchOp.Remove: DoRemove(i); break;
          case NListPatchOp.Patch: DoPatch(i); break;
          case NListPatchOp.Move: DoMove(i); break;
        }

        NPatch.Finalize(i.Finalizer);
      }
    }

    protected abstract void DoInsert(NListPatchEntry i);
    protected abstract void DoRemove(NListPatchEntry i);
    protected abstract void DoPatch(NListPatchEntry i);
    protected abstract void DoMove(NListPatchEntry i);
  }

  class NIListPatcher : NListPatcher
  {
    readonly IList _target;

    public NIListPatcher(IList target)
    {
      _target = target;
    }

    protected override void DoInsert(NListPatchEntry i)
    {
      _target.Insert(i.iInsert, i.Value.Create());
    }

    protected override void DoRemove(NListPatchEntry i)
    {
      _target.RemoveAt(i.iRemove);
    }

    protected override void DoMove(NListPatchEntry i)
    {
      var idx = i.iRemove;
      var x = _target[idx];
      _target.RemoveAt(idx);

      var p = i.Patch;
      if (p != null) x = p.Apply(x);

      _target.Insert(i.iInsert, x);
    }

    protected override void DoPatch(NListPatchEntry i)
    {
      var idx = i.iFinal;
      var x = _target[idx];
      var y = i.Patch.Apply(x);

      if (!ReferenceEquals(x, y))
        _target[idx] = y;
    }
  }

  class NIListPatcher<T> : NListPatcher
  {
    readonly IList<T> _target;

    public NIListPatcher(IList<T> target)
    {
      _target = target;
    }

    protected override void DoInsert(NListPatchEntry i)
    {
      _target.Insert(i.iInsert, (T)i.Value.Create());
    }

    protected override void DoRemove(NListPatchEntry i)
    {
      _target.RemoveAt(i.iRemove);
    }

    protected override void DoMove(NListPatchEntry i)
    {
      var idx = i.iRemove;
      var x = _target[idx];
      _target.RemoveAt(idx);

      var p = i.Patch;
      if (p != null) x = (T)p.Apply(x);

      _target.Insert(i.iInsert, x);
    }

    protected override void DoPatch(NListPatchEntry i)
    {
      var idx = i.iFinal;
      var x = _target[idx];
      var y = (T)i.Patch.Apply(x);

      if (!ReferenceEquals(x, y))
        _target[idx] = y;
    }
  }

  class NUIElementCollectionPatcher : NListPatcher
  {
    readonly UIElementCollection _target;
    public NUIElementCollectionPatcher(UIElementCollection target)
    {
      _target = target;
    }

    protected override void DoInsert(NListPatchEntry i)
    {
      _target.Insert(i.iInsert, (UIElement)i.Value.Create());
    }

    protected override void DoRemove(NListPatchEntry i)
    {
      _target.RemoveAt(i.iRemove);
    }

    protected override void DoMove(NListPatchEntry i)
    {
      var idx = i.iRemove;
      var x = _target[idx];
      _target.RemoveAt(idx);

      var p = i.Patch;
      if (p != null) x = (UIElement)p.Apply(x);

      _target.Insert(i.iInsert, x);
    }

    protected override void DoPatch(NListPatchEntry i)
    {
      var idx = i.iFinal;
      var x = _target[idx];
      var y = (UIElement)i.Patch.Apply(x);

      if (!ReferenceEquals(x, y))
      {
#if WPF
        _target.RemoveAt(idx);
        _target.Insert(idx, y);
#else
        _target[idx] = y;
#endif
      }
    }
  }
}
