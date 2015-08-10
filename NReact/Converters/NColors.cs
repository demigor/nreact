using System;
#if NETFX_CORE
using Windows.UI;
#else
using System.Windows.Media;
#endif

namespace NReact
{
  public static partial class NConverters
  {
    public static class NColors
    {
      enum KnownColor : uint
      {
        AliceBlue = 4293982463u,
        AntiqueWhite = 4294634455u,
        Aqua = 4278255615u,
        Aquamarine = 4286578644u,
        Azure = 4293984255u,
        Beige = 4294309340u,
        Bisque = 4294960324u,
        Black = 4278190080u,
        BlanchedAlmond = 4294962125u,
        Blue = 4278190335u,
        BlueViolet = 4287245282u,
        Brown = 4289014314u,
        BurlyWood = 4292786311u,
        CadetBlue = 4284456608u,
        Chartreuse = 4286578432u,
        Chocolate = 4291979550u,
        Coral = 4294934352u,
        CornflowerBlue = 4284782061u,
        Cornsilk = 4294965468u,
        Crimson = 4292613180u,
        Cyan = 4278255615u,
        DarkBlue = 4278190219u,
        DarkCyan = 4278225803u,
        DarkGoldenrod = 4290283019u,
        DarkGray = 4289309097u,
        DarkGreen = 4278215680u,
        DarkKhaki = 4290623339u,
        DarkMagenta = 4287299723u,
        DarkOliveGreen = 4283788079u,
        DarkOrange = 4294937600u,
        DarkOrchid = 4288230092u,
        DarkRed = 4287299584u,
        DarkSalmon = 4293498490u,
        DarkSeaGreen = 4287609999u,
        DarkSlateBlue = 4282924427u,
        DarkSlateGray = 4281290575u,
        DarkTurquoise = 4278243025u,
        DarkViolet = 4287889619u,
        DeepPink = 4294907027u,
        DeepSkyBlue = 4278239231u,
        DimGray = 4285098345u,
        DodgerBlue = 4280193279u,
        Firebrick = 4289864226u,
        FloralWhite = 4294966000u,
        ForestGreen = 4280453922u,
        Fuchsia = 4294902015u,
        Gainsboro = 4292664540u,
        GhostWhite = 4294506751u,
        Gold = 4294956800u,
        Goldenrod = 4292519200u,
        Gray = 4286611584u,
        Green = 4278222848u,
        GreenYellow = 4289593135u,
        Honeydew = 4293984240u,
        HotPink = 4294928820u,
        IndianRed = 4291648604u,
        Indigo = 4283105410u,
        Ivory = 4294967280u,
        Khaki = 4293977740u,
        Lavender = 4293322490u,
        LavenderBlush = 4294963445u,
        LawnGreen = 4286381056u,
        LemonChiffon = 4294965965u,
        LightBlue = 4289583334u,
        LightCoral = 4293951616u,
        LightCyan = 4292935679u,
        LightGoldenrodYellow = 4294638290u,
        LightGreen = 4287688336u,
        LightGray = 4292072403u,
        LightPink = 4294948545u,
        LightSalmon = 4294942842u,
        LightSeaGreen = 4280332970u,
        LightSkyBlue = 4287090426u,
        LightSlateGray = 4286023833u,
        LightSteelBlue = 4289774814u,
        LightYellow = 4294967264u,
        Lime = 4278255360u,
        LimeGreen = 4281519410u,
        Linen = 4294635750u,
        Magenta = 4294902015u,
        Maroon = 4286578688u,
        MediumAquamarine = 4284927402u,
        MediumBlue = 4278190285u,
        MediumOrchid = 4290401747u,
        MediumPurple = 4287852763u,
        MediumSeaGreen = 4282168177u,
        MediumSlateBlue = 4286277870u,
        MediumSpringGreen = 4278254234u,
        MediumTurquoise = 4282962380u,
        MediumVioletRed = 4291237253u,
        MidnightBlue = 4279834992u,
        MintCream = 4294311930u,
        MistyRose = 4294960353u,
        Moccasin = 4294960309u,
        NavajoWhite = 4294958765u,
        Navy = 4278190208u,
        OldLace = 4294833638u,
        Olive = 4286611456u,
        OliveDrab = 4285238819u,
        Orange = 4294944000u,
        OrangeRed = 4294919424u,
        Orchid = 4292505814u,
        PaleGoldenrod = 4293847210u,
        PaleGreen = 4288215960u,
        PaleTurquoise = 4289720046u,
        PaleVioletRed = 4292571283u,
        PapayaWhip = 4294963157u,
        PeachPuff = 4294957753u,
        Peru = 4291659071u,
        Pink = 4294951115u,
        Plum = 4292714717u,
        PowderBlue = 4289781990u,
        Purple = 4286578816u,
        Red = 4294901760u,
        RosyBrown = 4290547599u,
        RoyalBlue = 4282477025u,
        SaddleBrown = 4287317267u,
        Salmon = 4294606962u,
        SandyBrown = 4294222944u,
        SeaGreen = 4281240407u,
        SeaShell = 4294964718u,
        Sienna = 4288696877u,
        Silver = 4290822336u,
        SkyBlue = 4287090411u,
        SlateBlue = 4285160141u,
        SlateGray = 4285563024u,
        Snow = 4294966010u,
        SpringGreen = 4278255487u,
        SteelBlue = 4282811060u,
        Tan = 4291998860u,
        Teal = 4278222976u,
        Thistle = 4292394968u,
        Tomato = 4294927175u,
        Transparent = 16777215u,
        Turquoise = 4282441936u,
        Violet = 4293821166u,
        Wheat = 4294303411u,
        White = 4294967295u,
        WhiteSmoke = 4294309365u,
        Yellow = 4294967040u,
        YellowGreen = 4288335154u,
        UnknownColor = 1u
      }

