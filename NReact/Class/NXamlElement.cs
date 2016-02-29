using System;

namespace NReact
{
  public class NXamlElement : NElement
  {
    internal override Type GetInnerType() { return Type; }
    public override string DisplayName { get { return Type.Name; } }

    internal readonly Type Type;

    public override object Key { get { return Props.Get<object>(NProps.Key, null); } set { throw new NotSupportedException(); } }

    public NXamlElement(Type type, NDataBag props)
    {
      Type = type;
      Props = props;
    }

    internal virtual NTypeFactory GetTypeFactory(NFactory factory)
    {
      return factory.GetTypeFactory(Type);
    }

    internal override NDataBag GetProps()
    {
      return Props;
    }
    internal override void AddProps(NDataCtor props)
    {
      for (var i = props.Head; i != null; i = i.Next)
      {
        Props = Props.Set(i.Id, i.Value);
      }
    }
    internal NDataBag Props;

    internal override void Unmount()
    {
    }

    public override NElement RenderInitial()
    {
      return this;
    }
  }

  public class NXamlElement<T> : NXamlElement where T : new()
  {
    internal override NTypeFactory GetTypeFactory(NFactory factory)
    {
      return NTypeFactory<T>.Default;
    }

    public NXamlElement(NDataBag props) : base(typeof(T), props) { }
  }
}
