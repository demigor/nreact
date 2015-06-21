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
  public static class NResources
  {
    public static Type[] GetSupportedTypes()
    {
      return new[] { typeof(DataTemplate), typeof(ControlTemplate), typeof(Style) };
    }

    public static bool Convert(object source, Type target, ref object result)
    {
      result = Application.Current.Resources[source];
      return true;
    }
  }
}
