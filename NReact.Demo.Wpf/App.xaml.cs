using NReact;
using System.Windows;

//to allow NReact reflect on anonymous types in this assembly
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NReact")]

namespace NReact.Demo.Wpf
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
