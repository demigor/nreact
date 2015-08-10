using System.Windows;
using System.Windows.Controls;

namespace NReact
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      Host.Settings.MaxFrameRate = 60;
//      Host.Settings.EnableRedrawRegions = true;
    }

    void Application_Startup(object sender, StartupEventArgs e)
    {
      ((UserControl)RootVisual).Render(new NDemo());
    }
  }
}
