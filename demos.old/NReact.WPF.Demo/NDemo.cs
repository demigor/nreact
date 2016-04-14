using System.Threading;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace NReact.Demos
{
  using static NFactory;

  static class NTimer
  {
    public const int RefreshDelay = 16;

    static int _timeUsageCount;
    static Timer _timer;

    public static void Start()
    {
      if (Interlocked.Increment(ref _timeUsageCount) == 1)
        _timer = new Timer(Tick, null, 0, RefreshDelay);
    }

    public static void Stop()
    {
      if (Interlocked.Decrement(ref _timeUsageCount) == 0)
        _timer.Dispose();
    }

    public static readonly MessageArgs TimerArgs = new MessageArgs(null, null);

    static void Tick(object state)
    {
      NDispatcher.Default.Enqueue(TimerArgs);
    }
  }

  public class NDemo : NClass
  {
    public double FontSize { get { return Get(Properties.FontSize, 12.0); } set { Set(Properties.FontSize, value); } }

    protected override void Loaded()
    {
      NTimer.Start();
      NDispatcher.Default.OnMessage += OnMessage;
    }

    protected override void Unloaded()
    {
      NDispatcher.Default.OnMessage -= OnMessage;
      NTimer.Stop();
    }

    void OnMessage(object sender, MessageArgs e)
    {
      if (e == NTimer.TimerArgs)
      {
        var fs = FontSize + 0.5;

        if (fs > 50)
          fs = 10.0;

        FontSize = fs;
      }
    }

    void ClickMe()
    {
#if NETFX_CORE
      var result = new MessageDialog("Click").ShowAsync();
#else
      MessageBox.Show("Click");
#endif
    }

    public override NElement Render()
    {
      return
        new NXaml<StackPanel>().Alignment(VerticalAlignment.Center).Alignment(HorizontalAlignment.Center).Children(
          new NClock { FontSize = FontSize },
          new NXaml<Button>().Click(ClickMe).Foreground(Colors.Red).Alignment(HorizontalAlignment.Center).Content("Click me #" + (int)FontSize),
          new NClock { FontSize = 60.0 - FontSize });
    }
  }
}
