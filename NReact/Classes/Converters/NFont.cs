using System;
#if NETFX_CORE
using Windows.UI.Xaml.Media;
using Windows.UI.Text;
using FStyles = Windows.UI.Text.FontStyle;
#else
using System.Windows;
using System.Windows.Media;
using FStyles = System.Windows.FontStyles;
#endif

namespace NReact.Converters
{
  static class NFont
  {

    public static bool Convert(object obj, Type target, ref object result)
    {
      var s = obj as string;
      if (s == null) return false;

      if (target == typeof(FontFamily))
      {
        result = new FontFamily(s);
        return true;
      }

      if (target == typeof(FontWeight))
      {
        switch (s.ToLower())
        {
          case "black": result = FontWeights.Black; break;
          case "bold": result = FontWeights.Bold; break;
          case "extraBold": result = FontWeights.ExtraBold; break;
          case "extralight": result = FontWeights.ExtraLight; break;
          case "light": result = FontWeights.Light; break;
          case "medium": result = FontWeights.Medium; break;
          case "normal": result = FontWeights.Normal; break;
          case "semibold": result = FontWeights.SemiBold; break;
#if SILVERLIGHT || NETFX_CORE
          case "extrabold": result = FontWeights.SemiLight; break;
#endif
          case "thin": result = FontWeights.Thin; break;
          default: return false;
        }
        return true;
      }

      if (target == typeof(FontStyle))
      {
        switch (s.ToLower())
        {
          case "italic": result = FStyles.Italic; break;
          case "normal": result = FStyles.Normal; break;
#if NETFX_CORE
          case "oblique": result = FStyles.Oblique; break;
#endif
          default: return false;
        }
        return true;
      }


      return false;
    }

    public static Type[] GetSupportedTypes()
    {
      return new[] { typeof(FontWeight), typeof(FontFamily), typeof(FontStyle) };
    }
  }
}
