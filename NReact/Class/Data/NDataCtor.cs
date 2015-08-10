using System;

namespace NReact
{
  /// <summary>
  /// Properties Constructor
  /// </summary>
  public sealed class NDataCtor
  {
    internal NDataBag Head, Tail;

    public NDataCtor Add(object key, object value)
    {
      return Add(NProps.Store[key], value);
    }
    public NDataCtor Add(int id, object value)
    {
      var data = new NDataBag(id, value);

      if (Head == null)
        Head = data;
      else
        Tail.Next = data;

      Tail = data;

      return this;
    }

    public NDataCtor Add(object key, Delegate value) { return Add(NProps.Store[key], value); }
    public NDataCtor Add(int id, Delegate value) { return Add(id, (object)value); }

    public NDataCtor Add(object key, Action value) { return Add(NProps.Store[key], value); }
    public NDataCtor Add(int id, Action value) { return Add(id, (object)value); }

    public NDataCtor Add(object key, Action<object> value) { return Add(NProps.Store[key], value); }
    public NDataCtor Add(int id, Action<object> value) { return Add(id, (object)value); }

    public NDataCtor Add(object key, EventHandler value) { return Add(NProps.Store[key], value); }
    public NDataCtor Add(int id, EventHandler value) { return Add(id, (object)value); }

    public NDataCtor Add<T>(object key, EventHandler<T> value) where T : EventArgs { return Add(NProps.Store[key], value); }
    public NDataCtor Add<T>(int id, EventHandler<T> value) where T : EventArgs { return Add(id, (object)value); }

#if DEBUG
    public override string ToString()
    {
      return string.Concat(Head);
    }
#endif
  }
}
