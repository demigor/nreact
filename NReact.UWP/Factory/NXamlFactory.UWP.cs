using System;
using WGDayOfWeek = Windows.Globalization.DayOfWeek;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

namespace NReact
{
  public partial class NXamlFactory: NFactory
  {
    public NXamlFactory()
    {
      GenerateUIElement();
      GenerateFrameworkElement();
      GeneratePopup();
      GeneratePanel();
      GenerateCanvas();
      GenerateLoopingSelectorPanel();
      GenerateGrid();
      GenerateRelativePanel();
      GenerateStackPanel();
      GenerateVariableSizedWrapGrid();
      GenerateCarouselPanel();
      GenerateOrientedVirtualizingPanel();
      GenerateVirtualizingStackPanel();
      GenerateWrapGrid();
      GenerateItemsStackPanel();
      GenerateItemsWrapGrid();
      GeneratePivotPanel();
      GenerateBorder();
      GenerateCaptureElement();
      GenerateContentPresenter();
      GenerateScrollContentPresenter();
      GenerateGridViewItemPresenter();
      GenerateListViewItemPresenter();
      GenerateImage();
      GenerateItemsPresenter();
      GenerateRichTextBlockOverflow();
      GenerateRichTextBlock();
      GenerateTextBlock();
      GenerateViewbox();
      GenerateTickBar();
      GenerateGlyphs();
      GenerateIconElement();
      GenerateBitmapIcon();
      GenerateFontIcon();
      GeneratePathIcon();
      GenerateSymbolIcon();
      GenerateMediaElement();
      GenerateWebView();
      GenerateShape();
      GenerateLine();
      GeneratePath();
      GeneratePolygon();
      GeneratePolyline();
      GenerateRectangle();
      GenerateControl();
      GenerateSemanticZoom();
      GenerateContentControl();
      GenerateSelectorItem();
      GenerateSettingsFlyout();
      GenerateToolTip();
      GenerateButtonBase();
      GenerateButton();
      GenerateAppBarButton();
      GenerateHyperlinkButton();
      GenerateRepeatButton();
      GenerateToggleButton();
      GenerateRadioButton();
      GenerateAppBarToggleButton();
      GenerateAppBar();
      GenerateCommandBar();
      GenerateContentDialog();
      GenerateFrame();
      GenerateScrollViewer();
      GeneratePivotItem();
      GenerateItemsControl();
      GenerateSelector();
      GenerateListViewBase();
      GenerateComboBox();
      GenerateFlipView();
      GenerateListBox();
      GenerateAutoSuggestBox();
      GeneratePivot();
      GenerateMediaTransportControls();
      GeneratePasswordBox();
      GenerateProgressRing();
      GenerateRichEditBox();
      GenerateTextBox();
      GenerateToggleSwitch();
      GenerateUserControl();
      GeneratePage();
      GenerateRangeBase();
      GenerateProgressBar();
      GenerateSlider();
      GenerateScrollBar();
      GenerateThumb();
      GenerateCalendarView();
      GenerateCalendarViewDayItem();
      GenerateHubSection();
      GenerateMenuFlyoutItem();
      GenerateToggleMenuFlyoutItem();
      GenerateMenuFlyoutSubItem();
      GenerateAppBarSeparator();
      GenerateCalendarDatePicker();
      GenerateDatePicker();
      GenerateHub();
      GenerateSearchBox();
      GenerateSplitView();
      GenerateTimePicker();
      GenerateMapControl();
      GenerateLoopingSelector();
      GenerateTextElement();
      GenerateBlock();
      GenerateParagraph();
      GenerateInlineUIContainer();
      GenerateRun();
      GenerateSpan();
      GenerateHyperlink();
      GenerateColumnDefinition();
      GenerateRowDefinition();
      GenerateToolTipService();
    }

    public override int GetContentKey(Type type)
    {
      if (typeof(NClass).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(Span).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(Run).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(InlineUIContainer).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Paragraph).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(MapControl).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(TimePicker).IsAssignableFrom(type)) return NProps.Header;
      if (typeof(SplitView).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(Hub).IsAssignableFrom(type)) return NProps.Sections;
      if (typeof(DatePicker).IsAssignableFrom(type)) return NProps.Header;
      if (typeof(MenuFlyoutSubItem).IsAssignableFrom(type)) return NProps.Items;
      if (typeof(MenuFlyoutItem).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(HubSection).IsAssignableFrom(type)) return NProps.ContentTemplate;
      if (typeof(UserControl).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(ToggleSwitch).IsAssignableFrom(type)) return NProps.Header;
      if (typeof(ItemsControl).IsAssignableFrom(type)) return NProps.Items;
      if (typeof(CommandBar).IsAssignableFrom(type)) return NProps.PrimaryCommands;
      if (typeof(ContentControl).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(SemanticZoom).IsAssignableFrom(type)) return NProps.ZoomedInView;
      if (typeof(Viewbox).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(TextBlock).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(RichTextBlock).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(ContentPresenter).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(Border).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Panel).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(Popup).IsAssignableFrom(type)) return NProps.Child;

