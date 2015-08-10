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
    public static class NThickness
    {
      public static Thickness Convert(object value)
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
          return Parse(s);

        throw new InvalidCastException();
      }

      public static Thickness Parse(string source)
      {
        if (string.IsNullOrEmpty(source))
          throw new FormatException("source");

        var parts = source.Split(new char[] { ' ', ',', ';' });

        switch (parts.Length)
        {
          case 1:
            return new Thickness(double.Parse(parts[0], XamlCulture));

          case 2:
            {
              var lr = double.Parse(parts[0], XamlCulture);
              var tb = double.Parse(parts[1], XamlCulture);
              return new Thickness(lr, tb, lr, tb);
            }

          case 4:
            return new Thickness(double.Parse(parts[0], XamlCulture), double.Parse(parts[1], XamlCulture), double.Parse(parts[2], XamlCulture), double.Parse(parts[3], XamlCulture));
        }
        throw new FormatException("Invalid number of Thickness components");
      }
    }
  }
}
