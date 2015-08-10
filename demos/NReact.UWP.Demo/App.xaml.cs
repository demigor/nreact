using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace NReact.UWP.Demo
{
  /// <summary>
  /// Provides application-specific behavior to supplement the default Application class.
  /// </summary>
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
