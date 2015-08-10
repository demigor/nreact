using System;
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
using System.Collections;
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
    public static NFactory Default = new NFactory();

    public NFactory()
    {
      RegisterUIElement();
      RegisterFrameworkElement();
      RegisterControl();
      RegisterPanel();
      RegisterStackPanel();
      RegisterGrid();
      RegisterRowDefinition();
      RegisterColumnDefinition();
      RegisterBorder();
      RegisterShape();
      RegisterTextBlock();
      RegisterRichTextBlock();
      RegisterContentControl();
      RegisterContentPresenter();
      RegisterUserControl();
      RegisterItemsControl();
      RegisterTextBox();
      RegisterRichTextBox();
      RegisterButtonBase();
      RegisterToggleButton();
      RegisterSelector();
    }

    void RegisterSelector()
    {
      Register<Selector>(NProps.SelectedIndex, (t, v) => t.SelectedIndex = NConverters.ToInt32(v));
      Register<Selector>(NProps.SelectionChanged, (t, v) => t.SelectionChanged += NConverters.NEvents.ToSelectionChangedEventHandler(v));
      Register<Selector>(NProps.SelectedValuePath, (t, v) => t.SelectedValuePath = NConverters.ToString(v));
      Register<Selector>(NProps.SelectedValue, (t, v) => AssignSingle(o => o.SelectedValue, (o, i) => o.SelectedValue = i, t, v));
      //public object SelectedItem { get; set; }
    }

    void RegisterToggleButton()
    {
      Register<ToggleButton>(NProps.IsChecked, (t, v) => t.IsChecked = NConverters.ToBoolN(v));
      Register<ToggleButton>(NProps.IsThreeState, (t, v) => t.IsThreeState = NConverters.ToBool(v));
      Register<ToggleButton>(NProps.Checked, (t, v) => t.Checked += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<ToggleButton>(NProps.Indeterminate, (t, v) => t.Indeterminate += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<ToggleButton>(NProps.Unchecked, (t, v) => t.Unchecked += NConverters.NEvents.ToRoutedEventHandler(v));
    }

    void RegisterButtonBase()
    {
      Register<ButtonBase>(NProps.ClickMode, (t, v) => t.ClickMode = NConverters.ToEnum<ClickMode>(v));
      Register<ButtonBase>(NProps.Command, (t, v) => AssignSingle(o => o.Command, (o, i) => o.Command = i, t, v));
      Register<ButtonBase>(NProps.CommandParameter, (t, v) => AssignSingle(o => o.CommandParameter, (o, i) => o.CommandParameter = i, t, v));
      Register<ButtonBase>(NProps.Click, (t, v) => t.Click += NConverters.NEvents.ToRoutedEventHandler(v));
    }

    void RegisterTextBox()
    {
      Register<TextBox>(NProps.AcceptsReturn, (t, v) => t.AcceptsReturn = NConverters.ToBool(v));
#if !NETFX_CORE
      Register<TextBox>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.NBrushes.Convert(v, t.CaretBrush));
      Register<TextBox>(NProps.HorizontalScrollBarVisibility, (t, v) => t.HorizontalScrollBarVisibility = NConverters.ToEnum<ScrollBarVisibility>(v));
      Register<TextBox>(NProps.VerticalScrollBarVisibility, (t, v) => t.VerticalScrollBarVisibility = NConverters.ToEnum<ScrollBarVisibility>(v));
#endif
      Register<TextBox>(NProps.IsReadOnly, (t, v) => t.IsReadOnly = NConverters.ToBool(v));
      Register<TextBox>(NProps.MaxLength, (t, v) => t.MaxLength = NConverters.ToInt32(v));
      Register<TextBox>(NProps.SelectionLength, (t, v) => t.SelectionLength = NConverters.ToInt32(v));
      Register<TextBox>(NProps.SelectionStart, (t, v) => t.SelectionStart = NConverters.ToInt32(v));
      Register<TextBox>(NProps.TextAlignment, (t, v) => t.TextAlignment = NConverters.ToEnum<TextAlignment>(v));
      Register<TextBox>(NProps.TextWrapping, (t, v) => t.TextWrapping = NConverters.ToEnum<TextWrapping>(v));
#if SILVERLIGHT
      Register<TextBox>(NProps.LineHeight, (t, v) => t.LineHeight = NConverters.ToDouble(v));
      Register<TextBox>(NProps.LineStackingStrategy, (t, v) => t.LineStackingStrategy = NConverters.ToEnum<LineStackingStrategy>(v));
      Register<TextBox>(NProps.Watermark, (t, v) => t.Watermark = v);
      Register<TextBox>(NProps.SelectionForeground, (t, v) => t.SelectionForeground = NConverters.NBrushes.Convert(v, t.SelectionForeground));
      Register<TextBox>(NProps.SelectionBackground, (t, v) => t.SelectionBackground = NConverters.NBrushes.Convert(v, t.SelectionBackground));
#endif
      Register<TextBox>(NProps.Text, (t, v) => t.Text = NConverters.ToString(v));
      Register<TextBox>(NProps.SelectedText, (t, v) => t.SelectedText = NConverters.ToString(v));
      Register<TextBox>(NProps.SelectionChanged, (t, v) => t.SelectionChanged += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<TextBox>(NProps.TextChanged, (t, v) => t.TextChanged += NConverters.NEvents.ToTextChangedEventHandler(v));
    }

    void RegisterItemsControl()
    {
      Register<ItemsControl>(NProps.DisplayMemberPath, (t, v) => t.DisplayMemberPath = NConverters.ToString(v));
      Register<ItemsControl>(NProps.Items, (t, v) => AssignList(t.Items, v));
      Register<ItemsControl>(NProps.ItemsPanel, (t, v) => AssignSingle(o => o.ItemsPanel, (o, i) => o.ItemsPanel = i, t, v));
      Register<ItemsControl>(NProps.ItemTemplate, (t, v) => AssignSingle(o => o.ItemTemplate, (o, i) => o.ItemTemplate = i, t, v));
      Register<ItemsControl>(NProps.ItemsSource, (t, v) => AssignSingle(o => o.ItemsSource, (o, i) => o.ItemsSource = i, t, v));
    }

    void RegisterContentPresenter()
    {
      Register<ContentPresenter>(NProps.Content, (t, v) => AssignSingle(o => o.Content, (o, i) => o.Content = i, t, v));
      Register<ContentPresenter>(NProps.ContentTemplate, (t, v) => AssignSingle(o => o.ContentTemplate, (o, i) => o.ContentTemplate = i, t, v));
    }

    void RegisterContentControl()
    {
      Register<ContentControl>(NProps.Content, (t, v) => AssignSingle(o => o.Content, (o, i) => o.Content = i, t, v));
      Register<ContentControl>(NProps.ContentTemplate, (t, v) => AssignSingle(o => o.ContentTemplate, (o, i) => o.ContentTemplate = i, t, v));
    }

    void RegisterRichTextBlock()
    {
#if SILVERLIGHT || NETFX_CORE
      Register<RichTextBlock>(NProps.CharacterSpacing, (t, v) => t.CharacterSpacing = NConverters.ToInt32(v));
      Register<RichTextBlock>(NProps.FontFamily, (t, v) => t.FontFamily = NConverters.ToFontFamily(v));
      Register<RichTextBlock>(NProps.FontSize, (t, v) => t.FontSize = NConverters.ToDouble(v));
      Register<RichTextBlock>(NProps.FontStretch, (t, v) => t.FontStretch = NConverters.ToFontStretch(v));
      Register<RichTextBlock>(NProps.FontStyle, (t, v) => t.FontStyle = NConverters.ToFontStyle(v));
      Register<RichTextBlock>(NProps.FontWeight, (t, v) => t.FontWeight = NConverters.ToFontWeight(v));
      Register<RichTextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.NBrushes.Convert(v, t.Foreground));
      Register<RichTextBlock>(NProps.Blocks, (t, v) => AssignList(t.Blocks, v));
      Register<RichTextBlock>(NProps.LineHeight, (t, v) => t.LineHeight = NConverters.ToDouble(v));
      Register<RichTextBlock>(NProps.Padding, (t, v) => t.Padding = NConverters.NThickness.Convert(v));
      Register<RichTextBlock>(NProps.TextAlignment, (t, v) => t.TextAlignment = NConverters.ToEnum<TextAlignment>(v));
      Register<RichTextBlock>(NProps.TextTrimming, (t, v) => t.TextTrimming = NConverters.ToEnum<TextTrimming>(v));
      Register<RichTextBlock>(NProps.TextWrapping, (t, v) => t.TextWrapping = NConverters.ToEnum<TextWrapping>(v));
      Register<RichTextBlock>(NProps.LineStackingStrategy, (t, v) => t.LineStackingStrategy = NConverters.ToEnum<LineStackingStrategy>(v));
      Register<RichTextBlock>(NProps.IsTextSelectionEnabled, (t, v) => t.IsTextSelectionEnabled = NConverters.ToBool(v));
      Register<RichTextBlock>(NProps.OverflowContentTarget, (t, v) => AssignSingle(o => o.OverflowContentTarget, (o, i) => o.OverflowContentTarget = i, t, v));
      Register<RichTextBlock>(NProps.SelectionChanged, (t, v) => t.SelectionChanged += NConverters.NEvents.ToRoutedEventHandler(v));
#endif
    }

    void RegisterTextBlock()
    {
#if SILVERLIGHT || NETFX_CORE
      Register<TextBlock>(NProps.CharacterSpacing, (t, v) => t.CharacterSpacing = NConverters.ToInt32(v));
#endif
      Register<TextBlock>(NProps.FontFamily, (t, v) => t.FontFamily = NConverters.ToFontFamily(v));
      Register<TextBlock>(NProps.FontSize, (t, v) => t.FontSize = NConverters.ToDouble(v));
      Register<TextBlock>(NProps.FontStretch, (t, v) => t.FontStretch = NConverters.ToFontStretch(v));
      Register<TextBlock>(NProps.FontStyle, (t, v) => t.FontStyle = NConverters.ToFontStyle(v));
      Register<TextBlock>(NProps.FontWeight, (t, v) => t.FontWeight = NConverters.ToFontWeight(v));
      Register<TextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.NBrushes.Convert(v, t.Foreground));
      Register<TextBlock>(NProps.Inlines, (t, v) => AssignList(t.Inlines, v));
      Register<TextBlock>(NProps.LineHeight, (t, v) => t.LineHeight = NConverters.ToDouble(v));
      Register<TextBlock>(NProps.LineStackingStrategy, (t, v) => t.LineStackingStrategy = NConverters.ToEnum<LineStackingStrategy>(v));
      Register<TextBlock>(NProps.Padding, (t, v) => t.Padding = NConverters.NThickness.Convert(v));
      Register<TextBlock>(NProps.TextAlignment, (t, v) => t.TextAlignment = NConverters.ToEnum<TextAlignment>(v));
      //Register<TextBlock>(NProps.TextDecorations, (t, v) => AssignList(t.TextDecorations, v));
      //Register<TextBlock>(NProps.TextEffects, (t, v) => AssignList(t.TextEffects, v));
      Register<TextBlock>(NProps.TextTrimming, (t, v) => t.TextTrimming = NConverters.ToEnum<TextTrimming>(v));
      Register<TextBlock>(NProps.TextWrapping, (t, v) => t.TextWrapping = NConverters.ToEnum<TextWrapping>(v));
      Register<TextBlock>(NProps.Text, (t, v) => t.Text = NConverters.ToString(v));
    }

    void RegisterShape()
    {
      Register<Shape>(NProps.Fill, (t, v) => t.Fill = NConverters.NBrushes.Convert(v, t.Fill));
      Register<Shape>(NProps.Stretch, (t, v) => t.Stretch = NConverters.ToEnum<Stretch>(v));
      Register<Shape>(NProps.Stroke, (t, v) => t.Stroke = NConverters.NBrushes.Convert(v, t.Stroke));
      //Register<Shape>(NProps.StrokeDashArray, (t, v( => t.StrokeDashArray = NConverters.ToDoubleCollection(v));
      Register<Shape>(NProps.StrokeDashCap, (t, v) => t.StrokeDashCap = NConverters.ToEnum<PenLineCap>(v));
      Register<Shape>(NProps.StrokeDashOffset, (t, v) => t.StrokeDashOffset = NConverters.ToDouble(v));
      Register<Shape>(NProps.StrokeEndLineCap, (t, v) => t.StrokeEndLineCap = NConverters.ToEnum<PenLineCap>(v));
      Register<Shape>(NProps.StrokeLineJoin, (t, v) => t.StrokeLineJoin = NConverters.ToEnum<PenLineJoin>(v));
      Register<Shape>(NProps.StrokeMiterLimit, (t, v) => t.StrokeMiterLimit = NConverters.ToDouble(v));
      Register<Shape>(NProps.StrokeStartLineCap, (t, v) => t.StrokeStartLineCap = NConverters.ToEnum<PenLineCap>(v));
      Register<Shape>(NProps.StrokeThickness, (t, v) => t.StrokeThickness = NConverters.ToDouble(v));
    }

    void RegisterBorder()
    {
      Register<Border>(NProps.Background, (t, v) => t.Background = NConverters.NBrushes.Convert(v, t.Background));
      Register<Border>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.NBrushes.Convert(v, t.BorderBrush));
      Register<Border>(NProps.BorderThickness, (t, v) => t.BorderThickness = NConverters.NThickness.Convert(v));
