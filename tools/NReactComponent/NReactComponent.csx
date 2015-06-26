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


//to allow NReact reflect on anonymous types in this assembly
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NReact")]

namespace $rootnamespace$
{
  public partial class $safeitemname$ : NComponent
  {
    // override Xaml presentation here
    public override NElement Render() 
    {               
      return <Grid/>;
    }
  }
}
