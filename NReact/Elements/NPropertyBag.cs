using System;
using System.Collections;
using System.Collections.Generic;

namespace NReact
{
  public class NPropertyEntry
  {
    internal NPropertyEntry Next;
    public readonly NProperty Key;
    internal object Value;

    internal NPropertyEntry(NPropertyEntry source)
    {
      Key = source.Key;
      Value = source.Value;
    }

    internal NPropertyEntry(NProperty key, object value, NPropertyEntry next)
    {
      Key = key;
      Value = value;
      Next = next;
    }

    public override string ToString()
    {
      return $" {Key.Name} = \"{Value}\"";
    }
  }

  public struct NPropertyBag : IEnumerable<NPropertyEntry>
  {
    internal NPropertyEntry Head;

    internal NPropertyEntry GetEntry(NProperty key)
    {
      for (var i = Head; i != null; i = i.Next)
        if (ReferenceEquals(i.Key, key))
          return i;

      return null;
    }

    public object Get(NProperty key)
    {
      var e = GetEntry(key);
      return e != null ? e.Value : NUndefined.Instance;
    }

    public T Get<T>(NProperty key, T @default)
    {
      var e = GetEntry(key);
      return e != null ? (T)e.Value : @default;
    }

    public bool HasKey(NProperty key)
    {
      return GetEntry(key) != null;
    }

    internal NPropertyBag Clone()
    {
      if (Head == null)
        return new NPropertyBag();

      var result = new NPropertyEntry(Head);
      var tail = result;

      for (var i = Head.Next; i != null; i = i.Next)
      {
        var e = new NPropertyEntry(i);
        tail.Next = e;
        tail = e;
      }

      return new NPropertyBag { Head = result };
    }

    internal bool Remove(NProperty key)
    {
      var last = default(NPropertyEntry);

      for (var i = Head; i != null; i = i.Next)
      {
        if (ReferenceEquals(i.Key, key))
        {
          if (last == null)
          {
            Head = i.Next;
          }
          else
          {
            last.Next = i.Next;
          }

          i.Next = null;

          return true;
        }

        last = i;
      }

      return false;
    }

    internal bool Set(NProperty key, object value)
    {
      var e = GetEntry(key);

      if (e == null)
      {
        Head = new NPropertyEntry(key, value, Head);
        return true;
      }

      if (Equals(e.Value, value))
        return false;

      e.Value = value;
      return true;
    }

    public override string ToString()
    {
      return string.Concat(this);
    }

    public IEnumerator<NPropertyEntry> GetEnumerator()
    {
      for (var i = Head; i != null; i = i.Next)
        yield return i;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
