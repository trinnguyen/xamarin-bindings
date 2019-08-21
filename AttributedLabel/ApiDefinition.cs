
using ObjCRuntime;
using Foundation;
using UIKit;
using System;
using CoreText;
using CoreGraphics;

namespace AttributedLabel
{
    // @interface NIAttributedLabel : UILabel
    [BaseType(typeof(UILabel))]
    interface NIAttributedLabel
    {
        // @property (nonatomic) BOOL autoDetectLinks;
        [Export("autoDetectLinks")]
        bool AutoDetectLinks { get; set; }

        // @property (nonatomic) NSTextCheckingType dataDetectorTypes;
        [Export("dataDetectorTypes", ArgumentSemantic.Assign)]
        NSTextCheckingType DataDetectorTypes { get; set; }

        // @property (nonatomic) BOOL deferLinkDetection;
        [Export("deferLinkDetection")]
        bool DeferLinkDetection { get; set; }

        // -(void)addLink:(NSURL *)urlLink range:(NSRange)range;
        [Export("addLink:range:")]
        void AddLink(NSUrl urlLink, NSRange range);

        // -(void)removeAllExplicitLinks;
        [Export("removeAllExplicitLinks")]
        void RemoveAllExplicitLinks();

        // @property (nonatomic, strong) UIColor * linkColor;
        [Export("linkColor", ArgumentSemantic.Strong)]
        UIColor LinkColor { get; set; }

