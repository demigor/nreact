using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
#if NETFX_CORE
using Windows.Foundation;
using Windows.System.Threading;
#endif

namespace NReact
{
  public class NDispatcher
  {
    public static readonly NDispatcher Default = new NDispatcher();
    public int ThreadId { get; private set; }

    static int CurrentThreadId
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
#if THREADSTATIC
      return Dispatcher == this;
#else
      return ThreadId == CurrentThreadId;
#endif
    }

#if NETFX_CORE
    IAsyncAction _taskProcessor;
#else
    Thread _taskProcessor;
#endif
    AutoResetEvent _signal = new AutoResetEvent(false);
    NTask _head;

    NDispatcher()
    {
#if NETFX_CORE
      _taskProcessor = ThreadPool.RunAsync(Process, WorkItemPriority.Normal, WorkItemOptions.TimeSliced);
#else
      _taskProcessor = new Thread(Process) { IsBackground = true };
      _taskProcessor.Start();
#endif
    }

#if THREADSTATIC
    [ThreadStatic]
    static object Dispatcher;
#endif

    void Process(object obj)
    {
      var updates = _classes = new List<NClass>();
#if THREADSTATIC
      Dispatcher = this;
#else
      ThreadId = CurrentThreadId;
#endif
      try
      {
        while (true)
        {
          _signal.WaitOne();

          var head = Interlocked.Exchange(ref _head, null);

          if (head != null)
            head.BackwardRun();

          for (var i = 0; i < updates.Count; i++)
            updates[i].Flush();

          updates.Clear();
        }
      }
      catch (Exception e)
      {
#if DEBUG
        Debugger.Launch();
#endif
      }
      finally
      {
#if THREADSTATIC
        Dispatcher = null;
#endif
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

    List<NClass> _classes;

    public void Enqueue(NClass target)
    {
      if (IsOnDispatcher())
        _classes.Add(target);
      else
        Enqueue(new NUpdateTask { Target = target });
    }

    public void Enqueue(Action task)
    {
      Enqueue(new NActionTask { Task = task });
    }

    public void Enqueue(MessageArgs msg)
    {
      Enqueue(new NMessageTask { Message = msg, Dispatcher = this });
    }

    public EventHandler<MessageArgs> OnMessage;

    abstract class NTask
    {
      public NTask Next;
      public abstract void Action();
      public void BackwardRun()
      {
        if (Next != null)
          Next.BackwardRun();

        try
        {
          Action();
        }
        catch (Exception e)
        {
          Debug.WriteLine("Error in NTask " + e.Message);
        }
      }
    }

    class NUpdateTask : NTask
    {
      public NClass Target;

      public override void Action()
      {
        Target.Flush();
      }
    }

    class NActionTask : NTask
    {
      public Action Task;
      public override void Action()
      {
        Task();
      }
    }

    class NMessageTask : NTask
    {
      public NDispatcher Dispatcher;
      public MessageArgs Message;

      public override void Action()
      {
        Dispatcher.Dispatch(Message);
      }
    }

    void Dispatch(MessageArgs message)
    {
      OnMessage?.Invoke(this, message);
    }
  }

  public class MessageArgs : EventArgs
  {
    public MessageArgs(object key, object msg)
    {
      Key = key;
      Message = msg;
    }
    public readonly object Key;
    public readonly object Message;
  }
}

