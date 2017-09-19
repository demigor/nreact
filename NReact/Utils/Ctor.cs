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

#if DROID
  static class CtxCtor<T>
  {
    public static readonly Func<Android.Content.Context, T> New = CreateCtxCtor();

    static Func<Android.Content.Context, T> CreateCtxCtor()
    {
      var ctr = typeof(T).GetConstructor(new[] { typeof(Android.Content.Context) });
      if (ctr == null) return null;
      var ctx = E.Parameter(typeof(Android.Content.Context));
      return E.Lambda<Func<Android.Content.Context, T>>(E.New(ctr, ctx), ctx).Compile();
    }
  }
#endif
}
