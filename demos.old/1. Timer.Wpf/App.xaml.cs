using System.Windows;
using NReact;

namespace NReact.Demos
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(new NTimer());
      MainWindow.Show();
    }
  }
}
