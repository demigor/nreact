using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NReact.Csx
{
  public class TranspileCsx : Task
  {
    static Action<string, object[]> _writeLine = Console.WriteLine;

    public static void WriteLine(string format, params object[] args)
    {
      _writeLine(format, args);
    }

    [Required]
    public string SourceDir { get; set; }

    public override bool Execute()
    {
      _writeLine = Log.LogMessage;

      Log.LogMessage("Starting NReact.TranspileCsx");
      var stopwatch = Stopwatch.StartNew();
      var errors = TranspileDir(SourceDir);
      Log.LogMessage("NReact.TranspileCsx completed in {0}", stopwatch.Elapsed);
      return errors == 0;
    }

    public static void Main(string[] args)
    {
      WriteLine("CSX Transpiler 1.0, Copyright (c) Lex Lavnikov 2015.");

      if (args == null || args.Length == 0)
        WriteLine("Usage: csx {file|directory}");

      int errors = 0;

      foreach (var f in args)
      {
        try
        {
          var dir = (File.GetAttributes(f) & FileAttributes.Directory) != 0;

          errors += dir ? TranspileDir(f) : Transpile(f);
        }
        catch (FileNotFoundException)
        {
          WriteLine("File/Directory {0} not found.", f);
          errors++;
        }
      }

      if (errors > 0)
        Environment.Exit(1);
    }

    static int TranspileDir(string path)
    {
      var result = 0;

      foreach (var f in Directory.EnumerateFiles(path, "*.csx", SearchOption.AllDirectories))
        result += Transpile(f);

      return result;
    }

    static int Transpile(string source)
    {
      try
      {
        var err = new StringBuilder();
        var csx = File.ReadAllText(source);

        var parser = new Parser(csx);
        parser.Errors.ErrorStream = new StringWriter(err);
        parser.Parse();
        parser.Errors.ErrorStream.Flush();

        if (parser.Errors.Count == 0)
        {
          var cs = parser.Result;
          var target = Path.ChangeExtension(source, ".g.cs");
          File.WriteAllText(target, cs);
          WriteLine("{0} -> {1}", source, Path.GetFileName(target));
          return 0;
        }

        WriteLine(err.ToString());
        WriteLine("Errors: {0}", parser.Errors.Count);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
      return 1;
    }
  }
}
