using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NReact
{
  public sealed partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
      var btn = new Button
      {
        Content = "NReact generator",
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Center
      };
      btn.Click += (s, e) => Save();
      Window.Current.Content = btn;
      Window.Current.Activate();
    }

    void Save()
    {
      new FileSavePicker
      {
        SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
        FileTypeChoices = { { "C# File", new List<string>() { ".cs" } } },
        SuggestedFileName = "NProps.generated.WRT.Phone.cs"
      }.PickSaveFileAndContinue();
    }

    protected override async void OnActivated(IActivatedEventArgs args)
    {
      base.OnActivated(args);

      var f = args as FileSavePickerContinuationEventArgs;
      if (f != null)
      {
        await FileIO.WriteTextAsync(f.File, new Generator().Generate());
      }
    }
  }
}