        // @property (nonatomic, strong) UIColor * highlightedLinkBackgroundColor;
        [Export("highlightedLinkBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HighlightedLinkBackgroundColor { get; set; }

        // @property (nonatomic) BOOL linksHaveUnderlines;
        [Export("linksHaveUnderlines")]
        bool LinksHaveUnderlines { get; set; }

        // @property (copy, nonatomic) NSDictionary * attributesForLinks;
        [Export("attributesForLinks", ArgumentSemantic.Copy)]
        NSDictionary AttributesForLinks { get; set; }

        // @property (copy, nonatomic) NSDictionary * attributesForHighlightedLink;
        [Export("attributesForHighlightedLink", ArgumentSemantic.Copy)]
        NSDictionary AttributesForHighlightedLink { get; set; }

        // @property (nonatomic) CGFloat lineHeight;
        [Export("lineHeight")]
        nfloat LineHeight { get; set; }

        // @property (nonatomic) NIVerticalTextAlignment verticalTextAlignment;
        [Export("verticalTextAlignment", ArgumentSemantic.Assign)]
        NIVerticalTextAlignment VerticalTextAlignment { get; set; }

        // @property (nonatomic) CTUnderlineStyle underlineStyle;
        [Export("underlineStyle", ArgumentSemantic.Assign)]
        CTUnderlineStyle UnderlineStyle { get; set; }

        // @property (nonatomic) CTUnderlineStyleModifiers underlineStyleModifier;
        [Export("underlineStyleModifier", ArgumentSemantic.Assign)]
        CTUnderlineStyleModifiers UnderlineStyleModifier { get; set; }

        // @property (nonatomic) CGFloat shadowBlur;
        [Export("shadowBlur")]
        nfloat ShadowBlur { get; set; }

        // @property (nonatomic) CGFloat strokeWidth;
        [Export("strokeWidth")]
        nfloat StrokeWidth { get; set; }

        // @property (nonatomic, strong) UIColor * strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property (nonatomic) CGFloat textKern;
        [Export("textKern")]
        nfloat TextKern { get; set; }

        // @property (copy, nonatomic) NSString * tailTruncationString;
        [Export("tailTruncationString")]
        string TailTruncationString { get; set; }

        // @property (nonatomic) BOOL shouldSortLinksLast;
        [Export("shouldSortLinksLast")]
        bool ShouldSortLinksLast { get; set; }

        // -(void)setFont:(UIFont *)font range:(NSRange)range;
        [Export("setFont:range:")]
        void SetFont(UIFont font, NSRange range);

        // -(void)setStrokeColor:(UIColor *)color range:(NSRange)range;
        [Export("setStrokeColor:range:")]
        void SetStrokeColor(UIColor color, NSRange range);

        // -(void)setStrokeWidth:(CGFloat)width range:(NSRange)range;
        [Export("setStrokeWidth:range:")]
        void SetStrokeWidth(nfloat width, NSRange range);

        // -(void)setTextColor:(UIColor *)textColor range:(NSRange)range;
        [Export("setTextColor:range:")]
        void SetTextColor(UIColor textColor, NSRange range);

        // -(void)setTextKern:(CGFloat)kern range:(NSRange)range;
        [Export("setTextKern:range:")]
        void SetTextKern(nfloat kern, NSRange range);

        // -(void)setUnderlineStyle:(CTUnderlineStyle)style modifier:(CTUnderlineStyleModifiers)modifier range:(NSRange)range;
        [Export("setUnderlineStyle:modifier:range:")]
        void SetUnderlineStyle(CTUnderlineStyle style, CTUnderlineStyleModifiers modifier, NSRange range);

        // -(void)insertImage:(UIImage *)image atIndex:(NSInteger)index;
        [Export("insertImage:atIndex:")]
        void InsertImage(UIImage image, nint index);

        // -(void)insertImage:(UIImage *)image atIndex:(NSInteger)index margins:(UIEdgeInsets)margins;
        [Export("insertImage:atIndex:margins:")]
        void InsertImage(UIImage image, nint index, UIEdgeInsets margins);

        // -(void)insertImage:(UIImage *)image atIndex:(NSInteger)index margins:(UIEdgeInsets)margins verticalTextAlignment:(NIVerticalTextAlignment)verticalTextAlignment;
        [Export("insertImage:atIndex:margins:verticalTextAlignment:")]
        void InsertImage(UIImage image, nint index, UIEdgeInsets margins, NIVerticalTextAlignment verticalTextAlignment);

        // -(void)invalidateAccessibleElements;
        [Export("invalidateAccessibleElements")]
        void InvalidateAccessibleElements();

        [Wrap("WeakDelegate")]
		NIAttributedLabelDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<NIAttributedLabelDelegate> delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

	interface INIAttributedLabelDelegate { }

    // @protocol NIAttributedLabelDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NIAttributedLabelDelegate
    {
        // @optional -(void)attributedLabel:(NIAttributedLabel *)attributedLabel didSelectTextCheckingResult:(NSTextCheckingResult *)result atPoint:(CGPoint)point;
        [Export("attributedLabel:didSelectTextCheckingResult:atPoint:")]
		void DidSelectTextCheckingResult(NIAttributedLabel attributedLabel, NSTextCheckingResult result, CGPoint point);

        // @optional -(BOOL)attributedLabel:(NIAttributedLabel *)attributedLabel shouldPresentActionSheet:(UIActionSheet *)actionSheet withTextCheckingResult:(NSTextCheckingResult *)result atPoint:(CGPoint)point;
        [Export("attributedLabel:shouldPresentActionSheet:withTextCheckingResult:atPoint:")]
		bool ShouldPresentActionSheet(NIAttributedLabel attributedLabel, UIActionSheet actionSheet, NSTextCheckingResult result, CGPoint point);
    }

    // @interface NimbusKitAttributedLabel (NSMutableAttributedString)
    [Category]
    [BaseType(typeof(NSMutableAttributedString))]
    interface NSMutableAttributedString_NimbusKitAttributedLabel
    {
        // -(void)nimbuskit_setFont:(UIFont *)font;
        [Export("nimbuskit_setFont:")]
        void Nimbuskit_setFont(UIFont font);

        // -(void)nimbuskit_setTextAlignment:(CTTextAlignment)textAlignment lineBreakMode:(CTLineBreakMode)lineBreakMode lineHeight:(CGFloat)lineHeight;
        [Export("nimbuskit_setTextAlignment:lineBreakMode:lineHeight:")]
        void Nimbuskit_setTextAlignment(CTTextAlignment textAlignment, CTLineBreakMode lineBreakMode, nfloat lineHeight);

        // -(void)nimbuskit_setTextColor:(UIColor *)color;
        [Export("nimbuskit_setTextColor:")]
        void Nimbuskit_setTextColor(UIColor color);

        // -(void)nimbuskit_setBackgroundColor:(UIColor *)color;
        [Export("nimbuskit_setBackgroundColor:")]
        void Nimbuskit_setBackgroundColor(UIColor color);

        // -(void)nimbuskit_setLigaturesEnabled:(BOOL)enabled;
        [Export("nimbuskit_setLigaturesEnabled:")]
        void Nimbuskit_setLigaturesEnabled(bool enabled);

        // -(void)nimbuskit_setKern:(CGFloat)kern;
        [Export("nimbuskit_setKern:")]
        void Nimbuskit_setKern(nfloat kern);

        // -(void)nimbuskit_setUnderlineStyle:(CTUnderlineStyle)style modifier:(CTUnderlineStyleModifiers)modifier;
        [Export("nimbuskit_setUnderlineStyle:modifier:")]
        void Nimbuskit_setUnderlineStyle(CTUnderlineStyle style, CTUnderlineStyleModifiers modifier);

        // -(void)nimbuskit_setStrokeWidth:(CGFloat)width;
        [Export("nimbuskit_setStrokeWidth:")]
        void Nimbuskit_setStrokeWidth(nfloat width);

        // -(void)nimbuskit_setStrokeColor:(UIColor *)color;
        [Export("nimbuskit_setStrokeColor:")]
        void Nimbuskit_setStrokeColor(UIColor color);

        // -(void)nimbuskit_setLetterpressEnabled:(BOOL)enabled;
        [Export("nimbuskit_setLetterpressEnabled:")]
        void Nimbuskit_setLetterpressEnabled(bool enabled);

        // -(void)nimbuskit_setFont:(UIFont *)font range:(NSRange)range;
        [Export("nimbuskit_setFont:range:")]
        void Nimbuskit_setFont(UIFont font, NSRange range);

        // -(void)nimbuskit_setTextAlignment:(CTTextAlignment)textAlignment lineBreakMode:(CTLineBreakMode)lineBreakMode lineHeight:(CGFloat)lineHeight range:(NSRange)range;
        [Export("nimbuskit_setTextAlignment:lineBreakMode:lineHeight:range:")]
        void Nimbuskit_setTextAlignment(CTTextAlignment textAlignment, CTLineBreakMode lineBreakMode, nfloat lineHeight, NSRange range);

        // -(void)nimbuskit_setTextColor:(UIColor *)color range:(NSRange)range;
        [Export("nimbuskit_setTextColor:range:")]
        void Nimbuskit_setTextColor(UIColor color, NSRange range);

        // -(void)nimbuskit_setBackgroundColor:(UIColor *)color range:(NSRange)range;
        [Export("nimbuskit_setBackgroundColor:range:")]
        void Nimbuskit_setBackgroundColor(UIColor color, NSRange range);

        // -(void)nimbuskit_setLigaturesEnabled:(BOOL)enabled range:(NSRange)range;
        [Export("nimbuskit_setLigaturesEnabled:range:")]
        void Nimbuskit_setLigaturesEnabled(bool enabled, NSRange range);

        // -(void)nimbuskit_setKern:(CGFloat)kern range:(NSRange)range;
        [Export("nimbuskit_setKern:range:")]
        void Nimbuskit_setKern(nfloat kern, NSRange range);

        // -(void)nimbuskit_setUnderlineStyle:(CTUnderlineStyle)style modifier:(CTUnderlineStyleModifiers)modifier range:(NSRange)range;
        [Export("nimbuskit_setUnderlineStyle:modifier:range:")]
        void Nimbuskit_setUnderlineStyle(CTUnderlineStyle style, CTUnderlineStyleModifiers modifier, NSRange range);

        // -(void)nimbuskit_setStrokeWidth:(CGFloat)width range:(NSRange)range;
        [Export("nimbuskit_setStrokeWidth:range:")]
        void Nimbuskit_setStrokeWidth(nfloat width, NSRange range);

        // -(void)nimbuskit_setStrokeColor:(UIColor *)color range:(NSRange)range;
        [Export("nimbuskit_setStrokeColor:range:")]
        void Nimbuskit_setStrokeColor(UIColor color, NSRange range);

        // -(void)nimbuskit_setLetterpressEnabled:(BOOL)enabled range:(NSRange)range;
        [Export("nimbuskit_setLetterpressEnabled:range:")]
        void Nimbuskit_setLetterpressEnabled(bool enabled, NSRange range);
    }

}

