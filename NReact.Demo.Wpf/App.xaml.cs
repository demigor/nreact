using NReact;
using System.Windows;

namespace WpfApplication1
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(NElement.New(typeof(NDemo)));
      MainWindow.Show();
    }
  }
}
