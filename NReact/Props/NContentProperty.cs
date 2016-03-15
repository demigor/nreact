using System;

namespace NReact
{
  /// <summary>
  /// Provides mapping between types and their content properties
  /// </summary>
  public class NContentProperty
  {
    public NContentProperty Content(Type type, NProperty content)
    {
      _items[type] = content;
      return this;
    }

    public NContentProperty Content<T>(NProperty content)
    {
      return Content(typeof(T), content);
    }

    public NProperty this[Type type] { get { return _items[type]; } }
    NTypedBag<NProperty> _items;
  }
}
