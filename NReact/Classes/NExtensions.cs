using System;
using System.Diagnostics;
using System.Reflection;
#if NETFX_CORE
using System.Linq;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
#endif

namespace NReact
{
  public static class NExtensions
  {
    public static NDynamic AsDynamic<T>(this T obj) where T : class
    {
      return NDynamicConverter<T>.Convert(obj);
    }

    public static T Render<T>(this ContentControl target, T element) where T : NElement
    {
      target.Content = CreateTree(element);

      return element;
    }

    public static T Render<T>(this UserControl target, T element) where T : NElement
    {
      target.Content = CreateTree(element);

      return element;
    }

    public static T Render<T>(this Window target, T element) where T : NElement
    {
      target.Content = CreateTree(element) as FrameworkElement;

      return element;
    }

#if SILVERLIGHT
    public static T Render<T>(this Application target, T element) where T : NElement
    {
      target.RootVisual = CreateTree(element);

      return element;
    }
#endif

    internal static UIElement CreateTree(NElement e)
    {
      if (e == null)
        return null;

      var c = e as NComponent;
      if (c != null)
        return c.Target = CreateTree(c.UI);

      return CreateXaml((NXamlElement)e);
    }

    static UIElement CreateXaml(NXamlElement e)
    {
      var result = (UIElement)NFactory.Create(e._type);

      if (e._props != null)
        result.Assign(e._props, e._type);

      var p = result as Panel;
      if (p != null)
      {
        var xamlChildren = p.Children;
        var vdomChildren = e.Children;

        for (int i = 0, c = vdomChildren.Length; i < c; i++)
          xamlChildren.Add(CreateTree(vdomChildren[i]) ?? new UserControl());
      }

      return result;
    }

    public static void Assign(this UIElement xe, NDynamic props, Type type = null)
    {
      if (type == null)
        type = xe.GetType();

      foreach (var i in props.GetContent())
        try
        {
          var setter = NFactory.GetSetter(type, i.Name);
          if (setter != null)
          {
            setter(xe, i.Value);
            continue;
          }

          throw new InvalidOperationException("Unknown Member " + i.Name);
        }
        catch (Exception e)
        {
          Debug.WriteLine("Failed to assign {0}.{1} with {2}\n{3}", xe.GetType().Name, i.Name, i.Value, e.Message);
        }
    }

#if SILVERLIGHT
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
        d.RunAsync(CoreDispatcherPriority.Normal, () => action(arg));
#else
      if (d.CheckAccess())
        action(arg);
      else
        d.BeginInvoke(action, arg);
#endif
    }
  }
}
