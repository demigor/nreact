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
  /// <summary>
  /// Represents named property key and its possible usage on different types
  /// </summary>
  public class NProperty
  {
    /// <summary>
    /// Constructs property with specified name 
    /// </summary>
    /// <param name="name"></param>
    public NProperty(string name)
    {
      Name = name;
    }

    /// <summary>
    /// Indicates name of the property
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// Returns string representation
    /// </summary>
    public override string ToString()
    {
      return Name;
    }

    /// <summary>
    /// Returns usage delegate for specified type
    /// </summary>
    /// <param name="type">Type to apply property values to</param>
    /// <returns>Usage delegate compatible with specified type</returns>
    public Action<object, object> this[Type type] { get { return _items[type]; } }
    NTypedBag<Action<object, object>> _items;

    /// <summary>
    /// Defines property support for a type 
    /// </summary>
    /// <param name="type">Type to support</param>
    /// <param name="setter">Supporting usage delegate</param>
    /// <returns>This instance to chain supports</returns>
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
