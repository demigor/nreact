using System;
using System.IO;
using Microsoft.Win32;

namespace NReact
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var f = new Generator().Generate();
      var dialog = new SaveFileDialog { FileName = "NProps.generated.WPF.cs" };
      if (dialog.ShowDialog() == true)
      {
        using (var s = dialog.OpenFile())
        using (var sw = new StreamWriter(s))
          sw.Write(f);
      }
    }
  }
}
