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
using NReact;

class TodoList : NClass
{
  public override NElement Render()
  {
    return new NXaml<StackPanel>().Children(Children.Select((i, idx) => new NXaml<TextBlock>(idx).Text("* " + i)));
  }
}

class TodoApp : NComponent
{
  protected object[] Items { get { return GetState<object[]>(Properties.Items, null); } set { SetState(Properties.Items, value); } }
  protected string Text { get { return GetState<string>(Properties.Text, null); } set { SetState(Properties.Text, value); } }

  public override NElement Render()
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
                  new NXaml<TextBox>().Text(Text).TextChanged(OnChange).Width(200),
                  new NXaml<Button>().Click(OnAdd).Content("Add #" + (Items.Length + 1))));
  }
}
  
Application.Current.MainWindow.Render(new TodoApp());
```

Final goal is to get something like this in Visual Studio/Roslyn/C#:

```javascript
using NReact;

class TodoList : NClass
{
  public override NElement Render()
  {
    return <StackPanel>{ Children.Select((i, idx) => <TextBlock Key={idx} Text={ "* " + i } />) }</StackPanel>;
  }
}

class TodoApp : NComponent
{
  protected object[] Items { get; set; }

  public override NElement Render()
  {
    var items = Items;
    
    return 
      <StackPanel HorizontalAlignment="Center">
        <TextBlock Text="TODO" FontSize="24" HorizontalAlignment="Center" />
        <TodoList Items={Items} />
        <StackPanel Orientation="Horizontal">
          <TextBox Text="Text" TextChanged={OnChange} Width="200" />
          <Button Click={OnAdd} Content={ "Add #" + (Items.Length + 1) } />
        </StackPanel>
      </StackPanel>;
  }
}
  
Application.Current.MainWindow.Render(<TodoApp/>);
```
All this should compile to extension methods:

<Element/> => this.New<Element>() 

<Element Attr1="Value"/> => this.New<Element>().Attr1("Value")

<Element Attr1={ Expression } /> => this.New<Element>().Attr1(Expression)

<Element Attr1={ Expression } Attr2={ Expression2 }/> => this.New<Element>().Attr1(Expression1).Attr2(Expression2)

<Element><Subelement/></Element> => this.New<Element>().Content(this.New<Subelement>())

How to install:
* Build from these sources
* Install Nuget NReact Package (install-package nreact -pre)
