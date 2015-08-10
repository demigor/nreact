using System.Text;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace NReact
{
  public class NDataBag
  {
    public static object UnsetValue = DependencyProperty.UnsetValue;

    public object Key { get { return NProps.Store.GetKey(Id); } }

    internal readonly int Id;
    internal object Value;
    internal NDataBag Next;
    internal bool Sealed;

    internal NDataBag(NDataBag next, int id, object value)
      : this(id, value)
    {
      Next = next;
    }

    internal NDataBag(int id, object value)
    {
      Id = id;
      Value = value;
    }

    public override string ToString()
    {
      var sb = new StringBuilder();
      var f = true;

      for (var i = this; i != null; i = i.Next)
      {
        if (f) f = false;
        else sb.Append(", ");

        sb.AppendFormat("{0} = {1}", i.Key, i.Value);
      }

      return sb.ToString();
    }
  }
}
