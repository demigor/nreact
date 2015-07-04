using System;
using System.Globalization;

#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact.Converters
{
  public static class NGridLength
  {
    public static Type[] GetSupportedTypes()
    {
      return new[] { typeof(GridLength) };
    }

    public static bool Convert(object source, Type target, ref object result)
    {
      var s = source as string;
      if (s == null)
        return false;

      switch (s.ToLower())
      {
        case "*": result = new GridLength(1, GridUnitType.Star); return true;  
        case "auto": result = GridLength.Auto; return true;  
        default:
          {
            var unit = GridUnitType.Pixel;

            if (s.StartsWith("*"))
            {
              s = s.Substring(1);
              unit = GridUnitType.Star;
            }
            else if (s.EndsWith("*"))
            {
              s = s.Substring(0, s.Length - 1);
              unit = GridUnitType.Star;
            }

            double x;

            if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out x))
            {
              result = new GridLength(x, unit);
              return true;
            }
          }
          break;
      }

      return false;
    }
  }
}
