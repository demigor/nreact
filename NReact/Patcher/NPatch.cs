using System;

namespace NReact
{
  abstract partial class NPatch
  {
    public abstract object Apply(object target);

    public static void Finalize(object value)
    {
      if (value == null) return;

      var e = value as NElement;
      if (e != null)
        e.Free();
      else
      {
        var a = value as NElement[];

        if (a != null)
          for (var i = 0; i < a.Length; i++)
            a[i].Free();
      }
    }

    public static readonly NPatch AssignNewValue = new NConstPatch();

    class NConstPatch : NPatch
    {
      public override object Apply(object target)
      {
        throw new NotSupportedException();
      }
    }

    internal static bool ElementEquals(NElement a, NElement b)
    {
      return a.GetXamlType() == b.GetXamlType() && Equals(a._key, b._key);
    }
  }
}
