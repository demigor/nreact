using Android.App;
using Android.Content.PM;
using Android.Gestures;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.InputMethodServices;
using Android.Media;
using Android.Media.TV;
using Android.Opengl;
using Android.Text;
using Android.Text.Util;
using Android.Views;
using Android.Views.InputMethods;
using Android.Webkit;
using Android.Widget;
using aw = Android.Widget;
using System;

namespace NReact
{

  public partial class NProperties
  {
    public NProperty AccessibilityLiveRegion { get { return _accessibilityLiveRegion ?? (_accessibilityLiveRegion = NPropFactories.CreateAccessibilityLiveRegion()); } }
           NProperty _accessibilityLiveRegion;

    public NProperty AccessibilityTraversalAfter { get { return _accessibilityTraversalAfter ?? (_accessibilityTraversalAfter = NPropFactories.CreateAccessibilityTraversalAfter()); } }
           NProperty _accessibilityTraversalAfter;

    public NProperty AccessibilityTraversalBefore { get { return _accessibilityTraversalBefore ?? (_accessibilityTraversalBefore = NPropFactories.CreateAccessibilityTraversalBefore()); } }
           NProperty _accessibilityTraversalBefore;

    public NProperty Activated { get { return _activated ?? (_activated = NPropFactories.CreateActivated()); } }
           NProperty _activated;

    public NProperty AfterTextChanged { get { return _afterTextChanged ?? (_afterTextChanged = NPropFactories.CreateAfterTextChanged()); } }
           NProperty _afterTextChanged;

    public NProperty AlignmentMode { get { return _alignmentMode ?? (_alignmentMode = NPropFactories.CreateAlignmentMode()); } }
           NProperty _alignmentMode;

    public NProperty Alpha { get { return _alpha ?? (_alpha = NPropFactories.CreateAlpha()); } }
           NProperty _alpha;

    public NProperty AlwaysDrawnWithCacheEnabled { get { return _alwaysDrawnWithCacheEnabled ?? (_alwaysDrawnWithCacheEnabled = NPropFactories.CreateAlwaysDrawnWithCacheEnabled()); } }
           NProperty _alwaysDrawnWithCacheEnabled;

    public NProperty AnimationCacheEnabled { get { return _animationCacheEnabled ?? (_animationCacheEnabled = NPropFactories.CreateAnimationCacheEnabled()); } }
           NProperty _animationCacheEnabled;

    public NProperty AnimationEnd { get { return _animationEnd ?? (_animationEnd = NPropFactories.CreateAnimationEnd()); } }
           NProperty _animationEnd;

    public NProperty AnimationRepeat { get { return _animationRepeat ?? (_animationRepeat = NPropFactories.CreateAnimationRepeat()); } }
           NProperty _animationRepeat;

    public NProperty AnimationStart { get { return _animationStart ?? (_animationStart = NPropFactories.CreateAnimationStart()); } }
           NProperty _animationStart;

    public NProperty AutoLinkMask { get { return _autoLinkMask ?? (_autoLinkMask = NPropFactories.CreateAutoLinkMask()); } }
           NProperty _autoLinkMask;

    public NProperty AutoMirrored { get { return _autoMirrored ?? (_autoMirrored = NPropFactories.CreateAutoMirrored()); } }
           NProperty _autoMirrored;

    public NProperty AutoStart { get { return _autoStart ?? (_autoStart = NPropFactories.CreateAutoStart()); } }
           NProperty _autoStart;

    public NProperty BaselineAlignBottom { get { return _baselineAlignBottom ?? (_baselineAlignBottom = NPropFactories.CreateBaselineAlignBottom()); } }
           NProperty _baselineAlignBottom;

    public NProperty BaselineAligned { get { return _baselineAligned ?? (_baselineAligned = NPropFactories.CreateBaselineAligned()); } }
           NProperty _baselineAligned;

    public NProperty BaselineAlignedChildIndex { get { return _baselineAlignedChildIndex ?? (_baselineAlignedChildIndex = NPropFactories.CreateBaselineAlignedChildIndex()); } }
           NProperty _baselineAlignedChildIndex;

    public NProperty BeforeTextChanged { get { return _beforeTextChanged ?? (_beforeTextChanged = NPropFactories.CreateBeforeTextChanged()); } }
           NProperty _beforeTextChanged;

    public NProperty Bottom { get { return _bottom ?? (_bottom = NPropFactories.CreateBottom()); } }
           NProperty _bottom;

    public NProperty BreadCrumbClick { get { return _breadCrumbClick ?? (_breadCrumbClick = NPropFactories.CreateBreadCrumbClick()); } }
           NProperty _breadCrumbClick;

    public NProperty BreakStrategy { get { return _breakStrategy ?? (_breakStrategy = NPropFactories.CreateBreakStrategy()); } }
           NProperty _breakStrategy;

    public NProperty CalendarViewShown { get { return _calendarViewShown ?? (_calendarViewShown = NPropFactories.CreateCalendarViewShown()); } }
           NProperty _calendarViewShown;

    public NProperty ChangingConfigurations { get { return _changingConfigurations ?? (_changingConfigurations = NPropFactories.CreateChangingConfigurations()); } }
           NProperty _changingConfigurations;

    public NProperty Checked { get { return _checked ?? (_checked = NPropFactories.CreateChecked()); } }
           NProperty _checked;

    public NProperty CheckedChange { get { return _checkedChange ?? (_checkedChange = NPropFactories.CreateCheckedChange()); } }
           NProperty _checkedChange;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
           NProperty _child;

    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
           NProperty _children;

    public NProperty ChildViewAdded { get { return _childViewAdded ?? (_childViewAdded = NPropFactories.CreateChildViewAdded()); } }
           NProperty _childViewAdded;

    public NProperty ChildViewRemoved { get { return _childViewRemoved ?? (_childViewRemoved = NPropFactories.CreateChildViewRemoved()); } }
           NProperty _childViewRemoved;

    public NProperty ChronometerTick { get { return _chronometerTick ?? (_chronometerTick = NPropFactories.CreateChronometerTick()); } }
           NProperty _chronometerTick;

    public NProperty Click { get { return _click ?? (_click = NPropFactories.CreateClick()); } }
           NProperty _click;

    public NProperty Clickable { get { return _clickable ?? (_clickable = NPropFactories.CreateClickable()); } }
           NProperty _clickable;

    public NProperty ClipToOutline { get { return _clipToOutline ?? (_clipToOutline = NPropFactories.CreateClipToOutline()); } }
           NProperty _clipToOutline;

    public NProperty Close { get { return _close ?? (_close = NPropFactories.CreateClose()); } }
           NProperty _close;

    public NProperty ColumnCount { get { return _columnCount ?? (_columnCount = NPropFactories.CreateColumnCount()); } }
           NProperty _columnCount;

    public NProperty ColumnOrderPreserved { get { return _columnOrderPreserved ?? (_columnOrderPreserved = NPropFactories.CreateColumnOrderPreserved()); } }
           NProperty _columnOrderPreserved;

    public NProperty Completion { get { return _completion ?? (_completion = NPropFactories.CreateCompletion()); } }
           NProperty _completion;

    public NProperty CompoundDrawablePadding { get { return _compoundDrawablePadding ?? (_compoundDrawablePadding = NPropFactories.CreateCompoundDrawablePadding()); } }
           NProperty _compoundDrawablePadding;

    public NProperty ContentDescription { get { return _contentDescription ?? (_contentDescription = NPropFactories.CreateContentDescription()); } }
           NProperty _contentDescription;

    public NProperty ContextClick { get { return _contextClick ?? (_contextClick = NPropFactories.CreateContextClick()); } }
           NProperty _contextClick;

    public NProperty ContextClickable { get { return _contextClickable ?? (_contextClickable = NPropFactories.CreateContextClickable()); } }
           NProperty _contextClickable;

    public NProperty ContextMenuCreated { get { return _contextMenuCreated ?? (_contextMenuCreated = NPropFactories.CreateContextMenuCreated()); } }
           NProperty _contextMenuCreated;

    public NProperty CropToPadding { get { return _cropToPadding ?? (_cropToPadding = NPropFactories.CreateCropToPadding()); } }
           NProperty _cropToPadding;

    public NProperty CrossFadeEnabled { get { return _crossFadeEnabled ?? (_crossFadeEnabled = NPropFactories.CreateCrossFadeEnabled()); } }
           NProperty _crossFadeEnabled;

    public NProperty CurrentTab { get { return _currentTab ?? (_currentTab = NPropFactories.CreateCurrentTab()); } }
           NProperty _currentTab;

    public NProperty DateChange { get { return _dateChange ?? (_dateChange = NPropFactories.CreateDateChange()); } }
           NProperty _dateChange;

    public NProperty DateTextAppearance { get { return _dateTextAppearance ?? (_dateTextAppearance = NPropFactories.CreateDateTextAppearance()); } }
           NProperty _dateTextAppearance;

    public NProperty DebugFlags { get { return _debugFlags ?? (_debugFlags = NPropFactories.CreateDebugFlags()); } }
           NProperty _debugFlags;

    public NProperty DescendantFocusability { get { return _descendantFocusability ?? (_descendantFocusability = NPropFactories.CreateDescendantFocusability()); } }
           NProperty _descendantFocusability;

    public NProperty Dismiss { get { return _dismiss ?? (_dismiss = NPropFactories.CreateDismiss()); } }
           NProperty _dismiss;

    public NProperty DisplayedChild { get { return _displayedChild ?? (_displayedChild = NPropFactories.CreateDisplayedChild()); } }
           NProperty _displayedChild;

    public NProperty DividerPadding { get { return _dividerPadding ?? (_dividerPadding = NPropFactories.CreateDividerPadding()); } }
           NProperty _dividerPadding;

    public NProperty Download { get { return _download ?? (_download = NPropFactories.CreateDownload()); } }
           NProperty _download;

    public NProperty Drag { get { return _drag ?? (_drag = NPropFactories.CreateDrag()); } }
           NProperty _drag;

    public NProperty DrawerClose { get { return _drawerClose ?? (_drawerClose = NPropFactories.CreateDrawerClose()); } }
           NProperty _drawerClose;

    public NProperty DrawerOpen { get { return _drawerOpen ?? (_drawerOpen = NPropFactories.CreateDrawerOpen()); } }
           NProperty _drawerOpen;

    public NProperty DrawingCacheEnabled { get { return _drawingCacheEnabled ?? (_drawingCacheEnabled = NPropFactories.CreateDrawingCacheEnabled()); } }
           NProperty _drawingCacheEnabled;

    public NProperty DrawingCacheQuality { get { return _drawingCacheQuality ?? (_drawingCacheQuality = NPropFactories.CreateDrawingCacheQuality()); } }
           NProperty _drawingCacheQuality;

    public NProperty DropDownAnchor { get { return _dropDownAnchor ?? (_dropDownAnchor = NPropFactories.CreateDropDownAnchor()); } }
           NProperty _dropDownAnchor;

    public NProperty DropDownHeight { get { return _dropDownHeight ?? (_dropDownHeight = NPropFactories.CreateDropDownHeight()); } }
           NProperty _dropDownHeight;

    public NProperty DropDownHorizontalOffset { get { return _dropDownHorizontalOffset ?? (_dropDownHorizontalOffset = NPropFactories.CreateDropDownHorizontalOffset()); } }
           NProperty _dropDownHorizontalOffset;

    public NProperty DropDownVerticalOffset { get { return _dropDownVerticalOffset ?? (_dropDownVerticalOffset = NPropFactories.CreateDropDownVerticalOffset()); } }
           NProperty _dropDownVerticalOffset;

    public NProperty DropDownWidth { get { return _dropDownWidth ?? (_dropDownWidth = NPropFactories.CreateDropDownWidth()); } }
           NProperty _dropDownWidth;

    public NProperty DuplicateParentStateEnabled { get { return _duplicateParentStateEnabled ?? (_duplicateParentStateEnabled = NPropFactories.CreateDuplicateParentStateEnabled()); } }
           NProperty _duplicateParentStateEnabled;

    public NProperty EditorAction { get { return _editorAction ?? (_editorAction = NPropFactories.CreateEditorAction()); } }
           NProperty _editorAction;

    public NProperty Elevation { get { return _elevation ?? (_elevation = NPropFactories.CreateElevation()); } }
           NProperty _elevation;

    public NProperty Enabled { get { return _enabled ?? (_enabled = NPropFactories.CreateEnabled()); } }
           NProperty _enabled;

    public NProperty Error { get { return _error ?? (_error = NPropFactories.CreateError()); } }
           NProperty _error;

    public NProperty EventsInterceptionEnabled { get { return _eventsInterceptionEnabled ?? (_eventsInterceptionEnabled = NPropFactories.CreateEventsInterceptionEnabled()); } }
           NProperty _eventsInterceptionEnabled;

    public NProperty ExtendedSettingsClick { get { return _extendedSettingsClick ?? (_extendedSettingsClick = NPropFactories.CreateExtendedSettingsClick()); } }
           NProperty _extendedSettingsClick;

    public NProperty FadeEnabled { get { return _fadeEnabled ?? (_fadeEnabled = NPropFactories.CreateFadeEnabled()); } }
           NProperty _fadeEnabled;

    public NProperty FillViewport { get { return _fillViewport ?? (_fillViewport = NPropFactories.CreateFillViewport()); } }
           NProperty _fillViewport;

    public NProperty FilterTouchesWhenObscured { get { return _filterTouchesWhenObscured ?? (_filterTouchesWhenObscured = NPropFactories.CreateFilterTouchesWhenObscured()); } }
           NProperty _filterTouchesWhenObscured;

    public NProperty Find { get { return _find ?? (_find = NPropFactories.CreateFind()); } }
           NProperty _find;

