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

  public partial class NProperties
  {
    public NProperty AcceptsReturn { get { return _acceptsReturn ?? (_acceptsReturn = NPropFactories.CreateAcceptsReturn()); } }
           NProperty _acceptsReturn;

    public NProperty AllowDownloading { get { return _allowDownloading ?? (_allowDownloading = NPropFactories.CreateAllowDownloading()); } }
           NProperty _allowDownloading;

    public NProperty AllowDrop { get { return _allowDrop ?? (_allowDrop = NPropFactories.CreateAllowDrop()); } }
           NProperty _allowDrop;

    public NProperty AudioStreamIndex { get { return _audioStreamIndex ?? (_audioStreamIndex = NPropFactories.CreateAudioStreamIndex()); } }
           NProperty _audioStreamIndex;

    public NProperty AutoPlay { get { return _autoPlay ?? (_autoPlay = NPropFactories.CreateAutoPlay()); } }
           NProperty _autoPlay;

    public NProperty Background { get { return _background ?? (_background = NPropFactories.CreateBackground()); } }
           NProperty _background;

    public NProperty Balance { get { return _balance ?? (_balance = NPropFactories.CreateBalance()); } }
           NProperty _balance;

    public NProperty BindingValidationError { get { return _bindingValidationError ?? (_bindingValidationError = NPropFactories.CreateBindingValidationError()); } }
           NProperty _bindingValidationError;

    public NProperty Blocks { get { return _blocks ?? (_blocks = NPropFactories.CreateBlocks()); } }
           NProperty _blocks;

    public NProperty BlurFactor { get { return _blurFactor ?? (_blurFactor = NPropFactories.CreateBlurFactor()); } }
           NProperty _blurFactor;

    public NProperty BorderBrush { get { return _borderBrush ?? (_borderBrush = NPropFactories.CreateBorderBrush()); } }
           NProperty _borderBrush;

    public NProperty BorderThickness { get { return _borderThickness ?? (_borderThickness = NPropFactories.CreateBorderThickness()); } }
           NProperty _borderThickness;

    public NProperty BufferingProgressChanged { get { return _bufferingProgressChanged ?? (_bufferingProgressChanged = NPropFactories.CreateBufferingProgressChanged()); } }
           NProperty _bufferingProgressChanged;

    public NProperty BufferingTime { get { return _bufferingTime ?? (_bufferingTime = NPropFactories.CreateBufferingTime()); } }
           NProperty _bufferingTime;

    public NProperty CacheMode { get { return _cacheMode ?? (_cacheMode = NPropFactories.CreateCacheMode()); } }
           NProperty _cacheMode;

    public NProperty CanHorizontallyScroll { get { return _canHorizontallyScroll ?? (_canHorizontallyScroll = NPropFactories.CreateCanHorizontallyScroll()); } }
           NProperty _canHorizontallyScroll;

    public NProperty CanvasLeft { get { return _canvasLeft ?? (_canvasLeft = NPropFactories.CreateCanvasLeft()); } }
           NProperty _canvasLeft;

    public NProperty CanvasTop { get { return _canvasTop ?? (_canvasTop = NPropFactories.CreateCanvasTop()); } }
           NProperty _canvasTop;

    public NProperty CanvasZIndex { get { return _canvasZIndex ?? (_canvasZIndex = NPropFactories.CreateCanvasZIndex()); } }
           NProperty _canvasZIndex;

    public NProperty CanVerticallyScroll { get { return _canVerticallyScroll ?? (_canVerticallyScroll = NPropFactories.CreateCanVerticallyScroll()); } }
           NProperty _canVerticallyScroll;

    public NProperty CaretBrush { get { return _caretBrush ?? (_caretBrush = NPropFactories.CreateCaretBrush()); } }
           NProperty _caretBrush;

    public NProperty CharacterSpacing { get { return _characterSpacing ?? (_characterSpacing = NPropFactories.CreateCharacterSpacing()); } }
           NProperty _characterSpacing;

    public NProperty Checked { get { return _checked ?? (_checked = NPropFactories.CreateChecked()); } }
           NProperty _checked;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
           NProperty _child;

    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
           NProperty _children;

    public NProperty CleanUpVirtualizedItemEvent { get { return _cleanUpVirtualizedItemEvent ?? (_cleanUpVirtualizedItemEvent = NPropFactories.CreateCleanUpVirtualizedItemEvent()); } }
           NProperty _cleanUpVirtualizedItemEvent;

    public NProperty Click { get { return _click ?? (_click = NPropFactories.CreateClick()); } }
           NProperty _click;

    public NProperty ClickMode { get { return _clickMode ?? (_clickMode = NPropFactories.CreateClickMode()); } }
           NProperty _clickMode;

    public NProperty Clip { get { return _clip ?? (_clip = NPropFactories.CreateClip()); } }
           NProperty _clip;

    public NProperty Closed { get { return _closed ?? (_closed = NPropFactories.CreateClosed()); } }
           NProperty _closed;

    public NProperty ColumnDefinitions { get { return _columnDefinitions ?? (_columnDefinitions = NPropFactories.CreateColumnDefinitions()); } }
           NProperty _columnDefinitions;

    public NProperty Command { get { return _command ?? (_command = NPropFactories.CreateCommand()); } }
           NProperty _command;

    public NProperty CommandParameter { get { return _commandParameter ?? (_commandParameter = NPropFactories.CreateCommandParameter()); } }
           NProperty _commandParameter;

    public NProperty Content { get { return _content ?? (_content = NPropFactories.CreateContent()); } }
           NProperty _content;

    public NProperty ContentChanged { get { return _contentChanged ?? (_contentChanged = NPropFactories.CreateContentChanged()); } }
           NProperty _contentChanged;

    public NProperty ContentTemplate { get { return _contentTemplate ?? (_contentTemplate = NPropFactories.CreateContentTemplate()); } }
           NProperty _contentTemplate;

    public NProperty CornerRadius { get { return _cornerRadius ?? (_cornerRadius = NPropFactories.CreateCornerRadius()); } }
           NProperty _cornerRadius;

    public NProperty CurrentStateChanged { get { return _currentStateChanged ?? (_currentStateChanged = NPropFactories.CreateCurrentStateChanged()); } }
           NProperty _currentStateChanged;

    public NProperty Cursor { get { return _cursor ?? (_cursor = NPropFactories.CreateCursor()); } }
           NProperty _cursor;

    public NProperty Data { get { return _data ?? (_data = NPropFactories.CreateData()); } }
           NProperty _data;

    public NProperty DataContext { get { return _dataContext ?? (_dataContext = NPropFactories.CreateDataContext()); } }
           NProperty _dataContext;

    public NProperty DataContextChanged { get { return _dataContextChanged ?? (_dataContextChanged = NPropFactories.CreateDataContextChanged()); } }
           NProperty _dataContextChanged;

    public NProperty Delay { get { return _delay ?? (_delay = NPropFactories.CreateDelay()); } }
           NProperty _delay;

    public NProperty DisplayMemberPath { get { return _displayMemberPath ?? (_displayMemberPath = NPropFactories.CreateDisplayMemberPath()); } }
           NProperty _displayMemberPath;

    public NProperty DoubleTap { get { return _doubleTap ?? (_doubleTap = NPropFactories.CreateDoubleTap()); } }
           NProperty _doubleTap;

    public NProperty DownloadProgressChanged { get { return _downloadProgressChanged ?? (_downloadProgressChanged = NPropFactories.CreateDownloadProgressChanged()); } }
           NProperty _downloadProgressChanged;

    public NProperty DragCompleted { get { return _dragCompleted ?? (_dragCompleted = NPropFactories.CreateDragCompleted()); } }
           NProperty _dragCompleted;

    public NProperty DragDelta { get { return _dragDelta ?? (_dragDelta = NPropFactories.CreateDragDelta()); } }
           NProperty _dragDelta;

    public NProperty DragEnter { get { return _dragEnter ?? (_dragEnter = NPropFactories.CreateDragEnter()); } }
           NProperty _dragEnter;

    public NProperty DragLeave { get { return _dragLeave ?? (_dragLeave = NPropFactories.CreateDragLeave()); } }
           NProperty _dragLeave;

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

    public NProperty Effect { get { return _effect ?? (_effect = NPropFactories.CreateEffect()); } }
           NProperty _effect;

    public NProperty Fill { get { return _fill ?? (_fill = NPropFactories.CreateFill()); } }
           NProperty _fill;

    public NProperty FillRule { get { return _fillRule ?? (_fillRule = NPropFactories.CreateFillRule()); } }
           NProperty _fillRule;

    public NProperty FlowDirection { get { return _flowDirection ?? (_flowDirection = NPropFactories.CreateFlowDirection()); } }
           NProperty _flowDirection;

    public NProperty FontFamily { get { return _fontFamily ?? (_fontFamily = NPropFactories.CreateFontFamily()); } }
           NProperty _fontFamily;

    public NProperty FontRenderingEmSize { get { return _fontRenderingEmSize ?? (_fontRenderingEmSize = NPropFactories.CreateFontRenderingEmSize()); } }
           NProperty _fontRenderingEmSize;

    public NProperty FontSize { get { return _fontSize ?? (_fontSize = NPropFactories.CreateFontSize()); } }
           NProperty _fontSize;

    public NProperty FontSource { get { return _fontSource ?? (_fontSource = NPropFactories.CreateFontSource()); } }
           NProperty _fontSource;

    public NProperty FontStretch { get { return _fontStretch ?? (_fontStretch = NPropFactories.CreateFontStretch()); } }
           NProperty _fontStretch;

    public NProperty FontStyle { get { return _fontStyle ?? (_fontStyle = NPropFactories.CreateFontStyle()); } }
           NProperty _fontStyle;

    public NProperty FontUri { get { return _fontUri ?? (_fontUri = NPropFactories.CreateFontUri()); } }
           NProperty _fontUri;

    public NProperty FontWeight { get { return _fontWeight ?? (_fontWeight = NPropFactories.CreateFontWeight()); } }
           NProperty _fontWeight;

    public NProperty Foreground { get { return _foreground ?? (_foreground = NPropFactories.CreateForeground()); } }
           NProperty _foreground;

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

    public NProperty GroupName { get { return _groupName ?? (_groupName = NPropFactories.CreateGroupName()); } }
           NProperty _groupName;

    public NProperty HasTrailingParagraphBreakOnPaste { get { return _hasTrailingParagraphBreakOnPaste ?? (_hasTrailingParagraphBreakOnPaste = NPropFactories.CreateHasTrailingParagraphBreakOnPaste()); } }
           NProperty _hasTrailingParagraphBreakOnPaste;

    public NProperty Height { get { return _height ?? (_height = NPropFactories.CreateHeight()); } }
           NProperty _height;

    public NProperty Hold { get { return _hold ?? (_hold = NPropFactories.CreateHold()); } }
           NProperty _hold;

    public NProperty HorizontalAlignment { get { return _horizontalAlignment ?? (_horizontalAlignment = NPropFactories.CreateHorizontalAlignment()); } }
           NProperty _horizontalAlignment;

    public NProperty HorizontalContentAlignment { get { return _horizontalContentAlignment ?? (_horizontalContentAlignment = NPropFactories.CreateHorizontalContentAlignment()); } }
           NProperty _horizontalContentAlignment;

    public NProperty HorizontalOffset { get { return _horizontalOffset ?? (_horizontalOffset = NPropFactories.CreateHorizontalOffset()); } }
           NProperty _horizontalOffset;

    public NProperty HorizontalScrollBarVisibility { get { return _horizontalScrollBarVisibility ?? (_horizontalScrollBarVisibility = NPropFactories.CreateHorizontalScrollBarVisibility()); } }
           NProperty _horizontalScrollBarVisibility;

    public NProperty ImageFailed { get { return _imageFailed ?? (_imageFailed = NPropFactories.CreateImageFailed()); } }
           NProperty _imageFailed;

    public NProperty ImageOpened { get { return _imageOpened ?? (_imageOpened = NPropFactories.CreateImageOpened()); } }
           NProperty _imageOpened;

    public NProperty ImageOpenFailed { get { return _imageOpenFailed ?? (_imageOpenFailed = NPropFactories.CreateImageOpenFailed()); } }
           NProperty _imageOpenFailed;

    public NProperty ImageOpenSucceeded { get { return _imageOpenSucceeded ?? (_imageOpenSucceeded = NPropFactories.CreateImageOpenSucceeded()); } }
           NProperty _imageOpenSucceeded;

    public NProperty Indeterminate { get { return _indeterminate ?? (_indeterminate = NPropFactories.CreateIndeterminate()); } }
           NProperty _indeterminate;

    public NProperty Indices { get { return _indices ?? (_indices = NPropFactories.CreateIndices()); } }
           NProperty _indices;

    public NProperty Inlines { get { return _inlines ?? (_inlines = NPropFactories.CreateInlines()); } }
           NProperty _inlines;

    public NProperty InputScope { get { return _inputScope ?? (_inputScope = NPropFactories.CreateInputScope()); } }
           NProperty _inputScope;

    public NProperty Interval { get { return _interval ?? (_interval = NPropFactories.CreateInterval()); } }
           NProperty _interval;

    public NProperty IsChecked { get { return _isChecked ?? (_isChecked = NPropFactories.CreateIsChecked()); } }
           NProperty _isChecked;

    public NProperty IsDirectionReversed { get { return _isDirectionReversed ?? (_isDirectionReversed = NPropFactories.CreateIsDirectionReversed()); } }
           NProperty _isDirectionReversed;

    public NProperty IsDropDownOpen { get { return _isDropDownOpen ?? (_isDropDownOpen = NPropFactories.CreateIsDropDownOpen()); } }
           NProperty _isDropDownOpen;

    public NProperty IsEnabled { get { return _isEnabled ?? (_isEnabled = NPropFactories.CreateIsEnabled()); } }
           NProperty _isEnabled;

    public NProperty IsEnabledChanged { get { return _isEnabledChanged ?? (_isEnabledChanged = NPropFactories.CreateIsEnabledChanged()); } }
           NProperty _isEnabledChanged;

    public NProperty IsHitTestVisible { get { return _isHitTestVisible ?? (_isHitTestVisible = NPropFactories.CreateIsHitTestVisible()); } }
           NProperty _isHitTestVisible;

    public NProperty IsIndeterminate { get { return _isIndeterminate ?? (_isIndeterminate = NPropFactories.CreateIsIndeterminate()); } }
           NProperty _isIndeterminate;

    public NProperty IsMuted { get { return _isMuted ?? (_isMuted = NPropFactories.CreateIsMuted()); } }
           NProperty _isMuted;

    public NProperty IsOpen { get { return _isOpen ?? (_isOpen = NPropFactories.CreateIsOpen()); } }
           NProperty _isOpen;

    public NProperty IsReadOnly { get { return _isReadOnly ?? (_isReadOnly = NPropFactories.CreateIsReadOnly()); } }
           NProperty _isReadOnly;

    public NProperty IsSelected { get { return _isSelected ?? (_isSelected = NPropFactories.CreateIsSelected()); } }
           NProperty _isSelected;

    public NProperty IsSynchronizedWithCurrentItem { get { return _isSynchronizedWithCurrentItem ?? (_isSynchronizedWithCurrentItem = NPropFactories.CreateIsSynchronizedWithCurrentItem()); } }
           NProperty _isSynchronizedWithCurrentItem;

    public NProperty IsTabStop { get { return _isTabStop ?? (_isTabStop = NPropFactories.CreateIsTabStop()); } }
           NProperty _isTabStop;

    public NProperty IsTextSelectionEnabled { get { return _isTextSelectionEnabled ?? (_isTextSelectionEnabled = NPropFactories.CreateIsTextSelectionEnabled()); } }
           NProperty _isTextSelectionEnabled;

    public NProperty IsThreeState { get { return _isThreeState ?? (_isThreeState = NPropFactories.CreateIsThreeState()); } }
           NProperty _isThreeState;

    public NProperty ItemContainerStyle { get { return _itemContainerStyle ?? (_itemContainerStyle = NPropFactories.CreateItemContainerStyle()); } }
           NProperty _itemContainerStyle;

    public NProperty Items { get { return _items ?? (_items = NPropFactories.CreateItems()); } }
           NProperty _items;

    public NProperty ItemsPanel { get { return _itemsPanel ?? (_itemsPanel = NPropFactories.CreateItemsPanel()); } }
           NProperty _itemsPanel;

    public NProperty ItemsSource { get { return _itemsSource ?? (_itemsSource = NPropFactories.CreateItemsSource()); } }
           NProperty _itemsSource;

    public NProperty ItemTemplate { get { return _itemTemplate ?? (_itemTemplate = NPropFactories.CreateItemTemplate()); } }
           NProperty _itemTemplate;

    public NProperty KeyDown { get { return _keyDown ?? (_keyDown = NPropFactories.CreateKeyDown()); } }
           NProperty _keyDown;

    public NProperty KeyUp { get { return _keyUp ?? (_keyUp = NPropFactories.CreateKeyUp()); } }
           NProperty _keyUp;

    public NProperty Language { get { return _language ?? (_language = NPropFactories.CreateLanguage()); } }
           NProperty _language;

    public NProperty LargeChange { get { return _largeChange ?? (_largeChange = NPropFactories.CreateLargeChange()); } }
           NProperty _largeChange;

    public NProperty LayoutUpdated { get { return _layoutUpdated ?? (_layoutUpdated = NPropFactories.CreateLayoutUpdated()); } }
           NProperty _layoutUpdated;

    public NProperty LineHeight { get { return _lineHeight ?? (_lineHeight = NPropFactories.CreateLineHeight()); } }
           NProperty _lineHeight;

    public NProperty LineStackingStrategy { get { return _lineStackingStrategy ?? (_lineStackingStrategy = NPropFactories.CreateLineStackingStrategy()); } }
           NProperty _lineStackingStrategy;

    public NProperty LoadCompleted { get { return _loadCompleted ?? (_loadCompleted = NPropFactories.CreateLoadCompleted()); } }
           NProperty _loadCompleted;

    public NProperty Loaded { get { return _loaded ?? (_loaded = NPropFactories.CreateLoaded()); } }
           NProperty _loaded;

    public NProperty LogReady { get { return _logReady ?? (_logReady = NPropFactories.CreateLogReady()); } }
           NProperty _logReady;

    public NProperty LostFocus { get { return _lostFocus ?? (_lostFocus = NPropFactories.CreateLostFocus()); } }
           NProperty _lostFocus;

    public NProperty LostMouseCapture { get { return _lostMouseCapture ?? (_lostMouseCapture = NPropFactories.CreateLostMouseCapture()); } }
           NProperty _lostMouseCapture;

    public NProperty ManipulationCompleted { get { return _manipulationCompleted ?? (_manipulationCompleted = NPropFactories.CreateManipulationCompleted()); } }
           NProperty _manipulationCompleted;

    public NProperty ManipulationDelta { get { return _manipulationDelta ?? (_manipulationDelta = NPropFactories.CreateManipulationDelta()); } }
           NProperty _manipulationDelta;

    public NProperty ManipulationMode { get { return _manipulationMode ?? (_manipulationMode = NPropFactories.CreateManipulationMode()); } }
           NProperty _manipulationMode;

    public NProperty ManipulationStarted { get { return _manipulationStarted ?? (_manipulationStarted = NPropFactories.CreateManipulationStarted()); } }
           NProperty _manipulationStarted;

    public NProperty Margin { get { return _margin ?? (_margin = NPropFactories.CreateMargin()); } }
           NProperty _margin;

    public NProperty MarkerReached { get { return _markerReached ?? (_markerReached = NPropFactories.CreateMarkerReached()); } }
           NProperty _markerReached;

    public NProperty Markers { get { return _markers ?? (_markers = NPropFactories.CreateMarkers()); } }
           NProperty _markers;

    public NProperty MaxDropDownHeight { get { return _maxDropDownHeight ?? (_maxDropDownHeight = NPropFactories.CreateMaxDropDownHeight()); } }
           NProperty _maxDropDownHeight;

    public NProperty MaxHeight { get { return _maxHeight ?? (_maxHeight = NPropFactories.CreateMaxHeight()); } }
           NProperty _maxHeight;

    public NProperty Maximum { get { return _maximum ?? (_maximum = NPropFactories.CreateMaximum()); } }
           NProperty _maximum;

    public NProperty MaxLength { get { return _maxLength ?? (_maxLength = NPropFactories.CreateMaxLength()); } }
           NProperty _maxLength;

    public NProperty MaxWidth { get { return _maxWidth ?? (_maxWidth = NPropFactories.CreateMaxWidth()); } }
           NProperty _maxWidth;

    public NProperty MediaCommand { get { return _mediaCommand ?? (_mediaCommand = NPropFactories.CreateMediaCommand()); } }
           NProperty _mediaCommand;

    public NProperty MediaEnded { get { return _mediaEnded ?? (_mediaEnded = NPropFactories.CreateMediaEnded()); } }
           NProperty _mediaEnded;

    public NProperty MediaFailed { get { return _mediaFailed ?? (_mediaFailed = NPropFactories.CreateMediaFailed()); } }
           NProperty _mediaFailed;

    public NProperty MediaOpened { get { return _mediaOpened ?? (_mediaOpened = NPropFactories.CreateMediaOpened()); } }
           NProperty _mediaOpened;

    public NProperty MinHeight { get { return _minHeight ?? (_minHeight = NPropFactories.CreateMinHeight()); } }
           NProperty _minHeight;

    public NProperty Minimum { get { return _minimum ?? (_minimum = NPropFactories.CreateMinimum()); } }
           NProperty _minimum;

    public NProperty MinWidth { get { return _minWidth ?? (_minWidth = NPropFactories.CreateMinWidth()); } }
           NProperty _minWidth;

    public NProperty MotionFinished { get { return _motionFinished ?? (_motionFinished = NPropFactories.CreateMotionFinished()); } }
           NProperty _motionFinished;

    public NProperty MouseEnter { get { return _mouseEnter ?? (_mouseEnter = NPropFactories.CreateMouseEnter()); } }
           NProperty _mouseEnter;

    public NProperty MouseLeave { get { return _mouseLeave ?? (_mouseLeave = NPropFactories.CreateMouseLeave()); } }
           NProperty _mouseLeave;

    public NProperty MouseLeftButtonDown { get { return _mouseLeftButtonDown ?? (_mouseLeftButtonDown = NPropFactories.CreateMouseLeftButtonDown()); } }
           NProperty _mouseLeftButtonDown;

    public NProperty MouseLeftButtonUp { get { return _mouseLeftButtonUp ?? (_mouseLeftButtonUp = NPropFactories.CreateMouseLeftButtonUp()); } }
           NProperty _mouseLeftButtonUp;

    public NProperty MouseMove { get { return _mouseMove ?? (_mouseMove = NPropFactories.CreateMouseMove()); } }
           NProperty _mouseMove;

    public NProperty MouseOverForeground { get { return _mouseOverForeground ?? (_mouseOverForeground = NPropFactories.CreateMouseOverForeground()); } }
           NProperty _mouseOverForeground;

    public NProperty MouseOverTextDecorations { get { return _mouseOverTextDecorations ?? (_mouseOverTextDecorations = NPropFactories.CreateMouseOverTextDecorations()); } }
           NProperty _mouseOverTextDecorations;

    public NProperty MouseRightButtonDown { get { return _mouseRightButtonDown ?? (_mouseRightButtonDown = NPropFactories.CreateMouseRightButtonDown()); } }
           NProperty _mouseRightButtonDown;

    public NProperty MouseRightButtonUp { get { return _mouseRightButtonUp ?? (_mouseRightButtonUp = NPropFactories.CreateMouseRightButtonUp()); } }
           NProperty _mouseRightButtonUp;

    public NProperty MouseWheel { get { return _mouseWheel ?? (_mouseWheel = NPropFactories.CreateMouseWheel()); } }
           NProperty _mouseWheel;

    public NProperty Name { get { return _name ?? (_name = NPropFactories.CreateName()); } }
           NProperty _name;

    public NProperty NavigateUri { get { return _navigateUri ?? (_navigateUri = NPropFactories.CreateNavigateUri()); } }
           NProperty _navigateUri;

    public NProperty Opacity { get { return _opacity ?? (_opacity = NPropFactories.CreateOpacity()); } }
           NProperty _opacity;

    public NProperty OpacityMask { get { return _opacityMask ?? (_opacityMask = NPropFactories.CreateOpacityMask()); } }
           NProperty _opacityMask;

    public NProperty Opened { get { return _opened ?? (_opened = NPropFactories.CreateOpened()); } }
           NProperty _opened;

    public NProperty Orientation { get { return _orientation ?? (_orientation = NPropFactories.CreateOrientation()); } }
           NProperty _orientation;

    public NProperty OriginX { get { return _originX ?? (_originX = NPropFactories.CreateOriginX()); } }
           NProperty _originX;

    public NProperty OriginY { get { return _originY ?? (_originY = NPropFactories.CreateOriginY()); } }
           NProperty _originY;

    public NProperty OverflowContentTarget { get { return _overflowContentTarget ?? (_overflowContentTarget = NPropFactories.CreateOverflowContentTarget()); } }
           NProperty _overflowContentTarget;

    public NProperty Padding { get { return _padding ?? (_padding = NPropFactories.CreatePadding()); } }
           NProperty _padding;

    public NProperty Password { get { return _password ?? (_password = NPropFactories.CreatePassword()); } }
           NProperty _password;

    public NProperty PasswordChanged { get { return _passwordChanged ?? (_passwordChanged = NPropFactories.CreatePasswordChanged()); } }
           NProperty _passwordChanged;

    public NProperty PasswordChar { get { return _passwordChar ?? (_passwordChar = NPropFactories.CreatePasswordChar()); } }
           NProperty _passwordChar;

    public NProperty Placement { get { return _placement ?? (_placement = NPropFactories.CreatePlacement()); } }
           NProperty _placement;

    public NProperty PlacementTarget { get { return _placementTarget ?? (_placementTarget = NPropFactories.CreatePlacementTarget()); } }
           NProperty _placementTarget;

    public NProperty PlaybackRate { get { return _playbackRate ?? (_playbackRate = NPropFactories.CreatePlaybackRate()); } }
           NProperty _playbackRate;

    public NProperty Points { get { return _points ?? (_points = NPropFactories.CreatePoints()); } }
           NProperty _points;

    public NProperty Position { get { return _position ?? (_position = NPropFactories.CreatePosition()); } }
           NProperty _position;

    public NProperty Projection { get { return _projection ?? (_projection = NPropFactories.CreateProjection()); } }
           NProperty _projection;

    public NProperty RadiusX { get { return _radiusX ?? (_radiusX = NPropFactories.CreateRadiusX()); } }
           NProperty _radiusX;

    public NProperty RadiusY { get { return _radiusY ?? (_radiusY = NPropFactories.CreateRadiusY()); } }
           NProperty _radiusY;

    public NProperty RateChanged { get { return _rateChanged ?? (_rateChanged = NPropFactories.CreateRateChanged()); } }
           NProperty _rateChanged;

    public NProperty RenderTransform { get { return _renderTransform ?? (_renderTransform = NPropFactories.CreateRenderTransform()); } }
           NProperty _renderTransform;

    public NProperty RenderTransformOrigin { get { return _renderTransformOrigin ?? (_renderTransformOrigin = NPropFactories.CreateRenderTransformOrigin()); } }
           NProperty _renderTransformOrigin;

    public NProperty Resources { get { return _resources ?? (_resources = NPropFactories.CreateResources()); } }
           NProperty _resources;

    public NProperty RowDefinitions { get { return _rowDefinitions ?? (_rowDefinitions = NPropFactories.CreateRowDefinitions()); } }
           NProperty _rowDefinitions;

    public NProperty ScriptNotify { get { return _scriptNotify ?? (_scriptNotify = NPropFactories.CreateScriptNotify()); } }
           NProperty _scriptNotify;

    public NProperty Scroll { get { return _scroll ?? (_scroll = NPropFactories.CreateScroll()); } }
           NProperty _scroll;

    public NProperty ScrollViewerHorizontalScrollBarVisibility { get { return _scrollViewerHorizontalScrollBarVisibility ?? (_scrollViewerHorizontalScrollBarVisibility = NPropFactories.CreateScrollViewerHorizontalScrollBarVisibility()); } }
           NProperty _scrollViewerHorizontalScrollBarVisibility;

    public NProperty ScrollViewerManipulationMode { get { return _scrollViewerManipulationMode ?? (_scrollViewerManipulationMode = NPropFactories.CreateScrollViewerManipulationMode()); } }
           NProperty _scrollViewerManipulationMode;

    public NProperty ScrollViewerVerticalScrollBarVisibility { get { return _scrollViewerVerticalScrollBarVisibility ?? (_scrollViewerVerticalScrollBarVisibility = NPropFactories.CreateScrollViewerVerticalScrollBarVisibility()); } }
           NProperty _scrollViewerVerticalScrollBarVisibility;

    public NProperty SelectedIndex { get { return _selectedIndex ?? (_selectedIndex = NPropFactories.CreateSelectedIndex()); } }
           NProperty _selectedIndex;

    public NProperty SelectedItem { get { return _selectedItem ?? (_selectedItem = NPropFactories.CreateSelectedItem()); } }
           NProperty _selectedItem;

    public NProperty SelectedItems { get { return _selectedItems ?? (_selectedItems = NPropFactories.CreateSelectedItems()); } }
           NProperty _selectedItems;

    public NProperty SelectedText { get { return _selectedText ?? (_selectedText = NPropFactories.CreateSelectedText()); } }
           NProperty _selectedText;

    public NProperty SelectedValue { get { return _selectedValue ?? (_selectedValue = NPropFactories.CreateSelectedValue()); } }
           NProperty _selectedValue;

    public NProperty SelectedValuePath { get { return _selectedValuePath ?? (_selectedValuePath = NPropFactories.CreateSelectedValuePath()); } }
           NProperty _selectedValuePath;

    public NProperty SelectionBackground { get { return _selectionBackground ?? (_selectionBackground = NPropFactories.CreateSelectionBackground()); } }
           NProperty _selectionBackground;

    public NProperty SelectionChanged { get { return _selectionChanged ?? (_selectionChanged = NPropFactories.CreateSelectionChanged()); } }
           NProperty _selectionChanged;

    public NProperty SelectionForeground { get { return _selectionForeground ?? (_selectionForeground = NPropFactories.CreateSelectionForeground()); } }
           NProperty _selectionForeground;

    public NProperty SelectionLength { get { return _selectionLength ?? (_selectionLength = NPropFactories.CreateSelectionLength()); } }
           NProperty _selectionLength;

    public NProperty SelectionMode { get { return _selectionMode ?? (_selectionMode = NPropFactories.CreateSelectionMode()); } }
           NProperty _selectionMode;

    public NProperty SelectionStart { get { return _selectionStart ?? (_selectionStart = NPropFactories.CreateSelectionStart()); } }
           NProperty _selectionStart;

    public NProperty ShowGridLines { get { return _showGridLines ?? (_showGridLines = NPropFactories.CreateShowGridLines()); } }
           NProperty _showGridLines;

    public NProperty SizeChanged { get { return _sizeChanged ?? (_sizeChanged = NPropFactories.CreateSizeChanged()); } }
           NProperty _sizeChanged;

    public NProperty SkipLevels { get { return _skipLevels ?? (_skipLevels = NPropFactories.CreateSkipLevels()); } }
           NProperty _skipLevels;

    public NProperty SmallChange { get { return _smallChange ?? (_smallChange = NPropFactories.CreateSmallChange()); } }
           NProperty _smallChange;

    public NProperty Source { get { return _source ?? (_source = NPropFactories.CreateSource()); } }
           NProperty _source;

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

    public NProperty Strokes { get { return _strokes ?? (_strokes = NPropFactories.CreateStrokes()); } }
           NProperty _strokes;

    public NProperty StrokeStartLineCap { get { return _strokeStartLineCap ?? (_strokeStartLineCap = NPropFactories.CreateStrokeStartLineCap()); } }
           NProperty _strokeStartLineCap;

    public NProperty StrokeThickness { get { return _strokeThickness ?? (_strokeThickness = NPropFactories.CreateStrokeThickness()); } }
           NProperty _strokeThickness;

    public NProperty Style { get { return _style ?? (_style = NPropFactories.CreateStyle()); } }
           NProperty _style;

    public NProperty StyleSimulations { get { return _styleSimulations ?? (_styleSimulations = NPropFactories.CreateStyleSimulations()); } }
           NProperty _styleSimulations;

    public NProperty SubImageOpenFailed { get { return _subImageOpenFailed ?? (_subImageOpenFailed = NPropFactories.CreateSubImageOpenFailed()); } }
           NProperty _subImageOpenFailed;

    public NProperty SubImageOpenSucceeded { get { return _subImageOpenSucceeded ?? (_subImageOpenSucceeded = NPropFactories.CreateSubImageOpenSucceeded()); } }
           NProperty _subImageOpenSucceeded;

    public NProperty SubImages { get { return _subImages ?? (_subImages = NPropFactories.CreateSubImages()); } }
           NProperty _subImages;

    public NProperty TabIndex { get { return _tabIndex ?? (_tabIndex = NPropFactories.CreateTabIndex()); } }
           NProperty _tabIndex;

    public NProperty TabNavigation { get { return _tabNavigation ?? (_tabNavigation = NPropFactories.CreateTabNavigation()); } }
           NProperty _tabNavigation;

    public NProperty Tag { get { return _tag ?? (_tag = NPropFactories.CreateTag()); } }
           NProperty _tag;

    public NProperty Tap { get { return _tap ?? (_tap = NPropFactories.CreateTap()); } }
           NProperty _tap;

    public NProperty TargetName { get { return _targetName ?? (_targetName = NPropFactories.CreateTargetName()); } }
           NProperty _targetName;

    public NProperty Template { get { return _template ?? (_template = NPropFactories.CreateTemplate()); } }
           NProperty _template;

    public NProperty Text { get { return _text ?? (_text = NPropFactories.CreateText()); } }
           NProperty _text;

    public NProperty TextAlignment { get { return _textAlignment ?? (_textAlignment = NPropFactories.CreateTextAlignment()); } }
           NProperty _textAlignment;

    public NProperty TextChanged { get { return _textChanged ?? (_textChanged = NPropFactories.CreateTextChanged()); } }
           NProperty _textChanged;

    public NProperty TextDecorations { get { return _textDecorations ?? (_textDecorations = NPropFactories.CreateTextDecorations()); } }
           NProperty _textDecorations;

    public NProperty TextInput { get { return _textInput ?? (_textInput = NPropFactories.CreateTextInput()); } }
           NProperty _textInput;

    public NProperty TextInputStart { get { return _textInputStart ?? (_textInputStart = NPropFactories.CreateTextInputStart()); } }
           NProperty _textInputStart;

    public NProperty TextInputUpdate { get { return _textInputUpdate ?? (_textInputUpdate = NPropFactories.CreateTextInputUpdate()); } }
           NProperty _textInputUpdate;

    public NProperty TextOptionsTextFormattingMode { get { return _textOptionsTextFormattingMode ?? (_textOptionsTextFormattingMode = NPropFactories.CreateTextOptionsTextFormattingMode()); } }
           NProperty _textOptionsTextFormattingMode;

    public NProperty TextOptionsTextHintingMode { get { return _textOptionsTextHintingMode ?? (_textOptionsTextHintingMode = NPropFactories.CreateTextOptionsTextHintingMode()); } }
           NProperty _textOptionsTextHintingMode;

    public NProperty TextOptionsTextRenderingMode { get { return _textOptionsTextRenderingMode ?? (_textOptionsTextRenderingMode = NPropFactories.CreateTextOptionsTextRenderingMode()); } }
           NProperty _textOptionsTextRenderingMode;

    public NProperty TextTrimming { get { return _textTrimming ?? (_textTrimming = NPropFactories.CreateTextTrimming()); } }
           NProperty _textTrimming;

    public NProperty TextWrapping { get { return _textWrapping ?? (_textWrapping = NPropFactories.CreateTextWrapping()); } }
           NProperty _textWrapping;

    public NProperty ToolTipServicePlacement { get { return _toolTipServicePlacement ?? (_toolTipServicePlacement = NPropFactories.CreateToolTipServicePlacement()); } }
           NProperty _toolTipServicePlacement;

    public NProperty ToolTipServicePlacementTarget { get { return _toolTipServicePlacementTarget ?? (_toolTipServicePlacementTarget = NPropFactories.CreateToolTipServicePlacementTarget()); } }
           NProperty _toolTipServicePlacementTarget;

    public NProperty ToolTipServiceToolTip { get { return _toolTipServiceToolTip ?? (_toolTipServiceToolTip = NPropFactories.CreateToolTipServiceToolTip()); } }
           NProperty _toolTipServiceToolTip;

    public NProperty Triggers { get { return _triggers ?? (_triggers = NPropFactories.CreateTriggers()); } }
           NProperty _triggers;

    public NProperty Unchecked { get { return _unchecked ?? (_unchecked = NPropFactories.CreateUnchecked()); } }
           NProperty _unchecked;

    public NProperty UnicodeString { get { return _unicodeString ?? (_unicodeString = NPropFactories.CreateUnicodeString()); } }
           NProperty _unicodeString;

    public NProperty Unloaded { get { return _unloaded ?? (_unloaded = NPropFactories.CreateUnloaded()); } }
           NProperty _unloaded;

    public NProperty UseLayoutRounding { get { return _useLayoutRounding ?? (_useLayoutRounding = NPropFactories.CreateUseLayoutRounding()); } }
           NProperty _useLayoutRounding;

    public NProperty UseSprings { get { return _useSprings ?? (_useSprings = NPropFactories.CreateUseSprings()); } }
           NProperty _useSprings;

    public NProperty Value { get { return _value ?? (_value = NPropFactories.CreateValue()); } }
           NProperty _value;

    public NProperty ValueChanged { get { return _valueChanged ?? (_valueChanged = NPropFactories.CreateValueChanged()); } }
           NProperty _valueChanged;

    public NProperty VerticalAlignment { get { return _verticalAlignment ?? (_verticalAlignment = NPropFactories.CreateVerticalAlignment()); } }
           NProperty _verticalAlignment;

    public NProperty VerticalContentAlignment { get { return _verticalContentAlignment ?? (_verticalContentAlignment = NPropFactories.CreateVerticalContentAlignment()); } }
           NProperty _verticalContentAlignment;

    public NProperty VerticalOffset { get { return _verticalOffset ?? (_verticalOffset = NPropFactories.CreateVerticalOffset()); } }
           NProperty _verticalOffset;

    public NProperty VerticalScrollBarVisibility { get { return _verticalScrollBarVisibility ?? (_verticalScrollBarVisibility = NPropFactories.CreateVerticalScrollBarVisibility()); } }
           NProperty _verticalScrollBarVisibility;

    public NProperty ViewportChanged { get { return _viewportChanged ?? (_viewportChanged = NPropFactories.CreateViewportChanged()); } }
           NProperty _viewportChanged;

    public NProperty ViewportOrigin { get { return _viewportOrigin ?? (_viewportOrigin = NPropFactories.CreateViewportOrigin()); } }
           NProperty _viewportOrigin;

    public NProperty ViewportSize { get { return _viewportSize ?? (_viewportSize = NPropFactories.CreateViewportSize()); } }
           NProperty _viewportSize;

    public NProperty ViewportWidth { get { return _viewportWidth ?? (_viewportWidth = NPropFactories.CreateViewportWidth()); } }
           NProperty _viewportWidth;

    public NProperty VirtualizingStackPanelVirtualizationMode { get { return _virtualizingStackPanelVirtualizationMode ?? (_virtualizingStackPanelVirtualizationMode = NPropFactories.CreateVirtualizingStackPanelVirtualizationMode()); } }
           NProperty _virtualizingStackPanelVirtualizationMode;

    public NProperty Visibility { get { return _visibility ?? (_visibility = NPropFactories.CreateVisibility()); } }
           NProperty _visibility;

    public NProperty Volume { get { return _volume ?? (_volume = NPropFactories.CreateVolume()); } }
           NProperty _volume;

    public NProperty Watermark { get { return _watermark ?? (_watermark = NPropFactories.CreateWatermark()); } }
           NProperty _watermark;

    public NProperty Width { get { return _width ?? (_width = NPropFactories.CreateWidth()); } }
           NProperty _width;

    public NProperty X1 { get { return _x1 ?? (_x1 = NPropFactories.CreateX1()); } }
           NProperty _x1;

    public NProperty X2 { get { return _x2 ?? (_x2 = NPropFactories.CreateX2()); } }
           NProperty _x2;

    public NProperty Xaml { get { return _xaml ?? (_xaml = NPropFactories.CreateXaml()); } }
           NProperty _xaml;

    public NProperty Y1 { get { return _y1 ?? (_y1 = NPropFactories.CreateY1()); } }
           NProperty _y1;

    public NProperty Y2 { get { return _y2 ?? (_y2 = NPropFactories.CreateY2()); } }
           NProperty _y2;

  }

  static partial class NPropFactories
  {
    public static NProperty CreateAcceptsReturn() => new NProperty(nameof(NProperties.AcceptsReturn)).
        Property<TextBox>(TextBox.AcceptsReturnProperty, NConverters.ToBool).
        Property<RichTextBox>(RichTextBox.AcceptsReturnProperty, NConverters.ToBool);

    public static NProperty CreateAllowDownloading() => new NProperty(nameof(NProperties.AllowDownloading)).
        Property<MultiScaleImage>(MultiScaleImage.AllowDownloadingProperty, NConverters.ToBool);

    public static NProperty CreateAllowDrop() => new NProperty(nameof(NProperties.AllowDrop)).
        Property<UIElement>(UIElement.AllowDropProperty, NConverters.ToBool);

    public static NProperty CreateAudioStreamIndex() => new NProperty(nameof(NProperties.AudioStreamIndex)).
        Property<MediaElement>(MediaElement.AudioStreamIndexProperty, NConverters.ToInt32N);

    public static NProperty CreateAutoPlay() => new NProperty(nameof(NProperties.AutoPlay)).
        Property<MediaElement>(MediaElement.AutoPlayProperty, NConverters.ToBool);

    public static NProperty CreateBackground() => new NProperty(nameof(NProperties.Background)).
        Property<Control>(Control.BackgroundProperty, NConverters.ToBrush).
        Property<Panel>(Panel.BackgroundProperty, NConverters.ToBrush).
        Property<Border>(Border.BackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateBalance() => new NProperty(nameof(NProperties.Balance)).
        Property<MediaElement>(MediaElement.BalanceProperty, NConverters.ToDouble);

    public static NProperty CreateBindingValidationError() => new NProperty(nameof(NProperties.BindingValidationError)).
        Event<FrameworkElement>((s, a) => s.BindingValidationError += a.EventHandler);

    public static NProperty CreateBlocks() => new NProperty(nameof(NProperties.Blocks)).
        Property<RichTextBox>((t, v) => NPatch.AssignListT(t.Blocks, v)).
        Property<RichTextBlock>((t, v) => NPatch.AssignListT(t.Blocks, v)).
        Property<Section>((t, v) => NPatch.AssignListT(t.Blocks, v));

    public static NProperty CreateBlurFactor() => new NProperty(nameof(NProperties.BlurFactor)).
        Property<MultiScaleImage>(MultiScaleImage.BlurFactorProperty, NConverters.ToDouble);

    public static NProperty CreateBorderBrush() => new NProperty(nameof(NProperties.BorderBrush)).
        Property<Control>(Control.BorderBrushProperty, NConverters.ToBrush).
        Property<Border>(Border.BorderBrushProperty, NConverters.ToBrush);

    public static NProperty CreateBorderThickness() => new NProperty(nameof(NProperties.BorderThickness)).
        Property<Control>(Control.BorderThicknessProperty, NConverters.ToThickness).
        Property<Border>(Border.BorderThicknessProperty, NConverters.ToThickness);

    public static NProperty CreateBufferingProgressChanged() => new NProperty(nameof(NProperties.BufferingProgressChanged)).
        Event<MediaElement>((s, a) => s.BufferingProgressChanged += a.EventHandler);

    public static NProperty CreateBufferingTime() => new NProperty(nameof(NProperties.BufferingTime)).
        Property<MediaElement>(MediaElement.BufferingTimeProperty, NConverters.ToTimeSpan);

    public static NProperty CreateCacheMode() => new NProperty(nameof(NProperties.CacheMode)).
        Property<UIElement>(UIElement.CacheModeProperty);

    public static NProperty CreateCanHorizontallyScroll() => new NProperty(nameof(NProperties.CanHorizontallyScroll)).
        Property<VirtualizingStackPanel>((t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v)).
        Property<ScrollContentPresenter>((t, v) => t.CanHorizontallyScroll = NConverters.ToBoolT(v));

    public static NProperty CreateCanvasLeft() => new NProperty(nameof(NProperties.CanvasLeft)).
        Property<UIElement>(Canvas.LeftProperty, NConverters.ToDouble);

    public static NProperty CreateCanvasTop() => new NProperty(nameof(NProperties.CanvasTop)).
        Property<UIElement>(Canvas.TopProperty, NConverters.ToDouble);

    public static NProperty CreateCanvasZIndex() => new NProperty(nameof(NProperties.CanvasZIndex)).
        Property<UIElement>(Canvas.ZIndexProperty, NConverters.ToInt32);

    public static NProperty CreateCanVerticallyScroll() => new NProperty(nameof(NProperties.CanVerticallyScroll)).
        Property<VirtualizingStackPanel>((t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v)).
        Property<ScrollContentPresenter>((t, v) => t.CanVerticallyScroll = NConverters.ToBoolT(v));

    public static NProperty CreateCaretBrush() => new NProperty(nameof(NProperties.CaretBrush)).
        Property<TextBox>(TextBox.CaretBrushProperty, NConverters.ToBrush).
        Property<RichTextBox>(RichTextBox.CaretBrushProperty, NConverters.ToBrush).
        Property<PasswordBox>(PasswordBox.CaretBrushProperty, NConverters.ToBrush);

    public static NProperty CreateCharacterSpacing() => new NProperty(nameof(NProperties.CharacterSpacing)).
        Property<Control>(Control.CharacterSpacingProperty, NConverters.ToInt32).
        Property<TextBlock>(TextBlock.CharacterSpacingProperty, NConverters.ToInt32).
        Property<RichTextBlock>(RichTextBlock.CharacterSpacingProperty, NConverters.ToInt32).
        Property<TextElement>(TextElement.CharacterSpacingProperty, NConverters.ToInt32);

    public static NProperty CreateChecked() => new NProperty(nameof(NProperties.Checked)).
        Event<ToggleButton>((s, a) => s.Checked += a.EventHandler);

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child)).
        Property<Viewbox>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v)).
        Property<Border>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v)).
        Property<Popup>(Popup.ChildProperty).
        Property<InlineUIContainer>((t, v) => NPatch.AssignSingle(o => o.Child, (o, i) => o.Child = i, t, v));

    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children)).
        Property<Panel>((t, v) => NPatch.AssignListT(t.Children, v));

    public static NProperty CreateCleanUpVirtualizedItemEvent() => new NProperty(nameof(NProperties.CleanUpVirtualizedItemEvent)).
        Event<VirtualizingStackPanel>((s, a) => s.CleanUpVirtualizedItemEvent += a.EventHandler);

    public static NProperty CreateClick() => new NProperty(nameof(NProperties.Click)).
        Event<ButtonBase>((s, a) => s.Click += a.EventHandler).
        Event<Hyperlink>((s, a) => s.Click += a.EventHandler);

    public static NProperty CreateClickMode() => new NProperty(nameof(NProperties.ClickMode)).
        Property<ButtonBase>(ButtonBase.ClickModeProperty, NConverters.ToEnum<ClickMode>);

    public static NProperty CreateClip() => new NProperty(nameof(NProperties.Clip)).
        Property<UIElement>(UIElement.ClipProperty);

    public static NProperty CreateClosed() => new NProperty(nameof(NProperties.Closed)).
        Event<ToolTip>((s, a) => s.Closed += a.EventHandler).
        Event<Popup>((s, a) => s.Closed += a.EventHandler);

    public static NProperty CreateColumnDefinitions() => new NProperty(nameof(NProperties.ColumnDefinitions)).
        Property<Grid>((t, v) => NPatch.AssignListT(t.ColumnDefinitions, v));

    public static NProperty CreateCommand() => new NProperty(nameof(NProperties.Command)).
        Property<ButtonBase>(ButtonBase.CommandProperty).
        Property<Hyperlink>(Hyperlink.CommandProperty);

    public static NProperty CreateCommandParameter() => new NProperty(nameof(NProperties.CommandParameter)).
        Property<ButtonBase>(ButtonBase.CommandParameterProperty).
        Property<Hyperlink>(Hyperlink.CommandParameterProperty);

    public static NProperty CreateContent() => new NProperty(nameof(NProperties.Content)).
        Property<ContentControl>(ContentControl.ContentProperty).
        Property<UserControl>(UserControl.ContentProperty).
        Property<ContentPresenter>(ContentPresenter.ContentProperty);

    public static NProperty CreateContentChanged() => new NProperty(nameof(NProperties.ContentChanged)).
        Event<RichTextBox>((s, a) => s.ContentChanged += a.EventHandler);

    public static NProperty CreateContentTemplate() => new NProperty(nameof(NProperties.ContentTemplate)).
        Property<ContentControl>(ContentControl.ContentTemplateProperty, NConverters.ToDataTemplate).
        Property<ContentPresenter>(ContentPresenter.ContentTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateCornerRadius() => new NProperty(nameof(NProperties.CornerRadius)).
        Property<Border>(Border.CornerRadiusProperty, NConverters.ToCornerRadius);

    public static NProperty CreateCurrentStateChanged() => new NProperty(nameof(NProperties.CurrentStateChanged)).
        Event<MediaElement>((s, a) => s.CurrentStateChanged += a.EventHandler);

    public static NProperty CreateCursor() => new NProperty(nameof(NProperties.Cursor)).
        Property<FrameworkElement>(FrameworkElement.CursorProperty, NConverters.ToCursor);

    public static NProperty CreateData() => new NProperty(nameof(NProperties.Data)).
        Property<Path>(Path.DataProperty);

    public static NProperty CreateDataContext() => new NProperty(nameof(NProperties.DataContext)).
        Property<FrameworkElement>(FrameworkElement.DataContextProperty);

    public static NProperty CreateDataContextChanged() => new NProperty(nameof(NProperties.DataContextChanged)).
        Event<FrameworkElement>((s, a) => s.DataContextChanged += a.EventHandlerAny);

    public static NProperty CreateDelay() => new NProperty(nameof(NProperties.Delay)).
        Property<RepeatButton>(RepeatButton.DelayProperty, NConverters.ToInt32);

    public static NProperty CreateDisplayMemberPath() => new NProperty(nameof(NProperties.DisplayMemberPath)).
        Property<ItemsControl>(ItemsControl.DisplayMemberPathProperty, NConverters.ToString);

    public static NProperty CreateDoubleTap() => new NProperty(nameof(NProperties.DoubleTap)).
        Event<UIElement>(UIElement.DoubleTapEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);

    public static NProperty CreateDownloadProgressChanged() => new NProperty(nameof(NProperties.DownloadProgressChanged)).
        Event<MediaElement>((s, a) => s.DownloadProgressChanged += a.EventHandler);

    public static NProperty CreateDragCompleted() => new NProperty(nameof(NProperties.DragCompleted)).
        Event<Thumb>((s, a) => s.DragCompleted += a.EventHandler);

    public static NProperty CreateDragDelta() => new NProperty(nameof(NProperties.DragDelta)).
        Event<Thumb>((s, a) => s.DragDelta += a.EventHandler);

    public static NProperty CreateDragEnter() => new NProperty(nameof(NProperties.DragEnter)).
        Event<UIElement>((s, a) => s.DragEnter += a.EventHandler);

    public static NProperty CreateDragLeave() => new NProperty(nameof(NProperties.DragLeave)).
        Event<UIElement>((s, a) => s.DragLeave += a.EventHandler);

    public static NProperty CreateDragOver() => new NProperty(nameof(NProperties.DragOver)).
        Event<UIElement>((s, a) => s.DragOver += a.EventHandler);

    public static NProperty CreateDragStarted() => new NProperty(nameof(NProperties.DragStarted)).
        Event<Thumb>((s, a) => s.DragStarted += a.EventHandler);

    public static NProperty CreateDrop() => new NProperty(nameof(NProperties.Drop)).
        Event<UIElement>((s, a) => s.Drop += a.EventHandler);

    public static NProperty CreateDropDownClosed() => new NProperty(nameof(NProperties.DropDownClosed)).
        Event<ComboBox>((s, a) => s.DropDownClosed += a.EventHandler);

    public static NProperty CreateDropDownOpened() => new NProperty(nameof(NProperties.DropDownOpened)).
        Event<ComboBox>((s, a) => s.DropDownOpened += a.EventHandler);

    public static NProperty CreateEffect() => new NProperty(nameof(NProperties.Effect)).
        Property<UIElement>(UIElement.EffectProperty);

    public static NProperty CreateFill() => new NProperty(nameof(NProperties.Fill)).
        Property<Shape>(Shape.FillProperty, NConverters.ToBrush).
        Property<Glyphs>(Glyphs.FillProperty, NConverters.ToBrush);

    public static NProperty CreateFillRule() => new NProperty(nameof(NProperties.FillRule)).
        Property<Polygon>(Polygon.FillRuleProperty, NConverters.ToEnum<FillRule>).
        Property<Polyline>(Polyline.FillRuleProperty, NConverters.ToEnum<FillRule>);

    public static NProperty CreateFlowDirection() => new NProperty(nameof(NProperties.FlowDirection)).
        Property<FrameworkElement>(FrameworkElement.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>).
        Property<Run>(Run.FlowDirectionProperty, NConverters.ToEnum<FlowDirection>);

    public static NProperty CreateFontFamily() => new NProperty(nameof(NProperties.FontFamily)).
        Property<Control>(Control.FontFamilyProperty, NConverters.ToFontFamily).
        Property<TextBlock>(TextBlock.FontFamilyProperty, NConverters.ToFontFamily).
        Property<RichTextBlock>(RichTextBlock.FontFamilyProperty, NConverters.ToFontFamily).
        Property<TextElement>(TextElement.FontFamilyProperty, NConverters.ToFontFamily);

    public static NProperty CreateFontRenderingEmSize() => new NProperty(nameof(NProperties.FontRenderingEmSize)).
        Property<Glyphs>(Glyphs.FontRenderingEmSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFontSize() => new NProperty(nameof(NProperties.FontSize)).
        Property<Control>(Control.FontSizeProperty, NConverters.ToDouble).
        Property<TextBlock>(TextBlock.FontSizeProperty, NConverters.ToDouble).
        Property<RichTextBlock>(RichTextBlock.FontSizeProperty, NConverters.ToDouble).
        Property<TextElement>(TextElement.FontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFontSource() => new NProperty(nameof(NProperties.FontSource)).
        Property<TextBox>((t, v) => t.FontSource = NConverters.ToFontSourceT(v)).
        Property<PasswordBox>((t, v) => t.FontSource = NConverters.ToFontSourceT(v)).
        Property<Glyphs>((t, v) => t.FontSource = NConverters.ToFontSourceT(v)).
        Property<TextBlock>((t, v) => t.FontSource = NConverters.ToFontSourceT(v));

    public static NProperty CreateFontStretch() => new NProperty(nameof(NProperties.FontStretch)).
        Property<Control>(Control.FontStretchProperty, NConverters.ToFontStretch).
        Property<TextBlock>(TextBlock.FontStretchProperty, NConverters.ToFontStretch).
        Property<RichTextBlock>(RichTextBlock.FontStretchProperty, NConverters.ToFontStretch).
        Property<TextElement>(TextElement.FontStretchProperty, NConverters.ToFontStretch);

    public static NProperty CreateFontStyle() => new NProperty(nameof(NProperties.FontStyle)).
        Property<Control>(Control.FontStyleProperty, NConverters.ToFontStyle).
        Property<TextBlock>(TextBlock.FontStyleProperty, NConverters.ToFontStyle).
        Property<RichTextBlock>(RichTextBlock.FontStyleProperty, NConverters.ToFontStyle).
        Property<TextElement>(TextElement.FontStyleProperty, NConverters.ToFontStyle);

    public static NProperty CreateFontUri() => new NProperty(nameof(NProperties.FontUri)).
        Property<Glyphs>(Glyphs.FontUriProperty, NConverters.ToUri);

    public static NProperty CreateFontWeight() => new NProperty(nameof(NProperties.FontWeight)).
        Property<Control>(Control.FontWeightProperty, NConverters.ToFontWeight).
        Property<TextBlock>(TextBlock.FontWeightProperty, NConverters.ToFontWeight).
        Property<RichTextBlock>(RichTextBlock.FontWeightProperty, NConverters.ToFontWeight).
        Property<TextElement>(TextElement.FontWeightProperty, NConverters.ToFontWeight);

    public static NProperty CreateForeground() => new NProperty(nameof(NProperties.Foreground)).
        Property<Control>(Control.ForegroundProperty, NConverters.ToBrush).
        Property<TextBlock>(TextBlock.ForegroundProperty, NConverters.ToBrush).
        Property<RichTextBlock>(RichTextBlock.ForegroundProperty, NConverters.ToBrush).
        Property<TextElement>(TextElement.ForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateGotFocus() => new NProperty(nameof(NProperties.GotFocus)).
        Event<UIElement>((s, a) => s.GotFocus += a.EventHandler);

    public static NProperty CreateGridColumn() => new NProperty(nameof(NProperties.GridColumn)).
        Property<FrameworkElement>(Grid.ColumnProperty, NConverters.ToInt32);

    public static NProperty CreateGridColumnSpan() => new NProperty(nameof(NProperties.GridColumnSpan)).
        Property<FrameworkElement>(Grid.ColumnSpanProperty, NConverters.ToInt32);

    public static NProperty CreateGridRow() => new NProperty(nameof(NProperties.GridRow)).
        Property<FrameworkElement>(Grid.RowProperty, NConverters.ToInt32);

    public static NProperty CreateGridRowSpan() => new NProperty(nameof(NProperties.GridRowSpan)).
        Property<FrameworkElement>(Grid.RowSpanProperty, NConverters.ToInt32);

    public static NProperty CreateGroupName() => new NProperty(nameof(NProperties.GroupName)).
        Property<RadioButton>(RadioButton.GroupNameProperty, NConverters.ToString);

    public static NProperty CreateHasTrailingParagraphBreakOnPaste() => new NProperty(nameof(NProperties.HasTrailingParagraphBreakOnPaste)).
        Property<Section>((t, v) => t.HasTrailingParagraphBreakOnPaste = NConverters.ToBoolT(v));

    public static NProperty CreateHeight() => new NProperty(nameof(NProperties.Height)).
        Property<FrameworkElement>(FrameworkElement.HeightProperty, NConverters.ToLength).
        Property<RowDefinition>(RowDefinition.HeightProperty, NConverters.ToGridLength);

    public static NProperty CreateHold() => new NProperty(nameof(NProperties.Hold)).
        Event<UIElement>(UIElement.HoldEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);

    public static NProperty CreateHorizontalAlignment() => new NProperty(nameof(NProperties.HorizontalAlignment)).
        Property<FrameworkElement>(FrameworkElement.HorizontalAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalContentAlignment() => new NProperty(nameof(NProperties.HorizontalContentAlignment)).
        Property<Control>(Control.HorizontalContentAlignmentProperty, NConverters.ToEnum<HorizontalAlignment>);

    public static NProperty CreateHorizontalOffset() => new NProperty(nameof(NProperties.HorizontalOffset)).
        Property<ToolTip>(ToolTip.HorizontalOffsetProperty, NConverters.ToDouble).
        Property<Popup>(Popup.HorizontalOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateHorizontalScrollBarVisibility() => new NProperty(nameof(NProperties.HorizontalScrollBarVisibility)).
        Property<TextBox>((t, v) => t.HorizontalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v)).
        Property<RichTextBox>((t, v) => t.HorizontalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v)).
        Property<ScrollViewer>(ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateImageFailed() => new NProperty(nameof(NProperties.ImageFailed)).
        Event<Image>((s, a) => s.ImageFailed += a.EventHandler).
        Event<MultiScaleImage>((s, a) => s.ImageFailed += a.EventHandler);

    public static NProperty CreateImageOpened() => new NProperty(nameof(NProperties.ImageOpened)).
        Event<Image>((s, a) => s.ImageOpened += a.EventHandler);

    public static NProperty CreateImageOpenFailed() => new NProperty(nameof(NProperties.ImageOpenFailed)).
        Event<MultiScaleImage>((s, a) => s.ImageOpenFailed += a.EventHandler);

    public static NProperty CreateImageOpenSucceeded() => new NProperty(nameof(NProperties.ImageOpenSucceeded)).
        Event<MultiScaleImage>((s, a) => s.ImageOpenSucceeded += a.EventHandler);

    public static NProperty CreateIndeterminate() => new NProperty(nameof(NProperties.Indeterminate)).
        Event<ToggleButton>((s, a) => s.Indeterminate += a.EventHandler);

    public static NProperty CreateIndices() => new NProperty(nameof(NProperties.Indices)).
        Property<Glyphs>(Glyphs.IndicesProperty, NConverters.ToString);

    public static NProperty CreateInlines() => new NProperty(nameof(NProperties.Inlines)).
        Property<TextBlock>((t, v) => NPatch.AssignListT(t.Inlines, v)).
        Property<Span>((t, v) => NPatch.AssignListT(t.Inlines, v)).
        Property<Paragraph>((t, v) => NPatch.AssignListT(t.Inlines, v));

    public static NProperty CreateInputScope() => new NProperty(nameof(NProperties.InputScope)).
        Property<TextBox>(TextBox.InputScopeProperty);

    public static NProperty CreateInterval() => new NProperty(nameof(NProperties.Interval)).
        Property<RepeatButton>(RepeatButton.IntervalProperty, NConverters.ToInt32);

    public static NProperty CreateIsChecked() => new NProperty(nameof(NProperties.IsChecked)).
        Property<ToggleButton>(ToggleButton.IsCheckedProperty, NConverters.ToBoolN);

    public static NProperty CreateIsDirectionReversed() => new NProperty(nameof(NProperties.IsDirectionReversed)).
        Property<Slider>(Slider.IsDirectionReversedProperty, NConverters.ToBool);

    public static NProperty CreateIsDropDownOpen() => new NProperty(nameof(NProperties.IsDropDownOpen)).
        Property<ComboBox>(ComboBox.IsDropDownOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsEnabled() => new NProperty(nameof(NProperties.IsEnabled)).
        Property<Control>(Control.IsEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsEnabledChanged() => new NProperty(nameof(NProperties.IsEnabledChanged)).
        Event<Control>((s, a) => s.IsEnabledChanged += a.EventHandlerAny);

    public static NProperty CreateIsHitTestVisible() => new NProperty(nameof(NProperties.IsHitTestVisible)).
        Property<UIElement>(UIElement.IsHitTestVisibleProperty, NConverters.ToBool);

    public static NProperty CreateIsIndeterminate() => new NProperty(nameof(NProperties.IsIndeterminate)).
        Property<ProgressBar>(ProgressBar.IsIndeterminateProperty, NConverters.ToBool);

    public static NProperty CreateIsMuted() => new NProperty(nameof(NProperties.IsMuted)).
        Property<MediaElement>(MediaElement.IsMutedProperty, NConverters.ToBool);

    public static NProperty CreateIsOpen() => new NProperty(nameof(NProperties.IsOpen)).
        Property<ToolTip>(ToolTip.IsOpenProperty, NConverters.ToBool).
        Property<Popup>(Popup.IsOpenProperty, NConverters.ToBool);

    public static NProperty CreateIsReadOnly() => new NProperty(nameof(NProperties.IsReadOnly)).
        Property<TextBox>(TextBox.IsReadOnlyProperty, NConverters.ToBool).
        Property<RichTextBox>(RichTextBox.IsReadOnlyProperty, NConverters.ToBool);

    public static NProperty CreateIsSelected() => new NProperty(nameof(NProperties.IsSelected)).
        Property<ListBoxItem>(ListBoxItem.IsSelectedProperty, NConverters.ToBool);

    public static NProperty CreateIsSynchronizedWithCurrentItem() => new NProperty(nameof(NProperties.IsSynchronizedWithCurrentItem)).
        Property<Selector>(Selector.IsSynchronizedWithCurrentItemProperty, NConverters.ToBoolN);

    public static NProperty CreateIsTabStop() => new NProperty(nameof(NProperties.IsTabStop)).
        Property<Control>(Control.IsTabStopProperty, NConverters.ToBool);

    public static NProperty CreateIsTextSelectionEnabled() => new NProperty(nameof(NProperties.IsTextSelectionEnabled)).
        Property<RichTextBlock>(RichTextBlock.IsTextSelectionEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsThreeState() => new NProperty(nameof(NProperties.IsThreeState)).
        Property<ToggleButton>(ToggleButton.IsThreeStateProperty, NConverters.ToBool);

    public static NProperty CreateItemContainerStyle() => new NProperty(nameof(NProperties.ItemContainerStyle)).
        Property<ComboBox>(ComboBox.ItemContainerStyleProperty, NConverters.ToStyle).
        Property<ListBox>(ListBox.ItemContainerStyleProperty, NConverters.ToStyle);

    public static NProperty CreateItems() => new NProperty(nameof(NProperties.Items)).
        Property<ItemsControl>((t, v) => NPatch.AssignListT(t.Items, v));

    public static NProperty CreateItemsPanel() => new NProperty(nameof(NProperties.ItemsPanel)).
        Property<ItemsControl>(ItemsControl.ItemsPanelProperty);

    public static NProperty CreateItemsSource() => new NProperty(nameof(NProperties.ItemsSource)).
        Property<ItemsControl>(ItemsControl.ItemsSourceProperty);

    public static NProperty CreateItemTemplate() => new NProperty(nameof(NProperties.ItemTemplate)).
        Property<ItemsControl>(ItemsControl.ItemTemplateProperty, NConverters.ToDataTemplate);

    public static NProperty CreateKeyDown() => new NProperty(nameof(NProperties.KeyDown)).
        Event<UIElement>(UIElement.KeyDownEvent, a => (KeyEventHandler)a.EventHandler);

    public static NProperty CreateKeyUp() => new NProperty(nameof(NProperties.KeyUp)).
        Event<UIElement>(UIElement.KeyUpEvent, a => (KeyEventHandler)a.EventHandler);

    public static NProperty CreateLanguage() => new NProperty(nameof(NProperties.Language)).
        Property<FrameworkElement>(FrameworkElement.LanguageProperty, NConverters.ToLanguage).
        Property<TextElement>(TextElement.LanguageProperty, NConverters.ToLanguage);

    public static NProperty CreateLargeChange() => new NProperty(nameof(NProperties.LargeChange)).
        Property<RangeBase>(RangeBase.LargeChangeProperty, NConverters.ToDouble);

    public static NProperty CreateLayoutUpdated() => new NProperty(nameof(NProperties.LayoutUpdated)).
        Event<FrameworkElement>((s, a) => s.LayoutUpdated += a.EventHandler);

    public static NProperty CreateLineHeight() => new NProperty(nameof(NProperties.LineHeight)).
        Property<TextBox>(TextBox.LineHeightProperty, NConverters.ToDouble).
        Property<RichTextBox>(RichTextBox.LineHeightProperty, NConverters.ToDouble).
        Property<TextBlock>(TextBlock.LineHeightProperty, NConverters.ToDouble).
        Property<RichTextBlock>(RichTextBlock.LineHeightProperty, NConverters.ToDouble).
        Property<Block>(Block.LineHeightProperty, NConverters.ToDouble);

    public static NProperty CreateLineStackingStrategy() => new NProperty(nameof(NProperties.LineStackingStrategy)).
        Property<TextBox>(TextBox.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<RichTextBox>(RichTextBox.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<TextBlock>(TextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<RichTextBlock>(RichTextBlock.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>).
        Property<Block>(Block.LineStackingStrategyProperty, NConverters.ToEnum<LineStackingStrategy>);

    public static NProperty CreateLoadCompleted() => new NProperty(nameof(NProperties.LoadCompleted)).
        Event<WebBrowser>((s, a) => s.LoadCompleted += a.EventHandler);

    public static NProperty CreateLoaded() => new NProperty(nameof(NProperties.Loaded)).
        Event<FrameworkElement>(FrameworkElement.LoadedEvent, a => (RoutedEventHandler)a.EventHandler);

    public static NProperty CreateLogReady() => new NProperty(nameof(NProperties.LogReady)).
        Event<MediaElement>((s, a) => s.LogReady += a.EventHandler);

    public static NProperty CreateLostFocus() => new NProperty(nameof(NProperties.LostFocus)).
        Event<UIElement>((s, a) => s.LostFocus += a.EventHandler);

    public static NProperty CreateLostMouseCapture() => new NProperty(nameof(NProperties.LostMouseCapture)).
        Event<UIElement>((s, a) => s.LostMouseCapture += a.EventHandler);

    public static NProperty CreateManipulationCompleted() => new NProperty(nameof(NProperties.ManipulationCompleted)).
        Event<UIElement>(UIElement.ManipulationCompletedEvent, a => (EventHandler<ManipulationCompletedEventArgs>)a.EventHandler);

    public static NProperty CreateManipulationDelta() => new NProperty(nameof(NProperties.ManipulationDelta)).
        Event<UIElement>(UIElement.ManipulationDeltaEvent, a => (EventHandler<ManipulationDeltaEventArgs>)a.EventHandler);

    public static NProperty CreateManipulationMode() => new NProperty(nameof(NProperties.ManipulationMode)).
        Property<ScrollViewer>(ScrollViewer.ManipulationModeProperty, NConverters.ToEnum<ManipulationMode>);

    public static NProperty CreateManipulationStarted() => new NProperty(nameof(NProperties.ManipulationStarted)).
        Event<UIElement>(UIElement.ManipulationStartedEvent, a => (EventHandler<ManipulationStartedEventArgs>)a.EventHandler);

    public static NProperty CreateMargin() => new NProperty(nameof(NProperties.Margin)).
        Property<FrameworkElement>(FrameworkElement.MarginProperty, NConverters.ToThickness);

    public static NProperty CreateMarkerReached() => new NProperty(nameof(NProperties.MarkerReached)).
        Event<MediaElement>((s, a) => s.MarkerReached += a.EventHandler);

    public static NProperty CreateMarkers() => new NProperty(nameof(NProperties.Markers)).
        Property<MediaElement>((t, v) => NPatch.AssignListT(t.Markers, v));

    public static NProperty CreateMaxDropDownHeight() => new NProperty(nameof(NProperties.MaxDropDownHeight)).
        Property<ComboBox>(ComboBox.MaxDropDownHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMaxHeight() => new NProperty(nameof(NProperties.MaxHeight)).
        Property<FrameworkElement>(FrameworkElement.MaxHeightProperty, NConverters.ToDouble).
        Property<RowDefinition>(RowDefinition.MaxHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMaximum() => new NProperty(nameof(NProperties.Maximum)).
        Property<RangeBase>(RangeBase.MaximumProperty, NConverters.ToDouble);

    public static NProperty CreateMaxLength() => new NProperty(nameof(NProperties.MaxLength)).
        Property<TextBox>(TextBox.MaxLengthProperty, NConverters.ToInt32).
        Property<PasswordBox>(PasswordBox.MaxLengthProperty, NConverters.ToInt32);

    public static NProperty CreateMaxWidth() => new NProperty(nameof(NProperties.MaxWidth)).
        Property<FrameworkElement>(FrameworkElement.MaxWidthProperty, NConverters.ToDouble).
        Property<ColumnDefinition>(ColumnDefinition.MaxWidthProperty, NConverters.ToDouble);

    public static NProperty CreateMediaCommand() => new NProperty(nameof(NProperties.MediaCommand)).
        Event<UIElement>((s, a) => s.MediaCommand += a.EventHandler);

    public static NProperty CreateMediaEnded() => new NProperty(nameof(NProperties.MediaEnded)).
        Event<MediaElement>((s, a) => s.MediaEnded += a.EventHandler);

    public static NProperty CreateMediaFailed() => new NProperty(nameof(NProperties.MediaFailed)).
        Event<MediaElement>((s, a) => s.MediaFailed += a.EventHandler);

    public static NProperty CreateMediaOpened() => new NProperty(nameof(NProperties.MediaOpened)).
        Event<MediaElement>((s, a) => s.MediaOpened += a.EventHandler);

    public static NProperty CreateMinHeight() => new NProperty(nameof(NProperties.MinHeight)).
        Property<FrameworkElement>(FrameworkElement.MinHeightProperty, NConverters.ToDouble).
        Property<RowDefinition>(RowDefinition.MinHeightProperty, NConverters.ToDouble);

    public static NProperty CreateMinimum() => new NProperty(nameof(NProperties.Minimum)).
        Property<RangeBase>(RangeBase.MinimumProperty, NConverters.ToDouble);

    public static NProperty CreateMinWidth() => new NProperty(nameof(NProperties.MinWidth)).
        Property<FrameworkElement>(FrameworkElement.MinWidthProperty, NConverters.ToDouble).
        Property<ColumnDefinition>(ColumnDefinition.MinWidthProperty, NConverters.ToDouble);

    public static NProperty CreateMotionFinished() => new NProperty(nameof(NProperties.MotionFinished)).
        Event<MultiScaleImage>((s, a) => s.MotionFinished += a.EventHandler);

    public static NProperty CreateMouseEnter() => new NProperty(nameof(NProperties.MouseEnter)).
        Event<UIElement>((s, a) => s.MouseEnter += a.EventHandler);

    public static NProperty CreateMouseLeave() => new NProperty(nameof(NProperties.MouseLeave)).
        Event<UIElement>((s, a) => s.MouseLeave += a.EventHandler);

    public static NProperty CreateMouseLeftButtonDown() => new NProperty(nameof(NProperties.MouseLeftButtonDown)).
        Event<UIElement>(UIElement.MouseLeftButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);

    public static NProperty CreateMouseLeftButtonUp() => new NProperty(nameof(NProperties.MouseLeftButtonUp)).
        Event<UIElement>(UIElement.MouseLeftButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);

    public static NProperty CreateMouseMove() => new NProperty(nameof(NProperties.MouseMove)).
        Event<UIElement>((s, a) => s.MouseMove += a.EventHandler);

    public static NProperty CreateMouseOverForeground() => new NProperty(nameof(NProperties.MouseOverForeground)).
        Property<Hyperlink>(Hyperlink.MouseOverForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateMouseOverTextDecorations() => new NProperty(nameof(NProperties.MouseOverTextDecorations)).
        Property<Hyperlink>(Hyperlink.MouseOverTextDecorationsProperty, NConverters.ToTextDecorations);

    public static NProperty CreateMouseRightButtonDown() => new NProperty(nameof(NProperties.MouseRightButtonDown)).
        Event<UIElement>(UIElement.MouseRightButtonDownEvent, a => (MouseButtonEventHandler)a.EventHandler);

    public static NProperty CreateMouseRightButtonUp() => new NProperty(nameof(NProperties.MouseRightButtonUp)).
        Event<UIElement>(UIElement.MouseRightButtonUpEvent, a => (MouseButtonEventHandler)a.EventHandler);

    public static NProperty CreateMouseWheel() => new NProperty(nameof(NProperties.MouseWheel)).
        Event<UIElement>(UIElement.MouseWheelEvent, a => (MouseWheelEventHandler)a.EventHandler);

    public static NProperty CreateName() => new NProperty(nameof(NProperties.Name)).
        Property<FrameworkElement>(FrameworkElement.NameProperty, NConverters.ToString);

    public static NProperty CreateNavigateUri() => new NProperty(nameof(NProperties.NavigateUri)).
        Property<HyperlinkButton>(HyperlinkButton.NavigateUriProperty, NConverters.ToUri).
        Property<Hyperlink>(Hyperlink.NavigateUriProperty, NConverters.ToUri);

    public static NProperty CreateOpacity() => new NProperty(nameof(NProperties.Opacity)).
        Property<UIElement>(UIElement.OpacityProperty, NConverters.ToDouble);

    public static NProperty CreateOpacityMask() => new NProperty(nameof(NProperties.OpacityMask)).
        Property<UIElement>(UIElement.OpacityMaskProperty, NConverters.ToBrush);

    public static NProperty CreateOpened() => new NProperty(nameof(NProperties.Opened)).
        Event<ToolTip>((s, a) => s.Opened += a.EventHandler).
        Event<Popup>((s, a) => s.Opened += a.EventHandler);

    public static NProperty CreateOrientation() => new NProperty(nameof(NProperties.Orientation)).
        Property<ScrollBar>(ScrollBar.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<Slider>(Slider.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<StackPanel>(StackPanel.OrientationProperty, NConverters.ToEnum<Orientation>).
        Property<VirtualizingStackPanel>(VirtualizingStackPanel.OrientationProperty, NConverters.ToEnum<Orientation>);

    public static NProperty CreateOriginX() => new NProperty(nameof(NProperties.OriginX)).
        Property<Glyphs>(Glyphs.OriginXProperty, NConverters.ToDouble);

    public static NProperty CreateOriginY() => new NProperty(nameof(NProperties.OriginY)).
        Property<Glyphs>(Glyphs.OriginYProperty, NConverters.ToDouble);

    public static NProperty CreateOverflowContentTarget() => new NProperty(nameof(NProperties.OverflowContentTarget)).
        Property<RichTextBlockOverflow>(RichTextBlockOverflow.OverflowContentTargetProperty).
        Property<RichTextBlock>(RichTextBlock.OverflowContentTargetProperty);

    public static NProperty CreatePadding() => new NProperty(nameof(NProperties.Padding)).
        Property<Control>(Control.PaddingProperty, NConverters.ToThickness).
        Property<TextBlock>(TextBlock.PaddingProperty, NConverters.ToThickness).
        Property<RichTextBlockOverflow>(RichTextBlockOverflow.PaddingProperty, NConverters.ToThickness).
        Property<RichTextBlock>(RichTextBlock.PaddingProperty, NConverters.ToThickness).
        Property<Border>(Border.PaddingProperty, NConverters.ToThickness);

    public static NProperty CreatePassword() => new NProperty(nameof(NProperties.Password)).
        Property<PasswordBox>(PasswordBox.PasswordProperty, NConverters.ToString);

    public static NProperty CreatePasswordChanged() => new NProperty(nameof(NProperties.PasswordChanged)).
        Event<PasswordBox>((s, a) => s.PasswordChanged += a.EventHandler);

    public static NProperty CreatePasswordChar() => new NProperty(nameof(NProperties.PasswordChar)).
        Property<PasswordBox>(PasswordBox.PasswordCharProperty, NConverters.ToChar);

    public static NProperty CreatePlacement() => new NProperty(nameof(NProperties.Placement)).
        Property<ToolTip>(ToolTip.PlacementProperty, NConverters.ToEnum<PlacementMode>);

    public static NProperty CreatePlacementTarget() => new NProperty(nameof(NProperties.PlacementTarget)).
        Property<ToolTip>(ToolTip.PlacementTargetProperty);

    public static NProperty CreatePlaybackRate() => new NProperty(nameof(NProperties.PlaybackRate)).
        Property<MediaElement>(MediaElement.PlaybackRateProperty, NConverters.ToDouble);

    public static NProperty CreatePoints() => new NProperty(nameof(NProperties.Points)).
        Property<Polygon>((t, v) => NPatch.AssignListT(t.Points, v)).
        Property<Polyline>((t, v) => NPatch.AssignListT(t.Points, v));

    public static NProperty CreatePosition() => new NProperty(nameof(NProperties.Position)).
        Property<MediaElement>(MediaElement.PositionProperty, NConverters.ToTimeSpan);

    public static NProperty CreateProjection() => new NProperty(nameof(NProperties.Projection)).
        Property<UIElement>(UIElement.ProjectionProperty);

    public static NProperty CreateRadiusX() => new NProperty(nameof(NProperties.RadiusX)).
        Property<Rectangle>(Rectangle.RadiusXProperty, NConverters.ToDouble);

    public static NProperty CreateRadiusY() => new NProperty(nameof(NProperties.RadiusY)).
        Property<Rectangle>(Rectangle.RadiusYProperty, NConverters.ToDouble);

    public static NProperty CreateRateChanged() => new NProperty(nameof(NProperties.RateChanged)).
        Event<MediaElement>((s, a) => s.RateChanged += a.EventHandler);

    public static NProperty CreateRenderTransform() => new NProperty(nameof(NProperties.RenderTransform)).
        Property<UIElement>(UIElement.RenderTransformProperty);

    public static NProperty CreateRenderTransformOrigin() => new NProperty(nameof(NProperties.RenderTransformOrigin)).
        Property<UIElement>(UIElement.RenderTransformOriginProperty, NConverters.ToPoint);

    public static NProperty CreateResources() => new NProperty(nameof(NProperties.Resources)).
        Property<FrameworkElement>((t, v) => t.Resources = NConverters.ToResourceDictionaryT(v));

    public static NProperty CreateRowDefinitions() => new NProperty(nameof(NProperties.RowDefinitions)).
        Property<Grid>((t, v) => NPatch.AssignListT(t.RowDefinitions, v));

    public static NProperty CreateScriptNotify() => new NProperty(nameof(NProperties.ScriptNotify)).
        Event<WebBrowser>((s, a) => s.ScriptNotify += a.EventHandler);

    public static NProperty CreateScroll() => new NProperty(nameof(NProperties.Scroll)).
        Event<ScrollBar>((s, a) => s.Scroll += a.EventHandler);

    public static NProperty CreateScrollViewerHorizontalScrollBarVisibility() => new NProperty(nameof(NProperties.ScrollViewerHorizontalScrollBarVisibility)).
        Property<DependencyObject>(ScrollViewer.HorizontalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateScrollViewerManipulationMode() => new NProperty(nameof(NProperties.ScrollViewerManipulationMode)).
        Property<DependencyObject>(ScrollViewer.ManipulationModeProperty, NConverters.ToEnum<ManipulationMode>);

    public static NProperty CreateScrollViewerVerticalScrollBarVisibility() => new NProperty(nameof(NProperties.ScrollViewerVerticalScrollBarVisibility)).
        Property<DependencyObject>(ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateSelectedIndex() => new NProperty(nameof(NProperties.SelectedIndex)).
        Property<Selector>(Selector.SelectedIndexProperty, NConverters.ToInt32);

    public static NProperty CreateSelectedItem() => new NProperty(nameof(NProperties.SelectedItem)).
        Property<Selector>(Selector.SelectedItemProperty);

    public static NProperty CreateSelectedItems() => new NProperty(nameof(NProperties.SelectedItems)).
        List<ListBox>(t => t.SelectedItems);

    public static NProperty CreateSelectedText() => new NProperty(nameof(NProperties.SelectedText)).
        Property<TextBox>((t, v) => t.SelectedText = NConverters.ToStringT(v));

    public static NProperty CreateSelectedValue() => new NProperty(nameof(NProperties.SelectedValue)).
        Property<Selector>(Selector.SelectedValueProperty);

    public static NProperty CreateSelectedValuePath() => new NProperty(nameof(NProperties.SelectedValuePath)).
        Property<Selector>(Selector.SelectedValuePathProperty, NConverters.ToString);

    public static NProperty CreateSelectionBackground() => new NProperty(nameof(NProperties.SelectionBackground)).
        Property<TextBox>(TextBox.SelectionBackgroundProperty, NConverters.ToBrush).
        Property<PasswordBox>(PasswordBox.SelectionBackgroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectionChanged() => new NProperty(nameof(NProperties.SelectionChanged)).
        Event<TextBox>((s, a) => s.SelectionChanged += a.EventHandler).
        Event<RichTextBox>((s, a) => s.SelectionChanged += a.EventHandler).
        Event<Selector>((s, a) => s.SelectionChanged += a.EventHandler).
        Event<RichTextBlock>((s, a) => s.SelectionChanged += a.EventHandler);

    public static NProperty CreateSelectionForeground() => new NProperty(nameof(NProperties.SelectionForeground)).
        Property<TextBox>(TextBox.SelectionForegroundProperty, NConverters.ToBrush).
        Property<PasswordBox>(PasswordBox.SelectionForegroundProperty, NConverters.ToBrush);

    public static NProperty CreateSelectionLength() => new NProperty(nameof(NProperties.SelectionLength)).
        Property<TextBox>((t, v) => t.SelectionLength = NConverters.ToInt32T(v));

    public static NProperty CreateSelectionMode() => new NProperty(nameof(NProperties.SelectionMode)).
        Property<ListBox>(ListBox.SelectionModeProperty, NConverters.ToEnum<SelectionMode>);

    public static NProperty CreateSelectionStart() => new NProperty(nameof(NProperties.SelectionStart)).
        Property<TextBox>((t, v) => t.SelectionStart = NConverters.ToInt32T(v));

    public static NProperty CreateShowGridLines() => new NProperty(nameof(NProperties.ShowGridLines)).
        Property<Grid>(Grid.ShowGridLinesProperty, NConverters.ToBool);

    public static NProperty CreateSizeChanged() => new NProperty(nameof(NProperties.SizeChanged)).
        Event<FrameworkElement>((s, a) => s.SizeChanged += a.EventHandler);

    public static NProperty CreateSkipLevels() => new NProperty(nameof(NProperties.SkipLevels)).
        Property<MultiScaleImage>(MultiScaleImage.SkipLevelsProperty, NConverters.ToInt32);

    public static NProperty CreateSmallChange() => new NProperty(nameof(NProperties.SmallChange)).
        Property<RangeBase>(RangeBase.SmallChangeProperty, NConverters.ToDouble);

    public static NProperty CreateSource() => new NProperty(nameof(NProperties.Source)).
        Property<Image>(Image.SourceProperty).
        Property<MediaElement>(MediaElement.SourceProperty, NConverters.ToUri).
        Property<MultiScaleImage>(MultiScaleImage.SourceProperty).
        Property<WebBrowser>((t, v) => t.Source = NConverters.ToUriT(v));

    public static NProperty CreateStretch() => new NProperty(nameof(NProperties.Stretch)).
        Property<Shape>(Shape.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<Image>(Image.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<MediaElement>(MediaElement.StretchProperty, NConverters.ToEnum<Stretch>).
        Property<Viewbox>(Viewbox.StretchProperty, NConverters.ToEnum<Stretch>);

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

    public static NProperty CreateStrokes() => new NProperty(nameof(NProperties.Strokes)).
        Property<InkPresenter>((t, v) => NPatch.AssignListT(t.Strokes, v));

    public static NProperty CreateStrokeStartLineCap() => new NProperty(nameof(NProperties.StrokeStartLineCap)).
        Property<Shape>(Shape.StrokeStartLineCapProperty, NConverters.ToEnum<PenLineCap>);

    public static NProperty CreateStrokeThickness() => new NProperty(nameof(NProperties.StrokeThickness)).
        Property<Shape>(Shape.StrokeThicknessProperty, NConverters.ToDouble);

    public static NProperty CreateStyle() => new NProperty(nameof(NProperties.Style)).
        Property<FrameworkElement>(FrameworkElement.StyleProperty, NConverters.ToStyle);

    public static NProperty CreateStyleSimulations() => new NProperty(nameof(NProperties.StyleSimulations)).
        Property<Glyphs>(Glyphs.StyleSimulationsProperty, NConverters.ToEnum<StyleSimulations>);

    public static NProperty CreateSubImageOpenFailed() => new NProperty(nameof(NProperties.SubImageOpenFailed)).
        Event<MultiScaleImage>((s, a) => s.SubImageOpenFailed += a.EventHandler);

    public static NProperty CreateSubImageOpenSucceeded() => new NProperty(nameof(NProperties.SubImageOpenSucceeded)).
        Event<MultiScaleImage>((s, a) => s.SubImageOpenSucceeded += a.EventHandler);

    public static NProperty CreateSubImages() => new NProperty(nameof(NProperties.SubImages)).
        Property<MultiScaleImage>((t, v) => NPatch.AssignListT(t.SubImages, v));

    public static NProperty CreateTabIndex() => new NProperty(nameof(NProperties.TabIndex)).
        Property<Control>(Control.TabIndexProperty, NConverters.ToInt32);

    public static NProperty CreateTabNavigation() => new NProperty(nameof(NProperties.TabNavigation)).
        Property<Control>(Control.TabNavigationProperty, NConverters.ToEnum<KeyboardNavigationMode>);

    public static NProperty CreateTag() => new NProperty(nameof(NProperties.Tag)).
        Property<FrameworkElement>(FrameworkElement.TagProperty);

    public static NProperty CreateTap() => new NProperty(nameof(NProperties.Tap)).
        Event<UIElement>(UIElement.TapEvent, a => (EventHandler<GestureEventArgs>)a.EventHandler);

    public static NProperty CreateTargetName() => new NProperty(nameof(NProperties.TargetName)).
        Property<HyperlinkButton>(HyperlinkButton.TargetNameProperty, NConverters.ToString).
        Property<Hyperlink>(Hyperlink.TargetNameProperty, NConverters.ToString);

    public static NProperty CreateTemplate() => new NProperty(nameof(NProperties.Template)).
        Property<Control>(Control.TemplateProperty, NConverters.ToControlTemplate);

    public static NProperty CreateText() => new NProperty(nameof(NProperties.Text)).
        Property<TextBox>(TextBox.TextProperty, NConverters.ToString).
        Property<TextBlock>(TextBlock.TextProperty, NConverters.ToString).
        Property<Run>((t, v) => t.Text = NConverters.ToStringT(v));

    public static NProperty CreateTextAlignment() => new NProperty(nameof(NProperties.TextAlignment)).
        Property<TextBox>(TextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<RichTextBox>(RichTextBox.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<TextBlock>(TextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<RichTextBlock>(RichTextBlock.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<Block>(Block.TextAlignmentProperty, NConverters.ToEnum<TextAlignment>);

    public static NProperty CreateTextChanged() => new NProperty(nameof(NProperties.TextChanged)).
        Event<TextBox>((s, a) => s.TextChanged += a.EventHandler);

    public static NProperty CreateTextDecorations() => new NProperty(nameof(NProperties.TextDecorations)).
        Property<TextBlock>(TextBlock.TextDecorationsProperty, NConverters.ToTextDecorations).
        Property<Inline>(Inline.TextDecorationsProperty, NConverters.ToTextDecorations);

    public static NProperty CreateTextInput() => new NProperty(nameof(NProperties.TextInput)).
        Event<UIElement>(UIElement.TextInputEvent, a => (TextCompositionEventHandler)a.EventHandler);

    public static NProperty CreateTextInputStart() => new NProperty(nameof(NProperties.TextInputStart)).
        Event<UIElement>(UIElement.TextInputStartEvent, a => (TextCompositionEventHandler)a.EventHandler);

    public static NProperty CreateTextInputUpdate() => new NProperty(nameof(NProperties.TextInputUpdate)).
        Event<UIElement>(UIElement.TextInputUpdateEvent, a => (TextCompositionEventHandler)a.EventHandler);

    public static NProperty CreateTextOptionsTextFormattingMode() => new NProperty(nameof(NProperties.TextOptionsTextFormattingMode)).
        Property<FrameworkElement>(TextOptions.TextFormattingModeProperty, NConverters.ToEnum<TextFormattingMode>);

    public static NProperty CreateTextOptionsTextHintingMode() => new NProperty(nameof(NProperties.TextOptionsTextHintingMode)).
        Property<FrameworkElement>(TextOptions.TextHintingModeProperty, NConverters.ToEnum<TextHintingMode>);

    public static NProperty CreateTextOptionsTextRenderingMode() => new NProperty(nameof(NProperties.TextOptionsTextRenderingMode)).
        Property<FrameworkElement>(TextOptions.TextRenderingModeProperty, NConverters.ToEnum<TextRenderingMode>);

    public static NProperty CreateTextTrimming() => new NProperty(nameof(NProperties.TextTrimming)).
        Property<TextBlock>(TextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>).
        Property<RichTextBlock>(RichTextBlock.TextTrimmingProperty, NConverters.ToEnum<TextTrimming>);

    public static NProperty CreateTextWrapping() => new NProperty(nameof(NProperties.TextWrapping)).
        Property<TextBox>(TextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<RichTextBox>(RichTextBox.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<TextBlock>(TextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>).
        Property<RichTextBlock>(RichTextBlock.TextWrappingProperty, NConverters.ToEnum<TextWrapping>);

    public static NProperty CreateToolTipServicePlacement() => new NProperty(nameof(NProperties.ToolTipServicePlacement)).
        Property<DependencyObject>(ToolTipService.PlacementProperty, NConverters.ToEnum<PlacementMode>);

    public static NProperty CreateToolTipServicePlacementTarget() => new NProperty(nameof(NProperties.ToolTipServicePlacementTarget)).
        Property<DependencyObject>(ToolTipService.PlacementTargetProperty);

    public static NProperty CreateToolTipServiceToolTip() => new NProperty(nameof(NProperties.ToolTipServiceToolTip)).
        Property<DependencyObject>(ToolTipService.ToolTipProperty);

    public static NProperty CreateTriggers() => new NProperty(nameof(NProperties.Triggers)).
        Property<FrameworkElement>((t, v) => NPatch.AssignListT(t.Triggers, v));

    public static NProperty CreateUnchecked() => new NProperty(nameof(NProperties.Unchecked)).
        Event<ToggleButton>((s, a) => s.Unchecked += a.EventHandler);

    public static NProperty CreateUnicodeString() => new NProperty(nameof(NProperties.UnicodeString)).
        Property<Glyphs>(Glyphs.UnicodeStringProperty, NConverters.ToString);

    public static NProperty CreateUnloaded() => new NProperty(nameof(NProperties.Unloaded)).
        Event<FrameworkElement>((s, a) => s.Unloaded += a.EventHandler);

    public static NProperty CreateUseLayoutRounding() => new NProperty(nameof(NProperties.UseLayoutRounding)).
        Property<UIElement>(UIElement.UseLayoutRoundingProperty, NConverters.ToBool);

    public static NProperty CreateUseSprings() => new NProperty(nameof(NProperties.UseSprings)).
        Property<MultiScaleImage>(MultiScaleImage.UseSpringsProperty, NConverters.ToBool);

    public static NProperty CreateValue() => new NProperty(nameof(NProperties.Value)).
        Property<RangeBase>(RangeBase.ValueProperty, NConverters.ToDouble);

    public static NProperty CreateValueChanged() => new NProperty(nameof(NProperties.ValueChanged)).
        Event<RangeBase>((s, a) => s.ValueChanged += a.EventHandler);

    public static NProperty CreateVerticalAlignment() => new NProperty(nameof(NProperties.VerticalAlignment)).
        Property<FrameworkElement>(FrameworkElement.VerticalAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalContentAlignment() => new NProperty(nameof(NProperties.VerticalContentAlignment)).
        Property<Control>(Control.VerticalContentAlignmentProperty, NConverters.ToEnum<VerticalAlignment>);

    public static NProperty CreateVerticalOffset() => new NProperty(nameof(NProperties.VerticalOffset)).
        Property<ToolTip>(ToolTip.VerticalOffsetProperty, NConverters.ToDouble).
        Property<Popup>(Popup.VerticalOffsetProperty, NConverters.ToDouble);

    public static NProperty CreateVerticalScrollBarVisibility() => new NProperty(nameof(NProperties.VerticalScrollBarVisibility)).
        Property<TextBox>((t, v) => t.VerticalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v)).
        Property<RichTextBox>((t, v) => t.VerticalScrollBarVisibility = NConverters.ToEnumT<ScrollBarVisibility>(v)).
        Property<ScrollViewer>(ScrollViewer.VerticalScrollBarVisibilityProperty, NConverters.ToEnum<ScrollBarVisibility>);

    public static NProperty CreateViewportChanged() => new NProperty(nameof(NProperties.ViewportChanged)).
        Event<MultiScaleImage>((s, a) => s.ViewportChanged += a.EventHandler);

    public static NProperty CreateViewportOrigin() => new NProperty(nameof(NProperties.ViewportOrigin)).
        Property<MultiScaleImage>(MultiScaleImage.ViewportOriginProperty, NConverters.ToPoint);

    public static NProperty CreateViewportSize() => new NProperty(nameof(NProperties.ViewportSize)).
        Property<ScrollBar>(ScrollBar.ViewportSizeProperty, NConverters.ToDouble);

    public static NProperty CreateViewportWidth() => new NProperty(nameof(NProperties.ViewportWidth)).
        Property<MultiScaleImage>(MultiScaleImage.ViewportWidthProperty, NConverters.ToDouble);

    public static NProperty CreateVirtualizingStackPanelVirtualizationMode() => new NProperty(nameof(NProperties.VirtualizingStackPanelVirtualizationMode)).
        Property<DependencyObject>(VirtualizingStackPanel.VirtualizationModeProperty, NConverters.ToEnum<VirtualizationMode>);

    public static NProperty CreateVisibility() => new NProperty(nameof(NProperties.Visibility)).
        Property<UIElement>(UIElement.VisibilityProperty, NConverters.ToEnum<Visibility>);

    public static NProperty CreateVolume() => new NProperty(nameof(NProperties.Volume)).
        Property<MediaElement>(MediaElement.VolumeProperty, NConverters.ToDouble);

    public static NProperty CreateWatermark() => new NProperty(nameof(NProperties.Watermark)).
        Property<TextBox>(TextBox.WatermarkProperty);

    public static NProperty CreateWidth() => new NProperty(nameof(NProperties.Width)).
        Property<FrameworkElement>(FrameworkElement.WidthProperty, NConverters.ToLength).
        Property<ColumnDefinition>(ColumnDefinition.WidthProperty, NConverters.ToGridLength);

    public static NProperty CreateX1() => new NProperty(nameof(NProperties.X1)).
        Property<Line>(Line.X1Property, NConverters.ToDouble);

    public static NProperty CreateX2() => new NProperty(nameof(NProperties.X2)).
        Property<Line>(Line.X2Property, NConverters.ToDouble);

    public static NProperty CreateXaml() => new NProperty(nameof(NProperties.Xaml)).
        Property<RichTextBox>((t, v) => t.Xaml = NConverters.ToStringT(v));

    public static NProperty CreateY1() => new NProperty(nameof(NProperties.Y1)).
        Property<Line>(Line.Y1Property, NConverters.ToDouble);

    public static NProperty CreateY2() => new NProperty(nameof(NProperties.Y2)).
        Property<Line>(Line.Y2Property, NConverters.ToDouble);

  }
}
