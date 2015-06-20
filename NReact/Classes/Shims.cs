using System;
using System.Linq;
using System.Reflection;

namespace NReact
{
  static class Shims
  {
#if NETFX_CORE
    public static PropertyInfo[] GetProperties(this Type type)
    {
      return type.GetRuntimeProperties().ToArray();
    }

    public static PropertyInfo GetProperty(this Type type, string name)
    {
      return type.GetRuntimeProperty(name);
    }

    public static EventInfo GetEvent(this Type type, string name)
    {
      return type.GetRuntimeEvent(name);
    }

    public static FieldInfo GetField(this Type type, string name)
    {
      return type.GetRuntimeField(name);
    }

    public static MethodInfo GetMethod(this Type type, string name)
    {
      return type.GetTypeInfo().GetDeclaredMethod(name);
    }

    public static MethodInfo GetNonPublicMethod(this Type type, string name)
    {
      return type.GetMethod(name);
    }

    public static bool IsAssignableFrom(this Type type, Type fromType)
    {
      return type.GetTypeInfo().IsAssignableFrom(fromType.GetTypeInfo());
    }

    public static bool IsEnum(this Type type) 
    {
      return type.GetTypeInfo().IsEnum;
    }
#else
    public static bool IsEnum(this Type type)
    {
      return type.IsEnum;
    }

    public static MethodInfo GetNonPublicMethod(this Type type, string name)
    {
      return type.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
    }

#if SILVERLIGHT

#else
    public static Delegate CreateDelegate(this MethodInfo method, Type delegateType) 
    {
      return Delegate.CreateDelegate(delegateType, method);
    }
#endif

#endif
  }
}
