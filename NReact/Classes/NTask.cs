using System;
using System.Diagnostics;
using System.Threading;
#if NETFX_CORE
using Windows.System.Threading;
#endif

namespace NReact
{
  class NDispatcher
  {
    public static readonly NDispatcher Default = new NDispatcher();

#if !NETFX_CORE
    Thread _taskProcessor;
#endif
    AutoResetEvent _signal = new AutoResetEvent(false);
    NTask _head;

    NDispatcher()
    {
#if NETFX_CORE
      ThreadPool.RunAsync(Process);
#else
      _taskProcessor = new Thread(Process) { IsBackground = true };
      _taskProcessor.Start();
#endif
    }

    void Process(object obj)
    {
      try
      {
        while (true)
        {
          _signal.WaitOne();

          var head = Interlocked.Exchange(ref _head, null);

          if (head != null)
            head.BackwardRun();
        }
      }
      catch
      {
        Debugger.Launch();
      }
    }

    void Enqueue(NTask task)
    {
#if DUMP
      Debug.WriteLine("Enqueue " + task);
#endif
      while (true)
      {
        var head = _head;
        task.Next = head;

        if (Interlocked.CompareExchange(ref _head, task, head) == head)
        {
          _signal.Set();
          break;
        }
      }
    }

    public void Enqueue(Action task)
    {
      Enqueue(new NTask { Action = task });
    }

    internal void EnqueueUpdate(NComponent component)
    {
      Enqueue(component.UpdateCore);
    }

    class NTask
    {
      internal NTask Next;
      public Action Action;
      public void BackwardRun()
      {
        if (Next != null)
          Next.BackwardRun();

        Action();
      }
    }
  }
}
