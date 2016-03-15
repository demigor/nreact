using System.Windows;
using NReact;

namespace TimerDemo.Wpf
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(NElement.New(typeof(NTimer)));
      MainWindow.Show();
    }
  }
}
