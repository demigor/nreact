using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
#if NETFX_CORE
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
#else
using System.Windows.Controls;
using System.Windows.Documents;
#endif

namespace NReact
{
  public partial class NClass
  {
    public NDataCtor CloneProps(params int[] props)
    {
      return CloneProps(true, props);
    }

    public NDataCtor ClonePropsExcluding(params int[] props)
    {
      return CloneProps(false, props);
    }

    public NDataCtor CloneProps()
    {
      var result = NewProps;

      for (var e = _props.New; e != null; e = e.Next)
        result.Add(e.Id, e.Value);

      return result;
    }

    NDataCtor CloneProps(bool including, params int[] props)
    {
      if (props != null && props.Length > 0)
      {
        var result = NewProps;

        for (var e = _props.New; e != null; e = e.Next)
          if ((Array.IndexOf(props, e.Id) >= 0) == including)
            result.Add(e.Id, e.Value);

        return result;
      }

      return CloneProps();
    }

    protected NDataCtor CloneAttachedProps()
    {
      return CloneProps(true, NProps.Margin, NProps.Width, NProps.Height, NProps.MaxWidth, NProps.MaxHeight, NProps.GridColumn, NProps.GridColumnSpan, NProps.GridRow, NProps.GridRowSpan, NProps.CanvasLeft, NProps.CanvasTop, NProps.CanvasZIndex, NProps.ToolTipServicePlacement, NProps.ToolTipServiceToolTip);
    }

    public static NDataCtor NewProps
    {
      get { return new NDataCtor(); }
    }

    public static NElement New(Type type)
    {
      return New(type, null);
    }

    public static NElement New(Type type, NDataCtor props)
    {
      var head = props != null ? props.Head : null;

      if (typeof(NClass).IsAssignableFrom(type))
      {
        var result = (NClass)NFactory.Default.CreateInstance(type);
        result.SetProps(head);
        return result;
      }

      return new NXamlElement(type, head);
    }

    public static NElement New(Type type, NDataCtor props, params object[] content)
    {
      return New(type, FlattenContent(type, props, content));
    }

    public static NElement New<T>(NDataCtor props = null) where T : new()
    {
      var head = props != null ? props.Head : null;

      if (typeof(NClass).IsAssignableFrom(typeof(T)))
      {
#if WINDOWS_UWP
        var result = (NClass)(object)new T();
#else
        var result = (NClass)NTypeFactory<T>.Default.Ctor();
#endif
        result.SetProps(head);
        return result;
      }

      return new NXamlElement<T>(head);
    }

    public static NElement New<T>(NDataCtor props, params object[] content) where T : new()
    {
      return New<T>(FlattenContent(typeof(T), props, content));
    }

    protected static NDataCtor FlattenContent(Type type, NDataCtor props, object[] content)
    {
      if (content.Length > 0)
      {
        content = Flatten(content);

        if (content.Length > 0)
          return (props ?? NewProps).Add(NFactory.Default.GetContentKey(type), content);
      }

      return props;
    }

    static NElement[] Flatten(object[] content)
    {
      var result = Converter(content).ToArray();

      for (var i = 0; i < result.Length; i++)
      {
        var c = result[i];
        var k = c.Key;

        if (k != null)
          c.Id = k;
        else
          c.Id = -i;
      }

      return result;
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

    public static NXamlElement TextBlock(string text)
    {
      return new NXamlElement<TextBlock>(new NDataBag(NProps.Text, text));
    }

    public static NXamlElement Run(string text)
    {
      return new NXamlElement<Run>(new NDataBag(NProps.Text, text));
    }

    public static NXamlElement LineBreak()
    {
      return new NXamlElement<LineBreak>(null);
    }
  }
}
