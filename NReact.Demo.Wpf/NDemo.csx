using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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

public partial class NDemo 
{
  public override object Render()
  {
    return 
      <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
        <NClock FS={ Props.FontSize } />
        <Button Click={ (RoutedEventHandler)ClickMe } Content={"Click me" + ((int)Props.FontSize)} HorizontalAlignment="Center" Foreground="Red" />
        <NClock FS={ 60.0 - Props.FontSize } />
      </StackPanel>;
  }
}
