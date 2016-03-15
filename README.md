# NReact
React/Flux principles in C#/Xaml application. Experimental playground. 
See various demos.

Please check official React/Flux resources to understand underlying concepts.

Implemented:
* Async Virtual Xaml (aka VirtualDOM) including complex patching mechanism (diff based on Keys) (NElement)
* Several Type Converters including enums, colors, brushes and resources (NConverters)
* Simple Flux Dispatcher (NDispatcher)
* Nuget Package including support for Store, WPF and Silverlight apps
* Key-based Diff-algorithm for Virtual Xaml (NPatch)

To to:
* Dynamic in-app CSX compilation using embeddable compiler (Mono.CSharp, Roslyn) 
* Xaml-like Visual Studio CSX syntax transform including syntax highlighting and debugging.
* More type converters

Removed:
* CSX - C# syntax extension (aka React JSX). CSX -> C# transform MSBuild task and standalone executable (NReact.Csx). Removed due to poor debugging experience. New Roslyn-based approach needed.
* Dynamic typing for Component's Props and State (NDynamic). Removed due to poor performance of dynamics.

Existence questions:
* Why does one need NReact?

```javascript
class TodoList : NClass
{
  public override object Render()
  {
    return new NXaml<StackPanel>().Children(Children.Select((i, idx) => new NXaml<TextBlock>().Ref(idx).Text("* " + i)));
  }
}

class TodoApp : NComponent
{
  protected object[] Items { get { return GetState<object[]>(Properties.Items, null); } set { SetState(Properties.Items, value); } }

  public override object Render()
  {
    var items = Items;
    
    return 
      new NXaml<StackPanel>().
            HorizontalAlignment(HorizontalAlignment.Center).
            Children(
              new NXaml<TextBlock>().Text("TODO").FontSize(24).HorizontalAlignment(HorizontalAlignment.Center),
              new TodoList { Items = this.Items },
              new NXaml<StackPanel>().Orientation(Orientation.Horizontal).
                Children(
                  new NXaml<TextBox>().Text(State.Text).TextChanged(OnChange).Width(200),
                  new NXaml<Button>().Click(OnAdd).Content("Add #" + (Items.Length + 1))));
  }
}
  
Application.Current.MainWindow.Render(new TodoApp());
```

How to install:
* Build from these sources
* Install Nuget NReact Package (install-package nreact -pre)
