using System;
using System.Globalization;
using System.Xml;
#if NETFX_CORE
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;
using FStyles = Windows.UI.Text.FontStyle;
using FStretches = Windows.UI.Text.FontStretch;
#else
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using FStyles = System.Windows.FontStyles;
using FStretches = System.Windows.FontStretches;
#endif

namespace NReact
{
  public static partial class NConverters
  {
    internal static readonly CultureInfo XamlCulture = CultureInfo.InvariantCulture;

    public static T ToEnum<T>(object value) where T : struct
    {
      if (value is T)
        return (T)value;

      var t = typeof(T);

      var s = value as string;
      if (s != null)
        return (T)Enum.Parse(t, s, true);

      if (Enum.IsDefined(t, value))
        return (T)Enum.ToObject(t, value);

      throw new InvalidCastException(string.Format("Cannot convert {0} to enum {1}", value, t.FullName));
    }

    public static string ToString(object value)
    {
      return System.Convert.ToString(value);
    }

    public static double ToDouble(object value)
    {
      return System.Convert.ToDouble(value, XamlCulture);
    }

    public static int ToInt32(object value)
    {
      return System.Convert.ToInt32(value, XamlCulture);
    }

    public static bool ToBool(object value)
    {
      return System.Convert.ToBoolean(value, XamlCulture);
    }

    public static bool? ToBoolN(object value)
    {
      if (value == null)
        return null;

      return System.Convert.ToBoolean(value, XamlCulture);
    }

    public static Point ToPoint(object value)
    {
      if (value is Point)
        return (Point)value;

      var s = value as string;
      if (s != null)
      {
        var pc = s.Split(' ', ',', ';');
        if (pc.Length == 2)
          return new Point(XmlConvert.ToDouble(pc[0]), XmlConvert.ToDouble(pc[1]));
      }

      throw new InvalidCastException();
    }

    public static Size ToSize(object value)
    {
      if (value is Size)
        return (Size)value;

      if (value is int)
        return new Size((int)value, (int)value);

      if (value is double)
        return new Size((double)value, (double)value);

      var s = value as string;
      if (s != null)
      {
        var pc = s.Split(' ', ',', ';');
        if (pc.Length == 2)
          return new Size(XmlConvert.ToDouble(pc[0]), XmlConvert.ToDouble(pc[1]));
      }

      throw new InvalidCastException();
    }

    public static object GetResource(object key)
    {
      return Application.Current.Resources[key];
    }

    public static Style ToStyle(object value)
    {
      if (value is Style)
        return (Style)value;

      if (value == null)
        return null;

      return GetResource(value) as Style;
    }

    public static ControlTemplate ToControlTemplate(object value)
    {
      if (value is Style)
        return (ControlTemplate)value;

      if (value == null)
        return null;

      return GetResource(value) as ControlTemplate;
    }

    public static DataTemplate ToDataTemplate(object value)
    {
      if (value is Style)
        return (DataTemplate)value;

      if (value == null)
        return null;

      return GetResource(value) as DataTemplate;
    }

#if !NETFX_CORE
    public static Cursor ToCursor(object value)
    {
      if (value is Cursor)
        return (Cursor)value;

#if !SILVERLIGHT
      if (value is Stream)
        return new Cursor((Stream)value);
#endif

      var s = value as string;
      if (s != null)
        switch (s.ToLower())
        {
          case "arrow": return Cursors.Arrow;
          case "hand": return Cursors.Hand;
          case "ibeam": return Cursors.IBeam;
          case "none": return Cursors.None;
          case "sizenesw": return Cursors.SizeNESW;
          case "sizens": return Cursors.SizeNS;
          case "sizenwse": return Cursors.SizeNWSE;
          case "sizewe": return Cursors.SizeWE;
          case "wait": return Cursors.Wait;
#if SILVERLIGHT
          case "eraser": return Cursors.Eraser;
          case "stylus": return Cursors.Stylus;
#else
          case "pen": return Cursors.Pen;
          case "no": return Cursors.No;
          case "help": return Cursors.Help;
          case "appstarting": return Cursors.AppStarting;
          case "arrowcd": return Cursors.ArrowCD;
          case "cross": return Cursors.Cross;
          case "scrollall": return Cursors.ScrollAll;
          case "scrolle": return Cursors.ScrollE;
          case "scrolln": return Cursors.ScrollN;
          case "scrollne": return Cursors.ScrollNE;
          case "scrollns": return Cursors.ScrollNS;
          case "scrollnw": return Cursors.ScrollNW;
          case "scrolls": return Cursors.ScrollS;
          case "scrollse": return Cursors.ScrollSE;
          case "scrollsw": return Cursors.ScrollSW;
          case "scrollw": return Cursors.ScrollW;
          case "scrollwe": return Cursors.ScrollWE;
          case "sizeall": return Cursors.SizeAll;
          case "uparrow": return Cursors.UpArrow;
          default: return new Cursor(s);
#endif
        }

      throw new InvalidCastException();
    }
#endif

