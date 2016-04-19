using System;
using Xamarin.Forms;

namespace NReact
{

  public partial class NProperties
  {
    public NProperty AnchorX { get { return _anchorX ?? (_anchorX = NPropFactories.CreateAnchorX()); } }
           NProperty _anchorX;

    public NProperty AnchorY { get { return _anchorY ?? (_anchorY = NPropFactories.CreateAnchorY()); } }
           NProperty _anchorY;

    public NProperty Appearing { get { return _appearing ?? (_appearing = NPropFactories.CreateAppearing()); } }
           NProperty _appearing;

    public NProperty Aspect { get { return _aspect ?? (_aspect = NPropFactories.CreateAspect()); } }
           NProperty _aspect;

    public NProperty BackgroundColor { get { return _backgroundColor ?? (_backgroundColor = NPropFactories.CreateBackgroundColor()); } }
           NProperty _backgroundColor;

    public NProperty BackgroundImage { get { return _backgroundImage ?? (_backgroundImage = NPropFactories.CreateBackgroundImage()); } }
           NProperty _backgroundImage;

    public NProperty BarBackgroundColor { get { return _barBackgroundColor ?? (_barBackgroundColor = NPropFactories.CreateBarBackgroundColor()); } }
           NProperty _barBackgroundColor;

    public NProperty BarTextColor { get { return _barTextColor ?? (_barTextColor = NPropFactories.CreateBarTextColor()); } }
           NProperty _barTextColor;

    public NProperty BorderColor { get { return _borderColor ?? (_borderColor = NPropFactories.CreateBorderColor()); } }
           NProperty _borderColor;

    public NProperty BorderRadius { get { return _borderRadius ?? (_borderRadius = NPropFactories.CreateBorderRadius()); } }
           NProperty _borderRadius;

    public NProperty BorderWidth { get { return _borderWidth ?? (_borderWidth = NPropFactories.CreateBorderWidth()); } }
           NProperty _borderWidth;

    public NProperty CancelButtonColor { get { return _cancelButtonColor ?? (_cancelButtonColor = NPropFactories.CreateCancelButtonColor()); } }
           NProperty _cancelButtonColor;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
           NProperty _child;

    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
           NProperty _children;

    public NProperty ChildrenReordered { get { return _childrenReordered ?? (_childrenReordered = NPropFactories.CreateChildrenReordered()); } }
           NProperty _childrenReordered;

    public NProperty Clicked { get { return _clicked ?? (_clicked = NPropFactories.CreateClicked()); } }
           NProperty _clicked;

    public NProperty Color { get { return _color ?? (_color = NPropFactories.CreateColor()); } }
           NProperty _color;

    public NProperty Command { get { return _command ?? (_command = NPropFactories.CreateCommand()); } }
           NProperty _command;

    public NProperty CommandParameter { get { return _commandParameter ?? (_commandParameter = NPropFactories.CreateCommandParameter()); } }
           NProperty _commandParameter;

    public NProperty Completed { get { return _completed ?? (_completed = NPropFactories.CreateCompleted()); } }
           NProperty _completed;

    public NProperty Content { get { return _content ?? (_content = NPropFactories.CreateContent()); } }
           NProperty _content;

    public NProperty ControlTemplate { get { return _controlTemplate ?? (_controlTemplate = NPropFactories.CreateControlTemplate()); } }
           NProperty _controlTemplate;

    public NProperty Date { get { return _date ?? (_date = NPropFactories.CreateDate()); } }
           NProperty _date;

    public NProperty DateSelected { get { return _dateSelected ?? (_dateSelected = NPropFactories.CreateDateSelected()); } }
           NProperty _dateSelected;

    public NProperty Disappearing { get { return _disappearing ?? (_disappearing = NPropFactories.CreateDisappearing()); } }
           NProperty _disappearing;

    public NProperty Focused { get { return _focused ?? (_focused = NPropFactories.CreateFocused()); } }
           NProperty _focused;

    public NProperty Font { get { return _font ?? (_font = NPropFactories.CreateFont()); } }
           NProperty _font;

    public NProperty FontAttributes { get { return _fontAttributes ?? (_fontAttributes = NPropFactories.CreateFontAttributes()); } }
           NProperty _fontAttributes;

    public NProperty FontFamily { get { return _fontFamily ?? (_fontFamily = NPropFactories.CreateFontFamily()); } }
           NProperty _fontFamily;

    public NProperty FontSize { get { return _fontSize ?? (_fontSize = NPropFactories.CreateFontSize()); } }
           NProperty _fontSize;

    public NProperty Format { get { return _format ?? (_format = NPropFactories.CreateFormat()); } }
           NProperty _format;

    public NProperty FormattedText { get { return _formattedText ?? (_formattedText = NPropFactories.CreateFormattedText()); } }
           NProperty _formattedText;

    public NProperty HasRenderLoop { get { return _hasRenderLoop ?? (_hasRenderLoop = NPropFactories.CreateHasRenderLoop()); } }
           NProperty _hasRenderLoop;

    public NProperty HasShadow { get { return _hasShadow ?? (_hasShadow = NPropFactories.CreateHasShadow()); } }
           NProperty _hasShadow;

