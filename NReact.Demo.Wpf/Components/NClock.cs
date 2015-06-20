using System;
using System.Threading;

namespace NReact
{
  public partial class NClock : NComponent
  {
    Timer _timer;

    public override object GetDefaultProps()
    {
      return new { FS = 36D }.AsDynamic();
    }

    protected override object GetInitialState()
    {
      return new { Time = DateTime.Now, Tick = 0 }.AsDynamic();
    }

    public override void ComponentDidMount()
    {
      _timer = new Timer(UpdateTime, null, 0, NDemo.RefreshDelay);
    }

    public override void ComponentWillUnmount()
    {
      _timer.Dispose();
    }

    void UpdateTime(object sender = null)
    {
      SetState(new { Time = DateTime.Now, Tick = State.Tick + 1 });
    }
  }
}
