using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
#if NETFX_CORE
using Windows.UI.Xaml.Controls;
#else
using System.Windows.Controls;
#endif

namespace NReact
{
  public partial class NClass
  {
    public static NDataCtor NewProps
    {
      get { return new NDataCtor(); }
    }

    public static NElement New(Type type)
    {
      return New(type, null);
    }

    public static NElement New(Type type, NDataCtor props, params object[] content)
    {
      if (props == null)
        props = NewProps;

      if (content.Length > 0)
      {
        content = Flatten(content);

        if (content.Length > 0)
          props.Add(NFactory.Default.GetContentKey(type), content);
      }

      if (typeof(NClass).IsAssignableFrom(type))
      {
        var result = (NClass)NFactory.Default.CreateInstance(type);
        result.SetProps(props.Head);
        return result;
      }

      return new NXamlElement(type, props);
    }

    public static NElement New<T>() where T : new()
    {
      return New<T>(null);
    }

    public static NElement New<T>(NDataCtor props, params object[] content) where T: new()
    {
      if (props == null)
        props = NewProps;

      if (content.Length > 0)
      {
        content = Flatten(content);

        if (content.Length > 0)
          props.Add(NFactory.Default.GetContentKey(typeof(T)), content);
      }

      if (typeof(NClass).IsAssignableFrom(typeof(T)))
      {
#if WINDOWS_UWP
        var result = (NClass)(object)new T();
#else
        var result = (NClass)NTypeFactory<T>.Default.Ctor();      // (NClass)(object)new T();
#endif
        result.SetProps(props.Head);
        return result;
      }

      return new NXamlElement<T>(props);
    }

    public static NXamlElement TextBlock(string text)
    {
      return new NXamlElement<TextBlock>(NewProps.Add(NProps.Text, text));
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
  }
}