      return NProps.CONTENT;
    }

    void GenerateUIElement()
    {
      Register<UIElement>(NProps.AllowDrop, UIElement.AllowDropProperty, NConverters.ToBool);
      Register<UIElement>(NProps.CacheMode, UIElement.CacheModeProperty);
      Register<UIElement>(NProps.CanDrag, UIElement.CanDragProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Clip, UIElement.ClipProperty);
      Register<UIElement>(NProps.CompositeMode, UIElement.CompositeModeProperty, NConverters.ToEnum<ElementCompositeMode>);
      Register<UIElement>(NProps.IsDoubleTapEnabled, UIElement.IsDoubleTapEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsHitTestVisible, UIElement.IsHitTestVisibleProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsHoldingEnabled, UIElement.IsHoldingEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsRightTapEnabled, UIElement.IsRightTapEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsTapEnabled, UIElement.IsTapEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.ManipulationMode, UIElement.ManipulationModeProperty, NConverters.ToEnum<ManipulationModes>);
      Register<UIElement>(NProps.Opacity, UIElement.OpacityProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.Projection, UIElement.ProjectionProperty);
      Register<UIElement>(NProps.RenderTransform, UIElement.RenderTransformProperty);
      Register<UIElement>(NProps.RenderTransformOrigin, UIElement.RenderTransformOriginProperty, NConverters.ToPoint);
      Register<UIElement>(NProps.Transform3D, UIElement.Transform3DProperty);
      Register<UIElement>(NProps.Transitions, (t, v) => AssignListT(t.Transitions, v));
      Register<UIElement>(NProps.UseLayoutRounding, UIElement.UseLayoutRoundingProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Visibility, UIElement.VisibilityProperty, NConverters.ToEnum<Visibility>);
      RegisterEvent<UIElement>(NProps._DoubleTapped, UIElement.DoubleTappedEvent, a => (DoubleTappedEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._DragEnter, UIElement.DragEnterEvent, a => (DragEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._DragLeave, UIElement.DragLeaveEvent, a => (DragEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._DragOver, UIElement.DragOverEvent, a => (DragEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._Drop, UIElement.DropEvent, a => (DragEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._Holding, UIElement.HoldingEvent, a => (HoldingEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._KeyDown, UIElement.KeyDownEvent, a => (KeyEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._KeyUp, UIElement.KeyUpEvent, a => (KeyEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._ManipulationCompleted, UIElement.ManipulationCompletedEvent, a => (ManipulationCompletedEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._ManipulationDelta, UIElement.ManipulationDeltaEvent, a => (ManipulationDeltaEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._ManipulationInertiaStarting, UIElement.ManipulationInertiaStartingEvent, a => (ManipulationInertiaStartingEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._ManipulationStarted, UIElement.ManipulationStartedEvent, a => (ManipulationStartedEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._ManipulationStarting, UIElement.ManipulationStartingEvent, a => (ManipulationStartingEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerCanceled, UIElement.PointerCanceledEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerCaptureLost, UIElement.PointerCaptureLostEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerEntered, UIElement.PointerEnteredEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerExited, UIElement.PointerExitedEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerMoved, UIElement.PointerMovedEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerPressed, UIElement.PointerPressedEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerReleased, UIElement.PointerReleasedEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._PointerWheelChanged, UIElement.PointerWheelChangedEvent, a => (PointerEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._RightTapped, UIElement.RightTappedEvent, a => (RightTappedEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps._Tapped, UIElement.TappedEvent, a => (TappedEventHandler)a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.DoubleTapped, (s, a) => s.DoubleTapped += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.DragEnter, (s, a) => s.DragEnter += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.DragLeave, (s, a) => s.DragLeave += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.DragOver, (s, a) => s.DragOver += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.Drop, (s, a) => s.Drop += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.GotFocus, (s, a) => s.GotFocus += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.Holding, (s, a) => s.Holding += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.KeyDown, (s, a) => s.KeyDown += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.KeyUp, (s, a) => s.KeyUp += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.LostFocus, (s, a) => s.LostFocus += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.ManipulationCompleted, (s, a) => s.ManipulationCompleted += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.ManipulationDelta, (s, a) => s.ManipulationDelta += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.ManipulationInertiaStarting, (s, a) => s.ManipulationInertiaStarting += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.ManipulationStarted, (s, a) => s.ManipulationStarted += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.ManipulationStarting, (s, a) => s.ManipulationStarting += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerCanceled, (s, a) => s.PointerCanceled += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerCaptureLost, (s, a) => s.PointerCaptureLost += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerEntered, (s, a) => s.PointerEntered += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerExited, (s, a) => s.PointerExited += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerMoved, (s, a) => s.PointerMoved += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerPressed, (s, a) => s.PointerPressed += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerReleased, (s, a) => s.PointerReleased += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.PointerWheelChanged, (s, a) => s.PointerWheelChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.RightTapped, (s, a) => s.RightTapped += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.Tapped, (s, a) => s.Tapped += a.EventHandlerAny);
    }

    void GenerateFrameworkElement()
    {
      Register<FrameworkElement>(NProps.DataContext, FrameworkElement.DataContextProperty);
      Register<FrameworkElement>(NProps.FlowDirection, FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<FrameworkElement>(NProps.Height, FrameworkElement.HeightProperty, NConverters.ToLength);
      Register<FrameworkElement>(NProps.HorizontalAlignment, FrameworkElement.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<FrameworkElement>(NProps.Language, FrameworkElement.LanguageProperty, NConverters.ToString);
      Register<FrameworkElement>(NProps.Margin, FrameworkElement.MarginProperty, NConverters.ToThickness);
      Register<FrameworkElement>(NProps.MaxHeight, FrameworkElement.MaxHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MaxWidth, FrameworkElement.MaxWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinHeight, FrameworkElement.MinHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinWidth, FrameworkElement.MinWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.Name, FrameworkElement.NameProperty, NConverters.ToString);
      Register<FrameworkElement>(NProps.RequestedTheme, FrameworkElement.RequestedThemeProperty, NConverters.ToEnum<ElementTheme>);
      Register<FrameworkElement>(NProps.Resources, (t, v) => t.Resources = NConverters.ToResourceDictionaryT(v));
      Register<FrameworkElement>(NProps.Style, FrameworkElement.StyleProperty, NConverters.ToStyle);
      Register<FrameworkElement>(NProps.Tag, FrameworkElement.TagProperty);
      Register<FrameworkElement>(NProps.Triggers, (t, v) => AssignListT(t.Triggers, v));
      Register<FrameworkElement>(NProps.VerticalAlignment, FrameworkElement.VerticalAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<FrameworkElement>(NProps.Width, FrameworkElement.WidthProperty, NConverters.ToLength);
      RegisterEvent<FrameworkElement>(NProps.LayoutUpdated, (s, a) => s.LayoutUpdated += a.EventHandlerAny);
      RegisterEvent<FrameworkElement>(NProps.Loaded, (s, a) => s.Loaded += a.EventHandlerAny);
      RegisterEvent<FrameworkElement>(NProps.SizeChanged, (s, a) => s.SizeChanged += a.EventHandlerAny);
      RegisterEvent<FrameworkElement>(NProps.Unloaded, (s, a) => s.Unloaded += a.EventHandlerAny);
    }

    void GeneratePopup()
    {
      Register<Popup>(NProps.Child, Popup.ChildProperty);
      Register<Popup>(NProps.ChildTransitions, (t, v) => AssignListT(t.ChildTransitions, v));
      Register<Popup>(NProps.HorizontalOffset, Popup.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<Popup>(NProps.IsLightDismissEnabled, Popup.IsLightDismissEnabledProperty, NConverters.ToBool);
      Register<Popup>(NProps.IsOpen, Popup.IsOpenProperty, NConverters.ToBool);
      Register<Popup>(NProps.VerticalOffset, Popup.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<Popup>(NProps.Closed, (s, a) => s.Closed += a.EventHandlerAny);
      RegisterEvent<Popup>(NProps.Opened, (s, a) => s.Opened += a.EventHandlerAny);
    }

    void GeneratePanel()
    {
      Register<Panel>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Panel>(NProps.Children, (t, v) => AssignListT(t.Children, v));
      Register<Panel>(NProps.ChildrenTransitions, (t, v) => AssignListT(t.ChildrenTransitions, v));
    }

    void GenerateCanvas()
    {
      Register<UIElement>(NProps.CanvasLeft, Canvas.LeftProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasTop, Canvas.TopProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasZIndex, Canvas.ZIndexProperty, NConverters.ToInt32);
    }

    void GenerateLoopingSelectorPanel()
    {
      RegisterEvent<LoopingSelectorPanel>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<LoopingSelectorPanel>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateGrid()
    {
      Register<Grid>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Grid>(NProps.BorderThickness, Grid.BorderThicknessProperty, NConverters.ToThickness);
      Register<Grid>(NProps.ColumnDefinitions, (t, v) => AssignListT(t.ColumnDefinitions, v));
      Register<Grid>(NProps.CornerRadius, Grid.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<Grid>(NProps.Padding, Grid.PaddingProperty, NConverters.ToThickness);
      Register<Grid>(NProps.RowDefinitions, (t, v) => AssignListT(t.RowDefinitions, v));
      Register<FrameworkElement>(NProps.GridColumn, Grid.ColumnProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridColumnSpan, Grid.ColumnSpanProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridRow, Grid.RowProperty, NConverters.ToInt32);
      Register<FrameworkElement>(NProps.GridRowSpan, Grid.RowSpanProperty, NConverters.ToInt32);
    }

    void GenerateRelativePanel()
    {
      Register<RelativePanel>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<RelativePanel>(NProps.BorderThickness, RelativePanel.BorderThicknessProperty, NConverters.ToThickness);
      Register<RelativePanel>(NProps.CornerRadius, RelativePanel.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<RelativePanel>(NProps.Padding, RelativePanel.PaddingProperty, NConverters.ToThickness);
      Register<UIElement>(NProps.RelativePanelAbove, RelativePanel.AboveProperty);
      Register<UIElement>(NProps.RelativePanelAlignBottomWithPanel, RelativePanel.AlignBottomWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignBottomWith, RelativePanel.AlignBottomWithProperty);
      Register<UIElement>(NProps.RelativePanelAlignHorizontalCenterWithPanel, RelativePanel.AlignHorizontalCenterWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignHorizontalCenterWith, RelativePanel.AlignHorizontalCenterWithProperty);
      Register<UIElement>(NProps.RelativePanelAlignLeftWithPanel, RelativePanel.AlignLeftWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignLeftWith, RelativePanel.AlignLeftWithProperty);
      Register<UIElement>(NProps.RelativePanelAlignRightWithPanel, RelativePanel.AlignRightWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignRightWith, RelativePanel.AlignRightWithProperty);
      Register<UIElement>(NProps.RelativePanelAlignTopWithPanel, RelativePanel.AlignTopWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignTopWith, RelativePanel.AlignTopWithProperty);
      Register<UIElement>(NProps.RelativePanelAlignVerticalCenterWithPanel, RelativePanel.AlignVerticalCenterWithPanelProperty, NConverters.ToBool);
      Register<UIElement>(NProps.RelativePanelAlignVerticalCenterWith, RelativePanel.AlignVerticalCenterWithProperty);
      Register<UIElement>(NProps.RelativePanelBelow, RelativePanel.BelowProperty);
      Register<UIElement>(NProps.RelativePanelLeftOf, RelativePanel.LeftOfProperty);
      Register<UIElement>(NProps.RelativePanelRightOf, RelativePanel.RightOfProperty);
    }

    void GenerateStackPanel()
    {
      Register<StackPanel>(NProps.AreScrollSnapPointsRegular, StackPanel.AreScrollSnapPointsRegularProperty, NConverters.ToBool);
      Register<StackPanel>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<StackPanel>(NProps.BorderThickness, StackPanel.BorderThicknessProperty, NConverters.ToThickness);
      Register<StackPanel>(NProps.CornerRadius, StackPanel.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<StackPanel>(NProps.Orientation, StackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<StackPanel>(NProps.Padding, StackPanel.PaddingProperty, NConverters.ToThickness);
      RegisterEvent<StackPanel>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<StackPanel>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateVariableSizedWrapGrid()
    {
      Register<VariableSizedWrapGrid>(NProps.HorizontalChildrenAlignment, VariableSizedWrapGrid.HorizontalChildrenAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<VariableSizedWrapGrid>(NProps.ItemHeight, VariableSizedWrapGrid.ItemHeightProperty, NConverters.ToDouble);
      Register<VariableSizedWrapGrid>(NProps.ItemWidth, VariableSizedWrapGrid.ItemWidthProperty, NConverters.ToDouble);
      Register<VariableSizedWrapGrid>(NProps.MaximumRowsOrColumns, VariableSizedWrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32);
      Register<VariableSizedWrapGrid>(NProps.Orientation, VariableSizedWrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<VariableSizedWrapGrid>(NProps.VerticalChildrenAlignment, VariableSizedWrapGrid.VerticalChildrenAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<UIElement>(NProps.VariableSizedWrapGridColumnSpan, VariableSizedWrapGrid.ColumnSpanProperty, NConverters.ToInt32);
      Register<UIElement>(NProps.VariableSizedWrapGridRowSpan, VariableSizedWrapGrid.RowSpanProperty, NConverters.ToInt32);
    }

    void GenerateCarouselPanel()
    {
      Register<CarouselPanel>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<CarouselPanel>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
//      Register<CarouselPanel>(NProps.ScrollOwner);
      RegisterEvent<CarouselPanel>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<CarouselPanel>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateOrientedVirtualizingPanel()
    {
      Register<OrientedVirtualizingPanel>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<OrientedVirtualizingPanel>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
//      Register<OrientedVirtualizingPanel>(NProps.ScrollOwner);
      RegisterEvent<OrientedVirtualizingPanel>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<OrientedVirtualizingPanel>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateVirtualizingStackPanel()
    {
      Register<VirtualizingStackPanel>(NProps.AreScrollSnapPointsRegular, VirtualizingStackPanel.AreScrollSnapPointsRegularProperty, NConverters.ToBool);
      Register<VirtualizingStackPanel>(NProps.Orientation, VirtualizingStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<DependencyObject>(NProps.VirtualizingStackPanelVirtualizationMode, VirtualizingStackPanel.VirtualizationModeProperty, NConverters.ToEnum<VirtualizationMode>);
      RegisterEvent<VirtualizingStackPanel>(NProps.CleanUpVirtualizedItemEvent, (s, a) => s.CleanUpVirtualizedItemEvent += a.EventHandlerAny);
    }

    void GenerateWrapGrid()
    {
      Register<WrapGrid>(NProps.HorizontalChildrenAlignment, WrapGrid.HorizontalChildrenAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<WrapGrid>(NProps.ItemHeight, WrapGrid.ItemHeightProperty, NConverters.ToDouble);
      Register<WrapGrid>(NProps.ItemWidth, WrapGrid.ItemWidthProperty, NConverters.ToDouble);
      Register<WrapGrid>(NProps.MaximumRowsOrColumns, WrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32);
      Register<WrapGrid>(NProps.Orientation, WrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<WrapGrid>(NProps.VerticalChildrenAlignment, WrapGrid.VerticalChildrenAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
    }

    void GenerateItemsStackPanel()
    {
      Register<ItemsStackPanel>(NProps.AreStickyGroupHeadersEnabled, ItemsStackPanel.AreStickyGroupHeadersEnabledProperty, NConverters.ToBool);
      Register<ItemsStackPanel>(NProps.CacheLength, ItemsStackPanel.CacheLengthProperty, NConverters.ToDouble);
      Register<ItemsStackPanel>(NProps.GroupHeaderPlacement, ItemsStackPanel.GroupHeaderPlacementProperty, NConverters.ToEnum<GroupHeaderPlacement>);
      Register<ItemsStackPanel>(NProps.GroupPadding, ItemsStackPanel.GroupPaddingProperty, NConverters.ToThickness);
      Register<ItemsStackPanel>(NProps.ItemsUpdatingScrollMode, (t, v) => t.ItemsUpdatingScrollMode = NConverters.ToEnumT<ItemsUpdatingScrollMode>(v));
      Register<ItemsStackPanel>(NProps.Orientation, ItemsStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GenerateItemsWrapGrid()
    {
      Register<ItemsWrapGrid>(NProps.AreStickyGroupHeadersEnabled, ItemsWrapGrid.AreStickyGroupHeadersEnabledProperty, NConverters.ToBool);
      Register<ItemsWrapGrid>(NProps.CacheLength, ItemsWrapGrid.CacheLengthProperty, NConverters.ToDouble);
      Register<ItemsWrapGrid>(NProps.GroupHeaderPlacement, ItemsWrapGrid.GroupHeaderPlacementProperty, NConverters.ToEnum<GroupHeaderPlacement>);
      Register<ItemsWrapGrid>(NProps.GroupPadding, ItemsWrapGrid.GroupPaddingProperty, NConverters.ToThickness);
      Register<ItemsWrapGrid>(NProps.ItemHeight, ItemsWrapGrid.ItemHeightProperty, NConverters.ToDouble);
      Register<ItemsWrapGrid>(NProps.ItemWidth, ItemsWrapGrid.ItemWidthProperty, NConverters.ToDouble);
      Register<ItemsWrapGrid>(NProps.MaximumRowsOrColumns, ItemsWrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32);
      Register<ItemsWrapGrid>(NProps.Orientation, ItemsWrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GeneratePivotPanel()
    {
      RegisterEvent<PivotPanel>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<PivotPanel>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateBorder()
    {
      Register<Border>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Border>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Border>(NProps.BorderThickness, Border.BorderThicknessProperty, NConverters.ToThickness);
      Register<Border>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
      Register<Border>(NProps.ChildTransitions, (t, v) => AssignListT(t.ChildTransitions, v));
      Register<Border>(NProps.CornerRadius, Border.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<Border>(NProps.Padding, Border.PaddingProperty, NConverters.ToThickness);
    }

    void GenerateCaptureElement()
    {
      Register<CaptureElement>(NProps.Source, CaptureElement.SourceProperty);
      Register<CaptureElement>(NProps.Stretch, CaptureElement.StretchProperty, NConverters.ToEnum<Stretch>);
    }

    void GenerateContentPresenter()
    {
      Register<ContentPresenter>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<ContentPresenter>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<ContentPresenter>(NProps.BorderThickness, ContentPresenter.BorderThicknessProperty, NConverters.ToThickness);
      Register<ContentPresenter>(NProps.CharacterSpacing, ContentPresenter.CharacterSpacingProperty, NConverters.ToInt32);
      Register<ContentPresenter>(NProps.Content, ContentPresenter.ContentProperty);
      Register<ContentPresenter>(NProps.ContentTemplate, ContentPresenter.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<ContentPresenter>(NProps.ContentTemplateSelector, ContentPresenter.ContentTemplateSelectorProperty);
      Register<ContentPresenter>(NProps.ContentTransitions, (t, v) => AssignListT(t.ContentTransitions, v));
      Register<ContentPresenter>(NProps.CornerRadius, ContentPresenter.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<ContentPresenter>(NProps.FontFamily, ContentPresenter.FontFamilyProperty, NConverters.ToFontFamily);
      Register<ContentPresenter>(NProps.FontSize, ContentPresenter.FontSizeProperty, NConverters.ToDouble);
      Register<ContentPresenter>(NProps.FontStretch, ContentPresenter.FontStretchProperty, NConverters.ToEnum<FontStretch>);
      Register<ContentPresenter>(NProps.FontStyle, ContentPresenter.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<ContentPresenter>(NProps.FontWeight, ContentPresenter.FontWeightProperty, NConverters.ToFontWeight);
      Register<ContentPresenter>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<ContentPresenter>(NProps.HorizontalContentAlignment, ContentPresenter.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<ContentPresenter>(NProps.IsTextScaleFactorEnabled, ContentPresenter.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<ContentPresenter>(NProps.LineHeight, ContentPresenter.LineHeightProperty, NConverters.ToDouble);
      Register<ContentPresenter>(NProps.LineStackingStrategy, ContentPresenter.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<ContentPresenter>(NProps.MaxLines, ContentPresenter.MaxLinesProperty, NConverters.ToInt32);
      Register<ContentPresenter>(NProps.OpticalMarginAlignment, ContentPresenter.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>);
      Register<ContentPresenter>(NProps.Padding, ContentPresenter.PaddingProperty, NConverters.ToThickness);
      Register<ContentPresenter>(NProps.TextLineBounds, ContentPresenter.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>);
      Register<ContentPresenter>(NProps.TextWrapping, ContentPresenter.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      Register<ContentPresenter>(NProps.VerticalContentAlignment, ContentPresenter.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
    }

    void GenerateScrollContentPresenter()
    {
      Register<ScrollContentPresenter>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<ScrollContentPresenter>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
//      Register<ScrollContentPresenter>(NProps.ScrollOwner);
    }

    void GenerateGridViewItemPresenter()
    {
      Register<GridViewItemPresenter>(NProps.CheckBrush, (t, v) => t.CheckBrush = NConverters.ToBrushT(v, t.CheckBrush));
      Register<GridViewItemPresenter>(NProps.CheckHintBrush, (t, v) => t.CheckHintBrush = NConverters.ToBrushT(v, t.CheckHintBrush));
      Register<GridViewItemPresenter>(NProps.CheckSelectingBrush, (t, v) => t.CheckSelectingBrush = NConverters.ToBrushT(v, t.CheckSelectingBrush));
      Register<GridViewItemPresenter>(NProps.ContentMargin, GridViewItemPresenter.ContentMarginProperty, NConverters.ToThickness);
      Register<GridViewItemPresenter>(NProps.DisabledOpacity, GridViewItemPresenter.DisabledOpacityProperty, NConverters.ToDouble);
      Register<GridViewItemPresenter>(NProps.DragBackground, (t, v) => t.DragBackground = NConverters.ToBrushT(v, t.DragBackground));
      Register<GridViewItemPresenter>(NProps.DragForeground, (t, v) => t.DragForeground = NConverters.ToBrushT(v, t.DragForeground));
      Register<GridViewItemPresenter>(NProps.DragOpacity, GridViewItemPresenter.DragOpacityProperty, NConverters.ToDouble);
      Register<GridViewItemPresenter>(NProps.FocusBorderBrush, (t, v) => t.FocusBorderBrush = NConverters.ToBrushT(v, t.FocusBorderBrush));
      Register<GridViewItemPresenter>(NProps.GridViewItemPresenterHorizontalContentAlignment, GridViewItemPresenter.GridViewItemPresenterHorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<GridViewItemPresenter>(NProps.GridViewItemPresenterPadding, GridViewItemPresenter.GridViewItemPresenterPaddingProperty, NConverters.ToThickness);
      Register<GridViewItemPresenter>(NProps.GridViewItemPresenterVerticalContentAlignment, GridViewItemPresenter.GridViewItemPresenterVerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<GridViewItemPresenter>(NProps.PlaceholderBackground, (t, v) => t.PlaceholderBackground = NConverters.ToBrushT(v, t.PlaceholderBackground));
      Register<GridViewItemPresenter>(NProps.PointerOverBackground, (t, v) => t.PointerOverBackground = NConverters.ToBrushT(v, t.PointerOverBackground));
      Register<GridViewItemPresenter>(NProps.PointerOverBackgroundMargin, GridViewItemPresenter.PointerOverBackgroundMarginProperty, NConverters.ToThickness);
      Register<GridViewItemPresenter>(NProps.ReorderHintOffset, GridViewItemPresenter.ReorderHintOffsetProperty, NConverters.ToDouble);
      Register<GridViewItemPresenter>(NProps.SelectedBackground, (t, v) => t.SelectedBackground = NConverters.ToBrushT(v, t.SelectedBackground));
      Register<GridViewItemPresenter>(NProps.SelectedBorderThickness, GridViewItemPresenter.SelectedBorderThicknessProperty, NConverters.ToThickness);
      Register<GridViewItemPresenter>(NProps.SelectedForeground, (t, v) => t.SelectedForeground = NConverters.ToBrushT(v, t.SelectedForeground));
      Register<GridViewItemPresenter>(NProps.SelectedPointerOverBackground, (t, v) => t.SelectedPointerOverBackground = NConverters.ToBrushT(v, t.SelectedPointerOverBackground));
      Register<GridViewItemPresenter>(NProps.SelectedPointerOverBorderBrush, (t, v) => t.SelectedPointerOverBorderBrush = NConverters.ToBrushT(v, t.SelectedPointerOverBorderBrush));
      Register<GridViewItemPresenter>(NProps.SelectionCheckMarkVisualEnabled, GridViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, NConverters.ToBool);
    }

    void GenerateListViewItemPresenter()
    {
      Register<ListViewItemPresenter>(NProps.CheckBoxBrush, (t, v) => t.CheckBoxBrush = NConverters.ToBrushT(v, t.CheckBoxBrush));
      Register<ListViewItemPresenter>(NProps.CheckBrush, (t, v) => t.CheckBrush = NConverters.ToBrushT(v, t.CheckBrush));
      Register<ListViewItemPresenter>(NProps.CheckHintBrush, (t, v) => t.CheckHintBrush = NConverters.ToBrushT(v, t.CheckHintBrush));
      Register<ListViewItemPresenter>(NProps.CheckMode, ListViewItemPresenter.CheckModeProperty, NConverters.ToEnum<ListViewItemPresenterCheckMode>);
      Register<ListViewItemPresenter>(NProps.CheckSelectingBrush, (t, v) => t.CheckSelectingBrush = NConverters.ToBrushT(v, t.CheckSelectingBrush));
      Register<ListViewItemPresenter>(NProps.ContentMargin, ListViewItemPresenter.ContentMarginProperty, NConverters.ToThickness);
      Register<ListViewItemPresenter>(NProps.DisabledOpacity, ListViewItemPresenter.DisabledOpacityProperty, NConverters.ToDouble);
      Register<ListViewItemPresenter>(NProps.DragBackground, (t, v) => t.DragBackground = NConverters.ToBrushT(v, t.DragBackground));
      Register<ListViewItemPresenter>(NProps.DragForeground, (t, v) => t.DragForeground = NConverters.ToBrushT(v, t.DragForeground));
      Register<ListViewItemPresenter>(NProps.DragOpacity, ListViewItemPresenter.DragOpacityProperty, NConverters.ToDouble);
      Register<ListViewItemPresenter>(NProps.FocusBorderBrush, (t, v) => t.FocusBorderBrush = NConverters.ToBrushT(v, t.FocusBorderBrush));
      Register<ListViewItemPresenter>(NProps.FocusSecondaryBorderBrush, (t, v) => t.FocusSecondaryBorderBrush = NConverters.ToBrushT(v, t.FocusSecondaryBorderBrush));
      Register<ListViewItemPresenter>(NProps.ListViewItemPresenterHorizontalContentAlignment, ListViewItemPresenter.ListViewItemPresenterHorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<ListViewItemPresenter>(NProps.ListViewItemPresenterPadding, ListViewItemPresenter.ListViewItemPresenterPaddingProperty, NConverters.ToThickness);
      Register<ListViewItemPresenter>(NProps.ListViewItemPresenterVerticalContentAlignment, ListViewItemPresenter.ListViewItemPresenterVerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<ListViewItemPresenter>(NProps.PlaceholderBackground, (t, v) => t.PlaceholderBackground = NConverters.ToBrushT(v, t.PlaceholderBackground));
      Register<ListViewItemPresenter>(NProps.PointerOverBackground, (t, v) => t.PointerOverBackground = NConverters.ToBrushT(v, t.PointerOverBackground));
      Register<ListViewItemPresenter>(NProps.PointerOverBackgroundMargin, ListViewItemPresenter.PointerOverBackgroundMarginProperty, NConverters.ToThickness);
      Register<ListViewItemPresenter>(NProps.PointerOverForeground, (t, v) => t.PointerOverForeground = NConverters.ToBrushT(v, t.PointerOverForeground));
      Register<ListViewItemPresenter>(NProps.PressedBackground, (t, v) => t.PressedBackground = NConverters.ToBrushT(v, t.PressedBackground));
      Register<ListViewItemPresenter>(NProps.ReorderHintOffset, ListViewItemPresenter.ReorderHintOffsetProperty, NConverters.ToDouble);
      Register<ListViewItemPresenter>(NProps.SelectedBackground, (t, v) => t.SelectedBackground = NConverters.ToBrushT(v, t.SelectedBackground));
      Register<ListViewItemPresenter>(NProps.SelectedBorderThickness, ListViewItemPresenter.SelectedBorderThicknessProperty, NConverters.ToThickness);
      Register<ListViewItemPresenter>(NProps.SelectedForeground, (t, v) => t.SelectedForeground = NConverters.ToBrushT(v, t.SelectedForeground));
      Register<ListViewItemPresenter>(NProps.SelectedPointerOverBackground, (t, v) => t.SelectedPointerOverBackground = NConverters.ToBrushT(v, t.SelectedPointerOverBackground));
      Register<ListViewItemPresenter>(NProps.SelectedPointerOverBorderBrush, (t, v) => t.SelectedPointerOverBorderBrush = NConverters.ToBrushT(v, t.SelectedPointerOverBorderBrush));
      Register<ListViewItemPresenter>(NProps.SelectedPressedBackground, (t, v) => t.SelectedPressedBackground = NConverters.ToBrushT(v, t.SelectedPressedBackground));
      Register<ListViewItemPresenter>(NProps.SelectionCheckMarkVisualEnabled, ListViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, NConverters.ToBool);
    }

    void GenerateImage()
    {
      Register<Image>(NProps.NineGrid, Image.NineGridProperty, NConverters.ToThickness);
      Register<Image>(NProps.Source, Image.SourceProperty);
      Register<Image>(NProps.Stretch, Image.StretchProperty, NConverters.ToEnum<Stretch>);
      RegisterEvent<Image>(NProps.ImageFailed, (s, a) => s.ImageFailed += a.EventHandlerAny);
      RegisterEvent<Image>(NProps.ImageOpened, (s, a) => s.ImageOpened += a.EventHandlerAny);
    }

    void GenerateItemsPresenter()
    {
      Register<ItemsPresenter>(NProps.Footer, ItemsPresenter.FooterProperty);
      Register<ItemsPresenter>(NProps.FooterTemplate, ItemsPresenter.FooterTemplateProperty, NConverters.ToDataTemplate);
      Register<ItemsPresenter>(NProps.FooterTransitions, (t, v) => AssignListT(t.FooterTransitions, v));
      Register<ItemsPresenter>(NProps.Header, ItemsPresenter.HeaderProperty);
      Register<ItemsPresenter>(NProps.HeaderTemplate, ItemsPresenter.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<ItemsPresenter>(NProps.HeaderTransitions, (t, v) => AssignListT(t.HeaderTransitions, v));
      Register<ItemsPresenter>(NProps.Padding, ItemsPresenter.PaddingProperty, NConverters.ToThickness);
      RegisterEvent<ItemsPresenter>(NProps.HorizontalSnapPointsChanged, (s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);
      RegisterEvent<ItemsPresenter>(NProps.VerticalSnapPointsChanged, (s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);
    }

    void GenerateRichTextBlockOverflow()
    {
      Register<RichTextBlockOverflow>(NProps.MaxLines, RichTextBlockOverflow.MaxLinesProperty, NConverters.ToInt32);
      Register<RichTextBlockOverflow>(NProps.OverflowContentTarget, RichTextBlockOverflow.OverflowContentTargetProperty);
      Register<RichTextBlockOverflow>(NProps.Padding, RichTextBlockOverflow.PaddingProperty, NConverters.ToThickness);
    }

    void GenerateRichTextBlock()
    {
      Register<RichTextBlock>(NProps.Blocks, (t, v) => AssignListT(t.Blocks, v));
      Register<RichTextBlock>(NProps.CharacterSpacing, RichTextBlock.CharacterSpacingProperty, NConverters.ToInt32);
      Register<RichTextBlock>(NProps.FontFamily, RichTextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<RichTextBlock>(NProps.FontSize, RichTextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<RichTextBlock>(NProps.FontStretch, RichTextBlock.FontStretchProperty, NConverters.ToEnum<FontStretch>);
      Register<RichTextBlock>(NProps.FontStyle, RichTextBlock.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<RichTextBlock>(NProps.FontWeight, RichTextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<RichTextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<RichTextBlock>(NProps.IsColorFontEnabled, RichTextBlock.IsColorFontEnabledProperty, NConverters.ToBool);
      Register<RichTextBlock>(NProps.IsTextScaleFactorEnabled, RichTextBlock.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<RichTextBlock>(NProps.IsTextSelectionEnabled, RichTextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool);
      Register<RichTextBlock>(NProps.LineHeight, RichTextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<RichTextBlock>(NProps.LineStackingStrategy, RichTextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<RichTextBlock>(NProps.MaxLines, RichTextBlock.MaxLinesProperty, NConverters.ToInt32);
      Register<RichTextBlock>(NProps.OpticalMarginAlignment, RichTextBlock.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>);
      Register<RichTextBlock>(NProps.OverflowContentTarget, RichTextBlock.OverflowContentTargetProperty);
      Register<RichTextBlock>(NProps.Padding, RichTextBlock.PaddingProperty, NConverters.ToThickness);
      Register<RichTextBlock>(NProps.SelectionHighlightColor, RichTextBlock.SelectionHighlightColorProperty);
      Register<RichTextBlock>(NProps.TextAlignment, RichTextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<RichTextBlock>(NProps.TextIndent, RichTextBlock.TextIndentProperty, NConverters.ToDouble);
      Register<RichTextBlock>(NProps.TextLineBounds, RichTextBlock.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>);
      Register<RichTextBlock>(NProps.TextReadingOrder, RichTextBlock.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);
      Register<RichTextBlock>(NProps.TextTrimming, RichTextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<RichTextBlock>(NProps.TextWrapping, RichTextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      RegisterEvent<RichTextBlock>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandlerAny);
      RegisterEvent<RichTextBlock>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
    }

    void GenerateTextBlock()
    {
      Register<TextBlock>(NProps.CharacterSpacing, TextBlock.CharacterSpacingProperty, NConverters.ToInt32);
      Register<TextBlock>(NProps.FontFamily, TextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextBlock>(NProps.FontSize, TextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.FontStretch, TextBlock.FontStretchProperty, NConverters.ToEnum<FontStretch>);
      Register<TextBlock>(NProps.FontStyle, TextBlock.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<TextBlock>(NProps.FontWeight, TextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextBlock>(NProps.Inlines, (t, v) => AssignListT(t.Inlines, v));
      Register<TextBlock>(NProps.IsColorFontEnabled, TextBlock.IsColorFontEnabledProperty, NConverters.ToBool);
      Register<TextBlock>(NProps.IsTextScaleFactorEnabled, TextBlock.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<TextBlock>(NProps.IsTextSelectionEnabled, TextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool);
      Register<TextBlock>(NProps.LineHeight, TextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.LineStackingStrategy, TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<TextBlock>(NProps.MaxLines, TextBlock.MaxLinesProperty, NConverters.ToInt32);
      Register<TextBlock>(NProps.OpticalMarginAlignment, TextBlock.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>);
      Register<TextBlock>(NProps.Padding, TextBlock.PaddingProperty, NConverters.ToThickness);
      Register<TextBlock>(NProps.SelectionHighlightColor, TextBlock.SelectionHighlightColorProperty);
      Register<TextBlock>(NProps.Text, TextBlock.TextProperty, NConverters.ToString);
      Register<TextBlock>(NProps.TextAlignment, TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBlock>(NProps.TextLineBounds, TextBlock.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>);
      Register<TextBlock>(NProps.TextReadingOrder, TextBlock.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);
      Register<TextBlock>(NProps.TextTrimming, TextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<TextBlock>(NProps.TextWrapping, TextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      RegisterEvent<TextBlock>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandlerAny);
      RegisterEvent<TextBlock>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
    }

    void GenerateViewbox()
    {
      Register<Viewbox>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
      Register<Viewbox>(NProps.Stretch, Viewbox.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<Viewbox>(NProps.StretchDirection, Viewbox.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
    }

    void GenerateTickBar()
    {
      Register<TickBar>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
    }

    void GenerateGlyphs()
    {
      Register<Glyphs>(NProps.ColorFontPaletteIndex, Glyphs.ColorFontPaletteIndexProperty, NConverters.ToInt32);
      Register<Glyphs>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
      Register<Glyphs>(NProps.FontRenderingEmSize, Glyphs.FontRenderingEmSizeProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.FontUri, Glyphs.FontUriProperty, NConverters.ToUri);
      Register<Glyphs>(NProps.Indices, Glyphs.IndicesProperty, NConverters.ToString);
      Register<Glyphs>(NProps.IsColorFontEnabled, Glyphs.IsColorFontEnabledProperty, NConverters.ToBool);
      Register<Glyphs>(NProps.OriginX, Glyphs.OriginXProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.OriginY, Glyphs.OriginYProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.StyleSimulations, Glyphs.StyleSimulationsProperty, NConverters.ToEnum<StyleSimulations>);
      Register<Glyphs>(NProps.UnicodeString, Glyphs.UnicodeStringProperty, NConverters.ToString);
    }

    void GenerateIconElement()
    {
      Register<IconElement>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
    }

    void GenerateBitmapIcon()
    {
      Register<BitmapIcon>(NProps.UriSource, BitmapIcon.UriSourceProperty, NConverters.ToUri);
    }

    void GenerateFontIcon()
    {
      Register<FontIcon>(NProps.FontFamily, FontIcon.FontFamilyProperty, NConverters.ToFontFamily);
      Register<FontIcon>(NProps.FontSize, FontIcon.FontSizeProperty, NConverters.ToDouble);
      Register<FontIcon>(NProps.FontStyle, FontIcon.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<FontIcon>(NProps.FontWeight, FontIcon.FontWeightProperty, NConverters.ToFontWeight);
      Register<FontIcon>(NProps.Glyph, FontIcon.GlyphProperty, NConverters.ToString);
      Register<FontIcon>(NProps.IsTextScaleFactorEnabled, FontIcon.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<FontIcon>(NProps.MirroredWhenRightToLeft, FontIcon.MirroredWhenRightToLeftProperty, NConverters.ToBool);
    }

    void GeneratePathIcon()
    {
      Register<PathIcon>(NProps.Data, PathIcon.DataProperty);
    }

    void GenerateSymbolIcon()
    {
      Register<SymbolIcon>(NProps.Symbol, SymbolIcon.SymbolProperty, NConverters.ToEnum<Symbol>);
    }

    void GenerateMediaElement()
    {
      Register<MediaElement>(NProps.AreTransportControlsEnabled, MediaElement.AreTransportControlsEnabledProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.AudioCategory, MediaElement.AudioCategoryProperty, NConverters.ToEnum<AudioCategory>);
      Register<MediaElement>(NProps.AudioDeviceType, MediaElement.AudioDeviceTypeProperty, NConverters.ToEnum<AudioDeviceType>);
      Register<MediaElement>(NProps.AudioStreamIndex, MediaElement.AudioStreamIndexProperty, NConverters.ToInt32N);
      Register<MediaElement>(NProps.AutoPlay, MediaElement.AutoPlayProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.Balance, MediaElement.BalanceProperty, NConverters.ToDouble);
      Register<MediaElement>(NProps.DefaultPlaybackRate, MediaElement.DefaultPlaybackRateProperty, NConverters.ToDouble);
      Register<MediaElement>(NProps.IsFullWindow, MediaElement.IsFullWindowProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.IsLooping, MediaElement.IsLoopingProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.IsMuted, MediaElement.IsMutedProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.Markers, (t, v) => AssignListT(t.Markers, v));
      Register<MediaElement>(NProps.PlaybackRate, MediaElement.PlaybackRateProperty, NConverters.ToDouble);
      Register<MediaElement>(NProps.PlayToPreferredSourceUri, MediaElement.PlayToPreferredSourceUriProperty, NConverters.ToUri);
      Register<MediaElement>(NProps.Position, MediaElement.PositionProperty, NConverters.ToTimeSpan);
      Register<MediaElement>(NProps.PosterSource, MediaElement.PosterSourceProperty);
      Register<MediaElement>(NProps.ProtectionManager, MediaElement.ProtectionManagerProperty);
      Register<MediaElement>(NProps.RealTimePlayback, MediaElement.RealTimePlaybackProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.Source, MediaElement.SourceProperty, NConverters.ToUri);
      Register<MediaElement>(NProps.Stereo3DVideoPackingMode, MediaElement.Stereo3DVideoPackingModeProperty, NConverters.ToEnum<Stereo3DVideoPackingMode>);
      Register<MediaElement>(NProps.Stereo3DVideoRenderMode, MediaElement.Stereo3DVideoRenderModeProperty, NConverters.ToEnum<Stereo3DVideoRenderMode>);
      Register<MediaElement>(NProps.Stretch, MediaElement.StretchProperty, NConverters.ToEnum<Stretch>);
//      Register<MediaElement>(NProps.TransportControls);
      Register<MediaElement>(NProps.Volume, MediaElement.VolumeProperty, NConverters.ToDouble);
      RegisterEvent<MediaElement>(NProps.BufferingProgressChanged, (s, a) => s.BufferingProgressChanged += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.CurrentStateChanged, (s, a) => s.CurrentStateChanged += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.DownloadProgressChanged, (s, a) => s.DownloadProgressChanged += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.MarkerReached, (s, a) => s.MarkerReached += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.MediaEnded, (s, a) => s.MediaEnded += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.MediaFailed, (s, a) => s.MediaFailed += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.MediaOpened, (s, a) => s.MediaOpened += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.RateChanged, (s, a) => s.RateChanged += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.SeekCompleted, (s, a) => s.SeekCompleted += a.EventHandlerAny);
      RegisterEvent<MediaElement>(NProps.VolumeChanged, (s, a) => s.VolumeChanged += a.EventHandlerAny);
    }

    void GenerateWebView()
    {
      Register<WebView>(NProps.AllowedScriptNotifyUris, WebView.AllowedScriptNotifyUrisProperty);
      Register<WebView>(NProps.DefaultBackgroundColor, WebView.DefaultBackgroundColorProperty, NConverters.ToColor);
      Register<WebView>(NProps.Source, WebView.SourceProperty, NConverters.ToUri);
      RegisterEvent<WebView>(NProps.LoadCompleted, (s, a) => s.LoadCompleted += a.EventHandlerAny);
      RegisterEvent<WebView>(NProps.NavigationFailed, (s, a) => s.NavigationFailed += a.EventHandlerAny);
      RegisterEvent<WebView>(NProps.ScriptNotify, (s, a) => s.ScriptNotify += a.EventHandlerAny);
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

    void GenerateLine()
    {
      Register<Line>(NProps.X1, Line.X1Property, NConverters.ToDouble);
      Register<Line>(NProps.X2, Line.X2Property, NConverters.ToDouble);
      Register<Line>(NProps.Y1, Line.Y1Property, NConverters.ToDouble);
      Register<Line>(NProps.Y2, Line.Y2Property, NConverters.ToDouble);
    }

    void GeneratePath()
    {
      Register<Path>(NProps.Data, Path.DataProperty);
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

    void GenerateControl()
    {
      Register<Control>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Control>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Control>(NProps.BorderThickness, Control.BorderThicknessProperty, NConverters.ToThickness);
      Register<Control>(NProps.CharacterSpacing, Control.CharacterSpacingProperty, NConverters.ToInt32);
      Register<Control>(NProps.FontFamily, Control.FontFamilyProperty, NConverters.ToFontFamily);
      Register<Control>(NProps.FontSize, Control.FontSizeProperty, NConverters.ToDouble);
      Register<Control>(NProps.FontStretch, Control.FontStretchProperty, NConverters.ToEnum<FontStretch>);
      Register<Control>(NProps.FontStyle, Control.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<Control>(NProps.FontWeight, Control.FontWeightProperty, NConverters.ToFontWeight);
      Register<Control>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<Control>(NProps.HorizontalContentAlignment, Control.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<Control>(NProps.IsEnabled, Control.IsEnabledProperty, NConverters.ToBool);
      Register<Control>(NProps.IsTabStop, Control.IsTabStopProperty, NConverters.ToBool);
      Register<Control>(NProps.IsTextScaleFactorEnabled, Control.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<Control>(NProps.Padding, Control.PaddingProperty, NConverters.ToThickness);
      Register<Control>(NProps.TabIndex, Control.TabIndexProperty, NConverters.ToInt32);
      Register<Control>(NProps.TabNavigation, Control.TabNavigationProperty, NConverters.ToEnum<KeyboardNavigationMode>);
      Register<Control>(NProps.Template, Control.TemplateProperty, NConverters.ToControlTemplate);
      Register<Control>(NProps.UseSystemFocusVisuals, Control.UseSystemFocusVisualsProperty, NConverters.ToBool);
      Register<Control>(NProps.VerticalContentAlignment, Control.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<FrameworkElement>(NProps.ControlIsTemplateFocusTarget, Control.IsTemplateFocusTargetProperty, NConverters.ToBool);
      RegisterEvent<Control>(NProps.IsEnabledChanged, (s, a) => s.IsEnabledChanged += a.EventHandlerAny);
    }

    void GenerateSemanticZoom()
    {
      Register<SemanticZoom>(NProps.CanChangeViews, SemanticZoom.CanChangeViewsProperty, NConverters.ToBool);
      Register<SemanticZoom>(NProps.IsZoomedInViewActive, SemanticZoom.IsZoomedInViewActiveProperty, NConverters.ToBool);
      Register<SemanticZoom>(NProps.IsZoomOutButtonEnabled, SemanticZoom.IsZoomOutButtonEnabledProperty, NConverters.ToBool);
      Register<SemanticZoom>(NProps.ZoomedInView, SemanticZoom.ZoomedInViewProperty);
      Register<SemanticZoom>(NProps.ZoomedOutView, SemanticZoom.ZoomedOutViewProperty);
      RegisterEvent<SemanticZoom>(NProps.ViewChangeCompleted, (s, a) => s.ViewChangeCompleted += a.EventHandlerAny);
      RegisterEvent<SemanticZoom>(NProps.ViewChangeStarted, (s, a) => s.ViewChangeStarted += a.EventHandlerAny);
    }

    void GenerateContentControl()
    {
      Register<ContentControl>(NProps.Content, ContentControl.ContentProperty);
      Register<ContentControl>(NProps.ContentTemplate, ContentControl.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<ContentControl>(NProps.ContentTemplateSelector, ContentControl.ContentTemplateSelectorProperty);
      Register<ContentControl>(NProps.ContentTransitions, (t, v) => AssignListT(t.ContentTransitions, v));
    }

    void GenerateSelectorItem()
    {
      Register<SelectorItem>(NProps.IsSelected, SelectorItem.IsSelectedProperty, NConverters.ToBool);
    }

    void GenerateSettingsFlyout()
    {
      Register<SettingsFlyout>(NProps.HeaderBackground, (t, v) => t.HeaderBackground = NConverters.ToBrushT(v, t.HeaderBackground));
      Register<SettingsFlyout>(NProps.HeaderForeground, (t, v) => t.HeaderForeground = NConverters.ToBrushT(v, t.HeaderForeground));
      Register<SettingsFlyout>(NProps.IconSource, SettingsFlyout.IconSourceProperty);
      Register<SettingsFlyout>(NProps.Title, SettingsFlyout.TitleProperty, NConverters.ToString);
      RegisterEvent<SettingsFlyout>(NProps.BackClick, (s, a) => s.BackClick += a.EventHandlerAny);
    }

    void GenerateToolTip()
    {
      Register<ToolTip>(NProps.HorizontalOffset, ToolTip.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<ToolTip>(NProps.IsOpen, ToolTip.IsOpenProperty, NConverters.ToBool);
      Register<ToolTip>(NProps.Placement, ToolTip.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<ToolTip>(NProps.PlacementTarget, ToolTip.PlacementTargetProperty);
      Register<ToolTip>(NProps.VerticalOffset, ToolTip.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<ToolTip>(NProps.Closed, (s, a) => s.Closed += a.EventHandlerAny);
      RegisterEvent<ToolTip>(NProps.Opened, (s, a) => s.Opened += a.EventHandlerAny);
    }

    void GenerateButtonBase()
    {
      Register<ButtonBase>(NProps.ClickMode, ButtonBase.ClickModeProperty, NConverters.ToEnum<ClickMode>);
      Register<ButtonBase>(NProps.Command, ButtonBase.CommandProperty);
      Register<ButtonBase>(NProps.CommandParameter, ButtonBase.CommandParameterProperty);
      RegisterEvent<ButtonBase>(NProps.Click, (s, a) => s.Click += a.EventHandlerAny);
    }

    void GenerateButton()
    {
      Register<Button>(NProps.Flyout, Button.FlyoutProperty);
    }

    void GenerateAppBarButton()
    {
      Register<AppBarButton>(NProps.Icon, AppBarButton.IconProperty);
      Register<AppBarButton>(NProps.IsCompact, AppBarButton.IsCompactProperty, NConverters.ToBool);
      Register<AppBarButton>(NProps.Label, AppBarButton.LabelProperty, NConverters.ToString);
    }

    void GenerateHyperlinkButton()
    {
      Register<HyperlinkButton>(NProps.NavigateUri, HyperlinkButton.NavigateUriProperty, NConverters.ToUri);
    }

    void GenerateRepeatButton()
    {
      Register<RepeatButton>(NProps.Delay, RepeatButton.DelayProperty, NConverters.ToInt32);
      Register<RepeatButton>(NProps.Interval, RepeatButton.IntervalProperty, NConverters.ToInt32);
    }

    void GenerateToggleButton()
    {
      Register<ToggleButton>(NProps.IsChecked, ToggleButton.IsCheckedProperty, NConverters.ToBoolN);
      Register<ToggleButton>(NProps.IsThreeState, ToggleButton.IsThreeStateProperty, NConverters.ToBool);
      RegisterEvent<ToggleButton>(NProps.Checked, (s, a) => s.Checked += a.EventHandlerAny);
      RegisterEvent<ToggleButton>(NProps.Indeterminate, (s, a) => s.Indeterminate += a.EventHandlerAny);
      RegisterEvent<ToggleButton>(NProps.Unchecked, (s, a) => s.Unchecked += a.EventHandlerAny);
    }

    void GenerateRadioButton()
    {
      Register<RadioButton>(NProps.GroupName, RadioButton.GroupNameProperty, NConverters.ToString);
    }

    void GenerateAppBarToggleButton()
    {
      Register<AppBarToggleButton>(NProps.Icon, AppBarToggleButton.IconProperty);
      Register<AppBarToggleButton>(NProps.IsCompact, AppBarToggleButton.IsCompactProperty, NConverters.ToBool);
      Register<AppBarToggleButton>(NProps.Label, AppBarToggleButton.LabelProperty, NConverters.ToString);
    }

    void GenerateAppBar()
    {
      Register<AppBar>(NProps.ClosedDisplayMode, AppBar.ClosedDisplayModeProperty, NConverters.ToEnum<AppBarClosedDisplayMode>);
      Register<AppBar>(NProps.IsOpen, AppBar.IsOpenProperty, NConverters.ToBool);
      Register<AppBar>(NProps.IsSticky, AppBar.IsStickyProperty, NConverters.ToBool);
      RegisterEvent<AppBar>(NProps.Closed, (s, a) => s.Closed += a.EventHandlerAny);
      RegisterEvent<AppBar>(NProps.Closing, (s, a) => s.Closing += a.EventHandlerAny);
      RegisterEvent<AppBar>(NProps.Opened, (s, a) => s.Opened += a.EventHandlerAny);
      RegisterEvent<AppBar>(NProps.Opening, (s, a) => s.Opening += a.EventHandlerAny);
    }

    void GenerateCommandBar()
    {
      Register<CommandBar>(NProps.CommandBarOverflowPresenterStyle, CommandBar.CommandBarOverflowPresenterStyleProperty, NConverters.ToStyle);
      Register<CommandBar>(NProps.PrimaryCommands, (t, v) => AssignListT(t.PrimaryCommands, v));
      Register<CommandBar>(NProps.SecondaryCommands, (t, v) => AssignListT(t.SecondaryCommands, v));
    }

    void GenerateContentDialog()
    {
      Register<ContentDialog>(NProps.FullSizeDesired, ContentDialog.FullSizeDesiredProperty, NConverters.ToBool);
      Register<ContentDialog>(NProps.IsPrimaryButtonEnabled, ContentDialog.IsPrimaryButtonEnabledProperty, NConverters.ToBool);
      Register<ContentDialog>(NProps.IsSecondaryButtonEnabled, ContentDialog.IsSecondaryButtonEnabledProperty, NConverters.ToBool);
      Register<ContentDialog>(NProps.PrimaryButtonCommand, ContentDialog.PrimaryButtonCommandProperty);
      Register<ContentDialog>(NProps.PrimaryButtonCommandParameter, ContentDialog.PrimaryButtonCommandParameterProperty);
      Register<ContentDialog>(NProps.PrimaryButtonText, ContentDialog.PrimaryButtonTextProperty, NConverters.ToString);
      Register<ContentDialog>(NProps.SecondaryButtonCommand, ContentDialog.SecondaryButtonCommandProperty);
      Register<ContentDialog>(NProps.SecondaryButtonCommandParameter, ContentDialog.SecondaryButtonCommandParameterProperty);
      Register<ContentDialog>(NProps.SecondaryButtonText, ContentDialog.SecondaryButtonTextProperty, NConverters.ToString);
      Register<ContentDialog>(NProps.Title, ContentDialog.TitleProperty);
      Register<ContentDialog>(NProps.TitleTemplate, ContentDialog.TitleTemplateProperty, NConverters.ToDataTemplate);
    }

    void GenerateFrame()
    {
      Register<Frame>(NProps.CacheSize, Frame.CacheSizeProperty, NConverters.ToInt32);
      Register<Frame>(NProps.SourcePageType, Frame.SourcePageTypeProperty);
      RegisterEvent<Frame>(NProps.Navigated, (s, a) => s.Navigated += a.EventHandlerAny);
      RegisterEvent<Frame>(NProps.Navigating, (s, a) => s.Navigating += a.EventHandlerAny);
      RegisterEvent<Frame>(NProps.NavigationFailed, (s, a) => s.NavigationFailed += a.EventHandlerAny);
      RegisterEvent<Frame>(NProps.NavigationStopped, (s, a) => s.NavigationStopped += a.EventHandlerAny);
    }

    void GenerateScrollViewer()
    {
      Register<ScrollViewer>(NProps.BringIntoViewOnFocusChange, ScrollViewer.BringIntoViewOnFocusChangeProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.HorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<ScrollViewer>(NProps.HorizontalScrollMode, ScrollViewer.HorizontalScrollModeProperty, NConverters.ToEnum<ScrollMode>);
      Register<ScrollViewer>(NProps.HorizontalSnapPointsAlignment, ScrollViewer.HorizontalSnapPointsAlignmentProperty, NConverters.ToEnum<SnapPointsAlignment>);
      Register<ScrollViewer>(NProps.HorizontalSnapPointsType, ScrollViewer.HorizontalSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);
      Register<ScrollViewer>(NProps.IsDeferredScrollingEnabled, ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsHorizontalRailEnabled, ScrollViewer.IsHorizontalRailEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsHorizontalScrollChainingEnabled, ScrollViewer.IsHorizontalScrollChainingEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsScrollInertiaEnabled, ScrollViewer.IsScrollInertiaEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsVerticalRailEnabled, ScrollViewer.IsVerticalRailEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsVerticalScrollChainingEnabled, ScrollViewer.IsVerticalScrollChainingEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsZoomChainingEnabled, ScrollViewer.IsZoomChainingEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.IsZoomInertiaEnabled, ScrollViewer.IsZoomInertiaEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.LeftHeader, ScrollViewer.LeftHeaderProperty);
      Register<ScrollViewer>(NProps.MaxZoomFactor, ScrollViewer.MaxZoomFactorProperty, NConverters.ToSingle);
      Register<ScrollViewer>(NProps.MinZoomFactor, ScrollViewer.MinZoomFactorProperty, NConverters.ToSingle);
      Register<ScrollViewer>(NProps.TopHeader, ScrollViewer.TopHeaderProperty);
      Register<ScrollViewer>(NProps.TopLeftHeader, ScrollViewer.TopLeftHeaderProperty);
      Register<ScrollViewer>(NProps.VerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<ScrollViewer>(NProps.VerticalScrollMode, ScrollViewer.VerticalScrollModeProperty, NConverters.ToEnum<ScrollMode>);
      Register<ScrollViewer>(NProps.VerticalSnapPointsAlignment, ScrollViewer.VerticalSnapPointsAlignmentProperty, NConverters.ToEnum<SnapPointsAlignment>);
      Register<ScrollViewer>(NProps.VerticalSnapPointsType, ScrollViewer.VerticalSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);
      Register<ScrollViewer>(NProps.ZoomMode, ScrollViewer.ZoomModeProperty, NConverters.ToEnum<ZoomMode>);
      Register<ScrollViewer>(NProps.ZoomSnapPointsType, ScrollViewer.ZoomSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);
      Register<DependencyObject>(NProps.ScrollViewerBringIntoViewOnFocusChange, ScrollViewer.BringIntoViewOnFocusChangeProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsZoomInertiaEnabled, ScrollViewer.IsZoomInertiaEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerHorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerHorizontalScrollMode, ScrollViewer.HorizontalScrollModeProperty, NConverters.ToEnum<ScrollMode>);
      Register<DependencyObject>(NProps.ScrollViewerIsDeferredScrollingEnabled, ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsHorizontalRailEnabled, ScrollViewer.IsHorizontalRailEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsHorizontalScrollChainingEnabled, ScrollViewer.IsHorizontalScrollChainingEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsScrollInertiaEnabled, ScrollViewer.IsScrollInertiaEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsVerticalRailEnabled, ScrollViewer.IsVerticalRailEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsVerticalScrollChainingEnabled, ScrollViewer.IsVerticalScrollChainingEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerIsZoomChainingEnabled, ScrollViewer.IsZoomChainingEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerVerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerVerticalScrollMode, ScrollViewer.VerticalScrollModeProperty, NConverters.ToEnum<ScrollMode>);
      Register<DependencyObject>(NProps.ScrollViewerZoomMode, ScrollViewer.ZoomModeProperty, NConverters.ToEnum<ZoomMode>);
      RegisterEvent<ScrollViewer>(NProps.DirectManipulationCompleted, (s, a) => s.DirectManipulationCompleted += a.EventHandlerAny);
      RegisterEvent<ScrollViewer>(NProps.DirectManipulationStarted, (s, a) => s.DirectManipulationStarted += a.EventHandlerAny);
      RegisterEvent<ScrollViewer>(NProps.ViewChanged, (s, a) => s.ViewChanged += a.EventHandlerAny);
      RegisterEvent<ScrollViewer>(NProps.ViewChanging, (s, a) => s.ViewChanging += a.EventHandlerAny);
    }

    void GeneratePivotItem()
    {
      Register<PivotItem>(NProps.Header, PivotItem.HeaderProperty);
    }

    void GenerateItemsControl()
    {
      Register<ItemsControl>(NProps.DisplayMemberPath, ItemsControl.DisplayMemberPathProperty, NConverters.ToString);
      Register<ItemsControl>(NProps.GroupStyle, (t, v) => AssignListT(t.GroupStyle, v));
      Register<ItemsControl>(NProps.GroupStyleSelector, ItemsControl.GroupStyleSelectorProperty);
      Register<ItemsControl>(NProps.ItemContainerStyle, ItemsControl.ItemContainerStyleProperty, NConverters.ToStyle);
      Register<ItemsControl>(NProps.ItemContainerStyleSelector, ItemsControl.ItemContainerStyleSelectorProperty);
      Register<ItemsControl>(NProps.ItemContainerTransitions, (t, v) => AssignListT(t.ItemContainerTransitions, v));
      Register<ItemsControl>(NProps.Items, (t, v) => AssignListT(t.Items, v));
      Register<ItemsControl>(NProps.ItemsPanel, ItemsControl.ItemsPanelProperty);
      Register<ItemsControl>(NProps.ItemsSource, ItemsControl.ItemsSourceProperty);
      Register<ItemsControl>(NProps.ItemTemplate, ItemsControl.ItemTemplateProperty, NConverters.ToDataTemplate);
      Register<ItemsControl>(NProps.ItemTemplateSelector, ItemsControl.ItemTemplateSelectorProperty);
    }

    void GenerateSelector()
    {
      Register<Selector>(NProps.IsSynchronizedWithCurrentItem, Selector.IsSynchronizedWithCurrentItemProperty, NConverters.ToBoolN);
      Register<Selector>(NProps.SelectedIndex, Selector.SelectedIndexProperty, NConverters.ToInt32);
      Register<Selector>(NProps.SelectedItem, Selector.SelectedItemProperty);
      Register<Selector>(NProps.SelectedValue, Selector.SelectedValueProperty);
      Register<Selector>(NProps.SelectedValuePath, Selector.SelectedValuePathProperty, NConverters.ToString);
      RegisterEvent<Selector>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
    }

    void GenerateListViewBase()
    {
      Register<ListViewBase>(NProps.CanDragItems, ListViewBase.CanDragItemsProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.CanReorderItems, ListViewBase.CanReorderItemsProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.DataFetchSize, ListViewBase.DataFetchSizeProperty, NConverters.ToDouble);
      Register<ListViewBase>(NProps.Footer, ListViewBase.FooterProperty);
      Register<ListViewBase>(NProps.FooterTemplate, ListViewBase.FooterTemplateProperty, NConverters.ToDataTemplate);
      Register<ListViewBase>(NProps.FooterTransitions, (t, v) => AssignListT(t.FooterTransitions, v));
      Register<ListViewBase>(NProps.Header, ListViewBase.HeaderProperty);
      Register<ListViewBase>(NProps.HeaderTemplate, ListViewBase.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<ListViewBase>(NProps.HeaderTransitions, (t, v) => AssignListT(t.HeaderTransitions, v));
      Register<ListViewBase>(NProps.IncrementalLoadingThreshold, ListViewBase.IncrementalLoadingThresholdProperty, NConverters.ToDouble);
      Register<ListViewBase>(NProps.IncrementalLoadingTrigger, ListViewBase.IncrementalLoadingTriggerProperty, NConverters.ToEnum<IncrementalLoadingTrigger>);
      Register<ListViewBase>(NProps.IsActiveView, ListViewBase.IsActiveViewProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.IsItemClickEnabled, ListViewBase.IsItemClickEnabledProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.IsMultiSelectCheckBoxEnabled, ListViewBase.IsMultiSelectCheckBoxEnabledProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.IsSwipeEnabled, ListViewBase.IsSwipeEnabledProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.IsZoomedInView, ListViewBase.IsZoomedInViewProperty, NConverters.ToBool);
      Register<ListViewBase>(NProps.ReorderMode, ListViewBase.ReorderModeProperty, NConverters.ToEnum<ListViewReorderMode>);
      Register<ListViewBase>(NProps.SelectionMode, ListViewBase.SelectionModeProperty, NConverters.ToEnum<ListViewSelectionMode>);
      Register<ListViewBase>(NProps.SemanticZoomOwner, ListViewBase.SemanticZoomOwnerProperty);
      Register<ListViewBase>(NProps.ShowsScrollingPlaceholders, ListViewBase.ShowsScrollingPlaceholdersProperty, NConverters.ToBool);
      RegisterEvent<ListViewBase>(NProps.DragItemsStarting, (s, a) => s.DragItemsStarting += a.EventHandlerAny);
      RegisterEvent<ListViewBase>(NProps.ItemClick, (s, a) => s.ItemClick += a.EventHandlerAny);
    }

    void GenerateComboBox()
    {
      Register<ComboBox>(NProps.Header, ComboBox.HeaderProperty);
      Register<ComboBox>(NProps.HeaderTemplate, ComboBox.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<ComboBox>(NProps.IsDropDownOpen, ComboBox.IsDropDownOpenProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.MaxDropDownHeight, ComboBox.MaxDropDownHeightProperty, NConverters.ToDouble);
      Register<ComboBox>(NProps.PlaceholderText, ComboBox.PlaceholderTextProperty, NConverters.ToString);
      RegisterEvent<ComboBox>(NProps.DropDownClosed, (s, a) => s.DropDownClosed += a.EventHandlerAny);
      RegisterEvent<ComboBox>(NProps.DropDownOpened, (s, a) => s.DropDownOpened += a.EventHandlerAny);
    }

    void GenerateFlipView()
    {
      Register<FlipView>(NProps.UseTouchAnimationsForAllNavigation, FlipView.UseTouchAnimationsForAllNavigationProperty, NConverters.ToBool);
    }

    void GenerateListBox()
    {
      Register<ListBox>(NProps.SelectionMode, ListBox.SelectionModeProperty, NConverters.ToEnum<SelectionMode>);
    }

    void GenerateAutoSuggestBox()
    {
      Register<AutoSuggestBox>(NProps.AutoMaximizeSuggestionArea, AutoSuggestBox.AutoMaximizeSuggestionAreaProperty, NConverters.ToBool);
      Register<AutoSuggestBox>(NProps.Header, AutoSuggestBox.HeaderProperty);
      Register<AutoSuggestBox>(NProps.IsSuggestionListOpen, AutoSuggestBox.IsSuggestionListOpenProperty, NConverters.ToBool);
      Register<AutoSuggestBox>(NProps.MaxSuggestionListHeight, AutoSuggestBox.MaxSuggestionListHeightProperty, NConverters.ToDouble);
      Register<AutoSuggestBox>(NProps.PlaceholderText, AutoSuggestBox.PlaceholderTextProperty, NConverters.ToString);
      Register<AutoSuggestBox>(NProps.QueryIcon, AutoSuggestBox.QueryIconProperty);
      Register<AutoSuggestBox>(NProps.Text, AutoSuggestBox.TextProperty, NConverters.ToString);
      Register<AutoSuggestBox>(NProps.TextBoxStyle, AutoSuggestBox.TextBoxStyleProperty, NConverters.ToStyle);
      Register<AutoSuggestBox>(NProps.TextMemberPath, AutoSuggestBox.TextMemberPathProperty, NConverters.ToString);
      Register<AutoSuggestBox>(NProps.UpdateTextOnSelect, AutoSuggestBox.UpdateTextOnSelectProperty, NConverters.ToBool);
    }

    void GeneratePivot()
    {
      Register<Pivot>(NProps.HeaderTemplate, Pivot.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<Pivot>(NProps.IsLocked, Pivot.IsLockedProperty, NConverters.ToBool);
      Register<Pivot>(NProps.LeftHeader, Pivot.LeftHeaderProperty);
      Register<Pivot>(NProps.LeftHeaderTemplate, Pivot.LeftHeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<Pivot>(NProps.RightHeader, Pivot.RightHeaderProperty);
      Register<Pivot>(NProps.RightHeaderTemplate, Pivot.RightHeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<Pivot>(NProps.SelectedIndex, Pivot.SelectedIndexProperty, NConverters.ToInt32);
      Register<Pivot>(NProps.SelectedItem, Pivot.SelectedItemProperty);
      Register<Pivot>(NProps.Title, Pivot.TitleProperty);
      Register<Pivot>(NProps.TitleTemplate, Pivot.TitleTemplateProperty, NConverters.ToDataTemplate);
      Register<FrameworkElement>(NProps.PivotSlideInAnimationGroup, Pivot.SlideInAnimationGroupProperty, NConverters.ToEnum<PivotSlideInAnimationGroup>);
      RegisterEvent<Pivot>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
    }

    void GenerateMediaTransportControls()
    {
      Register<MediaTransportControls>(NProps.IsCompact, MediaTransportControls.IsCompactProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFastForwardButtonVisible, MediaTransportControls.IsFastForwardButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFastForwardEnabled, MediaTransportControls.IsFastForwardEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFastRewindButtonVisible, MediaTransportControls.IsFastRewindButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFastRewindEnabled, MediaTransportControls.IsFastRewindEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFullWindowButtonVisible, MediaTransportControls.IsFullWindowButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsFullWindowEnabled, MediaTransportControls.IsFullWindowEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsPlaybackRateButtonVisible, MediaTransportControls.IsPlaybackRateButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsPlaybackRateEnabled, MediaTransportControls.IsPlaybackRateEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsSeekBarVisible, MediaTransportControls.IsSeekBarVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsSeekEnabled, MediaTransportControls.IsSeekEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsStopButtonVisible, MediaTransportControls.IsStopButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsStopEnabled, MediaTransportControls.IsStopEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsVolumeButtonVisible, MediaTransportControls.IsVolumeButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsVolumeEnabled, MediaTransportControls.IsVolumeEnabledProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsZoomButtonVisible, MediaTransportControls.IsZoomButtonVisibleProperty, NConverters.ToBool);
      Register<MediaTransportControls>(NProps.IsZoomEnabled, MediaTransportControls.IsZoomEnabledProperty, NConverters.ToBool);
    }

    void GeneratePasswordBox()
    {
      Register<PasswordBox>(NProps.Header, PasswordBox.HeaderProperty);
      Register<PasswordBox>(NProps.HeaderTemplate, PasswordBox.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<PasswordBox>(NProps.InputScope, PasswordBox.InputScopeProperty);
      Register<PasswordBox>(NProps.IsPasswordRevealButtonEnabled, PasswordBox.IsPasswordRevealButtonEnabledProperty, NConverters.ToBool);
      Register<PasswordBox>(NProps.MaxLength, PasswordBox.MaxLengthProperty, NConverters.ToInt32);
      Register<PasswordBox>(NProps.Password, PasswordBox.PasswordProperty, NConverters.ToString);
      Register<PasswordBox>(NProps.PasswordChar, PasswordBox.PasswordCharProperty, NConverters.ToString);
      Register<PasswordBox>(NProps.PasswordRevealMode, PasswordBox.PasswordRevealModeProperty, NConverters.ToEnum<PasswordRevealMode>);
      Register<PasswordBox>(NProps.PlaceholderText, PasswordBox.PlaceholderTextProperty, NConverters.ToString);
      Register<PasswordBox>(NProps.PreventKeyboardDisplayOnProgrammaticFocus, PasswordBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool);
      Register<PasswordBox>(NProps.SelectionHighlightColor, PasswordBox.SelectionHighlightColorProperty);
      Register<PasswordBox>(NProps.TextReadingOrder, PasswordBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);
      RegisterEvent<PasswordBox>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandlerAny);
      RegisterEvent<PasswordBox>(NProps.PasswordChanged, (s, a) => s.PasswordChanged += a.EventHandlerAny);
      RegisterEvent<PasswordBox>(NProps.Paste, (s, a) => s.Paste += a.EventHandlerAny);
    }

    void GenerateProgressRing()
    {
      Register<ProgressRing>(NProps.IsActive, ProgressRing.IsActiveProperty, NConverters.ToBool);
    }

    void GenerateRichEditBox()
    {
      Register<RichEditBox>(NProps.AcceptsReturn, RichEditBox.AcceptsReturnProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.ClipboardCopyFormat, RichEditBox.ClipboardCopyFormatProperty, NConverters.ToEnum<RichEditClipboardFormat>);
      Register<RichEditBox>(NProps.DesiredCandidateWindowAlignment, RichEditBox.DesiredCandidateWindowAlignmentProperty, NConverters.ToEnum<CandidateWindowAlignment>);
      Register<RichEditBox>(NProps.Header, RichEditBox.HeaderProperty);
      Register<RichEditBox>(NProps.HeaderTemplate, RichEditBox.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<RichEditBox>(NProps.InputScope, RichEditBox.InputScopeProperty);
      Register<RichEditBox>(NProps.IsColorFontEnabled, RichEditBox.IsColorFontEnabledProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.IsReadOnly, RichEditBox.IsReadOnlyProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.IsSpellCheckEnabled, RichEditBox.IsSpellCheckEnabledProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.IsTextPredictionEnabled, RichEditBox.IsTextPredictionEnabledProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.PlaceholderText, RichEditBox.PlaceholderTextProperty, NConverters.ToString);
      Register<RichEditBox>(NProps.PreventKeyboardDisplayOnProgrammaticFocus, RichEditBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool);
      Register<RichEditBox>(NProps.SelectionHighlightColor, RichEditBox.SelectionHighlightColorProperty);
      Register<RichEditBox>(NProps.TextAlignment, RichEditBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<RichEditBox>(NProps.TextReadingOrder, RichEditBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);
      Register<RichEditBox>(NProps.TextWrapping, RichEditBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      RegisterEvent<RichEditBox>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandlerAny);
      RegisterEvent<RichEditBox>(NProps.Paste, (s, a) => s.Paste += a.EventHandlerAny);
      RegisterEvent<RichEditBox>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
      RegisterEvent<RichEditBox>(NProps.TextChanged, (s, a) => s.TextChanged += a.EventHandlerAny);
    }

    void GenerateTextBox()
    {
      Register<TextBox>(NProps.AcceptsReturn, TextBox.AcceptsReturnProperty, NConverters.ToBool);
      Register<TextBox>(NProps.DesiredCandidateWindowAlignment, TextBox.DesiredCandidateWindowAlignmentProperty, NConverters.ToEnum<CandidateWindowAlignment>);
      Register<TextBox>(NProps.Header, TextBox.HeaderProperty);
      Register<TextBox>(NProps.HeaderTemplate, TextBox.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<TextBox>(NProps.InputScope, TextBox.InputScopeProperty);
      Register<TextBox>(NProps.IsColorFontEnabled, TextBox.IsColorFontEnabledProperty, NConverters.ToBool);
      Register<TextBox>(NProps.IsReadOnly, TextBox.IsReadOnlyProperty, NConverters.ToBool);
      Register<TextBox>(NProps.IsSpellCheckEnabled, TextBox.IsSpellCheckEnabledProperty, NConverters.ToBool);
      Register<TextBox>(NProps.IsTextPredictionEnabled, TextBox.IsTextPredictionEnabledProperty, NConverters.ToBool);
      Register<TextBox>(NProps.MaxLength, TextBox.MaxLengthProperty, NConverters.ToInt32);
      Register<TextBox>(NProps.PlaceholderText, TextBox.PlaceholderTextProperty, NConverters.ToString);
      Register<TextBox>(NProps.PreventKeyboardDisplayOnProgrammaticFocus, TextBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool);
      Register<TextBox>(NProps.SelectedText, (t, v) => t.SelectedText = NConverters.ToStringT(v));
      Register<TextBox>(NProps.SelectionHighlightColor, TextBox.SelectionHighlightColorProperty);
      Register<TextBox>(NProps.SelectionLength, (t, v) => t.SelectionLength = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.SelectionStart, (t, v) => t.SelectionStart = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.Text, TextBox.TextProperty, NConverters.ToString);
      Register<TextBox>(NProps.TextAlignment, TextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBox>(NProps.TextReadingOrder, TextBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);
      Register<TextBox>(NProps.TextWrapping, TextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      RegisterEvent<TextBox>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandlerAny);
      RegisterEvent<TextBox>(NProps.Paste, (s, a) => s.Paste += a.EventHandlerAny);
      RegisterEvent<TextBox>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
      RegisterEvent<TextBox>(NProps.TextChanged, (s, a) => s.TextChanged += a.EventHandlerAny);
    }

    void GenerateToggleSwitch()
    {
      Register<ToggleSwitch>(NProps.Header, ToggleSwitch.HeaderProperty);
      Register<ToggleSwitch>(NProps.HeaderTemplate, ToggleSwitch.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<ToggleSwitch>(NProps.IsOn, ToggleSwitch.IsOnProperty, NConverters.ToBool);
      Register<ToggleSwitch>(NProps.OffContent, ToggleSwitch.OffContentProperty);
      Register<ToggleSwitch>(NProps.OffContentTemplate, ToggleSwitch.OffContentTemplateProperty, NConverters.ToDataTemplate);
      Register<ToggleSwitch>(NProps.OnContent, ToggleSwitch.OnContentProperty);
      Register<ToggleSwitch>(NProps.OnContentTemplate, ToggleSwitch.OnContentTemplateProperty, NConverters.ToDataTemplate);
      RegisterEvent<ToggleSwitch>(NProps.Toggled, (s, a) => s.Toggled += a.EventHandlerAny);
    }

    void GenerateUserControl()
    {
      Register<UserControl>(NProps.Content, UserControl.ContentProperty);
    }

    void GeneratePage()
    {
      Register<Page>(NProps.BottomAppBar, Page.BottomAppBarProperty);
      Register<Page>(NProps.NavigationCacheMode, (t, v) => t.NavigationCacheMode = NConverters.ToEnumT<NavigationCacheMode>(v));
      Register<Page>(NProps.TopAppBar, Page.TopAppBarProperty);
    }

    void GenerateRangeBase()
    {
      Register<RangeBase>(NProps.LargeChange, RangeBase.LargeChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Maximum, RangeBase.MaximumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Minimum, RangeBase.MinimumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.SmallChange, RangeBase.SmallChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Value, RangeBase.ValueProperty, NConverters.ToDouble);
      RegisterEvent<RangeBase>(NProps.ValueChanged, (s, a) => s.ValueChanged += a.EventHandlerAny);
    }

    void GenerateProgressBar()
    {
      Register<ProgressBar>(NProps.IsIndeterminate, ProgressBar.IsIndeterminateProperty, NConverters.ToBool);
      Register<ProgressBar>(NProps.ShowError, ProgressBar.ShowErrorProperty, NConverters.ToBool);
      Register<ProgressBar>(NProps.ShowPaused, ProgressBar.ShowPausedProperty, NConverters.ToBool);
    }

    void GenerateSlider()
    {
      Register<Slider>(NProps.Header, Slider.HeaderProperty);
      Register<Slider>(NProps.HeaderTemplate, Slider.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<Slider>(NProps.IntermediateValue, Slider.IntermediateValueProperty, NConverters.ToDouble);
      Register<Slider>(NProps.IsDirectionReversed, Slider.IsDirectionReversedProperty, NConverters.ToBool);
      Register<Slider>(NProps.IsThumbToolTipEnabled, Slider.IsThumbToolTipEnabledProperty, NConverters.ToBool);
      Register<Slider>(NProps.Orientation, Slider.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<Slider>(NProps.SnapsTo, Slider.SnapsToProperty, NConverters.ToEnum<SliderSnapsTo>);
      Register<Slider>(NProps.StepFrequency, Slider.StepFrequencyProperty, NConverters.ToDouble);
      Register<Slider>(NProps.ThumbToolTipValueConverter, Slider.ThumbToolTipValueConverterProperty);
      Register<Slider>(NProps.TickFrequency, Slider.TickFrequencyProperty, NConverters.ToDouble);
      Register<Slider>(NProps.TickPlacement, Slider.TickPlacementProperty, NConverters.ToEnum<TickPlacement>);
    }

    void GenerateScrollBar()
    {
      Register<ScrollBar>(NProps.IndicatorMode, ScrollBar.IndicatorModeProperty, NConverters.ToEnum<ScrollingIndicatorMode>);
      Register<ScrollBar>(NProps.Orientation, ScrollBar.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<ScrollBar>(NProps.ViewportSize, ScrollBar.ViewportSizeProperty, NConverters.ToDouble);
      RegisterEvent<ScrollBar>(NProps.Scroll, (s, a) => s.Scroll += a.EventHandlerAny);
    }

    void GenerateThumb()
    {
      RegisterEvent<Thumb>(NProps.DragCompleted, (s, a) => s.DragCompleted += a.EventHandlerAny);
      RegisterEvent<Thumb>(NProps.DragDelta, (s, a) => s.DragDelta += a.EventHandlerAny);
      RegisterEvent<Thumb>(NProps.DragStarted, (s, a) => s.DragStarted += a.EventHandlerAny);
    }

    void GenerateCalendarView()
    {
      Register<CalendarView>(NProps.BlackoutForeground, (t, v) => t.BlackoutForeground = NConverters.ToBrushT(v, t.BlackoutForeground));
      Register<CalendarView>(NProps.CalendarIdentifier, CalendarView.CalendarIdentifierProperty, NConverters.ToString);
      Register<CalendarView>(NProps.CalendarItemBackground, (t, v) => t.CalendarItemBackground = NConverters.ToBrushT(v, t.CalendarItemBackground));
      Register<CalendarView>(NProps.CalendarItemBorderBrush, (t, v) => t.CalendarItemBorderBrush = NConverters.ToBrushT(v, t.CalendarItemBorderBrush));
      Register<CalendarView>(NProps.CalendarItemBorderThickness, CalendarView.CalendarItemBorderThicknessProperty, NConverters.ToThickness);
      Register<CalendarView>(NProps.CalendarItemForeground, (t, v) => t.CalendarItemForeground = NConverters.ToBrushT(v, t.CalendarItemForeground));
      Register<CalendarView>(NProps.CalendarViewDayItemStyle, CalendarView.CalendarViewDayItemStyleProperty, NConverters.ToStyle);
      Register<CalendarView>(NProps.DayItemFontFamily, CalendarView.DayItemFontFamilyProperty, NConverters.ToFontFamily);
      Register<CalendarView>(NProps.DayItemFontSize, CalendarView.DayItemFontSizeProperty, NConverters.ToDouble);
      Register<CalendarView>(NProps.DayItemFontStyle, CalendarView.DayItemFontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<CalendarView>(NProps.DayItemFontWeight, CalendarView.DayItemFontWeightProperty, NConverters.ToFontWeight);
      Register<CalendarView>(NProps.DayOfWeekFormat, CalendarView.DayOfWeekFormatProperty, NConverters.ToString);
      Register<CalendarView>(NProps.DisplayMode, CalendarView.DisplayModeProperty, NConverters.ToEnum<CalendarViewDisplayMode>);
      Register<CalendarView>(NProps.FirstDayOfWeek, CalendarView.FirstDayOfWeekProperty, NConverters.ToEnum<WGDayOfWeek>);
      Register<CalendarView>(NProps.FirstOfMonthLabelFontFamily, CalendarView.FirstOfMonthLabelFontFamilyProperty, NConverters.ToFontFamily);
      Register<CalendarView>(NProps.FirstOfMonthLabelFontSize, CalendarView.FirstOfMonthLabelFontSizeProperty, NConverters.ToDouble);
      Register<CalendarView>(NProps.FirstOfMonthLabelFontStyle, CalendarView.FirstOfMonthLabelFontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<CalendarView>(NProps.FirstOfMonthLabelFontWeight, CalendarView.FirstOfMonthLabelFontWeightProperty, NConverters.ToFontWeight);
      Register<CalendarView>(NProps.FirstOfYearDecadeLabelFontFamily, CalendarView.FirstOfYearDecadeLabelFontFamilyProperty, NConverters.ToFontFamily);
      Register<CalendarView>(NProps.FirstOfYearDecadeLabelFontSize, CalendarView.FirstOfYearDecadeLabelFontSizeProperty, NConverters.ToDouble);
      Register<CalendarView>(NProps.FirstOfYearDecadeLabelFontStyle, CalendarView.FirstOfYearDecadeLabelFontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<CalendarView>(NProps.FirstOfYearDecadeLabelFontWeight, CalendarView.FirstOfYearDecadeLabelFontWeightProperty, NConverters.ToFontWeight);
      Register<CalendarView>(NProps.FocusBorderBrush, (t, v) => t.FocusBorderBrush = NConverters.ToBrushT(v, t.FocusBorderBrush));
      Register<CalendarView>(NProps.HorizontalDayItemAlignment, CalendarView.HorizontalDayItemAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<CalendarView>(NProps.HorizontalFirstOfMonthLabelAlignment, CalendarView.HorizontalFirstOfMonthLabelAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<CalendarView>(NProps.HoverBorderBrush, (t, v) => t.HoverBorderBrush = NConverters.ToBrushT(v, t.HoverBorderBrush));
      Register<CalendarView>(NProps.IsGroupLabelVisible, CalendarView.IsGroupLabelVisibleProperty, NConverters.ToBool);
      Register<CalendarView>(NProps.IsOutOfScopeEnabled, CalendarView.IsOutOfScopeEnabledProperty, NConverters.ToBool);
      Register<CalendarView>(NProps.IsTodayHighlighted, CalendarView.IsTodayHighlightedProperty, NConverters.ToBool);
      Register<CalendarView>(NProps.MaxDate, CalendarView.MaxDateProperty, NConverters.ToDateTimeOffset);
      Register<CalendarView>(NProps.MinDate, CalendarView.MinDateProperty, NConverters.ToDateTimeOffset);
      Register<CalendarView>(NProps.MonthYearItemFontFamily, CalendarView.MonthYearItemFontFamilyProperty, NConverters.ToFontFamily);
      Register<CalendarView>(NProps.MonthYearItemFontSize, CalendarView.MonthYearItemFontSizeProperty, NConverters.ToDouble);
      Register<CalendarView>(NProps.MonthYearItemFontStyle, CalendarView.MonthYearItemFontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<CalendarView>(NProps.MonthYearItemFontWeight, CalendarView.MonthYearItemFontWeightProperty, NConverters.ToFontWeight);
      Register<CalendarView>(NProps.NumberOfWeeksInView, CalendarView.NumberOfWeeksInViewProperty, NConverters.ToInt32);
      Register<CalendarView>(NProps.OutOfScopeBackground, (t, v) => t.OutOfScopeBackground = NConverters.ToBrushT(v, t.OutOfScopeBackground));
      Register<CalendarView>(NProps.OutOfScopeForeground, (t, v) => t.OutOfScopeForeground = NConverters.ToBrushT(v, t.OutOfScopeForeground));
      Register<CalendarView>(NProps.PressedBorderBrush, (t, v) => t.PressedBorderBrush = NConverters.ToBrushT(v, t.PressedBorderBrush));
      Register<CalendarView>(NProps.PressedForeground, (t, v) => t.PressedForeground = NConverters.ToBrushT(v, t.PressedForeground));
      Register<CalendarView>(NProps.SelectedBorderBrush, (t, v) => t.SelectedBorderBrush = NConverters.ToBrushT(v, t.SelectedBorderBrush));
      Register<CalendarView>(NProps.SelectedForeground, (t, v) => t.SelectedForeground = NConverters.ToBrushT(v, t.SelectedForeground));
      Register<CalendarView>(NProps.SelectedHoverBorderBrush, (t, v) => t.SelectedHoverBorderBrush = NConverters.ToBrushT(v, t.SelectedHoverBorderBrush));
      Register<CalendarView>(NProps.SelectedPressedBorderBrush, (t, v) => t.SelectedPressedBorderBrush = NConverters.ToBrushT(v, t.SelectedPressedBorderBrush));
      Register<CalendarView>(NProps.SelectionMode, CalendarView.SelectionModeProperty, NConverters.ToEnum<CalendarViewSelectionMode>);
      Register<CalendarView>(NProps.TodayFontWeight, CalendarView.TodayFontWeightProperty, NConverters.ToFontWeight);
      Register<CalendarView>(NProps.TodayForeground, (t, v) => t.TodayForeground = NConverters.ToBrushT(v, t.TodayForeground));
      Register<CalendarView>(NProps.VerticalDayItemAlignment, CalendarView.VerticalDayItemAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<CalendarView>(NProps.VerticalFirstOfMonthLabelAlignment, CalendarView.VerticalFirstOfMonthLabelAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
    }

    void GenerateCalendarViewDayItem()
    {
      Register<CalendarViewDayItem>(NProps.IsBlackout, CalendarViewDayItem.IsBlackoutProperty, NConverters.ToBool);
    }

    void GenerateHubSection()
    {
      Register<HubSection>(NProps.ContentTemplate, HubSection.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<HubSection>(NProps.Header, HubSection.HeaderProperty);
      Register<HubSection>(NProps.HeaderTemplate, HubSection.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<HubSection>(NProps.IsHeaderInteractive, HubSection.IsHeaderInteractiveProperty, NConverters.ToBool);
    }

    void GenerateMenuFlyoutItem()
    {
      Register<MenuFlyoutItem>(NProps.Command, MenuFlyoutItem.CommandProperty);
      Register<MenuFlyoutItem>(NProps.CommandParameter, MenuFlyoutItem.CommandParameterProperty);
      Register<MenuFlyoutItem>(NProps.Text, MenuFlyoutItem.TextProperty, NConverters.ToString);
      RegisterEvent<MenuFlyoutItem>(NProps.Click, (s, a) => s.Click += a.EventHandlerAny);
    }

    void GenerateToggleMenuFlyoutItem()
    {
      Register<ToggleMenuFlyoutItem>(NProps.IsChecked, ToggleMenuFlyoutItem.IsCheckedProperty, NConverters.ToBool);
    }

    void GenerateMenuFlyoutSubItem()
    {
      Register<MenuFlyoutSubItem>(NProps.Text, MenuFlyoutSubItem.TextProperty, NConverters.ToString);
    }

    void GenerateAppBarSeparator()
    {
      Register<AppBarSeparator>(NProps.IsCompact, AppBarSeparator.IsCompactProperty, NConverters.ToBool);
    }

    void GenerateCalendarDatePicker()
    {
      Register<CalendarDatePicker>(NProps.CalendarIdentifier, CalendarDatePicker.CalendarIdentifierProperty, NConverters.ToString);
      Register<CalendarDatePicker>(NProps.CalendarViewStyle, CalendarDatePicker.CalendarViewStyleProperty, NConverters.ToStyle);
      Register<CalendarDatePicker>(NProps.Date, CalendarDatePicker.DateProperty, NConverters.ToDateTimeOffsetN);
      Register<CalendarDatePicker>(NProps.DateFormat, CalendarDatePicker.DateFormatProperty, NConverters.ToString);
      Register<CalendarDatePicker>(NProps.DayOfWeekFormat, CalendarDatePicker.DayOfWeekFormatProperty, NConverters.ToString);
      Register<CalendarDatePicker>(NProps.DisplayMode, CalendarDatePicker.DisplayModeProperty, NConverters.ToEnum<CalendarViewDisplayMode>);
      Register<CalendarDatePicker>(NProps.FirstDayOfWeek, CalendarDatePicker.FirstDayOfWeekProperty, NConverters.ToEnum<WGDayOfWeek>);
      Register<CalendarDatePicker>(NProps.Header, CalendarDatePicker.HeaderProperty);
      Register<CalendarDatePicker>(NProps.HeaderTemplate, CalendarDatePicker.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<CalendarDatePicker>(NProps.IsCalendarOpen, CalendarDatePicker.IsCalendarOpenProperty, NConverters.ToBool);
      Register<CalendarDatePicker>(NProps.IsGroupLabelVisible, CalendarDatePicker.IsGroupLabelVisibleProperty, NConverters.ToBool);
      Register<CalendarDatePicker>(NProps.IsOutOfScopeEnabled, CalendarDatePicker.IsOutOfScopeEnabledProperty, NConverters.ToBool);
      Register<CalendarDatePicker>(NProps.IsTodayHighlighted, CalendarDatePicker.IsTodayHighlightedProperty, NConverters.ToBool);
      Register<CalendarDatePicker>(NProps.MaxDate, CalendarDatePicker.MaxDateProperty, NConverters.ToDateTimeOffset);
      Register<CalendarDatePicker>(NProps.MinDate, CalendarDatePicker.MinDateProperty, NConverters.ToDateTimeOffset);
      Register<CalendarDatePicker>(NProps.PlaceholderText, CalendarDatePicker.PlaceholderTextProperty, NConverters.ToString);
      RegisterEvent<CalendarDatePicker>(NProps.Closed, (s, a) => s.Closed += a.EventHandlerAny);
      RegisterEvent<CalendarDatePicker>(NProps.Opened, (s, a) => s.Opened += a.EventHandlerAny);
    }

    void GenerateDatePicker()
    {
      Register<DatePicker>(NProps.CalendarIdentifier, DatePicker.CalendarIdentifierProperty, NConverters.ToString);
      Register<DatePicker>(NProps.Date, DatePicker.DateProperty, NConverters.ToDateTimeOffset);
      Register<DatePicker>(NProps.DayFormat, DatePicker.DayFormatProperty, NConverters.ToString);
      Register<DatePicker>(NProps.DayVisible, DatePicker.DayVisibleProperty, NConverters.ToBool);
      Register<DatePicker>(NProps.Header, DatePicker.HeaderProperty);
      Register<DatePicker>(NProps.HeaderTemplate, DatePicker.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<DatePicker>(NProps.MaxYear, DatePicker.MaxYearProperty, NConverters.ToDateTimeOffset);
      Register<DatePicker>(NProps.MinYear, DatePicker.MinYearProperty, NConverters.ToDateTimeOffset);
      Register<DatePicker>(NProps.MonthFormat, DatePicker.MonthFormatProperty, NConverters.ToString);
      Register<DatePicker>(NProps.MonthVisible, DatePicker.MonthVisibleProperty, NConverters.ToBool);
      Register<DatePicker>(NProps.Orientation, DatePicker.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<DatePicker>(NProps.YearFormat, DatePicker.YearFormatProperty, NConverters.ToString);
      Register<DatePicker>(NProps.YearVisible, DatePicker.YearVisibleProperty, NConverters.ToBool);
      RegisterEvent<DatePicker>(NProps.DateChanged, (s, a) => s.DateChanged += a.EventHandlerAny);
    }

    void GenerateHub()
    {
      Register<Hub>(NProps.DefaultSectionIndex, Hub.DefaultSectionIndexProperty, NConverters.ToInt32);
      Register<Hub>(NProps.Header, Hub.HeaderProperty);
      Register<Hub>(NProps.HeaderTemplate, Hub.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<Hub>(NProps.IsActiveView, Hub.IsActiveViewProperty, NConverters.ToBool);
      Register<Hub>(NProps.IsZoomedInView, Hub.IsZoomedInViewProperty, NConverters.ToBool);
      Register<Hub>(NProps.Orientation, Hub.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<Hub>(NProps.SectionHeaders, (t, v) => AssignListT(t.SectionHeaders, v));
      Register<Hub>(NProps.SemanticZoomOwner, Hub.SemanticZoomOwnerProperty);
      RegisterEvent<Hub>(NProps.SectionHeaderClick, (s, a) => s.SectionHeaderClick += a.EventHandlerAny);
      RegisterEvent<Hub>(NProps.SectionsInViewChanged, (s, a) => s.SectionsInViewChanged += a.EventHandlerAny);
    }

    void GenerateSearchBox()
    {
      Register<SearchBox>(NProps.ChooseSuggestionOnEnter, SearchBox.ChooseSuggestionOnEnterProperty, NConverters.ToBool);
      Register<SearchBox>(NProps.FocusOnKeyboardInput, SearchBox.FocusOnKeyboardInputProperty, NConverters.ToBool);
      Register<SearchBox>(NProps.PlaceholderText, SearchBox.PlaceholderTextProperty, NConverters.ToString);
      Register<SearchBox>(NProps.QueryText, SearchBox.QueryTextProperty, NConverters.ToString);
      Register<SearchBox>(NProps.SearchHistoryContext, SearchBox.SearchHistoryContextProperty, NConverters.ToString);
      Register<SearchBox>(NProps.SearchHistoryEnabled, SearchBox.SearchHistoryEnabledProperty, NConverters.ToBool);
    }

    void GenerateSplitView()
    {
      Register<SplitView>(NProps.CompactPaneLength, SplitView.CompactPaneLengthProperty, NConverters.ToDouble);
      Register<SplitView>(NProps.Content, SplitView.ContentProperty);
      Register<SplitView>(NProps.DisplayMode, SplitView.DisplayModeProperty, NConverters.ToEnum<SplitViewDisplayMode>);
      Register<SplitView>(NProps.IsPaneOpen, SplitView.IsPaneOpenProperty, NConverters.ToBool);
      Register<SplitView>(NProps.OpenPaneLength, SplitView.OpenPaneLengthProperty, NConverters.ToDouble);
      Register<SplitView>(NProps.Pane, SplitView.PaneProperty);
      Register<SplitView>(NProps.PaneBackground, (t, v) => t.PaneBackground = NConverters.ToBrushT(v, t.PaneBackground));
      Register<SplitView>(NProps.PanePlacement, SplitView.PanePlacementProperty, NConverters.ToEnum<SplitViewPanePlacement>);
    }

    void GenerateTimePicker()
    {
      Register<TimePicker>(NProps.ClockIdentifier, TimePicker.ClockIdentifierProperty, NConverters.ToString);
      Register<TimePicker>(NProps.Header, TimePicker.HeaderProperty);
      Register<TimePicker>(NProps.HeaderTemplate, TimePicker.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<TimePicker>(NProps.MinuteIncrement, TimePicker.MinuteIncrementProperty, NConverters.ToInt32);
      Register<TimePicker>(NProps.Time, TimePicker.TimeProperty, NConverters.ToTimeSpan);
      RegisterEvent<TimePicker>(NProps.TimeChanged, (s, a) => s.TimeChanged += a.EventHandlerAny);
    }

    void GenerateMapControl()
    {
      Register<MapControl>(NProps.BusinessLandmarksVisible, MapControl.BusinessLandmarksVisibleProperty, NConverters.ToBool);
      Register<MapControl>(NProps.Center, MapControl.CenterProperty);
      Register<MapControl>(NProps.ColorScheme, MapControl.ColorSchemeProperty, NConverters.ToEnum<MapColorScheme>);
//      Register<MapControl>(NProps.CustomExperience);
      Register<MapControl>(NProps.DesiredPitch, MapControl.DesiredPitchProperty, NConverters.ToDouble);
      Register<MapControl>(NProps.Heading, MapControl.HeadingProperty, NConverters.ToDouble);
      Register<MapControl>(NProps.LandmarksVisible, MapControl.LandmarksVisibleProperty, NConverters.ToBool);
      Register<MapControl>(NProps.MapServiceToken, MapControl.MapServiceTokenProperty, NConverters.ToString);
      Register<MapControl>(NProps.PanInteractionMode, MapControl.PanInteractionModeProperty, NConverters.ToEnum<MapPanInteractionMode>);
      Register<MapControl>(NProps.PedestrianFeaturesVisible, MapControl.PedestrianFeaturesVisibleProperty, NConverters.ToBool);
      Register<MapControl>(NProps.RotateInteractionMode, MapControl.RotateInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);
      Register<MapControl>(NProps.Scene, MapControl.SceneProperty);
      Register<MapControl>(NProps.Style, MapControl.StyleProperty, NConverters.ToEnum<MapStyle>);
      Register<MapControl>(NProps.TiltInteractionMode, MapControl.TiltInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);
      Register<MapControl>(NProps.TrafficFlowVisible, MapControl.TrafficFlowVisibleProperty, NConverters.ToBool);
      Register<MapControl>(NProps.TransformOrigin, MapControl.TransformOriginProperty, NConverters.ToPoint);
      Register<MapControl>(NProps.TransitFeaturesVisible, MapControl.TransitFeaturesVisibleProperty, NConverters.ToBool);
      Register<MapControl>(NProps.WatermarkMode, MapControl.WatermarkModeProperty, NConverters.ToEnum<MapWatermarkMode>);
      Register<MapControl>(NProps.ZoomInteractionMode, MapControl.ZoomInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);
      Register<MapControl>(NProps.ZoomLevel, MapControl.ZoomLevelProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.MapControlLocation, MapControl.LocationProperty);
      Register<DependencyObject>(NProps.MapControlNormalizedAnchorPoint, MapControl.NormalizedAnchorPointProperty, NConverters.ToPoint);
    }

    void GenerateLoopingSelector()
    {
      Register<LoopingSelector>(NProps.ItemHeight, LoopingSelector.ItemHeightProperty, NConverters.ToInt32);
      Register<LoopingSelector>(NProps.Items, LoopingSelector.ItemsProperty);
      Register<LoopingSelector>(NProps.ItemTemplate, LoopingSelector.ItemTemplateProperty, NConverters.ToDataTemplate);
      Register<LoopingSelector>(NProps.ItemWidth, LoopingSelector.ItemWidthProperty, NConverters.ToInt32);
      Register<LoopingSelector>(NProps.SelectedIndex, LoopingSelector.SelectedIndexProperty, NConverters.ToInt32);
      Register<LoopingSelector>(NProps.SelectedItem, LoopingSelector.SelectedItemProperty);
      Register<LoopingSelector>(NProps.ShouldLoop, LoopingSelector.ShouldLoopProperty, NConverters.ToBool);
      RegisterEvent<LoopingSelector>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandlerAny);
    }

    void GenerateTextElement()
    {
      Register<TextElement>(NProps.CharacterSpacing, TextElement.CharacterSpacingProperty, NConverters.ToInt32);
      Register<TextElement>(NProps.FontFamily, TextElement.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextElement>(NProps.FontSize, TextElement.FontSizeProperty, NConverters.ToDouble);
      Register<TextElement>(NProps.FontStretch, TextElement.FontStretchProperty, NConverters.ToEnum<FontStretch>);
      Register<TextElement>(NProps.FontStyle, TextElement.FontStyleProperty, NConverters.ToEnum<FontStyle>);
      Register<TextElement>(NProps.FontWeight, TextElement.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextElement>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextElement>(NProps.IsTextScaleFactorEnabled, TextElement.IsTextScaleFactorEnabledProperty, NConverters.ToBool);
      Register<TextElement>(NProps.Language, TextElement.LanguageProperty, NConverters.ToString);
    }

    void GenerateBlock()
    {
      Register<Block>(NProps.LineHeight, Block.LineHeightProperty, NConverters.ToDouble);
      Register<Block>(NProps.LineStackingStrategy, Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<Block>(NProps.Margin, Block.MarginProperty, NConverters.ToThickness);
      Register<Block>(NProps.TextAlignment, Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateParagraph()
    {
      Register<Paragraph>(NProps.Inlines, (t, v) => AssignListT(t.Inlines, v));
      Register<Paragraph>(NProps.TextIndent, Paragraph.TextIndentProperty, NConverters.ToDouble);
    }

    void GenerateInlineUIContainer()
    {
      Register<InlineUIContainer>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
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
      Register<Hyperlink>(NProps.NavigateUri, Hyperlink.NavigateUriProperty, NConverters.ToUri);
      Register<Hyperlink>(NProps.UnderlineStyle, Hyperlink.UnderlineStyleProperty, NConverters.ToEnum<UnderlineStyle>);
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
      Register<DependencyObject>(NProps.ToolTipServicePlacement, ToolTipService.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<DependencyObject>(NProps.ToolTipServicePlacementTarget, ToolTipService.PlacementTargetProperty);
      Register<DependencyObject>(NProps.ToolTipServiceToolTip, ToolTipService.ToolTipProperty);
    }
  }

  public partial class NProps
  {
    public static readonly int _DoubleTapped = Store["_DoubleTapped"];
    public static readonly int _DragEnter = Store["_DragEnter"];
    public static readonly int _DragLeave = Store["_DragLeave"];
    public static readonly int _DragOver = Store["_DragOver"];
    public static readonly int _Drop = Store["_Drop"];
    public static readonly int _Holding = Store["_Holding"];
    public static readonly int _KeyDown = Store["_KeyDown"];
    public static readonly int _KeyUp = Store["_KeyUp"];
    public static readonly int _ManipulationCompleted = Store["_ManipulationCompleted"];
    public static readonly int _ManipulationDelta = Store["_ManipulationDelta"];
    public static readonly int _ManipulationInertiaStarting = Store["_ManipulationInertiaStarting"];
    public static readonly int _ManipulationStarted = Store["_ManipulationStarted"];
    public static readonly int _ManipulationStarting = Store["_ManipulationStarting"];
    public static readonly int _PointerCanceled = Store["_PointerCanceled"];
    public static readonly int _PointerCaptureLost = Store["_PointerCaptureLost"];
    public static readonly int _PointerEntered = Store["_PointerEntered"];
    public static readonly int _PointerExited = Store["_PointerExited"];
    public static readonly int _PointerMoved = Store["_PointerMoved"];
    public static readonly int _PointerPressed = Store["_PointerPressed"];
    public static readonly int _PointerReleased = Store["_PointerReleased"];
    public static readonly int _PointerWheelChanged = Store["_PointerWheelChanged"];
    public static readonly int _RightTapped = Store["_RightTapped"];
    public static readonly int _Tapped = Store["_Tapped"];
    public static readonly int AcceptsReturn = Store["AcceptsReturn"];
    public static readonly int AllowDrop = Store["AllowDrop"];
    public static readonly int AllowedScriptNotifyUris = Store["AllowedScriptNotifyUris"];
    public static readonly int AreScrollSnapPointsRegular = Store["AreScrollSnapPointsRegular"];
    public static readonly int AreStickyGroupHeadersEnabled = Store["AreStickyGroupHeadersEnabled"];
    public static readonly int AreTransportControlsEnabled = Store["AreTransportControlsEnabled"];
    public static readonly int AudioCategory = Store["AudioCategory"];
    public static readonly int AudioDeviceType = Store["AudioDeviceType"];
    public static readonly int AudioStreamIndex = Store["AudioStreamIndex"];
    public static readonly int AutoMaximizeSuggestionArea = Store["AutoMaximizeSuggestionArea"];
    public static readonly int AutoPlay = Store["AutoPlay"];
    public static readonly int BackClick = Store["BackClick"];
    public static readonly int Background = Store["Background"];
    public static readonly int Balance = Store["Balance"];
    public static readonly int BlackoutForeground = Store["BlackoutForeground"];
    public static readonly int BorderBrush = Store["BorderBrush"];
    public static readonly int BorderThickness = Store["BorderThickness"];
    public static readonly int BottomAppBar = Store["BottomAppBar"];
    public static readonly int BringIntoViewOnFocusChange = Store["BringIntoViewOnFocusChange"];
    public static readonly int BufferingProgressChanged = Store["BufferingProgressChanged"];
    public static readonly int BusinessLandmarksVisible = Store["BusinessLandmarksVisible"];
    public static readonly int CacheLength = Store["CacheLength"];
    public static readonly int CacheMode = Store["CacheMode"];
    public static readonly int CacheSize = Store["CacheSize"];
    public static readonly int CalendarIdentifier = Store["CalendarIdentifier"];
    public static readonly int CalendarItemBackground = Store["CalendarItemBackground"];
    public static readonly int CalendarItemBorderBrush = Store["CalendarItemBorderBrush"];
    public static readonly int CalendarItemBorderThickness = Store["CalendarItemBorderThickness"];
    public static readonly int CalendarItemForeground = Store["CalendarItemForeground"];
    public static readonly int CalendarViewDayItemStyle = Store["CalendarViewDayItemStyle"];
    public static readonly int CalendarViewStyle = Store["CalendarViewStyle"];
    public static readonly int CanChangeViews = Store["CanChangeViews"];
    public static readonly int CanDrag = Store["CanDrag"];
    public static readonly int CanDragItems = Store["CanDragItems"];
    public static readonly int CanHorizontallyScroll = Store["CanHorizontallyScroll"];
    public static readonly int CanReorderItems = Store["CanReorderItems"];
    public static readonly int CanvasLeft = Store["CanvasLeft"];
    public static readonly int CanvasTop = Store["CanvasTop"];
    public static readonly int CanvasZIndex = Store["CanvasZIndex"];
    public static readonly int CanVerticallyScroll = Store["CanVerticallyScroll"];
    public static readonly int Center = Store["Center"];
    public static readonly int CharacterSpacing = Store["CharacterSpacing"];
    public static readonly int CheckBoxBrush = Store["CheckBoxBrush"];
    public static readonly int CheckBrush = Store["CheckBrush"];
    public static readonly int Checked = Store["Checked"];
    public static readonly int CheckHintBrush = Store["CheckHintBrush"];
    public static readonly int CheckMode = Store["CheckMode"];
    public static readonly int CheckSelectingBrush = Store["CheckSelectingBrush"];
    public static readonly int Child = Store["Child"];
    public static readonly int ChildrenTransitions = Store["ChildrenTransitions"];
    public static readonly int ChildTransitions = Store["ChildTransitions"];
    public static readonly int ChooseSuggestionOnEnter = Store["ChooseSuggestionOnEnter"];
    public static readonly int CleanUpVirtualizedItemEvent = Store["CleanUpVirtualizedItemEvent"];
    public static readonly int Click = Store["Click"];
    public static readonly int ClickMode = Store["ClickMode"];
    public static readonly int Clip = Store["Clip"];
    public static readonly int ClipboardCopyFormat = Store["ClipboardCopyFormat"];
    public static readonly int ClockIdentifier = Store["ClockIdentifier"];
    public static readonly int Closed = Store["Closed"];
    public static readonly int ClosedDisplayMode = Store["ClosedDisplayMode"];
    public static readonly int Closing = Store["Closing"];
    public static readonly int ColorFontPaletteIndex = Store["ColorFontPaletteIndex"];
    public static readonly int ColorScheme = Store["ColorScheme"];
    public static readonly int Command = Store["Command"];
    public static readonly int CommandBarOverflowPresenterStyle = Store["CommandBarOverflowPresenterStyle"];
    public static readonly int CommandParameter = Store["CommandParameter"];
    public static readonly int CompactPaneLength = Store["CompactPaneLength"];
    public static readonly int CompositeMode = Store["CompositeMode"];
    public static readonly int Content = Store["Content"];
    public static readonly int ContentMargin = Store["ContentMargin"];
    public static readonly int ContentTemplate = Store["ContentTemplate"];
    public static readonly int ContentTemplateSelector = Store["ContentTemplateSelector"];
    public static readonly int ContentTransitions = Store["ContentTransitions"];
    public static readonly int ContextMenuOpening = Store["ContextMenuOpening"];
    public static readonly int ControlIsTemplateFocusTarget = Store["ControlIsTemplateFocusTarget"];
    public static readonly int CornerRadius = Store["CornerRadius"];
    public static readonly int CurrentStateChanged = Store["CurrentStateChanged"];
    public static readonly int CustomExperience = Store["CustomExperience"];
    public static readonly int Data = Store["Data"];
    public static readonly int DataContext = Store["DataContext"];
    public static readonly int DataFetchSize = Store["DataFetchSize"];
    public static readonly int Date = Store["Date"];
    public static readonly int DateChanged = Store["DateChanged"];
    public static readonly int DateFormat = Store["DateFormat"];
    public static readonly int DayFormat = Store["DayFormat"];
    public static readonly int DayItemFontFamily = Store["DayItemFontFamily"];
    public static readonly int DayItemFontSize = Store["DayItemFontSize"];
    public static readonly int DayItemFontStyle = Store["DayItemFontStyle"];
    public static readonly int DayItemFontWeight = Store["DayItemFontWeight"];
    public static readonly int DayOfWeekFormat = Store["DayOfWeekFormat"];
    public static readonly int DayVisible = Store["DayVisible"];
    public static readonly int DefaultBackgroundColor = Store["DefaultBackgroundColor"];
    public static readonly int DefaultPlaybackRate = Store["DefaultPlaybackRate"];
    public static readonly int DefaultSectionIndex = Store["DefaultSectionIndex"];
    public static readonly int Delay = Store["Delay"];
    public static readonly int DesiredCandidateWindowAlignment = Store["DesiredCandidateWindowAlignment"];
    public static readonly int DesiredPitch = Store["DesiredPitch"];
    public static readonly int DirectManipulationCompleted = Store["DirectManipulationCompleted"];
    public static readonly int DirectManipulationStarted = Store["DirectManipulationStarted"];
    public static readonly int DisabledOpacity = Store["DisabledOpacity"];
    public static readonly int DisplayMemberPath = Store["DisplayMemberPath"];
    public static readonly int DisplayMode = Store["DisplayMode"];
    public static readonly int DoubleTapped = Store["DoubleTapped"];
    public static readonly int DownloadProgressChanged = Store["DownloadProgressChanged"];
    public static readonly int DragBackground = Store["DragBackground"];
    public static readonly int DragCompleted = Store["DragCompleted"];
    public static readonly int DragDelta = Store["DragDelta"];
    public static readonly int DragEnter = Store["DragEnter"];
    public static readonly int DragForeground = Store["DragForeground"];
    public static readonly int DragItemsStarting = Store["DragItemsStarting"];
    public static readonly int DragLeave = Store["DragLeave"];
    public static readonly int DragOpacity = Store["DragOpacity"];
    public static readonly int DragOver = Store["DragOver"];
    public static readonly int DragStarted = Store["DragStarted"];
    public static readonly int Drop = Store["Drop"];
    public static readonly int DropDownClosed = Store["DropDownClosed"];
    public static readonly int DropDownOpened = Store["DropDownOpened"];
    public static readonly int Fill = Store["Fill"];
    public static readonly int FillRule = Store["FillRule"];
    public static readonly int FirstDayOfWeek = Store["FirstDayOfWeek"];
    public static readonly int FirstOfMonthLabelFontFamily = Store["FirstOfMonthLabelFontFamily"];
    public static readonly int FirstOfMonthLabelFontSize = Store["FirstOfMonthLabelFontSize"];
    public static readonly int FirstOfMonthLabelFontStyle = Store["FirstOfMonthLabelFontStyle"];
    public static readonly int FirstOfMonthLabelFontWeight = Store["FirstOfMonthLabelFontWeight"];
    public static readonly int FirstOfYearDecadeLabelFontFamily = Store["FirstOfYearDecadeLabelFontFamily"];
    public static readonly int FirstOfYearDecadeLabelFontSize = Store["FirstOfYearDecadeLabelFontSize"];
    public static readonly int FirstOfYearDecadeLabelFontStyle = Store["FirstOfYearDecadeLabelFontStyle"];
    public static readonly int FirstOfYearDecadeLabelFontWeight = Store["FirstOfYearDecadeLabelFontWeight"];
    public static readonly int FlowDirection = Store["FlowDirection"];
    public static readonly int Flyout = Store["Flyout"];
    public static readonly int FocusBorderBrush = Store["FocusBorderBrush"];
    public static readonly int FocusOnKeyboardInput = Store["FocusOnKeyboardInput"];
    public static readonly int FocusSecondaryBorderBrush = Store["FocusSecondaryBorderBrush"];
    public static readonly int FontFamily = Store["FontFamily"];
    public static readonly int FontRenderingEmSize = Store["FontRenderingEmSize"];
    public static readonly int FontSize = Store["FontSize"];
    public static readonly int FontStretch = Store["FontStretch"];
    public static readonly int FontStyle = Store["FontStyle"];
    public static readonly int FontUri = Store["FontUri"];
    public static readonly int FontWeight = Store["FontWeight"];
    public static readonly int Footer = Store["Footer"];
    public static readonly int FooterTemplate = Store["FooterTemplate"];
    public static readonly int FooterTransitions = Store["FooterTransitions"];
    public static readonly int Foreground = Store["Foreground"];
    public static readonly int FullSizeDesired = Store["FullSizeDesired"];
    public static readonly int Glyph = Store["Glyph"];
    public static readonly int GotFocus = Store["GotFocus"];
    public static readonly int GridColumn = Store["GridColumn"];
    public static readonly int GridColumnSpan = Store["GridColumnSpan"];
    public static readonly int GridRow = Store["GridRow"];
    public static readonly int GridRowSpan = Store["GridRowSpan"];
    public static readonly int GridViewItemPresenterHorizontalContentAlignment = Store["GridViewItemPresenterHorizontalContentAlignment"];
    public static readonly int GridViewItemPresenterPadding = Store["GridViewItemPresenterPadding"];
    public static readonly int GridViewItemPresenterVerticalContentAlignment = Store["GridViewItemPresenterVerticalContentAlignment"];
    public static readonly int GroupHeaderPlacement = Store["GroupHeaderPlacement"];
    public static readonly int GroupName = Store["GroupName"];
    public static readonly int GroupPadding = Store["GroupPadding"];
    public static readonly int GroupStyle = Store["GroupStyle"];
    public static readonly int GroupStyleSelector = Store["GroupStyleSelector"];
    public static readonly int Header = Store["Header"];
    public static readonly int HeaderBackground = Store["HeaderBackground"];
    public static readonly int HeaderForeground = Store["HeaderForeground"];
    public static readonly int HeaderTemplate = Store["HeaderTemplate"];
    public static readonly int HeaderTransitions = Store["HeaderTransitions"];
    public static readonly int Heading = Store["Heading"];
    public static readonly int Height = Store["Height"];
    public static readonly int Holding = Store["Holding"];
    public static readonly int HorizontalAlignment = Store["HorizontalAlignment"];
    public static readonly int HorizontalChildrenAlignment = Store["HorizontalChildrenAlignment"];
    public static readonly int HorizontalContentAlignment = Store["HorizontalContentAlignment"];
    public static readonly int HorizontalDayItemAlignment = Store["HorizontalDayItemAlignment"];
    public static readonly int HorizontalFirstOfMonthLabelAlignment = Store["HorizontalFirstOfMonthLabelAlignment"];
    public static readonly int HorizontalOffset = Store["HorizontalOffset"];
    public static readonly int HorizontalScrollBarVisibility = Store["HorizontalScrollBarVisibility"];
    public static readonly int HorizontalScrollMode = Store["HorizontalScrollMode"];
    public static readonly int HorizontalSnapPointsAlignment = Store["HorizontalSnapPointsAlignment"];
    public static readonly int HorizontalSnapPointsChanged = Store["HorizontalSnapPointsChanged"];
    public static readonly int HorizontalSnapPointsType = Store["HorizontalSnapPointsType"];
    public static readonly int HoverBorderBrush = Store["HoverBorderBrush"];
    public static readonly int Icon = Store["Icon"];
    public static readonly int IconSource = Store["IconSource"];
    public static readonly int ImageFailed = Store["ImageFailed"];
    public static readonly int ImageOpened = Store["ImageOpened"];
    public static readonly int IncrementalLoadingThreshold = Store["IncrementalLoadingThreshold"];
    public static readonly int IncrementalLoadingTrigger = Store["IncrementalLoadingTrigger"];
    public static readonly int Indeterminate = Store["Indeterminate"];
    public static readonly int IndicatorMode = Store["IndicatorMode"];
    public static readonly int Indices = Store["Indices"];
    public static readonly int InputScope = Store["InputScope"];
    public static readonly int IntermediateValue = Store["IntermediateValue"];
    public static readonly int Interval = Store["Interval"];
    public static readonly int IsActive = Store["IsActive"];
    public static readonly int IsActiveView = Store["IsActiveView"];
    public static readonly int IsBlackout = Store["IsBlackout"];
    public static readonly int IsCalendarOpen = Store["IsCalendarOpen"];
    public static readonly int IsChecked = Store["IsChecked"];
    public static readonly int IsColorFontEnabled = Store["IsColorFontEnabled"];
    public static readonly int IsCompact = Store["IsCompact"];
    public static readonly int IsDeferredScrollingEnabled = Store["IsDeferredScrollingEnabled"];
    public static readonly int IsDirectionReversed = Store["IsDirectionReversed"];
    public static readonly int IsDoubleTapEnabled = Store["IsDoubleTapEnabled"];
    public static readonly int IsDropDownOpen = Store["IsDropDownOpen"];
    public static readonly int IsEnabled = Store["IsEnabled"];
    public static readonly int IsEnabledChanged = Store["IsEnabledChanged"];
    public static readonly int IsFastForwardButtonVisible = Store["IsFastForwardButtonVisible"];
    public static readonly int IsFastForwardEnabled = Store["IsFastForwardEnabled"];
    public static readonly int IsFastRewindButtonVisible = Store["IsFastRewindButtonVisible"];
    public static readonly int IsFastRewindEnabled = Store["IsFastRewindEnabled"];
    public static readonly int IsFullWindow = Store["IsFullWindow"];
    public static readonly int IsFullWindowButtonVisible = Store["IsFullWindowButtonVisible"];
    public static readonly int IsFullWindowEnabled = Store["IsFullWindowEnabled"];
    public static readonly int IsGroupLabelVisible = Store["IsGroupLabelVisible"];
    public static readonly int IsHeaderInteractive = Store["IsHeaderInteractive"];
    public static readonly int IsHitTestVisible = Store["IsHitTestVisible"];
    public static readonly int IsHoldingEnabled = Store["IsHoldingEnabled"];
    public static readonly int IsHorizontalRailEnabled = Store["IsHorizontalRailEnabled"];
    public static readonly int IsHorizontalScrollChainingEnabled = Store["IsHorizontalScrollChainingEnabled"];
    public static readonly int IsIndeterminate = Store["IsIndeterminate"];
    public static readonly int IsItemClickEnabled = Store["IsItemClickEnabled"];
    public static readonly int IsLightDismissEnabled = Store["IsLightDismissEnabled"];
    public static readonly int IsLocked = Store["IsLocked"];
    public static readonly int IsLooping = Store["IsLooping"];
    public static readonly int IsMultiSelectCheckBoxEnabled = Store["IsMultiSelectCheckBoxEnabled"];
    public static readonly int IsMuted = Store["IsMuted"];
    public static readonly int IsOn = Store["IsOn"];
    public static readonly int IsOpen = Store["IsOpen"];
    public static readonly int IsOutOfScopeEnabled = Store["IsOutOfScopeEnabled"];
    public static readonly int IsPaneOpen = Store["IsPaneOpen"];
    public static readonly int IsPasswordRevealButtonEnabled = Store["IsPasswordRevealButtonEnabled"];
    public static readonly int IsPlaybackRateButtonVisible = Store["IsPlaybackRateButtonVisible"];
    public static readonly int IsPlaybackRateEnabled = Store["IsPlaybackRateEnabled"];
    public static readonly int IsPrimaryButtonEnabled = Store["IsPrimaryButtonEnabled"];
    public static readonly int IsReadOnly = Store["IsReadOnly"];
    public static readonly int IsRightTapEnabled = Store["IsRightTapEnabled"];
    public static readonly int IsScrollInertiaEnabled = Store["IsScrollInertiaEnabled"];
    public static readonly int IsSecondaryButtonEnabled = Store["IsSecondaryButtonEnabled"];
    public static readonly int IsSeekBarVisible = Store["IsSeekBarVisible"];
    public static readonly int IsSeekEnabled = Store["IsSeekEnabled"];
    public static readonly int IsSelected = Store["IsSelected"];
    public static readonly int IsSpellCheckEnabled = Store["IsSpellCheckEnabled"];
    public static readonly int IsSticky = Store["IsSticky"];
    public static readonly int IsStopButtonVisible = Store["IsStopButtonVisible"];
    public static readonly int IsStopEnabled = Store["IsStopEnabled"];
    public static readonly int IsSuggestionListOpen = Store["IsSuggestionListOpen"];
    public static readonly int IsSwipeEnabled = Store["IsSwipeEnabled"];
    public static readonly int IsSynchronizedWithCurrentItem = Store["IsSynchronizedWithCurrentItem"];
    public static readonly int IsTabStop = Store["IsTabStop"];
    public static readonly int IsTapEnabled = Store["IsTapEnabled"];
    public static readonly int IsTextPredictionEnabled = Store["IsTextPredictionEnabled"];
    public static readonly int IsTextScaleFactorEnabled = Store["IsTextScaleFactorEnabled"];
    public static readonly int IsTextSelectionEnabled = Store["IsTextSelectionEnabled"];
    public static readonly int IsThreeState = Store["IsThreeState"];
    public static readonly int IsThumbToolTipEnabled = Store["IsThumbToolTipEnabled"];
    public static readonly int IsTodayHighlighted = Store["IsTodayHighlighted"];
    public static readonly int IsVerticalRailEnabled = Store["IsVerticalRailEnabled"];
    public static readonly int IsVerticalScrollChainingEnabled = Store["IsVerticalScrollChainingEnabled"];
    public static readonly int IsVolumeButtonVisible = Store["IsVolumeButtonVisible"];
    public static readonly int IsVolumeEnabled = Store["IsVolumeEnabled"];
    public static readonly int IsZoomButtonVisible = Store["IsZoomButtonVisible"];
    public static readonly int IsZoomChainingEnabled = Store["IsZoomChainingEnabled"];
    public static readonly int IsZoomedInView = Store["IsZoomedInView"];
    public static readonly int IsZoomedInViewActive = Store["IsZoomedInViewActive"];
    public static readonly int IsZoomEnabled = Store["IsZoomEnabled"];
    public static readonly int IsZoomInertiaEnabled = Store["IsZoomInertiaEnabled"];
    public static readonly int IsZoomOutButtonEnabled = Store["IsZoomOutButtonEnabled"];
    public static readonly int ItemClick = Store["ItemClick"];
    public static readonly int ItemContainerStyle = Store["ItemContainerStyle"];
    public static readonly int ItemContainerStyleSelector = Store["ItemContainerStyleSelector"];
    public static readonly int ItemContainerTransitions = Store["ItemContainerTransitions"];
    public static readonly int ItemHeight = Store["ItemHeight"];
    public static readonly int ItemsPanel = Store["ItemsPanel"];
    public static readonly int ItemsSource = Store["ItemsSource"];
    public static readonly int ItemsUpdatingScrollMode = Store["ItemsUpdatingScrollMode"];
    public static readonly int ItemTemplate = Store["ItemTemplate"];
    public static readonly int ItemTemplateSelector = Store["ItemTemplateSelector"];
    public static readonly int ItemWidth = Store["ItemWidth"];
    public static readonly int KeyDown = Store["KeyDown"];
    public static readonly int KeyUp = Store["KeyUp"];
    public static readonly int Label = Store["Label"];
    public static readonly int LandmarksVisible = Store["LandmarksVisible"];
    public static readonly int Language = Store["Language"];
    public static readonly int LargeChange = Store["LargeChange"];
    public static readonly int LayoutUpdated = Store["LayoutUpdated"];
    public static readonly int LeftHeader = Store["LeftHeader"];
    public static readonly int LeftHeaderTemplate = Store["LeftHeaderTemplate"];
    public static readonly int LineHeight = Store["LineHeight"];
    public static readonly int LineStackingStrategy = Store["LineStackingStrategy"];
    public static readonly int ListViewItemPresenterHorizontalContentAlignment = Store["ListViewItemPresenterHorizontalContentAlignment"];
    public static readonly int ListViewItemPresenterPadding = Store["ListViewItemPresenterPadding"];
    public static readonly int ListViewItemPresenterVerticalContentAlignment = Store["ListViewItemPresenterVerticalContentAlignment"];
    public static readonly int LoadCompleted = Store["LoadCompleted"];
    public static readonly int Loaded = Store["Loaded"];
    public static readonly int LostFocus = Store["LostFocus"];
    public static readonly int ManipulationCompleted = Store["ManipulationCompleted"];
    public static readonly int ManipulationDelta = Store["ManipulationDelta"];
    public static readonly int ManipulationInertiaStarting = Store["ManipulationInertiaStarting"];
    public static readonly int ManipulationMode = Store["ManipulationMode"];
    public static readonly int ManipulationStarted = Store["ManipulationStarted"];
    public static readonly int ManipulationStarting = Store["ManipulationStarting"];
    public static readonly int MapControlLocation = Store["MapControlLocation"];
    public static readonly int MapControlNormalizedAnchorPoint = Store["MapControlNormalizedAnchorPoint"];
    public static readonly int MapServiceToken = Store["MapServiceToken"];
    public static readonly int Margin = Store["Margin"];
    public static readonly int MarkerReached = Store["MarkerReached"];
    public static readonly int Markers = Store["Markers"];
    public static readonly int MaxDate = Store["MaxDate"];
    public static readonly int MaxDropDownHeight = Store["MaxDropDownHeight"];
    public static readonly int MaxHeight = Store["MaxHeight"];
    public static readonly int Maximum = Store["Maximum"];
    public static readonly int MaximumRowsOrColumns = Store["MaximumRowsOrColumns"];
    public static readonly int MaxLength = Store["MaxLength"];
    public static readonly int MaxLines = Store["MaxLines"];
    public static readonly int MaxSuggestionListHeight = Store["MaxSuggestionListHeight"];
    public static readonly int MaxWidth = Store["MaxWidth"];
    public static readonly int MaxYear = Store["MaxYear"];
    public static readonly int MaxZoomFactor = Store["MaxZoomFactor"];
    public static readonly int MediaEnded = Store["MediaEnded"];
    public static readonly int MediaFailed = Store["MediaFailed"];
    public static readonly int MediaOpened = Store["MediaOpened"];
    public static readonly int MinDate = Store["MinDate"];
    public static readonly int MinHeight = Store["MinHeight"];
    public static readonly int Minimum = Store["Minimum"];
    public static readonly int MinuteIncrement = Store["MinuteIncrement"];
    public static readonly int MinWidth = Store["MinWidth"];
    public static readonly int MinYear = Store["MinYear"];
    public static readonly int MinZoomFactor = Store["MinZoomFactor"];
    public static readonly int MirroredWhenRightToLeft = Store["MirroredWhenRightToLeft"];
    public static readonly int MonthFormat = Store["MonthFormat"];
    public static readonly int MonthVisible = Store["MonthVisible"];
    public static readonly int MonthYearItemFontFamily = Store["MonthYearItemFontFamily"];
    public static readonly int MonthYearItemFontSize = Store["MonthYearItemFontSize"];
    public static readonly int MonthYearItemFontStyle = Store["MonthYearItemFontStyle"];
    public static readonly int MonthYearItemFontWeight = Store["MonthYearItemFontWeight"];
    public static readonly int Name = Store["Name"];
    public static readonly int Navigated = Store["Navigated"];
    public static readonly int NavigateUri = Store["NavigateUri"];
    public static readonly int Navigating = Store["Navigating"];
    public static readonly int NavigationCacheMode = Store["NavigationCacheMode"];
    public static readonly int NavigationFailed = Store["NavigationFailed"];
    public static readonly int NavigationStopped = Store["NavigationStopped"];
    public static readonly int NineGrid = Store["NineGrid"];
    public static readonly int NumberOfWeeksInView = Store["NumberOfWeeksInView"];
    public static readonly int OffContent = Store["OffContent"];
    public static readonly int OffContentTemplate = Store["OffContentTemplate"];
    public static readonly int OnContent = Store["OnContent"];
    public static readonly int OnContentTemplate = Store["OnContentTemplate"];
    public static readonly int Opacity = Store["Opacity"];
    public static readonly int Opened = Store["Opened"];
    public static readonly int Opening = Store["Opening"];
    public static readonly int OpenPaneLength = Store["OpenPaneLength"];
    public static readonly int OpticalMarginAlignment = Store["OpticalMarginAlignment"];
    public static readonly int Orientation = Store["Orientation"];
    public static readonly int OriginX = Store["OriginX"];
    public static readonly int OriginY = Store["OriginY"];
    public static readonly int OutOfScopeBackground = Store["OutOfScopeBackground"];
    public static readonly int OutOfScopeForeground = Store["OutOfScopeForeground"];
    public static readonly int OverflowContentTarget = Store["OverflowContentTarget"];
    public static readonly int Padding = Store["Padding"];
    public static readonly int Pane = Store["Pane"];
    public static readonly int PaneBackground = Store["PaneBackground"];
    public static readonly int PanePlacement = Store["PanePlacement"];
    public static readonly int PanInteractionMode = Store["PanInteractionMode"];
    public static readonly int Password = Store["Password"];
    public static readonly int PasswordChanged = Store["PasswordChanged"];
    public static readonly int PasswordChar = Store["PasswordChar"];
    public static readonly int PasswordRevealMode = Store["PasswordRevealMode"];
    public static readonly int Paste = Store["Paste"];
    public static readonly int PedestrianFeaturesVisible = Store["PedestrianFeaturesVisible"];
    public static readonly int PivotSlideInAnimationGroup = Store["PivotSlideInAnimationGroup"];
    public static readonly int PlaceholderBackground = Store["PlaceholderBackground"];
    public static readonly int PlaceholderText = Store["PlaceholderText"];
    public static readonly int Placement = Store["Placement"];
    public static readonly int PlacementTarget = Store["PlacementTarget"];
    public static readonly int PlaybackRate = Store["PlaybackRate"];
    public static readonly int PlayToPreferredSourceUri = Store["PlayToPreferredSourceUri"];
    public static readonly int PointerCanceled = Store["PointerCanceled"];
    public static readonly int PointerCaptureLost = Store["PointerCaptureLost"];
    public static readonly int PointerEntered = Store["PointerEntered"];
    public static readonly int PointerExited = Store["PointerExited"];
    public static readonly int PointerMoved = Store["PointerMoved"];
    public static readonly int PointerOverBackground = Store["PointerOverBackground"];
    public static readonly int PointerOverBackgroundMargin = Store["PointerOverBackgroundMargin"];
    public static readonly int PointerOverForeground = Store["PointerOverForeground"];
    public static readonly int PointerPressed = Store["PointerPressed"];
    public static readonly int PointerReleased = Store["PointerReleased"];
    public static readonly int PointerWheelChanged = Store["PointerWheelChanged"];
    public static readonly int Points = Store["Points"];
    public static readonly int Position = Store["Position"];
    public static readonly int PosterSource = Store["PosterSource"];
    public static readonly int PressedBackground = Store["PressedBackground"];
    public static readonly int PressedBorderBrush = Store["PressedBorderBrush"];
    public static readonly int PressedForeground = Store["PressedForeground"];
    public static readonly int PreventKeyboardDisplayOnProgrammaticFocus = Store["PreventKeyboardDisplayOnProgrammaticFocus"];
    public static readonly int PrimaryButtonCommand = Store["PrimaryButtonCommand"];
    public static readonly int PrimaryButtonCommandParameter = Store["PrimaryButtonCommandParameter"];
    public static readonly int PrimaryButtonText = Store["PrimaryButtonText"];
    public static readonly int PrimaryCommands = Store["PrimaryCommands"];
    public static readonly int Projection = Store["Projection"];
    public static readonly int ProtectionManager = Store["ProtectionManager"];
    public static readonly int QueryIcon = Store["QueryIcon"];
    public static readonly int QueryText = Store["QueryText"];
    public static readonly int RadiusX = Store["RadiusX"];
    public static readonly int RadiusY = Store["RadiusY"];
    public static readonly int RateChanged = Store["RateChanged"];
    public static readonly int RealTimePlayback = Store["RealTimePlayback"];
    public static readonly int RelativePanelAbove = Store["RelativePanelAbove"];
    public static readonly int RelativePanelAlignBottomWith = Store["RelativePanelAlignBottomWith"];
    public static readonly int RelativePanelAlignBottomWithPanel = Store["RelativePanelAlignBottomWithPanel"];
    public static readonly int RelativePanelAlignHorizontalCenterWith = Store["RelativePanelAlignHorizontalCenterWith"];
    public static readonly int RelativePanelAlignHorizontalCenterWithPanel = Store["RelativePanelAlignHorizontalCenterWithPanel"];
    public static readonly int RelativePanelAlignLeftWith = Store["RelativePanelAlignLeftWith"];
    public static readonly int RelativePanelAlignLeftWithPanel = Store["RelativePanelAlignLeftWithPanel"];
    public static readonly int RelativePanelAlignRightWith = Store["RelativePanelAlignRightWith"];
    public static readonly int RelativePanelAlignRightWithPanel = Store["RelativePanelAlignRightWithPanel"];
    public static readonly int RelativePanelAlignTopWith = Store["RelativePanelAlignTopWith"];
    public static readonly int RelativePanelAlignTopWithPanel = Store["RelativePanelAlignTopWithPanel"];
    public static readonly int RelativePanelAlignVerticalCenterWith = Store["RelativePanelAlignVerticalCenterWith"];
    public static readonly int RelativePanelAlignVerticalCenterWithPanel = Store["RelativePanelAlignVerticalCenterWithPanel"];
    public static readonly int RelativePanelBelow = Store["RelativePanelBelow"];
    public static readonly int RelativePanelLeftOf = Store["RelativePanelLeftOf"];
    public static readonly int RelativePanelRightOf = Store["RelativePanelRightOf"];
    public static readonly int RenderTransform = Store["RenderTransform"];
    public static readonly int RenderTransformOrigin = Store["RenderTransformOrigin"];
    public static readonly int ReorderHintOffset = Store["ReorderHintOffset"];
    public static readonly int ReorderMode = Store["ReorderMode"];
    public static readonly int RequestedTheme = Store["RequestedTheme"];
    public static readonly int Resources = Store["Resources"];
    public static readonly int RightHeader = Store["RightHeader"];
    public static readonly int RightHeaderTemplate = Store["RightHeaderTemplate"];
    public static readonly int RightTapped = Store["RightTapped"];
    public static readonly int RotateInteractionMode = Store["RotateInteractionMode"];
    public static readonly int Scene = Store["Scene"];
    public static readonly int ScriptNotify = Store["ScriptNotify"];
    public static readonly int Scroll = Store["Scroll"];
    public static readonly int ScrollOwner = Store["ScrollOwner"];
    public static readonly int ScrollViewerBringIntoViewOnFocusChange = Store["ScrollViewerBringIntoViewOnFocusChange"];
    public static readonly int ScrollViewerHorizontalScrollBarVisibility = Store["ScrollViewerHorizontalScrollBarVisibility"];
    public static readonly int ScrollViewerHorizontalScrollMode = Store["ScrollViewerHorizontalScrollMode"];
    public static readonly int ScrollViewerIsDeferredScrollingEnabled = Store["ScrollViewerIsDeferredScrollingEnabled"];
    public static readonly int ScrollViewerIsHorizontalRailEnabled = Store["ScrollViewerIsHorizontalRailEnabled"];
    public static readonly int ScrollViewerIsHorizontalScrollChainingEnabled = Store["ScrollViewerIsHorizontalScrollChainingEnabled"];
    public static readonly int ScrollViewerIsScrollInertiaEnabled = Store["ScrollViewerIsScrollInertiaEnabled"];
    public static readonly int ScrollViewerIsVerticalRailEnabled = Store["ScrollViewerIsVerticalRailEnabled"];
    public static readonly int ScrollViewerIsVerticalScrollChainingEnabled = Store["ScrollViewerIsVerticalScrollChainingEnabled"];
    public static readonly int ScrollViewerIsZoomChainingEnabled = Store["ScrollViewerIsZoomChainingEnabled"];
    public static readonly int ScrollViewerIsZoomInertiaEnabled = Store["ScrollViewerIsZoomInertiaEnabled"];
    public static readonly int ScrollViewerVerticalScrollBarVisibility = Store["ScrollViewerVerticalScrollBarVisibility"];
    public static readonly int ScrollViewerVerticalScrollMode = Store["ScrollViewerVerticalScrollMode"];
    public static readonly int ScrollViewerZoomMode = Store["ScrollViewerZoomMode"];
    public static readonly int SearchHistoryContext = Store["SearchHistoryContext"];
    public static readonly int SearchHistoryEnabled = Store["SearchHistoryEnabled"];
    public static readonly int SecondaryButtonCommand = Store["SecondaryButtonCommand"];
    public static readonly int SecondaryButtonCommandParameter = Store["SecondaryButtonCommandParameter"];
    public static readonly int SecondaryButtonText = Store["SecondaryButtonText"];
    public static readonly int SecondaryCommands = Store["SecondaryCommands"];
    public static readonly int SectionHeaderClick = Store["SectionHeaderClick"];
    public static readonly int SectionHeaders = Store["SectionHeaders"];
    public static readonly int Sections = Store["Sections"];
    public static readonly int SectionsInViewChanged = Store["SectionsInViewChanged"];
    public static readonly int SeekCompleted = Store["SeekCompleted"];
    public static readonly int SelectedBackground = Store["SelectedBackground"];
    public static readonly int SelectedBorderBrush = Store["SelectedBorderBrush"];
    public static readonly int SelectedBorderThickness = Store["SelectedBorderThickness"];
    public static readonly int SelectedForeground = Store["SelectedForeground"];
    public static readonly int SelectedHoverBorderBrush = Store["SelectedHoverBorderBrush"];
    public static readonly int SelectedIndex = Store["SelectedIndex"];
    public static readonly int SelectedItem = Store["SelectedItem"];
    public static readonly int SelectedPointerOverBackground = Store["SelectedPointerOverBackground"];
    public static readonly int SelectedPointerOverBorderBrush = Store["SelectedPointerOverBorderBrush"];
    public static readonly int SelectedPressedBackground = Store["SelectedPressedBackground"];
    public static readonly int SelectedPressedBorderBrush = Store["SelectedPressedBorderBrush"];
    public static readonly int SelectedText = Store["SelectedText"];
    public static readonly int SelectedValue = Store["SelectedValue"];
    public static readonly int SelectedValuePath = Store["SelectedValuePath"];
    public static readonly int SelectionChanged = Store["SelectionChanged"];
    public static readonly int SelectionCheckMarkVisualEnabled = Store["SelectionCheckMarkVisualEnabled"];
    public static readonly int SelectionHighlightColor = Store["SelectionHighlightColor"];
    public static readonly int SelectionLength = Store["SelectionLength"];
    public static readonly int SelectionMode = Store["SelectionMode"];
    public static readonly int SelectionStart = Store["SelectionStart"];
    public static readonly int SemanticZoomOwner = Store["SemanticZoomOwner"];
    public static readonly int ShouldLoop = Store["ShouldLoop"];
    public static readonly int ShowError = Store["ShowError"];
    public static readonly int ShowPaused = Store["ShowPaused"];
    public static readonly int ShowsScrollingPlaceholders = Store["ShowsScrollingPlaceholders"];
    public static readonly int SizeChanged = Store["SizeChanged"];
    public static readonly int SmallChange = Store["SmallChange"];
    public static readonly int SnapsTo = Store["SnapsTo"];
    public static readonly int Source = Store["Source"];
    public static readonly int SourcePageType = Store["SourcePageType"];
    public static readonly int StepFrequency = Store["StepFrequency"];
    public static readonly int Stereo3DVideoPackingMode = Store["Stereo3DVideoPackingMode"];
    public static readonly int Stereo3DVideoRenderMode = Store["Stereo3DVideoRenderMode"];
    public static readonly int Stretch = Store["Stretch"];
    public static readonly int StretchDirection = Store["StretchDirection"];
    public static readonly int Stroke = Store["Stroke"];
    public static readonly int StrokeDashArray = Store["StrokeDashArray"];
    public static readonly int StrokeDashCap = Store["StrokeDashCap"];
    public static readonly int StrokeDashOffset = Store["StrokeDashOffset"];
    public static readonly int StrokeEndLineCap = Store["StrokeEndLineCap"];
    public static readonly int StrokeLineJoin = Store["StrokeLineJoin"];
    public static readonly int StrokeMiterLimit = Store["StrokeMiterLimit"];
    public static readonly int StrokeStartLineCap = Store["StrokeStartLineCap"];
    public static readonly int StrokeThickness = Store["StrokeThickness"];
    public static readonly int Style = Store["Style"];
    public static readonly int StyleSimulations = Store["StyleSimulations"];
    public static readonly int Symbol = Store["Symbol"];
    public static readonly int TabIndex = Store["TabIndex"];
    public static readonly int TabNavigation = Store["TabNavigation"];
    public static readonly int Tag = Store["Tag"];
    public static readonly int Tapped = Store["Tapped"];
    public static readonly int Template = Store["Template"];
    public static readonly int Text = Store["Text"];
    public static readonly int TextAlignment = Store["TextAlignment"];
    public static readonly int TextBoxStyle = Store["TextBoxStyle"];
    public static readonly int TextChanged = Store["TextChanged"];
    public static readonly int TextIndent = Store["TextIndent"];
    public static readonly int TextLineBounds = Store["TextLineBounds"];
    public static readonly int TextMemberPath = Store["TextMemberPath"];
    public static readonly int TextReadingOrder = Store["TextReadingOrder"];
    public static readonly int TextTrimming = Store["TextTrimming"];
    public static readonly int TextWrapping = Store["TextWrapping"];
    public static readonly int ThumbToolTipValueConverter = Store["ThumbToolTipValueConverter"];
    public static readonly int TickFrequency = Store["TickFrequency"];
    public static readonly int TickPlacement = Store["TickPlacement"];
    public static readonly int TiltInteractionMode = Store["TiltInteractionMode"];
    public static readonly int Time = Store["Time"];
    public static readonly int TimeChanged = Store["TimeChanged"];
    public static readonly int Title = Store["Title"];
    public static readonly int TitleTemplate = Store["TitleTemplate"];
    public static readonly int TodayFontWeight = Store["TodayFontWeight"];
    public static readonly int TodayForeground = Store["TodayForeground"];
    public static readonly int Toggled = Store["Toggled"];
    public static readonly int ToolTipServicePlacement = Store["ToolTipServicePlacement"];
    public static readonly int ToolTipServicePlacementTarget = Store["ToolTipServicePlacementTarget"];
    public static readonly int ToolTipServiceToolTip = Store["ToolTipServiceToolTip"];
    public static readonly int TopAppBar = Store["TopAppBar"];
    public static readonly int TopHeader = Store["TopHeader"];
    public static readonly int TopLeftHeader = Store["TopLeftHeader"];
    public static readonly int TrafficFlowVisible = Store["TrafficFlowVisible"];
    public static readonly int Transform3D = Store["Transform3D"];
    public static readonly int TransformOrigin = Store["TransformOrigin"];
    public static readonly int TransitFeaturesVisible = Store["TransitFeaturesVisible"];
    public static readonly int Transitions = Store["Transitions"];
    public static readonly int TransportControls = Store["TransportControls"];
    public static readonly int Triggers = Store["Triggers"];
    public static readonly int Unchecked = Store["Unchecked"];
    public static readonly int UnderlineStyle = Store["UnderlineStyle"];
    public static readonly int UnicodeString = Store["UnicodeString"];
    public static readonly int Unloaded = Store["Unloaded"];
    public static readonly int UpdateTextOnSelect = Store["UpdateTextOnSelect"];
    public static readonly int UriSource = Store["UriSource"];
    public static readonly int UseLayoutRounding = Store["UseLayoutRounding"];
    public static readonly int UseSystemFocusVisuals = Store["UseSystemFocusVisuals"];
    public static readonly int UseTouchAnimationsForAllNavigation = Store["UseTouchAnimationsForAllNavigation"];
    public static readonly int Value = Store["Value"];
    public static readonly int ValueChanged = Store["ValueChanged"];
    public static readonly int VariableSizedWrapGridColumnSpan = Store["VariableSizedWrapGridColumnSpan"];
    public static readonly int VariableSizedWrapGridRowSpan = Store["VariableSizedWrapGridRowSpan"];
    public static readonly int VerticalAlignment = Store["VerticalAlignment"];
    public static readonly int VerticalChildrenAlignment = Store["VerticalChildrenAlignment"];
    public static readonly int VerticalContentAlignment = Store["VerticalContentAlignment"];
    public static readonly int VerticalDayItemAlignment = Store["VerticalDayItemAlignment"];
    public static readonly int VerticalFirstOfMonthLabelAlignment = Store["VerticalFirstOfMonthLabelAlignment"];
    public static readonly int VerticalOffset = Store["VerticalOffset"];
    public static readonly int VerticalScrollBarVisibility = Store["VerticalScrollBarVisibility"];
    public static readonly int VerticalScrollMode = Store["VerticalScrollMode"];
    public static readonly int VerticalSnapPointsAlignment = Store["VerticalSnapPointsAlignment"];
    public static readonly int VerticalSnapPointsChanged = Store["VerticalSnapPointsChanged"];
    public static readonly int VerticalSnapPointsType = Store["VerticalSnapPointsType"];
    public static readonly int ViewChangeCompleted = Store["ViewChangeCompleted"];
    public static readonly int ViewChanged = Store["ViewChanged"];
    public static readonly int ViewChangeStarted = Store["ViewChangeStarted"];
    public static readonly int ViewChanging = Store["ViewChanging"];
    public static readonly int ViewportSize = Store["ViewportSize"];
    public static readonly int VirtualizingStackPanelVirtualizationMode = Store["VirtualizingStackPanelVirtualizationMode"];
    public static readonly int Visibility = Store["Visibility"];
    public static readonly int Volume = Store["Volume"];
    public static readonly int VolumeChanged = Store["VolumeChanged"];
    public static readonly int WatermarkMode = Store["WatermarkMode"];
    public static readonly int Width = Store["Width"];
    public static readonly int X1 = Store["X1"];
    public static readonly int X2 = Store["X2"];
    public static readonly int Y1 = Store["Y1"];
    public static readonly int Y2 = Store["Y2"];
    public static readonly int YearFormat = Store["YearFormat"];
    public static readonly int YearVisible = Store["YearVisible"];
    public static readonly int ZoomedInView = Store["ZoomedInView"];
    public static readonly int ZoomedOutView = Store["ZoomedOutView"];
    public static readonly int ZoomInteractionMode = Store["ZoomInteractionMode"];
    public static readonly int ZoomLevel = Store["ZoomLevel"];
    public static readonly int ZoomMode = Store["ZoomMode"];
    public static readonly int ZoomSnapPointsType = Store["ZoomSnapPointsType"];
  }
}
