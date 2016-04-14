using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace NReact
{
  public class NPropertyEntry
  {
    internal NPropertyEntry Next;
    /// <summary>
    /// Indicates property key
    /// </summary>
    public readonly NProperty Key;
    /// <summary>
    /// Indicates property value
    /// </summary>
    public object Value { get { return _value; } }
    internal object _value;

    internal NPropertyEntry(NPropertyEntry source)
    {
      Key = source.Key;
      _value = source._value;
    }

    internal NPropertyEntry(NProperty key, object value, NPropertyEntry next)
    {
      Key = key;
      _value = value;
      Next = next;
    }

    /// <summary>
    /// Returns string representation
    /// </summary>
    public override string ToString()
    {
      {
        var e = _value as NElement;
        if (e != null)
          return $" {Key.Name}={e}";
      }

      {
        var a = _value as NElement[];
        if (a != null)
          return $" {Key.Name}=[ {string.Join(", ", a.Select(i => i.ToString()))} ]";
      }

      return $" {Key.Name}=\"{_value}\"";
    }
  }

  /// <summary>
  /// Property-Value linked list
  /// </summary>
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

    /// <summary>
    /// Retrieves value of specified property
    /// </summary>
    /// <param name="key">Property key</param>
    /// <returns>Property value or NUndefined.Instance if it is not set</returns>
    public object Get(NProperty key)
    {
      var e = GetEntry(key);
      return e != null ? e._value : NUndefined.Instance;
    }

    /// <summary>
    /// Retrieves value of specified property
    /// </summary>
    /// <param name="key">Property key</param>
    /// <param name="default">Default value</param>
    /// <returns>Property value or @default if property is not set</returns>
    public T Get<T>(NProperty key, T @default)
    {
      var e = GetEntry(key);
      return e != null ? (T)e._value : @default;
    }

    /// <summary>
    /// Indicates whether specified property is set
    /// </summary>
    /// <param name="key">Property key</param>
    /// <returns>True is property is set, false otherwise</returns>
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

      if (Equals(e._value, value))
        return false;

      e._value = value;
      return true;
    }

    /// <summary>
    /// Returns string representation
    /// </summary>
    public override string ToString()
    {
      return string.Concat(this);
    }

    IEnumerator<NPropertyEntry> IEnumerable<NPropertyEntry>.GetEnumerator()
    {
      for (var i = Head; i != null; i = i.Next)
        yield return i;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return ((IEnumerable<NPropertyEntry>)this).GetEnumerator();
    }
  }
}
