using System;
using E = System.Linq.Expressions.Expression;

namespace NReact
{
  static class Ctor<T>
  {
#if NO_EMIT
    public static readonly Func<T> New = Activator.CreateInstance<T>;
#else
    public static readonly Func<T> New = E.Lambda<Func<T>>(E.New(typeof(T))).Compile();
#endif
  }
}
