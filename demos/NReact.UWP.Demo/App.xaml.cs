using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace NReact.UWP.Demo
{
  sealed partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs e)
    {
      base.OnLaunched(e);
      Window.Current.Render(new NDemo());
      Window.Current.Activate();
    }
  }
}
