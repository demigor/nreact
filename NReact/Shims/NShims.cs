using System;
using System.Reflection;

namespace NReact
{
  static class NShims
  {
#if NETFX_CORE
    public static bool IsAssignableFrom(this Type type, Type target) 
    {
      return type.GetTypeInfo().IsAssignableFrom(target.GetTypeInfo());
    }

    public static MethodInfo GetInstanceMethod(this Type type, string name, params Type[] args)
    {
      return type.GetRuntimeMethod(name, args);
    }

    public static object GetStaticFieldValue(this Type type, string name)
    {
      return type.GetRuntimeField(name).GetValue(null);
    }
#else
    public static MethodInfo GetInstanceMethod(this Type type, string name, params Type[] args)
    {
      return type.GetMethod(name, args);
    }

    public static object GetStaticFieldValue(this Type type, string name)
    {
      return type.GetField(name, BindingFlags.Static | BindingFlags.Public).GetValue(null);
    }
#endif

    public static void EnsureCapacity<T>(ref T[] array, int idx, int factor = 4)
    {
      if (array == null || array.Length <= idx)
        Array.Resize(ref array, ((idx + (2 << factor) - 1) >> factor) << factor);
    }
  }
}
