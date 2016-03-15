using System.Windows;
using NReact;

namespace OrderForm.Wpf
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(NElement.New(typeof(ServiceChooser), new
      {
        Items = new[] {
          new { Name = "Web Development", Price = 300, Active = true },
          new { Name = "Design", Price = 400, Active = false },
          new { Name = "Integration", Price = 250, Active = false },
          new { Name = "Traning", Price = 220, Active = false }
        }
      }));
      MainWindow.Show();
    }
  }
}
