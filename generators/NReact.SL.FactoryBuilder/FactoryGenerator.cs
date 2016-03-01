using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Input;
#if NETFX_CORE
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Markup;
using Cursor = Windows.UI.Core.CoreCursorType;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Input;
#endif

namespace NReact.FactoryBuilder
{
  public class FactoryGenerator
  {
    StringBuilder _sb = new StringBuilder();
    HashSet<string> _ns = new HashSet<string> { "System" };
    HashSet<string> _ps = new HashSet<string>();
    List<Tuple<Type, string>> _ccs = new List<Tuple<Type, string>>();

    static IEnumerable<Assembly> GetAssemblies()
    {
      yield return typeof(UIElement).Assembly();
      yield return typeof(Button).Assembly();
    }

    static IEnumerable<Type> GetTypes()
    {
      var subjects = from a in GetAssemblies().Distinct()
                     from t in a.GetTypes()
                     where !t.IsInterface() && t.IsPublic() && !t.IsGenericTypeDefinition()
                     select t;

      var types = subjects.GroupBy(i => i.BaseType() ?? typeof(object)).ToDictionary(i => i.Key, i => i.ToArray());

      foreach (var type in GetTypesRecursive(typeof(UIElement), types))
        yield return type;

      foreach (var type in GetTypesRecursive(typeof(TextElement), types))
        yield return type;

      yield return typeof(ColumnDefinition);
      yield return typeof(RowDefinition);
      yield return typeof(ToolTipService);

#if !NETFX_CORE
      yield return typeof(TextOptions);
#endif
    }

    static IEnumerable<Type> GetTypesRecursive(Type type, Dictionary<Type, Type[]> types)
    {
      yield return type;

      Type[] nested;
      if (types.TryGetValue(type, out nested))
        foreach (var n in nested)
          foreach (var i in GetTypesRecursive(n, types))
            yield return i;
    }

    public string Generate()
    {
      _sb.AppendLine();
      _sb.AppendLine("namespace NReact");
      _sb.AppendLine("{");
      GenerateNFactory();
      GenerateNProps();
      _sb.AppendLine("}");

      return string.Concat(from s in _ns orderby s select "using " + s + ";" + Environment.NewLine) + _sb;
    }

    void GenerateNFactory()
    {
      _sb.AppendLine("  public partial class NXamlFactory: NFactory");
      _sb.AppendLine("  {");
      _sb.AppendLine("    public NXamlFactory()");
      _sb.AppendLine("    {");
      GenerateClasses(GetContents(GetTypes()));
      _sb.AppendLine("    }");


      if (_ccs.Count > 0)
      {
        _sb.AppendLine();
        _sb.AppendLine("    public override int GetContentKey(Type type)");
        _sb.AppendLine("    {");
        _sb.AppendLine("      if (typeof(NClass).IsAssignableFrom(type)) return NProps.Children;");

        foreach (var i in _ccs)
          _sb.AppendLine($"      if (typeof({i.Item1.Name}).IsAssignableFrom(type)) return NProps.{i.Item2};");

        _sb.AppendLine();
        _sb.AppendLine("      return NProps.CONTENT;");
        _sb.AppendLine("    }");
      }


      foreach (var i in _generators)
        foreach (var s in i.Result)
          _sb.AppendLine(s);

      _sb.AppendLine("  }");
    }

    IEnumerable<Type> GetContents(IEnumerable<Type> types)
    {
      foreach (var i in types)
      {
        var cc = i.GetContentAttribute();
        if (cc != null)
        {
          _ns.Add(i.Namespace);
          _ccs.Add(Tuple.Create(i, cc));
          _ps.Add(cc);
        }

        yield return i;
      }
      _ccs.Reverse();
    }

    static HashSet<string> KnownProps = new HashSet<string> { "Key", "Ref", "Items", "RowDefinitions", "ColumnDefinitions", "Children", "Blocks", "Inlines" };

