using System;
using System.Collections;
#if NETFX_CORE
using Windows.UI.Xaml;
using System.Diagnostics;
#else
using System.Windows;
using System.Diagnostics;
#endif

namespace NReact
{
  public abstract class NComponent : NElement
  {
    public override string DisplayName { get { return "c:" + GetType().Name; } }

    internal override Type InnerType { get { return GetType(); } }

    internal override void Setup(NDynamic props, object content)
    {
      base.Setup(DefaultProps() + props, content);
      SetStateCore(InitialState() ?? NDynamic.Empty);
#if TrackOwner
      _owner = CurrentOwner;
#endif
    }

    protected virtual object GetInitialState()
    {
      return null;
    }

    public virtual object GetDefaultProps()
    {
      return null;
    }

    internal NDynamic DefaultProps()
    {
      return NFactory.ToDynamic(GetDefaultProps());
    }

    internal NDynamic InitialState()
    {
      return NFactory.ToDynamic(GetInitialState());
    }

    protected dynamic State { get { return _state; } }
    internal NDynamic _state;

    protected void SetState<T>(T state) where T : class
    {
      SetState(state.AsDynamic());
    }

    protected void ReplaceState<T>(T state) where T : class
    {
      ReplaceState(state.AsDynamic());
    }

    public void SetProps<T>(T props) where T : class
    {
      SetProps(props.AsDynamic());
    }

    public void ReplaceProps<T>(T props) where T : class
    {
      ReplaceProps(props.AsDynamic());
    }

    protected void Update()
    {
      NDispatcher.Default.EnqueueUpdate(this);
    }

    public void ForceUpdate()
    {
      _newForceUpdate = true;
      Update();
    }

    public void SetProps(NDynamic newProps)
    {
      _newProps = (_newProps ?? _props) + newProps;
      Update();
    }

    public void ReplaceProps(NDynamic newProps)
    {
      _newProps = newProps ?? new NDynamic();
      Update();
    }

    protected void SetState(NDynamic newState)
    {
      _newState = (_newState ?? _state) + newState;
      Update();
    }

    public void ReplaceState(NDynamic newState)
    {
      _newState = newState ?? new NDynamic();
      Update();
    }

    public virtual void ComponentDidMount() { }
    public virtual void ComponentWillUnmount() { }

    internal NDynamic _newState, _newProps;
    internal bool _newForceUpdate;

    public abstract object Render();

    internal NElement UI { get { return _ui ?? (_ui = RenderCore()); } }
    NElement _ui;

    public virtual bool ShouldComponentUpdate(NDynamic newProps, NDynamic newState)
    {
      return _props != newProps || _state != newState;
    }

#if TrackOwner
    [ThreadStatic]
    static NComponent CurrentOwner;
    internal NComponent _owner;
#endif

    internal NElement RenderCore()
    {
#if TrackOwner
      var save = CurrentOwner;
      CurrentOwner = this;
      try
      {
        return Convert(Render());
      }
      finally
      {
        CurrentOwner = save;
      }
#else
      return Convert(Render());
#endif
    }

    static NElement Convert(object source)
    {
      var result = source as NElement;
      if (result != null)
        return result;

      return TextBlock(string.Concat(source));
    }

    internal override void Unmount()
    {
      Target = null;
      base.Unmount();
    }

    internal void SetStateCore(NDynamic state)
    {
      _state = state.Seal();
    }

    internal void UpdateCore()
    {
      if (!_newForceUpdate && _newProps == null && _newState == null)
      {
#if DUMP
        Debug.WriteLine("No update needed for " + this + " [" + GetHashCode() + "]");
#endif
        return;
      }

      var newProps = _newProps ?? _props;
      var newState = _newState ?? _state;
      var update = _newForceUpdate || ShouldComponentUpdate(newProps, newState);

      SetPropsCore(newProps);
      SetStateCore(newState);

      _newState = null;
      _newProps = null;
      _newForceUpdate = false;

      if (update)
      {
        var oldUI = _ui;
        var newUI = RenderCore();

        var patch = NPatch.Make(oldUI, ref newUI);
        _ui = newUI;
        if (patch == null) return;

#if DUMP
        Debug.WriteLine("New UI Patch for : " + this + " \n" + patch);
#endif
        if (_target != null)
          patch.ApplyAsync(_target);
      }
    }

    internal object Target
    {
      get { return _target; }
      set
      {
        if (_target == value) return;

        if (_target != null)
          ComponentWillUnmount();

        _target = value;

        if (_target != null)
          ComponentDidMount();
      }
    }
    object _target;
  }
}
