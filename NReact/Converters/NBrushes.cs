#if NETFX_CORE
using Windows.UI.Xaml.Media;
#else
using System;
using System.Windows.Media;
#endif

namespace NReact
{
  static partial class NConverters
  {
    public static class NBrushes
    {
      public static Brush Convert(object value)
      {
        var result = value as Brush;
        if (result != null) return result;

        return new SolidColorBrush(NColors.Convert(value));
      }

      public static Brush Convert(object value, Brush oldValue)
      {
        var patch = value as NPropPatch;
        if (patch != null)
          return (Brush)patch.Apply(oldValue);

        return Convert(value);
      }
    }
  }
}
