using System.Windows;

namespace NReact
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(new NDemo());
      MainWindow.Show();
    }
  }
}
