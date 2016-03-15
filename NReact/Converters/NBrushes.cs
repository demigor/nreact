#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
#else
using System;
using System.Windows;
using System.Windows.Media;
#endif

namespace NReact
{
  static partial class NConverters
  {
    public static object ToBrush(object value)
    {
      return ToBrushT(value);
    }

    public static Brush ToBrushT(object value)
    {
      var result = value as Brush;
      if (result != null)
        return result;

      return new SolidColorBrush(ToColorT(value));
    }
  }
}