    public NProperty HasUnevenRows { get { return _hasUnevenRows ?? (_hasUnevenRows = NPropFactories.CreateHasUnevenRows()); } }
           NProperty _hasUnevenRows;

    public NProperty HeightRequest { get { return _heightRequest ?? (_heightRequest = NPropFactories.CreateHeightRequest()); } }
           NProperty _heightRequest;

    public NProperty HorizontalOptions { get { return _horizontalOptions ?? (_horizontalOptions = NPropFactories.CreateHorizontalOptions()); } }
           NProperty _horizontalOptions;

    public NProperty HorizontalTextAlignment { get { return _horizontalTextAlignment ?? (_horizontalTextAlignment = NPropFactories.CreateHorizontalTextAlignment()); } }
           NProperty _horizontalTextAlignment;

    public NProperty Icon { get { return _icon ?? (_icon = NPropFactories.CreateIcon()); } }
           NProperty _icon;

    public NProperty Image { get { return _image ?? (_image = NPropFactories.CreateImage()); } }
           NProperty _image;

    public NProperty Increment { get { return _increment ?? (_increment = NPropFactories.CreateIncrement()); } }
           NProperty _increment;

    public NProperty InputTransparent { get { return _inputTransparent ?? (_inputTransparent = NPropFactories.CreateInputTransparent()); } }
           NProperty _inputTransparent;

    public NProperty Intent { get { return _intent ?? (_intent = NPropFactories.CreateIntent()); } }
           NProperty _intent;

    public NProperty IsBusy { get { return _isBusy ?? (_isBusy = NPropFactories.CreateIsBusy()); } }
           NProperty _isBusy;

    public NProperty IsClippedToBounds { get { return _isClippedToBounds ?? (_isClippedToBounds = NPropFactories.CreateIsClippedToBounds()); } }
           NProperty _isClippedToBounds;

    public NProperty IsEnabled { get { return _isEnabled ?? (_isEnabled = NPropFactories.CreateIsEnabled()); } }
           NProperty _isEnabled;

    public NProperty IsGestureEnabled { get { return _isGestureEnabled ?? (_isGestureEnabled = NPropFactories.CreateIsGestureEnabled()); } }
           NProperty _isGestureEnabled;

    public NProperty IsOpaque { get { return _isOpaque ?? (_isOpaque = NPropFactories.CreateIsOpaque()); } }
           NProperty _isOpaque;

    public NProperty IsPassword { get { return _isPassword ?? (_isPassword = NPropFactories.CreateIsPassword()); } }
           NProperty _isPassword;

    public NProperty IsPresented { get { return _isPresented ?? (_isPresented = NPropFactories.CreateIsPresented()); } }
           NProperty _isPresented;

    public NProperty IsPresentedChanged { get { return _isPresentedChanged ?? (_isPresentedChanged = NPropFactories.CreateIsPresentedChanged()); } }
           NProperty _isPresentedChanged;

    public NProperty IsRunning { get { return _isRunning ?? (_isRunning = NPropFactories.CreateIsRunning()); } }
           NProperty _isRunning;

    public NProperty IsToggled { get { return _isToggled ?? (_isToggled = NPropFactories.CreateIsToggled()); } }
           NProperty _isToggled;

    public NProperty IsVisible { get { return _isVisible ?? (_isVisible = NPropFactories.CreateIsVisible()); } }
           NProperty _isVisible;

    public NProperty Keyboard { get { return _keyboard ?? (_keyboard = NPropFactories.CreateKeyboard()); } }
           NProperty _keyboard;

    public NProperty LayoutChanged { get { return _layoutChanged ?? (_layoutChanged = NPropFactories.CreateLayoutChanged()); } }
           NProperty _layoutChanged;

    public NProperty LineBreakMode { get { return _lineBreakMode ?? (_lineBreakMode = NPropFactories.CreateLineBreakMode()); } }
           NProperty _lineBreakMode;

    public NProperty MasterBehavior { get { return _masterBehavior ?? (_masterBehavior = NPropFactories.CreateMasterBehavior()); } }
           NProperty _masterBehavior;

    public NProperty Maximum { get { return _maximum ?? (_maximum = NPropFactories.CreateMaximum()); } }
           NProperty _maximum;

    public NProperty MaximumDate { get { return _maximumDate ?? (_maximumDate = NPropFactories.CreateMaximumDate()); } }
           NProperty _maximumDate;

    public NProperty MeasureInvalidated { get { return _measureInvalidated ?? (_measureInvalidated = NPropFactories.CreateMeasureInvalidated()); } }
           NProperty _measureInvalidated;

    public NProperty Minimum { get { return _minimum ?? (_minimum = NPropFactories.CreateMinimum()); } }
           NProperty _minimum;

    public NProperty MinimumDate { get { return _minimumDate ?? (_minimumDate = NPropFactories.CreateMinimumDate()); } }
           NProperty _minimumDate;

    public NProperty MinimumHeightRequest { get { return _minimumHeightRequest ?? (_minimumHeightRequest = NPropFactories.CreateMinimumHeightRequest()); } }
           NProperty _minimumHeightRequest;

    public NProperty MinimumWidthRequest { get { return _minimumWidthRequest ?? (_minimumWidthRequest = NPropFactories.CreateMinimumWidthRequest()); } }
           NProperty _minimumWidthRequest;

