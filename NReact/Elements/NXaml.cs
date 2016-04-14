using System;

namespace NReact
{
  /// <summary>
  /// Generic NReact Xaml element
  /// </summary>
  /// <typeparam name="T">Xaml type to represent</typeparam>
  public class NXaml<T> : NElement where T : new()
  {
    public NXaml() { }

    public NXaml(object key) { _key = key; }

    internal override object CreateXaml()
    {
      return Ctor<T>.New();
    }

    public override Type GetXamlType()
    {
      return typeof(T);
    }
  }

  /// <summary>
  /// Parameterizable NReact Xaml element
  /// </summary>
  public class NXaml : NElement
  {
    /// <summary>
    /// Indicates type of the Xaml element to represent
    /// </summary>
    public readonly Type Type;

    /// <summary>
    /// Initializes new NXaml instance
    /// </summary>
    /// <param name="type">Specifies type of the Xaml element to represent</param>
    public NXaml(Type type)
    {
      Type = type;
    }

    public NXaml(Type type, object key) : this(type)
    {
      _key = key;
    }

    internal override object CreateXaml()
    {
      return Activator.CreateInstance(Type);
    }

    public override Type GetXamlType()
    {
      return Type;
    }
  }
}
