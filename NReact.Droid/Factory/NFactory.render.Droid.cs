using Android.App;
using Android.Views;

namespace NReact
{
  public static partial class NFactory
  {
    public static NElement Render(this Activity control, NElement content)
    {
      content.Context = control;

      var cls = content as NClass;
      if (cls != null)
        cls.XamlChanged = (c, p) => control.SetContentView(p as View);

      control.SetContentView(content.Create() as View);
      return content;
    }
  }
}