    public NProperty Navigated { get { return _navigated ?? (_navigated = NPropFactories.CreateNavigated()); } }
           NProperty _navigated;

    public NProperty Navigating { get { return _navigating ?? (_navigating = NPropFactories.CreateNavigating()); } }
           NProperty _navigating;

    public NProperty NavigationPageBackButtonTitle { get { return _navigationPageBackButtonTitle ?? (_navigationPageBackButtonTitle = NPropFactories.CreateNavigationPageBackButtonTitle()); } }
           NProperty _navigationPageBackButtonTitle;

    public NProperty NavigationPageHasBackButton { get { return _navigationPageHasBackButton ?? (_navigationPageHasBackButton = NPropFactories.CreateNavigationPageHasBackButton()); } }
           NProperty _navigationPageHasBackButton;

    public NProperty NavigationPageHasNavigationBar { get { return _navigationPageHasNavigationBar ?? (_navigationPageHasNavigationBar = NPropFactories.CreateNavigationPageHasNavigationBar()); } }
           NProperty _navigationPageHasNavigationBar;

    public NProperty NavigationPageTitleIcon { get { return _navigationPageTitleIcon ?? (_navigationPageTitleIcon = NPropFactories.CreateNavigationPageTitleIcon()); } }
           NProperty _navigationPageTitleIcon;

    public NProperty Opacity { get { return _opacity ?? (_opacity = NPropFactories.CreateOpacity()); } }
           NProperty _opacity;

    public NProperty Orientation { get { return _orientation ?? (_orientation = NPropFactories.CreateOrientation()); } }
           NProperty _orientation;

    public NProperty OutlineColor { get { return _outlineColor ?? (_outlineColor = NPropFactories.CreateOutlineColor()); } }
           NProperty _outlineColor;

    public NProperty Padding { get { return _padding ?? (_padding = NPropFactories.CreatePadding()); } }
           NProperty _padding;

    public NProperty Placeholder { get { return _placeholder ?? (_placeholder = NPropFactories.CreatePlaceholder()); } }
           NProperty _placeholder;

    public NProperty PlaceholderColor { get { return _placeholderColor ?? (_placeholderColor = NPropFactories.CreatePlaceholderColor()); } }
           NProperty _placeholderColor;

    public NProperty Popped { get { return _popped ?? (_popped = NPropFactories.CreatePopped()); } }
           NProperty _popped;

    public NProperty PoppedToRoot { get { return _poppedToRoot ?? (_poppedToRoot = NPropFactories.CreatePoppedToRoot()); } }
           NProperty _poppedToRoot;

    public NProperty Progress { get { return _progress ?? (_progress = NPropFactories.CreateProgress()); } }
           NProperty _progress;

    public NProperty Pushed { get { return _pushed ?? (_pushed = NPropFactories.CreatePushed()); } }
           NProperty _pushed;

    public NProperty Root { get { return _root ?? (_root = NPropFactories.CreateRoot()); } }
           NProperty _root;

    public NProperty Rotation { get { return _rotation ?? (_rotation = NPropFactories.CreateRotation()); } }
           NProperty _rotation;

    public NProperty RotationX { get { return _rotationX ?? (_rotationX = NPropFactories.CreateRotationX()); } }
           NProperty _rotationX;

    public NProperty RotationY { get { return _rotationY ?? (_rotationY = NPropFactories.CreateRotationY()); } }
           NProperty _rotationY;

    public NProperty RowHeight { get { return _rowHeight ?? (_rowHeight = NPropFactories.CreateRowHeight()); } }
           NProperty _rowHeight;

    public NProperty Scale { get { return _scale ?? (_scale = NPropFactories.CreateScale()); } }
           NProperty _scale;

    public NProperty Scrolled { get { return _scrolled ?? (_scrolled = NPropFactories.CreateScrolled()); } }
           NProperty _scrolled;

    public NProperty SearchButtonPressed { get { return _searchButtonPressed ?? (_searchButtonPressed = NPropFactories.CreateSearchButtonPressed()); } }
           NProperty _searchButtonPressed;

    public NProperty SearchCommand { get { return _searchCommand ?? (_searchCommand = NPropFactories.CreateSearchCommand()); } }
           NProperty _searchCommand;

    public NProperty SearchCommandParameter { get { return _searchCommandParameter ?? (_searchCommandParameter = NPropFactories.CreateSearchCommandParameter()); } }
           NProperty _searchCommandParameter;

    public NProperty SelectedIndex { get { return _selectedIndex ?? (_selectedIndex = NPropFactories.CreateSelectedIndex()); } }
           NProperty _selectedIndex;

    public NProperty SelectedIndexChanged { get { return _selectedIndexChanged ?? (_selectedIndexChanged = NPropFactories.CreateSelectedIndexChanged()); } }
           NProperty _selectedIndexChanged;

    public NProperty SizeChanged { get { return _sizeChanged ?? (_sizeChanged = NPropFactories.CreateSizeChanged()); } }
           NProperty _sizeChanged;

    public NProperty Source { get { return _source ?? (_source = NPropFactories.CreateSource()); } }
           NProperty _source;

    public NProperty Style { get { return _style ?? (_style = NPropFactories.CreateStyle()); } }
           NProperty _style;

    public NProperty Text { get { return _text ?? (_text = NPropFactories.CreateText()); } }
           NProperty _text;

