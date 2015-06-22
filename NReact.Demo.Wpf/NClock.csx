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

public partial class NClock : NComponent
{
  public override NElement Render()
  {
    return
      <Grid HorizontalAlignment="Center" VerticalAlignment="Center">
        <TextBlock FontSize = {Props.FS} Text = { string.Format("{0:o} #{1}", State.Time, State.Tick) }/>
      </Grid>;
  }
}