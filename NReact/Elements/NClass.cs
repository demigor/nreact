using System;
using System.Diagnostics;
using static NReact.NFactory;
#if NETFX_CORE
using Windows.UI.Xaml.Controls;
#else
using System.Windows.Controls;
#endif

namespace NReact
{
  public abstract class NClass : NElement
  {
    bool _dirty, _force;
    NPropertyBag _state, _stateCommitted, _propsCommitted;

    internal override NPropertyBag GetCommittedProps()
    {
      return _propsCommitted;
    }

    protected sealed override object CreateXaml()
    {
      if (_xaml == null)
        Xaml = RenderInitial().Create();

      return _xaml;
    }

    protected override object InitXaml(object target)
    {
      return target;
    }

    internal NPatch Upgrade(NClass newVersion)
    {
      AssignProps(newVersion, true);
      return Diff();
    }

    public override Type GetXamlType()
    {
      return GetType();
    }

    #region Patching Indicators

    internal void BeginPatching()
    {
      _isPatching = true;
    }

    internal void EndPatching()
    {
      _isPatching = false;
    }

    protected bool IsPatching { get { return _isPatching; } }
    bool _isPatching;

    #endregion

    protected T GetState<T>(NProperty key, T @default)
    {
      return _state.Get(key, @default);
    }

    protected void SetState(NProperty key, object value)
    {
      if (_xaml != null && !_dirty)
      {
        if (Set(ref _state, key, value))
          Update(false);
      }
      else
        _state.Set(key, value);
    }

    static bool Set(ref NPropertyBag head, NProperty key, object value)
    {
      var e = head.GetEntry(key);
      if (e != null && Equals(e.Value, value))
        return false; // value not changed -> do nothing

      head = head.Clone();
      head.Set(key, value);

      return true;
    }

    static bool Unset(ref NPropertyBag head, NProperty key)
    {
      var e = head.GetEntry(key);
      if (e == null)
        return false; // value not changed -> do nothing

      head = head.Clone();
      head.Remove(key);
      return true;
    }

    internal override void SetProp(NProperty key, object value, bool silent)
    {
      if (_xaml != null && !_dirty)
      {
        if (Set(ref _props, key, value))
          Update(silent);
      }
      else
        _props.Set(key, value);
    }

    internal override void UnsetProp(NProperty key, bool silent)
    {
      if (_xaml != null && !_dirty)
      {
        if (Unset(ref _props, key))
          Update(silent);
      }
      else
        _props.Remove(key);
    }

    void Update(bool enqueue)
    {
      if (_dirty) return;
      _dirty = true;

      if (!enqueue && _xaml != null)
        NDispatcher.Default.Enqueue(this);
    }

    public void ForceUpdate()
    {
      _force = true;
      Update(false);
    }

    void Commit()
    {
      _dirty = false;
      _force = false;
      _stateCommitted = _state;
      _propsCommitted = _props;
    }

    protected virtual void InitState() { }

    public abstract NElement Render();

    public NElement RenderInitial()
    {
      if (_ui == null)
      {
        InitState();
        Commit();
        _ui = RenderUI();
      }

      return _ui;
    }
    internal NElement _ui;

    NElement RenderUI()
    {
      var save = SetCurrentOwner(Owner);
      try
      {
        return AssignAttachedProps(Render());
      }
      finally
      {
        SetCurrentOwner(save);
      }
    }

    NElement AssignAttachedProps(NElement result)
    {
      if (result == null)
        result = new NXaml<StackPanel>();

      for (var i = _props.Head; i != null; i = i.Next)
        if (Ambients.Contains(i.Key))
          result.Set(i.Key, i.Value);

      return result;
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public static object SetCurrentOwner(object owner)
    {
      var result = CurrentOwner;
      CurrentOwner = owner;
      return result;
    }

    public readonly object Owner = CurrentOwner;
    [ThreadStatic]
    static object CurrentOwner;

    internal object Xaml
    {
      get { return _xaml; }
      set
      {
        if (_xaml == value)
          return;

        var oldLoaded = _xaml != null;

        _xaml = value;

        var newLoaded = _xaml != null;

        if (oldLoaded != newLoaded)
          if (newLoaded)
            Loaded();
          else
            Unloaded();

        XamlChanged?.Invoke(this, _xaml);
      }
    }
    object _xaml;

    protected virtual void Loaded() { }

    protected virtual void Unloaded() { }

    internal Action<NClass, object> XamlChanged;

    public NElement[] Children { get { return Get(Properties.Children, EmptyList); } set { Set(Properties.Children, value ?? EmptyList); } }

    static readonly NElement[] EmptyList = new NElement[0];

    public override string ToString()
    {
      var name = GetType().Name;
      var result = $"<{name} {_props}";

      if (Children.Length > 0)
        result += $">..({Children.Length})..</{name}>";
      else
        result += "/>";

      return result;
    }

    internal NPatch Diff()
    {
      var update = _force || ShouldComponentUpdate(_props, _state, _propsCommitted, _stateCommitted);

      Commit();

      if (!update)
        return null;

      var oldUI = _ui;
      var newUI = RenderUI();

      var patch = NPropDiffer.Diff(oldUI, newUI);

      if (oldUI is NClass)  // oldUI represented by nested class which is assigned after NPropDiffer anyway
        return patch;

      _ui = newUI;

      if (patch == NPatch.AssignNewValue) // Assign New UI
        patch = new NActionPatch(i => { var result = Xaml = newUI.Create(); oldUI?.Free(); return result; });

      return patch;
    }

    internal void Flush()
    {
      var patch = Diff();
      if (patch == null)
        return;

      if (patch is NActionPatch) // Assign New UI
      {
#if DEBUG
        Debug.WriteLine("New UI for : " + this);
        Debug.WriteLine(_ui);
      }
      else
      {
        Debug.WriteLine("New UI Patch for : " + this);
        Debug.WriteLine(patch);
#endif
      }

      NPatch.OnUIThread(patch, i => Xaml = i.Apply(Xaml));
    }

    protected virtual bool ShouldComponentUpdate(NPropertyBag props, NPropertyBag state, NPropertyBag oldProps, NPropertyBag oldState)
    {
      return props.Head != oldProps.Head || state.Head != oldState.Head;
    }

    internal override void Free()
    {
      Xaml = null;

      for (var i = _propsCommitted.Head; i != null; i = i.Next)
        NPatch.Finalize(i.Value);

      for (var i = _stateCommitted.Head; i != null; i = i.Next)
        NPatch.Finalize(i.Value);

      _ui?.Free();
    }

    protected static NElement New<T>(object key = null) where T : new()
    {
      return CreateElement<T>(key);
    }
  }
}
