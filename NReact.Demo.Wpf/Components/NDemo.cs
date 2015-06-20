using System;
using System.Threading;
#if NETFX_CORE
using Windows.UI.Popups;
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace NReact
{
  public partial class NDemo : NComponent
  {
    public const int RefreshDelay = 10;

    public override object GetDefaultProps()
    {
      return new { FontSize = 12D }.AsDynamic();
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
      if (fs > 50) fs = 10d;

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
}