      static KnownColor ColorStringToKnownColor(string colorString)
      {
        switch (colorString.ToLower())
        {
          case "aliceblue": return KnownColor.AliceBlue;
          case "antiquewhite": return KnownColor.AntiqueWhite;
          case "aqua": return KnownColor.Aqua;
          case "aquamarine": return KnownColor.Aquamarine;
          case "azure": return KnownColor.Azure;
          case "beige": return KnownColor.Beige;
          case "bisque": return KnownColor.Bisque;
          case "black": return KnownColor.Black;
          case "blanchedalmond": return KnownColor.BlanchedAlmond;
          case "blue": return KnownColor.Blue;
          case "blueviolet": return KnownColor.BlueViolet;
          case "brown": return KnownColor.Brown;
          case "burlywood": return KnownColor.BurlyWood;
          case "cadetblue": return KnownColor.CadetBlue;
          case "chartreuse": return KnownColor.Chartreuse;
          case "chocolate": return KnownColor.Chocolate;
          case "coral": return KnownColor.Coral;
          case "cornflowerblue": return KnownColor.CornflowerBlue;
          case "cornsilk": return KnownColor.Cornsilk;
          case "crimson": return KnownColor.Crimson;
          case "cyan": return KnownColor.Cyan;
          case "darkblue": return KnownColor.DarkBlue;
          case "darkcyan": return KnownColor.DarkCyan;
          case "darkgoldenrod": return KnownColor.DarkGoldenrod;
          case "darkgray": return KnownColor.DarkGray;
          case "darkgreen": return KnownColor.DarkGreen;
          case "darkkhaki": return KnownColor.DarkKhaki;
          case "darkmagenta": return KnownColor.DarkMagenta;
          case "darkolivegreen": return KnownColor.DarkOliveGreen;
          case "darkorange": return KnownColor.DarkOrange;
          case "darkorchid": return KnownColor.DarkOrchid;
          case "darkred": return KnownColor.DarkRed;
          case "darksalmon": return KnownColor.DarkSalmon;
          case "darkseagreen": return KnownColor.DarkSeaGreen;
          case "darkslateblue": return KnownColor.DarkSlateBlue;
          case "darkslategray": return KnownColor.DarkSlateGray;
          case "darkturquoise": return KnownColor.DarkTurquoise;
          case "darkviolet": return KnownColor.DarkViolet;
          case "deeppink": return KnownColor.DeepPink;
          case "deepskyblue": return KnownColor.DeepSkyBlue;
          case "dimgray": return KnownColor.DimGray;
          case "dodgerblue": return KnownColor.DodgerBlue;
          case "firebrick": return KnownColor.Firebrick;
          case "floralwhite": return KnownColor.FloralWhite;
          case "forestgreen": return KnownColor.ForestGreen;
          case "fuchsia": return KnownColor.Fuchsia;
          case "gainsboro": return KnownColor.Gainsboro;
          case "ghostwhite": return KnownColor.GhostWhite;
          case "gold": return KnownColor.Gold;
          case "goldenrod": return KnownColor.Goldenrod;
          case "gray": return KnownColor.Gray;
          case "green": return KnownColor.Green;
          case "greenyellow": return KnownColor.GreenYellow;
          case "honeydew": return KnownColor.Honeydew;
          case "hotpink": return KnownColor.HotPink;
          case "indianred": return KnownColor.IndianRed;
          case "indigo": return KnownColor.Indigo;
          case "ivory": return KnownColor.Ivory;
          case "khaki": return KnownColor.Khaki;
          case "lavender": return KnownColor.Lavender;
          case "lavenderblush": return KnownColor.LavenderBlush;
          case "lawngreen": return KnownColor.LawnGreen;
          case "lemonchiffon": return KnownColor.LemonChiffon;
          case "lightblue": return KnownColor.LightBlue;
          case "lightcoral": return KnownColor.LightCoral;
          case "lightcyan": return KnownColor.LightCyan;
          case "lightgoldenrodyellow": return KnownColor.LightGoldenrodYellow;
          case "lightgreen": return KnownColor.LightGreen;
          case "lightgray": return KnownColor.LightGray;
          case "lightpink": return KnownColor.LightPink;
          case "lightsalmon": return KnownColor.LightSalmon;
          case "lightseagreen": return KnownColor.LightSeaGreen;
          case "lightskyblue": return KnownColor.LightSkyBlue;
          case "lightslategray": return KnownColor.LightSlateGray;
          case "lightsteelblue": return KnownColor.LightSteelBlue;
          case "lightyellow": return KnownColor.LightYellow;
          case "lime": return KnownColor.Lime;
          case "limegreen": return KnownColor.LimeGreen;
          case "linen": return KnownColor.Linen;
          case "magenta": return KnownColor.Magenta;
          case "maroon": return KnownColor.Maroon;
          case "mediumaquamarine": return KnownColor.MediumAquamarine;
          case "mediumblue": return KnownColor.MediumBlue;
          case "mediumorchid": return KnownColor.MediumOrchid;
          case "mediumpurple": return KnownColor.MediumPurple;
          case "mediumseagreen": return KnownColor.MediumSeaGreen;
          case "mediumslateblue": return KnownColor.MediumSlateBlue;
          case "mediumspringgreen": return KnownColor.MediumSpringGreen;
          case "mediumturquoise": return KnownColor.MediumTurquoise;
          case "mediumvioletred": return KnownColor.MediumVioletRed;
          case "midnightblue": return KnownColor.MidnightBlue;
          case "mintcream": return KnownColor.MintCream;
          case "mistyrose": return KnownColor.MistyRose;
          case "moccasin": return KnownColor.Moccasin;
          case "navajowhite": return KnownColor.NavajoWhite;
          case "navy": return KnownColor.Navy;
          case "oldlace": return KnownColor.OldLace;
          case "olive": return KnownColor.Olive;
          case "olivedrab": return KnownColor.OliveDrab;
          case "orange": return KnownColor.Orange;
          case "orangered": return KnownColor.OrangeRed;
          case "orchid": return KnownColor.Orchid;
          case "palegoldenrod": return KnownColor.PaleGoldenrod;
          case "palegreen": return KnownColor.PaleGreen;
          case "paleturquoise": return KnownColor.PaleTurquoise;
          case "palevioletred": return KnownColor.PaleVioletRed;
          case "papayawhip": return KnownColor.PapayaWhip;
          case "peachpuff": return KnownColor.PeachPuff;
          case "peru": return KnownColor.Peru;
          case "pink": return KnownColor.Pink;
          case "plum": return KnownColor.Plum;
          case "powderblue": return KnownColor.PowderBlue;
          case "purple": return KnownColor.Purple;
          case "red": return KnownColor.Red;
          case "rosybrown": return KnownColor.RosyBrown;
          case "royalblue": return KnownColor.RoyalBlue;
          case "saddlebrown": return KnownColor.SaddleBrown;
          case "salmon": return KnownColor.Salmon;
          case "sandybrown": return KnownColor.SandyBrown;
          case "seagreen": return KnownColor.SeaGreen;
          case "seashell": return KnownColor.SeaShell;
          case "sienna": return KnownColor.Sienna;
          case "silver": return KnownColor.Silver;
          case "skyblue": return KnownColor.SkyBlue;
          case "slateblue": return KnownColor.SlateBlue;
          case "slategray": return KnownColor.SlateGray;
          case "snow": return KnownColor.Snow;
          case "springgreen": return KnownColor.SpringGreen;
          case "steelblue": return KnownColor.SteelBlue;
          case "tan": return KnownColor.Tan;
          case "teal": return KnownColor.Teal;
          case "thistle": return KnownColor.Thistle;
          case "tomato": return KnownColor.Tomato;
          case "transparent": return KnownColor.Transparent;
          case "turquoise": return KnownColor.Turquoise;
          case "violet": return KnownColor.Violet;
          case "wheat": return KnownColor.Wheat;
          case "white": return KnownColor.White;
          case "whitesmoke": return KnownColor.WhiteSmoke;
          case "yellow": return KnownColor.Yellow;
          case "yellowgreen": return KnownColor.YellowGreen;

          default:
            return KnownColor.UnknownColor;
        }
      }

