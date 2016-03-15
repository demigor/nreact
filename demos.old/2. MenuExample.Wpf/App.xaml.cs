using NReact;
using System.Windows;

namespace Navigation.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(NElement.New(typeof(NMenuExample), new { Items = new[] { "Home", "Services", "About", "Contact us" } }));
      MainWindow.Show();
    }
  }
}
