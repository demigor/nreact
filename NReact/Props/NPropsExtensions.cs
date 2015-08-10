using System;
using System.Linq;
using System.Collections;
#if NETFX_CORE
using Windows.UI;
using Windows.UI.Text;
using SW = Windows.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
#else
using System.Windows;
using SW = System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace NReact
{
  public static class NPropsExtensions
  {
    #region Visibility overloads

    public static NDataCtor Visibility(this NDataCtor props, Visibility value)
    {
      return props.Add(NProps.Visibility, value);
    }

    public static NDataCtor Visibility(this NDataCtor props, bool value)
    {
      return props.Visibility(value ? SW.Visibility.Visible : SW.Visibility.Collapsed);
    }

    #endregion

    #region Opacity overloads

    public static NDataCtor Opacity(this NDataCtor props, double value)
    {
      return props.Add(NProps.Opacity, value);
    }

    public static NDataCtor Opacity(this NDataCtor props, bool value)
    {
      return props.Opacity(value ? 1 : 0);
    }

    #endregion

    #region Grid Attached Properties overloads

    public static NDataCtor GridColumn(this NDataCtor props, int value)
    {
      return props.Add(NProps.GridColumn, value);
    }

    public static NDataCtor GridColumnSpan(this NDataCtor props, int value)
    {
      return props.Add(NProps.GridColumnSpan, value);
    }

    public static NDataCtor GridRow(this NDataCtor props, int value)
    {
      return props.Add(NProps.GridRow, value);
    }

    public static NDataCtor GridRowSpan(this NDataCtor props, int value)
    {
      return props.Add(NProps.GridRowSpan, value);
    }

    #endregion

    #region Canvas Attached Properties overloads

    public static NDataCtor CanvasLeft(this NDataCtor props, double value)
    {
      return props.Add(NProps.CanvasLeft, value);
    }

    public static NDataCtor CanvasTop(this NDataCtor props, double value)
    {
      return props.Add(NProps.CanvasTop, value);
    }

    #endregion

    #region Width, Height, MinWidth, MinHeight, MaxWidth, MaxHeight Properties overloads

    public static NDataCtor Width(this NDataCtor props, string value)
    {
      return props.Add(NProps.Width, value);
    }

    public static NDataCtor Height(this NDataCtor props, string value)
    {
      return props.Add(NProps.Height, value);
    }

    public static NDataCtor Width(this NDataCtor props, double value)
    {
      return props.Add(NProps.Width, value);
    }

    public static NDataCtor Height(this NDataCtor props, double value)
    {
      return props.Add(NProps.Height, value);
    }

    public static NDataCtor MaxWidth(this NDataCtor props, double value)
    {
      return props.Add(NProps.MaxWidth, value);
    }

    public static NDataCtor MaxHeight(this NDataCtor props, double value)
    {
      return props.Add(NProps.MaxHeight, value);
    }

    public static NDataCtor MinWidth(this NDataCtor props, double value)
    {
      return props.Add(NProps.MinWidth, value);
    }

    public static NDataCtor MinHeight(this NDataCtor props, double value)
    {
      return props.Add(NProps.MinHeight, value);
    }

    #endregion

    #region SelectedItem overloads

    public static NDataCtor SelectedIndex(this NDataCtor props, int value)
    {
      return props.Add(NProps.SelectedIndex, value);
    }

    #endregion

    #region SelectedValue overloads

    public static NDataCtor SelectedValue(this NDataCtor props, object value)
    {
      return props.Add(NProps.SelectedValue, value);
    }

    #endregion

    #region SelectedValuePath overloads

    public static NDataCtor SelectedValuePath(this NDataCtor props, string value)
    {
      return props.Add(NProps.SelectedValuePath, value);
    }

    #endregion

    #region ContentAlignment overloads

    public static NDataCtor ContentAlignment(this NDataCtor props, HorizontalAlignment value)
    {
      return props.Add(NProps.HorizontalContentAlignment, value);
    }

    public static NDataCtor ContentAlignment(this NDataCtor props, VerticalAlignment value)
    {
      return props.Add(NProps.VerticalContentAlignment, value);
    }

    #endregion

    #region Alignment overloads

    public static NDataCtor Alignment(this NDataCtor props, HorizontalAlignment value)
    {
      return props.Add(NProps.HorizontalAlignment, value);
    }

    public static NDataCtor Alignment(this NDataCtor props, VerticalAlignment value)
    {
      return props.Add(NProps.VerticalAlignment, value);
    }

    public static NDataCtor Alignment(this NDataCtor props, TextAlignment value)
    {
      return props.Add(NProps.TextAlignment, value);
    }

    #endregion

    #region HorizontalAlignment & HorizontalContentAlignment overloads

    public static NDataCtor HorizontalAlignment(this NDataCtor props, HorizontalAlignment value)
    {
      return props.Add(NProps.HorizontalAlignment, value);
    }

    public static NDataCtor HorizontalContentAlignment(this NDataCtor props, HorizontalAlignment value)
    {
      return props.Add(NProps.HorizontalContentAlignment, value);
    }

    #endregion

    #region VerticalAlignment & VerticalContentAlignment overloads

    public static NDataCtor VerticalAlignment(this NDataCtor props, VerticalAlignment value)
    {
      return props.Add(NProps.VerticalAlignment, value);
    }

    public static NDataCtor VerticalContentAlignment(this NDataCtor props, VerticalAlignment value)
    {
      return props.Add(NProps.VerticalContentAlignment, value);
    }

    #endregion

    #region Orientation overloads

    public static NDataCtor Orientation(this NDataCtor props, Orientation value)
    {
      return props.Add(NProps.Orientation, value);
    }

    #endregion

    #region Tag overloads

    public static NDataCtor Tag(this NDataCtor props, object value)
    {
      return props.Add(NProps.Tag, value);
    }

    #endregion

    #region Ref overloads

    public static NDataCtor Ref(this NDataCtor props, string value)
    {
      return props.Add(NProps.Ref, value);
    }

    #endregion

    #region Key overloads

    public static NDataCtor Key(this NDataCtor props, object value)
    {
      return props.Add(NProps.Key, value);
    }

    #endregion

    #region Style overloads

    public static NDataCtor Style(this NDataCtor props, Style value)
    {
      return props.Add(NProps.Style, value);
    }

    public static NDataCtor Style(this NDataCtor props, string value)
    {
      return props.Add(NProps.Style, value);
    }

    #endregion

    #region Text overloads

    public static NDataCtor Text(this NDataCtor props, object value)
    {
      return props.Add(NProps.Text, value);
    }

    public static NDataCtor Text(this NDataCtor props, string format, params object[] data)
    {
      return props.Add(NProps.Text, string.Format(format, data));
    }

    #endregion

    #region TextAlignment overloads

    public static NDataCtor TextAlignment(this NDataCtor props, TextAlignment value)
    {
      return props.Add(NProps.TextAlignment, value);
    }

    #endregion

    #region TextWrapping overloads

    public static NDataCtor TextWrapping(this NDataCtor props, TextWrapping value)
    {
      return props.Add(NProps.TextWrapping, value);
    }

    #endregion

    #region FontFamily overloads

    public static NDataCtor FontFamily(this NDataCtor props, string value)
    {
      return props.Add(NProps.FontFamily, value);
    }

    public static NDataCtor FontFamily(this NDataCtor props, FontFamily value)
    {
      return props.Add(NProps.FontFamily, value);
    }

    #endregion

    #region FontSize overloads

    public static NDataCtor FontSize(this NDataCtor props, double value)
    {
      return props.Add(NProps.FontSize, value);
    }

    #endregion

    #region FontWeight overloads

    public static NDataCtor FontWeight(this NDataCtor props, FontWeight value)
    {
      return props.Add(NProps.FontWeight, value);
    }

    #endregion

    #region IsReadOnly overloads

    public static NDataCtor IsReadOnly(this NDataCtor props, bool value)
    {
      return props.Add(NProps.IsReadOnly, value);
    }

    #endregion

    #region AcceptsReturn overloads

    public static NDataCtor AcceptsReturn(this NDataCtor props, bool value)
    {
      return props.Add(NProps.AcceptsReturn, value);
    }

    #endregion

    #region ColumnDefinitions overloads

    public static NDataCtor ColumnDefinitions(this NDataCtor props, params NElement[] values)
    {
      return props.Add(NProps.ColumnDefinitions, values);
    }

    public static NDataCtor ColumnDefinitions(this NDataCtor props, params NDataCtor[] columns)
    {
      return props.Add(NProps.ColumnDefinitions, columns.Select((i, idx) => NClass.New<ColumnDefinition>(i.Key(idx))).ToArray());
    }

    public static NDataCtor ColumnDefinitions(this NDataCtor props, int count, Func<NDataCtor, NDataCtor> propsCtor = null)
    {
      return props.Add(NProps.ColumnDefinitions, Enumerable.Range(1, count).Select(i => NClass.New<ColumnDefinition>(propsCtor == null ? null : propsCtor(NClass.NewProps))).ToArray());
    }

    #endregion

    #region RowDefinitions overloads

    public static NDataCtor RowDefinitions(this NDataCtor props, params NElement[] values)
    {
      return props.Add(NProps.RowDefinitions, values);
    }

    public static NDataCtor RowDefinitions(this NDataCtor props, params NDataCtor[] rows)
    {
      return props.Add(NProps.RowDefinitions, rows.Select((i, idx) => NClass.New<RowDefinition>(i.Key(idx))).ToArray());
    }

    public static NDataCtor RowDefinitions(this NDataCtor props, int count, Func<NDataCtor, NDataCtor> propsCtor = null)
    {
      return props.Add(NProps.RowDefinitions, Enumerable.Range(1, count).Select(i => NClass.New<RowDefinition>(propsCtor == null ? null : propsCtor(NClass.NewProps))).ToArray());
    }

    #endregion

    #region Margin overloads

    public static NDataCtor Margin(this NDataCtor props, double value)
    {
      return props.Add(NProps.Margin, value);
    }

    public static NDataCtor Margin(this NDataCtor props, double horz, double vert)
    {
      return props.Add(NProps.Margin, new Thickness(horz, vert, horz, vert));
    }

    public static NDataCtor Margin(this NDataCtor props, double left, double top, double right, double bottom)
    {
      return props.Add(NProps.Margin, new Thickness(left, top, right, bottom));
    }

    public static NDataCtor Margin(this NDataCtor props, string value)
    {
      return props.Add(NProps.Margin, value);
    }

    #endregion

    #region Padding overloads

    public static NDataCtor Padding(this NDataCtor props, double value)
    {
      return props.Add(NProps.Padding, value);
    }

    public static NDataCtor Padding(this NDataCtor props, double horz, double vert)
    {
      return props.Add(NProps.Padding, new Thickness(horz, vert, horz, vert));
    }

    public static NDataCtor Padding(this NDataCtor props, double left, double top, double right, double bottom)
    {
      return props.Add(NProps.Padding, new Thickness(left, top, right, bottom));
    }

    public static NDataCtor Padding(this NDataCtor props, string value)
    {
      return props.Add(NProps.Padding, value);
    }

    #endregion

    #region BorderThickness overloads

    public static NDataCtor BorderThickness(this NDataCtor props, double value)
    {
      return props.Add(NProps.BorderThickness, value);
    }

    public static NDataCtor BorderThickness(this NDataCtor props, double horz, double vert)
    {
      return props.Add(NProps.BorderThickness, new Thickness(horz, vert, horz, vert));
    }

    public static NDataCtor BorderThickness(this NDataCtor props, double left, double top, double right, double bottom)
    {
      return props.Add(NProps.BorderThickness, new Thickness(left, top, right, bottom));
    }

    public static NDataCtor BorderThickness(this NDataCtor props, string value)
    {
      return props.Add(NProps.BorderThickness, value);
    }

    #endregion

    #region BorderBrush overloads

    public static NDataCtor BorderBrush(this NDataCtor props, string value)
    {
      return props.Add(NProps.BorderBrush, value);
    }

    public static NDataCtor BorderBrush(this NDataCtor props, Color value)
    {
      return props.Add(NProps.BorderBrush, value);
    }

    public static NDataCtor BorderBrush(this NDataCtor props, Brush value)
    {
      return props.Add(NProps.BorderBrush, value);
    }

    public static NDataCtor BorderBrush(this NDataCtor props, int r, int g, int b)
    {
      return props.Add(NProps.BorderBrush, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor BorderBrush(this NDataCtor props, int a, int r, int g, int b)
    {
      return props.Add(NProps.BorderBrush, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    #endregion

    #region Foreground overloads

    public static NDataCtor Foreground(this NDataCtor props, int r, int g, int b)
    {
      return props.Add(NProps.Foreground, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Foreground(this NDataCtor props, int a, int r, int g, int b)
    {
      return props.Add(NProps.Foreground, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Foreground(this NDataCtor props, string value)
    {
      return props.Add(NProps.Foreground, value);
    }

    public static NDataCtor Foreground(this NDataCtor props, Color value)
    {
      return props.Add(NProps.Foreground, value);
    }

    public static NDataCtor Foreground(this NDataCtor props, Brush value)
    {
      return props.Add(NProps.Foreground, value);
    }

    #endregion

    #region Background overloads

    public static NDataCtor Background(this NDataCtor props, int r, int g, int b)
    {
      return props.Add(NProps.Background, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Background(this NDataCtor props, int a, int r, int g, int b)
    {
      return props.Add(NProps.Background, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Background(this NDataCtor props, string value)
    {
      return props.Add(NProps.Background, value);
    }

    public static NDataCtor Background(this NDataCtor props, Color value)
    {
      return props.Add(NProps.Background, value);
    }

    public static NDataCtor Background(this NDataCtor props, Brush value)
    {
      return props.Add(NProps.Background, value);
    }

    #endregion


    #region Items overloads

    public static NDataCtor Items(this NDataCtor props, IEnumerable items)
    {
      return props.Add(NProps.Items, items);
    }

    #endregion

    #region Fill overloads

    public static NDataCtor Fill(this NDataCtor props, int r, int g, int b)
    {
      return props.Add(NProps.Fill, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Fill(this NDataCtor props, int a, int r, int g, int b)
    {
      return props.Add(NProps.Fill, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Fill(this NDataCtor props, string value)
    {
      return props.Add(NProps.Fill, value);
    }

    public static NDataCtor Fill(this NDataCtor props, Color value)
    {
      return props.Add(NProps.Fill, value);
    }

    public static NDataCtor Fill(this NDataCtor props, Brush value)
    {
      return props.Add(NProps.Fill, value);
    }

    #endregion

    #region Stroke overloads

    public static NDataCtor Stroke(this NDataCtor props, int r, int g, int b)
    {
      return props.Add(NProps.Stroke, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Stroke(this NDataCtor props, int a, int r, int g, int b)
    {
      return props.Add(NProps.Stroke, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NDataCtor Stroke(this NDataCtor props, string value)
    {
      return props.Add(NProps.Stroke, value);
    }

    public static NDataCtor Stroke(this NDataCtor props, Color value)
    {
      return props.Add(NProps.Stroke, value);
    }

    public static NDataCtor Stroke(this NDataCtor props, Brush value)
    {
      return props.Add(NProps.Stroke, value);
    }

    #endregion

    #region Events extensions

    #region Click overloads

    public static NDataCtor Click(this NDataCtor props, Action value)
    {
      return props.Add(NProps.Click, value);
    }

    public static NDataCtor Click(this NDataCtor props, Action<object> value)
    {
      return props.Add(NProps.Click, value);
    }

    public static NDataCtor Click(this NDataCtor props, EventHandler value)
    {
      return props.Add(NProps.Click, value);
    }

    #endregion

    #region ContentChanged overloads

    public static NDataCtor ContentChanged(this NDataCtor props, Action value)
    {
      return props.Add(NProps.ContentChanged, value);
    }

    public static NDataCtor ContentChanged(this NDataCtor props, Action<object> value)
    {
      return props.Add(NProps.ContentChanged, value);
    }

    public static NDataCtor ContentChanged(this NDataCtor props, EventHandler value)
    {
      return props.Add(NProps.ContentChanged, value);
    }

#if SILVERLIGHT
    public static NDataCtor ContentChanged(this NDataCtor props, ContentChangedEventHandler value)
    {
      return props.Add(NProps.ContentChanged, value);
    }
#endif

    #endregion

    #region TextChanged overloads

    public static NDataCtor TextChanged(this NDataCtor props, Action value)
    {
      return props.Add(NProps.TextChanged, value);
    }

    public static NDataCtor TextChanged(this NDataCtor props, Action<object> value)
    {
      return props.Add(NProps.TextChanged, value);
    }

    public static NDataCtor TextChanged(this NDataCtor props, EventHandler value)
    {
      return props.Add(NProps.TextChanged, value);
    }

    public static NDataCtor TextChanged(this NDataCtor props, TextChangedEventHandler value)
    {
      return props.Add(NProps.TextChanged, value);
    }

    #endregion

    #region SelectionChanged overloads

    public static NDataCtor SelectionChanged(this NDataCtor props, Action value)
    {
      return props.Add(NProps.SelectionChanged, value);
    }

    public static NDataCtor SelectionChanged(this NDataCtor props, Action<object> value)
    {
      return props.Add(NProps.SelectionChanged, value);
    }

    public static NDataCtor SelectionChanged(this NDataCtor props, EventHandler value)
    {
      return props.Add(NProps.SelectionChanged, value);
    }

    public static NDataCtor SelectionChanged(this NDataCtor props, SelectionChangedEventHandler value)
    {
      return props.Add(NProps.SelectionChanged, value);
    }

    #endregion

    #region _MouseLeftButtonUp overloads

    /// <summary>
    /// Includes handled events
    /// </summary>
    public static NDataCtor _MouseLeftButtonUp(this NDataCtor props, Action value)
    {
      return props.Add(NProps._MouseLeftButtonUp, value);
    }

    /// <summary>
    /// Includes handled events
    /// </summary>
    public static NDataCtor _MouseLeftButtonUp(this NDataCtor props, Action<object> value)
    {
      return props.Add(NProps._MouseLeftButtonUp, value);
    }

    /// <summary>
    /// Includes handled events
    /// </summary>
    public static NDataCtor _MouseLeftButtonUp(this NDataCtor props, EventHandler value)
    {
      return props.Add(NProps._MouseLeftButtonUp, value);
    }

    #endregion

    #endregion

    #region TextOptions Attached Properties overloads

#if !NETFX_CORE
    public static NDataCtor TextOptions(this NDataCtor props, TextFormattingMode value)
    {
      return props.Add(NProps.TextOptionsTextFormattingMode, value);
    }

    public static NDataCtor TextOptions(this NDataCtor props, TextRenderingMode value)
    {
      return props.Add(NProps.TextOptionsTextRenderingMode, value);
    }

    public static NDataCtor TextOptions(this NDataCtor props, TextHintingMode value)
    {
      return props.Add(NProps.TextOptionsTextHintingMode, value);
    }
#endif

    #endregion
  }
}