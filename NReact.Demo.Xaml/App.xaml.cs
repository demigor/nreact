using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

//to allow NReact reflect on anonymous types in this assembly
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NReact")]

namespace NReact.Demo.Xaml
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
      base.OnLaunched(args);
      Window.Current.Render(NElement.New(typeof(NDemo)));
      Window.Current.Activate();
    }
  }
}
