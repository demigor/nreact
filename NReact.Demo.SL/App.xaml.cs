using System.Windows;
using System.Windows.Controls;

namespace NReact.SL
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    void Application_Startup(object sender, StartupEventArgs e)
    {
      ((UserControl)RootVisual).Render(NElement.New(typeof(NDemo)));
    }
  }
}
