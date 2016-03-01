using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NReact
{
  public partial class NXamlFactory: NFactory
  {
    public NXamlFactory()
    {
      GenerateUIElement();
      GenerateFrameworkElement();
      GenerateControl();
      GenerateTextBox();
      GenerateRichTextBox();
      GeneratePasswordBox();
      GenerateItemsControl();
      GenerateSelector();
      GenerateComboBox();
      GenerateListBox();
      GenerateContentControl();
      GenerateScrollViewer();
      GenerateButtonBase();
      GenerateToggleButton();
      GenerateRadioButton();
      GenerateHyperlinkButton();
      GenerateRepeatButton();
      GenerateListBoxItem();
      GenerateToolTip();
      GenerateUserControl();
      GenerateRangeBase();
      GenerateScrollBar();
      GenerateProgressBar();
      GenerateSlider();
      GenerateThumb();
      GenerateShape();
      GeneratePath();
      GenerateLine();
      GeneratePolygon();
      GeneratePolyline();
      GenerateRectangle();
      GenerateGlyphs();
      GeneratePanel();
      GenerateCanvas();
      GenerateInkPresenter();
      GenerateStackPanel();
      GenerateGrid();
      GenerateVirtualizingStackPanel();
      GenerateImage();
      GenerateTextBlock();
      GenerateRichTextBlockOverflow();
      GenerateRichTextBlock();
      GenerateMediaElement();
      GenerateMultiScaleImage();
      GenerateViewbox();
      GenerateBorder();
      GenerateContentPresenter();
      GenerateScrollContentPresenter();
      GenerateWebBrowser();
      GeneratePopup();
      GenerateTextElement();
      GenerateInline();
      GenerateRun();
      GenerateSpan();
      GenerateHyperlink();
      GenerateInlineUIContainer();
      GenerateBlock();
      GenerateParagraph();
      GenerateSection();
      GenerateColumnDefinition();
      GenerateRowDefinition();
      GenerateToolTipService();
      GenerateTextOptions();
    }

    public override int GetContentKey(Type type)
    {
      if (typeof(NClass).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(Section).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(Paragraph).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(InlineUIContainer).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Span).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(Run).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(Popup).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(ContentPresenter).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(Border).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Viewbox).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(RichTextBlock).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(TextBlock).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(Panel).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(UserControl).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(ContentControl).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(ItemsControl).IsAssignableFrom(type)) return NProps.Items;
      if (typeof(RichTextBox).IsAssignableFrom(type)) return NProps.Blocks;

      return NProps.CONTENT;
    }

    void GenerateUIElement()
    {
      Register<UIElement>(NProps.AllowDrop, UIElement.AllowDropProperty, NConverters.ToBool);
      Register<UIElement>(NProps.CacheMode, UIElement.CacheModeProperty);
      Register<UIElement>(NProps.Clip, UIElement.ClipProperty);
      Register<UIElement>(NProps.Effect, UIElement.EffectProperty);
      Register<UIElement>(NProps.IsHitTestVisible, UIElement.IsHitTestVisibleProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Opacity, UIElement.OpacityProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.OpacityMask, (t, v) => t.OpacityMask = NConverters.ToBrushT(v, t.OpacityMask));
      Register<UIElement>(NProps.Projection, UIElement.ProjectionProperty);
      Register<UIElement>(NProps.RenderTransform, UIElement.RenderTransformProperty);
      Register<UIElement>(NProps.RenderTransformOrigin, UIElement.RenderTransformOriginProperty, NConverters.ToPoint);
      Register<UIElement>(NProps.UseLayoutRounding, UIElement.UseLayoutRoundingProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Visibility, UIElement.VisibilityProperty, NConverters.ToEnum<Visibility>);
      RegisterEvent<UIElement>(NProps._DoubleTap, UIElement.DoubleTapEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._Hold, UIElement.HoldEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._KeyDown, UIElement.KeyDownEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._KeyUp, UIElement.KeyUpEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationCompleted, UIElement.ManipulationCompletedEvent, a => (EventHandler<ManipulationCompletedEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationDelta, UIElement.ManipulationDeltaEvent, a => (EventHandler<ManipulationDeltaEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationStarted, UIElement.ManipulationStartedEvent, a => (EventHandler<ManipulationStartedEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseLeftButtonDown, UIElement.MouseLeftButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseLeftButtonUp, UIElement.MouseLeftButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseRightButtonDown, UIElement.MouseRightButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseRightButtonUp, UIElement.MouseRightButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseWheel, UIElement.MouseWheelEvent, a => (MouseWheelEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._Tap, UIElement.TapEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TextInput, UIElement.TextInputEvent, a => (TextCompositionEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TextInputStart, UIElement.TextInputStartEvent, a => (TextCompositionEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TextInputUpdate, UIElement.TextInputUpdateEvent, a => (TextCompositionEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps.DoubleTap, (s, a) => s.DoubleTap += a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragEnter, (s, a) => s.DragEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragLeave, (s, a) => s.DragLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragOver, (s, a) => s.DragOver += a.EventHandler);
      RegisterEvent<UIElement>(NProps.Drop, (s, a) => s.Drop += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotFocus, (s, a) => s.GotFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.Hold, (s, a) => s.Hold += a.EventHandler);
      RegisterEvent<UIElement>(NProps.KeyDown, (s, a) => s.KeyDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.KeyUp, (s, a) => s.KeyUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostFocus, (s, a) => s.LostFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostMouseCapture, (s, a) => s.LostMouseCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationCompleted, (s, a) => s.ManipulationCompleted += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationDelta, (s, a) => s.ManipulationDelta += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationStarted, (s, a) => s.ManipulationStarted += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MediaCommand, (s, a) => s.MediaCommand += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseEnter, (s, a) => s.MouseEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeave, (s, a) => s.MouseLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeftButtonDown, (s, a) => s.MouseLeftButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeftButtonUp, (s, a) => s.MouseLeftButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseMove, (s, a) => s.MouseMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseRightButtonDown, (s, a) => s.MouseRightButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseRightButtonUp, (s, a) => s.MouseRightButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseWheel, (s, a) => s.MouseWheel += a.EventHandler);
      RegisterEvent<UIElement>(NProps.Tap, (s, a) => s.Tap += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TextInput, (s, a) => s.TextInput += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TextInputStart, (s, a) => s.TextInputStart += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TextInputUpdate, (s, a) => s.TextInputUpdate += a.EventHandler);
    }

    void GenerateFrameworkElement()
    {
      Register<FrameworkElement>(NProps.Cursor, FrameworkElement.CursorProperty, NConverters.ToCursor);
      Register<FrameworkElement>(NProps.DataContext, FrameworkElement.DataContextProperty);
      Register<FrameworkElement>(NProps.FlowDirection, FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<FrameworkElement>(NProps.Height, FrameworkElement.HeightProperty, NConverters.ToLength);
      Register<FrameworkElement>(NProps.HorizontalAlignment, FrameworkElement.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<FrameworkElement>(NProps.Language, FrameworkElement.LanguageProperty, NConverters.ToLanguage);
      Register<FrameworkElement>(NProps.Margin, FrameworkElement.MarginProperty, NConverters.ToThickness);
      Register<FrameworkElement>(NProps.MaxHeight, FrameworkElement.MaxHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MaxWidth, FrameworkElement.MaxWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinHeight, FrameworkElement.MinHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinWidth, FrameworkElement.MinWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.Name, FrameworkElement.NameProperty, NConverters.ToString);
      Register<FrameworkElement>(NProps.Resources, (t, v) => t.Resources = NConverters.ToResourceDictionaryT(v));
      Register<FrameworkElement>(NProps.Style, FrameworkElement.StyleProperty, NConverters.ToStyle);
      Register<FrameworkElement>(NProps.Tag, FrameworkElement.TagProperty);
      Register<FrameworkElement>(NProps.Triggers, (t, v) => AssignListT(t.Triggers, v));
      Register<FrameworkElement>(NProps.VerticalAlignment, FrameworkElement.VerticalAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<FrameworkElement>(NProps.Width, FrameworkElement.WidthProperty, NConverters.ToLength);
      RegisterEvent<FrameworkElement>(NProps._Loaded, FrameworkElement.LoadedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.BindingValidationError, (s, a) => s.BindingValidationError += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.DataContextChanged, (s, a) => s.DataContextChanged += a.EventHandlerAny);
      RegisterEvent<FrameworkElement>(NProps.LayoutUpdated, (s, a) => s.LayoutUpdated += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.Loaded, (s, a) => s.Loaded += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.SizeChanged, (s, a) => s.SizeChanged += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.Unloaded, (s, a) => s.Unloaded += a.EventHandler);
    }

    void GenerateControl()
    {
      Register<Control>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Control>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Control>(NProps.BorderThickness, Control.BorderThicknessProperty, NConverters.ToThickness);
      Register<Control>(NProps.CharacterSpacing, Control.CharacterSpacingProperty, NConverters.ToInt32);
      Register<Control>(NProps.FontFamily, Control.FontFamilyProperty, NConverters.ToFontFamily);
      Register<Control>(NProps.FontSize, Control.FontSizeProperty, NConverters.ToDouble);
      Register<Control>(NProps.FontStretch, Control.FontStretchProperty, NConverters.ToFontStretch);
      Register<Control>(NProps.FontStyle, Control.FontStyleProperty, NConverters.ToFontStyle);
      Register<Control>(NProps.FontWeight, Control.FontWeightProperty, NConverters.ToFontWeight);
      Register<Control>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<Control>(NProps.HorizontalContentAlignment, Control.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<Control>(NProps.IsEnabled, Control.IsEnabledProperty, NConverters.ToBool);
      Register<Control>(NProps.IsTabStop, Control.IsTabStopProperty, NConverters.ToBool);
      Register<Control>(NProps.Padding, Control.PaddingProperty, NConverters.ToThickness);
      Register<Control>(NProps.TabIndex, Control.TabIndexProperty, NConverters.ToInt32);
      Register<Control>(NProps.TabNavigation, Control.TabNavigationProperty, NConverters.ToEnum<KeyboardNavigationMode>);
      Register<Control>(NProps.Template, Control.TemplateProperty, NConverters.ToControlTemplate);
      Register<Control>(NProps.VerticalContentAlignment, Control.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      RegisterEvent<Control>(NProps.IsEnabledChanged, (s, a) => s.IsEnabledChanged += a.EventHandlerAny);
    }

    void GenerateTextBox()
    {
      Register<TextBox>(NProps.AcceptsReturn, TextBox.AcceptsReturnProperty, NConverters.ToBool);
      Register<TextBox>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.ToBrushT(v, t.CaretBrush));
      Register<TextBox>(NProps.FontSource, (t, v) => t.FontSource = NConverters.ToFontSourceT(v));
      Register<TextBox>(NProps.HorizontalScrollBarVisibility, (t, v) => t.HorizontalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v));
      Register<TextBox>(NProps.InputScope, TextBox.InputScopeProperty);
      Register<TextBox>(NProps.IsReadOnly, TextBox.IsReadOnlyProperty, NConverters.ToBool);
      Register<TextBox>(NProps.LineHeight, TextBox.LineHeightProperty, NConverters.ToDouble);
      Register<TextBox>(NProps.LineStackingStrategy, TextBox.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<TextBox>(NProps.MaxLength, TextBox.MaxLengthProperty, NConverters.ToInt32);
      Register<TextBox>(NProps.SelectedText, (t, v) => t.SelectedText = NConverters.ToStringT(v));
      Register<TextBox>(NProps.SelectionBackground, (t, v) => t.SelectionBackground = NConverters.ToBrushT(v, t.SelectionBackground));
      Register<TextBox>(NProps.SelectionForeground, (t, v) => t.SelectionForeground = NConverters.ToBrushT(v, t.SelectionForeground));
      Register<TextBox>(NProps.SelectionLength, (t, v) => t.SelectionLength = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.SelectionStart, (t, v) => t.SelectionStart = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.Text, TextBox.TextProperty, NConverters.ToString);
      Register<TextBox>(NProps.TextAlignment, TextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBox>(NProps.TextWrapping, TextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      Register<TextBox>(NProps.VerticalScrollBarVisibility, (t, v) => t.VerticalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v));
      Register<TextBox>(NProps.Watermark, TextBox.WatermarkProperty);
      RegisterEvent<TextBox>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
      RegisterEvent<TextBox>(NProps.TextChanged, (s, a) => s.TextChanged += a.EventHandler);
    }

    void GenerateRichTextBox()
    {
      Register<RichTextBox>(NProps.AcceptsReturn, RichTextBox.AcceptsReturnProperty, NConverters.ToBool);
      Register<RichTextBox>(NProps.Blocks, (t, v) => AssignListT(t.Blocks, v));
      Register<RichTextBox>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.ToBrushT(v, t.CaretBrush));
      Register<RichTextBox>(NProps.HorizontalScrollBarVisibility, (t, v) => t.HorizontalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v));
      Register<RichTextBox>(NProps.IsReadOnly, RichTextBox.IsReadOnlyProperty, NConverters.ToBool);
      Register<RichTextBox>(NProps.LineHeight, RichTextBox.LineHeightProperty, NConverters.ToDouble);
      Register<RichTextBox>(NProps.LineStackingStrategy, RichTextBox.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<RichTextBox>(NProps.TextAlignment, RichTextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<RichTextBox>(NProps.TextWrapping, RichTextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      Register<RichTextBox>(NProps.VerticalScrollBarVisibility, (t, v) => t.VerticalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v));
      Register<RichTextBox>(NProps.Xaml, (t, v) => t.Xaml = NConverters.ToStringT(v));
      RegisterEvent<RichTextBox>(NProps.ContentChanged, (s, a) => s.ContentChanged += a.EventHandler);
      RegisterEvent<RichTextBox>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
    }

    void GeneratePasswordBox()
    {
      Register<PasswordBox>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.ToBrushT(v, t.CaretBrush));
      Register<PasswordBox>(NProps.FontSource, (t, v) => t.FontSource = NConverters.ToFontSourceT(v));
      Register<PasswordBox>(NProps.MaxLength, PasswordBox.MaxLengthProperty, NConverters.ToInt32);
      Register<PasswordBox>(NProps.Password, PasswordBox.PasswordProperty, NConverters.ToString);
      Register<PasswordBox>(NProps.PasswordChar, PasswordBox.PasswordCharProperty, NConverters.ToChar);
      Register<PasswordBox>(NProps.SelectionBackground, (t, v) => t.SelectionBackground = NConverters.ToBrushT(v, t.SelectionBackground));
      Register<PasswordBox>(NProps.SelectionForeground, (t, v) => t.SelectionForeground = NConverters.ToBrushT(v, t.SelectionForeground));
      RegisterEvent<PasswordBox>(NProps.PasswordChanged, (s, a) => s.PasswordChanged += a.EventHandler);
    }

    void GenerateItemsControl()
    {
      Register<ItemsControl>(NProps.DisplayMemberPath, ItemsControl.DisplayMemberPathProperty, NConverters.ToString);
      Register<ItemsControl>(NProps.Items, (t, v) => AssignListT(t.Items, v));
      Register<ItemsControl>(NProps.ItemsPanel, ItemsControl.ItemsPanelProperty);
      Register<ItemsControl>(NProps.ItemsSource, ItemsControl.ItemsSourceProperty);
      Register<ItemsControl>(NProps.ItemTemplate, ItemsControl.ItemTemplateProperty, NConverters.ToDataTemplate);
    }

    void GenerateSelector()
    {
      Register<Selector>(NProps.IsSynchronizedWithCurrentItem, Selector.IsSynchronizedWithCurrentItemProperty, NConverters.ToBoolN);
      Register<Selector>(NProps.SelectedIndex, Selector.SelectedIndexProperty, NConverters.ToInt32);
      Register<Selector>(NProps.SelectedItem, Selector.SelectedItemProperty);
      Register<Selector>(NProps.SelectedValue, Selector.SelectedValueProperty);
      Register<Selector>(NProps.SelectedValuePath, Selector.SelectedValuePathProperty, NConverters.ToString);
      RegisterEvent<Selector>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
    }

    void GenerateComboBox()
    {
      Register<ComboBox>(NProps.IsDropDownOpen, ComboBox.IsDropDownOpenProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.ItemContainerStyle, ComboBox.ItemContainerStyleProperty, NConverters.ToStyle);
      Register<ComboBox>(NProps.MaxDropDownHeight, ComboBox.MaxDropDownHeightProperty, NConverters.ToDouble);
      RegisterEvent<ComboBox>(NProps.DropDownClosed, (s, a) => s.DropDownClosed += a.EventHandler);
      RegisterEvent<ComboBox>(NProps.DropDownOpened, (s, a) => s.DropDownOpened += a.EventHandler);
    }

    void GenerateListBox()
    {
      Register<ListBox>(NProps.ItemContainerStyle, ListBox.ItemContainerStyleProperty, NConverters.ToStyle);
      Register<ListBox>(NProps.SelectedItems, (t, v) => AssignList(t.SelectedItems, v));
      Register<ListBox>(NProps.SelectionMode, ListBox.SelectionModeProperty, NConverters.ToEnum<SelectionMode>);
    }

    void GenerateContentControl()
    {
      Register<ContentControl>(NProps.Content, ContentControl.ContentProperty);
      Register<ContentControl>(NProps.ContentTemplate, ContentControl.ContentTemplateProperty, NConverters.ToDataTemplate);
    }

    void GenerateScrollViewer()
    {
      Register<ScrollViewer>(NProps.HorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<ScrollViewer>(NProps.ManipulationMode, ScrollViewer.ManipulationModeProperty, NConverters.ToEnum<ManipulationMode>);
      Register<ScrollViewer>(NProps.VerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerManipulationMode, ScrollViewer.ManipulationModeProperty, NConverters.ToEnum<ManipulationMode>);
      Register<DependencyObject>(NProps.ScrollViewerHorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerVerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
    }

    void GenerateButtonBase()
    {
      Register<ButtonBase>(NProps.ClickMode, ButtonBase.ClickModeProperty, NConverters.ToEnum<ClickMode>);
      Register<ButtonBase>(NProps.Command, ButtonBase.CommandProperty);
      Register<ButtonBase>(NProps.CommandParameter, ButtonBase.CommandParameterProperty);
      RegisterEvent<ButtonBase>(NProps.Click, (s, a) => s.Click += a.EventHandler);
    }

    void GenerateToggleButton()
    {
      Register<ToggleButton>(NProps.IsChecked, ToggleButton.IsCheckedProperty, NConverters.ToBoolN);
      Register<ToggleButton>(NProps.IsThreeState, ToggleButton.IsThreeStateProperty, NConverters.ToBool);
      RegisterEvent<ToggleButton>(NProps.Checked, (s, a) => s.Checked += a.EventHandler);
      RegisterEvent<ToggleButton>(NProps.Indeterminate, (s, a) => s.Indeterminate += a.EventHandler);
      RegisterEvent<ToggleButton>(NProps.Unchecked, (s, a) => s.Unchecked += a.EventHandler);
    }

    void GenerateRadioButton()
    {
      Register<RadioButton>(NProps.GroupName, RadioButton.GroupNameProperty, NConverters.ToString);
    }

    void GenerateHyperlinkButton()
    {
      Register<HyperlinkButton>(NProps.NavigateUri, HyperlinkButton.NavigateUriProperty, NConverters.ToUri);
      Register<HyperlinkButton>(NProps.TargetName, HyperlinkButton.TargetNameProperty, NConverters.ToString);
    }

    void GenerateRepeatButton()
    {
      Register<RepeatButton>(NProps.Delay, RepeatButton.DelayProperty, NConverters.ToInt32);
      Register<RepeatButton>(NProps.Interval, RepeatButton.IntervalProperty, NConverters.ToInt32);
    }

    void GenerateListBoxItem()
    {
      Register<ListBoxItem>(NProps.IsSelected, ListBoxItem.IsSelectedProperty, NConverters.ToBool);
    }

    void GenerateToolTip()
    {
      Register<ToolTip>(NProps.HorizontalOffset, ToolTip.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<ToolTip>(NProps.IsOpen, ToolTip.IsOpenProperty, NConverters.ToBool);
      Register<ToolTip>(NProps.Placement, ToolTip.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<ToolTip>(NProps.PlacementTarget, ToolTip.PlacementTargetProperty);
      Register<ToolTip>(NProps.VerticalOffset, ToolTip.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<ToolTip>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<ToolTip>(NProps.Opened, (s, a) => s.Opened += a.EventHandler);
    }

    void GenerateUserControl()
    {
      Register<UserControl>(NProps.Content, UserControl.ContentProperty);
    }

    void GenerateRangeBase()
    {
      Register<RangeBase>(NProps.LargeChange, RangeBase.LargeChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Maximum, RangeBase.MaximumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Minimum, RangeBase.MinimumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.SmallChange, RangeBase.SmallChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Value, RangeBase.ValueProperty, NConverters.ToDouble);
      RegisterEvent<RangeBase>(NProps.ValueChanged, (s, a) => s.ValueChanged += a.EventHandler);
    }

    void GenerateScrollBar()
    {
      Register<ScrollBar>(NProps.Orientation, ScrollBar.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<ScrollBar>(NProps.ViewportSize, ScrollBar.ViewportSizeProperty, NConverters.ToDouble);
      RegisterEvent<ScrollBar>(NProps.Scroll, (s, a) => s.Scroll += a.EventHandler);
    }

    void GenerateProgressBar()
    {
      Register<ProgressBar>(NProps.IsIndeterminate, ProgressBar.IsIndeterminateProperty, NConverters.ToBool);
    }

    void GenerateSlider()
    {
      Register<Slider>(NProps.IsDirectionReversed, Slider.IsDirectionReversedProperty, NConverters.ToBool);
      Register<Slider>(NProps.Orientation, Slider.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GenerateThumb()
    {
      RegisterEvent<Thumb>(NProps.DragCompleted, (s, a) => s.DragCompleted += a.EventHandler);
      RegisterEvent<Thumb>(NProps.DragDelta, (s, a) => s.DragDelta += a.EventHandler);
      RegisterEvent<Thumb>(NProps.DragStarted, (s, a) => s.DragStarted += a.EventHandler);
    }

    void GenerateShape()
    {
      Register<Shape>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
      Register<Shape>(NProps.Stretch, Shape.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<Shape>(NProps.Stroke, (t, v) => t.Stroke = NConverters.ToBrushT(v, t.Stroke));
      Register<Shape>(NProps.StrokeDashArray, (t, v) => AssignListT(t.StrokeDashArray, v));
      Register<Shape>(NProps.StrokeDashCap, Shape.StrokeDashCapProperty, NConverters.ToEnum<PenLineCap>);
      Register<Shape>(NProps.StrokeDashOffset, Shape.StrokeDashOffsetProperty, NConverters.ToDouble);
      Register<Shape>(NProps.StrokeEndLineCap, Shape.StrokeEndLineCapProperty, NConverters.ToEnum<PenLineCap>);
      Register<Shape>(NProps.StrokeLineJoin, Shape.StrokeLineJoinProperty, NConverters.ToEnum<PenLineJoin>);
      Register<Shape>(NProps.StrokeMiterLimit, Shape.StrokeMiterLimitProperty, NConverters.ToDouble);
      Register<Shape>(NProps.StrokeStartLineCap, Shape.StrokeStartLineCapProperty, NConverters.ToEnum<PenLineCap>);
      Register<Shape>(NProps.StrokeThickness, Shape.StrokeThicknessProperty, NConverters.ToDouble);
    }

    void GeneratePath()
    {
      Register<Path>(NProps.Data, Path.DataProperty);
    }

    void GenerateLine()
    {
      Register<Line>(NProps.X1, Line.X1Property, NConverters.ToDouble);
      Register<Line>(NProps.X2, Line.X2Property, NConverters.ToDouble);
      Register<Line>(NProps.Y1, Line.Y1Property, NConverters.ToDouble);
      Register<Line>(NProps.Y2, Line.Y2Property, NConverters.ToDouble);
    }

    void GeneratePolygon()
    {
      Register<Polygon>(NProps.FillRule, Polygon.FillRuleProperty, NConverters.ToEnum<FillRule>);
      Register<Polygon>(NProps.Points, (t, v) => AssignListT(t.Points, v));
    }

    void GeneratePolyline()
    {
      Register<Polyline>(NProps.FillRule, Polyline.FillRuleProperty, NConverters.ToEnum<FillRule>);
      Register<Polyline>(NProps.Points, (t, v) => AssignListT(t.Points, v));
    }

    void GenerateRectangle()
    {
      Register<Rectangle>(NProps.RadiusX, Rectangle.RadiusXProperty, NConverters.ToDouble);
      Register<Rectangle>(NProps.RadiusY, Rectangle.RadiusYProperty, NConverters.ToDouble);
    }

    void GenerateGlyphs()
    {
      Register<Glyphs>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
      Register<Glyphs>(NProps.FontRenderingEmSize, Glyphs.FontRenderingEmSizeProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.FontSource, (t, v) => t.FontSource = NConverters.ToFontSourceT(v));
      Register<Glyphs>(NProps.FontUri, Glyphs.FontUriProperty, NConverters.ToUri);
      Register<Glyphs>(NProps.Indices, Glyphs.IndicesProperty, NConverters.ToString);
      Register<Glyphs>(NProps.OriginX, Glyphs.OriginXProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.OriginY, Glyphs.OriginYProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.StyleSimulations, Glyphs.StyleSimulationsProperty, NConverters.ToEnum<StyleSimulations>);
      Register<Glyphs>(NProps.UnicodeString, Glyphs.UnicodeStringProperty, NConverters.ToString);
    }

    void GeneratePanel()
    {
      Register<Panel>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Panel>(NProps.Children, (t, v) => AssignListT(t.Children, v));
    }

    void GenerateCanvas()
    {
      Register<UIElement>(NProps.CanvasLeft, Canvas.LeftProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasTop, Canvas.TopProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasZIndex, Canvas.ZIndexProperty, NConverters.ToInt32);
    }

    void GenerateInkPresenter()
    {
      Register<InkPresenter>(NProps.Strokes, (t, v) => AssignListT(t.Strokes, v));
    }

    void GenerateStackPanel()
    {
      Register<StackPanel>(NProps.Orientation, StackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GenerateGrid()
    {
      Register<Grid>(NProps.ColumnDefinitions, (t, v) => AssignListT(t.ColumnDefinitions, v));
      Register<Grid>(NProps.RowDefinitions, (t, v) => AssignListT(t.RowDefinitions, v));
      Register<Grid>(NProps.ShowGridLines, Grid.ShowGridLinesProperty, NConverters.ToBool);
      Register<FrameworkElement>(NProps.GridRow, Grid.RowProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridColumn, Grid.ColumnProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridRowSpan, Grid.RowSpanProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridColumnSpan, Grid.ColumnSpanProperty, NConverters.ToInt32);
    }

    void GenerateVirtualizingStackPanel()
    {
      Register<VirtualizingStackPanel>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<VirtualizingStackPanel>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
      Register<VirtualizingStackPanel>(NProps.Orientation, VirtualizingStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
//      Register<VirtualizingStackPanel>(NProps.ScrollOwner);
      Register<DependencyObject>(NProps.VirtualizingStackPanelVirtualizationMode, VirtualizingStackPanel.VirtualizationModeProperty, NConverters.ToEnum<VirtualizationMode>);
      RegisterEvent<VirtualizingStackPanel>(NProps.CleanUpVirtualizedItemEvent, (s, a) => s.CleanUpVirtualizedItemEvent += a.EventHandler);
    }

    void GenerateImage()
    {
      Register<Image>(NProps.Source, Image.SourceProperty);
      Register<Image>(NProps.Stretch, Image.StretchProperty, NConverters.ToEnum<Stretch>);
      RegisterEvent<Image>(NProps.ImageFailed, (s, a) => s.ImageFailed += a.EventHandler);
      RegisterEvent<Image>(NProps.ImageOpened, (s, a) => s.ImageOpened += a.EventHandler);
    }

    void GenerateTextBlock()
    {
      Register<TextBlock>(NProps.CharacterSpacing, TextBlock.CharacterSpacingProperty, NConverters.ToInt32);
      Register<TextBlock>(NProps.FontFamily, TextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextBlock>(NProps.FontSize, TextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.FontSource, (t, v) => t.FontSource = NConverters.ToFontSourceT(v));
      Register<TextBlock>(NProps.FontStretch, TextBlock.FontStretchProperty, NConverters.ToFontStretch);
      Register<TextBlock>(NProps.FontStyle, TextBlock.FontStyleProperty, NConverters.ToFontStyle);
      Register<TextBlock>(NProps.FontWeight, TextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextBlock>(NProps.Inlines, (t, v) => AssignListT(t.Inlines, v));
      Register<TextBlock>(NProps.LineHeight, TextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.LineStackingStrategy, TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<TextBlock>(NProps.Padding, TextBlock.PaddingProperty, NConverters.ToThickness);
      Register<TextBlock>(NProps.Text, TextBlock.TextProperty, NConverters.ToString);
      Register<TextBlock>(NProps.TextAlignment, TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBlock>(NProps.TextDecorations, TextBlock.TextDecorationsProperty, NConverters.ToTextDecorations);
      Register<TextBlock>(NProps.TextTrimming, TextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<TextBlock>(NProps.TextWrapping, TextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
    }

    void GenerateRichTextBlockOverflow()
    {
      Register<RichTextBlockOverflow>(NProps.OverflowContentTarget, RichTextBlockOverflow.OverflowContentTargetProperty);
      Register<RichTextBlockOverflow>(NProps.Padding, RichTextBlockOverflow.PaddingProperty, NConverters.ToThickness);
    }

    void GenerateRichTextBlock()
    {
      Register<RichTextBlock>(NProps.Blocks, (t, v) => AssignListT(t.Blocks, v));
      Register<RichTextBlock>(NProps.CharacterSpacing, RichTextBlock.CharacterSpacingProperty, NConverters.ToInt32);
      Register<RichTextBlock>(NProps.FontFamily, RichTextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<RichTextBlock>(NProps.FontSize, RichTextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<RichTextBlock>(NProps.FontStretch, RichTextBlock.FontStretchProperty, NConverters.ToFontStretch);
      Register<RichTextBlock>(NProps.FontStyle, RichTextBlock.FontStyleProperty, NConverters.ToFontStyle);
      Register<RichTextBlock>(NProps.FontWeight, RichTextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<RichTextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<RichTextBlock>(NProps.IsTextSelectionEnabled, RichTextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool);
      Register<RichTextBlock>(NProps.LineHeight, RichTextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<RichTextBlock>(NProps.LineStackingStrategy, RichTextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<RichTextBlock>(NProps.OverflowContentTarget, RichTextBlock.OverflowContentTargetProperty);
      Register<RichTextBlock>(NProps.Padding, RichTextBlock.PaddingProperty, NConverters.ToThickness);
      Register<RichTextBlock>(NProps.TextAlignment, RichTextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<RichTextBlock>(NProps.TextTrimming, RichTextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<RichTextBlock>(NProps.TextWrapping, RichTextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      RegisterEvent<RichTextBlock>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
    }

    void GenerateMediaElement()
    {
      Register<MediaElement>(NProps.AudioStreamIndex, MediaElement.AudioStreamIndexProperty, NConverters.ToInt32N);
      Register<MediaElement>(NProps.AutoPlay, MediaElement.AutoPlayProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.Balance, MediaElement.BalanceProperty, NConverters.ToDouble);
      Register<MediaElement>(NProps.BufferingTime, MediaElement.BufferingTimeProperty, NConverters.ToTimeSpan);
      Register<MediaElement>(NProps.IsMuted, MediaElement.IsMutedProperty, NConverters.ToBool);
//      Register<MediaElement>(NProps.LicenseAcquirer);
      Register<MediaElement>(NProps.Markers, (t, v) => AssignListT(t.Markers, v));
      Register<MediaElement>(NProps.PlaybackRate, MediaElement.PlaybackRateProperty, NConverters.ToDouble);
      Register<MediaElement>(NProps.Position, MediaElement.PositionProperty, NConverters.ToTimeSpan);
      Register<MediaElement>(NProps.Source, MediaElement.SourceProperty, NConverters.ToUri);
      Register<MediaElement>(NProps.Stretch, MediaElement.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<MediaElement>(NProps.Volume, MediaElement.VolumeProperty, NConverters.ToDouble);
      RegisterEvent<MediaElement>(NProps.BufferingProgressChanged, (s, a) => s.BufferingProgressChanged += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.CurrentStateChanged, (s, a) => s.CurrentStateChanged += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.DownloadProgressChanged, (s, a) => s.DownloadProgressChanged += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.LogReady, (s, a) => s.LogReady += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MarkerReached, (s, a) => s.MarkerReached += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaEnded, (s, a) => s.MediaEnded += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaFailed, (s, a) => s.MediaFailed += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaOpened, (s, a) => s.MediaOpened += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.RateChanged, (s, a) => s.RateChanged += a.EventHandler);
    }

    void GenerateMultiScaleImage()
    {
      Register<MultiScaleImage>(NProps.AllowDownloading, MultiScaleImage.AllowDownloadingProperty, NConverters.ToBool);
      Register<MultiScaleImage>(NProps.BlurFactor, MultiScaleImage.BlurFactorProperty, NConverters.ToDouble);
      Register<MultiScaleImage>(NProps.SkipLevels, MultiScaleImage.SkipLevelsProperty, NConverters.ToInt32);
      Register<MultiScaleImage>(NProps.Source, MultiScaleImage.SourceProperty);
      Register<MultiScaleImage>(NProps.SubImages, (t, v) => AssignListT(t.SubImages, v));
      Register<MultiScaleImage>(NProps.UseSprings, MultiScaleImage.UseSpringsProperty, NConverters.ToBool);
      Register<MultiScaleImage>(NProps.ViewportOrigin, MultiScaleImage.ViewportOriginProperty, NConverters.ToPoint);
      Register<MultiScaleImage>(NProps.ViewportWidth, MultiScaleImage.ViewportWidthProperty, NConverters.ToDouble);
      RegisterEvent<MultiScaleImage>(NProps.ImageFailed, (s, a) => s.ImageFailed += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.ImageOpenFailed, (s, a) => s.ImageOpenFailed += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.ImageOpenSucceeded, (s, a) => s.ImageOpenSucceeded += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.MotionFinished, (s, a) => s.MotionFinished += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.SubImageOpenFailed, (s, a) => s.SubImageOpenFailed += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.SubImageOpenSucceeded, (s, a) => s.SubImageOpenSucceeded += a.EventHandler);
      RegisterEvent<MultiScaleImage>(NProps.ViewportChanged, (s, a) => s.ViewportChanged += a.EventHandler);
    }

    void GenerateViewbox()
    {
      Register<Viewbox>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
      Register<Viewbox>(NProps.Stretch, Viewbox.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<Viewbox>(NProps.StretchDirection, Viewbox.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
    }

    void GenerateBorder()
    {
      Register<Border>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Border>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Border>(NProps.BorderThickness, Border.BorderThicknessProperty, NConverters.ToThickness);
      Register<Border>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
      Register<Border>(NProps.CornerRadius, Border.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<Border>(NProps.Padding, Border.PaddingProperty, NConverters.ToThickness);
    }

    void GenerateContentPresenter()
    {
      Register<ContentPresenter>(NProps.Content, ContentPresenter.ContentProperty);
      Register<ContentPresenter>(NProps.ContentTemplate, ContentPresenter.ContentTemplateProperty, NConverters.ToDataTemplate);
    }

    void GenerateScrollContentPresenter()
    {
      Register<ScrollContentPresenter>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<ScrollContentPresenter>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
//      Register<ScrollContentPresenter>(NProps.ScrollOwner);
    }

    void GenerateWebBrowser()
    {
      Register<WebBrowser>(NProps.Source, (t, v) => t.Source = NConverters.ToUriT(v));
      RegisterEvent<WebBrowser>(NProps.LoadCompleted, (s, a) => s.LoadCompleted += a.EventHandler);
      RegisterEvent<WebBrowser>(NProps.ScriptNotify, (s, a) => s.ScriptNotify += a.EventHandler);
    }

    void GeneratePopup()
    {
      Register<Popup>(NProps.Child, Popup.ChildProperty);
      Register<Popup>(NProps.HorizontalOffset, Popup.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<Popup>(NProps.IsOpen, Popup.IsOpenProperty, NConverters.ToBool);
      Register<Popup>(NProps.VerticalOffset, Popup.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<Popup>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<Popup>(NProps.Opened, (s, a) => s.Opened += a.EventHandler);
    }

    void GenerateTextElement()
    {
      Register<TextElement>(NProps.CharacterSpacing, TextElement.CharacterSpacingProperty, NConverters.ToInt32);
      Register<TextElement>(NProps.FontFamily, TextElement.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextElement>(NProps.FontSize, TextElement.FontSizeProperty, NConverters.ToDouble);
      Register<TextElement>(NProps.FontStretch, TextElement.FontStretchProperty, NConverters.ToFontStretch);
      Register<TextElement>(NProps.FontStyle, TextElement.FontStyleProperty, NConverters.ToFontStyle);
      Register<TextElement>(NProps.FontWeight, TextElement.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextElement>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextElement>(NProps.Language, TextElement.LanguageProperty, NConverters.ToLanguage);
    }

    void GenerateInline()
    {
      Register<Inline>(NProps.TextDecorations, Inline.TextDecorationsProperty, NConverters.ToTextDecorations);
    }

    void GenerateRun()
    {
      Register<Run>(NProps.FlowDirection, Run.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<Run>(NProps.Text, (t, v) => t.Text = NConverters.ToStringT(v));
    }

    void GenerateSpan()
    {
      Register<Span>(NProps.Inlines, (t, v) => AssignListT(t.Inlines, v));
    }

    void GenerateHyperlink()
    {
      Register<Hyperlink>(NProps.Command, Hyperlink.CommandProperty);
      Register<Hyperlink>(NProps.CommandParameter, Hyperlink.CommandParameterProperty);
      Register<Hyperlink>(NProps.MouseOverForeground, (t, v) => t.MouseOverForeground = NConverters.ToBrushT(v, t.MouseOverForeground));
      Register<Hyperlink>(NProps.MouseOverTextDecorations, Hyperlink.MouseOverTextDecorationsProperty, NConverters.ToTextDecorations);
      Register<Hyperlink>(NProps.NavigateUri, Hyperlink.NavigateUriProperty, NConverters.ToUri);
      Register<Hyperlink>(NProps.TargetName, Hyperlink.TargetNameProperty, NConverters.ToString);
      RegisterEvent<Hyperlink>(NProps.Click, (s, a) => s.Click += a.EventHandler);
    }

    void GenerateInlineUIContainer()
    {
      Register<InlineUIContainer>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateBlock()
    {
      Register<Block>(NProps.LineHeight, Block.LineHeightProperty, NConverters.ToDouble);
      Register<Block>(NProps.LineStackingStrategy, Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<Block>(NProps.TextAlignment, Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateParagraph()
    {
      Register<Paragraph>(NProps.Inlines, (t, v) => AssignListT(t.Inlines, v));
    }

    void GenerateSection()
    {
      Register<Section>(NProps.Blocks, (t, v) => AssignListT(t.Blocks, v));
      Register<Section>(NProps.HasTrailingParagraphBreakOnPaste, (t, v) => t.HasTrailingParagraphBreakOnPaste = NConverters.ToBoolT(v));
    }

    void GenerateColumnDefinition()
    {
      Register<ColumnDefinition>(NProps.MaxWidth, ColumnDefinition.MaxWidthProperty, NConverters.ToDouble);
      Register<ColumnDefinition>(NProps.MinWidth, ColumnDefinition.MinWidthProperty, NConverters.ToDouble);
      Register<ColumnDefinition>(NProps.Width, ColumnDefinition.WidthProperty, NConverters.ToGridLength);
    }

    void GenerateRowDefinition()
    {
      Register<RowDefinition>(NProps.Height, RowDefinition.HeightProperty, NConverters.ToGridLength);
      Register<RowDefinition>(NProps.MaxHeight, RowDefinition.MaxHeightProperty, NConverters.ToDouble);
      Register<RowDefinition>(NProps.MinHeight, RowDefinition.MinHeightProperty, NConverters.ToDouble);
    }

    void GenerateToolTipService()
    {
      Register<DependencyObject>(NProps.ToolTipServiceToolTip, ToolTipService.ToolTipProperty);
      Register<DependencyObject>(NProps.ToolTipServicePlacementTarget, ToolTipService.PlacementTargetProperty);
      Register<DependencyObject>(NProps.ToolTipServicePlacement, ToolTipService.PlacementProperty, NConverters.ToEnum<PlacementMode>);
    }

    void GenerateTextOptions()
    {
      Register<FrameworkElement>(NProps.TextOptionsTextHintingMode, TextOptions.TextHintingModeProperty, NConverters.ToEnum<TextHintingMode>);
      Register<FrameworkElement>(NProps.TextOptionsTextFormattingMode, TextOptions.TextFormattingModeProperty, NConverters.ToEnum<TextFormattingMode>);
      Register<FrameworkElement>(NProps.TextOptionsTextRenderingMode, TextOptions.TextRenderingModeProperty, NConverters.ToEnum<TextRenderingMode>);
    }
  }

  public partial class NProps
  {
    public static readonly int _DoubleTap = Store["_DoubleTap"];
    public static readonly int _Hold = Store["_Hold"];
    public static readonly int _KeyDown = Store["_KeyDown"];
    public static readonly int _KeyUp = Store["_KeyUp"];
    public static readonly int _Loaded = Store["_Loaded"];
    public static readonly int _ManipulationCompleted = Store["_ManipulationCompleted"];
    public static readonly int _ManipulationDelta = Store["_ManipulationDelta"];
    public static readonly int _ManipulationStarted = Store["_ManipulationStarted"];
    public static readonly int _MouseLeftButtonDown = Store["_MouseLeftButtonDown"];
    public static readonly int _MouseLeftButtonUp = Store["_MouseLeftButtonUp"];
    public static readonly int _MouseRightButtonDown = Store["_MouseRightButtonDown"];
    public static readonly int _MouseRightButtonUp = Store["_MouseRightButtonUp"];
    public static readonly int _MouseWheel = Store["_MouseWheel"];
    public static readonly int _Tap = Store["_Tap"];
    public static readonly int _TextInput = Store["_TextInput"];
    public static readonly int _TextInputStart = Store["_TextInputStart"];
    public static readonly int _TextInputUpdate = Store["_TextInputUpdate"];
    public static readonly int AcceptsReturn = Store["AcceptsReturn"];
    public static readonly int AllowDownloading = Store["AllowDownloading"];
    public static readonly int AllowDrop = Store["AllowDrop"];
    public static readonly int AudioStreamIndex = Store["AudioStreamIndex"];
    public static readonly int AutoPlay = Store["AutoPlay"];
    public static readonly int Background = Store["Background"];
    public static readonly int Balance = Store["Balance"];
    public static readonly int BindingValidationError = Store["BindingValidationError"];
    public static readonly int BlurFactor = Store["BlurFactor"];
    public static readonly int BorderBrush = Store["BorderBrush"];
    public static readonly int BorderThickness = Store["BorderThickness"];
    public static readonly int BufferingProgressChanged = Store["BufferingProgressChanged"];
    public static readonly int BufferingTime = Store["BufferingTime"];
    public static readonly int CacheMode = Store["CacheMode"];
    public static readonly int CanHorizontallyScroll = Store["CanHorizontallyScroll"];
    public static readonly int CanvasLeft = Store["CanvasLeft"];
    public static readonly int CanvasTop = Store["CanvasTop"];
    public static readonly int CanvasZIndex = Store["CanvasZIndex"];
    public static readonly int CanVerticallyScroll = Store["CanVerticallyScroll"];
    public static readonly int CaretBrush = Store["CaretBrush"];
    public static readonly int CharacterSpacing = Store["CharacterSpacing"];
    public static readonly int Checked = Store["Checked"];
    public static readonly int Child = Store["Child"];
    public static readonly int CleanUpVirtualizedItemEvent = Store["CleanUpVirtualizedItemEvent"];
    public static readonly int Click = Store["Click"];
    public static readonly int ClickMode = Store["ClickMode"];
    public static readonly int Clip = Store["Clip"];
    public static readonly int Closed = Store["Closed"];
    public static readonly int Command = Store["Command"];
    public static readonly int CommandParameter = Store["CommandParameter"];
    public static readonly int Content = Store["Content"];
    public static readonly int ContentChanged = Store["ContentChanged"];
    public static readonly int ContentTemplate = Store["ContentTemplate"];
    public static readonly int CornerRadius = Store["CornerRadius"];
    public static readonly int CurrentStateChanged = Store["CurrentStateChanged"];
    public static readonly int Cursor = Store["Cursor"];
    public static readonly int Data = Store["Data"];
    public static readonly int DataContext = Store["DataContext"];
    public static readonly int DataContextChanged = Store["DataContextChanged"];
    public static readonly int Delay = Store["Delay"];
    public static readonly int DisplayMemberPath = Store["DisplayMemberPath"];
    public static readonly int DoubleTap = Store["DoubleTap"];
    public static readonly int DownloadProgressChanged = Store["DownloadProgressChanged"];
    public static readonly int DragCompleted = Store["DragCompleted"];
    public static readonly int DragDelta = Store["DragDelta"];
    public static readonly int DragEnter = Store["DragEnter"];
    public static readonly int DragLeave = Store["DragLeave"];
    public static readonly int DragOver = Store["DragOver"];
    public static readonly int DragStarted = Store["DragStarted"];
    public static readonly int Drop = Store["Drop"];
    public static readonly int DropDownClosed = Store["DropDownClosed"];
    public static readonly int DropDownOpened = Store["DropDownOpened"];
    public static readonly int Effect = Store["Effect"];
    public static readonly int Fill = Store["Fill"];
    public static readonly int FillRule = Store["FillRule"];
    public static readonly int FlowDirection = Store["FlowDirection"];
    public static readonly int FontFamily = Store["FontFamily"];
    public static readonly int FontRenderingEmSize = Store["FontRenderingEmSize"];
    public static readonly int FontSize = Store["FontSize"];
    public static readonly int FontSource = Store["FontSource"];
    public static readonly int FontStretch = Store["FontStretch"];
    public static readonly int FontStyle = Store["FontStyle"];
    public static readonly int FontUri = Store["FontUri"];
    public static readonly int FontWeight = Store["FontWeight"];
    public static readonly int Foreground = Store["Foreground"];
    public static readonly int GotFocus = Store["GotFocus"];
    public static readonly int GridColumn = Store["GridColumn"];
    public static readonly int GridColumnSpan = Store["GridColumnSpan"];
    public static readonly int GridRow = Store["GridRow"];
    public static readonly int GridRowSpan = Store["GridRowSpan"];
    public static readonly int GroupName = Store["GroupName"];
    public static readonly int HasTrailingParagraphBreakOnPaste = Store["HasTrailingParagraphBreakOnPaste"];
    public static readonly int Height = Store["Height"];
    public static readonly int Hold = Store["Hold"];
    public static readonly int HorizontalAlignment = Store["HorizontalAlignment"];
    public static readonly int HorizontalContentAlignment = Store["HorizontalContentAlignment"];
    public static readonly int HorizontalOffset = Store["HorizontalOffset"];
    public static readonly int HorizontalScrollBarVisibility = Store["HorizontalScrollBarVisibility"];
    public static readonly int ImageFailed = Store["ImageFailed"];
    public static readonly int ImageOpened = Store["ImageOpened"];
    public static readonly int ImageOpenFailed = Store["ImageOpenFailed"];
    public static readonly int ImageOpenSucceeded = Store["ImageOpenSucceeded"];
    public static readonly int Indeterminate = Store["Indeterminate"];
    public static readonly int Indices = Store["Indices"];
    public static readonly int InputScope = Store["InputScope"];
    public static readonly int Interval = Store["Interval"];
    public static readonly int IsChecked = Store["IsChecked"];
    public static readonly int IsDirectionReversed = Store["IsDirectionReversed"];
    public static readonly int IsDropDownOpen = Store["IsDropDownOpen"];
    public static readonly int IsEnabled = Store["IsEnabled"];
    public static readonly int IsEnabledChanged = Store["IsEnabledChanged"];
    public static readonly int IsHitTestVisible = Store["IsHitTestVisible"];
    public static readonly int IsIndeterminate = Store["IsIndeterminate"];
    public static readonly int IsMuted = Store["IsMuted"];
    public static readonly int IsOpen = Store["IsOpen"];
    public static readonly int IsReadOnly = Store["IsReadOnly"];
    public static readonly int IsSelected = Store["IsSelected"];
    public static readonly int IsSynchronizedWithCurrentItem = Store["IsSynchronizedWithCurrentItem"];
    public static readonly int IsTabStop = Store["IsTabStop"];
    public static readonly int IsTextSelectionEnabled = Store["IsTextSelectionEnabled"];
    public static readonly int IsThreeState = Store["IsThreeState"];
    public static readonly int ItemContainerStyle = Store["ItemContainerStyle"];
    public static readonly int ItemsPanel = Store["ItemsPanel"];
    public static readonly int ItemsSource = Store["ItemsSource"];
    public static readonly int ItemTemplate = Store["ItemTemplate"];
    public static readonly int KeyDown = Store["KeyDown"];
    public static readonly int KeyUp = Store["KeyUp"];
    public static readonly int Language = Store["Language"];
    public static readonly int LargeChange = Store["LargeChange"];
    public static readonly int LayoutUpdated = Store["LayoutUpdated"];
    public static readonly int LicenseAcquirer = Store["LicenseAcquirer"];
    public static readonly int LineHeight = Store["LineHeight"];
    public static readonly int LineStackingStrategy = Store["LineStackingStrategy"];
    public static readonly int LoadCompleted = Store["LoadCompleted"];
    public static readonly int Loaded = Store["Loaded"];
    public static readonly int LogReady = Store["LogReady"];
    public static readonly int LostFocus = Store["LostFocus"];
    public static readonly int LostMouseCapture = Store["LostMouseCapture"];
    public static readonly int ManipulationCompleted = Store["ManipulationCompleted"];
    public static readonly int ManipulationDelta = Store["ManipulationDelta"];
    public static readonly int ManipulationMode = Store["ManipulationMode"];
    public static readonly int ManipulationStarted = Store["ManipulationStarted"];
    public static readonly int Margin = Store["Margin"];
    public static readonly int MarkerReached = Store["MarkerReached"];
    public static readonly int Markers = Store["Markers"];
    public static readonly int MaxDropDownHeight = Store["MaxDropDownHeight"];
    public static readonly int MaxHeight = Store["MaxHeight"];
    public static readonly int Maximum = Store["Maximum"];
    public static readonly int MaxLength = Store["MaxLength"];
    public static readonly int MaxWidth = Store["MaxWidth"];
    public static readonly int MediaCommand = Store["MediaCommand"];
    public static readonly int MediaEnded = Store["MediaEnded"];
    public static readonly int MediaFailed = Store["MediaFailed"];
    public static readonly int MediaOpened = Store["MediaOpened"];
    public static readonly int MinHeight = Store["MinHeight"];
    public static readonly int Minimum = Store["Minimum"];
    public static readonly int MinWidth = Store["MinWidth"];
    public static readonly int MotionFinished = Store["MotionFinished"];
    public static readonly int MouseEnter = Store["MouseEnter"];
    public static readonly int MouseLeave = Store["MouseLeave"];
    public static readonly int MouseLeftButtonDown = Store["MouseLeftButtonDown"];
    public static readonly int MouseLeftButtonUp = Store["MouseLeftButtonUp"];
    public static readonly int MouseMove = Store["MouseMove"];
    public static readonly int MouseOverForeground = Store["MouseOverForeground"];
    public static readonly int MouseOverTextDecorations = Store["MouseOverTextDecorations"];
    public static readonly int MouseRightButtonDown = Store["MouseRightButtonDown"];
    public static readonly int MouseRightButtonUp = Store["MouseRightButtonUp"];
    public static readonly int MouseWheel = Store["MouseWheel"];
    public static readonly int Name = Store["Name"];
    public static readonly int NavigateUri = Store["NavigateUri"];
    public static readonly int Opacity = Store["Opacity"];
    public static readonly int OpacityMask = Store["OpacityMask"];
    public static readonly int Opened = Store["Opened"];
    public static readonly int Orientation = Store["Orientation"];
    public static readonly int OriginX = Store["OriginX"];
    public static readonly int OriginY = Store["OriginY"];
    public static readonly int OverflowContentTarget = Store["OverflowContentTarget"];
    public static readonly int Padding = Store["Padding"];
    public static readonly int Password = Store["Password"];
    public static readonly int PasswordChanged = Store["PasswordChanged"];
    public static readonly int PasswordChar = Store["PasswordChar"];
    public static readonly int Placement = Store["Placement"];
    public static readonly int PlacementTarget = Store["PlacementTarget"];
    public static readonly int PlaybackRate = Store["PlaybackRate"];
    public static readonly int Points = Store["Points"];
    public static readonly int Position = Store["Position"];
    public static readonly int Projection = Store["Projection"];
    public static readonly int RadiusX = Store["RadiusX"];
    public static readonly int RadiusY = Store["RadiusY"];
    public static readonly int RateChanged = Store["RateChanged"];
    public static readonly int RenderTransform = Store["RenderTransform"];
    public static readonly int RenderTransformOrigin = Store["RenderTransformOrigin"];
    public static readonly int Resources = Store["Resources"];
    public static readonly int ScriptNotify = Store["ScriptNotify"];
    public static readonly int Scroll = Store["Scroll"];
    public static readonly int ScrollOwner = Store["ScrollOwner"];
    public static readonly int ScrollViewerHorizontalScrollBarVisibility = Store["ScrollViewerHorizontalScrollBarVisibility"];
    public static readonly int ScrollViewerManipulationMode = Store["ScrollViewerManipulationMode"];
    public static readonly int ScrollViewerVerticalScrollBarVisibility = Store["ScrollViewerVerticalScrollBarVisibility"];
    public static readonly int SelectedIndex = Store["SelectedIndex"];
    public static readonly int SelectedItem = Store["SelectedItem"];
    public static readonly int SelectedItems = Store["SelectedItems"];
    public static readonly int SelectedText = Store["SelectedText"];
    public static readonly int SelectedValue = Store["SelectedValue"];
    public static readonly int SelectedValuePath = Store["SelectedValuePath"];
    public static readonly int SelectionBackground = Store["SelectionBackground"];
    public static readonly int SelectionChanged = Store["SelectionChanged"];
    public static readonly int SelectionForeground = Store["SelectionForeground"];
    public static readonly int SelectionLength = Store["SelectionLength"];
    public static readonly int SelectionMode = Store["SelectionMode"];
    public static readonly int SelectionStart = Store["SelectionStart"];
    public static readonly int ShowGridLines = Store["ShowGridLines"];
    public static readonly int SizeChanged = Store["SizeChanged"];
    public static readonly int SkipLevels = Store["SkipLevels"];
    public static readonly int SmallChange = Store["SmallChange"];
    public static readonly int Source = Store["Source"];
    public static readonly int Stretch = Store["Stretch"];
    public static readonly int StretchDirection = Store["StretchDirection"];
    public static readonly int Stroke = Store["Stroke"];
    public static readonly int StrokeDashArray = Store["StrokeDashArray"];
    public static readonly int StrokeDashCap = Store["StrokeDashCap"];
    public static readonly int StrokeDashOffset = Store["StrokeDashOffset"];
    public static readonly int StrokeEndLineCap = Store["StrokeEndLineCap"];
    public static readonly int StrokeLineJoin = Store["StrokeLineJoin"];
    public static readonly int StrokeMiterLimit = Store["StrokeMiterLimit"];
    public static readonly int Strokes = Store["Strokes"];
    public static readonly int StrokeStartLineCap = Store["StrokeStartLineCap"];
    public static readonly int StrokeThickness = Store["StrokeThickness"];
    public static readonly int Style = Store["Style"];
    public static readonly int StyleSimulations = Store["StyleSimulations"];
    public static readonly int SubImageOpenFailed = Store["SubImageOpenFailed"];
    public static readonly int SubImageOpenSucceeded = Store["SubImageOpenSucceeded"];
    public static readonly int SubImages = Store["SubImages"];
    public static readonly int TabIndex = Store["TabIndex"];
    public static readonly int TabNavigation = Store["TabNavigation"];
    public static readonly int Tag = Store["Tag"];
    public static readonly int Tap = Store["Tap"];
    public static readonly int TargetName = Store["TargetName"];
    public static readonly int Template = Store["Template"];
    public static readonly int Text = Store["Text"];
    public static readonly int TextAlignment = Store["TextAlignment"];
    public static readonly int TextChanged = Store["TextChanged"];
    public static readonly int TextDecorations = Store["TextDecorations"];
    public static readonly int TextInput = Store["TextInput"];
    public static readonly int TextInputStart = Store["TextInputStart"];
    public static readonly int TextInputUpdate = Store["TextInputUpdate"];
    public static readonly int TextOptionsTextFormattingMode = Store["TextOptionsTextFormattingMode"];
    public static readonly int TextOptionsTextHintingMode = Store["TextOptionsTextHintingMode"];
    public static readonly int TextOptionsTextRenderingMode = Store["TextOptionsTextRenderingMode"];
    public static readonly int TextTrimming = Store["TextTrimming"];
    public static readonly int TextWrapping = Store["TextWrapping"];
    public static readonly int ToolTipServicePlacement = Store["ToolTipServicePlacement"];
    public static readonly int ToolTipServicePlacementTarget = Store["ToolTipServicePlacementTarget"];
    public static readonly int ToolTipServiceToolTip = Store["ToolTipServiceToolTip"];
    public static readonly int Triggers = Store["Triggers"];
    public static readonly int Unchecked = Store["Unchecked"];
    public static readonly int UnicodeString = Store["UnicodeString"];
    public static readonly int Unloaded = Store["Unloaded"];
    public static readonly int UseLayoutRounding = Store["UseLayoutRounding"];
    public static readonly int UseSprings = Store["UseSprings"];
    public static readonly int Value = Store["Value"];
    public static readonly int ValueChanged = Store["ValueChanged"];
    public static readonly int VerticalAlignment = Store["VerticalAlignment"];
    public static readonly int VerticalContentAlignment = Store["VerticalContentAlignment"];
    public static readonly int VerticalOffset = Store["VerticalOffset"];
    public static readonly int VerticalScrollBarVisibility = Store["VerticalScrollBarVisibility"];
    public static readonly int ViewportChanged = Store["ViewportChanged"];
    public static readonly int ViewportOrigin = Store["ViewportOrigin"];
    public static readonly int ViewportSize = Store["ViewportSize"];
    public static readonly int ViewportWidth = Store["ViewportWidth"];
    public static readonly int VirtualizingStackPanelVirtualizationMode = Store["VirtualizingStackPanelVirtualizationMode"];
    public static readonly int Visibility = Store["Visibility"];
    public static readonly int Volume = Store["Volume"];
    public static readonly int Watermark = Store["Watermark"];
    public static readonly int Width = Store["Width"];
    public static readonly int X1 = Store["X1"];
    public static readonly int X2 = Store["X2"];
    public static readonly int Xaml = Store["Xaml"];
    public static readonly int Y1 = Store["Y1"];
    public static readonly int Y2 = Store["Y2"];
  }
}
