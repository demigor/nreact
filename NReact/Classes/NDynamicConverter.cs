using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace NReact
{
  static class NDynamicConverter<T> where T : class
  {
    static readonly Func<T, NDynamic> _ctor = CreateCtor();

    static Func<T, NDynamic> CreateCtor()
    {
      var source = Expression.Parameter(typeof(T));

      var stmts = new List<Expression>();

      var result = Expression.Variable(typeof(NDynamic));
      var assign = Expression.Assign(result, Expression.New(typeof(NDynamic)));

      stmts.Add(assign);

      var addMethod = typeof(NDynamic).GetNonPublicMethod("Add");

      var props = typeof(T).GetProperties();

      for (int i = 0, c = props.Length; i < c; i++)
      {
        var prop = props[i];

        if (!prop.CanRead) continue;
        if (prop.GetIndexParameters().Length != 0) continue;

        stmts.Add(Expression.Call(result, addMethod, Expression.Constant(prop.Name), Expression.Convert(Expression.Property(source, prop), typeof(object))));
      }

      stmts.Add(result);

      return Expression.Lambda<Func<T, NDynamic>>(Expression.Block(new[] { result }, stmts), source).Compile();
    }

    static Func<T, object> CreateGetter(PropertyInfo prop)
    {
      var obj = Expression.Parameter(typeof(T));
      var call = Expression.Convert(Expression.Property(obj, prop), typeof(object));
      var lambda = Expression.Lambda<Func<T, object>>(call, obj);
      return lambda.Compile();
    }

    public static NDynamic Cast(object source)
    {
      return Convert((T)source);
    }

    public static NDynamic Convert(T source)
    {
      return source == null ? null : _ctor(source);
    }
  }

}
