using System;
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
    public static NElement GetRender(DependencyObject obj)
    {
      return (NElement)obj.GetValue(RenderProperty);
    }

    public static void SetRender(DependencyObject obj, NElement value)
    {
      obj.SetValue(RenderProperty, value);
    }

    public static readonly DependencyProperty RenderProperty = DependencyProperty.RegisterAttached("Render", typeof(NElement), typeof(NFactory), new PropertyMetadata(null, SetRenderElement));

    static void SetRenderElement(DependencyObject d, DependencyPropertyChangedEventArgs args)
    {
      NPatch.Finalize(args.OldValue);

      var e = (NElement)args.NewValue;
      if (e == null) return;

      var cc = d as ContentControl;
      if (cc != null) { cc.Render(e); return; }

      var uc = d as UserControl;
      if (uc != null) { uc.Render(e); return; }

#if !NETFX_CORE
      var w = d as Window;
      if (w != null) { w.Render(e); return; }
#endif

      var b = d as Border;
      if (b != null) { b.Render(e); return; }

      throw new NotSupportedException();
    }

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