    void GenerateNProps()
    {
      _sb.AppendLine();
      _sb.AppendLine("  public partial class NProps");
      _sb.AppendLine("  {");

      foreach (var i in _ps.OrderBy(i => i))
        if (!KnownProps.Contains(i))
          _sb.AppendLine($"    public static readonly int {i} = Store[\"{i}\"];");

      _sb.AppendLine("  }");
    }

    void GenerateClasses(IEnumerable<Type> types)
    {
      foreach (var type in types)
      {
        var g = new ClassGenerator(type) { UseNamespace = i => _ns.Add(i), UseProperty = i => _ps.Add(i) };
        g.Result = g.Generate().ToList();
        if (g.Result.Count > 4)
        {
          _sb.AppendLine("      Generate" + type.Name + "();");
          _generators.Add(g);
        }
      }
    }

    List<ClassGenerator> _generators = new List<ClassGenerator>();
  }

  public class ClassGenerator
  {
    Type _type;
    Dictionary<string, MemberInfo> _dProps, _rEvents;
    public List<string> Result;

    public ClassGenerator(Type type)
    {
      _type = type;

      var allFields = _type.GetPublicStaticFields();
      var allProps = _type.GetPublicStaticProperties();

      {
        var fields = allFields.Where(IsDependencyField).OfType<MemberInfo>();
        var props = allProps.Where(IsDependencyProperty).OfType<MemberInfo>();
        _dProps = fields.Concat(props).ToDictionary(i => i.Name.Substring(0, i.Name.Length - 8));
      }

      {
        var fields = allFields.Where(IsRoutedEventField).OfType<MemberInfo>();
        var props = allProps.Where(IsRoutedEventProperty).OfType<MemberInfo>();
        _rEvents = fields.Concat(props).ToDictionary(i => i.Name.Substring(0, i.Name.Length - 5));
      }
    }

    public IEnumerable<string> Generate()
    {
      yield return "";
      yield return "    void Generate" + _type.Name + "()";
      yield return "    {";

      foreach (var i in GenerateProperties())
        yield return i;

      foreach (var i in GenerateAttachedProperties())
        yield return i;

      foreach (var i in GenerateRoutedEvents())
        yield return i;

      foreach (var i in GenerateEvents())
        yield return i;

      yield return "    }";
    }

    IEnumerable<string> GenerateEvents()
    {
      var props = _type.GetPublicInstanceEvents().OrderBy(i => i.Name);

      foreach (var prop in props)
      {
        var args = prop.EventHandlerType.GetMethod("Invoke").GetParameters();
        if (args.Length != 2 || args[0].ParameterType != typeof(object)) continue;

        var payload = args[1].ParameterType;
        var eh = typeof(EventArgs).IsAssignableFrom(payload) ? "" : "Any";

        yield return $"      RegisterEvent<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}, (s, a) => s.{SafePropertyName(prop.Name)} += a.EventHandler{eh});";
      }
    }

    IEnumerable<string> GenerateRoutedEvents()
    {
      var props = _type.GetPublicInstanceEvents().OrderBy(i => i.Name);

      foreach (var prop in props)
      {
        MemberInfo dep;
        if (_rEvents.TryGetValue(prop.Name, out dep))
        {
          var eht = prop.EventHandlerType;
          var args = eht.GetMethod("Invoke").GetParameters();
          if (args.Length != 2 || args[0].ParameterType != typeof(object)) continue;

          var payload = args[1].ParameterType;
          var eh = typeof(EventArgs).IsAssignableFrom(payload) ? "" : "Any";

          yield return $"      RegisterEvent<{SafeTypeName(_type)}>(NProps.{SafePropertyName("_" + prop.Name)}, {SafeTypeName(_type)}.{dep.Name}, a => ({SafeTypeName(eht)})a.EventHandler{eh});";
        }
      }
    }

