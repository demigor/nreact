using System;
using System.Diagnostics;

namespace NReact
{
  public abstract partial class NElement
  {
    public object Key { get { return _key; } }
    internal object _key;

    internal Action<object> _refCallback;

    /// <summary>
    /// Indicates Xaml Type of the element
    /// </summary>
    public abstract Type GetXamlType();

    protected abstract object CreateXaml();

    internal object Create()
    {
      var result = InitXaml(CreateXaml());
      _refCallback?.Invoke(result); // Register xaml element reference if delegate specified
      return result;
    }

    protected virtual object InitXaml(object target)
    {
      var type = target.GetType();

      for (var i = _props.Head; i != null; i = i.Next)
      {
        var setter = i.Key[type];
        if (setter != null)
          setter(target, i.Value);
        else
          Debug.WriteLine($"Warning: Property {type}.{i.Key.Name} is not supported (1)");
      }

      return target;
    }

    public override string ToString()
    {
      return $"<{GetXamlType().Name} {_props}/>";
    }

    #region NElement Props Methods

    internal virtual NPropertyBag GetCommittedProps()
    {
      return _props;
    }

    internal NPropertyBag _props;

    public T Get<T>(NProperty key, T @default)
    {
      return _props.Get(key, @default);
    }

    public NElement Set(NProperty prop, object value)
    {
      SetProp(prop, value);
      return this;
    }

    public NElement Unset(NProperty prop)
    {
      UnsetProp(prop);
      return this;
    }

    internal virtual void Free()
    {
      for (var i = _props.Head; i != null; i = i.Next)
        NPatch.Finalize(i.Value);
    }

    internal virtual void SetProp(NProperty key, object value, bool silent = false)
    {
      _props.Set(key, value);
    }

    internal virtual void UnsetProp(NProperty key, bool silent = false)
    {
      _props.Remove(key);
    }

    internal void AssignProps(NElement source, bool silent)
    {
      for (var i = _props.Head; i != null; i = i.Next)
        if (!source._props.HasKey(i.Key))
          UnsetProp(i.Key, silent);

      for (var i = source._props.Head; i != null; i = i.Next)
        SetProp(i.Key, i.Value, silent);
    }

    public virtual NElement AssignProps(NElement source)
    {
      AssignProps(source, false);

      return this;
    }

    public virtual NElement AssignPropsExcluding(NElement source, params NProperty[] exclude)
    {
      for (var i = source._props.Head; i != null; i = i.Next)
        if (Array.IndexOf(exclude, i.Key) < 0)
          SetProp(i.Key, i.Value, false);

      return this;
    }

    #endregion
  }
}
