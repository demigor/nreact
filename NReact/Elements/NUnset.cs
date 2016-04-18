#if XAML
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif
#endif

namespace NReact
{
  /// <summary>
  /// Represents undefined value
  /// </summary>
  public static class NUnset
  {
    /// <summary>
    /// Unset dependency value constant
    /// </summary>
#if XAML
    public static readonly object Instance = DependencyProperty.UnsetValue;
#else
    public static readonly object Instance = new object();
#endif
  }
}