    public NProperty FirstDayOfWeek { get { return _firstDayOfWeek ?? (_firstDayOfWeek = NPropFactories.CreateFirstDayOfWeek()); } }
           NProperty _firstDayOfWeek;

    public NProperty Focusable { get { return _focusable ?? (_focusable = NPropFactories.CreateFocusable()); } }
           NProperty _focusable;

    public NProperty FocusableInTouchMode { get { return _focusableInTouchMode ?? (_focusableInTouchMode = NPropFactories.CreateFocusableInTouchMode()); } }
           NProperty _focusableInTouchMode;

    public NProperty FocusChange { get { return _focusChange ?? (_focusChange = NPropFactories.CreateFocusChange()); } }
           NProperty _focusChange;

    public NProperty FontFeatureSettings { get { return _fontFeatureSettings ?? (_fontFeatureSettings = NPropFactories.CreateFontFeatureSettings()); } }
           NProperty _fontFeatureSettings;

    public NProperty Format { get { return _format ?? (_format = NPropFactories.CreateFormat()); } }
           NProperty _format;

    public NProperty Format12Hour { get { return _format12Hour ?? (_format12Hour = NPropFactories.CreateFormat12Hour()); } }
           NProperty _format12Hour;

    public NProperty Format24Hour { get { return _format24Hour ?? (_format24Hour = NPropFactories.CreateFormat24Hour()); } }
           NProperty _format24Hour;

    public NProperty FreezesText { get { return _freezesText ?? (_freezesText = NPropFactories.CreateFreezesText()); } }
           NProperty _freezesText;

    public NProperty FromDegrees { get { return _fromDegrees ?? (_fromDegrees = NPropFactories.CreateFromDegrees()); } }
           NProperty _fromDegrees;

    public NProperty GenericMotion { get { return _genericMotion ?? (_genericMotion = NPropFactories.CreateGenericMotion()); } }
           NProperty _genericMotion;

    public NProperty GestureCancelled { get { return _gestureCancelled ?? (_gestureCancelled = NPropFactories.CreateGestureCancelled()); } }
           NProperty _gestureCancelled;

    public NProperty GestureEnded { get { return _gestureEnded ?? (_gestureEnded = NPropFactories.CreateGestureEnded()); } }
           NProperty _gestureEnded;

    public NProperty GestureEvent { get { return _gestureEvent ?? (_gestureEvent = NPropFactories.CreateGestureEvent()); } }
           NProperty _gestureEvent;

    public NProperty GesturePerformed { get { return _gesturePerformed ?? (_gesturePerformed = NPropFactories.CreateGesturePerformed()); } }
           NProperty _gesturePerformed;

    public NProperty GestureStarted { get { return _gestureStarted ?? (_gestureStarted = NPropFactories.CreateGestureStarted()); } }
           NProperty _gestureStarted;

    public NProperty GestureStrokeAngleThreshold { get { return _gestureStrokeAngleThreshold ?? (_gestureStrokeAngleThreshold = NPropFactories.CreateGestureStrokeAngleThreshold()); } }
           NProperty _gestureStrokeAngleThreshold;

    public NProperty GestureStrokeLengthThreshold { get { return _gestureStrokeLengthThreshold ?? (_gestureStrokeLengthThreshold = NPropFactories.CreateGestureStrokeLengthThreshold()); } }
           NProperty _gestureStrokeLengthThreshold;

    public NProperty GestureStrokeSquarenessTreshold { get { return _gestureStrokeSquarenessTreshold ?? (_gestureStrokeSquarenessTreshold = NPropFactories.CreateGestureStrokeSquarenessTreshold()); } }
           NProperty _gestureStrokeSquarenessTreshold;

    public NProperty GestureStrokeType { get { return _gestureStrokeType ?? (_gestureStrokeType = NPropFactories.CreateGestureStrokeType()); } }
           NProperty _gestureStrokeType;

    public NProperty GestureStrokeWidth { get { return _gestureStrokeWidth ?? (_gestureStrokeWidth = NPropFactories.CreateGestureStrokeWidth()); } }
           NProperty _gestureStrokeWidth;

    public NProperty GestureVisible { get { return _gestureVisible ?? (_gestureVisible = NPropFactories.CreateGestureVisible()); } }
           NProperty _gestureVisible;

    public NProperty GesturingEnded { get { return _gesturingEnded ?? (_gesturingEnded = NPropFactories.CreateGesturingEnded()); } }
           NProperty _gesturingEnded;

    public NProperty GesturingStarted { get { return _gesturingStarted ?? (_gesturingStarted = NPropFactories.CreateGesturingStarted()); } }
           NProperty _gesturingStarted;

    public NProperty Gravity { get { return _gravity ?? (_gravity = NPropFactories.CreateGravity()); } }
           NProperty _gravity;

    public NProperty HapticFeedbackEnabled { get { return _hapticFeedbackEnabled ?? (_hapticFeedbackEnabled = NPropFactories.CreateHapticFeedbackEnabled()); } }
           NProperty _hapticFeedbackEnabled;

    public NProperty HasTransientState { get { return _hasTransientState ?? (_hasTransientState = NPropFactories.CreateHasTransientState()); } }
           NProperty _hasTransientState;

    public NProperty Hint { get { return _hint ?? (_hint = NPropFactories.CreateHint()); } }
           NProperty _hint;

    public NProperty HorizontalFadingEdgeEnabled { get { return _horizontalFadingEdgeEnabled ?? (_horizontalFadingEdgeEnabled = NPropFactories.CreateHorizontalFadingEdgeEnabled()); } }
           NProperty _horizontalFadingEdgeEnabled;

    public NProperty HorizontalScrollBarEnabled { get { return _horizontalScrollBarEnabled ?? (_horizontalScrollBarEnabled = NPropFactories.CreateHorizontalScrollBarEnabled()); } }
           NProperty _horizontalScrollBarEnabled;

    public NProperty Hour { get { return _hour ?? (_hour = NPropFactories.CreateHour()); } }
           NProperty _hour;

    public NProperty Hover { get { return _hover ?? (_hover = NPropFactories.CreateHover()); } }
           NProperty _hover;

    public NProperty Hovered { get { return _hovered ?? (_hovered = NPropFactories.CreateHovered()); } }
           NProperty _hovered;

    public NProperty HyphenationFrequency { get { return _hyphenationFrequency ?? (_hyphenationFrequency = NPropFactories.CreateHyphenationFrequency()); } }
           NProperty _hyphenationFrequency;

    public NProperty Iconified { get { return _iconified ?? (_iconified = NPropFactories.CreateIconified()); } }
           NProperty _iconified;

    public NProperty Id { get { return _id ?? (_id = NPropFactories.CreateId()); } }
           NProperty _id;

    public NProperty ImageAlpha { get { return _imageAlpha ?? (_imageAlpha = NPropFactories.CreateImageAlpha()); } }
           NProperty _imageAlpha;

    public NProperty ImeOptions { get { return _imeOptions ?? (_imeOptions = NPropFactories.CreateImeOptions()); } }
           NProperty _imeOptions;

    public NProperty ImportantForAccessibility { get { return _importantForAccessibility ?? (_importantForAccessibility = NPropFactories.CreateImportantForAccessibility()); } }
           NProperty _importantForAccessibility;

    public NProperty Indeterminate { get { return _indeterminate ?? (_indeterminate = NPropFactories.CreateIndeterminate()); } }
           NProperty _indeterminate;

    public NProperty InflatedId { get { return _inflatedId ?? (_inflatedId = NPropFactories.CreateInflatedId()); } }
           NProperty _inflatedId;

    public NProperty InflateEvent { get { return _inflateEvent ?? (_inflateEvent = NPropFactories.CreateInflateEvent()); } }
           NProperty _inflateEvent;

    public NProperty Info { get { return _info ?? (_info = NPropFactories.CreateInfo()); } }
           NProperty _info;

    public NProperty InputType { get { return _inputType ?? (_inputType = NPropFactories.CreateInputType()); } }
           NProperty _inputType;

    public NProperty IsIndicator { get { return _isIndicator ?? (_isIndicator = NPropFactories.CreateIsIndicator()); } }
           NProperty _isIndicator;

    public NProperty ItemClick { get { return _itemClick ?? (_itemClick = NPropFactories.CreateItemClick()); } }
           NProperty _itemClick;

    public NProperty ItemLongClick { get { return _itemLongClick ?? (_itemLongClick = NPropFactories.CreateItemLongClick()); } }
           NProperty _itemLongClick;

    public NProperty ItemSelected { get { return _itemSelected ?? (_itemSelected = NPropFactories.CreateItemSelected()); } }
           NProperty _itemSelected;

    public NProperty ItemSelectionCleared { get { return _itemSelectionCleared ?? (_itemSelectionCleared = NPropFactories.CreateItemSelectionCleared()); } }
           NProperty _itemSelectionCleared;

    public NProperty KeepScreenOn { get { return _keepScreenOn ?? (_keepScreenOn = NPropFactories.CreateKeepScreenOn()); } }
           NProperty _keepScreenOn;

    public NProperty Key { get { return _key ?? (_key = NPropFactories.CreateKey()); } }
           NProperty _key;

    public NProperty KeyPress { get { return _keyPress ?? (_keyPress = NPropFactories.CreateKeyPress()); } }
           NProperty _keyPress;

    public NProperty KeyProgressIncrement { get { return _keyProgressIncrement ?? (_keyProgressIncrement = NPropFactories.CreateKeyProgressIncrement()); } }
           NProperty _keyProgressIncrement;

    public NProperty LabelFor { get { return _labelFor ?? (_labelFor = NPropFactories.CreateLabelFor()); } }
           NProperty _labelFor;

    public NProperty LayoutChange { get { return _layoutChange ?? (_layoutChange = NPropFactories.CreateLayoutChange()); } }
           NProperty _layoutChange;

    public NProperty LayoutDirection { get { return _layoutDirection ?? (_layoutDirection = NPropFactories.CreateLayoutDirection()); } }
           NProperty _layoutDirection;

    public NProperty LayoutMode { get { return _layoutMode ?? (_layoutMode = NPropFactories.CreateLayoutMode()); } }
           NProperty _layoutMode;

    public NProperty LayoutResource { get { return _layoutResource ?? (_layoutResource = NPropFactories.CreateLayoutResource()); } }
           NProperty _layoutResource;

    public NProperty Left { get { return _left ?? (_left = NPropFactories.CreateLeft()); } }
           NProperty _left;

    public NProperty LetterSpacing { get { return _letterSpacing ?? (_letterSpacing = NPropFactories.CreateLetterSpacing()); } }
           NProperty _letterSpacing;

    public NProperty LinksClickable { get { return _linksClickable ?? (_linksClickable = NPropFactories.CreateLinksClickable()); } }
           NProperty _linksClickable;

    public NProperty ListSelection { get { return _listSelection ?? (_listSelection = NPropFactories.CreateListSelection()); } }
           NProperty _listSelection;

    public NProperty LogoDescription { get { return _logoDescription ?? (_logoDescription = NPropFactories.CreateLogoDescription()); } }
           NProperty _logoDescription;

    public NProperty LongClick { get { return _longClick ?? (_longClick = NPropFactories.CreateLongClick()); } }
           NProperty _longClick;

    public NProperty LongClickable { get { return _longClickable ?? (_longClickable = NPropFactories.CreateLongClickable()); } }
           NProperty _longClickable;

    public NProperty Max { get { return _max ?? (_max = NPropFactories.CreateMax()); } }
           NProperty _max;

    public NProperty MaxValue { get { return _maxValue ?? (_maxValue = NPropFactories.CreateMaxValue()); } }
           NProperty _maxValue;

    public NProperty MeasureAllChildren { get { return _measureAllChildren ?? (_measureAllChildren = NPropFactories.CreateMeasureAllChildren()); } }
           NProperty _measureAllChildren;

    public NProperty MeasureWithLargestChildEnabled { get { return _measureWithLargestChildEnabled ?? (_measureWithLargestChildEnabled = NPropFactories.CreateMeasureWithLargestChildEnabled()); } }
           NProperty _measureWithLargestChildEnabled;

    public NProperty MenuItemClick { get { return _menuItemClick ?? (_menuItemClick = NPropFactories.CreateMenuItemClick()); } }
           NProperty _menuItemClick;

    public NProperty Minute { get { return _minute ?? (_minute = NPropFactories.CreateMinute()); } }
           NProperty _minute;

    public NProperty MinValue { get { return _minValue ?? (_minValue = NPropFactories.CreateMinValue()); } }
           NProperty _minValue;

    public NProperty Mode { get { return _mode ?? (_mode = NPropFactories.CreateMode()); } }
           NProperty _mode;

    public NProperty MotionEventSplittingEnabled { get { return _motionEventSplittingEnabled ?? (_motionEventSplittingEnabled = NPropFactories.CreateMotionEventSplittingEnabled()); } }
           NProperty _motionEventSplittingEnabled;

    public NProperty NavigationContentDescription { get { return _navigationContentDescription ?? (_navigationContentDescription = NPropFactories.CreateNavigationContentDescription()); } }
           NProperty _navigationContentDescription;

    public NProperty NavigationOnClick { get { return _navigationOnClick ?? (_navigationOnClick = NPropFactories.CreateNavigationOnClick()); } }
           NProperty _navigationOnClick;

    public NProperty NestedScrollingEnabled { get { return _nestedScrollingEnabled ?? (_nestedScrollingEnabled = NPropFactories.CreateNestedScrollingEnabled()); } }
           NProperty _nestedScrollingEnabled;

    public NProperty NextClick { get { return _nextClick ?? (_nextClick = NPropFactories.CreateNextClick()); } }
           NProperty _nextClick;

    public NProperty NextFocusDownId { get { return _nextFocusDownId ?? (_nextFocusDownId = NPropFactories.CreateNextFocusDownId()); } }
           NProperty _nextFocusDownId;

