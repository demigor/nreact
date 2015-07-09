using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
#if NETFX_CORE
using Windows.System.Threading;
#endif

namespace NReact
{
  public class NDispatcher
  {
    public static readonly NDispatcher Default = new NDispatcher();
    public int ThreadId { get; private set; }

    public static int CurrentThreadId
    {
      get
      {
#if NETFX_CORE
        return Environment.CurrentManagedThreadId;
#else
        return Thread.CurrentThread.ManagedThreadId;
#endif
      }
    }

    public bool IsOnDispatcher()
    {
      return Dispatcher == this;
    }

#if NETFX_CORE
#else
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

    [ThreadStatic]
    static object Dispatcher;

    void Process(object obj)
    {
      var updates = _components = new HashSet<NComponent>();
      Dispatcher = this;
      try
      {
        while (true)
        {
          _signal.WaitOne();

          var head = Interlocked.Exchange(ref _head, null);

          if (head != null)
            head.BackwardRun();

          foreach (var i in updates)
            i.UpdateCore();

          updates.Clear();
        }
      }
      catch
      {
        Debugger.Launch();
      }
      finally
      {
        Dispatcher = null;
      }
    }

    void Enqueue(NTask task)
    {
#if DUMP
      Debug.WriteLine("Enqueue Task");
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

    HashSet<NComponent> _components;

    public void EnqueueUpdate(NComponent component)
    {
      if (IsOnDispatcher())
        _components.Add(component);
      else
        Enqueue(component.UpdateCore);
    }

    public void Enqueue(Action task)
    {
      Enqueue(new NTask { Action = task });
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
