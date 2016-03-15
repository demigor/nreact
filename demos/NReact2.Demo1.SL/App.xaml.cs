using System.Windows;

namespace NReact.Demos
{
  public partial class App 
  {
    public App()
    {
      Startup += Application_Startup;

      InitializeComponent();
    }

    NElement _root;
    void Application_Startup(object sender, StartupEventArgs args)
    {
      _root = this.Render(new Demo1());
      //this.Render(new Demo2());
    }
  }
}
