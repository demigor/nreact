using System.Collections.Generic;

namespace NReact
{
  /// <summary>
  /// Default properties defined here
  /// </summary>
  public partial class NProperties
  {
#if WPF
    public NProperty CanvasZIndex { get { return PanelZIndex; } }
#endif
  }
}
