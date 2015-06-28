using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace NReact
{
  public class NXamlElement : NElement
  {
    public override string DisplayName { get { return _type.Name; } }

    internal override Type InnerType { get { return _type; } }
    internal readonly Type _type;

    internal override NElement[] GetChildren() { return Children; }
    internal NElement[] Children = _empty;

    public NXamlElement(Type type, NDynamic props, IEnumerable children = null)
    {
      _type = type;
      Children = base.Setup(props, children);
    }

    internal override void Unmount()
    {
      for (int i = 0, c = Children.Length; i < c; i++)
        Children[i].Unmount();
    }
  }
}
