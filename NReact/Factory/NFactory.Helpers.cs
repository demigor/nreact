#if XAML
using System;
using System.Collections;
using System.Linq;
#if NETFX_CORE
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using sw = Windows.UI.Xaml;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using sw = System.Windows;
#endif

namespace NReact
{
  public static partial class NFactory
  {
    #region Visibility overloads

    public static NElement Visibility(this NElement self, Visibility value)
    {
      return self.Set(Properties.Visibility, value);
    }

    public static NElement Visibility(this NElement self, bool value)
    {
      return self.Visibility(value ? sw.Visibility.Visible : sw.Visibility.Collapsed);
    }

    #endregion

    #region Opacity overloads

    public static NElement Opacity(this NElement self, double value)
    {
      return self.Set(Properties.Opacity, value);
    }

    public static NElement Opacity(this NElement self, bool value)
    {
      return self.Opacity(value ? 1 : 0);
    }

    #endregion

    #region Grid Attached Properties overloads

    public static NElement GridColumn(this NElement self, int value)
    {
      return self.Set(Properties.GridColumn, value);
    }

    public static NElement GridColumnSpan(this NElement self, int value)
    {
      return self.Set(Properties.GridColumnSpan, value);
    }

    public static NElement GridRow(this NElement self, int value)
    {
      return self.Set(Properties.GridRow, value);
    }

    public static NElement GridRowSpan(this NElement self, int value)
    {
      return self.Set(Properties.GridRowSpan, value);
    }

    #endregion

    #region Canvas Attached Properties overloads

    public static NElement CanvasLeft(this NElement self, double value)
    {
      return self.Set(Properties.CanvasLeft, value);
    }

    public static NElement CanvasTop(this NElement self, double value)
    {
      return self.Set(Properties.CanvasTop, value);
    }

    #endregion

    #region Width, Height, MinWidth, MinHeight, MaxWidth, MaxHeight Properties overloads

    public static NElement Width(this NElement self, string value)
    {
      return self.Set(Properties.Width, value);
    }

    public static NElement Height(this NElement self, string value)
    {
      return self.Set(Properties.Height, value);
    }

    public static NElement Width(this NElement self, double value)
    {
      return self.Set(Properties.Width, value);
    }

    public static NElement Width(this NElement self, double value, GridUnitType type)
    {
      return self.Set(Properties.Width, new GridLength(value, type));
    }

    public static NElement Height(this NElement self, double value)
    {
      return self.Set(Properties.Height, value);
    }

    public static NElement Height(this NElement self, double value, GridUnitType type)
    {
      return self.Set(Properties.Height, new GridLength(value, type));
    }

    public static NElement MaxWidth(this NElement self, double value)
    {
      return self.Set(Properties.MaxWidth, value);
    }

    public static NElement MaxHeight(this NElement self, double value)
    {
      return self.Set(Properties.MaxHeight, value);
    }

    public static NElement MinWidth(this NElement self, double value)
    {
      return self.Set(Properties.MinWidth, value);
    }

    public static NElement MinHeight(this NElement self, double value)
    {
      return self.Set(Properties.MinHeight, value);
    }

    #endregion

    #region SelectedItem overloads

    public static NElement SelectedIndex(this NElement self, int value)
    {
      return self.Set(Properties.SelectedIndex, value);
    }

    #endregion

    #region SelectedValue overloads

    public static NElement SelectedValue(this NElement self, object value)
    {
      return self.Set(Properties.SelectedValue, value);
    }

    #endregion

    #region SelectedValuePath overloads

    public static NElement SelectedValuePath(this NElement self, string value)
    {
      return self.Set(Properties.SelectedValuePath, value);
    }

    #endregion

    #region IsChecked overloads

    public static NElement IsChecked(this NElement self, bool value)
    {
      return self.Set(Properties.IsChecked, value);
    }

    #endregion

    #region Content overloads

    public static NElement Content(this NElement self, object value)
    {
      return self.Set(Properties.Content, value);
    }

    #endregion

    #region ContentAlignment overloads

    public static NElement ContentAlignment(this NElement self, HorizontalAlignment value)
    {
      return self.HorizontalContentAlignment(value);
    }

    public static NElement ContentAlignment(this NElement self, VerticalAlignment value)
    {
      return self.VerticalContentAlignment(value);
    }

    public static NElement ContentAlignment(this NElement self, HorizontalAlignment horz, VerticalAlignment vert)
    {
      return self.HorizontalContentAlignment(horz).VerticalContentAlignment(vert);
    }

    #endregion

    #region Alignment overloads

