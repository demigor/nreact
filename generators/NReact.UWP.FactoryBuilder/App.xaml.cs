using System;
using System.IO;
using Windows.ApplicationModel.Activation;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace NReact.FactoryBuilder
{
  sealed partial class App : Application
  {
    public App()
    {
      this.InitializeComponent();
    }

    protected async override void OnLaunched(LaunchActivatedEventArgs e)
    {
      var f = new FactoryGenerator().Generate();

      var root = new TextBox
      {
        Opacity = 1,
        BorderThickness = new Thickness(0, 0, 0, 0),
        AcceptsReturn = true,
        Text = f,
        FontFamily = new FontFamily("Envy Code R"),
        FontSize = 13,
        VerticalAlignment = VerticalAlignment.Stretch,
        HorizontalAlignment = HorizontalAlignment.Stretch
      };
      ScrollViewer.SetVerticalScrollBarVisibility(root, ScrollBarVisibility.Auto);
      ScrollViewer.SetHorizontalScrollBarVisibility(root, ScrollBarVisibility.Auto);
      Window.Current.Content = root;

      Window.Current.Activate();

      var p = new FileSavePicker
      {
        SuggestedFileName = "NXamlFactory.UWP.cs",
        SuggestedStartLocation = PickerLocationId.DocumentsLibrary
      };
      p.FileTypeChoices.Add("All Files (*.cs)", new[] { ".cs" });

      var x = await p.PickSaveFileAsync();
      if (x == null) return;

      var s = await x.OpenStreamForWriteAsync();
      using (var sw = new StreamWriter(s))
        sw.Write(f);

    }
  }
}
