using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace NReact.Csx
{
  public class TranspileCsx : Task
  {
    static Action<string, object[]> _writeLine = Console.WriteLine;

    public static void WriteLine(string format, params object[] args)
    {
      _writeLine(format, args);
    }

    public ITaskItem[] TemplateFiles { get; set; }
    public ITaskItem[] SourceCodeFiles { get; set; }
    [Output]
    public ITaskItem[] GeneratedSourceCodeFiles { get; set; }

    [Required]
    public string OutputPath { get; set; }
    [Required]
    public string ProjectPath { get; set; }

    public override bool Execute()
    {
      _writeLine = Log.LogMessage;

      Log.LogMessage("Starting NReact.TranspileCsx");
      var stopwatch = Stopwatch.StartNew();
      var errors = 0;

      if (TemplateFiles != null)
      {
        var result = new List<ITaskItem>();

        foreach (var i in TemplateFiles)
        {
          var file = i.GetMetadata("FullPath");
          var target = Path.Combine(OutputPath, i.GetMetadata("RelativeDir"));
          var targetDir = Path.Combine(ProjectPath, target);
          if (!Directory.Exists(targetDir))
            Directory.CreateDirectory(targetDir);
          
          target = Path.Combine(target, Path.ChangeExtension(Path.GetFileNameWithoutExtension(file), ".g.cs"));

          Transpile(file, Path.Combine(ProjectPath, target));

          result.Add(new TaskItem { ItemSpec = target });
        }

        GeneratedSourceCodeFiles = result.ToArray();
      }

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

          errors += dir ? TranspileDir(f) : Transpile(f, Path.GetDirectoryName(f));
        }
        catch (FileNotFoundException)
        {
          WriteLine("File/Directory {0} not found.", f);
          errors++;
        }
      }

#if DEBUG
      Console.ReadLine();
#endif


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

    static int Transpile(string source, string target = null)
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

          if (target == null)
            target = Path.ChangeExtension(source, ".g.cs");

          File.WriteAllText(target, cs);
          WriteLine("{0} -> {1}", source, target);
          return 0;
        }

        WriteLine("{0} -> Errors: {1}", source, parser.Errors.Count);
        WriteLine(err.ToString());
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
      return 1;
    }
  }
}