    public NProperty TextChanged { get { return _textChanged ?? (_textChanged = NPropFactories.CreateTextChanged()); } }
           NProperty _textChanged;

    public NProperty TextColor { get { return _textColor ?? (_textColor = NPropFactories.CreateTextColor()); } }
           NProperty _textColor;

    public NProperty Time { get { return _time ?? (_time = NPropFactories.CreateTime()); } }
           NProperty _time;

    public NProperty Tint { get { return _tint ?? (_tint = NPropFactories.CreateTint()); } }
           NProperty _tint;

    public NProperty Title { get { return _title ?? (_title = NPropFactories.CreateTitle()); } }
           NProperty _title;

    public NProperty Toggled { get { return _toggled ?? (_toggled = NPropFactories.CreateToggled()); } }
           NProperty _toggled;

    public NProperty TranslationX { get { return _translationX ?? (_translationX = NPropFactories.CreateTranslationX()); } }
           NProperty _translationX;

    public NProperty TranslationY { get { return _translationY ?? (_translationY = NPropFactories.CreateTranslationY()); } }
           NProperty _translationY;

    public NProperty Unfocused { get { return _unfocused ?? (_unfocused = NPropFactories.CreateUnfocused()); } }
           NProperty _unfocused;

    public NProperty Value { get { return _value ?? (_value = NPropFactories.CreateValue()); } }
           NProperty _value;

    public NProperty ValueChanged { get { return _valueChanged ?? (_valueChanged = NPropFactories.CreateValueChanged()); } }
           NProperty _valueChanged;

    public NProperty VerticalOptions { get { return _verticalOptions ?? (_verticalOptions = NPropFactories.CreateVerticalOptions()); } }
           NProperty _verticalOptions;

    public NProperty VerticalTextAlignment { get { return _verticalTextAlignment ?? (_verticalTextAlignment = NPropFactories.CreateVerticalTextAlignment()); } }
           NProperty _verticalTextAlignment;

    public NProperty WidthRequest { get { return _widthRequest ?? (_widthRequest = NPropFactories.CreateWidthRequest()); } }
           NProperty _widthRequest;

    public NProperty XAlign { get { return _xAlign ?? (_xAlign = NPropFactories.CreateXAlign()); } }
           NProperty _xAlign;

    public NProperty YAlign { get { return _yAlign ?? (_yAlign = NPropFactories.CreateYAlign()); } }
           NProperty _yAlign;

  }

  static partial class NPropFactories
  {
    public static NProperty CreateAnchorX() => new NProperty(nameof(NProperties.AnchorX)).
        Property<VisualElement>(VisualElement.AnchorXProperty, NConverters.ToDouble);

    public static NProperty CreateAnchorY() => new NProperty(nameof(NProperties.AnchorY)).
        Property<VisualElement>(VisualElement.AnchorYProperty, NConverters.ToDouble);

    public static NProperty CreateAppearing() => new NProperty(nameof(NProperties.Appearing)).
        Event<Page>((s, a) => s.Appearing += a.EventHandler);

    public static NProperty CreateAspect() => new NProperty(nameof(NProperties.Aspect)).
        Property<Image>(Image.AspectProperty, NConverters.ToEnum<Aspect>);

    public static NProperty CreateBackgroundColor() => new NProperty(nameof(NProperties.BackgroundColor)).
        Property<VisualElement>(VisualElement.BackgroundColorProperty);

    public static NProperty CreateBackgroundImage() => new NProperty(nameof(NProperties.BackgroundImage)).
        Property<Page>(Page.BackgroundImageProperty, NConverters.ToString);

    public static NProperty CreateBarBackgroundColor() => new NProperty(nameof(NProperties.BarBackgroundColor)).
        Property<NavigationPage>(NavigationPage.BarBackgroundColorProperty);

    public static NProperty CreateBarTextColor() => new NProperty(nameof(NProperties.BarTextColor)).
        Property<NavigationPage>(NavigationPage.BarTextColorProperty);

    public static NProperty CreateBorderColor() => new NProperty(nameof(NProperties.BorderColor)).
        Property<Button>(Button.BorderColorProperty);

    public static NProperty CreateBorderRadius() => new NProperty(nameof(NProperties.BorderRadius)).
        Property<Button>(Button.BorderRadiusProperty, NConverters.ToInt32);

    public static NProperty CreateBorderWidth() => new NProperty(nameof(NProperties.BorderWidth)).
        Property<Button>(Button.BorderWidthProperty, NConverters.ToDouble);

