using System;
using System.Linq;
using System.Collections;
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

class TodoList : NComponent
{
  public override NElement Render()
  {
 	  var list = (IEnumerable<string>)Props.Items;
    
    return 
      <StackPanel>
      { list.Select((i,idx) => <TextBlock Key={idx} Text={"* " + i}/>) }
      </StackPanel>;
  }
}

class TodoApp : NComponent
{
  protected override object GetInitialState()
  {
    return new { Items = new string[0], Text = "" };
  }

  void OnChange(object sender, EventArgs args)
  {
    SetState(new { Text = ((TextBox)sender).Text });
  }

  static string[] AppendElement(string[] source, string element)
  {
    return source.Concat(new[] { element }).ToArray();    
  }

  void OnAdd(object sender, EventArgs args)
  {
    SetState(new { Items = AppendElement(State.Items, State.Text), Text = "" });
  }

  public override NElement Render()
  {
    return 
      <StackPanel HorizontalAlignment="Center">
        <TextBlock Text="TODO" FontSize={24.0} HorizontalAlignment="Center"/>
        <TodoList Items={State.Items}/>
        <StackPanel Orientation="Horizontal">
           <TextBox Text={State.Text} TextChanged={(TextChangedEventHandler)OnChange} Width={200.0}/>
           <Button Click={(RoutedEventHandler)OnAdd} Content={"Add #" + (State.Items.Length + 1)}/>
        </StackPanel>
      </StackPanel>;
  }
}
