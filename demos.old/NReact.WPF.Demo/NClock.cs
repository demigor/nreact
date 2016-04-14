using System;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact.Demos
{
  public class NClock : NClass
  {
    public static class Properties 
    {
      public static readonly NProperty Time = new NProperty(nameof(Time));
      public static readonly NProperty Tick = new NProperty(nameof(Tick));
      public static readonly NProperty FontSize = new NProperty(nameof(FontSize));
    }

    public double FontSize { get { return Get(Properties.FontSize, 36.0); } set { Set(Properties.FontSize, value); } }
    protected DateTime Time { get { return GetState(Properties.Time, DateTime.Now); } set { SetState(Properties.Time, value); } }
    protected int Tick { get { return GetState(Properties.Tick, 0); } set { SetState(Properties.Tick, value); } }

    protected override void Loaded()
    {
      NDispatcher.Default.OnMessage += OnMessage;
      NTimer.Start();
    }
    protected override void Unloaded()
    {
      NTimer.Stop();
      NDispatcher.Default.OnMessage -= OnMessage;
    }

    void OnMessage(object sender, MessageArgs e)
    {
      if (e == NTimer.TimerArgs)
      {
        Time = DateTime.Now;
        Tick++;
      }
    }

    public override NElement Render()
    {
      return
        new NXaml<Grid>().
              Alignment(HorizontalAlignment.Center, VerticalAlignment.Center).
              Children(new NXaml<TextBlock>().
                             FontSize(FontSize).
                             Text($"{Time:o} #{Tick}"));
    }
  }
}
