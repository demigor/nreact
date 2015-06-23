using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
  public abstract class NElement
  {
    public override string ToString()
    {
      var sb = new StringBuilder();
      ToString(sb);
      return sb.ToString();
    }

    void ToString(StringBuilder sb, int indent = 0)
    {
      sb.Append(' ', indent * 2);
      sb.Append("<");
      sb.Append(DisplayName);

      if (!_props.IsEmpty)
      {
        foreach (var i in _props.GetContent())
        {
          sb.Append(" ");
          sb.Append(i.Name);
          sb.AppendFormat("=\"{0}\"", i.Value);
        }
      }

      if (_children.Length == 0)
        sb.Append(" />");

      else
      {
        sb.AppendLine(">");

        indent++;

        for (int i = 0, c = _children.Length; i < c; i++)
        {
          _children[i].ToString(sb, indent);
          sb.AppendLine();
        }

        indent--;

        sb.Append(' ', indent * 2);
        sb.Append("</");
        sb.Append(DisplayName);
        sb.Append(">");
      }
    }

    public abstract string DisplayName { get; }
    internal abstract Type InnerType { get; }

    internal static readonly NElement[] _empty = new NElement[0];

    internal NElement[] _children = _empty;
    internal NDynamic _props = NDynamic.Empty;

    public object Key { get { return _key; } }
    internal object _key;

    public string Ref { get { return _ref; } }
    internal string _ref;

    public dynamic Refs { get { return _refs; } }
    internal NDynamic _refs;

    public dynamic Props { get { return _props; } }
    public NElement[] Children { get { return _children; } }

    internal virtual void Unmount()
    {
      if (_children != null)
        for (int i = 0, c = _children.Length; i < c; i++)
          _children[i].Unmount();
    }

    static readonly int _keyKey = NDynamic.GetKey("Key");
    static readonly int _keyRef = NDynamic.GetKey("Ref");

    internal void Setup(NDynamic props, IEnumerable children)
    {
      if (props != null)
      {
        object value;

        if (props.RemoveByKey(_keyKey, out value))
          _key = value;

        if (props.RemoveByKey(_keyRef, out value))
          _ref = string.Concat(value);

        _props = props.Seal();
      }

      if (children != null)
        _children = children.OfType<object>().SelectMany(Converter).ToArray();
    }

    public static NElement New(Type type, NDynamic props = null, IEnumerable children = null)
    {
      if (typeof(NComponent).IsAssignableFrom(type))
      {
        var result = (NComponent)NFactory.Create(type);
        result.Setup(props, children);
        return result;
      }
#if DEBUG
      if (!typeof(UIElement).IsAssignableFrom(type))
        throw new InvalidOperationException("UIElement or NComponent based type expected");
#endif
      return new NXamlElement(type, props, children);
    }

    public static NElement New(Type type, NDynamic props, params object[] children)
    {
      return New(type, props, (IEnumerable)children);
    }

    public static NElement New<T>(Type type, T props, IEnumerable children = null) where T : class
    {
      return New(type, props.AsDynamic(), children);
    }

    public static NElement New<T>(Type type, T props, params object[] children) where T : class
    {
      return New(type, props.AsDynamic(), children);
    }

    public static NElement Text(string text)
    {
      return new NXamlElement(typeof(TextBlock), new { Text = text }.AsDynamic());
    }

    static IEnumerable<NElement> Converter(object source)
    {
      if (source == null)
        yield break;

      #region NElement

      var result = source as NElement;
      if (result != null)
      {
        yield return result;
        yield break;
      }

      #endregion

      #region String

      var s = source as string;
      if (s != null)
      {
        yield return Text(s);
        yield break;
      }

      #endregion

      #region IEnumerable

      var ee = source as IEnumerable;
      if (ee != null)
      {
        foreach (var i in ee.OfType<NElement>())
          yield return i;

        yield break;
      }

      #endregion

      yield return Text(string.Concat(source));
    }
  }
}
