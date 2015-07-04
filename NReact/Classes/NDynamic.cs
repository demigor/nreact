using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
#if NETFX_CORE
using DepProperty = Windows.UI.Xaml.DependencyProperty;
#else
using DepProperty = System.Windows.DependencyProperty;
#endif

namespace NReact
{
  public interface IKeyNameValue
  {
    int Key { get; }
    string Name { get; }
    object Value { get; }
  }

  [DebuggerDisplay("{ToDebugString()}")]
  public class NDynamic : IDynamicMetaObjectProvider
  {
    #region Key/Name Registration

    static readonly Dictionary<string, int> _keys = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    static readonly List<string> _names = new List<string>();

    internal static int GetKey(string name)
    {
      int result;

      lock (_keys)
        if (!_keys.TryGetValue(name, out result))
        {
          _keys[name] = result = _keys.Count;
          _names.Add(name);
        }

      return result;
    }

    internal static string GetName(int key)
    {
      lock (_keys)
        return _names[key];
    }

    #endregion

    /// <summary>
    /// Represents a value with no properties. This field is constant.
    /// </summary>
    public static readonly NDynamic Empty = new NDynamic().Seal();

#if DEBUG
    internal string ToDebugString()
    {
      return string.Join(", ", GetContent().Select(i => string.Format("{0} = {1}", i.Name, i.Value)));
    }
#endif

    public IEnumerable<IKeyNameValue> GetContent()
    {
      for (var i = Head; i != null; i = i.Next)
        yield return i;
    }

    internal class Entry : IKeyNameValue
    {
      public Entry Next;
      public int Key;
      public object Value;
      public string Name { get { return GetName(Key); } }
      int IKeyNameValue.Key { get { return Key; } }
      object IKeyNameValue.Value { get { return Value; } }
    }

    internal Entry Head;
    bool _sealed;

    /// <summary>
    /// Seals the container, disabling updates.
    /// </summary>
    /// <returns>Returns itself.</returns>
    public NDynamic Seal()
    {
      _sealed = true;
      return this;
    }
    internal NDynamic Unseal()
    {
      _sealed = false;
      return this;
    }

    void CheckWriteAccess()
    {
      if (_sealed)
        throw new InvalidOperationException();
    }

    public bool HasProperty(string name)
    {
      var key = GetKey(name);

      for (var i = Head; i != null; i = i.Next)
        if (i.Key == key)
          return true;

      return false;
    }

    internal object GetByKey(int key)
    {
      for (var i = Head; i != null; i = i.Next)
        if (i.Key == key)
          return i.Value;

      throw new MemberAccessException(GetName(key));
    }

    internal object TryGetByKey(int key)
    {
      for (var i = Head; i != null; i = i.Next)
        if (i.Key == key)
          return i.Value;

      return null;
    }

    internal object SetByKey(int key, object value)
    {
      CheckWriteAccess();

      for (var i = Head; i != null; i = i.Next)
        if (i.Key == key)
        {
          i.Value = value;
          return value;
        }

      Head = new Entry { Key = key, Value = value, Next = Head };
      return value;
    }

    internal bool RemoveByKey(int key, out object result)
    {
      CheckWriteAccess();

      var prev = default(Entry);

      for (var i = Head; i != null; i = i.Next)
      {
        if (i.Key == key)
        {
          if (prev == null)
            Head = i.Next;
          else
            prev.Next = i.Next;

          result = i.Value;
          return true;
        }
        prev = i;
      }

      result = null;
      return false;
    }

    /// <summary>
    /// Clones the content of source container.
    /// </summary>
    /// <param name="source">Container to clone.</param>
    /// <returns>A shallow copy of the source container.</returns>
    public static NDynamic Clone(NDynamic source)
    {
      if (source == null)
        return new NDynamic();

      var first = default(Entry);
      var last = default(Entry);

      for (var i = source.Head; i != null; i = i.Next)
      {
        var copy = new Entry { Key = i.Key, Value = i.Value };

        if (last != null)
          last.Next = copy;
        else
          first = copy;

        last = copy;
      }

      return new NDynamic { Head = first };
    }

    internal void Insert(Entry value)
    {
      value.Next = Head;
      Head = value;
    }

    internal void Add(string name, object value)
    {
      Insert(new Entry { Key = GetKey(name), Value = value });
    }