    IEnumerable<string> GenerateAttachedProperties()
    {
      var props = _type.GetPublicStaticMethods().Where(i => i.Name.StartsWith("Get") || i.Name.StartsWith("Set")).ToDictionary(i => i.Name);

      foreach (var dep in _dProps)
      {
        MethodInfo getter, setter;
        if (!props.TryGetValue("Get" + dep.Key, out getter) || getter.ReturnType == typeof(void)) continue;
        var getterParams = getter.GetParameters();
        if (getterParams.Length != 1) continue;

        if (!props.TryGetValue("Set" + dep.Key, out setter) || setter.ReturnType != typeof(void)) continue;
        var setterParams = setter.GetParameters();
        if (setterParams.Length != 2) continue;

        var ut = getterParams[0].ParameterType;
        if (ut != setterParams[0].ParameterType) continue;
        if (getter.ReturnType != setterParams[1].ParameterType) continue;

        var converter = GetDPConverter(getter);

        UseNamespace(ut.Namespace);
        yield return $"      Register<{SafeTypeName(ut)}>(NProps.{SafePropertyName(_type.Name + dep.Key)}, {SafeTypeName(_type)}.{dep.Value.Name}{converter});";
      }
    }

    static bool IsDependencyField(FieldInfo info)
    {
      return info.Name.EndsWith("Property") && info.FieldType == typeof(DependencyProperty);
    }
    static bool IsDependencyProperty(PropertyInfo info)
    {
      return info.Name.EndsWith("Property") && info.PropertyType == typeof(DependencyProperty) && info.CanRead;
    }

    static bool IsRoutedEventField(FieldInfo info)
    {
      return info.Name.EndsWith("Event") && info.FieldType == typeof(RoutedEvent);
    }
    static bool IsRoutedEventProperty(PropertyInfo info)
    {
      return info.Name.EndsWith("Event") && info.PropertyType == typeof(RoutedEvent) && info.CanRead;
    }

    public Action<string> UseNamespace;
    public Action<string> UseProperty;

    public string SafeTypeName(Type type)
    {
#if NETFX_CORE
      if (type == typeof(Windows.Globalization.DayOfWeek))
      {
        UseNamespace("WGDayOfWeek = Windows.Globalization.DayOfWeek");
        return "WGDayOfWeek";
      }
#endif
      if (UseNamespace != null)
        UseNamespace(type.Namespace);

      if (type.IsGenericType())
      {
        var name = type.GetGenericTypeDefinition().Name;

        return name.Substring(0, name.Length - 2) + "<" + string.Join(", ", type.GetGenericArguments().Select(SafeTypeName)) + ">";
      }

      return type.Name;
    }

    public string SafePropertyName(string name)
    {
      if (UseProperty != null)
        UseProperty(name);

      return name;
    }

    IEnumerable<string> GenerateProperties()
    {
      var props = _type.GetPublicInstanceProperties().OrderBy(i => i.Name);

      foreach (var prop in props)
      {
        if (prop.PropertyType.IsListOfT())
        {
          yield return $"      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}, (t, v) => AssignListT(t.{prop.Name}, v));";
        }
        else if (prop.PropertyType.IsList())
        {
          yield return $"      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}, (t, v) => AssignList(t.{prop.Name}, v));";
        }
        else if (prop.CanWrite && prop.GetSetMethod() != null)
        {
          if (prop.PropertyType == typeof(Brush))
          {
            yield return $"      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}, (t, v) => t.{prop.Name} = NConverters.ToBrushT(v, t.{prop.Name}));";
          }
          else
          {
            var dep = GetDPMember(prop.Name);

            if (dep != null)
            {
              var converter = GetDPConverter(prop);
              yield return $"      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}, {SafeTypeName(_type)}.{dep.Name}{converter});";
            }
            else
            {
              var converter = GetNPConverter(prop);
              if (converter == null)
                yield return $"//      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)});";
              else
                yield return $"      Register<{SafeTypeName(_type)}>(NProps.{SafePropertyName(prop.Name)}{converter});";
            }
          }
        }
      }
    }

    MemberInfo GetDPMember(string name)
    {
      MemberInfo result;
      _dProps.TryGetValue(name, out result);
      return result;
    }

    string GetDPConverter(PropertyInfo prop)
    {
      return GetDPConverter(prop.DeclaringType, prop.Name, prop.PropertyType);
    }

    string GetDPConverter(MethodInfo getter)
    {
      return GetDPConverter(getter.DeclaringType, getter.Name.Substring(3), getter.ReturnType);
    }

