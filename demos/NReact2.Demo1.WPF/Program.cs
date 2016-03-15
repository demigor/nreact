using System;
using System.Windows;

namespace NReact.Demos
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var app = new Application();
      app.MainWindow = Test1(app);
      //app.MainWindow = Test2(app);
      app.Run();
    }

    static Window Test1(Application app)
    {
      var window = new Window { Visibility = Visibility.Visible };
      window.Render(new Demo1());
      return window;
    }

    static Window Test2(Application app)
    {
      var window = new Window { Visibility = Visibility.Visible };
      window.Render(new Demo2());
      return window;
    }
  }
}
