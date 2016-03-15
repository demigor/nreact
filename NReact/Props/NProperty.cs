using System;
using System.Collections;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact
{
  public class NProperty
  {
    public NProperty(string name)
    {
      Name = name;
    }

    public readonly string Name;

    public override string ToString()
    {
      return Name;
    }

    public Action<object, object> this[Type type] { get { return _items[type]; } }
    NTypedBag<Action<object, object>> _items;

    public NProperty Support(Type type, Action<object, object> setter)
    {
      _items[type] = setter;
      return this;
    }

    public NProperty List<T>(Func<T, IList> getter/*, Action<T, IList> setter = null*/)
    {
      return Support(typeof(T), (t, v) => NPatch.AssignList(getter((T)t), v));
    }

    public NProperty Property<T>(Action<T, object> setter)
    {
      return Support(typeof(T), (t, v) => setter((T)t, v));
    }

    public NProperty Property<T>(DependencyProperty property, Func<object, object> converter = null) where T : DependencyObject
    {
      return Support(typeof(T), (t, v) => NPatch.AssignSingle((DependencyObject)t, v, property, converter));
    }

    public NProperty Event<T>(Action<T, NEventAdapter> subscribe) where T : DependencyObject
    {
      return Support(typeof(T), (t, v) => NEventAggregator.AssignEvent(this, v, (T)t, subscribe));
    }

    public NProperty Event<T>(RoutedEvent routedEvent, Func<NEventAdapter, Delegate> extractor) where T : DependencyObject
    {
      return Support(typeof(T), (t, v) => NEventAggregator.AssignEvent(this, v, (DependencyObject)t, routedEvent, extractor));
    }
  }
}
