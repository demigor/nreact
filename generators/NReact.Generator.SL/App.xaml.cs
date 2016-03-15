using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace NReact
{
  public partial class App : Application
  {
    public App()
    {
      Startup += Application_Startup;

      InitializeComponent();
    }

    void Application_Startup(object sender, StartupEventArgs args)
    {
      RootVisual = new Grid { Children = { new TextBlock { Text = "NReact Generator", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center } } };
      Save();
    }

    void Save()
    {
      var f = new Generator().Generate();
      var dialog = new SaveFileDialog { DefaultFileName = "NProps.generated.SL.cs" };
      if (dialog.ShowDialog() == true)
      {
        using (var s = dialog.OpenFile())
        using (var sw = new StreamWriter(s))
          sw.Write(f);
      }
    }
  }
}
