using System;
using System.Collections.Generic;
#if NETFX_CORE
using System.Reflection;
using Windows.UI;
using Windows.UI.Xaml.Media;
#else
using System.Windows.Media;
#endif

namespace NReact.Converters
{
  public static class NConverters
  {
    static NConverters()
    {
      Register(NColors.Convert, typeof(Brush), typeof(Color));
      Register(NEnums.Convert, typeof(object));
      Register(NResources.Convert, typeof(object));
    }

    static Entry _default;
    static Dictionary<Type, Entry> _converters = new Dictionary<Type, Entry>();
    class Entry
    {
      public Entry Next;
      public NConvert Converter;
    }

    public static void Register(NConvert converter, params Type[] targets)
    {
      lock (_converters)
        foreach (var i in targets)
        {
          Entry head;

          if (i == typeof(object))
          {
            _default = new Entry
            {
              Next = _default,
              Converter = converter
            };
          }
          else
          {
            _converters.TryGetValue(i, out head);
            _converters[i] = new Entry
            {
              Next = head,
              Converter = converter
            };
          }
        }
    }

    public static bool TryConvert(object value, Type target, out object result)
    {
      if (value == null)
      {
#if NETFX_CORE
        if (!target.GetTypeInfo().IsValueType)
#else
        if (!target.IsValueType)
#endif
        {
          result = null;
          return true;
        }
      }
      else
      {
        var sourceType = value.GetType();
        if (target == sourceType)
        {
          result = value;
          return true;
        }
      }

      Entry head;

      lock (_converters)
        _converters.TryGetValue(target, out head);

      result = value;

      for (var i = head; i != null; i = i.Next)
        if (i.Converter(value, target, out result))
          return true;

      for (var i = _default; i != null; i = i.Next)
        if (i.Converter(value, target, out result))
          return true;

      if (target == typeof(string))
      {
        result = System.Convert.ToString(value);
        return true;
      }

      return false;
    }

    public static T Convert<T>(object value)
    {
      object result;

      if (TryConvert(value, typeof(T), out result))
        return (T)result;

      try
      {
        return (T)value;
      }
      catch
      {
        return default(T);
      }
    }
  }

  public delegate bool NConvert(object obj, Type target, out object result);
}
