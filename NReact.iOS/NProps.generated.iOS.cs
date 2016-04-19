using AddressBookUI;
using AVFoundation;
using AVKit;
using ContactsUI;
using CoreAudioKit;
using CoreGraphics;
using EventKitUI;
using GameKit;
using GLKit;
using iAd;
using MapKit;
using MediaPlayer;
using MessageUI;
using Metal;
using MetalKit;
using PassKit;
using PhotosUI;
using QuickLook;
using SceneKit;
using Social;
using SpriteKit;
using StoreKit;
using System;
using UIKit;
using WebKit;

namespace NReact
{

  public partial class NProperties
  {
    public NProperty AccessibilityCustomActions { get { return _accessibilityCustomActions ?? (_accessibilityCustomActions = NPropFactories.CreateAccessibilityCustomActions()); } }
           NProperty _accessibilityCustomActions;

    public NProperty AccessibilityElementsHidden { get { return _accessibilityElementsHidden ?? (_accessibilityElementsHidden = NPropFactories.CreateAccessibilityElementsHidden()); } }
           NProperty _accessibilityElementsHidden;

    public NProperty AccessibilityHint { get { return _accessibilityHint ?? (_accessibilityHint = NPropFactories.CreateAccessibilityHint()); } }
           NProperty _accessibilityHint;

    public NProperty AccessibilityIdentifier { get { return _accessibilityIdentifier ?? (_accessibilityIdentifier = NPropFactories.CreateAccessibilityIdentifier()); } }
           NProperty _accessibilityIdentifier;

    public NProperty AccessibilityLabel { get { return _accessibilityLabel ?? (_accessibilityLabel = NPropFactories.CreateAccessibilityLabel()); } }
           NProperty _accessibilityLabel;

    public NProperty AccessibilityLanguage { get { return _accessibilityLanguage ?? (_accessibilityLanguage = NPropFactories.CreateAccessibilityLanguage()); } }
           NProperty _accessibilityLanguage;

    public NProperty AccessibilityNavigationStyle { get { return _accessibilityNavigationStyle ?? (_accessibilityNavigationStyle = NPropFactories.CreateAccessibilityNavigationStyle()); } }
           NProperty _accessibilityNavigationStyle;

    public NProperty AccessibilityTraits { get { return _accessibilityTraits ?? (_accessibilityTraits = NPropFactories.CreateAccessibilityTraits()); } }
           NProperty _accessibilityTraits;

    public NProperty AccessibilityValue { get { return _accessibilityValue ?? (_accessibilityValue = NPropFactories.CreateAccessibilityValue()); } }
           NProperty _accessibilityValue;

    public NProperty AccessibilityViewIsModal { get { return _accessibilityViewIsModal ?? (_accessibilityViewIsModal = NPropFactories.CreateAccessibilityViewIsModal()); } }
           NProperty _accessibilityViewIsModal;

    public NProperty Accessory { get { return _accessory ?? (_accessory = NPropFactories.CreateAccessory()); } }
           NProperty _accessory;

    public NProperty ActionFinished { get { return _actionFinished ?? (_actionFinished = NPropFactories.CreateActionFinished()); } }
           NProperty _actionFinished;

    public NProperty Actions { get { return _actions ?? (_actions = NPropFactories.CreateActions()); } }
           NProperty _actions;

    public NProperty Active { get { return _active ?? (_active = NPropFactories.CreateActive()); } }
           NProperty _active;

    public NProperty ActivityIndicatorViewStyle { get { return _activityIndicatorViewStyle ?? (_activityIndicatorViewStyle = NPropFactories.CreateActivityIndicatorViewStyle()); } }
           NProperty _activityIndicatorViewStyle;

    public NProperty AdjustsFontSizeToFitWidth { get { return _adjustsFontSizeToFitWidth ?? (_adjustsFontSizeToFitWidth = NPropFactories.CreateAdjustsFontSizeToFitWidth()); } }
           NProperty _adjustsFontSizeToFitWidth;

    public NProperty AdjustsImageWhenDisabled { get { return _adjustsImageWhenDisabled ?? (_adjustsImageWhenDisabled = NPropFactories.CreateAdjustsImageWhenDisabled()); } }
           NProperty _adjustsImageWhenDisabled;

    public NProperty AdjustsImageWhenHighlighted { get { return _adjustsImageWhenHighlighted ?? (_adjustsImageWhenHighlighted = NPropFactories.CreateAdjustsImageWhenHighlighted()); } }
           NProperty _adjustsImageWhenHighlighted;

    public NProperty AdjustsLetterSpacingToFitWidth { get { return _adjustsLetterSpacingToFitWidth ?? (_adjustsLetterSpacingToFitWidth = NPropFactories.CreateAdjustsLetterSpacingToFitWidth()); } }
           NProperty _adjustsLetterSpacingToFitWidth;

    public NProperty AdLoaded { get { return _adLoaded ?? (_adLoaded = NPropFactories.CreateAdLoaded()); } }
           NProperty _adLoaded;

    public NProperty AdvertisingSection { get { return _advertisingSection ?? (_advertisingSection = NPropFactories.CreateAdvertisingSection()); } }
           NProperty _advertisingSection;

    public NProperty AlertViewStyle { get { return _alertViewStyle ?? (_alertViewStyle = NPropFactories.CreateAlertViewStyle()); } }
           NProperty _alertViewStyle;

    public NProperty Alignment { get { return _alignment ?? (_alignment = NPropFactories.CreateAlignment()); } }
           NProperty _alignment;

    public NProperty AllEditingEvents { get { return _allEditingEvents ?? (_allEditingEvents = NPropFactories.CreateAllEditingEvents()); } }
           NProperty _allEditingEvents;

    public NProperty AllEvents { get { return _allEvents ?? (_allEvents = NPropFactories.CreateAllEvents()); } }
           NProperty _allEvents;

    public NProperty AllowsActions { get { return _allowsActions ?? (_allowsActions = NPropFactories.CreateAllowsActions()); } }
           NProperty _allowsActions;

    public NProperty AllowsAddingToAddressBook { get { return _allowsAddingToAddressBook ?? (_allowsAddingToAddressBook = NPropFactories.CreateAllowsAddingToAddressBook()); } }
           NProperty _allowsAddingToAddressBook;

    public NProperty AllowsBackForwardNavigationGestures { get { return _allowsBackForwardNavigationGestures ?? (_allowsBackForwardNavigationGestures = NPropFactories.CreateAllowsBackForwardNavigationGestures()); } }
           NProperty _allowsBackForwardNavigationGestures;

    public NProperty AllowsCalendarPreview { get { return _allowsCalendarPreview ?? (_allowsCalendarPreview = NPropFactories.CreateAllowsCalendarPreview()); } }
           NProperty _allowsCalendarPreview;

    public NProperty AllowsCameraControl { get { return _allowsCameraControl ?? (_allowsCameraControl = NPropFactories.CreateAllowsCameraControl()); } }
           NProperty _allowsCameraControl;

    public NProperty AllowsDefaultTighteningForTruncation { get { return _allowsDefaultTighteningForTruncation ?? (_allowsDefaultTighteningForTruncation = NPropFactories.CreateAllowsDefaultTighteningForTruncation()); } }
           NProperty _allowsDefaultTighteningForTruncation;

    public NProperty AllowsEditing { get { return _allowsEditing ?? (_allowsEditing = NPropFactories.CreateAllowsEditing()); } }
           NProperty _allowsEditing;

    public NProperty AllowsEditingTextAttributes { get { return _allowsEditingTextAttributes ?? (_allowsEditingTextAttributes = NPropFactories.CreateAllowsEditingTextAttributes()); } }
           NProperty _allowsEditingTextAttributes;

    public NProperty AllowsImageEditing { get { return _allowsImageEditing ?? (_allowsImageEditing = NPropFactories.CreateAllowsImageEditing()); } }
           NProperty _allowsImageEditing;

    public NProperty AllowsInlineMediaPlayback { get { return _allowsInlineMediaPlayback ?? (_allowsInlineMediaPlayback = NPropFactories.CreateAllowsInlineMediaPlayback()); } }
           NProperty _allowsInlineMediaPlayback;

    public NProperty AllowsLinkPreview { get { return _allowsLinkPreview ?? (_allowsLinkPreview = NPropFactories.CreateAllowsLinkPreview()); } }
           NProperty _allowsLinkPreview;

    public NProperty AllowsMultipleSelection { get { return _allowsMultipleSelection ?? (_allowsMultipleSelection = NPropFactories.CreateAllowsMultipleSelection()); } }
           NProperty _allowsMultipleSelection;

    public NProperty AllowsMultipleSelectionDuringEditing { get { return _allowsMultipleSelectionDuringEditing ?? (_allowsMultipleSelectionDuringEditing = NPropFactories.CreateAllowsMultipleSelectionDuringEditing()); } }
           NProperty _allowsMultipleSelectionDuringEditing;

    public NProperty AllowsPickingMultipleItems { get { return _allowsPickingMultipleItems ?? (_allowsPickingMultipleItems = NPropFactories.CreateAllowsPickingMultipleItems()); } }
           NProperty _allowsPickingMultipleItems;

    public NProperty AllowsPictureInPictureMediaPlayback { get { return _allowsPictureInPictureMediaPlayback ?? (_allowsPictureInPictureMediaPlayback = NPropFactories.CreateAllowsPictureInPictureMediaPlayback()); } }
           NProperty _allowsPictureInPictureMediaPlayback;

    public NProperty AllowsPictureInPicturePlayback { get { return _allowsPictureInPicturePlayback ?? (_allowsPictureInPicturePlayback = NPropFactories.CreateAllowsPictureInPicturePlayback()); } }
           NProperty _allowsPictureInPicturePlayback;

    public NProperty AllowsSelection { get { return _allowsSelection ?? (_allowsSelection = NPropFactories.CreateAllowsSelection()); } }
           NProperty _allowsSelection;

    public NProperty AllowsSelectionDuringEditing { get { return _allowsSelectionDuringEditing ?? (_allowsSelectionDuringEditing = NPropFactories.CreateAllowsSelectionDuringEditing()); } }
           NProperty _allowsSelectionDuringEditing;

    public NProperty AllowsSelfSizing { get { return _allowsSelfSizing ?? (_allowsSelfSizing = NPropFactories.CreateAllowsSelfSizing()); } }
           NProperty _allowsSelfSizing;

    public NProperty AllowsTransparency { get { return _allowsTransparency ?? (_allowsTransparency = NPropFactories.CreateAllowsTransparency()); } }
           NProperty _allowsTransparency;

    public NProperty AllTouchEvents { get { return _allTouchEvents ?? (_allTouchEvents = NPropFactories.CreateAllTouchEvents()); } }
           NProperty _allTouchEvents;

    public NProperty AlternateName { get { return _alternateName ?? (_alternateName = NPropFactories.CreateAlternateName()); } }
           NProperty _alternateName;

    public NProperty AlwaysBounceHorizontal { get { return _alwaysBounceHorizontal ?? (_alwaysBounceHorizontal = NPropFactories.CreateAlwaysBounceHorizontal()); } }
           NProperty _alwaysBounceHorizontal;

    public NProperty AlwaysBounceVertical { get { return _alwaysBounceVertical ?? (_alwaysBounceVertical = NPropFactories.CreateAlwaysBounceVertical()); } }
           NProperty _alwaysBounceVertical;

    public NProperty AnimatesDrop { get { return _animatesDrop ?? (_animatesDrop = NPropFactories.CreateAnimatesDrop()); } }
           NProperty _animatesDrop;

    public NProperty AnimationImages { get { return _animationImages ?? (_animationImages = NPropFactories.CreateAnimationImages()); } }
           NProperty _animationImages;

    public NProperty AnimationSpeed { get { return _animationSpeed ?? (_animationSpeed = NPropFactories.CreateAnimationSpeed()); } }
           NProperty _animationSpeed;

    public NProperty Annotations { get { return _annotations ?? (_annotations = NPropFactories.CreateAnnotations()); } }
           NProperty _annotations;

    public NProperty Antialiased { get { return _antialiased ?? (_antialiased = NPropFactories.CreateAntialiased()); } }
           NProperty _antialiased;

    public NProperty AntialiasingMode { get { return _antialiasingMode ?? (_antialiasingMode = NPropFactories.CreateAntialiasingMode()); } }
           NProperty _antialiasingMode;

    public NProperty ApplicationSupportsShakeToEdit { get { return _applicationSupportsShakeToEdit ?? (_applicationSupportsShakeToEdit = NPropFactories.CreateApplicationSupportsShakeToEdit()); } }
           NProperty _applicationSupportsShakeToEdit;

    public NProperty ApportionsSegmentWidthsByContent { get { return _apportionsSegmentWidthsByContent ?? (_apportionsSegmentWidthsByContent = NPropFactories.CreateApportionsSegmentWidthsByContent()); } }
           NProperty _apportionsSegmentWidthsByContent;

    public NProperty ArrangedSubviews { get { return _arrangedSubviews ?? (_arrangedSubviews = NPropFactories.CreateArrangedSubviews()); } }
           NProperty _arrangedSubviews;

    public NProperty ArrowDirection { get { return _arrowDirection ?? (_arrowDirection = NPropFactories.CreateArrowDirection()); } }
           NProperty _arrowDirection;

    public NProperty Asynchronous { get { return _asynchronous ?? (_asynchronous = NPropFactories.CreateAsynchronous()); } }
           NProperty _asynchronous;

    public NProperty AutocapitalizationType { get { return _autocapitalizationType ?? (_autocapitalizationType = NPropFactories.CreateAutocapitalizationType()); } }
           NProperty _autocapitalizationType;

    public NProperty AutocorrectionType { get { return _autocorrectionType ?? (_autocorrectionType = NPropFactories.CreateAutocorrectionType()); } }
           NProperty _autocorrectionType;

    public NProperty AutoenablesDefaultLighting { get { return _autoenablesDefaultLighting ?? (_autoenablesDefaultLighting = NPropFactories.CreateAutoenablesDefaultLighting()); } }
           NProperty _autoenablesDefaultLighting;

    public NProperty AutomaticallyAdjustsScrollViewInsets { get { return _automaticallyAdjustsScrollViewInsets ?? (_automaticallyAdjustsScrollViewInsets = NPropFactories.CreateAutomaticallyAdjustsScrollViewInsets()); } }
           NProperty _automaticallyAdjustsScrollViewInsets;

    public NProperty AutoplayLooped { get { return _autoplayLooped ?? (_autoplayLooped = NPropFactories.CreateAutoplayLooped()); } }
           NProperty _autoplayLooped;

    public NProperty AutoRepeat { get { return _autoRepeat ?? (_autoRepeat = NPropFactories.CreateAutoRepeat()); } }
           NProperty _autoRepeat;

    public NProperty AutoResizeDrawable { get { return _autoResizeDrawable ?? (_autoResizeDrawable = NPropFactories.CreateAutoResizeDrawable()); } }
           NProperty _autoResizeDrawable;

    public NProperty AutoresizingMask { get { return _autoresizingMask ?? (_autoresizingMask = NPropFactories.CreateAutoresizingMask()); } }
           NProperty _autoresizingMask;

    public NProperty AutosizesSubviews { get { return _autosizesSubviews ?? (_autosizesSubviews = NPropFactories.CreateAutosizesSubviews()); } }
           NProperty _autosizesSubviews;

    public NProperty Axis { get { return _axis ?? (_axis = NPropFactories.CreateAxis()); } }
           NProperty _axis;

    public NProperty BarStyle { get { return _barStyle ?? (_barStyle = NPropFactories.CreateBarStyle()); } }
           NProperty _barStyle;

    public NProperty BaselineAdjustment { get { return _baselineAdjustment ?? (_baselineAdjustment = NPropFactories.CreateBaselineAdjustment()); } }
           NProperty _baselineAdjustment;

    public NProperty BaselineRelativeArrangement { get { return _baselineRelativeArrangement ?? (_baselineRelativeArrangement = NPropFactories.CreateBaselineRelativeArrangement()); } }
           NProperty _baselineRelativeArrangement;

    public NProperty BlendMode { get { return _blendMode ?? (_blendMode = NPropFactories.CreateBlendMode()); } }
           NProperty _blendMode;

    public NProperty Body { get { return _body ?? (_body = NPropFactories.CreateBody()); } }
           NProperty _body;

    public NProperty BookmarkButtonClicked { get { return _bookmarkButtonClicked ?? (_bookmarkButtonClicked = NPropFactories.CreateBookmarkButtonClicked()); } }
           NProperty _bookmarkButtonClicked;

    public NProperty BorderStyle { get { return _borderStyle ?? (_borderStyle = NPropFactories.CreateBorderStyle()); } }
           NProperty _borderStyle;

    public NProperty Bounces { get { return _bounces ?? (_bounces = NPropFactories.CreateBounces()); } }
           NProperty _bounces;

    public NProperty BouncesZoom { get { return _bouncesZoom ?? (_bouncesZoom = NPropFactories.CreateBouncesZoom()); } }
           NProperty _bouncesZoom;

    public NProperty CalloutAccessoryControlTapped { get { return _calloutAccessoryControlTapped ?? (_calloutAccessoryControlTapped = NPropFactories.CreateCalloutAccessoryControlTapped()); } }
           NProperty _calloutAccessoryControlTapped;

    public NProperty CameraCaptureMode { get { return _cameraCaptureMode ?? (_cameraCaptureMode = NPropFactories.CreateCameraCaptureMode()); } }
           NProperty _cameraCaptureMode;

    public NProperty CameraDevice { get { return _cameraDevice ?? (_cameraDevice = NPropFactories.CreateCameraDevice()); } }
           NProperty _cameraDevice;

    public NProperty CameraFlashMode { get { return _cameraFlashMode ?? (_cameraFlashMode = NPropFactories.CreateCameraFlashMode()); } }
           NProperty _cameraFlashMode;

    public NProperty CanCancelContentTouches { get { return _canCancelContentTouches ?? (_canCancelContentTouches = NPropFactories.CreateCanCancelContentTouches()); } }
           NProperty _canCancelContentTouches;

    public NProperty CancelButtonClicked { get { return _cancelButtonClicked ?? (_cancelButtonClicked = NPropFactories.CreateCancelButtonClicked()); } }
           NProperty _cancelButtonClicked;

    public NProperty Canceled { get { return _canceled ?? (_canceled = NPropFactories.CreateCanceled()); } }
           NProperty _canceled;

    public NProperty Cancelled { get { return _cancelled ?? (_cancelled = NPropFactories.CreateCancelled()); } }
           NProperty _cancelled;

    public NProperty CanShowCallout { get { return _canShowCallout ?? (_canShowCallout = NPropFactories.CreateCanShowCallout()); } }
           NProperty _canShowCallout;

    public NProperty Category { get { return _category ?? (_category = NPropFactories.CreateCategory()); } }
           NProperty _category;

    public NProperty CellLayoutMarginsFollowReadableWidth { get { return _cellLayoutMarginsFollowReadableWidth ?? (_cellLayoutMarginsFollowReadableWidth = NPropFactories.CreateCellLayoutMarginsFollowReadableWidth()); } }
           NProperty _cellLayoutMarginsFollowReadableWidth;

    public NProperty CertificateChain { get { return _certificateChain ?? (_certificateChain = NPropFactories.CreateCertificateChain()); } }
           NProperty _certificateChain;

    public NProperty Changed { get { return _changed ?? (_changed = NPropFactories.CreateChanged()); } }
           NProperty _changed;

    public NProperty ChangedDragState { get { return _changedDragState ?? (_changedDragState = NPropFactories.CreateChangedDragState()); } }
           NProperty _changedDragState;

    public NProperty Child { get { return _child ?? (_child = NPropFactories.CreateChild()); } }
           NProperty _child;

    public NProperty Children { get { return _children ?? (_children = NPropFactories.CreateChildren()); } }
           NProperty _children;

    public NProperty ChildViewControllers { get { return _childViewControllers ?? (_childViewControllers = NPropFactories.CreateChildViewControllers()); } }
           NProperty _childViewControllers;

    public NProperty ClearButtonMode { get { return _clearButtonMode ?? (_clearButtonMode = NPropFactories.CreateClearButtonMode()); } }
           NProperty _clearButtonMode;

    public NProperty ClearsContextBeforeDrawing { get { return _clearsContextBeforeDrawing ?? (_clearsContextBeforeDrawing = NPropFactories.CreateClearsContextBeforeDrawing()); } }
           NProperty _clearsContextBeforeDrawing;

    public NProperty ClearsOnBeginEditing { get { return _clearsOnBeginEditing ?? (_clearsOnBeginEditing = NPropFactories.CreateClearsOnBeginEditing()); } }
           NProperty _clearsOnBeginEditing;

    public NProperty ClearsOnInsertion { get { return _clearsOnInsertion ?? (_clearsOnInsertion = NPropFactories.CreateClearsOnInsertion()); } }
           NProperty _clearsOnInsertion;

    public NProperty ClearsSelectionOnViewWillAppear { get { return _clearsSelectionOnViewWillAppear ?? (_clearsSelectionOnViewWillAppear = NPropFactories.CreateClearsSelectionOnViewWillAppear()); } }
           NProperty _clearsSelectionOnViewWillAppear;

    public NProperty Clicked { get { return _clicked ?? (_clicked = NPropFactories.CreateClicked()); } }
           NProperty _clicked;

    public NProperty ClipsToBounds { get { return _clipsToBounds ?? (_clipsToBounds = NPropFactories.CreateClipsToBounds()); } }
           NProperty _clipsToBounds;

    public NProperty ColorPixelFormat { get { return _colorPixelFormat ?? (_colorPixelFormat = NPropFactories.CreateColorPixelFormat()); } }
           NProperty _colorPixelFormat;

    public NProperty Completed { get { return _completed ?? (_completed = NPropFactories.CreateCompleted()); } }
           NProperty _completed;

    public NProperty Constraints { get { return _constraints ?? (_constraints = NPropFactories.CreateConstraints()); } }
           NProperty _constraints;

    public NProperty ContentMode { get { return _contentMode ?? (_contentMode = NPropFactories.CreateContentMode()); } }
           NProperty _contentMode;

    public NProperty Continuous { get { return _continuous ?? (_continuous = NPropFactories.CreateContinuous()); } }
           NProperty _continuous;

    public NProperty ControlStyle { get { return _controlStyle ?? (_controlStyle = NPropFactories.CreateControlStyle()); } }
           NProperty _controlStyle;

    public NProperty CurrentContentSizeIdentifier { get { return _currentContentSizeIdentifier ?? (_currentContentSizeIdentifier = NPropFactories.CreateCurrentContentSizeIdentifier()); } }
           NProperty _currentContentSizeIdentifier;

    public NProperty CustomizableViewControllers { get { return _customizableViewControllers ?? (_customizableViewControllers = NPropFactories.CreateCustomizableViewControllers()); } }
           NProperty _customizableViewControllers;

    public NProperty CustomUserAgent { get { return _customUserAgent ?? (_customUserAgent = NPropFactories.CreateCustomUserAgent()); } }
           NProperty _customUserAgent;

    public NProperty DataDetectorTypes { get { return _dataDetectorTypes ?? (_dataDetectorTypes = NPropFactories.CreateDataDetectorTypes()); } }
           NProperty _dataDetectorTypes;

    public NProperty DebugOptions { get { return _debugOptions ?? (_debugOptions = NPropFactories.CreateDebugOptions()); } }
           NProperty _debugOptions;

    public NProperty DecelerationEnded { get { return _decelerationEnded ?? (_decelerationEnded = NPropFactories.CreateDecelerationEnded()); } }
           NProperty _decelerationEnded;

    public NProperty DecelerationStarted { get { return _decelerationStarted ?? (_decelerationStarted = NPropFactories.CreateDecelerationStarted()); } }
           NProperty _decelerationStarted;

    public NProperty DefaultInvitationMessage { get { return _defaultInvitationMessage ?? (_defaultInvitationMessage = NPropFactories.CreateDefaultInvitationMessage()); } }
           NProperty _defaultInvitationMessage;

    public NProperty DefersCurrentPageDisplay { get { return _defersCurrentPageDisplay ?? (_defersCurrentPageDisplay = NPropFactories.CreateDefersCurrentPageDisplay()); } }
           NProperty _defersCurrentPageDisplay;

    public NProperty DefinesPresentationContext { get { return _definesPresentationContext ?? (_definesPresentationContext = NPropFactories.CreateDefinesPresentationContext()); } }
           NProperty _definesPresentationContext;

    public NProperty DelaysContentTouches { get { return _delaysContentTouches ?? (_delaysContentTouches = NPropFactories.CreateDelaysContentTouches()); } }
           NProperty _delaysContentTouches;

