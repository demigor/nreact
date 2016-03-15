using System;
using System.Diagnostics;

namespace NReact
{
  /// <summary>
  /// Effective dictionary keyed by hierarchical Type for small number of items
  /// </summary>
  struct NTypedBag<T>
  {
    class NEntry
    {
      public NEntry Next;
      public readonly Type Type;
      public T Value;

      public NEntry(Type type, T value)
      {
        Type = type;
        Value = value;
      }

      public NEntry(Type type, T value, NEntry next) : this(type, value)
      {
        Next = next;
      }
    }

    NEntry _head;

    public T this[Type type]
    {
      get
      {
        for (var i = _head; i != null; i = i.Next)
          if (i.Type.IsAssignableFrom(type))
            return i.Value;

        return default(T);
      }
      set
      {
        var prev = default(NEntry);

        for (var i = _head; i != null; i = i.Next)
        {
          if (type == i.Type)
          {
            Debug.WriteLine($"Warning: Setter for type ({type.Name}) has been already registered");
            i.Value = value;
            return;
          }

          if (type.IsAssignableFrom(i.Type))
          {
            var e = new NEntry(type, value, i);
            if (prev == null)
            {
              _head = e;
            }
            else
            {
              prev.Next = e;
            }
            return;
          }

          prev = i;
        }

        {
          var e = new NEntry(type, value);
          if (prev == null)
            _head = e;
          else
            prev.Next = e;
        }
      }
    }
  }
}
