using System.Collections.Generic;

namespace NReact
{
  public static class NDataBagExtensions
  {
    /// <summary>
    /// Extracts value by key from NDataBag linked list
    /// </summary>
    /// <returns>Returns NUndefined.Instance if not found</returns>
    public static object Get(this NDataBag source, int key)
    {
      for (var i = source; i != null; i = i.Next)
        if (i.Id == key)
          return i.Value;

      return NUndefined.Instance;
    }

    public static T Get<T>(this NDataBag source, int key, T @default)
    {
      var result = source.Get(key);

      if (result == NUndefined.Instance)
        return @default;

      return (T)result;
    }

    public static NDataBag Set(this NDataBag source, int key, object value)
    {
      for (var i = source; i != null; i = i.Next)
      {
        if (i.Sealed)
          break;

        if (i.Id == key)
        {
          i.Value = value;
          return source;
        }
      }

      return new NDataBag(source, key, value);
    }

    /*
        public static NNanoData Remove(this NNanoData source, int key, ref object value)
        {
          var seal = false;
          var head = default(NNanoData);
          var last = default(NNanoData);

          for (var i = source; i != null; i = i.Next)
          {
            seal = seal || i._sealed;

            if (i.Key == key)
            {
              if (seal)
                return new NNanoData(source, key, value);

              value = i.Value;

              if (head == null)
                head = i.Next;
              else
                last.Next = i.Next;

              return head;
            }
            last = i;
          }

          value = NNanoData.Undefined;
          return source;
        }
    */

    public static NDataBag Seal(this NDataBag source)
    {
      if (source == null)
        return null;

      // looking for a sealed head
      var tail = default(NDataBag);
      var head = default(NDataBag);

      for (var i = source; i != null; i = i.Next)
      {
        if (i.Sealed)
        {
          head = i;
          break;
        }

        tail = i;
      }

      if (head != null && tail != null)
      {
        // removing duplicates in sealed area
        for (var i = source; i != null; i = i.Next)
        {
          var last = tail;

          for (var j = last.Next; j != null; j = j.Next)
          {
            if (j.Id == i.Id)
              last.Next = j.Next;
            else
              last = j;
          }

          if (i == tail)
            break;
        }
      }

      source.Sealed = true;
      return source;
    }
  }
}
