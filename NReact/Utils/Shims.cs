using System;
#if NETFX_CORE || XFORMS
using System.Reflection;
#endif
#if NETFX_CORE 
using Windows.UI.Core;
#endif

namespace NReact
{
  static class Shims
  {
#if NETFX_CORE || XFORMS
    public static bool IsSubclassOf(this Type type, Type check)
    {
      return type.GetTypeInfo().IsSubclassOf(check);
    }
#endif

#if NETFX_CORE 
    public static bool CheckAccess(this CoreDispatcher dispatcher) 
    {
      return dispatcher.HasThreadAccess;
    }

    public static void BeginInvoke<T>(this CoreDispatcher dispatcher, Action<T> action, T arg) 
    {
#pragma warning disable CS4014
      dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action(arg));
#pragma warning restore CS4014
    }
#endif
  }
}
