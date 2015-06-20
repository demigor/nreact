using System;
using System.Diagnostics;
using System.Dynamic;
using NReact;
using System.Runtime.CompilerServices;

namespace Dynamics
{
  class Program
  {
    class Test
    {
      public string Field;
      public string Field2;
    }

    class Test2 : NDynamic
    {
      static readonly int Field1Handle = GetKey("Field");
      static readonly int Field2Handle = GetKey("Field2");

      public string Field
      {
        get
        {
          return (string)GetByKey(Field1Handle);
        }
        set
        {
          SetByKey(Field1Handle, value);
        }
      }

      public string Field2
      {
        get
        {
          return (string)GetByKey(Field2Handle);
        }
        set
        {
          SetByKey(Field2Handle, value);
        }
      }
    }

    static void Main(string[] args)
    {
      TestProc1("Native POCO", new Test());
      TestProc2("Native NDynamic", new Test2());
      TestProc("Dynamic POCO", new Test());
      TestProc("Dynamic NDynamic", new NDynamic());
      TestProc("Dynamic Expando", new ExpandoObject());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static int CalcSomething(string a, string b)
    {
      return a != null ? 1 : b != null ? 2 : 0;
    }

    static int TestProc1(string test, Test s)
    {
      int x = 0;
      var sw2 = Stopwatch.StartNew();
      {
        s.Field = "sdfasdfds";
        s.Field2 = "asdfasdfasd fasdf";

        for (var i = 0; i < 10000000; i++)
        {
          x += CalcSomething(s.Field, s.Field2);
        }
      }
      sw2.Stop();
      Console.WriteLine("{0} took {1} ms.", test, sw2.ElapsedMilliseconds);
      return x;
    }

    static int TestProc2(string test, Test2 s)
    {
      int x = 0;
      var sw2 = Stopwatch.StartNew();
      {
        s.Field = "sdfasdfds";
        s.Field2 = "asdfasdfasd fasdf";

        for (var i = 0; i < 10000000; i++)
        {
          x += CalcSomething(s.Field, s.Field2);
        }
      }
      sw2.Stop();
      Console.WriteLine("{0} took {1} ms.", test, sw2.ElapsedMilliseconds);
      return x;
    }

    static int TestProc(string test, dynamic s)
    {
      int x = 0;
      var sw2 = Stopwatch.StartNew();
      {
        s.Field = "sdfasdfds";
        s.Field2 = "asdfasdfasd fasdf";

        for (var i = 0; i < 10000000; i++)
        {
          x += CalcSomething(s.Field, s.Field2);
        }
      }
      sw2.Stop();
      Console.WriteLine("{0} took {1} ms.", test, sw2.ElapsedMilliseconds);
      return x;
    }
  }
}

namespace System.Windows
{
  class DependencyProperty
  {
    public static readonly object UnsetValue = new object();
  }
}