    public NProperty NextFocusForwardId { get { return _nextFocusForwardId ?? (_nextFocusForwardId = NPropFactories.CreateNextFocusForwardId()); } }
           NProperty _nextFocusForwardId;

    public NProperty NextFocusLeftId { get { return _nextFocusLeftId ?? (_nextFocusLeftId = NPropFactories.CreateNextFocusLeftId()); } }
           NProperty _nextFocusLeftId;

    public NProperty NextFocusRightId { get { return _nextFocusRightId ?? (_nextFocusRightId = NPropFactories.CreateNextFocusRightId()); } }
           NProperty _nextFocusRightId;

    public NProperty NextFocusUpId { get { return _nextFocusUpId ?? (_nextFocusUpId = NPropFactories.CreateNextFocusUpId()); } }
           NProperty _nextFocusUpId;

    public NProperty NothingSelected { get { return _nothingSelected ?? (_nothingSelected = NPropFactories.CreateNothingSelected()); } }
           NProperty _nothingSelected;

    public NProperty NumStars { get { return _numStars ?? (_numStars = NPropFactories.CreateNumStars()); } }
           NProperty _numStars;

    public NProperty OneShot { get { return _oneShot ?? (_oneShot = NPropFactories.CreateOneShot()); } }
           NProperty _oneShot;

    public NProperty Orientation { get { return _orientation ?? (_orientation = NPropFactories.CreateOrientation()); } }
           NProperty _orientation;

    public NProperty OverScrollMode { get { return _overScrollMode ?? (_overScrollMode = NPropFactories.CreateOverScrollMode()); } }
           NProperty _overScrollMode;

    public NProperty PaddingMode { get { return _paddingMode ?? (_paddingMode = NPropFactories.CreatePaddingMode()); } }
           NProperty _paddingMode;

    public NProperty PaintFlags { get { return _paintFlags ?? (_paintFlags = NPropFactories.CreatePaintFlags()); } }
           NProperty _paintFlags;

    public NProperty PersistentDrawingCache { get { return _persistentDrawingCache ?? (_persistentDrawingCache = NPropFactories.CreatePersistentDrawingCache()); } }
           NProperty _persistentDrawingCache;

    public NProperty Picture { get { return _picture ?? (_picture = NPropFactories.CreatePicture()); } }
           NProperty _picture;

    public NProperty PivotX { get { return _pivotX ?? (_pivotX = NPropFactories.CreatePivotX()); } }
           NProperty _pivotX;

    public NProperty PivotXRelative { get { return _pivotXRelative ?? (_pivotXRelative = NPropFactories.CreatePivotXRelative()); } }
           NProperty _pivotXRelative;

    public NProperty PivotY { get { return _pivotY ?? (_pivotY = NPropFactories.CreatePivotY()); } }
           NProperty _pivotY;

    public NProperty PivotYRelative { get { return _pivotYRelative ?? (_pivotYRelative = NPropFactories.CreatePivotYRelative()); } }
           NProperty _pivotYRelative;

    public NProperty PopupTheme { get { return _popupTheme ?? (_popupTheme = NPropFactories.CreatePopupTheme()); } }
           NProperty _popupTheme;

    public NProperty Prepared { get { return _prepared ?? (_prepared = NPropFactories.CreatePrepared()); } }
           NProperty _prepared;

    public NProperty PreserveEGLContextOnPause { get { return _preserveEGLContextOnPause ?? (_preserveEGLContextOnPause = NPropFactories.CreatePreserveEGLContextOnPause()); } }
           NProperty _preserveEGLContextOnPause;

    public NProperty Press { get { return _press ?? (_press = NPropFactories.CreatePress()); } }
           NProperty _press;

    public NProperty Pressed { get { return _pressed ?? (_pressed = NPropFactories.CreatePressed()); } }
           NProperty _pressed;

    public NProperty PreviewEnabled { get { return _previewEnabled ?? (_previewEnabled = NPropFactories.CreatePreviewEnabled()); } }
           NProperty _previewEnabled;

    public NProperty PreviousClick { get { return _previousClick ?? (_previousClick = NPropFactories.CreatePreviousClick()); } }
           NProperty _previousClick;

    public NProperty PrivateImeOptions { get { return _privateImeOptions ?? (_privateImeOptions = NPropFactories.CreatePrivateImeOptions()); } }
           NProperty _privateImeOptions;

    public NProperty Progress { get { return _progress ?? (_progress = NPropFactories.CreateProgress()); } }
           NProperty _progress;

    public NProperty ProgressChanged { get { return _progressChanged ?? (_progressChanged = NPropFactories.CreateProgressChanged()); } }
           NProperty _progressChanged;

    public NProperty ProximityCorrectionEnabled { get { return _proximityCorrectionEnabled ?? (_proximityCorrectionEnabled = NPropFactories.CreateProximityCorrectionEnabled()); } }
           NProperty _proximityCorrectionEnabled;

    public NProperty QueryRefinementEnabled { get { return _queryRefinementEnabled ?? (_queryRefinementEnabled = NPropFactories.CreateQueryRefinementEnabled()); } }
           NProperty _queryRefinementEnabled;

    public NProperty QueryTextChange { get { return _queryTextChange ?? (_queryTextChange = NPropFactories.CreateQueryTextChange()); } }
           NProperty _queryTextChange;

    public NProperty QueryTextFocusChange { get { return _queryTextFocusChange ?? (_queryTextFocusChange = NPropFactories.CreateQueryTextFocusChange()); } }
           NProperty _queryTextFocusChange;

    public NProperty QueryTextSubmit { get { return _queryTextSubmit ?? (_queryTextSubmit = NPropFactories.CreateQueryTextSubmit()); } }
           NProperty _queryTextSubmit;

    public NProperty Radius { get { return _radius ?? (_radius = NPropFactories.CreateRadius()); } }
           NProperty _radius;

    public NProperty Rating { get { return _rating ?? (_rating = NPropFactories.CreateRating()); } }
           NProperty _rating;

    public NProperty RatingBarChange { get { return _ratingBarChange ?? (_ratingBarChange = NPropFactories.CreateRatingBarChange()); } }
           NProperty _ratingBarChange;

    public NProperty Release { get { return _release ?? (_release = NPropFactories.CreateRelease()); } }
           NProperty _release;

    public NProperty RenderMode { get { return _renderMode ?? (_renderMode = NPropFactories.CreateRenderMode()); } }
           NProperty _renderMode;

    public NProperty Right { get { return _right ?? (_right = NPropFactories.CreateRight()); } }
           NProperty _right;

    public NProperty Rotation { get { return _rotation ?? (_rotation = NPropFactories.CreateRotation()); } }
           NProperty _rotation;

    public NProperty RotationX { get { return _rotationX ?? (_rotationX = NPropFactories.CreateRotationX()); } }
           NProperty _rotationX;

    public NProperty RotationY { get { return _rotationY ?? (_rotationY = NPropFactories.CreateRotationY()); } }
           NProperty _rotationY;

    public NProperty RouteTypes { get { return _routeTypes ?? (_routeTypes = NPropFactories.CreateRouteTypes()); } }
           NProperty _routeTypes;

    public NProperty RowCount { get { return _rowCount ?? (_rowCount = NPropFactories.CreateRowCount()); } }
           NProperty _rowCount;

    public NProperty RowOrderPreserved { get { return _rowOrderPreserved ?? (_rowOrderPreserved = NPropFactories.CreateRowOrderPreserved()); } }
           NProperty _rowOrderPreserved;

    public NProperty SaveEnabled { get { return _saveEnabled ?? (_saveEnabled = NPropFactories.CreateSaveEnabled()); } }
           NProperty _saveEnabled;

    public NProperty SaveFromParentEnabled { get { return _saveFromParentEnabled ?? (_saveFromParentEnabled = NPropFactories.CreateSaveFromParentEnabled()); } }
           NProperty _saveFromParentEnabled;

    public NProperty ScaleX { get { return _scaleX ?? (_scaleX = NPropFactories.CreateScaleX()); } }
           NProperty _scaleX;

    public NProperty ScaleY { get { return _scaleY ?? (_scaleY = NPropFactories.CreateScaleY()); } }
           NProperty _scaleY;

    public NProperty Scroll { get { return _scroll ?? (_scroll = NPropFactories.CreateScroll()); } }
           NProperty _scroll;

    public NProperty ScrollBarDefaultDelayBeforeFade { get { return _scrollBarDefaultDelayBeforeFade ?? (_scrollBarDefaultDelayBeforeFade = NPropFactories.CreateScrollBarDefaultDelayBeforeFade()); } }
           NProperty _scrollBarDefaultDelayBeforeFade;

    public NProperty ScrollBarFadeDuration { get { return _scrollBarFadeDuration ?? (_scrollBarFadeDuration = NPropFactories.CreateScrollBarFadeDuration()); } }
           NProperty _scrollBarFadeDuration;

    public NProperty ScrollbarFadingEnabled { get { return _scrollbarFadingEnabled ?? (_scrollbarFadingEnabled = NPropFactories.CreateScrollbarFadingEnabled()); } }
           NProperty _scrollbarFadingEnabled;

    public NProperty ScrollBarSize { get { return _scrollBarSize ?? (_scrollBarSize = NPropFactories.CreateScrollBarSize()); } }
           NProperty _scrollBarSize;

    public NProperty ScrollBarStyle { get { return _scrollBarStyle ?? (_scrollBarStyle = NPropFactories.CreateScrollBarStyle()); } }
           NProperty _scrollBarStyle;

    public NProperty ScrollChange { get { return _scrollChange ?? (_scrollChange = NPropFactories.CreateScrollChange()); } }
           NProperty _scrollChange;

    public NProperty ScrollEnded { get { return _scrollEnded ?? (_scrollEnded = NPropFactories.CreateScrollEnded()); } }
           NProperty _scrollEnded;

    public NProperty ScrollStarted { get { return _scrollStarted ?? (_scrollStarted = NPropFactories.CreateScrollStarted()); } }
           NProperty _scrollStarted;

    public NProperty ScrollX { get { return _scrollX ?? (_scrollX = NPropFactories.CreateScrollX()); } }
           NProperty _scrollX;

    public NProperty ScrollY { get { return _scrollY ?? (_scrollY = NPropFactories.CreateScrollY()); } }
           NProperty _scrollY;

    public NProperty SearchClick { get { return _searchClick ?? (_searchClick = NPropFactories.CreateSearchClick()); } }
           NProperty _searchClick;

    public NProperty SecondaryProgress { get { return _secondaryProgress ?? (_secondaryProgress = NPropFactories.CreateSecondaryProgress()); } }
           NProperty _secondaryProgress;

    public NProperty Selected { get { return _selected ?? (_selected = NPropFactories.CreateSelected()); } }
           NProperty _selected;

    public NProperty ShowDividers { get { return _showDividers ?? (_showDividers = NPropFactories.CreateShowDividers()); } }
           NProperty _showDividers;

    public NProperty ShownWeekCount { get { return _shownWeekCount ?? (_shownWeekCount = NPropFactories.CreateShownWeekCount()); } }
           NProperty _shownWeekCount;

    public NProperty ShowSoftInputOnFocus { get { return _showSoftInputOnFocus ?? (_showSoftInputOnFocus = NPropFactories.CreateShowSoftInputOnFocus()); } }
           NProperty _showSoftInputOnFocus;

    public NProperty ShowText { get { return _showText ?? (_showText = NPropFactories.CreateShowText()); } }
           NProperty _showText;

    public NProperty ShowWeekNumber { get { return _showWeekNumber ?? (_showWeekNumber = NPropFactories.CreateShowWeekNumber()); } }
           NProperty _showWeekNumber;

    public NProperty ShrinkAllColumns { get { return _shrinkAllColumns ?? (_shrinkAllColumns = NPropFactories.CreateShrinkAllColumns()); } }
           NProperty _shrinkAllColumns;

    public NProperty SmoothScrollingEnabled { get { return _smoothScrollingEnabled ?? (_smoothScrollingEnabled = NPropFactories.CreateSmoothScrollingEnabled()); } }
           NProperty _smoothScrollingEnabled;

    public NProperty SoundEffectsEnabled { get { return _soundEffectsEnabled ?? (_soundEffectsEnabled = NPropFactories.CreateSoundEffectsEnabled()); } }
           NProperty _soundEffectsEnabled;

    public NProperty SpinnersShown { get { return _spinnersShown ?? (_spinnersShown = NPropFactories.CreateSpinnersShown()); } }
           NProperty _spinnersShown;

    public NProperty SplitTrack { get { return _splitTrack ?? (_splitTrack = NPropFactories.CreateSplitTrack()); } }
           NProperty _splitTrack;

    public NProperty StartTrackingTouch { get { return _startTrackingTouch ?? (_startTrackingTouch = NPropFactories.CreateStartTrackingTouch()); } }
           NProperty _startTrackingTouch;

    public NProperty StepSize { get { return _stepSize ?? (_stepSize = NPropFactories.CreateStepSize()); } }
           NProperty _stepSize;

    public NProperty StopTrackingTouch { get { return _stopTrackingTouch ?? (_stopTrackingTouch = NPropFactories.CreateStopTrackingTouch()); } }
           NProperty _stopTrackingTouch;

    public NProperty StretchAllColumns { get { return _stretchAllColumns ?? (_stretchAllColumns = NPropFactories.CreateStretchAllColumns()); } }
           NProperty _stretchAllColumns;

    public NProperty StripEnabled { get { return _stripEnabled ?? (_stripEnabled = NPropFactories.CreateStripEnabled()); } }
           NProperty _stripEnabled;

    public NProperty SubmitButtonEnabled { get { return _submitButtonEnabled ?? (_submitButtonEnabled = NPropFactories.CreateSubmitButtonEnabled()); } }
           NProperty _submitButtonEnabled;

    public NProperty Subtitle { get { return _subtitle ?? (_subtitle = NPropFactories.CreateSubtitle()); } }
           NProperty _subtitle;

