using System.Windows;

namespace NReact.Demos
{
  public partial class App : Application
  {
    void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindow.Render(new NServiceChooser
      {
        Items = new[] { new { Name = "Web Development", Price = 300 },
                        new { Name = "Design", Price = 400 },
                        new { Name = "Integration", Price = 250 },
                        new { Name = "Traning", Price = 220 } }
      });
      MainWindow.Show();
    }
  }
}
