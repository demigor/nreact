using System;

namespace NReact
{
  struct LList<T> where T : LList<T>.Item
  {
    public class Item
    {
      public T Next;
    }

    public T Head, Tail;

    public void Add(T entry)
    {
      if (Head == null)
        Head = entry;
      else
        Tail.Next = entry;

      Tail = entry;
    }

    public int RemoveWhere(Func<T, bool> filter)
    {
      var result = 0;
      var prev = default(T);

      for (var i = Head; i != null; i = i.Next)
      {
        if (filter(i))
        {
          if (prev == null)
            Head = i.Next;
          else
            prev.Next = i.Next;

          result++;
        }
        else
          prev = i;
      }

      Tail = prev;
      return result;
    }
  }
}