    public static FontFamily ToFontFamily(object value)
    {
      var ff = value as FontFamily;
      if (ff != null) return ff;

      var s = value as string;
      if (s != null) return new FontFamily(s);

      throw new InvalidCastException();
    }

    public static FontWeight ToFontWeight(object value)
    {
      if (value is FontWeight)
        return (FontWeight)value;

#if !(SILVERLIGHT || NETFX_CORE)
      if (value is int)
        return FontWeight.FromOpenTypeWeight((int)value);
#endif

      var s = value as string;
      if (s != null)
        switch (s.ToLower())
        {
          case "black": return FontWeights.Black;
          case "bold": return FontWeights.Bold;
          case "extraBold": return FontWeights.ExtraBold;
          case "extralight": return FontWeights.ExtraLight;
          case "light": return FontWeights.Light;
          case "medium": return FontWeights.Medium;
          case "normal": return FontWeights.Normal;
          case "semibold": return FontWeights.SemiBold;
#if SILVERLIGHT || NETFX_CORE
          case "extrabold": return FontWeights.SemiLight;
#endif
          case "thin": return FontWeights.Thin;
        }

      throw new InvalidCastException();
    }

    public static FontStretch ToFontStretch(object value)
    {
      if (value is FontStretch)
        return (FontStretch)value;

#if !(SILVERLIGHT || NETFX_CORE)
      if (value is int)
        return FontStretch.FromOpenTypeStretch((int)value);
#endif

      var s = value as string;
      if (s != null)
        switch (s.ToLower())
        {
          case "normal": return FStretches.Normal;

#if !(SILVERLIGHT || NETFX_CORE)
          case "medium": return FStretches.Medium;
#endif
          case "expanded": return FStretches.Expanded;
          case "condensed": return FStretches.Condensed;
          case "semiexpanded": return FStretches.SemiExpanded;
          case "semicondensed": return FStretches.SemiCondensed;
          case "extraexpanded": return FStretches.ExtraExpanded;
          case "ultraexpanded": return FStretches.UltraExpanded;
          case "ultracondensed": return FStretches.UltraCondensed;
          case "extracondensed": return FStretches.ExtraCondensed;
        }

      throw new InvalidCastException();
    }

    public static FontStyle ToFontStyle(object value)
    {
      if (value is FontStyle)
        return (FontStyle)value;

      var s = value as string;
      if (s != null)
        switch (s.ToLower())
        {
          case "italic": return FStyles.Italic;
          case "normal": return FStyles.Normal;
#if !SILVERLIGHT
          case "oblique": return FStyles.Oblique;
#endif
        }

      throw new InvalidCastException();
    }

    public static GridLength ToGridLength(object value)
    {
      if (value is GridLength)
        return (GridLength)value;

      if (value is int)
        return new GridLength((int)value);

      if (value is double)
        return new GridLength((double)value);

      var s = value as string;
      if (s != null)
        switch (s.ToLower())
        {
          case "*": return new GridLength(1, GridUnitType.Star);
          case "auto": return GridLength.Auto;
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
                return new GridLength(x, unit);
            }
            break;
        }

      throw new InvalidCastException();
    }

    public static double ToLength(object value)
    {
      if (value == null)
        return double.NaN;

      if (value is double)
        return (double)value;

      var s = value as string;
      if (string.Equals(s, "Auto", StringComparison.OrdinalIgnoreCase))
        return double.NaN;

      return ToDouble(value);
    }

#if !NETFX_CORE
    public static XmlLanguage ToLanguage(object value)
    {
      if (value is XmlLanguage)
        return (XmlLanguage)value;

      var s = value as string;
      if (s != null) return XmlLanguage.GetLanguage(s);

      throw new InvalidCastException();
    }
#endif
  }
}
