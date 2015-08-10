using System;
using System.Windows;

namespace NReact
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    ToDoApp _todoApp = new ToDoApp();
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(_todoApp);
      MainWindow.Show();
    }

    void Window_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      NDispatcher.Default.Enqueue(() => _todoApp.AddNewItem("From " + DateTime.Now));
    }
  }
}
