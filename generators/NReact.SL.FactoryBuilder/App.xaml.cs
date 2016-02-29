using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NReact.FactoryBuilder
{
  public partial class App : Application
  {
    public App()
    {
      Startup += App_Startup;
      InitializeComponent();
    }

    void App_Startup(object sender, StartupEventArgs e)
    {
      var f = new FactoryGenerator().Generate();

      RootVisual = new TextBox
      {
        Text = f,
        BorderThickness = new Thickness(0, 0, 0, 0),
        AcceptsReturn = true,
        FontFamily = new FontFamily("Envy Code R"),
        FontSize = 13,
        VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
        HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
      };

      var dialog = new SaveFileDialog { DefaultFileName = "NXamlFactory.SL.cs" };
      if (dialog.ShowDialog() == true)
      {
        using (var s = dialog.OpenFile())
        using (var sw = new StreamWriter(s))
          sw.Write(f);
      }
    }
  }
}
