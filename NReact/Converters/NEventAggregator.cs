using System;
#if XAML
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif
#elif XFORMS
using Xamarin.Forms;
#endif

namespace NReact
{
  class NEventAggregator
  {
    NEventAdapter _first, _last;
                                                                                                     
    public NEventAdapter this[NProperty key]
    {
      get
      {
        for (var i = _first; i != null; i = i.Next)
          if (ReferenceEquals(i.Property, key)) return i;

        return null;
      }
      set
      {
        if (_first == null)
        {
          _first = _last = value;
        }
        else
        {
          _last.Next = value;
          _last = value;
        }
      }
    }

    public static void AssignEvent<T>(NProperty prop, object action, T target, Action<T, NEventAdapter> subscribe) where T : class
    {
      var handled = NEventAdapter.UnpackHandler(ref action);
      if (handled)
        throw new InvalidOperationException($"No support for handled events of {prop.Name}");

#if XAML
      var dep = target as DependencyObject;
      if (dep != null)
      {
        var agg = (NEventAggregator)dep.GetValue(AggregatorProperty);
        if (agg == null)
          dep.SetValue(AggregatorProperty, agg = new NEventAggregator());

        var adapter = agg[prop];
        if (adapter == null)
        {
          agg[prop] = adapter = new NEventAdapter(prop) { Action = action };
          subscribe(target, adapter);
        }
        else
          adapter.Action = action;
      } else
#elif XFORMS
      var dep = target as BindableObject;
      if (dep != null)
      {
        var agg = (NEventAggregator)dep.GetValue(AggregatorProperty);
        if (agg == null)
          dep.SetValue(AggregatorProperty, agg = new NEventAggregator());

        var adapter = agg[prop];
        if (adapter == null)
        {
          agg[prop] = adapter = new NEventAdapter(prop) { Action = action };
          subscribe(target, adapter);
        }
        else
          adapter.Action = action;
      }
      else
#endif
      {
        subscribe(target, new NEventAdapter(prop) { Action = action });
      }
    }

#if XAML
    public static void AssignEvent(NProperty prop, object action, DependencyObject target, RoutedEvent routedEvent, Func<NEventAdapter, Delegate> extractor)
    {
      var handled = NEventAdapter.UnpackHandler(ref action);

      var agg = (NEventAggregator)target.GetValue(AggregatorProperty);
      if (agg == null)
        target.SetValue(AggregatorProperty, agg = new NEventAggregator());

      var adapter = agg[prop];
      if (adapter == null)
      {
        agg[prop] = adapter = new NEventAdapter(prop) { Action = action };

        var handler = extractor(adapter);

        var e = target as UIElement;
        if (e != null)
          e.AddHandler(routedEvent, handler, handled);
#if WPF
          else
          {
            var ce = target as ContentElement;
            if (ce != null)
              ce.AddHandler(routedEvent, handler, true);
          }
#endif
      }
      else
        adapter.Action = action;
    }

    public static readonly DependencyProperty AggregatorProperty = DependencyProperty.RegisterAttached("Aggregator", typeof(NEventAggregator), typeof(NEventAggregator), null);
#elif XFORMS
    public static readonly BindableProperty AggregatorProperty = BindableProperty.CreateAttached("Aggregator", typeof(NEventAggregator), typeof(NEventAggregator), null);
#endif
  }

  public class NEventAdapter
  {
    public readonly NProperty Property;
    public NEventAdapter(NProperty prop)
    {
      Property = prop;
    }

    void Raise(object sender, object args)
    {
      if (_event == null) return;

      {
        var a = _event as EventHandler;
        if (a != null) { a(sender, ToEventArgs(args)); return; }
      }

      {
        var a = _event as Action<object, object>;
        if (a != null) { a(sender, args); return; }
      }

      {
        var a = _event as Action<object>;
        if (a != null) { a(sender); return; }
      }

      {
        var a = _event as Action;
        if (a != null) { a(); return; }
      }

      throw new NotSupportedException($"Error: Not supported event handler type: {_event}");
    }

    object _event;
    internal NEventAdapter Next;
    public void EventHandlerAny<T>(object sender, T args)
    {
      {
        var e = _event as Action<object, T>;
        if (e != null) { e(sender, args); return; }
      }

      {
        var e = _event as Action<object>;
        if (e != null) { e(sender); return; }
      }

      {
        var e = _event as Action<T>;
        if (e != null) { e(args); return; }
      }

      Raise(sender, args);
    }
    public void EventHandler<T>(object sender, T args) where T : EventArgs
    {
      {
        var e = _event as EventHandler<T>;
        if (e != null) { e(sender, args); return; }
      }

      EventHandlerAny(sender, args);
    }
    EventArgs ToEventArgs(object a)
    {
      var result = a as EventArgs;
      if (result != null) return result;

      return new NEventArgs(a);
    }
    internal object Action
    {
      set
      {
        if (value == null || value == NUnset.Instance)
          _event = null;
        else
          _event = value;
      }
    }

    public static object PackHandler(object action, bool includeHandled)
    {
      return includeHandled ? new NHandledEventWrapper(action) : action;
    }

    public static bool UnpackHandler(ref object action)
    {
      var e = action as NHandledEventWrapper;
      if (e != null)
      {
        action = e.Action;
        return true;
      }

      return false;
    }
  }

  class NHandledEventWrapper
  {
    public readonly object Action;

    public NHandledEventWrapper(object action)
    {
      Action = action;
    }
  }

  public class NEventArgs : EventArgs
  {
    public NEventArgs(object original) { Original = original; }
    public object Original { get; private set; }
  }
}