    string GetDPConverter(Type cls, string propName, Type propType)
    {
      if (propType == typeof(object)) return null;
      if (propType == typeof(IEnumerable)) return null;
      if (propType == typeof(ICommand)) return null;
#if SILVERLIGHT
      if (propType == typeof(FontSource)) return null;
#endif
      if (propType == typeof(ResourceDictionary)) return null;

      if (propType.IsEnum()) return $", NConverters.ToEnum<{SafeTypeName(propType)}>";
      if (propType == typeof(string)) return ", NConverters.ToString";
      if (propType == typeof(bool)) return ", NConverters.ToBool";
      if (propType == typeof(bool?)) return ", NConverters.ToBoolN";
      if (propType == typeof(int)) return ", NConverters.ToInt32";
      if (propType == typeof(int?)) return ", NConverters.ToInt32N";
      if (propType == typeof(double))
      {
        if (cls == typeof(FrameworkElement) && (propName == "Width" || propName == "Height"))
          return ", NConverters.ToLength";

        return ", NConverters.ToDouble";
      }
      if (propType == typeof(double?)) return ", NConverters.ToDoubleN";
      if (propType == typeof(float)) return ", NConverters.ToSingle";
      if (propType == typeof(Point)) return ", NConverters.ToPoint";
      if (propType == typeof(Color)) return ", NConverters.ToColor";
      if (propType == typeof(char)) return ", NConverters.ToChar";
      if (propType == typeof(TimeSpan)) return ", NConverters.ToTimeSpan";
      if (propType == typeof(DateTimeOffset)) return ", NConverters.ToDateTimeOffset";
      if (propType == typeof(DateTimeOffset?)) return ", NConverters.ToDateTimeOffsetN";
      if (propType == typeof(Cursor)) return ", NConverters.ToCursor";
#if !NETFX_CORE
      if (propType == typeof(XmlLanguage)) return ", NConverters.ToLanguage";
      if (propType == typeof(TextDecorationCollection)) return ", NConverters.ToTextDecorations";
#endif
      if (propType == typeof(Thickness)) return ", NConverters.ToThickness";
      if (propType == typeof(FontFamily)) return ", NConverters.ToFontFamily";
      if (propType == typeof(FontStretch)) return ", NConverters.ToFontStretch";
      if (propType == typeof(FontStyle)) return ", NConverters.ToFontStyle";
      if (propType == typeof(FontWeight)) return ", NConverters.ToFontWeight";
      if (propType == typeof(GridLength)) return ", NConverters.ToGridLength";
      if (propType == typeof(CornerRadius)) return ", NConverters.ToCornerRadius";
      if (propType == typeof(Uri)) return ", NConverters.ToUri";
      if (propType == typeof(Style)) return ", NConverters.ToStyle";
      if (propType == typeof(DataTemplate)) return ", NConverters.ToDataTemplate";
      if (propType == typeof(ControlTemplate)) return ", NConverters.ToControlTemplate";

      if (typeof(DependencyObject).IsAssignableFrom(propType))
      {
        return null;
      }

      Debug.WriteLine($"{cls.Name}.{propName} : {propType.Name}");
      return null;
    }

