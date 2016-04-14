using System.Windows;
using NReact;

namespace NReact.Demos
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(new TodoApp());
      MainWindow.Show();
    }
  }
}
