using System.Collections.Generic;

namespace NReact
{
  public partial class NProperties
  {
#if WPF
    public NProperty CanvasZIndex { get { return PanelZIndex; } }
#endif
  }
}
