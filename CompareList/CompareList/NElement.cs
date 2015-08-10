namespace NReact
{
  class NElement
  {
    static readonly NElement[] _empty = new NElement[0];

    public object Type;
    public object Key;
    public NElement[] Children = _empty;
    public object Props;

    public override string ToString()
    {
      return string.Concat(Key, " : ", Type);
    }

    public void ReplaceProps(object props)
    {
      Props = props;
    }
  }

  class NComponent : NElement
  {
  }
}
