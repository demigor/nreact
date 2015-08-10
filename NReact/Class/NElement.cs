using System;
using System.Text;

namespace NReact
{
  public abstract class NElement
  {
    internal object Id;
    public abstract object Key { get; set; }
    public abstract string DisplayName { get; }
    internal abstract void Unmount();
    internal abstract Type GetInnerType();
    internal abstract NDataBag GetProps();

    protected internal static readonly object[] EmptyList = new object[0];

    public abstract NElement RenderInitial();

#if DEBUG
    public string Xaml { get { return ToString(); } }

    public override string ToString()
    {
      var sb = new StringBuilder();
      ToString(sb);
      return sb.ToString();
    }

    void ToString(StringBuilder sb, int indent = 0)
    {
      sb.Append(' ', indent * 2);
      sb.Append("<");
      sb.Append(DisplayName);

      var props = GetProps();
      var children = new NElement[0];

      for (var i = props; i != null; i = i.Next)
      {
        if (i.Id == NProps.Children)
        {
          children = (NElement[])i.Value;
        }
        else
        {
          sb.Append(" ");
          sb.Append(i.Key);
          sb.AppendFormat("=\"{0}\"", i.Value);
        }
      }

      if (children.Length == 0)
        sb.Append(" />");

      else
      {
        sb.AppendLine(">");

        indent++;

        for (int i = 0, c = children.Length; i < c; i++)
        {
          children[i].ToString(sb, indent);
          sb.AppendLine();
        }

        indent--;

        sb.Append(' ', indent * 2);
        sb.Append("</");
        sb.Append(DisplayName);
        sb.Append(">");
      }
    }
#endif
  }
}
