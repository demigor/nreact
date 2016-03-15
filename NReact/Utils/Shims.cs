using System;
#if NETFX_CORE
using System.Reflection;
#endif

namespace NReact
{
  static class Shims
  {
#if NETFX_CORE
    public static bool IsAssignableFrom(this Type type, Type check)
    {
      return type.GetTypeInfo().IsAssignableFrom(check.GetTypeInfo());
    }
#endif
  }
}