    public static NElement AlignRight(this NElement self)
    {
      return self.Set(Properties.HorizontalAlignment, sw.HorizontalAlignment.Right);
    }

    public static NElement AlignLeft(this NElement self)
    {
      return self.Set(Properties.HorizontalAlignment, sw.HorizontalAlignment.Left);
    }

    public static NElement AlignHCenter(this NElement self)
    {
      return self.Set(Properties.HorizontalAlignment, sw.HorizontalAlignment.Center);
    }

    public static NElement AlignHStretch(this NElement self)
    {
      return self.Set(Properties.HorizontalAlignment, sw.HorizontalAlignment.Stretch);
    }

    public static NElement AlignTop(this NElement self)
    {
      return self.Set(Properties.VerticalAlignment, sw.VerticalAlignment.Top);
    }

    public static NElement AlignBottom(this NElement self)
    {
      return self.Set(Properties.VerticalAlignment, sw.VerticalAlignment.Bottom);
    }

    public static NElement AlignVCenter(this NElement self)
    {
      return self.Set(Properties.VerticalAlignment, sw.VerticalAlignment.Center);
    }

    public static NElement AlignVStretch(this NElement self)
    {
      return self.Set(Properties.VerticalAlignment, sw.VerticalAlignment.Stretch);
    }

    public static NElement Alignment(this NElement self, HorizontalAlignment value)
    {
      return self.HorizontalAlignment(value);
    }

    public static NElement Alignment(this NElement self, VerticalAlignment value)
    {
      return self.VerticalAlignment(value);
    }

    public static NElement Alignment(this NElement self, HorizontalAlignment horz, VerticalAlignment vert)
    {
      return self.HorizontalAlignment(horz).VerticalAlignment(vert);
    }

    public static NElement Alignment(this NElement self, TextAlignment value)
    {
      return self.TextAlignment(value);
    }

    #endregion

    #region HorizontalAlignment & HorizontalContentAlignment overloads

    public static NElement HorizontalAlignment(this NElement self, HorizontalAlignment value)
    {
      return self.Set(Properties.HorizontalAlignment, value);
    }

    public static NElement HorizontalContentAlignment(this NElement self, HorizontalAlignment value)
    {
      return self.Set(Properties.HorizontalContentAlignment, value);
    }

    #endregion

    #region VerticalAlignment & VerticalContentAlignment overloads

    public static NElement VerticalAlignment(this NElement self, VerticalAlignment value)
    {
      return self.Set(Properties.VerticalAlignment, value);
    }

    public static NElement VerticalContentAlignment(this NElement self, VerticalAlignment value)
    {
      return self.Set(Properties.VerticalContentAlignment, value);
    }

    #endregion

    #region Orientation overloads

    public static NElement Orientation(this NElement self, Orientation value)
    {
      return self.Set(Properties.Orientation, value);
    }

    #endregion

    #region Tag overloads

    public static NElement Tag(this NElement self, object value)
    {
      return self.Set(Properties.Tag, value);
    }

    #endregion

    #region Style overloads

    public static NElement Style(this NElement self, Style value)
    {
      return self.Set(Properties.Style, value);
    }

    public static NElement Style(this NElement self, string value)
    {
      return self.Set(Properties.Style, value);
    }

    #endregion

    #region Text overloads

    public static NElement Text(this NElement self, object value)
    {
      return self.Set(Properties.Text, value);
    }

    public static NElement Text(this NElement self, string value)
    {
      return self.Set(Properties.Text, value);
    }

    public static NElement Text(this NElement self, string format, params object[] data)
    {
      return self.Set(Properties.Text, string.Format(format, data));
    }

    #endregion

    #region Inlines overloads

    public static NElement Inlines(this NElement self, object value)
    {
      return self.Set(Properties.Inlines, value);
    }

    #endregion

    #region Tooltip overloads

    public static NElement Tooltip(this NElement self, object value)
    {
      return self.Set(Properties.ToolTipServiceToolTip, value);
    }

    public static NElement TooltipPlacement(this NElement self, PlacementMode value)
    {
      return self.Set(Properties.ToolTipServicePlacement, value);
    }

    #endregion


    #region TextAlignment overloads

    public static NElement TextAlignment(this NElement self, TextAlignment value)
    {
      return self.Set(Properties.TextAlignment, value);
    }

    #endregion

    #region TextWrapping overloads

    public static NElement TextWrapping(this NElement self, TextWrapping value)
    {
      return self.Set(Properties.TextWrapping, value);
    }

    public static NElement Wrapping(this NElement self, TextWrapping value)
    {
      return self.TextWrapping(value);
    }

    #endregion

#if !NETFX_CORE
    #region TextDecorations overloads

