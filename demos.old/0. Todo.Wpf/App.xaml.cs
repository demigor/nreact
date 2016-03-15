using System.Windows;
using NReact;

namespace ToDoList.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(NElement.New(typeof(TodoApp)));
      MainWindow.Show();
    }
  }
}
