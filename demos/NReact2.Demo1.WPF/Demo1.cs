using System.Threading;
#if NETFX_CORE
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace NReact
{
  using static NFactory;

  class Demo1 : NClass
  {
    Timer _timer;

    protected override void Loaded()
    {
      _timer = new Timer(i => FontSize += 0.1, null, 0, 10);
    }

    protected override void Unloaded()
    {
      _timer.Dispose();
    }

    public double FontSize { get { return Get(Properties.FontSize, 10.0); } set { Set(Properties.FontSize, value); } }

    public override NElement Render()
    {
      if (FontSize > 15)
        return new NXaml<Border>().
                      Alignment(HorizontalAlignment.Stretch, VerticalAlignment.Stretch).
                      BorderThickness(10).
                      BorderBrush("Red").
                      Child(
                        new NXaml<Button>().
                          Alignment(HorizontalAlignment.Center, VerticalAlignment.Center).
                          Content("Click me").
                          FontSize(FontSize));

      return new NXaml<Grid>().Alignment(HorizontalAlignment.Stretch, VerticalAlignment.Stretch).Children(
                 new NXaml<Button>().Alignment(HorizontalAlignment.Center, VerticalAlignment.Center).Content("Click me").FontSize(FontSize));
    }
  }
}