    string GetNPConverter(PropertyInfo prop)
    {
#if SILVERLIGHT
      if (prop.PropertyType == typeof(FontSource))
        return $", (t, v) => t.{prop.Name} = NConverters.ToFontSourceT(v)";
#endif
      if (prop.PropertyType == typeof(ResourceDictionary))
        return $", (t, v) => t.{prop.Name} = NConverters.ToResourceDictionaryT(v)";

      if (prop.PropertyType == typeof(string))
        return $", (t, v) => t.{prop.Name} = NConverters.ToStringT(v)";

      if (prop.PropertyType == typeof(char))
        return $", (t, v) => t.{prop.Name} = NConverters.ToCharT(v)";

      if (prop.PropertyType == typeof(TimeSpan))
        return $", (t, v) => t.{prop.Name} = NConverters.ToTimeSpanT(v)";

      if (prop.PropertyType == typeof(DateTimeOffset))
        return $", (t, v) => t.{prop.Name} = NConverters.ToDateTimeOffsetT(v)";

      if (prop.PropertyType == typeof(int))
        return $", (t, v) => t.{prop.Name} = NConverters.ToInt32T(v)";

      if (prop.PropertyType == typeof(float))
        return $", (t, v) => t.{prop.Name} = NConverters.ToSingleT(v)";

      if (prop.PropertyType == typeof(bool))
        return $", (t, v) => t.{prop.Name} = NConverters.ToBoolT(v)";

      if (prop.PropertyType == typeof(Color))
        return $", (t, v) => t.{prop.Name} = NConverters.ToColorT(v)";

      if (prop.PropertyType == typeof(Uri))
        return $", (t, v) => t.{prop.Name} = NConverters.ToUriT(v)";

      if (prop.PropertyType.IsEnum())
        return $", (t, v) => t.{prop.Name} = NConverters.ToEnumT<{SafeTypeName(prop.PropertyType)}>(v)";

      if (prop.PropertyType == typeof(UIElement))
        return $", (t, v) => AssignSingle(o => o.{prop.Name}, (o, i) => o.{prop.Name} = i, t, v)";

      Debug.WriteLine($"{prop.DeclaringType.Name}.{prop.Name} : {prop.PropertyType.Name}");
      return null;
    }
  }

  public static class ReflectionShims
  {
#if NETFX_CORE

    public static Type BaseType(this Type type)
    {
      return type.GetTypeInfo().BaseType;
    }

    public static bool IsPublic(this Type type)
    {
      return type.GetTypeInfo().IsPublic;
    }

    public static bool IsInterface(this Type type)
    {
      return type.GetTypeInfo().IsInterface;
    }

    public static bool IsEnum(this Type type)
    {
      return type.GetTypeInfo().IsEnum;
    }

    public static Assembly Assembly(this Type type)
    {
      return type.GetTypeInfo().Assembly;
    }

    public static bool IsGenericType(this Type type)
    {
      return type.GetTypeInfo().IsGenericType;
    }

    public static bool IsGenericTypeDefinition(this Type type)
    {
      return type.GetTypeInfo().IsGenericTypeDefinition;
    }

    public static Type[] GetGenericArguments(this Type type)
    {
      return type.GetTypeInfo().GenericTypeArguments;
    }

    public static string GetContentAttribute(this Type type)
    {
      try
      {
        var attributes = type.GetTypeInfo().CustomAttributes;
        var x = attributes.FirstOrDefault(i => i.AttributeType == typeof(ContentPropertyAttribute));
        if (x == null)
          return null;

        return x.NamedArguments.Where(i => i.MemberName == "Name").Select(i => (string)i.TypedValue.Value).FirstOrDefault();
      }
      catch
      {
        // current Windows build is broken and returns null on ALL GetCustomAttribute calls due to missing metadata of StaticAttribute
      }

      var result = type.GetTypeInfo().GetCustomAttribute<ContentPropertyAttribute>(true)?.Name;
      if (result != null)
        return result;

#if UWP
      if (type == typeof(Border) || type == typeof(Popup) || type == typeof(Viewbox) || type == typeof(InlineUIContainer))
        return "Child";

      if (type == typeof(SplitView) || type == typeof(UserControl) || type == typeof(ContentPresenter) || type == typeof(ContentControl))
        return "Content";

      if (type == typeof(Panel) || type == typeof(Windows.UI.Xaml.Controls.Maps.MapControl))
        return "Children";

      if (type == typeof(HubSection))
        return "ContentTemplate";

      if (type == typeof(Hub))
        return "Sections";

      if (type == typeof(ItemsControl) || type == typeof(MenuFlyoutSubItem))
        return "Items";

      if (type == typeof(TextBlock) || type == typeof(Span) || type == typeof(Paragraph))
        return "Inlines";

      if (type == typeof(RichTextBlock))
        return "Blocks";

      if (type == typeof(TimePicker) || type == typeof(DatePicker) || type == typeof(ToggleSwitch))
        return "Header";

      if (type == typeof(MenuFlyoutItem) || type == typeof(Run))
        return "Text";

      if (type == typeof(CommandBar))
        return "PrimaryCommands";

      if (type == typeof(SemanticZoom))
        return "ZoomedInView";

#endif
      return null;
    }

