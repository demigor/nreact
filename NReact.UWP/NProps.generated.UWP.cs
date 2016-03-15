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

  public partial class NProperties
  {
    public NProperty AcceptsReturn { get { return _acceptsReturn ?? (_acceptsReturn = NPropFactories.CreateAcceptsReturn()); } }
           NProperty _acceptsReturn;

    public NProperty AllowDrop { get { return _allowDrop ?? (_allowDrop = NPropFactories.CreateAllowDrop()); } }
           NProperty _allowDrop;

    public NProperty AllowedScriptNotifyUris { get { return _allowedScriptNotifyUris ?? (_allowedScriptNotifyUris = NPropFactories.CreateAllowedScriptNotifyUris()); } }
           NProperty _allowedScriptNotifyUris;

    public NProperty AreScrollSnapPointsRegular { get { return _areScrollSnapPointsRegular ?? (_areScrollSnapPointsRegular = NPropFactories.CreateAreScrollSnapPointsRegular()); } }
           NProperty _areScrollSnapPointsRegular;

    public NProperty AreStickyGroupHeadersEnabled { get { return _areStickyGroupHeadersEnabled ?? (_areStickyGroupHeadersEnabled = NPropFactories.CreateAreStickyGroupHeadersEnabled()); } }
           NProperty _areStickyGroupHeadersEnabled;

    public NProperty AreTransportControlsEnabled { get { return _areTransportControlsEnabled ?? (_areTransportControlsEnabled = NPropFactories.CreateAreTransportControlsEnabled()); } }
           NProperty _areTransportControlsEnabled;

    public NProperty AudioCategory { get { return _audioCategory ?? (_audioCategory = NPropFactories.CreateAudioCategory()); } }
           NProperty _audioCategory;

    public NProperty AudioDeviceType { get { return _audioDeviceType ?? (_audioDeviceType = NPropFactories.CreateAudioDeviceType()); } }
           NProperty _audioDeviceType;

    public NProperty AudioStreamIndex { get { return _audioStreamIndex ?? (_audioStreamIndex = NPropFactories.CreateAudioStreamIndex()); } }
           NProperty _audioStreamIndex;

    public NProperty AutoMaximizeSuggestionArea { get { return _autoMaximizeSuggestionArea ?? (_autoMaximizeSuggestionArea = NPropFactories.CreateAutoMaximizeSuggestionArea()); } }
           NProperty _autoMaximizeSuggestionArea;

    public NProperty AutoPlay { get { return _autoPlay ?? (_autoPlay = NPropFactories.CreateAutoPlay()); } }
           NProperty _autoPlay;

    public NProperty BackClick { get { return _backClick ?? (_backClick = NPropFactories.CreateBackClick()); } }
           NProperty _backClick;

    public NProperty Background { get { return _background ?? (_background = NPropFactories.CreateBackground()); } }
           NProperty _background;

    public NProperty Balance { get { return _balance ?? (_balance = NPropFactories.CreateBalance()); } }
           NProperty _balance;

    public NProperty BlackoutForeground { get { return _blackoutForeground ?? (_blackoutForeground = NPropFactories.CreateBlackoutForeground()); } }
           NProperty _blackoutForeground;

    public NProperty Blocks { get { return _blocks ?? (_blocks = NPropFactories.CreateBlocks()); } }
           NProperty _blocks;

    public NProperty BorderBrush { get { return _borderBrush ?? (_borderBrush = NPropFactories.CreateBorderBrush()); } }
           NProperty _borderBrush;

    public NProperty BorderThickness { get { return _borderThickness ?? (_borderThickness = NPropFactories.CreateBorderThickness()); } }
           NProperty _borderThickness;

    public NProperty BottomAppBar { get { return _bottomAppBar ?? (_bottomAppBar = NPropFactories.CreateBottomAppBar()); } }
           NProperty _bottomAppBar;

    public NProperty BringIntoViewOnFocusChange { get { return _bringIntoViewOnFocusChange ?? (_bringIntoViewOnFocusChange = NPropFactories.CreateBringIntoViewOnFocusChange()); } }
           NProperty _bringIntoViewOnFocusChange;

    public NProperty BufferingProgressChanged { get { return _bufferingProgressChanged ?? (_bufferingProgressChanged = NPropFactories.CreateBufferingProgressChanged()); } }
           NProperty _bufferingProgressChanged;

    public NProperty BusinessLandmarksVisible { get { return _businessLandmarksVisible ?? (_businessLandmarksVisible = NPropFactories.CreateBusinessLandmarksVisible()); } }
           NProperty _businessLandmarksVisible;

    public NProperty CacheLength { get { return _cacheLength ?? (_cacheLength = NPropFactories.CreateCacheLength()); } }
           NProperty _cacheLength;

    public NProperty CacheMode { get { return _cacheMode ?? (_cacheMode = NPropFactories.CreateCacheMode()); } }
           NProperty _cacheMode;

    public NProperty CacheSize { get { return _cacheSize ?? (_cacheSize = NPropFactories.CreateCacheSize()); } }
           NProperty _cacheSize;

    public NProperty CalendarIdentifier { get { return _calendarIdentifier ?? (_calendarIdentifier = NPropFactories.CreateCalendarIdentifier()); } }
           NProperty _calendarIdentifier;

    public NProperty CalendarItemBackground { get { return _calendarItemBackground ?? (_calendarItemBackground = NPropFactories.CreateCalendarItemBackground()); } }
           NProperty _calendarItemBackground;

    public NProperty CalendarItemBorderBrush { get { return _calendarItemBorderBrush ?? (_calendarItemBorderBrush = NPropFactories.CreateCalendarItemBorderBrush()); } }
           NProperty _calendarItemBorderBrush;

    public NProperty CalendarItemBorderThickness { get { return _calendarItemBorderThickness ?? (_calendarItemBorderThickness = NPropFactories.CreateCalendarItemBorderThickness()); } }
           NProperty _calendarItemBorderThickness;

    public NProperty CalendarItemForeground { get { return _calendarItemForeground ?? (_calendarItemForeground = NPropFactories.CreateCalendarItemForeground()); } }
           NProperty _calendarItemForeground;

    public NProperty CalendarViewDayItemStyle { get { return _calendarViewDayItemStyle ?? (_calendarViewDayItemStyle = NPropFactories.CreateCalendarViewDayItemStyle()); } }
           NProperty _calendarViewDayItemStyle;

    public NProperty CalendarViewStyle { get { return _calendarViewStyle ?? (_calendarViewStyle = NPropFactories.CreateCalendarViewStyle()); } }
           NProperty _calendarViewStyle;

    public NProperty CanChangeViews { get { return _canChangeViews ?? (_canChangeViews = NPropFactories.CreateCanChangeViews()); } }
           NProperty _canChangeViews;

    public NProperty CanDrag { get { return _canDrag ?? (_canDrag = NPropFactories.CreateCanDrag()); } }
           NProperty _canDrag;

    public NProperty CanDragItems { get { return _canDragItems ?? (_canDragItems = NPropFactories.CreateCanDragItems()); } }
           NProperty _canDragItems;

    public NProperty CanHorizontallyScroll { get { return _canHorizontallyScroll ?? (_canHorizontallyScroll = NPropFactories.CreateCanHorizontallyScroll()); } }
           NProperty _canHorizontallyScroll;

    public NProperty CanReorderItems { get { return _canReorderItems ?? (_canReorderItems = NPropFactories.CreateCanReorderItems()); } }
           NProperty _canReorderItems;

    public NProperty CanvasLeft { get { return _canvasLeft ?? (_canvasLeft = NPropFactories.CreateCanvasLeft()); } }
           NProperty _canvasLeft;

    public NProperty CanvasTop { get { return _canvasTop ?? (_canvasTop = NPropFactories.CreateCanvasTop()); } }
           NProperty _canvasTop;

    public NProperty CanvasZIndex { get { return _canvasZIndex ?? (_canvasZIndex = NPropFactories.CreateCanvasZIndex()); } }
           NProperty _canvasZIndex;

    public NProperty CanVerticallyScroll { get { return _canVerticallyScroll ?? (_canVerticallyScroll = NPropFactories.CreateCanVerticallyScroll()); } }
           NProperty _canVerticallyScroll;

    public NProperty Center { get { return _center ?? (_center = NPropFactories.CreateCenter()); } }
           NProperty _center;

    public NProperty CharacterSpacing { get { return _characterSpacing ?? (_characterSpacing = NPropFactories.CreateCharacterSpacing()); } }
           NProperty _characterSpacing;

    public NProperty CheckBoxBrush { get { return _checkBoxBrush ?? (_checkBoxBrush = NPropFactories.CreateCheckBoxBrush()); } }
           NProperty _checkBoxBrush;

    public NProperty CheckBrush { get { return _checkBrush ?? (_checkBrush = NPropFactories.CreateCheckBrush()); } }
           NProperty _checkBrush;

    public NProperty Checked { get { return _checked ?? (_checked = NPropFactories.CreateChecked()); } }
           NProperty _checked;

    public NProperty CheckHintBrush { get { return _checkHintBrush ?? (_checkHintBrush = NPropFactories.CreateCheckHintBrush()); } }
           NProperty _checkHintBrush;

    public NProperty CheckMode { get { return _checkMode ?? (_checkMode = NPropFactories.CreateCheckMode()); } }
           NProperty _checkMode;

    public NProperty CheckSelectingBrush { get { return _checkSelectingBrush ?? (_checkSelectingBrush = NPropFactories.CreateCheckSelectingBrush()); } }
           NProperty _checkSelectingBrush;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
           NProperty _child;

    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
           NProperty _children;

    public NProperty ChildrenTransitions { get { return _childrenTransitions ?? (_childrenTransitions = NPropFactories.CreateChildrenTransitions()); } }
           NProperty _childrenTransitions;

    public NProperty ChildTransitions { get { return _childTransitions ?? (_childTransitions = NPropFactories.CreateChildTransitions()); } }
           NProperty _childTransitions;

    public NProperty ChooseSuggestionOnEnter { get { return _chooseSuggestionOnEnter ?? (_chooseSuggestionOnEnter = NPropFactories.CreateChooseSuggestionOnEnter()); } }
           NProperty _chooseSuggestionOnEnter;

    public NProperty CleanUpVirtualizedItemEvent { get { return _cleanUpVirtualizedItemEvent ?? (_cleanUpVirtualizedItemEvent = NPropFactories.CreateCleanUpVirtualizedItemEvent()); } }
           NProperty _cleanUpVirtualizedItemEvent;

    public NProperty Click { get { return _click ?? (_click = NPropFactories.CreateClick()); } }
           NProperty _click;

    public NProperty ClickMode { get { return _clickMode ?? (_clickMode = NPropFactories.CreateClickMode()); } }
           NProperty _clickMode;

    public NProperty Clip { get { return _clip ?? (_clip = NPropFactories.CreateClip()); } }
           NProperty _clip;

    public NProperty ClipboardCopyFormat { get { return _clipboardCopyFormat ?? (_clipboardCopyFormat = NPropFactories.CreateClipboardCopyFormat()); } }
           NProperty _clipboardCopyFormat;

    public NProperty ClockIdentifier { get { return _clockIdentifier ?? (_clockIdentifier = NPropFactories.CreateClockIdentifier()); } }
           NProperty _clockIdentifier;

    public NProperty Closed { get { return _closed ?? (_closed = NPropFactories.CreateClosed()); } }
           NProperty _closed;

    public NProperty ClosedDisplayMode { get { return _closedDisplayMode ?? (_closedDisplayMode = NPropFactories.CreateClosedDisplayMode()); } }
           NProperty _closedDisplayMode;

    public NProperty Closing { get { return _closing ?? (_closing = NPropFactories.CreateClosing()); } }
           NProperty _closing;

    public NProperty ColorFontPaletteIndex { get { return _colorFontPaletteIndex ?? (_colorFontPaletteIndex = NPropFactories.CreateColorFontPaletteIndex()); } }
           NProperty _colorFontPaletteIndex;

    public NProperty ColorScheme { get { return _colorScheme ?? (_colorScheme = NPropFactories.CreateColorScheme()); } }
           NProperty _colorScheme;

    public NProperty ColumnDefinitions { get { return _columnDefinitions ?? (_columnDefinitions = NPropFactories.CreateColumnDefinitions()); } }
           NProperty _columnDefinitions;

    public NProperty Command { get { return _command ?? (_command = NPropFactories.CreateCommand()); } }
           NProperty _command;

    public NProperty CommandBarOverflowPresenterStyle { get { return _commandBarOverflowPresenterStyle ?? (_commandBarOverflowPresenterStyle = NPropFactories.CreateCommandBarOverflowPresenterStyle()); } }
           NProperty _commandBarOverflowPresenterStyle;

    public NProperty CommandParameter { get { return _commandParameter ?? (_commandParameter = NPropFactories.CreateCommandParameter()); } }
           NProperty _commandParameter;

    public NProperty CompactPaneLength { get { return _compactPaneLength ?? (_compactPaneLength = NPropFactories.CreateCompactPaneLength()); } }
           NProperty _compactPaneLength;

    public NProperty CompositeMode { get { return _compositeMode ?? (_compositeMode = NPropFactories.CreateCompositeMode()); } }
           NProperty _compositeMode;

    public NProperty Content { get { return _content ?? (_content = NPropFactories.CreateContent()); } }
           NProperty _content;

    public NProperty ContentMargin { get { return _contentMargin ?? (_contentMargin = NPropFactories.CreateContentMargin()); } }
           NProperty _contentMargin;

    public NProperty ContentTemplate { get { return _contentTemplate ?? (_contentTemplate = NPropFactories.CreateContentTemplate()); } }
           NProperty _contentTemplate;

    public NProperty ContentTemplateSelector { get { return _contentTemplateSelector ?? (_contentTemplateSelector = NPropFactories.CreateContentTemplateSelector()); } }
           NProperty _contentTemplateSelector;

    public NProperty ContentTransitions { get { return _contentTransitions ?? (_contentTransitions = NPropFactories.CreateContentTransitions()); } }
           NProperty _contentTransitions;

    public NProperty ContextMenuOpening { get { return _contextMenuOpening ?? (_contextMenuOpening = NPropFactories.CreateContextMenuOpening()); } }
           NProperty _contextMenuOpening;

    public NProperty ControlIsTemplateFocusTarget { get { return _controlIsTemplateFocusTarget ?? (_controlIsTemplateFocusTarget = NPropFactories.CreateControlIsTemplateFocusTarget()); } }
           NProperty _controlIsTemplateFocusTarget;

    public NProperty CornerRadius { get { return _cornerRadius ?? (_cornerRadius = NPropFactories.CreateCornerRadius()); } }
           NProperty _cornerRadius;

    public NProperty CurrentStateChanged { get { return _currentStateChanged ?? (_currentStateChanged = NPropFactories.CreateCurrentStateChanged()); } }
           NProperty _currentStateChanged;

    public NProperty Data { get { return _data ?? (_data = NPropFactories.CreateData()); } }
           NProperty _data;

    public NProperty DataContext { get { return _dataContext ?? (_dataContext = NPropFactories.CreateDataContext()); } }
           NProperty _dataContext;

    public NProperty DataFetchSize { get { return _dataFetchSize ?? (_dataFetchSize = NPropFactories.CreateDataFetchSize()); } }
           NProperty _dataFetchSize;

    public NProperty Date { get { return _date ?? (_date = NPropFactories.CreateDate()); } }
           NProperty _date;

    public NProperty DateChanged { get { return _dateChanged ?? (_dateChanged = NPropFactories.CreateDateChanged()); } }
           NProperty _dateChanged;

    public NProperty DateFormat { get { return _dateFormat ?? (_dateFormat = NPropFactories.CreateDateFormat()); } }
           NProperty _dateFormat;

    public NProperty DayFormat { get { return _dayFormat ?? (_dayFormat = NPropFactories.CreateDayFormat()); } }
           NProperty _dayFormat;

    public NProperty DayItemFontFamily { get { return _dayItemFontFamily ?? (_dayItemFontFamily = NPropFactories.CreateDayItemFontFamily()); } }
           NProperty _dayItemFontFamily;

    public NProperty DayItemFontSize { get { return _dayItemFontSize ?? (_dayItemFontSize = NPropFactories.CreateDayItemFontSize()); } }
           NProperty _dayItemFontSize;

    public NProperty DayItemFontStyle { get { return _dayItemFontStyle ?? (_dayItemFontStyle = NPropFactories.CreateDayItemFontStyle()); } }
           NProperty _dayItemFontStyle;

    public NProperty DayItemFontWeight { get { return _dayItemFontWeight ?? (_dayItemFontWeight = NPropFactories.CreateDayItemFontWeight()); } }
           NProperty _dayItemFontWeight;

    public NProperty DayOfWeekFormat { get { return _dayOfWeekFormat ?? (_dayOfWeekFormat = NPropFactories.CreateDayOfWeekFormat()); } }
           NProperty _dayOfWeekFormat;

    public NProperty DayVisible { get { return _dayVisible ?? (_dayVisible = NPropFactories.CreateDayVisible()); } }
           NProperty _dayVisible;

    public NProperty DefaultBackgroundColor { get { return _defaultBackgroundColor ?? (_defaultBackgroundColor = NPropFactories.CreateDefaultBackgroundColor()); } }
           NProperty _defaultBackgroundColor;

    public NProperty DefaultPlaybackRate { get { return _defaultPlaybackRate ?? (_defaultPlaybackRate = NPropFactories.CreateDefaultPlaybackRate()); } }
           NProperty _defaultPlaybackRate;

    public NProperty DefaultSectionIndex { get { return _defaultSectionIndex ?? (_defaultSectionIndex = NPropFactories.CreateDefaultSectionIndex()); } }
           NProperty _defaultSectionIndex;

    public NProperty Delay { get { return _delay ?? (_delay = NPropFactories.CreateDelay()); } }
           NProperty _delay;

    public NProperty DesiredCandidateWindowAlignment { get { return _desiredCandidateWindowAlignment ?? (_desiredCandidateWindowAlignment = NPropFactories.CreateDesiredCandidateWindowAlignment()); } }
           NProperty _desiredCandidateWindowAlignment;

    public NProperty DesiredPitch { get { return _desiredPitch ?? (_desiredPitch = NPropFactories.CreateDesiredPitch()); } }
           NProperty _desiredPitch;

    public NProperty DirectManipulationCompleted { get { return _directManipulationCompleted ?? (_directManipulationCompleted = NPropFactories.CreateDirectManipulationCompleted()); } }
           NProperty _directManipulationCompleted;

    public NProperty DirectManipulationStarted { get { return _directManipulationStarted ?? (_directManipulationStarted = NPropFactories.CreateDirectManipulationStarted()); } }
           NProperty _directManipulationStarted;

    public NProperty DisabledOpacity { get { return _disabledOpacity ?? (_disabledOpacity = NPropFactories.CreateDisabledOpacity()); } }
           NProperty _disabledOpacity;

    public NProperty DisplayMemberPath { get { return _displayMemberPath ?? (_displayMemberPath = NPropFactories.CreateDisplayMemberPath()); } }
           NProperty _displayMemberPath;

    public NProperty DisplayMode { get { return _displayMode ?? (_displayMode = NPropFactories.CreateDisplayMode()); } }
           NProperty _displayMode;

    public NProperty DoubleTapped { get { return _doubleTapped ?? (_doubleTapped = NPropFactories.CreateDoubleTapped()); } }
           NProperty _doubleTapped;

    public NProperty DownloadProgressChanged { get { return _downloadProgressChanged ?? (_downloadProgressChanged = NPropFactories.CreateDownloadProgressChanged()); } }
           NProperty _downloadProgressChanged;

    public NProperty DragBackground { get { return _dragBackground ?? (_dragBackground = NPropFactories.CreateDragBackground()); } }
           NProperty _dragBackground;

    public NProperty DragCompleted { get { return _dragCompleted ?? (_dragCompleted = NPropFactories.CreateDragCompleted()); } }
           NProperty _dragCompleted;

    public NProperty DragDelta { get { return _dragDelta ?? (_dragDelta = NPropFactories.CreateDragDelta()); } }
           NProperty _dragDelta;

    public NProperty DragEnter { get { return _dragEnter ?? (_dragEnter = NPropFactories.CreateDragEnter()); } }
           NProperty _dragEnter;

    public NProperty DragForeground { get { return _dragForeground ?? (_dragForeground = NPropFactories.CreateDragForeground()); } }
           NProperty _dragForeground;

    public NProperty DragItemsStarting { get { return _dragItemsStarting ?? (_dragItemsStarting = NPropFactories.CreateDragItemsStarting()); } }
           NProperty _dragItemsStarting;

    public NProperty DragLeave { get { return _dragLeave ?? (_dragLeave = NPropFactories.CreateDragLeave()); } }
           NProperty _dragLeave;

    public NProperty DragOpacity { get { return _dragOpacity ?? (_dragOpacity = NPropFactories.CreateDragOpacity()); } }
           NProperty _dragOpacity;

    public NProperty DragOver { get { return _dragOver ?? (_dragOver = NPropFactories.CreateDragOver()); } }
           NProperty _dragOver;

    public NProperty DragStarted { get { return _dragStarted ?? (_dragStarted = NPropFactories.CreateDragStarted()); } }
           NProperty _dragStarted;

    public NProperty Drop { get { return _drop ?? (_drop = NPropFactories.CreateDrop()); } }
           NProperty _drop;

    public NProperty DropDownClosed { get { return _dropDownClosed ?? (_dropDownClosed = NPropFactories.CreateDropDownClosed()); } }
           NProperty _dropDownClosed;

    public NProperty DropDownOpened { get { return _dropDownOpened ?? (_dropDownOpened = NPropFactories.CreateDropDownOpened()); } }
           NProperty _dropDownOpened;

    public NProperty Fill { get { return _fill ?? (_fill = NPropFactories.CreateFill()); } }
           NProperty _fill;

    public NProperty FillRule { get { return _fillRule ?? (_fillRule = NPropFactories.CreateFillRule()); } }
           NProperty _fillRule;

    public NProperty FirstDayOfWeek { get { return _firstDayOfWeek ?? (_firstDayOfWeek = NPropFactories.CreateFirstDayOfWeek()); } }
           NProperty _firstDayOfWeek;

    public NProperty FirstOfMonthLabelFontFamily { get { return _firstOfMonthLabelFontFamily ?? (_firstOfMonthLabelFontFamily = NPropFactories.CreateFirstOfMonthLabelFontFamily()); } }
           NProperty _firstOfMonthLabelFontFamily;

    public NProperty FirstOfMonthLabelFontSize { get { return _firstOfMonthLabelFontSize ?? (_firstOfMonthLabelFontSize = NPropFactories.CreateFirstOfMonthLabelFontSize()); } }
           NProperty _firstOfMonthLabelFontSize;

    public NProperty FirstOfMonthLabelFontStyle { get { return _firstOfMonthLabelFontStyle ?? (_firstOfMonthLabelFontStyle = NPropFactories.CreateFirstOfMonthLabelFontStyle()); } }
           NProperty _firstOfMonthLabelFontStyle;

    public NProperty FirstOfMonthLabelFontWeight { get { return _firstOfMonthLabelFontWeight ?? (_firstOfMonthLabelFontWeight = NPropFactories.CreateFirstOfMonthLabelFontWeight()); } }
           NProperty _firstOfMonthLabelFontWeight;

    public NProperty FirstOfYearDecadeLabelFontFamily { get { return _firstOfYearDecadeLabelFontFamily ?? (_firstOfYearDecadeLabelFontFamily = NPropFactories.CreateFirstOfYearDecadeLabelFontFamily()); } }
           NProperty _firstOfYearDecadeLabelFontFamily;

    public NProperty FirstOfYearDecadeLabelFontSize { get { return _firstOfYearDecadeLabelFontSize ?? (_firstOfYearDecadeLabelFontSize = NPropFactories.CreateFirstOfYearDecadeLabelFontSize()); } }
           NProperty _firstOfYearDecadeLabelFontSize;

    public NProperty FirstOfYearDecadeLabelFontStyle { get { return _firstOfYearDecadeLabelFontStyle ?? (_firstOfYearDecadeLabelFontStyle = NPropFactories.CreateFirstOfYearDecadeLabelFontStyle()); } }
           NProperty _firstOfYearDecadeLabelFontStyle;

    public NProperty FirstOfYearDecadeLabelFontWeight { get { return _firstOfYearDecadeLabelFontWeight ?? (_firstOfYearDecadeLabelFontWeight = NPropFactories.CreateFirstOfYearDecadeLabelFontWeight()); } }
           NProperty _firstOfYearDecadeLabelFontWeight;

    public NProperty FlowDirection { get { return _flowDirection ?? (_flowDirection = NPropFactories.CreateFlowDirection()); } }
           NProperty _flowDirection;

    public NProperty Flyout { get { return _flyout ?? (_flyout = NPropFactories.CreateFlyout()); } }
           NProperty _flyout;

    public NProperty FocusBorderBrush { get { return _focusBorderBrush ?? (_focusBorderBrush = NPropFactories.CreateFocusBorderBrush()); } }
           NProperty _focusBorderBrush;

    public NProperty FocusOnKeyboardInput { get { return _focusOnKeyboardInput ?? (_focusOnKeyboardInput = NPropFactories.CreateFocusOnKeyboardInput()); } }
           NProperty _focusOnKeyboardInput;

    public NProperty FocusSecondaryBorderBrush { get { return _focusSecondaryBorderBrush ?? (_focusSecondaryBorderBrush = NPropFactories.CreateFocusSecondaryBorderBrush()); } }
           NProperty _focusSecondaryBorderBrush;

    public NProperty FontFamily { get { return _fontFamily ?? (_fontFamily = NPropFactories.CreateFontFamily()); } }
           NProperty _fontFamily;

    public NProperty FontRenderingEmSize { get { return _fontRenderingEmSize ?? (_fontRenderingEmSize = NPropFactories.CreateFontRenderingEmSize()); } }
           NProperty _fontRenderingEmSize;

    public NProperty FontSize { get { return _fontSize ?? (_fontSize = NPropFactories.CreateFontSize()); } }
           NProperty _fontSize;

    public NProperty FontStretch { get { return _fontStretch ?? (_fontStretch = NPropFactories.CreateFontStretch()); } }
           NProperty _fontStretch;

    public NProperty FontStyle { get { return _fontStyle ?? (_fontStyle = NPropFactories.CreateFontStyle()); } }
           NProperty _fontStyle;

    public NProperty FontUri { get { return _fontUri ?? (_fontUri = NPropFactories.CreateFontUri()); } }
           NProperty _fontUri;

    public NProperty FontWeight { get { return _fontWeight ?? (_fontWeight = NPropFactories.CreateFontWeight()); } }
           NProperty _fontWeight;

    public NProperty Footer { get { return _footer ?? (_footer = NPropFactories.CreateFooter()); } }
           NProperty _footer;

    public NProperty FooterTemplate { get { return _footerTemplate ?? (_footerTemplate = NPropFactories.CreateFooterTemplate()); } }
           NProperty _footerTemplate;

    public NProperty FooterTransitions { get { return _footerTransitions ?? (_footerTransitions = NPropFactories.CreateFooterTransitions()); } }
           NProperty _footerTransitions;

    public NProperty Foreground { get { return _foreground ?? (_foreground = NPropFactories.CreateForeground()); } }
           NProperty _foreground;

    public NProperty FullSizeDesired { get { return _fullSizeDesired ?? (_fullSizeDesired = NPropFactories.CreateFullSizeDesired()); } }
           NProperty _fullSizeDesired;

    public NProperty Glyph { get { return _glyph ?? (_glyph = NPropFactories.CreateGlyph()); } }
           NProperty _glyph;

    public NProperty GotFocus { get { return _gotFocus ?? (_gotFocus = NPropFactories.CreateGotFocus()); } }
           NProperty _gotFocus;

    public NProperty GridColumn { get { return _gridColumn ?? (_gridColumn = NPropFactories.CreateGridColumn()); } }
           NProperty _gridColumn;

    public NProperty GridColumnSpan { get { return _gridColumnSpan ?? (_gridColumnSpan = NPropFactories.CreateGridColumnSpan()); } }
           NProperty _gridColumnSpan;

    public NProperty GridRow { get { return _gridRow ?? (_gridRow = NPropFactories.CreateGridRow()); } }
           NProperty _gridRow;

    public NProperty GridRowSpan { get { return _gridRowSpan ?? (_gridRowSpan = NPropFactories.CreateGridRowSpan()); } }
           NProperty _gridRowSpan;

    public NProperty GridViewItemPresenterHorizontalContentAlignment { get { return _gridViewItemPresenterHorizontalContentAlignment ?? (_gridViewItemPresenterHorizontalContentAlignment = NPropFactories.CreateGridViewItemPresenterHorizontalContentAlignment()); } }
           NProperty _gridViewItemPresenterHorizontalContentAlignment;

    public NProperty GridViewItemPresenterPadding { get { return _gridViewItemPresenterPadding ?? (_gridViewItemPresenterPadding = NPropFactories.CreateGridViewItemPresenterPadding()); } }
           NProperty _gridViewItemPresenterPadding;

    public NProperty GridViewItemPresenterVerticalContentAlignment { get { return _gridViewItemPresenterVerticalContentAlignment ?? (_gridViewItemPresenterVerticalContentAlignment = NPropFactories.CreateGridViewItemPresenterVerticalContentAlignment()); } }
           NProperty _gridViewItemPresenterVerticalContentAlignment;

    public NProperty GroupHeaderPlacement { get { return _groupHeaderPlacement ?? (_groupHeaderPlacement = NPropFactories.CreateGroupHeaderPlacement()); } }
           NProperty _groupHeaderPlacement;

    public NProperty GroupName { get { return _groupName ?? (_groupName = NPropFactories.CreateGroupName()); } }
           NProperty _groupName;

    public NProperty GroupPadding { get { return _groupPadding ?? (_groupPadding = NPropFactories.CreateGroupPadding()); } }
           NProperty _groupPadding;

    public NProperty GroupStyle { get { return _groupStyle ?? (_groupStyle = NPropFactories.CreateGroupStyle()); } }
           NProperty _groupStyle;

    public NProperty GroupStyleSelector { get { return _groupStyleSelector ?? (_groupStyleSelector = NPropFactories.CreateGroupStyleSelector()); } }
           NProperty _groupStyleSelector;

    public NProperty Header { get { return _header ?? (_header = NPropFactories.CreateHeader()); } }
           NProperty _header;

    public NProperty HeaderBackground { get { return _headerBackground ?? (_headerBackground = NPropFactories.CreateHeaderBackground()); } }
           NProperty _headerBackground;

    public NProperty HeaderForeground { get { return _headerForeground ?? (_headerForeground = NPropFactories.CreateHeaderForeground()); } }
           NProperty _headerForeground;

    public NProperty HeaderTemplate { get { return _headerTemplate ?? (_headerTemplate = NPropFactories.CreateHeaderTemplate()); } }
           NProperty _headerTemplate;

    public NProperty HeaderTransitions { get { return _headerTransitions ?? (_headerTransitions = NPropFactories.CreateHeaderTransitions()); } }
           NProperty _headerTransitions;

    public NProperty Heading { get { return _heading ?? (_heading = NPropFactories.CreateHeading()); } }
           NProperty _heading;

    public NProperty Height { get { return _height ?? (_height = NPropFactories.CreateHeight()); } }
           NProperty _height;

    public NProperty Holding { get { return _holding ?? (_holding = NPropFactories.CreateHolding()); } }
           NProperty _holding;

    public NProperty HorizontalAlignment { get { return _horizontalAlignment ?? (_horizontalAlignment = NPropFactories.CreateHorizontalAlignment()); } }
           NProperty _horizontalAlignment;

    public NProperty HorizontalChildrenAlignment { get { return _horizontalChildrenAlignment ?? (_horizontalChildrenAlignment = NPropFactories.CreateHorizontalChildrenAlignment()); } }
           NProperty _horizontalChildrenAlignment;

    public NProperty HorizontalContentAlignment { get { return _horizontalContentAlignment ?? (_horizontalContentAlignment = NPropFactories.CreateHorizontalContentAlignment()); } }
           NProperty _horizontalContentAlignment;

    public NProperty HorizontalDayItemAlignment { get { return _horizontalDayItemAlignment ?? (_horizontalDayItemAlignment = NPropFactories.CreateHorizontalDayItemAlignment()); } }
           NProperty _horizontalDayItemAlignment;

    public NProperty HorizontalFirstOfMonthLabelAlignment { get { return _horizontalFirstOfMonthLabelAlignment ?? (_horizontalFirstOfMonthLabelAlignment = NPropFactories.CreateHorizontalFirstOfMonthLabelAlignment()); } }
           NProperty _horizontalFirstOfMonthLabelAlignment;

    public NProperty HorizontalOffset { get { return _horizontalOffset ?? (_horizontalOffset = NPropFactories.CreateHorizontalOffset()); } }
           NProperty _horizontalOffset;

    public NProperty HorizontalScrollBarVisibility { get { return _horizontalScrollBarVisibility ?? (_horizontalScrollBarVisibility = NPropFactories.CreateHorizontalScrollBarVisibility()); } }
           NProperty _horizontalScrollBarVisibility;

    public NProperty HorizontalScrollMode { get { return _horizontalScrollMode ?? (_horizontalScrollMode = NPropFactories.CreateHorizontalScrollMode()); } }
           NProperty _horizontalScrollMode;

    public NProperty HorizontalSnapPointsAlignment { get { return _horizontalSnapPointsAlignment ?? (_horizontalSnapPointsAlignment = NPropFactories.CreateHorizontalSnapPointsAlignment()); } }
           NProperty _horizontalSnapPointsAlignment;

    public NProperty HorizontalSnapPointsChanged { get { return _horizontalSnapPointsChanged ?? (_horizontalSnapPointsChanged = NPropFactories.CreateHorizontalSnapPointsChanged()); } }
           NProperty _horizontalSnapPointsChanged;

    public NProperty HorizontalSnapPointsType { get { return _horizontalSnapPointsType ?? (_horizontalSnapPointsType = NPropFactories.CreateHorizontalSnapPointsType()); } }
           NProperty _horizontalSnapPointsType;

    public NProperty HoverBorderBrush { get { return _hoverBorderBrush ?? (_hoverBorderBrush = NPropFactories.CreateHoverBorderBrush()); } }
           NProperty _hoverBorderBrush;

    public NProperty Icon { get { return _icon ?? (_icon = NPropFactories.CreateIcon()); } }
           NProperty _icon;

    public NProperty IconSource { get { return _iconSource ?? (_iconSource = NPropFactories.CreateIconSource()); } }
           NProperty _iconSource;

    public NProperty ImageFailed { get { return _imageFailed ?? (_imageFailed = NPropFactories.CreateImageFailed()); } }
           NProperty _imageFailed;

    public NProperty ImageOpened { get { return _imageOpened ?? (_imageOpened = NPropFactories.CreateImageOpened()); } }
           NProperty _imageOpened;

    public NProperty IncrementalLoadingThreshold { get { return _incrementalLoadingThreshold ?? (_incrementalLoadingThreshold = NPropFactories.CreateIncrementalLoadingThreshold()); } }
           NProperty _incrementalLoadingThreshold;

    public NProperty IncrementalLoadingTrigger { get { return _incrementalLoadingTrigger ?? (_incrementalLoadingTrigger = NPropFactories.CreateIncrementalLoadingTrigger()); } }
           NProperty _incrementalLoadingTrigger;

    public NProperty Indeterminate { get { return _indeterminate ?? (_indeterminate = NPropFactories.CreateIndeterminate()); } }
           NProperty _indeterminate;

    public NProperty IndicatorMode { get { return _indicatorMode ?? (_indicatorMode = NPropFactories.CreateIndicatorMode()); } }
           NProperty _indicatorMode;

    public NProperty Indices { get { return _indices ?? (_indices = NPropFactories.CreateIndices()); } }
           NProperty _indices;

    public NProperty Inlines { get { return _inlines ?? (_inlines = NPropFactories.CreateInlines()); } }
           NProperty _inlines;

    public NProperty InputScope { get { return _inputScope ?? (_inputScope = NPropFactories.CreateInputScope()); } }
           NProperty _inputScope;

    public NProperty IntermediateValue { get { return _intermediateValue ?? (_intermediateValue = NPropFactories.CreateIntermediateValue()); } }
           NProperty _intermediateValue;

    public NProperty Interval { get { return _interval ?? (_interval = NPropFactories.CreateInterval()); } }
           NProperty _interval;

    public NProperty IsActive { get { return _isActive ?? (_isActive = NPropFactories.CreateIsActive()); } }
           NProperty _isActive;

    public NProperty IsActiveView { get { return _isActiveView ?? (_isActiveView = NPropFactories.CreateIsActiveView()); } }
           NProperty _isActiveView;

    public NProperty IsBlackout { get { return _isBlackout ?? (_isBlackout = NPropFactories.CreateIsBlackout()); } }
           NProperty _isBlackout;

    public NProperty IsCalendarOpen { get { return _isCalendarOpen ?? (_isCalendarOpen = NPropFactories.CreateIsCalendarOpen()); } }
           NProperty _isCalendarOpen;

    public NProperty IsChecked { get { return _isChecked ?? (_isChecked = NPropFactories.CreateIsChecked()); } }
           NProperty _isChecked;

    public NProperty IsColorFontEnabled { get { return _isColorFontEnabled ?? (_isColorFontEnabled = NPropFactories.CreateIsColorFontEnabled()); } }
           NProperty _isColorFontEnabled;

    public NProperty IsCompact { get { return _isCompact ?? (_isCompact = NPropFactories.CreateIsCompact()); } }
           NProperty _isCompact;

    public NProperty IsDeferredScrollingEnabled { get { return _isDeferredScrollingEnabled ?? (_isDeferredScrollingEnabled = NPropFactories.CreateIsDeferredScrollingEnabled()); } }
           NProperty _isDeferredScrollingEnabled;

    public NProperty IsDirectionReversed { get { return _isDirectionReversed ?? (_isDirectionReversed = NPropFactories.CreateIsDirectionReversed()); } }
           NProperty _isDirectionReversed;

    public NProperty IsDoubleTapEnabled { get { return _isDoubleTapEnabled ?? (_isDoubleTapEnabled = NPropFactories.CreateIsDoubleTapEnabled()); } }
           NProperty _isDoubleTapEnabled;

    public NProperty IsDropDownOpen { get { return _isDropDownOpen ?? (_isDropDownOpen = NPropFactories.CreateIsDropDownOpen()); } }
           NProperty _isDropDownOpen;

    public NProperty IsEnabled { get { return _isEnabled ?? (_isEnabled = NPropFactories.CreateIsEnabled()); } }
           NProperty _isEnabled;

    public NProperty IsEnabledChanged { get { return _isEnabledChanged ?? (_isEnabledChanged = NPropFactories.CreateIsEnabledChanged()); } }
           NProperty _isEnabledChanged;

    public NProperty IsFastForwardButtonVisible { get { return _isFastForwardButtonVisible ?? (_isFastForwardButtonVisible = NPropFactories.CreateIsFastForwardButtonVisible()); } }
           NProperty _isFastForwardButtonVisible;

    public NProperty IsFastForwardEnabled { get { return _isFastForwardEnabled ?? (_isFastForwardEnabled = NPropFactories.CreateIsFastForwardEnabled()); } }
           NProperty _isFastForwardEnabled;

    public NProperty IsFastRewindButtonVisible { get { return _isFastRewindButtonVisible ?? (_isFastRewindButtonVisible = NPropFactories.CreateIsFastRewindButtonVisible()); } }
           NProperty _isFastRewindButtonVisible;

    public NProperty IsFastRewindEnabled { get { return _isFastRewindEnabled ?? (_isFastRewindEnabled = NPropFactories.CreateIsFastRewindEnabled()); } }
           NProperty _isFastRewindEnabled;

    public NProperty IsFullWindow { get { return _isFullWindow ?? (_isFullWindow = NPropFactories.CreateIsFullWindow()); } }
           NProperty _isFullWindow;

    public NProperty IsFullWindowButtonVisible { get { return _isFullWindowButtonVisible ?? (_isFullWindowButtonVisible = NPropFactories.CreateIsFullWindowButtonVisible()); } }
           NProperty _isFullWindowButtonVisible;

    public NProperty IsFullWindowEnabled { get { return _isFullWindowEnabled ?? (_isFullWindowEnabled = NPropFactories.CreateIsFullWindowEnabled()); } }
           NProperty _isFullWindowEnabled;

    public NProperty IsGroupLabelVisible { get { return _isGroupLabelVisible ?? (_isGroupLabelVisible = NPropFactories.CreateIsGroupLabelVisible()); } }
           NProperty _isGroupLabelVisible;

    public NProperty IsHeaderInteractive { get { return _isHeaderInteractive ?? (_isHeaderInteractive = NPropFactories.CreateIsHeaderInteractive()); } }
           NProperty _isHeaderInteractive;

    public NProperty IsHitTestVisible { get { return _isHitTestVisible ?? (_isHitTestVisible = NPropFactories.CreateIsHitTestVisible()); } }
           NProperty _isHitTestVisible;

    public NProperty IsHoldingEnabled { get { return _isHoldingEnabled ?? (_isHoldingEnabled = NPropFactories.CreateIsHoldingEnabled()); } }
           NProperty _isHoldingEnabled;

    public NProperty IsHorizontalRailEnabled { get { return _isHorizontalRailEnabled ?? (_isHorizontalRailEnabled = NPropFactories.CreateIsHorizontalRailEnabled()); } }
           NProperty _isHorizontalRailEnabled;

    public NProperty IsHorizontalScrollChainingEnabled { get { return _isHorizontalScrollChainingEnabled ?? (_isHorizontalScrollChainingEnabled = NPropFactories.CreateIsHorizontalScrollChainingEnabled()); } }
           NProperty _isHorizontalScrollChainingEnabled;

    public NProperty IsIndeterminate { get { return _isIndeterminate ?? (_isIndeterminate = NPropFactories.CreateIsIndeterminate()); } }
           NProperty _isIndeterminate;

    public NProperty IsItemClickEnabled { get { return _isItemClickEnabled ?? (_isItemClickEnabled = NPropFactories.CreateIsItemClickEnabled()); } }
           NProperty _isItemClickEnabled;

    public NProperty IsLightDismissEnabled { get { return _isLightDismissEnabled ?? (_isLightDismissEnabled = NPropFactories.CreateIsLightDismissEnabled()); } }
           NProperty _isLightDismissEnabled;

    public NProperty IsLocked { get { return _isLocked ?? (_isLocked = NPropFactories.CreateIsLocked()); } }
           NProperty _isLocked;

    public NProperty IsLooping { get { return _isLooping ?? (_isLooping = NPropFactories.CreateIsLooping()); } }
           NProperty _isLooping;

    public NProperty IsMultiSelectCheckBoxEnabled { get { return _isMultiSelectCheckBoxEnabled ?? (_isMultiSelectCheckBoxEnabled = NPropFactories.CreateIsMultiSelectCheckBoxEnabled()); } }
           NProperty _isMultiSelectCheckBoxEnabled;

    public NProperty IsMuted { get { return _isMuted ?? (_isMuted = NPropFactories.CreateIsMuted()); } }
           NProperty _isMuted;

    public NProperty IsOn { get { return _isOn ?? (_isOn = NPropFactories.CreateIsOn()); } }
           NProperty _isOn;

    public NProperty IsOpen { get { return _isOpen ?? (_isOpen = NPropFactories.CreateIsOpen()); } }
           NProperty _isOpen;

    public NProperty IsOutOfScopeEnabled { get { return _isOutOfScopeEnabled ?? (_isOutOfScopeEnabled = NPropFactories.CreateIsOutOfScopeEnabled()); } }
           NProperty _isOutOfScopeEnabled;

    public NProperty IsPaneOpen { get { return _isPaneOpen ?? (_isPaneOpen = NPropFactories.CreateIsPaneOpen()); } }
           NProperty _isPaneOpen;

    public NProperty IsPasswordRevealButtonEnabled { get { return _isPasswordRevealButtonEnabled ?? (_isPasswordRevealButtonEnabled = NPropFactories.CreateIsPasswordRevealButtonEnabled()); } }
           NProperty _isPasswordRevealButtonEnabled;

    public NProperty IsPlaybackRateButtonVisible { get { return _isPlaybackRateButtonVisible ?? (_isPlaybackRateButtonVisible = NPropFactories.CreateIsPlaybackRateButtonVisible()); } }
           NProperty _isPlaybackRateButtonVisible;

    public NProperty IsPlaybackRateEnabled { get { return _isPlaybackRateEnabled ?? (_isPlaybackRateEnabled = NPropFactories.CreateIsPlaybackRateEnabled()); } }
           NProperty _isPlaybackRateEnabled;

    public NProperty IsPrimaryButtonEnabled { get { return _isPrimaryButtonEnabled ?? (_isPrimaryButtonEnabled = NPropFactories.CreateIsPrimaryButtonEnabled()); } }
           NProperty _isPrimaryButtonEnabled;

    public NProperty IsReadOnly { get { return _isReadOnly ?? (_isReadOnly = NPropFactories.CreateIsReadOnly()); } }
           NProperty _isReadOnly;

    public NProperty IsRightTapEnabled { get { return _isRightTapEnabled ?? (_isRightTapEnabled = NPropFactories.CreateIsRightTapEnabled()); } }
           NProperty _isRightTapEnabled;

    public NProperty IsScrollInertiaEnabled { get { return _isScrollInertiaEnabled ?? (_isScrollInertiaEnabled = NPropFactories.CreateIsScrollInertiaEnabled()); } }
           NProperty _isScrollInertiaEnabled;

    public NProperty IsSecondaryButtonEnabled { get { return _isSecondaryButtonEnabled ?? (_isSecondaryButtonEnabled = NPropFactories.CreateIsSecondaryButtonEnabled()); } }
           NProperty _isSecondaryButtonEnabled;

    public NProperty IsSeekBarVisible { get { return _isSeekBarVisible ?? (_isSeekBarVisible = NPropFactories.CreateIsSeekBarVisible()); } }
           NProperty _isSeekBarVisible;

    public NProperty IsSeekEnabled { get { return _isSeekEnabled ?? (_isSeekEnabled = NPropFactories.CreateIsSeekEnabled()); } }
           NProperty _isSeekEnabled;

    public NProperty IsSelected { get { return _isSelected ?? (_isSelected = NPropFactories.CreateIsSelected()); } }
           NProperty _isSelected;

    public NProperty IsSpellCheckEnabled { get { return _isSpellCheckEnabled ?? (_isSpellCheckEnabled = NPropFactories.CreateIsSpellCheckEnabled()); } }
           NProperty _isSpellCheckEnabled;

    public NProperty IsSticky { get { return _isSticky ?? (_isSticky = NPropFactories.CreateIsSticky()); } }
           NProperty _isSticky;

    public NProperty IsStopButtonVisible { get { return _isStopButtonVisible ?? (_isStopButtonVisible = NPropFactories.CreateIsStopButtonVisible()); } }
           NProperty _isStopButtonVisible;

    public NProperty IsStopEnabled { get { return _isStopEnabled ?? (_isStopEnabled = NPropFactories.CreateIsStopEnabled()); } }
           NProperty _isStopEnabled;

    public NProperty IsSuggestionListOpen { get { return _isSuggestionListOpen ?? (_isSuggestionListOpen = NPropFactories.CreateIsSuggestionListOpen()); } }
           NProperty _isSuggestionListOpen;

    public NProperty IsSwipeEnabled { get { return _isSwipeEnabled ?? (_isSwipeEnabled = NPropFactories.CreateIsSwipeEnabled()); } }
           NProperty _isSwipeEnabled;

    public NProperty IsSynchronizedWithCurrentItem { get { return _isSynchronizedWithCurrentItem ?? (_isSynchronizedWithCurrentItem = NPropFactories.CreateIsSynchronizedWithCurrentItem()); } }
           NProperty _isSynchronizedWithCurrentItem;

    public NProperty IsTabStop { get { return _isTabStop ?? (_isTabStop = NPropFactories.CreateIsTabStop()); } }
           NProperty _isTabStop;

    public NProperty IsTapEnabled { get { return _isTapEnabled ?? (_isTapEnabled = NPropFactories.CreateIsTapEnabled()); } }
           NProperty _isTapEnabled;

    public NProperty IsTextPredictionEnabled { get { return _isTextPredictionEnabled ?? (_isTextPredictionEnabled = NPropFactories.CreateIsTextPredictionEnabled()); } }
           NProperty _isTextPredictionEnabled;

    public NProperty IsTextScaleFactorEnabled { get { return _isTextScaleFactorEnabled ?? (_isTextScaleFactorEnabled = NPropFactories.CreateIsTextScaleFactorEnabled()); } }
           NProperty _isTextScaleFactorEnabled;

    public NProperty IsTextSelectionEnabled { get { return _isTextSelectionEnabled ?? (_isTextSelectionEnabled = NPropFactories.CreateIsTextSelectionEnabled()); } }
           NProperty _isTextSelectionEnabled;

    public NProperty IsThreeState { get { return _isThreeState ?? (_isThreeState = NPropFactories.CreateIsThreeState()); } }
           NProperty _isThreeState;

    public NProperty IsThumbToolTipEnabled { get { return _isThumbToolTipEnabled ?? (_isThumbToolTipEnabled = NPropFactories.CreateIsThumbToolTipEnabled()); } }
           NProperty _isThumbToolTipEnabled;

    public NProperty IsTodayHighlighted { get { return _isTodayHighlighted ?? (_isTodayHighlighted = NPropFactories.CreateIsTodayHighlighted()); } }
           NProperty _isTodayHighlighted;

    public NProperty IsVerticalRailEnabled { get { return _isVerticalRailEnabled ?? (_isVerticalRailEnabled = NPropFactories.CreateIsVerticalRailEnabled()); } }
           NProperty _isVerticalRailEnabled;

    public NProperty IsVerticalScrollChainingEnabled { get { return _isVerticalScrollChainingEnabled ?? (_isVerticalScrollChainingEnabled = NPropFactories.CreateIsVerticalScrollChainingEnabled()); } }
           NProperty _isVerticalScrollChainingEnabled;

    public NProperty IsVolumeButtonVisible { get { return _isVolumeButtonVisible ?? (_isVolumeButtonVisible = NPropFactories.CreateIsVolumeButtonVisible()); } }
           NProperty _isVolumeButtonVisible;

    public NProperty IsVolumeEnabled { get { return _isVolumeEnabled ?? (_isVolumeEnabled = NPropFactories.CreateIsVolumeEnabled()); } }
           NProperty _isVolumeEnabled;

    public NProperty IsZoomButtonVisible { get { return _isZoomButtonVisible ?? (_isZoomButtonVisible = NPropFactories.CreateIsZoomButtonVisible()); } }
           NProperty _isZoomButtonVisible;

    public NProperty IsZoomChainingEnabled { get { return _isZoomChainingEnabled ?? (_isZoomChainingEnabled = NPropFactories.CreateIsZoomChainingEnabled()); } }
           NProperty _isZoomChainingEnabled;

    public NProperty IsZoomedInView { get { return _isZoomedInView ?? (_isZoomedInView = NPropFactories.CreateIsZoomedInView()); } }
           NProperty _isZoomedInView;

    public NProperty IsZoomedInViewActive { get { return _isZoomedInViewActive ?? (_isZoomedInViewActive = NPropFactories.CreateIsZoomedInViewActive()); } }
           NProperty _isZoomedInViewActive;

    public NProperty IsZoomEnabled { get { return _isZoomEnabled ?? (_isZoomEnabled = NPropFactories.CreateIsZoomEnabled()); } }
           NProperty _isZoomEnabled;

    public NProperty IsZoomInertiaEnabled { get { return _isZoomInertiaEnabled ?? (_isZoomInertiaEnabled = NPropFactories.CreateIsZoomInertiaEnabled()); } }
           NProperty _isZoomInertiaEnabled;

    public NProperty IsZoomOutButtonEnabled { get { return _isZoomOutButtonEnabled ?? (_isZoomOutButtonEnabled = NPropFactories.CreateIsZoomOutButtonEnabled()); } }
           NProperty _isZoomOutButtonEnabled;

    public NProperty ItemClick { get { return _itemClick ?? (_itemClick = NPropFactories.CreateItemClick()); } }
           NProperty _itemClick;

    public NProperty ItemContainerStyle { get { return _itemContainerStyle ?? (_itemContainerStyle = NPropFactories.CreateItemContainerStyle()); } }
           NProperty _itemContainerStyle;

    public NProperty ItemContainerStyleSelector { get { return _itemContainerStyleSelector ?? (_itemContainerStyleSelector = NPropFactories.CreateItemContainerStyleSelector()); } }
           NProperty _itemContainerStyleSelector;

    public NProperty ItemContainerTransitions { get { return _itemContainerTransitions ?? (_itemContainerTransitions = NPropFactories.CreateItemContainerTransitions()); } }
           NProperty _itemContainerTransitions;

    public NProperty ItemHeight { get { return _itemHeight ?? (_itemHeight = NPropFactories.CreateItemHeight()); } }
           NProperty _itemHeight;

    public NProperty Items { get { return _items ?? (_items = NPropFactories.CreateItems()); } }
           NProperty _items;

    public NProperty ItemsPanel { get { return _itemsPanel ?? (_itemsPanel = NPropFactories.CreateItemsPanel()); } }
           NProperty _itemsPanel;

    public NProperty ItemsSource { get { return _itemsSource ?? (_itemsSource = NPropFactories.CreateItemsSource()); } }
           NProperty _itemsSource;

    public NProperty ItemsUpdatingScrollMode { get { return _itemsUpdatingScrollMode ?? (_itemsUpdatingScrollMode = NPropFactories.CreateItemsUpdatingScrollMode()); } }
           NProperty _itemsUpdatingScrollMode;

    public NProperty ItemTemplate { get { return _itemTemplate ?? (_itemTemplate = NPropFactories.CreateItemTemplate()); } }
           NProperty _itemTemplate;

    public NProperty ItemTemplateSelector { get { return _itemTemplateSelector ?? (_itemTemplateSelector = NPropFactories.CreateItemTemplateSelector()); } }
           NProperty _itemTemplateSelector;

    public NProperty ItemWidth { get { return _itemWidth ?? (_itemWidth = NPropFactories.CreateItemWidth()); } }
           NProperty _itemWidth;

    public NProperty KeyDown { get { return _keyDown ?? (_keyDown = NPropFactories.CreateKeyDown()); } }
           NProperty _keyDown;

    public NProperty KeyUp { get { return _keyUp ?? (_keyUp = NPropFactories.CreateKeyUp()); } }
           NProperty _keyUp;

    public NProperty Label { get { return _label ?? (_label = NPropFactories.CreateLabel()); } }
           NProperty _label;

    public NProperty LandmarksVisible { get { return _landmarksVisible ?? (_landmarksVisible = NPropFactories.CreateLandmarksVisible()); } }
           NProperty _landmarksVisible;

    public NProperty Language { get { return _language ?? (_language = NPropFactories.CreateLanguage()); } }
           NProperty _language;

    public NProperty LargeChange { get { return _largeChange ?? (_largeChange = NPropFactories.CreateLargeChange()); } }
           NProperty _largeChange;

    public NProperty LayoutUpdated { get { return _layoutUpdated ?? (_layoutUpdated = NPropFactories.CreateLayoutUpdated()); } }
           NProperty _layoutUpdated;

    public NProperty LeftHeader { get { return _leftHeader ?? (_leftHeader = NPropFactories.CreateLeftHeader()); } }
           NProperty _leftHeader;

    public NProperty LeftHeaderTemplate { get { return _leftHeaderTemplate ?? (_leftHeaderTemplate = NPropFactories.CreateLeftHeaderTemplate()); } }
           NProperty _leftHeaderTemplate;

    public NProperty LineHeight { get { return _lineHeight ?? (_lineHeight = NPropFactories.CreateLineHeight()); } }
           NProperty _lineHeight;

    public NProperty LineStackingStrategy { get { return _lineStackingStrategy ?? (_lineStackingStrategy = NPropFactories.CreateLineStackingStrategy()); } }
           NProperty _lineStackingStrategy;

    public NProperty ListViewItemPresenterHorizontalContentAlignment { get { return _listViewItemPresenterHorizontalContentAlignment ?? (_listViewItemPresenterHorizontalContentAlignment = NPropFactories.CreateListViewItemPresenterHorizontalContentAlignment()); } }
           NProperty _listViewItemPresenterHorizontalContentAlignment;

    public NProperty ListViewItemPresenterPadding { get { return _listViewItemPresenterPadding ?? (_listViewItemPresenterPadding = NPropFactories.CreateListViewItemPresenterPadding()); } }
           NProperty _listViewItemPresenterPadding;

    public NProperty ListViewItemPresenterVerticalContentAlignment { get { return _listViewItemPresenterVerticalContentAlignment ?? (_listViewItemPresenterVerticalContentAlignment = NPropFactories.CreateListViewItemPresenterVerticalContentAlignment()); } }
           NProperty _listViewItemPresenterVerticalContentAlignment;

    public NProperty LoadCompleted { get { return _loadCompleted ?? (_loadCompleted = NPropFactories.CreateLoadCompleted()); } }
           NProperty _loadCompleted;

    public NProperty Loaded { get { return _loaded ?? (_loaded = NPropFactories.CreateLoaded()); } }
           NProperty _loaded;

    public NProperty LostFocus { get { return _lostFocus ?? (_lostFocus = NPropFactories.CreateLostFocus()); } }
           NProperty _lostFocus;

    public NProperty ManipulationCompleted { get { return _manipulationCompleted ?? (_manipulationCompleted = NPropFactories.CreateManipulationCompleted()); } }
           NProperty _manipulationCompleted;

    public NProperty ManipulationDelta { get { return _manipulationDelta ?? (_manipulationDelta = NPropFactories.CreateManipulationDelta()); } }
           NProperty _manipulationDelta;

    public NProperty ManipulationInertiaStarting { get { return _manipulationInertiaStarting ?? (_manipulationInertiaStarting = NPropFactories.CreateManipulationInertiaStarting()); } }
           NProperty _manipulationInertiaStarting;

    public NProperty ManipulationMode { get { return _manipulationMode ?? (_manipulationMode = NPropFactories.CreateManipulationMode()); } }
           NProperty _manipulationMode;

    public NProperty ManipulationStarted { get { return _manipulationStarted ?? (_manipulationStarted = NPropFactories.CreateManipulationStarted()); } }
           NProperty _manipulationStarted;

    public NProperty ManipulationStarting { get { return _manipulationStarting ?? (_manipulationStarting = NPropFactories.CreateManipulationStarting()); } }
           NProperty _manipulationStarting;

    public NProperty MapControlLocation { get { return _mapControlLocation ?? (_mapControlLocation = NPropFactories.CreateMapControlLocation()); } }
           NProperty _mapControlLocation;

    public NProperty MapControlNormalizedAnchorPoint { get { return _mapControlNormalizedAnchorPoint ?? (_mapControlNormalizedAnchorPoint = NPropFactories.CreateMapControlNormalizedAnchorPoint()); } }
           NProperty _mapControlNormalizedAnchorPoint;

    public NProperty MapServiceToken { get { return _mapServiceToken ?? (_mapServiceToken = NPropFactories.CreateMapServiceToken()); } }
           NProperty _mapServiceToken;

    public NProperty Margin { get { return _margin ?? (_margin = NPropFactories.CreateMargin()); } }
           NProperty _margin;

    public NProperty MarkerReached { get { return _markerReached ?? (_markerReached = NPropFactories.CreateMarkerReached()); } }
           NProperty _markerReached;

    public NProperty Markers { get { return _markers ?? (_markers = NPropFactories.CreateMarkers()); } }
           NProperty _markers;

    public NProperty MaxDate { get { return _maxDate ?? (_maxDate = NPropFactories.CreateMaxDate()); } }
           NProperty _maxDate;

    public NProperty MaxDropDownHeight { get { return _maxDropDownHeight ?? (_maxDropDownHeight = NPropFactories.CreateMaxDropDownHeight()); } }
           NProperty _maxDropDownHeight;

    public NProperty MaxHeight { get { return _maxHeight ?? (_maxHeight = NPropFactories.CreateMaxHeight()); } }
           NProperty _maxHeight;

    public NProperty Maximum { get { return _maximum ?? (_maximum = NPropFactories.CreateMaximum()); } }
           NProperty _maximum;

    public NProperty MaximumRowsOrColumns { get { return _maximumRowsOrColumns ?? (_maximumRowsOrColumns = NPropFactories.CreateMaximumRowsOrColumns()); } }
           NProperty _maximumRowsOrColumns;

    public NProperty MaxLength { get { return _maxLength ?? (_maxLength = NPropFactories.CreateMaxLength()); } }
           NProperty _maxLength;

    public NProperty MaxLines { get { return _maxLines ?? (_maxLines = NPropFactories.CreateMaxLines()); } }
           NProperty _maxLines;

    public NProperty MaxSuggestionListHeight { get { return _maxSuggestionListHeight ?? (_maxSuggestionListHeight = NPropFactories.CreateMaxSuggestionListHeight()); } }
           NProperty _maxSuggestionListHeight;

    public NProperty MaxWidth { get { return _maxWidth ?? (_maxWidth = NPropFactories.CreateMaxWidth()); } }
           NProperty _maxWidth;

    public NProperty MaxYear { get { return _maxYear ?? (_maxYear = NPropFactories.CreateMaxYear()); } }
           NProperty _maxYear;

    public NProperty MaxZoomFactor { get { return _maxZoomFactor ?? (_maxZoomFactor = NPropFactories.CreateMaxZoomFactor()); } }
           NProperty _maxZoomFactor;

    public NProperty MediaEnded { get { return _mediaEnded ?? (_mediaEnded = NPropFactories.CreateMediaEnded()); } }
           NProperty _mediaEnded;

    public NProperty MediaFailed { get { return _mediaFailed ?? (_mediaFailed = NPropFactories.CreateMediaFailed()); } }
           NProperty _mediaFailed;

    public NProperty MediaOpened { get { return _mediaOpened ?? (_mediaOpened = NPropFactories.CreateMediaOpened()); } }
           NProperty _mediaOpened;

    public NProperty MinDate { get { return _minDate ?? (_minDate = NPropFactories.CreateMinDate()); } }
           NProperty _minDate;

    public NProperty MinHeight { get { return _minHeight ?? (_minHeight = NPropFactories.CreateMinHeight()); } }
           NProperty _minHeight;

    public NProperty Minimum { get { return _minimum ?? (_minimum = NPropFactories.CreateMinimum()); } }
           NProperty _minimum;

    public NProperty MinuteIncrement { get { return _minuteIncrement ?? (_minuteIncrement = NPropFactories.CreateMinuteIncrement()); } }
           NProperty _minuteIncrement;

    public NProperty MinWidth { get { return _minWidth ?? (_minWidth = NPropFactories.CreateMinWidth()); } }
           NProperty _minWidth;

    public NProperty MinYear { get { return _minYear ?? (_minYear = NPropFactories.CreateMinYear()); } }
           NProperty _minYear;

    public NProperty MinZoomFactor { get { return _minZoomFactor ?? (_minZoomFactor = NPropFactories.CreateMinZoomFactor()); } }
           NProperty _minZoomFactor;

    public NProperty MirroredWhenRightToLeft { get { return _mirroredWhenRightToLeft ?? (_mirroredWhenRightToLeft = NPropFactories.CreateMirroredWhenRightToLeft()); } }
           NProperty _mirroredWhenRightToLeft;

    public NProperty MonthFormat { get { return _monthFormat ?? (_monthFormat = NPropFactories.CreateMonthFormat()); } }
           NProperty _monthFormat;

    public NProperty MonthVisible { get { return _monthVisible ?? (_monthVisible = NPropFactories.CreateMonthVisible()); } }
           NProperty _monthVisible;

    public NProperty MonthYearItemFontFamily { get { return _monthYearItemFontFamily ?? (_monthYearItemFontFamily = NPropFactories.CreateMonthYearItemFontFamily()); } }
           NProperty _monthYearItemFontFamily;

    public NProperty MonthYearItemFontSize { get { return _monthYearItemFontSize ?? (_monthYearItemFontSize = NPropFactories.CreateMonthYearItemFontSize()); } }
           NProperty _monthYearItemFontSize;

    public NProperty MonthYearItemFontStyle { get { return _monthYearItemFontStyle ?? (_monthYearItemFontStyle = NPropFactories.CreateMonthYearItemFontStyle()); } }
           NProperty _monthYearItemFontStyle;

    public NProperty MonthYearItemFontWeight { get { return _monthYearItemFontWeight ?? (_monthYearItemFontWeight = NPropFactories.CreateMonthYearItemFontWeight()); } }
           NProperty _monthYearItemFontWeight;

    public NProperty Name { get { return _name ?? (_name = NPropFactories.CreateName()); } }
           NProperty _name;

    public NProperty Navigated { get { return _navigated ?? (_navigated = NPropFactories.CreateNavigated()); } }
           NProperty _navigated;

    public NProperty NavigateUri { get { return _navigateUri ?? (_navigateUri = NPropFactories.CreateNavigateUri()); } }
           NProperty _navigateUri;

    public NProperty Navigating { get { return _navigating ?? (_navigating = NPropFactories.CreateNavigating()); } }
           NProperty _navigating;

    public NProperty NavigationCacheMode { get { return _navigationCacheMode ?? (_navigationCacheMode = NPropFactories.CreateNavigationCacheMode()); } }
           NProperty _navigationCacheMode;

    public NProperty NavigationFailed { get { return _navigationFailed ?? (_navigationFailed = NPropFactories.CreateNavigationFailed()); } }
           NProperty _navigationFailed;

    public NProperty NavigationStopped { get { return _navigationStopped ?? (_navigationStopped = NPropFactories.CreateNavigationStopped()); } }
           NProperty _navigationStopped;

    public NProperty NineGrid { get { return _nineGrid ?? (_nineGrid = NPropFactories.CreateNineGrid()); } }
           NProperty _nineGrid;

    public NProperty NumberOfWeeksInView { get { return _numberOfWeeksInView ?? (_numberOfWeeksInView = NPropFactories.CreateNumberOfWeeksInView()); } }
           NProperty _numberOfWeeksInView;

    public NProperty OffContent { get { return _offContent ?? (_offContent = NPropFactories.CreateOffContent()); } }
           NProperty _offContent;

    public NProperty OffContentTemplate { get { return _offContentTemplate ?? (_offContentTemplate = NPropFactories.CreateOffContentTemplate()); } }
           NProperty _offContentTemplate;

    public NProperty OnContent { get { return _onContent ?? (_onContent = NPropFactories.CreateOnContent()); } }
           NProperty _onContent;

    public NProperty OnContentTemplate { get { return _onContentTemplate ?? (_onContentTemplate = NPropFactories.CreateOnContentTemplate()); } }
           NProperty _onContentTemplate;

    public NProperty Opacity { get { return _opacity ?? (_opacity = NPropFactories.CreateOpacity()); } }
           NProperty _opacity;

    public NProperty Opened { get { return _opened ?? (_opened = NPropFactories.CreateOpened()); } }
           NProperty _opened;

    public NProperty Opening { get { return _opening ?? (_opening = NPropFactories.CreateOpening()); } }
           NProperty _opening;

    public NProperty OpenPaneLength { get { return _openPaneLength ?? (_openPaneLength = NPropFactories.CreateOpenPaneLength()); } }
           NProperty _openPaneLength;

    public NProperty OpticalMarginAlignment { get { return _opticalMarginAlignment ?? (_opticalMarginAlignment = NPropFactories.CreateOpticalMarginAlignment()); } }
           NProperty _opticalMarginAlignment;

    public NProperty Orientation { get { return _orientation ?? (_orientation = NPropFactories.CreateOrientation()); } }
           NProperty _orientation;

    public NProperty OriginX { get { return _originX ?? (_originX = NPropFactories.CreateOriginX()); } }
           NProperty _originX;

    public NProperty OriginY { get { return _originY ?? (_originY = NPropFactories.CreateOriginY()); } }
           NProperty _originY;

    public NProperty OutOfScopeBackground { get { return _outOfScopeBackground ?? (_outOfScopeBackground = NPropFactories.CreateOutOfScopeBackground()); } }
           NProperty _outOfScopeBackground;

    public NProperty OutOfScopeForeground { get { return _outOfScopeForeground ?? (_outOfScopeForeground = NPropFactories.CreateOutOfScopeForeground()); } }
           NProperty _outOfScopeForeground;

    public NProperty OverflowContentTarget { get { return _overflowContentTarget ?? (_overflowContentTarget = NPropFactories.CreateOverflowContentTarget()); } }
           NProperty _overflowContentTarget;

    public NProperty Padding { get { return _padding ?? (_padding = NPropFactories.CreatePadding()); } }
           NProperty _padding;

    public NProperty Pane { get { return _pane ?? (_pane = NPropFactories.CreatePane()); } }
           NProperty _pane;

    public NProperty PaneBackground { get { return _paneBackground ?? (_paneBackground = NPropFactories.CreatePaneBackground()); } }
           NProperty _paneBackground;

    public NProperty PanePlacement { get { return _panePlacement ?? (_panePlacement = NPropFactories.CreatePanePlacement()); } }
           NProperty _panePlacement;

    public NProperty PanInteractionMode { get { return _panInteractionMode ?? (_panInteractionMode = NPropFactories.CreatePanInteractionMode()); } }
           NProperty _panInteractionMode;

    public NProperty Password { get { return _password ?? (_password = NPropFactories.CreatePassword()); } }
           NProperty _password;

    public NProperty PasswordChanged { get { return _passwordChanged ?? (_passwordChanged = NPropFactories.CreatePasswordChanged()); } }
           NProperty _passwordChanged;

    public NProperty PasswordChar { get { return _passwordChar ?? (_passwordChar = NPropFactories.CreatePasswordChar()); } }
           NProperty _passwordChar;

    public NProperty PasswordRevealMode { get { return _passwordRevealMode ?? (_passwordRevealMode = NPropFactories.CreatePasswordRevealMode()); } }
           NProperty _passwordRevealMode;

    public NProperty Paste { get { return _paste ?? (_paste = NPropFactories.CreatePaste()); } }
           NProperty _paste;

    public NProperty PedestrianFeaturesVisible { get { return _pedestrianFeaturesVisible ?? (_pedestrianFeaturesVisible = NPropFactories.CreatePedestrianFeaturesVisible()); } }
           NProperty _pedestrianFeaturesVisible;

    public NProperty PivotSlideInAnimationGroup { get { return _pivotSlideInAnimationGroup ?? (_pivotSlideInAnimationGroup = NPropFactories.CreatePivotSlideInAnimationGroup()); } }
           NProperty _pivotSlideInAnimationGroup;

    public NProperty PlaceholderBackground { get { return _placeholderBackground ?? (_placeholderBackground = NPropFactories.CreatePlaceholderBackground()); } }
           NProperty _placeholderBackground;

    public NProperty PlaceholderText { get { return _placeholderText ?? (_placeholderText = NPropFactories.CreatePlaceholderText()); } }
           NProperty _placeholderText;

    public NProperty Placement { get { return _placement ?? (_placement = NPropFactories.CreatePlacement()); } }
           NProperty _placement;

    public NProperty PlacementTarget { get { return _placementTarget ?? (_placementTarget = NPropFactories.CreatePlacementTarget()); } }
           NProperty _placementTarget;

    public NProperty PlaybackRate { get { return _playbackRate ?? (_playbackRate = NPropFactories.CreatePlaybackRate()); } }
           NProperty _playbackRate;

    public NProperty PlayToPreferredSourceUri { get { return _playToPreferredSourceUri ?? (_playToPreferredSourceUri = NPropFactories.CreatePlayToPreferredSourceUri()); } }
           NProperty _playToPreferredSourceUri;

    public NProperty PointerCanceled { get { return _pointerCanceled ?? (_pointerCanceled = NPropFactories.CreatePointerCanceled()); } }
           NProperty _pointerCanceled;

    public NProperty PointerCaptureLost { get { return _pointerCaptureLost ?? (_pointerCaptureLost = NPropFactories.CreatePointerCaptureLost()); } }
           NProperty _pointerCaptureLost;

    public NProperty PointerEntered { get { return _pointerEntered ?? (_pointerEntered = NPropFactories.CreatePointerEntered()); } }
           NProperty _pointerEntered;

    public NProperty PointerExited { get { return _pointerExited ?? (_pointerExited = NPropFactories.CreatePointerExited()); } }
           NProperty _pointerExited;

    public NProperty PointerMoved { get { return _pointerMoved ?? (_pointerMoved = NPropFactories.CreatePointerMoved()); } }
           NProperty _pointerMoved;

    public NProperty PointerOverBackground { get { return _pointerOverBackground ?? (_pointerOverBackground = NPropFactories.CreatePointerOverBackground()); } }
           NProperty _pointerOverBackground;

    public NProperty PointerOverBackgroundMargin { get { return _pointerOverBackgroundMargin ?? (_pointerOverBackgroundMargin = NPropFactories.CreatePointerOverBackgroundMargin()); } }
           NProperty _pointerOverBackgroundMargin;

    public NProperty PointerOverForeground { get { return _pointerOverForeground ?? (_pointerOverForeground = NPropFactories.CreatePointerOverForeground()); } }
           NProperty _pointerOverForeground;

    public NProperty PointerPressed { get { return _pointerPressed ?? (_pointerPressed = NPropFactories.CreatePointerPressed()); } }
           NProperty _pointerPressed;

    public NProperty PointerReleased { get { return _pointerReleased ?? (_pointerReleased = NPropFactories.CreatePointerReleased()); } }
           NProperty _pointerReleased;

    public NProperty PointerWheelChanged { get { return _pointerWheelChanged ?? (_pointerWheelChanged = NPropFactories.CreatePointerWheelChanged()); } }
           NProperty _pointerWheelChanged;

    public NProperty Points { get { return _points ?? (_points = NPropFactories.CreatePoints()); } }
           NProperty _points;

    public NProperty Position { get { return _position ?? (_position = NPropFactories.CreatePosition()); } }
           NProperty _position;

    public NProperty PosterSource { get { return _posterSource ?? (_posterSource = NPropFactories.CreatePosterSource()); } }
           NProperty _posterSource;

    public NProperty PressedBackground { get { return _pressedBackground ?? (_pressedBackground = NPropFactories.CreatePressedBackground()); } }
           NProperty _pressedBackground;

    public NProperty PressedBorderBrush { get { return _pressedBorderBrush ?? (_pressedBorderBrush = NPropFactories.CreatePressedBorderBrush()); } }
           NProperty _pressedBorderBrush;

    public NProperty PressedForeground { get { return _pressedForeground ?? (_pressedForeground = NPropFactories.CreatePressedForeground()); } }
           NProperty _pressedForeground;

    public NProperty PreventKeyboardDisplayOnProgrammaticFocus { get { return _preventKeyboardDisplayOnProgrammaticFocus ?? (_preventKeyboardDisplayOnProgrammaticFocus = NPropFactories.CreatePreventKeyboardDisplayOnProgrammaticFocus()); } }
           NProperty _preventKeyboardDisplayOnProgrammaticFocus;

    public NProperty PrimaryButtonCommand { get { return _primaryButtonCommand ?? (_primaryButtonCommand = NPropFactories.CreatePrimaryButtonCommand()); } }
           NProperty _primaryButtonCommand;

    public NProperty PrimaryButtonCommandParameter { get { return _primaryButtonCommandParameter ?? (_primaryButtonCommandParameter = NPropFactories.CreatePrimaryButtonCommandParameter()); } }
           NProperty _primaryButtonCommandParameter;

    public NProperty PrimaryButtonText { get { return _primaryButtonText ?? (_primaryButtonText = NPropFactories.CreatePrimaryButtonText()); } }
           NProperty _primaryButtonText;

    public NProperty PrimaryCommands { get { return _primaryCommands ?? (_primaryCommands = NPropFactories.CreatePrimaryCommands()); } }
           NProperty _primaryCommands;

    public NProperty Projection { get { return _projection ?? (_projection = NPropFactories.CreateProjection()); } }
           NProperty _projection;

    public NProperty ProtectionManager { get { return _protectionManager ?? (_protectionManager = NPropFactories.CreateProtectionManager()); } }
           NProperty _protectionManager;

    public NProperty QueryIcon { get { return _queryIcon ?? (_queryIcon = NPropFactories.CreateQueryIcon()); } }
           NProperty _queryIcon;

    public NProperty QueryText { get { return _queryText ?? (_queryText = NPropFactories.CreateQueryText()); } }
           NProperty _queryText;

    public NProperty RadiusX { get { return _radiusX ?? (_radiusX = NPropFactories.CreateRadiusX()); } }
           NProperty _radiusX;

    public NProperty RadiusY { get { return _radiusY ?? (_radiusY = NPropFactories.CreateRadiusY()); } }
           NProperty _radiusY;

    public NProperty RateChanged { get { return _rateChanged ?? (_rateChanged = NPropFactories.CreateRateChanged()); } }
           NProperty _rateChanged;

    public NProperty RealTimePlayback { get { return _realTimePlayback ?? (_realTimePlayback = NPropFactories.CreateRealTimePlayback()); } }
           NProperty _realTimePlayback;

    public NProperty RelativePanelAbove { get { return _relativePanelAbove ?? (_relativePanelAbove = NPropFactories.CreateRelativePanelAbove()); } }
           NProperty _relativePanelAbove;

    public NProperty RelativePanelAlignBottomWith { get { return _relativePanelAlignBottomWith ?? (_relativePanelAlignBottomWith = NPropFactories.CreateRelativePanelAlignBottomWith()); } }
           NProperty _relativePanelAlignBottomWith;

    public NProperty RelativePanelAlignBottomWithPanel { get { return _relativePanelAlignBottomWithPanel ?? (_relativePanelAlignBottomWithPanel = NPropFactories.CreateRelativePanelAlignBottomWithPanel()); } }
           NProperty _relativePanelAlignBottomWithPanel;

    public NProperty RelativePanelAlignHorizontalCenterWith { get { return _relativePanelAlignHorizontalCenterWith ?? (_relativePanelAlignHorizontalCenterWith = NPropFactories.CreateRelativePanelAlignHorizontalCenterWith()); } }
           NProperty _relativePanelAlignHorizontalCenterWith;

    public NProperty RelativePanelAlignHorizontalCenterWithPanel { get { return _relativePanelAlignHorizontalCenterWithPanel ?? (_relativePanelAlignHorizontalCenterWithPanel = NPropFactories.CreateRelativePanelAlignHorizontalCenterWithPanel()); } }
           NProperty _relativePanelAlignHorizontalCenterWithPanel;

    public NProperty RelativePanelAlignLeftWith { get { return _relativePanelAlignLeftWith ?? (_relativePanelAlignLeftWith = NPropFactories.CreateRelativePanelAlignLeftWith()); } }
           NProperty _relativePanelAlignLeftWith;

    public NProperty RelativePanelAlignLeftWithPanel { get { return _relativePanelAlignLeftWithPanel ?? (_relativePanelAlignLeftWithPanel = NPropFactories.CreateRelativePanelAlignLeftWithPanel()); } }
           NProperty _relativePanelAlignLeftWithPanel;

    public NProperty RelativePanelAlignRightWith { get { return _relativePanelAlignRightWith ?? (_relativePanelAlignRightWith = NPropFactories.CreateRelativePanelAlignRightWith()); } }
           NProperty _relativePanelAlignRightWith;

    public NProperty RelativePanelAlignRightWithPanel { get { return _relativePanelAlignRightWithPanel ?? (_relativePanelAlignRightWithPanel = NPropFactories.CreateRelativePanelAlignRightWithPanel()); } }
           NProperty _relativePanelAlignRightWithPanel;

    public NProperty RelativePanelAlignTopWith { get { return _relativePanelAlignTopWith ?? (_relativePanelAlignTopWith = NPropFactories.CreateRelativePanelAlignTopWith()); } }
           NProperty _relativePanelAlignTopWith;

    public NProperty RelativePanelAlignTopWithPanel { get { return _relativePanelAlignTopWithPanel ?? (_relativePanelAlignTopWithPanel = NPropFactories.CreateRelativePanelAlignTopWithPanel()); } }
           NProperty _relativePanelAlignTopWithPanel;

    public NProperty RelativePanelAlignVerticalCenterWith { get { return _relativePanelAlignVerticalCenterWith ?? (_relativePanelAlignVerticalCenterWith = NPropFactories.CreateRelativePanelAlignVerticalCenterWith()); } }
           NProperty _relativePanelAlignVerticalCenterWith;

    public NProperty RelativePanelAlignVerticalCenterWithPanel { get { return _relativePanelAlignVerticalCenterWithPanel ?? (_relativePanelAlignVerticalCenterWithPanel = NPropFactories.CreateRelativePanelAlignVerticalCenterWithPanel()); } }
           NProperty _relativePanelAlignVerticalCenterWithPanel;

    public NProperty RelativePanelBelow { get { return _relativePanelBelow ?? (_relativePanelBelow = NPropFactories.CreateRelativePanelBelow()); } }
           NProperty _relativePanelBelow;

    public NProperty RelativePanelLeftOf { get { return _relativePanelLeftOf ?? (_relativePanelLeftOf = NPropFactories.CreateRelativePanelLeftOf()); } }
           NProperty _relativePanelLeftOf;

    public NProperty RelativePanelRightOf { get { return _relativePanelRightOf ?? (_relativePanelRightOf = NPropFactories.CreateRelativePanelRightOf()); } }
           NProperty _relativePanelRightOf;

    public NProperty RenderTransform { get { return _renderTransform ?? (_renderTransform = NPropFactories.CreateRenderTransform()); } }
           NProperty _renderTransform;

    public NProperty RenderTransformOrigin { get { return _renderTransformOrigin ?? (_renderTransformOrigin = NPropFactories.CreateRenderTransformOrigin()); } }
           NProperty _renderTransformOrigin;

    public NProperty ReorderHintOffset { get { return _reorderHintOffset ?? (_reorderHintOffset = NPropFactories.CreateReorderHintOffset()); } }
           NProperty _reorderHintOffset;

    public NProperty ReorderMode { get { return _reorderMode ?? (_reorderMode = NPropFactories.CreateReorderMode()); } }
           NProperty _reorderMode;

    public NProperty RequestedTheme { get { return _requestedTheme ?? (_requestedTheme = NPropFactories.CreateRequestedTheme()); } }
           NProperty _requestedTheme;

    public NProperty Resources { get { return _resources ?? (_resources = NPropFactories.CreateResources()); } }
           NProperty _resources;

    public NProperty RightHeader { get { return _rightHeader ?? (_rightHeader = NPropFactories.CreateRightHeader()); } }
           NProperty _rightHeader;

    public NProperty RightHeaderTemplate { get { return _rightHeaderTemplate ?? (_rightHeaderTemplate = NPropFactories.CreateRightHeaderTemplate()); } }
           NProperty _rightHeaderTemplate;

    public NProperty RightTapped { get { return _rightTapped ?? (_rightTapped = NPropFactories.CreateRightTapped()); } }
           NProperty _rightTapped;

    public NProperty RotateInteractionMode { get { return _rotateInteractionMode ?? (_rotateInteractionMode = NPropFactories.CreateRotateInteractionMode()); } }
           NProperty _rotateInteractionMode;

    public NProperty RowDefinitions { get { return _rowDefinitions ?? (_rowDefinitions = NPropFactories.CreateRowDefinitions()); } }
           NProperty _rowDefinitions;

    public NProperty Scene { get { return _scene ?? (_scene = NPropFactories.CreateScene()); } }
           NProperty _scene;

    public NProperty ScriptNotify { get { return _scriptNotify ?? (_scriptNotify = NPropFactories.CreateScriptNotify()); } }
           NProperty _scriptNotify;

    public NProperty Scroll { get { return _scroll ?? (_scroll = NPropFactories.CreateScroll()); } }
           NProperty _scroll;

    public NProperty ScrollViewerBringIntoViewOnFocusChange { get { return _scrollViewerBringIntoViewOnFocusChange ?? (_scrollViewerBringIntoViewOnFocusChange = NPropFactories.CreateScrollViewerBringIntoViewOnFocusChange()); } }
           NProperty _scrollViewerBringIntoViewOnFocusChange;

    public NProperty ScrollViewerHorizontalScrollBarVisibility { get { return _scrollViewerHorizontalScrollBarVisibility ?? (_scrollViewerHorizontalScrollBarVisibility = NPropFactories.CreateScrollViewerHorizontalScrollBarVisibility()); } }
           NProperty _scrollViewerHorizontalScrollBarVisibility;

    public NProperty ScrollViewerHorizontalScrollMode { get { return _scrollViewerHorizontalScrollMode ?? (_scrollViewerHorizontalScrollMode = NPropFactories.CreateScrollViewerHorizontalScrollMode()); } }
           NProperty _scrollViewerHorizontalScrollMode;

    public NProperty ScrollViewerIsDeferredScrollingEnabled { get { return _scrollViewerIsDeferredScrollingEnabled ?? (_scrollViewerIsDeferredScrollingEnabled = NPropFactories.CreateScrollViewerIsDeferredScrollingEnabled()); } }
           NProperty _scrollViewerIsDeferredScrollingEnabled;

    public NProperty ScrollViewerIsHorizontalRailEnabled { get { return _scrollViewerIsHorizontalRailEnabled ?? (_scrollViewerIsHorizontalRailEnabled = NPropFactories.CreateScrollViewerIsHorizontalRailEnabled()); } }
           NProperty _scrollViewerIsHorizontalRailEnabled;

    public NProperty ScrollViewerIsHorizontalScrollChainingEnabled { get { return _scrollViewerIsHorizontalScrollChainingEnabled ?? (_scrollViewerIsHorizontalScrollChainingEnabled = NPropFactories.CreateScrollViewerIsHorizontalScrollChainingEnabled()); } }
           NProperty _scrollViewerIsHorizontalScrollChainingEnabled;

    public NProperty ScrollViewerIsScrollInertiaEnabled { get { return _scrollViewerIsScrollInertiaEnabled ?? (_scrollViewerIsScrollInertiaEnabled = NPropFactories.CreateScrollViewerIsScrollInertiaEnabled()); } }
           NProperty _scrollViewerIsScrollInertiaEnabled;

    public NProperty ScrollViewerIsVerticalRailEnabled { get { return _scrollViewerIsVerticalRailEnabled ?? (_scrollViewerIsVerticalRailEnabled = NPropFactories.CreateScrollViewerIsVerticalRailEnabled()); } }
           NProperty _scrollViewerIsVerticalRailEnabled;

    public NProperty ScrollViewerIsVerticalScrollChainingEnabled { get { return _scrollViewerIsVerticalScrollChainingEnabled ?? (_scrollViewerIsVerticalScrollChainingEnabled = NPropFactories.CreateScrollViewerIsVerticalScrollChainingEnabled()); } }
           NProperty _scrollViewerIsVerticalScrollChainingEnabled;

    public NProperty ScrollViewerIsZoomChainingEnabled { get { return _scrollViewerIsZoomChainingEnabled ?? (_scrollViewerIsZoomChainingEnabled = NPropFactories.CreateScrollViewerIsZoomChainingEnabled()); } }
           NProperty _scrollViewerIsZoomChainingEnabled;

    public NProperty ScrollViewerIsZoomInertiaEnabled { get { return _scrollViewerIsZoomInertiaEnabled ?? (_scrollViewerIsZoomInertiaEnabled = NPropFactories.CreateScrollViewerIsZoomInertiaEnabled()); } }
           NProperty _scrollViewerIsZoomInertiaEnabled;

    public NProperty ScrollViewerVerticalScrollBarVisibility { get { return _scrollViewerVerticalScrollBarVisibility ?? (_scrollViewerVerticalScrollBarVisibility = NPropFactories.CreateScrollViewerVerticalScrollBarVisibility()); } }
           NProperty _scrollViewerVerticalScrollBarVisibility;

    public NProperty ScrollViewerVerticalScrollMode { get { return _scrollViewerVerticalScrollMode ?? (_scrollViewerVerticalScrollMode = NPropFactories.CreateScrollViewerVerticalScrollMode()); } }
           NProperty _scrollViewerVerticalScrollMode;

    public NProperty ScrollViewerZoomMode { get { return _scrollViewerZoomMode ?? (_scrollViewerZoomMode = NPropFactories.CreateScrollViewerZoomMode()); } }
           NProperty _scrollViewerZoomMode;

    public NProperty SearchHistoryContext { get { return _searchHistoryContext ?? (_searchHistoryContext = NPropFactories.CreateSearchHistoryContext()); } }
           NProperty _searchHistoryContext;

    public NProperty SearchHistoryEnabled { get { return _searchHistoryEnabled ?? (_searchHistoryEnabled = NPropFactories.CreateSearchHistoryEnabled()); } }
           NProperty _searchHistoryEnabled;

    public NProperty SecondaryButtonCommand { get { return _secondaryButtonCommand ?? (_secondaryButtonCommand = NPropFactories.CreateSecondaryButtonCommand()); } }
           NProperty _secondaryButtonCommand;

    public NProperty SecondaryButtonCommandParameter { get { return _secondaryButtonCommandParameter ?? (_secondaryButtonCommandParameter = NPropFactories.CreateSecondaryButtonCommandParameter()); } }
           NProperty _secondaryButtonCommandParameter;

    public NProperty SecondaryButtonText { get { return _secondaryButtonText ?? (_secondaryButtonText = NPropFactories.CreateSecondaryButtonText()); } }
           NProperty _secondaryButtonText;

    public NProperty SecondaryCommands { get { return _secondaryCommands ?? (_secondaryCommands = NPropFactories.CreateSecondaryCommands()); } }
           NProperty _secondaryCommands;

    public NProperty SectionHeaderClick { get { return _sectionHeaderClick ?? (_sectionHeaderClick = NPropFactories.CreateSectionHeaderClick()); } }
           NProperty _sectionHeaderClick;

    public NProperty SectionHeaders { get { return _sectionHeaders ?? (_sectionHeaders = NPropFactories.CreateSectionHeaders()); } }
           NProperty _sectionHeaders;

    public NProperty SectionsInViewChanged { get { return _sectionsInViewChanged ?? (_sectionsInViewChanged = NPropFactories.CreateSectionsInViewChanged()); } }
           NProperty _sectionsInViewChanged;

    public NProperty SeekCompleted { get { return _seekCompleted ?? (_seekCompleted = NPropFactories.CreateSeekCompleted()); } }
           NProperty _seekCompleted;

    public NProperty SelectedBackground { get { return _selectedBackground ?? (_selectedBackground = NPropFactories.CreateSelectedBackground()); } }
           NProperty _selectedBackground;

    public NProperty SelectedBorderBrush { get { return _selectedBorderBrush ?? (_selectedBorderBrush = NPropFactories.CreateSelectedBorderBrush()); } }
           NProperty _selectedBorderBrush;

    public NProperty SelectedBorderThickness { get { return _selectedBorderThickness ?? (_selectedBorderThickness = NPropFactories.CreateSelectedBorderThickness()); } }
           NProperty _selectedBorderThickness;

    public NProperty SelectedForeground { get { return _selectedForeground ?? (_selectedForeground = NPropFactories.CreateSelectedForeground()); } }
           NProperty _selectedForeground;

    public NProperty SelectedHoverBorderBrush { get { return _selectedHoverBorderBrush ?? (_selectedHoverBorderBrush = NPropFactories.CreateSelectedHoverBorderBrush()); } }
           NProperty _selectedHoverBorderBrush;

    public NProperty SelectedIndex { get { return _selectedIndex ?? (_selectedIndex = NPropFactories.CreateSelectedIndex()); } }
           NProperty _selectedIndex;

    public NProperty SelectedItem { get { return _selectedItem ?? (_selectedItem = NPropFactories.CreateSelectedItem()); } }
           NProperty _selectedItem;

    public NProperty SelectedPointerOverBackground { get { return _selectedPointerOverBackground ?? (_selectedPointerOverBackground = NPropFactories.CreateSelectedPointerOverBackground()); } }
           NProperty _selectedPointerOverBackground;

    public NProperty SelectedPointerOverBorderBrush { get { return _selectedPointerOverBorderBrush ?? (_selectedPointerOverBorderBrush = NPropFactories.CreateSelectedPointerOverBorderBrush()); } }
           NProperty _selectedPointerOverBorderBrush;

    public NProperty SelectedPressedBackground { get { return _selectedPressedBackground ?? (_selectedPressedBackground = NPropFactories.CreateSelectedPressedBackground()); } }
           NProperty _selectedPressedBackground;

    public NProperty SelectedPressedBorderBrush { get { return _selectedPressedBorderBrush ?? (_selectedPressedBorderBrush = NPropFactories.CreateSelectedPressedBorderBrush()); } }
           NProperty _selectedPressedBorderBrush;

    public NProperty SelectedText { get { return _selectedText ?? (_selectedText = NPropFactories.CreateSelectedText()); } }
           NProperty _selectedText;

    public NProperty SelectedValue { get { return _selectedValue ?? (_selectedValue = NPropFactories.CreateSelectedValue()); } }
           NProperty _selectedValue;

    public NProperty SelectedValuePath { get { return _selectedValuePath ?? (_selectedValuePath = NPropFactories.CreateSelectedValuePath()); } }
           NProperty _selectedValuePath;

    public NProperty SelectionChanged { get { return _selectionChanged ?? (_selectionChanged = NPropFactories.CreateSelectionChanged()); } }
           NProperty _selectionChanged;

    public NProperty SelectionCheckMarkVisualEnabled { get { return _selectionCheckMarkVisualEnabled ?? (_selectionCheckMarkVisualEnabled = NPropFactories.CreateSelectionCheckMarkVisualEnabled()); } }
           NProperty _selectionCheckMarkVisualEnabled;

    public NProperty SelectionHighlightColor { get { return _selectionHighlightColor ?? (_selectionHighlightColor = NPropFactories.CreateSelectionHighlightColor()); } }
           NProperty _selectionHighlightColor;

    public NProperty SelectionLength { get { return _selectionLength ?? (_selectionLength = NPropFactories.CreateSelectionLength()); } }
           NProperty _selectionLength;

    public NProperty SelectionMode { get { return _selectionMode ?? (_selectionMode = NPropFactories.CreateSelectionMode()); } }
           NProperty _selectionMode;

    public NProperty SelectionStart { get { return _selectionStart ?? (_selectionStart = NPropFactories.CreateSelectionStart()); } }
           NProperty _selectionStart;

    public NProperty SemanticZoomOwner { get { return _semanticZoomOwner ?? (_semanticZoomOwner = NPropFactories.CreateSemanticZoomOwner()); } }
           NProperty _semanticZoomOwner;

    public NProperty ShouldLoop { get { return _shouldLoop ?? (_shouldLoop = NPropFactories.CreateShouldLoop()); } }
           NProperty _shouldLoop;

    public NProperty ShowError { get { return _showError ?? (_showError = NPropFactories.CreateShowError()); } }
           NProperty _showError;

    public NProperty ShowPaused { get { return _showPaused ?? (_showPaused = NPropFactories.CreateShowPaused()); } }
           NProperty _showPaused;

    public NProperty ShowsScrollingPlaceholders { get { return _showsScrollingPlaceholders ?? (_showsScrollingPlaceholders = NPropFactories.CreateShowsScrollingPlaceholders()); } }
           NProperty _showsScrollingPlaceholders;

    public NProperty SizeChanged { get { return _sizeChanged ?? (_sizeChanged = NPropFactories.CreateSizeChanged()); } }
           NProperty _sizeChanged;

    public NProperty SmallChange { get { return _smallChange ?? (_smallChange = NPropFactories.CreateSmallChange()); } }
           NProperty _smallChange;

    public NProperty SnapsTo { get { return _snapsTo ?? (_snapsTo = NPropFactories.CreateSnapsTo()); } }
           NProperty _snapsTo;

    public NProperty Source { get { return _source ?? (_source = NPropFactories.CreateSource()); } }
           NProperty _source;

    public NProperty SourcePageType { get { return _sourcePageType ?? (_sourcePageType = NPropFactories.CreateSourcePageType()); } }
           NProperty _sourcePageType;

    public NProperty StepFrequency { get { return _stepFrequency ?? (_stepFrequency = NPropFactories.CreateStepFrequency()); } }
           NProperty _stepFrequency;

    public NProperty Stereo3DVideoPackingMode { get { return _stereo3DVideoPackingMode ?? (_stereo3DVideoPackingMode = NPropFactories.CreateStereo3DVideoPackingMode()); } }
           NProperty _stereo3DVideoPackingMode;

    public NProperty Stereo3DVideoRenderMode { get { return _stereo3DVideoRenderMode ?? (_stereo3DVideoRenderMode = NPropFactories.CreateStereo3DVideoRenderMode()); } }
           NProperty _stereo3DVideoRenderMode;

    public NProperty Stretch { get { return _stretch ?? (_stretch = NPropFactories.CreateStretch()); } }
           NProperty _stretch;

    public NProperty StretchDirection { get { return _stretchDirection ?? (_stretchDirection = NPropFactories.CreateStretchDirection()); } }
           NProperty _stretchDirection;

    public NProperty Stroke { get { return _stroke ?? (_stroke = NPropFactories.CreateStroke()); } }
           NProperty _stroke;

    public NProperty StrokeDashArray { get { return _strokeDashArray ?? (_strokeDashArray = NPropFactories.CreateStrokeDashArray()); } }
           NProperty _strokeDashArray;

    public NProperty StrokeDashCap { get { return _strokeDashCap ?? (_strokeDashCap = NPropFactories.CreateStrokeDashCap()); } }
           NProperty _strokeDashCap;

    public NProperty StrokeDashOffset { get { return _strokeDashOffset ?? (_strokeDashOffset = NPropFactories.CreateStrokeDashOffset()); } }
           NProperty _strokeDashOffset;

    public NProperty StrokeEndLineCap { get { return _strokeEndLineCap ?? (_strokeEndLineCap = NPropFactories.CreateStrokeEndLineCap()); } }
           NProperty _strokeEndLineCap;

    public NProperty StrokeLineJoin { get { return _strokeLineJoin ?? (_strokeLineJoin = NPropFactories.CreateStrokeLineJoin()); } }
           NProperty _strokeLineJoin;

    public NProperty StrokeMiterLimit { get { return _strokeMiterLimit ?? (_strokeMiterLimit = NPropFactories.CreateStrokeMiterLimit()); } }
           NProperty _strokeMiterLimit;

    public NProperty StrokeStartLineCap { get { return _strokeStartLineCap ?? (_strokeStartLineCap = NPropFactories.CreateStrokeStartLineCap()); } }
           NProperty _strokeStartLineCap;

    public NProperty StrokeThickness { get { return _strokeThickness ?? (_strokeThickness = NPropFactories.CreateStrokeThickness()); } }
           NProperty _strokeThickness;

    public NProperty Style { get { return _style ?? (_style = NPropFactories.CreateStyle()); } }
           NProperty _style;

    public NProperty StyleSimulations { get { return _styleSimulations ?? (_styleSimulations = NPropFactories.CreateStyleSimulations()); } }
           NProperty _styleSimulations;

    public NProperty Symbol { get { return _symbol ?? (_symbol = NPropFactories.CreateSymbol()); } }
           NProperty _symbol;

    public NProperty TabIndex { get { return _tabIndex ?? (_tabIndex = NPropFactories.CreateTabIndex()); } }
           NProperty _tabIndex;

    public NProperty TabNavigation { get { return _tabNavigation ?? (_tabNavigation = NPropFactories.CreateTabNavigation()); } }
           NProperty _tabNavigation;

    public NProperty Tag { get { return _tag ?? (_tag = NPropFactories.CreateTag()); } }
           NProperty _tag;

    public NProperty Tapped { get { return _tapped ?? (_tapped = NPropFactories.CreateTapped()); } }
           NProperty _tapped;

    public NProperty Template { get { return _template ?? (_template = NPropFactories.CreateTemplate()); } }
           NProperty _template;

    public NProperty Text { get { return _text ?? (_text = NPropFactories.CreateText()); } }
           NProperty _text;

    public NProperty TextAlignment { get { return _textAlignment ?? (_textAlignment = NPropFactories.CreateTextAlignment()); } }
           NProperty _textAlignment;

    public NProperty TextBoxStyle { get { return _textBoxStyle ?? (_textBoxStyle = NPropFactories.CreateTextBoxStyle()); } }
           NProperty _textBoxStyle;

    public NProperty TextChanged { get { return _textChanged ?? (_textChanged = NPropFactories.CreateTextChanged()); } }
           NProperty _textChanged;

    public NProperty TextIndent { get { return _textIndent ?? (_textIndent = NPropFactories.CreateTextIndent()); } }
           NProperty _textIndent;

    public NProperty TextLineBounds { get { return _textLineBounds ?? (_textLineBounds = NPropFactories.CreateTextLineBounds()); } }
           NProperty _textLineBounds;

    public NProperty TextMemberPath { get { return _textMemberPath ?? (_textMemberPath = NPropFactories.CreateTextMemberPath()); } }
           NProperty _textMemberPath;

    public NProperty TextReadingOrder { get { return _textReadingOrder ?? (_textReadingOrder = NPropFactories.CreateTextReadingOrder()); } }
           NProperty _textReadingOrder;

    public NProperty TextTrimming { get { return _textTrimming ?? (_textTrimming = NPropFactories.CreateTextTrimming()); } }
           NProperty _textTrimming;

    public NProperty TextWrapping { get { return _textWrapping ?? (_textWrapping = NPropFactories.CreateTextWrapping()); } }
           NProperty _textWrapping;

    public NProperty ThumbToolTipValueConverter { get { return _thumbToolTipValueConverter ?? (_thumbToolTipValueConverter = NPropFactories.CreateThumbToolTipValueConverter()); } }
           NProperty _thumbToolTipValueConverter;

    public NProperty TickFrequency { get { return _tickFrequency ?? (_tickFrequency = NPropFactories.CreateTickFrequency()); } }
           NProperty _tickFrequency;

    public NProperty TickPlacement { get { return _tickPlacement ?? (_tickPlacement = NPropFactories.CreateTickPlacement()); } }
           NProperty _tickPlacement;

    public NProperty TiltInteractionMode { get { return _tiltInteractionMode ?? (_tiltInteractionMode = NPropFactories.CreateTiltInteractionMode()); } }
           NProperty _tiltInteractionMode;

    public NProperty Time { get { return _time ?? (_time = NPropFactories.CreateTime()); } }
           NProperty _time;

    public NProperty TimeChanged { get { return _timeChanged ?? (_timeChanged = NPropFactories.CreateTimeChanged()); } }
           NProperty _timeChanged;

    public NProperty Title { get { return _title ?? (_title = NPropFactories.CreateTitle()); } }
           NProperty _title;

    public NProperty TitleTemplate { get { return _titleTemplate ?? (_titleTemplate = NPropFactories.CreateTitleTemplate()); } }
           NProperty _titleTemplate;

    public NProperty TodayFontWeight { get { return _todayFontWeight ?? (_todayFontWeight = NPropFactories.CreateTodayFontWeight()); } }
           NProperty _todayFontWeight;

    public NProperty TodayForeground { get { return _todayForeground ?? (_todayForeground = NPropFactories.CreateTodayForeground()); } }
           NProperty _todayForeground;

    public NProperty Toggled { get { return _toggled ?? (_toggled = NPropFactories.CreateToggled()); } }
           NProperty _toggled;

    public NProperty ToolTipServicePlacement { get { return _toolTipServicePlacement ?? (_toolTipServicePlacement = NPropFactories.CreateToolTipServicePlacement()); } }
           NProperty _toolTipServicePlacement;

    public NProperty ToolTipServicePlacementTarget { get { return _toolTipServicePlacementTarget ?? (_toolTipServicePlacementTarget = NPropFactories.CreateToolTipServicePlacementTarget()); } }
           NProperty _toolTipServicePlacementTarget;

    public NProperty ToolTipServiceToolTip { get { return _toolTipServiceToolTip ?? (_toolTipServiceToolTip = NPropFactories.CreateToolTipServiceToolTip()); } }
           NProperty _toolTipServiceToolTip;

    public NProperty TopAppBar { get { return _topAppBar ?? (_topAppBar = NPropFactories.CreateTopAppBar()); } }
           NProperty _topAppBar;

    public NProperty TopHeader { get { return _topHeader ?? (_topHeader = NPropFactories.CreateTopHeader()); } }
           NProperty _topHeader;

    public NProperty TopLeftHeader { get { return _topLeftHeader ?? (_topLeftHeader = NPropFactories.CreateTopLeftHeader()); } }
           NProperty _topLeftHeader;

    public NProperty TrafficFlowVisible { get { return _trafficFlowVisible ?? (_trafficFlowVisible = NPropFactories.CreateTrafficFlowVisible()); } }
           NProperty _trafficFlowVisible;

    public NProperty Transform3D { get { return _transform3D ?? (_transform3D = NPropFactories.CreateTransform3D()); } }
           NProperty _transform3D;

    public NProperty TransformOrigin { get { return _transformOrigin ?? (_transformOrigin = NPropFactories.CreateTransformOrigin()); } }
           NProperty _transformOrigin;

    public NProperty TransitFeaturesVisible { get { return _transitFeaturesVisible ?? (_transitFeaturesVisible = NPropFactories.CreateTransitFeaturesVisible()); } }
           NProperty _transitFeaturesVisible;

    public NProperty Transitions { get { return _transitions ?? (_transitions = NPropFactories.CreateTransitions()); } }
           NProperty _transitions;

    public NProperty Triggers { get { return _triggers ?? (_triggers = NPropFactories.CreateTriggers()); } }
           NProperty _triggers;

    public NProperty Unchecked { get { return _unchecked ?? (_unchecked = NPropFactories.CreateUnchecked()); } }
           NProperty _unchecked;

    public NProperty UnderlineStyle { get { return _underlineStyle ?? (_underlineStyle = NPropFactories.CreateUnderlineStyle()); } }
           NProperty _underlineStyle;

    public NProperty UnicodeString { get { return _unicodeString ?? (_unicodeString = NPropFactories.CreateUnicodeString()); } }
           NProperty _unicodeString;

    public NProperty Unloaded { get { return _unloaded ?? (_unloaded = NPropFactories.CreateUnloaded()); } }
           NProperty _unloaded;

    public NProperty UpdateTextOnSelect { get { return _updateTextOnSelect ?? (_updateTextOnSelect = NPropFactories.CreateUpdateTextOnSelect()); } }
           NProperty _updateTextOnSelect;

    public NProperty UriSource { get { return _uriSource ?? (_uriSource = NPropFactories.CreateUriSource()); } }
           NProperty _uriSource;

    public NProperty UseLayoutRounding { get { return _useLayoutRounding ?? (_useLayoutRounding = NPropFactories.CreateUseLayoutRounding()); } }
           NProperty _useLayoutRounding;

    public NProperty UseSystemFocusVisuals { get { return _useSystemFocusVisuals ?? (_useSystemFocusVisuals = NPropFactories.CreateUseSystemFocusVisuals()); } }
           NProperty _useSystemFocusVisuals;

    public NProperty UseTouchAnimationsForAllNavigation { get { return _useTouchAnimationsForAllNavigation ?? (_useTouchAnimationsForAllNavigation = NPropFactories.CreateUseTouchAnimationsForAllNavigation()); } }
           NProperty _useTouchAnimationsForAllNavigation;

    public NProperty Value { get { return _value ?? (_value = NPropFactories.CreateValue()); } }
           NProperty _value;

    public NProperty ValueChanged { get { return _valueChanged ?? (_valueChanged = NPropFactories.CreateValueChanged()); } }
           NProperty _valueChanged;

    public NProperty VariableSizedWrapGridColumnSpan { get { return _variableSizedWrapGridColumnSpan ?? (_variableSizedWrapGridColumnSpan = NPropFactories.CreateVariableSizedWrapGridColumnSpan()); } }
           NProperty _variableSizedWrapGridColumnSpan;

    public NProperty VariableSizedWrapGridRowSpan { get { return _variableSizedWrapGridRowSpan ?? (_variableSizedWrapGridRowSpan = NPropFactories.CreateVariableSizedWrapGridRowSpan()); } }
           NProperty _variableSizedWrapGridRowSpan;

    public NProperty VerticalAlignment { get { return _verticalAlignment ?? (_verticalAlignment = NPropFactories.CreateVerticalAlignment()); } }
           NProperty _verticalAlignment;

    public NProperty VerticalChildrenAlignment { get { return _verticalChildrenAlignment ?? (_verticalChildrenAlignment = NPropFactories.CreateVerticalChildrenAlignment()); } }
           NProperty _verticalChildrenAlignment;

    public NProperty VerticalContentAlignment { get { return _verticalContentAlignment ?? (_verticalContentAlignment = NPropFactories.CreateVerticalContentAlignment()); } }
           NProperty _verticalContentAlignment;

    public NProperty VerticalDayItemAlignment { get { return _verticalDayItemAlignment ?? (_verticalDayItemAlignment = NPropFactories.CreateVerticalDayItemAlignment()); } }
           NProperty _verticalDayItemAlignment;

    public NProperty VerticalFirstOfMonthLabelAlignment { get { return _verticalFirstOfMonthLabelAlignment ?? (_verticalFirstOfMonthLabelAlignment = NPropFactories.CreateVerticalFirstOfMonthLabelAlignment()); } }
           NProperty _verticalFirstOfMonthLabelAlignment;

    public NProperty VerticalOffset { get { return _verticalOffset ?? (_verticalOffset = NPropFactories.CreateVerticalOffset()); } }
           NProperty _verticalOffset;

    public NProperty VerticalScrollBarVisibility { get { return _verticalScrollBarVisibility ?? (_verticalScrollBarVisibility = NPropFactories.CreateVerticalScrollBarVisibility()); } }
           NProperty _verticalScrollBarVisibility;

    public NProperty VerticalScrollMode { get { return _verticalScrollMode ?? (_verticalScrollMode = NPropFactories.CreateVerticalScrollMode()); } }
           NProperty _verticalScrollMode;

    public NProperty VerticalSnapPointsAlignment { get { return _verticalSnapPointsAlignment ?? (_verticalSnapPointsAlignment = NPropFactories.CreateVerticalSnapPointsAlignment()); } }
           NProperty _verticalSnapPointsAlignment;

    public NProperty VerticalSnapPointsChanged { get { return _verticalSnapPointsChanged ?? (_verticalSnapPointsChanged = NPropFactories.CreateVerticalSnapPointsChanged()); } }
           NProperty _verticalSnapPointsChanged;

    public NProperty VerticalSnapPointsType { get { return _verticalSnapPointsType ?? (_verticalSnapPointsType = NPropFactories.CreateVerticalSnapPointsType()); } }
           NProperty _verticalSnapPointsType;

    public NProperty ViewChangeCompleted { get { return _viewChangeCompleted ?? (_viewChangeCompleted = NPropFactories.CreateViewChangeCompleted()); } }
           NProperty _viewChangeCompleted;

    public NProperty ViewChanged { get { return _viewChanged ?? (_viewChanged = NPropFactories.CreateViewChanged()); } }
           NProperty _viewChanged;

    public NProperty ViewChangeStarted { get { return _viewChangeStarted ?? (_viewChangeStarted = NPropFactories.CreateViewChangeStarted()); } }
           NProperty _viewChangeStarted;

    public NProperty ViewChanging { get { return _viewChanging ?? (_viewChanging = NPropFactories.CreateViewChanging()); } }
           NProperty _viewChanging;

    public NProperty ViewportSize { get { return _viewportSize ?? (_viewportSize = NPropFactories.CreateViewportSize()); } }
           NProperty _viewportSize;

    public NProperty VirtualizingStackPanelVirtualizationMode { get { return _virtualizingStackPanelVirtualizationMode ?? (_virtualizingStackPanelVirtualizationMode = NPropFactories.CreateVirtualizingStackPanelVirtualizationMode()); } }
           NProperty _virtualizingStackPanelVirtualizationMode;

    public NProperty Visibility { get { return _visibility ?? (_visibility = NPropFactories.CreateVisibility()); } }
           NProperty _visibility;

    public NProperty Volume { get { return _volume ?? (_volume = NPropFactories.CreateVolume()); } }
           NProperty _volume;

    public NProperty VolumeChanged { get { return _volumeChanged ?? (_volumeChanged = NPropFactories.CreateVolumeChanged()); } }
           NProperty _volumeChanged;

    public NProperty WatermarkMode { get { return _watermarkMode ?? (_watermarkMode = NPropFactories.CreateWatermarkMode()); } }
           NProperty _watermarkMode;

    public NProperty Width { get { return _width ?? (_width = NPropFactories.CreateWidth()); } }
           NProperty _width;

    public NProperty X1 { get { return _x1 ?? (_x1 = NPropFactories.CreateX1()); } }
           NProperty _x1;

    public NProperty X2 { get { return _x2 ?? (_x2 = NPropFactories.CreateX2()); } }
           NProperty _x2;

    public NProperty Y1 { get { return _y1 ?? (_y1 = NPropFactories.CreateY1()); } }
           NProperty _y1;

    public NProperty Y2 { get { return _y2 ?? (_y2 = NPropFactories.CreateY2()); } }
           NProperty _y2;

    public NProperty YearFormat { get { return _yearFormat ?? (_yearFormat = NPropFactories.CreateYearFormat()); } }
           NProperty _yearFormat;

    public NProperty YearVisible { get { return _yearVisible ?? (_yearVisible = NPropFactories.CreateYearVisible()); } }
           NProperty _yearVisible;

    public NProperty ZoomedInView { get { return _zoomedInView ?? (_zoomedInView = NPropFactories.CreateZoomedInView()); } }
           NProperty _zoomedInView;

    public NProperty ZoomedOutView { get { return _zoomedOutView ?? (_zoomedOutView = NPropFactories.CreateZoomedOutView()); } }
           NProperty _zoomedOutView;

    public NProperty ZoomInteractionMode { get { return _zoomInteractionMode ?? (_zoomInteractionMode = NPropFactories.CreateZoomInteractionMode()); } }
           NProperty _zoomInteractionMode;

    public NProperty ZoomLevel { get { return _zoomLevel ?? (_zoomLevel = NPropFactories.CreateZoomLevel()); } }
           NProperty _zoomLevel;

    public NProperty ZoomMode { get { return _zoomMode ?? (_zoomMode = NPropFactories.CreateZoomMode()); } }
           NProperty _zoomMode;

    public NProperty ZoomSnapPointsType { get { return _zoomSnapPointsType ?? (_zoomSnapPointsType = NPropFactories.CreateZoomSnapPointsType()); } }
           NProperty _zoomSnapPointsType;

  }

  static partial class NPropFactories
  {
    public static NProperty CreateAcceptsReturn() => new NProperty(nameof(NProperties.AcceptsReturn)).
        Property<RichEditBox>(RichEditBox.AcceptsReturnProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.AcceptsReturnProperty, NConverters.ToBool);

    public static NProperty CreateAllowDrop() => new NProperty(nameof(NProperties.AllowDrop)).
        Property<UIElement>(UIElement.AllowDropProperty, NConverters.ToBool);

    public static NProperty CreateAllowedScriptNotifyUris() => new NProperty(nameof(NProperties.AllowedScriptNotifyUris)).
        Property<WebView>(WebView.AllowedScriptNotifyUrisProperty);

    public static NProperty CreateAreScrollSnapPointsRegular() => new NProperty(nameof(NProperties.AreScrollSnapPointsRegular)).
        Property<StackPanel>(StackPanel.AreScrollSnapPointsRegularProperty, NConverters.ToBool).
        Property<VirtualizingStackPanel>(VirtualizingStackPanel.AreScrollSnapPointsRegularProperty, NConverters.ToBool);

    public static NProperty CreateAreStickyGroupHeadersEnabled() => new NProperty(nameof(NProperties.AreStickyGroupHeadersEnabled)).
        Property<ItemsStackPanel>(ItemsStackPanel.AreStickyGroupHeadersEnabledProperty, NConverters.ToBool).
        Property<ItemsWrapGrid>(ItemsWrapGrid.AreStickyGroupHeadersEnabledProperty, NConverters.ToBool);

    public static NProperty CreateAreTransportControlsEnabled() => new NProperty(nameof(NProperties.AreTransportControlsEnabled)).
        Property<MediaElement>(MediaElement.AreTransportControlsEnabledProperty, NConverters.ToBool);

    public static NProperty CreateAudioCategory() => new NProperty(nameof(NProperties.AudioCategory)).
        Property<MediaElement>(MediaElement.AudioCategoryProperty, NConverters.ToEnum<AudioCategory>);

    public static NProperty CreateAudioDeviceType() => new NProperty(nameof(NProperties.AudioDeviceType)).
        Property<MediaElement>(MediaElement.AudioDeviceTypeProperty, NConverters.ToEnum<AudioDeviceType>);

    public static NProperty CreateAudioStreamIndex() => new NProperty(nameof(NProperties.AudioStreamIndex)).
        Property<MediaElement>(MediaElement.AudioStreamIndexProperty, NConverters.ToInt32N);

    public static NProperty CreateAutoMaximizeSuggestionArea() => new NProperty(nameof(NProperties.AutoMaximizeSuggestionArea)).
        Property<AutoSuggestBox>(AutoSuggestBox.AutoMaximizeSuggestionAreaProperty, NConverters.ToBool);

    public static NProperty CreateAutoPlay() => new NProperty(nameof(NProperties.AutoPlay)).
        Property<MediaElement>(MediaElement.AutoPlayProperty, NConverters.ToBool);

    public static NProperty CreateBackClick() => new NProperty(nameof(NProperties.BackClick)).
        Event<SettingsFlyout>((s, a) => s.BackClick += a.EventHandlerAny);

    public static NProperty CreateBackground() => new NProperty(nameof(NProperties.Background)).
        Property<Panel>(Panel.BackgroundProperty, NConverters.ToBrush).
        Property<Border>(Border.BackgroundProperty, NConverters.ToBrush).
        Property<ContentPresenter>(ContentPresenter.BackgroundProperty, NConverters.ToBrush).
        Property<Control>(Control.BackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateBalance() => new NProperty(nameof(NProperties.Balance)).
        Property<MediaElement>(MediaElement.BalanceProperty, NConverters.ToDouble);

    public static NProperty CreateBlackoutForeground() => new NProperty(nameof(NProperties.BlackoutForeground)).
        Property<CalendarView>(CalendarView.BlackoutForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateBlocks() => new NProperty(nameof(NProperties.Blocks)).
        Property<RichTextBlock>((t, v) => NPatch.AssignListT(t.Blocks, v));

    public static NProperty CreateBorderBrush() => new NProperty(nameof(NProperties.BorderBrush)).
        Property<Grid>(Grid.BorderBrushProperty, NConverters.ToBrush).
        Property<RelativePanel>(RelativePanel.BorderBrushProperty, NConverters.ToBrush).
        Property<StackPanel>(StackPanel.BorderBrushProperty, NConverters.ToBrush).
        Property<Border>(Border.BorderBrushProperty, NConverters.ToBrush).
        Property<ContentPresenter>(ContentPresenter.BorderBrushProperty, NConverters.ToBrush).
        Property<Control>(Control.BorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateBorderThickness() => new NProperty(nameof(NProperties.BorderThickness)).
        Property<Grid>(Grid.BorderThicknessProperty, NConverters.ToThickness).
        Property<RelativePanel>(RelativePanel.BorderThicknessProperty, NConverters.ToThickness).
        Property<StackPanel>(StackPanel.BorderThicknessProperty, NConverters.ToThickness).
        Property<Border>(Border.BorderThicknessProperty, NConverters.ToThickness).
        Property<ContentPresenter>(ContentPresenter.BorderThicknessProperty, NConverters.ToThickness).
        Property<Control>(Control.BorderThicknessProperty, NConverters.ToThickness);

    public static NProperty CreateBottomAppBar() => new NProperty(nameof(NProperties.BottomAppBar)).
        Property<Page>(Page.BottomAppBarProperty);

    public static NProperty CreateBringIntoViewOnFocusChange() => new NProperty(nameof(NProperties.BringIntoViewOnFocusChange)).
        Property<ScrollViewer>(ScrollViewer.BringIntoViewOnFocusChangeProperty, NConverters.ToBool);

    public static NProperty CreateBufferingProgressChanged() => new NProperty(nameof(NProperties.BufferingProgressChanged)).
        Event<MediaElement>((s, a) => s.BufferingProgressChanged += a.EventHandlerAny);

    public static NProperty CreateBusinessLandmarksVisible() => new NProperty(nameof(NProperties.BusinessLandmarksVisible)).
        Property<MapControl>(MapControl.BusinessLandmarksVisibleProperty, NConverters.ToBool);

    public static NProperty CreateCacheLength() => new NProperty(nameof(NProperties.CacheLength)).
        Property<ItemsStackPanel>(ItemsStackPanel.CacheLengthProperty, NConverters.ToDouble).
        Property<ItemsWrapGrid>(ItemsWrapGrid.CacheLengthProperty, NConverters.ToDouble);

    public static NProperty CreateCacheMode() => new NProperty(nameof(NProperties.CacheMode)).
        Property<UIElement>(UIElement.CacheModeProperty);

    public static NProperty CreateCacheSize() => new NProperty(nameof(NProperties.CacheSize)).
        Property<Frame>(Frame.CacheSizeProperty, NConverters.ToInt32);

    public static NProperty CreateCalendarIdentifier() => new NProperty(nameof(NProperties.CalendarIdentifier)).
        Property<CalendarView>(CalendarView.CalendarIdentifierProperty, NConverters.ToString).
        Property<CalendarDatePicker>(CalendarDatePicker.CalendarIdentifierProperty, NConverters.ToString).
        Property<DatePicker>(DatePicker.CalendarIdentifierProperty, NConverters.ToString);

    public static NProperty CreateCalendarItemBackground() => new NProperty(nameof(NProperties.CalendarItemBackground)).
        Property<CalendarView>(CalendarView.CalendarItemBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateCalendarItemBorderBrush() => new NProperty(nameof(NProperties.CalendarItemBorderBrush)).
        Property<CalendarView>(CalendarView.CalendarItemBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateCalendarItemBorderThickness() => new NProperty(nameof(NProperties.CalendarItemBorderThickness)).
        Property<CalendarView>(CalendarView.CalendarItemBorderThicknessProperty, NConverters.ToThickness);

    public static NProperty CreateCalendarItemForeground() => new NProperty(nameof(NProperties.CalendarItemForeground)).
        Property<CalendarView>(CalendarView.CalendarItemForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateCalendarViewDayItemStyle() => new NProperty(nameof(NProperties.CalendarViewDayItemStyle)).
        Property<CalendarView>(CalendarView.CalendarViewDayItemStyleProperty, NConverters.ToStyle);

    public static NProperty CreateCalendarViewStyle() => new NProperty(nameof(NProperties.CalendarViewStyle)).
        Property<CalendarDatePicker>(CalendarDatePicker.CalendarViewStyleProperty, NConverters.ToStyle);

    public static NProperty CreateCanChangeViews() => new NProperty(nameof(NProperties.CanChangeViews)).
        Property<SemanticZoom>(SemanticZoom.CanChangeViewsProperty, NConverters.ToBool);

    public static NProperty CreateCanDrag() => new NProperty(nameof(NProperties.CanDrag)).
        Property<UIElement>(UIElement.CanDragProperty, NConverters.ToBool);

    public static NProperty CreateCanDragItems() => new NProperty(nameof(NProperties.CanDragItems)).
        Property<ListViewBase>(ListViewBase.CanDragItemsProperty, NConverters.ToBool);

    public static NProperty CreateCanHorizontallyScroll() => new NProperty(nameof(NProperties.CanHorizontallyScroll)).
        Property<CarouselPanel>((t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v)).
        Property<OrientedVirtualizingPanel>((t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v)).
        Property<ScrollContentPresenter>((t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));

    public static NProperty CreateCanReorderItems() => new NProperty(nameof(NProperties.CanReorderItems)).
        Property<ListViewBase>(ListViewBase.CanReorderItemsProperty, NConverters.ToBool);

    public static NProperty CreateCanvasLeft() => new NProperty(nameof(NProperties.CanvasLeft)).
        Property<UIElement>(Canvas.LeftProperty, NConverters.ToDouble);

    public static NProperty CreateCanvasTop() => new NProperty(nameof(NProperties.CanvasTop)).
        Property<UIElement>(Canvas.TopProperty, NConverters.ToDouble);

    public static NProperty CreateCanvasZIndex() => new NProperty(nameof(NProperties.CanvasZIndex)).
        Property<UIElement>(Canvas.ZIndexProperty, NConverters.ToInt32);

    public static NProperty CreateCanVerticallyScroll() => new NProperty(nameof(NProperties.CanVerticallyScroll)).
        Property<CarouselPanel>((t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v)).
        Property<OrientedVirtualizingPanel>((t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v)).
        Property<ScrollContentPresenter>((t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));

    public static NProperty CreateCenter() => new NProperty(nameof(NProperties.Center)).
        Property<MapControl>(MapControl.CenterProperty);

    public static NProperty CreateCharacterSpacing() => new NProperty(nameof(NProperties.CharacterSpacing)).
        Property<ContentPresenter>(ContentPresenter.CharacterSpacingProperty, NConverters.ToInt32).
        Property<RichTextBlock>(RichTextBlock.CharacterSpacingProperty, NConverters.ToInt32).
        Property<TextBlock>(TextBlock.CharacterSpacingProperty, NConverters.ToInt32).
        Property<Control>(Control.CharacterSpacingProperty, NConverters.ToInt32).
        Property<TextElement>(TextElement.CharacterSpacingProperty, NConverters.ToInt32);

    public static NProperty CreateCheckBoxBrush() => new NProperty(nameof(NProperties.CheckBoxBrush)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.CheckBoxBrushProperty, NConverters.ToBrush);

    public static NProperty CreateCheckBrush() => new NProperty(nameof(NProperties.CheckBrush)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.CheckBrushProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.CheckBrushProperty, NConverters.ToBrush);

    public static NProperty CreateChecked() => new NProperty(nameof(NProperties.Checked)).
        Event<ToggleButton>((s, a) => s.Checked += a.EventHandlerAny);

    public static NProperty CreateCheckHintBrush() => new NProperty(nameof(NProperties.CheckHintBrush)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.CheckHintBrushProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.CheckHintBrushProperty, NConverters.ToBrush);

    public static NProperty CreateCheckMode() => new NProperty(nameof(NProperties.CheckMode)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.CheckModeProperty, NConverters.ToEnum<ListViewItemPresenterCheckMode>);

    public static NProperty CreateCheckSelectingBrush() => new NProperty(nameof(NProperties.CheckSelectingBrush)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.CheckSelectingBrushProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.CheckSelectingBrushProperty, NConverters.ToBrush);

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child)).
        Property<Popup>(Popup.ChildProperty).
        Property<Border>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v)).
        Property<Viewbox>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v)).
        Property<InlineUIContainer>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));

    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children)).
        Property<Panel>((t, v) => NPatch.AssignListT(t.Children, v));

    public static NProperty CreateChildrenTransitions() => new NProperty(nameof(NProperties.ChildrenTransitions)).
        Property<Panel>((t, v) => NPatch.AssignListT(t.ChildrenTransitions, v));

    public static NProperty CreateChildTransitions() => new NProperty(nameof(NProperties.ChildTransitions)).
        Property<Popup>((t, v) => NPatch.AssignListT(t.ChildTransitions, v)).
        Property<Border>((t, v) => NPatch.AssignListT(t.ChildTransitions, v));

    public static NProperty CreateChooseSuggestionOnEnter() => new NProperty(nameof(NProperties.ChooseSuggestionOnEnter)).
        Property<SearchBox>(SearchBox.ChooseSuggestionOnEnterProperty, NConverters.ToBool);

    public static NProperty CreateCleanUpVirtualizedItemEvent() => new NProperty(nameof(NProperties.CleanUpVirtualizedItemEvent)).
        Event<VirtualizingStackPanel>((s, a) => s.CleanUpVirtualizedItemEvent += a.EventHandlerAny);

    public static NProperty CreateClick() => new NProperty(nameof(NProperties.Click)).
        Event<ButtonBase>((s, a) => s.Click += a.EventHandlerAny).
        Event<MenuFlyoutItem>((s, a) => s.Click += a.EventHandlerAny);

    public static NProperty CreateClickMode() => new NProperty(nameof(NProperties.ClickMode)).
        Property<ButtonBase>(ButtonBase.ClickModeProperty, NConverters.ToEnum<ClickMode>);

    public static NProperty CreateClip() => new NProperty(nameof(NProperties.Clip)).
        Property<UIElement>(UIElement.ClipProperty);

    public static NProperty CreateClipboardCopyFormat() => new NProperty(nameof(NProperties.ClipboardCopyFormat)).
        Property<RichEditBox>(RichEditBox.ClipboardCopyFormatProperty, NConverters.ToEnum<RichEditClipboardFormat>);

    public static NProperty CreateClockIdentifier() => new NProperty(nameof(NProperties.ClockIdentifier)).
        Property<TimePicker>(TimePicker.ClockIdentifierProperty, NConverters.ToString);

    public static NProperty CreateClosed() => new NProperty(nameof(NProperties.Closed)).
        Event<Popup>((s, a) => s.Closed += a.EventHandlerAny).
        Event<ToolTip>((s, a) => s.Closed += a.EventHandlerAny).
        Event<AppBar>((s, a) => s.Closed += a.EventHandlerAny).
        Event<CalendarDatePicker>((s, a) => s.Closed += a.EventHandlerAny);

    public static NProperty CreateClosedDisplayMode() => new NProperty(nameof(NProperties.ClosedDisplayMode)).
        Property<AppBar>(AppBar.ClosedDisplayModeProperty, NConverters.ToEnum<AppBarClosedDisplayMode>);

    public static NProperty CreateClosing() => new NProperty(nameof(NProperties.Closing)).
        Event<AppBar>((s, a) => s.Closing += a.EventHandlerAny);

    public static NProperty CreateColorFontPaletteIndex() => new NProperty(nameof(NProperties.ColorFontPaletteIndex)).
        Property<Glyphs>(Glyphs.ColorFontPaletteIndexProperty, NConverters.ToInt32);

    public static NProperty CreateColorScheme() => new NProperty(nameof(NProperties.ColorScheme)).
        Property<MapControl>(MapControl.ColorSchemeProperty, NConverters.ToEnum<MapColorScheme>);

    public static NProperty CreateColumnDefinitions() => new NProperty(nameof(NProperties.ColumnDefinitions)).
        Property<Grid>((t, v) => NPatch.AssignListT(t.ColumnDefinitions, v));

    public static NProperty CreateCommand() => new NProperty(nameof(NProperties.Command)).
        Property<ButtonBase>(ButtonBase.CommandProperty).
        Property<MenuFlyoutItem>(MenuFlyoutItem.CommandProperty);

    public static NProperty CreateCommandBarOverflowPresenterStyle() => new NProperty(nameof(NProperties.CommandBarOverflowPresenterStyle)).
        Property<CommandBar>(CommandBar.CommandBarOverflowPresenterStyleProperty, NConverters.ToStyle);

    public static NProperty CreateCommandParameter() => new NProperty(nameof(NProperties.CommandParameter)).
        Property<ButtonBase>(ButtonBase.CommandParameterProperty).
        Property<MenuFlyoutItem>(MenuFlyoutItem.CommandParameterProperty);

    public static NProperty CreateCompactPaneLength() => new NProperty(nameof(NProperties.CompactPaneLength)).
        Property<SplitView>(SplitView.CompactPaneLengthProperty, NConverters.ToDouble);

    public static NProperty CreateCompositeMode() => new NProperty(nameof(NProperties.CompositeMode)).
        Property<UIElement>(UIElement.CompositeModeProperty, NConverters.ToEnum<ElementCompositeMode>);

    public static NProperty CreateContent() => new NProperty(nameof(NProperties.Content)).
        Property<ContentPresenter>(ContentPresenter.ContentProperty).
        Property<ContentControl>(ContentControl.ContentProperty).
        Property<UserControl>(UserControl.ContentProperty).
        Property<SplitView>(SplitView.ContentProperty);

    public static NProperty CreateContentMargin() => new NProperty(nameof(NProperties.ContentMargin)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.ContentMarginProperty, NConverters.ToThickness).
        Property<ListViewItemPresenter>(ListViewItemPresenter.ContentMarginProperty, NConverters.ToThickness);

    public static NProperty CreateContentTemplate() => new NProperty(nameof(NProperties.ContentTemplate)).
        Property<ContentPresenter>(ContentPresenter.ContentTemplateProperty, NConverters.ToDataTemplate).
        Property<ContentControl>(ContentControl.ContentTemplateProperty, NConverters.ToDataTemplate).
        Property<HubSection>(HubSection.ContentTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateContentTemplateSelector() => new NProperty(nameof(NProperties.ContentTemplateSelector)).
        Property<ContentPresenter>(ContentPresenter.ContentTemplateSelectorProperty).
        Property<ContentControl>(ContentControl.ContentTemplateSelectorProperty);

    public static NProperty CreateContentTransitions() => new NProperty(nameof(NProperties.ContentTransitions)).
        Property<ContentPresenter>((t, v) => NPatch.AssignListT(t.ContentTransitions, v)).
        Property<ContentControl>((t, v) => NPatch.AssignListT(t.ContentTransitions, v));

    public static NProperty CreateContextMenuOpening() => new NProperty(nameof(NProperties.ContextMenuOpening)).
        Event<RichTextBlock>((s, a) => s.ContextMenuOpening += a.EventHandlerAny).
        Event<TextBlock>((s, a) => s.ContextMenuOpening += a.EventHandlerAny).
        Event<PasswordBox>((s, a) => s.ContextMenuOpening += a.EventHandlerAny).
        Event<RichEditBox>((s, a) => s.ContextMenuOpening += a.EventHandlerAny).
        Event<TextBox>((s, a) => s.ContextMenuOpening += a.EventHandlerAny);

    public static NProperty CreateControlIsTemplateFocusTarget() => new NProperty(nameof(NProperties.ControlIsTemplateFocusTarget)).
        Property<FrameworkElement>(Control.IsTemplateFocusTargetProperty, NConverters.ToBool);

    public static NProperty CreateCornerRadius() => new NProperty(nameof(NProperties.CornerRadius)).
        Property<Grid>(Grid.CornerRadiusProperty, NConverters.ToCornerRadius).
        Property<RelativePanel>(RelativePanel.CornerRadiusProperty, NConverters.ToCornerRadius).
        Property<StackPanel>(StackPanel.CornerRadiusProperty, NConverters.ToCornerRadius).
        Property<Border>(Border.CornerRadiusProperty, NConverters.ToCornerRadius).
        Property<ContentPresenter>(ContentPresenter.CornerRadiusProperty, NConverters.ToCornerRadius);

    public static NProperty CreateCurrentStateChanged() => new NProperty(nameof(NProperties.CurrentStateChanged)).
        Event<MediaElement>((s, a) => s.CurrentStateChanged += a.EventHandlerAny);

    public static NProperty CreateData() => new NProperty(nameof(NProperties.Data)).
        Property<PathIcon>(PathIcon.DataProperty).
        Property<Path>(Path.DataProperty);

    public static NProperty CreateDataContext() => new NProperty(nameof(NProperties.DataContext)).
        Property<FrameworkElement>(FrameworkElement.DataContextProperty);

    public static NProperty CreateDataFetchSize() => new NProperty(nameof(NProperties.DataFetchSize)).
        Property<ListViewBase>(ListViewBase.DataFetchSizeProperty, NConverters.ToDouble);

    public static NProperty CreateDate() => new NProperty(nameof(NProperties.Date)).
        Property<CalendarDatePicker>(CalendarDatePicker.DateProperty, NConverters.ToDateTimeOffsetN).
        Property<DatePicker>(DatePicker.DateProperty, NConverters.ToDateTimeOffset);

    public static NProperty CreateDateChanged() => new NProperty(nameof(NProperties.DateChanged)).
        Event<DatePicker>((s, a) => s.DateChanged += a.EventHandlerAny);

    public static NProperty CreateDateFormat() => new NProperty(nameof(NProperties.DateFormat)).
        Property<CalendarDatePicker>(CalendarDatePicker.DateFormatProperty, NConverters.ToString);

    public static NProperty CreateDayFormat() => new NProperty(nameof(NProperties.DayFormat)).
        Property<DatePicker>(DatePicker.DayFormatProperty, NConverters.ToString);

    public static NProperty CreateDayItemFontFamily() => new NProperty(nameof(NProperties.DayItemFontFamily)).
        Property<CalendarView>(CalendarView.DayItemFontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateDayItemFontSize() => new NProperty(nameof(NProperties.DayItemFontSize)).
        Property<CalendarView>(CalendarView.DayItemFontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateDayItemFontStyle() => new NProperty(nameof(NProperties.DayItemFontStyle)).
        Property<CalendarView>(CalendarView.DayItemFontStyleProperty, NConverters.ToEnum<FontStyle>);

    public static NProperty CreateDayItemFontWeight() => new NProperty(nameof(NProperties.DayItemFontWeight)).
        Property<CalendarView>(CalendarView.DayItemFontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateDayOfWeekFormat() => new NProperty(nameof(NProperties.DayOfWeekFormat)).
        Property<CalendarView>(CalendarView.DayOfWeekFormatProperty, NConverters.ToString).
        Property<CalendarDatePicker>(CalendarDatePicker.DayOfWeekFormatProperty, NConverters.ToString);

    public static NProperty CreateDayVisible() => new NProperty(nameof(NProperties.DayVisible)).
        Property<DatePicker>(DatePicker.DayVisibleProperty, NConverters.ToBool);

    public static NProperty CreateDefaultBackgroundColor() => new NProperty(nameof(NProperties.DefaultBackgroundColor)).
        Property<WebView>(WebView.DefaultBackgroundColorProperty, NConverters.ToColor);

    public static NProperty CreateDefaultPlaybackRate() => new NProperty(nameof(NProperties.DefaultPlaybackRate)).
        Property<MediaElement>(MediaElement.DefaultPlaybackRateProperty, NConverters.ToDouble);

    public static NProperty CreateDefaultSectionIndex() => new NProperty(nameof(NProperties.DefaultSectionIndex)).
        Property<Hub>(Hub.DefaultSectionIndexProperty, NConverters.ToInt32);

    public static NProperty CreateDelay() => new NProperty(nameof(NProperties.Delay)).
        Property<RepeatButton>(RepeatButton.DelayProperty, NConverters.ToInt32);

    public static NProperty CreateDesiredCandidateWindowAlignment() => new NProperty(nameof(NProperties.DesiredCandidateWindowAlignment)).
        Property<RichEditBox>(RichEditBox.DesiredCandidateWindowAlignmentProperty, NConverters.ToEnum<CandidateWindowAlignment>).
        Property<TextBox>(TextBox.DesiredCandidateWindowAlignmentProperty, NConverters.ToEnum<CandidateWindowAlignment>);

    public static NProperty CreateDesiredPitch() => new NProperty(nameof(NProperties.DesiredPitch)).
        Property<MapControl>(MapControl.DesiredPitchProperty, NConverters.ToDouble);

    public static NProperty CreateDirectManipulationCompleted() => new NProperty(nameof(NProperties.DirectManipulationCompleted)).
        Event<ScrollViewer>((s, a) => s.DirectManipulationCompleted += a.EventHandlerAny);

    public static NProperty CreateDirectManipulationStarted() => new NProperty(nameof(NProperties.DirectManipulationStarted)).
        Event<ScrollViewer>((s, a) => s.DirectManipulationStarted += a.EventHandlerAny);

    public static NProperty CreateDisabledOpacity() => new NProperty(nameof(NProperties.DisabledOpacity)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.DisabledOpacityProperty, NConverters.ToDouble).
        Property<ListViewItemPresenter>(ListViewItemPresenter.DisabledOpacityProperty, NConverters.ToDouble);

    public static NProperty CreateDisplayMemberPath() => new NProperty(nameof(NProperties.DisplayMemberPath)).
        Property<ItemsControl>(ItemsControl.DisplayMemberPathProperty, NConverters.ToString);

    public static NProperty CreateDisplayMode() => new NProperty(nameof(NProperties.DisplayMode)).
        Property<CalendarView>(CalendarView.DisplayModeProperty, NConverters.ToEnum<CalendarViewDisplayMode>).
        Property<CalendarDatePicker>(CalendarDatePicker.DisplayModeProperty, NConverters.ToEnum<CalendarViewDisplayMode>).
        Property<SplitView>(SplitView.DisplayModeProperty, NConverters.ToEnum<SplitViewDisplayMode>);

    public static NProperty CreateDoubleTapped() => new NProperty(nameof(NProperties.DoubleTapped)).
        Event<UIElement>(UIElement.DoubleTappedEvent, a => (DoubleTappedEventHandler)a.EventHandlerAny);

    public static NProperty CreateDownloadProgressChanged() => new NProperty(nameof(NProperties.DownloadProgressChanged)).
        Event<MediaElement>((s, a) => s.DownloadProgressChanged += a.EventHandlerAny);

    public static NProperty CreateDragBackground() => new NProperty(nameof(NProperties.DragBackground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.DragBackgroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.DragBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateDragCompleted() => new NProperty(nameof(NProperties.DragCompleted)).
        Event<Thumb>((s, a) => s.DragCompleted += a.EventHandlerAny);

    public static NProperty CreateDragDelta() => new NProperty(nameof(NProperties.DragDelta)).
        Event<Thumb>((s, a) => s.DragDelta += a.EventHandlerAny);

    public static NProperty CreateDragEnter() => new NProperty(nameof(NProperties.DragEnter)).
        Event<UIElement>(UIElement.DragEnterEvent, a => (DragEventHandler)a.EventHandlerAny);

    public static NProperty CreateDragForeground() => new NProperty(nameof(NProperties.DragForeground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.DragForegroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.DragForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateDragItemsStarting() => new NProperty(nameof(NProperties.DragItemsStarting)).
        Event<ListViewBase>((s, a) => s.DragItemsStarting += a.EventHandlerAny);

    public static NProperty CreateDragLeave() => new NProperty(nameof(NProperties.DragLeave)).
        Event<UIElement>(UIElement.DragLeaveEvent, a => (DragEventHandler)a.EventHandlerAny);

    public static NProperty CreateDragOpacity() => new NProperty(nameof(NProperties.DragOpacity)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.DragOpacityProperty, NConverters.ToDouble).
        Property<ListViewItemPresenter>(ListViewItemPresenter.DragOpacityProperty, NConverters.ToDouble);

    public static NProperty CreateDragOver() => new NProperty(nameof(NProperties.DragOver)).
        Event<UIElement>(UIElement.DragOverEvent, a => (DragEventHandler)a.EventHandlerAny);

    public static NProperty CreateDragStarted() => new NProperty(nameof(NProperties.DragStarted)).
        Event<Thumb>((s, a) => s.DragStarted += a.EventHandlerAny);

    public static NProperty CreateDrop() => new NProperty(nameof(NProperties.Drop)).
        Event<UIElement>(UIElement.DropEvent, a => (DragEventHandler)a.EventHandlerAny);

    public static NProperty CreateDropDownClosed() => new NProperty(nameof(NProperties.DropDownClosed)).
        Event<ComboBox>((s, a) => s.DropDownClosed += a.EventHandlerAny);

    public static NProperty CreateDropDownOpened() => new NProperty(nameof(NProperties.DropDownOpened)).
        Event<ComboBox>((s, a) => s.DropDownOpened += a.EventHandlerAny);

    public static NProperty CreateFill() => new NProperty(nameof(NProperties.Fill)).
        Property<TickBar>(TickBar.FillProperty, NConverters.ToBrush).
        Property<Glyphs>(Glyphs.FillProperty, NConverters.ToBrush).
        Property<Shape>(Shape.FillProperty, NConverters.ToBrush);

    public static NProperty CreateFillRule() => new NProperty(nameof(NProperties.FillRule)).
        Property<Polygon>(Polygon.FillRuleProperty, NConverters.ToEnum<FillRule>).
        Property<Polyline>(Polyline.FillRuleProperty, NConverters.ToEnum<FillRule>);

    public static NProperty CreateFirstDayOfWeek() => new NProperty(nameof(NProperties.FirstDayOfWeek)).
        Property<CalendarView>(CalendarView.FirstDayOfWeekProperty, NConverters.ToEnum<WGDayOfWeek>).
        Property<CalendarDatePicker>(CalendarDatePicker.FirstDayOfWeekProperty, NConverters.ToEnum<WGDayOfWeek>);

    public static NProperty CreateFirstOfMonthLabelFontFamily() => new NProperty(nameof(NProperties.FirstOfMonthLabelFontFamily)).
        Property<CalendarView>(CalendarView.FirstOfMonthLabelFontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateFirstOfMonthLabelFontSize() => new NProperty(nameof(NProperties.FirstOfMonthLabelFontSize)).
        Property<CalendarView>(CalendarView.FirstOfMonthLabelFontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFirstOfMonthLabelFontStyle() => new NProperty(nameof(NProperties.FirstOfMonthLabelFontStyle)).
        Property<CalendarView>(CalendarView.FirstOfMonthLabelFontStyleProperty, NConverters.ToEnum<FontStyle>);

    public static NProperty CreateFirstOfMonthLabelFontWeight() => new NProperty(nameof(NProperties.FirstOfMonthLabelFontWeight)).
        Property<CalendarView>(CalendarView.FirstOfMonthLabelFontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateFirstOfYearDecadeLabelFontFamily() => new NProperty(nameof(NProperties.FirstOfYearDecadeLabelFontFamily)).
        Property<CalendarView>(CalendarView.FirstOfYearDecadeLabelFontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateFirstOfYearDecadeLabelFontSize() => new NProperty(nameof(NProperties.FirstOfYearDecadeLabelFontSize)).
        Property<CalendarView>(CalendarView.FirstOfYearDecadeLabelFontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFirstOfYearDecadeLabelFontStyle() => new NProperty(nameof(NProperties.FirstOfYearDecadeLabelFontStyle)).
        Property<CalendarView>(CalendarView.FirstOfYearDecadeLabelFontStyleProperty, NConverters.ToEnum<FontStyle>);

    public static NProperty CreateFirstOfYearDecadeLabelFontWeight() => new NProperty(nameof(NProperties.FirstOfYearDecadeLabelFontWeight)).
        Property<CalendarView>(CalendarView.FirstOfYearDecadeLabelFontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateFlowDirection() => new NProperty(nameof(NProperties.FlowDirection)).
        Property<FrameworkElement>(FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>).
        Property<Run>(Run.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);

    public static NProperty CreateFlyout() => new NProperty(nameof(NProperties.Flyout)).
        Property<Button>(Button.FlyoutProperty);

    public static NProperty CreateFocusBorderBrush() => new NProperty(nameof(NProperties.FocusBorderBrush)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.FocusBorderBrushProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.FocusBorderBrushProperty, NConverters.ToBrush).
        Property<CalendarView>(CalendarView.FocusBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateFocusOnKeyboardInput() => new NProperty(nameof(NProperties.FocusOnKeyboardInput)).
        Property<SearchBox>(SearchBox.FocusOnKeyboardInputProperty, NConverters.ToBool);

    public static NProperty CreateFocusSecondaryBorderBrush() => new NProperty(nameof(NProperties.FocusSecondaryBorderBrush)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.FocusSecondaryBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateFontFamily() => new NProperty(nameof(NProperties.FontFamily)).
        Property<ContentPresenter>(ContentPresenter.FontFamilyProperty, NConverters.ToFontFamily).
        Property<RichTextBlock>(RichTextBlock.FontFamilyProperty, NConverters.ToFontFamily).
        Property<TextBlock>(TextBlock.FontFamilyProperty, NConverters.ToFontFamily).
        Property<FontIcon>(FontIcon.FontFamilyProperty, NConverters.ToFontFamily).
        Property<Control>(Control.FontFamilyProperty, NConverters.ToFontFamily).
        Property<TextElement>(TextElement.FontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateFontRenderingEmSize() => new NProperty(nameof(NProperties.FontRenderingEmSize)).
        Property<Glyphs>(Glyphs.FontRenderingEmSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFontSize() => new NProperty(nameof(NProperties.FontSize)).
        Property<ContentPresenter>(ContentPresenter.FontSizeProperty, NConverters.ToDouble).
        Property<RichTextBlock>(RichTextBlock.FontSizeProperty, NConverters.ToDouble).
        Property<TextBlock>(TextBlock.FontSizeProperty, NConverters.ToDouble).
        Property<FontIcon>(FontIcon.FontSizeProperty, NConverters.ToDouble).
        Property<Control>(Control.FontSizeProperty, NConverters.ToDouble).
        Property<TextElement>(TextElement.FontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFontStretch() => new NProperty(nameof(NProperties.FontStretch)).
        Property<ContentPresenter>(ContentPresenter.FontStretchProperty, NConverters.ToEnum<FontStretch>).
        Property<RichTextBlock>(RichTextBlock.FontStretchProperty, NConverters.ToEnum<FontStretch>).
        Property<TextBlock>(TextBlock.FontStretchProperty, NConverters.ToEnum<FontStretch>).
        Property<Control>(Control.FontStretchProperty, NConverters.ToEnum<FontStretch>).
        Property<TextElement>(TextElement.FontStretchProperty, NConverters.ToEnum<FontStretch>);

    public static NProperty CreateFontStyle() => new NProperty(nameof(NProperties.FontStyle)).
        Property<ContentPresenter>(ContentPresenter.FontStyleProperty, NConverters.ToEnum<FontStyle>).
        Property<RichTextBlock>(RichTextBlock.FontStyleProperty, NConverters.ToEnum<FontStyle>).
        Property<TextBlock>(TextBlock.FontStyleProperty, NConverters.ToEnum<FontStyle>).
        Property<FontIcon>(FontIcon.FontStyleProperty, NConverters.ToEnum<FontStyle>).
        Property<Control>(Control.FontStyleProperty, NConverters.ToEnum<FontStyle>).
        Property<TextElement>(TextElement.FontStyleProperty, NConverters.ToEnum<FontStyle>);

    public static NProperty CreateFontUri() => new NProperty(nameof(NProperties.FontUri)).
        Property<Glyphs>(Glyphs.FontUriProperty, NConverters.ToUri);

    public static NProperty CreateFontWeight() => new NProperty(nameof(NProperties.FontWeight)).
        Property<ContentPresenter>(ContentPresenter.FontWeightProperty, NConverters.ToFontWeight).
        Property<RichTextBlock>(RichTextBlock.FontWeightProperty, NConverters.ToFontWeight).
        Property<TextBlock>(TextBlock.FontWeightProperty, NConverters.ToFontWeight).
        Property<FontIcon>(FontIcon.FontWeightProperty, NConverters.ToFontWeight).
        Property<Control>(Control.FontWeightProperty, NConverters.ToFontWeight).
        Property<TextElement>(TextElement.FontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateFooter() => new NProperty(nameof(NProperties.Footer)).
        Property<ItemsPresenter>(ItemsPresenter.FooterProperty).
        Property<ListViewBase>(ListViewBase.FooterProperty);

    public static NProperty CreateFooterTemplate() => new NProperty(nameof(NProperties.FooterTemplate)).
        Property<ItemsPresenter>(ItemsPresenter.FooterTemplateProperty, NConverters.ToDataTemplate).
        Property<ListViewBase>(ListViewBase.FooterTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateFooterTransitions() => new NProperty(nameof(NProperties.FooterTransitions)).
        Property<ItemsPresenter>((t, v) => NPatch.AssignListT(t.FooterTransitions, v)).
        Property<ListViewBase>((t, v) => NPatch.AssignListT(t.FooterTransitions, v));

    public static NProperty CreateForeground() => new NProperty(nameof(NProperties.Foreground)).
        Property<ContentPresenter>(ContentPresenter.ForegroundProperty, NConverters.ToBrush).
        Property<RichTextBlock>(RichTextBlock.ForegroundProperty, NConverters.ToBrush).
        Property<TextBlock>(TextBlock.ForegroundProperty, NConverters.ToBrush).
        Property<IconElement>(IconElement.ForegroundProperty, NConverters.ToBrush).
        Property<Control>(Control.ForegroundProperty, NConverters.ToBrush).
        Property<TextElement>(TextElement.ForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateFullSizeDesired() => new NProperty(nameof(NProperties.FullSizeDesired)).
        Property<ContentDialog>(ContentDialog.FullSizeDesiredProperty, NConverters.ToBool);

    public static NProperty CreateGlyph() => new NProperty(nameof(NProperties.Glyph)).
        Property<FontIcon>(FontIcon.GlyphProperty, NConverters.ToString);

    public static NProperty CreateGotFocus() => new NProperty(nameof(NProperties.GotFocus)).
        Event<UIElement>((s, a) => s.GotFocus += a.EventHandlerAny);

    public static NProperty CreateGridColumn() => new NProperty(nameof(NProperties.GridColumn)).
        Property<FrameworkElement>(Grid.ColumnProperty, NConverters.ToInt32);

    public static NProperty CreateGridColumnSpan() => new NProperty(nameof(NProperties.GridColumnSpan)).
        Property<FrameworkElement>(Grid.ColumnSpanProperty, NConverters.ToInt32);

    public static NProperty CreateGridRow() => new NProperty(nameof(NProperties.GridRow)).
        Property<FrameworkElement>(Grid.RowProperty, NConverters.ToInt32);

    public static NProperty CreateGridRowSpan() => new NProperty(nameof(NProperties.GridRowSpan)).
        Property<FrameworkElement>(Grid.RowSpanProperty, NConverters.ToInt32);

    public static NProperty CreateGridViewItemPresenterHorizontalContentAlignment() => new NProperty(nameof(NProperties.GridViewItemPresenterHorizontalContentAlignment)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.GridViewItemPresenterHorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateGridViewItemPresenterPadding() => new NProperty(nameof(NProperties.GridViewItemPresenterPadding)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.GridViewItemPresenterPaddingProperty, NConverters.ToThickness);

    public static NProperty CreateGridViewItemPresenterVerticalContentAlignment() => new NProperty(nameof(NProperties.GridViewItemPresenterVerticalContentAlignment)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.GridViewItemPresenterVerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateGroupHeaderPlacement() => new NProperty(nameof(NProperties.GroupHeaderPlacement)).
        Property<ItemsStackPanel>(ItemsStackPanel.GroupHeaderPlacementProperty, NConverters.ToEnum<GroupHeaderPlacement>).
        Property<ItemsWrapGrid>(ItemsWrapGrid.GroupHeaderPlacementProperty, NConverters.ToEnum<GroupHeaderPlacement>);

    public static NProperty CreateGroupName() => new NProperty(nameof(NProperties.GroupName)).
        Property<RadioButton>(RadioButton.GroupNameProperty, NConverters.ToString);

    public static NProperty CreateGroupPadding() => new NProperty(nameof(NProperties.GroupPadding)).
        Property<ItemsStackPanel>(ItemsStackPanel.GroupPaddingProperty, NConverters.ToThickness).
        Property<ItemsWrapGrid>(ItemsWrapGrid.GroupPaddingProperty, NConverters.ToThickness);

    public static NProperty CreateGroupStyle() => new NProperty(nameof(NProperties.GroupStyle)).
        Property<ItemsControl>((t, v) => NPatch.AssignListT(t.GroupStyle, v));

    public static NProperty CreateGroupStyleSelector() => new NProperty(nameof(NProperties.GroupStyleSelector)).
        Property<ItemsControl>(ItemsControl.GroupStyleSelectorProperty);

    public static NProperty CreateHeader() => new NProperty(nameof(NProperties.Header)).
        Property<ItemsPresenter>(ItemsPresenter.HeaderProperty).
        Property<PivotItem>(PivotItem.HeaderProperty).
        Property<ListViewBase>(ListViewBase.HeaderProperty).
        Property<ComboBox>(ComboBox.HeaderProperty).
        Property<AutoSuggestBox>(AutoSuggestBox.HeaderProperty).
        Property<PasswordBox>(PasswordBox.HeaderProperty).
        Property<RichEditBox>(RichEditBox.HeaderProperty).
        Property<TextBox>(TextBox.HeaderProperty).
        Property<ToggleSwitch>(ToggleSwitch.HeaderProperty).
        Property<Slider>(Slider.HeaderProperty).
        Property<HubSection>(HubSection.HeaderProperty).
        Property<CalendarDatePicker>(CalendarDatePicker.HeaderProperty).
        Property<DatePicker>(DatePicker.HeaderProperty).
        Property<Hub>(Hub.HeaderProperty).
        Property<TimePicker>(TimePicker.HeaderProperty);

    public static NProperty CreateHeaderBackground() => new NProperty(nameof(NProperties.HeaderBackground)).
        Property<SettingsFlyout>(SettingsFlyout.HeaderBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateHeaderForeground() => new NProperty(nameof(NProperties.HeaderForeground)).
        Property<SettingsFlyout>(SettingsFlyout.HeaderForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateHeaderTemplate() => new NProperty(nameof(NProperties.HeaderTemplate)).
        Property<ItemsPresenter>(ItemsPresenter.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<ListViewBase>(ListViewBase.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<ComboBox>(ComboBox.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<Pivot>(Pivot.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<PasswordBox>(PasswordBox.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<RichEditBox>(RichEditBox.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<TextBox>(TextBox.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<ToggleSwitch>(ToggleSwitch.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<Slider>(Slider.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<HubSection>(HubSection.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<CalendarDatePicker>(CalendarDatePicker.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<DatePicker>(DatePicker.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<Hub>(Hub.HeaderTemplateProperty, NConverters.ToDataTemplate).
        Property<TimePicker>(TimePicker.HeaderTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateHeaderTransitions() => new NProperty(nameof(NProperties.HeaderTransitions)).
        Property<ItemsPresenter>((t, v) => NPatch.AssignListT(t.HeaderTransitions, v)).
        Property<ListViewBase>((t, v) => NPatch.AssignListT(t.HeaderTransitions, v));

    public static NProperty CreateHeading() => new NProperty(nameof(NProperties.Heading)).
        Property<MapControl>(MapControl.HeadingProperty, NConverters.ToDouble);

    public static NProperty CreateHeight() => new NProperty(nameof(NProperties.Height)).
        Property<FrameworkElement>(FrameworkElement.HeightProperty, NConverters.ToLength).
        Property<RowDefinition>(RowDefinition.HeightProperty, NConverters.ToGridLength);

    public static NProperty CreateHolding() => new NProperty(nameof(NProperties.Holding)).
        Event<UIElement>(UIElement.HoldingEvent, a => (HoldingEventHandler)a.EventHandlerAny);

    public static NProperty CreateHorizontalAlignment() => new NProperty(nameof(NProperties.HorizontalAlignment)).
        Property<FrameworkElement>(FrameworkElement.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalChildrenAlignment() => new NProperty(nameof(NProperties.HorizontalChildrenAlignment)).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.HorizontalChildrenAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>).
        Property<WrapGrid>(WrapGrid.HorizontalChildrenAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalContentAlignment() => new NProperty(nameof(NProperties.HorizontalContentAlignment)).
        Property<ContentPresenter>(ContentPresenter.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>).
        Property<Control>(Control.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalDayItemAlignment() => new NProperty(nameof(NProperties.HorizontalDayItemAlignment)).
        Property<CalendarView>(CalendarView.HorizontalDayItemAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalFirstOfMonthLabelAlignment() => new NProperty(nameof(NProperties.HorizontalFirstOfMonthLabelAlignment)).
        Property<CalendarView>(CalendarView.HorizontalFirstOfMonthLabelAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalOffset() => new NProperty(nameof(NProperties.HorizontalOffset)).
        Property<Popup>(Popup.HorizontalOffsetProperty, NConverters.ToDouble).
        Property<ToolTip>(ToolTip.HorizontalOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateHorizontalScrollBarVisibility() => new NProperty(nameof(NProperties.HorizontalScrollBarVisibility)).
        Property<ScrollViewer>(ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateHorizontalScrollMode() => new NProperty(nameof(NProperties.HorizontalScrollMode)).
        Property<ScrollViewer>(ScrollViewer.HorizontalScrollModeProperty, NConverters.ToEnum<ScrollMode>);

    public static NProperty CreateHorizontalSnapPointsAlignment() => new NProperty(nameof(NProperties.HorizontalSnapPointsAlignment)).
        Property<ScrollViewer>(ScrollViewer.HorizontalSnapPointsAlignmentProperty, NConverters.ToEnum<SnapPointsAlignment>);

    public static NProperty CreateHorizontalSnapPointsChanged() => new NProperty(nameof(NProperties.HorizontalSnapPointsChanged)).
        Event<LoopingSelectorPanel>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny).
        Event<StackPanel>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny).
        Event<CarouselPanel>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny).
        Event<OrientedVirtualizingPanel>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny).
        Event<PivotPanel>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny).
        Event<ItemsPresenter>((s, a) => s.HorizontalSnapPointsChanged += a.EventHandlerAny);

    public static NProperty CreateHorizontalSnapPointsType() => new NProperty(nameof(NProperties.HorizontalSnapPointsType)).
        Property<ScrollViewer>(ScrollViewer.HorizontalSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);

    public static NProperty CreateHoverBorderBrush() => new NProperty(nameof(NProperties.HoverBorderBrush)).
        Property<CalendarView>(CalendarView.HoverBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateIcon() => new NProperty(nameof(NProperties.Icon)).
        Property<AppBarButton>(AppBarButton.IconProperty).
        Property<AppBarToggleButton>(AppBarToggleButton.IconProperty);

    public static NProperty CreateIconSource() => new NProperty(nameof(NProperties.IconSource)).
        Property<SettingsFlyout>(SettingsFlyout.IconSourceProperty);

    public static NProperty CreateImageFailed() => new NProperty(nameof(NProperties.ImageFailed)).
        Event<Image>((s, a) => s.ImageFailed += a.EventHandlerAny);

    public static NProperty CreateImageOpened() => new NProperty(nameof(NProperties.ImageOpened)).
        Event<Image>((s, a) => s.ImageOpened += a.EventHandlerAny);

    public static NProperty CreateIncrementalLoadingThreshold() => new NProperty(nameof(NProperties.IncrementalLoadingThreshold)).
        Property<ListViewBase>(ListViewBase.IncrementalLoadingThresholdProperty, NConverters.ToDouble);

    public static NProperty CreateIncrementalLoadingTrigger() => new NProperty(nameof(NProperties.IncrementalLoadingTrigger)).
        Property<ListViewBase>(ListViewBase.IncrementalLoadingTriggerProperty, NConverters.ToEnum<IncrementalLoadingTrigger>);

    public static NProperty CreateIndeterminate() => new NProperty(nameof(NProperties.Indeterminate)).
        Event<ToggleButton>((s, a) => s.Indeterminate += a.EventHandlerAny);

    public static NProperty CreateIndicatorMode() => new NProperty(nameof(NProperties.IndicatorMode)).
        Property<ScrollBar>(ScrollBar.IndicatorModeProperty, NConverters.ToEnum<ScrollingIndicatorMode>);

    public static NProperty CreateIndices() => new NProperty(nameof(NProperties.Indices)).
        Property<Glyphs>(Glyphs.IndicesProperty, NConverters.ToString);

    public static NProperty CreateInlines() => new NProperty(nameof(NProperties.Inlines)).
        Property<TextBlock>((t, v) => NPatch.AssignListT(t.Inlines, v)).
        Property<Paragraph>((t, v) => NPatch.AssignListT(t.Inlines, v)).
        Property<Span>((t, v) => NPatch.AssignListT(t.Inlines, v));

    public static NProperty CreateInputScope() => new NProperty(nameof(NProperties.InputScope)).
        Property<PasswordBox>(PasswordBox.InputScopeProperty).
        Property<RichEditBox>(RichEditBox.InputScopeProperty).
        Property<TextBox>(TextBox.InputScopeProperty);

    public static NProperty CreateIntermediateValue() => new NProperty(nameof(NProperties.IntermediateValue)).
        Property<Slider>(Slider.IntermediateValueProperty, NConverters.ToDouble);

    public static NProperty CreateInterval() => new NProperty(nameof(NProperties.Interval)).
        Property<RepeatButton>(RepeatButton.IntervalProperty, NConverters.ToInt32);

    public static NProperty CreateIsActive() => new NProperty(nameof(NProperties.IsActive)).
        Property<ProgressRing>(ProgressRing.IsActiveProperty, NConverters.ToBool);

    public static NProperty CreateIsActiveView() => new NProperty(nameof(NProperties.IsActiveView)).
        Property<ListViewBase>(ListViewBase.IsActiveViewProperty, NConverters.ToBool).
        Property<Hub>(Hub.IsActiveViewProperty, NConverters.ToBool);

    public static NProperty CreateIsBlackout() => new NProperty(nameof(NProperties.IsBlackout)).
        Property<CalendarViewDayItem>(CalendarViewDayItem.IsBlackoutProperty, NConverters.ToBool);

    public static NProperty CreateIsCalendarOpen() => new NProperty(nameof(NProperties.IsCalendarOpen)).
        Property<CalendarDatePicker>(CalendarDatePicker.IsCalendarOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsChecked() => new NProperty(nameof(NProperties.IsChecked)).
        Property<ToggleButton>(ToggleButton.IsCheckedProperty, NConverters.ToBoolN).
        Property<ToggleMenuFlyoutItem>(ToggleMenuFlyoutItem.IsCheckedProperty, NConverters.ToBool);

    public static NProperty CreateIsColorFontEnabled() => new NProperty(nameof(NProperties.IsColorFontEnabled)).
        Property<RichTextBlock>(RichTextBlock.IsColorFontEnabledProperty, NConverters.ToBool).
        Property<TextBlock>(TextBlock.IsColorFontEnabledProperty, NConverters.ToBool).
        Property<Glyphs>(Glyphs.IsColorFontEnabledProperty, NConverters.ToBool).
        Property<RichEditBox>(RichEditBox.IsColorFontEnabledProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.IsColorFontEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsCompact() => new NProperty(nameof(NProperties.IsCompact)).
        Property<AppBarButton>(AppBarButton.IsCompactProperty, NConverters.ToBool).
        Property<AppBarToggleButton>(AppBarToggleButton.IsCompactProperty, NConverters.ToBool).
        Property<MediaTransportControls>(MediaTransportControls.IsCompactProperty, NConverters.ToBool).
        Property<AppBarSeparator>(AppBarSeparator.IsCompactProperty, NConverters.ToBool);

    public static NProperty CreateIsDeferredScrollingEnabled() => new NProperty(nameof(NProperties.IsDeferredScrollingEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsDirectionReversed() => new NProperty(nameof(NProperties.IsDirectionReversed)).
        Property<Slider>(Slider.IsDirectionReversedProperty, NConverters.ToBool);

    public static NProperty CreateIsDoubleTapEnabled() => new NProperty(nameof(NProperties.IsDoubleTapEnabled)).
        Property<UIElement>(UIElement.IsDoubleTapEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsDropDownOpen() => new NProperty(nameof(NProperties.IsDropDownOpen)).
        Property<ComboBox>(ComboBox.IsDropDownOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsEnabled() => new NProperty(nameof(NProperties.IsEnabled)).
        Property<Control>(Control.IsEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsEnabledChanged() => new NProperty(nameof(NProperties.IsEnabledChanged)).
        Event<Control>((s, a) => s.IsEnabledChanged += a.EventHandlerAny);

    public static NProperty CreateIsFastForwardButtonVisible() => new NProperty(nameof(NProperties.IsFastForwardButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsFastForwardButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsFastForwardEnabled() => new NProperty(nameof(NProperties.IsFastForwardEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsFastForwardEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsFastRewindButtonVisible() => new NProperty(nameof(NProperties.IsFastRewindButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsFastRewindButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsFastRewindEnabled() => new NProperty(nameof(NProperties.IsFastRewindEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsFastRewindEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsFullWindow() => new NProperty(nameof(NProperties.IsFullWindow)).
        Property<MediaElement>(MediaElement.IsFullWindowProperty, NConverters.ToBool);

    public static NProperty CreateIsFullWindowButtonVisible() => new NProperty(nameof(NProperties.IsFullWindowButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsFullWindowButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsFullWindowEnabled() => new NProperty(nameof(NProperties.IsFullWindowEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsFullWindowEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsGroupLabelVisible() => new NProperty(nameof(NProperties.IsGroupLabelVisible)).
        Property<CalendarView>(CalendarView.IsGroupLabelVisibleProperty, NConverters.ToBool).
        Property<CalendarDatePicker>(CalendarDatePicker.IsGroupLabelVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsHeaderInteractive() => new NProperty(nameof(NProperties.IsHeaderInteractive)).
        Property<HubSection>(HubSection.IsHeaderInteractiveProperty, NConverters.ToBool);

    public static NProperty CreateIsHitTestVisible() => new NProperty(nameof(NProperties.IsHitTestVisible)).
        Property<UIElement>(UIElement.IsHitTestVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsHoldingEnabled() => new NProperty(nameof(NProperties.IsHoldingEnabled)).
        Property<UIElement>(UIElement.IsHoldingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsHorizontalRailEnabled() => new NProperty(nameof(NProperties.IsHorizontalRailEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsHorizontalRailEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsHorizontalScrollChainingEnabled() => new NProperty(nameof(NProperties.IsHorizontalScrollChainingEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsHorizontalScrollChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsIndeterminate() => new NProperty(nameof(NProperties.IsIndeterminate)).
        Property<ProgressBar>(ProgressBar.IsIndeterminateProperty, NConverters.ToBool);

    public static NProperty CreateIsItemClickEnabled() => new NProperty(nameof(NProperties.IsItemClickEnabled)).
        Property<ListViewBase>(ListViewBase.IsItemClickEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsLightDismissEnabled() => new NProperty(nameof(NProperties.IsLightDismissEnabled)).
        Property<Popup>(Popup.IsLightDismissEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsLocked() => new NProperty(nameof(NProperties.IsLocked)).
        Property<Pivot>(Pivot.IsLockedProperty, NConverters.ToBool);

    public static NProperty CreateIsLooping() => new NProperty(nameof(NProperties.IsLooping)).
        Property<MediaElement>(MediaElement.IsLoopingProperty, NConverters.ToBool);

    public static NProperty CreateIsMultiSelectCheckBoxEnabled() => new NProperty(nameof(NProperties.IsMultiSelectCheckBoxEnabled)).
        Property<ListViewBase>(ListViewBase.IsMultiSelectCheckBoxEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsMuted() => new NProperty(nameof(NProperties.IsMuted)).
        Property<MediaElement>(MediaElement.IsMutedProperty, NConverters.ToBool);

    public static NProperty CreateIsOn() => new NProperty(nameof(NProperties.IsOn)).
        Property<ToggleSwitch>(ToggleSwitch.IsOnProperty, NConverters.ToBool);

    public static NProperty CreateIsOpen() => new NProperty(nameof(NProperties.IsOpen)).
        Property<Popup>(Popup.IsOpenProperty, NConverters.ToBool).
        Property<ToolTip>(ToolTip.IsOpenProperty, NConverters.ToBool).
        Property<AppBar>(AppBar.IsOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsOutOfScopeEnabled() => new NProperty(nameof(NProperties.IsOutOfScopeEnabled)).
        Property<CalendarView>(CalendarView.IsOutOfScopeEnabledProperty, NConverters.ToBool).
        Property<CalendarDatePicker>(CalendarDatePicker.IsOutOfScopeEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsPaneOpen() => new NProperty(nameof(NProperties.IsPaneOpen)).
        Property<SplitView>(SplitView.IsPaneOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsPasswordRevealButtonEnabled() => new NProperty(nameof(NProperties.IsPasswordRevealButtonEnabled)).
        Property<PasswordBox>(PasswordBox.IsPasswordRevealButtonEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsPlaybackRateButtonVisible() => new NProperty(nameof(NProperties.IsPlaybackRateButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsPlaybackRateButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsPlaybackRateEnabled() => new NProperty(nameof(NProperties.IsPlaybackRateEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsPlaybackRateEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsPrimaryButtonEnabled() => new NProperty(nameof(NProperties.IsPrimaryButtonEnabled)).
        Property<ContentDialog>(ContentDialog.IsPrimaryButtonEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsReadOnly() => new NProperty(nameof(NProperties.IsReadOnly)).
        Property<RichEditBox>(RichEditBox.IsReadOnlyProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.IsReadOnlyProperty, NConverters.ToBool);

    public static NProperty CreateIsRightTapEnabled() => new NProperty(nameof(NProperties.IsRightTapEnabled)).
        Property<UIElement>(UIElement.IsRightTapEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsScrollInertiaEnabled() => new NProperty(nameof(NProperties.IsScrollInertiaEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsScrollInertiaEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSecondaryButtonEnabled() => new NProperty(nameof(NProperties.IsSecondaryButtonEnabled)).
        Property<ContentDialog>(ContentDialog.IsSecondaryButtonEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSeekBarVisible() => new NProperty(nameof(NProperties.IsSeekBarVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsSeekBarVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsSeekEnabled() => new NProperty(nameof(NProperties.IsSeekEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsSeekEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSelected() => new NProperty(nameof(NProperties.IsSelected)).
        Property<SelectorItem>(SelectorItem.IsSelectedProperty, NConverters.ToBool);

    public static NProperty CreateIsSpellCheckEnabled() => new NProperty(nameof(NProperties.IsSpellCheckEnabled)).
        Property<RichEditBox>(RichEditBox.IsSpellCheckEnabledProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.IsSpellCheckEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSticky() => new NProperty(nameof(NProperties.IsSticky)).
        Property<AppBar>(AppBar.IsStickyProperty, NConverters.ToBool);

    public static NProperty CreateIsStopButtonVisible() => new NProperty(nameof(NProperties.IsStopButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsStopButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsStopEnabled() => new NProperty(nameof(NProperties.IsStopEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsStopEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSuggestionListOpen() => new NProperty(nameof(NProperties.IsSuggestionListOpen)).
        Property<AutoSuggestBox>(AutoSuggestBox.IsSuggestionListOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsSwipeEnabled() => new NProperty(nameof(NProperties.IsSwipeEnabled)).
        Property<ListViewBase>(ListViewBase.IsSwipeEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsSynchronizedWithCurrentItem() => new NProperty(nameof(NProperties.IsSynchronizedWithCurrentItem)).
        Property<Selector>(Selector.IsSynchronizedWithCurrentItemProperty, NConverters.ToBoolN);

    public static NProperty CreateIsTabStop() => new NProperty(nameof(NProperties.IsTabStop)).
        Property<Control>(Control.IsTabStopProperty, NConverters.ToBool);

    public static NProperty CreateIsTapEnabled() => new NProperty(nameof(NProperties.IsTapEnabled)).
        Property<UIElement>(UIElement.IsTapEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsTextPredictionEnabled() => new NProperty(nameof(NProperties.IsTextPredictionEnabled)).
        Property<RichEditBox>(RichEditBox.IsTextPredictionEnabledProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.IsTextPredictionEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsTextScaleFactorEnabled() => new NProperty(nameof(NProperties.IsTextScaleFactorEnabled)).
        Property<ContentPresenter>(ContentPresenter.IsTextScaleFactorEnabledProperty, NConverters.ToBool).
        Property<RichTextBlock>(RichTextBlock.IsTextScaleFactorEnabledProperty, NConverters.ToBool).
        Property<TextBlock>(TextBlock.IsTextScaleFactorEnabledProperty, NConverters.ToBool).
        Property<FontIcon>(FontIcon.IsTextScaleFactorEnabledProperty, NConverters.ToBool).
        Property<Control>(Control.IsTextScaleFactorEnabledProperty, NConverters.ToBool).
        Property<TextElement>(TextElement.IsTextScaleFactorEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsTextSelectionEnabled() => new NProperty(nameof(NProperties.IsTextSelectionEnabled)).
        Property<RichTextBlock>(RichTextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool).
        Property<TextBlock>(TextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsThreeState() => new NProperty(nameof(NProperties.IsThreeState)).
        Property<ToggleButton>(ToggleButton.IsThreeStateProperty, NConverters.ToBool);

    public static NProperty CreateIsThumbToolTipEnabled() => new NProperty(nameof(NProperties.IsThumbToolTipEnabled)).
        Property<Slider>(Slider.IsThumbToolTipEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsTodayHighlighted() => new NProperty(nameof(NProperties.IsTodayHighlighted)).
        Property<CalendarView>(CalendarView.IsTodayHighlightedProperty, NConverters.ToBool).
        Property<CalendarDatePicker>(CalendarDatePicker.IsTodayHighlightedProperty, NConverters.ToBool);

    public static NProperty CreateIsVerticalRailEnabled() => new NProperty(nameof(NProperties.IsVerticalRailEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsVerticalRailEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsVerticalScrollChainingEnabled() => new NProperty(nameof(NProperties.IsVerticalScrollChainingEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsVerticalScrollChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsVolumeButtonVisible() => new NProperty(nameof(NProperties.IsVolumeButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsVolumeButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsVolumeEnabled() => new NProperty(nameof(NProperties.IsVolumeEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsVolumeEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomButtonVisible() => new NProperty(nameof(NProperties.IsZoomButtonVisible)).
        Property<MediaTransportControls>(MediaTransportControls.IsZoomButtonVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomChainingEnabled() => new NProperty(nameof(NProperties.IsZoomChainingEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsZoomChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomedInView() => new NProperty(nameof(NProperties.IsZoomedInView)).
        Property<ListViewBase>(ListViewBase.IsZoomedInViewProperty, NConverters.ToBool).
        Property<Hub>(Hub.IsZoomedInViewProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomedInViewActive() => new NProperty(nameof(NProperties.IsZoomedInViewActive)).
        Property<SemanticZoom>(SemanticZoom.IsZoomedInViewActiveProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomEnabled() => new NProperty(nameof(NProperties.IsZoomEnabled)).
        Property<MediaTransportControls>(MediaTransportControls.IsZoomEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomInertiaEnabled() => new NProperty(nameof(NProperties.IsZoomInertiaEnabled)).
        Property<ScrollViewer>(ScrollViewer.IsZoomInertiaEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsZoomOutButtonEnabled() => new NProperty(nameof(NProperties.IsZoomOutButtonEnabled)).
        Property<SemanticZoom>(SemanticZoom.IsZoomOutButtonEnabledProperty, NConverters.ToBool);

    public static NProperty CreateItemClick() => new NProperty(nameof(NProperties.ItemClick)).
        Event<ListViewBase>((s, a) => s.ItemClick += a.EventHandlerAny);

    public static NProperty CreateItemContainerStyle() => new NProperty(nameof(NProperties.ItemContainerStyle)).
        Property<ItemsControl>(ItemsControl.ItemContainerStyleProperty, NConverters.ToStyle);

    public static NProperty CreateItemContainerStyleSelector() => new NProperty(nameof(NProperties.ItemContainerStyleSelector)).
        Property<ItemsControl>(ItemsControl.ItemContainerStyleSelectorProperty);

    public static NProperty CreateItemContainerTransitions() => new NProperty(nameof(NProperties.ItemContainerTransitions)).
        Property<ItemsControl>((t, v) => NPatch.AssignListT(t.ItemContainerTransitions, v));

    public static NProperty CreateItemHeight() => new NProperty(nameof(NProperties.ItemHeight)).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.ItemHeightProperty, NConverters.ToDouble).
        Property<WrapGrid>(WrapGrid.ItemHeightProperty, NConverters.ToDouble).
        Property<ItemsWrapGrid>(ItemsWrapGrid.ItemHeightProperty, NConverters.ToDouble).
        Property<LoopingSelector>(LoopingSelector.ItemHeightProperty, NConverters.ToInt32);

    public static NProperty CreateItems() => new NProperty(nameof(NProperties.Items)).
        Property<ItemsControl>((t, v) => NPatch.AssignListT(t.Items, v)).
        Property<LoopingSelector>(LoopingSelector.ItemsProperty);

    public static NProperty CreateItemsPanel() => new NProperty(nameof(NProperties.ItemsPanel)).
        Property<ItemsControl>(ItemsControl.ItemsPanelProperty);

    public static NProperty CreateItemsSource() => new NProperty(nameof(NProperties.ItemsSource)).
        Property<ItemsControl>(ItemsControl.ItemsSourceProperty);

    public static NProperty CreateItemsUpdatingScrollMode() => new NProperty(nameof(NProperties.ItemsUpdatingScrollMode)).
        Property<ItemsStackPanel>((t, v) => t.ItemsUpdatingScrollMode = NConverters.ToEnumT<ItemsUpdatingScrollMode>(v));

    public static NProperty CreateItemTemplate() => new NProperty(nameof(NProperties.ItemTemplate)).
        Property<ItemsControl>(ItemsControl.ItemTemplateProperty, NConverters.ToDataTemplate).
        Property<LoopingSelector>(LoopingSelector.ItemTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateItemTemplateSelector() => new NProperty(nameof(NProperties.ItemTemplateSelector)).
        Property<ItemsControl>(ItemsControl.ItemTemplateSelectorProperty);

    public static NProperty CreateItemWidth() => new NProperty(nameof(NProperties.ItemWidth)).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.ItemWidthProperty, NConverters.ToDouble).
        Property<WrapGrid>(WrapGrid.ItemWidthProperty, NConverters.ToDouble).
        Property<ItemsWrapGrid>(ItemsWrapGrid.ItemWidthProperty, NConverters.ToDouble).
        Property<LoopingSelector>(LoopingSelector.ItemWidthProperty, NConverters.ToInt32);

    public static NProperty CreateKeyDown() => new NProperty(nameof(NProperties.KeyDown)).
        Event<UIElement>(UIElement.KeyDownEvent, a => (KeyEventHandler)a.EventHandlerAny);

    public static NProperty CreateKeyUp() => new NProperty(nameof(NProperties.KeyUp)).
        Event<UIElement>(UIElement.KeyUpEvent, a => (KeyEventHandler)a.EventHandlerAny);

    public static NProperty CreateLabel() => new NProperty(nameof(NProperties.Label)).
        Property<AppBarButton>(AppBarButton.LabelProperty, NConverters.ToString).
        Property<AppBarToggleButton>(AppBarToggleButton.LabelProperty, NConverters.ToString);

    public static NProperty CreateLandmarksVisible() => new NProperty(nameof(NProperties.LandmarksVisible)).
        Property<MapControl>(MapControl.LandmarksVisibleProperty, NConverters.ToBool);

    public static NProperty CreateLanguage() => new NProperty(nameof(NProperties.Language)).
        Property<FrameworkElement>(FrameworkElement.LanguageProperty, NConverters.ToString).
        Property<TextElement>(TextElement.LanguageProperty, NConverters.ToString);

    public static NProperty CreateLargeChange() => new NProperty(nameof(NProperties.LargeChange)).
        Property<RangeBase>(RangeBase.LargeChangeProperty, NConverters.ToDouble);

    public static NProperty CreateLayoutUpdated() => new NProperty(nameof(NProperties.LayoutUpdated)).
        Event<FrameworkElement>((s, a) => s.LayoutUpdated += a.EventHandlerAny);

    public static NProperty CreateLeftHeader() => new NProperty(nameof(NProperties.LeftHeader)).
        Property<ScrollViewer>(ScrollViewer.LeftHeaderProperty).
        Property<Pivot>(Pivot.LeftHeaderProperty);

    public static NProperty CreateLeftHeaderTemplate() => new NProperty(nameof(NProperties.LeftHeaderTemplate)).
        Property<Pivot>(Pivot.LeftHeaderTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateLineHeight() => new NProperty(nameof(NProperties.LineHeight)).
        Property<ContentPresenter>(ContentPresenter.LineHeightProperty, NConverters.ToDouble).
        Property<RichTextBlock>(RichTextBlock.LineHeightProperty, NConverters.ToDouble).
        Property<TextBlock>(TextBlock.LineHeightProperty, NConverters.ToDouble).
        Property<Block>(Block.LineHeightProperty, NConverters.ToDouble);

    public static NProperty CreateLineStackingStrategy() => new NProperty(nameof(NProperties.LineStackingStrategy)).
        Property<ContentPresenter>(ContentPresenter.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<RichTextBlock>(RichTextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<TextBlock>(TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<Block>(Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);

    public static NProperty CreateListViewItemPresenterHorizontalContentAlignment() => new NProperty(nameof(NProperties.ListViewItemPresenterHorizontalContentAlignment)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.ListViewItemPresenterHorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateListViewItemPresenterPadding() => new NProperty(nameof(NProperties.ListViewItemPresenterPadding)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.ListViewItemPresenterPaddingProperty, NConverters.ToThickness);

    public static NProperty CreateListViewItemPresenterVerticalContentAlignment() => new NProperty(nameof(NProperties.ListViewItemPresenterVerticalContentAlignment)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.ListViewItemPresenterVerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateLoadCompleted() => new NProperty(nameof(NProperties.LoadCompleted)).
        Event<WebView>((s, a) => s.LoadCompleted += a.EventHandlerAny);

    public static NProperty CreateLoaded() => new NProperty(nameof(NProperties.Loaded)).
        Event<FrameworkElement>((s, a) => s.Loaded += a.EventHandlerAny);

    public static NProperty CreateLostFocus() => new NProperty(nameof(NProperties.LostFocus)).
        Event<UIElement>((s, a) => s.LostFocus += a.EventHandlerAny);

    public static NProperty CreateManipulationCompleted() => new NProperty(nameof(NProperties.ManipulationCompleted)).
        Event<UIElement>(UIElement.ManipulationCompletedEvent, a => (ManipulationCompletedEventHandler)a.EventHandlerAny);

    public static NProperty CreateManipulationDelta() => new NProperty(nameof(NProperties.ManipulationDelta)).
        Event<UIElement>(UIElement.ManipulationDeltaEvent, a => (ManipulationDeltaEventHandler)a.EventHandlerAny);

    public static NProperty CreateManipulationInertiaStarting() => new NProperty(nameof(NProperties.ManipulationInertiaStarting)).
        Event<UIElement>(UIElement.ManipulationInertiaStartingEvent, a => (ManipulationInertiaStartingEventHandler)a.EventHandlerAny);

    public static NProperty CreateManipulationMode() => new NProperty(nameof(NProperties.ManipulationMode)).
        Property<UIElement>(UIElement.ManipulationModeProperty, NConverters.ToEnum<ManipulationModes>);

    public static NProperty CreateManipulationStarted() => new NProperty(nameof(NProperties.ManipulationStarted)).
        Event<UIElement>(UIElement.ManipulationStartedEvent, a => (ManipulationStartedEventHandler)a.EventHandlerAny);

    public static NProperty CreateManipulationStarting() => new NProperty(nameof(NProperties.ManipulationStarting)).
        Event<UIElement>(UIElement.ManipulationStartingEvent, a => (ManipulationStartingEventHandler)a.EventHandlerAny);

    public static NProperty CreateMapControlLocation() => new NProperty(nameof(NProperties.MapControlLocation)).
        Property<DependencyObject>(MapControl.LocationProperty);

    public static NProperty CreateMapControlNormalizedAnchorPoint() => new NProperty(nameof(NProperties.MapControlNormalizedAnchorPoint)).
        Property<DependencyObject>(MapControl.NormalizedAnchorPointProperty, NConverters.ToPoint);

    public static NProperty CreateMapServiceToken() => new NProperty(nameof(NProperties.MapServiceToken)).
        Property<MapControl>(MapControl.MapServiceTokenProperty, NConverters.ToString);

    public static NProperty CreateMargin() => new NProperty(nameof(NProperties.Margin)).
        Property<FrameworkElement>(FrameworkElement.MarginProperty, NConverters.ToThickness).
        Property<Block>(Block.MarginProperty, NConverters.ToThickness);

    public static NProperty CreateMarkerReached() => new NProperty(nameof(NProperties.MarkerReached)).
        Event<MediaElement>((s, a) => s.MarkerReached += a.EventHandlerAny);

    public static NProperty CreateMarkers() => new NProperty(nameof(NProperties.Markers)).
        Property<MediaElement>((t, v) => NPatch.AssignListT(t.Markers, v));

    public static NProperty CreateMaxDate() => new NProperty(nameof(NProperties.MaxDate)).
        Property<CalendarView>(CalendarView.MaxDateProperty, NConverters.ToDateTimeOffset).
        Property<CalendarDatePicker>(CalendarDatePicker.MaxDateProperty, NConverters.ToDateTimeOffset);

    public static NProperty CreateMaxDropDownHeight() => new NProperty(nameof(NProperties.MaxDropDownHeight)).
        Property<ComboBox>(ComboBox.MaxDropDownHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMaxHeight() => new NProperty(nameof(NProperties.MaxHeight)).
        Property<FrameworkElement>(FrameworkElement.MaxHeightProperty, NConverters.ToDouble).
        Property<RowDefinition>(RowDefinition.MaxHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMaximum() => new NProperty(nameof(NProperties.Maximum)).
        Property<RangeBase>(RangeBase.MaximumProperty, NConverters.ToDouble);

    public static NProperty CreateMaximumRowsOrColumns() => new NProperty(nameof(NProperties.MaximumRowsOrColumns)).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32).
        Property<WrapGrid>(WrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32).
        Property<ItemsWrapGrid>(ItemsWrapGrid.MaximumRowsOrColumnsProperty, NConverters.ToInt32);

    public static NProperty CreateMaxLength() => new NProperty(nameof(NProperties.MaxLength)).
        Property<PasswordBox>(PasswordBox.MaxLengthProperty, NConverters.ToInt32).
        Property<TextBox>(TextBox.MaxLengthProperty, NConverters.ToInt32);

    public static NProperty CreateMaxLines() => new NProperty(nameof(NProperties.MaxLines)).
        Property<ContentPresenter>(ContentPresenter.MaxLinesProperty, NConverters.ToInt32).
        Property<RichTextBlockOverflow>(RichTextBlockOverflow.MaxLinesProperty, NConverters.ToInt32).
        Property<RichTextBlock>(RichTextBlock.MaxLinesProperty, NConverters.ToInt32).
        Property<TextBlock>(TextBlock.MaxLinesProperty, NConverters.ToInt32);

    public static NProperty CreateMaxSuggestionListHeight() => new NProperty(nameof(NProperties.MaxSuggestionListHeight)).
        Property<AutoSuggestBox>(AutoSuggestBox.MaxSuggestionListHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMaxWidth() => new NProperty(nameof(NProperties.MaxWidth)).
        Property<FrameworkElement>(FrameworkElement.MaxWidthProperty, NConverters.ToDouble).
        Property<ColumnDefinition>(ColumnDefinition.MaxWidthProperty, NConverters.ToDouble);

    public static NProperty CreateMaxYear() => new NProperty(nameof(NProperties.MaxYear)).
        Property<DatePicker>(DatePicker.MaxYearProperty, NConverters.ToDateTimeOffset);

    public static NProperty CreateMaxZoomFactor() => new NProperty(nameof(NProperties.MaxZoomFactor)).
        Property<ScrollViewer>(ScrollViewer.MaxZoomFactorProperty, NConverters.ToSingle);

    public static NProperty CreateMediaEnded() => new NProperty(nameof(NProperties.MediaEnded)).
        Event<MediaElement>((s, a) => s.MediaEnded += a.EventHandlerAny);

    public static NProperty CreateMediaFailed() => new NProperty(nameof(NProperties.MediaFailed)).
        Event<MediaElement>((s, a) => s.MediaFailed += a.EventHandlerAny);

    public static NProperty CreateMediaOpened() => new NProperty(nameof(NProperties.MediaOpened)).
        Event<MediaElement>((s, a) => s.MediaOpened += a.EventHandlerAny);

    public static NProperty CreateMinDate() => new NProperty(nameof(NProperties.MinDate)).
        Property<CalendarView>(CalendarView.MinDateProperty, NConverters.ToDateTimeOffset).
        Property<CalendarDatePicker>(CalendarDatePicker.MinDateProperty, NConverters.ToDateTimeOffset);

    public static NProperty CreateMinHeight() => new NProperty(nameof(NProperties.MinHeight)).
        Property<FrameworkElement>(FrameworkElement.MinHeightProperty, NConverters.ToDouble).
        Property<RowDefinition>(RowDefinition.MinHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMinimum() => new NProperty(nameof(NProperties.Minimum)).
        Property<RangeBase>(RangeBase.MinimumProperty, NConverters.ToDouble);

    public static NProperty CreateMinuteIncrement() => new NProperty(nameof(NProperties.MinuteIncrement)).
        Property<TimePicker>(TimePicker.MinuteIncrementProperty, NConverters.ToInt32);

    public static NProperty CreateMinWidth() => new NProperty(nameof(NProperties.MinWidth)).
        Property<FrameworkElement>(FrameworkElement.MinWidthProperty, NConverters.ToDouble).
        Property<ColumnDefinition>(ColumnDefinition.MinWidthProperty, NConverters.ToDouble);

    public static NProperty CreateMinYear() => new NProperty(nameof(NProperties.MinYear)).
        Property<DatePicker>(DatePicker.MinYearProperty, NConverters.ToDateTimeOffset);

    public static NProperty CreateMinZoomFactor() => new NProperty(nameof(NProperties.MinZoomFactor)).
        Property<ScrollViewer>(ScrollViewer.MinZoomFactorProperty, NConverters.ToSingle);

    public static NProperty CreateMirroredWhenRightToLeft() => new NProperty(nameof(NProperties.MirroredWhenRightToLeft)).
        Property<FontIcon>(FontIcon.MirroredWhenRightToLeftProperty, NConverters.ToBool);

    public static NProperty CreateMonthFormat() => new NProperty(nameof(NProperties.MonthFormat)).
        Property<DatePicker>(DatePicker.MonthFormatProperty, NConverters.ToString);

    public static NProperty CreateMonthVisible() => new NProperty(nameof(NProperties.MonthVisible)).
        Property<DatePicker>(DatePicker.MonthVisibleProperty, NConverters.ToBool);

    public static NProperty CreateMonthYearItemFontFamily() => new NProperty(nameof(NProperties.MonthYearItemFontFamily)).
        Property<CalendarView>(CalendarView.MonthYearItemFontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateMonthYearItemFontSize() => new NProperty(nameof(NProperties.MonthYearItemFontSize)).
        Property<CalendarView>(CalendarView.MonthYearItemFontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateMonthYearItemFontStyle() => new NProperty(nameof(NProperties.MonthYearItemFontStyle)).
        Property<CalendarView>(CalendarView.MonthYearItemFontStyleProperty, NConverters.ToEnum<FontStyle>);

    public static NProperty CreateMonthYearItemFontWeight() => new NProperty(nameof(NProperties.MonthYearItemFontWeight)).
        Property<CalendarView>(CalendarView.MonthYearItemFontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateName() => new NProperty(nameof(NProperties.Name)).
        Property<FrameworkElement>(FrameworkElement.NameProperty, NConverters.ToString);

    public static NProperty CreateNavigated() => new NProperty(nameof(NProperties.Navigated)).
        Event<Frame>((s, a) => s.Navigated += a.EventHandlerAny);

    public static NProperty CreateNavigateUri() => new NProperty(nameof(NProperties.NavigateUri)).
        Property<HyperlinkButton>(HyperlinkButton.NavigateUriProperty, NConverters.ToUri).
        Property<Hyperlink>(Hyperlink.NavigateUriProperty, NConverters.ToUri);

    public static NProperty CreateNavigating() => new NProperty(nameof(NProperties.Navigating)).
        Event<Frame>((s, a) => s.Navigating += a.EventHandlerAny);

    public static NProperty CreateNavigationCacheMode() => new NProperty(nameof(NProperties.NavigationCacheMode)).
        Property<Page>((t, v) => t.NavigationCacheMode = NConverters.ToEnumT<NavigationCacheMode>(v));

    public static NProperty CreateNavigationFailed() => new NProperty(nameof(NProperties.NavigationFailed)).
        Event<WebView>((s, a) => s.NavigationFailed += a.EventHandlerAny).
        Event<Frame>((s, a) => s.NavigationFailed += a.EventHandlerAny);

    public static NProperty CreateNavigationStopped() => new NProperty(nameof(NProperties.NavigationStopped)).
        Event<Frame>((s, a) => s.NavigationStopped += a.EventHandlerAny);

    public static NProperty CreateNineGrid() => new NProperty(nameof(NProperties.NineGrid)).
        Property<Image>(Image.NineGridProperty, NConverters.ToThickness);

    public static NProperty CreateNumberOfWeeksInView() => new NProperty(nameof(NProperties.NumberOfWeeksInView)).
        Property<CalendarView>(CalendarView.NumberOfWeeksInViewProperty, NConverters.ToInt32);

    public static NProperty CreateOffContent() => new NProperty(nameof(NProperties.OffContent)).
        Property<ToggleSwitch>(ToggleSwitch.OffContentProperty);

    public static NProperty CreateOffContentTemplate() => new NProperty(nameof(NProperties.OffContentTemplate)).
        Property<ToggleSwitch>(ToggleSwitch.OffContentTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateOnContent() => new NProperty(nameof(NProperties.OnContent)).
        Property<ToggleSwitch>(ToggleSwitch.OnContentProperty);

    public static NProperty CreateOnContentTemplate() => new NProperty(nameof(NProperties.OnContentTemplate)).
        Property<ToggleSwitch>(ToggleSwitch.OnContentTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateOpacity() => new NProperty(nameof(NProperties.Opacity)).
        Property<UIElement>(UIElement.OpacityProperty, NConverters.ToDouble);

    public static NProperty CreateOpened() => new NProperty(nameof(NProperties.Opened)).
        Event<Popup>((s, a) => s.Opened += a.EventHandlerAny).
        Event<ToolTip>((s, a) => s.Opened += a.EventHandlerAny).
        Event<AppBar>((s, a) => s.Opened += a.EventHandlerAny).
        Event<CalendarDatePicker>((s, a) => s.Opened += a.EventHandlerAny);

    public static NProperty CreateOpening() => new NProperty(nameof(NProperties.Opening)).
        Event<AppBar>((s, a) => s.Opening += a.EventHandlerAny);

    public static NProperty CreateOpenPaneLength() => new NProperty(nameof(NProperties.OpenPaneLength)).
        Property<SplitView>(SplitView.OpenPaneLengthProperty, NConverters.ToDouble);

    public static NProperty CreateOpticalMarginAlignment() => new NProperty(nameof(NProperties.OpticalMarginAlignment)).
        Property<ContentPresenter>(ContentPresenter.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>).
        Property<RichTextBlock>(RichTextBlock.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>).
        Property<TextBlock>(TextBlock.OpticalMarginAlignmentProperty, NConverters.ToEnum<OpticalMarginAlignment>);

    public static NProperty CreateOrientation() => new NProperty(nameof(NProperties.Orientation)).
        Property<StackPanel>(StackPanel.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<VirtualizingStackPanel>(VirtualizingStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<WrapGrid>(WrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<ItemsStackPanel>(ItemsStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<ItemsWrapGrid>(ItemsWrapGrid.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<Slider>(Slider.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<ScrollBar>(ScrollBar.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<DatePicker>(DatePicker.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<Hub>(Hub.OrientationProperty, NConverters.ToEnum<Orientation>);

    public static NProperty CreateOriginX() => new NProperty(nameof(NProperties.OriginX)).
        Property<Glyphs>(Glyphs.OriginXProperty, NConverters.ToDouble);

    public static NProperty CreateOriginY() => new NProperty(nameof(NProperties.OriginY)).
        Property<Glyphs>(Glyphs.OriginYProperty, NConverters.ToDouble);

    public static NProperty CreateOutOfScopeBackground() => new NProperty(nameof(NProperties.OutOfScopeBackground)).
        Property<CalendarView>(CalendarView.OutOfScopeBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateOutOfScopeForeground() => new NProperty(nameof(NProperties.OutOfScopeForeground)).
        Property<CalendarView>(CalendarView.OutOfScopeForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateOverflowContentTarget() => new NProperty(nameof(NProperties.OverflowContentTarget)).
        Property<RichTextBlockOverflow>(RichTextBlockOverflow.OverflowContentTargetProperty).
        Property<RichTextBlock>(RichTextBlock.OverflowContentTargetProperty);

    public static NProperty CreatePadding() => new NProperty(nameof(NProperties.Padding)).
        Property<Grid>(Grid.PaddingProperty, NConverters.ToThickness).
        Property<RelativePanel>(RelativePanel.PaddingProperty, NConverters.ToThickness).
        Property<StackPanel>(StackPanel.PaddingProperty, NConverters.ToThickness).
        Property<Border>(Border.PaddingProperty, NConverters.ToThickness).
        Property<ContentPresenter>(ContentPresenter.PaddingProperty, NConverters.ToThickness).
        Property<ItemsPresenter>(ItemsPresenter.PaddingProperty, NConverters.ToThickness).
        Property<RichTextBlockOverflow>(RichTextBlockOverflow.PaddingProperty, NConverters.ToThickness).
        Property<RichTextBlock>(RichTextBlock.PaddingProperty, NConverters.ToThickness).
        Property<TextBlock>(TextBlock.PaddingProperty, NConverters.ToThickness).
        Property<Control>(Control.PaddingProperty, NConverters.ToThickness);

    public static NProperty CreatePane() => new NProperty(nameof(NProperties.Pane)).
        Property<SplitView>(SplitView.PaneProperty);

    public static NProperty CreatePaneBackground() => new NProperty(nameof(NProperties.PaneBackground)).
        Property<SplitView>(SplitView.PaneBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreatePanePlacement() => new NProperty(nameof(NProperties.PanePlacement)).
        Property<SplitView>(SplitView.PanePlacementProperty, NConverters.ToEnum<SplitViewPanePlacement>);

    public static NProperty CreatePanInteractionMode() => new NProperty(nameof(NProperties.PanInteractionMode)).
        Property<MapControl>(MapControl.PanInteractionModeProperty, NConverters.ToEnum<MapPanInteractionMode>);

    public static NProperty CreatePassword() => new NProperty(nameof(NProperties.Password)).
        Property<PasswordBox>(PasswordBox.PasswordProperty, NConverters.ToString);

    public static NProperty CreatePasswordChanged() => new NProperty(nameof(NProperties.PasswordChanged)).
        Event<PasswordBox>((s, a) => s.PasswordChanged += a.EventHandlerAny);

    public static NProperty CreatePasswordChar() => new NProperty(nameof(NProperties.PasswordChar)).
        Property<PasswordBox>(PasswordBox.PasswordCharProperty, NConverters.ToString);

    public static NProperty CreatePasswordRevealMode() => new NProperty(nameof(NProperties.PasswordRevealMode)).
        Property<PasswordBox>(PasswordBox.PasswordRevealModeProperty, NConverters.ToEnum<PasswordRevealMode>);

    public static NProperty CreatePaste() => new NProperty(nameof(NProperties.Paste)).
        Event<PasswordBox>((s, a) => s.Paste += a.EventHandlerAny).
        Event<RichEditBox>((s, a) => s.Paste += a.EventHandlerAny).
        Event<TextBox>((s, a) => s.Paste += a.EventHandlerAny);

    public static NProperty CreatePedestrianFeaturesVisible() => new NProperty(nameof(NProperties.PedestrianFeaturesVisible)).
        Property<MapControl>(MapControl.PedestrianFeaturesVisibleProperty, NConverters.ToBool);

    public static NProperty CreatePivotSlideInAnimationGroup() => new NProperty(nameof(NProperties.PivotSlideInAnimationGroup)).
        Property<FrameworkElement>(Pivot.SlideInAnimationGroupProperty, NConverters.ToEnum<PivotSlideInAnimationGroup>);

    public static NProperty CreatePlaceholderBackground() => new NProperty(nameof(NProperties.PlaceholderBackground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.PlaceholderBackgroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.PlaceholderBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreatePlaceholderText() => new NProperty(nameof(NProperties.PlaceholderText)).
        Property<ComboBox>(ComboBox.PlaceholderTextProperty, NConverters.ToString).
        Property<AutoSuggestBox>(AutoSuggestBox.PlaceholderTextProperty, NConverters.ToString).
        Property<PasswordBox>(PasswordBox.PlaceholderTextProperty, NConverters.ToString).
        Property<RichEditBox>(RichEditBox.PlaceholderTextProperty, NConverters.ToString).
        Property<TextBox>(TextBox.PlaceholderTextProperty, NConverters.ToString).
        Property<CalendarDatePicker>(CalendarDatePicker.PlaceholderTextProperty, NConverters.ToString).
        Property<SearchBox>(SearchBox.PlaceholderTextProperty, NConverters.ToString);

    public static NProperty CreatePlacement() => new NProperty(nameof(NProperties.Placement)).
        Property<ToolTip>(ToolTip.PlacementProperty, NConverters.ToEnum<PlacementMode>);

    public static NProperty CreatePlacementTarget() => new NProperty(nameof(NProperties.PlacementTarget)).
        Property<ToolTip>(ToolTip.PlacementTargetProperty);

    public static NProperty CreatePlaybackRate() => new NProperty(nameof(NProperties.PlaybackRate)).
        Property<MediaElement>(MediaElement.PlaybackRateProperty, NConverters.ToDouble);

    public static NProperty CreatePlayToPreferredSourceUri() => new NProperty(nameof(NProperties.PlayToPreferredSourceUri)).
        Property<MediaElement>(MediaElement.PlayToPreferredSourceUriProperty, NConverters.ToUri);

    public static NProperty CreatePointerCanceled() => new NProperty(nameof(NProperties.PointerCanceled)).
        Event<UIElement>(UIElement.PointerCanceledEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerCaptureLost() => new NProperty(nameof(NProperties.PointerCaptureLost)).
        Event<UIElement>(UIElement.PointerCaptureLostEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerEntered() => new NProperty(nameof(NProperties.PointerEntered)).
        Event<UIElement>(UIElement.PointerEnteredEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerExited() => new NProperty(nameof(NProperties.PointerExited)).
        Event<UIElement>(UIElement.PointerExitedEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerMoved() => new NProperty(nameof(NProperties.PointerMoved)).
        Event<UIElement>(UIElement.PointerMovedEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerOverBackground() => new NProperty(nameof(NProperties.PointerOverBackground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.PointerOverBackgroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.PointerOverBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreatePointerOverBackgroundMargin() => new NProperty(nameof(NProperties.PointerOverBackgroundMargin)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.PointerOverBackgroundMarginProperty, NConverters.ToThickness).
        Property<ListViewItemPresenter>(ListViewItemPresenter.PointerOverBackgroundMarginProperty, NConverters.ToThickness);

    public static NProperty CreatePointerOverForeground() => new NProperty(nameof(NProperties.PointerOverForeground)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.PointerOverForegroundProperty, NConverters.ToBrush);

    public static NProperty CreatePointerPressed() => new NProperty(nameof(NProperties.PointerPressed)).
        Event<UIElement>(UIElement.PointerPressedEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerReleased() => new NProperty(nameof(NProperties.PointerReleased)).
        Event<UIElement>(UIElement.PointerReleasedEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePointerWheelChanged() => new NProperty(nameof(NProperties.PointerWheelChanged)).
        Event<UIElement>(UIElement.PointerWheelChangedEvent, a => (PointerEventHandler)a.EventHandlerAny);

    public static NProperty CreatePoints() => new NProperty(nameof(NProperties.Points)).
        Property<Polygon>((t, v) => NPatch.AssignListT(t.Points, v)).
        Property<Polyline>((t, v) => NPatch.AssignListT(t.Points, v));

    public static NProperty CreatePosition() => new NProperty(nameof(NProperties.Position)).
        Property<MediaElement>(MediaElement.PositionProperty, NConverters.ToTimeSpan);

    public static NProperty CreatePosterSource() => new NProperty(nameof(NProperties.PosterSource)).
        Property<MediaElement>(MediaElement.PosterSourceProperty);

    public static NProperty CreatePressedBackground() => new NProperty(nameof(NProperties.PressedBackground)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.PressedBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreatePressedBorderBrush() => new NProperty(nameof(NProperties.PressedBorderBrush)).
        Property<CalendarView>(CalendarView.PressedBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreatePressedForeground() => new NProperty(nameof(NProperties.PressedForeground)).
        Property<CalendarView>(CalendarView.PressedForegroundProperty, NConverters.ToBrush);

    public static NProperty CreatePreventKeyboardDisplayOnProgrammaticFocus() => new NProperty(nameof(NProperties.PreventKeyboardDisplayOnProgrammaticFocus)).
        Property<PasswordBox>(PasswordBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool).
        Property<RichEditBox>(RichEditBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool).
        Property<TextBox>(TextBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, NConverters.ToBool);

    public static NProperty CreatePrimaryButtonCommand() => new NProperty(nameof(NProperties.PrimaryButtonCommand)).
        Property<ContentDialog>(ContentDialog.PrimaryButtonCommandProperty);

    public static NProperty CreatePrimaryButtonCommandParameter() => new NProperty(nameof(NProperties.PrimaryButtonCommandParameter)).
        Property<ContentDialog>(ContentDialog.PrimaryButtonCommandParameterProperty);

    public static NProperty CreatePrimaryButtonText() => new NProperty(nameof(NProperties.PrimaryButtonText)).
        Property<ContentDialog>(ContentDialog.PrimaryButtonTextProperty, NConverters.ToString);

    public static NProperty CreatePrimaryCommands() => new NProperty(nameof(NProperties.PrimaryCommands)).
        Property<CommandBar>((t, v) => NPatch.AssignListT(t.PrimaryCommands, v));

    public static NProperty CreateProjection() => new NProperty(nameof(NProperties.Projection)).
        Property<UIElement>(UIElement.ProjectionProperty);

    public static NProperty CreateProtectionManager() => new NProperty(nameof(NProperties.ProtectionManager)).
        Property<MediaElement>(MediaElement.ProtectionManagerProperty);

    public static NProperty CreateQueryIcon() => new NProperty(nameof(NProperties.QueryIcon)).
        Property<AutoSuggestBox>(AutoSuggestBox.QueryIconProperty);

    public static NProperty CreateQueryText() => new NProperty(nameof(NProperties.QueryText)).
        Property<SearchBox>(SearchBox.QueryTextProperty, NConverters.ToString);

    public static NProperty CreateRadiusX() => new NProperty(nameof(NProperties.RadiusX)).
        Property<Rectangle>(Rectangle.RadiusXProperty, NConverters.ToDouble);

    public static NProperty CreateRadiusY() => new NProperty(nameof(NProperties.RadiusY)).
        Property<Rectangle>(Rectangle.RadiusYProperty, NConverters.ToDouble);

    public static NProperty CreateRateChanged() => new NProperty(nameof(NProperties.RateChanged)).
        Event<MediaElement>((s, a) => s.RateChanged += a.EventHandlerAny);

    public static NProperty CreateRealTimePlayback() => new NProperty(nameof(NProperties.RealTimePlayback)).
        Property<MediaElement>(MediaElement.RealTimePlaybackProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAbove() => new NProperty(nameof(NProperties.RelativePanelAbove)).
        Property<UIElement>(RelativePanel.AboveProperty);

    public static NProperty CreateRelativePanelAlignBottomWith() => new NProperty(nameof(NProperties.RelativePanelAlignBottomWith)).
        Property<UIElement>(RelativePanel.AlignBottomWithProperty);

    public static NProperty CreateRelativePanelAlignBottomWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignBottomWithPanel)).
        Property<UIElement>(RelativePanel.AlignBottomWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAlignHorizontalCenterWith() => new NProperty(nameof(NProperties.RelativePanelAlignHorizontalCenterWith)).
        Property<UIElement>(RelativePanel.AlignHorizontalCenterWithProperty);

    public static NProperty CreateRelativePanelAlignHorizontalCenterWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignHorizontalCenterWithPanel)).
        Property<UIElement>(RelativePanel.AlignHorizontalCenterWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAlignLeftWith() => new NProperty(nameof(NProperties.RelativePanelAlignLeftWith)).
        Property<UIElement>(RelativePanel.AlignLeftWithProperty);

    public static NProperty CreateRelativePanelAlignLeftWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignLeftWithPanel)).
        Property<UIElement>(RelativePanel.AlignLeftWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAlignRightWith() => new NProperty(nameof(NProperties.RelativePanelAlignRightWith)).
        Property<UIElement>(RelativePanel.AlignRightWithProperty);

    public static NProperty CreateRelativePanelAlignRightWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignRightWithPanel)).
        Property<UIElement>(RelativePanel.AlignRightWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAlignTopWith() => new NProperty(nameof(NProperties.RelativePanelAlignTopWith)).
        Property<UIElement>(RelativePanel.AlignTopWithProperty);

    public static NProperty CreateRelativePanelAlignTopWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignTopWithPanel)).
        Property<UIElement>(RelativePanel.AlignTopWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelAlignVerticalCenterWith() => new NProperty(nameof(NProperties.RelativePanelAlignVerticalCenterWith)).
        Property<UIElement>(RelativePanel.AlignVerticalCenterWithProperty);

    public static NProperty CreateRelativePanelAlignVerticalCenterWithPanel() => new NProperty(nameof(NProperties.RelativePanelAlignVerticalCenterWithPanel)).
        Property<UIElement>(RelativePanel.AlignVerticalCenterWithPanelProperty, NConverters.ToBool);

    public static NProperty CreateRelativePanelBelow() => new NProperty(nameof(NProperties.RelativePanelBelow)).
        Property<UIElement>(RelativePanel.BelowProperty);

    public static NProperty CreateRelativePanelLeftOf() => new NProperty(nameof(NProperties.RelativePanelLeftOf)).
        Property<UIElement>(RelativePanel.LeftOfProperty);

    public static NProperty CreateRelativePanelRightOf() => new NProperty(nameof(NProperties.RelativePanelRightOf)).
        Property<UIElement>(RelativePanel.RightOfProperty);

    public static NProperty CreateRenderTransform() => new NProperty(nameof(NProperties.RenderTransform)).
        Property<UIElement>(UIElement.RenderTransformProperty);

    public static NProperty CreateRenderTransformOrigin() => new NProperty(nameof(NProperties.RenderTransformOrigin)).
        Property<UIElement>(UIElement.RenderTransformOriginProperty, NConverters.ToPoint);

    public static NProperty CreateReorderHintOffset() => new NProperty(nameof(NProperties.ReorderHintOffset)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.ReorderHintOffsetProperty, NConverters.ToDouble).
        Property<ListViewItemPresenter>(ListViewItemPresenter.ReorderHintOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateReorderMode() => new NProperty(nameof(NProperties.ReorderMode)).
        Property<ListViewBase>(ListViewBase.ReorderModeProperty, NConverters.ToEnum<ListViewReorderMode>);

    public static NProperty CreateRequestedTheme() => new NProperty(nameof(NProperties.RequestedTheme)).
        Property<FrameworkElement>(FrameworkElement.RequestedThemeProperty, NConverters.ToEnum<ElementTheme>);

    public static NProperty CreateResources() => new NProperty(nameof(NProperties.Resources)).
        Property<FrameworkElement>((t, v) => t.Resources = NConverters.ToResourceDictionaryT(v));

    public static NProperty CreateRightHeader() => new NProperty(nameof(NProperties.RightHeader)).
        Property<Pivot>(Pivot.RightHeaderProperty);

    public static NProperty CreateRightHeaderTemplate() => new NProperty(nameof(NProperties.RightHeaderTemplate)).
        Property<Pivot>(Pivot.RightHeaderTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateRightTapped() => new NProperty(nameof(NProperties.RightTapped)).
        Event<UIElement>(UIElement.RightTappedEvent, a => (RightTappedEventHandler)a.EventHandlerAny);

    public static NProperty CreateRotateInteractionMode() => new NProperty(nameof(NProperties.RotateInteractionMode)).
        Property<MapControl>(MapControl.RotateInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);

    public static NProperty CreateRowDefinitions() => new NProperty(nameof(NProperties.RowDefinitions)).
        Property<Grid>((t, v) => NPatch.AssignListT(t.RowDefinitions, v));

    public static NProperty CreateScene() => new NProperty(nameof(NProperties.Scene)).
        Property<MapControl>(MapControl.SceneProperty);

    public static NProperty CreateScriptNotify() => new NProperty(nameof(NProperties.ScriptNotify)).
        Event<WebView>((s, a) => s.ScriptNotify += a.EventHandlerAny);

    public static NProperty CreateScroll() => new NProperty(nameof(NProperties.Scroll)).
        Event<ScrollBar>((s, a) => s.Scroll += a.EventHandlerAny);

    public static NProperty CreateScrollViewerBringIntoViewOnFocusChange() => new NProperty(nameof(NProperties.ScrollViewerBringIntoViewOnFocusChange)).
        Property<DependencyObject>(ScrollViewer.BringIntoViewOnFocusChangeProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerHorizontalScrollBarVisibility() => new NProperty(nameof(NProperties.ScrollViewerHorizontalScrollBarVisibility)).
        Property<DependencyObject>(ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateScrollViewerHorizontalScrollMode() => new NProperty(nameof(NProperties.ScrollViewerHorizontalScrollMode)).
        Property<DependencyObject>(ScrollViewer.HorizontalScrollModeProperty, NConverters.ToEnum<ScrollMode>);

    public static NProperty CreateScrollViewerIsDeferredScrollingEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsDeferredScrollingEnabled)).
        Property<DependencyObject>(ScrollViewer.IsDeferredScrollingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsHorizontalRailEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsHorizontalRailEnabled)).
        Property<DependencyObject>(ScrollViewer.IsHorizontalRailEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsHorizontalScrollChainingEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsHorizontalScrollChainingEnabled)).
        Property<DependencyObject>(ScrollViewer.IsHorizontalScrollChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsScrollInertiaEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsScrollInertiaEnabled)).
        Property<DependencyObject>(ScrollViewer.IsScrollInertiaEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsVerticalRailEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsVerticalRailEnabled)).
        Property<DependencyObject>(ScrollViewer.IsVerticalRailEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsVerticalScrollChainingEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsVerticalScrollChainingEnabled)).
        Property<DependencyObject>(ScrollViewer.IsVerticalScrollChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsZoomChainingEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsZoomChainingEnabled)).
        Property<DependencyObject>(ScrollViewer.IsZoomChainingEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerIsZoomInertiaEnabled() => new NProperty(nameof(NProperties.ScrollViewerIsZoomInertiaEnabled)).
        Property<DependencyObject>(ScrollViewer.IsZoomInertiaEnabledProperty, NConverters.ToBool);

    public static NProperty CreateScrollViewerVerticalScrollBarVisibility() => new NProperty(nameof(NProperties.ScrollViewerVerticalScrollBarVisibility)).
        Property<DependencyObject>(ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateScrollViewerVerticalScrollMode() => new NProperty(nameof(NProperties.ScrollViewerVerticalScrollMode)).
        Property<DependencyObject>(ScrollViewer.VerticalScrollModeProperty, NConverters.ToEnum<ScrollMode>);

    public static NProperty CreateScrollViewerZoomMode() => new NProperty(nameof(NProperties.ScrollViewerZoomMode)).
        Property<DependencyObject>(ScrollViewer.ZoomModeProperty, NConverters.ToEnum<ZoomMode>);

    public static NProperty CreateSearchHistoryContext() => new NProperty(nameof(NProperties.SearchHistoryContext)).
        Property<SearchBox>(SearchBox.SearchHistoryContextProperty, NConverters.ToString);

    public static NProperty CreateSearchHistoryEnabled() => new NProperty(nameof(NProperties.SearchHistoryEnabled)).
        Property<SearchBox>(SearchBox.SearchHistoryEnabledProperty, NConverters.ToBool);

    public static NProperty CreateSecondaryButtonCommand() => new NProperty(nameof(NProperties.SecondaryButtonCommand)).
        Property<ContentDialog>(ContentDialog.SecondaryButtonCommandProperty);

    public static NProperty CreateSecondaryButtonCommandParameter() => new NProperty(nameof(NProperties.SecondaryButtonCommandParameter)).
        Property<ContentDialog>(ContentDialog.SecondaryButtonCommandParameterProperty);

    public static NProperty CreateSecondaryButtonText() => new NProperty(nameof(NProperties.SecondaryButtonText)).
        Property<ContentDialog>(ContentDialog.SecondaryButtonTextProperty, NConverters.ToString);

    public static NProperty CreateSecondaryCommands() => new NProperty(nameof(NProperties.SecondaryCommands)).
        Property<CommandBar>((t, v) => NPatch.AssignListT(t.SecondaryCommands, v));

    public static NProperty CreateSectionHeaderClick() => new NProperty(nameof(NProperties.SectionHeaderClick)).
        Event<Hub>((s, a) => s.SectionHeaderClick += a.EventHandlerAny);

    public static NProperty CreateSectionHeaders() => new NProperty(nameof(NProperties.SectionHeaders)).
        Property<Hub>((t, v) => NPatch.AssignListT(t.SectionHeaders, v));

    public static NProperty CreateSectionsInViewChanged() => new NProperty(nameof(NProperties.SectionsInViewChanged)).
        Event<Hub>((s, a) => s.SectionsInViewChanged += a.EventHandlerAny);

    public static NProperty CreateSeekCompleted() => new NProperty(nameof(NProperties.SeekCompleted)).
        Event<MediaElement>((s, a) => s.SeekCompleted += a.EventHandlerAny);

    public static NProperty CreateSelectedBackground() => new NProperty(nameof(NProperties.SelectedBackground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectedBackgroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedBorderBrush() => new NProperty(nameof(NProperties.SelectedBorderBrush)).
        Property<CalendarView>(CalendarView.SelectedBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedBorderThickness() => new NProperty(nameof(NProperties.SelectedBorderThickness)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectedBorderThicknessProperty, NConverters.ToThickness).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedBorderThicknessProperty, NConverters.ToThickness);

    public static NProperty CreateSelectedForeground() => new NProperty(nameof(NProperties.SelectedForeground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectedForegroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedForegroundProperty, NConverters.ToBrush).
        Property<CalendarView>(CalendarView.SelectedForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedHoverBorderBrush() => new NProperty(nameof(NProperties.SelectedHoverBorderBrush)).
        Property<CalendarView>(CalendarView.SelectedHoverBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedIndex() => new NProperty(nameof(NProperties.SelectedIndex)).
        Property<Selector>(Selector.SelectedIndexProperty, NConverters.ToInt32).
        Property<Pivot>(Pivot.SelectedIndexProperty, NConverters.ToInt32).
        Property<LoopingSelector>(LoopingSelector.SelectedIndexProperty, NConverters.ToInt32);

    public static NProperty CreateSelectedItem() => new NProperty(nameof(NProperties.SelectedItem)).
        Property<Selector>(Selector.SelectedItemProperty).
        Property<Pivot>(Pivot.SelectedItemProperty).
        Property<LoopingSelector>(LoopingSelector.SelectedItemProperty);

    public static NProperty CreateSelectedPointerOverBackground() => new NProperty(nameof(NProperties.SelectedPointerOverBackground)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectedPointerOverBackgroundProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedPointerOverBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedPointerOverBorderBrush() => new NProperty(nameof(NProperties.SelectedPointerOverBorderBrush)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectedPointerOverBorderBrushProperty, NConverters.ToBrush).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedPointerOverBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedPressedBackground() => new NProperty(nameof(NProperties.SelectedPressedBackground)).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectedPressedBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedPressedBorderBrush() => new NProperty(nameof(NProperties.SelectedPressedBorderBrush)).
        Property<CalendarView>(CalendarView.SelectedPressedBorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateSelectedText() => new NProperty(nameof(NProperties.SelectedText)).
        Property<TextBox>((t, v) => t.SelectedText = NConverters.ToStringT(v));

    public static NProperty CreateSelectedValue() => new NProperty(nameof(NProperties.SelectedValue)).
        Property<Selector>(Selector.SelectedValueProperty);

    public static NProperty CreateSelectedValuePath() => new NProperty(nameof(NProperties.SelectedValuePath)).
        Property<Selector>(Selector.SelectedValuePathProperty, NConverters.ToString);

    public static NProperty CreateSelectionChanged() => new NProperty(nameof(NProperties.SelectionChanged)).
        Event<RichTextBlock>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<TextBlock>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<Selector>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<Pivot>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<RichEditBox>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<TextBox>((s, a) => s.SelectionChanged += a.EventHandlerAny).
        Event<LoopingSelector>((s, a) => s.SelectionChanged += a.EventHandlerAny);

    public static NProperty CreateSelectionCheckMarkVisualEnabled() => new NProperty(nameof(NProperties.SelectionCheckMarkVisualEnabled)).
        Property<GridViewItemPresenter>(GridViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, NConverters.ToBool).
        Property<ListViewItemPresenter>(ListViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, NConverters.ToBool);

    public static NProperty CreateSelectionHighlightColor() => new NProperty(nameof(NProperties.SelectionHighlightColor)).
        Property<RichTextBlock>(RichTextBlock.SelectionHighlightColorProperty).
        Property<TextBlock>(TextBlock.SelectionHighlightColorProperty).
        Property<PasswordBox>(PasswordBox.SelectionHighlightColorProperty).
        Property<RichEditBox>(RichEditBox.SelectionHighlightColorProperty).
        Property<TextBox>(TextBox.SelectionHighlightColorProperty);

    public static NProperty CreateSelectionLength() => new NProperty(nameof(NProperties.SelectionLength)).
        Property<TextBox>((t, v) => t.SelectionLength = NConverters.ToInt32T(v));

    public static NProperty CreateSelectionMode() => new NProperty(nameof(NProperties.SelectionMode)).
        Property<ListViewBase>(ListViewBase.SelectionModeProperty, NConverters.ToEnum<ListViewSelectionMode>).
        Property<ListBox>(ListBox.SelectionModeProperty, NConverters.ToEnum<SelectionMode>).
        Property<CalendarView>(CalendarView.SelectionModeProperty, NConverters.ToEnum<CalendarViewSelectionMode>);

    public static NProperty CreateSelectionStart() => new NProperty(nameof(NProperties.SelectionStart)).
        Property<TextBox>((t, v) => t.SelectionStart = NConverters.ToInt32T(v));

    public static NProperty CreateSemanticZoomOwner() => new NProperty(nameof(NProperties.SemanticZoomOwner)).
        Property<ListViewBase>(ListViewBase.SemanticZoomOwnerProperty).
        Property<Hub>(Hub.SemanticZoomOwnerProperty);

    public static NProperty CreateShouldLoop() => new NProperty(nameof(NProperties.ShouldLoop)).
        Property<LoopingSelector>(LoopingSelector.ShouldLoopProperty, NConverters.ToBool);

    public static NProperty CreateShowError() => new NProperty(nameof(NProperties.ShowError)).
        Property<ProgressBar>(ProgressBar.ShowErrorProperty, NConverters.ToBool);

    public static NProperty CreateShowPaused() => new NProperty(nameof(NProperties.ShowPaused)).
        Property<ProgressBar>(ProgressBar.ShowPausedProperty, NConverters.ToBool);

    public static NProperty CreateShowsScrollingPlaceholders() => new NProperty(nameof(NProperties.ShowsScrollingPlaceholders)).
        Property<ListViewBase>(ListViewBase.ShowsScrollingPlaceholdersProperty, NConverters.ToBool);

    public static NProperty CreateSizeChanged() => new NProperty(nameof(NProperties.SizeChanged)).
        Event<FrameworkElement>((s, a) => s.SizeChanged += a.EventHandlerAny);

    public static NProperty CreateSmallChange() => new NProperty(nameof(NProperties.SmallChange)).
        Property<RangeBase>(RangeBase.SmallChangeProperty, NConverters.ToDouble);

    public static NProperty CreateSnapsTo() => new NProperty(nameof(NProperties.SnapsTo)).
        Property<Slider>(Slider.SnapsToProperty, NConverters.ToEnum<SliderSnapsTo>);

    public static NProperty CreateSource() => new NProperty(nameof(NProperties.Source)).
        Property<CaptureElement>(CaptureElement.SourceProperty).
        Property<Image>(Image.SourceProperty).
        Property<MediaElement>(MediaElement.SourceProperty, NConverters.ToUri).
        Property<WebView>(WebView.SourceProperty, NConverters.ToUri);

    public static NProperty CreateSourcePageType() => new NProperty(nameof(NProperties.SourcePageType)).
        Property<Frame>(Frame.SourcePageTypeProperty);

    public static NProperty CreateStepFrequency() => new NProperty(nameof(NProperties.StepFrequency)).
        Property<Slider>(Slider.StepFrequencyProperty, NConverters.ToDouble);

    public static NProperty CreateStereo3DVideoPackingMode() => new NProperty(nameof(NProperties.Stereo3DVideoPackingMode)).
        Property<MediaElement>(MediaElement.Stereo3DVideoPackingModeProperty, NConverters.ToEnum<Stereo3DVideoPackingMode>);

    public static NProperty CreateStereo3DVideoRenderMode() => new NProperty(nameof(NProperties.Stereo3DVideoRenderMode)).
        Property<MediaElement>(MediaElement.Stereo3DVideoRenderModeProperty, NConverters.ToEnum<Stereo3DVideoRenderMode>);

    public static NProperty CreateStretch() => new NProperty(nameof(NProperties.Stretch)).
        Property<CaptureElement>(CaptureElement.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<Image>(Image.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<Viewbox>(Viewbox.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<MediaElement>(MediaElement.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<Shape>(Shape.StretchProperty, NConverters.ToEnum<Stretch>);

    public static NProperty CreateStretchDirection() => new NProperty(nameof(NProperties.StretchDirection)).
        Property<Viewbox>(Viewbox.StretchDirectionProperty, NConverters.ToEnum<StretchDirection>);

    public static NProperty CreateStroke() => new NProperty(nameof(NProperties.Stroke)).
        Property<Shape>(Shape.StrokeProperty, NConverters.ToBrush);

    public static NProperty CreateStrokeDashArray() => new NProperty(nameof(NProperties.StrokeDashArray)).
        Property<Shape>((t, v) => NPatch.AssignListT(t.StrokeDashArray, v));

    public static NProperty CreateStrokeDashCap() => new NProperty(nameof(NProperties.StrokeDashCap)).
        Property<Shape>(Shape.StrokeDashCapProperty, NConverters.ToEnum<PenLineCap>);

    public static NProperty CreateStrokeDashOffset() => new NProperty(nameof(NProperties.StrokeDashOffset)).
        Property<Shape>(Shape.StrokeDashOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateStrokeEndLineCap() => new NProperty(nameof(NProperties.StrokeEndLineCap)).
        Property<Shape>(Shape.StrokeEndLineCapProperty, NConverters.ToEnum<PenLineCap>);

    public static NProperty CreateStrokeLineJoin() => new NProperty(nameof(NProperties.StrokeLineJoin)).
        Property<Shape>(Shape.StrokeLineJoinProperty, NConverters.ToEnum<PenLineJoin>);

    public static NProperty CreateStrokeMiterLimit() => new NProperty(nameof(NProperties.StrokeMiterLimit)).
        Property<Shape>(Shape.StrokeMiterLimitProperty, NConverters.ToDouble);

    public static NProperty CreateStrokeStartLineCap() => new NProperty(nameof(NProperties.StrokeStartLineCap)).
        Property<Shape>(Shape.StrokeStartLineCapProperty, NConverters.ToEnum<PenLineCap>);

    public static NProperty CreateStrokeThickness() => new NProperty(nameof(NProperties.StrokeThickness)).
        Property<Shape>(Shape.StrokeThicknessProperty, NConverters.ToDouble);

    public static NProperty CreateStyle() => new NProperty(nameof(NProperties.Style)).
        Property<FrameworkElement>(FrameworkElement.StyleProperty, NConverters.ToStyle).
        Property<MapControl>(MapControl.StyleProperty, NConverters.ToEnum<MapStyle>);

    public static NProperty CreateStyleSimulations() => new NProperty(nameof(NProperties.StyleSimulations)).
        Property<Glyphs>(Glyphs.StyleSimulationsProperty, NConverters.ToEnum<StyleSimulations>);

    public static NProperty CreateSymbol() => new NProperty(nameof(NProperties.Symbol)).
        Property<SymbolIcon>(SymbolIcon.SymbolProperty, NConverters.ToEnum<Symbol>);

    public static NProperty CreateTabIndex() => new NProperty(nameof(NProperties.TabIndex)).
        Property<Control>(Control.TabIndexProperty, NConverters.ToInt32);

    public static NProperty CreateTabNavigation() => new NProperty(nameof(NProperties.TabNavigation)).
        Property<Control>(Control.TabNavigationProperty, NConverters.ToEnum<KeyboardNavigationMode>);

    public static NProperty CreateTag() => new NProperty(nameof(NProperties.Tag)).
        Property<FrameworkElement>(FrameworkElement.TagProperty);

    public static NProperty CreateTapped() => new NProperty(nameof(NProperties.Tapped)).
        Event<UIElement>(UIElement.TappedEvent, a => (TappedEventHandler)a.EventHandlerAny);

    public static NProperty CreateTemplate() => new NProperty(nameof(NProperties.Template)).
        Property<Control>(Control.TemplateProperty, NConverters.ToControlTemplate);

    public static NProperty CreateText() => new NProperty(nameof(NProperties.Text)).
        Property<TextBlock>(TextBlock.TextProperty, NConverters.ToString).
        Property<AutoSuggestBox>(AutoSuggestBox.TextProperty, NConverters.ToString).
        Property<TextBox>(TextBox.TextProperty, NConverters.ToString).
        Property<MenuFlyoutItem>(MenuFlyoutItem.TextProperty, NConverters.ToString).
        Property<MenuFlyoutSubItem>(MenuFlyoutSubItem.TextProperty, NConverters.ToString).
        Property<Run>((t, v) => t.Text = NConverters.ToStringT(v));

    public static NProperty CreateTextAlignment() => new NProperty(nameof(NProperties.TextAlignment)).
        Property<RichTextBlock>(RichTextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<TextBlock>(TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<RichEditBox>(RichEditBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<TextBox>(TextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<Block>(Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);

    public static NProperty CreateTextBoxStyle() => new NProperty(nameof(NProperties.TextBoxStyle)).
        Property<AutoSuggestBox>(AutoSuggestBox.TextBoxStyleProperty, NConverters.ToStyle);

    public static NProperty CreateTextChanged() => new NProperty(nameof(NProperties.TextChanged)).
        Event<RichEditBox>((s, a) => s.TextChanged += a.EventHandlerAny).
        Event<TextBox>((s, a) => s.TextChanged += a.EventHandlerAny);

    public static NProperty CreateTextIndent() => new NProperty(nameof(NProperties.TextIndent)).
        Property<RichTextBlock>(RichTextBlock.TextIndentProperty, NConverters.ToDouble).
        Property<Paragraph>(Paragraph.TextIndentProperty, NConverters.ToDouble);

    public static NProperty CreateTextLineBounds() => new NProperty(nameof(NProperties.TextLineBounds)).
        Property<ContentPresenter>(ContentPresenter.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>).
        Property<RichTextBlock>(RichTextBlock.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>).
        Property<TextBlock>(TextBlock.TextLineBoundsProperty, NConverters.ToEnum<TextLineBounds>);

    public static NProperty CreateTextMemberPath() => new NProperty(nameof(NProperties.TextMemberPath)).
        Property<AutoSuggestBox>(AutoSuggestBox.TextMemberPathProperty, NConverters.ToString);

    public static NProperty CreateTextReadingOrder() => new NProperty(nameof(NProperties.TextReadingOrder)).
        Property<RichTextBlock>(RichTextBlock.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>).
        Property<TextBlock>(TextBlock.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>).
        Property<PasswordBox>(PasswordBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>).
        Property<RichEditBox>(RichEditBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>).
        Property<TextBox>(TextBox.TextReadingOrderProperty, NConverters.ToEnum<TextReadingOrder>);

    public static NProperty CreateTextTrimming() => new NProperty(nameof(NProperties.TextTrimming)).
        Property<RichTextBlock>(RichTextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>).
        Property<TextBlock>(TextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);

    public static NProperty CreateTextWrapping() => new NProperty(nameof(NProperties.TextWrapping)).
        Property<ContentPresenter>(ContentPresenter.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<RichTextBlock>(RichTextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<TextBlock>(TextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<RichEditBox>(RichEditBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<TextBox>(TextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);

    public static NProperty CreateThumbToolTipValueConverter() => new NProperty(nameof(NProperties.ThumbToolTipValueConverter)).
        Property<Slider>(Slider.ThumbToolTipValueConverterProperty);

    public static NProperty CreateTickFrequency() => new NProperty(nameof(NProperties.TickFrequency)).
        Property<Slider>(Slider.TickFrequencyProperty, NConverters.ToDouble);

    public static NProperty CreateTickPlacement() => new NProperty(nameof(NProperties.TickPlacement)).
        Property<Slider>(Slider.TickPlacementProperty, NConverters.ToEnum<TickPlacement>);

    public static NProperty CreateTiltInteractionMode() => new NProperty(nameof(NProperties.TiltInteractionMode)).
        Property<MapControl>(MapControl.TiltInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);

    public static NProperty CreateTime() => new NProperty(nameof(NProperties.Time)).
        Property<TimePicker>(TimePicker.TimeProperty, NConverters.ToTimeSpan);

    public static NProperty CreateTimeChanged() => new NProperty(nameof(NProperties.TimeChanged)).
        Event<TimePicker>((s, a) => s.TimeChanged += a.EventHandlerAny);

    public static NProperty CreateTitle() => new NProperty(nameof(NProperties.Title)).
        Property<SettingsFlyout>(SettingsFlyout.TitleProperty, NConverters.ToString).
        Property<ContentDialog>(ContentDialog.TitleProperty).
        Property<Pivot>(Pivot.TitleProperty);

    public static NProperty CreateTitleTemplate() => new NProperty(nameof(NProperties.TitleTemplate)).
        Property<ContentDialog>(ContentDialog.TitleTemplateProperty, NConverters.ToDataTemplate).
        Property<Pivot>(Pivot.TitleTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateTodayFontWeight() => new NProperty(nameof(NProperties.TodayFontWeight)).
        Property<CalendarView>(CalendarView.TodayFontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateTodayForeground() => new NProperty(nameof(NProperties.TodayForeground)).
        Property<CalendarView>(CalendarView.TodayForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateToggled() => new NProperty(nameof(NProperties.Toggled)).
        Event<ToggleSwitch>((s, a) => s.Toggled += a.EventHandlerAny);

    public static NProperty CreateToolTipServicePlacement() => new NProperty(nameof(NProperties.ToolTipServicePlacement)).
        Property<DependencyObject>(ToolTipService.PlacementProperty, NConverters.ToEnum<PlacementMode>);

    public static NProperty CreateToolTipServicePlacementTarget() => new NProperty(nameof(NProperties.ToolTipServicePlacementTarget)).
        Property<DependencyObject>(ToolTipService.PlacementTargetProperty);

    public static NProperty CreateToolTipServiceToolTip() => new NProperty(nameof(NProperties.ToolTipServiceToolTip)).
        Property<DependencyObject>(ToolTipService.ToolTipProperty);

    public static NProperty CreateTopAppBar() => new NProperty(nameof(NProperties.TopAppBar)).
        Property<Page>(Page.TopAppBarProperty);

    public static NProperty CreateTopHeader() => new NProperty(nameof(NProperties.TopHeader)).
        Property<ScrollViewer>(ScrollViewer.TopHeaderProperty);

    public static NProperty CreateTopLeftHeader() => new NProperty(nameof(NProperties.TopLeftHeader)).
        Property<ScrollViewer>(ScrollViewer.TopLeftHeaderProperty);

    public static NProperty CreateTrafficFlowVisible() => new NProperty(nameof(NProperties.TrafficFlowVisible)).
        Property<MapControl>(MapControl.TrafficFlowVisibleProperty, NConverters.ToBool);

    public static NProperty CreateTransform3D() => new NProperty(nameof(NProperties.Transform3D)).
        Property<UIElement>(UIElement.Transform3DProperty);

    public static NProperty CreateTransformOrigin() => new NProperty(nameof(NProperties.TransformOrigin)).
        Property<MapControl>(MapControl.TransformOriginProperty, NConverters.ToPoint);

    public static NProperty CreateTransitFeaturesVisible() => new NProperty(nameof(NProperties.TransitFeaturesVisible)).
        Property<MapControl>(MapControl.TransitFeaturesVisibleProperty, NConverters.ToBool);

    public static NProperty CreateTransitions() => new NProperty(nameof(NProperties.Transitions)).
        Property<UIElement>((t, v) => NPatch.AssignListT(t.Transitions, v));

    public static NProperty CreateTriggers() => new NProperty(nameof(NProperties.Triggers)).
        Property<FrameworkElement>((t, v) => NPatch.AssignListT(t.Triggers, v));

    public static NProperty CreateUnchecked() => new NProperty(nameof(NProperties.Unchecked)).
        Event<ToggleButton>((s, a) => s.Unchecked += a.EventHandlerAny);

    public static NProperty CreateUnderlineStyle() => new NProperty(nameof(NProperties.UnderlineStyle)).
        Property<Hyperlink>(Hyperlink.UnderlineStyleProperty, NConverters.ToEnum<UnderlineStyle>);

    public static NProperty CreateUnicodeString() => new NProperty(nameof(NProperties.UnicodeString)).
        Property<Glyphs>(Glyphs.UnicodeStringProperty, NConverters.ToString);

    public static NProperty CreateUnloaded() => new NProperty(nameof(NProperties.Unloaded)).
        Event<FrameworkElement>((s, a) => s.Unloaded += a.EventHandlerAny);

    public static NProperty CreateUpdateTextOnSelect() => new NProperty(nameof(NProperties.UpdateTextOnSelect)).
        Property<AutoSuggestBox>(AutoSuggestBox.UpdateTextOnSelectProperty, NConverters.ToBool);

    public static NProperty CreateUriSource() => new NProperty(nameof(NProperties.UriSource)).
        Property<BitmapIcon>(BitmapIcon.UriSourceProperty, NConverters.ToUri);

    public static NProperty CreateUseLayoutRounding() => new NProperty(nameof(NProperties.UseLayoutRounding)).
        Property<UIElement>(UIElement.UseLayoutRoundingProperty, NConverters.ToBool);

    public static NProperty CreateUseSystemFocusVisuals() => new NProperty(nameof(NProperties.UseSystemFocusVisuals)).
        Property<Control>(Control.UseSystemFocusVisualsProperty, NConverters.ToBool);

    public static NProperty CreateUseTouchAnimationsForAllNavigation() => new NProperty(nameof(NProperties.UseTouchAnimationsForAllNavigation)).
        Property<FlipView>(FlipView.UseTouchAnimationsForAllNavigationProperty, NConverters.ToBool);

    public static NProperty CreateValue() => new NProperty(nameof(NProperties.Value)).
        Property<RangeBase>(RangeBase.ValueProperty, NConverters.ToDouble);

    public static NProperty CreateValueChanged() => new NProperty(nameof(NProperties.ValueChanged)).
        Event<RangeBase>((s, a) => s.ValueChanged += a.EventHandlerAny);

    public static NProperty CreateVariableSizedWrapGridColumnSpan() => new NProperty(nameof(NProperties.VariableSizedWrapGridColumnSpan)).
        Property<UIElement>(VariableSizedWrapGrid.ColumnSpanProperty, NConverters.ToInt32);

    public static NProperty CreateVariableSizedWrapGridRowSpan() => new NProperty(nameof(NProperties.VariableSizedWrapGridRowSpan)).
        Property<UIElement>(VariableSizedWrapGrid.RowSpanProperty, NConverters.ToInt32);

    public static NProperty CreateVerticalAlignment() => new NProperty(nameof(NProperties.VerticalAlignment)).
        Property<FrameworkElement>(FrameworkElement.VerticalAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalChildrenAlignment() => new NProperty(nameof(NProperties.VerticalChildrenAlignment)).
        Property<VariableSizedWrapGrid>(VariableSizedWrapGrid.VerticalChildrenAlignmentProperty, NConverters.ToEnum<VerticalAlignment>).
        Property<WrapGrid>(WrapGrid.VerticalChildrenAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalContentAlignment() => new NProperty(nameof(NProperties.VerticalContentAlignment)).
        Property<ContentPresenter>(ContentPresenter.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>).
        Property<Control>(Control.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalDayItemAlignment() => new NProperty(nameof(NProperties.VerticalDayItemAlignment)).
        Property<CalendarView>(CalendarView.VerticalDayItemAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalFirstOfMonthLabelAlignment() => new NProperty(nameof(NProperties.VerticalFirstOfMonthLabelAlignment)).
        Property<CalendarView>(CalendarView.VerticalFirstOfMonthLabelAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalOffset() => new NProperty(nameof(NProperties.VerticalOffset)).
        Property<Popup>(Popup.VerticalOffsetProperty, NConverters.ToDouble).
        Property<ToolTip>(ToolTip.VerticalOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateVerticalScrollBarVisibility() => new NProperty(nameof(NProperties.VerticalScrollBarVisibility)).
        Property<ScrollViewer>(ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateVerticalScrollMode() => new NProperty(nameof(NProperties.VerticalScrollMode)).
        Property<ScrollViewer>(ScrollViewer.VerticalScrollModeProperty, NConverters.ToEnum<ScrollMode>);

    public static NProperty CreateVerticalSnapPointsAlignment() => new NProperty(nameof(NProperties.VerticalSnapPointsAlignment)).
        Property<ScrollViewer>(ScrollViewer.VerticalSnapPointsAlignmentProperty, NConverters.ToEnum<SnapPointsAlignment>);

    public static NProperty CreateVerticalSnapPointsChanged() => new NProperty(nameof(NProperties.VerticalSnapPointsChanged)).
        Event<LoopingSelectorPanel>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny).
        Event<StackPanel>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny).
        Event<CarouselPanel>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny).
        Event<OrientedVirtualizingPanel>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny).
        Event<PivotPanel>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny).
        Event<ItemsPresenter>((s, a) => s.VerticalSnapPointsChanged += a.EventHandlerAny);

    public static NProperty CreateVerticalSnapPointsType() => new NProperty(nameof(NProperties.VerticalSnapPointsType)).
        Property<ScrollViewer>(ScrollViewer.VerticalSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);

    public static NProperty CreateViewChangeCompleted() => new NProperty(nameof(NProperties.ViewChangeCompleted)).
        Event<SemanticZoom>((s, a) => s.ViewChangeCompleted += a.EventHandlerAny);

    public static NProperty CreateViewChanged() => new NProperty(nameof(NProperties.ViewChanged)).
        Event<ScrollViewer>((s, a) => s.ViewChanged += a.EventHandlerAny);

    public static NProperty CreateViewChangeStarted() => new NProperty(nameof(NProperties.ViewChangeStarted)).
        Event<SemanticZoom>((s, a) => s.ViewChangeStarted += a.EventHandlerAny);

    public static NProperty CreateViewChanging() => new NProperty(nameof(NProperties.ViewChanging)).
        Event<ScrollViewer>((s, a) => s.ViewChanging += a.EventHandlerAny);

    public static NProperty CreateViewportSize() => new NProperty(nameof(NProperties.ViewportSize)).
        Property<ScrollBar>(ScrollBar.ViewportSizeProperty, NConverters.ToDouble);

    public static NProperty CreateVirtualizingStackPanelVirtualizationMode() => new NProperty(nameof(NProperties.VirtualizingStackPanelVirtualizationMode)).
        Property<DependencyObject>(VirtualizingStackPanel.VirtualizationModeProperty, NConverters.ToEnum<VirtualizationMode>);

    public static NProperty CreateVisibility() => new NProperty(nameof(NProperties.Visibility)).
        Property<UIElement>(UIElement.VisibilityProperty, NConverters.ToEnum<Visibility>);

    public static NProperty CreateVolume() => new NProperty(nameof(NProperties.Volume)).
        Property<MediaElement>(MediaElement.VolumeProperty, NConverters.ToDouble);

    public static NProperty CreateVolumeChanged() => new NProperty(nameof(NProperties.VolumeChanged)).
        Event<MediaElement>((s, a) => s.VolumeChanged += a.EventHandlerAny);

    public static NProperty CreateWatermarkMode() => new NProperty(nameof(NProperties.WatermarkMode)).
        Property<MapControl>(MapControl.WatermarkModeProperty, NConverters.ToEnum<MapWatermarkMode>);

    public static NProperty CreateWidth() => new NProperty(nameof(NProperties.Width)).
        Property<FrameworkElement>(FrameworkElement.WidthProperty, NConverters.ToLength).
        Property<ColumnDefinition>(ColumnDefinition.WidthProperty, NConverters.ToGridLength);

    public static NProperty CreateX1() => new NProperty(nameof(NProperties.X1)).
        Property<Line>(Line.X1Property, NConverters.ToDouble);

    public static NProperty CreateX2() => new NProperty(nameof(NProperties.X2)).
        Property<Line>(Line.X2Property, NConverters.ToDouble);

    public static NProperty CreateY1() => new NProperty(nameof(NProperties.Y1)).
        Property<Line>(Line.Y1Property, NConverters.ToDouble);

    public static NProperty CreateY2() => new NProperty(nameof(NProperties.Y2)).
        Property<Line>(Line.Y2Property, NConverters.ToDouble);

    public static NProperty CreateYearFormat() => new NProperty(nameof(NProperties.YearFormat)).
        Property<DatePicker>(DatePicker.YearFormatProperty, NConverters.ToString);

    public static NProperty CreateYearVisible() => new NProperty(nameof(NProperties.YearVisible)).
        Property<DatePicker>(DatePicker.YearVisibleProperty, NConverters.ToBool);

    public static NProperty CreateZoomedInView() => new NProperty(nameof(NProperties.ZoomedInView)).
        Property<SemanticZoom>(SemanticZoom.ZoomedInViewProperty);

    public static NProperty CreateZoomedOutView() => new NProperty(nameof(NProperties.ZoomedOutView)).
        Property<SemanticZoom>(SemanticZoom.ZoomedOutViewProperty);

    public static NProperty CreateZoomInteractionMode() => new NProperty(nameof(NProperties.ZoomInteractionMode)).
        Property<MapControl>(MapControl.ZoomInteractionModeProperty, NConverters.ToEnum<MapInteractionMode>);

    public static NProperty CreateZoomLevel() => new NProperty(nameof(NProperties.ZoomLevel)).
        Property<MapControl>(MapControl.ZoomLevelProperty, NConverters.ToDouble);

    public static NProperty CreateZoomMode() => new NProperty(nameof(NProperties.ZoomMode)).
        Property<ScrollViewer>(ScrollViewer.ZoomModeProperty, NConverters.ToEnum<ZoomMode>);

    public static NProperty CreateZoomSnapPointsType() => new NProperty(nameof(NProperties.ZoomSnapPointsType)).
        Property<ScrollViewer>(ScrollViewer.ZoomSnapPointsTypeProperty, NConverters.ToEnum<SnapPointsType>);

  }
}
