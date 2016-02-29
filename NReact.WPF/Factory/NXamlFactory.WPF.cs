using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NReact
{
  public partial class NXamlFactory: NFactory
  {
    public NXamlFactory()
    {
      GenerateUIElement();
      GenerateFrameworkElement();
      GenerateShape();
      GenerateLine();
      GeneratePath();
      GeneratePolygon();
      GeneratePolyline();
      GenerateRectangle();
      GenerateAdorner();
      GenerateDocumentReference();
      GenerateFixedPage();
      GenerateGlyphs();
      GeneratePageContent();
      GenerateAccessText();
      GenerateAdornedElementPlaceholder();
      GenerateContentPresenter();
      GenerateScrollContentPresenter();
      GenerateControl();
      GenerateStickyNoteControl();
      GenerateCalendar();
      GenerateContentControl();
      GenerateWindow();
      GenerateNavigationWindow();
      GenerateDataGridCell();
      GenerateFrame();
      GenerateHeaderedContentControl();
      GenerateExpander();
      GenerateTabItem();
      GenerateLabel();
      GenerateListBoxItem();
      GenerateScrollViewer();
      GenerateToolTip();
      GenerateButtonBase();
      GenerateButton();
      GenerateDataGridColumnHeader();
      GenerateDataGridRowHeader();
      GenerateRepeatButton();
      GenerateToggleButton();
      GenerateRadioButton();
      GenerateDataGridRow();
      GenerateDatePicker();
      GenerateFlowDocumentReader();
      GenerateFlowDocumentScrollViewer();
      GenerateItemsControl();
      GenerateHeaderedItemsControl();
      GenerateMenuItem();
      GenerateToolBar();
      GenerateTreeViewItem();
      GenerateTreeView();
      GenerateMenuBase();
      GenerateContextMenu();
      GenerateMenu();
      GenerateSelector();
      GenerateComboBox();
      GenerateListBox();
      GenerateListView();
      GenerateTabControl();
      GenerateMultiSelector();
      GenerateDataGrid();
      GenerateStatusBar();
      GeneratePasswordBox();
      GenerateDocumentViewerBase();
      GenerateDocumentViewer();
      GenerateFlowDocumentPageViewer();
      GenerateRangeBase();
      GenerateProgressBar();
      GenerateSlider();
      GenerateScrollBar();
      GenerateTextBoxBase();
      GenerateRichTextBox();
      GenerateTextBox();
      GenerateThumb();
      GenerateGridSplitter();
      GenerateDecorator();
      GenerateAdornerDecorator();
      GenerateBorder();
      GenerateInkPresenter();
      GenerateViewbox();
      GenerateBulletDecorator();
      GenerateImage();
      GenerateInkCanvas();
      GenerateMediaElement();
      GeneratePage();
      GeneratePageFunctionBase();
      GeneratePanel();
      GenerateCanvas();
      GenerateDockPanel();
      GenerateGrid();
      GenerateSelectiveScrollingGrid();
      GenerateStackPanel();
      GenerateVirtualizingPanel();
      GenerateVirtualizingStackPanel();
      GenerateWrapPanel();
      GenerateToolBarOverflowPanel();
      GenerateUniformGrid();
      GenerateTextBlock();
      GenerateToolBarTray();
      GenerateViewport3D();
      GenerateDocumentPageView();
      GenerateGridViewRowPresenterBase();
      GenerateGridViewHeaderRowPresenter();
      GenerateGridViewRowPresenter();
      GeneratePopup();
      GenerateTickBar();
      GenerateTrack();
      GenerateWebBrowser();
      GenerateTextElement();
      GenerateBlock();
      GenerateBlockUIContainer();
      GenerateList();
      GenerateParagraph();
      GenerateSection();
      GenerateTable();
      GenerateInline();
      GenerateAnchoredBlock();
      GenerateFigure();
      GenerateFloater();
      GenerateInlineUIContainer();
      GenerateRun();
      GenerateSpan();
      GenerateHyperlink();
      GenerateListItem();
      GenerateTableCell();
      GenerateTableRow();
      GenerateTableRowGroup();
      GenerateColumnDefinition();
      GenerateRowDefinition();
      GenerateToolTipService();
      GenerateTextOptions();
    }

    public override int GetContentKey(Type type)
    {
      if (typeof(NClass).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(TableRowGroup).IsAssignableFrom(type)) return NProps.Rows;
      if (typeof(TableRow).IsAssignableFrom(type)) return NProps.Cells;
      if (typeof(TableCell).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(ListItem).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(Span).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(Run).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(InlineUIContainer).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(AnchoredBlock).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(Table).IsAssignableFrom(type)) return NProps.RowGroups;
      if (typeof(Section).IsAssignableFrom(type)) return NProps.Blocks;
      if (typeof(Paragraph).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(List).IsAssignableFrom(type)) return NProps.ListItems;
      if (typeof(BlockUIContainer).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Popup).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(Viewport3D).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(ToolBarTray).IsAssignableFrom(type)) return NProps.ToolBars;
      if (typeof(TextBlock).IsAssignableFrom(type)) return NProps.Inlines;
      if (typeof(Panel).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(Page).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(InkCanvas).IsAssignableFrom(type)) return NProps.Children;
      if (typeof(Decorator).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(TextBox).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(RichTextBox).IsAssignableFrom(type)) return NProps.Document;
      if (typeof(DocumentViewerBase).IsAssignableFrom(type)) return NProps.Document;
      if (typeof(ItemsControl).IsAssignableFrom(type)) return NProps.Items;
      if (typeof(FlowDocumentScrollViewer).IsAssignableFrom(type)) return NProps.Document;
      if (typeof(FlowDocumentReader).IsAssignableFrom(type)) return NProps.Document;
      if (typeof(ContentControl).IsAssignableFrom(type)) return NProps.Content;
      if (typeof(AdornedElementPlaceholder).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(AccessText).IsAssignableFrom(type)) return NProps.Text;
      if (typeof(PageContent).IsAssignableFrom(type)) return NProps.Child;
      if (typeof(FixedPage).IsAssignableFrom(type)) return NProps.Children;

      return NProps.CONTENT;
    }

    void GenerateUIElement()
    {
      Register<UIElement>(NProps.AllowDrop, UIElement.AllowDropProperty, NConverters.ToBool);
      Register<UIElement>(NProps.BitmapEffect, UIElement.BitmapEffectProperty);
      Register<UIElement>(NProps.BitmapEffectInput, UIElement.BitmapEffectInputProperty);
      Register<UIElement>(NProps.CacheMode, UIElement.CacheModeProperty);
      Register<UIElement>(NProps.Clip, UIElement.ClipProperty);
      Register<UIElement>(NProps.ClipToBounds, UIElement.ClipToBoundsProperty, NConverters.ToBool);
      Register<UIElement>(NProps.CommandBindings, (t, v) => AssignList(t.CommandBindings, v));
      Register<UIElement>(NProps.Effect, UIElement.EffectProperty);
      Register<UIElement>(NProps.Focusable, UIElement.FocusableProperty, NConverters.ToBool);
      Register<UIElement>(NProps.InputBindings, (t, v) => AssignList(t.InputBindings, v));
      Register<UIElement>(NProps.IsEnabled, UIElement.IsEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsHitTestVisible, UIElement.IsHitTestVisibleProperty, NConverters.ToBool);
      Register<UIElement>(NProps.IsManipulationEnabled, UIElement.IsManipulationEnabledProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Opacity, UIElement.OpacityProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.OpacityMask, (t, v) => t.OpacityMask = NConverters.ToBrushT(v, t.OpacityMask));
//      Register<UIElement>(NProps.RenderSize);
      Register<UIElement>(NProps.RenderTransform, UIElement.RenderTransformProperty);
      Register<UIElement>(NProps.RenderTransformOrigin, UIElement.RenderTransformOriginProperty, NConverters.ToPoint);
      Register<UIElement>(NProps.SnapsToDevicePixels, UIElement.SnapsToDevicePixelsProperty, NConverters.ToBool);
      Register<UIElement>(NProps.Uid, UIElement.UidProperty, NConverters.ToString);
      Register<UIElement>(NProps.Visibility, UIElement.VisibilityProperty, NConverters.ToEnum<Visibility>);
      RegisterEvent<UIElement>(NProps._DragEnter, UIElement.DragEnterEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._DragLeave, UIElement.DragLeaveEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._DragOver, UIElement.DragOverEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._Drop, UIElement.DropEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GiveFeedback, UIElement.GiveFeedbackEvent, a => (GiveFeedbackEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GotFocus, UIElement.GotFocusEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GotKeyboardFocus, UIElement.GotKeyboardFocusEvent, a => (KeyboardFocusChangedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GotMouseCapture, UIElement.GotMouseCaptureEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GotStylusCapture, UIElement.GotStylusCaptureEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._GotTouchCapture, UIElement.GotTouchCaptureEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._KeyDown, UIElement.KeyDownEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._KeyUp, UIElement.KeyUpEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._LostFocus, UIElement.LostFocusEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._LostKeyboardFocus, UIElement.LostKeyboardFocusEvent, a => (KeyboardFocusChangedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._LostMouseCapture, UIElement.LostMouseCaptureEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._LostStylusCapture, UIElement.LostStylusCaptureEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._LostTouchCapture, UIElement.LostTouchCaptureEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationBoundaryFeedback, UIElement.ManipulationBoundaryFeedbackEvent, a => (EventHandler<ManipulationBoundaryFeedbackEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationCompleted, UIElement.ManipulationCompletedEvent, a => (EventHandler<ManipulationCompletedEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationDelta, UIElement.ManipulationDeltaEvent, a => (EventHandler<ManipulationDeltaEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationInertiaStarting, UIElement.ManipulationInertiaStartingEvent, a => (EventHandler<ManipulationInertiaStartingEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationStarted, UIElement.ManipulationStartedEvent, a => (EventHandler<ManipulationStartedEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._ManipulationStarting, UIElement.ManipulationStartingEvent, a => (EventHandler<ManipulationStartingEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseDown, UIElement.MouseDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseEnter, UIElement.MouseEnterEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseLeave, UIElement.MouseLeaveEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseLeftButtonDown, UIElement.MouseLeftButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseLeftButtonUp, UIElement.MouseLeftButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseMove, UIElement.MouseMoveEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseRightButtonDown, UIElement.MouseRightButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseRightButtonUp, UIElement.MouseRightButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseUp, UIElement.MouseUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._MouseWheel, UIElement.MouseWheelEvent, a => (MouseWheelEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewDragEnter, UIElement.PreviewDragEnterEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewDragLeave, UIElement.PreviewDragLeaveEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewDragOver, UIElement.PreviewDragOverEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewDrop, UIElement.PreviewDropEvent, a => (DragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewGiveFeedback, UIElement.PreviewGiveFeedbackEvent, a => (GiveFeedbackEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewGotKeyboardFocus, UIElement.PreviewGotKeyboardFocusEvent, a => (KeyboardFocusChangedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewKeyDown, UIElement.PreviewKeyDownEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewKeyUp, UIElement.PreviewKeyUpEvent, a => (KeyEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewLostKeyboardFocus, UIElement.PreviewLostKeyboardFocusEvent, a => (KeyboardFocusChangedEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseDown, UIElement.PreviewMouseDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseLeftButtonDown, UIElement.PreviewMouseLeftButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseLeftButtonUp, UIElement.PreviewMouseLeftButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseMove, UIElement.PreviewMouseMoveEvent, a => (MouseEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseRightButtonDown, UIElement.PreviewMouseRightButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseRightButtonUp, UIElement.PreviewMouseRightButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseUp, UIElement.PreviewMouseUpEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewMouseWheel, UIElement.PreviewMouseWheelEvent, a => (MouseWheelEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewQueryContinueDrag, UIElement.PreviewQueryContinueDragEvent, a => (QueryContinueDragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusButtonDown, UIElement.PreviewStylusButtonDownEvent, a => (StylusButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusButtonUp, UIElement.PreviewStylusButtonUpEvent, a => (StylusButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusDown, UIElement.PreviewStylusDownEvent, a => (StylusDownEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusInAirMove, UIElement.PreviewStylusInAirMoveEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusInRange, UIElement.PreviewStylusInRangeEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusMove, UIElement.PreviewStylusMoveEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusOutOfRange, UIElement.PreviewStylusOutOfRangeEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusSystemGesture, UIElement.PreviewStylusSystemGestureEvent, a => (StylusSystemGestureEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewStylusUp, UIElement.PreviewStylusUpEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewTextInput, UIElement.PreviewTextInputEvent, a => (TextCompositionEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewTouchDown, UIElement.PreviewTouchDownEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewTouchMove, UIElement.PreviewTouchMoveEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._PreviewTouchUp, UIElement.PreviewTouchUpEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._QueryContinueDrag, UIElement.QueryContinueDragEvent, a => (QueryContinueDragEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._QueryCursor, UIElement.QueryCursorEvent, a => (QueryCursorEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusButtonDown, UIElement.StylusButtonDownEvent, a => (StylusButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusButtonUp, UIElement.StylusButtonUpEvent, a => (StylusButtonEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusDown, UIElement.StylusDownEvent, a => (StylusDownEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusEnter, UIElement.StylusEnterEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusInAirMove, UIElement.StylusInAirMoveEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusInRange, UIElement.StylusInRangeEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusLeave, UIElement.StylusLeaveEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusMove, UIElement.StylusMoveEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusOutOfRange, UIElement.StylusOutOfRangeEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusSystemGesture, UIElement.StylusSystemGestureEvent, a => (StylusSystemGestureEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._StylusUp, UIElement.StylusUpEvent, a => (StylusEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TextInput, UIElement.TextInputEvent, a => (TextCompositionEventHandler)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TouchDown, UIElement.TouchDownEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TouchEnter, UIElement.TouchEnterEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TouchLeave, UIElement.TouchLeaveEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TouchMove, UIElement.TouchMoveEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps._TouchUp, UIElement.TouchUpEvent, a => (EventHandler<TouchEventArgs>)a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragEnter, (s, a) => s.DragEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragLeave, (s, a) => s.DragLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.DragOver, (s, a) => s.DragOver += a.EventHandler);
      RegisterEvent<UIElement>(NProps.Drop, (s, a) => s.Drop += a.EventHandler);
      RegisterEvent<UIElement>(NProps.FocusableChanged, (s, a) => s.FocusableChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.GiveFeedback, (s, a) => s.GiveFeedback += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotFocus, (s, a) => s.GotFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotKeyboardFocus, (s, a) => s.GotKeyboardFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotMouseCapture, (s, a) => s.GotMouseCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotStylusCapture, (s, a) => s.GotStylusCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.GotTouchCapture, (s, a) => s.GotTouchCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.IsEnabledChanged, (s, a) => s.IsEnabledChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsHitTestVisibleChanged, (s, a) => s.IsHitTestVisibleChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsKeyboardFocusedChanged, (s, a) => s.IsKeyboardFocusedChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsKeyboardFocusWithinChanged, (s, a) => s.IsKeyboardFocusWithinChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsMouseCapturedChanged, (s, a) => s.IsMouseCapturedChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsMouseCaptureWithinChanged, (s, a) => s.IsMouseCaptureWithinChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsMouseDirectlyOverChanged, (s, a) => s.IsMouseDirectlyOverChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsStylusCapturedChanged, (s, a) => s.IsStylusCapturedChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsStylusCaptureWithinChanged, (s, a) => s.IsStylusCaptureWithinChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsStylusDirectlyOverChanged, (s, a) => s.IsStylusDirectlyOverChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.IsVisibleChanged, (s, a) => s.IsVisibleChanged += a.EventHandlerAny);
      RegisterEvent<UIElement>(NProps.KeyDown, (s, a) => s.KeyDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.KeyUp, (s, a) => s.KeyUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LayoutUpdated, (s, a) => s.LayoutUpdated += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostFocus, (s, a) => s.LostFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostKeyboardFocus, (s, a) => s.LostKeyboardFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostMouseCapture, (s, a) => s.LostMouseCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostStylusCapture, (s, a) => s.LostStylusCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.LostTouchCapture, (s, a) => s.LostTouchCapture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationBoundaryFeedback, (s, a) => s.ManipulationBoundaryFeedback += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationCompleted, (s, a) => s.ManipulationCompleted += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationDelta, (s, a) => s.ManipulationDelta += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationInertiaStarting, (s, a) => s.ManipulationInertiaStarting += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationStarted, (s, a) => s.ManipulationStarted += a.EventHandler);
      RegisterEvent<UIElement>(NProps.ManipulationStarting, (s, a) => s.ManipulationStarting += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseDown, (s, a) => s.MouseDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseEnter, (s, a) => s.MouseEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeave, (s, a) => s.MouseLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeftButtonDown, (s, a) => s.MouseLeftButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseLeftButtonUp, (s, a) => s.MouseLeftButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseMove, (s, a) => s.MouseMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseRightButtonDown, (s, a) => s.MouseRightButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseRightButtonUp, (s, a) => s.MouseRightButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseUp, (s, a) => s.MouseUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.MouseWheel, (s, a) => s.MouseWheel += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewDragEnter, (s, a) => s.PreviewDragEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewDragLeave, (s, a) => s.PreviewDragLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewDragOver, (s, a) => s.PreviewDragOver += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewDrop, (s, a) => s.PreviewDrop += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewGiveFeedback, (s, a) => s.PreviewGiveFeedback += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewGotKeyboardFocus, (s, a) => s.PreviewGotKeyboardFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewKeyDown, (s, a) => s.PreviewKeyDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewKeyUp, (s, a) => s.PreviewKeyUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewLostKeyboardFocus, (s, a) => s.PreviewLostKeyboardFocus += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseDown, (s, a) => s.PreviewMouseDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseLeftButtonDown, (s, a) => s.PreviewMouseLeftButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseLeftButtonUp, (s, a) => s.PreviewMouseLeftButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseMove, (s, a) => s.PreviewMouseMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseRightButtonDown, (s, a) => s.PreviewMouseRightButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseRightButtonUp, (s, a) => s.PreviewMouseRightButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseUp, (s, a) => s.PreviewMouseUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewMouseWheel, (s, a) => s.PreviewMouseWheel += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewQueryContinueDrag, (s, a) => s.PreviewQueryContinueDrag += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusButtonDown, (s, a) => s.PreviewStylusButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusButtonUp, (s, a) => s.PreviewStylusButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusDown, (s, a) => s.PreviewStylusDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusInAirMove, (s, a) => s.PreviewStylusInAirMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusInRange, (s, a) => s.PreviewStylusInRange += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusMove, (s, a) => s.PreviewStylusMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusOutOfRange, (s, a) => s.PreviewStylusOutOfRange += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusSystemGesture, (s, a) => s.PreviewStylusSystemGesture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewStylusUp, (s, a) => s.PreviewStylusUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewTextInput, (s, a) => s.PreviewTextInput += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewTouchDown, (s, a) => s.PreviewTouchDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewTouchMove, (s, a) => s.PreviewTouchMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.PreviewTouchUp, (s, a) => s.PreviewTouchUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.QueryContinueDrag, (s, a) => s.QueryContinueDrag += a.EventHandler);
      RegisterEvent<UIElement>(NProps.QueryCursor, (s, a) => s.QueryCursor += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusButtonDown, (s, a) => s.StylusButtonDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusButtonUp, (s, a) => s.StylusButtonUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusDown, (s, a) => s.StylusDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusEnter, (s, a) => s.StylusEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusInAirMove, (s, a) => s.StylusInAirMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusInRange, (s, a) => s.StylusInRange += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusLeave, (s, a) => s.StylusLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusMove, (s, a) => s.StylusMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusOutOfRange, (s, a) => s.StylusOutOfRange += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusSystemGesture, (s, a) => s.StylusSystemGesture += a.EventHandler);
      RegisterEvent<UIElement>(NProps.StylusUp, (s, a) => s.StylusUp += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TextInput, (s, a) => s.TextInput += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TouchDown, (s, a) => s.TouchDown += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TouchEnter, (s, a) => s.TouchEnter += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TouchLeave, (s, a) => s.TouchLeave += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TouchMove, (s, a) => s.TouchMove += a.EventHandler);
      RegisterEvent<UIElement>(NProps.TouchUp, (s, a) => s.TouchUp += a.EventHandler);
    }

    void GenerateFrameworkElement()
    {
      Register<FrameworkElement>(NProps.BindingGroup, FrameworkElement.BindingGroupProperty);
      Register<FrameworkElement>(NProps.ContextMenu, FrameworkElement.ContextMenuProperty);
      Register<FrameworkElement>(NProps.Cursor, FrameworkElement.CursorProperty, NConverters.ToCursor);
      Register<FrameworkElement>(NProps.DataContext, FrameworkElement.DataContextProperty);
      Register<FrameworkElement>(NProps.FlowDirection, FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<FrameworkElement>(NProps.FocusVisualStyle, FrameworkElement.FocusVisualStyleProperty, NConverters.ToStyle);
      Register<FrameworkElement>(NProps.ForceCursor, FrameworkElement.ForceCursorProperty, NConverters.ToBool);
      Register<FrameworkElement>(NProps.Height, FrameworkElement.HeightProperty, NConverters.ToLength);
      Register<FrameworkElement>(NProps.HorizontalAlignment, FrameworkElement.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<FrameworkElement>(NProps.InputScope, FrameworkElement.InputScopeProperty);
      Register<FrameworkElement>(NProps.Language, FrameworkElement.LanguageProperty, NConverters.ToLanguage);
      Register<FrameworkElement>(NProps.LayoutTransform, FrameworkElement.LayoutTransformProperty);
      Register<FrameworkElement>(NProps.Margin, FrameworkElement.MarginProperty, NConverters.ToThickness);
      Register<FrameworkElement>(NProps.MaxHeight, FrameworkElement.MaxHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MaxWidth, FrameworkElement.MaxWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinHeight, FrameworkElement.MinHeightProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.MinWidth, FrameworkElement.MinWidthProperty, NConverters.ToDouble);
      Register<FrameworkElement>(NProps.Name, FrameworkElement.NameProperty, NConverters.ToString);
      Register<FrameworkElement>(NProps.OverridesDefaultStyle, FrameworkElement.OverridesDefaultStyleProperty, NConverters.ToBool);
      Register<FrameworkElement>(NProps.Resources, (t, v) => t.Resources = NConverters.ToResourceDictionaryT(v));
      Register<FrameworkElement>(NProps.Style, FrameworkElement.StyleProperty, NConverters.ToStyle);
      Register<FrameworkElement>(NProps.Tag, FrameworkElement.TagProperty);
      Register<FrameworkElement>(NProps.ToolTip, FrameworkElement.ToolTipProperty);
      Register<FrameworkElement>(NProps.Triggers, (t, v) => AssignListT(t.Triggers, v));
      Register<FrameworkElement>(NProps.UseLayoutRounding, FrameworkElement.UseLayoutRoundingProperty, NConverters.ToBool);
      Register<FrameworkElement>(NProps.VerticalAlignment, FrameworkElement.VerticalAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      Register<FrameworkElement>(NProps.Width, FrameworkElement.WidthProperty, NConverters.ToLength);
      Register<DependencyObject>(NProps.FrameworkElementFlowDirection, FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      RegisterEvent<FrameworkElement>(NProps._ContextMenuClosing, FrameworkElement.ContextMenuClosingEvent, a => (ContextMenuEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._ContextMenuOpening, FrameworkElement.ContextMenuOpeningEvent, a => (ContextMenuEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._Loaded, FrameworkElement.LoadedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._RequestBringIntoView, FrameworkElement.RequestBringIntoViewEvent, a => (RequestBringIntoViewEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._SizeChanged, FrameworkElement.SizeChangedEvent, a => (SizeChangedEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._ToolTipClosing, FrameworkElement.ToolTipClosingEvent, a => (ToolTipEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._ToolTipOpening, FrameworkElement.ToolTipOpeningEvent, a => (ToolTipEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps._Unloaded, FrameworkElement.UnloadedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.ContextMenuClosing, (s, a) => s.ContextMenuClosing += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.ContextMenuOpening, (s, a) => s.ContextMenuOpening += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.DataContextChanged, (s, a) => s.DataContextChanged += a.EventHandlerAny);
      RegisterEvent<FrameworkElement>(NProps.Initialized, (s, a) => s.Initialized += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.Loaded, (s, a) => s.Loaded += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.RequestBringIntoView, (s, a) => s.RequestBringIntoView += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.SizeChanged, (s, a) => s.SizeChanged += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.SourceUpdated, (s, a) => s.SourceUpdated += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.TargetUpdated, (s, a) => s.TargetUpdated += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.ToolTipClosing, (s, a) => s.ToolTipClosing += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.ToolTipOpening, (s, a) => s.ToolTipOpening += a.EventHandler);
      RegisterEvent<FrameworkElement>(NProps.Unloaded, (s, a) => s.Unloaded += a.EventHandler);
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

    void GenerateAdorner()
    {
      Register<Adorner>(NProps.IsClipEnabled, (t, v) => t.IsClipEnabled = NConverters.ToBoolT(v));
    }

    void GenerateDocumentReference()
    {
      Register<DocumentReference>(NProps.Source, DocumentReference.SourceProperty, NConverters.ToUri);
    }

    void GenerateFixedPage()
    {
      Register<FixedPage>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<FixedPage>(NProps.BleedBox, FixedPage.BleedBoxProperty);
      Register<FixedPage>(NProps.Children, (t, v) => AssignList(t.Children, v));
      Register<FixedPage>(NProps.ContentBox, FixedPage.ContentBoxProperty);
      Register<FixedPage>(NProps.PrintTicket, FixedPage.PrintTicketProperty);
      Register<UIElement>(NProps.FixedPageLeft, FixedPage.LeftProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.FixedPageTop, FixedPage.TopProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.FixedPageRight, FixedPage.RightProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.FixedPageBottom, FixedPage.BottomProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.FixedPageNavigateUri, FixedPage.NavigateUriProperty, NConverters.ToUri);
    }

    void GenerateGlyphs()
    {
      Register<Glyphs>(NProps.BidiLevel, Glyphs.BidiLevelProperty, NConverters.ToInt32);
      Register<Glyphs>(NProps.CaretStops, Glyphs.CaretStopsProperty, NConverters.ToString);
      Register<Glyphs>(NProps.DeviceFontName, Glyphs.DeviceFontNameProperty, NConverters.ToString);
      Register<Glyphs>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
      Register<Glyphs>(NProps.FontRenderingEmSize, Glyphs.FontRenderingEmSizeProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.FontUri, Glyphs.FontUriProperty, NConverters.ToUri);
      Register<Glyphs>(NProps.Indices, Glyphs.IndicesProperty, NConverters.ToString);
      Register<Glyphs>(NProps.IsSideways, Glyphs.IsSidewaysProperty, NConverters.ToBool);
      Register<Glyphs>(NProps.OriginX, Glyphs.OriginXProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.OriginY, Glyphs.OriginYProperty, NConverters.ToDouble);
      Register<Glyphs>(NProps.StyleSimulations, Glyphs.StyleSimulationsProperty, NConverters.ToEnum<StyleSimulations>);
      Register<Glyphs>(NProps.UnicodeString, Glyphs.UnicodeStringProperty, NConverters.ToString);
    }

    void GeneratePageContent()
    {
//      Register<PageContent>(NProps.Child);
      Register<PageContent>(NProps.LinkTargets, (t, v) => AssignList(t.LinkTargets, v));
      Register<PageContent>(NProps.Source, PageContent.SourceProperty, NConverters.ToUri);
      RegisterEvent<PageContent>(NProps.GetPageRootCompleted, (s, a) => s.GetPageRootCompleted += a.EventHandler);
    }

    void GenerateAccessText()
    {
      Register<AccessText>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<AccessText>(NProps.BaselineOffset, AccessText.BaselineOffsetProperty, NConverters.ToDouble);
      Register<AccessText>(NProps.FontFamily, AccessText.FontFamilyProperty, NConverters.ToFontFamily);
      Register<AccessText>(NProps.FontSize, AccessText.FontSizeProperty, NConverters.ToDouble);
      Register<AccessText>(NProps.FontStretch, AccessText.FontStretchProperty, NConverters.ToFontStretch);
      Register<AccessText>(NProps.FontStyle, AccessText.FontStyleProperty, NConverters.ToFontStyle);
      Register<AccessText>(NProps.FontWeight, AccessText.FontWeightProperty, NConverters.ToFontWeight);
      Register<AccessText>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<AccessText>(NProps.LineHeight, AccessText.LineHeightProperty, NConverters.ToDouble);
      Register<AccessText>(NProps.LineStackingStrategy, AccessText.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<AccessText>(NProps.Text, AccessText.TextProperty, NConverters.ToString);
      Register<AccessText>(NProps.TextAlignment, AccessText.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<AccessText>(NProps.TextDecorations, (t, v) => AssignListT(t.TextDecorations, v));
      Register<AccessText>(NProps.TextEffects, (t, v) => AssignListT(t.TextEffects, v));
      Register<AccessText>(NProps.TextTrimming, AccessText.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<AccessText>(NProps.TextWrapping, AccessText.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
    }

    void GenerateAdornedElementPlaceholder()
    {
      Register<AdornedElementPlaceholder>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateContentPresenter()
    {
      Register<ContentPresenter>(NProps.Content, ContentPresenter.ContentProperty);
      Register<ContentPresenter>(NProps.ContentSource, ContentPresenter.ContentSourceProperty, NConverters.ToString);
      Register<ContentPresenter>(NProps.ContentStringFormat, ContentPresenter.ContentStringFormatProperty, NConverters.ToString);
      Register<ContentPresenter>(NProps.ContentTemplate, ContentPresenter.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<ContentPresenter>(NProps.ContentTemplateSelector, ContentPresenter.ContentTemplateSelectorProperty);
      Register<ContentPresenter>(NProps.RecognizesAccessKey, ContentPresenter.RecognizesAccessKeyProperty, NConverters.ToBool);
    }

    void GenerateScrollContentPresenter()
    {
      Register<ScrollContentPresenter>(NProps.CanContentScroll, ScrollContentPresenter.CanContentScrollProperty, NConverters.ToBool);
      Register<ScrollContentPresenter>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<ScrollContentPresenter>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
//      Register<ScrollContentPresenter>(NProps.ScrollOwner);
    }

    void GenerateControl()
    {
      Register<Control>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Control>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Control>(NProps.BorderThickness, Control.BorderThicknessProperty, NConverters.ToThickness);
      Register<Control>(NProps.FontFamily, Control.FontFamilyProperty, NConverters.ToFontFamily);
      Register<Control>(NProps.FontSize, Control.FontSizeProperty, NConverters.ToDouble);
      Register<Control>(NProps.FontStretch, Control.FontStretchProperty, NConverters.ToFontStretch);
      Register<Control>(NProps.FontStyle, Control.FontStyleProperty, NConverters.ToFontStyle);
      Register<Control>(NProps.FontWeight, Control.FontWeightProperty, NConverters.ToFontWeight);
      Register<Control>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<Control>(NProps.HorizontalContentAlignment, Control.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<Control>(NProps.IsTabStop, Control.IsTabStopProperty, NConverters.ToBool);
      Register<Control>(NProps.Padding, Control.PaddingProperty, NConverters.ToThickness);
      Register<Control>(NProps.TabIndex, Control.TabIndexProperty, NConverters.ToInt32);
      Register<Control>(NProps.Template, Control.TemplateProperty, NConverters.ToControlTemplate);
      Register<Control>(NProps.VerticalContentAlignment, Control.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);
      RegisterEvent<Control>(NProps._MouseDoubleClick, Control.MouseDoubleClickEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<Control>(NProps._PreviewMouseDoubleClick, Control.PreviewMouseDoubleClickEvent, a => (MouseButtonEventHandler)a.EventHandler);
      RegisterEvent<Control>(NProps.MouseDoubleClick, (s, a) => s.MouseDoubleClick += a.EventHandler);
      RegisterEvent<Control>(NProps.PreviewMouseDoubleClick, (s, a) => s.PreviewMouseDoubleClick += a.EventHandler);
    }

    void GenerateStickyNoteControl()
    {
      Register<StickyNoteControl>(NProps.CaptionFontFamily, StickyNoteControl.CaptionFontFamilyProperty, NConverters.ToFontFamily);
      Register<StickyNoteControl>(NProps.CaptionFontSize, StickyNoteControl.CaptionFontSizeProperty, NConverters.ToDouble);
      Register<StickyNoteControl>(NProps.CaptionFontStretch, StickyNoteControl.CaptionFontStretchProperty, NConverters.ToFontStretch);
      Register<StickyNoteControl>(NProps.CaptionFontStyle, StickyNoteControl.CaptionFontStyleProperty, NConverters.ToFontStyle);
      Register<StickyNoteControl>(NProps.CaptionFontWeight, StickyNoteControl.CaptionFontWeightProperty, NConverters.ToFontWeight);
      Register<StickyNoteControl>(NProps.IsExpanded, StickyNoteControl.IsExpandedProperty, NConverters.ToBool);
      Register<StickyNoteControl>(NProps.PenWidth, StickyNoteControl.PenWidthProperty, NConverters.ToDouble);
    }

    void GenerateCalendar()
    {
      Register<Calendar>(NProps.BlackoutDates, (t, v) => AssignListT(t.BlackoutDates, v));
      Register<Calendar>(NProps.CalendarButtonStyle, Calendar.CalendarButtonStyleProperty, NConverters.ToStyle);
      Register<Calendar>(NProps.CalendarDayButtonStyle, Calendar.CalendarDayButtonStyleProperty, NConverters.ToStyle);
      Register<Calendar>(NProps.CalendarItemStyle, Calendar.CalendarItemStyleProperty, NConverters.ToStyle);
      Register<Calendar>(NProps.DisplayDate, Calendar.DisplayDateProperty);
      Register<Calendar>(NProps.DisplayDateEnd, Calendar.DisplayDateEndProperty);
      Register<Calendar>(NProps.DisplayDateStart, Calendar.DisplayDateStartProperty);
      Register<Calendar>(NProps.DisplayMode, Calendar.DisplayModeProperty, NConverters.ToEnum<CalendarMode>);
      Register<Calendar>(NProps.FirstDayOfWeek, Calendar.FirstDayOfWeekProperty, NConverters.ToEnum<DayOfWeek>);
      Register<Calendar>(NProps.IsTodayHighlighted, Calendar.IsTodayHighlightedProperty, NConverters.ToBool);
      Register<Calendar>(NProps.SelectedDate, Calendar.SelectedDateProperty);
      Register<Calendar>(NProps.SelectedDates, (t, v) => AssignListT(t.SelectedDates, v));
      Register<Calendar>(NProps.SelectionMode, Calendar.SelectionModeProperty, NConverters.ToEnum<CalendarSelectionMode>);
      RegisterEvent<Calendar>(NProps._SelectedDatesChanged, Calendar.SelectedDatesChangedEvent, a => (EventHandler<SelectionChangedEventArgs>)a.EventHandler);
      RegisterEvent<Calendar>(NProps.DisplayDateChanged, (s, a) => s.DisplayDateChanged += a.EventHandler);
      RegisterEvent<Calendar>(NProps.DisplayModeChanged, (s, a) => s.DisplayModeChanged += a.EventHandler);
      RegisterEvent<Calendar>(NProps.SelectedDatesChanged, (s, a) => s.SelectedDatesChanged += a.EventHandler);
      RegisterEvent<Calendar>(NProps.SelectionModeChanged, (s, a) => s.SelectionModeChanged += a.EventHandler);
    }

    void GenerateContentControl()
    {
      Register<ContentControl>(NProps.Content, ContentControl.ContentProperty);
      Register<ContentControl>(NProps.ContentStringFormat, ContentControl.ContentStringFormatProperty, NConverters.ToString);
      Register<ContentControl>(NProps.ContentTemplate, ContentControl.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<ContentControl>(NProps.ContentTemplateSelector, ContentControl.ContentTemplateSelectorProperty);
    }

    void GenerateWindow()
    {
      Register<Window>(NProps.AllowsTransparency, Window.AllowsTransparencyProperty, NConverters.ToBool);
//      Register<Window>(NProps.DialogResult);
      Register<Window>(NProps.Icon, Window.IconProperty);
      Register<Window>(NProps.Left, Window.LeftProperty, NConverters.ToDouble);
//      Register<Window>(NProps.Owner);
      Register<Window>(NProps.ResizeMode, Window.ResizeModeProperty, NConverters.ToEnum<ResizeMode>);
      Register<Window>(NProps.ShowActivated, Window.ShowActivatedProperty, NConverters.ToBool);
      Register<Window>(NProps.ShowInTaskbar, Window.ShowInTaskbarProperty, NConverters.ToBool);
      Register<Window>(NProps.SizeToContent, Window.SizeToContentProperty, NConverters.ToEnum<SizeToContent>);
      Register<Window>(NProps.TaskbarItemInfo, Window.TaskbarItemInfoProperty);
      Register<Window>(NProps.Title, Window.TitleProperty, NConverters.ToString);
      Register<Window>(NProps.Top, Window.TopProperty, NConverters.ToDouble);
      Register<Window>(NProps.Topmost, Window.TopmostProperty, NConverters.ToBool);
      Register<Window>(NProps.WindowStartupLocation, (t, v) => t.WindowStartupLocation = NConverters.ToEnumT<WindowStartupLocation>(v));
      Register<Window>(NProps.WindowState, Window.WindowStateProperty, NConverters.ToEnum<WindowState>);
      Register<Window>(NProps.WindowStyle, Window.WindowStyleProperty, NConverters.ToEnum<WindowStyle>);
      RegisterEvent<Window>(NProps.Activated, (s, a) => s.Activated += a.EventHandler);
      RegisterEvent<Window>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<Window>(NProps.Closing, (s, a) => s.Closing += a.EventHandler);
      RegisterEvent<Window>(NProps.ContentRendered, (s, a) => s.ContentRendered += a.EventHandler);
      RegisterEvent<Window>(NProps.Deactivated, (s, a) => s.Deactivated += a.EventHandler);
      RegisterEvent<Window>(NProps.LocationChanged, (s, a) => s.LocationChanged += a.EventHandler);
      RegisterEvent<Window>(NProps.SourceInitialized, (s, a) => s.SourceInitialized += a.EventHandler);
      RegisterEvent<Window>(NProps.StateChanged, (s, a) => s.StateChanged += a.EventHandler);
    }

    void GenerateNavigationWindow()
    {
      Register<NavigationWindow>(NProps.SandboxExternalContent, NavigationWindow.SandboxExternalContentProperty, NConverters.ToBool);
      Register<NavigationWindow>(NProps.ShowsNavigationUI, NavigationWindow.ShowsNavigationUIProperty, NConverters.ToBool);
      Register<NavigationWindow>(NProps.Source, NavigationWindow.SourceProperty, NConverters.ToUri);
      RegisterEvent<NavigationWindow>(NProps.FragmentNavigation, (s, a) => s.FragmentNavigation += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.LoadCompleted, (s, a) => s.LoadCompleted += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.Navigated, (s, a) => s.Navigated += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.Navigating, (s, a) => s.Navigating += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.NavigationFailed, (s, a) => s.NavigationFailed += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.NavigationProgress, (s, a) => s.NavigationProgress += a.EventHandler);
      RegisterEvent<NavigationWindow>(NProps.NavigationStopped, (s, a) => s.NavigationStopped += a.EventHandler);
    }

    void GenerateDataGridCell()
    {
      Register<DataGridCell>(NProps.IsEditing, DataGridCell.IsEditingProperty, NConverters.ToBool);
      Register<DataGridCell>(NProps.IsSelected, DataGridCell.IsSelectedProperty, NConverters.ToBool);
      RegisterEvent<DataGridCell>(NProps._Selected, DataGridCell.SelectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<DataGridCell>(NProps._Unselected, DataGridCell.UnselectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<DataGridCell>(NProps.Selected, (s, a) => s.Selected += a.EventHandler);
      RegisterEvent<DataGridCell>(NProps.Unselected, (s, a) => s.Unselected += a.EventHandler);
    }

    void GenerateFrame()
    {
      Register<Frame>(NProps.JournalOwnership, Frame.JournalOwnershipProperty, NConverters.ToEnum<JournalOwnership>);
      Register<Frame>(NProps.NavigationUIVisibility, Frame.NavigationUIVisibilityProperty, NConverters.ToEnum<NavigationUIVisibility>);
      Register<Frame>(NProps.SandboxExternalContent, Frame.SandboxExternalContentProperty, NConverters.ToBool);
      Register<Frame>(NProps.Source, Frame.SourceProperty, NConverters.ToUri);
      RegisterEvent<Frame>(NProps.ContentRendered, (s, a) => s.ContentRendered += a.EventHandler);
      RegisterEvent<Frame>(NProps.FragmentNavigation, (s, a) => s.FragmentNavigation += a.EventHandler);
      RegisterEvent<Frame>(NProps.LoadCompleted, (s, a) => s.LoadCompleted += a.EventHandler);
      RegisterEvent<Frame>(NProps.Navigated, (s, a) => s.Navigated += a.EventHandler);
      RegisterEvent<Frame>(NProps.Navigating, (s, a) => s.Navigating += a.EventHandler);
      RegisterEvent<Frame>(NProps.NavigationFailed, (s, a) => s.NavigationFailed += a.EventHandler);
      RegisterEvent<Frame>(NProps.NavigationProgress, (s, a) => s.NavigationProgress += a.EventHandler);
      RegisterEvent<Frame>(NProps.NavigationStopped, (s, a) => s.NavigationStopped += a.EventHandler);
    }

    void GenerateHeaderedContentControl()
    {
      Register<HeaderedContentControl>(NProps.Header, HeaderedContentControl.HeaderProperty);
      Register<HeaderedContentControl>(NProps.HeaderStringFormat, HeaderedContentControl.HeaderStringFormatProperty, NConverters.ToString);
      Register<HeaderedContentControl>(NProps.HeaderTemplate, HeaderedContentControl.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<HeaderedContentControl>(NProps.HeaderTemplateSelector, HeaderedContentControl.HeaderTemplateSelectorProperty);
    }

    void GenerateExpander()
    {
      Register<Expander>(NProps.ExpandDirection, Expander.ExpandDirectionProperty, NConverters.ToEnum<ExpandDirection>);
      Register<Expander>(NProps.IsExpanded, Expander.IsExpandedProperty, NConverters.ToBool);
      RegisterEvent<Expander>(NProps._Collapsed, Expander.CollapsedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<Expander>(NProps._Expanded, Expander.ExpandedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<Expander>(NProps.Collapsed, (s, a) => s.Collapsed += a.EventHandler);
      RegisterEvent<Expander>(NProps.Expanded, (s, a) => s.Expanded += a.EventHandler);
    }

    void GenerateTabItem()
    {
      Register<TabItem>(NProps.IsSelected, TabItem.IsSelectedProperty, NConverters.ToBool);
    }

    void GenerateLabel()
    {
      Register<Label>(NProps.Target, Label.TargetProperty);
    }

    void GenerateListBoxItem()
    {
      Register<ListBoxItem>(NProps.IsSelected, ListBoxItem.IsSelectedProperty, NConverters.ToBool);
      RegisterEvent<ListBoxItem>(NProps._Selected, ListBoxItem.SelectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ListBoxItem>(NProps._Unselected, ListBoxItem.UnselectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ListBoxItem>(NProps.Selected, (s, a) => s.Selected += a.EventHandler);
      RegisterEvent<ListBoxItem>(NProps.Unselected, (s, a) => s.Unselected += a.EventHandler);
    }

    void GenerateScrollViewer()
    {
      Register<ScrollViewer>(NProps.CanContentScroll, ScrollViewer.CanContentScrollProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.HorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<ScrollViewer>(NProps.IsDeferredScrollingEnabled, ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);
      Register<ScrollViewer>(NProps.PanningDeceleration, ScrollViewer.PanningDecelerationProperty, NConverters.ToDouble);
      Register<ScrollViewer>(NProps.PanningMode, ScrollViewer.PanningModeProperty, NConverters.ToEnum<PanningMode>);
      Register<ScrollViewer>(NProps.PanningRatio, ScrollViewer.PanningRatioProperty, NConverters.ToDouble);
      Register<ScrollViewer>(NProps.VerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerCanContentScroll, ScrollViewer.CanContentScrollProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerHorizontalScrollBarVisibility, ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerVerticalScrollBarVisibility, ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DependencyObject>(NProps.ScrollViewerIsDeferredScrollingEnabled, ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ScrollViewerPanningMode, ScrollViewer.PanningModeProperty, NConverters.ToEnum<PanningMode>);
      Register<DependencyObject>(NProps.ScrollViewerPanningDeceleration, ScrollViewer.PanningDecelerationProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.ScrollViewerPanningRatio, ScrollViewer.PanningRatioProperty, NConverters.ToDouble);
      RegisterEvent<ScrollViewer>(NProps._ScrollChanged, ScrollViewer.ScrollChangedEvent, a => (ScrollChangedEventHandler)a.EventHandler);
      RegisterEvent<ScrollViewer>(NProps.ScrollChanged, (s, a) => s.ScrollChanged += a.EventHandler);
    }

    void GenerateToolTip()
    {
      Register<ToolTip>(NProps.CustomPopupPlacementCallback, ToolTip.CustomPopupPlacementCallbackProperty);
      Register<ToolTip>(NProps.HasDropShadow, ToolTip.HasDropShadowProperty, NConverters.ToBool);
      Register<ToolTip>(NProps.HorizontalOffset, ToolTip.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<ToolTip>(NProps.IsOpen, ToolTip.IsOpenProperty, NConverters.ToBool);
      Register<ToolTip>(NProps.Placement, ToolTip.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<ToolTip>(NProps.PlacementRectangle, ToolTip.PlacementRectangleProperty);
      Register<ToolTip>(NProps.PlacementTarget, ToolTip.PlacementTargetProperty);
      Register<ToolTip>(NProps.StaysOpen, ToolTip.StaysOpenProperty, NConverters.ToBool);
      Register<ToolTip>(NProps.VerticalOffset, ToolTip.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<ToolTip>(NProps._Closed, ToolTip.ClosedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ToolTip>(NProps._Opened, ToolTip.OpenedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ToolTip>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<ToolTip>(NProps.Opened, (s, a) => s.Opened += a.EventHandler);
    }

    void GenerateButtonBase()
    {
      Register<ButtonBase>(NProps.ClickMode, ButtonBase.ClickModeProperty, NConverters.ToEnum<ClickMode>);
      Register<ButtonBase>(NProps.Command, ButtonBase.CommandProperty);
      Register<ButtonBase>(NProps.CommandParameter, ButtonBase.CommandParameterProperty);
      Register<ButtonBase>(NProps.CommandTarget, ButtonBase.CommandTargetProperty);
      RegisterEvent<ButtonBase>(NProps._Click, ButtonBase.ClickEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ButtonBase>(NProps.Click, (s, a) => s.Click += a.EventHandler);
    }

    void GenerateButton()
    {
      Register<Button>(NProps.IsCancel, Button.IsCancelProperty, NConverters.ToBool);
      Register<Button>(NProps.IsDefault, Button.IsDefaultProperty, NConverters.ToBool);
    }

    void GenerateDataGridColumnHeader()
    {
      Register<DataGridColumnHeader>(NProps.SeparatorBrush, (t, v) => t.SeparatorBrush = NConverters.ToBrushT(v, t.SeparatorBrush));
      Register<DataGridColumnHeader>(NProps.SeparatorVisibility, DataGridColumnHeader.SeparatorVisibilityProperty, NConverters.ToEnum<Visibility>);
    }

    void GenerateDataGridRowHeader()
    {
      Register<DataGridRowHeader>(NProps.SeparatorBrush, (t, v) => t.SeparatorBrush = NConverters.ToBrushT(v, t.SeparatorBrush));
      Register<DataGridRowHeader>(NProps.SeparatorVisibility, DataGridRowHeader.SeparatorVisibilityProperty, NConverters.ToEnum<Visibility>);
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
      RegisterEvent<ToggleButton>(NProps._Checked, ToggleButton.CheckedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ToggleButton>(NProps._Indeterminate, ToggleButton.IndeterminateEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ToggleButton>(NProps._Unchecked, ToggleButton.UncheckedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ToggleButton>(NProps.Checked, (s, a) => s.Checked += a.EventHandler);
      RegisterEvent<ToggleButton>(NProps.Indeterminate, (s, a) => s.Indeterminate += a.EventHandler);
      RegisterEvent<ToggleButton>(NProps.Unchecked, (s, a) => s.Unchecked += a.EventHandler);
    }

    void GenerateRadioButton()
    {
      Register<RadioButton>(NProps.GroupName, RadioButton.GroupNameProperty, NConverters.ToString);
    }

    void GenerateDataGridRow()
    {
      Register<DataGridRow>(NProps.DetailsTemplate, DataGridRow.DetailsTemplateProperty, NConverters.ToDataTemplate);
      Register<DataGridRow>(NProps.DetailsTemplateSelector, DataGridRow.DetailsTemplateSelectorProperty);
      Register<DataGridRow>(NProps.DetailsVisibility, DataGridRow.DetailsVisibilityProperty, NConverters.ToEnum<Visibility>);
      Register<DataGridRow>(NProps.Header, DataGridRow.HeaderProperty);
      Register<DataGridRow>(NProps.HeaderStyle, DataGridRow.HeaderStyleProperty, NConverters.ToStyle);
      Register<DataGridRow>(NProps.HeaderTemplate, DataGridRow.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<DataGridRow>(NProps.HeaderTemplateSelector, DataGridRow.HeaderTemplateSelectorProperty);
      Register<DataGridRow>(NProps.IsSelected, DataGridRow.IsSelectedProperty, NConverters.ToBool);
      Register<DataGridRow>(NProps.Item, DataGridRow.ItemProperty);
      Register<DataGridRow>(NProps.ItemsPanel, DataGridRow.ItemsPanelProperty);
      Register<DataGridRow>(NProps.ValidationErrorTemplate, DataGridRow.ValidationErrorTemplateProperty, NConverters.ToControlTemplate);
      RegisterEvent<DataGridRow>(NProps._Selected, DataGridRow.SelectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<DataGridRow>(NProps._Unselected, DataGridRow.UnselectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<DataGridRow>(NProps.Selected, (s, a) => s.Selected += a.EventHandler);
      RegisterEvent<DataGridRow>(NProps.Unselected, (s, a) => s.Unselected += a.EventHandler);
    }

    void GenerateDatePicker()
    {
      Register<DatePicker>(NProps.BlackoutDates, (t, v) => AssignListT(t.BlackoutDates, v));
      Register<DatePicker>(NProps.CalendarStyle, DatePicker.CalendarStyleProperty, NConverters.ToStyle);
      Register<DatePicker>(NProps.DisplayDate, DatePicker.DisplayDateProperty);
      Register<DatePicker>(NProps.DisplayDateEnd, DatePicker.DisplayDateEndProperty);
      Register<DatePicker>(NProps.DisplayDateStart, DatePicker.DisplayDateStartProperty);
      Register<DatePicker>(NProps.FirstDayOfWeek, DatePicker.FirstDayOfWeekProperty, NConverters.ToEnum<DayOfWeek>);
      Register<DatePicker>(NProps.IsDropDownOpen, DatePicker.IsDropDownOpenProperty, NConverters.ToBool);
      Register<DatePicker>(NProps.IsTodayHighlighted, DatePicker.IsTodayHighlightedProperty, NConverters.ToBool);
      Register<DatePicker>(NProps.SelectedDate, DatePicker.SelectedDateProperty);
      Register<DatePicker>(NProps.SelectedDateFormat, DatePicker.SelectedDateFormatProperty, NConverters.ToEnum<DatePickerFormat>);
      Register<DatePicker>(NProps.Text, DatePicker.TextProperty, NConverters.ToString);
      RegisterEvent<DatePicker>(NProps._SelectedDateChanged, DatePicker.SelectedDateChangedEvent, a => (EventHandler<SelectionChangedEventArgs>)a.EventHandler);
      RegisterEvent<DatePicker>(NProps.CalendarClosed, (s, a) => s.CalendarClosed += a.EventHandler);
      RegisterEvent<DatePicker>(NProps.CalendarOpened, (s, a) => s.CalendarOpened += a.EventHandler);
      RegisterEvent<DatePicker>(NProps.DateValidationError, (s, a) => s.DateValidationError += a.EventHandler);
      RegisterEvent<DatePicker>(NProps.SelectedDateChanged, (s, a) => s.SelectedDateChanged += a.EventHandler);
    }

    void GenerateFlowDocumentReader()
    {
      Register<FlowDocumentReader>(NProps.Document, FlowDocumentReader.DocumentProperty);
      Register<FlowDocumentReader>(NProps.IsFindEnabled, FlowDocumentReader.IsFindEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.IsInactiveSelectionHighlightEnabled, FlowDocumentReader.IsInactiveSelectionHighlightEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.IsPageViewEnabled, FlowDocumentReader.IsPageViewEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.IsPrintEnabled, FlowDocumentReader.IsPrintEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.IsScrollViewEnabled, FlowDocumentReader.IsScrollViewEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.IsTwoPageViewEnabled, FlowDocumentReader.IsTwoPageViewEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentReader>(NProps.MaxZoom, FlowDocumentReader.MaxZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentReader>(NProps.MinZoom, FlowDocumentReader.MinZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentReader>(NProps.SelectionBrush, (t, v) => t.SelectionBrush = NConverters.ToBrushT(v, t.SelectionBrush));
      Register<FlowDocumentReader>(NProps.SelectionOpacity, FlowDocumentReader.SelectionOpacityProperty, NConverters.ToDouble);
      Register<FlowDocumentReader>(NProps.ViewingMode, FlowDocumentReader.ViewingModeProperty, NConverters.ToEnum<FlowDocumentReaderViewingMode>);
      Register<FlowDocumentReader>(NProps.Zoom, FlowDocumentReader.ZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentReader>(NProps.ZoomIncrement, FlowDocumentReader.ZoomIncrementProperty, NConverters.ToDouble);
    }

    void GenerateFlowDocumentScrollViewer()
    {
      Register<FlowDocumentScrollViewer>(NProps.Document, FlowDocumentScrollViewer.DocumentProperty);
      Register<FlowDocumentScrollViewer>(NProps.HorizontalScrollBarVisibility, FlowDocumentScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<FlowDocumentScrollViewer>(NProps.IsInactiveSelectionHighlightEnabled, FlowDocumentScrollViewer.IsInactiveSelectionHighlightEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentScrollViewer>(NProps.IsSelectionEnabled, FlowDocumentScrollViewer.IsSelectionEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentScrollViewer>(NProps.IsToolBarVisible, FlowDocumentScrollViewer.IsToolBarVisibleProperty, NConverters.ToBool);
      Register<FlowDocumentScrollViewer>(NProps.MaxZoom, FlowDocumentScrollViewer.MaxZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentScrollViewer>(NProps.MinZoom, FlowDocumentScrollViewer.MinZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentScrollViewer>(NProps.SelectionBrush, (t, v) => t.SelectionBrush = NConverters.ToBrushT(v, t.SelectionBrush));
      Register<FlowDocumentScrollViewer>(NProps.SelectionOpacity, FlowDocumentScrollViewer.SelectionOpacityProperty, NConverters.ToDouble);
      Register<FlowDocumentScrollViewer>(NProps.VerticalScrollBarVisibility, FlowDocumentScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<FlowDocumentScrollViewer>(NProps.Zoom, FlowDocumentScrollViewer.ZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentScrollViewer>(NProps.ZoomIncrement, FlowDocumentScrollViewer.ZoomIncrementProperty, NConverters.ToDouble);
    }

    void GenerateItemsControl()
    {
      Register<ItemsControl>(NProps.AlternationCount, ItemsControl.AlternationCountProperty, NConverters.ToInt32);
      Register<ItemsControl>(NProps.DisplayMemberPath, ItemsControl.DisplayMemberPathProperty, NConverters.ToString);
      Register<ItemsControl>(NProps.GroupStyle, (t, v) => AssignListT(t.GroupStyle, v));
      Register<ItemsControl>(NProps.GroupStyleSelector, ItemsControl.GroupStyleSelectorProperty);
      Register<ItemsControl>(NProps.IsTextSearchCaseSensitive, ItemsControl.IsTextSearchCaseSensitiveProperty, NConverters.ToBool);
      Register<ItemsControl>(NProps.IsTextSearchEnabled, ItemsControl.IsTextSearchEnabledProperty, NConverters.ToBool);
      Register<ItemsControl>(NProps.ItemBindingGroup, ItemsControl.ItemBindingGroupProperty);
      Register<ItemsControl>(NProps.ItemContainerStyle, ItemsControl.ItemContainerStyleProperty, NConverters.ToStyle);
      Register<ItemsControl>(NProps.ItemContainerStyleSelector, ItemsControl.ItemContainerStyleSelectorProperty);
      Register<ItemsControl>(NProps.Items, (t, v) => AssignList(t.Items, v));
      Register<ItemsControl>(NProps.ItemsPanel, ItemsControl.ItemsPanelProperty);
      Register<ItemsControl>(NProps.ItemsSource, ItemsControl.ItemsSourceProperty);
      Register<ItemsControl>(NProps.ItemStringFormat, ItemsControl.ItemStringFormatProperty, NConverters.ToString);
      Register<ItemsControl>(NProps.ItemTemplate, ItemsControl.ItemTemplateProperty, NConverters.ToDataTemplate);
      Register<ItemsControl>(NProps.ItemTemplateSelector, ItemsControl.ItemTemplateSelectorProperty);
    }

    void GenerateHeaderedItemsControl()
    {
      Register<HeaderedItemsControl>(NProps.Header, HeaderedItemsControl.HeaderProperty);
      Register<HeaderedItemsControl>(NProps.HeaderStringFormat, HeaderedItemsControl.HeaderStringFormatProperty, NConverters.ToString);
      Register<HeaderedItemsControl>(NProps.HeaderTemplate, HeaderedItemsControl.HeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<HeaderedItemsControl>(NProps.HeaderTemplateSelector, HeaderedItemsControl.HeaderTemplateSelectorProperty);
    }

    void GenerateMenuItem()
    {
      Register<MenuItem>(NProps.Command, MenuItem.CommandProperty);
      Register<MenuItem>(NProps.CommandParameter, MenuItem.CommandParameterProperty);
      Register<MenuItem>(NProps.CommandTarget, MenuItem.CommandTargetProperty);
      Register<MenuItem>(NProps.Icon, MenuItem.IconProperty);
      Register<MenuItem>(NProps.InputGestureText, MenuItem.InputGestureTextProperty, NConverters.ToString);
      Register<MenuItem>(NProps.IsCheckable, MenuItem.IsCheckableProperty, NConverters.ToBool);
      Register<MenuItem>(NProps.IsChecked, MenuItem.IsCheckedProperty, NConverters.ToBool);
      Register<MenuItem>(NProps.IsSubmenuOpen, MenuItem.IsSubmenuOpenProperty, NConverters.ToBool);
      Register<MenuItem>(NProps.ItemContainerTemplateSelector, MenuItem.ItemContainerTemplateSelectorProperty);
      Register<MenuItem>(NProps.StaysOpenOnClick, MenuItem.StaysOpenOnClickProperty, NConverters.ToBool);
      Register<MenuItem>(NProps.UsesItemContainerTemplate, MenuItem.UsesItemContainerTemplateProperty, NConverters.ToBool);
      RegisterEvent<MenuItem>(NProps._Checked, MenuItem.CheckedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MenuItem>(NProps._Click, MenuItem.ClickEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MenuItem>(NProps._SubmenuClosed, MenuItem.SubmenuClosedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MenuItem>(NProps._SubmenuOpened, MenuItem.SubmenuOpenedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MenuItem>(NProps._Unchecked, MenuItem.UncheckedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MenuItem>(NProps.Checked, (s, a) => s.Checked += a.EventHandler);
      RegisterEvent<MenuItem>(NProps.Click, (s, a) => s.Click += a.EventHandler);
      RegisterEvent<MenuItem>(NProps.SubmenuClosed, (s, a) => s.SubmenuClosed += a.EventHandler);
      RegisterEvent<MenuItem>(NProps.SubmenuOpened, (s, a) => s.SubmenuOpened += a.EventHandler);
      RegisterEvent<MenuItem>(NProps.Unchecked, (s, a) => s.Unchecked += a.EventHandler);
    }

    void GenerateToolBar()
    {
      Register<ToolBar>(NProps.Band, ToolBar.BandProperty, NConverters.ToInt32);
      Register<ToolBar>(NProps.BandIndex, ToolBar.BandIndexProperty, NConverters.ToInt32);
      Register<ToolBar>(NProps.IsOverflowOpen, ToolBar.IsOverflowOpenProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ToolBarOverflowMode, ToolBar.OverflowModeProperty, NConverters.ToEnum<OverflowMode>);
    }

    void GenerateTreeViewItem()
    {
      Register<TreeViewItem>(NProps.IsExpanded, TreeViewItem.IsExpandedProperty, NConverters.ToBool);
      Register<TreeViewItem>(NProps.IsSelected, TreeViewItem.IsSelectedProperty, NConverters.ToBool);
      RegisterEvent<TreeViewItem>(NProps._Collapsed, TreeViewItem.CollapsedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps._Expanded, TreeViewItem.ExpandedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps._Selected, TreeViewItem.SelectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps._Unselected, TreeViewItem.UnselectedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps.Collapsed, (s, a) => s.Collapsed += a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps.Expanded, (s, a) => s.Expanded += a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps.Selected, (s, a) => s.Selected += a.EventHandler);
      RegisterEvent<TreeViewItem>(NProps.Unselected, (s, a) => s.Unselected += a.EventHandler);
    }

    void GenerateTreeView()
    {
      Register<TreeView>(NProps.SelectedValuePath, TreeView.SelectedValuePathProperty, NConverters.ToString);
      RegisterEvent<TreeView>(NProps._SelectedItemChanged, TreeView.SelectedItemChangedEvent, a => (RoutedPropertyChangedEventHandler<Object>)a.EventHandler);
      RegisterEvent<TreeView>(NProps.SelectedItemChanged, (s, a) => s.SelectedItemChanged += a.EventHandler);
    }

    void GenerateMenuBase()
    {
      Register<MenuBase>(NProps.ItemContainerTemplateSelector, MenuBase.ItemContainerTemplateSelectorProperty);
      Register<MenuBase>(NProps.UsesItemContainerTemplate, MenuBase.UsesItemContainerTemplateProperty, NConverters.ToBool);
    }

    void GenerateContextMenu()
    {
      Register<ContextMenu>(NProps.CustomPopupPlacementCallback, ContextMenu.CustomPopupPlacementCallbackProperty);
      Register<ContextMenu>(NProps.HasDropShadow, ContextMenu.HasDropShadowProperty, NConverters.ToBool);
      Register<ContextMenu>(NProps.HorizontalOffset, ContextMenu.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<ContextMenu>(NProps.IsOpen, ContextMenu.IsOpenProperty, NConverters.ToBool);
      Register<ContextMenu>(NProps.Placement, ContextMenu.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<ContextMenu>(NProps.PlacementRectangle, ContextMenu.PlacementRectangleProperty);
      Register<ContextMenu>(NProps.PlacementTarget, ContextMenu.PlacementTargetProperty);
      Register<ContextMenu>(NProps.StaysOpen, ContextMenu.StaysOpenProperty, NConverters.ToBool);
      Register<ContextMenu>(NProps.VerticalOffset, ContextMenu.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<ContextMenu>(NProps._Closed, ContextMenu.ClosedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ContextMenu>(NProps._Opened, ContextMenu.OpenedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<ContextMenu>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<ContextMenu>(NProps.Opened, (s, a) => s.Opened += a.EventHandler);
    }

    void GenerateMenu()
    {
      Register<Menu>(NProps.IsMainMenu, Menu.IsMainMenuProperty, NConverters.ToBool);
    }

    void GenerateSelector()
    {
      Register<Selector>(NProps.IsSynchronizedWithCurrentItem, Selector.IsSynchronizedWithCurrentItemProperty, NConverters.ToBoolN);
      Register<Selector>(NProps.SelectedIndex, Selector.SelectedIndexProperty, NConverters.ToInt32);
      Register<Selector>(NProps.SelectedItem, Selector.SelectedItemProperty);
      Register<Selector>(NProps.SelectedValue, Selector.SelectedValueProperty);
      Register<Selector>(NProps.SelectedValuePath, Selector.SelectedValuePathProperty, NConverters.ToString);
      Register<DependencyObject>(NProps.SelectorIsSelected, Selector.IsSelectedProperty, NConverters.ToBool);
      RegisterEvent<Selector>(NProps._SelectionChanged, Selector.SelectionChangedEvent, a => (SelectionChangedEventHandler)a.EventHandler);
      RegisterEvent<Selector>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
    }

    void GenerateComboBox()
    {
      Register<ComboBox>(NProps.IsDropDownOpen, ComboBox.IsDropDownOpenProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.IsEditable, ComboBox.IsEditableProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.IsReadOnly, ComboBox.IsReadOnlyProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.MaxDropDownHeight, ComboBox.MaxDropDownHeightProperty, NConverters.ToDouble);
      Register<ComboBox>(NProps.ShouldPreserveUserEnteredPrefix, ComboBox.ShouldPreserveUserEnteredPrefixProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.StaysOpenOnEdit, ComboBox.StaysOpenOnEditProperty, NConverters.ToBool);
      Register<ComboBox>(NProps.Text, ComboBox.TextProperty, NConverters.ToString);
      RegisterEvent<ComboBox>(NProps.DropDownClosed, (s, a) => s.DropDownClosed += a.EventHandler);
      RegisterEvent<ComboBox>(NProps.DropDownOpened, (s, a) => s.DropDownOpened += a.EventHandler);
    }

    void GenerateListBox()
    {
      Register<ListBox>(NProps.SelectedItems, (t, v) => AssignList(t.SelectedItems, v));
      Register<ListBox>(NProps.SelectionMode, ListBox.SelectionModeProperty, NConverters.ToEnum<SelectionMode>);
    }

    void GenerateListView()
    {
      Register<ListView>(NProps.View, ListView.ViewProperty);
    }

    void GenerateTabControl()
    {
      Register<TabControl>(NProps.ContentStringFormat, TabControl.ContentStringFormatProperty, NConverters.ToString);
      Register<TabControl>(NProps.ContentTemplate, TabControl.ContentTemplateProperty, NConverters.ToDataTemplate);
      Register<TabControl>(NProps.ContentTemplateSelector, TabControl.ContentTemplateSelectorProperty);
      Register<TabControl>(NProps.TabStripPlacement, TabControl.TabStripPlacementProperty, NConverters.ToEnum<Dock>);
    }

    void GenerateMultiSelector()
    {
      Register<MultiSelector>(NProps.SelectedItems, (t, v) => AssignList(t.SelectedItems, v));
    }

    void GenerateDataGrid()
    {
      Register<DataGrid>(NProps.AlternatingRowBackground, (t, v) => t.AlternatingRowBackground = NConverters.ToBrushT(v, t.AlternatingRowBackground));
      Register<DataGrid>(NProps.AreRowDetailsFrozen, DataGrid.AreRowDetailsFrozenProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.AutoGenerateColumns, DataGrid.AutoGenerateColumnsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserAddRows, DataGrid.CanUserAddRowsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserDeleteRows, DataGrid.CanUserDeleteRowsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserReorderColumns, DataGrid.CanUserReorderColumnsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserResizeColumns, DataGrid.CanUserResizeColumnsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserResizeRows, DataGrid.CanUserResizeRowsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CanUserSortColumns, DataGrid.CanUserSortColumnsProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.CellStyle, DataGrid.CellStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.ClipboardCopyMode, DataGrid.ClipboardCopyModeProperty, NConverters.ToEnum<DataGridClipboardCopyMode>);
      Register<DataGrid>(NProps.ColumnHeaderHeight, DataGrid.ColumnHeaderHeightProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.ColumnHeaderStyle, DataGrid.ColumnHeaderStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.Columns, (t, v) => AssignListT(t.Columns, v));
      Register<DataGrid>(NProps.ColumnWidth, DataGrid.ColumnWidthProperty);
      Register<DataGrid>(NProps.CurrentCell, DataGrid.CurrentCellProperty);
      Register<DataGrid>(NProps.CurrentColumn, DataGrid.CurrentColumnProperty);
      Register<DataGrid>(NProps.CurrentItem, DataGrid.CurrentItemProperty);
      Register<DataGrid>(NProps.DragIndicatorStyle, DataGrid.DragIndicatorStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.DropLocationIndicatorStyle, DataGrid.DropLocationIndicatorStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.EnableColumnVirtualization, DataGrid.EnableColumnVirtualizationProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.EnableRowVirtualization, DataGrid.EnableRowVirtualizationProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.FrozenColumnCount, DataGrid.FrozenColumnCountProperty, NConverters.ToInt32);
      Register<DataGrid>(NProps.GridLinesVisibility, DataGrid.GridLinesVisibilityProperty, NConverters.ToEnum<DataGridGridLinesVisibility>);
      Register<DataGrid>(NProps.HeadersVisibility, DataGrid.HeadersVisibilityProperty, NConverters.ToEnum<DataGridHeadersVisibility>);
      Register<DataGrid>(NProps.HorizontalGridLinesBrush, (t, v) => t.HorizontalGridLinesBrush = NConverters.ToBrushT(v, t.HorizontalGridLinesBrush));
      Register<DataGrid>(NProps.HorizontalScrollBarVisibility, DataGrid.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<DataGrid>(NProps.IsReadOnly, DataGrid.IsReadOnlyProperty, NConverters.ToBool);
      Register<DataGrid>(NProps.MaxColumnWidth, DataGrid.MaxColumnWidthProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.MinColumnWidth, DataGrid.MinColumnWidthProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.MinRowHeight, DataGrid.MinRowHeightProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.RowBackground, (t, v) => t.RowBackground = NConverters.ToBrushT(v, t.RowBackground));
      Register<DataGrid>(NProps.RowDetailsTemplate, DataGrid.RowDetailsTemplateProperty, NConverters.ToDataTemplate);
      Register<DataGrid>(NProps.RowDetailsTemplateSelector, DataGrid.RowDetailsTemplateSelectorProperty);
      Register<DataGrid>(NProps.RowDetailsVisibilityMode, DataGrid.RowDetailsVisibilityModeProperty, NConverters.ToEnum<DataGridRowDetailsVisibilityMode>);
      Register<DataGrid>(NProps.RowHeaderStyle, DataGrid.RowHeaderStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.RowHeaderTemplate, DataGrid.RowHeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<DataGrid>(NProps.RowHeaderTemplateSelector, DataGrid.RowHeaderTemplateSelectorProperty);
      Register<DataGrid>(NProps.RowHeaderWidth, DataGrid.RowHeaderWidthProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.RowHeight, DataGrid.RowHeightProperty, NConverters.ToDouble);
      Register<DataGrid>(NProps.RowStyle, DataGrid.RowStyleProperty, NConverters.ToStyle);
      Register<DataGrid>(NProps.RowStyleSelector, DataGrid.RowStyleSelectorProperty);
      Register<DataGrid>(NProps.RowValidationErrorTemplate, DataGrid.RowValidationErrorTemplateProperty, NConverters.ToControlTemplate);
      Register<DataGrid>(NProps.RowValidationRules, (t, v) => AssignListT(t.RowValidationRules, v));
      Register<DataGrid>(NProps.SelectionMode, DataGrid.SelectionModeProperty, NConverters.ToEnum<DataGridSelectionMode>);
      Register<DataGrid>(NProps.SelectionUnit, DataGrid.SelectionUnitProperty, NConverters.ToEnum<DataGridSelectionUnit>);
      Register<DataGrid>(NProps.VerticalGridLinesBrush, (t, v) => t.VerticalGridLinesBrush = NConverters.ToBrushT(v, t.VerticalGridLinesBrush));
      Register<DataGrid>(NProps.VerticalScrollBarVisibility, DataGrid.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      RegisterEvent<DataGrid>(NProps.AddingNewItem, (s, a) => s.AddingNewItem += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.AutoGeneratedColumns, (s, a) => s.AutoGeneratedColumns += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.AutoGeneratingColumn, (s, a) => s.AutoGeneratingColumn += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.BeginningEdit, (s, a) => s.BeginningEdit += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.CellEditEnding, (s, a) => s.CellEditEnding += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnDisplayIndexChanged, (s, a) => s.ColumnDisplayIndexChanged += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnHeaderDragCompleted, (s, a) => s.ColumnHeaderDragCompleted += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnHeaderDragDelta, (s, a) => s.ColumnHeaderDragDelta += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnHeaderDragStarted, (s, a) => s.ColumnHeaderDragStarted += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnReordered, (s, a) => s.ColumnReordered += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.ColumnReordering, (s, a) => s.ColumnReordering += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.CopyingRowClipboardContent, (s, a) => s.CopyingRowClipboardContent += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.CurrentCellChanged, (s, a) => s.CurrentCellChanged += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.InitializingNewItem, (s, a) => s.InitializingNewItem += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.LoadingRow, (s, a) => s.LoadingRow += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.LoadingRowDetails, (s, a) => s.LoadingRowDetails += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.PreparingCellForEdit, (s, a) => s.PreparingCellForEdit += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.RowDetailsVisibilityChanged, (s, a) => s.RowDetailsVisibilityChanged += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.RowEditEnding, (s, a) => s.RowEditEnding += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.SelectedCellsChanged, (s, a) => s.SelectedCellsChanged += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.Sorting, (s, a) => s.Sorting += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.UnloadingRow, (s, a) => s.UnloadingRow += a.EventHandler);
      RegisterEvent<DataGrid>(NProps.UnloadingRowDetails, (s, a) => s.UnloadingRowDetails += a.EventHandler);
    }

    void GenerateStatusBar()
    {
      Register<StatusBar>(NProps.ItemContainerTemplateSelector, StatusBar.ItemContainerTemplateSelectorProperty);
      Register<StatusBar>(NProps.UsesItemContainerTemplate, StatusBar.UsesItemContainerTemplateProperty, NConverters.ToBool);
    }

    void GeneratePasswordBox()
    {
      Register<PasswordBox>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.ToBrushT(v, t.CaretBrush));
      Register<PasswordBox>(NProps.IsInactiveSelectionHighlightEnabled, PasswordBox.IsInactiveSelectionHighlightEnabledProperty, NConverters.ToBool);
      Register<PasswordBox>(NProps.MaxLength, PasswordBox.MaxLengthProperty, NConverters.ToInt32);
      Register<PasswordBox>(NProps.Password, (t, v) => t.Password = NConverters.ToStringT(v));
      Register<PasswordBox>(NProps.PasswordChar, PasswordBox.PasswordCharProperty, NConverters.ToChar);
      Register<PasswordBox>(NProps.SelectionBrush, (t, v) => t.SelectionBrush = NConverters.ToBrushT(v, t.SelectionBrush));
      Register<PasswordBox>(NProps.SelectionOpacity, PasswordBox.SelectionOpacityProperty, NConverters.ToDouble);
      RegisterEvent<PasswordBox>(NProps._PasswordChanged, PasswordBox.PasswordChangedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<PasswordBox>(NProps.PasswordChanged, (s, a) => s.PasswordChanged += a.EventHandler);
    }

    void GenerateDocumentViewerBase()
    {
      Register<DocumentViewerBase>(NProps.Document, DocumentViewerBase.DocumentProperty);
      Register<DocumentViewerBase>(NProps.PageViews, (t, v) => AssignListT(t.PageViews, v));
      Register<DependencyObject>(NProps.DocumentViewerBaseIsMasterPage, DocumentViewerBase.IsMasterPageProperty, NConverters.ToBool);
      RegisterEvent<DocumentViewerBase>(NProps.PageViewsChanged, (s, a) => s.PageViewsChanged += a.EventHandler);
    }

    void GenerateDocumentViewer()
    {
      Register<DocumentViewer>(NProps.HorizontalOffset, DocumentViewer.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<DocumentViewer>(NProps.HorizontalPageSpacing, DocumentViewer.HorizontalPageSpacingProperty, NConverters.ToDouble);
      Register<DocumentViewer>(NProps.MaxPagesAcross, DocumentViewer.MaxPagesAcrossProperty, NConverters.ToInt32);
      Register<DocumentViewer>(NProps.ShowPageBorders, DocumentViewer.ShowPageBordersProperty, NConverters.ToBool);
      Register<DocumentViewer>(NProps.VerticalOffset, DocumentViewer.VerticalOffsetProperty, NConverters.ToDouble);
      Register<DocumentViewer>(NProps.VerticalPageSpacing, DocumentViewer.VerticalPageSpacingProperty, NConverters.ToDouble);
      Register<DocumentViewer>(NProps.Zoom, DocumentViewer.ZoomProperty, NConverters.ToDouble);
    }

    void GenerateFlowDocumentPageViewer()
    {
      Register<FlowDocumentPageViewer>(NProps.IsInactiveSelectionHighlightEnabled, FlowDocumentPageViewer.IsInactiveSelectionHighlightEnabledProperty, NConverters.ToBool);
      Register<FlowDocumentPageViewer>(NProps.MaxZoom, FlowDocumentPageViewer.MaxZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentPageViewer>(NProps.MinZoom, FlowDocumentPageViewer.MinZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentPageViewer>(NProps.SelectionBrush, (t, v) => t.SelectionBrush = NConverters.ToBrushT(v, t.SelectionBrush));
      Register<FlowDocumentPageViewer>(NProps.SelectionOpacity, FlowDocumentPageViewer.SelectionOpacityProperty, NConverters.ToDouble);
      Register<FlowDocumentPageViewer>(NProps.Zoom, FlowDocumentPageViewer.ZoomProperty, NConverters.ToDouble);
      Register<FlowDocumentPageViewer>(NProps.ZoomIncrement, FlowDocumentPageViewer.ZoomIncrementProperty, NConverters.ToDouble);
    }

    void GenerateRangeBase()
    {
      Register<RangeBase>(NProps.LargeChange, RangeBase.LargeChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Maximum, RangeBase.MaximumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Minimum, RangeBase.MinimumProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.SmallChange, RangeBase.SmallChangeProperty, NConverters.ToDouble);
      Register<RangeBase>(NProps.Value, RangeBase.ValueProperty, NConverters.ToDouble);
      RegisterEvent<RangeBase>(NProps._ValueChanged, RangeBase.ValueChangedEvent, a => (RoutedPropertyChangedEventHandler<Double>)a.EventHandler);
      RegisterEvent<RangeBase>(NProps.ValueChanged, (s, a) => s.ValueChanged += a.EventHandler);
    }

    void GenerateProgressBar()
    {
      Register<ProgressBar>(NProps.IsIndeterminate, ProgressBar.IsIndeterminateProperty, NConverters.ToBool);
      Register<ProgressBar>(NProps.Orientation, ProgressBar.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GenerateSlider()
    {
      Register<Slider>(NProps.AutoToolTipPlacement, Slider.AutoToolTipPlacementProperty, NConverters.ToEnum<AutoToolTipPlacement>);
      Register<Slider>(NProps.AutoToolTipPrecision, Slider.AutoToolTipPrecisionProperty, NConverters.ToInt32);
      Register<Slider>(NProps.Delay, Slider.DelayProperty, NConverters.ToInt32);
      Register<Slider>(NProps.Interval, Slider.IntervalProperty, NConverters.ToInt32);
      Register<Slider>(NProps.IsDirectionReversed, Slider.IsDirectionReversedProperty, NConverters.ToBool);
      Register<Slider>(NProps.IsMoveToPointEnabled, Slider.IsMoveToPointEnabledProperty, NConverters.ToBool);
      Register<Slider>(NProps.IsSelectionRangeEnabled, Slider.IsSelectionRangeEnabledProperty, NConverters.ToBool);
      Register<Slider>(NProps.IsSnapToTickEnabled, Slider.IsSnapToTickEnabledProperty, NConverters.ToBool);
      Register<Slider>(NProps.Orientation, Slider.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<Slider>(NProps.SelectionEnd, Slider.SelectionEndProperty, NConverters.ToDouble);
      Register<Slider>(NProps.SelectionStart, Slider.SelectionStartProperty, NConverters.ToDouble);
      Register<Slider>(NProps.TickFrequency, Slider.TickFrequencyProperty, NConverters.ToDouble);
      Register<Slider>(NProps.TickPlacement, Slider.TickPlacementProperty, NConverters.ToEnum<TickPlacement>);
      Register<Slider>(NProps.Ticks, (t, v) => AssignListT(t.Ticks, v));
    }

    void GenerateScrollBar()
    {
      Register<ScrollBar>(NProps.Orientation, ScrollBar.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<ScrollBar>(NProps.ViewportSize, ScrollBar.ViewportSizeProperty, NConverters.ToDouble);
      RegisterEvent<ScrollBar>(NProps._Scroll, ScrollBar.ScrollEvent, a => (ScrollEventHandler)a.EventHandler);
      RegisterEvent<ScrollBar>(NProps.Scroll, (s, a) => s.Scroll += a.EventHandler);
    }

    void GenerateTextBoxBase()
    {
      Register<TextBoxBase>(NProps.AcceptsReturn, TextBoxBase.AcceptsReturnProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.AcceptsTab, TextBoxBase.AcceptsTabProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.AutoWordSelection, TextBoxBase.AutoWordSelectionProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.CaretBrush, (t, v) => t.CaretBrush = NConverters.ToBrushT(v, t.CaretBrush));
      Register<TextBoxBase>(NProps.HorizontalScrollBarVisibility, TextBoxBase.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      Register<TextBoxBase>(NProps.IsInactiveSelectionHighlightEnabled, TextBoxBase.IsInactiveSelectionHighlightEnabledProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.IsReadOnly, TextBoxBase.IsReadOnlyProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.IsReadOnlyCaretVisible, TextBoxBase.IsReadOnlyCaretVisibleProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.IsUndoEnabled, TextBoxBase.IsUndoEnabledProperty, NConverters.ToBool);
      Register<TextBoxBase>(NProps.SelectionBrush, (t, v) => t.SelectionBrush = NConverters.ToBrushT(v, t.SelectionBrush));
      Register<TextBoxBase>(NProps.SelectionOpacity, TextBoxBase.SelectionOpacityProperty, NConverters.ToDouble);
      Register<TextBoxBase>(NProps.UndoLimit, TextBoxBase.UndoLimitProperty, NConverters.ToInt32);
      Register<TextBoxBase>(NProps.VerticalScrollBarVisibility, TextBoxBase.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);
      RegisterEvent<TextBoxBase>(NProps._SelectionChanged, TextBoxBase.SelectionChangedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<TextBoxBase>(NProps._TextChanged, TextBoxBase.TextChangedEvent, a => (TextChangedEventHandler)a.EventHandler);
      RegisterEvent<TextBoxBase>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
      RegisterEvent<TextBoxBase>(NProps.TextChanged, (s, a) => s.TextChanged += a.EventHandler);
    }

    void GenerateRichTextBox()
    {
//      Register<RichTextBox>(NProps.CaretPosition);
//      Register<RichTextBox>(NProps.Document);
      Register<RichTextBox>(NProps.IsDocumentEnabled, RichTextBox.IsDocumentEnabledProperty, NConverters.ToBool);
    }

    void GenerateTextBox()
    {
      Register<TextBox>(NProps.CaretIndex, (t, v) => t.CaretIndex = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.CharacterCasing, TextBox.CharacterCasingProperty, NConverters.ToEnum<CharacterCasing>);
      Register<TextBox>(NProps.MaxLength, TextBox.MaxLengthProperty, NConverters.ToInt32);
      Register<TextBox>(NProps.MaxLines, TextBox.MaxLinesProperty, NConverters.ToInt32);
      Register<TextBox>(NProps.MinLines, TextBox.MinLinesProperty, NConverters.ToInt32);
      Register<TextBox>(NProps.SelectedText, (t, v) => t.SelectedText = NConverters.ToStringT(v));
      Register<TextBox>(NProps.SelectionLength, (t, v) => t.SelectionLength = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.SelectionStart, (t, v) => t.SelectionStart = NConverters.ToInt32T(v));
      Register<TextBox>(NProps.Text, TextBox.TextProperty, NConverters.ToString);
      Register<TextBox>(NProps.TextAlignment, TextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBox>(NProps.TextDecorations, (t, v) => AssignListT(t.TextDecorations, v));
      Register<TextBox>(NProps.TextWrapping, TextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
    }

    void GenerateThumb()
    {
      RegisterEvent<Thumb>(NProps._DragCompleted, Thumb.DragCompletedEvent, a => (DragCompletedEventHandler)a.EventHandler);
      RegisterEvent<Thumb>(NProps._DragDelta, Thumb.DragDeltaEvent, a => (DragDeltaEventHandler)a.EventHandler);
      RegisterEvent<Thumb>(NProps._DragStarted, Thumb.DragStartedEvent, a => (DragStartedEventHandler)a.EventHandler);
      RegisterEvent<Thumb>(NProps.DragCompleted, (s, a) => s.DragCompleted += a.EventHandler);
      RegisterEvent<Thumb>(NProps.DragDelta, (s, a) => s.DragDelta += a.EventHandler);
      RegisterEvent<Thumb>(NProps.DragStarted, (s, a) => s.DragStarted += a.EventHandler);
    }

    void GenerateGridSplitter()
    {
      Register<GridSplitter>(NProps.DragIncrement, GridSplitter.DragIncrementProperty, NConverters.ToDouble);
      Register<GridSplitter>(NProps.KeyboardIncrement, GridSplitter.KeyboardIncrementProperty, NConverters.ToDouble);
      Register<GridSplitter>(NProps.PreviewStyle, GridSplitter.PreviewStyleProperty, NConverters.ToStyle);
      Register<GridSplitter>(NProps.ResizeBehavior, GridSplitter.ResizeBehaviorProperty, NConverters.ToEnum<GridResizeBehavior>);
      Register<GridSplitter>(NProps.ResizeDirection, GridSplitter.ResizeDirectionProperty, NConverters.ToEnum<GridResizeDirection>);
      Register<GridSplitter>(NProps.ShowsPreview, GridSplitter.ShowsPreviewProperty, NConverters.ToBool);
    }

    void GenerateDecorator()
    {
      Register<Decorator>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateAdornerDecorator()
    {
      Register<AdornerDecorator>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateBorder()
    {
      Register<Border>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Border>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Border>(NProps.BorderThickness, Border.BorderThicknessProperty, NConverters.ToThickness);
      Register<Border>(NProps.CornerRadius, Border.CornerRadiusProperty, NConverters.ToCornerRadius);
      Register<Border>(NProps.Padding, Border.PaddingProperty, NConverters.ToThickness);
    }

    void GenerateInkPresenter()
    {
      Register<InkPresenter>(NProps.Strokes, (t, v) => AssignListT(t.Strokes, v));
    }

    void GenerateViewbox()
    {
      Register<Viewbox>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
      Register<Viewbox>(NProps.Stretch, Viewbox.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<Viewbox>(NProps.StretchDirection, Viewbox.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
    }

    void GenerateBulletDecorator()
    {
      Register<BulletDecorator>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<BulletDecorator>(NProps.Bullet, (t, v) => AssignSingle(o => o.Bullet, (o, i) => o.Bullet = i, t, v));
    }

    void GenerateImage()
    {
      Register<Image>(NProps.Source, Image.SourceProperty);
      Register<Image>(NProps.Stretch, Image.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<Image>(NProps.StretchDirection, Image.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
      RegisterEvent<Image>(NProps._ImageFailed, Image.ImageFailedEvent, a => (EventHandler<ExceptionRoutedEventArgs>)a.EventHandler);
      RegisterEvent<Image>(NProps.ImageFailed, (s, a) => s.ImageFailed += a.EventHandler);
    }

    void GenerateInkCanvas()
    {
      Register<InkCanvas>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<InkCanvas>(NProps.Children, (t, v) => AssignList(t.Children, v));
      Register<InkCanvas>(NProps.DefaultDrawingAttributes, InkCanvas.DefaultDrawingAttributesProperty);
//      Register<InkCanvas>(NProps.DefaultStylusPointDescription);
      Register<InkCanvas>(NProps.EditingMode, InkCanvas.EditingModeProperty, NConverters.ToEnum<InkCanvasEditingMode>);
      Register<InkCanvas>(NProps.EditingModeInverted, InkCanvas.EditingModeInvertedProperty, NConverters.ToEnum<InkCanvasEditingMode>);
//      Register<InkCanvas>(NProps.EraserShape);
      Register<InkCanvas>(NProps.MoveEnabled, (t, v) => t.MoveEnabled = NConverters.ToBoolT(v));
//      Register<InkCanvas>(NProps.PreferredPasteFormats);
      Register<InkCanvas>(NProps.ResizeEnabled, (t, v) => t.ResizeEnabled = NConverters.ToBoolT(v));
      Register<InkCanvas>(NProps.Strokes, (t, v) => AssignListT(t.Strokes, v));
      Register<InkCanvas>(NProps.UseCustomCursor, (t, v) => t.UseCustomCursor = NConverters.ToBoolT(v));
      Register<UIElement>(NProps.InkCanvasTop, InkCanvas.TopProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.InkCanvasBottom, InkCanvas.BottomProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.InkCanvasLeft, InkCanvas.LeftProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.InkCanvasRight, InkCanvas.RightProperty, NConverters.ToDouble);
      RegisterEvent<InkCanvas>(NProps._ActiveEditingModeChanged, InkCanvas.ActiveEditingModeChangedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps._EditingModeChanged, InkCanvas.EditingModeChangedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps._EditingModeInvertedChanged, InkCanvas.EditingModeInvertedChangedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps._Gesture, InkCanvas.GestureEvent, a => (InkCanvasGestureEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps._StrokeCollected, InkCanvas.StrokeCollectedEvent, a => (InkCanvasStrokeCollectedEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps._StrokeErased, InkCanvas.StrokeErasedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.ActiveEditingModeChanged, (s, a) => s.ActiveEditingModeChanged += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.DefaultDrawingAttributesReplaced, (s, a) => s.DefaultDrawingAttributesReplaced += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.EditingModeChanged, (s, a) => s.EditingModeChanged += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.EditingModeInvertedChanged, (s, a) => s.EditingModeInvertedChanged += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.Gesture, (s, a) => s.Gesture += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionChanged, (s, a) => s.SelectionChanged += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionChanging, (s, a) => s.SelectionChanging += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionMoved, (s, a) => s.SelectionMoved += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionMoving, (s, a) => s.SelectionMoving += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionResized, (s, a) => s.SelectionResized += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.SelectionResizing, (s, a) => s.SelectionResizing += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.StrokeCollected, (s, a) => s.StrokeCollected += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.StrokeErased, (s, a) => s.StrokeErased += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.StrokeErasing, (s, a) => s.StrokeErasing += a.EventHandler);
      RegisterEvent<InkCanvas>(NProps.StrokesReplaced, (s, a) => s.StrokesReplaced += a.EventHandler);
    }

    void GenerateMediaElement()
    {
      Register<MediaElement>(NProps.Balance, MediaElement.BalanceProperty, NConverters.ToDouble);
//      Register<MediaElement>(NProps.Clock);
      Register<MediaElement>(NProps.IsMuted, MediaElement.IsMutedProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.LoadedBehavior, MediaElement.LoadedBehaviorProperty, NConverters.ToEnum<MediaState>);
      Register<MediaElement>(NProps.Position, (t, v) => t.Position = NConverters.ToTimeSpanT(v));
      Register<MediaElement>(NProps.ScrubbingEnabled, MediaElement.ScrubbingEnabledProperty, NConverters.ToBool);
      Register<MediaElement>(NProps.Source, MediaElement.SourceProperty, NConverters.ToUri);
//      Register<MediaElement>(NProps.SpeedRatio);
      Register<MediaElement>(NProps.Stretch, MediaElement.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<MediaElement>(NProps.StretchDirection, MediaElement.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
      Register<MediaElement>(NProps.UnloadedBehavior, MediaElement.UnloadedBehaviorProperty, NConverters.ToEnum<MediaState>);
      Register<MediaElement>(NProps.Volume, MediaElement.VolumeProperty, NConverters.ToDouble);
      RegisterEvent<MediaElement>(NProps._BufferingEnded, MediaElement.BufferingEndedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MediaElement>(NProps._BufferingStarted, MediaElement.BufferingStartedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MediaElement>(NProps._MediaEnded, MediaElement.MediaEndedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MediaElement>(NProps._MediaFailed, MediaElement.MediaFailedEvent, a => (EventHandler<ExceptionRoutedEventArgs>)a.EventHandler);
      RegisterEvent<MediaElement>(NProps._MediaOpened, MediaElement.MediaOpenedEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<MediaElement>(NProps._ScriptCommand, MediaElement.ScriptCommandEvent, a => (EventHandler<MediaScriptCommandRoutedEventArgs>)a.EventHandler);
      RegisterEvent<MediaElement>(NProps.BufferingEnded, (s, a) => s.BufferingEnded += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.BufferingStarted, (s, a) => s.BufferingStarted += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaEnded, (s, a) => s.MediaEnded += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaFailed, (s, a) => s.MediaFailed += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.MediaOpened, (s, a) => s.MediaOpened += a.EventHandler);
      RegisterEvent<MediaElement>(NProps.ScriptCommand, (s, a) => s.ScriptCommand += a.EventHandler);
    }

    void GeneratePage()
    {
      Register<Page>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Page>(NProps.Content, Page.ContentProperty);
      Register<Page>(NProps.FontFamily, Page.FontFamilyProperty, NConverters.ToFontFamily);
      Register<Page>(NProps.FontSize, Page.FontSizeProperty, NConverters.ToDouble);
      Register<Page>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<Page>(NProps.KeepAlive, Page.KeepAliveProperty, NConverters.ToBool);
      Register<Page>(NProps.ShowsNavigationUI, (t, v) => t.ShowsNavigationUI = NConverters.ToBoolT(v));
      Register<Page>(NProps.Template, Page.TemplateProperty, NConverters.ToControlTemplate);
      Register<Page>(NProps.Title, Page.TitleProperty, NConverters.ToString);
//      Register<Page>(NProps.WindowHeight);
      Register<Page>(NProps.WindowTitle, (t, v) => t.WindowTitle = NConverters.ToStringT(v));
//      Register<Page>(NProps.WindowWidth);
    }

    void GeneratePageFunctionBase()
    {
      Register<PageFunctionBase>(NProps.RemoveFromJournal, (t, v) => t.RemoveFromJournal = NConverters.ToBoolT(v));
    }

    void GeneratePanel()
    {
      Register<Panel>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<Panel>(NProps.Children, (t, v) => AssignList(t.Children, v));
      Register<Panel>(NProps.IsItemsHost, Panel.IsItemsHostProperty, NConverters.ToBool);
      Register<UIElement>(NProps.PanelZIndex, Panel.ZIndexProperty, NConverters.ToInt32);
    }

    void GenerateCanvas()
    {
      Register<UIElement>(NProps.CanvasLeft, Canvas.LeftProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasTop, Canvas.TopProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasRight, Canvas.RightProperty, NConverters.ToDouble);
      Register<UIElement>(NProps.CanvasBottom, Canvas.BottomProperty, NConverters.ToDouble);
    }

    void GenerateDockPanel()
    {
      Register<DockPanel>(NProps.LastChildFill, DockPanel.LastChildFillProperty, NConverters.ToBool);
      Register<UIElement>(NProps.DockPanelDock, DockPanel.DockProperty, NConverters.ToEnum<Dock>);
    }

    void GenerateGrid()
    {
      Register<Grid>(NProps.ColumnDefinitions, (t, v) => AssignListT(t.ColumnDefinitions, v));
      Register<Grid>(NProps.RowDefinitions, (t, v) => AssignListT(t.RowDefinitions, v));
      Register<Grid>(NProps.ShowGridLines, Grid.ShowGridLinesProperty, NConverters.ToBool);
      Register<UIElement>(NProps.GridColumn, Grid.ColumnProperty, NConverters.ToInt32);
      Register<UIElement>(NProps.GridRow, Grid.RowProperty, NConverters.ToInt32);
      Register<UIElement>(NProps.GridColumnSpan, Grid.ColumnSpanProperty, NConverters.ToInt32);
      Register<UIElement>(NProps.GridRowSpan, Grid.RowSpanProperty, NConverters.ToInt32);
      Register<UIElement>(NProps.GridIsSharedSizeScope, Grid.IsSharedSizeScopeProperty, NConverters.ToBool);
    }

    void GenerateSelectiveScrollingGrid()
    {
      Register<DependencyObject>(NProps.SelectiveScrollingGridSelectiveScrollingOrientation, SelectiveScrollingGrid.SelectiveScrollingOrientationProperty, NConverters.ToEnum<SelectiveScrollingOrientation>);
    }

    void GenerateStackPanel()
    {
      Register<StackPanel>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<StackPanel>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
      Register<StackPanel>(NProps.Orientation, StackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
//      Register<StackPanel>(NProps.ScrollOwner);
    }

    void GenerateVirtualizingPanel()
    {
      Register<DependencyObject>(NProps.VirtualizingPanelIsVirtualizing, VirtualizingPanel.IsVirtualizingProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.VirtualizingPanelVirtualizationMode, VirtualizingPanel.VirtualizationModeProperty, NConverters.ToEnum<VirtualizationMode>);
      Register<DependencyObject>(NProps.VirtualizingPanelIsVirtualizingWhenGrouping, VirtualizingPanel.IsVirtualizingWhenGroupingProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.VirtualizingPanelScrollUnit, VirtualizingPanel.ScrollUnitProperty, NConverters.ToEnum<ScrollUnit>);
      Register<DependencyObject>(NProps.VirtualizingPanelCacheLength, VirtualizingPanel.CacheLengthProperty);
      Register<DependencyObject>(NProps.VirtualizingPanelCacheLengthUnit, VirtualizingPanel.CacheLengthUnitProperty, NConverters.ToEnum<VirtualizationCacheLengthUnit>);
      Register<DependencyObject>(NProps.VirtualizingPanelIsContainerVirtualizable, VirtualizingPanel.IsContainerVirtualizableProperty, NConverters.ToBool);
    }

    void GenerateVirtualizingStackPanel()
    {
      Register<VirtualizingStackPanel>(NProps.CanHorizontallyScroll, (t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));
      Register<VirtualizingStackPanel>(NProps.CanVerticallyScroll, (t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));
      Register<VirtualizingStackPanel>(NProps.Orientation, VirtualizingStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
//      Register<VirtualizingStackPanel>(NProps.ScrollOwner);
    }

    void GenerateWrapPanel()
    {
      Register<WrapPanel>(NProps.ItemHeight, WrapPanel.ItemHeightProperty, NConverters.ToDouble);
      Register<WrapPanel>(NProps.ItemWidth, WrapPanel.ItemWidthProperty, NConverters.ToDouble);
      Register<WrapPanel>(NProps.Orientation, WrapPanel.OrientationProperty, NConverters.ToEnum<Orientation>);
    }

    void GenerateToolBarOverflowPanel()
    {
      Register<ToolBarOverflowPanel>(NProps.WrapWidth, ToolBarOverflowPanel.WrapWidthProperty, NConverters.ToDouble);
    }

    void GenerateUniformGrid()
    {
      Register<UniformGrid>(NProps.Columns, UniformGrid.ColumnsProperty, NConverters.ToInt32);
      Register<UniformGrid>(NProps.FirstColumn, UniformGrid.FirstColumnProperty, NConverters.ToInt32);
      Register<UniformGrid>(NProps.Rows, UniformGrid.RowsProperty, NConverters.ToInt32);
    }

    void GenerateTextBlock()
    {
      Register<TextBlock>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<TextBlock>(NProps.BaselineOffset, TextBlock.BaselineOffsetProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.FontFamily, TextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextBlock>(NProps.FontSize, TextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.FontStretch, TextBlock.FontStretchProperty, NConverters.ToFontStretch);
      Register<TextBlock>(NProps.FontStyle, TextBlock.FontStyleProperty, NConverters.ToFontStyle);
      Register<TextBlock>(NProps.FontWeight, TextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextBlock>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextBlock>(NProps.Inlines, (t, v) => AssignList(t.Inlines, v));
      Register<TextBlock>(NProps.IsHyphenationEnabled, TextBlock.IsHyphenationEnabledProperty, NConverters.ToBool);
      Register<TextBlock>(NProps.LineHeight, TextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<TextBlock>(NProps.LineStackingStrategy, TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<TextBlock>(NProps.Padding, TextBlock.PaddingProperty, NConverters.ToThickness);
      Register<TextBlock>(NProps.Text, TextBlock.TextProperty, NConverters.ToString);
      Register<TextBlock>(NProps.TextAlignment, TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<TextBlock>(NProps.TextDecorations, (t, v) => AssignListT(t.TextDecorations, v));
      Register<TextBlock>(NProps.TextEffects, (t, v) => AssignListT(t.TextEffects, v));
      Register<TextBlock>(NProps.TextTrimming, TextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);
      Register<TextBlock>(NProps.TextWrapping, TextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);
      Register<DependencyObject>(NProps.TextBlockBaselineOffset, TextBlock.BaselineOffsetProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.TextBlockFontFamily, TextBlock.FontFamilyProperty, NConverters.ToFontFamily);
      Register<DependencyObject>(NProps.TextBlockFontStyle, TextBlock.FontStyleProperty, NConverters.ToFontStyle);
      Register<DependencyObject>(NProps.TextBlockFontWeight, TextBlock.FontWeightProperty, NConverters.ToFontWeight);
      Register<DependencyObject>(NProps.TextBlockFontStretch, TextBlock.FontStretchProperty, NConverters.ToFontStretch);
      Register<DependencyObject>(NProps.TextBlockFontSize, TextBlock.FontSizeProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.TextBlockForeground, TextBlock.ForegroundProperty);
      Register<DependencyObject>(NProps.TextBlockLineHeight, TextBlock.LineHeightProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.TextBlockLineStackingStrategy, TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<DependencyObject>(NProps.TextBlockTextAlignment, TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateToolBarTray()
    {
      Register<ToolBarTray>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<ToolBarTray>(NProps.IsLocked, ToolBarTray.IsLockedProperty, NConverters.ToBool);
      Register<ToolBarTray>(NProps.Orientation, ToolBarTray.OrientationProperty, NConverters.ToEnum<Orientation>);
      Register<ToolBarTray>(NProps.ToolBars, (t, v) => AssignListT(t.ToolBars, v));
      Register<DependencyObject>(NProps.ToolBarTrayIsLocked, ToolBarTray.IsLockedProperty, NConverters.ToBool);
    }

    void GenerateViewport3D()
    {
      Register<Viewport3D>(NProps.Camera, Viewport3D.CameraProperty);
      Register<Viewport3D>(NProps.Children, (t, v) => AssignListT(t.Children, v));
    }

    void GenerateDocumentPageView()
    {
//      Register<DocumentPageView>(NProps.DocumentPaginator);
      Register<DocumentPageView>(NProps.PageNumber, DocumentPageView.PageNumberProperty, NConverters.ToInt32);
      Register<DocumentPageView>(NProps.Stretch, DocumentPageView.StretchProperty, NConverters.ToEnum<Stretch>);
      Register<DocumentPageView>(NProps.StretchDirection, DocumentPageView.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);
      RegisterEvent<DocumentPageView>(NProps.PageConnected, (s, a) => s.PageConnected += a.EventHandler);
      RegisterEvent<DocumentPageView>(NProps.PageDisconnected, (s, a) => s.PageDisconnected += a.EventHandler);
    }

    void GenerateGridViewRowPresenterBase()
    {
      Register<GridViewRowPresenterBase>(NProps.Columns, (t, v) => AssignListT(t.Columns, v));
    }

    void GenerateGridViewHeaderRowPresenter()
    {
      Register<GridViewHeaderRowPresenter>(NProps.AllowsColumnReorder, GridViewHeaderRowPresenter.AllowsColumnReorderProperty, NConverters.ToBool);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderContainerStyle, GridViewHeaderRowPresenter.ColumnHeaderContainerStyleProperty, NConverters.ToStyle);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderContextMenu, GridViewHeaderRowPresenter.ColumnHeaderContextMenuProperty);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderStringFormat, GridViewHeaderRowPresenter.ColumnHeaderStringFormatProperty, NConverters.ToString);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderTemplate, GridViewHeaderRowPresenter.ColumnHeaderTemplateProperty, NConverters.ToDataTemplate);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderTemplateSelector, GridViewHeaderRowPresenter.ColumnHeaderTemplateSelectorProperty);
      Register<GridViewHeaderRowPresenter>(NProps.ColumnHeaderToolTip, GridViewHeaderRowPresenter.ColumnHeaderToolTipProperty);
    }

    void GenerateGridViewRowPresenter()
    {
      Register<GridViewRowPresenter>(NProps.Content, GridViewRowPresenter.ContentProperty);
    }

    void GeneratePopup()
    {
      Register<Popup>(NProps.AllowsTransparency, Popup.AllowsTransparencyProperty, NConverters.ToBool);
      Register<Popup>(NProps.Child, Popup.ChildProperty);
      Register<Popup>(NProps.CustomPopupPlacementCallback, Popup.CustomPopupPlacementCallbackProperty);
      Register<Popup>(NProps.HorizontalOffset, Popup.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<Popup>(NProps.IsOpen, Popup.IsOpenProperty, NConverters.ToBool);
      Register<Popup>(NProps.Placement, Popup.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<Popup>(NProps.PlacementRectangle, Popup.PlacementRectangleProperty);
      Register<Popup>(NProps.PlacementTarget, Popup.PlacementTargetProperty);
      Register<Popup>(NProps.PopupAnimation, Popup.PopupAnimationProperty, NConverters.ToEnum<PopupAnimation>);
      Register<Popup>(NProps.StaysOpen, Popup.StaysOpenProperty, NConverters.ToBool);
      Register<Popup>(NProps.VerticalOffset, Popup.VerticalOffsetProperty, NConverters.ToDouble);
      RegisterEvent<Popup>(NProps.Closed, (s, a) => s.Closed += a.EventHandler);
      RegisterEvent<Popup>(NProps.Opened, (s, a) => s.Opened += a.EventHandler);
    }

    void GenerateTickBar()
    {
      Register<TickBar>(NProps.Fill, (t, v) => t.Fill = NConverters.ToBrushT(v, t.Fill));
      Register<TickBar>(NProps.IsDirectionReversed, TickBar.IsDirectionReversedProperty, NConverters.ToBool);
      Register<TickBar>(NProps.IsSelectionRangeEnabled, TickBar.IsSelectionRangeEnabledProperty, NConverters.ToBool);
      Register<TickBar>(NProps.Maximum, TickBar.MaximumProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.Minimum, TickBar.MinimumProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.Placement, TickBar.PlacementProperty, NConverters.ToEnum<TickBarPlacement>);
      Register<TickBar>(NProps.ReservedSpace, TickBar.ReservedSpaceProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.SelectionEnd, TickBar.SelectionEndProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.SelectionStart, TickBar.SelectionStartProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.TickFrequency, TickBar.TickFrequencyProperty, NConverters.ToDouble);
      Register<TickBar>(NProps.Ticks, (t, v) => AssignListT(t.Ticks, v));
    }

    void GenerateTrack()
    {
//      Register<Track>(NProps.DecreaseRepeatButton);
//      Register<Track>(NProps.IncreaseRepeatButton);
      Register<Track>(NProps.IsDirectionReversed, Track.IsDirectionReversedProperty, NConverters.ToBool);
      Register<Track>(NProps.Maximum, Track.MaximumProperty, NConverters.ToDouble);
      Register<Track>(NProps.Minimum, Track.MinimumProperty, NConverters.ToDouble);
      Register<Track>(NProps.Orientation, Track.OrientationProperty, NConverters.ToEnum<Orientation>);
//      Register<Track>(NProps.Thumb);
      Register<Track>(NProps.Value, Track.ValueProperty, NConverters.ToDouble);
      Register<Track>(NProps.ViewportSize, Track.ViewportSizeProperty, NConverters.ToDouble);
    }

    void GenerateWebBrowser()
    {
//      Register<WebBrowser>(NProps.ObjectForScripting);
      Register<WebBrowser>(NProps.Source, (t, v) => t.Source = NConverters.ToUriT(v));
      RegisterEvent<WebBrowser>(NProps.LoadCompleted, (s, a) => s.LoadCompleted += a.EventHandler);
      RegisterEvent<WebBrowser>(NProps.Navigated, (s, a) => s.Navigated += a.EventHandler);
      RegisterEvent<WebBrowser>(NProps.Navigating, (s, a) => s.Navigating += a.EventHandler);
    }

    void GenerateTextElement()
    {
      Register<TextElement>(NProps.Background, (t, v) => t.Background = NConverters.ToBrushT(v, t.Background));
      Register<TextElement>(NProps.FontFamily, TextElement.FontFamilyProperty, NConverters.ToFontFamily);
      Register<TextElement>(NProps.FontSize, TextElement.FontSizeProperty, NConverters.ToDouble);
      Register<TextElement>(NProps.FontStretch, TextElement.FontStretchProperty, NConverters.ToFontStretch);
      Register<TextElement>(NProps.FontStyle, TextElement.FontStyleProperty, NConverters.ToFontStyle);
      Register<TextElement>(NProps.FontWeight, TextElement.FontWeightProperty, NConverters.ToFontWeight);
      Register<TextElement>(NProps.Foreground, (t, v) => t.Foreground = NConverters.ToBrushT(v, t.Foreground));
      Register<TextElement>(NProps.TextEffects, (t, v) => AssignListT(t.TextEffects, v));
      Register<DependencyObject>(NProps.TextElementFontFamily, TextElement.FontFamilyProperty, NConverters.ToFontFamily);
      Register<DependencyObject>(NProps.TextElementFontStyle, TextElement.FontStyleProperty, NConverters.ToFontStyle);
      Register<DependencyObject>(NProps.TextElementFontWeight, TextElement.FontWeightProperty, NConverters.ToFontWeight);
      Register<DependencyObject>(NProps.TextElementFontStretch, TextElement.FontStretchProperty, NConverters.ToFontStretch);
      Register<DependencyObject>(NProps.TextElementFontSize, TextElement.FontSizeProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.TextElementForeground, TextElement.ForegroundProperty);
    }

    void GenerateBlock()
    {
      Register<Block>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<Block>(NProps.BorderThickness, Block.BorderThicknessProperty, NConverters.ToThickness);
      Register<Block>(NProps.BreakColumnBefore, Block.BreakColumnBeforeProperty, NConverters.ToBool);
      Register<Block>(NProps.BreakPageBefore, Block.BreakPageBeforeProperty, NConverters.ToBool);
      Register<Block>(NProps.ClearFloaters, Block.ClearFloatersProperty, NConverters.ToEnum<WrapDirection>);
      Register<Block>(NProps.FlowDirection, Block.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<Block>(NProps.IsHyphenationEnabled, Block.IsHyphenationEnabledProperty, NConverters.ToBool);
      Register<Block>(NProps.LineHeight, Block.LineHeightProperty, NConverters.ToDouble);
      Register<Block>(NProps.LineStackingStrategy, Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<Block>(NProps.Margin, Block.MarginProperty, NConverters.ToThickness);
      Register<Block>(NProps.Padding, Block.PaddingProperty, NConverters.ToThickness);
      Register<Block>(NProps.SiblingBlocks, (t, v) => AssignList(t.SiblingBlocks, v));
      Register<Block>(NProps.TextAlignment, Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<DependencyObject>(NProps.BlockIsHyphenationEnabled, Block.IsHyphenationEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.BlockTextAlignment, Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
      Register<DependencyObject>(NProps.BlockLineHeight, Block.LineHeightProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.BlockLineStackingStrategy, Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
    }

    void GenerateBlockUIContainer()
    {
      Register<BlockUIContainer>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateList()
    {
      Register<List>(NProps.ListItems, (t, v) => AssignList(t.ListItems, v));
      Register<List>(NProps.MarkerOffset, List.MarkerOffsetProperty, NConverters.ToDouble);
      Register<List>(NProps.MarkerStyle, List.MarkerStyleProperty, NConverters.ToEnum<TextMarkerStyle>);
      Register<List>(NProps.StartIndex, List.StartIndexProperty, NConverters.ToInt32);
    }

    void GenerateParagraph()
    {
      Register<Paragraph>(NProps.Inlines, (t, v) => AssignList(t.Inlines, v));
      Register<Paragraph>(NProps.KeepTogether, Paragraph.KeepTogetherProperty, NConverters.ToBool);
      Register<Paragraph>(NProps.KeepWithNext, Paragraph.KeepWithNextProperty, NConverters.ToBool);
      Register<Paragraph>(NProps.MinOrphanLines, Paragraph.MinOrphanLinesProperty, NConverters.ToInt32);
      Register<Paragraph>(NProps.MinWidowLines, Paragraph.MinWidowLinesProperty, NConverters.ToInt32);
      Register<Paragraph>(NProps.TextDecorations, (t, v) => AssignListT(t.TextDecorations, v));
      Register<Paragraph>(NProps.TextIndent, Paragraph.TextIndentProperty, NConverters.ToDouble);
    }

    void GenerateSection()
    {
      Register<Section>(NProps.Blocks, (t, v) => AssignList(t.Blocks, v));
      Register<Section>(NProps.HasTrailingParagraphBreakOnPaste, (t, v) => t.HasTrailingParagraphBreakOnPaste = NConverters.ToBoolT(v));
    }

    void GenerateTable()
    {
      Register<Table>(NProps.CellSpacing, Table.CellSpacingProperty, NConverters.ToDouble);
      Register<Table>(NProps.Columns, (t, v) => AssignListT(t.Columns, v));
      Register<Table>(NProps.RowGroups, (t, v) => AssignListT(t.RowGroups, v));
    }

    void GenerateInline()
    {
      Register<Inline>(NProps.BaselineAlignment, Inline.BaselineAlignmentProperty, NConverters.ToEnum<BaselineAlignment>);
      Register<Inline>(NProps.FlowDirection, Inline.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<Inline>(NProps.SiblingInlines, (t, v) => AssignList(t.SiblingInlines, v));
      Register<Inline>(NProps.TextDecorations, (t, v) => AssignListT(t.TextDecorations, v));
    }

    void GenerateAnchoredBlock()
    {
      Register<AnchoredBlock>(NProps.Blocks, (t, v) => AssignList(t.Blocks, v));
      Register<AnchoredBlock>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<AnchoredBlock>(NProps.BorderThickness, AnchoredBlock.BorderThicknessProperty, NConverters.ToThickness);
      Register<AnchoredBlock>(NProps.LineHeight, AnchoredBlock.LineHeightProperty, NConverters.ToDouble);
      Register<AnchoredBlock>(NProps.LineStackingStrategy, AnchoredBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<AnchoredBlock>(NProps.Margin, AnchoredBlock.MarginProperty, NConverters.ToThickness);
      Register<AnchoredBlock>(NProps.Padding, AnchoredBlock.PaddingProperty, NConverters.ToThickness);
      Register<AnchoredBlock>(NProps.TextAlignment, AnchoredBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateFigure()
    {
      Register<Figure>(NProps.CanDelayPlacement, Figure.CanDelayPlacementProperty, NConverters.ToBool);
      Register<Figure>(NProps.Height, Figure.HeightProperty);
      Register<Figure>(NProps.HorizontalAnchor, Figure.HorizontalAnchorProperty, NConverters.ToEnum<FigureHorizontalAnchor>);
      Register<Figure>(NProps.HorizontalOffset, Figure.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<Figure>(NProps.VerticalAnchor, Figure.VerticalAnchorProperty, NConverters.ToEnum<FigureVerticalAnchor>);
      Register<Figure>(NProps.VerticalOffset, Figure.VerticalOffsetProperty, NConverters.ToDouble);
      Register<Figure>(NProps.Width, Figure.WidthProperty);
      Register<Figure>(NProps.WrapDirection, Figure.WrapDirectionProperty, NConverters.ToEnum<WrapDirection>);
    }

    void GenerateFloater()
    {
      Register<Floater>(NProps.HorizontalAlignment, Floater.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);
      Register<Floater>(NProps.Width, Floater.WidthProperty, NConverters.ToDouble);
    }

    void GenerateInlineUIContainer()
    {
      Register<InlineUIContainer>(NProps.Child, (t, v) => AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));
    }

    void GenerateRun()
    {
      Register<Run>(NProps.Text, Run.TextProperty, NConverters.ToString);
    }

    void GenerateSpan()
    {
      Register<Span>(NProps.Inlines, (t, v) => AssignList(t.Inlines, v));
    }

    void GenerateHyperlink()
    {
      Register<Hyperlink>(NProps.Command, Hyperlink.CommandProperty);
      Register<Hyperlink>(NProps.CommandParameter, Hyperlink.CommandParameterProperty);
      Register<Hyperlink>(NProps.CommandTarget, Hyperlink.CommandTargetProperty);
      Register<Hyperlink>(NProps.NavigateUri, Hyperlink.NavigateUriProperty, NConverters.ToUri);
      Register<Hyperlink>(NProps.TargetName, Hyperlink.TargetNameProperty, NConverters.ToString);
      RegisterEvent<Hyperlink>(NProps._Click, Hyperlink.ClickEvent, a => (RoutedEventHandler)a.EventHandler);
      RegisterEvent<Hyperlink>(NProps._RequestNavigate, Hyperlink.RequestNavigateEvent, a => (RequestNavigateEventHandler)a.EventHandler);
      RegisterEvent<Hyperlink>(NProps.Click, (s, a) => s.Click += a.EventHandler);
      RegisterEvent<Hyperlink>(NProps.RequestNavigate, (s, a) => s.RequestNavigate += a.EventHandler);
    }

    void GenerateListItem()
    {
      Register<ListItem>(NProps.Blocks, (t, v) => AssignList(t.Blocks, v));
      Register<ListItem>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<ListItem>(NProps.BorderThickness, ListItem.BorderThicknessProperty, NConverters.ToThickness);
      Register<ListItem>(NProps.FlowDirection, ListItem.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<ListItem>(NProps.LineHeight, ListItem.LineHeightProperty, NConverters.ToDouble);
      Register<ListItem>(NProps.LineStackingStrategy, ListItem.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<ListItem>(NProps.Margin, ListItem.MarginProperty, NConverters.ToThickness);
      Register<ListItem>(NProps.Padding, ListItem.PaddingProperty, NConverters.ToThickness);
      Register<ListItem>(NProps.SiblingListItems, (t, v) => AssignList(t.SiblingListItems, v));
      Register<ListItem>(NProps.TextAlignment, ListItem.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateTableCell()
    {
      Register<TableCell>(NProps.Blocks, (t, v) => AssignList(t.Blocks, v));
      Register<TableCell>(NProps.BorderBrush, (t, v) => t.BorderBrush = NConverters.ToBrushT(v, t.BorderBrush));
      Register<TableCell>(NProps.BorderThickness, TableCell.BorderThicknessProperty, NConverters.ToThickness);
      Register<TableCell>(NProps.ColumnSpan, TableCell.ColumnSpanProperty, NConverters.ToInt32);
      Register<TableCell>(NProps.FlowDirection, TableCell.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);
      Register<TableCell>(NProps.LineHeight, TableCell.LineHeightProperty, NConverters.ToDouble);
      Register<TableCell>(NProps.LineStackingStrategy, TableCell.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);
      Register<TableCell>(NProps.Padding, TableCell.PaddingProperty, NConverters.ToThickness);
      Register<TableCell>(NProps.RowSpan, TableCell.RowSpanProperty, NConverters.ToInt32);
      Register<TableCell>(NProps.TextAlignment, TableCell.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);
    }

    void GenerateTableRow()
    {
      Register<TableRow>(NProps.Cells, (t, v) => AssignListT(t.Cells, v));
    }

    void GenerateTableRowGroup()
    {
      Register<TableRowGroup>(NProps.Rows, (t, v) => AssignListT(t.Rows, v));
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
      Register<DependencyObject>(NProps.ToolTipServiceHorizontalOffset, ToolTipService.HorizontalOffsetProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.ToolTipServiceVerticalOffset, ToolTipService.VerticalOffsetProperty, NConverters.ToDouble);
      Register<DependencyObject>(NProps.ToolTipServiceHasDropShadow, ToolTipService.HasDropShadowProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ToolTipServicePlacementTarget, ToolTipService.PlacementTargetProperty);
      Register<DependencyObject>(NProps.ToolTipServicePlacementRectangle, ToolTipService.PlacementRectangleProperty);
      Register<DependencyObject>(NProps.ToolTipServicePlacement, ToolTipService.PlacementProperty, NConverters.ToEnum<PlacementMode>);
      Register<DependencyObject>(NProps.ToolTipServiceShowOnDisabled, ToolTipService.ShowOnDisabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ToolTipServiceIsEnabled, ToolTipService.IsEnabledProperty, NConverters.ToBool);
      Register<DependencyObject>(NProps.ToolTipServiceShowDuration, ToolTipService.ShowDurationProperty, NConverters.ToInt32);
      Register<DependencyObject>(NProps.ToolTipServiceInitialShowDelay, ToolTipService.InitialShowDelayProperty, NConverters.ToInt32);
      Register<DependencyObject>(NProps.ToolTipServiceBetweenShowDelay, ToolTipService.BetweenShowDelayProperty, NConverters.ToInt32);
    }

    void GenerateTextOptions()
    {
      Register<DependencyObject>(NProps.TextOptionsTextFormattingMode, TextOptions.TextFormattingModeProperty, NConverters.ToEnum<TextFormattingMode>);
      Register<DependencyObject>(NProps.TextOptionsTextRenderingMode, TextOptions.TextRenderingModeProperty, NConverters.ToEnum<TextRenderingMode>);
      Register<DependencyObject>(NProps.TextOptionsTextHintingMode, TextOptions.TextHintingModeProperty, NConverters.ToEnum<TextHintingMode>);
    }
  }

  public partial class NProps
  {
    public static readonly int _ActiveEditingModeChanged = Store["_ActiveEditingModeChanged"];
    public static readonly int _BufferingEnded = Store["_BufferingEnded"];
    public static readonly int _BufferingStarted = Store["_BufferingStarted"];
    public static readonly int _Checked = Store["_Checked"];
    public static readonly int _Click = Store["_Click"];
    public static readonly int _Closed = Store["_Closed"];
    public static readonly int _Collapsed = Store["_Collapsed"];
    public static readonly int _ContextMenuClosing = Store["_ContextMenuClosing"];
    public static readonly int _ContextMenuOpening = Store["_ContextMenuOpening"];
    public static readonly int _DragCompleted = Store["_DragCompleted"];
    public static readonly int _DragDelta = Store["_DragDelta"];
    public static readonly int _DragEnter = Store["_DragEnter"];
    public static readonly int _DragLeave = Store["_DragLeave"];
    public static readonly int _DragOver = Store["_DragOver"];
    public static readonly int _DragStarted = Store["_DragStarted"];
    public static readonly int _Drop = Store["_Drop"];
    public static readonly int _EditingModeChanged = Store["_EditingModeChanged"];
    public static readonly int _EditingModeInvertedChanged = Store["_EditingModeInvertedChanged"];
    public static readonly int _Expanded = Store["_Expanded"];
    public static readonly int _Gesture = Store["_Gesture"];
    public static readonly int _GiveFeedback = Store["_GiveFeedback"];
    public static readonly int _GotFocus = Store["_GotFocus"];
    public static readonly int _GotKeyboardFocus = Store["_GotKeyboardFocus"];
    public static readonly int _GotMouseCapture = Store["_GotMouseCapture"];
    public static readonly int _GotStylusCapture = Store["_GotStylusCapture"];
    public static readonly int _GotTouchCapture = Store["_GotTouchCapture"];
    public static readonly int _ImageFailed = Store["_ImageFailed"];
    public static readonly int _Indeterminate = Store["_Indeterminate"];
    public static readonly int _KeyDown = Store["_KeyDown"];
    public static readonly int _KeyUp = Store["_KeyUp"];
    public static readonly int _Loaded = Store["_Loaded"];
    public static readonly int _LostFocus = Store["_LostFocus"];
    public static readonly int _LostKeyboardFocus = Store["_LostKeyboardFocus"];
    public static readonly int _LostMouseCapture = Store["_LostMouseCapture"];
    public static readonly int _LostStylusCapture = Store["_LostStylusCapture"];
    public static readonly int _LostTouchCapture = Store["_LostTouchCapture"];
    public static readonly int _ManipulationBoundaryFeedback = Store["_ManipulationBoundaryFeedback"];
    public static readonly int _ManipulationCompleted = Store["_ManipulationCompleted"];
    public static readonly int _ManipulationDelta = Store["_ManipulationDelta"];
    public static readonly int _ManipulationInertiaStarting = Store["_ManipulationInertiaStarting"];
    public static readonly int _ManipulationStarted = Store["_ManipulationStarted"];
    public static readonly int _ManipulationStarting = Store["_ManipulationStarting"];
    public static readonly int _MediaEnded = Store["_MediaEnded"];
    public static readonly int _MediaFailed = Store["_MediaFailed"];
    public static readonly int _MediaOpened = Store["_MediaOpened"];
    public static readonly int _MouseDoubleClick = Store["_MouseDoubleClick"];
    public static readonly int _MouseDown = Store["_MouseDown"];
    public static readonly int _MouseEnter = Store["_MouseEnter"];
    public static readonly int _MouseLeave = Store["_MouseLeave"];
    public static readonly int _MouseLeftButtonDown = Store["_MouseLeftButtonDown"];
    public static readonly int _MouseLeftButtonUp = Store["_MouseLeftButtonUp"];
    public static readonly int _MouseMove = Store["_MouseMove"];
    public static readonly int _MouseRightButtonDown = Store["_MouseRightButtonDown"];
    public static readonly int _MouseRightButtonUp = Store["_MouseRightButtonUp"];
    public static readonly int _MouseUp = Store["_MouseUp"];
    public static readonly int _MouseWheel = Store["_MouseWheel"];
    public static readonly int _Opened = Store["_Opened"];
    public static readonly int _PasswordChanged = Store["_PasswordChanged"];
    public static readonly int _PreviewDragEnter = Store["_PreviewDragEnter"];
    public static readonly int _PreviewDragLeave = Store["_PreviewDragLeave"];
    public static readonly int _PreviewDragOver = Store["_PreviewDragOver"];
    public static readonly int _PreviewDrop = Store["_PreviewDrop"];
    public static readonly int _PreviewGiveFeedback = Store["_PreviewGiveFeedback"];
    public static readonly int _PreviewGotKeyboardFocus = Store["_PreviewGotKeyboardFocus"];
    public static readonly int _PreviewKeyDown = Store["_PreviewKeyDown"];
    public static readonly int _PreviewKeyUp = Store["_PreviewKeyUp"];
    public static readonly int _PreviewLostKeyboardFocus = Store["_PreviewLostKeyboardFocus"];
    public static readonly int _PreviewMouseDoubleClick = Store["_PreviewMouseDoubleClick"];
    public static readonly int _PreviewMouseDown = Store["_PreviewMouseDown"];
    public static readonly int _PreviewMouseLeftButtonDown = Store["_PreviewMouseLeftButtonDown"];
    public static readonly int _PreviewMouseLeftButtonUp = Store["_PreviewMouseLeftButtonUp"];
    public static readonly int _PreviewMouseMove = Store["_PreviewMouseMove"];
    public static readonly int _PreviewMouseRightButtonDown = Store["_PreviewMouseRightButtonDown"];
    public static readonly int _PreviewMouseRightButtonUp = Store["_PreviewMouseRightButtonUp"];
    public static readonly int _PreviewMouseUp = Store["_PreviewMouseUp"];
    public static readonly int _PreviewMouseWheel = Store["_PreviewMouseWheel"];
    public static readonly int _PreviewQueryContinueDrag = Store["_PreviewQueryContinueDrag"];
    public static readonly int _PreviewStylusButtonDown = Store["_PreviewStylusButtonDown"];
    public static readonly int _PreviewStylusButtonUp = Store["_PreviewStylusButtonUp"];
    public static readonly int _PreviewStylusDown = Store["_PreviewStylusDown"];
    public static readonly int _PreviewStylusInAirMove = Store["_PreviewStylusInAirMove"];
    public static readonly int _PreviewStylusInRange = Store["_PreviewStylusInRange"];
    public static readonly int _PreviewStylusMove = Store["_PreviewStylusMove"];
    public static readonly int _PreviewStylusOutOfRange = Store["_PreviewStylusOutOfRange"];
    public static readonly int _PreviewStylusSystemGesture = Store["_PreviewStylusSystemGesture"];
    public static readonly int _PreviewStylusUp = Store["_PreviewStylusUp"];
    public static readonly int _PreviewTextInput = Store["_PreviewTextInput"];
    public static readonly int _PreviewTouchDown = Store["_PreviewTouchDown"];
    public static readonly int _PreviewTouchMove = Store["_PreviewTouchMove"];
    public static readonly int _PreviewTouchUp = Store["_PreviewTouchUp"];
    public static readonly int _QueryContinueDrag = Store["_QueryContinueDrag"];
    public static readonly int _QueryCursor = Store["_QueryCursor"];
    public static readonly int _RequestBringIntoView = Store["_RequestBringIntoView"];
    public static readonly int _RequestNavigate = Store["_RequestNavigate"];
    public static readonly int _ScriptCommand = Store["_ScriptCommand"];
    public static readonly int _Scroll = Store["_Scroll"];
    public static readonly int _ScrollChanged = Store["_ScrollChanged"];
    public static readonly int _Selected = Store["_Selected"];
    public static readonly int _SelectedDateChanged = Store["_SelectedDateChanged"];
    public static readonly int _SelectedDatesChanged = Store["_SelectedDatesChanged"];
    public static readonly int _SelectedItemChanged = Store["_SelectedItemChanged"];
    public static readonly int _SelectionChanged = Store["_SelectionChanged"];
    public static readonly int _SizeChanged = Store["_SizeChanged"];
    public static readonly int _StrokeCollected = Store["_StrokeCollected"];
    public static readonly int _StrokeErased = Store["_StrokeErased"];
    public static readonly int _StylusButtonDown = Store["_StylusButtonDown"];
    public static readonly int _StylusButtonUp = Store["_StylusButtonUp"];
    public static readonly int _StylusDown = Store["_StylusDown"];
    public static readonly int _StylusEnter = Store["_StylusEnter"];
    public static readonly int _StylusInAirMove = Store["_StylusInAirMove"];
    public static readonly int _StylusInRange = Store["_StylusInRange"];
    public static readonly int _StylusLeave = Store["_StylusLeave"];
    public static readonly int _StylusMove = Store["_StylusMove"];
    public static readonly int _StylusOutOfRange = Store["_StylusOutOfRange"];
    public static readonly int _StylusSystemGesture = Store["_StylusSystemGesture"];
    public static readonly int _StylusUp = Store["_StylusUp"];
    public static readonly int _SubmenuClosed = Store["_SubmenuClosed"];
    public static readonly int _SubmenuOpened = Store["_SubmenuOpened"];
    public static readonly int _TextChanged = Store["_TextChanged"];
    public static readonly int _TextInput = Store["_TextInput"];
    public static readonly int _ToolTipClosing = Store["_ToolTipClosing"];
    public static readonly int _ToolTipOpening = Store["_ToolTipOpening"];
    public static readonly int _TouchDown = Store["_TouchDown"];
    public static readonly int _TouchEnter = Store["_TouchEnter"];
    public static readonly int _TouchLeave = Store["_TouchLeave"];
    public static readonly int _TouchMove = Store["_TouchMove"];
    public static readonly int _TouchUp = Store["_TouchUp"];
    public static readonly int _Unchecked = Store["_Unchecked"];
    public static readonly int _Unloaded = Store["_Unloaded"];
    public static readonly int _Unselected = Store["_Unselected"];
    public static readonly int _ValueChanged = Store["_ValueChanged"];
    public static readonly int AcceptsReturn = Store["AcceptsReturn"];
    public static readonly int AcceptsTab = Store["AcceptsTab"];
    public static readonly int Activated = Store["Activated"];
    public static readonly int ActiveEditingModeChanged = Store["ActiveEditingModeChanged"];
    public static readonly int AddingNewItem = Store["AddingNewItem"];
    public static readonly int AllowDrop = Store["AllowDrop"];
    public static readonly int AllowsColumnReorder = Store["AllowsColumnReorder"];
    public static readonly int AllowsTransparency = Store["AllowsTransparency"];
    public static readonly int AlternatingRowBackground = Store["AlternatingRowBackground"];
    public static readonly int AlternationCount = Store["AlternationCount"];
    public static readonly int AreRowDetailsFrozen = Store["AreRowDetailsFrozen"];
    public static readonly int AutoGenerateColumns = Store["AutoGenerateColumns"];
    public static readonly int AutoGeneratedColumns = Store["AutoGeneratedColumns"];
    public static readonly int AutoGeneratingColumn = Store["AutoGeneratingColumn"];
    public static readonly int AutoToolTipPlacement = Store["AutoToolTipPlacement"];
    public static readonly int AutoToolTipPrecision = Store["AutoToolTipPrecision"];
    public static readonly int AutoWordSelection = Store["AutoWordSelection"];
    public static readonly int Background = Store["Background"];
    public static readonly int Balance = Store["Balance"];
    public static readonly int Band = Store["Band"];
    public static readonly int BandIndex = Store["BandIndex"];
    public static readonly int BaselineAlignment = Store["BaselineAlignment"];
    public static readonly int BaselineOffset = Store["BaselineOffset"];
    public static readonly int BeginningEdit = Store["BeginningEdit"];
    public static readonly int BidiLevel = Store["BidiLevel"];
    public static readonly int BindingGroup = Store["BindingGroup"];
    public static readonly int BitmapEffect = Store["BitmapEffect"];
    public static readonly int BitmapEffectInput = Store["BitmapEffectInput"];
    public static readonly int BlackoutDates = Store["BlackoutDates"];
    public static readonly int BleedBox = Store["BleedBox"];
    public static readonly int BlockIsHyphenationEnabled = Store["BlockIsHyphenationEnabled"];
    public static readonly int BlockLineHeight = Store["BlockLineHeight"];
    public static readonly int BlockLineStackingStrategy = Store["BlockLineStackingStrategy"];
    public static readonly int BlockTextAlignment = Store["BlockTextAlignment"];
    public static readonly int BorderBrush = Store["BorderBrush"];
    public static readonly int BorderThickness = Store["BorderThickness"];
    public static readonly int BreakColumnBefore = Store["BreakColumnBefore"];
    public static readonly int BreakPageBefore = Store["BreakPageBefore"];
    public static readonly int BufferingEnded = Store["BufferingEnded"];
    public static readonly int BufferingStarted = Store["BufferingStarted"];
    public static readonly int Bullet = Store["Bullet"];
    public static readonly int CacheMode = Store["CacheMode"];
    public static readonly int CalendarButtonStyle = Store["CalendarButtonStyle"];
    public static readonly int CalendarClosed = Store["CalendarClosed"];
    public static readonly int CalendarDayButtonStyle = Store["CalendarDayButtonStyle"];
    public static readonly int CalendarItemStyle = Store["CalendarItemStyle"];
    public static readonly int CalendarOpened = Store["CalendarOpened"];
    public static readonly int CalendarStyle = Store["CalendarStyle"];
    public static readonly int Camera = Store["Camera"];
    public static readonly int CanContentScroll = Store["CanContentScroll"];
    public static readonly int CanDelayPlacement = Store["CanDelayPlacement"];
    public static readonly int CanHorizontallyScroll = Store["CanHorizontallyScroll"];
    public static readonly int CanUserAddRows = Store["CanUserAddRows"];
    public static readonly int CanUserDeleteRows = Store["CanUserDeleteRows"];
    public static readonly int CanUserReorderColumns = Store["CanUserReorderColumns"];
    public static readonly int CanUserResizeColumns = Store["CanUserResizeColumns"];
    public static readonly int CanUserResizeRows = Store["CanUserResizeRows"];
    public static readonly int CanUserSortColumns = Store["CanUserSortColumns"];
    public static readonly int CanvasBottom = Store["CanvasBottom"];
    public static readonly int CanvasLeft = Store["CanvasLeft"];
    public static readonly int CanvasRight = Store["CanvasRight"];
    public static readonly int CanvasTop = Store["CanvasTop"];
    public static readonly int CanVerticallyScroll = Store["CanVerticallyScroll"];
    public static readonly int CaptionFontFamily = Store["CaptionFontFamily"];
    public static readonly int CaptionFontSize = Store["CaptionFontSize"];
    public static readonly int CaptionFontStretch = Store["CaptionFontStretch"];
    public static readonly int CaptionFontStyle = Store["CaptionFontStyle"];
    public static readonly int CaptionFontWeight = Store["CaptionFontWeight"];
    public static readonly int CaretBrush = Store["CaretBrush"];
    public static readonly int CaretIndex = Store["CaretIndex"];
    public static readonly int CaretPosition = Store["CaretPosition"];
    public static readonly int CaretStops = Store["CaretStops"];
    public static readonly int CellEditEnding = Store["CellEditEnding"];
    public static readonly int Cells = Store["Cells"];
    public static readonly int CellSpacing = Store["CellSpacing"];
    public static readonly int CellStyle = Store["CellStyle"];
    public static readonly int CharacterCasing = Store["CharacterCasing"];
    public static readonly int Checked = Store["Checked"];
    public static readonly int Child = Store["Child"];
    public static readonly int ClearFloaters = Store["ClearFloaters"];
    public static readonly int Click = Store["Click"];
    public static readonly int ClickMode = Store["ClickMode"];
    public static readonly int Clip = Store["Clip"];
    public static readonly int ClipboardCopyMode = Store["ClipboardCopyMode"];
    public static readonly int ClipToBounds = Store["ClipToBounds"];
    public static readonly int Clock = Store["Clock"];
    public static readonly int Closed = Store["Closed"];
    public static readonly int Closing = Store["Closing"];
    public static readonly int Collapsed = Store["Collapsed"];
    public static readonly int ColumnDisplayIndexChanged = Store["ColumnDisplayIndexChanged"];
    public static readonly int ColumnHeaderContainerStyle = Store["ColumnHeaderContainerStyle"];
    public static readonly int ColumnHeaderContextMenu = Store["ColumnHeaderContextMenu"];
    public static readonly int ColumnHeaderDragCompleted = Store["ColumnHeaderDragCompleted"];
    public static readonly int ColumnHeaderDragDelta = Store["ColumnHeaderDragDelta"];
    public static readonly int ColumnHeaderDragStarted = Store["ColumnHeaderDragStarted"];
    public static readonly int ColumnHeaderHeight = Store["ColumnHeaderHeight"];
    public static readonly int ColumnHeaderStringFormat = Store["ColumnHeaderStringFormat"];
    public static readonly int ColumnHeaderStyle = Store["ColumnHeaderStyle"];
    public static readonly int ColumnHeaderTemplate = Store["ColumnHeaderTemplate"];
    public static readonly int ColumnHeaderTemplateSelector = Store["ColumnHeaderTemplateSelector"];
    public static readonly int ColumnHeaderToolTip = Store["ColumnHeaderToolTip"];
    public static readonly int ColumnReordered = Store["ColumnReordered"];
    public static readonly int ColumnReordering = Store["ColumnReordering"];
    public static readonly int Columns = Store["Columns"];
    public static readonly int ColumnSpan = Store["ColumnSpan"];
    public static readonly int ColumnWidth = Store["ColumnWidth"];
    public static readonly int Command = Store["Command"];
    public static readonly int CommandBindings = Store["CommandBindings"];
    public static readonly int CommandParameter = Store["CommandParameter"];
    public static readonly int CommandTarget = Store["CommandTarget"];
    public static readonly int Content = Store["Content"];
    public static readonly int ContentBox = Store["ContentBox"];
    public static readonly int ContentRendered = Store["ContentRendered"];
    public static readonly int ContentSource = Store["ContentSource"];
    public static readonly int ContentStringFormat = Store["ContentStringFormat"];
    public static readonly int ContentTemplate = Store["ContentTemplate"];
    public static readonly int ContentTemplateSelector = Store["ContentTemplateSelector"];
    public static readonly int ContextMenu = Store["ContextMenu"];
    public static readonly int ContextMenuClosing = Store["ContextMenuClosing"];
    public static readonly int ContextMenuOpening = Store["ContextMenuOpening"];
    public static readonly int CopyingRowClipboardContent = Store["CopyingRowClipboardContent"];
    public static readonly int CornerRadius = Store["CornerRadius"];
    public static readonly int CurrentCell = Store["CurrentCell"];
    public static readonly int CurrentCellChanged = Store["CurrentCellChanged"];
    public static readonly int CurrentColumn = Store["CurrentColumn"];
    public static readonly int CurrentItem = Store["CurrentItem"];
    public static readonly int Cursor = Store["Cursor"];
    public static readonly int CustomPopupPlacementCallback = Store["CustomPopupPlacementCallback"];
    public static readonly int Data = Store["Data"];
    public static readonly int DataContext = Store["DataContext"];
    public static readonly int DataContextChanged = Store["DataContextChanged"];
    public static readonly int DateValidationError = Store["DateValidationError"];
    public static readonly int Deactivated = Store["Deactivated"];
    public static readonly int DecreaseRepeatButton = Store["DecreaseRepeatButton"];
    public static readonly int DefaultDrawingAttributes = Store["DefaultDrawingAttributes"];
    public static readonly int DefaultDrawingAttributesReplaced = Store["DefaultDrawingAttributesReplaced"];
    public static readonly int DefaultStylusPointDescription = Store["DefaultStylusPointDescription"];
    public static readonly int Delay = Store["Delay"];
    public static readonly int DetailsTemplate = Store["DetailsTemplate"];
    public static readonly int DetailsTemplateSelector = Store["DetailsTemplateSelector"];
    public static readonly int DetailsVisibility = Store["DetailsVisibility"];
    public static readonly int DeviceFontName = Store["DeviceFontName"];
    public static readonly int DialogResult = Store["DialogResult"];
    public static readonly int DisplayDate = Store["DisplayDate"];
    public static readonly int DisplayDateChanged = Store["DisplayDateChanged"];
    public static readonly int DisplayDateEnd = Store["DisplayDateEnd"];
    public static readonly int DisplayDateStart = Store["DisplayDateStart"];
    public static readonly int DisplayMemberPath = Store["DisplayMemberPath"];
    public static readonly int DisplayMode = Store["DisplayMode"];
    public static readonly int DisplayModeChanged = Store["DisplayModeChanged"];
    public static readonly int DockPanelDock = Store["DockPanelDock"];
    public static readonly int Document = Store["Document"];
    public static readonly int DocumentPaginator = Store["DocumentPaginator"];
    public static readonly int DocumentViewerBaseIsMasterPage = Store["DocumentViewerBaseIsMasterPage"];
    public static readonly int DragCompleted = Store["DragCompleted"];
    public static readonly int DragDelta = Store["DragDelta"];
    public static readonly int DragEnter = Store["DragEnter"];
    public static readonly int DragIncrement = Store["DragIncrement"];
    public static readonly int DragIndicatorStyle = Store["DragIndicatorStyle"];
    public static readonly int DragLeave = Store["DragLeave"];
    public static readonly int DragOver = Store["DragOver"];
    public static readonly int DragStarted = Store["DragStarted"];
    public static readonly int Drop = Store["Drop"];
    public static readonly int DropDownClosed = Store["DropDownClosed"];
    public static readonly int DropDownOpened = Store["DropDownOpened"];
    public static readonly int DropLocationIndicatorStyle = Store["DropLocationIndicatorStyle"];
    public static readonly int EditingMode = Store["EditingMode"];
    public static readonly int EditingModeChanged = Store["EditingModeChanged"];
    public static readonly int EditingModeInverted = Store["EditingModeInverted"];
    public static readonly int EditingModeInvertedChanged = Store["EditingModeInvertedChanged"];
    public static readonly int Effect = Store["Effect"];
    public static readonly int EnableColumnVirtualization = Store["EnableColumnVirtualization"];
    public static readonly int EnableRowVirtualization = Store["EnableRowVirtualization"];
    public static readonly int EraserShape = Store["EraserShape"];
    public static readonly int ExpandDirection = Store["ExpandDirection"];
    public static readonly int Expanded = Store["Expanded"];
    public static readonly int Fill = Store["Fill"];
    public static readonly int FillRule = Store["FillRule"];
    public static readonly int FirstColumn = Store["FirstColumn"];
    public static readonly int FirstDayOfWeek = Store["FirstDayOfWeek"];
    public static readonly int FixedPageBottom = Store["FixedPageBottom"];
    public static readonly int FixedPageLeft = Store["FixedPageLeft"];
    public static readonly int FixedPageNavigateUri = Store["FixedPageNavigateUri"];
    public static readonly int FixedPageRight = Store["FixedPageRight"];
    public static readonly int FixedPageTop = Store["FixedPageTop"];
    public static readonly int FlowDirection = Store["FlowDirection"];
    public static readonly int Focusable = Store["Focusable"];
    public static readonly int FocusableChanged = Store["FocusableChanged"];
    public static readonly int FocusVisualStyle = Store["FocusVisualStyle"];
    public static readonly int FontFamily = Store["FontFamily"];
    public static readonly int FontRenderingEmSize = Store["FontRenderingEmSize"];
    public static readonly int FontSize = Store["FontSize"];
    public static readonly int FontStretch = Store["FontStretch"];
    public static readonly int FontStyle = Store["FontStyle"];
    public static readonly int FontUri = Store["FontUri"];
    public static readonly int FontWeight = Store["FontWeight"];
    public static readonly int ForceCursor = Store["ForceCursor"];
    public static readonly int Foreground = Store["Foreground"];
    public static readonly int FragmentNavigation = Store["FragmentNavigation"];
    public static readonly int FrameworkElementFlowDirection = Store["FrameworkElementFlowDirection"];
    public static readonly int FrozenColumnCount = Store["FrozenColumnCount"];
    public static readonly int Gesture = Store["Gesture"];
    public static readonly int GetPageRootCompleted = Store["GetPageRootCompleted"];
    public static readonly int GiveFeedback = Store["GiveFeedback"];
    public static readonly int GotFocus = Store["GotFocus"];
    public static readonly int GotKeyboardFocus = Store["GotKeyboardFocus"];
    public static readonly int GotMouseCapture = Store["GotMouseCapture"];
    public static readonly int GotStylusCapture = Store["GotStylusCapture"];
    public static readonly int GotTouchCapture = Store["GotTouchCapture"];
    public static readonly int GridColumn = Store["GridColumn"];
    public static readonly int GridColumnSpan = Store["GridColumnSpan"];
    public static readonly int GridIsSharedSizeScope = Store["GridIsSharedSizeScope"];
    public static readonly int GridLinesVisibility = Store["GridLinesVisibility"];
    public static readonly int GridRow = Store["GridRow"];
    public static readonly int GridRowSpan = Store["GridRowSpan"];
    public static readonly int GroupName = Store["GroupName"];
    public static readonly int GroupStyle = Store["GroupStyle"];
    public static readonly int GroupStyleSelector = Store["GroupStyleSelector"];
    public static readonly int HasDropShadow = Store["HasDropShadow"];
    public static readonly int HasTrailingParagraphBreakOnPaste = Store["HasTrailingParagraphBreakOnPaste"];
    public static readonly int Header = Store["Header"];
    public static readonly int HeaderStringFormat = Store["HeaderStringFormat"];
    public static readonly int HeaderStyle = Store["HeaderStyle"];
    public static readonly int HeadersVisibility = Store["HeadersVisibility"];
    public static readonly int HeaderTemplate = Store["HeaderTemplate"];
    public static readonly int HeaderTemplateSelector = Store["HeaderTemplateSelector"];
    public static readonly int Height = Store["Height"];
    public static readonly int HorizontalAlignment = Store["HorizontalAlignment"];
    public static readonly int HorizontalAnchor = Store["HorizontalAnchor"];
    public static readonly int HorizontalContentAlignment = Store["HorizontalContentAlignment"];
    public static readonly int HorizontalGridLinesBrush = Store["HorizontalGridLinesBrush"];
    public static readonly int HorizontalOffset = Store["HorizontalOffset"];
    public static readonly int HorizontalPageSpacing = Store["HorizontalPageSpacing"];
    public static readonly int HorizontalScrollBarVisibility = Store["HorizontalScrollBarVisibility"];
    public static readonly int Icon = Store["Icon"];
    public static readonly int ImageFailed = Store["ImageFailed"];
    public static readonly int IncreaseRepeatButton = Store["IncreaseRepeatButton"];
    public static readonly int Indeterminate = Store["Indeterminate"];
    public static readonly int Indices = Store["Indices"];
    public static readonly int Initialized = Store["Initialized"];
    public static readonly int InitializingNewItem = Store["InitializingNewItem"];
    public static readonly int InkCanvasBottom = Store["InkCanvasBottom"];
    public static readonly int InkCanvasLeft = Store["InkCanvasLeft"];
    public static readonly int InkCanvasRight = Store["InkCanvasRight"];
    public static readonly int InkCanvasTop = Store["InkCanvasTop"];
    public static readonly int InputBindings = Store["InputBindings"];
    public static readonly int InputGestureText = Store["InputGestureText"];
    public static readonly int InputScope = Store["InputScope"];
    public static readonly int Interval = Store["Interval"];
    public static readonly int IsCancel = Store["IsCancel"];
    public static readonly int IsCheckable = Store["IsCheckable"];
    public static readonly int IsChecked = Store["IsChecked"];
    public static readonly int IsClipEnabled = Store["IsClipEnabled"];
    public static readonly int IsDefault = Store["IsDefault"];
    public static readonly int IsDeferredScrollingEnabled = Store["IsDeferredScrollingEnabled"];
    public static readonly int IsDirectionReversed = Store["IsDirectionReversed"];
    public static readonly int IsDocumentEnabled = Store["IsDocumentEnabled"];
    public static readonly int IsDropDownOpen = Store["IsDropDownOpen"];
    public static readonly int IsEditable = Store["IsEditable"];
    public static readonly int IsEditing = Store["IsEditing"];
    public static readonly int IsEnabled = Store["IsEnabled"];
    public static readonly int IsEnabledChanged = Store["IsEnabledChanged"];
    public static readonly int IsExpanded = Store["IsExpanded"];
    public static readonly int IsFindEnabled = Store["IsFindEnabled"];
    public static readonly int IsHitTestVisible = Store["IsHitTestVisible"];
    public static readonly int IsHitTestVisibleChanged = Store["IsHitTestVisibleChanged"];
    public static readonly int IsHyphenationEnabled = Store["IsHyphenationEnabled"];
    public static readonly int IsInactiveSelectionHighlightEnabled = Store["IsInactiveSelectionHighlightEnabled"];
    public static readonly int IsIndeterminate = Store["IsIndeterminate"];
    public static readonly int IsItemsHost = Store["IsItemsHost"];
    public static readonly int IsKeyboardFocusedChanged = Store["IsKeyboardFocusedChanged"];
    public static readonly int IsKeyboardFocusWithinChanged = Store["IsKeyboardFocusWithinChanged"];
    public static readonly int IsLocked = Store["IsLocked"];
    public static readonly int IsMainMenu = Store["IsMainMenu"];
    public static readonly int IsManipulationEnabled = Store["IsManipulationEnabled"];
    public static readonly int IsMouseCapturedChanged = Store["IsMouseCapturedChanged"];
    public static readonly int IsMouseCaptureWithinChanged = Store["IsMouseCaptureWithinChanged"];
    public static readonly int IsMouseDirectlyOverChanged = Store["IsMouseDirectlyOverChanged"];
    public static readonly int IsMoveToPointEnabled = Store["IsMoveToPointEnabled"];
    public static readonly int IsMuted = Store["IsMuted"];
    public static readonly int IsOpen = Store["IsOpen"];
    public static readonly int IsOverflowOpen = Store["IsOverflowOpen"];
    public static readonly int IsPageViewEnabled = Store["IsPageViewEnabled"];
    public static readonly int IsPrintEnabled = Store["IsPrintEnabled"];
    public static readonly int IsReadOnly = Store["IsReadOnly"];
    public static readonly int IsReadOnlyCaretVisible = Store["IsReadOnlyCaretVisible"];
    public static readonly int IsScrollViewEnabled = Store["IsScrollViewEnabled"];
    public static readonly int IsSelected = Store["IsSelected"];
    public static readonly int IsSelectionEnabled = Store["IsSelectionEnabled"];
    public static readonly int IsSelectionRangeEnabled = Store["IsSelectionRangeEnabled"];
    public static readonly int IsSideways = Store["IsSideways"];
    public static readonly int IsSnapToTickEnabled = Store["IsSnapToTickEnabled"];
    public static readonly int IsStylusCapturedChanged = Store["IsStylusCapturedChanged"];
    public static readonly int IsStylusCaptureWithinChanged = Store["IsStylusCaptureWithinChanged"];
    public static readonly int IsStylusDirectlyOverChanged = Store["IsStylusDirectlyOverChanged"];
    public static readonly int IsSubmenuOpen = Store["IsSubmenuOpen"];
    public static readonly int IsSynchronizedWithCurrentItem = Store["IsSynchronizedWithCurrentItem"];
    public static readonly int IsTabStop = Store["IsTabStop"];
    public static readonly int IsTextSearchCaseSensitive = Store["IsTextSearchCaseSensitive"];
    public static readonly int IsTextSearchEnabled = Store["IsTextSearchEnabled"];
    public static readonly int IsThreeState = Store["IsThreeState"];
    public static readonly int IsTodayHighlighted = Store["IsTodayHighlighted"];
    public static readonly int IsToolBarVisible = Store["IsToolBarVisible"];
    public static readonly int IsTwoPageViewEnabled = Store["IsTwoPageViewEnabled"];
    public static readonly int IsUndoEnabled = Store["IsUndoEnabled"];
    public static readonly int IsVisibleChanged = Store["IsVisibleChanged"];
    public static readonly int Item = Store["Item"];
    public static readonly int ItemBindingGroup = Store["ItemBindingGroup"];
    public static readonly int ItemContainerStyle = Store["ItemContainerStyle"];
    public static readonly int ItemContainerStyleSelector = Store["ItemContainerStyleSelector"];
    public static readonly int ItemContainerTemplateSelector = Store["ItemContainerTemplateSelector"];
    public static readonly int ItemHeight = Store["ItemHeight"];
    public static readonly int ItemsPanel = Store["ItemsPanel"];
    public static readonly int ItemsSource = Store["ItemsSource"];
    public static readonly int ItemStringFormat = Store["ItemStringFormat"];
    public static readonly int ItemTemplate = Store["ItemTemplate"];
    public static readonly int ItemTemplateSelector = Store["ItemTemplateSelector"];
    public static readonly int ItemWidth = Store["ItemWidth"];
    public static readonly int JournalOwnership = Store["JournalOwnership"];
    public static readonly int KeepAlive = Store["KeepAlive"];
    public static readonly int KeepTogether = Store["KeepTogether"];
    public static readonly int KeepWithNext = Store["KeepWithNext"];
    public static readonly int KeyboardIncrement = Store["KeyboardIncrement"];
    public static readonly int KeyDown = Store["KeyDown"];
    public static readonly int KeyUp = Store["KeyUp"];
    public static readonly int Language = Store["Language"];
    public static readonly int LargeChange = Store["LargeChange"];
    public static readonly int LastChildFill = Store["LastChildFill"];
    public static readonly int LayoutTransform = Store["LayoutTransform"];
    public static readonly int LayoutUpdated = Store["LayoutUpdated"];
    public static readonly int Left = Store["Left"];
    public static readonly int LineHeight = Store["LineHeight"];
    public static readonly int LineStackingStrategy = Store["LineStackingStrategy"];
    public static readonly int LinkTargets = Store["LinkTargets"];
    public static readonly int ListItems = Store["ListItems"];
    public static readonly int LoadCompleted = Store["LoadCompleted"];
    public static readonly int Loaded = Store["Loaded"];
    public static readonly int LoadedBehavior = Store["LoadedBehavior"];
    public static readonly int LoadingRow = Store["LoadingRow"];
    public static readonly int LoadingRowDetails = Store["LoadingRowDetails"];
    public static readonly int LocationChanged = Store["LocationChanged"];
    public static readonly int LostFocus = Store["LostFocus"];
    public static readonly int LostKeyboardFocus = Store["LostKeyboardFocus"];
    public static readonly int LostMouseCapture = Store["LostMouseCapture"];
    public static readonly int LostStylusCapture = Store["LostStylusCapture"];
    public static readonly int LostTouchCapture = Store["LostTouchCapture"];
    public static readonly int ManipulationBoundaryFeedback = Store["ManipulationBoundaryFeedback"];
    public static readonly int ManipulationCompleted = Store["ManipulationCompleted"];
    public static readonly int ManipulationDelta = Store["ManipulationDelta"];
    public static readonly int ManipulationInertiaStarting = Store["ManipulationInertiaStarting"];
    public static readonly int ManipulationStarted = Store["ManipulationStarted"];
    public static readonly int ManipulationStarting = Store["ManipulationStarting"];
    public static readonly int Margin = Store["Margin"];
    public static readonly int MarkerOffset = Store["MarkerOffset"];
    public static readonly int MarkerStyle = Store["MarkerStyle"];
    public static readonly int MaxColumnWidth = Store["MaxColumnWidth"];
    public static readonly int MaxDropDownHeight = Store["MaxDropDownHeight"];
    public static readonly int MaxHeight = Store["MaxHeight"];
    public static readonly int Maximum = Store["Maximum"];
    public static readonly int MaxLength = Store["MaxLength"];
    public static readonly int MaxLines = Store["MaxLines"];
    public static readonly int MaxPagesAcross = Store["MaxPagesAcross"];
    public static readonly int MaxWidth = Store["MaxWidth"];
    public static readonly int MaxZoom = Store["MaxZoom"];
    public static readonly int MediaEnded = Store["MediaEnded"];
    public static readonly int MediaFailed = Store["MediaFailed"];
    public static readonly int MediaOpened = Store["MediaOpened"];
    public static readonly int MinColumnWidth = Store["MinColumnWidth"];
    public static readonly int MinHeight = Store["MinHeight"];
    public static readonly int Minimum = Store["Minimum"];
    public static readonly int MinLines = Store["MinLines"];
    public static readonly int MinOrphanLines = Store["MinOrphanLines"];
    public static readonly int MinRowHeight = Store["MinRowHeight"];
    public static readonly int MinWidowLines = Store["MinWidowLines"];
    public static readonly int MinWidth = Store["MinWidth"];
    public static readonly int MinZoom = Store["MinZoom"];
    public static readonly int MouseDoubleClick = Store["MouseDoubleClick"];
    public static readonly int MouseDown = Store["MouseDown"];
    public static readonly int MouseEnter = Store["MouseEnter"];
    public static readonly int MouseLeave = Store["MouseLeave"];
    public static readonly int MouseLeftButtonDown = Store["MouseLeftButtonDown"];
    public static readonly int MouseLeftButtonUp = Store["MouseLeftButtonUp"];
    public static readonly int MouseMove = Store["MouseMove"];
    public static readonly int MouseRightButtonDown = Store["MouseRightButtonDown"];
    public static readonly int MouseRightButtonUp = Store["MouseRightButtonUp"];
    public static readonly int MouseUp = Store["MouseUp"];
    public static readonly int MouseWheel = Store["MouseWheel"];
    public static readonly int MoveEnabled = Store["MoveEnabled"];
    public static readonly int Name = Store["Name"];
    public static readonly int Navigated = Store["Navigated"];
    public static readonly int NavigateUri = Store["NavigateUri"];
    public static readonly int Navigating = Store["Navigating"];
    public static readonly int NavigationFailed = Store["NavigationFailed"];
    public static readonly int NavigationProgress = Store["NavigationProgress"];
    public static readonly int NavigationStopped = Store["NavigationStopped"];
    public static readonly int NavigationUIVisibility = Store["NavigationUIVisibility"];
    public static readonly int ObjectForScripting = Store["ObjectForScripting"];
    public static readonly int Opacity = Store["Opacity"];
    public static readonly int OpacityMask = Store["OpacityMask"];
    public static readonly int Opened = Store["Opened"];
    public static readonly int Orientation = Store["Orientation"];
    public static readonly int OriginX = Store["OriginX"];
    public static readonly int OriginY = Store["OriginY"];
    public static readonly int OverridesDefaultStyle = Store["OverridesDefaultStyle"];
    public static readonly int Owner = Store["Owner"];
    public static readonly int Padding = Store["Padding"];
    public static readonly int PageConnected = Store["PageConnected"];
    public static readonly int PageDisconnected = Store["PageDisconnected"];
    public static readonly int PageNumber = Store["PageNumber"];
    public static readonly int PageViews = Store["PageViews"];
    public static readonly int PageViewsChanged = Store["PageViewsChanged"];
    public static readonly int PanelZIndex = Store["PanelZIndex"];
    public static readonly int PanningDeceleration = Store["PanningDeceleration"];
    public static readonly int PanningMode = Store["PanningMode"];
    public static readonly int PanningRatio = Store["PanningRatio"];
    public static readonly int Password = Store["Password"];
    public static readonly int PasswordChanged = Store["PasswordChanged"];
    public static readonly int PasswordChar = Store["PasswordChar"];
    public static readonly int PenWidth = Store["PenWidth"];
    public static readonly int Placement = Store["Placement"];
    public static readonly int PlacementRectangle = Store["PlacementRectangle"];
    public static readonly int PlacementTarget = Store["PlacementTarget"];
    public static readonly int Points = Store["Points"];
    public static readonly int PopupAnimation = Store["PopupAnimation"];
    public static readonly int Position = Store["Position"];
    public static readonly int PreferredPasteFormats = Store["PreferredPasteFormats"];
    public static readonly int PreparingCellForEdit = Store["PreparingCellForEdit"];
    public static readonly int PreviewDragEnter = Store["PreviewDragEnter"];
    public static readonly int PreviewDragLeave = Store["PreviewDragLeave"];
    public static readonly int PreviewDragOver = Store["PreviewDragOver"];
    public static readonly int PreviewDrop = Store["PreviewDrop"];
    public static readonly int PreviewGiveFeedback = Store["PreviewGiveFeedback"];
    public static readonly int PreviewGotKeyboardFocus = Store["PreviewGotKeyboardFocus"];
    public static readonly int PreviewKeyDown = Store["PreviewKeyDown"];
    public static readonly int PreviewKeyUp = Store["PreviewKeyUp"];
    public static readonly int PreviewLostKeyboardFocus = Store["PreviewLostKeyboardFocus"];
    public static readonly int PreviewMouseDoubleClick = Store["PreviewMouseDoubleClick"];
    public static readonly int PreviewMouseDown = Store["PreviewMouseDown"];
    public static readonly int PreviewMouseLeftButtonDown = Store["PreviewMouseLeftButtonDown"];
    public static readonly int PreviewMouseLeftButtonUp = Store["PreviewMouseLeftButtonUp"];
    public static readonly int PreviewMouseMove = Store["PreviewMouseMove"];
    public static readonly int PreviewMouseRightButtonDown = Store["PreviewMouseRightButtonDown"];
    public static readonly int PreviewMouseRightButtonUp = Store["PreviewMouseRightButtonUp"];
    public static readonly int PreviewMouseUp = Store["PreviewMouseUp"];
    public static readonly int PreviewMouseWheel = Store["PreviewMouseWheel"];
    public static readonly int PreviewQueryContinueDrag = Store["PreviewQueryContinueDrag"];
    public static readonly int PreviewStyle = Store["PreviewStyle"];
    public static readonly int PreviewStylusButtonDown = Store["PreviewStylusButtonDown"];
    public static readonly int PreviewStylusButtonUp = Store["PreviewStylusButtonUp"];
    public static readonly int PreviewStylusDown = Store["PreviewStylusDown"];
    public static readonly int PreviewStylusInAirMove = Store["PreviewStylusInAirMove"];
    public static readonly int PreviewStylusInRange = Store["PreviewStylusInRange"];
    public static readonly int PreviewStylusMove = Store["PreviewStylusMove"];
    public static readonly int PreviewStylusOutOfRange = Store["PreviewStylusOutOfRange"];
    public static readonly int PreviewStylusSystemGesture = Store["PreviewStylusSystemGesture"];
    public static readonly int PreviewStylusUp = Store["PreviewStylusUp"];
    public static readonly int PreviewTextInput = Store["PreviewTextInput"];
    public static readonly int PreviewTouchDown = Store["PreviewTouchDown"];
    public static readonly int PreviewTouchMove = Store["PreviewTouchMove"];
    public static readonly int PreviewTouchUp = Store["PreviewTouchUp"];
    public static readonly int PrintTicket = Store["PrintTicket"];
    public static readonly int QueryContinueDrag = Store["QueryContinueDrag"];
    public static readonly int QueryCursor = Store["QueryCursor"];
    public static readonly int RadiusX = Store["RadiusX"];
    public static readonly int RadiusY = Store["RadiusY"];
    public static readonly int RecognizesAccessKey = Store["RecognizesAccessKey"];
    public static readonly int RemoveFromJournal = Store["RemoveFromJournal"];
    public static readonly int RenderSize = Store["RenderSize"];
    public static readonly int RenderTransform = Store["RenderTransform"];
    public static readonly int RenderTransformOrigin = Store["RenderTransformOrigin"];
    public static readonly int RequestBringIntoView = Store["RequestBringIntoView"];
    public static readonly int RequestNavigate = Store["RequestNavigate"];
    public static readonly int ReservedSpace = Store["ReservedSpace"];
    public static readonly int ResizeBehavior = Store["ResizeBehavior"];
    public static readonly int ResizeDirection = Store["ResizeDirection"];
    public static readonly int ResizeEnabled = Store["ResizeEnabled"];
    public static readonly int ResizeMode = Store["ResizeMode"];
    public static readonly int Resources = Store["Resources"];
    public static readonly int RowBackground = Store["RowBackground"];
    public static readonly int RowDetailsTemplate = Store["RowDetailsTemplate"];
    public static readonly int RowDetailsTemplateSelector = Store["RowDetailsTemplateSelector"];
    public static readonly int RowDetailsVisibilityChanged = Store["RowDetailsVisibilityChanged"];
    public static readonly int RowDetailsVisibilityMode = Store["RowDetailsVisibilityMode"];
    public static readonly int RowEditEnding = Store["RowEditEnding"];
    public static readonly int RowGroups = Store["RowGroups"];
    public static readonly int RowHeaderStyle = Store["RowHeaderStyle"];
    public static readonly int RowHeaderTemplate = Store["RowHeaderTemplate"];
    public static readonly int RowHeaderTemplateSelector = Store["RowHeaderTemplateSelector"];
    public static readonly int RowHeaderWidth = Store["RowHeaderWidth"];
    public static readonly int RowHeight = Store["RowHeight"];
    public static readonly int Rows = Store["Rows"];
    public static readonly int RowSpan = Store["RowSpan"];
    public static readonly int RowStyle = Store["RowStyle"];
    public static readonly int RowStyleSelector = Store["RowStyleSelector"];
    public static readonly int RowValidationErrorTemplate = Store["RowValidationErrorTemplate"];
    public static readonly int RowValidationRules = Store["RowValidationRules"];
    public static readonly int SandboxExternalContent = Store["SandboxExternalContent"];
    public static readonly int ScriptCommand = Store["ScriptCommand"];
    public static readonly int Scroll = Store["Scroll"];
    public static readonly int ScrollChanged = Store["ScrollChanged"];
    public static readonly int ScrollOwner = Store["ScrollOwner"];
    public static readonly int ScrollViewerCanContentScroll = Store["ScrollViewerCanContentScroll"];
    public static readonly int ScrollViewerHorizontalScrollBarVisibility = Store["ScrollViewerHorizontalScrollBarVisibility"];
    public static readonly int ScrollViewerIsDeferredScrollingEnabled = Store["ScrollViewerIsDeferredScrollingEnabled"];
    public static readonly int ScrollViewerPanningDeceleration = Store["ScrollViewerPanningDeceleration"];
    public static readonly int ScrollViewerPanningMode = Store["ScrollViewerPanningMode"];
    public static readonly int ScrollViewerPanningRatio = Store["ScrollViewerPanningRatio"];
    public static readonly int ScrollViewerVerticalScrollBarVisibility = Store["ScrollViewerVerticalScrollBarVisibility"];
    public static readonly int ScrubbingEnabled = Store["ScrubbingEnabled"];
    public static readonly int Selected = Store["Selected"];
    public static readonly int SelectedCellsChanged = Store["SelectedCellsChanged"];
    public static readonly int SelectedDate = Store["SelectedDate"];
    public static readonly int SelectedDateChanged = Store["SelectedDateChanged"];
    public static readonly int SelectedDateFormat = Store["SelectedDateFormat"];
    public static readonly int SelectedDates = Store["SelectedDates"];
    public static readonly int SelectedDatesChanged = Store["SelectedDatesChanged"];
    public static readonly int SelectedIndex = Store["SelectedIndex"];
    public static readonly int SelectedItem = Store["SelectedItem"];
    public static readonly int SelectedItemChanged = Store["SelectedItemChanged"];
    public static readonly int SelectedItems = Store["SelectedItems"];
    public static readonly int SelectedText = Store["SelectedText"];
    public static readonly int SelectedValue = Store["SelectedValue"];
    public static readonly int SelectedValuePath = Store["SelectedValuePath"];
    public static readonly int SelectionBrush = Store["SelectionBrush"];
    public static readonly int SelectionChanged = Store["SelectionChanged"];
    public static readonly int SelectionChanging = Store["SelectionChanging"];
    public static readonly int SelectionEnd = Store["SelectionEnd"];
    public static readonly int SelectionLength = Store["SelectionLength"];
    public static readonly int SelectionMode = Store["SelectionMode"];
    public static readonly int SelectionModeChanged = Store["SelectionModeChanged"];
    public static readonly int SelectionMoved = Store["SelectionMoved"];
    public static readonly int SelectionMoving = Store["SelectionMoving"];
    public static readonly int SelectionOpacity = Store["SelectionOpacity"];
    public static readonly int SelectionResized = Store["SelectionResized"];
    public static readonly int SelectionResizing = Store["SelectionResizing"];
    public static readonly int SelectionStart = Store["SelectionStart"];
    public static readonly int SelectionUnit = Store["SelectionUnit"];
    public static readonly int SelectiveScrollingGridSelectiveScrollingOrientation = Store["SelectiveScrollingGridSelectiveScrollingOrientation"];
    public static readonly int SelectorIsSelected = Store["SelectorIsSelected"];
    public static readonly int SeparatorBrush = Store["SeparatorBrush"];
    public static readonly int SeparatorVisibility = Store["SeparatorVisibility"];
    public static readonly int ShouldPreserveUserEnteredPrefix = Store["ShouldPreserveUserEnteredPrefix"];
    public static readonly int ShowActivated = Store["ShowActivated"];
    public static readonly int ShowGridLines = Store["ShowGridLines"];
    public static readonly int ShowInTaskbar = Store["ShowInTaskbar"];
    public static readonly int ShowPageBorders = Store["ShowPageBorders"];
    public static readonly int ShowsNavigationUI = Store["ShowsNavigationUI"];
    public static readonly int ShowsPreview = Store["ShowsPreview"];
    public static readonly int SiblingBlocks = Store["SiblingBlocks"];
    public static readonly int SiblingInlines = Store["SiblingInlines"];
    public static readonly int SiblingListItems = Store["SiblingListItems"];
    public static readonly int SizeChanged = Store["SizeChanged"];
    public static readonly int SizeToContent = Store["SizeToContent"];
    public static readonly int SmallChange = Store["SmallChange"];
    public static readonly int SnapsToDevicePixels = Store["SnapsToDevicePixels"];
    public static readonly int Sorting = Store["Sorting"];
    public static readonly int Source = Store["Source"];
    public static readonly int SourceInitialized = Store["SourceInitialized"];
    public static readonly int SourceUpdated = Store["SourceUpdated"];
    public static readonly int SpeedRatio = Store["SpeedRatio"];
    public static readonly int StartIndex = Store["StartIndex"];
    public static readonly int StateChanged = Store["StateChanged"];
    public static readonly int StaysOpen = Store["StaysOpen"];
    public static readonly int StaysOpenOnClick = Store["StaysOpenOnClick"];
    public static readonly int StaysOpenOnEdit = Store["StaysOpenOnEdit"];
    public static readonly int Stretch = Store["Stretch"];
    public static readonly int StretchDirection = Store["StretchDirection"];
    public static readonly int Stroke = Store["Stroke"];
    public static readonly int StrokeCollected = Store["StrokeCollected"];
    public static readonly int StrokeDashArray = Store["StrokeDashArray"];
    public static readonly int StrokeDashCap = Store["StrokeDashCap"];
    public static readonly int StrokeDashOffset = Store["StrokeDashOffset"];
    public static readonly int StrokeEndLineCap = Store["StrokeEndLineCap"];
    public static readonly int StrokeErased = Store["StrokeErased"];
    public static readonly int StrokeErasing = Store["StrokeErasing"];
    public static readonly int StrokeLineJoin = Store["StrokeLineJoin"];
    public static readonly int StrokeMiterLimit = Store["StrokeMiterLimit"];
    public static readonly int Strokes = Store["Strokes"];
    public static readonly int StrokesReplaced = Store["StrokesReplaced"];
    public static readonly int StrokeStartLineCap = Store["StrokeStartLineCap"];
    public static readonly int StrokeThickness = Store["StrokeThickness"];
    public static readonly int Style = Store["Style"];
    public static readonly int StyleSimulations = Store["StyleSimulations"];
    public static readonly int StylusButtonDown = Store["StylusButtonDown"];
    public static readonly int StylusButtonUp = Store["StylusButtonUp"];
    public static readonly int StylusDown = Store["StylusDown"];
    public static readonly int StylusEnter = Store["StylusEnter"];
    public static readonly int StylusInAirMove = Store["StylusInAirMove"];
    public static readonly int StylusInRange = Store["StylusInRange"];
    public static readonly int StylusLeave = Store["StylusLeave"];
    public static readonly int StylusMove = Store["StylusMove"];
    public static readonly int StylusOutOfRange = Store["StylusOutOfRange"];
    public static readonly int StylusSystemGesture = Store["StylusSystemGesture"];
    public static readonly int StylusUp = Store["StylusUp"];
    public static readonly int SubmenuClosed = Store["SubmenuClosed"];
    public static readonly int SubmenuOpened = Store["SubmenuOpened"];
    public static readonly int TabIndex = Store["TabIndex"];
    public static readonly int TabStripPlacement = Store["TabStripPlacement"];
    public static readonly int Tag = Store["Tag"];
    public static readonly int Target = Store["Target"];
    public static readonly int TargetName = Store["TargetName"];
    public static readonly int TargetUpdated = Store["TargetUpdated"];
    public static readonly int TaskbarItemInfo = Store["TaskbarItemInfo"];
    public static readonly int Template = Store["Template"];
    public static readonly int Text = Store["Text"];
    public static readonly int TextAlignment = Store["TextAlignment"];
    public static readonly int TextBlockBaselineOffset = Store["TextBlockBaselineOffset"];
    public static readonly int TextBlockFontFamily = Store["TextBlockFontFamily"];
    public static readonly int TextBlockFontSize = Store["TextBlockFontSize"];
    public static readonly int TextBlockFontStretch = Store["TextBlockFontStretch"];
    public static readonly int TextBlockFontStyle = Store["TextBlockFontStyle"];
    public static readonly int TextBlockFontWeight = Store["TextBlockFontWeight"];
    public static readonly int TextBlockForeground = Store["TextBlockForeground"];
    public static readonly int TextBlockLineHeight = Store["TextBlockLineHeight"];
    public static readonly int TextBlockLineStackingStrategy = Store["TextBlockLineStackingStrategy"];
    public static readonly int TextBlockTextAlignment = Store["TextBlockTextAlignment"];
    public static readonly int TextChanged = Store["TextChanged"];
    public static readonly int TextDecorations = Store["TextDecorations"];
    public static readonly int TextEffects = Store["TextEffects"];
    public static readonly int TextElementFontFamily = Store["TextElementFontFamily"];
    public static readonly int TextElementFontSize = Store["TextElementFontSize"];
    public static readonly int TextElementFontStretch = Store["TextElementFontStretch"];
    public static readonly int TextElementFontStyle = Store["TextElementFontStyle"];
    public static readonly int TextElementFontWeight = Store["TextElementFontWeight"];
    public static readonly int TextElementForeground = Store["TextElementForeground"];
    public static readonly int TextIndent = Store["TextIndent"];
    public static readonly int TextInput = Store["TextInput"];
    public static readonly int TextOptionsTextFormattingMode = Store["TextOptionsTextFormattingMode"];
    public static readonly int TextOptionsTextHintingMode = Store["TextOptionsTextHintingMode"];
    public static readonly int TextOptionsTextRenderingMode = Store["TextOptionsTextRenderingMode"];
    public static readonly int TextTrimming = Store["TextTrimming"];
    public static readonly int TextWrapping = Store["TextWrapping"];
    public static readonly int Thumb = Store["Thumb"];
    public static readonly int TickFrequency = Store["TickFrequency"];
    public static readonly int TickPlacement = Store["TickPlacement"];
    public static readonly int Ticks = Store["Ticks"];
    public static readonly int Title = Store["Title"];
    public static readonly int ToolBarOverflowMode = Store["ToolBarOverflowMode"];
    public static readonly int ToolBars = Store["ToolBars"];
    public static readonly int ToolBarTrayIsLocked = Store["ToolBarTrayIsLocked"];
    public static readonly int ToolTip = Store["ToolTip"];
    public static readonly int ToolTipClosing = Store["ToolTipClosing"];
    public static readonly int ToolTipOpening = Store["ToolTipOpening"];
    public static readonly int ToolTipServiceBetweenShowDelay = Store["ToolTipServiceBetweenShowDelay"];
    public static readonly int ToolTipServiceHasDropShadow = Store["ToolTipServiceHasDropShadow"];
    public static readonly int ToolTipServiceHorizontalOffset = Store["ToolTipServiceHorizontalOffset"];
    public static readonly int ToolTipServiceInitialShowDelay = Store["ToolTipServiceInitialShowDelay"];
    public static readonly int ToolTipServiceIsEnabled = Store["ToolTipServiceIsEnabled"];
    public static readonly int ToolTipServicePlacement = Store["ToolTipServicePlacement"];
    public static readonly int ToolTipServicePlacementRectangle = Store["ToolTipServicePlacementRectangle"];
    public static readonly int ToolTipServicePlacementTarget = Store["ToolTipServicePlacementTarget"];
    public static readonly int ToolTipServiceShowDuration = Store["ToolTipServiceShowDuration"];
    public static readonly int ToolTipServiceShowOnDisabled = Store["ToolTipServiceShowOnDisabled"];
    public static readonly int ToolTipServiceToolTip = Store["ToolTipServiceToolTip"];
    public static readonly int ToolTipServiceVerticalOffset = Store["ToolTipServiceVerticalOffset"];
    public static readonly int Top = Store["Top"];
    public static readonly int Topmost = Store["Topmost"];
    public static readonly int TouchDown = Store["TouchDown"];
    public static readonly int TouchEnter = Store["TouchEnter"];
    public static readonly int TouchLeave = Store["TouchLeave"];
    public static readonly int TouchMove = Store["TouchMove"];
    public static readonly int TouchUp = Store["TouchUp"];
    public static readonly int Triggers = Store["Triggers"];
    public static readonly int Uid = Store["Uid"];
    public static readonly int Unchecked = Store["Unchecked"];
    public static readonly int UndoLimit = Store["UndoLimit"];
    public static readonly int UnicodeString = Store["UnicodeString"];
    public static readonly int Unloaded = Store["Unloaded"];
    public static readonly int UnloadedBehavior = Store["UnloadedBehavior"];
    public static readonly int UnloadingRow = Store["UnloadingRow"];
    public static readonly int UnloadingRowDetails = Store["UnloadingRowDetails"];
    public static readonly int Unselected = Store["Unselected"];
    public static readonly int UseCustomCursor = Store["UseCustomCursor"];
    public static readonly int UseLayoutRounding = Store["UseLayoutRounding"];
    public static readonly int UsesItemContainerTemplate = Store["UsesItemContainerTemplate"];
    public static readonly int ValidationErrorTemplate = Store["ValidationErrorTemplate"];
    public static readonly int Value = Store["Value"];
    public static readonly int ValueChanged = Store["ValueChanged"];
    public static readonly int VerticalAlignment = Store["VerticalAlignment"];
    public static readonly int VerticalAnchor = Store["VerticalAnchor"];
    public static readonly int VerticalContentAlignment = Store["VerticalContentAlignment"];
    public static readonly int VerticalGridLinesBrush = Store["VerticalGridLinesBrush"];
    public static readonly int VerticalOffset = Store["VerticalOffset"];
    public static readonly int VerticalPageSpacing = Store["VerticalPageSpacing"];
    public static readonly int VerticalScrollBarVisibility = Store["VerticalScrollBarVisibility"];
    public static readonly int View = Store["View"];
    public static readonly int ViewingMode = Store["ViewingMode"];
    public static readonly int ViewportSize = Store["ViewportSize"];
    public static readonly int VirtualizingPanelCacheLength = Store["VirtualizingPanelCacheLength"];
    public static readonly int VirtualizingPanelCacheLengthUnit = Store["VirtualizingPanelCacheLengthUnit"];
    public static readonly int VirtualizingPanelIsContainerVirtualizable = Store["VirtualizingPanelIsContainerVirtualizable"];
    public static readonly int VirtualizingPanelIsVirtualizing = Store["VirtualizingPanelIsVirtualizing"];
    public static readonly int VirtualizingPanelIsVirtualizingWhenGrouping = Store["VirtualizingPanelIsVirtualizingWhenGrouping"];
    public static readonly int VirtualizingPanelScrollUnit = Store["VirtualizingPanelScrollUnit"];
    public static readonly int VirtualizingPanelVirtualizationMode = Store["VirtualizingPanelVirtualizationMode"];
    public static readonly int Visibility = Store["Visibility"];
    public static readonly int Volume = Store["Volume"];
    public static readonly int Width = Store["Width"];
    public static readonly int WindowHeight = Store["WindowHeight"];
    public static readonly int WindowStartupLocation = Store["WindowStartupLocation"];
    public static readonly int WindowState = Store["WindowState"];
    public static readonly int WindowStyle = Store["WindowStyle"];
    public static readonly int WindowTitle = Store["WindowTitle"];
    public static readonly int WindowWidth = Store["WindowWidth"];
    public static readonly int WrapDirection = Store["WrapDirection"];
    public static readonly int WrapWidth = Store["WrapWidth"];
    public static readonly int X1 = Store["X1"];
    public static readonly int X2 = Store["X2"];
    public static readonly int Y1 = Store["Y1"];
    public static readonly int Y2 = Store["Y2"];
    public static readonly int Zoom = Store["Zoom"];
    public static readonly int ZoomIncrement = Store["ZoomIncrement"];
  }
}
