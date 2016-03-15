using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace NReact
{
  sealed partial class App 
  {
    public App()
    {
      InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs e)
    {
      Window.Current.Render(new Demo2());
      Window.Current.Activate();
    }
  }
}