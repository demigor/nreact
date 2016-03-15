using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
#if NETFX_CORE
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
#else
using System.Windows;
using System.Windows.Threading;
#endif

namespace NReact
{
  partial class NPatch
  {
    /// <summary>
    /// Assigns value to a dependency property 
    /// </summary>
    public static void AssignSingle(DependencyObject target, object value, DependencyProperty property, Func<object, object> converter = null)
    {
      #region NPatch assignment

      var p = value as NPatch;
      if (p != null)
      {
        var oldValue = target.GetValue(property);
        value = p.Apply(oldValue);

        if (!ReferenceEquals(value, oldValue))
          target.SetValue(property, value);

        return;
      }

      #endregion

      #region UnsetValue assignment

      if (IsUnsetValue(value))
      {
        target.ClearValue(property);
        return;
      }

      #endregion

      #region NElement assignment

      var e = value as NElement;
      if (e != null)
      {
        target.SetValue(property, e.Create());
        return;
      }

      #endregion

      #region NElement[] assignment

      var ea = value as NElement[];
      if (ea != null)
      {
        if (ea.Length == 0)
          target.ClearValue(property);
        else
          target.SetValue(property, ea[0].Create());

        return;
      }

      #endregion

      if (converter != null)
        value = converter(value);

      target.SetValue(property, value);
    }

    /// <summary>
    /// Assigns value to a plain property
    /// </summary>
    public static void AssignSingle<T, K>(Func<T, K> getter, Action<T, K> setter, T target, object value)
    {
      #region NPatch assignment

      var p = value as NPatch;
      if (p != null)
      {
        var oldValue = getter(target);
        value = p.Apply(oldValue);

        if (ReferenceEquals(oldValue, value))
          return;

        goto set;
      }

      #endregion

      #region UnsetValue assignment

      if (IsUnsetValue(value))
      {
        setter(target, default(K));
        return;
      }

      #endregion

      #region NElement assignment

      var e = value as NElement;
      if (e != null)
      {
        value = e.Create();
        goto set;
      }

      #endregion

      #region NElement[] assignment

      var ea = value as NElement[];
      if (ea != null)
      {
        if (ea.Length == 0)
          value = null;
        else
          value = ea[0].Create();

        goto set;
      }

      #endregion

      set:
      setter(target, (K)value);
    }

    /// <summary>
    /// Assigns value to a IList<T> property
    /// </summary>
    public static void AssignListT<T>(IList<T> list, object value)
    {
      #region NListPatch assignment
      {
        var patch = value as NListPatch;
        if (patch != null)
        {
          patch.Apply(list);
          return;
        }
      }
      #endregion

      #region NPatch assignment
      {
        var patch = value as NPatch;
        if (patch != null)
        {
          var result = patch.Apply(list);
#if DEBUG
          if (!ReferenceEquals(result, list))
            throw new InvalidOperationException("NPatch attempted to replace underlying list instance");
#endif
          return;
        }
      }
      #endregion

      #region UnsetValue assignment

      if (IsUnsetValue(value))
      {
        list.Clear();
        return;
      }

      #endregion

      #region NElement[] assignment
      {
        var items = value as NElement[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
          {
            var item = items[i].Create();
            list.Add((T)item);
          }

          return;
        }
      }
      #endregion

      #region NElement assignment
      {
        var item = value as NElement;
        if (item != null)
        {
          list.Clear();
          list.Add((T)item.Create());

          return;
        }
      }
      #endregion

      #region object[] assignment
      {
        var items = value as object[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
            list.Add((T)Create(items[i]));

          return;
        }
      }
      #endregion

      #region IList assignment
      {
        var items = value as IList<T>;
        if (items != null)
        {
          list.Clear();
          for (var i = 0; i < items.Count; i++)
            list.Add(items[i]);

          return;
        }
      }
      #endregion

      Debug.WriteLine($"Unsupported attempt to assign IList<{typeof(T).Name}> property with {value} value");
    }

    /// <summary>
    /// Assigns value to a IList property
    /// </summary>
    /// <param name="list"></param>
    /// <param name="value"></param>
    public static void AssignList(IList list, object value)
    {
      #region NPatch assignment

      var patch = value as NPatch;
      if (patch != null)
      {
        var result = patch.Apply(list);
#if DEBUG
        if (!ReferenceEquals(result, list))
          throw new InvalidOperationException("NPatch attempted to replace underlying list instance");
#endif
        return;
      }

      #endregion

      #region UnsetValue assignment

      if (IsUnsetValue(value))
      {
        list.Clear();
        return;
      }

      #endregion

      #region NElement[] assignment
      {
        var items = value as NElement[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
            list.Add(items[i].Create());

          return;
        }
      }
      #endregion

      #region NElement assignment
      {
        var item = value as NElement;
        if (item != null)
        {
          list.Clear();
          list.Add(item.Create());
          return;
        }
      }
      #endregion

      #region object[] assignment
      {
        var items = value as object[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
            list.Add(Create(items[i]));

          return;
        }
      }
      #endregion

      #region IList assignment
      {
        var items = value as IList;
        if (items != null)
        {
          list.Clear();
          for (var i = 0; i < items.Count; i++)
            list.Add(Create(items[i]));

          return;
        }
      }
      #endregion

      Debug.WriteLine($"Unsupported attempt to assign IList property with {value} value");
    }

    protected static object Create(object obj)
    {
      var e = obj as NElement;
      return e != null ? e.Create() : obj;
    }

    static bool IsUnsetValue(object value)
    {
      return ReferenceEquals(value, DependencyProperty.UnsetValue);
    }

#if NETFX_CORE
    static CoreDispatcher Dispatcher;
#else
    static Dispatcher Dispatcher;
#endif

    static NPatch()
    {
      InitDispatcher();
    }

    public static void InitDispatcher()
    {
#if NETFX_CORE
      Dispatcher = CoreApplication.MainView?.CoreWindow?.Dispatcher;
#elif SILVERLIGHT
      Dispatcher = Deployment.Current?.Dispatcher;
#else
      Dispatcher = Application.Current?.Dispatcher;
#endif
    }

    internal static void OnUIThread<T>(T arg, Action<T> action)
    {
      var d = Dispatcher;

#if NETFX_CORE
      if (d.HasThreadAccess)
        action(arg);
      else
#pragma warning disable CS4014
        d.RunAsync(CoreDispatcherPriority.Normal, () => action(arg));
#pragma warning restore CS4014
#else
      if (d.CheckAccess())
        action(arg);
      else
        d.BeginInvoke(action, arg);
#endif
    }

  }
}
