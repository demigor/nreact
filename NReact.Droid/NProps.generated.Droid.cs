namespace NReact
{
  public partial class NProperties
  {
    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
    NProperty _children;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
    NProperty _child;
  }

  static partial class NPropFactories
  {
    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children));

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child));
  }
}
