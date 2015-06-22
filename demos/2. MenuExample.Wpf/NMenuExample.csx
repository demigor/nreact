using System;
using System.Linq;
using System.Collections.Generic;

#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

using NReact;

public class NMenuExample: NComponent
{
  protected override object GetInitialState()
  {
    return new { Focused = 0 };
  }

  void Clicked(int index) 
  {
    SetState(new { Focused = index });
  }

  public override NElement Render() 
  {
    var items = (IEnumerable<string>)Props.Items;

    return 
      <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
        <StackPanel Orientation="Horizontal">
        { items.Select((m,index) =>
            <Button Content={m} Style={State.Focused == index ? "Focused" : "Unfocused"} Click={(RoutedEventHandler)((s,e) => Clicked(index))}/>)}
        </StackPanel>
        <TextBlock Style="P" Text={"Selected: " + Props.Items[State.Focused]} />
      </StackPanel>;
  }
}