      public static Color Convert(object value)
      {
        if (value is Color)
          return (Color)value;

        if (value is int)
          return ColorFromUInt32(0xFF000000 | (uint)(int)value);

        if (value is uint)
          return ColorFromUInt32((uint)value);

        var s = value as string;
        if (s != null)
          return Parse(s);

        throw new InvalidCastException();
      }

      public static Color Parse(string color)
      {
        color = color.Trim();

        switch (color.Length)
        {
          case 4:
          case 5:
          case 7:
          case 9:
            if (color[0] == '#')
              return ParseHexColor(color);
            break;
        }

        var kc = ColorStringToKnownColor(color);
        if (kc != KnownColor.UnknownColor)
          return ColorFromUInt32((uint)kc);

        throw new FormatException("Unrecognized Color Literal");
      }

      static Color ColorFromUInt32(uint argb)
      {
        return Color.FromArgb(
          (byte)((argb & 0xFF000000) >> 24),
          (byte)((argb & 0x00FF0000) >> 16),
          (byte)((argb & 0x0000FF00) >> 8),
          (byte)(argb & 0xFF));
      }

      static int ParseHexChar(char c)
      {
        if (c >= '0' && c <= '9')
        {
          return (int)(c - '0');
        }
        if (c >= 'a' && c <= 'f')
        {
          return (int)(c - 'a' + '\n');
        }
        if (c >= 'A' && c <= 'F')
        {
          return (int)(c - 'A' + '\n');
        }
        throw new FormatException("Illegal Hexadecimal");
      }

