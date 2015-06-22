using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Popups;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

using NReact;

public partial class NDemo : NComponent
{
  public const int RefreshDelay = 10;

  public override object GetDefaultProps()
  {
    return new { FontSize = 12.0 };
  }

  Timer _timer;

  public override void ComponentDidMount()
  {
    _timer = new Timer(TickSize, null, 0, RefreshDelay);
  }

  public override void ComponentWillUnmount()
  {
    _timer.Dispose();
  }

  void TickSize(object state)
  {
    var fs = Props.FontSize + 0.5;
    if (fs > 50) fs = 10.0;

    SetProps(new { FontSize = fs });
  }

  void ClickMe(object sender, RoutedEventArgs args)
  {
#if NETFX_CORE
      new MessageDialog("Click").ShowAsync();
#else
    MessageBox.Show("Click");
#endif
  }
}
