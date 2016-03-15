using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace NReact
{
  public class NTimer : NClass
  {
    public static class Properties
    {
      public static readonly int Start = NProps.Store["Start"];
      public static readonly int Now = NProps.Store["Now"];
    }

    protected DateTime Start { get { return GetState(Properties.Start, DateTime.MinValue); } set { SetState(Properties.Start, value); } }
    protected DateTime Now { get { return GetState(Properties.Now, DateTime.MinValue); } set { SetState(Properties.Now, value); } }

    Timer _timer;
    protected override void InitState()
    {
      Start = DateTime.Now;
      Now = DateTime.Now;
    }

    protected override void ComponentDidMount()
    {
      _timer = new Timer(UpdateTime, null, 0, 10);
    }

    protected override void ComponentWillUnmount()
    {
      _timer.Dispose();
    }

    void UpdateTime(object state)
    {
      Now = DateTime.Now;
    }

    public override object Render()
    {
      return
        New<TextBlock>(NewProps.Alignment(HorizontalAlignment.Center).Alignment(VerticalAlignment.Center).FontSize(24.5).
           Text((Now - Start).ToString("s'.'fff")));
    }
  }
}
