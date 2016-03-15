using System.Linq;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;

namespace NReact
{
  public class ToDoTask : NClass
  {
    public override object Render()
    {
      throw new System.NotImplementedException();
    }
  }

  public class ToDoApp : NClass
  {
    static readonly int idItems = NProps.Store["Items"];

    public IEnumerable<string> Items { get { return GetProp(idItems, Enumerable.Empty<string>()); } set { SetProp(idItems, value); } }

    void TextChanged(object sender)
    {

    }

    public override object Render()
    {
      return
        New<StackPanel>(NewProps.Alignment(HorizontalAlignment.Center).TextOptions(TextFormattingMode.Display),
          Items.Select((i, idx) =>
            New<TextBox>(NewProps.
                TextChanged(TextChanged).
                Text(i + " #" + idx).
                Key(idx).
                Alignment(HorizontalAlignment.Center).
                FontSize(idx * 5 + 10).
                Foreground((idx * 8), ((idx * 8) << 8), ((idx * 8) << 16))))
        );
    }

    public void AddNewItem(string item)
    {
      if (Items.Any())
        Items = Items.Concat(new[] { item });
      else
        Items = new[] { item };
    }
  }
}
