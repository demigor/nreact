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
    public static bool Convert(object source, Type target, out object result)
    {
      if (target == typeof(DataTemplate) || target == typeof(ControlTemplate) || target == typeof(Style))
      {
        result = Application.Current.Resources[source];
        return true;
      }

      result = null;
      return false;
    }
  }
}