#if SILVERLIGHT || NETFX_CORE
      Register<Border>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
#else
      Register<Decorator>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
#endif
      Register<Border>(NProps.Padding, (t, v) => t.Padding = NConverters.NThickness.Convert(v));
      //Register<Border>(NProps.CornerRadius, (t, v) => t.CornerRadius = NConverters.NThickness.Convert(v));
    }

    void RegisterColumnDefinition()
    {
      Register<ColumnDefinition>(NProps.Width, (t, v) => t.Width = NConverters.ToGridLength(v));
      Register<ColumnDefinition>(NProps.MaxWidth, (t, v) => t.MaxWidth = NConverters.ToDouble(v));
      Register<ColumnDefinition>(NProps.MinWidth, (t, v) => t.MinWidth = NConverters.ToDouble(v));
    }

    void RegisterRowDefinition()
    {
      Register<RowDefinition>(NProps.Height, (t, v) => t.Height = NConverters.ToGridLength(v));
      Register<RowDefinition>(NProps.MaxHeight, (t, v) => t.MaxHeight = NConverters.ToDouble(v));
      Register<RowDefinition>(NProps.MinHeight, (t, v) => t.MinHeight = NConverters.ToDouble(v));
    }

    void RegisterGrid()
    {
      Register<Grid>(NProps.ColumnDefinitions, (t, v) => AssignList(t.ColumnDefinitions, v));
      Register<Grid>(NProps.RowDefinitions, (t, v) => AssignList(t.RowDefinitions, v));
      Register<Grid>(NProps.ShowGridLines, (t, v) => NConverters.ToBool(v));
    }

    void RegisterStackPanel()
    {
      Register<StackPanel>(NProps.Orientation, (t, v) => t.Orientation = NConverters.ToEnum<Orientation>(v));
    }

    void RegisterRichTextBox()
    {
#if SILVERLIGHT
      Register<RichTextBox>(NProps.ContentChanged, (t, v) => t.ContentChanged += NConverters.NEvents.ToContentChangedEventHandler(v));
#endif
    }

    void RegisterUserControl()
    {
#if SILVERLIGHT
      Register<UserControl>(NProps.Content, (t, v) => AssignSingle(o => o.Content, (o, i) => o.Content = i, t, v));
#endif
    }

    void RegisterPanel()
    {
      Register<Panel>(NProps.Background, (t, v) => t.Background = NConverters.NBrushes.Convert(v, t.Background));
      Register<Panel>(NProps.Children, (t, v) => AssignList(t.Children, v));
    }

    void RegisterControl()
    {
      Register<Control>(NProps.Background, (t, v) => t.Background = NConverters.NBrushes.Convert(v, t.Background));
      Register<Control>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.NBrushes.Convert(v, t.BorderBrush));
      Register<Control>(NProps.BorderThickness, (t, v) => t.BorderThickness = NConverters.NThickness.Convert(v));
      Register<Control>(NProps.FontFamily, (t, v) => t.FontFamily = NConverters.ToFontFamily(v));
      Register<Control>(NProps.FontSize, (t, v) => t.FontSize = NConverters.ToDouble(v));
      Register<Control>(NProps.FontStretch, (t, v) => t.FontStretch = NConverters.ToFontStretch(v));
      Register<Control>(NProps.FontStyle, (t, v) => t.FontStyle = NConverters.ToFontStyle(v));
      Register<Control>(NProps.FontWeight, (t, v) => t.FontWeight = NConverters.ToFontWeight(v));
      Register<Control>(NProps.Foreground, (t, v) => t.Foreground = NConverters.NBrushes.Convert(v, t.Foreground));
      Register<Control>(NProps.HorizontalContentAlignment, (t, v) => t.HorizontalContentAlignment = NConverters.ToEnum<HorizontalAlignment>(v));
      Register<Control>(NProps.IsTabStop, (t, v) => t.IsTabStop = NConverters.ToBool(v));
      Register<Control>(NProps.Padding, (t, v) => t.Padding = NConverters.NThickness.Convert(v));
      Register<Control>(NProps.TabIndex, (t, v) => t.TabIndex = NConverters.ToInt32(v));
      Register<Control>(NProps.Template, (t, v) => AssignSingle(o => o.Template, (o, i) => o.Template = i, t, v));
      Register<Control>(NProps.VerticalContentAlignment, (t, v) => t.VerticalContentAlignment = NConverters.ToEnum<VerticalAlignment>(v));
      Register<Control>(NProps.IsEnabled, (t, v) => t.IsEnabled = NConverters.ToBool(v));
