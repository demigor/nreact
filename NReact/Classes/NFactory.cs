using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
#if NETFX_CORE
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media.Animation;
using VSM = Windows.UI.Xaml.VisualStateManager;
using UIE = Windows.UI.Xaml.UIElement;
using RE = Windows.UI.Xaml.RoutedEvent;
#else
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using VSM = System.Windows.VisualStateManager;
using UIE = System.Windows.UIElement;
using RE = System.Windows.RoutedEvent;
#endif

namespace NReact
{
  using Converters;

  static class NFactory
  {
    static Dictionary<Type, Func<object>> _ctors = new Dictionary<Type, Func<object>>();
    static Dictionary<Type, Func<object, NDynamic>> _casts = new Dictionary<Type, Func<object, NDynamic>>();
    static Dictionary<MemberInfo, Action<object, object>> _setters = new Dictionary<MemberInfo, Action<object, object>>();

    static Func<object> CreateCtor(Type type)
    {
      return Expression.Lambda<Func<object>>(Expression.Convert(Expression.New(type), typeof(object))).Compile();
    }

    static Func<object, NDynamic> CreateDynamicConverter(Type type)
    {
      var t = typeof(NDynamicConverter<>).MakeGenericType(type);
      return (Func<object, NDynamic>)t.GetMethod("Cast").CreateDelegate(typeof(Func<object, NDynamic>));
    }

#if NETFX_CORE

    abstract class EventSubscriber
    {
      public EventInfo Event;
      public abstract void AddEventHandler(object instance, object callback);
      public abstract void RemoveEventHandler(object instance, object callback);
    }

    class EventSubscriber<T> : EventSubscriber
    {
      public override void AddEventHandler(object instance, object callback)
      {
        WindowsRuntimeMarshal.AddEventHandler<T>(
          (Func<T, EventRegistrationToken>)Event.AddMethod.CreateDelegate(typeof(Func<T, EventRegistrationToken>), instance),
          (Action<EventRegistrationToken>)Event.RemoveMethod.CreateDelegate(typeof(Action<EventRegistrationToken>), instance),
          (T)callback);
      }

      public override void RemoveEventHandler(object instance, object callback)
      {
        WindowsRuntimeMarshal.RemoveEventHandler<T>((Action<EventRegistrationToken>)Event.RemoveMethod.CreateDelegate(typeof(Action<EventRegistrationToken>), instance),
          (T)callback);
      }
    }

#endif
    static Action<object, object> CreateSetter(EventInfo e)
    {
#if DEBUG
      Debug.WriteLine("Making Event Setter {0}.{1} : {2}", e.DeclaringType, e.Name, e.EventHandlerType);
#endif

#if NETFX_CORE
      var es = (EventSubscriber)Create(typeof(EventSubscriber<>).MakeGenericType(e.EventHandlerType));
      es.Event = e;

      var result = (Action<object, object>)es.AddEventHandler;
#else
      var obj = Expression.Parameter(typeof(object));
      var val = Expression.Parameter(typeof(object));

      var objT = Expression.Convert(obj, e.DeclaringType);
      var valT = CallConverter(e.EventHandlerType, val);

      var result = Expression.Lambda<Action<object, object>>(Expression.Call(objT, e.GetAddMethod(), valT), obj, val).Compile();
#endif

#if DUMP
      return (a, b)
        =>
        {
          Debug.WriteLine("Subscribing {0}.{1} = {2}", a.GetType().Name, e.Name, b);
          result(a, b);
        };
#else
      return result;
#endif
    }

    static Expression CallConverter(Type type, Expression val)
    {
      return Expression.Call(typeof(NConverters).GetMethod("Convert").MakeGenericMethod(type), val);
    }

