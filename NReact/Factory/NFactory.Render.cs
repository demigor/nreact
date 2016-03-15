#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
using sw = System.Windows;
#endif

namespace NReact
{
  public static partial class NFactory
  {
    public static NElement Render(this ContentControl control, NElement content)
    {
      var cls = content as NClass;
      if (cls != null)
        cls.XamlChanged = (c, p) => control.Content = p;

      control.Content = content.Create();
      return content;
    }

    public static NElement Render(this UserControl control, NElement content)
    {
      control.Content = (UIElement)content.Create();

      var cls = content as NClass;
      if (cls != null)
        cls.XamlChanged = (c, p) => control.Content = (UIElement)p;

      return content;
    }

    public static NElement Render(this Window control, NElement content)
    {
      control.Content = (FrameworkElement)content.Create();

      var cls = content as NClass;
      if (cls != null)
        cls.XamlChanged = (c, p) => control.Content = (FrameworkElement)p;

      return content;
    }

    public static NElement Render(this Border control, NElement content)
    {
      control.Child = (UIElement)content.Create();

      var cls = content as NClass;
      if (cls != null)
        cls.XamlChanged = (c, p) => control.Child = (UIElement)p;

      return content;
    }

#if SILVERLIGHT
    public static NElement Render(this Application app, NElement content)
    {
      if (content is NClass) 
      {
        var border = new Border { HorizontalAlignment = sw.HorizontalAlignment.Stretch, VerticalAlignment = sw.VerticalAlignment.Stretch };
        content = border.Render(content);
        app.RootVisual = border;
      } 
      else 
      {
        app.RootVisual = (UIElement)content.Create();
      }
      return content;
    }
#endif

  }
}