    public NProperty SuggestionClick { get { return _suggestionClick ?? (_suggestionClick = NPropFactories.CreateSuggestionClick()); } }
           NProperty _suggestionClick;

    public NProperty SuggestionSelect { get { return _suggestionSelect ?? (_suggestionSelect = NPropFactories.CreateSuggestionSelect()); } }
           NProperty _suggestionSelect;

    public NProperty SurfaceTextureAvailable { get { return _surfaceTextureAvailable ?? (_surfaceTextureAvailable = NPropFactories.CreateSurfaceTextureAvailable()); } }
           NProperty _surfaceTextureAvailable;

    public NProperty SurfaceTextureDestroyed { get { return _surfaceTextureDestroyed ?? (_surfaceTextureDestroyed = NPropFactories.CreateSurfaceTextureDestroyed()); } }
           NProperty _surfaceTextureDestroyed;

    public NProperty SurfaceTextureSizeChanged { get { return _surfaceTextureSizeChanged ?? (_surfaceTextureSizeChanged = NPropFactories.CreateSurfaceTextureSizeChanged()); } }
           NProperty _surfaceTextureSizeChanged;

    public NProperty SurfaceTextureUpdated { get { return _surfaceTextureUpdated ?? (_surfaceTextureUpdated = NPropFactories.CreateSurfaceTextureUpdated()); } }
           NProperty _surfaceTextureUpdated;

    public NProperty SwipeDownEvent { get { return _swipeDownEvent ?? (_swipeDownEvent = NPropFactories.CreateSwipeDownEvent()); } }
           NProperty _swipeDownEvent;

    public NProperty SwipeLeftEvent { get { return _swipeLeftEvent ?? (_swipeLeftEvent = NPropFactories.CreateSwipeLeftEvent()); } }
           NProperty _swipeLeftEvent;

    public NProperty SwipeRightEvent { get { return _swipeRightEvent ?? (_swipeRightEvent = NPropFactories.CreateSwipeRightEvent()); } }
           NProperty _swipeRightEvent;

    public NProperty SwipeUpEvent { get { return _swipeUpEvent ?? (_swipeUpEvent = NPropFactories.CreateSwipeUpEvent()); } }
           NProperty _swipeUpEvent;

    public NProperty SwitchMinWidth { get { return _switchMinWidth ?? (_switchMinWidth = NPropFactories.CreateSwitchMinWidth()); } }
           NProperty _switchMinWidth;

    public NProperty SwitchPadding { get { return _switchPadding ?? (_switchPadding = NPropFactories.CreateSwitchPadding()); } }
           NProperty _switchPadding;

    public NProperty SystemUiVisibility { get { return _systemUiVisibility ?? (_systemUiVisibility = NPropFactories.CreateSystemUiVisibility()); } }
           NProperty _systemUiVisibility;

    public NProperty SystemUiVisibilityChange { get { return _systemUiVisibilityChange ?? (_systemUiVisibilityChange = NPropFactories.CreateSystemUiVisibilityChange()); } }
           NProperty _systemUiVisibilityChange;

    public NProperty TabChanged { get { return _tabChanged ?? (_tabChanged = NPropFactories.CreateTabChanged()); } }
           NProperty _tabChanged;

    public NProperty Text { get { return _text ?? (_text = NPropFactories.CreateText()); } }
           NProperty _text;

    public NProperty TextAlignment { get { return _textAlignment ?? (_textAlignment = NPropFactories.CreateTextAlignment()); } }
           NProperty _textAlignment;

    public NProperty TextChanged { get { return _textChanged ?? (_textChanged = NPropFactories.CreateTextChanged()); } }
           NProperty _textChanged;

    public NProperty TextDirection { get { return _textDirection ?? (_textDirection = NPropFactories.CreateTextDirection()); } }
           NProperty _textDirection;

    public NProperty TextOff { get { return _textOff ?? (_textOff = NPropFactories.CreateTextOff()); } }
           NProperty _textOff;

    public NProperty TextOn { get { return _textOn ?? (_textOn = NPropFactories.CreateTextOn()); } }
           NProperty _textOn;

    public NProperty TextScaleX { get { return _textScaleX ?? (_textScaleX = NPropFactories.CreateTextScaleX()); } }
           NProperty _textScaleX;

    public NProperty TextSize { get { return _textSize ?? (_textSize = NPropFactories.CreateTextSize()); } }
           NProperty _textSize;

    public NProperty Threshold { get { return _threshold ?? (_threshold = NPropFactories.CreateThreshold()); } }
           NProperty _threshold;

    public NProperty ThumbOffset { get { return _thumbOffset ?? (_thumbOffset = NPropFactories.CreateThumbOffset()); } }
           NProperty _thumbOffset;

    public NProperty ThumbTextPadding { get { return _thumbTextPadding ?? (_thumbTextPadding = NPropFactories.CreateThumbTextPadding()); } }
           NProperty _thumbTextPadding;

    public NProperty TimeChanged { get { return _timeChanged ?? (_timeChanged = NPropFactories.CreateTimeChanged()); } }
           NProperty _timeChanged;

    public NProperty TimeZone { get { return _timeZone ?? (_timeZone = NPropFactories.CreateTimeZone()); } }
           NProperty _timeZone;

    public NProperty Title { get { return _title ?? (_title = NPropFactories.CreateTitle()); } }
           NProperty _title;

    public NProperty ToDegrees { get { return _toDegrees ?? (_toDegrees = NPropFactories.CreateToDegrees()); } }
           NProperty _toDegrees;

    public NProperty Top { get { return _top ?? (_top = NPropFactories.CreateTop()); } }
           NProperty _top;

    public NProperty Touch { get { return _touch ?? (_touch = NPropFactories.CreateTouch()); } }
           NProperty _touch;

    public NProperty TouchscreenBlocksFocus { get { return _touchscreenBlocksFocus ?? (_touchscreenBlocksFocus = NPropFactories.CreateTouchscreenBlocksFocus()); } }
           NProperty _touchscreenBlocksFocus;

    public NProperty TransitionGroup { get { return _transitionGroup ?? (_transitionGroup = NPropFactories.CreateTransitionGroup()); } }
           NProperty _transitionGroup;

    public NProperty TransitionName { get { return _transitionName ?? (_transitionName = NPropFactories.CreateTransitionName()); } }
           NProperty _transitionName;

    public NProperty TranslationX { get { return _translationX ?? (_translationX = NPropFactories.CreateTranslationX()); } }
           NProperty _translationX;

    public NProperty TranslationY { get { return _translationY ?? (_translationY = NPropFactories.CreateTranslationY()); } }
           NProperty _translationY;

    public NProperty TranslationZ { get { return _translationZ ?? (_translationZ = NPropFactories.CreateTranslationZ()); } }
           NProperty _translationZ;

    public NProperty UnhandledInputEvent { get { return _unhandledInputEvent ?? (_unhandledInputEvent = NPropFactories.CreateUnhandledInputEvent()); } }
           NProperty _unhandledInputEvent;

    public NProperty UseDefaultMargins { get { return _useDefaultMargins ?? (_useDefaultMargins = NPropFactories.CreateUseDefaultMargins()); } }
           NProperty _useDefaultMargins;

    public NProperty Value { get { return _value ?? (_value = NPropFactories.CreateValue()); } }
           NProperty _value;

    public NProperty ValueChanged { get { return _valueChanged ?? (_valueChanged = NPropFactories.CreateValueChanged()); } }
           NProperty _valueChanged;

    public NProperty VerticalFadingEdgeEnabled { get { return _verticalFadingEdgeEnabled ?? (_verticalFadingEdgeEnabled = NPropFactories.CreateVerticalFadingEdgeEnabled()); } }
           NProperty _verticalFadingEdgeEnabled;

    public NProperty VerticalScrollBarEnabled { get { return _verticalScrollBarEnabled ?? (_verticalScrollBarEnabled = NPropFactories.CreateVerticalScrollBarEnabled()); } }
           NProperty _verticalScrollBarEnabled;

    public NProperty VerticalScrollbarPosition { get { return _verticalScrollbarPosition ?? (_verticalScrollbarPosition = NPropFactories.CreateVerticalScrollbarPosition()); } }
           NProperty _verticalScrollbarPosition;

    public NProperty ViewAttachedToWindow { get { return _viewAttachedToWindow ?? (_viewAttachedToWindow = NPropFactories.CreateViewAttachedToWindow()); } }
           NProperty _viewAttachedToWindow;

    public NProperty ViewDetachedFromWindow { get { return _viewDetachedFromWindow ?? (_viewDetachedFromWindow = NPropFactories.CreateViewDetachedFromWindow()); } }
           NProperty _viewDetachedFromWindow;

    public NProperty Visibility { get { return _visibility ?? (_visibility = NPropFactories.CreateVisibility()); } }
           NProperty _visibility;

    public NProperty WeekDayTextAppearance { get { return _weekDayTextAppearance ?? (_weekDayTextAppearance = NPropFactories.CreateWeekDayTextAppearance()); } }
           NProperty _weekDayTextAppearance;

    public NProperty WeightSum { get { return _weightSum ?? (_weightSum = NPropFactories.CreateWeightSum()); } }
           NProperty _weightSum;

    public NProperty WrapSelectorWheel { get { return _wrapSelectorWheel ?? (_wrapSelectorWheel = NPropFactories.CreateWrapSelectorWheel()); } }
           NProperty _wrapSelectorWheel;

    public NProperty ZoomInClick { get { return _zoomInClick ?? (_zoomInClick = NPropFactories.CreateZoomInClick()); } }
           NProperty _zoomInClick;

    public NProperty ZoomOutClick { get { return _zoomOutClick ?? (_zoomOutClick = NPropFactories.CreateZoomOutClick()); } }
           NProperty _zoomOutClick;

  }

  static partial class NPropFactories
  {
    public static NProperty CreateAccessibilityLiveRegion() => new NProperty(nameof(NProperties.AccessibilityLiveRegion)).
        Property<View>((t, v) => t.AccessibilityLiveRegion = NConverters.ToEnumT<AccessibilityLiveRegion>(v));

    public static NProperty CreateAccessibilityTraversalAfter() => new NProperty(nameof(NProperties.AccessibilityTraversalAfter)).
        Property<View>((t, v) => t.AccessibilityTraversalAfter = NConverters.ToInt32T(v));

    public static NProperty CreateAccessibilityTraversalBefore() => new NProperty(nameof(NProperties.AccessibilityTraversalBefore)).
        Property<View>((t, v) => t.AccessibilityTraversalBefore = NConverters.ToInt32T(v));

    public static NProperty CreateActivated() => new NProperty(nameof(NProperties.Activated)).
        Property<View>((t, v) => t.Activated = NConverters.ToBoolT(v));

    public static NProperty CreateAfterTextChanged() => new NProperty(nameof(NProperties.AfterTextChanged)).
        Event<TextView>((s, a) => s.AfterTextChanged += a.EventHandler);

    public static NProperty CreateAlignmentMode() => new NProperty(nameof(NProperties.AlignmentMode)).
        Property<GridLayout>((t, v) => t.AlignmentMode = NConverters.ToEnumT<GridAlign>(v));

    public static NProperty CreateAlpha() => new NProperty(nameof(NProperties.Alpha)).
        Property<View>((t, v) => t.Alpha = NConverters.ToSingleT(v)).
        Property<Drawable>((t, v) => t.Alpha = NConverters.ToInt32T(v)).
        Property<ColorDrawable>((t, v) => t.Alpha = NConverters.ToInt32T(v));