    public NProperty DepthStencilPixelFormat { get { return _depthStencilPixelFormat ?? (_depthStencilPixelFormat = NPropFactories.CreateDepthStencilPixelFormat()); } }
           NProperty _depthStencilPixelFormat;

    public NProperty DidAddAnnotationViews { get { return _didAddAnnotationViews ?? (_didAddAnnotationViews = NPropFactories.CreateDidAddAnnotationViews()); } }
           NProperty _didAddAnnotationViews;

    public NProperty DidAddOverlayRenderers { get { return _didAddOverlayRenderers ?? (_didAddOverlayRenderers = NPropFactories.CreateDidAddOverlayRenderers()); } }
           NProperty _didAddOverlayRenderers;

    public NProperty DidAddOverlayViews { get { return _didAddOverlayViews ?? (_didAddOverlayViews = NPropFactories.CreateDidAddOverlayViews()); } }
           NProperty _didAddOverlayViews;

    public NProperty DidAuthorizePayment { get { return _didAuthorizePayment ?? (_didAuthorizePayment = NPropFactories.CreateDidAuthorizePayment()); } }
           NProperty _didAuthorizePayment;

    public NProperty DidBeginCustomizingItems { get { return _didBeginCustomizingItems ?? (_didBeginCustomizingItems = NPropFactories.CreateDidBeginCustomizingItems()); } }
           NProperty _didBeginCustomizingItems;

    public NProperty DidCancel { get { return _didCancel ?? (_didCancel = NPropFactories.CreateDidCancel()); } }
           NProperty _didCancel;

    public NProperty DidChangeUserTrackingMode { get { return _didChangeUserTrackingMode ?? (_didChangeUserTrackingMode = NPropFactories.CreateDidChangeUserTrackingMode()); } }
           NProperty _didChangeUserTrackingMode;

    public NProperty DidDeselectAnnotationView { get { return _didDeselectAnnotationView ?? (_didDeselectAnnotationView = NPropFactories.CreateDidDeselectAnnotationView()); } }
           NProperty _didDeselectAnnotationView;

    public NProperty DidDismiss { get { return _didDismiss ?? (_didDismiss = NPropFactories.CreateDidDismiss()); } }
           NProperty _didDismiss;

    public NProperty DidEndCustomizingItems { get { return _didEndCustomizingItems ?? (_didEndCustomizingItems = NPropFactories.CreateDidEndCustomizingItems()); } }
           NProperty _didEndCustomizingItems;

    public NProperty DidFailToLocateUser { get { return _didFailToLocateUser ?? (_didFailToLocateUser = NPropFactories.CreateDidFailToLocateUser()); } }
           NProperty _didFailToLocateUser;

    public NProperty DidFailWithError { get { return _didFailWithError ?? (_didFailWithError = NPropFactories.CreateDidFailWithError()); } }
           NProperty _didFailWithError;

    public NProperty DidFindHostedPlayers { get { return _didFindHostedPlayers ?? (_didFindHostedPlayers = NPropFactories.CreateDidFindHostedPlayers()); } }
           NProperty _didFindHostedPlayers;

    public NProperty DidFindMatch { get { return _didFindMatch ?? (_didFindMatch = NPropFactories.CreateDidFindMatch()); } }
           NProperty _didFindMatch;

    public NProperty DidFindPlayers { get { return _didFindPlayers ?? (_didFindPlayers = NPropFactories.CreateDidFindPlayers()); } }
           NProperty _didFindPlayers;

    public NProperty DidFinish { get { return _didFinish ?? (_didFinish = NPropFactories.CreateDidFinish()); } }
           NProperty _didFinish;

    public NProperty DidFinishAnimating { get { return _didFinishAnimating ?? (_didFinishAnimating = NPropFactories.CreateDidFinishAnimating()); } }
           NProperty _didFinishAnimating;

    public NProperty DidFinishRenderingMap { get { return _didFinishRenderingMap ?? (_didFinishRenderingMap = NPropFactories.CreateDidFinishRenderingMap()); } }
           NProperty _didFinishRenderingMap;

    public NProperty DidPickDocument { get { return _didPickDocument ?? (_didPickDocument = NPropFactories.CreateDidPickDocument()); } }
           NProperty _didPickDocument;

    public NProperty DidPickDocumentPicker { get { return _didPickDocumentPicker ?? (_didPickDocumentPicker = NPropFactories.CreateDidPickDocumentPicker()); } }
           NProperty _didPickDocumentPicker;

    public NProperty DidSelectAnnotationView { get { return _didSelectAnnotationView ?? (_didSelectAnnotationView = NPropFactories.CreateDidSelectAnnotationView()); } }
           NProperty _didSelectAnnotationView;

    public NProperty DidSelectPaymentMethod { get { return _didSelectPaymentMethod ?? (_didSelectPaymentMethod = NPropFactories.CreateDidSelectPaymentMethod()); } }
           NProperty _didSelectPaymentMethod;

    public NProperty DidSelectShippingAddress { get { return _didSelectShippingAddress ?? (_didSelectShippingAddress = NPropFactories.CreateDidSelectShippingAddress()); } }
           NProperty _didSelectShippingAddress;

    public NProperty DidSelectShippingContact { get { return _didSelectShippingContact ?? (_didSelectShippingContact = NPropFactories.CreateDidSelectShippingContact()); } }
           NProperty _didSelectShippingContact;

    public NProperty DidSelectShippingMethod { get { return _didSelectShippingMethod ?? (_didSelectShippingMethod = NPropFactories.CreateDidSelectShippingMethod()); } }
           NProperty _didSelectShippingMethod;

    public NProperty DidStopLocatingUser { get { return _didStopLocatingUser ?? (_didStopLocatingUser = NPropFactories.CreateDidStopLocatingUser()); } }
           NProperty _didStopLocatingUser;

    public NProperty DidUpdateUserLocation { get { return _didUpdateUserLocation ?? (_didUpdateUserLocation = NPropFactories.CreateDidUpdateUserLocation()); } }
           NProperty _didUpdateUserLocation;

    public NProperty DidZoom { get { return _didZoom ?? (_didZoom = NPropFactories.CreateDidZoom()); } }
           NProperty _didZoom;

    public NProperty DimsBackgroundDuringPresentation { get { return _dimsBackgroundDuringPresentation ?? (_dimsBackgroundDuringPresentation = NPropFactories.CreateDimsBackgroundDuringPresentation()); } }
           NProperty _dimsBackgroundDuringPresentation;

    public NProperty DirectionalLockEnabled { get { return _directionalLockEnabled ?? (_directionalLockEnabled = NPropFactories.CreateDirectionalLockEnabled()); } }
           NProperty _directionalLockEnabled;

    public NProperty Dismissed { get { return _dismissed ?? (_dismissed = NPropFactories.CreateDismissed()); } }
           NProperty _dismissed;

    public NProperty DisplayedPropertyKeys { get { return _displayedPropertyKeys ?? (_displayedPropertyKeys = NPropFactories.CreateDisplayedPropertyKeys()); } }
           NProperty _displayedPropertyKeys;

    public NProperty Distribution { get { return _distribution ?? (_distribution = NPropFactories.CreateDistribution()); } }
           NProperty _distribution;

    public NProperty DoubleSided { get { return _doubleSided ?? (_doubleSided = NPropFactories.CreateDoubleSided()); } }
           NProperty _doubleSided;

    public NProperty Draggable { get { return _draggable ?? (_draggable = NPropFactories.CreateDraggable()); } }
           NProperty _draggable;

    public NProperty DraggingEnded { get { return _draggingEnded ?? (_draggingEnded = NPropFactories.CreateDraggingEnded()); } }
           NProperty _draggingEnded;

    public NProperty DraggingStarted { get { return _draggingStarted ?? (_draggingStarted = NPropFactories.CreateDraggingStarted()); } }
           NProperty _draggingStarted;

    public NProperty DragState { get { return _dragState ?? (_dragState = NPropFactories.CreateDragState()); } }
           NProperty _dragState;

    public NProperty DrawableColorFormat { get { return _drawableColorFormat ?? (_drawableColorFormat = NPropFactories.CreateDrawableColorFormat()); } }
           NProperty _drawableColorFormat;

    public NProperty DrawableDepthFormat { get { return _drawableDepthFormat ?? (_drawableDepthFormat = NPropFactories.CreateDrawableDepthFormat()); } }
           NProperty _drawableDepthFormat;

    public NProperty DrawableMultisample { get { return _drawableMultisample ?? (_drawableMultisample = NPropFactories.CreateDrawableMultisample()); } }
           NProperty _drawableMultisample;

    public NProperty DrawableStencilFormat { get { return _drawableStencilFormat ?? (_drawableStencilFormat = NPropFactories.CreateDrawableStencilFormat()); } }
           NProperty _drawableStencilFormat;

    public NProperty DrawInRect { get { return _drawInRect ?? (_drawInRect = NPropFactories.CreateDrawInRect()); } }
           NProperty _drawInRect;

    public NProperty EdgesForExtendedLayout { get { return _edgesForExtendedLayout ?? (_edgesForExtendedLayout = NPropFactories.CreateEdgesForExtendedLayout()); } }
           NProperty _edgesForExtendedLayout;

    public NProperty Editable { get { return _editable ?? (_editable = NPropFactories.CreateEditable()); } }
           NProperty _editable;

    public NProperty Editing { get { return _editing ?? (_editing = NPropFactories.CreateEditing()); } }
           NProperty _editing;

    public NProperty EditingAccessory { get { return _editingAccessory ?? (_editingAccessory = NPropFactories.CreateEditingAccessory()); } }
           NProperty _editingAccessory;

    public NProperty EditingChanged { get { return _editingChanged ?? (_editingChanged = NPropFactories.CreateEditingChanged()); } }
           NProperty _editingChanged;

    public NProperty EditingDidBegin { get { return _editingDidBegin ?? (_editingDidBegin = NPropFactories.CreateEditingDidBegin()); } }
           NProperty _editingDidBegin;

    public NProperty EditingDidEnd { get { return _editingDidEnd ?? (_editingDidEnd = NPropFactories.CreateEditingDidEnd()); } }
           NProperty _editingDidEnd;

    public NProperty EditingDidEndOnExit { get { return _editingDidEndOnExit ?? (_editingDidEndOnExit = NPropFactories.CreateEditingDidEndOnExit()); } }
           NProperty _editingDidEndOnExit;

    public NProperty Enabled { get { return _enabled ?? (_enabled = NPropFactories.CreateEnabled()); } }
           NProperty _enabled;

    public NProperty EnableSetNeedsDisplay { get { return _enableSetNeedsDisplay ?? (_enableSetNeedsDisplay = NPropFactories.CreateEnableSetNeedsDisplay()); } }
           NProperty _enableSetNeedsDisplay;

    public NProperty EnablesReturnKeyAutomatically { get { return _enablesReturnKeyAutomatically ?? (_enablesReturnKeyAutomatically = NPropFactories.CreateEnablesReturnKeyAutomatically()); } }
           NProperty _enablesReturnKeyAutomatically;

    public NProperty Ended { get { return _ended ?? (_ended = NPropFactories.CreateEnded()); } }
           NProperty _ended;

    public NProperty ExcludedActivityTypes { get { return _excludedActivityTypes ?? (_excludedActivityTypes = NPropFactories.CreateExcludedActivityTypes()); } }
           NProperty _excludedActivityTypes;

    public NProperty Exclusive { get { return _exclusive ?? (_exclusive = NPropFactories.CreateExclusive()); } }
           NProperty _exclusive;

    public NProperty ExclusiveTouch { get { return _exclusiveTouch ?? (_exclusiveTouch = NPropFactories.CreateExclusiveTouch()); } }
           NProperty _exclusiveTouch;

    public NProperty ExtendedLayoutIncludesOpaqueBars { get { return _extendedLayoutIncludesOpaqueBars ?? (_extendedLayoutIncludesOpaqueBars = NPropFactories.CreateExtendedLayoutIncludesOpaqueBars()); } }
           NProperty _extendedLayoutIncludesOpaqueBars;

    public NProperty Failed { get { return _failed ?? (_failed = NPropFactories.CreateFailed()); } }
           NProperty _failed;

    public NProperty FailedToReceiveAd { get { return _failedToReceiveAd ?? (_failedToReceiveAd = NPropFactories.CreateFailedToReceiveAd()); } }
           NProperty _failedToReceiveAd;

    public NProperty Falloff { get { return _falloff ?? (_falloff = NPropFactories.CreateFalloff()); } }
           NProperty _falloff;

    public NProperty Finished { get { return _finished ?? (_finished = NPropFactories.CreateFinished()); } }
           NProperty _finished;

    public NProperty FinishedCustomizingViewControllers { get { return _finishedCustomizingViewControllers ?? (_finishedCustomizingViewControllers = NPropFactories.CreateFinishedCustomizingViewControllers()); } }
           NProperty _finishedCustomizingViewControllers;

    public NProperty FinishedPickingImage { get { return _finishedPickingImage ?? (_finishedPickingImage = NPropFactories.CreateFinishedPickingImage()); } }
           NProperty _finishedPickingImage;

    public NProperty FinishedPickingMedia { get { return _finishedPickingMedia ?? (_finishedPickingMedia = NPropFactories.CreateFinishedPickingMedia()); } }
           NProperty _finishedPickingMedia;

    public NProperty FocusStyle { get { return _focusStyle ?? (_focusStyle = NPropFactories.CreateFocusStyle()); } }
           NProperty _focusStyle;

    public NProperty FontName { get { return _fontName ?? (_fontName = NPropFactories.CreateFontName()); } }
           NProperty _fontName;

    public NProperty FramebufferOnly { get { return _framebufferOnly ?? (_framebufferOnly = NPropFactories.CreateFramebufferOnly()); } }
           NProperty _framebufferOnly;

    public NProperty GestureRecognizers { get { return _gestureRecognizers ?? (_gestureRecognizers = NPropFactories.CreateGestureRecognizers()); } }
           NProperty _gestureRecognizers;

    public NProperty Hidden { get { return _hidden ?? (_hidden = NPropFactories.CreateHidden()); } }
           NProperty _hidden;

    public NProperty HidesBarsOnSwipe { get { return _hidesBarsOnSwipe ?? (_hidesBarsOnSwipe = NPropFactories.CreateHidesBarsOnSwipe()); } }
           NProperty _hidesBarsOnSwipe;

    public NProperty HidesBarsOnTap { get { return _hidesBarsOnTap ?? (_hidesBarsOnTap = NPropFactories.CreateHidesBarsOnTap()); } }
           NProperty _hidesBarsOnTap;

    public NProperty HidesBarsWhenKeyboardAppears { get { return _hidesBarsWhenKeyboardAppears ?? (_hidesBarsWhenKeyboardAppears = NPropFactories.CreateHidesBarsWhenKeyboardAppears()); } }
           NProperty _hidesBarsWhenKeyboardAppears;

    public NProperty HidesBarsWhenVerticallyCompact { get { return _hidesBarsWhenVerticallyCompact ?? (_hidesBarsWhenVerticallyCompact = NPropFactories.CreateHidesBarsWhenVerticallyCompact()); } }
           NProperty _hidesBarsWhenVerticallyCompact;

    public NProperty HidesBottomBarWhenPushed { get { return _hidesBottomBarWhenPushed ?? (_hidesBottomBarWhenPushed = NPropFactories.CreateHidesBottomBarWhenPushed()); } }
           NProperty _hidesBottomBarWhenPushed;

    public NProperty HidesForSinglePage { get { return _hidesForSinglePage ?? (_hidesForSinglePage = NPropFactories.CreateHidesForSinglePage()); } }
           NProperty _hidesForSinglePage;

    public NProperty HidesNavigationBarDuringPresentation { get { return _hidesNavigationBarDuringPresentation ?? (_hidesNavigationBarDuringPresentation = NPropFactories.CreateHidesNavigationBarDuringPresentation()); } }
           NProperty _hidesNavigationBarDuringPresentation;

    public NProperty HidesWhenStopped { get { return _hidesWhenStopped ?? (_hidesWhenStopped = NPropFactories.CreateHidesWhenStopped()); } }
           NProperty _hidesWhenStopped;

    public NProperty Highlighted { get { return _highlighted ?? (_highlighted = NPropFactories.CreateHighlighted()); } }
           NProperty _highlighted;

    public NProperty HighlightedAnimationImages { get { return _highlightedAnimationImages ?? (_highlightedAnimationImages = NPropFactories.CreateHighlightedAnimationImages()); } }
           NProperty _highlightedAnimationImages;

    public NProperty HorizontalAlignment { get { return _horizontalAlignment ?? (_horizontalAlignment = NPropFactories.CreateHorizontalAlignment()); } }
           NProperty _horizontalAlignment;

    public NProperty HorizontalAlignmentMode { get { return _horizontalAlignmentMode ?? (_horizontalAlignmentMode = NPropFactories.CreateHorizontalAlignmentMode()); } }
           NProperty _horizontalAlignmentMode;

    public NProperty Hosted { get { return _hosted ?? (_hosted = NPropFactories.CreateHosted()); } }
           NProperty _hosted;

    public NProperty HostedPlayerDidAccept { get { return _hostedPlayerDidAccept ?? (_hostedPlayerDidAccept = NPropFactories.CreateHostedPlayerDidAccept()); } }
           NProperty _hostedPlayerDidAccept;

    public NProperty IdleTimerDisabled { get { return _idleTimerDisabled ?? (_idleTimerDisabled = NPropFactories.CreateIdleTimerDisabled()); } }
           NProperty _idleTimerDisabled;

    public NProperty IgnoresSiblingOrder { get { return _ignoresSiblingOrder ?? (_ignoresSiblingOrder = NPropFactories.CreateIgnoresSiblingOrder()); } }
           NProperty _ignoresSiblingOrder;

    public NProperty IndexPathsForSelectedRows { get { return _indexPathsForSelectedRows ?? (_indexPathsForSelectedRows = NPropFactories.CreateIndexPathsForSelectedRows()); } }
           NProperty _indexPathsForSelectedRows;

    public NProperty IndexPathsForVisibleItems { get { return _indexPathsForVisibleItems ?? (_indexPathsForVisibleItems = NPropFactories.CreateIndexPathsForVisibleItems()); } }
           NProperty _indexPathsForVisibleItems;

    public NProperty IndexPathsForVisibleRows { get { return _indexPathsForVisibleRows ?? (_indexPathsForVisibleRows = NPropFactories.CreateIndexPathsForVisibleRows()); } }
           NProperty _indexPathsForVisibleRows;

    public NProperty IndicatorStyle { get { return _indicatorStyle ?? (_indicatorStyle = NPropFactories.CreateIndicatorStyle()); } }
           NProperty _indicatorStyle;

    public NProperty InstallsStandardGestureForInteractiveMovement { get { return _installsStandardGestureForInteractiveMovement ?? (_installsStandardGestureForInteractiveMovement = NPropFactories.CreateInstallsStandardGestureForInteractiveMovement()); } }
           NProperty _installsStandardGestureForInteractiveMovement;

    public NProperty IsAccessibilityElement { get { return _isAccessibilityElement ?? (_isAccessibilityElement = NPropFactories.CreateIsAccessibilityElement()); } }
           NProperty _isAccessibilityElement;

    public NProperty ItemPositioning { get { return _itemPositioning ?? (_itemPositioning = NPropFactories.CreateItemPositioning()); } }
           NProperty _itemPositioning;

    public NProperty Items { get { return _items ?? (_items = NPropFactories.CreateItems()); } }
           NProperty _items;

    public NProperty ItemSelected { get { return _itemSelected ?? (_itemSelected = NPropFactories.CreateItemSelected()); } }
           NProperty _itemSelected;

    public NProperty ItemsPicked { get { return _itemsPicked ?? (_itemsPicked = NPropFactories.CreateItemsPicked()); } }
           NProperty _itemsPicked;

    public NProperty JitteringEnabled { get { return _jitteringEnabled ?? (_jitteringEnabled = NPropFactories.CreateJitteringEnabled()); } }
           NProperty _jitteringEnabled;

    public NProperty KeyboardAppearance { get { return _keyboardAppearance ?? (_keyboardAppearance = NPropFactories.CreateKeyboardAppearance()); } }
           NProperty _keyboardAppearance;

    public NProperty KeyboardDismissMode { get { return _keyboardDismissMode ?? (_keyboardDismissMode = NPropFactories.CreateKeyboardDismissMode()); } }
           NProperty _keyboardDismissMode;

    public NProperty KeyboardDisplayRequiresUserAction { get { return _keyboardDisplayRequiresUserAction ?? (_keyboardDisplayRequiresUserAction = NPropFactories.CreateKeyboardDisplayRequiresUserAction()); } }
           NProperty _keyboardDisplayRequiresUserAction;

    public NProperty KeyboardType { get { return _keyboardType ?? (_keyboardType = NPropFactories.CreateKeyboardType()); } }
           NProperty _keyboardType;

    public NProperty KeyCommands { get { return _keyCommands ?? (_keyCommands = NPropFactories.CreateKeyCommands()); } }
           NProperty _keyCommands;

    public NProperty LayoutGuides { get { return _layoutGuides ?? (_layoutGuides = NPropFactories.CreateLayoutGuides()); } }
           NProperty _layoutGuides;

    public NProperty LayoutMarginsRelativeArrangement { get { return _layoutMarginsRelativeArrangement ?? (_layoutMarginsRelativeArrangement = NPropFactories.CreateLayoutMarginsRelativeArrangement()); } }
           NProperty _layoutMarginsRelativeArrangement;

    public NProperty LeaderboardCategory { get { return _leaderboardCategory ?? (_leaderboardCategory = NPropFactories.CreateLeaderboardCategory()); } }
           NProperty _leaderboardCategory;

    public NProperty LeaderboardIdentifier { get { return _leaderboardIdentifier ?? (_leaderboardIdentifier = NPropFactories.CreateLeaderboardIdentifier()); } }
           NProperty _leaderboardIdentifier;

    public NProperty LeaderboardTimeScope { get { return _leaderboardTimeScope ?? (_leaderboardTimeScope = NPropFactories.CreateLeaderboardTimeScope()); } }
           NProperty _leaderboardTimeScope;

    public NProperty LeftViewMode { get { return _leftViewMode ?? (_leftViewMode = NPropFactories.CreateLeftViewMode()); } }
           NProperty _leftViewMode;

    public NProperty LineBreakMode { get { return _lineBreakMode ?? (_lineBreakMode = NPropFactories.CreateLineBreakMode()); } }
           NProperty _lineBreakMode;

    public NProperty Linecap { get { return _linecap ?? (_linecap = NPropFactories.CreateLinecap()); } }
           NProperty _linecap;

    public NProperty LineCap { get { return _lineCap ?? (_lineCap = NPropFactories.CreateLineCap()); } }
           NProperty _lineCap;

    public NProperty LineDashPattern { get { return _lineDashPattern ?? (_lineDashPattern = NPropFactories.CreateLineDashPattern()); } }
           NProperty _lineDashPattern;

    public NProperty LineJoin { get { return _lineJoin ?? (_lineJoin = NPropFactories.CreateLineJoin()); } }
           NProperty _lineJoin;

    public NProperty ListButtonClicked { get { return _listButtonClicked ?? (_listButtonClicked = NPropFactories.CreateListButtonClicked()); } }
           NProperty _listButtonClicked;

    public NProperty LoadError { get { return _loadError ?? (_loadError = NPropFactories.CreateLoadError()); } }
           NProperty _loadError;

    public NProperty LoadFinished { get { return _loadFinished ?? (_loadFinished = NPropFactories.CreateLoadFinished()); } }
           NProperty _loadFinished;

    public NProperty LoadingMapFailed { get { return _loadingMapFailed ?? (_loadingMapFailed = NPropFactories.CreateLoadingMapFailed()); } }
           NProperty _loadingMapFailed;

    public NProperty LoadStarted { get { return _loadStarted ?? (_loadStarted = NPropFactories.CreateLoadStarted()); } }
           NProperty _loadStarted;

    public NProperty Loops { get { return _loops ?? (_loops = NPropFactories.CreateLoops()); } }
           NProperty _loops;

    public NProperty MapLoaded { get { return _mapLoaded ?? (_mapLoaded = NPropFactories.CreateMapLoaded()); } }
           NProperty _mapLoaded;

    public NProperty MapType { get { return _mapType ?? (_mapType = NPropFactories.CreateMapType()); } }
           NProperty _mapType;

    public NProperty MaxValue { get { return _maxValue ?? (_maxValue = NPropFactories.CreateMaxValue()); } }
           NProperty _maxValue;

