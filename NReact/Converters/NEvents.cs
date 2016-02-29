using System;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
using System.Windows.Input;
#endif

namespace NReact
{
  public class NEventAdapter
  {
    public class Aggregator
    {
      NEventAdapter _first, _last;

      public NEventAdapter this[int id]
      {
        get
        {
          for (var i = _first; i != null; i = i._next)
            if (i.Id == id) return i;

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
            _last._next = value;
            _last = value;
          }
        }
      }

      public static void AssignEvent<T>(int id, object action, T target, Action<T, NEventAdapter> subscribe) where T : class
      {
        var dep = target as DependencyObject;
        if (dep == null)
        {
          subscribe(target, new NEventAdapter(id) { Action = action });
        }
        else {
          var agg = (Aggregator)dep.GetValue(AggregatorProperty);
          if (agg == null)
            dep.SetValue(AggregatorProperty, agg = new Aggregator());

          var adapter = agg[id];
          if (adapter == null)
            subscribe(target, agg[id] = adapter = new NEventAdapter(id) { Action = action });
          else
            adapter.Action = action;
        }
      }

      public static void AssignRoutedEvent(int id, object action, DependencyObject target, RoutedEvent routedEvent, Func<NEventAdapter, Delegate> extractor)
      {
        var agg = (Aggregator)target.GetValue(AggregatorProperty);
        if (agg == null)
          target.SetValue(AggregatorProperty, agg = new Aggregator());

        var adapter = agg[id];
        if (adapter == null)
        {
          agg[id] = adapter = new NEventAdapter(id) { Action = action };

          var handler = extractor(adapter);

          var e = target as UIElement;
          if (e != null)
            e.AddHandler(routedEvent, handler, true);
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

      public static readonly DependencyProperty AggregatorProperty = DependencyProperty.RegisterAttached("Aggregator", typeof(Aggregator), typeof(Aggregator), null);
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

      throw new NotSupportedException("Not supported event handler type: " + _event);
    }

    object _event;
    NEventAdapter _next;

    public readonly int Id;

    public NEventAdapter(int id)
    {
      Id = id;
    }

    public void EventHandlerAny<T>(object sender, T args)
    {
      {
        var e = _event as Action<object, T>;
        if (e != null) { e(sender, args); return; }
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

    public object Action
    {
      set
      {
        if (value == null || value == NDataBag.UnsetValue)
          _event = null;
        else
          _event = value;
      }
    }
  }

  public class NEventArgs : EventArgs
  {
    public NEventArgs(object original) { Original = original; }
    public object Original { get; private set; }
  }
}
