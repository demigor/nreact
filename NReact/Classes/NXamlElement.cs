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

    public NXamlElement(Type type, NDynamic props, IEnumerable children = null)
    {
      _type = type;
      Setup(props, children);
    }
  }
}
