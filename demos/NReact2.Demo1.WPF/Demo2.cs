using System;
using System.Diagnostics;
#if NETFX_CORE
using Windows.UI;
using Windows.UI.Xaml.Controls;
#else
using System.Windows.Controls;
using System.Windows.Media;
#endif


namespace NReact
{
  class NButton : NClass
  {
    public string Text { get { return Get(NFactory.Properties.Text, ""); } set { Set(NFactory.Properties.Text, value); } }

    public override NElement Render()
    {
      if (Text.StartsWith("Text"))
        return new NXaml<TextBlock>().Text(Text);

      return new NXaml<Button>().Content(Text);
    }
  }

  class NStackPanel : NClass
  {
    public override NElement Render()
    {
      return new NXaml<StackPanel>().Children(Children);
    }
  }

  class Demo2 : NClass
  {
    int state;

    public void Tick()
    {
      state++;
      ForceUpdate();
    }

    public override NElement Render()
    {                  
      return new NXaml<Border>().
        Background(Colors.Transparent).
#if NETFX_CORE
        PointerPressed(Tick, true).
#else
        MouseLeftButtonDown(Tick, true).
#endif
        Child(RenderContent());
    }

    NElement RenderContent()
    {
      switch (state % 9)
      {
        case 0: return new NStackPanel().Children(new NButton().Key(1).Text("Button1"));
        case 1: return new NStackPanel().Children(new NButton().Key(1).Text("Button1"), new NButton().Key(2).Text("Button2"));
        case 2: return new NStackPanel().Children(new NButton().Key(2).Text("Button2"), new NButton().Key(1).Text("Button1"));
        case 3: return new NStackPanel().Children(new NButton().Key(1).Text("Button1"));
        case 4: return new NStackPanel();
        case 5: return new NStackPanel().Children(new NButton().Key(1).Text("Button1"));
        case 6: return new NStackPanel().Children(new NButton().Key(1).Text("TextX"));
        case 7: return new NStackPanel().Children(new NButton().Key(1).Text("TextX"), new NButton().Key(2).Text("Button2"));
        default: return new NStackPanel().Children(new NButton().Key(2).Text("Button2"), new NButton().Key(1).Text("Button1"));
      }
    }
  }

}
