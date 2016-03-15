using System;

namespace NReact
{
  public class NXaml<T> : NElement where T : new()
  {
    protected override object CreateXaml()
    {
      return Ctor<T>.New();
    }

    public override Type GetXamlType()
    {
      return typeof(T);
    }
  }

  public class NXaml : NElement
  {
    public readonly Type Type;

    public NXaml(Type type)
    {
      Type = type;
    }

    protected override object CreateXaml()
    {
      return Activator.CreateInstance(Type);
    }

    public override Type GetXamlType()
    {
      return Type;
    }
  }
}
