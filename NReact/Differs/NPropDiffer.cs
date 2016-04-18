using System;
using System.Diagnostics;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace NReact
{
  struct NPropDiffer
  {
    public static NPatch Diff(NElement oldE, ref NElement newE)
    {
      var oldSet = oldE != null;
      var newSet = newE != null;

      if (oldSet == newSet)
      {
        if (!oldSet)
          return null;

        if (NPatch.ElementEquals(oldE, newE))
        {
          var oldC = oldE as NClass;
          if (oldC != null)
          {
            var newC = (NClass)newE;
            newE = oldE;
            return oldC.Upgrade(newC);
          }

          return new NPropDiffer(oldE, newE).Diff();
        }
      }

      return NPatch.AssignNewValue;
    }

    readonly NElement _source, _target;
    readonly Type _type;
    NPropPatchEntry _head, _tail;

    NPropDiffer(NElement source, NElement target)
    {
      _source = source;
      _target = target;
      _type = source.GetXamlType();
      _head = null;
      _tail = null;
    }

    NPatch Diff()
    {
      // TODO: optimize assignment if any of props is empty
      var oldProps = _source.GetCommittedProps();
      var newProps = _target.GetCommittedProps();

      for (var i = oldProps.Head; i != null; i = i.Next)
        if (!newProps.HasKey(i.Key))
          Remove(i.Key, i._value);

      for (var i = newProps.Head; i != null; i = i.Next)
      {
        var key = i.Key;
        var newValue = i._value;

        var e = oldProps.GetEntry(key);
        if (e == null)
          Insert(key, newValue);
        else
        {
          var oldValue = e._value;

          if (!Equals(oldValue, newValue))
          {
            if (Update(key, newValue, oldValue))
              i._value = oldValue;
          }
        }
      }

      return _head != null ? new NPropPatch(_source, _head) : null;
    }

    NPropPatchEntry Add(NProperty key)
    {
      var setter = key[_type];

      if (setter == null)
        Debug.WriteLine($"Warning: Property {_type.Name}.{key.Name} is not supported (2)");

      var result = new NPropPatchEntry { Key = key, Setter = setter };

      if (_tail != null)
        _tail.Next = result;
      else
        _head = result;

      _tail = result;

      return result;
    }

    void Insert(NProperty key, object value)
    {
      Add(key).Value = value;
    }

    void Remove(NProperty key, object value)
    {
      var e = Add(key);
      e.Finalizer = value;
      e.Value = NUnset.Instance;
    }

    bool Update(NProperty key, object newValue, object oldValue)
    {
      #region NElement property
      {
        var oldE = oldValue as NElement;
        var newE = newValue as NElement;

        if (oldE != null || newE != null)
        {
          var s = newE;
          var p = Diff(oldE, ref newE);
          if (p == null)
            return newE != s;

          var e = Add(key);

          if (p == NPatch.AssignNewValue)
          {
            e.Value = newE;
            e.Finalizer = oldValue;
          }
          else
            e.Value = p;

          return false;
        }
      }
      #endregion

      #region NElement[] property
      {
        var oldE = oldValue as NElement[];
        var newE = newValue as NElement[];

        if (oldE != null || newE != null)
        {
          var p = NListDiffer.Diff(oldE, newE);
          if (p == null)
            return false;

          var e = Add(key);

          if (p == NPatch.AssignNewValue)
          {
            e.Value = newE;
            e.Finalizer = oldValue;
          }
          else
            e.Value = p;

          return false;
        }
      }
      #endregion

      {
        var e = Add(key);

        e.Value = newValue;
        e.Finalizer = oldValue;
      }

      return false;
    }
  }
}
