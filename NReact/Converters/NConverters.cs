using System;
using System.Globalization;

namespace NReact
{
  public static partial class NConverters
  {
    internal static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

    public static object ToEnum<T>(object value) where T : struct
    {
      if (value is T)
        return value;

      var t = typeof(T);

      var s = value as string;
      if (s != null)
        return Enum.Parse(t, s, true);

      if (Enum.IsDefined(t, value))
        return Enum.ToObject(t, value);

      throw new InvalidCastException($"Cannot convert {value} to enum {t.FullName}");
    }

    public static T ToEnumT<T>(object value) where T : struct
    {
      return (T)ToEnum<T>(value);
    }

    public static object ToChar(object value)
    {
      return ToCharT(value);
    }

    public static char ToCharT(object value)
    {
      return System.Convert.ToChar(value);
    }

    public static object ToTimeSpan(object value)
    {
      return ToTimeSpanT(value);
    }

    public static TimeSpan ToTimeSpanT(object value)
    {
      if (value is TimeSpan)
        return (TimeSpan)value;

      return TimeSpan.Parse(ToStringT(value));
    }

    public static object ToDateTimeOffset(object value)
    {
      return ToDateTimeOffsetT(value);
    }

    public static DateTimeOffset ToDateTimeOffsetT(object value)
    {
      if (value is DateTimeOffset)
        return (DateTimeOffset)value;

      return DateTimeOffset.Parse(ToStringT(value));
    }

    public static object ToDateTimeOffsetN(object value)
    {
      return value == null ? null : (DateTimeOffset?)ToDateTimeOffsetT(value);
    }

    public static object ToUri(object value)
    {
      return ToUriT(value);
    }

    public static Uri ToUriT(object value)
    {
      var uri = value as Uri;
      if (uri != null) return uri;

      return new Uri(ToStringT(value));
    }

    public static object ToString(object value)
    {
      return ToStringT(value);
    }

    public static string ToStringT(object value)
    {
      return System.Convert.ToString(value);
    }

    public static object ToDouble(object value)
    {
      return ToDoubleT(value);
    }

    public static double ToDoubleT(object value)
    {
      return System.Convert.ToDouble(value, Culture);
    }

    public static object ToSingle(object value)
    {
      return ToSingleT(value);
    }

    public static float ToSingleT(object value)
    {
      return System.Convert.ToSingle(value, Culture);
    }

    public static object ToInt32(object value)
    {
      return ToInt32T(value);
    }

    public static int ToInt32T(object value)
    {
      return System.Convert.ToInt32(value, Culture);
    }

    public static object ToInt32N(object value)
    {
      return value == null ? null : ToInt32(value);
    }

    public static object ToBool(object value)
    {
      return ToBoolT(value);
    }

    public static bool ToBoolT(object value)
    {
      return System.Convert.ToBoolean(value, Culture);
    }

    public static object ToBoolN(object value)
    {
      return value == null ? null : ToBool(value);
    }
  }
}
