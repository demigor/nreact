using System;
#if NETFX_CORE
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
#endif

namespace NReact
{
  public static partial class NConverters
  {
    static EventArgs ToEventArgs<T>(this T arg) where T : RoutedEventArgs
    {
#if NETFX_CORE
      return new EventArgs<T>(arg);
#else
      return arg;
#endif
    }

    public static class NEvents
    {
      public static RoutedEventHandler ToRoutedEventHandler(object value)
      {
        var r = value as RoutedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<RoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

#if NETFX_CORE
      public static ManipulationCompletedEventHandler ToManipulationCompletedEventHandler(object value)
      {
        var r = value as ManipulationCompletedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<ManipulationCompletedRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static ManipulationDeltaEventHandler ToManipulationDeltaEventHandler(object value)
      {
        var r = value as ManipulationDeltaEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<ManipulationDeltaRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static ManipulationInertiaStartingEventHandler ToManipulationInertiaStartingEventHandler(object value)
      {
        var r = value as ManipulationInertiaStartingEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<ManipulationInertiaStartingRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static ManipulationStartingEventHandler ToManipulationStartingEventHandler(object value)
      {
        var r = value as ManipulationStartingEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<ManipulationStartingRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static ManipulationStartedEventHandler ToManipulationStartedEventHandler(object value)
      {
        var r = value as ManipulationStartedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<ManipulationStartedRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }


      public static TypedEventHandler<T, A> ToTypedEventHandler<T, A>(object value) where A : RoutedEventArgs
      {
        var r = value as TypedEventHandler<T, A>;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<A>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static PointerEventHandler ToPointerEventHandler(object value)
      {
        var r = value as PointerEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<PointerRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static HoldingEventHandler ToHoldingEventHandler(object value)
      {
        var r = value as HoldingEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<HoldingRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static TappedEventHandler ToTappedEventHandler(object value)
      {
        var r = value as TappedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<TappedRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static RightTappedEventHandler ToRightTappedEventHandler(object value)
      {
        var r = value as RightTappedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<RightTappedRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static DoubleTappedEventHandler ToDoubleTappedEventHandler(object value)
      {
        var r = value as DoubleTappedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<DoubleTappedRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static KeyEventHandler ToKeyEventHandler(object value)
      {
        var r = value as KeyEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<KeyRoutedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

#else
      public static EventHandler<ManipulationCompletedEventArgs> ToManipulationCompletedEventHandler(object value)
      {
        return ToEventHandler<ManipulationCompletedEventArgs>(value);
      }

      public static EventHandler<ManipulationStartedEventArgs> ToManipulationStartedEventHandler(object value)
      {
        return ToEventHandler<ManipulationStartedEventArgs>(value);
      }

      public static EventHandler<ManipulationDeltaEventArgs> ToManipulationDeltaEventHandler(object value)
      {
        return ToEventHandler<ManipulationDeltaEventArgs>(value);
      }

      public static EventHandler<A> ToEventHandler<A>(object value) where A : EventArgs
      {
        var r = value as EventHandler<A>;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<A>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static KeyEventHandler ToKeyEventHandler(object value)
      {
        var r = value as KeyEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<KeyEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }
#endif

      public static TextChangedEventHandler ToTextChangedEventHandler(object value)
      {
        var r = value as TextChangedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<TextChangedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static SelectionChangedEventHandler ToSelectionChangedEventHandler(object value)
      {
        var r = value as SelectionChangedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<SelectionChangedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

#if SILVERLIGHT
      public static ContentChangedEventHandler ToContentChangedEventHandler(object value)
      {
        var r = value as ContentChangedEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<ContentChangedEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static MediaCommandEventHandler ToMediaCommandEventHandler(object value)
      {
        var r = value as MediaCommandEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<MediaCommandEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }
#endif

      public static DragEventHandler ToDragEventHandler(object value)
      {
        var r = value as DragEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args.ToEventArgs());

        var et = value as EventHandler<DragEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

#if !NETFX_CORE
      public static TextCompositionEventHandler ToTextCompositionEventHandler(object value)
      {
        var r = value as TextCompositionEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<TextCompositionEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static MouseEventHandler ToMouseEventHandler(object value)
      {
        var r = value as MouseEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<MouseEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static MouseWheelEventHandler ToMouseWheelEventHandler(object value)
      {
        var r = value as MouseWheelEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<MouseWheelEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }

      public static MouseButtonEventHandler ToMouseButtonEventHandler(object value)
      {
        var r = value as MouseButtonEventHandler;
        if (r != null) return r;

        var a = value as Action;
        if (a != null) return (sender, args) => a();

        var a1 = value as Action<object>;
        if (a1 != null) return (sender, args) => a1(sender);

        var eh = value as EventHandler;
        if (eh != null) return (sender, args) => eh(sender, args);

        var et = value as EventHandler<MouseButtonEventArgs>;
        if (et != null) return (sender, args) => et(sender, args);

        throw new InvalidCastException();
      }
#endif
    }
  }

#if NETFX_CORE
  public class EventArgs<T> : EventArgs
  {
    public EventArgs(T arg) { Args = arg; }
    public T Args { get; private set; }
  }
#endif
}
