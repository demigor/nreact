using System;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
#endif

namespace NReact.Converters
{
  public static class NEvents
  {
    public static EventHandler ToEventHandler(object source)
    {
      var c = source as EventHandler;
      if (c != null)
        return c;

      var a = source as Action;
      if (a != null)
        return (sender, args) => a();

      return null;
    }

    public static KeyEventHandler ToKeyEventHandler(object source)
    {
      var d = source as KeyEventHandler;
      if (d != null)
        return d;

      var c = source as EventHandler;
      if (c != null)
        return (sender, args) => c(sender, WrapEventArgs.Wrap(args));

      var a = source as Action;
      if (a != null)
        return (sender, args) => a();

      throw new InvalidCastException("Cannot convert value to KeyEventHandler");
    }

#if NETFX_CORE
    public static PointerEventHandler ToPointerEventHandler(object source)
    {
      var d = source as PointerEventHandler;
      if (d != null)
        return d;

      var c = source as EventHandler;
      if (c != null)
        return (sender, args) => c(sender, WrapEventArgs.Wrap(args));

      var a = source as Action;
      if (a != null)
        return (sender, args) => a();

      throw new InvalidCastException("Cannot convert value to PointerEventHandler");
    }
#else
    public static MouseButtonEventHandler ToMouseButtonEventHandler(object source)
    {
      var d = source as MouseButtonEventHandler;
      if (d != null)
        return d;

      var c = source as EventHandler;
      if (c != null)
        return (sender, args) => c(sender, args);

      var a = source as Action;
      if (a != null)
        return (sender, args) => a();

      throw new InvalidCastException("Cannot convert value to MouseEventHandler");
    }
#endif

    public static bool Convert(object source, Type target, ref object result)
    {
      var e = ToEventHandler(source);
      if (e == null) return false;

      if (target == typeof(EventHandler))
      {
        result = e;
        return true;
      }

      if (target == typeof(RoutedEventHandler))
      {
        result = (RoutedEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }

      if (target == typeof(KeyEventHandler))
      {
        result = (KeyEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }

#if NETFX_CORE
      if (target == typeof(PointerEventHandler))
      {
        result = (PointerEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }
#else
      if (target == typeof(MouseEventHandler))
      {
        result = (MouseEventHandler)((sender, args) => e(sender, args));
        return true;
      }

      if (target == typeof(MouseButtonEventHandler))
      {
        result = (MouseButtonEventHandler)((sender, args) => e(sender, args));
        return true;
      }
      if (target == typeof(MouseWheelEventHandler))
      {
        result = (MouseWheelEventHandler)((sender, args) => e(sender, args));
        return true;
      }
      if (target == typeof(TextCompositionEventHandler))
      {
        result = (TextCompositionEventHandler)((sender, args) => e(sender, args));
        return true;
      }
#endif

      if (target == typeof(TextChangedEventHandler))
      {
        result = (TextChangedEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }

      if (target == typeof(DependencyPropertyChangedEventHandler))
      {
        result = (DependencyPropertyChangedEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }

      if (target == typeof(SizeChangedEventHandler))
      {
        result = (SizeChangedEventHandler)((sender, args) => e(sender, WrapEventArgs.Wrap(args)));
        return true;
      }

      return false;
    }

    public static Type[] GetSupportedTypes()
    {
      return new[] { typeof(EventHandler), typeof(RoutedEventHandler), typeof(KeyEventHandler), typeof(KeyEventHandler),
#if NETFX_CORE
        typeof(PointerEventHandler), 
#else
        typeof(MouseEventHandler), typeof(MouseButtonEventHandler), typeof(MouseWheelEventHandler), typeof(TextCompositionEventHandler),
#endif
        typeof(TextChangedEventHandler), typeof(DependencyPropertyChangedEventHandler), typeof(SizeChangedEventHandler)
      };
    }
  }

  public class WrapEventArgs : EventArgs
  {
    public static EventArgs Wrap(object args)
    {
      var result = args as EventArgs;
      if (result != null)
        return result;

      return new WrapEventArgs(args);
    }

    public WrapEventArgs(object original)
    {
      Args = original;
    }

    public object Args { get; private set; }
  }
}
