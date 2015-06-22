using System;
using System.Collections.Generic;
using System.Globalization;
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
      Register(NColors.Convert, NColors.GetSupportedTypes());
      Register(NEnums.Convert, typeof(object));
      Register(NResources.Convert, NResources.GetSupportedTypes());
      Register(NThickness.Convert, NThickness.GetSupportedTypes());

      Register(ConvertToBoolean, typeof(bool));
      Register(ConvertToByte, typeof(byte));
      Register(ConvertToChar, typeof(char));
      Register(ConvertToDateTime, typeof(DateTime));
      Register(ConvertToTimeSpan, typeof(TimeSpan));
      Register(ConvertToDecimal, typeof(decimal));
      Register(ConvertToDouble, typeof(double));
      Register(ConvertToInt16, typeof(short));
      Register(ConvertToInt32, typeof(int));
      Register(ConvertToInt64, typeof(long));
      Register(ConvertToSByte, typeof(sbyte));
      Register(ConvertToSingle, typeof(float));
      Register(ConvertToString, typeof(string));
      Register(ConvertToUInt16, typeof(ushort));
      Register(ConvertToUInt32, typeof(uint));
      Register(ConvertToUInt64, typeof(ulong));
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

    public static bool TryConvert(object value, Type target, ref object result)
    {
      if (value != null)
      {
        var sourceType = value.GetType();
        if (target == sourceType)
        {
          result = value;
          return true;
        }

        Entry head;

        lock (_converters)
          _converters.TryGetValue(target, out head);

        for (var i = head; i != null; i = i.Next)
          if (i.Converter(value, target, ref result))
            return true;
      }
      else
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

      for (var i = _default; i != null; i = i.Next)
        if (i.Converter(value, target, ref result))
          return true;

      return false;
    }

    static bool ConvertToBoolean(object value, Type target, ref object result)
    {
      result = System.Convert.ToBoolean(value, CultureInfo.InvariantCulture);
      return true;
    }

    static bool ConvertToByte(object value, Type target, ref object result)
    {
      result = System.Convert.ToByte(value, CultureInfo.InvariantCulture);
      return true;
    }

    static bool ConvertToChar(object value, Type target, ref object result)
    {
      result = System.Convert.ToChar(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToDateTime(object value, Type target, ref object result)
    {
      result = System.Convert.ToDateTime(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToTimeSpan(object value, Type target, ref object result)
    {
      var s = value as string;
      if (s != null)
      {
        result = TimeSpan.Parse(s, CultureInfo.InvariantCulture);
        return true;
      }
      return false;
    }

    static bool ConvertToDecimal(object value, Type target, ref object result)
    {
      result = System.Convert.ToDecimal(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToDouble(object value, Type target, ref object result)
    {
      result = System.Convert.ToDouble(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToInt16(object value, Type target, ref object result)
    {
      result = System.Convert.ToInt16(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToInt32(object value, Type target, ref object result)
    {
      result = System.Convert.ToInt32(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToInt64(object value, Type target, ref object result)
    {
      result = System.Convert.ToInt64(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToSByte(object value, Type target, ref object result)
    {
      result = System.Convert.ToSByte(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToSingle(object value, Type target, ref object result)
    {
      result = System.Convert.ToSingle(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToString(object value, Type target, ref object result)
    {
      result = System.Convert.ToString(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToUInt16(object value, Type target, ref object result)
    {
      result = System.Convert.ToUInt16(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToUInt32(object value, Type target, ref object result)
    {
      result = System.Convert.ToUInt32(value, CultureInfo.InvariantCulture);
      return true;
    }
    static bool ConvertToUInt64(object value, Type target, ref object result)
    {
      result = System.Convert.ToUInt64(value, CultureInfo.InvariantCulture);
      return true;
    }

    public static T Convert<T>(object value)
    {
      var result = value;

      if (TryConvert(value, typeof(T), ref result))
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

  public delegate bool NConvert(object obj, Type target, ref object result);
}
