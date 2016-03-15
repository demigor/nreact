namespace NReact
{
  /// <summary>
  /// Represents undefined value
  /// </summary>
  public sealed class NUndefined
  {
    /// <summary>
    /// Undefined value instance 
    /// </summary>
    public static readonly object Instance = new NUndefined();

    NUndefined() { }

    /// <summary>
    /// Returns string representation
    /// </summary>
    public override string ToString()
    {
      return "(Undefined)";
    }
  }
}
