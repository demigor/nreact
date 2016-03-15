namespace NReact
{
  public sealed class NUndefined
  {
    public static readonly object Instance = new NUndefined();

    NUndefined() { }

    public override string ToString()
    {
      return "(Undefined)";
    }
  }
}