      static Color ParseHexColor(string trimmedColor)
      {
        int a = 255;

        int r;
        int g;
        int b;

        if (trimmedColor.Length > 7)
        {
          a = ParseHexChar(trimmedColor[1]) * 16 + ParseHexChar(trimmedColor[2]);
          r = ParseHexChar(trimmedColor[3]) * 16 + ParseHexChar(trimmedColor[4]);
          g = ParseHexChar(trimmedColor[5]) * 16 + ParseHexChar(trimmedColor[6]);
          b = ParseHexChar(trimmedColor[7]) * 16 + ParseHexChar(trimmedColor[8]);
        }
        else if (trimmedColor.Length > 5)
        {
          r = ParseHexChar(trimmedColor[1]) * 16 + ParseHexChar(trimmedColor[2]);
          g = ParseHexChar(trimmedColor[3]) * 16 + ParseHexChar(trimmedColor[4]);
          b = ParseHexChar(trimmedColor[5]) * 16 + ParseHexChar(trimmedColor[6]);
        }
        else if (trimmedColor.Length > 4)
        {
          a = ParseHexChar(trimmedColor[1]);
          int expr_107 = a;
          a = expr_107 + expr_107 * 16;
          r = ParseHexChar(trimmedColor[2]);
          int expr_11B = r;
          r = expr_11B + expr_11B * 16;
          g = ParseHexChar(trimmedColor[3]);
          int expr_12F = g;
          g = expr_12F + expr_12F * 16;
          b = ParseHexChar(trimmedColor[4]);
          int expr_143 = b;
          b = expr_143 + expr_143 * 16;
        }
        else
        {
          r = ParseHexChar(trimmedColor[1]);
          int expr_159 = r;
          r = expr_159 + expr_159 * 16;
          g = ParseHexChar(trimmedColor[2]);
          int expr_16D = g;
          g = expr_16D + expr_16D * 16;
          b = ParseHexChar(trimmedColor[3]);
          int expr_181 = b;
          b = expr_181 + expr_181 * 16;
        }
        return Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
      }
    }
  }
}
