using System;

namespace NReact
{
  public class NXamlElement : NElement
  {
    internal override Type GetInnerType() { return Type; }
    public override string DisplayName { get { return Type.Name; } }

    internal readonly Type Type;

    public override object Key { get { return Props.Get<object>(NProps.Key, null); } set { throw new NotSupportedException(); } }

    public NXamlElement(Type type, NDataCtor props)
    {
      Type = type;
      Props = props.Head;
      //      Children = Props.Get(NProps.Children, _emptyList);
    }

    internal virtual NTypeFactory GetTypeFactory(NFactory factory)
    {
      return factory.GetTypeFactory(Type);
    }

    internal override NDataBag GetProps() { return Props; }
    internal readonly NDataBag Props;
    //    internal object[] Children;

    internal override void Unmount()
    {
      //var children = Children;

      //for (var i = 0; i < children.Length; i++)
      //{
      //  var o = children[i] as NElement;
      //  if (o == null) continue;
      //  o.Unmount();
      //}
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

    public NXamlElement(NDataCtor props) : base(typeof(T), props) { }
  }
}