    public static NElement TextDecorations(this NElement self, object value)
    {
      return self.Set(Properties.TextDecorations, value);
    }

    #endregion
#endif

    #region FontFamily overloads

    public static NElement FontFamily(this NElement self, string value)
    {
      return self.Set(Properties.FontFamily, value);
    }

    public static NElement FontFamily(this NElement self, FontFamily value)
    {
      return self.Set(Properties.FontFamily, value);
    }

    #endregion

    #region FontSize overloads

    public static NElement FontSize(this NElement self, double value)
    {
      return self.Set(Properties.FontSize, value);
    }

    #endregion

    #region FontWeight overloads

    public static NElement FontWeight(this NElement self, FontWeight value)
    {
      return self.Set(Properties.FontWeight, value);
    }

    #endregion

    #region FontStyle overloads

    public static NElement FontStyle(this NElement self, FontStyle value)
    {
      return self.Set(Properties.FontStyle, value);
    }

    #endregion

    #region IsHitTestVisible overloads

    public static NElement IsHitTestVisible(this NElement self, bool value)
    {
      return self.Set(Properties.IsHitTestVisible, value);
    }

    #endregion


    #region IsReadOnly overloads

    public static NElement IsReadOnly(this NElement self, bool value)
    {
      return self.Set(Properties.IsReadOnly, value);
    }

    #endregion

    #region AcceptsReturn overloads

    public static NElement AcceptsReturn(this NElement self, bool value)
    {
      return self.Set(Properties.AcceptsReturn, value);
    }

    #endregion

    #region ColumnDefinitions overloads

    public static NElement StarColumns(this NElement self, params double[] widths)
    {
      return self.ColumnDefinitions(widths.Select((w, idx) => new NXaml<ColumnDefinition>(idx).Width(w, GridUnitType.Star)).ToArray());
    }

    public static NElement ColumnDefinitions(this NElement self, params NElement[] values)
    {
      return self.Set(Properties.ColumnDefinitions, values);
    }

    public static NElement ColumnDefinitions(this NElement self, Func<NElement, NElement>[] ctors)
    {
      return self.Set(Properties.ColumnDefinitions, ctors.Select((ctor, idx) => SafeCall(new NXaml<ColumnDefinition>(idx), ctor)).ToArray());
    }

    public static NElement ColumnDefinitions(this NElement self, int count, Func<NElement, NElement> ctor = null)
    {
      return self.Set(Properties.ColumnDefinitions, Enumerable.Range(1, count).Select(idx => SafeCall(new NXaml<ColumnDefinition>(idx), ctor)).ToArray());
    }

    static NElement SafeCall(NElement target, Func<NElement, NElement> appender)
    {
      return appender != null ? appender(target) : target;
    }

    #endregion

    #region RowDefinitions overloads

    public static NElement Rows(this NElement self, params double[] heights)
    {
      return self.RowDefinitions(heights.Select((w, idx) => new NXaml<RowDefinition>(idx).Height(w, GridUnitType.Star)).ToArray());
    }

    public static NElement RowDefinitions(this NElement self, params NElement[] values)
    {
      return self.Set(Properties.RowDefinitions, values);
    }

    public static NElement RowDefinitions(this NElement self, params Func<NElement, NElement>[] ctors)
    {
      return self.RowDefinitions(ctors.Select((ctor, idx) => SafeCall(new NXaml<RowDefinition>(idx), ctor)).ToArray());
    }

    public static NElement RowDefinitions(this NElement self, int count, Func<NElement, NElement> ctor = null)
    {
      return self.RowDefinitions(Enumerable.Range(1, count).Select(idx => SafeCall(CreateElement<RowDefinition>(idx), ctor)).ToArray());
    }

    #endregion

    #region Margin overloads

    public static NElement Margin(this NElement self, double value)
    {
      return self.Set(Properties.Margin, value);
    }

    public static NElement Margin(this NElement self, double horz, double vert)
    {
      return self.Set(Properties.Margin, new Thickness(horz, vert, horz, vert));
    }

    public static NElement Margin(this NElement self, double left, double top, double right, double bottom)
    {
      return self.Set(Properties.Margin, new Thickness(left, top, right, bottom));
    }

    public static NElement Margin(this NElement self, string value)
    {
      return self.Set(Properties.Margin, value);
    }

    #endregion

    #region Padding overloads

    public static NElement Padding(this NElement self, double value)
    {
      return self.Set(Properties.Padding, value);
    }

    public static NElement Padding(this NElement self, double horz, double vert)
    {
      return self.Set(Properties.Padding, new Thickness(horz, vert, horz, vert));
    }

