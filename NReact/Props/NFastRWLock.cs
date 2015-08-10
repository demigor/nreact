using System.Diagnostics.Contracts;
using System.Threading;

namespace NReact
{
  struct NFastRWLock
  {
    // if lock is above this value then somebody has a write lock
    const int _writerLock = 1000000;

    public int LockCount;

    public void EnterReadLock()
    {
      var w = new SpinWait();
#if DEBUG
      var c = 0;
#endif
      var tmpLock = LockCount;
      while (tmpLock >= _writerLock || tmpLock != Interlocked.CompareExchange(ref LockCount, tmpLock + 1, tmpLock))
      {
        w.SpinOnce();
        tmpLock = LockCount;
#if DEBUG
        c++;
        Contract.Assert(c < 10000, "Spin exceeded");
#endif
      }
    }

    public void EnterWriteLock(bool upgrade = false)
    {
      var w = new SpinWait();
      var requiredLockCount = upgrade ? 1 : 0;

#if DEBUG
      var actualLockCount = Interlocked.CompareExchange(ref LockCount, _writerLock, requiredLockCount);
      if (actualLockCount == requiredLockCount) return;

      Contract.Assert(!upgrade || actualLockCount != 0, "No read locks detected. At least own should be present");

      var c = 0;
#endif

      while (Interlocked.CompareExchange(ref LockCount, _writerLock, requiredLockCount) != requiredLockCount)
      {
        w.SpinOnce();
#if DEBUG
        c++;
        Contract.Assert(c < 10000, "Spin exceeded");
#endif
      }
    }

    public void ExitReadLock()
    {
      Interlocked.Decrement(ref LockCount);
    }

    public void ExitWriteLock()
    {
      LockCount = 0;
    }
  }

#if SILVERLIGHT
  struct SpinWait
  {
    public void SpinOnce()
    {
      Thread.SpinWait(1);
    }
  }
#endif
}