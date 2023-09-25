using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreText;

namespace Xamarin.Toast
{
    [Static]
    partial interface ToastConstants
    {
        // extern const NSString * CSToastPositionTop;
        [Field("CSToastPositionTop", "__Internal")]
        NSString CSToastPositionTop { get; }

        // extern const NSString * CSToastPositionCenter;
        [Field("CSToastPositionCenter", "__Internal")]
        NSString CSToastPositionCenter { get; }

        // extern const NSString * CSToastPositionBottom;
        [Field("CSToastPositionBottom", "__Internal")]
        NSString CSToastPositionBottom { get; }
    }

    // @interface Toast (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_Toast
    {
        // -(void)makeToast:(NSString *)message;
        [Export("makeToast:")]
        void MakeToast(string message);

        // -(void)makeToast:(NSString *)message duration:(NSTimeInterval)duration position:(id)position;
        [Export("makeToast:duration:position:")]
        void MakeToast(string message, double duration, NSObject position);

        // -(void)makeToast:(NSString *)message duration:(NSTimeInterval)duration position:(id)position style:(CSToastStyle *)style;
        [Export("makeToast:duration:position:style:")]
        void MakeToast(string message, double duration, NSObject position, CSToastStyle style);

        // -(void)makeToast:(NSString *)message duration:(NSTimeInterval)duration position:(id)position title:(NSString *)title image:(UIImage *)image style:(CSToastStyle *)style completion:(void (^)(BOOL))completion;
        [Export("makeToast:duration:position:title:image:style:completion:")]
        void MakeToast(string message, double duration, NSObject position, string title, UIImage image, [NullAllowed] CSToastStyle style, Action<bool> completion);

        // -(UIView *)toastViewForMessage:(NSString *)message title:(NSString *)title image:(UIImage *)image style:(CSToastStyle *)style;
        [Export("toastViewForMessage:title:image:style:")]
        UIView ToastViewForMessage(string message, string title, UIImage image, CSToastStyle style);

        // -(void)hideToast;
        [Export("hideToast")]
        void HideToast();

        // -(void)hideToast:(UIView *)toast;
        [Export("hideToast:")]
        void HideToast(UIView toast);

        // -(void)hideAllToasts;
        [Export("hideAllToasts")]
        void HideAllToasts();

        // -(void)hideAllToasts:(BOOL)includeActivity clearQueue:(BOOL)clearQueue;
        [Export("hideAllToasts:clearQueue:")]
        void HideAllToasts(bool includeActivity, bool clearQueue);

        // -(void)clearToastQueue;
        [Export("clearToastQueue")]
        void ClearToastQueue();

        // -(void)makeToastActivity:(id)position;
        [Export("makeToastActivity:")]
        void MakeToastActivity(NSObject position);

        // -(void)hideToastActivity;
        [Export("hideToastActivity")]
        void HideToastActivity();

        // -(void)showToast:(UIView *)toast;
        [Export("showToast:")]
        void ShowToast(UIView toast);

        // -(void)showToast:(UIView *)toast duration:(NSTimeInterval)duration position:(id)position completion:(void (^)(BOOL))completion;
        [Export("showToast:duration:position:completion:")]
        void ShowToast(UIView toast, double duration, NSObject position, Action<bool> completion);
    }

    // @interface CSToastStyle : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface CSToastStyle
    {
        // @property (nonatomic, strong) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * messageColor;
        [Export("messageColor", ArgumentSemantic.Strong)]
        UIColor MessageColor { get; set; }

        // @property (assign, nonatomic) CGFloat maxWidthPercentage;
        [Export("maxWidthPercentage")]
        nfloat MaxWidthPercentage { get; set; }

        // @property (assign, nonatomic) CGFloat maxHeightPercentage;
        [Export("maxHeightPercentage")]
        nfloat MaxHeightPercentage { get; set; }

        // @property (assign, nonatomic) CGFloat horizontalPadding;
        [Export("horizontalPadding")]
        nfloat HorizontalPadding { get; set; }

        // @property (assign, nonatomic) CGFloat verticalPadding;
        [Export("verticalPadding")]
        nfloat VerticalPadding { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, strong) UIFont * titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * messageFont;
        [Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (assign, nonatomic) NSTextAlignment titleAlignment;
        [Export("titleAlignment", ArgumentSemantic.Assign)]
        CTTextAlignment TitleAlignment { get; set; }

        // @property (assign, nonatomic) NSTextAlignment messageAlignment;
        [Export("messageAlignment", ArgumentSemantic.Assign)]
        CTTextAlignment MessageAlignment { get; set; }

        // @property (assign, nonatomic) NSInteger titleNumberOfLines;
        [Export("titleNumberOfLines")]
        nint TitleNumberOfLines { get; set; }

        // @property (assign, nonatomic) NSInteger messageNumberOfLines;
        [Export("messageNumberOfLines")]
        nint MessageNumberOfLines { get; set; }

        // @property (assign, nonatomic) BOOL displayShadow;
        [Export("displayShadow")]
        bool DisplayShadow { get; set; }

        // @property (nonatomic, strong) UIColor * shadowColor;
        [Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

        // @property (assign, nonatomic) CGFloat shadowOpacity;
        [Export("shadowOpacity")]
        nfloat ShadowOpacity { get; set; }

        // @property (assign, nonatomic) CGFloat shadowRadius;
        [Export("shadowRadius")]
        nfloat ShadowRadius { get; set; }

        // @property (assign, nonatomic) CGSize shadowOffset;
        [Export("shadowOffset", ArgumentSemantic.Assign)]
        CGSize ShadowOffset { get; set; }

        // @property (assign, nonatomic) CGSize imageSize;
        [Export("imageSize", ArgumentSemantic.Assign)]
        CGSize ImageSize { get; set; }

        // @property (assign, nonatomic) CGSize activitySize;
        [Export("activitySize", ArgumentSemantic.Assign)]
        CGSize ActivitySize { get; set; }

        // @property (assign, nonatomic) NSTimeInterval fadeDuration;
        [Export("fadeDuration")]
        double FadeDuration { get; set; }
    }

    // @interface CSToastManager : NSObject
    [BaseType(typeof(NSObject))]
    interface CSToastManager
    {
        // +(CSToastStyle *)sharedStyle;
        // +(void)setSharedStyle:(CSToastStyle *)sharedStyle;
        [Static]
        [Export("sharedStyle")]
        CSToastStyle SharedStyle { get; set; }

        // +(void)setTapToDismissEnabled:(BOOL)tapToDismissEnabled;
        [Static]
        [Export("setTapToDismissEnabled:")]
        void SetTapToDismissEnabled(bool tapToDismissEnabled);

        // +(BOOL)isTapToDismissEnabled;
        [Static]
        [Export("isTapToDismissEnabled")]
        bool IsTapToDismissEnabled { get; }

        // +(void)setQueueEnabled:(BOOL)queueEnabled;
        [Static]
        [Export("setQueueEnabled:")]
        void SetQueueEnabled(bool queueEnabled);

        // +(BOOL)isQueueEnabled;
        [Static]
        [Export("isQueueEnabled")]
        bool IsQueueEnabled { get; }

        // +(NSTimeInterval)defaultDuration;
        // +(void)setDefaultDuration:(NSTimeInterval)duration;
        [Static]
        [Export("defaultDuration")]
        double DefaultDuration { get; set; }

        // +(id)defaultPosition;
        // +(void)setDefaultPosition:(id)position;
        [Static]
        [Export("defaultPosition")]
        NSObject DefaultPosition { get; set; }
    }
}
