using System;
using System.Collections.Generic;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace NReact
{
  class NPropPatchEntry
  {
    public NProperty Key;
    public NPropPatchEntry Next;
    public Action<object, object> Setter;
    public object Value, Finalizer;

    public override string ToString()
    {
      return $" {Key.Name} = {Value}";
    }
  }

  class NPropPatch : NPatch
  {
    readonly NElement _element;
    readonly NPropPatchEntry _head;

    public NPropPatch(NElement element, NPropPatchEntry head)
    {
      _element = element;
      _head = head;
    }

    public override object Apply(object target)
    {
      var c = _element as NClass;
      c?.BeginPatching();
      try
      {
#if DEBUG
        if (target.GetType() != _element.GetXamlType())
          throw new InvalidOperationException();
#endif

        for (var i = _head; i != null; i = i.Next)
        {
          i.Setter?.Invoke(target, i.Value);
          Finalize(i.Finalizer);
        }
      }
      finally
      {
        c?.EndPatching();
      }
      return target;
    }

    public override string ToString()
    {
      return $"NPropPatch ({_element.GetXamlType().Name}):" + string.Concat(Enumerate());
    }

    IEnumerable<NPropPatchEntry> Enumerate()
    {
      for (var i = _head; i != null; i = i.Next)
        yield return i;
    }
  }
}