    public static NProperty CreateAlwaysDrawnWithCacheEnabled() => new NProperty(nameof(NProperties.AlwaysDrawnWithCacheEnabled)).
        Property<ViewGroup>((t, v) => t.AlwaysDrawnWithCacheEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateAnimationCacheEnabled() => new NProperty(nameof(NProperties.AnimationCacheEnabled)).
        Property<ViewGroup>((t, v) => t.AnimationCacheEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateAnimationEnd() => new NProperty(nameof(NProperties.AnimationEnd)).
        Event<ViewGroup>((s, a) => s.AnimationEnd += a.EventHandler);

    public static NProperty CreateAnimationRepeat() => new NProperty(nameof(NProperties.AnimationRepeat)).
        Event<ViewGroup>((s, a) => s.AnimationRepeat += a.EventHandler);

    public static NProperty CreateAnimationStart() => new NProperty(nameof(NProperties.AnimationStart)).
        Event<ViewGroup>((s, a) => s.AnimationStart += a.EventHandler);

    public static NProperty CreateAutoLinkMask() => new NProperty(nameof(NProperties.AutoLinkMask)).
        Property<TextView>((t, v) => t.AutoLinkMask = NConverters.ToEnumT<MatchOptions>(v));

    public static NProperty CreateAutoMirrored() => new NProperty(nameof(NProperties.AutoMirrored)).
        Property<Drawable>((t, v) => t.AutoMirrored = NConverters.ToBoolT(v));

    public static NProperty CreateAutoStart() => new NProperty(nameof(NProperties.AutoStart)).
        Property<AdapterViewFlipper>((t, v) => t.AutoStart = NConverters.ToBoolT(v)).
        Property<ViewFlipper>((t, v) => t.AutoStart = NConverters.ToBoolT(v));

    public static NProperty CreateBaselineAlignBottom() => new NProperty(nameof(NProperties.BaselineAlignBottom)).
        Property<ImageView>((t, v) => t.BaselineAlignBottom = NConverters.ToBoolT(v));

    public static NProperty CreateBaselineAligned() => new NProperty(nameof(NProperties.BaselineAligned)).
        Property<LinearLayout>((t, v) => t.BaselineAligned = NConverters.ToBoolT(v));

    public static NProperty CreateBaselineAlignedChildIndex() => new NProperty(nameof(NProperties.BaselineAlignedChildIndex)).
        Property<LinearLayout>((t, v) => t.BaselineAlignedChildIndex = NConverters.ToInt32T(v));

    public static NProperty CreateBeforeTextChanged() => new NProperty(nameof(NProperties.BeforeTextChanged)).
        Event<TextView>((s, a) => s.BeforeTextChanged += a.EventHandler);

    public static NProperty CreateBottom() => new NProperty(nameof(NProperties.Bottom)).
        Property<View>((t, v) => t.Bottom = NConverters.ToInt32T(v));

    public static NProperty CreateBreadCrumbClick() => new NProperty(nameof(NProperties.BreadCrumbClick)).
        Event<FragmentBreadCrumbs>((s, a) => s.BreadCrumbClick += a.EventHandler);

    public static NProperty CreateBreakStrategy() => new NProperty(nameof(NProperties.BreakStrategy)).
        Property<TextView>((t, v) => t.BreakStrategy = NConverters.ToEnumT<BreakStrategy>(v));

    public static NProperty CreateCalendarViewShown() => new NProperty(nameof(NProperties.CalendarViewShown)).
        Property<DatePicker>((t, v) => t.CalendarViewShown = NConverters.ToBoolT(v));

    public static NProperty CreateChangingConfigurations() => new NProperty(nameof(NProperties.ChangingConfigurations)).
        Property<Drawable>((t, v) => t.ChangingConfigurations = NConverters.ToEnumT<ConfigChanges>(v));

    public static NProperty CreateChecked() => new NProperty(nameof(NProperties.Checked)).
        Property<CompoundButton>((t, v) => t.Checked = NConverters.ToBoolT(v)).
        Property<CheckedTextView>((t, v) => t.Checked = NConverters.ToBoolT(v));

    public static NProperty CreateCheckedChange() => new NProperty(nameof(NProperties.CheckedChange)).
        Event<CompoundButton>((s, a) => s.CheckedChange += a.EventHandler).
        Event<RadioGroup>((s, a) => s.CheckedChange += a.EventHandler);

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child));

    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children));

    public static NProperty CreateChildViewAdded() => new NProperty(nameof(NProperties.ChildViewAdded)).
        Event<ViewGroup>((s, a) => s.ChildViewAdded += a.EventHandler);

    public static NProperty CreateChildViewRemoved() => new NProperty(nameof(NProperties.ChildViewRemoved)).
        Event<ViewGroup>((s, a) => s.ChildViewRemoved += a.EventHandler);

    public static NProperty CreateChronometerTick() => new NProperty(nameof(NProperties.ChronometerTick)).
        Event<Chronometer>((s, a) => s.ChronometerTick += a.EventHandler);

    public static NProperty CreateClick() => new NProperty(nameof(NProperties.Click)).
        Event<View>((s, a) => s.Click += a.EventHandler);

    public static NProperty CreateClickable() => new NProperty(nameof(NProperties.Clickable)).
        Property<View>((t, v) => t.Clickable = NConverters.ToBoolT(v));

    public static NProperty CreateClipToOutline() => new NProperty(nameof(NProperties.ClipToOutline)).
        Property<View>((t, v) => t.ClipToOutline = NConverters.ToBoolT(v));

    public static NProperty CreateClose() => new NProperty(nameof(NProperties.Close)).
        Event<SearchView>((s, a) => s.Close += a.EventHandler);

    public static NProperty CreateColumnCount() => new NProperty(nameof(NProperties.ColumnCount)).
        Property<GridLayout>((t, v) => t.ColumnCount = NConverters.ToInt32T(v));

    public static NProperty CreateColumnOrderPreserved() => new NProperty(nameof(NProperties.ColumnOrderPreserved)).
        Property<GridLayout>((t, v) => t.ColumnOrderPreserved = NConverters.ToBoolT(v));

    public static NProperty CreateCompletion() => new NProperty(nameof(NProperties.Completion)).
        Event<VideoView>((s, a) => s.Completion += a.EventHandler);

    public static NProperty CreateCompoundDrawablePadding() => new NProperty(nameof(NProperties.CompoundDrawablePadding)).
        Property<TextView>((t, v) => t.CompoundDrawablePadding = NConverters.ToInt32T(v));

    public static NProperty CreateContentDescription() => new NProperty(nameof(NProperties.ContentDescription)).
        Property<View>((t, v) => t.ContentDescription = NConverters.ToStringT(v));

    public static NProperty CreateContextClick() => new NProperty(nameof(NProperties.ContextClick)).
        Event<View>((s, a) => s.ContextClick += a.EventHandler);

    public static NProperty CreateContextClickable() => new NProperty(nameof(NProperties.ContextClickable)).
        Property<View>((t, v) => t.ContextClickable = NConverters.ToBoolT(v));

    public static NProperty CreateContextMenuCreated() => new NProperty(nameof(NProperties.ContextMenuCreated)).
        Event<View>((s, a) => s.ContextMenuCreated += a.EventHandler);

    public static NProperty CreateCropToPadding() => new NProperty(nameof(NProperties.CropToPadding)).
        Property<ImageView>((t, v) => t.CropToPadding = NConverters.ToBoolT(v));

    public static NProperty CreateCrossFadeEnabled() => new NProperty(nameof(NProperties.CrossFadeEnabled)).
        Property<TransitionDrawable>((t, v) => t.CrossFadeEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateCurrentTab() => new NProperty(nameof(NProperties.CurrentTab)).
        Property<TabHost>((t, v) => t.CurrentTab = NConverters.ToInt32T(v));

    public static NProperty CreateDateChange() => new NProperty(nameof(NProperties.DateChange)).
        Event<CalendarView>((s, a) => s.DateChange += a.EventHandler);

    public static NProperty CreateDateTextAppearance() => new NProperty(nameof(NProperties.DateTextAppearance)).
        Property<CalendarView>((t, v) => t.DateTextAppearance = NConverters.ToInt32T(v));

    public static NProperty CreateDebugFlags() => new NProperty(nameof(NProperties.DebugFlags)).
        Property<GLSurfaceView>((t, v) => t.DebugFlags = NConverters.ToEnumT<DebugFlags>(v));

    public static NProperty CreateDescendantFocusability() => new NProperty(nameof(NProperties.DescendantFocusability)).
        Property<ViewGroup>((t, v) => t.DescendantFocusability = NConverters.ToEnumT<DescendantFocusability>(v));

    public static NProperty CreateDismiss() => new NProperty(nameof(NProperties.Dismiss)).
        Event<AutoCompleteTextView>((s, a) => s.Dismiss += a.EventHandler);

    public static NProperty CreateDisplayedChild() => new NProperty(nameof(NProperties.DisplayedChild)).
        Property<AdapterViewAnimator>((t, v) => t.DisplayedChild = NConverters.ToInt32T(v)).
        Property<ViewAnimator>((t, v) => t.DisplayedChild = NConverters.ToInt32T(v));

    public static NProperty CreateDividerPadding() => new NProperty(nameof(NProperties.DividerPadding)).
        Property<LinearLayout>((t, v) => t.DividerPadding = NConverters.ToInt32T(v));

    public static NProperty CreateDownload() => new NProperty(nameof(NProperties.Download)).
        Event<WebView>((s, a) => s.Download += a.EventHandler);

    public static NProperty CreateDrag() => new NProperty(nameof(NProperties.Drag)).
        Event<View>((s, a) => s.Drag += a.EventHandler);

    public static NProperty CreateDrawerClose() => new NProperty(nameof(NProperties.DrawerClose)).
        Event<SlidingDrawer>((s, a) => s.DrawerClose += a.EventHandler);

    public static NProperty CreateDrawerOpen() => new NProperty(nameof(NProperties.DrawerOpen)).
        Event<SlidingDrawer>((s, a) => s.DrawerOpen += a.EventHandler);

    public static NProperty CreateDrawingCacheEnabled() => new NProperty(nameof(NProperties.DrawingCacheEnabled)).
        Property<View>((t, v) => t.DrawingCacheEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateDrawingCacheQuality() => new NProperty(nameof(NProperties.DrawingCacheQuality)).
        Property<View>((t, v) => t.DrawingCacheQuality = NConverters.ToEnumT<DrawingCacheQuality>(v));

    public static NProperty CreateDropDownAnchor() => new NProperty(nameof(NProperties.DropDownAnchor)).
        Property<AutoCompleteTextView>((t, v) => t.DropDownAnchor = NConverters.ToInt32T(v));

    public static NProperty CreateDropDownHeight() => new NProperty(nameof(NProperties.DropDownHeight)).
        Property<AutoCompleteTextView>((t, v) => t.DropDownHeight = NConverters.ToInt32T(v));

    public static NProperty CreateDropDownHorizontalOffset() => new NProperty(nameof(NProperties.DropDownHorizontalOffset)).
        Property<AutoCompleteTextView>((t, v) => t.DropDownHorizontalOffset = NConverters.ToInt32T(v));

    public static NProperty CreateDropDownVerticalOffset() => new NProperty(nameof(NProperties.DropDownVerticalOffset)).
        Property<AutoCompleteTextView>((t, v) => t.DropDownVerticalOffset = NConverters.ToInt32T(v));

    public static NProperty CreateDropDownWidth() => new NProperty(nameof(NProperties.DropDownWidth)).
        Property<AutoCompleteTextView>((t, v) => t.DropDownWidth = NConverters.ToInt32T(v));

    public static NProperty CreateDuplicateParentStateEnabled() => new NProperty(nameof(NProperties.DuplicateParentStateEnabled)).
        Property<View>((t, v) => t.DuplicateParentStateEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateEditorAction() => new NProperty(nameof(NProperties.EditorAction)).
        Event<TextView>((s, a) => s.EditorAction += a.EventHandler);

    public static NProperty CreateElevation() => new NProperty(nameof(NProperties.Elevation)).
        Property<View>((t, v) => t.Elevation = NConverters.ToSingleT(v));

    public static NProperty CreateEnabled() => new NProperty(nameof(NProperties.Enabled)).
        Property<View>((t, v) => t.Enabled = NConverters.ToBoolT(v));

    public static NProperty CreateError() => new NProperty(nameof(NProperties.Error)).
        Property<TextView>((t, v) => t.Error = NConverters.ToStringT(v)).
        Event<VideoView>((s, a) => s.Error += a.EventHandler);

    public static NProperty CreateEventsInterceptionEnabled() => new NProperty(nameof(NProperties.EventsInterceptionEnabled)).
        Property<GestureOverlayView>((t, v) => t.EventsInterceptionEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateExtendedSettingsClick() => new NProperty(nameof(NProperties.ExtendedSettingsClick)).
        Event<MediaRouteButton>((s, a) => s.ExtendedSettingsClick += a.EventHandler);

    public static NProperty CreateFadeEnabled() => new NProperty(nameof(NProperties.FadeEnabled)).
        Property<GestureOverlayView>((t, v) => t.FadeEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateFillViewport() => new NProperty(nameof(NProperties.FillViewport)).
        Property<HorizontalScrollView>((t, v) => t.FillViewport = NConverters.ToBoolT(v)).
        Property<ScrollView>((t, v) => t.FillViewport = NConverters.ToBoolT(v));

    public static NProperty CreateFilterTouchesWhenObscured() => new NProperty(nameof(NProperties.FilterTouchesWhenObscured)).
        Property<View>((t, v) => t.FilterTouchesWhenObscured = NConverters.ToBoolT(v));

    public static NProperty CreateFind() => new NProperty(nameof(NProperties.Find)).
        Event<WebView>((s, a) => s.Find += a.EventHandler);

    public static NProperty CreateFirstDayOfWeek() => new NProperty(nameof(NProperties.FirstDayOfWeek)).
        Property<DatePicker>((t, v) => t.FirstDayOfWeek = NConverters.ToInt32T(v)).
        Property<CalendarView>((t, v) => t.FirstDayOfWeek = NConverters.ToInt32T(v));

    public static NProperty CreateFocusable() => new NProperty(nameof(NProperties.Focusable)).
        Property<View>((t, v) => t.Focusable = NConverters.ToBoolT(v));

    public static NProperty CreateFocusableInTouchMode() => new NProperty(nameof(NProperties.FocusableInTouchMode)).
        Property<View>((t, v) => t.FocusableInTouchMode = NConverters.ToBoolT(v));

    public static NProperty CreateFocusChange() => new NProperty(nameof(NProperties.FocusChange)).
        Event<View>((s, a) => s.FocusChange += a.EventHandler);

    public static NProperty CreateFontFeatureSettings() => new NProperty(nameof(NProperties.FontFeatureSettings)).
        Property<TextView>((t, v) => t.FontFeatureSettings = NConverters.ToStringT(v));

    public static NProperty CreateFormat() => new NProperty(nameof(NProperties.Format)).
        Property<Chronometer>((t, v) => t.Format = NConverters.ToStringT(v));

    public static NProperty CreateFormat12Hour() => new NProperty(nameof(NProperties.Format12Hour)).
        Property<TextClock>((t, v) => t.Format12Hour = NConverters.ToStringT(v));

    public static NProperty CreateFormat24Hour() => new NProperty(nameof(NProperties.Format24Hour)).
        Property<TextClock>((t, v) => t.Format24Hour = NConverters.ToStringT(v));

    public static NProperty CreateFreezesText() => new NProperty(nameof(NProperties.FreezesText)).
        Property<TextView>((t, v) => t.FreezesText = NConverters.ToBoolT(v));

    public static NProperty CreateFromDegrees() => new NProperty(nameof(NProperties.FromDegrees)).
        Property<RotateDrawable>((t, v) => t.FromDegrees = NConverters.ToSingleT(v));

    public static NProperty CreateGenericMotion() => new NProperty(nameof(NProperties.GenericMotion)).
        Event<View>((s, a) => s.GenericMotion += a.EventHandler);

    public static NProperty CreateGestureCancelled() => new NProperty(nameof(NProperties.GestureCancelled)).
        Event<GestureOverlayView>((s, a) => s.GestureCancelled += a.EventHandler);

    public static NProperty CreateGestureEnded() => new NProperty(nameof(NProperties.GestureEnded)).
        Event<GestureOverlayView>((s, a) => s.GestureEnded += a.EventHandler);

    public static NProperty CreateGestureEvent() => new NProperty(nameof(NProperties.GestureEvent)).
        Event<GestureOverlayView>((s, a) => s.GestureEvent += a.EventHandler);

    public static NProperty CreateGesturePerformed() => new NProperty(nameof(NProperties.GesturePerformed)).
        Event<GestureOverlayView>((s, a) => s.GesturePerformed += a.EventHandler);

    public static NProperty CreateGestureStarted() => new NProperty(nameof(NProperties.GestureStarted)).
        Event<GestureOverlayView>((s, a) => s.GestureStarted += a.EventHandler);

    public static NProperty CreateGestureStrokeAngleThreshold() => new NProperty(nameof(NProperties.GestureStrokeAngleThreshold)).
        Property<GestureOverlayView>((t, v) => t.GestureStrokeAngleThreshold = NConverters.ToSingleT(v));

    public static NProperty CreateGestureStrokeLengthThreshold() => new NProperty(nameof(NProperties.GestureStrokeLengthThreshold)).
        Property<GestureOverlayView>((t, v) => t.GestureStrokeLengthThreshold = NConverters.ToSingleT(v));

    public static NProperty CreateGestureStrokeSquarenessTreshold() => new NProperty(nameof(NProperties.GestureStrokeSquarenessTreshold)).
        Property<GestureOverlayView>((t, v) => t.GestureStrokeSquarenessTreshold = NConverters.ToSingleT(v));

    public static NProperty CreateGestureStrokeType() => new NProperty(nameof(NProperties.GestureStrokeType)).
        Property<GestureOverlayView>((t, v) => t.GestureStrokeType = NConverters.ToEnumT<GestureStrokeType>(v));

    public static NProperty CreateGestureStrokeWidth() => new NProperty(nameof(NProperties.GestureStrokeWidth)).
        Property<GestureOverlayView>((t, v) => t.GestureStrokeWidth = NConverters.ToSingleT(v));

    public static NProperty CreateGestureVisible() => new NProperty(nameof(NProperties.GestureVisible)).
        Property<GestureOverlayView>((t, v) => t.GestureVisible = NConverters.ToBoolT(v));

    public static NProperty CreateGesturingEnded() => new NProperty(nameof(NProperties.GesturingEnded)).
        Event<GestureOverlayView>((s, a) => s.GesturingEnded += a.EventHandler);

    public static NProperty CreateGesturingStarted() => new NProperty(nameof(NProperties.GesturingStarted)).
        Event<GestureOverlayView>((s, a) => s.GesturingStarted += a.EventHandler);

    public static NProperty CreateGravity() => new NProperty(nameof(NProperties.Gravity)).
        Property<TextView>((t, v) => t.Gravity = NConverters.ToEnumT<GravityFlags>(v)).
        Property<BitmapDrawable>((t, v) => t.Gravity = NConverters.ToEnumT<GravityFlags>(v));

    public static NProperty CreateHapticFeedbackEnabled() => new NProperty(nameof(NProperties.HapticFeedbackEnabled)).
        Property<View>((t, v) => t.HapticFeedbackEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateHasTransientState() => new NProperty(nameof(NProperties.HasTransientState)).
        Property<View>((t, v) => t.HasTransientState = NConverters.ToBoolT(v));

    public static NProperty CreateHint() => new NProperty(nameof(NProperties.Hint)).
        Property<TextView>((t, v) => t.Hint = NConverters.ToStringT(v));

    public static NProperty CreateHorizontalFadingEdgeEnabled() => new NProperty(nameof(NProperties.HorizontalFadingEdgeEnabled)).
        Property<View>((t, v) => t.HorizontalFadingEdgeEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateHorizontalScrollBarEnabled() => new NProperty(nameof(NProperties.HorizontalScrollBarEnabled)).
        Property<View>((t, v) => t.HorizontalScrollBarEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateHour() => new NProperty(nameof(NProperties.Hour)).
        Property<TimePicker>((t, v) => t.Hour = NConverters.ToInt32T(v));

    public static NProperty CreateHover() => new NProperty(nameof(NProperties.Hover)).
        Event<View>((s, a) => s.Hover += a.EventHandler);

    public static NProperty CreateHovered() => new NProperty(nameof(NProperties.Hovered)).
        Property<View>((t, v) => t.Hovered = NConverters.ToBoolT(v));

    public static NProperty CreateHyphenationFrequency() => new NProperty(nameof(NProperties.HyphenationFrequency)).
        Property<TextView>((t, v) => t.HyphenationFrequency = NConverters.ToEnumT<HyphenationFrequency>(v));

    public static NProperty CreateIconified() => new NProperty(nameof(NProperties.Iconified)).
        Property<SearchView>((t, v) => t.Iconified = NConverters.ToBoolT(v));

    public static NProperty CreateId() => new NProperty(nameof(NProperties.Id)).
        Property<View>((t, v) => t.Id = NConverters.ToInt32T(v));

    public static NProperty CreateImageAlpha() => new NProperty(nameof(NProperties.ImageAlpha)).
        Property<ImageView>((t, v) => t.ImageAlpha = NConverters.ToInt32T(v));

    public static NProperty CreateImeOptions() => new NProperty(nameof(NProperties.ImeOptions)).
        Property<TextView>((t, v) => t.ImeOptions = NConverters.ToEnumT<ImeAction>(v));

    public static NProperty CreateImportantForAccessibility() => new NProperty(nameof(NProperties.ImportantForAccessibility)).
        Property<View>((t, v) => t.ImportantForAccessibility = NConverters.ToEnumT<ImportantForAccessibility>(v));

    public static NProperty CreateIndeterminate() => new NProperty(nameof(NProperties.Indeterminate)).
        Property<ProgressBar>((t, v) => t.Indeterminate = NConverters.ToBoolT(v));

    public static NProperty CreateInflatedId() => new NProperty(nameof(NProperties.InflatedId)).
        Property<ViewStub>((t, v) => t.InflatedId = NConverters.ToInt32T(v));

    public static NProperty CreateInflateEvent() => new NProperty(nameof(NProperties.InflateEvent)).
        Event<ViewStub>((s, a) => s.InflateEvent += a.EventHandler);

    public static NProperty CreateInfo() => new NProperty(nameof(NProperties.Info)).
        Event<VideoView>((s, a) => s.Info += a.EventHandler);

    public static NProperty CreateInputType() => new NProperty(nameof(NProperties.InputType)).
        Property<TextView>((t, v) => t.InputType = NConverters.ToEnumT<InputTypes>(v));

    public static NProperty CreateIsIndicator() => new NProperty(nameof(NProperties.IsIndicator)).
        Property<RatingBar>((t, v) => t.IsIndicator = NConverters.ToBoolT(v));

    public static NProperty CreateItemClick() => new NProperty(nameof(NProperties.ItemClick)).
        Event<AutoCompleteTextView>((s, a) => s.ItemClick += a.EventHandler).
        Event<AdapterView>((s, a) => s.ItemClick += a.EventHandler);

    public static NProperty CreateItemLongClick() => new NProperty(nameof(NProperties.ItemLongClick)).
        Event<AdapterView>((s, a) => s.ItemLongClick += a.EventHandler);

    public static NProperty CreateItemSelected() => new NProperty(nameof(NProperties.ItemSelected)).
        Event<AutoCompleteTextView>((s, a) => s.ItemSelected += a.EventHandler).
        Event<AdapterView>((s, a) => s.ItemSelected += a.EventHandler);

    public static NProperty CreateItemSelectionCleared() => new NProperty(nameof(NProperties.ItemSelectionCleared)).
        Event<AutoCompleteTextView>((s, a) => s.ItemSelectionCleared += a.EventHandler).
        Event<AdapterView>((s, a) => s.ItemSelectionCleared += a.EventHandler);

    public static NProperty CreateKeepScreenOn() => new NProperty(nameof(NProperties.KeepScreenOn)).
        Property<View>((t, v) => t.KeepScreenOn = NConverters.ToBoolT(v));

    public static NProperty CreateKey() => new NProperty(nameof(NProperties.Key)).
        Event<KeyboardView>((s, a) => s.Key += a.EventHandler);

    public static NProperty CreateKeyPress() => new NProperty(nameof(NProperties.KeyPress)).
        Event<View>((s, a) => s.KeyPress += a.EventHandler);

    public static NProperty CreateKeyProgressIncrement() => new NProperty(nameof(NProperties.KeyProgressIncrement)).
        Property<AbsSeekBar>((t, v) => t.KeyProgressIncrement = NConverters.ToInt32T(v));

    public static NProperty CreateLabelFor() => new NProperty(nameof(NProperties.LabelFor)).
        Property<View>((t, v) => t.LabelFor = NConverters.ToInt32T(v));

    public static NProperty CreateLayoutChange() => new NProperty(nameof(NProperties.LayoutChange)).
        Event<View>((s, a) => s.LayoutChange += a.EventHandler);

    public static NProperty CreateLayoutDirection() => new NProperty(nameof(NProperties.LayoutDirection)).
        Property<View>((t, v) => t.LayoutDirection = NConverters.ToEnumT<LayoutDirection>(v));

    public static NProperty CreateLayoutMode() => new NProperty(nameof(NProperties.LayoutMode)).
        Property<ViewGroup>((t, v) => t.LayoutMode = NConverters.ToEnumT<ViewLayoutMode>(v));

    public static NProperty CreateLayoutResource() => new NProperty(nameof(NProperties.LayoutResource)).
        Property<ViewStub>((t, v) => t.LayoutResource = NConverters.ToInt32T(v));

    public static NProperty CreateLeft() => new NProperty(nameof(NProperties.Left)).
        Property<View>((t, v) => t.Left = NConverters.ToInt32T(v));

    public static NProperty CreateLetterSpacing() => new NProperty(nameof(NProperties.LetterSpacing)).
        Property<TextView>((t, v) => t.LetterSpacing = NConverters.ToSingleT(v));

    public static NProperty CreateLinksClickable() => new NProperty(nameof(NProperties.LinksClickable)).
        Property<TextView>((t, v) => t.LinksClickable = NConverters.ToBoolT(v));

    public static NProperty CreateListSelection() => new NProperty(nameof(NProperties.ListSelection)).
        Property<AutoCompleteTextView>((t, v) => t.ListSelection = NConverters.ToInt32T(v));

    public static NProperty CreateLogoDescription() => new NProperty(nameof(NProperties.LogoDescription)).
        Property<Toolbar>((t, v) => t.LogoDescription = NConverters.ToStringT(v));

    public static NProperty CreateLongClick() => new NProperty(nameof(NProperties.LongClick)).
        Event<View>((s, a) => s.LongClick += a.EventHandler);

    public static NProperty CreateLongClickable() => new NProperty(nameof(NProperties.LongClickable)).
        Property<View>((t, v) => t.LongClickable = NConverters.ToBoolT(v));

    public static NProperty CreateMax() => new NProperty(nameof(NProperties.Max)).
        Property<ProgressBar>((t, v) => t.Max = NConverters.ToInt32T(v));

    public static NProperty CreateMaxValue() => new NProperty(nameof(NProperties.MaxValue)).
        Property<NumberPicker>((t, v) => t.MaxValue = NConverters.ToInt32T(v));

    public static NProperty CreateMeasureAllChildren() => new NProperty(nameof(NProperties.MeasureAllChildren)).
        Property<FrameLayout>((t, v) => t.MeasureAllChildren = NConverters.ToBoolT(v));

    public static NProperty CreateMeasureWithLargestChildEnabled() => new NProperty(nameof(NProperties.MeasureWithLargestChildEnabled)).
        Property<LinearLayout>((t, v) => t.MeasureWithLargestChildEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateMenuItemClick() => new NProperty(nameof(NProperties.MenuItemClick)).
        Event<ActionMenuView>((s, a) => s.MenuItemClick += a.EventHandler).
        Event<Toolbar>((s, a) => s.MenuItemClick += a.EventHandler);

    public static NProperty CreateMinute() => new NProperty(nameof(NProperties.Minute)).
        Property<TimePicker>((t, v) => t.Minute = NConverters.ToInt32T(v));

    public static NProperty CreateMinValue() => new NProperty(nameof(NProperties.MinValue)).
        Property<NumberPicker>((t, v) => t.MinValue = NConverters.ToInt32T(v));

    public static NProperty CreateMode() => new NProperty(nameof(NProperties.Mode)).
        Property<DialerFilter>((t, v) => t.Mode = NConverters.ToEnumT<DialerMode>(v));

    public static NProperty CreateMotionEventSplittingEnabled() => new NProperty(nameof(NProperties.MotionEventSplittingEnabled)).
        Property<ViewGroup>((t, v) => t.MotionEventSplittingEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateNavigationContentDescription() => new NProperty(nameof(NProperties.NavigationContentDescription)).
        Property<Toolbar>((t, v) => t.NavigationContentDescription = NConverters.ToStringT(v));

    public static NProperty CreateNavigationOnClick() => new NProperty(nameof(NProperties.NavigationOnClick)).
        Event<Toolbar>((s, a) => s.NavigationOnClick += a.EventHandler);

    public static NProperty CreateNestedScrollingEnabled() => new NProperty(nameof(NProperties.NestedScrollingEnabled)).
        Property<View>((t, v) => t.NestedScrollingEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateNextClick() => new NProperty(nameof(NProperties.NextClick)).
        Event<MediaController>((s, a) => s.NextClick += a.EventHandler);

    public static NProperty CreateNextFocusDownId() => new NProperty(nameof(NProperties.NextFocusDownId)).
        Property<View>((t, v) => t.NextFocusDownId = NConverters.ToInt32T(v));

    public static NProperty CreateNextFocusForwardId() => new NProperty(nameof(NProperties.NextFocusForwardId)).
        Property<View>((t, v) => t.NextFocusForwardId = NConverters.ToInt32T(v));

    public static NProperty CreateNextFocusLeftId() => new NProperty(nameof(NProperties.NextFocusLeftId)).
        Property<View>((t, v) => t.NextFocusLeftId = NConverters.ToInt32T(v));

    public static NProperty CreateNextFocusRightId() => new NProperty(nameof(NProperties.NextFocusRightId)).
        Property<View>((t, v) => t.NextFocusRightId = NConverters.ToInt32T(v));

    public static NProperty CreateNextFocusUpId() => new NProperty(nameof(NProperties.NextFocusUpId)).
        Property<View>((t, v) => t.NextFocusUpId = NConverters.ToInt32T(v));

    public static NProperty CreateNothingSelected() => new NProperty(nameof(NProperties.NothingSelected)).
        Event<AutoCompleteTextView>((s, a) => s.NothingSelected += a.EventHandler).
        Event<AdapterView>((s, a) => s.NothingSelected += a.EventHandler);

    public static NProperty CreateNumStars() => new NProperty(nameof(NProperties.NumStars)).
        Property<RatingBar>((t, v) => t.NumStars = NConverters.ToInt32T(v));

    public static NProperty CreateOneShot() => new NProperty(nameof(NProperties.OneShot)).
        Property<AnimationDrawable>((t, v) => t.OneShot = NConverters.ToBoolT(v));

    public static NProperty CreateOrientation() => new NProperty(nameof(NProperties.Orientation)).
        Property<GestureOverlayView>((t, v) => t.Orientation = NConverters.ToEnumT<GestureOrientation>(v)).
        Property<GridLayout>((t, v) => t.Orientation = NConverters.ToEnumT<GridOrientation>(v)).
        Property<LinearLayout>((t, v) => t.Orientation = NConverters.ToEnumT<aw.Orientation>(v));

    public static NProperty CreateOverScrollMode() => new NProperty(nameof(NProperties.OverScrollMode)).
        Property<View>((t, v) => t.OverScrollMode = NConverters.ToEnumT<OverScrollMode>(v));

    public static NProperty CreatePaddingMode() => new NProperty(nameof(NProperties.PaddingMode)).
        Property<LayerDrawable>((t, v) => t.PaddingMode = NConverters.ToInt32T(v));

    public static NProperty CreatePaintFlags() => new NProperty(nameof(NProperties.PaintFlags)).
        Property<TextView>((t, v) => t.PaintFlags = NConverters.ToEnumT<PaintFlags>(v));

    public static NProperty CreatePersistentDrawingCache() => new NProperty(nameof(NProperties.PersistentDrawingCache)).
        Property<ViewGroup>((t, v) => t.PersistentDrawingCache = NConverters.ToEnumT<PersistentDrawingCaches>(v));

    public static NProperty CreatePicture() => new NProperty(nameof(NProperties.Picture)).
        Event<WebView>((s, a) => s.Picture += a.EventHandler);

    public static NProperty CreatePivotX() => new NProperty(nameof(NProperties.PivotX)).
        Property<View>((t, v) => t.PivotX = NConverters.ToSingleT(v)).
        Property<RotateDrawable>((t, v) => t.PivotX = NConverters.ToSingleT(v));

    public static NProperty CreatePivotXRelative() => new NProperty(nameof(NProperties.PivotXRelative)).
        Property<RotateDrawable>((t, v) => t.PivotXRelative = NConverters.ToBoolT(v));

    public static NProperty CreatePivotY() => new NProperty(nameof(NProperties.PivotY)).
        Property<View>((t, v) => t.PivotY = NConverters.ToSingleT(v)).
        Property<RotateDrawable>((t, v) => t.PivotY = NConverters.ToSingleT(v));

    public static NProperty CreatePivotYRelative() => new NProperty(nameof(NProperties.PivotYRelative)).
        Property<RotateDrawable>((t, v) => t.PivotYRelative = NConverters.ToBoolT(v));

    public static NProperty CreatePopupTheme() => new NProperty(nameof(NProperties.PopupTheme)).
        Property<ActionMenuView>((t, v) => t.PopupTheme = NConverters.ToInt32T(v)).
        Property<Toolbar>((t, v) => t.PopupTheme = NConverters.ToInt32T(v));

    public static NProperty CreatePrepared() => new NProperty(nameof(NProperties.Prepared)).
        Event<VideoView>((s, a) => s.Prepared += a.EventHandler);

    public static NProperty CreatePreserveEGLContextOnPause() => new NProperty(nameof(NProperties.PreserveEGLContextOnPause)).
        Property<GLSurfaceView>((t, v) => t.PreserveEGLContextOnPause = NConverters.ToBoolT(v));

    public static NProperty CreatePress() => new NProperty(nameof(NProperties.Press)).
        Event<KeyboardView>((s, a) => s.Press += a.EventHandler);

    public static NProperty CreatePressed() => new NProperty(nameof(NProperties.Pressed)).
        Property<View>((t, v) => t.Pressed = NConverters.ToBoolT(v));

    public static NProperty CreatePreviewEnabled() => new NProperty(nameof(NProperties.PreviewEnabled)).
        Property<KeyboardView>((t, v) => t.PreviewEnabled = NConverters.ToBoolT(v));

    public static NProperty CreatePreviousClick() => new NProperty(nameof(NProperties.PreviousClick)).
        Event<MediaController>((s, a) => s.PreviousClick += a.EventHandler);

    public static NProperty CreatePrivateImeOptions() => new NProperty(nameof(NProperties.PrivateImeOptions)).
        Property<TextView>((t, v) => t.PrivateImeOptions = NConverters.ToStringT(v));

    public static NProperty CreateProgress() => new NProperty(nameof(NProperties.Progress)).
        Property<ProgressBar>((t, v) => t.Progress = NConverters.ToInt32T(v));

    public static NProperty CreateProgressChanged() => new NProperty(nameof(NProperties.ProgressChanged)).
        Event<SeekBar>((s, a) => s.ProgressChanged += a.EventHandler);

    public static NProperty CreateProximityCorrectionEnabled() => new NProperty(nameof(NProperties.ProximityCorrectionEnabled)).
        Property<KeyboardView>((t, v) => t.ProximityCorrectionEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateQueryRefinementEnabled() => new NProperty(nameof(NProperties.QueryRefinementEnabled)).
        Property<SearchView>((t, v) => t.QueryRefinementEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateQueryTextChange() => new NProperty(nameof(NProperties.QueryTextChange)).
        Event<SearchView>((s, a) => s.QueryTextChange += a.EventHandler);

    public static NProperty CreateQueryTextFocusChange() => new NProperty(nameof(NProperties.QueryTextFocusChange)).
        Event<SearchView>((s, a) => s.QueryTextFocusChange += a.EventHandler);

    public static NProperty CreateQueryTextSubmit() => new NProperty(nameof(NProperties.QueryTextSubmit)).
        Event<SearchView>((s, a) => s.QueryTextSubmit += a.EventHandler);

    public static NProperty CreateRadius() => new NProperty(nameof(NProperties.Radius)).
        Property<RippleDrawable>((t, v) => t.Radius = NConverters.ToInt32T(v));

    public static NProperty CreateRating() => new NProperty(nameof(NProperties.Rating)).
        Property<RatingBar>((t, v) => t.Rating = NConverters.ToSingleT(v));

    public static NProperty CreateRatingBarChange() => new NProperty(nameof(NProperties.RatingBarChange)).
        Event<RatingBar>((s, a) => s.RatingBarChange += a.EventHandler);

    public static NProperty CreateRelease() => new NProperty(nameof(NProperties.Release)).
        Event<KeyboardView>((s, a) => s.Release += a.EventHandler);

    public static NProperty CreateRenderMode() => new NProperty(nameof(NProperties.RenderMode)).
        Property<GLSurfaceView>((t, v) => t.RenderMode = NConverters.ToEnumT<Rendermode>(v));

    public static NProperty CreateRight() => new NProperty(nameof(NProperties.Right)).
        Property<View>((t, v) => t.Right = NConverters.ToInt32T(v));

    public static NProperty CreateRotation() => new NProperty(nameof(NProperties.Rotation)).
        Property<View>((t, v) => t.Rotation = NConverters.ToSingleT(v));

    public static NProperty CreateRotationX() => new NProperty(nameof(NProperties.RotationX)).
        Property<View>((t, v) => t.RotationX = NConverters.ToSingleT(v));

    public static NProperty CreateRotationY() => new NProperty(nameof(NProperties.RotationY)).
        Property<View>((t, v) => t.RotationY = NConverters.ToSingleT(v));

    public static NProperty CreateRouteTypes() => new NProperty(nameof(NProperties.RouteTypes)).
        Property<MediaRouteButton>((t, v) => t.RouteTypes = NConverters.ToEnumT<MediaRouteType>(v));

    public static NProperty CreateRowCount() => new NProperty(nameof(NProperties.RowCount)).
        Property<GridLayout>((t, v) => t.RowCount = NConverters.ToInt32T(v));

    public static NProperty CreateRowOrderPreserved() => new NProperty(nameof(NProperties.RowOrderPreserved)).
        Property<GridLayout>((t, v) => t.RowOrderPreserved = NConverters.ToBoolT(v));

    public static NProperty CreateSaveEnabled() => new NProperty(nameof(NProperties.SaveEnabled)).
        Property<View>((t, v) => t.SaveEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSaveFromParentEnabled() => new NProperty(nameof(NProperties.SaveFromParentEnabled)).
        Property<View>((t, v) => t.SaveFromParentEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateScaleX() => new NProperty(nameof(NProperties.ScaleX)).
        Property<View>((t, v) => t.ScaleX = NConverters.ToSingleT(v));

    public static NProperty CreateScaleY() => new NProperty(nameof(NProperties.ScaleY)).
        Property<View>((t, v) => t.ScaleY = NConverters.ToSingleT(v));

    public static NProperty CreateScroll() => new NProperty(nameof(NProperties.Scroll)).
        Event<NumberPicker>((s, a) => s.Scroll += a.EventHandler);

    public static NProperty CreateScrollBarDefaultDelayBeforeFade() => new NProperty(nameof(NProperties.ScrollBarDefaultDelayBeforeFade)).
        Property<View>((t, v) => t.ScrollBarDefaultDelayBeforeFade = NConverters.ToInt32T(v));

    public static NProperty CreateScrollBarFadeDuration() => new NProperty(nameof(NProperties.ScrollBarFadeDuration)).
        Property<View>((t, v) => t.ScrollBarFadeDuration = NConverters.ToInt32T(v));

    public static NProperty CreateScrollbarFadingEnabled() => new NProperty(nameof(NProperties.ScrollbarFadingEnabled)).
        Property<View>((t, v) => t.ScrollbarFadingEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateScrollBarSize() => new NProperty(nameof(NProperties.ScrollBarSize)).
        Property<View>((t, v) => t.ScrollBarSize = NConverters.ToInt32T(v));

    public static NProperty CreateScrollBarStyle() => new NProperty(nameof(NProperties.ScrollBarStyle)).
        Property<View>((t, v) => t.ScrollBarStyle = NConverters.ToEnumT<ScrollbarStyles>(v));

    public static NProperty CreateScrollChange() => new NProperty(nameof(NProperties.ScrollChange)).
        Event<View>((s, a) => s.ScrollChange += a.EventHandler);

    public static NProperty CreateScrollEnded() => new NProperty(nameof(NProperties.ScrollEnded)).
        Event<SlidingDrawer>((s, a) => s.ScrollEnded += a.EventHandler);

    public static NProperty CreateScrollStarted() => new NProperty(nameof(NProperties.ScrollStarted)).
        Event<SlidingDrawer>((s, a) => s.ScrollStarted += a.EventHandler);

    public static NProperty CreateScrollX() => new NProperty(nameof(NProperties.ScrollX)).
        Property<View>((t, v) => t.ScrollX = NConverters.ToInt32T(v));

    public static NProperty CreateScrollY() => new NProperty(nameof(NProperties.ScrollY)).
        Property<View>((t, v) => t.ScrollY = NConverters.ToInt32T(v));

    public static NProperty CreateSearchClick() => new NProperty(nameof(NProperties.SearchClick)).
        Event<SearchView>((s, a) => s.SearchClick += a.EventHandler);

    public static NProperty CreateSecondaryProgress() => new NProperty(nameof(NProperties.SecondaryProgress)).
        Property<ProgressBar>((t, v) => t.SecondaryProgress = NConverters.ToInt32T(v));

    public static NProperty CreateSelected() => new NProperty(nameof(NProperties.Selected)).
        Property<View>((t, v) => t.Selected = NConverters.ToBoolT(v));

    public static NProperty CreateShowDividers() => new NProperty(nameof(NProperties.ShowDividers)).
        Property<LinearLayout>((t, v) => t.ShowDividers = NConverters.ToEnumT<ShowDividers>(v));

    public static NProperty CreateShownWeekCount() => new NProperty(nameof(NProperties.ShownWeekCount)).
        Property<CalendarView>((t, v) => t.ShownWeekCount = NConverters.ToInt32T(v));

    public static NProperty CreateShowSoftInputOnFocus() => new NProperty(nameof(NProperties.ShowSoftInputOnFocus)).
        Property<TextView>((t, v) => t.ShowSoftInputOnFocus = NConverters.ToBoolT(v));

    public static NProperty CreateShowText() => new NProperty(nameof(NProperties.ShowText)).
        Property<Switch>((t, v) => t.ShowText = NConverters.ToBoolT(v));

    public static NProperty CreateShowWeekNumber() => new NProperty(nameof(NProperties.ShowWeekNumber)).
        Property<CalendarView>((t, v) => t.ShowWeekNumber = NConverters.ToBoolT(v));

    public static NProperty CreateShrinkAllColumns() => new NProperty(nameof(NProperties.ShrinkAllColumns)).
        Property<TableLayout>((t, v) => t.ShrinkAllColumns = NConverters.ToBoolT(v));

    public static NProperty CreateSmoothScrollingEnabled() => new NProperty(nameof(NProperties.SmoothScrollingEnabled)).
        Property<HorizontalScrollView>((t, v) => t.SmoothScrollingEnabled = NConverters.ToBoolT(v)).
        Property<ScrollView>((t, v) => t.SmoothScrollingEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSoundEffectsEnabled() => new NProperty(nameof(NProperties.SoundEffectsEnabled)).
        Property<View>((t, v) => t.SoundEffectsEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSpinnersShown() => new NProperty(nameof(NProperties.SpinnersShown)).
        Property<DatePicker>((t, v) => t.SpinnersShown = NConverters.ToBoolT(v));

    public static NProperty CreateSplitTrack() => new NProperty(nameof(NProperties.SplitTrack)).
        Property<Switch>((t, v) => t.SplitTrack = NConverters.ToBoolT(v)).
        Property<AbsSeekBar>((t, v) => t.SplitTrack = NConverters.ToBoolT(v));

    public static NProperty CreateStartTrackingTouch() => new NProperty(nameof(NProperties.StartTrackingTouch)).
        Event<SeekBar>((s, a) => s.StartTrackingTouch += a.EventHandler);

    public static NProperty CreateStepSize() => new NProperty(nameof(NProperties.StepSize)).
        Property<RatingBar>((t, v) => t.StepSize = NConverters.ToSingleT(v));

    public static NProperty CreateStopTrackingTouch() => new NProperty(nameof(NProperties.StopTrackingTouch)).
        Event<SeekBar>((s, a) => s.StopTrackingTouch += a.EventHandler);

    public static NProperty CreateStretchAllColumns() => new NProperty(nameof(NProperties.StretchAllColumns)).
        Property<TableLayout>((t, v) => t.StretchAllColumns = NConverters.ToBoolT(v));

    public static NProperty CreateStripEnabled() => new NProperty(nameof(NProperties.StripEnabled)).
        Property<TabWidget>((t, v) => t.StripEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSubmitButtonEnabled() => new NProperty(nameof(NProperties.SubmitButtonEnabled)).
        Property<SearchView>((t, v) => t.SubmitButtonEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSubtitle() => new NProperty(nameof(NProperties.Subtitle)).
        Property<Toolbar>((t, v) => t.Subtitle = NConverters.ToStringT(v));

    public static NProperty CreateSuggestionClick() => new NProperty(nameof(NProperties.SuggestionClick)).
        Event<SearchView>((s, a) => s.SuggestionClick += a.EventHandler);

    public static NProperty CreateSuggestionSelect() => new NProperty(nameof(NProperties.SuggestionSelect)).
        Event<SearchView>((s, a) => s.SuggestionSelect += a.EventHandler);

    public static NProperty CreateSurfaceTextureAvailable() => new NProperty(nameof(NProperties.SurfaceTextureAvailable)).
        Event<TextureView>((s, a) => s.SurfaceTextureAvailable += a.EventHandler);

    public static NProperty CreateSurfaceTextureDestroyed() => new NProperty(nameof(NProperties.SurfaceTextureDestroyed)).
        Event<TextureView>((s, a) => s.SurfaceTextureDestroyed += a.EventHandler);

    public static NProperty CreateSurfaceTextureSizeChanged() => new NProperty(nameof(NProperties.SurfaceTextureSizeChanged)).
        Event<TextureView>((s, a) => s.SurfaceTextureSizeChanged += a.EventHandler);

    public static NProperty CreateSurfaceTextureUpdated() => new NProperty(nameof(NProperties.SurfaceTextureUpdated)).
        Event<TextureView>((s, a) => s.SurfaceTextureUpdated += a.EventHandler);

    public static NProperty CreateSwipeDownEvent() => new NProperty(nameof(NProperties.SwipeDownEvent)).
        Event<KeyboardView>((s, a) => s.SwipeDownEvent += a.EventHandler);

    public static NProperty CreateSwipeLeftEvent() => new NProperty(nameof(NProperties.SwipeLeftEvent)).
        Event<KeyboardView>((s, a) => s.SwipeLeftEvent += a.EventHandler);

    public static NProperty CreateSwipeRightEvent() => new NProperty(nameof(NProperties.SwipeRightEvent)).
        Event<KeyboardView>((s, a) => s.SwipeRightEvent += a.EventHandler);

    public static NProperty CreateSwipeUpEvent() => new NProperty(nameof(NProperties.SwipeUpEvent)).
        Event<KeyboardView>((s, a) => s.SwipeUpEvent += a.EventHandler);

    public static NProperty CreateSwitchMinWidth() => new NProperty(nameof(NProperties.SwitchMinWidth)).
        Property<Switch>((t, v) => t.SwitchMinWidth = NConverters.ToInt32T(v));

    public static NProperty CreateSwitchPadding() => new NProperty(nameof(NProperties.SwitchPadding)).
        Property<Switch>((t, v) => t.SwitchPadding = NConverters.ToInt32T(v));

    public static NProperty CreateSystemUiVisibility() => new NProperty(nameof(NProperties.SystemUiVisibility)).
        Property<View>((t, v) => t.SystemUiVisibility = NConverters.ToEnumT<StatusBarVisibility>(v));

    public static NProperty CreateSystemUiVisibilityChange() => new NProperty(nameof(NProperties.SystemUiVisibilityChange)).
        Event<View>((s, a) => s.SystemUiVisibilityChange += a.EventHandler);

    public static NProperty CreateTabChanged() => new NProperty(nameof(NProperties.TabChanged)).
        Event<TabHost>((s, a) => s.TabChanged += a.EventHandler);

    public static NProperty CreateText() => new NProperty(nameof(NProperties.Text)).
        Event<KeyboardView>((s, a) => s.Text += a.EventHandler).
        Property<TextView>((t, v) => t.Text = NConverters.ToStringT(v));

    public static NProperty CreateTextAlignment() => new NProperty(nameof(NProperties.TextAlignment)).
        Property<View>((t, v) => t.TextAlignment = NConverters.ToEnumT<TextAlignment>(v));

    public static NProperty CreateTextChanged() => new NProperty(nameof(NProperties.TextChanged)).
        Event<TextView>((s, a) => s.TextChanged += a.EventHandler);

    public static NProperty CreateTextDirection() => new NProperty(nameof(NProperties.TextDirection)).
        Property<View>((t, v) => t.TextDirection = NConverters.ToEnumT<TextDirection>(v));

    public static NProperty CreateTextOff() => new NProperty(nameof(NProperties.TextOff)).
        Property<Switch>((t, v) => t.TextOff = NConverters.ToStringT(v)).
        Property<ToggleButton>((t, v) => t.TextOff = NConverters.ToStringT(v));

    public static NProperty CreateTextOn() => new NProperty(nameof(NProperties.TextOn)).
        Property<Switch>((t, v) => t.TextOn = NConverters.ToStringT(v)).
        Property<ToggleButton>((t, v) => t.TextOn = NConverters.ToStringT(v));

    public static NProperty CreateTextScaleX() => new NProperty(nameof(NProperties.TextScaleX)).
        Property<TextView>((t, v) => t.TextScaleX = NConverters.ToSingleT(v));

    public static NProperty CreateTextSize() => new NProperty(nameof(NProperties.TextSize)).
        Property<TextView>((t, v) => t.TextSize = NConverters.ToSingleT(v));

    public static NProperty CreateThreshold() => new NProperty(nameof(NProperties.Threshold)).
        Property<AutoCompleteTextView>((t, v) => t.Threshold = NConverters.ToInt32T(v));

    public static NProperty CreateThumbOffset() => new NProperty(nameof(NProperties.ThumbOffset)).
        Property<AbsSeekBar>((t, v) => t.ThumbOffset = NConverters.ToInt32T(v));

    public static NProperty CreateThumbTextPadding() => new NProperty(nameof(NProperties.ThumbTextPadding)).
        Property<Switch>((t, v) => t.ThumbTextPadding = NConverters.ToInt32T(v));

    public static NProperty CreateTimeChanged() => new NProperty(nameof(NProperties.TimeChanged)).
        Event<TimePicker>((s, a) => s.TimeChanged += a.EventHandler);

    public static NProperty CreateTimeZone() => new NProperty(nameof(NProperties.TimeZone)).
        Property<TextClock>((t, v) => t.TimeZone = NConverters.ToStringT(v));

    public static NProperty CreateTitle() => new NProperty(nameof(NProperties.Title)).
        Property<Toolbar>((t, v) => t.Title = NConverters.ToStringT(v));

    public static NProperty CreateToDegrees() => new NProperty(nameof(NProperties.ToDegrees)).
        Property<RotateDrawable>((t, v) => t.ToDegrees = NConverters.ToSingleT(v));

    public static NProperty CreateTop() => new NProperty(nameof(NProperties.Top)).
        Property<View>((t, v) => t.Top = NConverters.ToInt32T(v));

    public static NProperty CreateTouch() => new NProperty(nameof(NProperties.Touch)).
        Event<View>((s, a) => s.Touch += a.EventHandler);

    public static NProperty CreateTouchscreenBlocksFocus() => new NProperty(nameof(NProperties.TouchscreenBlocksFocus)).
        Property<ViewGroup>((t, v) => t.TouchscreenBlocksFocus = NConverters.ToBoolT(v));

    public static NProperty CreateTransitionGroup() => new NProperty(nameof(NProperties.TransitionGroup)).
        Property<ViewGroup>((t, v) => t.TransitionGroup = NConverters.ToBoolT(v));

    public static NProperty CreateTransitionName() => new NProperty(nameof(NProperties.TransitionName)).
        Property<View>((t, v) => t.TransitionName = NConverters.ToStringT(v));

    public static NProperty CreateTranslationX() => new NProperty(nameof(NProperties.TranslationX)).
        Property<View>((t, v) => t.TranslationX = NConverters.ToSingleT(v));

    public static NProperty CreateTranslationY() => new NProperty(nameof(NProperties.TranslationY)).
        Property<View>((t, v) => t.TranslationY = NConverters.ToSingleT(v));

    public static NProperty CreateTranslationZ() => new NProperty(nameof(NProperties.TranslationZ)).
        Property<View>((t, v) => t.TranslationZ = NConverters.ToSingleT(v));

    public static NProperty CreateUnhandledInputEvent() => new NProperty(nameof(NProperties.UnhandledInputEvent)).
        Event<TvView>((s, a) => s.UnhandledInputEvent += a.EventHandler);

    public static NProperty CreateUseDefaultMargins() => new NProperty(nameof(NProperties.UseDefaultMargins)).
        Property<GridLayout>((t, v) => t.UseDefaultMargins = NConverters.ToBoolT(v));

    public static NProperty CreateValue() => new NProperty(nameof(NProperties.Value)).
        Property<NumberPicker>((t, v) => t.Value = NConverters.ToInt32T(v));

    public static NProperty CreateValueChanged() => new NProperty(nameof(NProperties.ValueChanged)).
        Event<NumberPicker>((s, a) => s.ValueChanged += a.EventHandler);

    public static NProperty CreateVerticalFadingEdgeEnabled() => new NProperty(nameof(NProperties.VerticalFadingEdgeEnabled)).
        Property<View>((t, v) => t.VerticalFadingEdgeEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateVerticalScrollBarEnabled() => new NProperty(nameof(NProperties.VerticalScrollBarEnabled)).
        Property<View>((t, v) => t.VerticalScrollBarEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateVerticalScrollbarPosition() => new NProperty(nameof(NProperties.VerticalScrollbarPosition)).
        Property<View>((t, v) => t.VerticalScrollbarPosition = NConverters.ToEnumT<ScrollbarPosition>(v));

    public static NProperty CreateViewAttachedToWindow() => new NProperty(nameof(NProperties.ViewAttachedToWindow)).
        Event<View>((s, a) => s.ViewAttachedToWindow += a.EventHandler);

    public static NProperty CreateViewDetachedFromWindow() => new NProperty(nameof(NProperties.ViewDetachedFromWindow)).
        Event<View>((s, a) => s.ViewDetachedFromWindow += a.EventHandler);

    public static NProperty CreateVisibility() => new NProperty(nameof(NProperties.Visibility)).
        Property<View>((t, v) => t.Visibility = NConverters.ToEnumT<ViewStates>(v));

    public static NProperty CreateWeekDayTextAppearance() => new NProperty(nameof(NProperties.WeekDayTextAppearance)).
        Property<CalendarView>((t, v) => t.WeekDayTextAppearance = NConverters.ToInt32T(v));

    public static NProperty CreateWeightSum() => new NProperty(nameof(NProperties.WeightSum)).
        Property<LinearLayout>((t, v) => t.WeightSum = NConverters.ToSingleT(v));

    public static NProperty CreateWrapSelectorWheel() => new NProperty(nameof(NProperties.WrapSelectorWheel)).
        Property<NumberPicker>((t, v) => t.WrapSelectorWheel = NConverters.ToBoolT(v));

    public static NProperty CreateZoomInClick() => new NProperty(nameof(NProperties.ZoomInClick)).
        Event<ZoomControls>((s, a) => s.ZoomInClick += a.EventHandler);

    public static NProperty CreateZoomOutClick() => new NProperty(nameof(NProperties.ZoomOutClick)).
        Event<ZoomControls>((s, a) => s.ZoomOutClick += a.EventHandler);

  }
}
