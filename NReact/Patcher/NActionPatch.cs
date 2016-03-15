using System;

namespace NReact
{
  class NActionPatch : NPatch
  {
    readonly Func<object, object> _patcher;

    public NActionPatch(Func<object, object> patcher)
    {
      _patcher = patcher;
    }

    public override object Apply(object target)
    {
      return _patcher(target);
    }
  }
}