    static Action<object, object> CreateSetter(PropertyInfo p)
    {
      if (!p.CanWrite)
      {
        var x = p.PropertyType.GetIListElementType();

        if (x == null || !x.IsClass()) return null;

#if DEBUG
        Debug.WriteLine("Making List<{3}> Property Setter {0}.{1} : {2}", p.DeclaringType, p.Name, p.PropertyType, x);
#endif

        var obj = Expression.Parameter(typeof(object));
        var val = Expression.Parameter(typeof(object));

        var assignList = typeof(NConverters).GetMethod("AssignList").MakeGenericMethod(x);

        var result = Expression.Lambda<Action<object, object>>(Expression.Call(assignList, Expression.Property(Expression.Convert(obj, p.DeclaringType), p), val), obj, val).Compile();

#if DUMP
      return (a, b)
        =>
        {
          Debug.WriteLine("Setting {0}.{1} = {2}", a.GetType().Name, p.Name, b);
          result(a, b);
        };
#else
        return result;
#endif
      }
      else
      {
#if DEBUG
        Debug.WriteLine("Making Property Setter {0}.{1} : {2}", p.DeclaringType, p.Name, p.PropertyType);
#endif

        var obj = Expression.Parameter(typeof(object));
        var val = Expression.Parameter(typeof(object));

        var result = Expression.Lambda<Action<object, object>>(Expression.Assign(Expression.Property(Expression.Convert(obj, p.DeclaringType), p), CallConverter(p.PropertyType, val)), obj, val).Compile();

#if DUMP
      return (a, b)
        =>
        {
          Debug.WriteLine("Setting {0}.{1} = {2}", a.GetType().Name, p.Name, b);
          result(a, b);
        };
#else
        return result;
#endif
      }
    }

    static Action<object, object> CreateSetter(FieldInfo f)
    {
      if (f.IsInitOnly) return null;
#if DEBUG
      Debug.WriteLine("Making Field Setter {0}.{1} : {2}", f.DeclaringType, f.Name, f.FieldType);
#endif
      var obj = Expression.Parameter(typeof(object));
      var val = Expression.Parameter(typeof(object));

      return Expression.Lambda<Action<object, object>>(Expression.Assign(Expression.Field(Expression.Convert(obj, f.DeclaringType), f), CallConverter(f.FieldType, val)), obj, val).Compile();
    }

    static Action<object, object> CreateSetter(MethodInfo m)
    {
      var pars = m.GetParameters();
      if (pars.Length != 2)
        return null;

#if DEBUG
      Debug.WriteLine("Making Attached Property Setter {0}.{1} : {2}", m.DeclaringType, m.Name, pars[1].ParameterType);
#endif
      var obj = Expression.Parameter(typeof(object));
      var val = Expression.Parameter(typeof(object));

      return Expression.Lambda<Action<object, object>>(Expression.Call(m, Expression.Convert(obj, pars[0].ParameterType), CallConverter(pars[1].ParameterType, val)), obj, val).Compile();
    }

    static Action<object, object> CreateSetter(MemberInfo member)
    {
      var p = member as PropertyInfo;
      if (p != null) return CreateSetter(p);

      var e = member as EventInfo;
      if (e != null) return CreateSetter(e);

      var f = member as FieldInfo;
      if (f != null) return CreateSetter(f);

      var m = member as MethodInfo;
      if (m != null) return CreateSetter(m);

      throw new NotSupportedException();
    }

    public static void Set(MemberInfo prop, object obj, object value)
    {
      GetSetter(prop)(obj, value);
    }

    public static Action<object, object> GetSetter(MemberInfo prop)
    {
      Action<object, object> setter;

      lock (_setters)
        if (!_setters.TryGetValue(prop, out setter))
          _setters[prop] = setter = CreateSetter(prop);

      return setter;
    }

    public static Func<object, NDynamic> GetDynamicConverter(Type type)
    {
      Func<object, NDynamic> ctor;

      lock (_casts)
        if (!_casts.TryGetValue(type, out ctor))
          _casts[type] = ctor = CreateDynamicConverter(type);

      return ctor;
    }

    public static Func<object> GetCtor(Type type)
    {
      Func<object> ctor;

      lock (_ctors)
        if (!_ctors.TryGetValue(type, out ctor))
          _ctors[type] = ctor = CreateCtor(type);

      return ctor;
    }

    public static object Create(Type type)
    {
      return GetCtor(type)();
    }

