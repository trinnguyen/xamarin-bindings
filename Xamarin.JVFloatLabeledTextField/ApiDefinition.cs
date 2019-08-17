using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.JVFloatLabeledText
{
    // @interface JVFloatLabeledTextField : UITextField
    [BaseType(typeof(UITextField))]
    interface JVFloatLabeledTextField
    {
        // @property (readonly, nonatomic, strong) UILabel * floatingLabel;
        [Export("floatingLabel", ArgumentSemantic.Strong)]
        UILabel FloatingLabel { get; }

        // @property (nonatomic) CGFloat floatingLabelYPadding;
        [Export("floatingLabelYPadding")]
        nfloat FloatingLabelYPadding { get; set; }

        // @property (nonatomic) CGFloat floatingLabelXPadding;
        [Export("floatingLabelXPadding")]
        nfloat FloatingLabelXPadding { get; set; }

        // @property (nonatomic) CGFloat floatingLabelReductionRatio;
        [Export("floatingLabelReductionRatio")]
        nfloat FloatingLabelReductionRatio { get; set; }

        // @property (nonatomic) CGFloat placeholderYPadding;
        [Export("placeholderYPadding")]
        nfloat PlaceholderYPadding { get; set; }

        // @property (nonatomic, strong) UIFont * floatingLabelFont;
        [Export("floatingLabelFont", ArgumentSemantic.Strong)]
        UIFont FloatingLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * floatingLabelTextColor;
        [Export("floatingLabelTextColor", ArgumentSemantic.Strong)]
        UIColor FloatingLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * floatingLabelActiveTextColor;
        [Export("floatingLabelActiveTextColor", ArgumentSemantic.Strong)]
        UIColor FloatingLabelActiveTextColor { get; set; }

        // @property (assign, nonatomic) BOOL animateEvenIfNotFirstResponder;
        [Export("animateEvenIfNotFirstResponder")]
        bool AnimateEvenIfNotFirstResponder { get; set; }

        // @property (assign, nonatomic) NSTimeInterval floatingLabelShowAnimationDuration;
        [Export("floatingLabelShowAnimationDuration")]
        double FloatingLabelShowAnimationDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval floatingLabelHideAnimationDuration;
        [Export("floatingLabelHideAnimationDuration")]
        double FloatingLabelHideAnimationDuration { get; set; }

        // @property (assign, nonatomic) BOOL adjustsClearButtonRect;
        [Export("adjustsClearButtonRect")]
        bool AdjustsClearButtonRect { get; set; }

        // @property (assign, nonatomic) BOOL keepBaseline;
        [Export("keepBaseline")]
        bool KeepBaseline { get; set; }

        // @property (assign, nonatomic) BOOL alwaysShowFloatingLabel;
        [Export("alwaysShowFloatingLabel")]
        bool AlwaysShowFloatingLabel { get; set; }

        // @property (nonatomic, strong) UIColor * placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // -(void)setPlaceholder:(NSString *)placeholder floatingTitle:(NSString *)floatingTitle;
        [Export("setPlaceholder:floatingTitle:")]
        void SetPlaceholder(string placeholder, string floatingTitle);

        // -(void)setAttributedPlaceholder:(NSAttributedString *)attributedPlaceholder floatingTitle:(NSString *)floatingTitle;
        [Export("setAttributedPlaceholder:floatingTitle:")]
        void SetAttributedPlaceholder(NSAttributedString attributedPlaceholder, string floatingTitle);
    }

    // @interface JVFloatLabeledTextView : UITextView
    [BaseType(typeof(UITextView))]
    interface JVFloatLabeledTextView
    {
        // @property (copy, nonatomic) NSString * placeholder;
        [Export("placeholder")]
        string Placeholder { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * placeholderLabel;
        [Export("placeholderLabel", ArgumentSemantic.Strong)]
        UILabel PlaceholderLabel { get; }

        // @property (readonly, nonatomic, strong) UILabel * floatingLabel;
        [Export("floatingLabel", ArgumentSemantic.Strong)]
        UILabel FloatingLabel { get; }

        // @property (nonatomic) CGFloat floatingLabelYPadding;
        [Export("floatingLabelYPadding")]
        nfloat FloatingLabelYPadding { get; set; }

        // @property (nonatomic) CGFloat floatingLabelXPadding;
        [Export("floatingLabelXPadding")]
        nfloat FloatingLabelXPadding { get; set; }

        // @property (nonatomic) CGFloat placeholderYPadding;
        [Export("placeholderYPadding")]
        nfloat PlaceholderYPadding { get; set; }

        // @property (nonatomic, strong) UIFont * floatingLabelFont;
        [Export("floatingLabelFont", ArgumentSemantic.Strong)]
        UIFont FloatingLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * floatingLabelTextColor;
        [Export("floatingLabelTextColor", ArgumentSemantic.Strong)]
        UIColor FloatingLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * floatingLabelActiveTextColor;
        [Export("floatingLabelActiveTextColor", ArgumentSemantic.Strong)]
        UIColor FloatingLabelActiveTextColor { get; set; }

        // @property (assign, nonatomic) BOOL floatingLabelShouldLockToTop;
        [Export("floatingLabelShouldLockToTop")]
        bool FloatingLabelShouldLockToTop { get; set; }

        // @property (nonatomic, strong) UIColor * placeholderTextColor;
        [Export("placeholderTextColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderTextColor { get; set; }

        // @property (assign, nonatomic) BOOL animateEvenIfNotFirstResponder;
        [Export("animateEvenIfNotFirstResponder")]
        bool AnimateEvenIfNotFirstResponder { get; set; }

        // @property (assign, nonatomic) NSTimeInterval floatingLabelShowAnimationDuration __attribute__((annotate("ui_appearance_selector")));
        [Export("floatingLabelShowAnimationDuration")]
        double FloatingLabelShowAnimationDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval floatingLabelHideAnimationDuration __attribute__((annotate("ui_appearance_selector")));
        [Export("floatingLabelHideAnimationDuration")]
        double FloatingLabelHideAnimationDuration { get; set; }

        // @property (assign, nonatomic) BOOL alwaysShowFloatingLabel;
        [Export("alwaysShowFloatingLabel")]
        bool AlwaysShowFloatingLabel { get; set; }

        // @property (nonatomic) CGFloat startingTextContainerInsetTop;
        [Export("startingTextContainerInsetTop")]
        nfloat StartingTextContainerInsetTop { get; set; }

        // -(void)setPlaceholder:(NSString *)placeholder floatingTitle:(NSString *)floatingTitle;
        [Export("setPlaceholder:floatingTitle:")]
        void SetPlaceholder(string placeholder, string floatingTitle);
    }
}
