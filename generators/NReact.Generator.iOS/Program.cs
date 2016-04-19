using System;
using System.IO;
using System.Windows.Forms;

namespace NReact
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var f = new Generator().Generate();
      var dialog = new SaveFileDialog { FileName = "NProps.generated.iOS.cs" };
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        using (var s = dialog.OpenFile())
        using (var sw = new StreamWriter(s))
          sw.Write(f);
      }
    }
  }
}