    public static NElement Padding(this NElement self, double left, double top, double right, double bottom)
    {
      return self.Set(Properties.Padding, new Thickness(left, top, right, bottom));
    }

    public static NElement Padding(this NElement self, string value)
    {
      return self.Set(Properties.Padding, value);
    }

    #endregion

    #region BorderThickness overloads

    public static NElement BorderThickness(this NElement self, double value)
    {
      return self.Set(Properties.BorderThickness, value);
    }

    public static NElement BorderThickness(this NElement self, double horz, double vert)
    {
      return self.Set(Properties.BorderThickness, new Thickness(horz, vert, horz, vert));
    }

    public static NElement BorderThickness(this NElement self, double left, double top, double right, double bottom)
    {
      return self.Set(Properties.BorderThickness, new Thickness(left, top, right, bottom));
    }

    public static NElement BorderThickness(this NElement self, string value)
    {
      return self.Set(Properties.BorderThickness, value);
    }

    public static NElement BorderThickness(this NElement self, object value)
    {
      return self.Set(Properties.BorderThickness, value);
    }

    #endregion

    #region StrokeThickness overloads

    public static NElement StrokeThickness(this NElement self, double value)
    {
      return self.Set(Properties.StrokeThickness, value);
    }

    public static NElement StrokeThickness(this NElement self, object value)
    {
      return self.Set(Properties.StrokeThickness, value);
    }

    #endregion


    #region BorderBrush overloads

    public static NElement BorderBrush(this NElement self, string value)
    {
      return self.Set(Properties.BorderBrush, value);
    }

    public static NElement BorderBrush(this NElement self, Color value)
    {
      return self.Set(Properties.BorderBrush, value);
    }

    public static NElement BorderBrush(this NElement self, Brush value)
    {
      return self.Set(Properties.BorderBrush, value);
    }

