using System;
using System.Diagnostics;

namespace NReact
{
  /// <summary>
  /// Base NReact element class
  /// </summary>
  public abstract partial class NElement
  {
    /// <summary>
    /// Indicates key of the NElement
    /// </summary>
    public object Key { get { return _key; } }
    internal object _key;

    internal Action<object> _refCallback;

    /// <summary>
    /// Specifies comparable type of the NReact element
    /// </summary>
    public abstract Type GetXamlType();

    internal abstract object CreateXaml();

    internal object Create()
    {
      var result = InitXaml(CreateXaml());
      _refCallback?.Invoke(result); // Register xaml element reference if delegate specified
      return result;
    }

#if DROID
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    internal Android.Content.Context Context = CurrentContext;

    [ThreadStatic]
    internal static Android.Content.Context CurrentContext;

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public static Android.Content.Context SetCurrentContext(Android.Content.Context ctx)
    {
      var result = CurrentContext;
      CurrentContext = ctx;
      return result;
    }
#endif

    internal virtual object InitXaml(object target)
    {
      var type = target.GetType();

      for (var i = _props.Head; i != null; i = i.Next)
      {
        var setter = i.Key[type];
        if (setter != null)
          setter(target, i._value);
        else
          Debug.WriteLine($"Warning: Property {type}.{i.Key.Name} is not supported (1)");
      }

      return target;
    }

    /// <summary>
    /// Returns string representation of the element
    /// </summary>
    public override string ToString()
    {
      return $"<{GetXamlType().Name}{_props}/>";
    }

    #region NElement Props Methods

    internal virtual NPropertyBag GetCommittedProps()
    {
      return _props;
    }

    internal NPropertyBag _props;

    /// <summary>
    /// Property getter 
    /// </summary>
    /// <typeparam name="T">Type of the property</typeparam>
    /// <param name="key">Property key</param>
    /// <param name="default">Default value in case the property is not set</param>
    /// <returns>Property value of @default in case the property is not set</returns>
    public T Get<T>(NProperty key, T @default)
    {
      return _props.Get(key, @default);
    }

    /// <summary>
    /// Property setter
    /// </summary>
    /// <param name="prop">Property key</param>
    /// <param name="value">Property value</param>
    /// <returns>This instance for setter chaining</returns>
    public NElement Set(NProperty prop, object value)
    {
      SetProp(prop, value);
      return this;
    }

    /// <summary>
    /// Property cleaner
    /// </summary>
    /// <param name="prop">Property key</param>
    /// <returns>This instance for setter chaining</returns>
    public NElement Unset(NProperty prop)
    {
      UnsetProp(prop);
      return this;
    }

    internal virtual void Free()
    {
      for (var i = _props.Head; i != null; i = i.Next)
        NPatch.Finalize(i._value);
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
        SetProp(i.Key, i._value, silent);
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
          SetProp(i.Key, i._value, false);

      return this;
    }


    #region Patching Indicators

    protected internal void BeginPatching() { _isPatching = true; _patchingDepth++; }
    protected internal void EndPatching() { _isPatching = false; _patchingDepth--; }

    /// <summary>
    /// Indicates whether this instance undergoes property patching
    /// </summary>
    protected bool IsPatching => _isPatching;
    bool _isPatching;

    protected static bool IsPatchingInProgress = _patchingDepth > 0;
    static int _patchingDepth = 0;

    protected static bool IsElementPatching(NElement element) => element._isPatching;

    #endregion
    #endregion
  }
}
