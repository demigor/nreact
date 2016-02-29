using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NReact
{
  class NClassData : IDynamicMetaObjectProvider
  {
    public bool Dirty { get { return New != Old; } }

    internal NDataBag Old, New;

    public object GetMember(int key)
    {
      return New.Get(key);
    }

    public T Get<T>(int key, T @default)
    {
      return New.Get(key, @default);
    }

    public bool Set(int key, object value)
    {
      var result = !Dirty;
      New = New.Set(key, value);
      return result;
    }

    public object SetMember(int key, object value)
    {
      Set(key, value);
      return value;
    }

    public bool Set(NDataBag value)
    {
      var result = !Dirty;
      New = value;
      return result;
    }

    public void Commit()
    {
      if (Dirty)
      {
        Old = New.Seal();
        New = Old;
      }
    }

    DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
    {
      return new NClassDataMetaObject(this, parameter);
    }

    internal IEnumerable<string> GetKeys()
    {
      for (var i = New; i != null; i = i.Next)
        yield return (string)NConverters.ToString(i.Key);
    }
  }

  class NClassDataMetaObject : DynamicMetaObject
  {
    static readonly MethodInfo Getter = typeof(NClassData).GetInstanceMethod("GetMember", typeof(int));
    static readonly MethodInfo Setter = typeof(NClassData).GetInstanceMethod("SetMember", typeof(int), typeof(object));

    public NClassDataMetaObject(NClassData bag, Expression parameter) : base(parameter, BindingRestrictions.Empty, bag) { }

    public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
    {
      var key = NProps.Store[binder.Name];
      var expr = Expression.Convert(Expression.Call(Self(), Getter, Expression.Constant(key)), binder.ReturnType);
      return new DynamicMetaObject(expr, BindingRestrictions.GetTypeRestriction(Expression, LimitType));
    }

    public override IEnumerable<string> GetDynamicMemberNames()
    {
      return ((NClassData)Value).GetKeys().Distinct();
    }

    Expression Self()
    {
      return Expression.Convert(Expression, typeof(NClassData));
    }

    public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
    {
      var key = NProps.Store[binder.Name];
      var expr = Expression.Call(Self(), Setter, Expression.Constant(key), Expression.Convert(value.Expression, typeof(object)));
      return new DynamicMetaObject(expr, BindingRestrictions.GetTypeRestriction(Expression, LimitType));
    }
  }
}
