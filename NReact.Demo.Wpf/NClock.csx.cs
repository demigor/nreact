using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

using NReact;

public partial class NClock : NComponent
{
  Timer _timer;

  public override object GetDefaultProps()
  {
    return new { FS = 36.0 };
  }

  protected override object GetInitialState()
  {
    return new { Time = DateTime.Now, Tick = 0 };
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

