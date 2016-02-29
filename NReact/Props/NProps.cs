namespace NReact
{
  public class NPropsBase
  {
    public static readonly NPropsStore Store = new NPropsStore();
    public static readonly int CONTENT = Store["<CONTENT>"];
    public static readonly int Key = Store["Key"];
    public static readonly int Ref = Store["Ref"];
  }

  public partial class NProps: NPropsBase
  {
    public static readonly int Items = Store["Items"];
    public static readonly int RowDefinitions = Store["RowDefinitions"];
    public static readonly int ColumnDefinitions = Store["ColumnDefinitions"];
    public static readonly int Children = Store["Children"];
    public static readonly int Blocks = Store["Blocks"];
    public static readonly int Inlines = Store["Inlines"];
#if WPF
    public static readonly int CanvasZIndex = PanelZIndex;
#endif
  }
}