    public NProperty MediaPlaybackAllowsAirPlay { get { return _mediaPlaybackAllowsAirPlay ?? (_mediaPlaybackAllowsAirPlay = NPropFactories.CreateMediaPlaybackAllowsAirPlay()); } }
           NProperty _mediaPlaybackAllowsAirPlay;

    public NProperty MediaPlaybackRequiresUserAction { get { return _mediaPlaybackRequiresUserAction ?? (_mediaPlaybackRequiresUserAction = NPropFactories.CreateMediaPlaybackRequiresUserAction()); } }
           NProperty _mediaPlaybackRequiresUserAction;

    public NProperty MediaTypes { get { return _mediaTypes ?? (_mediaTypes = NPropFactories.CreateMediaTypes()); } }
           NProperty _mediaTypes;

    public NProperty Message { get { return _message ?? (_message = NPropFactories.CreateMessage()); } }
           NProperty _message;

    public NProperty MinimumRadius { get { return _minimumRadius ?? (_minimumRadius = NPropFactories.CreateMinimumRadius()); } }
           NProperty _minimumRadius;

    public NProperty MinValue { get { return _minValue ?? (_minValue = NPropFactories.CreateMinValue()); } }
           NProperty _minValue;

    public NProperty ModalInPopover { get { return _modalInPopover ?? (_modalInPopover = NPropFactories.CreateModalInPopover()); } }
           NProperty _modalInPopover;

    public NProperty ModalPresentationCapturesStatusBarAppearance { get { return _modalPresentationCapturesStatusBarAppearance ?? (_modalPresentationCapturesStatusBarAppearance = NPropFactories.CreateModalPresentationCapturesStatusBarAppearance()); } }
           NProperty _modalPresentationCapturesStatusBarAppearance;

    public NProperty ModalPresentationStyle { get { return _modalPresentationStyle ?? (_modalPresentationStyle = NPropFactories.CreateModalPresentationStyle()); } }
           NProperty _modalPresentationStyle;

    public NProperty ModalTransitionStyle { get { return _modalTransitionStyle ?? (_modalTransitionStyle = NPropFactories.CreateModalTransitionStyle()); } }
           NProperty _modalTransitionStyle;

    public NProperty Mode { get { return _mode ?? (_mode = NPropFactories.CreateMode()); } }
           NProperty _mode;

    public NProperty Momentary { get { return _momentary ?? (_momentary = NPropFactories.CreateMomentary()); } }
           NProperty _momentary;

    public NProperty MotionEffects { get { return _motionEffects ?? (_motionEffects = NPropFactories.CreateMotionEffects()); } }
           NProperty _motionEffects;

    public NProperty MultipleTouchEnabled { get { return _multipleTouchEnabled ?? (_multipleTouchEnabled = NPropFactories.CreateMultipleTouchEnabled()); } }
           NProperty _multipleTouchEnabled;

    public NProperty Muted { get { return _muted ?? (_muted = NPropFactories.CreateMuted()); } }
           NProperty _muted;

    public NProperty Name { get { return _name ?? (_name = NPropFactories.CreateName()); } }
           NProperty _name;

    public NProperty NavigationBarHidden { get { return _navigationBarHidden ?? (_navigationBarHidden = NPropFactories.CreateNavigationBarHidden()); } }
           NProperty _navigationBarHidden;

    public NProperty NetworkActivityIndicatorVisible { get { return _networkActivityIndicatorVisible ?? (_networkActivityIndicatorVisible = NPropFactories.CreateNetworkActivityIndicatorVisible()); } }
           NProperty _networkActivityIndicatorVisible;

    public NProperty NewPersonComplete { get { return _newPersonComplete ?? (_newPersonComplete = NPropFactories.CreateNewPersonComplete()); } }
           NProperty _newPersonComplete;

    public NProperty ObscuresBackgroundDuringPresentation { get { return _obscuresBackgroundDuringPresentation ?? (_obscuresBackgroundDuringPresentation = NPropFactories.CreateObscuresBackgroundDuringPresentation()); } }
           NProperty _obscuresBackgroundDuringPresentation;

    public NProperty On { get { return _on ?? (_on = NPropFactories.CreateOn()); } }
           NProperty _on;

    public NProperty OnCustomizingViewControllers { get { return _onCustomizingViewControllers ?? (_onCustomizingViewControllers = NPropFactories.CreateOnCustomizingViewControllers()); } }
           NProperty _onCustomizingViewControllers;

    public NProperty OnEditingStarted { get { return _onEditingStarted ?? (_onEditingStarted = NPropFactories.CreateOnEditingStarted()); } }
           NProperty _onEditingStarted;

    public NProperty OnEditingStopped { get { return _onEditingStopped ?? (_onEditingStopped = NPropFactories.CreateOnEditingStopped()); } }
           NProperty _onEditingStopped;

    public NProperty OnEndCustomizingViewControllers { get { return _onEndCustomizingViewControllers ?? (_onEndCustomizingViewControllers = NPropFactories.CreateOnEndCustomizingViewControllers()); } }
           NProperty _onEndCustomizingViewControllers;

    public NProperty Opaque { get { return _opaque ?? (_opaque = NPropFactories.CreateOpaque()); } }
           NProperty _opaque;

    public NProperty Overlays { get { return _overlays ?? (_overlays = NPropFactories.CreateOverlays()); } }
           NProperty _overlays;

    public NProperty PaginationBreakingMode { get { return _paginationBreakingMode ?? (_paginationBreakingMode = NPropFactories.CreatePaginationBreakingMode()); } }
           NProperty _paginationBreakingMode;

    public NProperty PaginationMode { get { return _paginationMode ?? (_paginationMode = NPropFactories.CreatePaginationMode()); } }
           NProperty _paginationMode;

    public NProperty PagingEnabled { get { return _pagingEnabled ?? (_pagingEnabled = NPropFactories.CreatePagingEnabled()); } }
           NProperty _pagingEnabled;

    public NProperty ParticleBlendMode { get { return _particleBlendMode ?? (_particleBlendMode = NPropFactories.CreateParticleBlendMode()); } }
           NProperty _particleBlendMode;

    public NProperty ParticleRenderOrder { get { return _particleRenderOrder ?? (_particleRenderOrder = NPropFactories.CreateParticleRenderOrder()); } }
           NProperty _particleRenderOrder;

    public NProperty Paused { get { return _paused ?? (_paused = NPropFactories.CreatePaused()); } }
           NProperty _paused;

    public NProperty PauseOnWillResignActive { get { return _pauseOnWillResignActive ?? (_pauseOnWillResignActive = NPropFactories.CreatePauseOnWillResignActive()); } }
           NProperty _pauseOnWillResignActive;

    public NProperty PaymentAuthorizationViewControllerDidFinish { get { return _paymentAuthorizationViewControllerDidFinish ?? (_paymentAuthorizationViewControllerDidFinish = NPropFactories.CreatePaymentAuthorizationViewControllerDidFinish()); } }
           NProperty _paymentAuthorizationViewControllerDidFinish;

    public NProperty PerformAction { get { return _performAction ?? (_performAction = NPropFactories.CreatePerformAction()); } }
           NProperty _performAction;

    public NProperty PerformAction2 { get { return _performAction2 ?? (_performAction2 = NPropFactories.CreatePerformAction2()); } }
           NProperty _performAction2;

    public NProperty PerformDefaultAction { get { return _performDefaultAction ?? (_performDefaultAction = NPropFactories.CreatePerformDefaultAction()); } }
           NProperty _performDefaultAction;

    public NProperty PersonCreated { get { return _personCreated ?? (_personCreated = NPropFactories.CreatePersonCreated()); } }
           NProperty _personCreated;

    public NProperty PinColor { get { return _pinColor ?? (_pinColor = NPropFactories.CreatePinColor()); } }
           NProperty _pinColor;

    public NProperty PitchEnabled { get { return _pitchEnabled ?? (_pitchEnabled = NPropFactories.CreatePitchEnabled()); } }
           NProperty _pitchEnabled;

    public NProperty Placeholder { get { return _placeholder ?? (_placeholder = NPropFactories.CreatePlaceholder()); } }
           NProperty _placeholder;

    public NProperty Playing { get { return _playing ?? (_playing = NPropFactories.CreatePlaying()); } }
           NProperty _playing;

    public NProperty Positional { get { return _positional ?? (_positional = NPropFactories.CreatePositional()); } }
           NProperty _positional;

    public NProperty PreferredDisplayMode { get { return _preferredDisplayMode ?? (_preferredDisplayMode = NPropFactories.CreatePreferredDisplayMode()); } }
           NProperty _preferredDisplayMode;

    public NProperty Presented { get { return _presented ?? (_presented = NPropFactories.CreatePresented()); } }
           NProperty _presented;

    public NProperty PresentsWithGesture { get { return _presentsWithGesture ?? (_presentsWithGesture = NPropFactories.CreatePresentsWithGesture()); } }
           NProperty _presentsWithGesture;

    public NProperty PresentsWithTransaction { get { return _presentsWithTransaction ?? (_presentsWithTransaction = NPropFactories.CreatePresentsWithTransaction()); } }
           NProperty _presentsWithTransaction;

    public NProperty PreservesSuperviewLayoutMargins { get { return _preservesSuperviewLayoutMargins ?? (_preservesSuperviewLayoutMargins = NPropFactories.CreatePreservesSuperviewLayoutMargins()); } }
           NProperty _preservesSuperviewLayoutMargins;

    public NProperty PreviewActionItems { get { return _previewActionItems ?? (_previewActionItems = NPropFactories.CreatePreviewActionItems()); } }
           NProperty _previewActionItems;

    public NProperty PrimaryLanguage { get { return _primaryLanguage ?? (_primaryLanguage = NPropFactories.CreatePrimaryLanguage()); } }
           NProperty _primaryLanguage;

    public NProperty Progress { get { return _progress ?? (_progress = NPropFactories.CreateProgress()); } }
           NProperty _progress;

    public NProperty Prompt { get { return _prompt ?? (_prompt = NPropFactories.CreatePrompt()); } }
           NProperty _prompt;

    public NProperty ProvidesPresentationContextTransitionStyle { get { return _providesPresentationContextTransitionStyle ?? (_providesPresentationContextTransitionStyle = NPropFactories.CreateProvidesPresentationContextTransitionStyle()); } }
           NProperty _providesPresentationContextTransitionStyle;

    public NProperty ReceivedAcceptFromHostedPlayer { get { return _receivedAcceptFromHostedPlayer ?? (_receivedAcceptFromHostedPlayer = NPropFactories.CreateReceivedAcceptFromHostedPlayer()); } }
           NProperty _receivedAcceptFromHostedPlayer;

    public NProperty Recipients { get { return _recipients ?? (_recipients = NPropFactories.CreateRecipients()); } }
           NProperty _recipients;

    public NProperty RegionChanged { get { return _regionChanged ?? (_regionChanged = NPropFactories.CreateRegionChanged()); } }
           NProperty _regionChanged;

    public NProperty RegionWillChange { get { return _regionWillChange ?? (_regionWillChange = NPropFactories.CreateRegionWillChange()); } }
           NProperty _regionWillChange;

    public NProperty RemembersLastFocusedIndexPath { get { return _remembersLastFocusedIndexPath ?? (_remembersLastFocusedIndexPath = NPropFactories.CreateRemembersLastFocusedIndexPath()); } }
           NProperty _remembersLastFocusedIndexPath;

    public NProperty RestorationIdentifier { get { return _restorationIdentifier ?? (_restorationIdentifier = NPropFactories.CreateRestorationIdentifier()); } }
           NProperty _restorationIdentifier;

    public NProperty ResumeOnDidBecomeActive { get { return _resumeOnDidBecomeActive ?? (_resumeOnDidBecomeActive = NPropFactories.CreateResumeOnDidBecomeActive()); } }
           NProperty _resumeOnDidBecomeActive;

    public NProperty ReturnKeyType { get { return _returnKeyType ?? (_returnKeyType = NPropFactories.CreateReturnKeyType()); } }
           NProperty _returnKeyType;

    public NProperty ReverseTitleShadowWhenHighlighted { get { return _reverseTitleShadowWhenHighlighted ?? (_reverseTitleShadowWhenHighlighted = NPropFactories.CreateReverseTitleShadowWhenHighlighted()); } }
           NProperty _reverseTitleShadowWhenHighlighted;

    public NProperty RightViewMode { get { return _rightViewMode ?? (_rightViewMode = NPropFactories.CreateRightViewMode()); } }
           NProperty _rightViewMode;

    public NProperty RotateEnabled { get { return _rotateEnabled ?? (_rotateEnabled = NPropFactories.CreateRotateEnabled()); } }
           NProperty _rotateEnabled;

    public NProperty Saved { get { return _saved ?? (_saved = NPropFactories.CreateSaved()); } }
           NProperty _saved;

    public NProperty ScaleMode { get { return _scaleMode ?? (_scaleMode = NPropFactories.CreateScaleMode()); } }
           NProperty _scaleMode;

    public NProperty ScalesPageToFit { get { return _scalesPageToFit ?? (_scalesPageToFit = NPropFactories.CreateScalesPageToFit()); } }
           NProperty _scalesPageToFit;

    public NProperty ScheduledLocalNotifications { get { return _scheduledLocalNotifications ?? (_scheduledLocalNotifications = NPropFactories.CreateScheduledLocalNotifications()); } }
           NProperty _scheduledLocalNotifications;

    public NProperty ScopeButtonTitles { get { return _scopeButtonTitles ?? (_scopeButtonTitles = NPropFactories.CreateScopeButtonTitles()); } }
           NProperty _scopeButtonTitles;

    public NProperty ScrollAnimationEnded { get { return _scrollAnimationEnded ?? (_scrollAnimationEnded = NPropFactories.CreateScrollAnimationEnded()); } }
           NProperty _scrollAnimationEnded;

    public NProperty Scrolled { get { return _scrolled ?? (_scrolled = NPropFactories.CreateScrolled()); } }
           NProperty _scrolled;

    public NProperty ScrolledToTop { get { return _scrolledToTop ?? (_scrolledToTop = NPropFactories.CreateScrolledToTop()); } }
           NProperty _scrolledToTop;

    public NProperty ScrollEnabled { get { return _scrollEnabled ?? (_scrollEnabled = NPropFactories.CreateScrollEnabled()); } }
           NProperty _scrollEnabled;

    public NProperty ScrollsToTop { get { return _scrollsToTop ?? (_scrollsToTop = NPropFactories.CreateScrollsToTop()); } }
           NProperty _scrollsToTop;

    public NProperty SearchBarStyle { get { return _searchBarStyle ?? (_searchBarStyle = NPropFactories.CreateSearchBarStyle()); } }
           NProperty _searchBarStyle;

    public NProperty SearchButtonClicked { get { return _searchButtonClicked ?? (_searchButtonClicked = NPropFactories.CreateSearchButtonClicked()); } }
           NProperty _searchButtonClicked;

    public NProperty SearchResultsButtonSelected { get { return _searchResultsButtonSelected ?? (_searchResultsButtonSelected = NPropFactories.CreateSearchResultsButtonSelected()); } }
           NProperty _searchResultsButtonSelected;

    public NProperty SecureTextEntry { get { return _secureTextEntry ?? (_secureTextEntry = NPropFactories.CreateSecureTextEntry()); } }
           NProperty _secureTextEntry;

    public NProperty Selectable { get { return _selectable ?? (_selectable = NPropFactories.CreateSelectable()); } }
           NProperty _selectable;

    public NProperty Selected { get { return _selected ?? (_selected = NPropFactories.CreateSelected()); } }
           NProperty _selected;

    public NProperty SelectedAnnotations { get { return _selectedAnnotations ?? (_selectedAnnotations = NPropFactories.CreateSelectedAnnotations()); } }
           NProperty _selectedAnnotations;

    public NProperty SelectedScopeButtonIndexChanged { get { return _selectedScopeButtonIndexChanged ?? (_selectedScopeButtonIndexChanged = NPropFactories.CreateSelectedScopeButtonIndexChanged()); } }
           NProperty _selectedScopeButtonIndexChanged;

    public NProperty SelectionChanged { get { return _selectionChanged ?? (_selectionChanged = NPropFactories.CreateSelectionChanged()); } }
           NProperty _selectionChanged;

    public NProperty SelectionStyle { get { return _selectionStyle ?? (_selectionStyle = NPropFactories.CreateSelectionStyle()); } }
           NProperty _selectionStyle;

    public NProperty SelectPerson { get { return _selectPerson ?? (_selectPerson = NPropFactories.CreateSelectPerson()); } }
           NProperty _selectPerson;

    public NProperty SelectPerson2 { get { return _selectPerson2 ?? (_selectPerson2 = NPropFactories.CreateSelectPerson2()); } }
           NProperty _selectPerson2;

    public NProperty SemanticContentAttribute { get { return _semanticContentAttribute ?? (_semanticContentAttribute = NPropFactories.CreateSemanticContentAttribute()); } }
           NProperty _semanticContentAttribute;

    public NProperty SeparatorStyle { get { return _separatorStyle ?? (_separatorStyle = NPropFactories.CreateSeparatorStyle()); } }
           NProperty _separatorStyle;

    public NProperty ShortcutItems { get { return _shortcutItems ?? (_shortcutItems = NPropFactories.CreateShortcutItems()); } }
           NProperty _shortcutItems;

    public NProperty ShouldCenterFilter { get { return _shouldCenterFilter ?? (_shouldCenterFilter = NPropFactories.CreateShouldCenterFilter()); } }
           NProperty _shouldCenterFilter;

    public NProperty ShouldCullNonVisibleNodes { get { return _shouldCullNonVisibleNodes ?? (_shouldCullNonVisibleNodes = NPropFactories.CreateShouldCullNonVisibleNodes()); } }
           NProperty _shouldCullNonVisibleNodes;

    public NProperty ShouldEnableEffects { get { return _shouldEnableEffects ?? (_shouldEnableEffects = NPropFactories.CreateShouldEnableEffects()); } }
           NProperty _shouldEnableEffects;

    public NProperty ShouldGroupAccessibilityChildren { get { return _shouldGroupAccessibilityChildren ?? (_shouldGroupAccessibilityChildren = NPropFactories.CreateShouldGroupAccessibilityChildren()); } }
           NProperty _shouldGroupAccessibilityChildren;

    public NProperty ShouldIndentWhileEditing { get { return _shouldIndentWhileEditing ?? (_shouldIndentWhileEditing = NPropFactories.CreateShouldIndentWhileEditing()); } }
           NProperty _shouldIndentWhileEditing;

    public NProperty ShouldRasterize { get { return _shouldRasterize ?? (_shouldRasterize = NPropFactories.CreateShouldRasterize()); } }
           NProperty _shouldRasterize;

    public NProperty ShouldShowLinkedContacts { get { return _shouldShowLinkedContacts ?? (_shouldShowLinkedContacts = NPropFactories.CreateShouldShowLinkedContacts()); } }
           NProperty _shouldShowLinkedContacts;

    public NProperty ShouldShowLinkedPeople { get { return _shouldShowLinkedPeople ?? (_shouldShowLinkedPeople = NPropFactories.CreateShouldShowLinkedPeople()); } }
           NProperty _shouldShowLinkedPeople;

    public NProperty ShowExistingMatches { get { return _showExistingMatches ?? (_showExistingMatches = NPropFactories.CreateShowExistingMatches()); } }
           NProperty _showExistingMatches;

    public NProperty ShowingAppNames { get { return _showingAppNames ?? (_showingAppNames = NPropFactories.CreateShowingAppNames()); } }
           NProperty _showingAppNames;

    public NProperty ShowingDeleteConfirmation { get { return _showingDeleteConfirmation ?? (_showingDeleteConfirmation = NPropFactories.CreateShowingDeleteConfirmation()); } }
           NProperty _showingDeleteConfirmation;

    public NProperty ShowsBookmarkButton { get { return _showsBookmarkButton ?? (_showsBookmarkButton = NPropFactories.CreateShowsBookmarkButton()); } }
           NProperty _showsBookmarkButton;

    public NProperty ShowsBuildings { get { return _showsBuildings ?? (_showsBuildings = NPropFactories.CreateShowsBuildings()); } }
           NProperty _showsBuildings;

    public NProperty ShowsCameraControls { get { return _showsCameraControls ?? (_showsCameraControls = NPropFactories.CreateShowsCameraControls()); } }
           NProperty _showsCameraControls;

    public NProperty ShowsCancelButton { get { return _showsCancelButton ?? (_showsCancelButton = NPropFactories.CreateShowsCancelButton()); } }
           NProperty _showsCancelButton;

    public NProperty ShowsCloudItems { get { return _showsCloudItems ?? (_showsCloudItems = NPropFactories.CreateShowsCloudItems()); } }
           NProperty _showsCloudItems;

    public NProperty ShowsCompass { get { return _showsCompass ?? (_showsCompass = NPropFactories.CreateShowsCompass()); } }
           NProperty _showsCompass;

    public NProperty ShowsDoneButton { get { return _showsDoneButton ?? (_showsDoneButton = NPropFactories.CreateShowsDoneButton()); } }
           NProperty _showsDoneButton;

    public NProperty ShowsDrawCount { get { return _showsDrawCount ?? (_showsDrawCount = NPropFactories.CreateShowsDrawCount()); } }
           NProperty _showsDrawCount;

    public NProperty ShowSelectionIndicator { get { return _showSelectionIndicator ?? (_showSelectionIndicator = NPropFactories.CreateShowSelectionIndicator()); } }
           NProperty _showSelectionIndicator;

    public NProperty ShowsFields { get { return _showsFields ?? (_showsFields = NPropFactories.CreateShowsFields()); } }
           NProperty _showsFields;

    public NProperty ShowsFPS { get { return _showsFPS ?? (_showsFPS = NPropFactories.CreateShowsFPS()); } }
           NProperty _showsFPS;

    public NProperty ShowsHorizontalScrollIndicator { get { return _showsHorizontalScrollIndicator ?? (_showsHorizontalScrollIndicator = NPropFactories.CreateShowsHorizontalScrollIndicator()); } }
           NProperty _showsHorizontalScrollIndicator;

    public NProperty ShowsItemsWithProtectedAssets { get { return _showsItemsWithProtectedAssets ?? (_showsItemsWithProtectedAssets = NPropFactories.CreateShowsItemsWithProtectedAssets()); } }
           NProperty _showsItemsWithProtectedAssets;

    public NProperty ShowsNodeCount { get { return _showsNodeCount ?? (_showsNodeCount = NPropFactories.CreateShowsNodeCount()); } }
           NProperty _showsNodeCount;

    public NProperty ShowsPhysics { get { return _showsPhysics ?? (_showsPhysics = NPropFactories.CreateShowsPhysics()); } }
           NProperty _showsPhysics;

    public NProperty ShowsPlaybackControls { get { return _showsPlaybackControls ?? (_showsPlaybackControls = NPropFactories.CreateShowsPlaybackControls()); } }
           NProperty _showsPlaybackControls;

    public NProperty ShowsPointsOfInterest { get { return _showsPointsOfInterest ?? (_showsPointsOfInterest = NPropFactories.CreateShowsPointsOfInterest()); } }
           NProperty _showsPointsOfInterest;

    public NProperty ShowsQuadCount { get { return _showsQuadCount ?? (_showsQuadCount = NPropFactories.CreateShowsQuadCount()); } }
           NProperty _showsQuadCount;

    public NProperty ShowsReorderControl { get { return _showsReorderControl ?? (_showsReorderControl = NPropFactories.CreateShowsReorderControl()); } }
           NProperty _showsReorderControl;

    public NProperty ShowsRouteButton { get { return _showsRouteButton ?? (_showsRouteButton = NPropFactories.CreateShowsRouteButton()); } }
           NProperty _showsRouteButton;

    public NProperty ShowsScale { get { return _showsScale ?? (_showsScale = NPropFactories.CreateShowsScale()); } }
           NProperty _showsScale;

    public NProperty ShowsScopeBar { get { return _showsScopeBar ?? (_showsScopeBar = NPropFactories.CreateShowsScopeBar()); } }
           NProperty _showsScopeBar;

    public NProperty ShowsSearchResultsButton { get { return _showsSearchResultsButton ?? (_showsSearchResultsButton = NPropFactories.CreateShowsSearchResultsButton()); } }
           NProperty _showsSearchResultsButton;

    public NProperty ShowsStatistics { get { return _showsStatistics ?? (_showsStatistics = NPropFactories.CreateShowsStatistics()); } }
           NProperty _showsStatistics;

    public NProperty ShowsTouchWhenHighlighted { get { return _showsTouchWhenHighlighted ?? (_showsTouchWhenHighlighted = NPropFactories.CreateShowsTouchWhenHighlighted()); } }
           NProperty _showsTouchWhenHighlighted;