    public static NProperty CreateCancelButtonColor() => new NProperty(nameof(NProperties.CancelButtonColor)).
        Property<SearchBar>(SearchBar.CancelButtonColorProperty);

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child));

    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children));

    public static NProperty CreateChildrenReordered() => new NProperty(nameof(NProperties.ChildrenReordered)).
        Event<VisualElement>((s, a) => s.ChildrenReordered += a.EventHandler);

    public static NProperty CreateClicked() => new NProperty(nameof(NProperties.Clicked)).
        Event<Button>((s, a) => s.Clicked += a.EventHandler);

    public static NProperty CreateColor() => new NProperty(nameof(NProperties.Color)).
        Property<ActivityIndicator>(ActivityIndicator.ColorProperty).
        Property<BoxView>(BoxView.ColorProperty);

    public static NProperty CreateCommand() => new NProperty(nameof(NProperties.Command)).
        Property<Button>(Button.CommandProperty);

    public static NProperty CreateCommandParameter() => new NProperty(nameof(NProperties.CommandParameter)).
        Property<Button>(Button.CommandParameterProperty);

    public static NProperty CreateCompleted() => new NProperty(nameof(NProperties.Completed)).
        Event<Editor>((s, a) => s.Completed += a.EventHandler).
        Event<Entry>((s, a) => s.Completed += a.EventHandler);

    public static NProperty CreateContent() => new NProperty(nameof(NProperties.Content)).
        Property<ContentPresenter>(ContentPresenter.ContentProperty).
        Property<ContentView>(ContentView.ContentProperty).
        Property<ContentPage>(ContentPage.ContentProperty);

    public static NProperty CreateControlTemplate() => new NProperty(nameof(NProperties.ControlTemplate)).
        Property<TemplatedView>(TemplatedView.ControlTemplateProperty).
        Property<TemplatedPage>(TemplatedPage.ControlTemplateProperty);

    public static NProperty CreateDate() => new NProperty(nameof(NProperties.Date)).
        Property<DatePicker>(DatePicker.DateProperty);

    public static NProperty CreateDateSelected() => new NProperty(nameof(NProperties.DateSelected)).
        Event<DatePicker>((s, a) => s.DateSelected += a.EventHandler);

    public static NProperty CreateDisappearing() => new NProperty(nameof(NProperties.Disappearing)).
        Event<Page>((s, a) => s.Disappearing += a.EventHandler);

    public static NProperty CreateFocused() => new NProperty(nameof(NProperties.Focused)).
        Event<VisualElement>((s, a) => s.Focused += a.EventHandler);

    public static NProperty CreateFont() => new NProperty(nameof(NProperties.Font)).
        Property<Button>(Button.FontProperty).
        Property<Label>(Label.FontProperty);

    public static NProperty CreateFontAttributes() => new NProperty(nameof(NProperties.FontAttributes)).
        Property<Button>(Button.FontAttributesProperty, NConverters.ToEnum<FontAttributes>).
        Property<Editor>(Editor.FontAttributesProperty, NConverters.ToEnum<FontAttributes>).
        Property<Entry>(Entry.FontAttributesProperty, NConverters.ToEnum<FontAttributes>).
        Property<Label>(Label.FontAttributesProperty, NConverters.ToEnum<FontAttributes>).
        Property<SearchBar>(SearchBar.FontAttributesProperty, NConverters.ToEnum<FontAttributes>);

    public static NProperty CreateFontFamily() => new NProperty(nameof(NProperties.FontFamily)).
        Property<Button>(Button.FontFamilyProperty, NConverters.ToString).
        Property<Editor>(Editor.FontFamilyProperty, NConverters.ToString).
        Property<Entry>(Entry.FontFamilyProperty, NConverters.ToString).
        Property<Label>(Label.FontFamilyProperty, NConverters.ToString).
        Property<SearchBar>(SearchBar.FontFamilyProperty, NConverters.ToString);

    public static NProperty CreateFontSize() => new NProperty(nameof(NProperties.FontSize)).
        Property<Button>(Button.FontSizeProperty, NConverters.ToDouble).
        Property<Editor>(Editor.FontSizeProperty, NConverters.ToDouble).
        Property<Entry>(Entry.FontSizeProperty, NConverters.ToDouble).
        Property<Label>(Label.FontSizeProperty, NConverters.ToDouble).
        Property<SearchBar>(SearchBar.FontSizeProperty, NConverters.ToDouble);

    public static NProperty CreateFormat() => new NProperty(nameof(NProperties.Format)).
        Property<DatePicker>(DatePicker.FormatProperty, NConverters.ToString).
        Property<TimePicker>(TimePicker.FormatProperty, NConverters.ToString);

    public static NProperty CreateFormattedText() => new NProperty(nameof(NProperties.FormattedText)).
        Property<Label>(Label.FormattedTextProperty);

    public static NProperty CreateHasRenderLoop() => new NProperty(nameof(NProperties.HasRenderLoop)).
        Property<OpenGLView>(OpenGLView.HasRenderLoopProperty, NConverters.ToBool);

    public static NProperty CreateHasShadow() => new NProperty(nameof(NProperties.HasShadow)).
        Property<Frame>(Frame.HasShadowProperty, NConverters.ToBool);

    public static NProperty CreateHasUnevenRows() => new NProperty(nameof(NProperties.HasUnevenRows)).
        Property<TableView>(TableView.HasUnevenRowsProperty, NConverters.ToBool);

    public static NProperty CreateHeightRequest() => new NProperty(nameof(NProperties.HeightRequest)).
        Property<VisualElement>(VisualElement.HeightRequestProperty, NConverters.ToDouble);

    public static NProperty CreateHorizontalOptions() => new NProperty(nameof(NProperties.HorizontalOptions)).
        Property<View>(View.HorizontalOptionsProperty);

    public static NProperty CreateHorizontalTextAlignment() => new NProperty(nameof(NProperties.HorizontalTextAlignment)).
        Property<Entry>(Entry.HorizontalTextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<Label>(Label.HorizontalTextAlignmentProperty, NConverters.ToEnum<TextAlignment>).
        Property<SearchBar>(SearchBar.HorizontalTextAlignmentProperty, NConverters.ToEnum<TextAlignment>);

    public static NProperty CreateIcon() => new NProperty(nameof(NProperties.Icon)).
        Property<Page>(Page.IconProperty);

    public static NProperty CreateImage() => new NProperty(nameof(NProperties.Image)).
        Property<Button>(Button.ImageProperty);

    public static NProperty CreateIncrement() => new NProperty(nameof(NProperties.Increment)).
        Property<Stepper>(Stepper.IncrementProperty, NConverters.ToDouble);

    public static NProperty CreateInputTransparent() => new NProperty(nameof(NProperties.InputTransparent)).
        Property<VisualElement>(VisualElement.InputTransparentProperty, NConverters.ToBool);

    public static NProperty CreateIntent() => new NProperty(nameof(NProperties.Intent)).
        Property<TableView>((t, v) => t.Intent = NConverters.ToEnumT<TableIntent>(v));

    public static NProperty CreateIsBusy() => new NProperty(nameof(NProperties.IsBusy)).
        Property<Page>(Page.IsBusyProperty, NConverters.ToBool);

    public static NProperty CreateIsClippedToBounds() => new NProperty(nameof(NProperties.IsClippedToBounds)).
        Property<Layout>(Layout.IsClippedToBoundsProperty, NConverters.ToBool);

    public static NProperty CreateIsEnabled() => new NProperty(nameof(NProperties.IsEnabled)).
        Property<VisualElement>(VisualElement.IsEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsGestureEnabled() => new NProperty(nameof(NProperties.IsGestureEnabled)).
        Property<MasterDetailPage>(MasterDetailPage.IsGestureEnabledProperty, NConverters.ToBool);

    public static NProperty CreateIsOpaque() => new NProperty(nameof(NProperties.IsOpaque)).
        Property<Image>(Image.IsOpaqueProperty, NConverters.ToBool);

    public static NProperty CreateIsPassword() => new NProperty(nameof(NProperties.IsPassword)).
        Property<Entry>(Entry.IsPasswordProperty, NConverters.ToBool);

    public static NProperty CreateIsPresented() => new NProperty(nameof(NProperties.IsPresented)).
        Property<MasterDetailPage>(MasterDetailPage.IsPresentedProperty, NConverters.ToBool);

    public static NProperty CreateIsPresentedChanged() => new NProperty(nameof(NProperties.IsPresentedChanged)).
        Event<MasterDetailPage>((s, a) => s.IsPresentedChanged += a.EventHandler);

    public static NProperty CreateIsRunning() => new NProperty(nameof(NProperties.IsRunning)).
        Property<ActivityIndicator>(ActivityIndicator.IsRunningProperty, NConverters.ToBool);

    public static NProperty CreateIsToggled() => new NProperty(nameof(NProperties.IsToggled)).
        Property<Switch>(Switch.IsToggledProperty, NConverters.ToBool);

    public static NProperty CreateIsVisible() => new NProperty(nameof(NProperties.IsVisible)).
        Property<VisualElement>(VisualElement.IsVisibleProperty, NConverters.ToBool);

    public static NProperty CreateKeyboard() => new NProperty(nameof(NProperties.Keyboard)).
        Property<InputView>(InputView.KeyboardProperty);

    public static NProperty CreateLayoutChanged() => new NProperty(nameof(NProperties.LayoutChanged)).
        Event<Layout>((s, a) => s.LayoutChanged += a.EventHandler).
        Event<Page>((s, a) => s.LayoutChanged += a.EventHandler);

    public static NProperty CreateLineBreakMode() => new NProperty(nameof(NProperties.LineBreakMode)).
        Property<Label>(Label.LineBreakModeProperty, NConverters.ToEnum<LineBreakMode>);

    public static NProperty CreateMasterBehavior() => new NProperty(nameof(NProperties.MasterBehavior)).
        Property<MasterDetailPage>(MasterDetailPage.MasterBehaviorProperty, NConverters.ToEnum<MasterBehavior>);

    public static NProperty CreateMaximum() => new NProperty(nameof(NProperties.Maximum)).
        Property<Slider>(Slider.MaximumProperty, NConverters.ToDouble).
        Property<Stepper>(Stepper.MaximumProperty, NConverters.ToDouble);

    public static NProperty CreateMaximumDate() => new NProperty(nameof(NProperties.MaximumDate)).
        Property<DatePicker>(DatePicker.MaximumDateProperty);

    public static NProperty CreateMeasureInvalidated() => new NProperty(nameof(NProperties.MeasureInvalidated)).
        Event<VisualElement>((s, a) => s.MeasureInvalidated += a.EventHandler);

    public static NProperty CreateMinimum() => new NProperty(nameof(NProperties.Minimum)).
        Property<Slider>(Slider.MinimumProperty, NConverters.ToDouble).
        Property<Stepper>(Stepper.MinimumProperty, NConverters.ToDouble);

    public static NProperty CreateMinimumDate() => new NProperty(nameof(NProperties.MinimumDate)).
        Property<DatePicker>(DatePicker.MinimumDateProperty);

    public static NProperty CreateMinimumHeightRequest() => new NProperty(nameof(NProperties.MinimumHeightRequest)).
        Property<VisualElement>(VisualElement.MinimumHeightRequestProperty, NConverters.ToDouble);

    public static NProperty CreateMinimumWidthRequest() => new NProperty(nameof(NProperties.MinimumWidthRequest)).
        Property<VisualElement>(VisualElement.MinimumWidthRequestProperty, NConverters.ToDouble);

    public static NProperty CreateNavigated() => new NProperty(nameof(NProperties.Navigated)).
        Event<WebView>((s, a) => s.Navigated += a.EventHandler);

    public static NProperty CreateNavigating() => new NProperty(nameof(NProperties.Navigating)).
        Event<WebView>((s, a) => s.Navigating += a.EventHandler);

    public static NProperty CreateNavigationPageBackButtonTitle() => new NProperty(nameof(NProperties.NavigationPageBackButtonTitle)).
        Property<BindableObject>(NavigationPage.BackButtonTitleProperty, NConverters.ToString);

    public static NProperty CreateNavigationPageHasBackButton() => new NProperty(nameof(NProperties.NavigationPageHasBackButton)).
        Property<Page>(NavigationPage.HasBackButtonProperty, NConverters.ToBool);

    public static NProperty CreateNavigationPageHasNavigationBar() => new NProperty(nameof(NProperties.NavigationPageHasNavigationBar)).
        Property<BindableObject>(NavigationPage.HasNavigationBarProperty, NConverters.ToBool);

    public static NProperty CreateNavigationPageTitleIcon() => new NProperty(nameof(NProperties.NavigationPageTitleIcon)).
        Property<BindableObject>(NavigationPage.TitleIconProperty);

    public static NProperty CreateOpacity() => new NProperty(nameof(NProperties.Opacity)).
        Property<VisualElement>(VisualElement.OpacityProperty, NConverters.ToDouble);

    public static NProperty CreateOrientation() => new NProperty(nameof(NProperties.Orientation)).
        Property<ScrollView>(ScrollView.OrientationProperty, NConverters.ToEnum<ScrollOrientation>);

    public static NProperty CreateOutlineColor() => new NProperty(nameof(NProperties.OutlineColor)).
        Property<Frame>(Frame.OutlineColorProperty);

    public static NProperty CreatePadding() => new NProperty(nameof(NProperties.Padding)).
        Property<Layout>(Layout.PaddingProperty).
        Property<Page>(Page.PaddingProperty);

    public static NProperty CreatePlaceholder() => new NProperty(nameof(NProperties.Placeholder)).
        Property<Entry>(Entry.PlaceholderProperty, NConverters.ToString).
        Property<SearchBar>(SearchBar.PlaceholderProperty, NConverters.ToString);

    public static NProperty CreatePlaceholderColor() => new NProperty(nameof(NProperties.PlaceholderColor)).
        Property<Entry>(Entry.PlaceholderColorProperty).
        Property<SearchBar>(SearchBar.PlaceholderColorProperty);

    public static NProperty CreatePopped() => new NProperty(nameof(NProperties.Popped)).
        Event<NavigationPage>((s, a) => s.Popped += a.EventHandler);

    public static NProperty CreatePoppedToRoot() => new NProperty(nameof(NProperties.PoppedToRoot)).
        Event<NavigationPage>((s, a) => s.PoppedToRoot += a.EventHandler);

    public static NProperty CreateProgress() => new NProperty(nameof(NProperties.Progress)).
        Property<ProgressBar>(ProgressBar.ProgressProperty, NConverters.ToDouble);

    public static NProperty CreatePushed() => new NProperty(nameof(NProperties.Pushed)).
        Event<NavigationPage>((s, a) => s.Pushed += a.EventHandler);

    public static NProperty CreateRoot() => new NProperty(nameof(NProperties.Root)).
        Property<TableView>((t, v) => NPatch.AssignListT(t.Root, v));

    public static NProperty CreateRotation() => new NProperty(nameof(NProperties.Rotation)).
        Property<VisualElement>(VisualElement.RotationProperty, NConverters.ToDouble);

    public static NProperty CreateRotationX() => new NProperty(nameof(NProperties.RotationX)).
        Property<VisualElement>(VisualElement.RotationXProperty, NConverters.ToDouble);

    public static NProperty CreateRotationY() => new NProperty(nameof(NProperties.RotationY)).
        Property<VisualElement>(VisualElement.RotationYProperty, NConverters.ToDouble);

    public static NProperty CreateRowHeight() => new NProperty(nameof(NProperties.RowHeight)).
        Property<TableView>(TableView.RowHeightProperty, NConverters.ToInt32);

    public static NProperty CreateScale() => new NProperty(nameof(NProperties.Scale)).
        Property<VisualElement>(VisualElement.ScaleProperty, NConverters.ToDouble);

    public static NProperty CreateScrolled() => new NProperty(nameof(NProperties.Scrolled)).
        Event<ScrollView>((s, a) => s.Scrolled += a.EventHandler);

    public static NProperty CreateSearchButtonPressed() => new NProperty(nameof(NProperties.SearchButtonPressed)).
        Event<SearchBar>((s, a) => s.SearchButtonPressed += a.EventHandler);

    public static NProperty CreateSearchCommand() => new NProperty(nameof(NProperties.SearchCommand)).
        Property<SearchBar>(SearchBar.SearchCommandProperty);

    public static NProperty CreateSearchCommandParameter() => new NProperty(nameof(NProperties.SearchCommandParameter)).
        Property<SearchBar>(SearchBar.SearchCommandParameterProperty);

    public static NProperty CreateSelectedIndex() => new NProperty(nameof(NProperties.SelectedIndex)).
        Property<Picker>(Picker.SelectedIndexProperty, NConverters.ToInt32);

    public static NProperty CreateSelectedIndexChanged() => new NProperty(nameof(NProperties.SelectedIndexChanged)).
        Event<Picker>((s, a) => s.SelectedIndexChanged += a.EventHandler);

    public static NProperty CreateSizeChanged() => new NProperty(nameof(NProperties.SizeChanged)).
        Event<VisualElement>((s, a) => s.SizeChanged += a.EventHandler);

    public static NProperty CreateSource() => new NProperty(nameof(NProperties.Source)).
        Property<Image>(Image.SourceProperty).
        Property<WebView>(WebView.SourceProperty);

    public static NProperty CreateStyle() => new NProperty(nameof(NProperties.Style)).
        Property<VisualElement>(VisualElement.StyleProperty);

    public static NProperty CreateText() => new NProperty(nameof(NProperties.Text)).
        Property<Button>(Button.TextProperty, NConverters.ToString).
        Property<Editor>(Editor.TextProperty, NConverters.ToString).
        Property<Entry>(Entry.TextProperty, NConverters.ToString).
        Property<Label>(Label.TextProperty, NConverters.ToString).
        Property<SearchBar>(SearchBar.TextProperty, NConverters.ToString);

    public static NProperty CreateTextChanged() => new NProperty(nameof(NProperties.TextChanged)).
        Event<Editor>((s, a) => s.TextChanged += a.EventHandler).
        Event<Entry>((s, a) => s.TextChanged += a.EventHandler).
        Event<SearchBar>((s, a) => s.TextChanged += a.EventHandler);

    public static NProperty CreateTextColor() => new NProperty(nameof(NProperties.TextColor)).
        Property<Button>(Button.TextColorProperty).
        Property<Editor>(Editor.TextColorProperty).
        Property<Entry>(Entry.TextColorProperty).
        Property<Label>(Label.TextColorProperty).
        Property<SearchBar>(SearchBar.TextColorProperty);

    public static NProperty CreateTime() => new NProperty(nameof(NProperties.Time)).
        Property<TimePicker>(TimePicker.TimeProperty, NConverters.ToTimeSpan);

    public static NProperty CreateTint() => new NProperty(nameof(NProperties.Tint)).
        Property<NavigationPage>(NavigationPage.TintProperty);

    public static NProperty CreateTitle() => new NProperty(nameof(NProperties.Title)).
        Property<Picker>(Picker.TitleProperty, NConverters.ToString).
        Property<Page>(Page.TitleProperty, NConverters.ToString);

    public static NProperty CreateToggled() => new NProperty(nameof(NProperties.Toggled)).
        Event<Switch>((s, a) => s.Toggled += a.EventHandler);

    public static NProperty CreateTranslationX() => new NProperty(nameof(NProperties.TranslationX)).
        Property<VisualElement>(VisualElement.TranslationXProperty, NConverters.ToDouble);

    public static NProperty CreateTranslationY() => new NProperty(nameof(NProperties.TranslationY)).
        Property<VisualElement>(VisualElement.TranslationYProperty, NConverters.ToDouble);

    public static NProperty CreateUnfocused() => new NProperty(nameof(NProperties.Unfocused)).
        Event<VisualElement>((s, a) => s.Unfocused += a.EventHandler);

    public static NProperty CreateValue() => new NProperty(nameof(NProperties.Value)).
        Property<Slider>(Slider.ValueProperty, NConverters.ToDouble).
        Property<Stepper>(Stepper.ValueProperty, NConverters.ToDouble);

    public static NProperty CreateValueChanged() => new NProperty(nameof(NProperties.ValueChanged)).
        Event<Slider>((s, a) => s.ValueChanged += a.EventHandler).
        Event<Stepper>((s, a) => s.ValueChanged += a.EventHandler);

    public static NProperty CreateVerticalOptions() => new NProperty(nameof(NProperties.VerticalOptions)).
        Property<View>(View.VerticalOptionsProperty);

    public static NProperty CreateVerticalTextAlignment() => new NProperty(nameof(NProperties.VerticalTextAlignment)).
        Property<Label>(Label.VerticalTextAlignmentProperty, NConverters.ToEnum<TextAlignment>);

    public static NProperty CreateWidthRequest() => new NProperty(nameof(NProperties.WidthRequest)).
        Property<VisualElement>(VisualElement.WidthRequestProperty, NConverters.ToDouble);

    public static NProperty CreateXAlign() => new NProperty(nameof(NProperties.XAlign)).
        Property<Label>(Label.XAlignProperty, NConverters.ToEnum<TextAlignment>);

    public static NProperty CreateYAlign() => new NProperty(nameof(NProperties.YAlign)).
        Property<Label>(Label.YAlignProperty, NConverters.ToEnum<TextAlignment>);

  }
}