    public static Action<object, object> GetSetter(Type type, string member)
    {
#if NETFX_CORE
      var p = type.GetProperty(member);
      if (p != null) return GetSetter(p);

      var e = type.GetEvent(member);
      if (e != null) return GetSetter(e);

      var f = type.GetField(member);
      if (f != null) return GetSetter(f);
#else
      var m = type.GetMember(member, MemberTypes.Event | MemberTypes.Field | MemberTypes.Property, BindingFlags.Public | BindingFlags.Instance);
      if (m.Length > 0) return GetSetter(m[0]);
#endif

      {
        var i = member.IndexOf('_');
        if (i == 0 && typeof(UIE).IsAssignableFrom(type))
        {
          switch (member)
          {
            case "_KeyDown": return (target, value) => ((UIE)target).AddHandler(UIE.KeyDownEvent, NEvents.ToKeyEventHandler(value), true);
            case "_KeyUp": return (target, value) => ((UIE)target).AddHandler(UIE.KeyUpEvent, NEvents.ToKeyEventHandler(value), true);
#if NETFX_CORE
            case "_PointerCanceled": return (target, value) => ((UIE)target).AddHandler(UIE.PointerCanceledEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerCaptureLost": return (target, value) => ((UIE)target).AddHandler(UIE.PointerCaptureLostEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerEntered": return (target, value) => ((UIE)target).AddHandler(UIE.PointerEnteredEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerExited": return (target, value) => ((UIE)target).AddHandler(UIE.PointerExitedEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerMoved": return (target, value) => ((UIE)target).AddHandler(UIE.PointerMovedEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerPressed": return (target, value) => ((UIE)target).AddHandler(UIE.PointerPressedEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerReleased": return (target, value) => ((UIE)target).AddHandler(UIE.PointerReleasedEvent, NEvents.ToPointerEventHandler(value), true);
            case "_PointerWheelChanged": return (target, value) => ((UIE)target).AddHandler(UIE.PointerWheelChangedEvent, NEvents.ToPointerEventHandler(value), true);
#else
            case "_MouseLeftButtonDown": return (target, value) => ((UIE)target).AddHandler(UIE.MouseLeftButtonDownEvent, NEvents.ToMouseButtonEventHandler(value), true);
            case "_MouseLeftButtonUp": return (target, value) => ((UIE)target).AddHandler(UIE.MouseLeftButtonUpEvent, NEvents.ToMouseButtonEventHandler(value), true);
            case "_MouseRightButtonDown": return (target, value) => ((UIE)target).AddHandler(UIE.MouseRightButtonDownEvent, NEvents.ToMouseButtonEventHandler(value), true);
            case "_MouseRightButtonUp": return (target, value) => ((UIE)target).AddHandler(UIE.MouseRightButtonUpEvent, NEvents.ToMouseButtonEventHandler(value), true);
#endif
          }
        }
        else if (i > 0)
        {
          var at = GetAttachedType(member.Substring(0, i));
          if (at != null)
          {
            var name = member.Substring(i + 1);
            var dpSetter = at.GetMethod("Set" + name);//, BindingFlags.Static | BindingFlags.Public);

            if (dpSetter != null)
              return GetSetter(dpSetter);
          }
        }
      }

#if DEBUG
      Debug.WriteLine("Failed to retrieve {0}.{1} member", type.Name, member);
#endif

      return null;
    }

    static Type GetAttachedType(string name)
    {
      switch (name)
      {
        case "Grid": return typeof(Grid);
        case "Canvas": return typeof(Canvas);
        case "Typography": return typeof(Typography);
        case "Storyboard": return typeof(Storyboard);
        case "VisualStateManager": return typeof(VSM);
#if !NETFX_CORE
        case "TextOptions": return typeof(TextOptions);
#endif
        default: return null;
      }
    }

    public static NDynamic ToDynamic(object obj)
    {
      if (obj == null) return null;
      var d = obj as NDynamic;
      if (d != null) return d;

      var c = GetDynamicConverter(obj.GetType());
      return c(obj);
    }
  }
}
