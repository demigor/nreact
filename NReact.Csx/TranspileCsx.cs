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
    public ITaskItem[] TemplateFiles { get; set; }
    public ITaskItem[] SourceCodeFiles { get; set; }
    [Output]
    public ITaskItem[] GeneratedSourceCodeFiles { get; set; }

    [Required]
    public string OutputPath { get; set; }
    [Required]
    public string ProjectPath { get; set; }

    void LogError(ParserError obj)
    {
      Log.LogError("Code", "CSX" + obj.Code, "N/A", _currentFile, obj.Line, obj.Column, obj.Line, obj.Column, obj.Message);
    }

    string _currentFile;

    public override bool Execute()
    {
      Log.LogMessage("Starting NReact.TranspileCsx");
      var stopwatch = Stopwatch.StartNew();
      var errors = 0;

      if (TemplateFiles != null)
      {
        var result = new List<ITaskItem>();
        var transpiler = new Transpiler { LogError = LogError, LogMessage = Log.LogMessage };
        foreach (var i in TemplateFiles)
        {
          var file = i.GetMetadata("FullPath");
          var target = Path.Combine(OutputPath, i.GetMetadata("RelativeDir"));
          var targetDir = Path.Combine(ProjectPath, target);
          if (!Directory.Exists(targetDir))
            Directory.CreateDirectory(targetDir);

          target = Path.Combine(target, Path.ChangeExtension(Path.GetFileNameWithoutExtension(file), ".g.cs"));

          _currentFile = file;

          if (!transpiler.TranspileFile(file, Path.Combine(ProjectPath, target)))
            errors++;

          result.Add(new TaskItem { ItemSpec = target });
        }

        GeneratedSourceCodeFiles = result.ToArray();
      }

      Log.LogMessage("NReact.TranspileCsx completed in {0}", stopwatch.Elapsed);
      return errors == 0;
    }

    public static void Main(string[] args)
    {
      Console.WriteLine("CSX Transpiler 1.0, Copyright (c) Lex Lavnikov 2015.");

      if (args == null || args.Length == 0)
        Console.WriteLine("Usage: csx {file|directory}");

      int errors = 0;

      foreach (var f in args)
      {
        try
        {
          var dir = (File.GetAttributes(f) & FileAttributes.Directory) != 0;

          errors += dir ? TranspileDir(f) : (Transpile(f, Path.GetDirectoryName(f)) ? 1 : 0);
        }
        catch (FileNotFoundException)
        {
          Console.WriteLine("File/Directory {0} not found.", f);
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
        if (!Transpile(f))
          result++;

      return result;
    }

    static bool Transpile(string source, string target = null)
    {
      return new Transpiler { LogError = ConsoleLogError, LogMessage = Console.WriteLine }.TranspileFile(source, target);
    }

    static void ConsoleLogError(ParserError obj)
    {
      Console.WriteLine("Line {0}, Column {1}, {2}", obj.Line, obj.Column, obj.Message);
    }
  }

  public class Transpiler
  {
    public Action<ParserError> LogError;
    public Action<string, object[]> LogMessage = Console.WriteLine;

    public bool TranspileFile(string source, string target = null)
    {
      try
      {
        var csx = File.ReadAllText(source);

        string result;
        if (TranspileSource(csx, out result))
        {
          if (target == null)
            target = Path.ChangeExtension(source, ".g.cs");

          File.WriteAllText(target, result);
          LogMessage("{0} -> {1}", new[] { source, target });
          return true;
        }
      }
      catch (Exception e)
      {
        if (LogError == null)
          LogMessage(e.Message, new object[0]);
        else
          LogError(new ParserError { Message = e.Message });
      }
      return false;
    }

    public bool TranspileSource(string csx, out string cs)
    {
      cs = null;

      var parser = new Parser(csx) { OnError = LogError };
      parser.Parse();

      if (parser.Errors.Count == 0)
      {
        cs = parser.Result;
        return true;
      }

      return false;
    }
  }
}
