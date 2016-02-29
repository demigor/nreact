using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
#if NETFX_CORE
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Input;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
#endif

namespace NReact
{
  public delegate NSetter NSetterResolver(Type target);

  public partial class NFactory : IEqualityComparer<NElement>
  {
    public static NFactory Default { get { return _default ?? (_default = new NXamlFactory()); } }
    protected static NFactory _default;

    public object Create(NElement e)
    {
      return CreateTree(e);
    }

    public void Destroy(NElement e, object xamlElement)
    {
      e.Unmount();
    }

    public virtual int GetContentKey(Type type)
    {
      if (typeof(NClass).IsAssignableFrom(type) || typeof(Panel).IsAssignableFrom(type))
        return NProps.Children;

      if (typeof(ItemsControl).IsAssignableFrom(type))
        return NProps.Items;

#if SILVERLIGHT
      if (typeof(UserControl).IsAssignableFrom(type))
        return NProps.Content;

      if (typeof(MultiScaleImage).IsAssignableFrom(type) || typeof(WebBrowser).IsAssignableFrom(type))
        return NProps.Source;
#endif

#if SILVERLIGHT || NETFX_CORE
      if (typeof(Border).IsAssignableFrom(type) || typeof(Viewbox).IsAssignableFrom(type))
        return NProps.Child;

      if (typeof(RichTextBlock).IsAssignableFrom(type))
        return NProps.Blocks;
#else
      if (typeof(Decorator).IsAssignableFrom(type))
        return NProps.Child;
#endif

      if (typeof(ContentControl).IsAssignableFrom(type) || typeof(ContentPresenter).IsAssignableFrom(type))
        return NProps.Content;

      if (typeof(TextBlock).IsAssignableFrom(type))
        return NProps.Inlines;

      if (typeof(TextBox).IsAssignableFrom(type) || typeof(PasswordBox).IsAssignableFrom(type))
        return NProps.Text;


#if !NETFX_CORE
      if (typeof(RichTextBox).IsAssignableFrom(type))
        return NProps.Blocks;

      if (typeof(WebBrowser).IsAssignableFrom(type))
        return NProps.Source;
#endif

      if (typeof(Image).IsAssignableFrom(type) || typeof(MediaElement).IsAssignableFrom(type))
        return NProps.Source;

      return NProps.CONTENT;
    }

    [DebuggerDisplay("{Type.Name}")]
    struct NSetterEntry
    {
      public Type Type;
      public NSetter Setter;
    }

    NSetterEntry[][] _setterMap = new NSetterEntry[64][];
    public NSetter this[int id, Type type]
    {
      get
      {
        return GetTypeFactory(type)[id, this];
      }
      protected set
      {
        if (id < 0) throw new ArgumentException();

        NShims.EnsureCapacity(ref _setterMap, id);

        var list = _setterMap[id];
        if (list == null)
          _setterMap[id] = new[] { new NSetterEntry { Type = type, Setter = value } };
        else
        {
          var freeSlot = -1;

          for (var i = 0; i < list.Length; i++)
          {
            var ct = list[i].Type;

            if (ct == type)
            {
              throw new InvalidOperationException("Such NSetter already registered");
            }

            if (ct == null)
            {
              freeSlot = i;
              break;
            }
          }

          if (freeSlot < 0)
          {
            freeSlot = list.Length;
            NShims.EnsureCapacity(ref list, freeSlot, 1);
            _setterMap[id] = list;
          }

          list[freeSlot] = new NSetterEntry { Type = type, Setter = value };
        }
      }
    }

    protected void Register<T>(int id, Action<T, object> setter)
    {
      this[id, typeof(T)] = (t, v) => setter((T)t, v);
    }

    protected void Register<T>(int id, DependencyProperty property, Func<object, object> converter = null) where T : DependencyObject
    {
      this[id, typeof(T)] = (t, v) => AssignSingleAttached((DependencyObject)t, v, property, converter);
    }

    protected void RegisterEvent<T>(int id, Action<T, NEventAdapter> subscribe) where T : DependencyObject
    {
      this[id, typeof(T)] = (t, v) => NEventAdapter.Aggregator.AssignEvent<T>(id, v, (T)t, subscribe);
    }

    protected void RegisterEvent<T>(int id, RoutedEvent routedEvent, Func<NEventAdapter, Delegate> extractor) where T : DependencyObject
    {
      this[id, typeof(T)] = (t, v) => NEventAdapter.Aggregator.AssignRoutedEvent(id, v, (DependencyObject)t, routedEvent, extractor);
    }

    #region Property Setters Factories

    internal NSetter ResolveSetter(Type type, int id)
    {
      if (id <= NProps.Ref) return null;

      var entries = GetSetterEntries(id);

      if (entries == null)
      {
#if DEBUG
        Debug.WriteLine("Unsupported property {0}", NProps.Store.GetKey(id));
#endif
        return null;
      }

      var result = default(NSetter);

      for (var i = 0; i < entries.Length; i++)
      {
        var entry = entries[i];

        if (entry.Type == null)
          break;

        if (entry.Type.IsAssignableFrom(type))
        {
          result = entry.Setter;
          break;
        }
      }


#if DEBUG
      if (result == null)
        Debug.WriteLine("Unsupported attempt to assign {0}.{1} property", type.FullName, NProps.Store.GetKey(id));
#endif
      return result;
    }

