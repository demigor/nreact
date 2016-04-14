using System;

namespace NReact
{
  struct NListDiffer
  {
    public static NPatch Diff(NElement[] source, NElement[] target)
    {
      var oldSet = source != null;
      var newSet = target != null;

      if (oldSet == newSet)
      { 
        if (!oldSet)
          return null;
          
        return new NListDiffer(source, target).Diff();
      }

      return NPatch.AssignNewValue;
    }

    readonly NElement[] _source, _target;

    NListDiffer(NElement[] source, NElement[] target)
    {
      _source = source;
      _target = target;
      _head = null;
      _tail = null;
    }

    NListPatchEntry _head, _tail;

    NPatch Diff()
    {
      var cOld = _source.Length;
      var cNew = _target.Length;

      if (cOld == 0 || cNew == 0)
        return NPatch.AssignNewValue;

      var iOld = 0;
      var iNew = 0;
      var iFix = 0;

      for (;;)
      {
        var oldH = iOld < cOld;
        var oldE = oldH ? _source[iOld] : null;

        var newH = iNew < cNew;
        var newE = newH ? _target[iNew] : null;

        if (oldH)
        {
          if (newH && NPatch.ElementEquals(oldE, newE))
          {
            Update(iOld + iFix, newE, oldE);
            iNew++;
          }
          else
          {
            Remove(iOld + iFix, oldE);
            iFix--;
          }
          iOld++;
        }
        else
        {
          if (newH)
          {
            Insert(iOld + iFix, newE);
            iOld++;
            iNew++;
          }
          else
            break;
        }
      }

      Optimize();

      TransferClasses();

      return _head != null ? new NListPatch(_head) : null;
    }

    void Optimize()
    {
      for (var i = _head; i != null; i = i.Next)
        switch (i.Op)
        {
          case NListPatchOp.Insert: OptimizeInsert(i); break;
          case NListPatchOp.Remove: OptimizeRemove(i); break;
        }
    }

    void OptimizeInsert(NListPatchEntry e)
    {
      var delta = 0;
      var newE = e.Finalizer;
      var last = e;

      for (var i = e.Next; i != null; i = i.Next)
      {
        switch (i.Op)
        {
          case NListPatchOp.Remove:
            {
              var oldE = i.Value;

              if (NPatch.ElementEquals(newE, oldE))
              {
                e.Op = NListPatchOp.Move;      // transform to move operation
                e.Finalizer = null;            // remove finalizer
                e.iRemove = i.iRemove + delta; // correct removal index at the time of move
                e.Value = oldE;                // preserve moved value
                e.Patch = NPropDiffer.Diff(oldE, ref newE); // make patch

                last.Next = i.Next; // delete removal
                return;
              }
              delta++;
            }
            break;

          case NListPatchOp.Insert:
            delta--;
            break;
        }
        last = i;
      }

    }

    void OptimizeRemove(NListPatchEntry e)
    {
      var delta = 0;
      var oldE = e.Finalizer;
      var last = e;

      for (var i = e.Next; i != null; i = i.Next)
      {
        switch (i.Op)
        {
          case NListPatchOp.Insert:
            {
              var newE = i.Value;

              if (NPatch.ElementEquals(newE, oldE))
              {
                e.Op = NListPatchOp.Move;      // transform to move
                e.Finalizer = null;            // remove finalizer
                e.iInsert = i.iInsert + delta; // correct insert index at the time of move
                e.iFinal = i.iFinal;           // preserve final index
                e.Patch = NPropDiffer.Diff(oldE, ref newE); // make patch
                e.Value = oldE;                // preserve moved value

                last.Next = i.Next; // delete insertion
                return;
              }
              delta--;
            }
            break;

          case NListPatchOp.Remove:
            delta++;
            break;
        }
        last = i;
      }

    }

    void TransferClasses()
    {
      for (var i = _head; i != null; i = i.Next)
        if (i.Op == NListPatchOp.Move && i.Value is NClass)
          _target[i.iFinal] = i.Value;
    }

    void Add(NListPatchEntry entry)
    {
      if (_tail != null)
        _tail.Next = entry;
      else
        _head = entry;

      _tail = entry;
    }

    void Insert(int idx, NElement newE)
    {
      Add(new NListPatchEntry { Op = NListPatchOp.Insert, Value = newE, iInsert = idx, iFinal = idx });
    }

    void Remove(int idx, NElement oldE)
    {
      Add(new NListPatchEntry { Op = NListPatchOp.Remove, iRemove = idx, Finalizer = oldE });
    }

    void Update(int idx, NElement newE, NElement oldE)
    {
      if (oldE is NClass)
        _target[idx] = oldE; // transfer updated classes

      var p = NPropDiffer.Diff(oldE, ref newE);
      if (p != null)
        Add(new NListPatchEntry { Op = NListPatchOp.Patch, Value = oldE, iFinal = idx, Patch = p });
    }
 }
}
