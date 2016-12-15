using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.MMDrawerController
{
	// @interface MMDrawerBarButtonItem : UIBarButtonItem
	[BaseType(typeof(UIBarButtonItem))]
	interface MMDrawerBarButtonItem
	{
		// -(instancetype)initWithTarget:(id)target action:(SEL)action;
		[Export("initWithTarget:action:")]
		IntPtr Constructor(NSObject target, Selector action);

		// -(UIColor *)menuButtonColorForState:(UIControlState)state __attribute__((deprecated("Use tintColor instead")));
		[Export("menuButtonColorForState:")]
		UIColor MenuButtonColorForState(UIControlState state);

		// -(void)setMenuButtonColor:(UIColor *)color forState:(UIControlState)state __attribute__((deprecated("Use tintColor instead")));
		[Export("setMenuButtonColor:forState:")]
		void SetMenuButtonColor(UIColor color, UIControlState state);

		// -(UIColor *)shadowColorForState:(UIControlState)state __attribute__((deprecated("Shadow is no longer supported")));
		[Export("shadowColorForState:")]
		UIColor ShadowColorForState(UIControlState state);

		// -(void)setShadowColor:(UIColor *)color forState:(UIControlState)state __attribute__((deprecated("Shadow is no longer supported")));
		[Export("setShadowColor:forState:")]
		void SetShadowColor(UIColor color, UIControlState state);
	}

	// typedef void (^MMDrawerControllerDrawerVisualStateBlock)(MMDrawerController *, MMDrawerSide, CGFloat);
	delegate void MMDrawerControllerDrawerVisualStateBlock(MMDrawerController arg0, MMDrawerSide arg1, nfloat arg2);

	// @interface MMDrawerController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface MMDrawerController
	{
		// @property (nonatomic, strong) UIViewController * centerViewController;
		[Export("centerViewController", ArgumentSemantic.Strong)]
		UIViewController CenterViewController { get; set; }

		// @property (nonatomic, strong) UIViewController * leftDrawerViewController;
		[Export("leftDrawerViewController", ArgumentSemantic.Strong)]
		UIViewController LeftDrawerViewController { get; set; }

		// @property (nonatomic, strong) UIViewController * rightDrawerViewController;
		[Export("rightDrawerViewController", ArgumentSemantic.Strong)]
		UIViewController RightDrawerViewController { get; set; }

		// @property (assign, nonatomic) CGFloat maximumLeftDrawerWidth;
		[Export("maximumLeftDrawerWidth")]
		nfloat MaximumLeftDrawerWidth { get; set; }

		// @property (assign, nonatomic) CGFloat maximumRightDrawerWidth;
		[Export("maximumRightDrawerWidth")]
		nfloat MaximumRightDrawerWidth { get; set; }

		// @property (readonly, assign, nonatomic) CGFloat visibleLeftDrawerWidth;
		[Export("visibleLeftDrawerWidth")]
		nfloat VisibleLeftDrawerWidth { get; }

		// @property (readonly, assign, nonatomic) CGFloat visibleRightDrawerWidth;
		[Export("visibleRightDrawerWidth")]
		nfloat VisibleRightDrawerWidth { get; }

		// @property (assign, nonatomic) CGFloat animationVelocity;
		[Export("animationVelocity")]
		nfloat AnimationVelocity { get; set; }

		// @property (assign, nonatomic) BOOL shouldStretchDrawer;
		[Export("shouldStretchDrawer")]
		bool ShouldStretchDrawer { get; set; }

		// @property (readonly, assign, nonatomic) MMDrawerSide openSide;
		[Export("openSide", ArgumentSemantic.Assign)]
		MMDrawerSide OpenSide { get; }

		// @property (assign, nonatomic) MMOpenDrawerGestureMode openDrawerGestureModeMask;
		[Export("openDrawerGestureModeMask", ArgumentSemantic.Assign)]
		MMOpenDrawerGestureMode OpenDrawerGestureModeMask { get; set; }

		// @property (assign, nonatomic) MMCloseDrawerGestureMode closeDrawerGestureModeMask;
		[Export("closeDrawerGestureModeMask", ArgumentSemantic.Assign)]
		MMCloseDrawerGestureMode CloseDrawerGestureModeMask { get; set; }

		// @property (assign, nonatomic) MMDrawerOpenCenterInteractionMode centerHiddenInteractionMode;
		[Export("centerHiddenInteractionMode", ArgumentSemantic.Assign)]
		MMDrawerOpenCenterInteractionMode CenterHiddenInteractionMode { get; set; }

		// @property (assign, nonatomic) BOOL showsShadow;
		[Export("showsShadow")]
		bool ShowsShadow { get; set; }

		// @property (assign, nonatomic) CGFloat shadowRadius;
		[Export("shadowRadius")]
		nfloat ShadowRadius { get; set; }

		// @property (assign, nonatomic) CGFloat shadowOpacity;
		[Export("shadowOpacity")]
		nfloat ShadowOpacity { get; set; }

		// @property (assign, nonatomic) CGSize shadowOffset;
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		CGSize ShadowOffset { get; set; }

		// @property (nonatomic, strong) UIColor * shadowColor;
		[Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (assign, nonatomic) BOOL showsStatusBarBackgroundView;
		[Export("showsStatusBarBackgroundView")]
		bool ShowsStatusBarBackgroundView { get; set; }

		// @property (nonatomic, strong) UIColor * statusBarViewBackgroundColor;
		[Export("statusBarViewBackgroundColor", ArgumentSemantic.Strong)]
		UIColor StatusBarViewBackgroundColor { get; set; }

		// @property (assign, nonatomic) CGFloat bezelPanningCenterViewRange;
		[Export("bezelPanningCenterViewRange")]
		nfloat BezelPanningCenterViewRange { get; set; }

		// @property (assign, nonatomic) CGFloat panVelocityXAnimationThreshold;
		[Export("panVelocityXAnimationThreshold")]
		nfloat PanVelocityXAnimationThreshold { get; set; }

		// -(instancetype)initWithCenterViewController:(UIViewController *)centerViewController leftDrawerViewController:(UIViewController *)leftDrawerViewController rightDrawerViewController:(UIViewController *)rightDrawerViewController;
		[Export("initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:")]
		IntPtr Constructor(UIViewController centerViewController, [NullAllowed] UIViewController leftDrawerViewController, [NullAllowed] UIViewController rightDrawerViewController);

		// -(instancetype)initWithCenterViewController:(UIViewController *)centerViewController leftDrawerViewController:(UIViewController *)leftDrawerViewController;
		[Export("initWithCenterViewController:leftDrawerViewController:")]
		IntPtr Constructor(UIViewController centerViewController, UIViewController leftDrawerViewController);

		// -(instancetype)initWithCenterViewController:(UIViewController *)centerViewController rightDrawerViewController:(UIViewController *)rightDrawerViewController;
		//[Export("initWithCenterViewController:rightDrawerViewController:")]
		//IntPtr Constructor(UIViewController centerViewController, UIViewController rightDrawerViewController);

		// -(void)toggleDrawerSide:(MMDrawerSide)drawerSide animated:(BOOL)animated completion:(void (^)(BOOL))completion;
		[Export("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide(MMDrawerSide drawerSide, bool animated, Action<bool> completion);

		// -(void)closeDrawerAnimated:(BOOL)animated completion:(void (^)(BOOL))completion;
		[Export("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated(bool animated, Action<bool> completion);

		// -(void)openDrawerSide:(MMDrawerSide)drawerSide animated:(BOOL)animated completion:(void (^)(BOOL))completion;
		[Export("openDrawerSide:animated:completion:")]
		void OpenDrawerSide(MMDrawerSide drawerSide, bool animated, Action<bool> completion);

		// -(void)setCenterViewController:(UIViewController *)centerViewController withCloseAnimation:(BOOL)closeAnimated completion:(void (^)(BOOL))completion;
		[Export("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController(UIViewController centerViewController, bool closeAnimated, Action<bool> completion);

		// -(void)setCenterViewController:(UIViewController *)newCenterViewController withFullCloseAnimation:(BOOL)fullCloseAnimated completion:(void (^)(BOOL))completion;
		[Export("setCenterViewController:withFullCloseAnimation:completion:")]
		void SetCenterViewControllerWithFullCloseAnimation(UIViewController newCenterViewController, bool fullCloseAnimated, Action<bool> completion);

		// -(void)setMaximumLeftDrawerWidth:(CGFloat)width animated:(BOOL)animated completion:(void (^)(BOOL))completion;
		[Export("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth(nfloat width, bool animated, Action<bool> completion);

		// -(void)setMaximumRightDrawerWidth:(CGFloat)width animated:(BOOL)animated completion:(void (^)(BOOL))completion;
		[Export("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth(nfloat width, bool animated, Action<bool> completion);

		// -(void)bouncePreviewForDrawerSide:(MMDrawerSide)drawerSide completion:(void (^)(BOOL))completion;
		[Export("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide(MMDrawerSide drawerSide, Action<bool> completion);

		// -(void)bouncePreviewForDrawerSide:(MMDrawerSide)drawerSide distance:(CGFloat)distance completion:(void (^)(BOOL))completion;
		[Export("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide(MMDrawerSide drawerSide, nfloat distance, Action<bool> completion);

		// -(void)setDrawerVisualStateBlock:(void (^)(MMDrawerController *, MMDrawerSide, CGFloat))drawerVisualStateBlock;
		[Export("setDrawerVisualStateBlock:")]
		void SetDrawerVisualStateBlock(Action<MMDrawerController, MMDrawerSide, nfloat> drawerVisualStateBlock);

		// -(void)setGestureCompletionBlock:(void (^)(MMDrawerController *, UIGestureRecognizer *))gestureCompletionBlock;
		[Export("setGestureCompletionBlock:")]
		void SetGestureCompletionBlock(Action<MMDrawerController, UIGestureRecognizer> gestureCompletionBlock);

		// -(void)setGestureShouldRecognizeTouchBlock:(BOOL (^)(MMDrawerController *, UIGestureRecognizer *, UITouch *))gestureShouldRecognizeTouchBlock;
		[Export("setGestureShouldRecognizeTouchBlock:")]
		void SetGestureShouldRecognizeTouchBlock(Func<MMDrawerController, UIGestureRecognizer, UITouch, bool> gestureShouldRecognizeTouchBlock);
	}

	// @interface Subclass (MMDrawerController)
	[Category]
	[BaseType(typeof(MMDrawerController))]
	interface MMDrawerController_Subclass
	{
		// -(void)tapGestureCallback:(UITapGestureRecognizer *)tapGesture __attribute__((objc_requires_super));
		[Export("tapGestureCallback:")]
		//[RequiresSuper]
		void TapGestureCallback(UITapGestureRecognizer tapGesture);

		// -(void)panGestureCallback:(UIPanGestureRecognizer *)panGesture __attribute__((objc_requires_super));
		[Export("panGestureCallback:")]
		//[RequiresSuper]
		void PanGestureCallback(UIPanGestureRecognizer panGesture);

		// -(BOOL)gestureRecognizer:(UIGestureRecognizer *)gestureRecognizer shouldReceiveTouch:(UITouch *)touch __attribute__((objc_requires_super));
		[Export("gestureRecognizer:shouldReceiveTouch:")]
		//[RequiresSuper]
		bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UITouch touch);

		// -(void)prepareToPresentDrawer:(MMDrawerSide)drawer animated:(BOOL)animated __attribute__((objc_requires_super));
		[Export("prepareToPresentDrawer:animated:")]
		//[RequiresSuper]
		void PrepareToPresentDrawer(MMDrawerSide drawer, bool animated);

		// -(void)closeDrawerAnimated:(BOOL)animated velocity:(CGFloat)velocity animationOptions:(UIViewAnimationOptions)options completion:(void (^)(BOOL))completion __attribute__((objc_requires_super));
		[Export("closeDrawerAnimated:velocity:animationOptions:completion:")]
		//[RequiresSuper]
		void CloseDrawerAnimated(bool animated, nfloat velocity, UIViewAnimationOptions options, Action<bool> completion);

		// -(void)openDrawerSide:(MMDrawerSide)drawerSide animated:(BOOL)animated velocity:(CGFloat)velocity animationOptions:(UIViewAnimationOptions)options completion:(void (^)(BOOL))completion __attribute__((objc_requires_super));
		[Export("openDrawerSide:animated:velocity:animationOptions:completion:")]
		//[RequiresSuper]
		void OpenDrawerSide(MMDrawerSide drawerSide, bool animated, nfloat velocity, UIViewAnimationOptions options, Action<bool> completion);

		// -(void)willRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration __attribute__((objc_requires_super));
		[Export("willRotateToInterfaceOrientation:duration:")]
		//[RequiresSuper]
		void WillRotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation, double duration);

		// -(void)willAnimateRotationToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration __attribute__((objc_requires_super));
		[Export("willAnimateRotationToInterfaceOrientation:duration:")]
		//[RequiresSuper]
		void WillAnimateRotationToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation, double duration);
	}

	// @interface MMDrawerVisualState : NSObject
	[BaseType(typeof(NSObject))]
	interface MMDrawerVisualState
	{
		// +(MMDrawerControllerDrawerVisualStateBlock)slideAndScaleVisualStateBlock;
		[Static]
		[Export("slideAndScaleVisualStateBlock")]
		//[Verify(MethodToProperty)]
		MMDrawerControllerDrawerVisualStateBlock SlideAndScaleVisualStateBlock { get; }

		// +(MMDrawerControllerDrawerVisualStateBlock)slideVisualStateBlock;
		[Static]
		[Export("slideVisualStateBlock")]
		//[Verify(MethodToProperty)]
		MMDrawerControllerDrawerVisualStateBlock SlideVisualStateBlock { get; }

		// +(MMDrawerControllerDrawerVisualStateBlock)swingingDoorVisualStateBlock;
		[Static]
		[Export("swingingDoorVisualStateBlock")]
		//[Verify(MethodToProperty)]
		MMDrawerControllerDrawerVisualStateBlock SwingingDoorVisualStateBlock { get; }

		// +(MMDrawerControllerDrawerVisualStateBlock)parallaxVisualStateBlockWithParallaxFactor:(CGFloat)parallaxFactor;
		[Static]
		[Export("parallaxVisualStateBlockWithParallaxFactor:")]
		MMDrawerControllerDrawerVisualStateBlock ParallaxVisualStateBlockWithParallaxFactor(nfloat parallaxFactor);
	}

	// @interface MMDrawerController (UIViewController)
	[Category]
	[BaseType(typeof(UIViewController))]
	interface UIViewController_MMDrawerController
	{
		// @property (readonly, nonatomic, strong) MMDrawerController * mm_drawerController;
		[Export("mm_drawerController", ArgumentSemantic.Strong)]
		MMDrawerController Mm_drawerController();

		// @property (readonly, assign, nonatomic) CGRect mm_visibleDrawerFrame;
		[Export("mm_visibleDrawerFrame", ArgumentSemantic.Assign)]
		CGRect Mm_visibleDrawerFrame();
	}
}