    public static bool IsList(this Type type)
    {
      return typeof(IList).IsAssignableFrom(type);
    }

    public static bool IsListOfT(this Type type)
    {
      return type.GetInterfaces().Any(i => i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == typeof(IList<>));
    }

    public static IEnumerable<FieldInfo> GetPublicStaticFields(this Type type)
    {
      return type.GetTypeInfo().DeclaredFields.Where(i => i.IsPublic && i.IsStatic);
    }

    public static IEnumerable<PropertyInfo> GetPublicStaticProperties(this Type type)
    {
      return type.GetTypeInfo().DeclaredProperties.Where(i => i.GetMethod != null && i.GetMethod.IsStatic && i.GetMethod.IsPublic);
    }

    public static IEnumerable<PropertyInfo> GetPublicInstanceProperties(this Type type)
    {
      return type.GetTypeInfo().DeclaredProperties.Where(i => i.GetMethod != null && !i.GetMethod.IsStatic && i.GetMethod.IsPublic);
    }

    public static IEnumerable<EventInfo> GetPublicInstanceEvents(this Type type)
    {
      return type.GetTypeInfo().DeclaredEvents.Where(i => i.AddMethod.IsPublic && !i.AddMethod.IsStatic);
    }

    public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
    {
      return type.GetTypeInfo().DeclaredMethods.Where(i => i.IsPublic && i.IsStatic);
    }

#if !UWP
    public static IEnumerable<Type> GetTypes(this Assembly assembly)
    {
      return assembly.DefinedTypes.Select(i => i.AsType());
    }

    public static MethodInfo GetSetMethod(this PropertyInfo prop)
    {
      return prop.SetMethod;
    }

    public static MethodInfo GetMethod(this Type type, string name)
    {
      return type.GetTypeInfo().GetDeclaredMethod(name);
    }

    public static bool IsAssignableFrom(this Type type, Type source)
    {
      return type.GetTypeInfo().IsAssignableFrom(source.GetTypeInfo());
    }

    public static IEnumerable<Type> GetInterfaces(this Type type)
    {
      return type.GetTypeInfo().ImplementedInterfaces;
    }
#endif

#else
    public static bool IsGenericTypeDefinition(this Type type)
    {
      return type.IsGenericTypeDefinition;
    }

    public static Type BaseType(this Type type)
    {
      return type.BaseType;
    }

    public static bool IsPublic(this Type type)
    {
      return type.IsPublic;
    }

    public static bool IsInterface(this Type type)
    {
      return type.IsInterface;
    }

    public static bool IsEnum(this Type type)
    {
      return type.IsEnum;
    }

    public static bool IsGenericType(this Type type)
    {
      return type.IsGenericType;
    }

    public static Assembly Assembly(this Type type)
    {
      return type.Assembly;
    }

    public static string GetContentAttribute(this Type type)
    {
      var a = (ContentPropertyAttribute)Attribute.GetCustomAttribute(type, typeof(ContentPropertyAttribute), false);
      return a != null ? a.Name : null;
    }

    public static bool IsListOfT(this Type type)
    {
      return type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IList<>));
    }

    public static bool IsList(this Type type)
    {
      return typeof(IList).IsAssignableFrom(type);
    }

    public static IEnumerable<FieldInfo> GetPublicStaticFields(this Type type)
    {
      return type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
    }

    public static IEnumerable<PropertyInfo> GetPublicStaticProperties(this Type type)
    {
      return type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
    }

    public static IEnumerable<PropertyInfo> GetPublicInstanceProperties(this Type type)
    {
      return type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
    }

    public static IEnumerable<EventInfo> GetPublicInstanceEvents(this Type type)
    {
      return type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
    }

    public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
    {
      return type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
    }
#endif
  }
}
