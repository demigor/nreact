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

namespace NReact
{
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
    public double FontSize { get { return GetProp(NProps.FontSize, 12.0); } set { SetProp(NProps.FontSize, value); } }

    protected override void ComponentDidMount()
    {
      NTimer.Start();
      NDispatcher.Default.OnMessage += OnMessage;
    }

    protected override void ComponentWillUnmount()
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

    public override object Render()
    {
      return
        New<StackPanel>(NewProps.Alignment(VerticalAlignment.Center).Alignment(HorizontalAlignment.Center),
          New<NClock>(NewProps.FontSize(FontSize)),
          New<Button>(NewProps.Click(ClickMe).Foreground("Red").Alignment(HorizontalAlignment.Center), "Click me #" + (int)FontSize),
          New<NClock>(NewProps.FontSize(60.0 - FontSize))
        );
    }
  }
}