    NSetterEntry[] GetSetterEntries(int id)
    {
      var result = default(NSetterEntry[]);

      if (id >= 0 && id < _setterMap.Length)
        result = _setterMap[id];

      return result;
    }

    #endregion

    protected void AssignSingleAttached(DependencyObject target, object value, DependencyProperty property, Func<object, object> converter = null)
    {
      if (value == NDataBag.UnsetValue)
      {
        target.SetValue(property, value);
        return;
      }

      var e = value as NElement;
      if (e != null)
      {
        target.SetValue(property, Create(e));
        return;
      }

      var ea = value as NElement[];
      if (ea != null)
      {
        value = ea.Length == 0 ? NDataBag.UnsetValue : Create(ea[0]);
        target.SetValue(property, value);
        return;
      }

      var lp = value as NListPatch;
      if (lp != null)
      {
        value = lp.Apply(target.GetValue(property));
        target.SetValue(property, value);
        return;
      }

      var pp = value as NPropPatch;
      if (pp != null)
      {
        pp.Apply(target.GetValue(property));
        return;
      }

      if (converter != null)
        value = converter(value);

      target.SetValue(property, value);
    }

    protected void AssignSingle<C, T>(Func<C, T> getter, Action<C, T> setter, C target, object value)
    {
      var e = value as NElement;
      if (e != null)
      {
        value = Create(e);
        goto set;
      }

      var ea = value as NElement[];
      if (ea != null)
      {
        if (ea.Length == 0)
          value = null;
        else
          value = Create(ea[0]);

        goto set;
      }

      var lp = value as NListPatch;
      if (lp != null)
      {
        value = lp.Apply(getter(target));
        goto set;
      }

      var pp = value as NPropPatch;
      if (pp != null)
      {
        pp.Apply(getter(target));
        return;
      }

      if (value == NDataBag.UnsetValue)
      {
        setter(target, default(T));
        return;
      }

      set:
      setter(target, (T)value);
    }

    protected void AssignListT<T>(IList<T> list, object value)
    {
      if (value == NDataBag.UnsetValue)
      {
        list.Clear();
        return;
      }

      {
        var items = value as NElement[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
          {
            var item = Create(items[i]);
            list.Add((T)item);
          }

          return;
        }
      }

      {
        var items = value as object[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
          {
            var obj = items[i];
            var e = obj as NElement;
            var item = e != null ? Create(e) : obj;
            list.Add((T)item);
          }

          return;
        }
      }


      var patch = value as NListPatch;
      if (patch != null)
      {
        patch.ApplyToList(list);
        return;
      }

      Debug.WriteLine("Unsupported attempt to assign IList<{1}> property with {0} value", value, typeof(T).Name);
    }

    protected void AssignList(IList list, object value)
    {
      if (value == NDataBag.UnsetValue)
      {
        list.Clear();
        return;
      }

      {
        var items = value as NElement[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
            list.Add(Create(items[i]));

          return;
        }
      }

      {
        var items = value as object[];
        if (items != null)
        {
          list.Clear();

          for (var i = 0; i < items.Length; i++)
          {
            var obj = items[i];
            var e = obj as NElement;
            var item = e != null ? Create(e) : obj;
            list.Add(item);
          }

          return;
        }
      }


      var patch = value as NListPatch;
      if (patch != null)
      {
        patch.ApplyToList(list);
        return;
      }

      Debug.WriteLine("Unsupported attempt to assign IList property with {0} value", value);
    }

    public object CreateTree(object e)
    {
      if (e == null)
        return null;

      var x = e as NXamlElement;
      if (x != null)
      {
        var tf = x.GetTypeFactory(this);
        var result = tf.Ctor();

        for (var i = x.Props; i != null; i = i.Next)
        {
          var setter = tf[i.Id, this];
          if (setter != null)
            setter(result, i.Value);
        }

        return result;
      }

      var c = e as NClass;
      if (c != null)
        return c.Peer = CreateTree(c.RenderInitial());

      return e;
    }

    public object CreateXaml(Type type, NDataBag props)
    {
      var result = CreateInstance(type);

      for (var i = props; i != null; i = i.Next)
      {
        var setter = this[i.Id, type];
        if (setter != null)
          setter(result, i.Value);
      }

      return result;
    }

    public bool Equals(NElement x, NElement y)
    {
      return Equals(x.GetInnerType(), y.GetInnerType()) && Equals(x.Id, y.Id);
    }

    public int GetHashCode(NElement obj)
    {
      var result = obj.GetInnerType().GetHashCode();
      var id = obj.Id;
      return id == null ? result : result ^ id.GetHashCode();
    }
  }
}
