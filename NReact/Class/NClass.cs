using System;
using System.Linq;
using System.Diagnostics;
using System.Threading;
#if NETFX_CORE
using Windows.UI.Xaml.Controls;
#else
using System.Windows.Controls;
#endif

namespace NReact
{
  public abstract partial class NClass : NElement
  {
    #region Patching Indication

    static int _patching;
    internal static void BeginPatching() { Interlocked.Increment(ref _patching); }
    internal static void EndPatching() { Interlocked.Decrement(ref _patching); }
    protected static bool IsPatching { get { return _patching != 0; } }

    #endregion

    internal override Type GetInnerType() { return GetType(); }
    internal override NDataBag GetProps() { return _props.New; }
    public override object Key { get { return GetProp(NProps.Key, (object)null); } set { SetProp(NProps.Key, value); } }
    public string Ref { get { return GetProp(NProps.Ref, (string)null); } set { SetProp(NProps.Ref, value); } }
    public object[] Children { get { return GetProp(NProps.Children, EmptyList); } set { SetProp(NProps.Children, value ?? EmptyList); } }

    protected virtual void InitState() { }
    protected virtual void InitProps() { }

    protected T GetProp<T>(int key, T @default)
    {
      return _props.Get(key, @default);
    }

    protected T GetState<T>(int key, T @default)
    {
      return _state.Get(key, @default);
    }

    protected void SetProp(int key, object value)
    {
      if (_props.Set(key, value))
        Update();
    }

    protected void SetState(int key, object value)
    {
      if (_state.Set(key, value))
        Update();
    }

    internal void SetProps(NDataBag values)
    {
      if (_props.Set(values))
        Update();
    }

    internal void SetState(NDataBag values)
    {
      if (_state.Set(values))
        Update();
    }

    public object Props
    {
      get { return _props; }
      set
      {
        if (value == null)
        {
          SetProps(null);
          return;
        }

        var nd = value as NDataBag;
        if (nd != null)
        {
          SetProps(nd);
          return;
        }

        var nc = value as NDataCtor;
        if (nc != null)
        {
          SetProps(nc.Head);
          return;
        }

        throw new InvalidOperationException();
      }
    }
    NClassData _props = new NClassData();

    public object State
    {
      get { return _state; }
      set
      {
        if (value == null)
        {
          SetState(null);
          return;
        }

        var nd = value as NDataBag;
        if (nd != null)
        {
          SetState(nd);
          return;
        }

        var nc = value as NDataCtor;
        if (nc != null)
        {
          SetState(nc.Head);
          return;
        }

        throw new InvalidOperationException();
      }
    }
    NClassData _state = new NClassData();

    bool _dirty;

    void Update()
    {
      if (_dirty) return;

      _dirty = true;

      if (_peer != null)
        NDispatcher.Default.EnqueueUpdate(this);
    }

    public override string DisplayName { get { return "#" + GetType().Name; } }

    bool _force;
    internal void UpdateCore()
    {
      Debug.WriteLine("Update Core");

      if (!_force && !_props.Dirty && !_state.Dirty)
      {
#if DEBUG
        Debug.WriteLine("No update needed for " + this + " [" + GetHashCode() + "]");
#endif
        Commit();
        return;
      }

      var update = _force || ShouldComponentUpdate(_props.New, _state.New, _props.Old, _state.Old);

      #region Commit changes

      Commit();

      #endregion

      if (!update) return;

      var oldUI = _ui;
      var newUI = RenderCore();

      var patch = NPatchBuilder.Make(oldUI, ref newUI);

      _ui = newUI;

      if (patch == null) return;

#if DEBUG
      Debug.WriteLine("New UI Patch for : " + this + " \n" + patch);
#endif

      if (_peer != null)
        patch.ApplyAsync(_peer);
    }

    internal void Commit()
    {
      _props.Commit();
      _state.Commit();

      _force = false;
      _dirty = false;
    }

    public void ForceUpdate()
    {
      _force = true;
      Update();
    }

    internal object Peer
    {
      get { return _peer; }
      set
      {
        if (_peer == value)
          return;

        if (_peer != null)
          ComponentWillUnmount();

        _peer = value;

        if (_peer != null)
          ComponentDidMount();
      }
    }
    object _peer;

    protected virtual void ComponentDidMount() { }

    protected virtual void ComponentWillUnmount() { }

    public override NElement RenderInitial()
    {
      if (_ui != null)
        return _ui;

      InitState();
      InitProps();
      Commit();

      return _ui = RenderCore();
    }
    NElement _ui;

    public abstract object Render();

    NElement RenderCore()
    {
      return MakeSingle(Render());
    }

    static NElement MakeSingle(object source)
    {
      if (source == null)
        return New(typeof(StackPanel), null);

      var result = source as NElement;
      if (result != null)
        return result;

      var list = Converter(source).ToArray();
      if (list.Length == 0)
        return null;

      if (list.Length == 1)
        return list[0];

      return New(typeof(StackPanel), null, list);
    }

    public virtual bool ShouldComponentUpdate(NDataBag newProps, NDataBag newState, NDataBag oldProps, NDataBag oldState)
    {
      return oldProps != newProps || oldState != newState;
    }

    public static string Text(object items)
    {
      if (items == null)
        return null;

      var text = items as string;
      if (text != null)
        return text;

      return string.Concat(Converter(items).Select(ConvertToString));
    }

    static string ConvertToString(NElement arg)
    {
      return arg.GetProps().Get(NProps.Text) as string;
    }

    internal override void Unmount()
    {
      Peer = null;

      var children = Children;
      for (var i = 0; i < children.Length; i++)
      {
        var o = children[i] as NElement;
        if (o == null) continue;
        o.Unmount();
      }
    }
  }
}
