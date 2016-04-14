using System.Windows;

namespace NReact.Demos
{
  public partial class App  
  {
    public App()
    {
      InitializeComponent();

      this.Render(new NDemo());
    }
  }
}