    public NProperty ShowsTraffic { get { return _showsTraffic ?? (_showsTraffic = NPropFactories.CreateShowsTraffic()); } }
           NProperty _showsTraffic;

    public NProperty ShowsUserLocation { get { return _showsUserLocation ?? (_showsUserLocation = NPropFactories.CreateShowsUserLocation()); } }
           NProperty _showsUserLocation;

    public NProperty ShowsVerticalScrollIndicator { get { return _showsVerticalScrollIndicator ?? (_showsVerticalScrollIndicator = NPropFactories.CreateShowsVerticalScrollIndicator()); } }
           NProperty _showsVerticalScrollIndicator;

    public NProperty ShowsVolumeSlider { get { return _showsVolumeSlider ?? (_showsVolumeSlider = NPropFactories.CreateShowsVolumeSlider()); } }
           NProperty _showsVolumeSlider;

    public NProperty Smoothness { get { return _smoothness ?? (_smoothness = NPropFactories.CreateSmoothness()); } }
           NProperty _smoothness;

    public NProperty SourceType { get { return _sourceType ?? (_sourceType = NPropFactories.CreateSourceType()); } }
           NProperty _sourceType;

    public NProperty SpellCheckingType { get { return _spellCheckingType ?? (_spellCheckingType = NPropFactories.CreateSpellCheckingType()); } }
           NProperty _spellCheckingType;

    public NProperty Started { get { return _started ?? (_started = NPropFactories.CreateStarted()); } }
           NProperty _started;

    public NProperty StatusBarHidden { get { return _statusBarHidden ?? (_statusBarHidden = NPropFactories.CreateStatusBarHidden()); } }
           NProperty _statusBarHidden;

    public NProperty StatusBarOrientation { get { return _statusBarOrientation ?? (_statusBarOrientation = NPropFactories.CreateStatusBarOrientation()); } }
           NProperty _statusBarOrientation;

    public NProperty StatusBarStyle { get { return _statusBarStyle ?? (_statusBarStyle = NPropFactories.CreateStatusBarStyle()); } }
           NProperty _statusBarStyle;

    public NProperty Strength { get { return _strength ?? (_strength = NPropFactories.CreateStrength()); } }
           NProperty _strength;

    public NProperty Style { get { return _style ?? (_style = NPropFactories.CreateStyle()); } }
           NProperty _style;

    public NProperty Subject { get { return _subject ?? (_subject = NPropFactories.CreateSubject()); } }
           NProperty _subject;

    public NProperty Subviews { get { return _subviews ?? (_subviews = NPropFactories.CreateSubviews()); } }
           NProperty _subviews;

    public NProperty SuppressesIncrementalRendering { get { return _suppressesIncrementalRendering ?? (_suppressesIncrementalRendering = NPropFactories.CreateSuppressesIncrementalRendering()); } }
           NProperty _suppressesIncrementalRendering;

    public NProperty Text { get { return _text ?? (_text = NPropFactories.CreateText()); } }
           NProperty _text;

    public NProperty TextAlignment { get { return _textAlignment ?? (_textAlignment = NPropFactories.CreateTextAlignment()); } }
           NProperty _textAlignment;

    public NProperty TextChanged { get { return _textChanged ?? (_textChanged = NPropFactories.CreateTextChanged()); } }
           NProperty _textChanged;

    public NProperty TextFields { get { return _textFields ?? (_textFields = NPropFactories.CreateTextFields()); } }
           NProperty _textFields;

    public NProperty TimeScope { get { return _timeScope ?? (_timeScope = NPropFactories.CreateTimeScope()); } }
           NProperty _timeScope;

    public NProperty TintAdjustmentMode { get { return _tintAdjustmentMode ?? (_tintAdjustmentMode = NPropFactories.CreateTintAdjustmentMode()); } }
           NProperty _tintAdjustmentMode;

    public NProperty Title { get { return _title ?? (_title = NPropFactories.CreateTitle()); } }
           NProperty _title;

    public NProperty ToolbarHidden { get { return _toolbarHidden ?? (_toolbarHidden = NPropFactories.CreateToolbarHidden()); } }
           NProperty _toolbarHidden;

    public NProperty ToolbarItems { get { return _toolbarItems ?? (_toolbarItems = NPropFactories.CreateToolbarItems()); } }
           NProperty _toolbarItems;

    public NProperty TouchCancel { get { return _touchCancel ?? (_touchCancel = NPropFactories.CreateTouchCancel()); } }
           NProperty _touchCancel;

    public NProperty TouchDown { get { return _touchDown ?? (_touchDown = NPropFactories.CreateTouchDown()); } }
           NProperty _touchDown;

    public NProperty TouchDownRepeat { get { return _touchDownRepeat ?? (_touchDownRepeat = NPropFactories.CreateTouchDownRepeat()); } }
           NProperty _touchDownRepeat;

    public NProperty TouchDragEnter { get { return _touchDragEnter ?? (_touchDragEnter = NPropFactories.CreateTouchDragEnter()); } }
           NProperty _touchDragEnter;

    public NProperty TouchDragExit { get { return _touchDragExit ?? (_touchDragExit = NPropFactories.CreateTouchDragExit()); } }
           NProperty _touchDragExit;

    public NProperty TouchDragInside { get { return _touchDragInside ?? (_touchDragInside = NPropFactories.CreateTouchDragInside()); } }
           NProperty _touchDragInside;

    public NProperty TouchDragOutside { get { return _touchDragOutside ?? (_touchDragOutside = NPropFactories.CreateTouchDragOutside()); } }
           NProperty _touchDragOutside;

    public NProperty TouchUpInside { get { return _touchUpInside ?? (_touchUpInside = NPropFactories.CreateTouchUpInside()); } }
           NProperty _touchUpInside;

    public NProperty TouchUpOutside { get { return _touchUpOutside ?? (_touchUpOutside = NPropFactories.CreateTouchUpOutside()); } }
           NProperty _touchUpOutside;

    public NProperty TranslatesAutoresizingMaskIntoConstraints { get { return _translatesAutoresizingMaskIntoConstraints ?? (_translatesAutoresizingMaskIntoConstraints = NPropFactories.CreateTranslatesAutoresizingMaskIntoConstraints()); } }
           NProperty _translatesAutoresizingMaskIntoConstraints;

    public NProperty Translucent { get { return _translucent ?? (_translucent = NPropFactories.CreateTranslucent()); } }
           NProperty _translucent;

    public NProperty UseLayoutToLayoutNavigationTransitions { get { return _useLayoutToLayoutNavigationTransitions ?? (_useLayoutToLayoutNavigationTransitions = NPropFactories.CreateUseLayoutToLayoutNavigationTransitions()); } }
           NProperty _useLayoutToLayoutNavigationTransitions;

    public NProperty UserCancelled { get { return _userCancelled ?? (_userCancelled = NPropFactories.CreateUserCancelled()); } }
           NProperty _userCancelled;

    public NProperty UserInteractionEnabled { get { return _userInteractionEnabled ?? (_userInteractionEnabled = NPropFactories.CreateUserInteractionEnabled()); } }
           NProperty _userInteractionEnabled;

    public NProperty UserTrackingMode { get { return _userTrackingMode ?? (_userTrackingMode = NPropFactories.CreateUserTrackingMode()); } }
           NProperty _userTrackingMode;

    public NProperty ValidTypes { get { return _validTypes ?? (_validTypes = NPropFactories.CreateValidTypes()); } }
           NProperty _validTypes;

    public NProperty Value { get { return _value ?? (_value = NPropFactories.CreateValue()); } }
           NProperty _value;

    public NProperty ValueChanged { get { return _valueChanged ?? (_valueChanged = NPropFactories.CreateValueChanged()); } }
           NProperty _valueChanged;

    public NProperty VerticalAlignment { get { return _verticalAlignment ?? (_verticalAlignment = NPropFactories.CreateVerticalAlignment()); } }
           NProperty _verticalAlignment;

    public NProperty VerticalAlignmentMode { get { return _verticalAlignmentMode ?? (_verticalAlignmentMode = NPropFactories.CreateVerticalAlignmentMode()); } }
           NProperty _verticalAlignmentMode;

    public NProperty VideoGravity { get { return _videoGravity ?? (_videoGravity = NPropFactories.CreateVideoGravity()); } }
           NProperty _videoGravity;

    public NProperty VideoPath { get { return _videoPath ?? (_videoPath = NPropFactories.CreateVideoPath()); } }
           NProperty _videoPath;

    public NProperty VideoQuality { get { return _videoQuality ?? (_videoQuality = NPropFactories.CreateVideoQuality()); } }
           NProperty _videoQuality;

    public NProperty ViewControllers { get { return _viewControllers ?? (_viewControllers = NPropFactories.CreateViewControllers()); } }
           NProperty _viewControllers;

    public NProperty ViewControllerSelected { get { return _viewControllerSelected ?? (_viewControllerSelected = NPropFactories.CreateViewControllerSelected()); } }
           NProperty _viewControllerSelected;

    public NProperty ViewState { get { return _viewState ?? (_viewState = NPropFactories.CreateViewState()); } }
           NProperty _viewState;

    public NProperty VisibleCells { get { return _visibleCells ?? (_visibleCells = NPropFactories.CreateVisibleCells()); } }
           NProperty _visibleCells;

    public NProperty WantsFullScreenLayout { get { return _wantsFullScreenLayout ?? (_wantsFullScreenLayout = NPropFactories.CreateWantsFullScreenLayout()); } }
           NProperty _wantsFullScreenLayout;

    public NProperty WasCancelled { get { return _wasCancelled ?? (_wasCancelled = NPropFactories.CreateWasCancelled()); } }
           NProperty _wasCancelled;

    public NProperty WillAuthorizePayment { get { return _willAuthorizePayment ?? (_willAuthorizePayment = NPropFactories.CreateWillAuthorizePayment()); } }
           NProperty _willAuthorizePayment;

    public NProperty WillBeginCustomizingItems { get { return _willBeginCustomizingItems ?? (_willBeginCustomizingItems = NPropFactories.CreateWillBeginCustomizingItems()); } }
           NProperty _willBeginCustomizingItems;

    public NProperty WillChangeDisplayMode { get { return _willChangeDisplayMode ?? (_willChangeDisplayMode = NPropFactories.CreateWillChangeDisplayMode()); } }
           NProperty _willChangeDisplayMode;

    public NProperty WillDismiss { get { return _willDismiss ?? (_willDismiss = NPropFactories.CreateWillDismiss()); } }
           NProperty _willDismiss;

    public NProperty WillEndCustomizingItems { get { return _willEndCustomizingItems ?? (_willEndCustomizingItems = NPropFactories.CreateWillEndCustomizingItems()); } }
           NProperty _willEndCustomizingItems;

    public NProperty WillEndDragging { get { return _willEndDragging ?? (_willEndDragging = NPropFactories.CreateWillEndDragging()); } }
           NProperty _willEndDragging;

    public NProperty WillHideViewController { get { return _willHideViewController ?? (_willHideViewController = NPropFactories.CreateWillHideViewController()); } }
           NProperty _willHideViewController;

    public NProperty WillLoad { get { return _willLoad ?? (_willLoad = NPropFactories.CreateWillLoad()); } }
           NProperty _willLoad;

    public NProperty WillPresent { get { return _willPresent ?? (_willPresent = NPropFactories.CreateWillPresent()); } }
           NProperty _willPresent;

    public NProperty WillPresentViewController { get { return _willPresentViewController ?? (_willPresentViewController = NPropFactories.CreateWillPresentViewController()); } }
           NProperty _willPresentViewController;

    public NProperty WillShowViewController { get { return _willShowViewController ?? (_willShowViewController = NPropFactories.CreateWillShowViewController()); } }
           NProperty _willShowViewController;

    public NProperty WillStartLoadingMap { get { return _willStartLoadingMap ?? (_willStartLoadingMap = NPropFactories.CreateWillStartLoadingMap()); } }
           NProperty _willStartLoadingMap;

    public NProperty WillStartLocatingUser { get { return _willStartLocatingUser ?? (_willStartLocatingUser = NPropFactories.CreateWillStartLocatingUser()); } }
           NProperty _willStartLocatingUser;

    public NProperty WillStartRenderingMap { get { return _willStartRenderingMap ?? (_willStartRenderingMap = NPropFactories.CreateWillStartRenderingMap()); } }
           NProperty _willStartRenderingMap;

    public NProperty WillTransition { get { return _willTransition ?? (_willTransition = NPropFactories.CreateWillTransition()); } }
           NProperty _willTransition;

    public NProperty Windows { get { return _windows ?? (_windows = NPropFactories.CreateWindows()); } }
           NProperty _windows;

    public NProperty Wraps { get { return _wraps ?? (_wraps = NPropFactories.CreateWraps()); } }
           NProperty _wraps;

    public NProperty ZoomEnabled { get { return _zoomEnabled ?? (_zoomEnabled = NPropFactories.CreateZoomEnabled()); } }
           NProperty _zoomEnabled;

    public NProperty ZoomingEnded { get { return _zoomingEnded ?? (_zoomingEnded = NPropFactories.CreateZoomingEnded()); } }
           NProperty _zoomingEnded;

    public NProperty ZoomingStarted { get { return _zoomingStarted ?? (_zoomingStarted = NPropFactories.CreateZoomingStarted()); } }
           NProperty _zoomingStarted;

  }

  static partial class NPropFactories
  {
    public static NProperty CreateAccessibilityCustomActions() => new NProperty(nameof(NProperties.AccessibilityCustomActions)).
        Property<UIResponder>((t, v) => NPatch.AssignListT(t.AccessibilityCustomActions, v));

    public static NProperty CreateAccessibilityElementsHidden() => new NProperty(nameof(NProperties.AccessibilityElementsHidden)).
        Property<UIView>((t, v) => t.AccessibilityElementsHidden = NConverters.ToBoolT(v));

    public static NProperty CreateAccessibilityHint() => new NProperty(nameof(NProperties.AccessibilityHint)).
        Property<UIView>((t, v) => t.AccessibilityHint = NConverters.ToStringT(v));

    public static NProperty CreateAccessibilityIdentifier() => new NProperty(nameof(NProperties.AccessibilityIdentifier)).
        Property<UIView>((t, v) => t.AccessibilityIdentifier = NConverters.ToStringT(v));

    public static NProperty CreateAccessibilityLabel() => new NProperty(nameof(NProperties.AccessibilityLabel)).
        Property<UIView>((t, v) => t.AccessibilityLabel = NConverters.ToStringT(v));

    public static NProperty CreateAccessibilityLanguage() => new NProperty(nameof(NProperties.AccessibilityLanguage)).
        Property<UIView>((t, v) => t.AccessibilityLanguage = NConverters.ToStringT(v));

    public static NProperty CreateAccessibilityNavigationStyle() => new NProperty(nameof(NProperties.AccessibilityNavigationStyle)).
        Property<UIView>((t, v) => t.AccessibilityNavigationStyle = NConverters.ToEnumT<UIAccessibilityNavigationStyle>(v));

    public static NProperty CreateAccessibilityTraits() => new NProperty(nameof(NProperties.AccessibilityTraits)).
        Property<UIView>((t, v) => t.AccessibilityTraits = NConverters.ToEnumT<UIAccessibilityTrait>(v));

    public static NProperty CreateAccessibilityValue() => new NProperty(nameof(NProperties.AccessibilityValue)).
        Property<UIView>((t, v) => t.AccessibilityValue = NConverters.ToStringT(v));

    public static NProperty CreateAccessibilityViewIsModal() => new NProperty(nameof(NProperties.AccessibilityViewIsModal)).
        Property<UIView>((t, v) => t.AccessibilityViewIsModal = NConverters.ToBoolT(v));

    public static NProperty CreateAccessory() => new NProperty(nameof(NProperties.Accessory)).
        Property<UITableViewCell>((t, v) => t.Accessory = NConverters.ToEnumT<UITableViewCellAccessory>(v));

    public static NProperty CreateActionFinished() => new NProperty(nameof(NProperties.ActionFinished)).
        Event<ADBannerView>((s, a) => s.ActionFinished += a.EventHandler);

    public static NProperty CreateActions() => new NProperty(nameof(NProperties.Actions)).
        Property<UIAlertController>((t, v) => NPatch.AssignListT(t.Actions, v));

    public static NProperty CreateActive() => new NProperty(nameof(NProperties.Active)).
        Property<UISearchController>((t, v) => t.Active = NConverters.ToBoolT(v));

    public static NProperty CreateActivityIndicatorViewStyle() => new NProperty(nameof(NProperties.ActivityIndicatorViewStyle)).
        Property<UIActivityIndicatorView>((t, v) => t.ActivityIndicatorViewStyle = NConverters.ToEnumT<UIActivityIndicatorViewStyle>(v));

    public static NProperty CreateAdjustsFontSizeToFitWidth() => new NProperty(nameof(NProperties.AdjustsFontSizeToFitWidth)).
        Property<UITextField>((t, v) => t.AdjustsFontSizeToFitWidth = NConverters.ToBoolT(v)).
        Property<UILabel>((t, v) => t.AdjustsFontSizeToFitWidth = NConverters.ToBoolT(v));

    public static NProperty CreateAdjustsImageWhenDisabled() => new NProperty(nameof(NProperties.AdjustsImageWhenDisabled)).
        Property<UIButton>((t, v) => t.AdjustsImageWhenDisabled = NConverters.ToBoolT(v));

    public static NProperty CreateAdjustsImageWhenHighlighted() => new NProperty(nameof(NProperties.AdjustsImageWhenHighlighted)).
        Property<UIButton>((t, v) => t.AdjustsImageWhenHighlighted = NConverters.ToBoolT(v));

    public static NProperty CreateAdjustsLetterSpacingToFitWidth() => new NProperty(nameof(NProperties.AdjustsLetterSpacingToFitWidth)).
        Property<UILabel>((t, v) => t.AdjustsLetterSpacingToFitWidth = NConverters.ToBoolT(v));

    public static NProperty CreateAdLoaded() => new NProperty(nameof(NProperties.AdLoaded)).
        Event<ADBannerView>((s, a) => s.AdLoaded += a.EventHandler);

    public static NProperty CreateAdvertisingSection() => new NProperty(nameof(NProperties.AdvertisingSection)).
        Property<ADBannerView>((t, v) => t.AdvertisingSection = NConverters.ToStringT(v));

    public static NProperty CreateAlertViewStyle() => new NProperty(nameof(NProperties.AlertViewStyle)).
        Property<UIAlertView>((t, v) => t.AlertViewStyle = NConverters.ToEnumT<UIAlertViewStyle>(v));

    public static NProperty CreateAlignment() => new NProperty(nameof(NProperties.Alignment)).
        Property<UIStackView>((t, v) => t.Alignment = NConverters.ToEnumT<UIStackViewAlignment>(v));

    public static NProperty CreateAllEditingEvents() => new NProperty(nameof(NProperties.AllEditingEvents)).
        Event<UIControl>((s, a) => s.AllEditingEvents += a.EventHandler);

    public static NProperty CreateAllEvents() => new NProperty(nameof(NProperties.AllEvents)).
        Event<UIControl>((s, a) => s.AllEvents += a.EventHandler);

