using System.Windows;
using System.Windows.Controls;

//to allow NReact reflect on anonymous types in this assembly
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NReact")]

namespace NReact.Demo.SL
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    void Application_Startup(object sender, StartupEventArgs e)
    {
      ((UserControl)RootVisual).Render(NElement.New(typeof(NDemo)));
    }
  }
}
