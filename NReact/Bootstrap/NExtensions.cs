using System;
#if NETFX_CORE
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
#endif

namespace NReact
{
  public static class NExtensions
  {
    public static NElement GetRender(DependencyObject obj)
    {
      return (NElement)obj.GetValue(RenderProperty);
    }

    public static void SetRender(DependencyObject obj, NElement value)
    {
      obj.SetValue(RenderProperty, value);
    }

    public static readonly DependencyProperty RenderProperty = DependencyProperty.RegisterAttached("Render", typeof(NElement), typeof(NExtensions), new PropertyMetadata(null, OnRenderChanged));

    static void OnRenderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      var cc = d as ContentControl;
      if (cc != null)
      {
        cc.Render((NElement)e.NewValue);
        return;
      }

#if SILVERLIGHT
      var uc = d as UserControl;
      if (uc != null)
      {
        uc.Render((NElement)e.NewValue);
        return;
      }
#endif

      var b = d as Border;
      if (b != null)
      {
        b.Render((NElement)e.NewValue);
        return;
      }

#if !NETFX_CORE
      var w = d as Window;
      if (w != null)
      {
        w.Render((NElement)e.NewValue);
        return;
      }
#endif

      throw new NotSupportedException();
    }

    public static T Render<T>(this Border target, T component) where T : NElement
    {
      target.Child = (UIElement)NFactory.Default.Create(component);
      return component;
    }

    public static T Render<T>(this ContentControl target, T component) where T : NElement
    {
      target.Content = NFactory.Default.Create(component);
      return component;
    }

    public static T Render<T>(this Window target, T component) where T : NElement
    {
      target.Content = (FrameworkElement)NFactory.Default.Create(component);
      return component;
    }

#if SILVERLIGHT
    public static T Render<T>(this UserControl target, T component) where T : NElement
    {
      target.Content = (UIElement)NFactory.Default.Create(component);
      return component;
    }

    static readonly Dispatcher Dispatcher = Deployment.Current.Dispatcher;
#elif NETFX_CORE
    static readonly CoreDispatcher Dispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
#else
    static readonly Dispatcher Dispatcher = Application.Current.Dispatcher;
#endif

    internal static void UIInvoke<T>(Action<T> action, T arg)
    {
      var d = Dispatcher;

#if NETFX_CORE
      if (d.HasThreadAccess)
        action(arg);
      else
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        d.RunAsync(CoreDispatcherPriority.Normal, () => action(arg));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
#else
      if (d.CheckAccess())
        action(arg);
      else
        d.BeginInvoke(action, arg);
#endif
    }
  }
}
