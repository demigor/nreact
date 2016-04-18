#if XAML
using System;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace NReact
{
  public static partial class NConverters
  {
    public static object ToThickness(object value)
    {
      return value is Thickness ? value : ToThicknessT(value);
    }

    public static Thickness ToThicknessT(object value)
    {
      if (value is Thickness)
        return (Thickness)value;

      if (value is double)
        return new Thickness((double)value);

      if (value is int)
        return new Thickness((int)value);

      if (value is float)
        return new Thickness((float)value);

      var s = value as string;
      if (s != null)
        return NThickness.Parse(s);

      throw new InvalidCastException();
    }

    public static object ToCornerRadius(object value)
    {
      return value is CornerRadius ? value : ToCornerRadiusT(value);
    }

    public static CornerRadius ToCornerRadiusT(object value)
    {
      if (value is CornerRadius)
        return (CornerRadius)value;

      if (value is double)
        return new CornerRadius((double)value);

      if (value is int)
        return new CornerRadius((int)value);

      if (value is float)
        return new CornerRadius((float)value);

      var s = value as string;
      if (s != null)
        return NCornerRadius.Parse(s);

      throw new InvalidCastException();
    }


    public static class NThickness
    {
      public static Thickness Parse(string source)
      {
        if (string.IsNullOrEmpty(source))
          throw new FormatException("source");

        var parts = source.Split(new char[] { ' ', ',', ';' });

        switch (parts.Length)
        {
          case 1:
            return new Thickness(double.Parse(parts[0], Culture));

          case 2:
            {
              var lr = double.Parse(parts[0], Culture);
              var tb = double.Parse(parts[1], Culture);
              return new Thickness(lr, tb, lr, tb);
            }

          case 4:
            return new Thickness(double.Parse(parts[0], Culture), double.Parse(parts[1], Culture), double.Parse(parts[2], Culture), double.Parse(parts[3], Culture));
        }
        throw new FormatException("Invalid number of Thickness components");
      }
    }

    public static class NCornerRadius
    {
      public static CornerRadius Parse(string source)
      {
        if (string.IsNullOrEmpty(source))
          throw new FormatException("source");

        var parts = source.Split(new char[] { ' ', ',', ';' });

        switch (parts.Length)
        {
          case 1:
            return new CornerRadius(double.Parse(parts[0], Culture));

          case 2:
            {
              var lr = double.Parse(parts[0], Culture);
              var tb = double.Parse(parts[1], Culture);
              return new CornerRadius(lr, tb, lr, tb);
            }

          case 4:
            return new CornerRadius(double.Parse(parts[0], Culture), double.Parse(parts[1], Culture), double.Parse(parts[2], Culture), double.Parse(parts[3], Culture));
        }
        throw new FormatException("Invalid number of CornerRadius components");
      }
    }
  }
}
#endif