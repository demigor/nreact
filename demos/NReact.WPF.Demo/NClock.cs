using System;
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace NReact
{
  public class NClock : NClass
  {
    class NProps: NReact.NProps 
    {
      public static readonly int Time = Store["Time"];
      public static readonly int Tick = Store["Tick"];
    }

    public double FontSize { get { return GetProp(NProps.FontSize, 36.0); } set { SetProp(NProps.FontSize, value); } }
    protected DateTime Time { get { return GetState(NProps.Time, DateTime.Now); } set { SetState(NProps.Time, value); } }
    protected int Tick { get { return GetState(NProps.Tick, 0); } set { SetState(NProps.Tick, value); } }

    protected override void ComponentDidMount()
    {
      NDispatcher.Default.OnMessage += OnMessage;
      NTimer.Start();
    }
    protected override void ComponentWillUnmount()
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

    public override object Render()
    {
      return
        New<Grid>(NewProps.Alignment(HorizontalAlignment.Center).Alignment(VerticalAlignment.Center),
          New<TextBlock>(NewProps.FontSize(FontSize).Text("{0:o} #{1}", Time, Tick)));
    }
  }
}