    public static NElement BorderBrush(this NElement self, int r, int g, int b)
    {
      return self.Set(Properties.BorderBrush, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NElement BorderBrush(this NElement self, int a, int r, int g, int b)
    {
      return self.Set(Properties.BorderBrush, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NElement BorderBrush(this NElement self, object value)
    {
      return self.Set(Properties.BorderBrush, value);
    }

    #endregion

    #region Foreground overloads

    public static NElement Foreground(this NElement self, int r, int g, int b)
    {
      return self.Set(Properties.Foreground, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Foreground(this NElement self, int a, int r, int g, int b)
    {
      return self.Set(Properties.Foreground, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Foreground(this NElement self, string value)
    {
      return self.Set(Properties.Foreground, value);
    }

    public static NElement Foreground(this NElement self, Color value)
    {
      return self.Set(Properties.Foreground, value);
    }

    public static NElement Foreground(this NElement self, Brush value)
    {
      return self.Set(Properties.Foreground, value);
    }

    #endregion

    #region Background overloads

    public static NElement Background(this NElement self, int r, int g, int b)
    {
      return self.Set(Properties.Background, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Background(this NElement self, int a, int r, int g, int b)
    {
      return self.Set(Properties.Background, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Background(this NElement self, string value)
    {
      return self.Set(Properties.Background, value);
    }

    public static NElement Background(this NElement self, Color value)
    {
      return self.Set(Properties.Background, value);
    }

    public static NElement Background(this NElement self, Brush value)
    {
      return self.Set(Properties.Background, value);
    }

    #endregion


    #region Items overloads

    public static NElement Items(this NElement self, IEnumerable items)
    {
      return self.Set(Properties.Items, items);
    }

    #endregion

    #region Fill overloads

    public static NElement Fill(this NElement self, int r, int g, int b)
    {
      return self.Set(Properties.Fill, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Fill(this NElement self, int a, int r, int g, int b)
    {
      return self.Set(Properties.Fill, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Fill(this NElement self, string value)
    {
      return self.Set(Properties.Fill, value);
    }

    public static NElement Fill(this NElement self, Color value)
    {
      return self.Set(Properties.Fill, value);
    }

    public static NElement Fill(this NElement self, Brush value)
    {
      return self.Set(Properties.Fill, value);
    }

    #endregion

    #region Stroke overloads

    public static NElement Stroke(this NElement self, int r, int g, int b)
    {
      return self.Set(Properties.Stroke, Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Stroke(this NElement self, int a, int r, int g, int b)
    {
      return self.Set(Properties.Stroke, Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b));
    }

    public static NElement Stroke(this NElement self, string value)
    {
      return self.Set(Properties.Stroke, value);
    }

    public static NElement Stroke(this NElement self, Color value)
    {
      return self.Set(Properties.Stroke, value);
    }

    public static NElement Stroke(this NElement self, Brush value)
    {
      return self.Set(Properties.Stroke, value);
    }

    #endregion

    #region Events extensions

    #region Click overloads

    public static NElement Click(this NElement self, Action value)
    {
      return self.Set(Properties.Click, value);
    }

    public static NElement Click(this NElement self, Action<object> value)
    {
      return self.Set(Properties.Click, value);
    }

    public static NElement Click(this NElement self, EventHandler value)
    {
      return self.Set(Properties.Click, value);
    }

    #endregion

#if SILVERLIGHT
    #region ContentChanged overloads

    public static NElement ContentChanged(this NElement self, Action value)
    {
      return self.Set(Properties.ContentChanged, value);
    }

    public static NElement ContentChanged(this NElement self, Action<object> value)
    {
      return self.Set(Properties.ContentChanged, value);
    }

    public static NElement ContentChanged(this NElement self, EventHandler value)
    {
      return self.Set(Properties.ContentChanged, value);
    }

    public static NElement ContentChanged(this NElement self, ContentChangedEventHandler value)
    {
      return self.Set(Properties.ContentChanged, value);
    }

    #endregion
#endif

    #region TextChanged overloads

    public static NElement TextChanged(this NElement self, Action value)
    {
      return self.Set(Properties.TextChanged, value);
    }

    public static NElement TextChanged(this NElement self, Action<object> value)
    {
      return self.Set(Properties.TextChanged, value);
    }

    public static NElement TextChanged(this NElement self, EventHandler value)
    {
      return self.Set(Properties.TextChanged, value);
    }

    public static NElement TextChanged(this NElement self, TextChangedEventHandler value)
    {
      return self.Set(Properties.TextChanged, value);
    }

    #endregion

    #region SelectionChanged overloads

    public static NElement SelectionChanged(this NElement self, Action value)
    {
      return self.Set(Properties.SelectionChanged, value);
    }

    public static NElement SelectionChanged(this NElement self, Action<object> value)
    {
      return self.Set(Properties.SelectionChanged, value);
    }

    public static NElement SelectionChanged(this NElement self, EventHandler value)
    {
      return self.Set(Properties.SelectionChanged, value);
    }

    public static NElement SelectionChanged(this NElement self, SelectionChangedEventHandler value)
    {
      return self.Set(Properties.SelectionChanged, value);
    }

    #endregion

#if NETFX_CORE
    public static NElement PointerPressed(this NElement self, Action value, bool includeHandled = false)
    {
      return self.Set(Properties.PointerPressed, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement PointerPressed(this NElement self, Action<object> value, bool includeHandled = false)
    {
      return self.Set(Properties.PointerPressed, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement PointerPressed(this NElement self, Action<PointerRoutedEventArgs> value, bool includeHandled = false)
    {
      return self.Set(Properties.PointerPressed, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement PointerPressed(this NElement self, PointerEventHandler value, bool includeHandled = false)
    {
      return self.Set(Properties.PointerPressed, NEventAdapter.PackHandler(value, includeHandled));
    }

#else

    #region MouseLeftButtonUp overloads

    public static NElement MouseLeftButtonUp(this NElement self, Action value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonUp, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement MouseLeftButtonUp(this NElement self, Action<object> value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonUp, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement MouseLeftButtonUp(this NElement self, MouseEventHandler value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonUp, NEventAdapter.PackHandler(value, includeHandled));
    }

    #endregion

    #region MouseLeftButtonDown overloads

    public static NElement MouseLeftButtonDown(this NElement self, Action value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonDown, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement MouseLeftButtonDown(this NElement self, Action<object> value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonDown, NEventAdapter.PackHandler(value, includeHandled));
    }

    public static NElement MouseLeftButtonDown(this NElement self, MouseEventHandler value, bool includeHandled = false)
    {
      return self.Set(Properties.MouseLeftButtonDown, NEventAdapter.PackHandler(value, includeHandled));
    }

    #endregion

#endif

    #endregion

    #region TextOptions Attached Properties overloads

#if !NETFX_CORE
    public static NElement TextOptions(this NElement self, TextFormattingMode value)
    {
      return self.Set(Properties.TextOptionsTextFormattingMode, value);
    }

    public static NElement TextOptions(this NElement self, TextRenderingMode value)
    {
      return self.Set(Properties.TextOptionsTextRenderingMode, value);
    }

    public static NElement TextOptions(this NElement self, TextHintingMode value)
    {
      return self.Set(Properties.TextOptionsTextHintingMode, value);
    }
#endif

    #endregion
  }
}
#endif