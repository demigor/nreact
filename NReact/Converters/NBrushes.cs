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
    public static Brush ToBrushT(object value)
    {
      var result = value as Brush;
      if (result != null) return result;

      return new SolidColorBrush(ToColorT(value));
    }

    public static Brush ToBrushT(object value, Brush oldValue)
    {
      var patch = value as NPropPatch;
      if (patch != null)
        return (Brush)patch.Apply(oldValue);

      if (value == NDataBag.UnsetValue)
        return null;

      return ToBrushT(value);
    }
  }
}