    /// <summary>
    /// Merges properties from two containers, replacing duplicates with values from the right container.
    /// </summary>
    /// <param name="left">Left side container (old state).</param>
    /// <param name="right">Right side container (new state).</param>
    /// <returns>A shallow copy of left and right containers, containing both values.</returns>
    public static NDynamic operator +(NDynamic left, NDynamic right)
    {
      if (left == null)
        return Clone(right);

      left = Clone(left);

      if (right != null)
        left.Merge(right);

      return left;
    }

    void Merge(NDynamic source)
    {
      var first = Head;

      for (var i = source.Head; i != null; i = i.Next)
      {
        var found = false;

        for (var j = first; j != null; j = j.Next)
        {
          if (j.Key == i.Key)
          {
            found = true;
            j.Value = i.Value;
            break;
          }
        }

        if (!found)
          Head = new Entry { Next = Head, Key = i.Key, Value = i.Value };
      }
    }

    /// <summary>
    /// Compares properties from two containers, removing same values and unsetting missing values
    /// </summary>
    /// <param name="left">Left side container (old state).</param>
    /// <param name="right">Right side container (new state).</param>
    /// <returns>A shallow difference of left and right containers, containing different values.</returns>
    public static NDynamic Diff(NDynamic left, NDynamic right)
    {
      var oldHead = left.Head;
      var newHead = right.Head;

      var result = new NDynamic();

      for (var i = oldHead; i != null; i = i.Next)
      {
        var unset = true;

        for (var j = newHead; j != null; j = j.Next)
        {
          if (j.Key == i.Key)
          {
            unset = false;
            break;
          }
        }

        if (unset)
          result.Insert(new Entry { Key = i.Key, Value = DepProperty.UnsetValue });
      }

      for (var i = newHead; i != null; i = i.Next)
      {
        var set = true;

        for (var j = oldHead; j != null; j = j.Next)
        {
          if (j.Key == i.Key)
          {
            if (Equals(i.Value, j.Value))
              set = false;

            break;
          }
        }

        if (set)
          result.Insert(new Entry { Key = i.Key, Value = i.Value });
      }

#if DUMP
      Debug.WriteLine("LEFT: " + left.ToDebugString());
      Debug.WriteLine("RIGHT: " + right.ToDebugString());
      Debug.WriteLine("RESULT: " + result.ToDebugString());
#endif

      return result;
    }

    /// <summary>
    /// Indicates whether container is empty
    /// </summary>
    public bool IsEmpty { get { return Head == null; } }

    /// <summary>
    /// Indicates whether container is sealed
    /// </summary>
    public bool IsSealed { get { return _sealed; } }

    /// <summary>
    /// Name/Value access to container properties
    /// </summary>
    public object this[string name]
    {
      get
      {
        try
        {
          return GetByKey(GetKey(name));
        }
        catch (MemberAccessException)
        {
          throw new MemberAccessException(string.Format("No property {0} defined.", name));
        }
      }
      set
      {
        SetByKey(GetKey(name), value);
      }
    }

    DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
    {
      return new MetaObject(parameter, this);
    }

    class MetaObject : DynamicMetaObject
    {
      public MetaObject(Expression expr, NDynamic source)
        : base(expr, BindingRestrictions.Empty, source)
      {
      }

      static MethodInfo _getByKey = typeof(NDynamic).GetNonPublicMethod("GetByKey");
      static MethodInfo _setByKey = typeof(NDynamic).GetNonPublicMethod("SetByKey");

      public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
      {
        var getter = Expression.Call(Expression.Convert(Expression, typeof(NDynamic)), _getByKey, Expression.Constant(GetKey(binder.Name)));
        return new DynamicMetaObject(getter, BindingRestrictions.GetTypeRestriction(Expression, LimitType));
      }

      public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
      {
        var setter = Expression.Call(Expression.Convert(Expression, typeof(NDynamic)), _setByKey, Expression.Constant(GetKey(binder.Name)), value.Expression);// Expression.Constant(value.Value));
        return new DynamicMetaObject(setter, BindingRestrictions.GetTypeRestriction(Expression, LimitType));
      }

      public override IEnumerable<string> GetDynamicMemberNames()
      {
        for (var i = ((NDynamic)Value).Head; i != null; i = i.Next)
          yield return GetName(i.Key);
      }
    }
  }
}
