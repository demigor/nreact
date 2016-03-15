using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NReact
{
  sealed partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override async void OnLaunched(LaunchActivatedEventArgs args)
    {
      Window.Current.Content = new Button();
      Window.Current.Activate();

      var dialog = new FileSavePicker { SuggestedStartLocation = PickerLocationId.DocumentsLibrary, FileTypeChoices = { { "C# File", new List<string>() { ".cs" } } }, SuggestedFileName = "NProps.generated.WRT.cs" };

      var file = await dialog.PickSaveFileAsync();
      if (file != null)
        await FileIO.WriteTextAsync(file, new Generator().Generate());
    }
  }
}
