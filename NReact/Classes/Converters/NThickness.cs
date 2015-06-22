using System;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact.Converters
{
  public static class NThickness
  {
    public static Type[] GetSupportedTypes()
    {
      return new[] { typeof(Thickness) };
    }

    public static bool Convert(object source, Type target, ref object result)
    {
      if (source is int)
        result = new Thickness((int)source);
      else if (source is double)
        result = new Thickness((double)source);
      else if (source is string)
        result = ParseString((string)source);
      else if (source is float)
        result = new Thickness((float)source);
      else
        return false;

      return true;
    }

    static object ParseString(string source)
    {
      var parts = source.Split(new char[] { ' ', ',', ';' });

      switch (parts.Length)
      {
        case 1: return new Thickness(double.Parse(parts[0]));
        case 2:
          {
            var lr = double.Parse(parts[0]);
            var tb = double.Parse(parts[1]);
            return new Thickness(lr, tb, lr, tb);
          }
        case 4:
          return new Thickness(double.Parse(parts[0]), double.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]));

        default:
          throw new FormatException("Invalid number of Thickness components");
      }
    }
  }
}
