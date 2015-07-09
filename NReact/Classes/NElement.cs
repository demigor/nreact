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
    internal static readonly int KeyKey = NDynamic.GetKey("Key");
    internal static readonly int KeyRef = NDynamic.GetKey("Ref");
    internal static readonly int KeyChildren = NDynamic.GetKey("Children");
    internal static readonly NDynamic _emptyProps = EmptyProps();
    internal static readonly NElement[] _emptyList = new NElement[0];

    static NDynamic EmptyProps()
    {
      var result = new NDynamic();
      result.SetByKey(KeyChildren, _emptyList);
      return result.Seal();
    }

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
          if (i.Key == KeyChildren) continue;

          sb.Append(" ");
          sb.Append(i.Name);
          sb.AppendFormat("=\"{0}\"", i.Value);
        }
      }

      var children = _children;

      if (children.Length == 0)
        sb.Append(" />");

      else
      {
        sb.AppendLine(">");

        indent++;

        for (int i = 0, c = children.Length; i < c; i++)
        {
          children[i].ToString(sb, indent);
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

    public object Key { get { return _key; } }
    internal object _key;
    internal object _id = string.Empty;

    public string Ref { get { return _ref; } }
    internal string _ref;

    public dynamic Props { get { return _props; } }
    internal NDynamic _props = _emptyProps;

    /// <summary>
    /// Read-Only Children Array (Do not update)
    /// </summary>
    protected NElement[] Children { get { return _children; } }
    internal NElement[] _children = _emptyList;

    internal virtual void Unmount()
    {
      for (int i = 0; i < _children.Length; i++)
        _children[i].Unmount();
    }

    internal virtual void Setup(NDynamic props, object content)
    {
      if (content != null)
      {
        if (props == null)
          props = new NDynamic();

        props.SetByKey(KeyChildren, content); // replacing Children with content
      }

      if (props != null)
        SetPropsCore(props);
    }

    internal void SetPropsCore(NDynamic props)
    {
      if (_props == props) return;

      props = props.Unseal();

      object value;

      if (props.RemoveByKey(KeyKey, out value))
        _key = value;

      if (props.RemoveByKey(KeyRef, out value))
        _ref = string.Concat(value);

      var content = props.TryGetByKey(KeyChildren);

      _children = content == null ? _emptyList : Materialize(content);
      props.SetByKey(KeyChildren, _children);

      _props = props.Seal();
    }

    NElement[] Materialize(object content)
    {
      if (content == null)
        return _emptyList;

      var result = Converter(content).ToArray();
      if (result.Length == 0)
        return _emptyList;

      for (var i = 0; i < result.Length; i++)
      {
        var c = result[i];
        var k = c._key;

        if (k != null)
          c._id = k;
        else
          c._id = -i;
      }

      return result;
    }

    public static NElement New(Type type, NDynamic props = null, IEnumerable children = null)
    {
      if (typeof(NComponent).IsAssignableFrom(type))
      {
        var result = (NComponent)NFactory.Create(type);
        result.Setup(props, children);
        return result;
      }

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

    public static NElement TextBlock(string text)
    {
      return new NXamlElement(typeof(TextBlock), new { Text = text, TextWrapping = TextWrapping.Wrap }.AsDynamic());
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
        yield return TextBlock(s);
        yield break;
      }

      #endregion

      #region IEnumerable

      var ee = source as IEnumerable;
      if (ee != null)
      {
        foreach (var i in ee)
          foreach (var r in Converter(i))
            if (r != null)
              yield return r;

        yield break;
      }

      #endregion

      yield return TextBlock(string.Concat(source));
    }

    public static string Text(object items)
    {
      if (items == null) return null;

      var s = items as string;
      if (s != null) return s;

      return string.Concat(Converter(items).Select(ConvertToString));
    }

    static string ConvertToString(NElement arg)
    {
      var e = arg as NXamlElement;
      if (e != null && e._type == typeof(TextBlock))
        return e.Props.Text;

      return string.Empty;
    }
  }
}
