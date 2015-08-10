using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;

namespace NReact
{
  /// <summary>
  /// Lightweight thread-safe property key cache
  /// </summary>
  public class NPropsStore
  {
    NFastRWLock _lock = new NFastRWLock();

    Dictionary<object, int> _ids = new Dictionary<object, int>();
    List<object> _keys = new List<object>();
    int _count;

    public NPropsStore(params object[] defaults)
    {
      for (var i = 0; i < defaults.Length; i++)
        Add(defaults[i]);
    }

    public int this[object key]
    {
      get
      {
        int result;
        int count;

        _lock.EnterReadLock();
        try
        {
          if (_ids.TryGetValue(key, out result))
            return result;

          count = _count;
        }
        finally
        {
          _lock.ExitReadLock();
        }

        _lock.EnterWriteLock();
        try
        {
          if (_count != count && _ids.TryGetValue(key, out result))
            return result;

          return Add(key);
        }
        finally
        {
          _lock.ExitWriteLock();
        }
      }
    }

    int Add(object name)
    {
      _keys.Add(name);
      _ids[name] = _count;

      return _count++;
    }

    public object GetKey(int id)
    {
      if (id < 0 || id >= _count)
        throw new ArgumentException("key");

      _lock.EnterReadLock();
      try
      {
        return _keys[id];
      }
      finally
      {
        _lock.ExitReadLock();
      }
    }
  }
}