    public static NProperty CreateAllowsActions() => new NProperty(nameof(NProperties.AllowsActions)).
        Property<ABPersonViewController>((t, v) => t.AllowsActions = NConverters.ToBoolT(v)).
        Property<ABUnknownPersonViewController>((t, v) => t.AllowsActions = NConverters.ToBoolT(v)).
        Property<CNContactViewController>((t, v) => t.AllowsActions = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsAddingToAddressBook() => new NProperty(nameof(NProperties.AllowsAddingToAddressBook)).
        Property<ABUnknownPersonViewController>((t, v) => t.AllowsAddingToAddressBook = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsBackForwardNavigationGestures() => new NProperty(nameof(NProperties.AllowsBackForwardNavigationGestures)).
        Property<WKWebView>((t, v) => t.AllowsBackForwardNavigationGestures = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsCalendarPreview() => new NProperty(nameof(NProperties.AllowsCalendarPreview)).
        Property<EKEventViewController>((t, v) => t.AllowsCalendarPreview = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsCameraControl() => new NProperty(nameof(NProperties.AllowsCameraControl)).
        Property<SCNView>((t, v) => t.AllowsCameraControl = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsDefaultTighteningForTruncation() => new NProperty(nameof(NProperties.AllowsDefaultTighteningForTruncation)).
        Property<UILabel>((t, v) => t.AllowsDefaultTighteningForTruncation = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsEditing() => new NProperty(nameof(NProperties.AllowsEditing)).
        Property<ABPersonViewController>((t, v) => t.AllowsEditing = NConverters.ToBoolT(v)).
        Property<UIImagePickerController>((t, v) => t.AllowsEditing = NConverters.ToBoolT(v)).
        Property<EKEventViewController>((t, v) => t.AllowsEditing = NConverters.ToBoolT(v)).
        Property<CNContactViewController>((t, v) => t.AllowsEditing = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsEditingTextAttributes() => new NProperty(nameof(NProperties.AllowsEditingTextAttributes)).
        Property<UITextField>((t, v) => t.AllowsEditingTextAttributes = NConverters.ToBoolT(v)).
        Property<UITextView>((t, v) => t.AllowsEditingTextAttributes = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsImageEditing() => new NProperty(nameof(NProperties.AllowsImageEditing)).
        Property<UIImagePickerController>((t, v) => t.AllowsImageEditing = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsInlineMediaPlayback() => new NProperty(nameof(NProperties.AllowsInlineMediaPlayback)).
        Property<UIWebView>((t, v) => t.AllowsInlineMediaPlayback = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsLinkPreview() => new NProperty(nameof(NProperties.AllowsLinkPreview)).
        Property<UIWebView>((t, v) => t.AllowsLinkPreview = NConverters.ToBoolT(v)).
        Property<WKWebView>((t, v) => t.AllowsLinkPreview = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsMultipleSelection() => new NProperty(nameof(NProperties.AllowsMultipleSelection)).
        Property<UICollectionView>((t, v) => t.AllowsMultipleSelection = NConverters.ToBoolT(v)).
        Property<UITableView>((t, v) => t.AllowsMultipleSelection = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsMultipleSelectionDuringEditing() => new NProperty(nameof(NProperties.AllowsMultipleSelectionDuringEditing)).
        Property<UITableView>((t, v) => t.AllowsMultipleSelectionDuringEditing = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsPickingMultipleItems() => new NProperty(nameof(NProperties.AllowsPickingMultipleItems)).
        Property<MPMediaPickerController>((t, v) => t.AllowsPickingMultipleItems = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsPictureInPictureMediaPlayback() => new NProperty(nameof(NProperties.AllowsPictureInPictureMediaPlayback)).
        Property<UIWebView>((t, v) => t.AllowsPictureInPictureMediaPlayback = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsPictureInPicturePlayback() => new NProperty(nameof(NProperties.AllowsPictureInPicturePlayback)).
        Property<AVPlayerViewController>((t, v) => t.AllowsPictureInPicturePlayback = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsSelection() => new NProperty(nameof(NProperties.AllowsSelection)).
        Property<UICollectionView>((t, v) => t.AllowsSelection = NConverters.ToBoolT(v)).
        Property<UITableView>((t, v) => t.AllowsSelection = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsSelectionDuringEditing() => new NProperty(nameof(NProperties.AllowsSelectionDuringEditing)).
        Property<UITableView>((t, v) => t.AllowsSelectionDuringEditing = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsSelfSizing() => new NProperty(nameof(NProperties.AllowsSelfSizing)).
        Property<UIInputView>((t, v) => t.AllowsSelfSizing = NConverters.ToBoolT(v));

    public static NProperty CreateAllowsTransparency() => new NProperty(nameof(NProperties.AllowsTransparency)).
        Property<SKView>((t, v) => t.AllowsTransparency = NConverters.ToBoolT(v));

    public static NProperty CreateAllTouchEvents() => new NProperty(nameof(NProperties.AllTouchEvents)).
        Event<UIControl>((s, a) => s.AllTouchEvents += a.EventHandler);

    public static NProperty CreateAlternateName() => new NProperty(nameof(NProperties.AlternateName)).
        Property<ABUnknownPersonViewController>((t, v) => t.AlternateName = NConverters.ToStringT(v)).
        Property<CNContactViewController>((t, v) => t.AlternateName = NConverters.ToStringT(v));

    public static NProperty CreateAlwaysBounceHorizontal() => new NProperty(nameof(NProperties.AlwaysBounceHorizontal)).
        Property<UIScrollView>((t, v) => t.AlwaysBounceHorizontal = NConverters.ToBoolT(v));

    public static NProperty CreateAlwaysBounceVertical() => new NProperty(nameof(NProperties.AlwaysBounceVertical)).
        Property<UIScrollView>((t, v) => t.AlwaysBounceVertical = NConverters.ToBoolT(v));

    public static NProperty CreateAnimatesDrop() => new NProperty(nameof(NProperties.AnimatesDrop)).
        Property<MKPinAnnotationView>((t, v) => t.AnimatesDrop = NConverters.ToBoolT(v));

    public static NProperty CreateAnimationImages() => new NProperty(nameof(NProperties.AnimationImages)).
        Property<UIImageView>((t, v) => NPatch.AssignListT(t.AnimationImages, v));

    public static NProperty CreateAnimationSpeed() => new NProperty(nameof(NProperties.AnimationSpeed)).
        Property<SKFieldNode>((t, v) => t.AnimationSpeed = NConverters.ToSingleT(v));

    public static NProperty CreateAnnotations() => new NProperty(nameof(NProperties.Annotations)).
        Property<MKMapView>((t, v) => NPatch.AssignListT(t.Annotations, v));

    public static NProperty CreateAntialiased() => new NProperty(nameof(NProperties.Antialiased)).
        Property<SKShapeNode>((t, v) => t.Antialiased = NConverters.ToBoolT(v));

    public static NProperty CreateAntialiasingMode() => new NProperty(nameof(NProperties.AntialiasingMode)).
        Property<SCNView>((t, v) => t.AntialiasingMode = NConverters.ToEnumT<SCNAntialiasingMode>(v));

    public static NProperty CreateApplicationSupportsShakeToEdit() => new NProperty(nameof(NProperties.ApplicationSupportsShakeToEdit)).
        Property<UIApplication>((t, v) => t.ApplicationSupportsShakeToEdit = NConverters.ToBoolT(v));

    public static NProperty CreateApportionsSegmentWidthsByContent() => new NProperty(nameof(NProperties.ApportionsSegmentWidthsByContent)).
        Property<UISegmentedControl>((t, v) => t.ApportionsSegmentWidthsByContent = NConverters.ToBoolT(v));

    public static NProperty CreateArrangedSubviews() => new NProperty(nameof(NProperties.ArrangedSubviews)).
        Property<UIStackView>((t, v) => NPatch.AssignListT(t.ArrangedSubviews, v));

    public static NProperty CreateArrowDirection() => new NProperty(nameof(NProperties.ArrowDirection)).
        Property<UIPopoverBackgroundView>((t, v) => t.ArrowDirection = NConverters.ToEnumT<UIPopoverArrowDirection>(v));

    public static NProperty CreateAsynchronous() => new NProperty(nameof(NProperties.Asynchronous)).
        Property<SKView>((t, v) => t.Asynchronous = NConverters.ToBoolT(v));

    public static NProperty CreateAutocapitalizationType() => new NProperty(nameof(NProperties.AutocapitalizationType)).
        Property<UITextField>((t, v) => t.AutocapitalizationType = NConverters.ToEnumT<UITextAutocapitalizationType>(v)).
        Property<UISearchBar>((t, v) => t.AutocapitalizationType = NConverters.ToEnumT<UITextAutocapitalizationType>(v)).
        Property<UITextView>((t, v) => t.AutocapitalizationType = NConverters.ToEnumT<UITextAutocapitalizationType>(v));

    public static NProperty CreateAutocorrectionType() => new NProperty(nameof(NProperties.AutocorrectionType)).
        Property<UITextField>((t, v) => t.AutocorrectionType = NConverters.ToEnumT<UITextAutocorrectionType>(v)).
        Property<UISearchBar>((t, v) => t.AutocorrectionType = NConverters.ToEnumT<UITextAutocorrectionType>(v)).
        Property<UITextView>((t, v) => t.AutocorrectionType = NConverters.ToEnumT<UITextAutocorrectionType>(v));

    public static NProperty CreateAutoenablesDefaultLighting() => new NProperty(nameof(NProperties.AutoenablesDefaultLighting)).
        Property<SK3DNode>((t, v) => t.AutoenablesDefaultLighting = NConverters.ToBoolT(v)).
        Property<SCNView>((t, v) => t.AutoenablesDefaultLighting = NConverters.ToBoolT(v));

    public static NProperty CreateAutomaticallyAdjustsScrollViewInsets() => new NProperty(nameof(NProperties.AutomaticallyAdjustsScrollViewInsets)).
        Property<UIViewController>((t, v) => t.AutomaticallyAdjustsScrollViewInsets = NConverters.ToBoolT(v));

    public static NProperty CreateAutoplayLooped() => new NProperty(nameof(NProperties.AutoplayLooped)).
        Property<SKAudioNode>((t, v) => t.AutoplayLooped = NConverters.ToBoolT(v));

    public static NProperty CreateAutoRepeat() => new NProperty(nameof(NProperties.AutoRepeat)).
        Property<UIStepper>((t, v) => t.AutoRepeat = NConverters.ToBoolT(v));

    public static NProperty CreateAutoResizeDrawable() => new NProperty(nameof(NProperties.AutoResizeDrawable)).
        Property<MTKView>((t, v) => t.AutoResizeDrawable = NConverters.ToBoolT(v));

    public static NProperty CreateAutoresizingMask() => new NProperty(nameof(NProperties.AutoresizingMask)).
        Property<UIView>((t, v) => t.AutoresizingMask = NConverters.ToEnumT<UIViewAutoresizing>(v));

    public static NProperty CreateAutosizesSubviews() => new NProperty(nameof(NProperties.AutosizesSubviews)).
        Property<UIView>((t, v) => t.AutosizesSubviews = NConverters.ToBoolT(v));

    public static NProperty CreateAxis() => new NProperty(nameof(NProperties.Axis)).
        Property<UIStackView>((t, v) => t.Axis = NConverters.ToEnumT<UILayoutConstraintAxis>(v));

    public static NProperty CreateBarStyle() => new NProperty(nameof(NProperties.BarStyle)).
        Property<UINavigationBar>((t, v) => t.BarStyle = NConverters.ToEnumT<UIBarStyle>(v)).
        Property<UISearchBar>((t, v) => t.BarStyle = NConverters.ToEnumT<UIBarStyle>(v)).
        Property<UIToolbar>((t, v) => t.BarStyle = NConverters.ToEnumT<UIBarStyle>(v)).
        Property<UITabBar>((t, v) => t.BarStyle = NConverters.ToEnumT<UIBarStyle>(v));

    public static NProperty CreateBaselineAdjustment() => new NProperty(nameof(NProperties.BaselineAdjustment)).
        Property<UILabel>((t, v) => t.BaselineAdjustment = NConverters.ToEnumT<UIBaselineAdjustment>(v));

    public static NProperty CreateBaselineRelativeArrangement() => new NProperty(nameof(NProperties.BaselineRelativeArrangement)).
        Property<UIStackView>((t, v) => t.BaselineRelativeArrangement = NConverters.ToBoolT(v));

    public static NProperty CreateBlendMode() => new NProperty(nameof(NProperties.BlendMode)).
        Property<SKSpriteNode>((t, v) => t.BlendMode = NConverters.ToEnumT<SKBlendMode>(v)).
        Property<SKEffectNode>((t, v) => t.BlendMode = NConverters.ToEnumT<SKBlendMode>(v)).
        Property<SKShapeNode>((t, v) => t.BlendMode = NConverters.ToEnumT<SKBlendMode>(v)).
        Property<SKLabelNode>((t, v) => t.BlendMode = NConverters.ToEnumT<SKBlendMode>(v));

    public static NProperty CreateBody() => new NProperty(nameof(NProperties.Body)).
        Property<MFMessageComposeViewController>((t, v) => t.Body = NConverters.ToStringT(v));

    public static NProperty CreateBookmarkButtonClicked() => new NProperty(nameof(NProperties.BookmarkButtonClicked)).
        Event<UISearchBar>((s, a) => s.BookmarkButtonClicked += a.EventHandler);

    public static NProperty CreateBorderStyle() => new NProperty(nameof(NProperties.BorderStyle)).
        Property<UITextField>((t, v) => t.BorderStyle = NConverters.ToEnumT<UITextBorderStyle>(v));

    public static NProperty CreateBounces() => new NProperty(nameof(NProperties.Bounces)).
        Property<UIScrollView>((t, v) => t.Bounces = NConverters.ToBoolT(v));

    public static NProperty CreateBouncesZoom() => new NProperty(nameof(NProperties.BouncesZoom)).
        Property<UIScrollView>((t, v) => t.BouncesZoom = NConverters.ToBoolT(v));

    public static NProperty CreateCalloutAccessoryControlTapped() => new NProperty(nameof(NProperties.CalloutAccessoryControlTapped)).
        Event<MKMapView>((s, a) => s.CalloutAccessoryControlTapped += a.EventHandler);

    public static NProperty CreateCameraCaptureMode() => new NProperty(nameof(NProperties.CameraCaptureMode)).
        Property<UIImagePickerController>((t, v) => t.CameraCaptureMode = NConverters.ToEnumT<UIImagePickerControllerCameraCaptureMode>(v));

    public static NProperty CreateCameraDevice() => new NProperty(nameof(NProperties.CameraDevice)).
        Property<UIImagePickerController>((t, v) => t.CameraDevice = NConverters.ToEnumT<UIImagePickerControllerCameraDevice>(v));

    public static NProperty CreateCameraFlashMode() => new NProperty(nameof(NProperties.CameraFlashMode)).
        Property<UIImagePickerController>((t, v) => t.CameraFlashMode = NConverters.ToEnumT<UIImagePickerControllerCameraFlashMode>(v));

    public static NProperty CreateCanCancelContentTouches() => new NProperty(nameof(NProperties.CanCancelContentTouches)).
        Property<UIScrollView>((t, v) => t.CanCancelContentTouches = NConverters.ToBoolT(v));

    public static NProperty CreateCancelButtonClicked() => new NProperty(nameof(NProperties.CancelButtonClicked)).
        Event<UISearchBar>((s, a) => s.CancelButtonClicked += a.EventHandler);

    public static NProperty CreateCanceled() => new NProperty(nameof(NProperties.Canceled)).
        Event<UIActionSheet>((s, a) => s.Canceled += a.EventHandler).
        Event<UIAlertView>((s, a) => s.Canceled += a.EventHandler).
        Event<UIImagePickerController>((s, a) => s.Canceled += a.EventHandler);

    public static NProperty CreateCancelled() => new NProperty(nameof(NProperties.Cancelled)).
        Event<ABPeoplePickerNavigationController>((s, a) => s.Cancelled += a.EventHandler).
        Event<EKCalendarChooser>((s, a) => s.Cancelled += a.EventHandler);

    public static NProperty CreateCanShowCallout() => new NProperty(nameof(NProperties.CanShowCallout)).
        Property<MKAnnotationView>((t, v) => t.CanShowCallout = NConverters.ToBoolT(v));

    public static NProperty CreateCategory() => new NProperty(nameof(NProperties.Category)).
        Property<GKLeaderboardViewController>((t, v) => t.Category = NConverters.ToStringT(v));

    public static NProperty CreateCellLayoutMarginsFollowReadableWidth() => new NProperty(nameof(NProperties.CellLayoutMarginsFollowReadableWidth)).
        Property<UITableView>((t, v) => t.CellLayoutMarginsFollowReadableWidth = NConverters.ToBoolT(v));

    public static NProperty CreateCertificateChain() => new NProperty(nameof(NProperties.CertificateChain)).
        Property<WKWebView>((t, v) => NPatch.AssignListT(t.CertificateChain, v));

    public static NProperty CreateChanged() => new NProperty(nameof(NProperties.Changed)).
        Event<UITextView>((s, a) => s.Changed += a.EventHandler);

    public static NProperty CreateChangedDragState() => new NProperty(nameof(NProperties.ChangedDragState)).
        Event<MKMapView>((s, a) => s.ChangedDragState += a.EventHandler);

    public static NProperty CreateChild() => new NProperty(nameof(NProperties.Child));

    public static NProperty CreateChildren() => new NProperty(nameof(NProperties.Children)).
        Property<SKNode>((t, v) => NPatch.AssignListT(t.Children, v));

    public static NProperty CreateChildViewControllers() => new NProperty(nameof(NProperties.ChildViewControllers)).
        Property<UIViewController>((t, v) => NPatch.AssignListT(t.ChildViewControllers, v));

    public static NProperty CreateClearButtonMode() => new NProperty(nameof(NProperties.ClearButtonMode)).
        Property<UITextField>((t, v) => t.ClearButtonMode = NConverters.ToEnumT<UITextFieldViewMode>(v));

    public static NProperty CreateClearsContextBeforeDrawing() => new NProperty(nameof(NProperties.ClearsContextBeforeDrawing)).
        Property<UIView>((t, v) => t.ClearsContextBeforeDrawing = NConverters.ToBoolT(v));

    public static NProperty CreateClearsOnBeginEditing() => new NProperty(nameof(NProperties.ClearsOnBeginEditing)).
        Property<UITextField>((t, v) => t.ClearsOnBeginEditing = NConverters.ToBoolT(v));

    public static NProperty CreateClearsOnInsertion() => new NProperty(nameof(NProperties.ClearsOnInsertion)).
        Property<UITextField>((t, v) => t.ClearsOnInsertion = NConverters.ToBoolT(v)).
        Property<UITextView>((t, v) => t.ClearsOnInsertion = NConverters.ToBoolT(v));

    public static NProperty CreateClearsSelectionOnViewWillAppear() => new NProperty(nameof(NProperties.ClearsSelectionOnViewWillAppear)).
        Property<UICollectionViewController>((t, v) => t.ClearsSelectionOnViewWillAppear = NConverters.ToBoolT(v)).
        Property<UITableViewController>((t, v) => t.ClearsSelectionOnViewWillAppear = NConverters.ToBoolT(v));

    public static NProperty CreateClicked() => new NProperty(nameof(NProperties.Clicked)).
        Event<UIActionSheet>((s, a) => s.Clicked += a.EventHandler).
        Event<UIAlertView>((s, a) => s.Clicked += a.EventHandler);

    public static NProperty CreateClipsToBounds() => new NProperty(nameof(NProperties.ClipsToBounds)).
        Property<UIView>((t, v) => t.ClipsToBounds = NConverters.ToBoolT(v));

    public static NProperty CreateColorPixelFormat() => new NProperty(nameof(NProperties.ColorPixelFormat)).
        Property<MTKView>((t, v) => t.ColorPixelFormat = NConverters.ToEnumT<MTLPixelFormat>(v));

    public static NProperty CreateCompleted() => new NProperty(nameof(NProperties.Completed)).
        Event<EKEventEditViewController>((s, a) => s.Completed += a.EventHandler).
        Event<EKEventViewController>((s, a) => s.Completed += a.EventHandler);

    public static NProperty CreateConstraints() => new NProperty(nameof(NProperties.Constraints)).
        Property<SKNode>((t, v) => NPatch.AssignListT(t.Constraints, v)).
        Property<UIView>((t, v) => NPatch.AssignListT(t.Constraints, v));

    public static NProperty CreateContentMode() => new NProperty(nameof(NProperties.ContentMode)).
        Property<UIView>((t, v) => t.ContentMode = NConverters.ToEnumT<UIViewContentMode>(v));

    public static NProperty CreateContinuous() => new NProperty(nameof(NProperties.Continuous)).
        Property<UISlider>((t, v) => t.Continuous = NConverters.ToBoolT(v)).
        Property<UIStepper>((t, v) => t.Continuous = NConverters.ToBoolT(v));

    public static NProperty CreateControlStyle() => new NProperty(nameof(NProperties.ControlStyle)).
        Property<UISegmentedControl>((t, v) => t.ControlStyle = NConverters.ToEnumT<UISegmentedControlStyle>(v));

    public static NProperty CreateCurrentContentSizeIdentifier() => new NProperty(nameof(NProperties.CurrentContentSizeIdentifier)).
        Property<ADBannerView>((t, v) => t.CurrentContentSizeIdentifier = NConverters.ToStringT(v));

    public static NProperty CreateCustomizableViewControllers() => new NProperty(nameof(NProperties.CustomizableViewControllers)).
        Property<UITabBarController>((t, v) => NPatch.AssignListT(t.CustomizableViewControllers, v));

    public static NProperty CreateCustomUserAgent() => new NProperty(nameof(NProperties.CustomUserAgent)).
        Property<WKWebView>((t, v) => t.CustomUserAgent = NConverters.ToStringT(v));

    public static NProperty CreateDataDetectorTypes() => new NProperty(nameof(NProperties.DataDetectorTypes)).
        Property<UITextView>((t, v) => t.DataDetectorTypes = NConverters.ToEnumT<UIDataDetectorType>(v)).
        Property<UIWebView>((t, v) => t.DataDetectorTypes = NConverters.ToEnumT<UIDataDetectorType>(v));

    public static NProperty CreateDebugOptions() => new NProperty(nameof(NProperties.DebugOptions)).
        Property<SCNView>((t, v) => t.DebugOptions = NConverters.ToEnumT<SCNDebugOptions>(v));

    public static NProperty CreateDecelerationEnded() => new NProperty(nameof(NProperties.DecelerationEnded)).
        Event<UIScrollView>((s, a) => s.DecelerationEnded += a.EventHandler);

    public static NProperty CreateDecelerationStarted() => new NProperty(nameof(NProperties.DecelerationStarted)).
        Event<UIScrollView>((s, a) => s.DecelerationStarted += a.EventHandler);

    public static NProperty CreateDefaultInvitationMessage() => new NProperty(nameof(NProperties.DefaultInvitationMessage)).
        Property<GKMatchmakerViewController>((t, v) => t.DefaultInvitationMessage = NConverters.ToStringT(v));

    public static NProperty CreateDefersCurrentPageDisplay() => new NProperty(nameof(NProperties.DefersCurrentPageDisplay)).
        Property<UIPageControl>((t, v) => t.DefersCurrentPageDisplay = NConverters.ToBoolT(v));

    public static NProperty CreateDefinesPresentationContext() => new NProperty(nameof(NProperties.DefinesPresentationContext)).
        Property<UIViewController>((t, v) => t.DefinesPresentationContext = NConverters.ToBoolT(v));

    public static NProperty CreateDelaysContentTouches() => new NProperty(nameof(NProperties.DelaysContentTouches)).
        Property<UIScrollView>((t, v) => t.DelaysContentTouches = NConverters.ToBoolT(v));

    public static NProperty CreateDepthStencilPixelFormat() => new NProperty(nameof(NProperties.DepthStencilPixelFormat)).
        Property<MTKView>((t, v) => t.DepthStencilPixelFormat = NConverters.ToEnumT<MTLPixelFormat>(v));

    public static NProperty CreateDidAddAnnotationViews() => new NProperty(nameof(NProperties.DidAddAnnotationViews)).
        Event<MKMapView>((s, a) => s.DidAddAnnotationViews += a.EventHandler);

    public static NProperty CreateDidAddOverlayRenderers() => new NProperty(nameof(NProperties.DidAddOverlayRenderers)).
        Event<MKMapView>((s, a) => s.DidAddOverlayRenderers += a.EventHandler);

    public static NProperty CreateDidAddOverlayViews() => new NProperty(nameof(NProperties.DidAddOverlayViews)).
        Event<MKMapView>((s, a) => s.DidAddOverlayViews += a.EventHandler);

    public static NProperty CreateDidAuthorizePayment() => new NProperty(nameof(NProperties.DidAuthorizePayment)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.DidAuthorizePayment += a.EventHandler);

    public static NProperty CreateDidBeginCustomizingItems() => new NProperty(nameof(NProperties.DidBeginCustomizingItems)).
        Event<UITabBar>((s, a) => s.DidBeginCustomizingItems += a.EventHandler);

    public static NProperty CreateDidCancel() => new NProperty(nameof(NProperties.DidCancel)).
        Event<MPMediaPickerController>((s, a) => s.DidCancel += a.EventHandler);

    public static NProperty CreateDidChangeUserTrackingMode() => new NProperty(nameof(NProperties.DidChangeUserTrackingMode)).
        Event<MKMapView>((s, a) => s.DidChangeUserTrackingMode += a.EventHandler);

    public static NProperty CreateDidDeselectAnnotationView() => new NProperty(nameof(NProperties.DidDeselectAnnotationView)).
        Event<MKMapView>((s, a) => s.DidDeselectAnnotationView += a.EventHandler);

    public static NProperty CreateDidDismiss() => new NProperty(nameof(NProperties.DidDismiss)).
        Event<QLPreviewController>((s, a) => s.DidDismiss += a.EventHandler);

    public static NProperty CreateDidEndCustomizingItems() => new NProperty(nameof(NProperties.DidEndCustomizingItems)).
        Event<UITabBar>((s, a) => s.DidEndCustomizingItems += a.EventHandler);

    public static NProperty CreateDidFailToLocateUser() => new NProperty(nameof(NProperties.DidFailToLocateUser)).
        Event<MKMapView>((s, a) => s.DidFailToLocateUser += a.EventHandler);

    public static NProperty CreateDidFailWithError() => new NProperty(nameof(NProperties.DidFailWithError)).
        Event<GKMatchmakerViewController>((s, a) => s.DidFailWithError += a.EventHandler);

    public static NProperty CreateDidFindHostedPlayers() => new NProperty(nameof(NProperties.DidFindHostedPlayers)).
        Event<GKMatchmakerViewController>((s, a) => s.DidFindHostedPlayers += a.EventHandler);

    public static NProperty CreateDidFindMatch() => new NProperty(nameof(NProperties.DidFindMatch)).
        Event<GKMatchmakerViewController>((s, a) => s.DidFindMatch += a.EventHandler);

    public static NProperty CreateDidFindPlayers() => new NProperty(nameof(NProperties.DidFindPlayers)).
        Event<GKMatchmakerViewController>((s, a) => s.DidFindPlayers += a.EventHandler);

    public static NProperty CreateDidFinish() => new NProperty(nameof(NProperties.DidFinish)).
        Event<GKFriendRequestComposeViewController>((s, a) => s.DidFinish += a.EventHandler).
        Event<GKLeaderboardViewController>((s, a) => s.DidFinish += a.EventHandler).
        Event<GKAchievementViewController>((s, a) => s.DidFinish += a.EventHandler);

    public static NProperty CreateDidFinishAnimating() => new NProperty(nameof(NProperties.DidFinishAnimating)).
        Event<UIPageViewController>((s, a) => s.DidFinishAnimating += a.EventHandler);

    public static NProperty CreateDidFinishRenderingMap() => new NProperty(nameof(NProperties.DidFinishRenderingMap)).
        Event<MKMapView>((s, a) => s.DidFinishRenderingMap += a.EventHandler);

    public static NProperty CreateDidPickDocument() => new NProperty(nameof(NProperties.DidPickDocument)).
        Event<UIDocumentPickerViewController>((s, a) => s.DidPickDocument += a.EventHandler);

    public static NProperty CreateDidPickDocumentPicker() => new NProperty(nameof(NProperties.DidPickDocumentPicker)).
        Event<UIDocumentMenuViewController>((s, a) => s.DidPickDocumentPicker += a.EventHandler);

    public static NProperty CreateDidSelectAnnotationView() => new NProperty(nameof(NProperties.DidSelectAnnotationView)).
        Event<MKMapView>((s, a) => s.DidSelectAnnotationView += a.EventHandler);

    public static NProperty CreateDidSelectPaymentMethod() => new NProperty(nameof(NProperties.DidSelectPaymentMethod)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.DidSelectPaymentMethod += a.EventHandler);

    public static NProperty CreateDidSelectShippingAddress() => new NProperty(nameof(NProperties.DidSelectShippingAddress)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.DidSelectShippingAddress += a.EventHandler);

    public static NProperty CreateDidSelectShippingContact() => new NProperty(nameof(NProperties.DidSelectShippingContact)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.DidSelectShippingContact += a.EventHandler);

    public static NProperty CreateDidSelectShippingMethod() => new NProperty(nameof(NProperties.DidSelectShippingMethod)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.DidSelectShippingMethod += a.EventHandler);

    public static NProperty CreateDidStopLocatingUser() => new NProperty(nameof(NProperties.DidStopLocatingUser)).
        Event<MKMapView>((s, a) => s.DidStopLocatingUser += a.EventHandler);

    public static NProperty CreateDidUpdateUserLocation() => new NProperty(nameof(NProperties.DidUpdateUserLocation)).
        Event<MKMapView>((s, a) => s.DidUpdateUserLocation += a.EventHandler);

    public static NProperty CreateDidZoom() => new NProperty(nameof(NProperties.DidZoom)).
        Event<UIScrollView>((s, a) => s.DidZoom += a.EventHandler);

    public static NProperty CreateDimsBackgroundDuringPresentation() => new NProperty(nameof(NProperties.DimsBackgroundDuringPresentation)).
        Property<UISearchController>((t, v) => t.DimsBackgroundDuringPresentation = NConverters.ToBoolT(v));

    public static NProperty CreateDirectionalLockEnabled() => new NProperty(nameof(NProperties.DirectionalLockEnabled)).
        Property<UIScrollView>((t, v) => t.DirectionalLockEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateDismissed() => new NProperty(nameof(NProperties.Dismissed)).
        Event<UIActionSheet>((s, a) => s.Dismissed += a.EventHandler).
        Event<UIAlertView>((s, a) => s.Dismissed += a.EventHandler);

    public static NProperty CreateDisplayedPropertyKeys() => new NProperty(nameof(NProperties.DisplayedPropertyKeys)).
        Property<CNContactPickerViewController>((t, v) => NPatch.AssignListT(t.DisplayedPropertyKeys, v)).
        Property<CNContactViewController>((t, v) => NPatch.AssignListT(t.DisplayedPropertyKeys, v));

    public static NProperty CreateDistribution() => new NProperty(nameof(NProperties.Distribution)).
        Property<UIStackView>((t, v) => t.Distribution = NConverters.ToEnumT<UIStackViewDistribution>(v));

    public static NProperty CreateDoubleSided() => new NProperty(nameof(NProperties.DoubleSided)).
        Property<UIPageViewController>((t, v) => t.DoubleSided = NConverters.ToBoolT(v));

    public static NProperty CreateDraggable() => new NProperty(nameof(NProperties.Draggable)).
        Property<MKAnnotationView>((t, v) => t.Draggable = NConverters.ToBoolT(v));

    public static NProperty CreateDraggingEnded() => new NProperty(nameof(NProperties.DraggingEnded)).
        Event<UIScrollView>((s, a) => s.DraggingEnded += a.EventHandler);

    public static NProperty CreateDraggingStarted() => new NProperty(nameof(NProperties.DraggingStarted)).
        Event<UIScrollView>((s, a) => s.DraggingStarted += a.EventHandler);

    public static NProperty CreateDragState() => new NProperty(nameof(NProperties.DragState)).
        Property<MKAnnotationView>((t, v) => t.DragState = NConverters.ToEnumT<MKAnnotationViewDragState>(v));

    public static NProperty CreateDrawableColorFormat() => new NProperty(nameof(NProperties.DrawableColorFormat)).
        Property<GLKView>((t, v) => t.DrawableColorFormat = NConverters.ToEnumT<GLKViewDrawableColorFormat>(v));

    public static NProperty CreateDrawableDepthFormat() => new NProperty(nameof(NProperties.DrawableDepthFormat)).
        Property<GLKView>((t, v) => t.DrawableDepthFormat = NConverters.ToEnumT<GLKViewDrawableDepthFormat>(v));

    public static NProperty CreateDrawableMultisample() => new NProperty(nameof(NProperties.DrawableMultisample)).
        Property<GLKView>((t, v) => t.DrawableMultisample = NConverters.ToEnumT<GLKViewDrawableMultisample>(v));

    public static NProperty CreateDrawableStencilFormat() => new NProperty(nameof(NProperties.DrawableStencilFormat)).
        Property<GLKView>((t, v) => t.DrawableStencilFormat = NConverters.ToEnumT<GLKViewDrawableStencilFormat>(v));

    public static NProperty CreateDrawInRect() => new NProperty(nameof(NProperties.DrawInRect)).
        Event<GLKView>((s, a) => s.DrawInRect += a.EventHandler);

    public static NProperty CreateEdgesForExtendedLayout() => new NProperty(nameof(NProperties.EdgesForExtendedLayout)).
        Property<UIViewController>((t, v) => t.EdgesForExtendedLayout = NConverters.ToEnumT<UIRectEdge>(v));

    public static NProperty CreateEditable() => new NProperty(nameof(NProperties.Editable)).
        Property<UITextView>((t, v) => t.Editable = NConverters.ToBoolT(v));

    public static NProperty CreateEditing() => new NProperty(nameof(NProperties.Editing)).
        Property<UITableViewCell>((t, v) => t.Editing = NConverters.ToBoolT(v)).
        Property<UITableView>((t, v) => t.Editing = NConverters.ToBoolT(v)).
        Property<UIViewController>((t, v) => t.Editing = NConverters.ToBoolT(v));

    public static NProperty CreateEditingAccessory() => new NProperty(nameof(NProperties.EditingAccessory)).
        Property<UITableViewCell>((t, v) => t.EditingAccessory = NConverters.ToEnumT<UITableViewCellAccessory>(v));

    public static NProperty CreateEditingChanged() => new NProperty(nameof(NProperties.EditingChanged)).
        Event<UIControl>((s, a) => s.EditingChanged += a.EventHandler);

    public static NProperty CreateEditingDidBegin() => new NProperty(nameof(NProperties.EditingDidBegin)).
        Event<UIControl>((s, a) => s.EditingDidBegin += a.EventHandler);

    public static NProperty CreateEditingDidEnd() => new NProperty(nameof(NProperties.EditingDidEnd)).
        Event<UIControl>((s, a) => s.EditingDidEnd += a.EventHandler);

    public static NProperty CreateEditingDidEndOnExit() => new NProperty(nameof(NProperties.EditingDidEndOnExit)).
        Event<UIControl>((s, a) => s.EditingDidEndOnExit += a.EventHandler);

    public static NProperty CreateEnabled() => new NProperty(nameof(NProperties.Enabled)).
        Property<SKFieldNode>((t, v) => t.Enabled = NConverters.ToBoolT(v)).
        Property<SKLightNode>((t, v) => t.Enabled = NConverters.ToBoolT(v)).
        Property<UIControl>((t, v) => t.Enabled = NConverters.ToBoolT(v)).
        Property<CAInterAppAudioTransportView>((t, v) => t.Enabled = NConverters.ToBoolT(v)).
        Property<MKAnnotationView>((t, v) => t.Enabled = NConverters.ToBoolT(v)).
        Property<UILabel>((t, v) => t.Enabled = NConverters.ToBoolT(v));

    public static NProperty CreateEnableSetNeedsDisplay() => new NProperty(nameof(NProperties.EnableSetNeedsDisplay)).
        Property<GLKView>((t, v) => t.EnableSetNeedsDisplay = NConverters.ToBoolT(v)).
        Property<MTKView>((t, v) => t.EnableSetNeedsDisplay = NConverters.ToBoolT(v));

    public static NProperty CreateEnablesReturnKeyAutomatically() => new NProperty(nameof(NProperties.EnablesReturnKeyAutomatically)).
        Property<UITextField>((t, v) => t.EnablesReturnKeyAutomatically = NConverters.ToBoolT(v)).
        Property<UISearchBar>((t, v) => t.EnablesReturnKeyAutomatically = NConverters.ToBoolT(v)).
        Property<UITextView>((t, v) => t.EnablesReturnKeyAutomatically = NConverters.ToBoolT(v));

    public static NProperty CreateEnded() => new NProperty(nameof(NProperties.Ended)).
        Event<UITextField>((s, a) => s.Ended += a.EventHandler).
        Event<UITextView>((s, a) => s.Ended += a.EventHandler);

    public static NProperty CreateExcludedActivityTypes() => new NProperty(nameof(NProperties.ExcludedActivityTypes)).
        Property<UIActivityViewController>((t, v) => NPatch.AssignListT(t.ExcludedActivityTypes, v));

    public static NProperty CreateExclusive() => new NProperty(nameof(NProperties.Exclusive)).
        Property<SKFieldNode>((t, v) => t.Exclusive = NConverters.ToBoolT(v));

    public static NProperty CreateExclusiveTouch() => new NProperty(nameof(NProperties.ExclusiveTouch)).
        Property<UIView>((t, v) => t.ExclusiveTouch = NConverters.ToBoolT(v));

    public static NProperty CreateExtendedLayoutIncludesOpaqueBars() => new NProperty(nameof(NProperties.ExtendedLayoutIncludesOpaqueBars)).
        Property<UIViewController>((t, v) => t.ExtendedLayoutIncludesOpaqueBars = NConverters.ToBoolT(v));

    public static NProperty CreateFailed() => new NProperty(nameof(NProperties.Failed)).
        Event<UIVideoEditorController>((s, a) => s.Failed += a.EventHandler);

    public static NProperty CreateFailedToReceiveAd() => new NProperty(nameof(NProperties.FailedToReceiveAd)).
        Event<ADBannerView>((s, a) => s.FailedToReceiveAd += a.EventHandler);

    public static NProperty CreateFalloff() => new NProperty(nameof(NProperties.Falloff)).
        Property<SKFieldNode>((t, v) => t.Falloff = NConverters.ToSingleT(v));

    public static NProperty CreateFinished() => new NProperty(nameof(NProperties.Finished)).
        Event<GKGameCenterViewController>((s, a) => s.Finished += a.EventHandler).
        Event<MFMailComposeViewController>((s, a) => s.Finished += a.EventHandler).
        Event<MFMessageComposeViewController>((s, a) => s.Finished += a.EventHandler).
        Event<EKCalendarChooser>((s, a) => s.Finished += a.EventHandler).
        Event<SKStoreProductViewController>((s, a) => s.Finished += a.EventHandler).
        Event<PKAddPassesViewController>((s, a) => s.Finished += a.EventHandler);

    public static NProperty CreateFinishedCustomizingViewControllers() => new NProperty(nameof(NProperties.FinishedCustomizingViewControllers)).
        Event<UITabBarController>((s, a) => s.FinishedCustomizingViewControllers += a.EventHandler);

    public static NProperty CreateFinishedPickingImage() => new NProperty(nameof(NProperties.FinishedPickingImage)).
        Event<UIImagePickerController>((s, a) => s.FinishedPickingImage += a.EventHandler);

    public static NProperty CreateFinishedPickingMedia() => new NProperty(nameof(NProperties.FinishedPickingMedia)).
        Event<UIImagePickerController>((s, a) => s.FinishedPickingMedia += a.EventHandler);

    public static NProperty CreateFocusStyle() => new NProperty(nameof(NProperties.FocusStyle)).
        Property<UITableViewCell>((t, v) => t.FocusStyle = NConverters.ToEnumT<UITableViewCellFocusStyle>(v));

    public static NProperty CreateFontName() => new NProperty(nameof(NProperties.FontName)).
        Property<SKLabelNode>((t, v) => t.FontName = NConverters.ToStringT(v));

    public static NProperty CreateFramebufferOnly() => new NProperty(nameof(NProperties.FramebufferOnly)).
        Property<MTKView>((t, v) => t.FramebufferOnly = NConverters.ToBoolT(v));

    public static NProperty CreateGestureRecognizers() => new NProperty(nameof(NProperties.GestureRecognizers)).
        Property<UIView>((t, v) => NPatch.AssignListT(t.GestureRecognizers, v)).
        Property<UIPageViewController>((t, v) => NPatch.AssignListT(t.GestureRecognizers, v));

    public static NProperty CreateHidden() => new NProperty(nameof(NProperties.Hidden)).
        Property<SKNode>((t, v) => t.Hidden = NConverters.ToBoolT(v)).
        Property<UIView>((t, v) => t.Hidden = NConverters.ToBoolT(v));

    public static NProperty CreateHidesBarsOnSwipe() => new NProperty(nameof(NProperties.HidesBarsOnSwipe)).
        Property<UINavigationController>((t, v) => t.HidesBarsOnSwipe = NConverters.ToBoolT(v));

    public static NProperty CreateHidesBarsOnTap() => new NProperty(nameof(NProperties.HidesBarsOnTap)).
        Property<UINavigationController>((t, v) => t.HidesBarsOnTap = NConverters.ToBoolT(v));

    public static NProperty CreateHidesBarsWhenKeyboardAppears() => new NProperty(nameof(NProperties.HidesBarsWhenKeyboardAppears)).
        Property<UINavigationController>((t, v) => t.HidesBarsWhenKeyboardAppears = NConverters.ToBoolT(v));

    public static NProperty CreateHidesBarsWhenVerticallyCompact() => new NProperty(nameof(NProperties.HidesBarsWhenVerticallyCompact)).
        Property<UINavigationController>((t, v) => t.HidesBarsWhenVerticallyCompact = NConverters.ToBoolT(v));

    public static NProperty CreateHidesBottomBarWhenPushed() => new NProperty(nameof(NProperties.HidesBottomBarWhenPushed)).
        Property<UIViewController>((t, v) => t.HidesBottomBarWhenPushed = NConverters.ToBoolT(v));

    public static NProperty CreateHidesForSinglePage() => new NProperty(nameof(NProperties.HidesForSinglePage)).
        Property<UIPageControl>((t, v) => t.HidesForSinglePage = NConverters.ToBoolT(v));

    public static NProperty CreateHidesNavigationBarDuringPresentation() => new NProperty(nameof(NProperties.HidesNavigationBarDuringPresentation)).
        Property<UISearchController>((t, v) => t.HidesNavigationBarDuringPresentation = NConverters.ToBoolT(v));

    public static NProperty CreateHidesWhenStopped() => new NProperty(nameof(NProperties.HidesWhenStopped)).
        Property<UIActivityIndicatorView>((t, v) => t.HidesWhenStopped = NConverters.ToBoolT(v));

    public static NProperty CreateHighlighted() => new NProperty(nameof(NProperties.Highlighted)).
        Property<UIControl>((t, v) => t.Highlighted = NConverters.ToBoolT(v)).
        Property<UITableViewCell>((t, v) => t.Highlighted = NConverters.ToBoolT(v)).
        Property<UICollectionViewCell>((t, v) => t.Highlighted = NConverters.ToBoolT(v)).
        Property<MKAnnotationView>((t, v) => t.Highlighted = NConverters.ToBoolT(v)).
        Property<UILabel>((t, v) => t.Highlighted = NConverters.ToBoolT(v)).
        Property<UIImageView>((t, v) => t.Highlighted = NConverters.ToBoolT(v));

    public static NProperty CreateHighlightedAnimationImages() => new NProperty(nameof(NProperties.HighlightedAnimationImages)).
        Property<UIImageView>((t, v) => NPatch.AssignListT(t.HighlightedAnimationImages, v));

    public static NProperty CreateHorizontalAlignment() => new NProperty(nameof(NProperties.HorizontalAlignment)).
        Property<UIControl>((t, v) => t.HorizontalAlignment = NConverters.ToEnumT<UIControlContentHorizontalAlignment>(v));

    public static NProperty CreateHorizontalAlignmentMode() => new NProperty(nameof(NProperties.HorizontalAlignmentMode)).
        Property<SKLabelNode>((t, v) => t.HorizontalAlignmentMode = NConverters.ToEnumT<SKLabelHorizontalAlignmentMode>(v));

    public static NProperty CreateHosted() => new NProperty(nameof(NProperties.Hosted)).
        Property<GKMatchmakerViewController>((t, v) => t.Hosted = NConverters.ToBoolT(v));

    public static NProperty CreateHostedPlayerDidAccept() => new NProperty(nameof(NProperties.HostedPlayerDidAccept)).
        Event<GKMatchmakerViewController>((s, a) => s.HostedPlayerDidAccept += a.EventHandler);

    public static NProperty CreateIdleTimerDisabled() => new NProperty(nameof(NProperties.IdleTimerDisabled)).
        Property<UIApplication>((t, v) => t.IdleTimerDisabled = NConverters.ToBoolT(v));

    public static NProperty CreateIgnoresSiblingOrder() => new NProperty(nameof(NProperties.IgnoresSiblingOrder)).
        Property<SKView>((t, v) => t.IgnoresSiblingOrder = NConverters.ToBoolT(v));

    public static NProperty CreateIndexPathsForSelectedRows() => new NProperty(nameof(NProperties.IndexPathsForSelectedRows)).
        Property<UITableView>((t, v) => NPatch.AssignListT(t.IndexPathsForSelectedRows, v));

    public static NProperty CreateIndexPathsForVisibleItems() => new NProperty(nameof(NProperties.IndexPathsForVisibleItems)).
        Property<UICollectionView>((t, v) => NPatch.AssignListT(t.IndexPathsForVisibleItems, v));

    public static NProperty CreateIndexPathsForVisibleRows() => new NProperty(nameof(NProperties.IndexPathsForVisibleRows)).
        Property<UITableView>((t, v) => NPatch.AssignListT(t.IndexPathsForVisibleRows, v));

    public static NProperty CreateIndicatorStyle() => new NProperty(nameof(NProperties.IndicatorStyle)).
        Property<UIScrollView>((t, v) => t.IndicatorStyle = NConverters.ToEnumT<UIScrollViewIndicatorStyle>(v));

    public static NProperty CreateInstallsStandardGestureForInteractiveMovement() => new NProperty(nameof(NProperties.InstallsStandardGestureForInteractiveMovement)).
        Property<UICollectionViewController>((t, v) => t.InstallsStandardGestureForInteractiveMovement = NConverters.ToBoolT(v));

    public static NProperty CreateIsAccessibilityElement() => new NProperty(nameof(NProperties.IsAccessibilityElement)).
        Property<UIView>((t, v) => t.IsAccessibilityElement = NConverters.ToBoolT(v));

    public static NProperty CreateItemPositioning() => new NProperty(nameof(NProperties.ItemPositioning)).
        Property<UITabBar>((t, v) => t.ItemPositioning = NConverters.ToEnumT<UITabBarItemPositioning>(v));

    public static NProperty CreateItems() => new NProperty(nameof(NProperties.Items)).
        Property<UINavigationBar>((t, v) => NPatch.AssignListT(t.Items, v)).
        Property<UIToolbar>((t, v) => NPatch.AssignListT(t.Items, v)).
        Property<UITabBar>((t, v) => NPatch.AssignListT(t.Items, v));

    public static NProperty CreateItemSelected() => new NProperty(nameof(NProperties.ItemSelected)).
        Event<UITabBar>((s, a) => s.ItemSelected += a.EventHandler);

    public static NProperty CreateItemsPicked() => new NProperty(nameof(NProperties.ItemsPicked)).
        Event<MPMediaPickerController>((s, a) => s.ItemsPicked += a.EventHandler);

    public static NProperty CreateJitteringEnabled() => new NProperty(nameof(NProperties.JitteringEnabled)).
        Property<SCNView>((t, v) => t.JitteringEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateKeyboardAppearance() => new NProperty(nameof(NProperties.KeyboardAppearance)).
        Property<UITextField>((t, v) => t.KeyboardAppearance = NConverters.ToEnumT<UIKeyboardAppearance>(v)).
        Property<UISearchBar>((t, v) => t.KeyboardAppearance = NConverters.ToEnumT<UIKeyboardAppearance>(v)).
        Property<UITextView>((t, v) => t.KeyboardAppearance = NConverters.ToEnumT<UIKeyboardAppearance>(v));

    public static NProperty CreateKeyboardDismissMode() => new NProperty(nameof(NProperties.KeyboardDismissMode)).
        Property<UIScrollView>((t, v) => t.KeyboardDismissMode = NConverters.ToEnumT<UIScrollViewKeyboardDismissMode>(v));

    public static NProperty CreateKeyboardDisplayRequiresUserAction() => new NProperty(nameof(NProperties.KeyboardDisplayRequiresUserAction)).
        Property<UIWebView>((t, v) => t.KeyboardDisplayRequiresUserAction = NConverters.ToBoolT(v));

    public static NProperty CreateKeyboardType() => new NProperty(nameof(NProperties.KeyboardType)).
        Property<UITextField>((t, v) => t.KeyboardType = NConverters.ToEnumT<UIKeyboardType>(v)).
        Property<UISearchBar>((t, v) => t.KeyboardType = NConverters.ToEnumT<UIKeyboardType>(v)).
        Property<UITextView>((t, v) => t.KeyboardType = NConverters.ToEnumT<UIKeyboardType>(v));

    public static NProperty CreateKeyCommands() => new NProperty(nameof(NProperties.KeyCommands)).
        Property<UIResponder>((t, v) => NPatch.AssignListT(t.KeyCommands, v));

    public static NProperty CreateLayoutGuides() => new NProperty(nameof(NProperties.LayoutGuides)).
        Property<UIView>((t, v) => NPatch.AssignListT(t.LayoutGuides, v));

    public static NProperty CreateLayoutMarginsRelativeArrangement() => new NProperty(nameof(NProperties.LayoutMarginsRelativeArrangement)).
        Property<UIStackView>((t, v) => t.LayoutMarginsRelativeArrangement = NConverters.ToBoolT(v));

    public static NProperty CreateLeaderboardCategory() => new NProperty(nameof(NProperties.LeaderboardCategory)).
        Property<GKGameCenterViewController>((t, v) => t.LeaderboardCategory = NConverters.ToStringT(v));

    public static NProperty CreateLeaderboardIdentifier() => new NProperty(nameof(NProperties.LeaderboardIdentifier)).
        Property<GKGameCenterViewController>((t, v) => t.LeaderboardIdentifier = NConverters.ToStringT(v));

    public static NProperty CreateLeaderboardTimeScope() => new NProperty(nameof(NProperties.LeaderboardTimeScope)).
        Property<GKGameCenterViewController>((t, v) => t.LeaderboardTimeScope = NConverters.ToEnumT<GKLeaderboardTimeScope>(v));

    public static NProperty CreateLeftViewMode() => new NProperty(nameof(NProperties.LeftViewMode)).
        Property<UITextField>((t, v) => t.LeftViewMode = NConverters.ToEnumT<UITextFieldViewMode>(v));

    public static NProperty CreateLineBreakMode() => new NProperty(nameof(NProperties.LineBreakMode)).
        Property<UIButton>((t, v) => t.LineBreakMode = NConverters.ToEnumT<UILineBreakMode>(v)).
        Property<UILabel>((t, v) => t.LineBreakMode = NConverters.ToEnumT<UILineBreakMode>(v));

    public static NProperty CreateLinecap() => new NProperty(nameof(NProperties.Linecap)).
        Property<MKOverlayPathView>((t, v) => t.Linecap = NConverters.ToEnumT<CGLineCap>(v));

    public static NProperty CreateLineCap() => new NProperty(nameof(NProperties.LineCap)).
        Property<SKShapeNode>((t, v) => t.LineCap = NConverters.ToEnumT<CGLineCap>(v));

    public static NProperty CreateLineDashPattern() => new NProperty(nameof(NProperties.LineDashPattern)).
        Property<MKOverlayPathView>((t, v) => NPatch.AssignListT(t.LineDashPattern, v));

    public static NProperty CreateLineJoin() => new NProperty(nameof(NProperties.LineJoin)).
        Property<SKShapeNode>((t, v) => t.LineJoin = NConverters.ToEnumT<CGLineJoin>(v)).
        Property<MKOverlayPathView>((t, v) => t.LineJoin = NConverters.ToEnumT<CGLineJoin>(v));

    public static NProperty CreateListButtonClicked() => new NProperty(nameof(NProperties.ListButtonClicked)).
        Event<UISearchBar>((s, a) => s.ListButtonClicked += a.EventHandler);

    public static NProperty CreateLoadError() => new NProperty(nameof(NProperties.LoadError)).
        Event<UIWebView>((s, a) => s.LoadError += a.EventHandler);

    public static NProperty CreateLoadFinished() => new NProperty(nameof(NProperties.LoadFinished)).
        Event<UIWebView>((s, a) => s.LoadFinished += a.EventHandler);

    public static NProperty CreateLoadingMapFailed() => new NProperty(nameof(NProperties.LoadingMapFailed)).
        Event<MKMapView>((s, a) => s.LoadingMapFailed += a.EventHandler);

    public static NProperty CreateLoadStarted() => new NProperty(nameof(NProperties.LoadStarted)).
        Event<UIWebView>((s, a) => s.LoadStarted += a.EventHandler);

    public static NProperty CreateLoops() => new NProperty(nameof(NProperties.Loops)).
        Property<SK3DNode>((t, v) => t.Loops = NConverters.ToBoolT(v)).
        Property<SCNView>((t, v) => t.Loops = NConverters.ToBoolT(v));

    public static NProperty CreateMapLoaded() => new NProperty(nameof(NProperties.MapLoaded)).
        Event<MKMapView>((s, a) => s.MapLoaded += a.EventHandler);

    public static NProperty CreateMapType() => new NProperty(nameof(NProperties.MapType)).
        Property<MKMapView>((t, v) => t.MapType = NConverters.ToEnumT<MKMapType>(v));

    public static NProperty CreateMaxValue() => new NProperty(nameof(NProperties.MaxValue)).
        Property<UISlider>((t, v) => t.MaxValue = NConverters.ToSingleT(v));

    public static NProperty CreateMediaPlaybackAllowsAirPlay() => new NProperty(nameof(NProperties.MediaPlaybackAllowsAirPlay)).
        Property<UIWebView>((t, v) => t.MediaPlaybackAllowsAirPlay = NConverters.ToBoolT(v));

    public static NProperty CreateMediaPlaybackRequiresUserAction() => new NProperty(nameof(NProperties.MediaPlaybackRequiresUserAction)).
        Property<UIWebView>((t, v) => t.MediaPlaybackRequiresUserAction = NConverters.ToBoolT(v));

    public static NProperty CreateMediaTypes() => new NProperty(nameof(NProperties.MediaTypes)).
        Property<UIImagePickerController>((t, v) => NPatch.AssignListT(t.MediaTypes, v));

    public static NProperty CreateMessage() => new NProperty(nameof(NProperties.Message)).
        Property<UIAlertView>((t, v) => t.Message = NConverters.ToStringT(v)).
        Property<ABUnknownPersonViewController>((t, v) => t.Message = NConverters.ToStringT(v)).
        Property<UIAlertController>((t, v) => t.Message = NConverters.ToStringT(v)).
        Property<CNContactViewController>((t, v) => t.Message = NConverters.ToStringT(v));

    public static NProperty CreateMinimumRadius() => new NProperty(nameof(NProperties.MinimumRadius)).
        Property<SKFieldNode>((t, v) => t.MinimumRadius = NConverters.ToSingleT(v));

    public static NProperty CreateMinValue() => new NProperty(nameof(NProperties.MinValue)).
        Property<UISlider>((t, v) => t.MinValue = NConverters.ToSingleT(v));

    public static NProperty CreateModalInPopover() => new NProperty(nameof(NProperties.ModalInPopover)).
        Property<UIViewController>((t, v) => t.ModalInPopover = NConverters.ToBoolT(v));

    public static NProperty CreateModalPresentationCapturesStatusBarAppearance() => new NProperty(nameof(NProperties.ModalPresentationCapturesStatusBarAppearance)).
        Property<UIViewController>((t, v) => t.ModalPresentationCapturesStatusBarAppearance = NConverters.ToBoolT(v));

    public static NProperty CreateModalPresentationStyle() => new NProperty(nameof(NProperties.ModalPresentationStyle)).
        Property<UIViewController>((t, v) => t.ModalPresentationStyle = NConverters.ToEnumT<UIModalPresentationStyle>(v));

    public static NProperty CreateModalTransitionStyle() => new NProperty(nameof(NProperties.ModalTransitionStyle)).
        Property<UIViewController>((t, v) => t.ModalTransitionStyle = NConverters.ToEnumT<UIModalTransitionStyle>(v));

    public static NProperty CreateMode() => new NProperty(nameof(NProperties.Mode)).
        Property<UIDatePicker>((t, v) => t.Mode = NConverters.ToEnumT<UIDatePickerMode>(v));

    public static NProperty CreateMomentary() => new NProperty(nameof(NProperties.Momentary)).
        Property<UISegmentedControl>((t, v) => t.Momentary = NConverters.ToBoolT(v));

    public static NProperty CreateMotionEffects() => new NProperty(nameof(NProperties.MotionEffects)).
        Property<UIView>((t, v) => NPatch.AssignListT(t.MotionEffects, v));

    public static NProperty CreateMultipleTouchEnabled() => new NProperty(nameof(NProperties.MultipleTouchEnabled)).
        Property<UIView>((t, v) => t.MultipleTouchEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateMuted() => new NProperty(nameof(NProperties.Muted)).
        Property<PHLivePhotoView>((t, v) => t.Muted = NConverters.ToBoolT(v));

    public static NProperty CreateName() => new NProperty(nameof(NProperties.Name)).
        Property<SKNode>((t, v) => t.Name = NConverters.ToStringT(v));

    public static NProperty CreateNavigationBarHidden() => new NProperty(nameof(NProperties.NavigationBarHidden)).
        Property<UINavigationController>((t, v) => t.NavigationBarHidden = NConverters.ToBoolT(v));

    public static NProperty CreateNetworkActivityIndicatorVisible() => new NProperty(nameof(NProperties.NetworkActivityIndicatorVisible)).
        Property<UIApplication>((t, v) => t.NetworkActivityIndicatorVisible = NConverters.ToBoolT(v));

    public static NProperty CreateNewPersonComplete() => new NProperty(nameof(NProperties.NewPersonComplete)).
        Event<ABNewPersonViewController>((s, a) => s.NewPersonComplete += a.EventHandler);

    public static NProperty CreateObscuresBackgroundDuringPresentation() => new NProperty(nameof(NProperties.ObscuresBackgroundDuringPresentation)).
        Property<UISearchController>((t, v) => t.ObscuresBackgroundDuringPresentation = NConverters.ToBoolT(v));

    public static NProperty CreateOn() => new NProperty(nameof(NProperties.On)).
        Property<UISwitch>((t, v) => t.On = NConverters.ToBoolT(v));

    public static NProperty CreateOnCustomizingViewControllers() => new NProperty(nameof(NProperties.OnCustomizingViewControllers)).
        Event<UITabBarController>((s, a) => s.OnCustomizingViewControllers += a.EventHandler);

    public static NProperty CreateOnEditingStarted() => new NProperty(nameof(NProperties.OnEditingStarted)).
        Event<UISearchBar>((s, a) => s.OnEditingStarted += a.EventHandler);

    public static NProperty CreateOnEditingStopped() => new NProperty(nameof(NProperties.OnEditingStopped)).
        Event<UISearchBar>((s, a) => s.OnEditingStopped += a.EventHandler);

    public static NProperty CreateOnEndCustomizingViewControllers() => new NProperty(nameof(NProperties.OnEndCustomizingViewControllers)).
        Event<UITabBarController>((s, a) => s.OnEndCustomizingViewControllers += a.EventHandler);

    public static NProperty CreateOpaque() => new NProperty(nameof(NProperties.Opaque)).
        Property<UIView>((t, v) => t.Opaque = NConverters.ToBoolT(v));

    public static NProperty CreateOverlays() => new NProperty(nameof(NProperties.Overlays)).
        Property<MKMapView>((t, v) => NPatch.AssignListT(t.Overlays, v));

    public static NProperty CreatePaginationBreakingMode() => new NProperty(nameof(NProperties.PaginationBreakingMode)).
        Property<UIWebView>((t, v) => t.PaginationBreakingMode = NConverters.ToEnumT<UIWebPaginationBreakingMode>(v));

    public static NProperty CreatePaginationMode() => new NProperty(nameof(NProperties.PaginationMode)).
        Property<UIWebView>((t, v) => t.PaginationMode = NConverters.ToEnumT<UIWebPaginationMode>(v));

    public static NProperty CreatePagingEnabled() => new NProperty(nameof(NProperties.PagingEnabled)).
        Property<UIScrollView>((t, v) => t.PagingEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateParticleBlendMode() => new NProperty(nameof(NProperties.ParticleBlendMode)).
        Property<SKEmitterNode>((t, v) => t.ParticleBlendMode = NConverters.ToEnumT<SKBlendMode>(v));

    public static NProperty CreateParticleRenderOrder() => new NProperty(nameof(NProperties.ParticleRenderOrder)).
        Property<SKEmitterNode>((t, v) => t.ParticleRenderOrder = NConverters.ToEnumT<SKParticleRenderOrder>(v));

    public static NProperty CreatePaused() => new NProperty(nameof(NProperties.Paused)).
        Property<SKNode>((t, v) => t.Paused = NConverters.ToBoolT(v)).
        Property<MTKView>((t, v) => t.Paused = NConverters.ToBoolT(v)).
        Property<SKView>((t, v) => t.Paused = NConverters.ToBoolT(v)).
        Property<GLKViewController>((t, v) => t.Paused = NConverters.ToBoolT(v));

    public static NProperty CreatePauseOnWillResignActive() => new NProperty(nameof(NProperties.PauseOnWillResignActive)).
        Property<GLKViewController>((t, v) => t.PauseOnWillResignActive = NConverters.ToBoolT(v));

    public static NProperty CreatePaymentAuthorizationViewControllerDidFinish() => new NProperty(nameof(NProperties.PaymentAuthorizationViewControllerDidFinish)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.PaymentAuthorizationViewControllerDidFinish += a.EventHandler);

    public static NProperty CreatePerformAction() => new NProperty(nameof(NProperties.PerformAction)).
        Event<ABPeoplePickerNavigationController>((s, a) => s.PerformAction += a.EventHandler);

    public static NProperty CreatePerformAction2() => new NProperty(nameof(NProperties.PerformAction2)).
        Event<ABPeoplePickerNavigationController>((s, a) => s.PerformAction2 += a.EventHandler);

    public static NProperty CreatePerformDefaultAction() => new NProperty(nameof(NProperties.PerformDefaultAction)).
        Event<ABPersonViewController>((s, a) => s.PerformDefaultAction += a.EventHandler).
        Event<ABUnknownPersonViewController>((s, a) => s.PerformDefaultAction += a.EventHandler);

    public static NProperty CreatePersonCreated() => new NProperty(nameof(NProperties.PersonCreated)).
        Event<ABUnknownPersonViewController>((s, a) => s.PersonCreated += a.EventHandler);

    public static NProperty CreatePinColor() => new NProperty(nameof(NProperties.PinColor)).
        Property<MKPinAnnotationView>((t, v) => t.PinColor = NConverters.ToEnumT<MKPinAnnotationColor>(v));

    public static NProperty CreatePitchEnabled() => new NProperty(nameof(NProperties.PitchEnabled)).
        Property<MKMapView>((t, v) => t.PitchEnabled = NConverters.ToBoolT(v));

    public static NProperty CreatePlaceholder() => new NProperty(nameof(NProperties.Placeholder)).
        Property<UITextField>((t, v) => t.Placeholder = NConverters.ToStringT(v)).
        Property<UISearchBar>((t, v) => t.Placeholder = NConverters.ToStringT(v)).
        Property<SLComposeServiceViewController>((t, v) => t.Placeholder = NConverters.ToStringT(v));

    public static NProperty CreatePlaying() => new NProperty(nameof(NProperties.Playing)).
        Property<SK3DNode>((t, v) => t.Playing = NConverters.ToBoolT(v)).
        Property<SCNView>((t, v) => t.Playing = NConverters.ToBoolT(v));

    public static NProperty CreatePositional() => new NProperty(nameof(NProperties.Positional)).
        Property<SKAudioNode>((t, v) => t.Positional = NConverters.ToBoolT(v));

    public static NProperty CreatePreferredDisplayMode() => new NProperty(nameof(NProperties.PreferredDisplayMode)).
        Property<UISplitViewController>((t, v) => t.PreferredDisplayMode = NConverters.ToEnumT<UISplitViewControllerDisplayMode>(v));

    public static NProperty CreatePresented() => new NProperty(nameof(NProperties.Presented)).
        Event<UIActionSheet>((s, a) => s.Presented += a.EventHandler).
        Event<UIAlertView>((s, a) => s.Presented += a.EventHandler);

    public static NProperty CreatePresentsWithGesture() => new NProperty(nameof(NProperties.PresentsWithGesture)).
        Property<UISplitViewController>((t, v) => t.PresentsWithGesture = NConverters.ToBoolT(v));

    public static NProperty CreatePresentsWithTransaction() => new NProperty(nameof(NProperties.PresentsWithTransaction)).
        Property<MTKView>((t, v) => t.PresentsWithTransaction = NConverters.ToBoolT(v));

    public static NProperty CreatePreservesSuperviewLayoutMargins() => new NProperty(nameof(NProperties.PreservesSuperviewLayoutMargins)).
        Property<UIView>((t, v) => t.PreservesSuperviewLayoutMargins = NConverters.ToBoolT(v));

    public static NProperty CreatePreviewActionItems() => new NProperty(nameof(NProperties.PreviewActionItems)).
        Property<UIViewController>((t, v) => NPatch.AssignListT(t.PreviewActionItems, v));

    public static NProperty CreatePrimaryLanguage() => new NProperty(nameof(NProperties.PrimaryLanguage)).
        Property<UIInputViewController>((t, v) => t.PrimaryLanguage = NConverters.ToStringT(v));

    public static NProperty CreateProgress() => new NProperty(nameof(NProperties.Progress)).
        Property<UIProgressView>((t, v) => t.Progress = NConverters.ToSingleT(v));

    public static NProperty CreatePrompt() => new NProperty(nameof(NProperties.Prompt)).
        Property<UISearchBar>((t, v) => t.Prompt = NConverters.ToStringT(v)).
        Property<MPMediaPickerController>((t, v) => t.Prompt = NConverters.ToStringT(v));

    public static NProperty CreateProvidesPresentationContextTransitionStyle() => new NProperty(nameof(NProperties.ProvidesPresentationContextTransitionStyle)).
        Property<UIViewController>((t, v) => t.ProvidesPresentationContextTransitionStyle = NConverters.ToBoolT(v));

    public static NProperty CreateReceivedAcceptFromHostedPlayer() => new NProperty(nameof(NProperties.ReceivedAcceptFromHostedPlayer)).
        Event<GKMatchmakerViewController>((s, a) => s.ReceivedAcceptFromHostedPlayer += a.EventHandler);

    public static NProperty CreateRecipients() => new NProperty(nameof(NProperties.Recipients)).
        Property<MFMessageComposeViewController>((t, v) => NPatch.AssignListT(t.Recipients, v));

    public static NProperty CreateRegionChanged() => new NProperty(nameof(NProperties.RegionChanged)).
        Event<MKMapView>((s, a) => s.RegionChanged += a.EventHandler);

    public static NProperty CreateRegionWillChange() => new NProperty(nameof(NProperties.RegionWillChange)).
        Event<MKMapView>((s, a) => s.RegionWillChange += a.EventHandler);

    public static NProperty CreateRemembersLastFocusedIndexPath() => new NProperty(nameof(NProperties.RemembersLastFocusedIndexPath)).
        Property<UICollectionView>((t, v) => t.RemembersLastFocusedIndexPath = NConverters.ToBoolT(v)).
        Property<UITableView>((t, v) => t.RemembersLastFocusedIndexPath = NConverters.ToBoolT(v));

    public static NProperty CreateRestorationIdentifier() => new NProperty(nameof(NProperties.RestorationIdentifier)).
        Property<UIView>((t, v) => t.RestorationIdentifier = NConverters.ToStringT(v)).
        Property<UIViewController>((t, v) => t.RestorationIdentifier = NConverters.ToStringT(v));

    public static NProperty CreateResumeOnDidBecomeActive() => new NProperty(nameof(NProperties.ResumeOnDidBecomeActive)).
        Property<GLKViewController>((t, v) => t.ResumeOnDidBecomeActive = NConverters.ToBoolT(v));

    public static NProperty CreateReturnKeyType() => new NProperty(nameof(NProperties.ReturnKeyType)).
        Property<UITextField>((t, v) => t.ReturnKeyType = NConverters.ToEnumT<UIReturnKeyType>(v)).
        Property<UISearchBar>((t, v) => t.ReturnKeyType = NConverters.ToEnumT<UIReturnKeyType>(v)).
        Property<UITextView>((t, v) => t.ReturnKeyType = NConverters.ToEnumT<UIReturnKeyType>(v));

    public static NProperty CreateReverseTitleShadowWhenHighlighted() => new NProperty(nameof(NProperties.ReverseTitleShadowWhenHighlighted)).
        Property<UIButton>((t, v) => t.ReverseTitleShadowWhenHighlighted = NConverters.ToBoolT(v));

    public static NProperty CreateRightViewMode() => new NProperty(nameof(NProperties.RightViewMode)).
        Property<UITextField>((t, v) => t.RightViewMode = NConverters.ToEnumT<UITextFieldViewMode>(v));

    public static NProperty CreateRotateEnabled() => new NProperty(nameof(NProperties.RotateEnabled)).
        Property<MKMapView>((t, v) => t.RotateEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateSaved() => new NProperty(nameof(NProperties.Saved)).
        Event<UIVideoEditorController>((s, a) => s.Saved += a.EventHandler);

    public static NProperty CreateScaleMode() => new NProperty(nameof(NProperties.ScaleMode)).
        Property<SKScene>((t, v) => t.ScaleMode = NConverters.ToEnumT<SKSceneScaleMode>(v));

    public static NProperty CreateScalesPageToFit() => new NProperty(nameof(NProperties.ScalesPageToFit)).
        Property<UIWebView>((t, v) => t.ScalesPageToFit = NConverters.ToBoolT(v));

    public static NProperty CreateScheduledLocalNotifications() => new NProperty(nameof(NProperties.ScheduledLocalNotifications)).
        Property<UIApplication>((t, v) => NPatch.AssignListT(t.ScheduledLocalNotifications, v));

    public static NProperty CreateScopeButtonTitles() => new NProperty(nameof(NProperties.ScopeButtonTitles)).
        Property<UISearchBar>((t, v) => NPatch.AssignListT(t.ScopeButtonTitles, v));

    public static NProperty CreateScrollAnimationEnded() => new NProperty(nameof(NProperties.ScrollAnimationEnded)).
        Event<UIScrollView>((s, a) => s.ScrollAnimationEnded += a.EventHandler);

    public static NProperty CreateScrolled() => new NProperty(nameof(NProperties.Scrolled)).
        Event<UIScrollView>((s, a) => s.Scrolled += a.EventHandler);

    public static NProperty CreateScrolledToTop() => new NProperty(nameof(NProperties.ScrolledToTop)).
        Event<UIScrollView>((s, a) => s.ScrolledToTop += a.EventHandler);

    public static NProperty CreateScrollEnabled() => new NProperty(nameof(NProperties.ScrollEnabled)).
        Property<MKMapView>((t, v) => t.ScrollEnabled = NConverters.ToBoolT(v)).
        Property<UIScrollView>((t, v) => t.ScrollEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateScrollsToTop() => new NProperty(nameof(NProperties.ScrollsToTop)).
        Property<UIScrollView>((t, v) => t.ScrollsToTop = NConverters.ToBoolT(v));

    public static NProperty CreateSearchBarStyle() => new NProperty(nameof(NProperties.SearchBarStyle)).
        Property<UISearchBar>((t, v) => t.SearchBarStyle = NConverters.ToEnumT<UISearchBarStyle>(v));

    public static NProperty CreateSearchButtonClicked() => new NProperty(nameof(NProperties.SearchButtonClicked)).
        Event<UISearchBar>((s, a) => s.SearchButtonClicked += a.EventHandler);

    public static NProperty CreateSearchResultsButtonSelected() => new NProperty(nameof(NProperties.SearchResultsButtonSelected)).
        Property<UISearchBar>((t, v) => t.SearchResultsButtonSelected = NConverters.ToBoolT(v));

    public static NProperty CreateSecureTextEntry() => new NProperty(nameof(NProperties.SecureTextEntry)).
        Property<UITextField>((t, v) => t.SecureTextEntry = NConverters.ToBoolT(v)).
        Property<UISearchBar>((t, v) => t.SecureTextEntry = NConverters.ToBoolT(v)).
        Property<UITextView>((t, v) => t.SecureTextEntry = NConverters.ToBoolT(v));

    public static NProperty CreateSelectable() => new NProperty(nameof(NProperties.Selectable)).
        Property<UITextView>((t, v) => t.Selectable = NConverters.ToBoolT(v));

    public static NProperty CreateSelected() => new NProperty(nameof(NProperties.Selected)).
        Property<UIControl>((t, v) => t.Selected = NConverters.ToBoolT(v)).
        Property<UITableViewCell>((t, v) => t.Selected = NConverters.ToBoolT(v)).
        Property<UICollectionViewCell>((t, v) => t.Selected = NConverters.ToBoolT(v)).
        Property<MKAnnotationView>((t, v) => t.Selected = NConverters.ToBoolT(v));

    public static NProperty CreateSelectedAnnotations() => new NProperty(nameof(NProperties.SelectedAnnotations)).
        Property<MKMapView>((t, v) => NPatch.AssignListT(t.SelectedAnnotations, v));

    public static NProperty CreateSelectedScopeButtonIndexChanged() => new NProperty(nameof(NProperties.SelectedScopeButtonIndexChanged)).
        Event<UISearchBar>((s, a) => s.SelectedScopeButtonIndexChanged += a.EventHandler);

    public static NProperty CreateSelectionChanged() => new NProperty(nameof(NProperties.SelectionChanged)).
        Event<UITextView>((s, a) => s.SelectionChanged += a.EventHandler).
        Event<EKCalendarChooser>((s, a) => s.SelectionChanged += a.EventHandler);

    public static NProperty CreateSelectionStyle() => new NProperty(nameof(NProperties.SelectionStyle)).
        Property<UITableViewCell>((t, v) => t.SelectionStyle = NConverters.ToEnumT<UITableViewCellSelectionStyle>(v)).
        Property<EKCalendarChooser>((t, v) => t.SelectionStyle = NConverters.ToEnumT<EKCalendarChooserSelectionStyle>(v));

    public static NProperty CreateSelectPerson() => new NProperty(nameof(NProperties.SelectPerson)).
        Event<ABPeoplePickerNavigationController>((s, a) => s.SelectPerson += a.EventHandler);

    public static NProperty CreateSelectPerson2() => new NProperty(nameof(NProperties.SelectPerson2)).
        Event<ABPeoplePickerNavigationController>((s, a) => s.SelectPerson2 += a.EventHandler);

    public static NProperty CreateSemanticContentAttribute() => new NProperty(nameof(NProperties.SemanticContentAttribute)).
        Property<UIView>((t, v) => t.SemanticContentAttribute = NConverters.ToEnumT<UISemanticContentAttribute>(v));

    public static NProperty CreateSeparatorStyle() => new NProperty(nameof(NProperties.SeparatorStyle)).
        Property<UITableView>((t, v) => t.SeparatorStyle = NConverters.ToEnumT<UITableViewCellSeparatorStyle>(v));

    public static NProperty CreateShortcutItems() => new NProperty(nameof(NProperties.ShortcutItems)).
        Property<UIApplication>((t, v) => NPatch.AssignListT(t.ShortcutItems, v));

    public static NProperty CreateShouldCenterFilter() => new NProperty(nameof(NProperties.ShouldCenterFilter)).
        Property<SKEffectNode>((t, v) => t.ShouldCenterFilter = NConverters.ToBoolT(v));

    public static NProperty CreateShouldCullNonVisibleNodes() => new NProperty(nameof(NProperties.ShouldCullNonVisibleNodes)).
        Property<SKView>((t, v) => t.ShouldCullNonVisibleNodes = NConverters.ToBoolT(v));

    public static NProperty CreateShouldEnableEffects() => new NProperty(nameof(NProperties.ShouldEnableEffects)).
        Property<SKEffectNode>((t, v) => t.ShouldEnableEffects = NConverters.ToBoolT(v));

    public static NProperty CreateShouldGroupAccessibilityChildren() => new NProperty(nameof(NProperties.ShouldGroupAccessibilityChildren)).
        Property<UIView>((t, v) => t.ShouldGroupAccessibilityChildren = NConverters.ToBoolT(v));

    public static NProperty CreateShouldIndentWhileEditing() => new NProperty(nameof(NProperties.ShouldIndentWhileEditing)).
        Property<UITableViewCell>((t, v) => t.ShouldIndentWhileEditing = NConverters.ToBoolT(v));

    public static NProperty CreateShouldRasterize() => new NProperty(nameof(NProperties.ShouldRasterize)).
        Property<SKEffectNode>((t, v) => t.ShouldRasterize = NConverters.ToBoolT(v));

    public static NProperty CreateShouldShowLinkedContacts() => new NProperty(nameof(NProperties.ShouldShowLinkedContacts)).
        Property<CNContactViewController>((t, v) => t.ShouldShowLinkedContacts = NConverters.ToBoolT(v));

    public static NProperty CreateShouldShowLinkedPeople() => new NProperty(nameof(NProperties.ShouldShowLinkedPeople)).
        Property<ABPersonViewController>((t, v) => t.ShouldShowLinkedPeople = NConverters.ToBoolT(v));

    public static NProperty CreateShowExistingMatches() => new NProperty(nameof(NProperties.ShowExistingMatches)).
        Property<GKTurnBasedMatchmakerViewController>((t, v) => t.ShowExistingMatches = NConverters.ToBoolT(v));

    public static NProperty CreateShowingAppNames() => new NProperty(nameof(NProperties.ShowingAppNames)).
        Property<CAInterAppAudioSwitcherView>((t, v) => t.ShowingAppNames = NConverters.ToBoolT(v));

    public static NProperty CreateShowingDeleteConfirmation() => new NProperty(nameof(NProperties.ShowingDeleteConfirmation)).
        Property<UITableViewCell>((t, v) => t.ShowingDeleteConfirmation = NConverters.ToBoolT(v));

    public static NProperty CreateShowsBookmarkButton() => new NProperty(nameof(NProperties.ShowsBookmarkButton)).
        Property<UISearchBar>((t, v) => t.ShowsBookmarkButton = NConverters.ToBoolT(v));

    public static NProperty CreateShowsBuildings() => new NProperty(nameof(NProperties.ShowsBuildings)).
        Property<MKMapView>((t, v) => t.ShowsBuildings = NConverters.ToBoolT(v));

    public static NProperty CreateShowsCameraControls() => new NProperty(nameof(NProperties.ShowsCameraControls)).
        Property<UIImagePickerController>((t, v) => t.ShowsCameraControls = NConverters.ToBoolT(v));

    public static NProperty CreateShowsCancelButton() => new NProperty(nameof(NProperties.ShowsCancelButton)).
        Property<UISearchBar>((t, v) => t.ShowsCancelButton = NConverters.ToBoolT(v)).
        Property<EKCalendarChooser>((t, v) => t.ShowsCancelButton = NConverters.ToBoolT(v));

    public static NProperty CreateShowsCloudItems() => new NProperty(nameof(NProperties.ShowsCloudItems)).
        Property<MPMediaPickerController>((t, v) => t.ShowsCloudItems = NConverters.ToBoolT(v));

    public static NProperty CreateShowsCompass() => new NProperty(nameof(NProperties.ShowsCompass)).
        Property<MKMapView>((t, v) => t.ShowsCompass = NConverters.ToBoolT(v));

    public static NProperty CreateShowsDoneButton() => new NProperty(nameof(NProperties.ShowsDoneButton)).
        Property<EKCalendarChooser>((t, v) => t.ShowsDoneButton = NConverters.ToBoolT(v));

    public static NProperty CreateShowsDrawCount() => new NProperty(nameof(NProperties.ShowsDrawCount)).
        Property<SKView>((t, v) => t.ShowsDrawCount = NConverters.ToBoolT(v));

    public static NProperty CreateShowSelectionIndicator() => new NProperty(nameof(NProperties.ShowSelectionIndicator)).
        Property<UIPickerView>((t, v) => t.ShowSelectionIndicator = NConverters.ToBoolT(v));

    public static NProperty CreateShowsFields() => new NProperty(nameof(NProperties.ShowsFields)).
        Property<SKView>((t, v) => t.ShowsFields = NConverters.ToBoolT(v));

    public static NProperty CreateShowsFPS() => new NProperty(nameof(NProperties.ShowsFPS)).
        Property<SKView>((t, v) => t.ShowsFPS = NConverters.ToBoolT(v));

    public static NProperty CreateShowsHorizontalScrollIndicator() => new NProperty(nameof(NProperties.ShowsHorizontalScrollIndicator)).
        Property<UIScrollView>((t, v) => t.ShowsHorizontalScrollIndicator = NConverters.ToBoolT(v));

    public static NProperty CreateShowsItemsWithProtectedAssets() => new NProperty(nameof(NProperties.ShowsItemsWithProtectedAssets)).
        Property<MPMediaPickerController>((t, v) => t.ShowsItemsWithProtectedAssets = NConverters.ToBoolT(v));

    public static NProperty CreateShowsNodeCount() => new NProperty(nameof(NProperties.ShowsNodeCount)).
        Property<SKView>((t, v) => t.ShowsNodeCount = NConverters.ToBoolT(v));

    public static NProperty CreateShowsPhysics() => new NProperty(nameof(NProperties.ShowsPhysics)).
        Property<SKView>((t, v) => t.ShowsPhysics = NConverters.ToBoolT(v));

    public static NProperty CreateShowsPlaybackControls() => new NProperty(nameof(NProperties.ShowsPlaybackControls)).
        Property<AVPlayerViewController>((t, v) => t.ShowsPlaybackControls = NConverters.ToBoolT(v));

    public static NProperty CreateShowsPointsOfInterest() => new NProperty(nameof(NProperties.ShowsPointsOfInterest)).
        Property<MKMapView>((t, v) => t.ShowsPointsOfInterest = NConverters.ToBoolT(v));

    public static NProperty CreateShowsQuadCount() => new NProperty(nameof(NProperties.ShowsQuadCount)).
        Property<SKView>((t, v) => t.ShowsQuadCount = NConverters.ToBoolT(v));

    public static NProperty CreateShowsReorderControl() => new NProperty(nameof(NProperties.ShowsReorderControl)).
        Property<UITableViewCell>((t, v) => t.ShowsReorderControl = NConverters.ToBoolT(v));

    public static NProperty CreateShowsRouteButton() => new NProperty(nameof(NProperties.ShowsRouteButton)).
        Property<MPVolumeView>((t, v) => t.ShowsRouteButton = NConverters.ToBoolT(v));

    public static NProperty CreateShowsScale() => new NProperty(nameof(NProperties.ShowsScale)).
        Property<MKMapView>((t, v) => t.ShowsScale = NConverters.ToBoolT(v));

    public static NProperty CreateShowsScopeBar() => new NProperty(nameof(NProperties.ShowsScopeBar)).
        Property<UISearchBar>((t, v) => t.ShowsScopeBar = NConverters.ToBoolT(v));

    public static NProperty CreateShowsSearchResultsButton() => new NProperty(nameof(NProperties.ShowsSearchResultsButton)).
        Property<UISearchBar>((t, v) => t.ShowsSearchResultsButton = NConverters.ToBoolT(v));

    public static NProperty CreateShowsStatistics() => new NProperty(nameof(NProperties.ShowsStatistics)).
        Property<SCNView>((t, v) => t.ShowsStatistics = NConverters.ToBoolT(v));

    public static NProperty CreateShowsTouchWhenHighlighted() => new NProperty(nameof(NProperties.ShowsTouchWhenHighlighted)).
        Property<UIButton>((t, v) => t.ShowsTouchWhenHighlighted = NConverters.ToBoolT(v));

    public static NProperty CreateShowsTraffic() => new NProperty(nameof(NProperties.ShowsTraffic)).
        Property<MKMapView>((t, v) => t.ShowsTraffic = NConverters.ToBoolT(v));

    public static NProperty CreateShowsUserLocation() => new NProperty(nameof(NProperties.ShowsUserLocation)).
        Property<MKMapView>((t, v) => t.ShowsUserLocation = NConverters.ToBoolT(v));

    public static NProperty CreateShowsVerticalScrollIndicator() => new NProperty(nameof(NProperties.ShowsVerticalScrollIndicator)).
        Property<UIScrollView>((t, v) => t.ShowsVerticalScrollIndicator = NConverters.ToBoolT(v));

    public static NProperty CreateShowsVolumeSlider() => new NProperty(nameof(NProperties.ShowsVolumeSlider)).
        Property<MPVolumeView>((t, v) => t.ShowsVolumeSlider = NConverters.ToBoolT(v));

    public static NProperty CreateSmoothness() => new NProperty(nameof(NProperties.Smoothness)).
        Property<SKFieldNode>((t, v) => t.Smoothness = NConverters.ToSingleT(v));

    public static NProperty CreateSourceType() => new NProperty(nameof(NProperties.SourceType)).
        Property<UIImagePickerController>((t, v) => t.SourceType = NConverters.ToEnumT<UIImagePickerControllerSourceType>(v));

    public static NProperty CreateSpellCheckingType() => new NProperty(nameof(NProperties.SpellCheckingType)).
        Property<UITextField>((t, v) => t.SpellCheckingType = NConverters.ToEnumT<UITextSpellCheckingType>(v)).
        Property<UISearchBar>((t, v) => t.SpellCheckingType = NConverters.ToEnumT<UITextSpellCheckingType>(v)).
        Property<UITextView>((t, v) => t.SpellCheckingType = NConverters.ToEnumT<UITextSpellCheckingType>(v));

    public static NProperty CreateStarted() => new NProperty(nameof(NProperties.Started)).
        Event<UITextField>((s, a) => s.Started += a.EventHandler).
        Event<UITextView>((s, a) => s.Started += a.EventHandler);

    public static NProperty CreateStatusBarHidden() => new NProperty(nameof(NProperties.StatusBarHidden)).
        Property<UIApplication>((t, v) => t.StatusBarHidden = NConverters.ToBoolT(v));

    public static NProperty CreateStatusBarOrientation() => new NProperty(nameof(NProperties.StatusBarOrientation)).
        Property<UIApplication>((t, v) => t.StatusBarOrientation = NConverters.ToEnumT<UIInterfaceOrientation>(v));

    public static NProperty CreateStatusBarStyle() => new NProperty(nameof(NProperties.StatusBarStyle)).
        Property<UIApplication>((t, v) => t.StatusBarStyle = NConverters.ToEnumT<UIStatusBarStyle>(v));

    public static NProperty CreateStrength() => new NProperty(nameof(NProperties.Strength)).
        Property<SKFieldNode>((t, v) => t.Strength = NConverters.ToSingleT(v));

    public static NProperty CreateStyle() => new NProperty(nameof(NProperties.Style)).
        Property<UIActionSheet>((t, v) => t.Style = NConverters.ToEnumT<UIActionSheetStyle>(v)).
        Property<PKAddPassButton>((t, v) => t.Style = NConverters.ToEnumT<PKAddPassButtonStyle>(v)).
        Property<UIProgressView>((t, v) => t.Style = NConverters.ToEnumT<UIProgressViewStyle>(v));

    public static NProperty CreateSubject() => new NProperty(nameof(NProperties.Subject)).
        Property<MFMessageComposeViewController>((t, v) => t.Subject = NConverters.ToStringT(v));

    public static NProperty CreateSubviews() => new NProperty(nameof(NProperties.Subviews)).
        Property<UIView>((t, v) => NPatch.AssignListT(t.Subviews, v));

    public static NProperty CreateSuppressesIncrementalRendering() => new NProperty(nameof(NProperties.SuppressesIncrementalRendering)).
        Property<UIWebView>((t, v) => t.SuppressesIncrementalRendering = NConverters.ToBoolT(v));

    public static NProperty CreateText() => new NProperty(nameof(NProperties.Text)).
        Property<SKLabelNode>((t, v) => t.Text = NConverters.ToStringT(v)).
        Property<UITextField>((t, v) => t.Text = NConverters.ToStringT(v)).
        Property<UISearchBar>((t, v) => t.Text = NConverters.ToStringT(v)).
        Property<UILabel>((t, v) => t.Text = NConverters.ToStringT(v)).
        Property<UITextView>((t, v) => t.Text = NConverters.ToStringT(v));

    public static NProperty CreateTextAlignment() => new NProperty(nameof(NProperties.TextAlignment)).
        Property<UITextField>((t, v) => t.TextAlignment = NConverters.ToEnumT<UITextAlignment>(v)).
        Property<UILabel>((t, v) => t.TextAlignment = NConverters.ToEnumT<UITextAlignment>(v)).
        Property<UITextView>((t, v) => t.TextAlignment = NConverters.ToEnumT<UITextAlignment>(v));

    public static NProperty CreateTextChanged() => new NProperty(nameof(NProperties.TextChanged)).
        Event<UISearchBar>((s, a) => s.TextChanged += a.EventHandler);

    public static NProperty CreateTextFields() => new NProperty(nameof(NProperties.TextFields)).
        Property<UIAlertController>((t, v) => NPatch.AssignListT(t.TextFields, v));

    public static NProperty CreateTimeScope() => new NProperty(nameof(NProperties.TimeScope)).
        Property<GKLeaderboardViewController>((t, v) => t.TimeScope = NConverters.ToEnumT<GKLeaderboardTimeScope>(v));

    public static NProperty CreateTintAdjustmentMode() => new NProperty(nameof(NProperties.TintAdjustmentMode)).
        Property<UIView>((t, v) => t.TintAdjustmentMode = NConverters.ToEnumT<UIViewTintAdjustmentMode>(v));

    public static NProperty CreateTitle() => new NProperty(nameof(NProperties.Title)).
        Property<UIActionSheet>((t, v) => t.Title = NConverters.ToStringT(v)).
        Property<UIAlertView>((t, v) => t.Title = NConverters.ToStringT(v)).
        Property<UIViewController>((t, v) => t.Title = NConverters.ToStringT(v)).
        Property<UIAlertController>((t, v) => t.Title = NConverters.ToStringT(v));

    public static NProperty CreateToolbarHidden() => new NProperty(nameof(NProperties.ToolbarHidden)).
        Property<UINavigationController>((t, v) => t.ToolbarHidden = NConverters.ToBoolT(v));

    public static NProperty CreateToolbarItems() => new NProperty(nameof(NProperties.ToolbarItems)).
        Property<UIViewController>((t, v) => NPatch.AssignListT(t.ToolbarItems, v));

    public static NProperty CreateTouchCancel() => new NProperty(nameof(NProperties.TouchCancel)).
        Event<UIControl>((s, a) => s.TouchCancel += a.EventHandler);

    public static NProperty CreateTouchDown() => new NProperty(nameof(NProperties.TouchDown)).
        Event<UIControl>((s, a) => s.TouchDown += a.EventHandler);

    public static NProperty CreateTouchDownRepeat() => new NProperty(nameof(NProperties.TouchDownRepeat)).
        Event<UIControl>((s, a) => s.TouchDownRepeat += a.EventHandler);

    public static NProperty CreateTouchDragEnter() => new NProperty(nameof(NProperties.TouchDragEnter)).
        Event<UIControl>((s, a) => s.TouchDragEnter += a.EventHandler);

    public static NProperty CreateTouchDragExit() => new NProperty(nameof(NProperties.TouchDragExit)).
        Event<UIControl>((s, a) => s.TouchDragExit += a.EventHandler);

    public static NProperty CreateTouchDragInside() => new NProperty(nameof(NProperties.TouchDragInside)).
        Event<UIControl>((s, a) => s.TouchDragInside += a.EventHandler);

    public static NProperty CreateTouchDragOutside() => new NProperty(nameof(NProperties.TouchDragOutside)).
        Event<UIControl>((s, a) => s.TouchDragOutside += a.EventHandler);

    public static NProperty CreateTouchUpInside() => new NProperty(nameof(NProperties.TouchUpInside)).
        Event<UIControl>((s, a) => s.TouchUpInside += a.EventHandler);

    public static NProperty CreateTouchUpOutside() => new NProperty(nameof(NProperties.TouchUpOutside)).
        Event<UIControl>((s, a) => s.TouchUpOutside += a.EventHandler);

    public static NProperty CreateTranslatesAutoresizingMaskIntoConstraints() => new NProperty(nameof(NProperties.TranslatesAutoresizingMaskIntoConstraints)).
        Property<UIView>((t, v) => t.TranslatesAutoresizingMaskIntoConstraints = NConverters.ToBoolT(v));

    public static NProperty CreateTranslucent() => new NProperty(nameof(NProperties.Translucent)).
        Property<UINavigationBar>((t, v) => t.Translucent = NConverters.ToBoolT(v)).
        Property<UISearchBar>((t, v) => t.Translucent = NConverters.ToBoolT(v)).
        Property<UIToolbar>((t, v) => t.Translucent = NConverters.ToBoolT(v)).
        Property<UITabBar>((t, v) => t.Translucent = NConverters.ToBoolT(v));

    public static NProperty CreateUseLayoutToLayoutNavigationTransitions() => new NProperty(nameof(NProperties.UseLayoutToLayoutNavigationTransitions)).
        Property<UICollectionViewController>((t, v) => t.UseLayoutToLayoutNavigationTransitions = NConverters.ToBoolT(v));

    public static NProperty CreateUserCancelled() => new NProperty(nameof(NProperties.UserCancelled)).
        Event<UIVideoEditorController>((s, a) => s.UserCancelled += a.EventHandler);

    public static NProperty CreateUserInteractionEnabled() => new NProperty(nameof(NProperties.UserInteractionEnabled)).
        Property<SKNode>((t, v) => t.UserInteractionEnabled = NConverters.ToBoolT(v)).
        Property<UIView>((t, v) => t.UserInteractionEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateUserTrackingMode() => new NProperty(nameof(NProperties.UserTrackingMode)).
        Property<MKMapView>((t, v) => t.UserTrackingMode = NConverters.ToEnumT<MKUserTrackingMode>(v));

    public static NProperty CreateValidTypes() => new NProperty(nameof(NProperties.ValidTypes)).
        Property<UIDocumentPickerExtensionViewController>((t, v) => NPatch.AssignListT(t.ValidTypes, v));

    public static NProperty CreateValue() => new NProperty(nameof(NProperties.Value)).
        Property<UISlider>((t, v) => t.Value = NConverters.ToSingleT(v));

    public static NProperty CreateValueChanged() => new NProperty(nameof(NProperties.ValueChanged)).
        Event<UIControl>((s, a) => s.ValueChanged += a.EventHandler);

    public static NProperty CreateVerticalAlignment() => new NProperty(nameof(NProperties.VerticalAlignment)).
        Property<UIControl>((t, v) => t.VerticalAlignment = NConverters.ToEnumT<UIControlContentVerticalAlignment>(v));

    public static NProperty CreateVerticalAlignmentMode() => new NProperty(nameof(NProperties.VerticalAlignmentMode)).
        Property<SKLabelNode>((t, v) => t.VerticalAlignmentMode = NConverters.ToEnumT<SKLabelVerticalAlignmentMode>(v));

    public static NProperty CreateVideoGravity() => new NProperty(nameof(NProperties.VideoGravity)).
        Property<AVPlayerViewController>((t, v) => t.VideoGravity = NConverters.ToEnumT<AVLayerVideoGravity>(v));

    public static NProperty CreateVideoPath() => new NProperty(nameof(NProperties.VideoPath)).
        Property<UIVideoEditorController>((t, v) => t.VideoPath = NConverters.ToStringT(v));

    public static NProperty CreateVideoQuality() => new NProperty(nameof(NProperties.VideoQuality)).
        Property<UIImagePickerController>((t, v) => t.VideoQuality = NConverters.ToEnumT<UIImagePickerControllerQualityType>(v)).
        Property<UIVideoEditorController>((t, v) => t.VideoQuality = NConverters.ToEnumT<UIImagePickerControllerQualityType>(v));

    public static NProperty CreateViewControllers() => new NProperty(nameof(NProperties.ViewControllers)).
        Property<UINavigationController>((t, v) => NPatch.AssignListT(t.ViewControllers, v)).
        Property<UIPageViewController>((t, v) => NPatch.AssignListT(t.ViewControllers, v)).
        Property<UITabBarController>((t, v) => NPatch.AssignListT(t.ViewControllers, v)).
        Property<UISplitViewController>((t, v) => NPatch.AssignListT(t.ViewControllers, v));

    public static NProperty CreateViewControllerSelected() => new NProperty(nameof(NProperties.ViewControllerSelected)).
        Event<UITabBarController>((s, a) => s.ViewControllerSelected += a.EventHandler);

    public static NProperty CreateViewState() => new NProperty(nameof(NProperties.ViewState)).
        Property<GKGameCenterViewController>((t, v) => t.ViewState = NConverters.ToEnumT<GKGameCenterViewControllerState>(v));

    public static NProperty CreateVisibleCells() => new NProperty(nameof(NProperties.VisibleCells)).
        Property<UICollectionView>((t, v) => NPatch.AssignListT(t.VisibleCells, v)).
        Property<UITableView>((t, v) => NPatch.AssignListT(t.VisibleCells, v));

    public static NProperty CreateWantsFullScreenLayout() => new NProperty(nameof(NProperties.WantsFullScreenLayout)).
        Property<UIViewController>((t, v) => t.WantsFullScreenLayout = NConverters.ToBoolT(v));

    public static NProperty CreateWasCancelled() => new NProperty(nameof(NProperties.WasCancelled)).
        Event<UIDocumentMenuViewController>((s, a) => s.WasCancelled += a.EventHandler).
        Event<UIDocumentPickerViewController>((s, a) => s.WasCancelled += a.EventHandler).
        Event<GKMatchmakerViewController>((s, a) => s.WasCancelled += a.EventHandler);

    public static NProperty CreateWillAuthorizePayment() => new NProperty(nameof(NProperties.WillAuthorizePayment)).
        Event<PKPaymentAuthorizationViewController>((s, a) => s.WillAuthorizePayment += a.EventHandler);

    public static NProperty CreateWillBeginCustomizingItems() => new NProperty(nameof(NProperties.WillBeginCustomizingItems)).
        Event<UITabBar>((s, a) => s.WillBeginCustomizingItems += a.EventHandler);

    public static NProperty CreateWillChangeDisplayMode() => new NProperty(nameof(NProperties.WillChangeDisplayMode)).
        Event<UISplitViewController>((s, a) => s.WillChangeDisplayMode += a.EventHandler);

    public static NProperty CreateWillDismiss() => new NProperty(nameof(NProperties.WillDismiss)).
        Event<UIActionSheet>((s, a) => s.WillDismiss += a.EventHandler).
        Event<UIAlertView>((s, a) => s.WillDismiss += a.EventHandler).
        Event<QLPreviewController>((s, a) => s.WillDismiss += a.EventHandler);

    public static NProperty CreateWillEndCustomizingItems() => new NProperty(nameof(NProperties.WillEndCustomizingItems)).
        Event<UITabBar>((s, a) => s.WillEndCustomizingItems += a.EventHandler);

    public static NProperty CreateWillEndDragging() => new NProperty(nameof(NProperties.WillEndDragging)).
        Event<UIScrollView>((s, a) => s.WillEndDragging += a.EventHandler);

    public static NProperty CreateWillHideViewController() => new NProperty(nameof(NProperties.WillHideViewController)).
        Event<UISplitViewController>((s, a) => s.WillHideViewController += a.EventHandler);

    public static NProperty CreateWillLoad() => new NProperty(nameof(NProperties.WillLoad)).
        Event<ADBannerView>((s, a) => s.WillLoad += a.EventHandler);

    public static NProperty CreateWillPresent() => new NProperty(nameof(NProperties.WillPresent)).
        Event<UIActionSheet>((s, a) => s.WillPresent += a.EventHandler).
        Event<UIAlertView>((s, a) => s.WillPresent += a.EventHandler);

    public static NProperty CreateWillPresentViewController() => new NProperty(nameof(NProperties.WillPresentViewController)).
        Event<UISplitViewController>((s, a) => s.WillPresentViewController += a.EventHandler);

    public static NProperty CreateWillShowViewController() => new NProperty(nameof(NProperties.WillShowViewController)).
        Event<UISplitViewController>((s, a) => s.WillShowViewController += a.EventHandler);

    public static NProperty CreateWillStartLoadingMap() => new NProperty(nameof(NProperties.WillStartLoadingMap)).
        Event<MKMapView>((s, a) => s.WillStartLoadingMap += a.EventHandler);

    public static NProperty CreateWillStartLocatingUser() => new NProperty(nameof(NProperties.WillStartLocatingUser)).
        Event<MKMapView>((s, a) => s.WillStartLocatingUser += a.EventHandler);

    public static NProperty CreateWillStartRenderingMap() => new NProperty(nameof(NProperties.WillStartRenderingMap)).
        Event<MKMapView>((s, a) => s.WillStartRenderingMap += a.EventHandler);

    public static NProperty CreateWillTransition() => new NProperty(nameof(NProperties.WillTransition)).
        Event<UIPageViewController>((s, a) => s.WillTransition += a.EventHandler);

    public static NProperty CreateWindows() => new NProperty(nameof(NProperties.Windows)).
        Property<UIApplication>((t, v) => NPatch.AssignListT(t.Windows, v));

    public static NProperty CreateWraps() => new NProperty(nameof(NProperties.Wraps)).
        Property<UIStepper>((t, v) => t.Wraps = NConverters.ToBoolT(v));

    public static NProperty CreateZoomEnabled() => new NProperty(nameof(NProperties.ZoomEnabled)).
        Property<MKMapView>((t, v) => t.ZoomEnabled = NConverters.ToBoolT(v));

    public static NProperty CreateZoomingEnded() => new NProperty(nameof(NProperties.ZoomingEnded)).
        Event<UIScrollView>((s, a) => s.ZoomingEnded += a.EventHandler);

    public static NProperty CreateZoomingStarted() => new NProperty(nameof(NProperties.ZoomingStarted)).
        Event<UIScrollView>((s, a) => s.ZoomingStarted += a.EventHandler);

  }
}