#if SILVERLIGHT || NETFX_CORE
      Register<Control>(NProps.CharacterSpacing, (t, v) => t.CharacterSpacing = NConverters.ToInt32(v));
      Register<Control>(NProps.TabNavigation, (t, v) => t.TabNavigation = NConverters.ToEnum<KeyboardNavigationMode>(v));
#endif
    }

    void RegisterFrameworkElement()
    {
      Register<FrameworkElement>(NProps.DataContext, (t, v) => t.DataContext = v);
      Register<FrameworkElement>(NProps.Width, (t, v) => t.Width = NConverters.ToLength(v));
      Register<FrameworkElement>(NProps.Height, (t, v) => t.Height = NConverters.ToLength(v));
      Register<FrameworkElement>(NProps.MinWidth, (t, v) => t.MinWidth = NConverters.ToDouble(v));
      Register<FrameworkElement>(NProps.MinHeight, (t, v) => t.MinHeight = NConverters.ToDouble(v));
      Register<FrameworkElement>(NProps.MaxWidth, (t, v) => t.MaxWidth = NConverters.ToDouble(v));
      Register<FrameworkElement>(NProps.MaxHeight, (t, v) => t.MaxHeight = NConverters.ToDouble(v));
      Register<FrameworkElement>(NProps.Name, (t, v) => t.Name = NConverters.ToString(v));
      Register<FrameworkElement>(NProps.HorizontalAlignment, (t, v) => t.HorizontalAlignment = NConverters.ToEnum<HorizontalAlignment>(v));
      Register<FrameworkElement>(NProps.VerticalAlignment, (t, v) => t.VerticalAlignment = NConverters.ToEnum<VerticalAlignment>(v));
      Register<FrameworkElement>(NProps.Tag, (t, v) => t.Tag = v);
      Register<FrameworkElement>(NProps.Style, (t, v) => t.Style = NConverters.ToStyle(v));
      Register<FrameworkElement>(NProps.FlowDirection, (t, v) => t.FlowDirection = NConverters.ToEnum<FlowDirection>(v));
      Register<FrameworkElement>(NProps.Margin, (t, v) => t.Margin = NConverters.NThickness.Convert(v));
      Register<FrameworkElement>(NProps.Triggers, (t, v) => AssignList(t.Triggers, v));
#if NETFX_CORE
      Register<FrameworkElement>(NProps.Language, (t, v) => t.Language = NConverters.ToString(v));
#else
      Register<FrameworkElement>(NProps.Language, (t, v) => t.Language = NConverters.ToLanguage(v));
      Register<FrameworkElement>(NProps.TextOptionsTextFormattingMode, (t, v) => TextOptions.SetTextFormattingMode(t, NConverters.ToEnum<TextFormattingMode>(v)));
      Register<FrameworkElement>(NProps.TextOptionsTextHintingMode, (t, v) => TextOptions.SetTextHintingMode(t, NConverters.ToEnum<TextHintingMode>(v)));
      Register<FrameworkElement>(NProps.TextOptionsTextRenderingMode, (t, v) => TextOptions.SetTextRenderingMode(t, NConverters.ToEnum<TextRenderingMode>(v)));
      Register<FrameworkElement>(NProps.Cursor, (t, v) => t.Cursor = NConverters.ToCursor(v));
#endif
      Register<FrameworkElement>(NProps.GridColumn, (t, v) => Grid.SetColumn(t, NConverters.ToInt32(v)));
      Register<FrameworkElement>(NProps.GridColumnSpan, (t, v) => Grid.SetColumnSpan(t, NConverters.ToInt32(v)));
      Register<FrameworkElement>(NProps.GridRow, (t, v) => Grid.SetRow(t, NConverters.ToInt32(v)));
      Register<FrameworkElement>(NProps.GridRowSpan, (t, v) => Grid.SetRowSpan(t, NConverters.ToInt32(v)));
      //public ResourceDictionary Resources { get; set; }
    }

    void RegisterUIElement()
    {
#if SILVERLIGHT

      Register<UIElement>(NProps.AllowDrop, (t, v) => t.AllowDrop = NConverters.ToBool(v));
      Register<UIElement>(NProps.CacheMode, (t, v) => AssignSingle(o => o.CacheMode, (o, i) => o.CacheMode = i, t, v));
      Register<UIElement>(NProps.Clip, (t, v) => AssignSingle(o => o.Clip, (o, i) => o.Clip = i, t, v));
      Register<UIElement>(NProps.Effect, (t, v) => AssignSingle(o => o.Effect, (o, i) => o.Effect = i, t, v));
      Register<UIElement>(NProps.IsHitTestVisible, (t, v) => t.IsHitTestVisible = NConverters.ToBool(v));
      Register<UIElement>(NProps.Opacity, (t, v) => t.Opacity = NConverters.ToDouble(v));
      Register<UIElement>(NProps.OpacityMask, (t, v) => t.OpacityMask = NConverters.NBrushes.Convert(v, t.OpacityMask));
      Register<UIElement>(NProps.Projection, (t, v) => AssignSingle(o => o.Projection, (o, i) => o.Projection = i, t, v));
      Register<UIElement>(NProps.RenderTransform, (t, v) => AssignSingle(o => o.RenderTransform, (o, i) => o.RenderTransform = i, t, v));
      Register<UIElement>(NProps.RenderTransformOrigin, (t, v) => t.RenderTransformOrigin = NConverters.ToPoint(v));
      Register<UIElement>(NProps.UseLayoutRounding, (t, v) => t.UseLayoutRounding = NConverters.ToBool(v));
      Register<UIElement>(NProps.Visibility, (t, v) => t.Visibility = NConverters.ToEnum<Visibility>(v));

      Register<UIElement>(NProps._DoubleTap, (t, v) => t.AddHandler(UIElement.DoubleTapEvent, NConverters.NEvents.ToEventHandler<GestureEventArgs>(v), true));
      Register<UIElement>(NProps._Hold, (t, v) => t.AddHandler(UIElement.HoldEvent, NConverters.NEvents.ToEventHandler<GestureEventArgs>(v), true));
      Register<UIElement>(NProps._KeyDown, (t, v) => t.AddHandler(UIElement.KeyDownEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._KeyUp, (t, v) => t.AddHandler(UIElement.KeyUpEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationCompleted, (t, v) => t.AddHandler(UIElement.ManipulationCompletedEvent, NConverters.NEvents.ToManipulationCompletedEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationDelta, (t, v) => t.AddHandler(UIElement.ManipulationDeltaEvent, NConverters.NEvents.ToManipulationDeltaEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationStarted, (t, v) => t.AddHandler(UIElement.ManipulationStartedEvent, NConverters.NEvents.ToManipulationStartedEventHandler(v), true));
      Register<UIElement>(NProps._MouseLeftButtonDown, (t, v) => t.AddHandler(UIElement.MouseLeftButtonDownEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseLeftButtonUp, (t, v) => t.AddHandler(UIElement.MouseLeftButtonUpEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseRightButtonDown, (t, v) => t.AddHandler(UIElement.MouseRightButtonDownEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseRightButtonUp, (t, v) => t.AddHandler(UIElement.MouseRightButtonUpEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseWheel, (t, v) => t.AddHandler(UIElement.MouseWheelEvent, NConverters.NEvents.ToMouseWheelEventHandler(v), true));
      Register<UIElement>(NProps._Tap, (t, v) => t.AddHandler(UIElement.TapEvent, NConverters.NEvents.ToEventHandler<GestureEventArgs>(v), true));
      Register<UIElement>(NProps._TextInput, (t, v) => t.AddHandler(UIElement.TextInputEvent, NConverters.NEvents.ToTextCompositionEventHandler(v), true));
      Register<UIElement>(NProps._TextInputStart, (t, v) => t.AddHandler(UIElement.TextInputStartEvent, NConverters.NEvents.ToTextCompositionEventHandler(v), true));
      Register<UIElement>(NProps._TextInputUpdate, (t, v) => t.AddHandler(UIElement.TextInputUpdateEvent, NConverters.NEvents.ToTextCompositionEventHandler(v), true));
      Register<UIElement>(NProps.DoubleTap, (t, v) => t.DoubleTap += NConverters.NEvents.ToEventHandler<GestureEventArgs>(v));
      Register<UIElement>(NProps.DragEnter, (t, v) => t.DragEnter += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragLeave, (t, v) => t.DragLeave += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragOver, (t, v) => t.DragOver += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.Drop, (t, v) => t.Drop += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.GotFocus, (t, v) => t.GotFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.Hold, (t, v) => t.Hold += NConverters.NEvents.ToEventHandler<GestureEventArgs>(v));
      Register<UIElement>(NProps.KeyDown, (t, v) => t.KeyDown += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.KeyUp, (t, v) => t.KeyUp += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.LostFocus, (t, v) => t.LostFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.LostMouseCapture, (t, v) => t.LostMouseCapture += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.ManipulationCompleted, (t, v) => t.ManipulationCompleted += NConverters.NEvents.ToManipulationCompletedEventHandler(v));
      Register<UIElement>(NProps.ManipulationDelta, (t, v) => t.ManipulationDelta += NConverters.NEvents.ToManipulationDeltaEventHandler(v));
      Register<UIElement>(NProps.ManipulationStarted, (t, v) => t.ManipulationStarted += NConverters.NEvents.ToManipulationStartedEventHandler(v));
      Register<UIElement>(NProps.MediaCommand, (t, v) => t.MediaCommand += NConverters.NEvents.ToMediaCommandEventHandler(v));
      Register<UIElement>(NProps.MouseEnter, (t, v) => t.MouseEnter += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseLeave, (t, v) => t.MouseLeave += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseLeftButtonDown, (t, v) => t.MouseLeftButtonDown += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseLeftButtonUp, (t, v) => t.MouseLeftButtonUp += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseMove, (t, v) => t.MouseMove += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseRightButtonDown, (t, v) => t.MouseRightButtonDown += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseRightButtonUp, (t, v) => t.MouseRightButtonUp += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseWheel, (t, v) => t.MouseWheel += NConverters.NEvents.ToMouseWheelEventHandler(v));
      Register<UIElement>(NProps.Tap, (t, v) => t.Tap += NConverters.NEvents.ToEventHandler<GestureEventArgs>(v));
      Register<UIElement>(NProps.TextInput, (t, v) => t.TextInput += NConverters.NEvents.ToTextCompositionEventHandler(v));
      Register<UIElement>(NProps.TextInputStart, (t, v) => t.TextInputStart += NConverters.NEvents.ToTextCompositionEventHandler(v));
      Register<UIElement>(NProps.TextInputUpdate, (t, v) => t.TextInputUpdate += NConverters.NEvents.ToTextCompositionEventHandler(v));

#elif NETFX_CORE

      Register<UIElement>(NProps.AllowDrop, (t, v) => t.AllowDrop = NConverters.ToBool(v));
      Register<UIElement>(NProps.CacheMode, (t, v) => AssignSingle(o => o.CacheMode, (o, i) => o.CacheMode = i, t, v));
      Register<UIElement>(NProps.Clip, (t, v) => AssignSingle(o => o.Clip, (o, i) => o.Clip = i, t, v));
      Register<UIElement>(NProps.CompositeMode, (t, v) => t.CompositeMode = NConverters.ToEnum<ElementCompositeMode>(v));
      Register<UIElement>(NProps.IsDoubleTapEnabled, (t, v) => t.IsDoubleTapEnabled = NConverters.ToBool(v));
      Register<UIElement>(NProps.IsHitTestVisible, (t, v) => t.IsHitTestVisible = NConverters.ToBool(v));
      Register<UIElement>(NProps.IsHoldingEnabled, (t, v) => t.IsHoldingEnabled = NConverters.ToBool(v));
      Register<UIElement>(NProps.IsRightTapEnabled, (t, v) => t.IsRightTapEnabled = NConverters.ToBool(v));
      Register<UIElement>(NProps.IsTapEnabled, (t, v) => t.IsTapEnabled = NConverters.ToBool(v));
      Register<UIElement>(NProps.ManipulationMode, (t, v) => t.ManipulationMode = NConverters.ToEnum<ManipulationModes>(v));
      Register<UIElement>(NProps.Opacity, (t, v) => t.Opacity = NConverters.ToDouble(v));
      Register<UIElement>(NProps.Projection, (t, v) => AssignSingle(o => o.Projection, (o, i) => o.Projection = i, t, v));
      Register<UIElement>(NProps.RenderTransform, (t, v) => AssignSingle(o => o.RenderTransform, (o, i) => o.RenderTransform = i, t, v));
      Register<UIElement>(NProps.RenderTransformOrigin, (t, v) => t.RenderTransformOrigin = NConverters.ToPoint(v));
      Register<UIElement>(NProps.Transitions, (t, v) => AssignList(t.Transitions, v));
      Register<UIElement>(NProps.UseLayoutRounding, (t, v) => t.UseLayoutRounding = NConverters.ToBool(v));
      Register<UIElement>(NProps.Visibility, (t, v) => t.Visibility = NConverters.ToEnum<Visibility>(v));

      Register<UIElement>(NProps._DoubleTapped, (t, v) => t.AddHandler(UIElement.DoubleTappedEvent, NConverters.NEvents.ToDoubleTappedEventHandler(v), true));
      Register<UIElement>(NProps._DragEnter, (t, v) => t.AddHandler(UIElement.DragEnterEvent, NConverters.NEvents.ToDragEventHandler(v), true));
      Register<UIElement>(NProps._DragLeave, (t, v) => t.AddHandler(UIElement.DragLeaveEvent, NConverters.NEvents.ToDragEventHandler(v), true));
      Register<UIElement>(NProps._DragOver, (t, v) => t.AddHandler(UIElement.DragOverEvent, NConverters.NEvents.ToDragEventHandler(v), true));
      Register<UIElement>(NProps._Drop, (t, v) => t.AddHandler(UIElement.DropEvent, NConverters.NEvents.ToDragEventHandler(v), true));
      Register<UIElement>(NProps._Holding, (t, v) => t.AddHandler(UIElement.HoldingEvent, NConverters.NEvents.ToHoldingEventHandler(v), true));
      Register<UIElement>(NProps._KeyDown, (t, v) => t.AddHandler(UIElement.KeyDownEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._KeyUp, (t, v) => t.AddHandler(UIElement.KeyUpEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationCompleted, (t, v) => t.AddHandler(UIElement.ManipulationCompletedEvent, NConverters.NEvents.ToManipulationCompletedEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationDelta, (t, v) => t.AddHandler(UIElement.ManipulationDeltaEvent, NConverters.NEvents.ToManipulationDeltaEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationInertiaStarting, (t, v) => t.AddHandler(UIElement.ManipulationInertiaStartingEvent, NConverters.NEvents.ToManipulationInertiaStartingEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationStarted, (t, v) => t.AddHandler(UIElement.ManipulationStartedEvent, NConverters.NEvents.ToManipulationStartedEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationStarting, (t, v) => t.AddHandler(UIElement.ManipulationStartingEvent, NConverters.NEvents.ToManipulationStartingEventHandler(v), true));
      Register<UIElement>(NProps._PointerCanceled, (t, v) => t.AddHandler(UIElement.PointerCanceledEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerCaptureLost, (t, v) => t.AddHandler(UIElement.PointerCaptureLostEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerEntered, (t, v) => t.AddHandler(UIElement.PointerEnteredEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerExited, (t, v) => t.AddHandler(UIElement.PointerExitedEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerMoved, (t, v) => t.AddHandler(UIElement.PointerMovedEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerPressed, (t, v) => t.AddHandler(UIElement.PointerPressedEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerReleased, (t, v) => t.AddHandler(UIElement.PointerReleasedEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._PointerWheelChanged, (t, v) => t.AddHandler(UIElement.PointerWheelChangedEvent, NConverters.NEvents.ToPointerEventHandler(v), true));
      Register<UIElement>(NProps._RightTapped, (t, v) => t.AddHandler(UIElement.RightTappedEvent, NConverters.NEvents.ToRightTappedEventHandler(v), true));
      Register<UIElement>(NProps._Tapped, (t, v) => t.AddHandler(UIElement.TappedEvent, NConverters.NEvents.ToTappedEventHandler(v), true));
      Register<UIElement>(NProps.DoubleTapped, (t, v) => t.DoubleTapped += NConverters.NEvents.ToDoubleTappedEventHandler(v));
      Register<UIElement>(NProps.DragEnter, (t, v) => t.DragEnter += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragLeave, (t, v) => t.DragLeave += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragOver, (t, v) => t.DragOver += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.Drop, (t, v) => t.Drop += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.GotFocus, (t, v) => t.GotFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.Holding, (t, v) => t.Holding += NConverters.NEvents.ToHoldingEventHandler(v));
      Register<UIElement>(NProps.KeyDown, (t, v) => t.KeyDown += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.KeyUp, (t, v) => t.KeyUp += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.LostFocus, (t, v) => t.LostFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.ManipulationCompleted, (t, v) => t.ManipulationCompleted += NConverters.NEvents.ToManipulationCompletedEventHandler(v));
      Register<UIElement>(NProps.ManipulationDelta, (t, v) => t.ManipulationDelta += NConverters.NEvents.ToManipulationDeltaEventHandler(v));
      Register<UIElement>(NProps.ManipulationInertiaStarting, (t, v) => t.ManipulationInertiaStarting += NConverters.NEvents.ToManipulationInertiaStartingEventHandler(v));
      Register<UIElement>(NProps.ManipulationStarted, (t, v) => t.ManipulationStarted += NConverters.NEvents.ToManipulationStartedEventHandler(v));
      Register<UIElement>(NProps.ManipulationStarting, (t, v) => t.ManipulationStarting += NConverters.NEvents.ToManipulationStartingEventHandler(v));
      Register<UIElement>(NProps.PointerCanceled, (t, v) => t.PointerCanceled += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerCaptureLost, (t, v) => t.PointerCaptureLost += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerEntered, (t, v) => t.PointerEntered += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerExited, (t, v) => t.PointerExited += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerMoved, (t, v) => t.PointerMoved += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerPressed, (t, v) => t.PointerPressed += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerReleased, (t, v) => t.PointerReleased += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.PointerWheelChanged, (t, v) => t.PointerWheelChanged += NConverters.NEvents.ToPointerEventHandler(v));
      Register<UIElement>(NProps.RightTapped, (t, v) => t.RightTapped += NConverters.NEvents.ToRightTappedEventHandler(v));
      Register<UIElement>(NProps.Tapped, (t, v) => t.Tapped += NConverters.NEvents.ToTappedEventHandler(v));

#if WINDOWS_UWP

      Register<UIElement>(NProps.Transform3D, (t, v) => AssignSingle(o => o.Transform3D, (o, i) => o.Transform3D = i, t, v));
      Register<UIElement>(NProps.CanDrag, (t, v) => t.CanDrag = NConverters.ToBool(v));
      Register<UIElement>(NProps.DragStarting, (t, v) => t.DragStarting += NConverters.NEvents.ToTypedEventHandler<UIElement, DragStartingEventArgs>(v));
      Register<UIElement>(NProps.DropCompleted, (t, v) => t.DropCompleted += NConverters.NEvents.ToTypedEventHandler<UIElement, DropCompletedEventArgs>(v));

#endif

#else
      Register<UIElement>(NProps.AllowDrop, (t, v) => t.AllowDrop = NConverters.ToBool(v));
      Register<UIElement>(NProps.CacheMode, (t, v) => AssignSingle(o => o.CacheMode, (o, i) => o.CacheMode = i, t, v));
      Register<UIElement>(NProps.Clip, (t, v) => AssignSingle(o => o.Clip, (o, i) => o.Clip = i, t, v));
      Register<UIElement>(NProps.Effect, (t, v) => AssignSingle(o => o.Effect, (o, i) => o.Effect = i, t, v));
      Register<UIElement>(NProps.IsHitTestVisible, (t, v) => t.IsHitTestVisible = NConverters.ToBool(v));
      Register<UIElement>(NProps.Opacity, (t, v) => t.Opacity = NConverters.ToDouble(v));
      Register<UIElement>(NProps.OpacityMask, (t, v) => t.OpacityMask = NConverters.NBrushes.Convert(v, t.OpacityMask));
      Register<UIElement>(NProps.RenderTransform, (t, v) => AssignSingle(o => o.RenderTransform, (o, i) => o.RenderTransform = i, t, v));
      Register<UIElement>(NProps.RenderTransformOrigin, (t, v) => t.RenderTransformOrigin = NConverters.ToPoint(v));
      Register<UIElement>(NProps.Visibility, (t, v) => t.Visibility = NConverters.ToEnum<Visibility>(v));

      Register<UIElement>(NProps._KeyDown, (t, v) => t.AddHandler(UIElement.KeyDownEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._KeyUp, (t, v) => t.AddHandler(UIElement.KeyUpEvent, NConverters.NEvents.ToKeyEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationCompleted, (t, v) => t.AddHandler(UIElement.ManipulationCompletedEvent, NConverters.NEvents.ToManipulationCompletedEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationDelta, (t, v) => t.AddHandler(UIElement.ManipulationDeltaEvent, NConverters.NEvents.ToManipulationDeltaEventHandler(v), true));
      Register<UIElement>(NProps._ManipulationStarted, (t, v) => t.AddHandler(UIElement.ManipulationStartedEvent, NConverters.NEvents.ToManipulationStartedEventHandler(v), true));
      Register<UIElement>(NProps._MouseLeftButtonDown, (t, v) => t.AddHandler(UIElement.MouseLeftButtonDownEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseLeftButtonUp, (t, v) => t.AddHandler(UIElement.MouseLeftButtonUpEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseRightButtonDown, (t, v) => t.AddHandler(UIElement.MouseRightButtonDownEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseRightButtonUp, (t, v) => t.AddHandler(UIElement.MouseRightButtonUpEvent, NConverters.NEvents.ToMouseButtonEventHandler(v), true));
      Register<UIElement>(NProps._MouseWheel, (t, v) => t.AddHandler(UIElement.MouseWheelEvent, NConverters.NEvents.ToMouseWheelEventHandler(v), true));
      Register<UIElement>(NProps._TextInput, (t, v) => t.AddHandler(UIElement.TextInputEvent, NConverters.NEvents.ToTextCompositionEventHandler(v), true));
      Register<UIElement>(NProps.DragEnter, (t, v) => t.DragEnter += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragLeave, (t, v) => t.DragLeave += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.DragOver, (t, v) => t.DragOver += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.Drop, (t, v) => t.Drop += NConverters.NEvents.ToDragEventHandler(v));
      Register<UIElement>(NProps.GotFocus, (t, v) => t.GotFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.KeyDown, (t, v) => t.KeyDown += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.KeyUp, (t, v) => t.KeyUp += NConverters.NEvents.ToKeyEventHandler(v));
      Register<UIElement>(NProps.LostFocus, (t, v) => t.LostFocus += NConverters.NEvents.ToRoutedEventHandler(v));
      Register<UIElement>(NProps.LostMouseCapture, (t, v) => t.LostMouseCapture += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.ManipulationCompleted, (t, v) => t.ManipulationCompleted += NConverters.NEvents.ToManipulationCompletedEventHandler(v));
      Register<UIElement>(NProps.ManipulationDelta, (t, v) => t.ManipulationDelta += NConverters.NEvents.ToManipulationDeltaEventHandler(v));
      Register<UIElement>(NProps.ManipulationStarted, (t, v) => t.ManipulationStarted += NConverters.NEvents.ToManipulationStartedEventHandler(v));
      Register<UIElement>(NProps.MouseEnter, (t, v) => t.MouseEnter += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseLeave, (t, v) => t.MouseLeave += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseLeftButtonDown, (t, v) => t.MouseLeftButtonDown += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseLeftButtonUp, (t, v) => t.MouseLeftButtonUp += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseMove, (t, v) => t.MouseMove += NConverters.NEvents.ToMouseEventHandler(v));
      Register<UIElement>(NProps.MouseRightButtonDown, (t, v) => t.MouseRightButtonDown += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseRightButtonUp, (t, v) => t.MouseRightButtonUp += NConverters.NEvents.ToMouseButtonEventHandler(v));
      Register<UIElement>(NProps.MouseWheel, (t, v) => t.MouseWheel += NConverters.NEvents.ToMouseWheelEventHandler(v));
      Register<UIElement>(NProps.TextInput, (t, v) => t.TextInput += NConverters.NEvents.ToTextCompositionEventHandler(v));

#endif
    }

    public object Create(NElement e)
    {
      return CreateTree(e);
    }

    public void Destroy(NElement e, object xamlElement)
    {
      e.Unmount();
    }

    public int GetContentKey(Type type)
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

    #region Property Setters Factories

    internal NSetter ResolveSetter(Type type, int id)
    {
      if (id <= NProps.Ref) return null;

      var entries = GetSetterEntries(id);

      if (entries == null)
      {
#if DEBUG
        throw new ArgumentException(string.Format("Unsupported property {0}", NProps.Store.GetKey(id)));
#else
        return null;
#endif
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
        throw new ArgumentException(string.Format("Unsupported attempt to assign {0}.{1} property", type.FullName, NProps.Store.GetKey(id)));
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

    void AssignSingle<C, T>(Func<C, T> getter, Action<C, T> setter, C target, object value)
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

      set:
      setter(target, (T)value);
    }

#if SILVERLIGHT || NETFX_CORE
    void AssignList<T>(IList<T> children, object value)
    {
      if (value == NDataBag.UnsetValue)
      {
        children.Clear();
        return;
      }

      var items = value as NElement[];
      if (items != null)
      {
        children.Clear();

        for (var i = 0; i < items.Length; i++)
          children.Add((T)Create(items[i]));

        return;
      }

      var patch = value as NListPatch;
      if (patch != null)
      {
        patch.ApplyToList(children);
        return;
      }

      Debug.WriteLine("Unsupported attempt to assign IList<{1}> property with {0} value", value, typeof(T).Name);
    }
#else
    void AssignList(IList children, object value)
    {
      if (value == NDataBag.UnsetValue)
      {
        children.Clear();
        return;
      }

      var items = value as NElement[];
      if (items != null)
      {
        children.Clear();

        for (var i = 0; i < items.Length; i++)
          children.Add(Create(items[i]));

        return;
      }

      var patch = value as NListPatch;
      if (patch != null)
      {
        patch.ApplyToList(children);
        return;
      }

      Debug.WriteLine("Unsupported attempt to assign IList property with {0} value", value);
    }
#endif

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
      return obj.GetInnerType().GetHashCode() ^ obj.Id.GetHashCode();
    }
  }
}
