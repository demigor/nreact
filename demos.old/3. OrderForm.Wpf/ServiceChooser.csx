using System;
using System.Linq;
using System.Collections;
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

public partial class ServiceChooser : NComponent
{
  protected override object GetInitialState() 
  {
    return new { Total = 0 };
  }

  void AddTotal(int price) 
  {
    SetState( new { Total = State.Total + price });
  }

  public override object Render() 
  {
     IEnumerable items = Props.Items;
     var services = from dynamic s in items 
                    select <Service Name={s.Name} Price={s.Price} Active={s.Active} AddTotal={(Action<int>)AddTotal} />;

     return <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
              <TextBlock FontSize="18" Text="Our services"/>

              <StackPanel>
                {services}
              </StackPanel>
              
              <TextBlock Text={"Total $" + State.Total} HorizontalAlignment="Center"/>
            </StackPanel>;
  }
}

public class Service: NComponent 
{
  protected override object GetInitialState() 
  {
    return new { Active = false };
  }

  void ClickHandler(object sender, RoutedEventArgs args) 
  {
    var active = !State.Active;

    SetState(new { Active = active });
        
    ((Action<int>)Props.AddTotal)(active ? Props.Price : -Props.Price);
  }

  public override object Render() 
  {
    return  <Button Style={State.Active ? "Active" : null} 
                    Padding="8,4"
                    Click={(RoutedEventHandler)ClickHandler} 
                    Content={Props.Name + " $" + Props.Price}/>;
  }
}