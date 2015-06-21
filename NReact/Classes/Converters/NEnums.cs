using System;

namespace NReact.Converters
{
  public static class NEnums
  {
    public static bool Convert(object source, Type target, ref object result)
    {
      if (target.IsEnum())
      {
        var s = source as string;
        if (s != null)
        {
          result = Enum.Parse(target, s, true);
          return true;
        }   
      }
      return false;
    }
  }
}
                        