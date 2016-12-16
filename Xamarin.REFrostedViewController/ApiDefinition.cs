using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.REFrostedViewController
{
	// @interface REFrostedContainerViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface REFrostedContainerViewController
	{
		// @property (readwrite, nonatomic, strong) UIImage * screenshotImage;
		[Export("screenshotImage", ArgumentSemantic.Strong)]
		UIImage ScreenshotImage { get; set; }

		// @property (readwrite, nonatomic, weak) REFrostedViewController * frostedViewController;
		[Export("frostedViewController", ArgumentSemantic.Weak)]
		REFrostedViewController FrostedViewController { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL animateApperance;
		[Export("animateApperance")]
		bool AnimateApperance { get; set; }

		// @property (readonly, nonatomic, strong) UIView * containerView;
		[Export("containerView", ArgumentSemantic.Strong)]
		UIView ContainerView { get; }

		// -(void)panGestureRecognized:(UIPanGestureRecognizer *)recognizer;
		[Export("panGestureRecognized:")]
		void PanGestureRecognized(UIPanGestureRecognizer recognizer);

		// -(void)hide;
		[Export("hide")]
		void Hide();

		// -(void)resizeToSize:(CGSize)size;
		[Export("resizeToSize:")]
		void ResizeToSize(CGSize size);

		// -(void)hideWithCompletionHandler:(void (^)(void))completionHandler;
		[Export("hideWithCompletionHandler:")]
		void HideWithCompletionHandler(Action completionHandler);

		// -(void)refreshBackgroundImage;
		[Export("refreshBackgroundImage")]
		void RefreshBackgroundImage();
	}

	// @interface REFrostedViewController (UIViewController)
	[Category]
	[BaseType(typeof(UIViewController))]
	interface UIViewController_REFrostedViewController
	{
		// @property (readonly, nonatomic, strong) REFrostedViewController * frostedViewController;
		[Export("frostedViewController", ArgumentSemantic.Strong)]
		REFrostedViewController GetFrostedViewController();

		// -(void)re_displayController:(UIViewController *)controller frame:(CGRect)frame;
		[Export("re_displayController:frame:")]
		void REDisplayController(UIViewController controller, CGRect frame);

		// -(void)re_hideController:(UIViewController *)controller;
		[Export("re_hideController:")]
		void REHideController(UIViewController controller);
	}

	// @interface REFrostedViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface REFrostedViewController
	{
		// @property (readonly, nonatomic, strong) UIPanGestureRecognizer * panGestureRecognizer;
		[Export("panGestureRecognizer", ArgumentSemantic.Strong)]
		UIPanGestureRecognizer PanGestureRecognizer { get; }

		// @property (assign, readwrite, nonatomic) BOOL panGestureEnabled;
		[Export("panGestureEnabled")]
		bool PanGestureEnabled { get; set; }

		// @property (assign, readwrite, nonatomic) REFrostedViewControllerDirection direction;
		[Export("direction", ArgumentSemantic.Assign)]
		REFrostedViewControllerDirection Direction { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat backgroundFadeAmount;
		[Export("backgroundFadeAmount")]
		nfloat BackgroundFadeAmount { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * blurTintColor;
		[Export("blurTintColor", ArgumentSemantic.Strong)]
		UIColor BlurTintColor { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat blurRadius;
		[Export("blurRadius")]
		nfloat BlurRadius { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat blurSaturationDeltaFactor;
		[Export("blurSaturationDeltaFactor")]
		nfloat BlurSaturationDeltaFactor { get; set; }

		// @property (assign, readwrite, nonatomic) NSTimeInterval animationDuration;
		[Export("animationDuration")]
		double AnimationDuration { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL limitMenuViewSize;
		[Export("limitMenuViewSize")]
		bool LimitMenuViewSize { get; set; }

		// @property (assign, readwrite, nonatomic) CGSize menuViewSize;
		[Export("menuViewSize", ArgumentSemantic.Assign)]
		CGSize MenuViewSize { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL liveBlur;
		[Export("liveBlur")]
		bool LiveBlur { get; set; }

		// @property (assign, readwrite, nonatomic) REFrostedViewControllerLiveBackgroundStyle liveBlurBackgroundStyle;
		[Export("liveBlurBackgroundStyle", ArgumentSemantic.Assign)]
		REFrostedViewControllerLiveBackgroundStyle LiveBlurBackgroundStyle { get; set; }

		[Wrap("WeakDelegate")]
		REFrostedViewControllerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<REFrostedViewControllerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, strong) UIViewController * contentViewController;
		[Export("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; set; }

		// @property (readwrite, nonatomic, strong) UIViewController * menuViewController;
		[Export("menuViewController", ArgumentSemantic.Strong)]
		UIViewController MenuViewController { get; set; }

		// -(id)initWithContentViewController:(UIViewController *)contentViewController menuViewController:(UIViewController *)menuViewController;
		[Export("initWithContentViewController:menuViewController:")]
		IntPtr Constructor(UIViewController contentViewController, UIViewController menuViewController);

		// -(void)presentMenuViewController;
		[Export("presentMenuViewController")]
		void PresentMenuViewController();

		// -(void)hideMenuViewController;
		[Export("hideMenuViewController")]
		void HideMenuViewController();

		// -(void)resizeMenuViewControllerToSize:(CGSize)size;
		[Export("resizeMenuViewControllerToSize:")]
		void ResizeMenuViewControllerToSize(CGSize size);

		// -(void)hideMenuViewControllerWithCompletionHandler:(void (^)(void))completionHandler;
		[Export("hideMenuViewControllerWithCompletionHandler:")]
		void HideMenuViewControllerWithCompletionHandler(Action completionHandler);

		// -(void)panGestureRecognized:(UIPanGestureRecognizer *)recognizer;
		[Export("panGestureRecognized:")]
		void PanGestureRecognized(UIPanGestureRecognizer recognizer);
	}

	// @protocol REFrostedViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface REFrostedViewControllerDelegate
	{
		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController willAnimateRotationToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration;
		[Export("frostedViewController:willAnimateRotationToInterfaceOrientation:duration:")]
		void WillAnimateRotationToInterfaceOrientation(REFrostedViewController frostedViewController, UIInterfaceOrientation toInterfaceOrientation, double duration);

		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController didRecognizePanGesture:(UIPanGestureRecognizer *)recognizer;
		[Export("frostedViewController:didRecognizePanGesture:")]
		void DidRecognizePanGesture(REFrostedViewController frostedViewController, UIPanGestureRecognizer recognizer);

		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController willShowMenuViewController:(UIViewController *)menuViewController;
		[Export("frostedViewController:willShowMenuViewController:")]
		void WillShowMenuViewController(REFrostedViewController frostedViewController, UIViewController menuViewController);

		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController didShowMenuViewController:(UIViewController *)menuViewController;
		[Export("frostedViewController:didShowMenuViewController:")]
		void DidShowMenuViewController(REFrostedViewController frostedViewController, UIViewController menuViewController);

		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController willHideMenuViewController:(UIViewController *)menuViewController;
		[Export("frostedViewController:willHideMenuViewController:")]
		void WillHideMenuViewController(REFrostedViewController frostedViewController, UIViewController menuViewController);

		// @optional -(void)frostedViewController:(REFrostedViewController *)frostedViewController didHideMenuViewController:(UIViewController *)menuViewController;
		[Export("frostedViewController:didHideMenuViewController:")]
		void DidHideMenuViewController(REFrostedViewController frostedViewController, UIViewController menuViewController);
	}

	// @interface REFrostedViewController (UIImage)
	[Category]
	[BaseType(typeof(UIImage))]
	interface UIImage_REFrostedViewController
	{
		// -(UIImage *)re_applyBlurWithRadius:(CGFloat)blurRadius tintColor:(UIColor *)tintColor saturationDeltaFactor:(CGFloat)saturationDeltaFactor maskImage:(UIImage *)maskImage;
		[Export("re_applyBlurWithRadius:tintColor:saturationDeltaFactor:maskImage:")]
		UIImage REApplyBlurWithRadius(nfloat blurRadius, UIColor tintColor, nfloat saturationDeltaFactor, UIImage maskImage);
	}

	// @interface REFrostedViewController (UIView)
	[Category]
	[BaseType(typeof(UIView))]
	interface UIView_REFrostedViewController
	{
		// -(UIImage *)re_screenshot;
		[Export("re_screenshot")]
		//[Verify(MethodToProperty)]
		UIImage GetREFrostedViewControllerScreenshot();
	}
}
