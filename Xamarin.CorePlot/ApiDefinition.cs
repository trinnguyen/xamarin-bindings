using System;
using CoreAnimation;
using CoreGraphics;
using CorePlot;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CorePlot
{
    interface ICPTAnimationDelegate { }

    // @protocol CPTAnimationDelegate <CAAnimationDelegate>
    [BaseType(typeof(NSObject))]
    [Model]
    [Protocol]
    interface CPTAnimationDelegate : ICAAnimationDelegate
    {
        // @optional -(void)animationDidStart:(CPTAnimationOperation * _Nonnull)operation;
        [Export("animationDidStart:")]
        void AnimationDidStart(CPTAnimationOperation operation);

        // @optional -(void)animationDidFinish:(CPTAnimationOperation * _Nonnull)operation;
        [Export("animationDidFinish:")]
        void AnimationDidFinish(CPTAnimationOperation operation);

        // @optional -(void)animationCancelled:(CPTAnimationOperation * _Nonnull)operation;
        [Export("animationCancelled:")]
        void AnimationCancelled(CPTAnimationOperation operation);

        // @optional -(void)animationWillUpdate:(CPTAnimationOperation * _Nonnull)operation;
        [Export("animationWillUpdate:")]
        void AnimationWillUpdate(CPTAnimationOperation operation);

        // @optional -(void)animationDidUpdate:(CPTAnimationOperation * _Nonnull)operation;
        [Export("animationDidUpdate:")]
        void AnimationDidUpdate(CPTAnimationOperation operation);
    }

    // @interface CPTAnimation : NSObject
    [BaseType(typeof(NSObject))]
    interface CPTAnimation
    {
        // @property (readonly, nonatomic) CGFloat timeOffset;
        [Export("timeOffset")]
        nfloat TimeOffset { get; }

        // @property (assign, nonatomic) CPTAnimationCurve defaultAnimationCurve;
        [Export("defaultAnimationCurve", ArgumentSemantic.Assign)]
        CPTAnimationCurve DefaultAnimationCurve { get; set; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        CPTAnimation SharedInstance();

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property period:(CPTAnimationPeriod * _Nonnull)period animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:period:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTAnimationPeriod period, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // -(CPTAnimationOperation * _Nonnull)addAnimationOperation:(CPTAnimationOperation * _Nonnull)animationOperation;
        [Export("addAnimationOperation:")]
        CPTAnimationOperation AddAnimationOperation(CPTAnimationOperation animationOperation);

        // -(void)removeAnimationOperation:(CPTAnimationOperation * _Nullable)animationOperation;
        [Export("removeAnimationOperation:")]
        void RemoveAnimationOperation([NullAllowed] CPTAnimationOperation animationOperation);

        // -(void)removeAllAnimationOperations;
        [Export("removeAllAnimationOperations")]
        void RemoveAllAnimationOperations();

        // -(CPTAnimationOperation * _Nullable)operationWithIdentifier:(id<NSCopying,NSObject> _Nullable)identifier;
        [Export("operationWithIdentifier:")]
        [return: NullAllowed]
        CPTAnimationOperation OperationWithIdentifier([NullAllowed] NSObject identifier);

        //bgen: The member 'Animate' is decorated with[Static] and its container class CorePlot.CPTAnimation_CPTAnimationPeriodAdditions is decorated with[Category] this leads to hard to use code.Please inline Animate into CorePlot.CPTAnimation class. (BI1117) (TestCorePlotBinding)

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:from:to:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:from:to:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:from:to:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration);
    }

    // @interface CPTAnnotation : NSObject <NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTAnnotation : INSCoding, INSSecureCoding
    {
        // @property (readwrite, nonatomic, strong) CPTLayer * _Nullable contentLayer;
        [NullAllowed, Export("contentLayer", ArgumentSemantic.Strong)]
        CPTLayer ContentLayer { get; set; }

        // @property (readwrite, nonatomic, weak) CPTAnnotationHostLayer * _Nullable annotationHostLayer;
        [NullAllowed, Export("annotationHostLayer", ArgumentSemantic.Weak)]
        CPTAnnotationHostLayer AnnotationHostLayer { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint contentAnchorPoint;
        [Export("contentAnchorPoint", ArgumentSemantic.Assign)]
        CGPoint ContentAnchorPoint { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint displacement;
        [Export("displacement", ArgumentSemantic.Assign)]
        CGPoint Displacement { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat rotation;
        [Export("rotation")]
        nfloat Rotation { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface AbstractMethods (CPTAnnotation)
    [Category]
    [BaseType(typeof(CPTAnnotation))]
    interface CPTAnnotation_AbstractMethods
    {
        // -(void)positionContentLayer;
        [Export("positionContentLayer")]
        void PositionContentLayer();
    }

    // @interface CPTAnnotationHostLayer : CPTLayer
    [BaseType(typeof(CPTLayer))]
    interface CPTAnnotationHostLayer
    {
        // @property (readonly, nonatomic) CPTAnnotationArray * _Nonnull annotations;
        [Export("annotations")]
        CPTAnnotation[] Annotations { get; }

        // -(void)addAnnotation:(CPTAnnotation * _Nullable)annotation;
        [Export("addAnnotation:")]
        void AddAnnotation([NullAllowed] CPTAnnotation annotation);

        // -(void)removeAnnotation:(CPTAnnotation * _Nullable)annotation;
        [Export("removeAnnotation:")]
        void RemoveAnnotation([NullAllowed] CPTAnnotation annotation);

        // -(void)removeAllAnnotations;
        [Export("removeAllAnnotations")]
        void RemoveAllAnnotations();
    }

    // @protocol CPTAxisDelegate <CPTLayerDelegate>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    [Protocol]
	interface CPTAxisDelegate : CPTLayerDelegate
    {
        // @optional -(BOOL)axisShouldRelabel:(CPTAxis * _Nonnull)axis;
        [Export("axisShouldRelabel:")]
        bool AxisShouldRelabel(CPTAxis axis);

        // @optional -(void)axisDidRelabel:(CPTAxis * _Nonnull)axis;
        [Export("axisDidRelabel:")]
        void AxisDidRelabel(CPTAxis axis);

        // @optional -(BOOL)axis:(CPTAxis * _Nonnull)axis shouldUpdateAxisLabelsAtLocations:(CPTNumberSet * _Nonnull)locations;
        [Export("axis:shouldUpdateAxisLabelsAtLocations:")]
        bool Axis(CPTAxis axis, NSSet<NSNumber> locations);

        // @optional -(BOOL)axis:(CPTAxis * _Nonnull)axis shouldUpdateMinorAxisLabelsAtLocations:(CPTNumberSet * _Nonnull)locations;
        [Export("axis:shouldUpdateMinorAxisLabelsAtLocations:")]
        bool ShouldUpdateMinorAxisLabelsAtLocations(CPTAxis axis, NSSet<NSNumber> locations);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelWasSelected:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:labelWasSelected:")]
        void LabelWasSelected(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelWasSelected:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:labelWasSelected:withEvent:")]
        void LabelWasSelected(CPTAxis axis, CPTAxisLabel label, UIEvent @event);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickLabelWasSelected:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:minorTickLabelWasSelected:")]
        void MinorTickLabelWasSelected(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickLabelWasSelected:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:minorTickLabelWasSelected:withEvent:")]
        void MinorTickLabelWasSelected(CPTAxis axis, CPTAxisLabel label, UIEvent @event);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelTouchDown:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:labelTouchDown:")]
        void LabelTouchDown(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelTouchDown:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:labelTouchDown:withEvent:")]
        void LabelTouchDown(CPTAxis axis, CPTAxisLabel label, UIEvent @event);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelTouchUp:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:labelTouchUp:")]
        void LabelTouchUp(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis labelTouchUp:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:labelTouchUp:withEvent:")]
        void LabelTouchUp(CPTAxis axis, CPTAxisLabel label, UIEvent @event);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickTouchDown:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:minorTickTouchDown:")]
        void MinorTickTouchDown(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickTouchDown:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:minorTickTouchDown:withEvent:")]
        void MinorTickTouchDown(CPTAxis axis, CPTAxisLabel label, UIEvent @event);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickTouchUp:(CPTAxisLabel * _Nonnull)label;
        [Export("axis:minorTickTouchUp:")]
        void MinorTickTouchUp(CPTAxis axis, CPTAxisLabel label);

        // @optional -(void)axis:(CPTAxis * _Nonnull)axis minorTickTouchUp:(CPTAxisLabel * _Nonnull)label withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("axis:minorTickTouchUp:withEvent:")]
        void MinorTickTouchUp(CPTAxis axis, CPTAxisLabel label, UIEvent @event);
    }

    // @interface CPTAxis : CPTLayer
    [BaseType(typeof(CPTLayer))]
    interface CPTAxis
    {
        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable axisLineStyle;
        [NullAllowed, Export("axisLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle AxisLineStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CPTCoordinate coordinate;
        [Export("coordinate", ArgumentSemantic.Assign)]
        CPTCoordinate Coordinate { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull labelingOrigin;
        [Export("labelingOrigin", ArgumentSemantic.Strong)]
        NSNumber LabelingOrigin { get; set; }

        // @property (assign, readwrite, nonatomic) CPTSign tickDirection;
        [Export("tickDirection", ArgumentSemantic.Assign)]
        CPTSign TickDirection { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable visibleRange;
        [NullAllowed, Export("visibleRange", ArgumentSemantic.Copy)]
        CPTPlotRange VisibleRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable visibleAxisRange;
        [NullAllowed, Export("visibleAxisRange", ArgumentSemantic.Copy)]
        CPTPlotRange VisibleAxisRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineCap * _Nullable axisLineCapMin;
        [NullAllowed, Export("axisLineCapMin", ArgumentSemantic.Copy)]
        CPTLineCap AxisLineCapMin { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineCap * _Nullable axisLineCapMax;
        [NullAllowed, Export("axisLineCapMax", ArgumentSemantic.Copy)]
        CPTLineCap AxisLineCapMax { get; set; }

        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable titleTextStyle;
        [NullAllowed, Export("titleTextStyle", ArgumentSemantic.Copy)]
        CPTTextStyle TitleTextStyle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisTitle * _Nullable axisTitle;
        [NullAllowed, Export("axisTitle", ArgumentSemantic.Strong)]
        CPTAxisTitle AxisTitle { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat titleOffset;
        [Export("titleOffset")]
        nfloat TitleOffset { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (readwrite, copy, nonatomic) NSAttributedString * _Nullable attributedTitle;
        [NullAllowed, Export("attributedTitle", ArgumentSemantic.Copy)]
        NSAttributedString AttributedTitle { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat titleRotation;
        [Export("titleRotation")]
        nfloat TitleRotation { get; set; }

        // @property (assign, readwrite, nonatomic) CPTSign titleDirection;
        [Export("titleDirection", ArgumentSemantic.Assign)]
        CPTSign TitleDirection { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable titleLocation;
        [NullAllowed, Export("titleLocation", ArgumentSemantic.Strong)]
        NSNumber TitleLocation { get; set; }

        // @property (readonly, nonatomic) NSNumber * _Nonnull defaultTitleLocation;
        [Export("defaultTitleLocation")]
        NSNumber DefaultTitleLocation { get; }

        // @property (assign, readwrite, nonatomic) CPTAxisLabelingPolicy labelingPolicy;
        [Export("labelingPolicy", ArgumentSemantic.Assign)]
        CPTAxisLabelingPolicy LabelingPolicy { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat labelOffset;
        [Export("labelOffset")]
        nfloat LabelOffset { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat minorTickLabelOffset;
        [Export("minorTickLabelOffset")]
        nfloat MinorTickLabelOffset { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat labelRotation;
        [Export("labelRotation")]
        nfloat LabelRotation { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat minorTickLabelRotation;
        [Export("minorTickLabelRotation")]
        nfloat MinorTickLabelRotation { get; set; }

        // @property (assign, readwrite, nonatomic) CPTAlignment labelAlignment;
        [Export("labelAlignment", ArgumentSemantic.Assign)]
        CPTAlignment LabelAlignment { get; set; }

        // @property (assign, readwrite, nonatomic) CPTAlignment minorTickLabelAlignment;
        [Export("minorTickLabelAlignment", ArgumentSemantic.Assign)]
        CPTAlignment MinorTickLabelAlignment { get; set; }

        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable labelTextStyle;
        [NullAllowed, Export("labelTextStyle", ArgumentSemantic.Copy)]
        CPTTextStyle LabelTextStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable minorTickLabelTextStyle;
        [NullAllowed, Export("minorTickLabelTextStyle", ArgumentSemantic.Copy)]
        CPTTextStyle MinorTickLabelTextStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CPTSign tickLabelDirection;
        [Export("tickLabelDirection", ArgumentSemantic.Assign)]
        CPTSign TickLabelDirection { get; set; }

        // @property (assign, readwrite, nonatomic) CPTSign minorTickLabelDirection;
        [Export("minorTickLabelDirection", ArgumentSemantic.Assign)]
        CPTSign MinorTickLabelDirection { get; set; }

        // @property (readwrite, nonatomic, strong) NSFormatter * _Nullable labelFormatter;
        [NullAllowed, Export("labelFormatter", ArgumentSemantic.Strong)]
        NSFormatter LabelFormatter { get; set; }

        // @property (readwrite, nonatomic, strong) NSFormatter * _Nullable minorTickLabelFormatter;
        [NullAllowed, Export("minorTickLabelFormatter", ArgumentSemantic.Strong)]
        NSFormatter MinorTickLabelFormatter { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisLabelSet * _Nullable axisLabels;
        [NullAllowed, Export("axisLabels", ArgumentSemantic.Strong)]
        NSSet<CPTAxisLabel> AxisLabels { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisLabelSet * _Nullable minorTickAxisLabels;
        [NullAllowed, Export("minorTickAxisLabels", ArgumentSemantic.Strong)]
        NSSet<CPTAxisLabel> MinorTickAxisLabels { get; set; }

        // @property (readonly, nonatomic) BOOL needsRelabel;
        [Export("needsRelabel")]
        bool NeedsRelabel { get; }

        // @property (readwrite, nonatomic, strong) CPTPlotRangeArray * _Nullable labelExclusionRanges;
        [NullAllowed, Export("labelExclusionRanges", ArgumentSemantic.Strong)]
        CPTPlotRange[] LabelExclusionRanges { get; set; }

        // @property (readwrite, nonatomic, strong) CPTShadow * _Nullable labelShadow;
        [NullAllowed, Export("labelShadow", ArgumentSemantic.Strong)]
        CPTShadow LabelShadow { get; set; }

        // @property (readwrite, nonatomic, strong) CPTShadow * _Nullable minorTickLabelShadow;
        [NullAllowed, Export("minorTickLabelShadow", ArgumentSemantic.Strong)]
        CPTShadow MinorTickLabelShadow { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable majorIntervalLength;
        [NullAllowed, Export("majorIntervalLength", ArgumentSemantic.Strong)]
        NSNumber MajorIntervalLength { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat majorTickLength;
        [Export("majorTickLength")]
        nfloat MajorTickLength { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable majorTickLineStyle;
        [NullAllowed, Export("majorTickLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle MajorTickLineStyle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTNumberSet * _Nullable majorTickLocations;
        [NullAllowed, Export("majorTickLocations", ArgumentSemantic.Strong)]
        NSSet<NSNumber> MajorTickLocations { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger preferredNumberOfMajorTicks;
        [Export("preferredNumberOfMajorTicks")]
        nuint PreferredNumberOfMajorTicks { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger minorTicksPerInterval;
        [Export("minorTicksPerInterval")]
        nuint MinorTicksPerInterval { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat minorTickLength;
        [Export("minorTickLength")]
        nfloat MinorTickLength { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable minorTickLineStyle;
        [NullAllowed, Export("minorTickLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle MinorTickLineStyle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTNumberSet * _Nullable minorTickLocations;
        [NullAllowed, Export("minorTickLocations", ArgumentSemantic.Strong)]
        NSSet<NSNumber> MinorTickLocations { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable majorGridLineStyle;
        [NullAllowed, Export("majorGridLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle MajorGridLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable minorGridLineStyle;
        [NullAllowed, Export("minorGridLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle MinorGridLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable gridLinesRange;
        [NullAllowed, Export("gridLinesRange", ArgumentSemantic.Copy)]
        CPTPlotRange GridLinesRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFillArray * _Nullable alternatingBandFills;
        [NullAllowed, Export("alternatingBandFills", ArgumentSemantic.Copy)]
        CPTFill[] AlternatingBandFills { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable alternatingBandAnchor;
        [NullAllowed, Export("alternatingBandAnchor", ArgumentSemantic.Strong)]
        NSNumber AlternatingBandAnchor { get; set; }

        // @property (readonly, nonatomic) CPTLimitBandArray * _Nullable backgroundLimitBands;
        [NullAllowed, Export("backgroundLimitBands")]
        CPTLimitBand[] BackgroundLimitBands { get; }

        // @property (readwrite, nonatomic, strong) CPTPlotSpace * _Nullable plotSpace;
        [NullAllowed, Export("plotSpace", ArgumentSemantic.Strong)]
        CPTPlotSpace PlotSpace { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL separateLayers;
        [Export("separateLayers")]
        bool SeparateLayers { get; set; }

        // @property (readwrite, nonatomic, weak) CPTPlotArea * _Nullable plotArea;
        [NullAllowed, Export("plotArea", ArgumentSemantic.Weak)]
        CPTPlotArea PlotArea { get; set; }

        // @property (readonly, nonatomic, weak) CPTGridLines * _Nullable minorGridLines;
        [NullAllowed, Export("minorGridLines", ArgumentSemantic.Weak)]
        CPTGridLines MinorGridLines { get; }

        // @property (readonly, nonatomic, weak) CPTGridLines * _Nullable majorGridLines;
        [NullAllowed, Export("majorGridLines", ArgumentSemantic.Weak)]
        CPTGridLines MajorGridLines { get; }

        // @property (readonly, nonatomic) CPTAxisSet * _Nullable axisSet;
        [NullAllowed, Export("axisSet")]
        CPTAxisSet AxisSet { get; }

        // -(void)updateAxisTitle;
        [Export("updateAxisTitle")]
        void UpdateAxisTitle();

        // -(void)relabel;
        [Export("relabel")]
        void Relabel();

        // -(void)setNeedsRelabel;
        [Export("setNeedsRelabel")]
        void SetNeedsRelabel();

        // -(void)updateMajorTickLabels;
        [Export("updateMajorTickLabels")]
        void UpdateMajorTickLabels();

        // -(void)updateMinorTickLabels;
        [Export("updateMinorTickLabels")]
        void UpdateMinorTickLabels();

        // -(CPTNumberSet * _Nullable)filteredMajorTickLocations:(CPTNumberSet * _Nullable)allLocations;
        [Export("filteredMajorTickLocations:")]
        [return: NullAllowed]
        NSSet<NSNumber> FilteredMajorTickLocations([NullAllowed] NSSet<NSNumber> allLocations);

        // -(CPTNumberSet * _Nullable)filteredMinorTickLocations:(CPTNumberSet * _Nullable)allLocations;
        [Export("filteredMinorTickLocations:")]
        [return: NullAllowed]
        NSSet<NSNumber> FilteredMinorTickLocations([NullAllowed] NSSet<NSNumber> allLocations);

        // -(void)addBackgroundLimitBand:(CPTLimitBand * _Nullable)limitBand;
        [Export("addBackgroundLimitBand:")]
        void AddBackgroundLimitBand([NullAllowed] CPTLimitBand limitBand);

        // -(void)removeBackgroundLimitBand:(CPTLimitBand * _Nullable)limitBand;
        [Export("removeBackgroundLimitBand:")]
        void RemoveBackgroundLimitBand([NullAllowed] CPTLimitBand limitBand);

        // -(void)removeAllBackgroundLimitBands;
        [Export("removeAllBackgroundLimitBands")]
        void RemoveAllBackgroundLimitBands();
    }

    // @interface AbstractMethods (CPTAxis)
    [Category]
    [BaseType(typeof(CPTAxis))]
    interface CPTAxis_AbstractMethods
    {
        // -(CGPoint)viewPointForCoordinateValue:(NSNumber * _Nullable)coordinateValue;
        [Export("viewPointForCoordinateValue:")]
        CGPoint ViewPointForCoordinateValue([NullAllowed] NSNumber coordinateValue);

        // -(void)drawGridLinesInContext:(CGContextRef _Nonnull)context isMajor:(BOOL)major;
        [Export("drawGridLinesInContext:isMajor:")]
        unsafe void DrawGridLinesInContext(CGContext context, bool major);

        // -(void)drawBackgroundBandsInContext:(CGContextRef _Nonnull)context;
        [Export("drawBackgroundBandsInContext:")]
        unsafe void DrawBackgroundBandsInContext(CGContext context);

        // -(void)drawBackgroundLimitsInContext:(CGContextRef _Nonnull)context;
        [Export("drawBackgroundLimitsInContext:")]
        unsafe void DrawBackgroundLimitsInContext(CGContext context);
    }

    // @interface CPTAxisSet : CPTLayer
    [BaseType(typeof(CPTLayer))]
    interface CPTAxisSet
    {
        // @property (readwrite, nonatomic, strong) CPTAxisArray * _Nullable axes;
        [NullAllowed, Export("axes", ArgumentSemantic.Strong)]
        CPTAxis[] Axes { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable borderLineStyle;
        [NullAllowed, Export("borderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle BorderLineStyle { get; set; }

        // -(void)relabelAxes;
        [Export("relabelAxes")]
        void RelabelAxes();

        // -(CPTAxis * _Nullable)axisForCoordinate:(CPTCoordinate)coordinate atIndex:(NSUInteger)idx;
        [Export("axisForCoordinate:atIndex:")]
        [return: NullAllowed]
        CPTAxis AxisForCoordinate(CPTCoordinate coordinate, nuint idx);
    }

    // @interface CPTBorderedLayer : CPTAnnotationHostLayer
    [BaseType(typeof(CPTAnnotationHostLayer))]
    interface CPTBorderedLayer
    {
        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable borderLineStyle;
        [NullAllowed, Export("borderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle BorderLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Copy)]
        CPTFill Fill { get; set; }

        // @property (readwrite, nonatomic) BOOL inLayout;
        [Export("inLayout")]
        bool InLayout { get; set; }

        // -(void)renderBorderedLayerAsVectorInContext:(CGContextRef _Nonnull)context;
        [Export("renderBorderedLayerAsVectorInContext:")]
        unsafe void RenderBorderedLayerAsVectorInContext(CGContext context);
    }

    // @interface CPTColor : NSObject <NSCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTColor : INSCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, nonatomic) CGColorRef _Nonnull cgColor;
        [Export("cgColor")]
        CGColor Color { get; }

        // @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; }

        // +(instancetype _Nonnull)clearColor;
        [Static]
        [Export("clearColor")]
        CPTColor ClearColor { get; }

        // +(instancetype _Nonnull)whiteColor;
        [Static]
        [Export("whiteColor")]
        CPTColor WhiteColor { get; }

        // +(instancetype _Nonnull)lightGrayColor;
        [Static]
        [Export("lightGrayColor")]
        CPTColor LightGrayColor { get; }

        // +(instancetype _Nonnull)grayColor;
        [Static]
        [Export("grayColor")]
        CPTColor GrayColor { get; }

        // +(instancetype _Nonnull)darkGrayColor;
        [Static]
        [Export("darkGrayColor")]
        CPTColor DarkGrayColor { get; }

        // +(instancetype _Nonnull)blackColor;
        [Static]
        [Export("blackColor")]
        CPTColor BlackColor { get; }

        // +(instancetype _Nonnull)redColor;
        [Static]
        [Export("redColor")]
        CPTColor RedColor { get; }

        // +(instancetype _Nonnull)greenColor;
        [Static]
        [Export("greenColor")]
        CPTColor GreenColor { get; }

        // +(instancetype _Nonnull)blueColor;
        [Static]
        [Export("blueColor")]
        CPTColor BlueColor { get; }

        // +(instancetype _Nonnull)cyanColor;
        [Static]
        [Export("cyanColor")]
        CPTColor CyanColor { get; }

        // +(instancetype _Nonnull)yellowColor;
        [Static]
        [Export("yellowColor")]
        CPTColor YellowColor { get; }

        // +(instancetype _Nonnull)magentaColor;
        [Static]
        [Export("magentaColor")]
        CPTColor MagentaColor { get; }

        // +(instancetype _Nonnull)orangeColor;
        [Static]
        [Export("orangeColor")]
        CPTColor OrangeColor { get; }

        // +(instancetype _Nonnull)purpleColor;
        [Static]
        [Export("purpleColor")]
        CPTColor PurpleColor { get; }

        // +(instancetype _Nonnull)brownColor;
        [Static]
        [Export("brownColor")]
        CPTColor BrownColor { get; }

        // +(instancetype _Nonnull)colorWithCGColor:(CGColorRef _Nonnull)newCGColor;
        [Static]
        [Export("colorWithCGColor:")]
        CPTColor FromCGColor(CGColor newCGColor);

        // +(instancetype _Nonnull)colorWithComponentRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue alpha:(CGFloat)alpha;
        [Static]
        [Export("colorWithComponentRed:green:blue:alpha:")]
        CPTColor FromRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha);

        // +(instancetype _Nonnull)colorWithGenericGray:(CGFloat)gray;
        [Static]
        [Export("colorWithGenericGray:")]
        CPTColor FromGenericGray(nfloat gray);

        // -(instancetype _Nonnull)initWithCGColor:(CGColorRef _Nonnull)cgColor __attribute__((objc_designated_initializer));
        [Export("initWithCGColor:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGColor cgColor);

        // -(instancetype _Nonnull)initWithComponentRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue alpha:(CGFloat)alpha;
        [Export("initWithComponentRed:green:blue:alpha:")]
        IntPtr Constructor(nfloat red, nfloat green, nfloat blue, nfloat alpha);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // -(instancetype _Nonnull)colorWithAlphaComponent:(CGFloat)alpha;
        [Export("colorWithAlphaComponent:")]
        CPTColor ColorWithAlphaComponent(nfloat alpha);
    }

    [Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTGraphNotification  _Nonnull const CPTGraphNeedsRedrawNotification;
        [Field("CPTGraphNeedsRedrawNotification", "__Internal")]
        NSString CPTGraphNeedsRedrawNotification { get; }

        // extern CPTGraphNotification  _Nonnull const CPTGraphDidAddPlotSpaceNotification;
        [Field("CPTGraphDidAddPlotSpaceNotification", "__Internal")]
        NSString CPTGraphDidAddPlotSpaceNotification { get; }

        // extern CPTGraphNotification  _Nonnull const CPTGraphDidRemovePlotSpaceNotification;
        [Field("CPTGraphDidRemovePlotSpaceNotification", "__Internal")]
        NSString CPTGraphDidRemovePlotSpaceNotification { get; }

        // extern CPTGraphPlotSpaceKey  _Nonnull const CPTGraphPlotSpaceNotificationKey;
        [Field("CPTGraphPlotSpaceNotificationKey", "__Internal")]
        NSString CPTGraphPlotSpaceNotificationKey { get; }
    }

    // @interface CPTGraph : CPTBorderedLayer
    [BaseType(typeof(CPTBorderedLayer))]
    interface CPTGraph
    {
        // @property (readwrite, nonatomic, weak) CPTGraphHostingView * _Nullable hostingView;
        [NullAllowed, Export("hostingView", ArgumentSemantic.Weak)]
        CPTGraphHostingView HostingView { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (readwrite, copy, nonatomic) NSAttributedString * _Nullable attributedTitle;
        [NullAllowed, Export("attributedTitle", ArgumentSemantic.Copy)]
        NSAttributedString AttributedTitle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable titleTextStyle;
        [NullAllowed, Export("titleTextStyle", ArgumentSemantic.Copy)]
        CPTTextStyle TitleTextStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint titleDisplacement;
        [Export("titleDisplacement", ArgumentSemantic.Assign)]
        CGPoint TitleDisplacement { get; set; }

        // @property (assign, readwrite, nonatomic) CPTRectAnchor titlePlotAreaFrameAnchor;
        [Export("titlePlotAreaFrameAnchor", ArgumentSemantic.Assign)]
        CPTRectAnchor TitlePlotAreaFrameAnchor { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisSet * _Nullable axisSet;
        [NullAllowed, Export("axisSet", ArgumentSemantic.Strong)]
        CPTAxisSet AxisSet { get; set; }

        // @property (readwrite, nonatomic, strong) CPTPlotAreaFrame * _Nullable plotAreaFrame;
        [NullAllowed, Export("plotAreaFrame", ArgumentSemantic.Strong)]
        CPTPlotAreaFrame PlotAreaFrame { get; set; }

        // @property (readonly, nonatomic) CPTPlotSpace * _Nullable defaultPlotSpace;
        [NullAllowed, Export("defaultPlotSpace")]
        CPTPlotSpace DefaultPlotSpace { get; }

        // @property (readwrite, nonatomic, strong) CPTNumberArray * _Nullable topDownLayerOrder;
        [NullAllowed, Export("topDownLayerOrder", ArgumentSemantic.Strong)]
        NSNumber[] TopDownLayerOrder { get; set; }

        // @property (readwrite, nonatomic, strong) CPTLegend * _Nullable legend;
        [NullAllowed, Export("legend", ArgumentSemantic.Strong)]
        CPTLegend Legend { get; set; }

        // @property (assign, readwrite, nonatomic) CPTRectAnchor legendAnchor;
        [Export("legendAnchor", ArgumentSemantic.Assign)]
        CPTRectAnchor LegendAnchor { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint legendDisplacement;
        [Export("legendDisplacement", ArgumentSemantic.Assign)]
        CGPoint LegendDisplacement { get; set; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)reloadDataIfNeeded;
        [Export("reloadDataIfNeeded")]
        void ReloadDataIfNeeded();

        // -(CPTPlotArray * _Nonnull)allPlots;
        [Export("allPlots")]
        // [Verify(MethodToProperty)]
        CPTPlot[] AllPlots { get; }

        // -(CPTPlot * _Nullable)plotAtIndex:(NSUInteger)idx;
        [Export("plotAtIndex:")]
        [return: NullAllowed]
        CPTPlot PlotAtIndex(nuint idx);

        // -(CPTPlot * _Nullable)plotWithIdentifier:(id<NSCopying> _Nullable)identifier;
        [Export("plotWithIdentifier:")]
        [return: NullAllowed]
        CPTPlot PlotWithIdentifier([NullAllowed] NSObject identifier);

        // -(void)addPlot:(CPTPlot * _Nonnull)plot;
        [Export("addPlot:")]
        void AddPlot(CPTPlot plot);

        // -(void)addPlot:(CPTPlot * _Nonnull)plot toPlotSpace:(CPTPlotSpace * _Nullable)space;
        [Export("addPlot:toPlotSpace:")]
        void AddPlot(CPTPlot plot, [NullAllowed] CPTPlotSpace space);

        // -(void)removePlot:(CPTPlot * _Nullable)plot;
        [Export("removePlot:")]
        void RemovePlot([NullAllowed] CPTPlot plot);

        // -(void)removePlotWithIdentifier:(id<NSCopying> _Nullable)identifier;
        [Export("removePlotWithIdentifier:")]
        void RemovePlotWithIdentifier([NullAllowed] NSCopying identifier);

        // -(void)insertPlot:(CPTPlot * _Nonnull)plot atIndex:(NSUInteger)idx;
        [Export("insertPlot:atIndex:")]
        void InsertPlot(CPTPlot plot, nuint idx);

        // -(void)insertPlot:(CPTPlot * _Nonnull)plot atIndex:(NSUInteger)idx intoPlotSpace:(CPTPlotSpace * _Nullable)space;
        [Export("insertPlot:atIndex:intoPlotSpace:")]
        void InsertPlot(CPTPlot plot, nuint idx, [NullAllowed] CPTPlotSpace space);

        // -(CPTPlotSpaceArray * _Nonnull)allPlotSpaces;
        [Export("allPlotSpaces")]
        // [Verify(MethodToProperty)]
        CPTPlotSpace[] AllPlotSpaces { get; }

        // -(CPTPlotSpace * _Nullable)plotSpaceAtIndex:(NSUInteger)idx;
        [Export("plotSpaceAtIndex:")]
        [return: NullAllowed]
        CPTPlotSpace PlotSpaceAtIndex(nuint idx);

        // -(CPTPlotSpace * _Nullable)plotSpaceWithIdentifier:(id<NSCopying> _Nullable)identifier;
        [Export("plotSpaceWithIdentifier:")]
        [return: NullAllowed]
        CPTPlotSpace PlotSpaceWithIdentifier([NullAllowed] NSCopying identifier);

        // -(void)addPlotSpace:(CPTPlotSpace * _Nonnull)space;
        [Export("addPlotSpace:")]
        void AddPlotSpace(CPTPlotSpace space);

        // -(void)removePlotSpace:(CPTPlotSpace * _Nullable)plotSpace;
        [Export("removePlotSpace:")]
        void RemovePlotSpace([NullAllowed] CPTPlotSpace plotSpace);

        // -(void)applyTheme:(CPTTheme * _Nullable)theme;
        [Export("applyTheme:")]
        void ApplyTheme([NullAllowed] CPTTheme theme);

        // -(CPTPlotSpace * _Nullable)newPlotSpace;
        [NullAllowed, Export("newPlotSpace")]
        // [Verify(MethodToProperty)]
        CPTPlotSpace NewPlotSpace { get; }

        // -(CPTAxisSet * _Nullable)newAxisSet;
        [NullAllowed, Export("newAxisSet")]
        // [Verify(MethodToProperty)]
        CPTAxisSet NewAxisSet { get; }
    }

    // @interface AbstractFactoryMethods (CPTGraph)
    /*
    [Category]
    [BaseType(typeof(CPTGraph))]
    interface CPTGraph_AbstractFactoryMethods
    {
        // -(CPTPlotSpace * _Nullable)newPlotSpace;
        [NullAllowed, Export("newPlotSpace")]
        // [Verify(MethodToProperty)]
        CPTPlotSpace NewPlotSpace { get; }

        // -(CPTAxisSet * _Nullable)newAxisSet;
        [NullAllowed, Export("newAxisSet")]
        // [Verify(MethodToProperty)]
        CPTAxisSet NewAxisSet { get; }
    }
    */

    // @interface CPTPlotSymbol : NSObject <NSCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTPlotSymbol : INSCopying, INSCoding, INSSecureCoding
    {
        // @property (assign, readwrite, nonatomic) CGPoint anchorPoint;
        [Export("anchorPoint", ArgumentSemantic.Assign)]
        CGPoint AnchorPoint { get; set; }

        // @property (assign, readwrite, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // @property (assign, readwrite, nonatomic) CPTPlotSymbolType symbolType;
        [Export("symbolType", ArgumentSemantic.Assign)]
        CPTPlotSymbolType SymbolType { get; set; }

        // @property (readwrite, nonatomic, strong) CPTLineStyle * _Nullable lineStyle;
        [NullAllowed, Export("lineStyle", ArgumentSemantic.Strong)]
        CPTLineStyle LineStyle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Strong)]
        CPTFill Fill { get; set; }

        // @property (readwrite, copy, nonatomic) CPTShadow * _Nullable shadow;
        [NullAllowed, Export("shadow", ArgumentSemantic.Copy)]
        CPTShadow Shadow { get; set; }

        // @property (assign, readwrite, nonatomic) CGPathRef _Nullable customSymbolPath;
        [NullAllowed, Export("customSymbolPath", ArgumentSemantic.Assign)]
        CGPath CustomSymbolPath { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL usesEvenOddClipRule;
        [Export("usesEvenOddClipRule")]
        bool UsesEvenOddClipRule { get; set; }

        // +(instancetype _Nonnull)plotSymbol;
        [Static]
        [Export("plotSymbol")]
        CPTPlotSymbol PlotSymbol { get; }

        // +(instancetype _Nonnull)crossPlotSymbol;
        [Static]
        [Export("crossPlotSymbol")]
        CPTPlotSymbol CrossPlotSymbol { get; }

        // +(instancetype _Nonnull)ellipsePlotSymbol;
        [Static]
        [Export("ellipsePlotSymbol")]
        CPTPlotSymbol EllipsePlotSymbol { get; }

        // +(instancetype _Nonnull)rectanglePlotSymbol;
        [Static]
        [Export("rectanglePlotSymbol")]
        CPTPlotSymbol RectanglePlotSymbol { get; }

        // +(instancetype _Nonnull)plusPlotSymbol;
        [Static]
        [Export("plusPlotSymbol")]
        CPTPlotSymbol PlusPlotSymbol { get; }

        // +(instancetype _Nonnull)starPlotSymbol;
        [Static]
        [Export("starPlotSymbol")]
        CPTPlotSymbol StarPlotSymbol { get; }

        // +(instancetype _Nonnull)diamondPlotSymbol;
        [Static]
        [Export("diamondPlotSymbol")]
        CPTPlotSymbol DiamondPlotSymbol { get; }

        // +(instancetype _Nonnull)trianglePlotSymbol;
        [Static]
        [Export("trianglePlotSymbol")]
        CPTPlotSymbol TrianglePlotSymbol { get; }

        // +(instancetype _Nonnull)pentagonPlotSymbol;
        [Static]
        [Export("pentagonPlotSymbol")]
        CPTPlotSymbol PentagonPlotSymbol { get; }

        // +(instancetype _Nonnull)hexagonPlotSymbol;
        [Static]
        [Export("hexagonPlotSymbol")]
        CPTPlotSymbol HexagonPlotSymbol { get; }

        // +(instancetype _Nonnull)dashPlotSymbol;
        [Static]
        [Export("dashPlotSymbol")]
        CPTPlotSymbol DashPlotSymbol { get; }

        // +(instancetype _Nonnull)snowPlotSymbol;
        [Static]
        [Export("snowPlotSymbol")]
        CPTPlotSymbol SnowPlotSymbol { get; }

        // +(instancetype _Nonnull)customPlotSymbolWithPath:(CGPathRef _Nullable)aPath;
        [Static]
        [Export("customPlotSymbolWithPath:")]
        unsafe CPTPlotSymbol CustomPlotSymbolWithPath([NullAllowed] CGPath path);

        // -(void)renderInContext:(CGContextRef _Nonnull)context atPoint:(CGPoint)center scale:(CGFloat)scale alignToPixels:(BOOL)alignToPixels;
        [Export("renderInContext:atPoint:scale:alignToPixels:")]
        unsafe void RenderInContext(CGContext context, CGPoint center, nfloat scale, bool alignToPixels);

        // -(void)renderAsVectorInContext:(CGContextRef _Nonnull)context atPoint:(CGPoint)center scale:(CGFloat)scale;
        [Export("renderAsVectorInContext:atPoint:scale:")]
        unsafe void RenderAsVectorInContext(CGContext context, CGPoint center, nfloat scale);
    }

    // Fix CPTAnimationOperation

    //[Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CPTEdgeInsets CPTEdgeInsetsZero;
        //[Field("CPTEdgeInsetsZero", "__Internal")]
        //CPTEdgeInsets CPTEdgeInsetsZero { get; }

        // extern const NSStringDrawingOptions CPTStringDrawingOptions;
        [Field("CPTStringDrawingOptions", "__Internal")]
        NSStringDrawingOptions CPTStringDrawingOptions { get; }
    }

    // typedef void (^CPTQuickLookImageBlock)(CGContextRef _Nonnull, CGFloat, CGRect);
    unsafe delegate void CPTQuickLookImageBlock(CGContext arg0, nfloat arg1, CGRect arg2);

    // @interface CPTAnimationOperation : NSObject
    [BaseType(typeof(NSObject))]
    interface CPTAnimationOperation
    {
        // @property (nonatomic, strong) CPTAnimationPeriod * _Nonnull period;
        [Export("period", ArgumentSemantic.Strong)]
        CPTAnimationPeriod Period { get; set; }

        // @property (assign, nonatomic) CPTAnimationCurve animationCurve;
        [Export("animationCurve", ArgumentSemantic.Assign)]
        CPTAnimationCurve AnimationCurve { get; set; }

        // @property (nonatomic, strong) id _Nonnull boundObject;
        [Export("boundObject", ArgumentSemantic.Strong)]
        NSObject BoundObject { get; set; }

        // @property (nonatomic) SEL _Nonnull boundGetter;
        [Export("boundGetter", ArgumentSemantic.Assign)]
        Selector BoundGetter { get; set; }

        // @property (nonatomic) SEL _Nonnull boundSetter;
        [Export("boundSetter", ArgumentSemantic.Assign)]
        Selector BoundSetter { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        CPTAnimationDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CPTAnimationDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (getter = isCanceled, atomic) BOOL canceled;
        [Export("canceled")]
        bool Canceled { [Bind("isCanceled")] get; set; }

        // @property (readwrite, copy, nonatomic) id<NSCopying,NSObject> _Nullable identifier;
        [NullAllowed, Export("identifier", ArgumentSemantic.Copy)]
        NSObject Identifier { get; set; }

        // @property (readwrite, copy, nonatomic) NSDictionary * _Nullable userInfo;
        [NullAllowed, Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; set; }

        // -(instancetype _Nonnull)initWithAnimationPeriod:(CPTAnimationPeriod * _Nonnull)animationPeriod animationCurve:(CPTAnimationCurve)curve object:(id _Nonnull)object getter:(SEL _Nonnull)getter setter:(SEL _Nonnull)setter __attribute__((objc_designated_initializer));
        [Export("initWithAnimationPeriod:animationCurve:object:getter:setter:")]
        [DesignatedInitializer]
        IntPtr Constructor(CPTAnimationPeriod animationPeriod, CPTAnimationCurve curve, NSObject @object, Selector getter, Selector setter);
    }

    // @interface CPTAnimationPeriod : NSObject
    [BaseType(typeof(NSObject))]
    interface CPTAnimationPeriod
    {
        // @property (readwrite, copy, nonatomic) NSValue * _Nullable startValue;
        [NullAllowed, Export("startValue", ArgumentSemantic.Copy)]
        NSValue StartValue { get; set; }

        // @property (readwrite, copy, nonatomic) NSValue * _Nullable endValue;
        [NullAllowed, Export("endValue", ArgumentSemantic.Copy)]
        NSValue EndValue { get; set; }

        // @property (readonly, nonatomic) Class _Nullable valueClass;
        [NullAllowed, Export("valueClass")]
        Class ValueClass { get; }

        // @property (readwrite, nonatomic) CGFloat duration;
        [Export("duration")]
        nfloat Duration { get; set; }

        // @property (readwrite, nonatomic) CGFloat delay;
        [Export("delay")]
        nfloat Delay { get; set; }

        // @property (readonly, nonatomic) CGFloat startOffset;
        [Export("startOffset")]
        nfloat StartOffset { get; }

        // +(instancetype _Nonnull)periodWithStart:(CGFloat)aStart end:(CGFloat)anEnd duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStart:end:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStart(nfloat aStart, nfloat anEnd, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartPoint:(CGPoint)aStartPoint endPoint:(CGPoint)anEndPoint duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartPoint:endPoint:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartPoint(CGPoint aStartPoint, CGPoint anEndPoint, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartSize:(CGSize)aStartSize endSize:(CGSize)anEndSize duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartSize:endSize:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartSize(CGSize aStartSize, CGSize anEndSize, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartRect:(CGRect)aStartRect endRect:(CGRect)anEndRect duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartRect:endRect:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartRect(CGRect aStartRect, CGRect anEndRect, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartDecimal:(NSDecimal)aStartDecimal endDecimal:(NSDecimal)anEndDecimal duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartDecimal:endDecimal:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartDecimal(NSDecimal aStartDecimal, NSDecimal anEndDecimal, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartNumber:(NSNumber * _Nullable)aStartNumber endNumber:(NSNumber * _Nonnull)anEndNumber duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartNumber:endNumber:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartNumber([NullAllowed] NSNumber aStartNumber, NSNumber anEndNumber, nfloat aDuration, nfloat aDelay);

        // +(instancetype _Nonnull)periodWithStartPlotRange:(CPTPlotRange * _Nonnull)aStartPlotRange endPlotRange:(CPTPlotRange * _Nonnull)anEndPlotRange duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Static]
        [Export("periodWithStartPlotRange:endPlotRange:duration:withDelay:")]
        CPTAnimationPeriod PeriodWithStartPlotRange(CPTPlotRange aStartPlotRange, CPTPlotRange anEndPlotRange, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStart:(CGFloat)aStart end:(CGFloat)anEnd duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStart:end:duration:withDelay:")]
        IntPtr Constructor(nfloat aStart, nfloat anEnd, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartPoint:(CGPoint)aStartPoint endPoint:(CGPoint)anEndPoint duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartPoint:endPoint:duration:withDelay:")]
        IntPtr Constructor(CGPoint aStartPoint, CGPoint anEndPoint, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartSize:(CGSize)aStartSize endSize:(CGSize)anEndSize duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartSize:endSize:duration:withDelay:")]
        IntPtr Constructor(CGSize aStartSize, CGSize anEndSize, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartRect:(CGRect)aStartRect endRect:(CGRect)anEndRect duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartRect:endRect:duration:withDelay:")]
        IntPtr Constructor(CGRect aStartRect, CGRect anEndRect, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartDecimal:(NSDecimal)aStartDecimal endDecimal:(NSDecimal)anEndDecimal duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartDecimal:endDecimal:duration:withDelay:")]
        IntPtr Constructor(NSDecimal aStartDecimal, NSDecimal anEndDecimal, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartNumber:(NSNumber * _Nullable)aStartNumber endNumber:(NSNumber * _Nonnull)anEndNumber duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartNumber:endNumber:duration:withDelay:")]
        IntPtr Constructor([NullAllowed] NSNumber aStartNumber, NSNumber anEndNumber, nfloat aDuration, nfloat aDelay);

        // -(instancetype _Nonnull)initWithStartPlotRange:(CPTPlotRange * _Nonnull)aStartPlotRange endPlotRange:(CPTPlotRange * _Nonnull)anEndPlotRange duration:(CGFloat)aDuration withDelay:(CGFloat)aDelay;
        [Export("initWithStartPlotRange:endPlotRange:duration:withDelay:")]
        IntPtr Constructor(CPTPlotRange aStartPlotRange, CPTPlotRange anEndPlotRange, nfloat aDuration, nfloat aDelay);
    }

    // @interface AbstractMethods (CPTAnimationPeriod)
    [Category]
    [BaseType(typeof(CPTAnimationPeriod))]
    interface CPTAnimationPeriod_AbstractMethods
    {
        // -(void)setStartValueFromObject:(id _Nonnull)boundObject propertyGetter:(SEL _Nonnull)boundGetter;
        [Export("setStartValueFromObject:propertyGetter:")]
        void SetStartValueFromObject(NSObject boundObject, Selector boundGetter);

        // -(NSValue * _Nonnull)tweenedValueForProgress:(CGFloat)progress;
        [Export("tweenedValueForProgress:")]
        NSValue TweenedValueForProgress(nfloat progress);

        // -(BOOL)canStartWithValueFromObject:(id _Nonnull)boundObject propertyGetter:(SEL _Nonnull)boundGetter;
        [Export("canStartWithValueFromObject:propertyGetter:")]
        bool CanStartWithValueFromObject(NSObject boundObject, Selector boundGetter);
    }

    // @interface CPTAnimationPeriodAdditions (CPTAnimation)
    /*
    [Category]
    [BaseType(typeof(CPTAnimation))]
    interface CPTAnimation_CPTAnimationPeriodAdditions
    {
        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:from:to:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:from:to:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property from:(CGFloat)from to:(CGFloat)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:from:to:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, nfloat from, nfloat to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPoint:(CGPoint)from toPoint:(CGPoint)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromPoint:toPoint:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGPoint from, CGPoint to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromSize:(CGSize)from toSize:(CGSize)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromSize:toSize:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGSize from, CGSize to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromRect:(CGRect)from toRect:(CGRect)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromRect:toRect:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CGRect from, CGRect to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromDecimal:(NSDecimal)from toDecimal:(NSDecimal)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromDecimal:toDecimal:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, NSDecimal from, NSDecimal to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromNumber:(NSNumber * _Nullable)from toNumber:(NSNumber * _Nonnull)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromNumber:toNumber:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, [NullAllowed] NSNumber from, NSNumber to, nfloat duration);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration withDelay:(CGFloat)delay animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:withDelay:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration, nfloat delay, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration animationCurve:(CPTAnimationCurve)animationCurve delegate:(id<CPTAnimationDelegate> _Nullable)delegate;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:animationCurve:delegate:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration, CPTAnimationCurve animationCurve, [NullAllowed] ICPTAnimationDelegate animationDelegate);

        // +(CPTAnimationOperation * _Nonnull)animate:(id _Nonnull)object property:(NSString * _Nonnull)property fromPlotRange:(CPTPlotRange * _Nonnull)from toPlotRange:(CPTPlotRange * _Nonnull)to duration:(CGFloat)duration;
        [Static]
        [Export("animate:property:fromPlotRange:toPlotRange:duration:")]
        CPTAnimationOperation Animate(NSObject @object, string property, CPTPlotRange from, CPTPlotRange to, nfloat duration);
    }
    */

    // #3 - CPTLayer
    // typedef void (^CPTQuickLookImageBlock)(CGContextRef _Nonnull, CGFloat, CGRect);
    //unsafe delegate void CPTQuickLookImageBlock(CGContext arg0, nfloat arg1, CGRect arg2);

    interface ICPTResponder { }

    // @protocol CPTResponder <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CPTResponder
    {
        // @required -(BOOL)pointingDeviceDownEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)interactionPoint;
        [Abstract]
        [Export("pointingDeviceDownEvent:atPoint:")]
        bool PointingDeviceDownEvent(UIEvent @event, CGPoint interactionPoint);

        // @required -(BOOL)pointingDeviceUpEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)interactionPoint;
        [Abstract]
        [Export("pointingDeviceUpEvent:atPoint:")]
        bool PointingDeviceUpEvent(UIEvent @event, CGPoint interactionPoint);

        // @required -(BOOL)pointingDeviceDraggedEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)interactionPoint;
        [Abstract]
        [Export("pointingDeviceDraggedEvent:atPoint:")]
        bool PointingDeviceDraggedEvent(UIEvent @event, CGPoint interactionPoint);

        // @required -(BOOL)pointingDeviceCancelledEvent:(CPTNativeEvent * _Nonnull)event;
        [Abstract]
        [Export("pointingDeviceCancelledEvent:")]
        bool PointingDeviceCancelledEvent(UIEvent @event);
    }

    //[Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTLayerNotification  _Nonnull const CPTLayerBoundsDidChangeNotification;
        [Field("CPTLayerBoundsDidChangeNotification", "__Internal")]
        NSString CPTLayerBoundsDidChangeNotification { get; }
    }

	interface ICPTLayerDelegate {}

    // @protocol CPTLayerDelegate <CALayerDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTLayerDelegate : ICALayerDelegate
    {
    }

    // @interface CPTLayer : CALayer <CPTResponder, NSSecureCoding>
    [BaseType(typeof(CALayer))]
    interface CPTLayer : ICPTResponder, INSSecureCoding
    {
        // @property (readwrite, nonatomic, weak) CPTGraph * _Nullable graph;
        [NullAllowed, Export("graph", ArgumentSemantic.Weak)]
        CPTGraph Graph { get; set; }

        // @property (readwrite, nonatomic) CGFloat paddingLeft;
        [Export("paddingLeft")]
        nfloat PaddingLeft { get; set; }

        // @property (readwrite, nonatomic) CGFloat paddingTop;
        [Export("paddingTop")]
        nfloat PaddingTop { get; set; }

        // @property (readwrite, nonatomic) CGFloat paddingRight;
        [Export("paddingRight")]
        nfloat PaddingRight { get; set; }

        // @property (readwrite, nonatomic) CGFloat paddingBottom;
        [Export("paddingBottom")]
        nfloat PaddingBottom { get; set; }

        // @property (readwrite) CGFloat contentsScale;
        //[Export("contentsScale")]
        //nfloat ContentsScale { get; set; }

        // @property (readonly, nonatomic) BOOL useFastRendering;
        [Export("useFastRendering")]
        bool UseFastRendering { get; }

        // @property (readwrite, copy, nonatomic) CPTShadow * _Nullable shadow;
        [NullAllowed, Export("shadow", ArgumentSemantic.Copy)]
        CPTShadow Shadow { get; set; }

        // @property (readonly, nonatomic) CGSize shadowMargin;
        [Export("shadowMargin")]
        CGSize ShadowMargin { get; }

        // @property (assign, readwrite, nonatomic) BOOL masksToBorder;
        [Export("masksToBorder")]
        bool MasksToBorder { get; set; }

        // @property (assign, readwrite, nonatomic) CGPathRef _Nullable outerBorderPath;
        [NullAllowed, Export("outerBorderPath", ArgumentSemantic.Assign)]
        CGPath OuterBorderPath { get; set; }

        // @property (assign, readwrite, nonatomic) CGPathRef _Nullable innerBorderPath;
        [NullAllowed, Export("innerBorderPath", ArgumentSemantic.Assign)]
        CGPath InnerBorderPath { get; set; }

        // @property (readonly, nonatomic) CGPathRef _Nullable maskingPath;
        [NullAllowed, Export("maskingPath")]
        CGPath MaskingPath { get; }

        // @property (readonly, nonatomic) CGPathRef _Nullable sublayerMaskingPath;
        [NullAllowed, Export("sublayerMaskingPath")]
        CGPath SublayerMaskingPath { get; }

        // @property (readwrite, copy, nonatomic) id<NSCopying,NSCoding,NSObject> _Nullable identifier;
        [NullAllowed, Export("identifier", ArgumentSemantic.Copy)]
        NSObject Identifier { get; set; }

        // @property (readonly, nonatomic) CPTSublayerSet * _Nullable sublayersExcludedFromAutomaticLayout;
        [NullAllowed, Export("sublayersExcludedFromAutomaticLayout")]
        NSSet<CALayer> SublayersExcludedFromAutomaticLayout { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)newFrame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect newFrame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor(CPTLayer layer);

        // -(void)renderAsVectorInContext:(CGContextRef _Nonnull)context;
        [Export("renderAsVectorInContext:")]
        void RenderAsVectorInContext(CGContext context);

        // -(void)recursivelyRenderInContext:(CGContextRef _Nonnull)context;
        [Export("recursivelyRenderInContext:")]
        void RecursivelyRenderInContext(CGContext context);

        // -(void)layoutAndRenderInContext:(CGContextRef _Nonnull)context;
        [Export("layoutAndRenderInContext:")]
        void LayoutAndRenderInContext(CGContext context);

        // -(NSData * _Nonnull)dataForPDFRepresentationOfLayer;
        [Export("dataForPDFRepresentationOfLayer")]
        // [Verify(MethodToProperty)]
        NSData DataForPDFRepresentationOfLayer { get; }

        // -(void)applySublayerMaskToContext:(CGContextRef _Nonnull)context forSublayer:(CPTLayer * _Nonnull)sublayer withOffset:(CGPoint)offset;
        [Export("applySublayerMaskToContext:forSublayer:withOffset:")]
        void ApplySublayerMaskToContext(CGContext context, CPTLayer sublayer, CGPoint offset);

        // -(void)applyMaskToContext:(CGContextRef _Nonnull)context;
        [Export("applyMaskToContext:")]
        void ApplyMaskToContext(CGContext context);

        // -(void)pixelAlign;
        [Export("pixelAlign")]
        void PixelAlign();

        // -(void)sublayerMarginLeft:(CGFloat * _Nonnull)left top:(CGFloat * _Nonnull)top right:(CGFloat * _Nonnull)right bottom:(CGFloat * _Nonnull)bottom;
        [Export("sublayerMarginLeft:top:right:bottom:")]
        void SublayerMarginLeft(IntPtr left, IntPtr top, IntPtr right, IntPtr bottom);

        // -(void)logLayers;
        [Export("logLayers")]
        void LogLayers();
    }

    // #4 Shadow
    // @interface CPTShadow
    [BaseType(typeof(NSObject))]
    interface CPTShadow
    {
        // @property (readonly, nonatomic) int shadowOffset;
        [Export("shadowOffset")]
        int ShadowOffset { get; }

        // @property (readonly, nonatomic) int shadowBlurRadius;
        [Export("shadowBlurRadius")]
        int ShadowBlurRadius { get; }

        // @property (readonly, nonatomic) CPTColor * _Nullable shadowColor;
        [NullAllowed, Export("shadowColor")]
        CPTColor ShadowColor { get; }

        // +(instancetype _Nonnull)shadow;
        [Static]
        [Export("shadow")]
        CPTShadow Shadow();

        // -(void)setShadowInContext:(id)context;
        [Export("setShadowInContext:")]
        void SetShadowInContext(NSObject context);
    }

    // 5
    // @interface CPTAxisLabel : NSObject <NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTAxisLabel : INSCoding, INSSecureCoding
    {
        // @property (readwrite, nonatomic, strong) CPTLayer * _Nullable contentLayer;
        [NullAllowed, Export("contentLayer", ArgumentSemantic.Strong)]
        CPTLayer ContentLayer { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat offset;
        [Export("offset")]
        nfloat Offset { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat rotation;
        [Export("rotation")]
        nfloat Rotation { get; set; }

        // @property (assign, readwrite, nonatomic) CPTAlignment alignment;
        [Export("alignment", ArgumentSemantic.Assign)]
        CPTAlignment Alignment { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull tickLocation;
        [Export("tickLocation", ArgumentSemantic.Strong)]
        NSNumber TickLocation { get; set; }

        // -(instancetype _Nonnull)initWithText:(NSString * _Nullable)newText textStyle:(CPTTextStyle * _Nullable)style;
        [Export("initWithText:textStyle:")]
        IntPtr Constructor([NullAllowed] string newText, [NullAllowed] CPTTextStyle style);

        // -(instancetype _Nonnull)initWithContentLayer:(CPTLayer * _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithContentLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor(CPTLayer layer);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // -(void)positionRelativeToViewPoint:(CGPoint)point forCoordinate:(CPTCoordinate)coordinate inDirection:(CPTSign)direction;
        [Export("positionRelativeToViewPoint:forCoordinate:inDirection:")]
        void PositionRelativeToViewPoint(CGPoint point, CPTCoordinate coordinate, CPTSign direction);

        // -(void)positionBetweenViewPoint:(CGPoint)firstPoint andViewPoint:(CGPoint)secondPoint forCoordinate:(CPTCoordinate)coordinate inDirection:(CPTSign)direction;
        [Export("positionBetweenViewPoint:andViewPoint:forCoordinate:inDirection:")]
        void PositionBetweenViewPoint(CGPoint firstPoint, CGPoint secondPoint, CPTCoordinate coordinate, CPTSign direction);
    }

    // 6
    // @interface CPTLineStyle : NSObject <NSCopying, NSMutableCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTLineStyle : INSCopying, INSMutableCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, nonatomic) CGLineCap lineCap;
        [Export("lineCap")]
        CGLineCap LineCap { get; }

        // @property (readonly, nonatomic) CGLineJoin lineJoin;
        [Export("lineJoin")]
        CGLineJoin LineJoin { get; }

        // @property (readonly, nonatomic) CGFloat miterLimit;
        [Export("miterLimit")]
        nfloat MiterLimit { get; }

        // @property (readonly, nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; }

        // @property (readonly, nonatomic) CPTNumberArray * _Nullable dashPattern;
        [NullAllowed, Export("dashPattern")]
        NSNumber[] DashPattern { get; }

        // @property (readonly, nonatomic) CGFloat patternPhase;
        [Export("patternPhase")]
        nfloat PatternPhase { get; }

        // @property (readonly, nonatomic) CPTColor * _Nullable lineColor;
        [NullAllowed, Export("lineColor")]
        CPTColor LineColor { get; }

        // @property (readonly, nonatomic) CPTFill * _Nullable lineFill;
        [NullAllowed, Export("lineFill")]
        CPTFill LineFill { get; }

        // @property (readonly, nonatomic) CPTGradient * _Nullable lineGradient;
        [NullAllowed, Export("lineGradient")]
        CPTGradient LineGradient { get; }

        // @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; }

        // +(instancetype _Nonnull)lineStyle;
        [Static]
        [Export("lineStyle")]
        CPTLineStyle LineStyle { get; }

        // +(instancetype _Nonnull)lineStyleWithStyle:(CPTLineStyle * _Nullable)lineStyle;
        [Static]
        [Export("lineStyleWithStyle:")]
        CPTLineStyle LineStyleWithStyle([NullAllowed] CPTLineStyle lineStyle);

        // -(void)setLineStyleInContext:(CGContextRef _Nonnull)context;
        [Export("setLineStyleInContext:")]
        unsafe void SetLineStyleInContext(CGContext context);

        // -(void)strokePathInContext:(CGContextRef _Nonnull)context;
        [Export("strokePathInContext:")]
        unsafe void StrokePathInContext(CGContext context);

        // -(void)strokeRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("strokeRect:inContext:")]
        unsafe void StrokeRect(CGRect rect, CGContext context);
    }

    // 7
    // @interface CPTPlotRange : NSObject <NSCopying, NSMutableCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTPlotRange : INSCopying, INSMutableCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull location;
        [Export("location", ArgumentSemantic.Strong)]
        NSNumber Location { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull length;
        [Export("length", ArgumentSemantic.Strong)]
        NSNumber Length { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull end;
        [Export("end", ArgumentSemantic.Strong)]
        NSNumber End { get; }

        // @property (readonly, nonatomic) NSDecimal locationDecimal;
        [Export("locationDecimal")]
        NSDecimal LocationDecimal { get; }

        // @property (readonly, nonatomic) NSDecimal lengthDecimal;
        [Export("lengthDecimal")]
        NSDecimal LengthDecimal { get; }

        // @property (readonly, nonatomic) NSDecimal endDecimal;
        [Export("endDecimal")]
        NSDecimal EndDecimal { get; }

        // @property (readonly, nonatomic) double locationDouble;
        [Export("locationDouble")]
        double LocationDouble { get; }

        // @property (readonly, nonatomic) double lengthDouble;
        [Export("lengthDouble")]
        double LengthDouble { get; }

        // @property (readonly, nonatomic) double endDouble;
        [Export("endDouble")]
        double EndDouble { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull minLimit;
        [Export("minLimit", ArgumentSemantic.Strong)]
        NSNumber MinLimit { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull midPoint;
        [Export("midPoint", ArgumentSemantic.Strong)]
        NSNumber MidPoint { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull maxLimit;
        [Export("maxLimit", ArgumentSemantic.Strong)]
        NSNumber MaxLimit { get; }

        // @property (readonly, nonatomic) NSDecimal minLimitDecimal;
        [Export("minLimitDecimal")]
        NSDecimal MinLimitDecimal { get; }

        // @property (readonly, nonatomic) NSDecimal midPointDecimal;
        [Export("midPointDecimal")]
        NSDecimal MidPointDecimal { get; }

        // @property (readonly, nonatomic) NSDecimal maxLimitDecimal;
        [Export("maxLimitDecimal")]
        NSDecimal MaxLimitDecimal { get; }

        // @property (readonly, nonatomic) double minLimitDouble;
        [Export("minLimitDouble")]
        double MinLimitDouble { get; }

        // @property (readonly, nonatomic) double midPointDouble;
        [Export("midPointDouble")]
        double MidPointDouble { get; }

        // @property (readonly, nonatomic) double maxLimitDouble;
        [Export("maxLimitDouble")]
        double MaxLimitDouble { get; }

        // +(instancetype _Nonnull)plotRangeWithLocation:(NSNumber * _Nonnull)loc length:(NSNumber * _Nonnull)len;
        [Static]
        [Export("plotRangeWithLocation:length:")]
		CPTPlotRange FromLocation(NSNumber loc, NSNumber len);

        // +(instancetype _Nonnull)plotRangeWithLocationDecimal:(NSDecimal)loc lengthDecimal:(NSDecimal)len;
        [Static]
        [Export("plotRangeWithLocationDecimal:lengthDecimal:")]
		CPTPlotRange FromLocationDecimal(NSDecimal loc, NSDecimal len);

        // -(instancetype _Nonnull)initWithLocation:(NSNumber * _Nonnull)loc length:(NSNumber * _Nonnull)len;
        [Export("initWithLocation:length:")]
        IntPtr Constructor(NSNumber loc, NSNumber len);

        // -(instancetype _Nonnull)initWithLocationDecimal:(NSDecimal)loc lengthDecimal:(NSDecimal)len __attribute__((objc_designated_initializer));
        [Export("initWithLocationDecimal:lengthDecimal:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDecimal loc, NSDecimal len);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // -(BOOL)contains:(NSDecimal)number;
        [Export("contains:")]
        bool Contains(NSDecimal number);

        // -(BOOL)containsDouble:(double)number;
        [Export("containsDouble:")]
        bool ContainsDouble(double number);

        // -(BOOL)containsNumber:(NSNumber * _Nullable)number;
        [Export("containsNumber:")]
        bool ContainsNumber([NullAllowed] NSNumber number);

        // -(BOOL)isEqualToRange:(CPTPlotRange * _Nullable)otherRange;
        [Export("isEqualToRange:")]
        bool IsEqualToRange([NullAllowed] CPTPlotRange otherRange);

        // -(BOOL)containsRange:(CPTPlotRange * _Nullable)otherRange;
        [Export("containsRange:")]
        bool ContainsRange([NullAllowed] CPTPlotRange otherRange);

        // -(BOOL)intersectsRange:(CPTPlotRange * _Nullable)otherRange;
        [Export("intersectsRange:")]
        bool IntersectsRange([NullAllowed] CPTPlotRange otherRange);

        // -(CPTPlotRangeComparisonResult)compareToNumber:(NSNumber * _Nonnull)number;
        [Export("compareToNumber:")]
        CPTPlotRangeComparisonResult CompareToNumber(NSNumber number);

        // -(CPTPlotRangeComparisonResult)compareToDecimal:(NSDecimal)number;
        [Export("compareToDecimal:")]
        CPTPlotRangeComparisonResult CompareToDecimal(NSDecimal number);

        // -(CPTPlotRangeComparisonResult)compareToDouble:(double)number;
        [Export("compareToDouble:")]
        CPTPlotRangeComparisonResult CompareToDouble(double number);
    }

    //
    // @interface CPTLineCap
    [BaseType(typeof(NSObject))]
    interface CPTLineCap
    {
        // @property (assign, readwrite, nonatomic) int size;
        [Export("size")]
        int Size { get; set; }

        // @property (assign, readwrite, nonatomic) int lineCapType;
        [Export("lineCapType")]
        int LineCapType { get; set; }

        // @property (readwrite, nonatomic, strong) CPTLineStyle * _Nullable lineStyle;
        [NullAllowed, Export("lineStyle", ArgumentSemantic.Strong)]
        CPTLineStyle LineStyle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Strong)]
        CPTFill Fill { get; set; }

        // @property (assign, readwrite, nonatomic) int customLineCapPath;
        [Export("customLineCapPath")]
        int CustomLineCapPath { get; set; }

        // @property (assign, readwrite, nonatomic) int usesEvenOddClipRule;
        [Export("usesEvenOddClipRule")]
        int UsesEvenOddClipRule { get; set; }

        // +(instancetype _Nonnull)lineCap;
        [Static]
        [Export("lineCap")]
        CPTLineCap LineCap();

        // +(instancetype _Nonnull)openArrowPlotLineCap;
        [Static]
        [Export("openArrowPlotLineCap")]
        CPTLineCap OpenArrowPlotLineCap();

        // +(instancetype _Nonnull)solidArrowPlotLineCap;
        [Static]
        [Export("solidArrowPlotLineCap")]
        CPTLineCap SolidArrowPlotLineCap();

        // +(instancetype _Nonnull)sweptArrowPlotLineCap;
        [Static]
        [Export("sweptArrowPlotLineCap")]
        CPTLineCap SweptArrowPlotLineCap();

        // +(instancetype _Nonnull)rectanglePlotLineCap;
        [Static]
        [Export("rectanglePlotLineCap")]
        CPTLineCap RectanglePlotLineCap();

        // +(instancetype _Nonnull)ellipsePlotLineCap;
        [Static]
        [Export("ellipsePlotLineCap")]
        CPTLineCap EllipsePlotLineCap();

        // +(instancetype _Nonnull)diamondPlotLineCap;
        [Static]
        [Export("diamondPlotLineCap")]
        CPTLineCap DiamondPlotLineCap();

        // +(instancetype _Nonnull)pentagonPlotLineCap;
        [Static]
        [Export("pentagonPlotLineCap")]
        CPTLineCap PentagonPlotLineCap();

        // +(instancetype _Nonnull)hexagonPlotLineCap;
        [Static]
        [Export("hexagonPlotLineCap")]
        CPTLineCap HexagonPlotLineCap();

        // +(instancetype _Nonnull)barPlotLineCap;
        [Static]
        [Export("barPlotLineCap")]
        CPTLineCap BarPlotLineCap();

        // +(instancetype _Nonnull)crossPlotLineCap;
        [Static]
        [Export("crossPlotLineCap")]
        CPTLineCap CrossPlotLineCap();

        // +(instancetype _Nonnull)snowPlotLineCap;
        [Static]
        [Export("snowPlotLineCap")]
        CPTLineCap SnowPlotLineCap();

        // +(instancetype _Nonnull)customLineCapWithPath:(id)aPath;
        [Static]
        [Export("customLineCapWithPath:")]
        CPTLineCap CustomLineCapWithPath(NSObject aPath);

        // -(void)renderAsVectorInContext:(id)context atPoint:(id)center inDirection:(id)direction;
        [Export("renderAsVectorInContext:atPoint:inDirection:")]
        void RenderAsVectorInContext(NSObject context, NSObject center, NSObject direction);
    }

    // 
    // @interface CPTTextStyle : NSObject <NSCopying, NSMutableCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTTextStyle : INSCopying, INSMutableCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable fontName;
        [NullAllowed, Export("fontName")]
        string FontName { get; }

        // @property (readonly, nonatomic) CGFloat fontSize;
        [Export("fontSize")]
        nfloat FontSize { get; }

        // @property (readonly, copy, nonatomic) CPTColor * _Nullable color;
        [NullAllowed, Export("color", ArgumentSemantic.Copy)]
        CPTColor Color { get; }

        // @property (readonly, nonatomic) CPTTextAlignment textAlignment;
        [Export("textAlignment")]
        CPTTextAlignment TextAlignment { get; }

        // @property (readonly, assign, nonatomic) NSLineBreakMode lineBreakMode;
        [Export("lineBreakMode", ArgumentSemantic.Assign)]
        UILineBreakMode LineBreakMode { get; }

        // +(instancetype _Nonnull)textStyle;
        [Static]
        [Export("textStyle")]
        CPTTextStyle TextStyle();

        // +(instancetype _Nonnull)textStyleWithStyle:(CPTTextStyle * _Nullable)textStyle;
        [Static]
        [Export("textStyleWithStyle:")]
        CPTTextStyle TextStyleWithStyle([NullAllowed] CPTTextStyle textStyle);

        [Export("attributes")]
        NSDictionary<NSString, NSObject> Attributes { get; }

        // +(instancetype _Nonnull)textStyleWithAttributes:(CPTDictionary * _Nullable)attributes;
        [Static]
        [Export("textStyleWithAttributes:")]
        CPTTextStyle TextStyleWithAttributes([NullAllowed] NSDictionary<NSString, NSObject> attributes);
    }

    // @interface CPTPlatformSpecificTextStyleExtensions (CPTTextStyle)
    //[Category]
    //[BaseType(typeof(CPTTextStyle))]
    //interface CPTTextStyle_CPTPlatformSpecificTextStyleExtensions
    //{
    //    // @property (readonly, nonatomic) CPTDictionary * _Nonnull attributes;
    //    [Export("attributes")]
    //    NSDictionary<NSString, NSObject> Attributes { get; }

    //    // +(instancetype _Nonnull)textStyleWithAttributes:(CPTDictionary * _Nullable)attributes;
    //    [Static]
    //    [Export("textStyleWithAttributes:")]
    //    CPTTextStyle TextStyleWithAttributes([NullAllowed] NSDictionary<NSString, NSObject> attributes);
    //}

    // @interface CPTTextStyleExtensions (NSString)
    [Category]
    [BaseType(typeof(NSString))]
    interface NSString_CPTTextStyleExtensions
    {
        // -(CGSize)sizeWithTextStyle:(CPTTextStyle * _Nullable)style;
        [Export("sizeWithTextStyle:")]
        CGSize SizeWithTextStyle([NullAllowed] CPTTextStyle style);

        // -(void)drawInRect:(CGRect)rect withTextStyle:(CPTTextStyle * _Nullable)style inContext:(CGContextRef _Nonnull)context;
        [Export("drawInRect:withTextStyle:inContext:")]
        unsafe void DrawInRect(CGRect rect, [NullAllowed] CPTTextStyle style, CGContext context);
    }

    // @interface CPTAxisTitle : CPTAxisLabel
    [BaseType(typeof(CPTAxisLabel))]
    interface CPTAxisTitle
    {
    }

    // @interface CPTFill
    [BaseType(typeof(NSObject))]
    interface CPTFill
    {
        // +(instancetype _Nonnull)fillWithColor:(CPTColor * _Nonnull)aColor;
        [Static]
        [Export("fillWithColor:")]
		CPTFill FromColor(CPTColor aColor);

        // +(instancetype _Nonnull)fillWithGradient:(CPTGradient * _Nonnull)aGradient;
        [Static]
        [Export("fillWithGradient:")]
		CPTFill FromGradient(CPTGradient aGradient);

        // +(instancetype _Nonnull)fillWithImage:(CPTImage * _Nonnull)anImage;
        [Static]
        [Export("fillWithImage:")]
		CPTFill FromImage(CPTImage anImage);

        // -(instancetype _Nonnull)initWithColor:(CPTColor * _Nonnull)aColor;
        [Export("initWithColor:")]
        IntPtr Constructor(CPTColor aColor);

        // -(instancetype _Nonnull)initWithGradient:(CPTGradient * _Nonnull)aGradient;
        [Export("initWithGradient:")]
        IntPtr Constructor(CPTGradient aGradient);

        // -(instancetype _Nonnull)initWithImage:(CPTImage * _Nonnull)anImage;
        [Export("initWithImage:")]
        IntPtr Constructor(CPTImage anImage);

        [Export("opaque")]
        int Opaque { [Bind("isOpaque")] get; }

        // @property (readonly, nonatomic) int cgColor;
        [Export("cgColor")]
        int CgColor { get; }

        // -(void)fillRect:(id)rect inContext:(id)context;
        [Export("fillRect:inContext:")]
        void FillRect(NSObject rect, NSObject context);

        // -(void)fillPathInContext:(id)context;
        [Export("fillPathInContext:")]
        void FillPathInContext(NSObject context);
    }

    // @interface AbstractMethods (CPTFill)
    /*
    [Category]
    [BaseType(typeof(CPTFill))]
    interface CPTFill_AbstractMethods
    {
        // @property (readonly, getter = isOpaque, nonatomic) int opaque;
        [Export("opaque")]
        int Opaque { [Bind("isOpaque")] get; }

        // @property (readonly, nonatomic) int cgColor;
        [Export("cgColor")]
        int CgColor { get; }

        // -(void)fillRect:(id)rect inContext:(id)context;
        [Export("fillRect:inContext:")]
        void FillRect(NSObject rect, NSObject context);

        // -(void)fillPathInContext:(id)context;
        [Export("fillPathInContext:")]
        void FillPathInContext(NSObject context);
    }
    */

    // @interface CPTLimitBand
    [BaseType(typeof(NSObject))]
    interface CPTLimitBand
    {
        // @property (readwrite, nonatomic, strong) CPTPlotRange * _Nullable range;
        [NullAllowed, Export("range", ArgumentSemantic.Strong)]
        CPTPlotRange Range { get; set; }

        // @property (readwrite, nonatomic, strong) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Strong)]
        CPTFill Fill { get; set; }

        // +(instancetype _Nonnull)limitBandWithRange:(CPTPlotRange * _Nullable)newRange fill:(CPTFill * _Nullable)newFill;
        [Static]
        [Export("limitBandWithRange:fill:")]
        CPTLimitBand LimitBandWithRange([NullAllowed] CPTPlotRange newRange, [NullAllowed] CPTFill newFill);

        // -(instancetype _Nonnull)initWithRange:(CPTPlotRange * _Nullable)newRange fill:(CPTFill * _Nullable)newFill;
        [Export("initWithRange:fill:")]
        IntPtr Constructor([NullAllowed] CPTPlotRange newRange, [NullAllowed] CPTFill newFill);

        // -(instancetype _Nullable)initWithCoder:(id)decoder;
        [Export("initWithCoder:")]
        IntPtr Constructor(NSObject decoder);
    }

    //[Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTPlotBinding  _Nonnull const CPTPlotBindingDataLabels;
        [Field("CPTPlotBindingDataLabels", "__Internal")]
        NSString CPTPlotBindingDataLabels { get; }
    }

    interface ICPTPlotDataSource { }

    // @protocol CPTPlotDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CPTPlotDataSource
    {
        // @required -(NSUInteger)numberOfRecordsForPlot:(CPTPlot * _Nonnull)plot;
        [Abstract]
        [Export("numberOfRecordsForPlot:")]
        nuint NumberOfRecordsForPlot(CPTPlot plot);

        // @optional -(NSArray * _Nullable)numbersForPlot:(CPTPlot * _Nonnull)plot field:(NSUInteger)fieldEnum recordIndexRange:(NSRange)indexRange;
        [Export("numbersForPlot:field:recordIndexRange:")]
        //[Verify(StronglyTypedNSArray)]
        [return: NullAllowed]
        NSNumber[] NumbersForPlot(CPTPlot plot, nuint fieldEnum, NSRange indexRange);

        // @optional -(id _Nullable)numberForPlot:(CPTPlot * _Nonnull)plot field:(NSUInteger)fieldEnum recordIndex:(NSUInteger)idx;
        [Export("numberForPlot:field:recordIndex:")]
        [return: NullAllowed]
        NSNumber NumberForPlot(CPTPlot plot, nuint fieldEnum, nuint idx);

        // @optional -(double * _Nullable)doublesForPlot:(CPTPlot * _Nonnull)plot field:(NSUInteger)fieldEnum recordIndexRange:(NSRange)indexRange __attribute__((objc_returns_inner_pointer));
        [Export("doublesForPlot:field:recordIndexRange:")]
        [return: NullAllowed]
        IntPtr DoublesForPlot(CPTPlot plot, nuint fieldEnum, NSRange indexRange);

        // @optional -(double)doubleForPlot:(CPTPlot * _Nonnull)plot field:(NSUInteger)fieldEnum recordIndex:(NSUInteger)idx;
        [Export("doubleForPlot:field:recordIndex:")]
        double DoubleForPlot(CPTPlot plot, nuint fieldEnum, nuint idx);

        // @optional -(CPTNumericData * _Nullable)dataForPlot:(CPTPlot * _Nonnull)plot field:(NSUInteger)fieldEnum recordIndexRange:(NSRange)indexRange;
        [Export("dataForPlot:field:recordIndexRange:")]
        [return: NullAllowed]
        CPTNumericData DataForPlot(CPTPlot plot, nuint fieldEnum, NSRange indexRange);

        // @optional -(CPTNumericData * _Nullable)dataForPlot:(CPTPlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("dataForPlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTNumericData DataForPlot(CPTPlot plot, NSRange indexRange);

        // @optional -(CPTLayerArray * _Nullable)dataLabelsForPlot:(CPTPlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("dataLabelsForPlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLayer[] DataLabelsForPlot(CPTPlot plot, NSRange indexRange);

        // @optional -(CPTLayer * _Nullable)dataLabelForPlot:(CPTPlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("dataLabelForPlot:recordIndex:")]
        [return: NullAllowed]
        CPTLayer DataLabelForPlot(CPTPlot plot, nuint idx);
    }

    // @protocol CPTPlotDelegate <CPTLayerDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTPlotDelegate : CPTLayerDelegate
    {
        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("plot:dataLabelWasSelectedAtRecordIndex:")]
        void DataLabelWasSelected(CPTPlot plot, nuint idx);

        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plot:dataLabelWasSelectedAtRecordIndex:withEvent:")]
        void DataLabelWasSelected(CPTPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("plot:dataLabelTouchDownAtRecordIndex:")]
        void DataLabelTouchDown(CPTPlot plot, nuint idx);

        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plot:dataLabelTouchDownAtRecordIndex:withEvent:")]
        void DataLabelTouchDown(CPTPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("plot:dataLabelTouchUpAtRecordIndex:")]
        void DataLabelTouchUp(CPTPlot plot, nuint idx);

        // @optional -(void)plot:(CPTPlot * _Nonnull)plot dataLabelTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plot:dataLabelTouchUpAtRecordIndex:withEvent:")]
        void DataLabelTouchUp(CPTPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)didFinishDrawing:(CPTPlot * _Nonnull)plot;
        [Export("didFinishDrawing:")]
        void DidFinishDrawing(CPTPlot plot);
    }

    // @interface CPTPlot : CPTAnnotationHostLayer
    [BaseType(typeof(CPTAnnotationHostLayer))]
    interface CPTPlot
    {
        // @property (readwrite, nonatomic, weak) id<CPTPlotDataSource> _Nullable dataSource;
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        ICPTPlotDataSource DataSource { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (readwrite, copy, nonatomic) NSAttributedString * _Nullable attributedTitle;
        [NullAllowed, Export("attributedTitle", ArgumentSemantic.Copy)]
        NSAttributedString AttributedTitle { get; set; }

        // @property (readwrite, nonatomic, strong) CPTPlotSpace * _Nullable plotSpace;
        [NullAllowed, Export("plotSpace", ArgumentSemantic.Strong)]
        CPTPlotSpace PlotSpace { get; set; }

        // @property (readonly, nonatomic) CPTPlotArea * _Nullable plotArea;
        [NullAllowed, Export("plotArea")]
        CPTPlotArea PlotArea { get; }

        // @property (readonly, nonatomic) BOOL dataNeedsReloading;
        [Export("dataNeedsReloading")]
        bool DataNeedsReloading { get; }

        // @property (readonly, nonatomic) NSUInteger cachedDataCount;
        [Export("cachedDataCount")]
        nuint CachedDataCount { get; }

        // @property (readonly, nonatomic) BOOL doublePrecisionCache;
        [Export("doublePrecisionCache")]
        bool DoublePrecisionCache { get; }

        // @property (assign, readwrite, nonatomic) CPTPlotCachePrecision cachePrecision;
        [Export("cachePrecision", ArgumentSemantic.Assign)]
        CPTPlotCachePrecision CachePrecision { get; set; }

        // @property (readonly, nonatomic) CPTNumericDataType doubleDataType;
        [Export("doubleDataType")]
        CPTNumericDataType DoubleDataType { get; }

        // @property (readonly, nonatomic) CPTNumericDataType decimalDataType;
        [Export("decimalDataType")]
        CPTNumericDataType DecimalDataType { get; }

        // @property (readonly, nonatomic) BOOL needsRelabel;
        [Export("needsRelabel")]
        bool NeedsRelabel { get; }

        // @property (assign, readwrite, nonatomic) BOOL adjustLabelAnchors;
        [Export("adjustLabelAnchors")]
        bool AdjustLabelAnchors { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL showLabels;
        [Export("showLabels")]
        bool ShowLabels { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat labelOffset;
        [Export("labelOffset")]
        nfloat LabelOffset { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat labelRotation;
        [Export("labelRotation")]
        nfloat LabelRotation { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger labelField;
        [Export("labelField")]
        nuint LabelField { get; set; }

        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable labelTextStyle;
        [NullAllowed, Export("labelTextStyle", ArgumentSemantic.Copy)]
        CPTTextStyle LabelTextStyle { get; set; }

        // @property (readwrite, nonatomic, strong) NSFormatter * _Nullable labelFormatter;
        [NullAllowed, Export("labelFormatter", ArgumentSemantic.Strong)]
        NSFormatter LabelFormatter { get; set; }

        // @property (readwrite, nonatomic, strong) CPTShadow * _Nullable labelShadow;
        [NullAllowed, Export("labelShadow", ArgumentSemantic.Strong)]
        CPTShadow LabelShadow { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL alignsPointsToPixels;
        [Export("alignsPointsToPixels")]
        bool AlignsPointsToPixels { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL drawLegendSwatchDecoration;
        [Export("drawLegendSwatchDecoration")]
        bool DrawLegendSwatchDecoration { get; set; }

        // -(void)setNeedsRelabel;
        [Export("setNeedsRelabel")]
        void SetNeedsRelabel();

        // -(void)relabel;
        [Export("relabel")]
        void Relabel();

        // -(void)relabelIndexRange:(NSRange)indexRange;
        [Export("relabelIndexRange:")]
        void RelabelIndexRange(NSRange indexRange);

        // -(void)repositionAllLabelAnnotations;
        [Export("repositionAllLabelAnnotations")]
        void RepositionAllLabelAnnotations();

        // -(void)reloadDataLabels;
        [Export("reloadDataLabels")]
        void ReloadDataLabels();

        // -(void)reloadDataLabelsInIndexRange:(NSRange)indexRange;
        [Export("reloadDataLabelsInIndexRange:")]
        void ReloadDataLabelsInIndexRange(NSRange indexRange);

        // -(void)setDataNeedsReloading;
        [Export("setDataNeedsReloading")]
        void SetDataNeedsReloading();

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)reloadDataIfNeeded;
        [Export("reloadDataIfNeeded")]
        void ReloadDataIfNeeded();

        // -(void)reloadDataInIndexRange:(NSRange)indexRange;
        [Export("reloadDataInIndexRange:")]
        void ReloadDataInIndexRange(NSRange indexRange);

        // -(void)insertDataAtIndex:(NSUInteger)idx numberOfRecords:(NSUInteger)numberOfRecords;
        [Export("insertDataAtIndex:numberOfRecords:")]
        void InsertDataAtIndex(nuint idx, nuint numberOfRecords);

        // -(void)deleteDataInIndexRange:(NSRange)indexRange;
        [Export("deleteDataInIndexRange:")]
        void DeleteDataInIndexRange(NSRange indexRange);

        // -(void)reloadPlotData;
        [Export("reloadPlotData")]
        void ReloadPlotData();

        // -(void)reloadPlotDataInIndexRange:(NSRange)indexRange;
        [Export("reloadPlotDataInIndexRange:")]
        void ReloadPlotDataInIndexRange(NSRange indexRange);

        // +(id _Nonnull)nilData;
        [Static]
        [Export("nilData")]
        // [Verify(MethodToProperty)]
        NSObject NilData { get; }

        // -(id _Nullable)numbersFromDataSourceForField:(NSUInteger)fieldEnum recordIndexRange:(NSRange)indexRange;
        [Export("numbersFromDataSourceForField:recordIndexRange:")]
        [return: NullAllowed]
        NSObject NumbersFromDataSourceForField(nuint fieldEnum, NSRange indexRange);

        // -(BOOL)loadNumbersForAllFieldsFromDataSourceInRecordIndexRange:(NSRange)indexRange;
        [Export("loadNumbersForAllFieldsFromDataSourceInRecordIndexRange:")]
        bool LoadNumbersForAllFieldsFromDataSourceInRecordIndexRange(NSRange indexRange);

        // -(CPTMutableNumericData * _Nullable)cachedNumbersForField:(NSUInteger)fieldEnum;
        [Export("cachedNumbersForField:")]
        [return: NullAllowed]
        CPTMutableNumericData CachedNumbersForField(nuint fieldEnum);

        // -(NSNumber * _Nullable)cachedNumberForField:(NSUInteger)fieldEnum recordIndex:(NSUInteger)idx;
        [Export("cachedNumberForField:recordIndex:")]
        [return: NullAllowed]
        NSNumber CachedNumberForField(nuint fieldEnum, nuint idx);

        // -(double)cachedDoubleForField:(NSUInteger)fieldEnum recordIndex:(NSUInteger)idx;
        [Export("cachedDoubleForField:recordIndex:")]
        double CachedDoubleForField(nuint fieldEnum, nuint idx);

        // -(NSDecimal)cachedDecimalForField:(NSUInteger)fieldEnum recordIndex:(NSUInteger)idx;
        [Export("cachedDecimalForField:recordIndex:")]
        NSDecimal CachedDecimalForField(nuint fieldEnum, nuint idx);

        // -(NSArray * _Nullable)cachedArrayForKey:(NSString * _Nonnull)key;
        [Export("cachedArrayForKey:")]
        //[Verify(StronglyTypedNSArray)]
        [return: NullAllowed]
        NSObject[] CachedArrayForKey(string key);

        // -(id _Nullable)cachedValueForKey:(NSString * _Nonnull)key recordIndex:(NSUInteger)idx;
        [Export("cachedValueForKey:recordIndex:")]
        [return: NullAllowed]
        NSObject CachedValueForKey(string key, nuint idx);

        // -(void)cacheNumbers:(id _Nullable)numbers forField:(NSUInteger)fieldEnum;
        [Export("cacheNumbers:forField:")]
        void CacheNumbers([NullAllowed] NSObject numbers, nuint fieldEnum);

        // -(void)cacheNumbers:(id _Nullable)numbers forField:(NSUInteger)fieldEnum atRecordIndex:(NSUInteger)idx;
        [Export("cacheNumbers:forField:atRecordIndex:")]
        void CacheNumbers([NullAllowed] NSObject numbers, nuint fieldEnum, nuint idx);

        // -(void)cacheArray:(NSArray * _Nullable)array forKey:(NSString * _Nonnull)key;
        [Export("cacheArray:forKey:")]
        //[Verify(StronglyTypedNSArray)]
        void CacheArray([NullAllowed] NSObject[] array, string key);

        // -(void)cacheArray:(NSArray * _Nullable)array forKey:(NSString * _Nonnull)key atRecordIndex:(NSUInteger)idx;
        [Export("cacheArray:forKey:atRecordIndex:")]
        //[Verify(StronglyTypedNSArray)]
        void CacheArray([NullAllowed] NSObject[] array, string key, nuint idx);

        // -(CPTPlotRange * _Nullable)plotRangeForField:(NSUInteger)fieldEnum;
        [Export("plotRangeForField:")]
        [return: NullAllowed]
        CPTPlotRange PlotRangeForField(nuint fieldEnum);

        // -(CPTPlotRange * _Nullable)plotRangeForCoordinate:(CPTCoordinate)coord;
        [Export("plotRangeForCoordinate:")]
        [return: NullAllowed]
        CPTPlotRange PlotRangeForCoordinate(CPTCoordinate coord);

        // -(CPTPlotRange * _Nullable)plotRangeEnclosingField:(NSUInteger)fieldEnum;
        [Export("plotRangeEnclosingField:")]
        [return: NullAllowed]
        CPTPlotRange PlotRangeEnclosingField(nuint fieldEnum);

        // -(CPTPlotRange * _Nullable)plotRangeEnclosingCoordinate:(CPTCoordinate)coord;
        [Export("plotRangeEnclosingCoordinate:")]
        [return: NullAllowed]
        CPTPlotRange PlotRangeEnclosingCoordinate(CPTCoordinate coord);

        // -(NSUInteger)numberOfLegendEntries;
        [Export("numberOfLegendEntries")]
        // [Verify(MethodToProperty)]
        nuint NumberOfLegendEntries { get; }

        // -(NSString * _Nullable)titleForLegendEntryAtIndex:(NSUInteger)idx;
        [Export("titleForLegendEntryAtIndex:")]
        [return: NullAllowed]
        string TitleForLegendEntryAtIndex(nuint idx);

        // -(NSAttributedString * _Nullable)attributedTitleForLegendEntryAtIndex:(NSUInteger)idx;
        [Export("attributedTitleForLegendEntryAtIndex:")]
        [return: NullAllowed]
        NSAttributedString AttributedTitleForLegendEntryAtIndex(nuint idx);

        // -(void)drawSwatchForLegend:(CPTLegend * _Nonnull)legend atIndex:(NSUInteger)idx inRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("drawSwatchForLegend:atIndex:inRect:inContext:")]
        unsafe void DrawSwatchForLegend(CPTLegend legend, nuint idx, CGRect rect, CGContext context);

        [Export("numberOfFields")]
        // [Verify(MethodToProperty)]
        nuint NumberOfFields { get; }

        // -(CPTNumberArray * _Nonnull)fieldIdentifiers;
        [Export("fieldIdentifiers")]
        // [Verify(MethodToProperty)]
        NSNumber[] FieldIdentifiers { get; }

        // -(CPTNumberArray * _Nonnull)fieldIdentifiersForCoordinate:(CPTCoordinate)coord;
        [Export("fieldIdentifiersForCoordinate:")]
        NSNumber[] FieldIdentifiersForCoordinate(CPTCoordinate coord);

        // -(CPTCoordinate)coordinateForFieldIdentifier:(NSUInteger)field;
        [Export("coordinateForFieldIdentifier:")]
        CPTCoordinate CoordinateForFieldIdentifier(nuint field);

        // -(void)positionLabelAnnotation:(CPTPlotSpaceAnnotation * _Nonnull)label forIndex:(NSUInteger)idx;
        [Export("positionLabelAnnotation:forIndex:")]
        void PositionLabelAnnotation(CPTPlotSpaceAnnotation label, nuint idx);

        // -(NSUInteger)dataIndexFromInteractionPoint:(CGPoint)point;
        [Export("dataIndexFromInteractionPoint:")]
        nuint DataIndexFromInteractionPoint(CGPoint point);
    }

    // @interface AbstractMethods (CPTPlot)
    /*
    [Category]
    [BaseType(typeof(CPTPlot))]
    interface CPTPlot_AbstractMethods
    {
        // -(NSUInteger)numberOfFields;
        [Export("numberOfFields")]
        // [Verify(MethodToProperty)]
        nuint NumberOfFields { get; }

        // -(CPTNumberArray * _Nonnull)fieldIdentifiers;
        [Export("fieldIdentifiers")]
        // [Verify(MethodToProperty)]
        NSNumber[] FieldIdentifiers { get; }

        // -(CPTNumberArray * _Nonnull)fieldIdentifiersForCoordinate:(CPTCoordinate)coord;
        [Export("fieldIdentifiersForCoordinate:")]
        NSNumber[] FieldIdentifiersForCoordinate(CPTCoordinate coord);

        // -(CPTCoordinate)coordinateForFieldIdentifier:(NSUInteger)field;
        [Export("coordinateForFieldIdentifier:")]
        CPTCoordinate CoordinateForFieldIdentifier(nuint field);

        // -(void)positionLabelAnnotation:(CPTPlotSpaceAnnotation * _Nonnull)label forIndex:(NSUInteger)idx;
        [Export("positionLabelAnnotation:forIndex:")]
        void PositionLabelAnnotation(CPTPlotSpaceAnnotation label, nuint idx);

        // -(NSUInteger)dataIndexFromInteractionPoint:(CGPoint)point;
        [Export("dataIndexFromInteractionPoint:")]
        nuint DataIndexFromInteractionPoint(CGPoint point);
    }
    */

    //[Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTPlotSpaceCoordinateMapping  _Nonnull const CPTPlotSpaceCoordinateMappingDidChangeNotification;
        [Field("CPTPlotSpaceCoordinateMappingDidChangeNotification", "__Internal")]
        NSString CPTPlotSpaceCoordinateMappingDidChangeNotification { get; }

        // extern CPTPlotSpaceInfoKey  _Nonnull const CPTPlotSpaceCoordinateKey;
        [Field("CPTPlotSpaceCoordinateKey", "__Internal")]
        NSString CPTPlotSpaceCoordinateKey { get; }

        // extern CPTPlotSpaceInfoKey  _Nonnull const CPTPlotSpaceScrollingKey;
        [Field("CPTPlotSpaceScrollingKey", "__Internal")]
        NSString CPTPlotSpaceScrollingKey { get; }

        // extern CPTPlotSpaceInfoKey  _Nonnull const CPTPlotSpaceDisplacementKey;
        [Field("CPTPlotSpaceDisplacementKey", "__Internal")]
        NSString CPTPlotSpaceDisplacementKey { get; }
    }

    interface ICPTPlotSpaceDelegate { }

    // @protocol CPTPlotSpaceDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CPTPlotSpaceDelegate
    {
        // @optional -(BOOL)plotSpace:(CPTPlotSpace * _Nonnull)space shouldScaleBy:(CGFloat)interactionScale aboutPoint:(CGPoint)interactionPoint;
        [DelegateName("ShouldScaleBy"), DefaultValue(false)]
        [Export("plotSpace:shouldScaleBy:aboutPoint:")]
        bool ShouldScaleBy(CPTPlotSpace space, nfloat interactionScale, CGPoint interactionPoint);

        // @optional -(CGPoint)plotSpace:(CPTPlotSpace * _Nonnull)space willDisplaceBy:(CGPoint)proposedDisplacementVector;
        [DelegateName("WillDisplace"), DefaultValueFromArgument("proposedDisplacementVector")]
        [Export("plotSpace:willDisplaceBy:")]
        CGPoint WillDisplace(CPTPlotSpace space, CGPoint proposedDisplacementVector);

        // @optional -(CPTPlotRange * _Nullable)plotSpace:(CPTPlotSpace * _Nonnull)space willChangePlotRangeTo:(CPTPlotRange * _Nonnull)newRange forCoordinate:(CPTCoordinate)coordinate;
        [DelegateName("WillChangePlotRange"), DefaultValueFromArgument("newRange")]
        [Export("plotSpace:willChangePlotRangeTo:forCoordinate:")]
        [return: NullAllowed]
        CPTPlotRange WillChangePlotRange(CPTPlotSpace space, CPTPlotRange newRange, CPTCoordinate coordinate);

        // @optional -(void)plotSpace:(CPTPlotSpace * _Nonnull)space didChangePlotRangeForCoordinate:(CPTCoordinate)coordinate;
        [EventArgs("DidChangePlotRange")]
        [Export("plotSpace:didChangePlotRangeForCoordinate:")]
        void DidChangePlotRange(CPTPlotSpace space, CPTCoordinate coordinate);

        // @optional -(BOOL)plotSpace:(CPTPlotSpace * _Nonnull)space shouldHandlePointingDeviceDownEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)point;
        [DelegateName("ShouldHandlePointingDeviceDownEvent"), DefaultValue(false)]
        [Export("plotSpace:shouldHandlePointingDeviceDownEvent:atPoint:")]
        bool ShouldHandlePointingDeviceDownEvent(CPTPlotSpace space, UIEvent @event, CGPoint point);

        // @optional -(BOOL)plotSpace:(CPTPlotSpace * _Nonnull)space shouldHandlePointingDeviceDraggedEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)point;
        [DelegateName("ShouldHandlePointingDeviceDragged"), DefaultValue(false)]
        [Export("plotSpace:shouldHandlePointingDeviceDraggedEvent:atPoint:")]
        bool ShouldHandlePointingDeviceDragged(CPTPlotSpace space, UIEvent @event, CGPoint point);

        // @optional -(BOOL)plotSpace:(CPTPlotSpace * _Nonnull)space shouldHandlePointingDeviceCancelledEvent:(CPTNativeEvent * _Nonnull)event;
        [DelegateName("ShouldHandlePointingDeviceCancelled"), DefaultValue(false)]
        [Export("plotSpace:shouldHandlePointingDeviceCancelledEvent:")]
        bool ShouldHandlePointingDeviceCancelled(CPTPlotSpace space, UIEvent @event);

        // @optional -(BOOL)plotSpace:(CPTPlotSpace * _Nonnull)space shouldHandlePointingDeviceUpEvent:(CPTNativeEvent * _Nonnull)event atPoint:(CGPoint)point;
        [DelegateName("ShouldHandlePointingDeviceUp"), DefaultValue(false)]
        [Export("plotSpace:shouldHandlePointingDeviceUpEvent:atPoint:")]
        bool ShouldHandlePointingDeviceUp(CPTPlotSpace space, UIEvent @event, CGPoint point);
    }

    // @interface CPTPlotSpace : NSObject <CPTResponder, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject),
    Delegates = new string[] { "WeakDelegate" },
    Events = new Type[] { typeof(CPTPlotSpaceDelegate) })]
    interface CPTPlotSpace : ICPTResponder, INSCoding, INSSecureCoding
    {
        // @property (readwrite, copy, nonatomic) id<NSCopying,NSCoding,NSObject> _Nullable identifier;
        [NullAllowed, Export("identifier", ArgumentSemantic.Copy)]
        NSObject Identifier { get; set; }

        // @property (readwrite, nonatomic) BOOL allowsUserInteraction;
        [Export("allowsUserInteraction")]
        bool AllowsUserInteraction { get; set; }

        // @property (readonly, nonatomic) BOOL isDragging;
        [Export("isDragging")]
        bool IsDragging { get; }

        // @property (readwrite, nonatomic, weak) CPTGraph * _Nullable graph;
        [NullAllowed, Export("graph", ArgumentSemantic.Weak)]
        CPTGraph Graph { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        CPTPlotSpaceDelegate Delegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<CPTPlotSpaceDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) NSUInteger numberOfCoordinates;
        [Export("numberOfCoordinates")]
        nuint NumberOfCoordinates { get; }

        // -(void)addCategory:(NSString * _Nonnull)category forCoordinate:(CPTCoordinate)coordinate;
        [Export("addCategory:forCoordinate:")]
        void AddCategory(string category, CPTCoordinate coordinate);

        // -(void)removeCategory:(NSString * _Nonnull)category forCoordinate:(CPTCoordinate)coordinate;
        [Export("removeCategory:forCoordinate:")]
        void RemoveCategory(string category, CPTCoordinate coordinate);

        // -(void)insertCategory:(NSString * _Nonnull)category forCoordinate:(CPTCoordinate)coordinate atIndex:(NSUInteger)idx;
        [Export("insertCategory:forCoordinate:atIndex:")]
        void InsertCategory(string category, CPTCoordinate coordinate, nuint idx);

        // -(void)setCategories:(CPTStringArray * _Nullable)newCategories forCoordinate:(CPTCoordinate)coordinate;
        [Export("setCategories:forCoordinate:")]
        void SetCategories([NullAllowed] string[] newCategories, CPTCoordinate coordinate);

        // -(void)removeAllCategories;
        [Export("removeAllCategories")]
        void RemoveAllCategories();

        // -(CPTStringArray * _Nonnull)categoriesForCoordinate:(CPTCoordinate)coordinate;
        [Export("categoriesForCoordinate:")]
        string[] CategoriesForCoordinate(CPTCoordinate coordinate);

        // -(NSString * _Nullable)categoryForCoordinate:(CPTCoordinate)coordinate atIndex:(NSUInteger)idx;
        [Export("categoryForCoordinate:atIndex:")]
        [return: NullAllowed]
        string CategoryForCoordinate(CPTCoordinate coordinate, nuint idx);

        // -(NSUInteger)indexOfCategory:(NSString * _Nonnull)category forCoordinate:(CPTCoordinate)coordinate;
        [Export("indexOfCategory:forCoordinate:")]
        nuint IndexOfCategory(string category, CPTCoordinate coordinate);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);
    }

    // @interface AbstractMethods (CPTPlotSpace)
    [Category]
    [BaseType(typeof(CPTPlotSpace))]
    interface CPTPlotSpace_AbstractMethods
    {
        // -(CGPoint)plotAreaViewPointForPlotPoint:(CPTNumberArray * _Nonnull)plotPoint;
        [Export("plotAreaViewPointForPlotPoint:")]
        CGPoint PlotAreaViewPointForPlotPoint(NSNumber[] plotPoint);

        // -(CGPoint)plotAreaViewPointForPlotPoint:(NSDecimal * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count;
        [Export("plotAreaViewPointForPlotPoint:numberOfCoordinates:")]
        unsafe CGPoint PlotAreaViewPointForPlotPoint(ref NSDecimal plotPoint, nuint count);

        // -(CGPoint)plotAreaViewPointForDoublePrecisionPlotPoint:(double * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count;
        [Export("plotAreaViewPointForDoublePrecisionPlotPoint:numberOfCoordinates:")]
        unsafe CGPoint PlotAreaViewPointForDoublePrecisionPlotPoint(ref double plotPoint, nuint count);

        // -(CPTNumberArray * _Nullable)plotPointForPlotAreaViewPoint:(CGPoint)point;
        [Export("plotPointForPlotAreaViewPoint:")]
        [return: NullAllowed]
        NSNumber[] PlotPointForPlotAreaViewPoint(CGPoint point);

        // -(void)plotPoint:(NSDecimal * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count forPlotAreaViewPoint:(CGPoint)point;
        [Export("plotPoint:numberOfCoordinates:forPlotAreaViewPoint:")]
        unsafe void PlotPoint(ref NSDecimal plotPoint, nuint count, CGPoint point);

        // -(void)doublePrecisionPlotPoint:(double * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count forPlotAreaViewPoint:(CGPoint)point;
        [Export("doublePrecisionPlotPoint:numberOfCoordinates:forPlotAreaViewPoint:")]
        unsafe void DoublePrecisionPlotPoint(ref double plotPoint, nuint count, CGPoint point);

        // -(CGPoint)plotAreaViewPointForEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotAreaViewPointForEvent:")]
        CGPoint PlotAreaViewPointForEvent(UIEvent @event);

        // -(CPTNumberArray * _Nullable)plotPointForEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotPointForEvent:")]
        [return: NullAllowed]
        NSNumber[] PlotPointForEvent(UIEvent @event);

        // -(void)plotPoint:(NSDecimal * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count forEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotPoint:numberOfCoordinates:forEvent:")]
        unsafe void PlotPoint(ref NSDecimal plotPoint, nuint count, UIEvent @event);

        // -(void)doublePrecisionPlotPoint:(double * _Nonnull)plotPoint numberOfCoordinates:(NSUInteger)count forEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("doublePrecisionPlotPoint:numberOfCoordinates:forEvent:")]
        unsafe void DoublePrecisionPlotPoint(ref double plotPoint, nuint count, UIEvent @event);

        // -(void)setPlotRange:(CPTPlotRange * _Nonnull)newRange forCoordinate:(CPTCoordinate)coordinate;
        [Export("setPlotRange:forCoordinate:")]
        void SetPlotRange(CPTPlotRange newRange, CPTCoordinate coordinate);

        // -(CPTPlotRange * _Nullable)plotRangeForCoordinate:(CPTCoordinate)coordinate;
        [Export("plotRangeForCoordinate:")]
        [return: NullAllowed]
        CPTPlotRange PlotRangeForCoordinate(CPTCoordinate coordinate);

        // -(void)setScaleType:(CPTScaleType)newType forCoordinate:(CPTCoordinate)coordinate;
        [Export("setScaleType:forCoordinate:")]
        void SetScaleType(CPTScaleType newType, CPTCoordinate coordinate);

        // -(CPTScaleType)scaleTypeForCoordinate:(CPTCoordinate)coordinate;
        [Export("scaleTypeForCoordinate:")]
        CPTScaleType ScaleTypeForCoordinate(CPTCoordinate coordinate);

        // -(void)scaleToFitPlots:(CPTPlotArray * _Nullable)plots;
        [Export("scaleToFitPlots:")]
        void ScaleToFitPlots([NullAllowed] CPTPlot[] plots);

        // -(void)scaleToFitPlots:(CPTPlotArray * _Nullable)plots forCoordinate:(CPTCoordinate)coordinate;
        [Export("scaleToFitPlots:forCoordinate:")]
        void ScaleToFitPlots([NullAllowed] CPTPlot[] plots, CPTCoordinate coordinate);

        // -(void)scaleToFitEntirePlots:(CPTPlotArray * _Nullable)plots;
        [Export("scaleToFitEntirePlots:")]
        void ScaleToFitEntirePlots([NullAllowed] CPTPlot[] plots);

        // -(void)scaleToFitEntirePlots:(CPTPlotArray * _Nullable)plots forCoordinate:(CPTCoordinate)coordinate;
        [Export("scaleToFitEntirePlots:forCoordinate:")]
        void ScaleToFitEntirePlots([NullAllowed] CPTPlot[] plots, CPTCoordinate coordinate);

        // -(void)scaleBy:(CGFloat)interactionScale aboutPoint:(CGPoint)interactionPoint;
        [Export("scaleBy:aboutPoint:")]
        void ScaleBy(nfloat interactionScale, CGPoint interactionPoint);
    }

    // @protocol CPTPlotAreaDelegate <CPTLayerDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTPlotAreaDelegate : CPTLayerDelegate
    {
        // @optional -(void)plotAreaWasSelected:(CPTPlotArea * _Nonnull)plotArea;
        [Export("plotAreaWasSelected:")]
        void PlotAreaWasSelected(CPTPlotArea plotArea);

        // @optional -(void)plotAreaWasSelected:(CPTPlotArea * _Nonnull)plotArea withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotAreaWasSelected:withEvent:")]
        void PlotAreaWasSelected(CPTPlotArea plotArea, UIEvent @event);

        // @optional -(void)plotAreaTouchDown:(CPTPlotArea * _Nonnull)plotArea;
        [Export("plotAreaTouchDown:")]
        void PlotAreaTouchDown(CPTPlotArea plotArea);

        // @optional -(void)plotAreaTouchDown:(CPTPlotArea * _Nonnull)plotArea withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotAreaTouchDown:withEvent:")]
        void PlotAreaTouchDown(CPTPlotArea plotArea, UIEvent @event);

        // @optional -(void)plotAreaTouchUp:(CPTPlotArea * _Nonnull)plotArea;
        [Export("plotAreaTouchUp:")]
        void PlotAreaTouchUp(CPTPlotArea plotArea);

        // @optional -(void)plotAreaTouchUp:(CPTPlotArea * _Nonnull)plotArea withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("plotAreaTouchUp:withEvent:")]
        void PlotAreaTouchUp(CPTPlotArea plotArea, UIEvent @event);
    }

    // @interface CPTPlotArea : CPTAnnotationHostLayer
    [BaseType(typeof(CPTAnnotationHostLayer))]
    interface CPTPlotArea
    {
        // @property (readwrite, nonatomic, strong) CPTGridLineGroup * _Nullable minorGridLineGroup;
        [NullAllowed, Export("minorGridLineGroup", ArgumentSemantic.Strong)]
        CPTGridLineGroup MinorGridLineGroup { get; set; }

        // @property (readwrite, nonatomic, strong) CPTGridLineGroup * _Nullable majorGridLineGroup;
        [NullAllowed, Export("majorGridLineGroup", ArgumentSemantic.Strong)]
        CPTGridLineGroup MajorGridLineGroup { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisSet * _Nullable axisSet;
        [NullAllowed, Export("axisSet", ArgumentSemantic.Strong)]
        CPTAxisSet AxisSet { get; set; }

        // @property (readwrite, nonatomic, strong) CPTPlotGroup * _Nullable plotGroup;
        [NullAllowed, Export("plotGroup", ArgumentSemantic.Strong)]
        CPTPlotGroup PlotGroup { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisLabelGroup * _Nullable axisLabelGroup;
        [NullAllowed, Export("axisLabelGroup", ArgumentSemantic.Strong)]
        CPTAxisLabelGroup AxisLabelGroup { get; set; }

        // @property (readwrite, nonatomic, strong) CPTAxisLabelGroup * _Nullable axisTitleGroup;
        [NullAllowed, Export("axisTitleGroup", ArgumentSemantic.Strong)]
        CPTAxisLabelGroup AxisTitleGroup { get; set; }

        // @property (readwrite, nonatomic, strong) CPTNumberArray * _Nullable topDownLayerOrder;
        [NullAllowed, Export("topDownLayerOrder", ArgumentSemantic.Strong)]
        NSNumber[] TopDownLayerOrder { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable borderLineStyle;
        [NullAllowed, Export("borderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle BorderLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Copy)]
        CPTFill Fill { get; set; }

        // @property (readonly, nonatomic) NSDecimal widthDecimal;
        [Export("widthDecimal")]
        NSDecimal WidthDecimal { get; }

        // @property (readonly, nonatomic) NSDecimal heightDecimal;
        [Export("heightDecimal")]
        NSDecimal HeightDecimal { get; }

        // -(void)updateAxisSetLayersForType:(CPTGraphLayerType)layerType;
        [Export("updateAxisSetLayersForType:")]
        void UpdateAxisSetLayersForType(CPTGraphLayerType layerType);

        // -(void)setAxisSetLayersForType:(CPTGraphLayerType)layerType;
        [Export("setAxisSetLayersForType:")]
        void SetAxisSetLayersForType(CPTGraphLayerType layerType);

        // -(unsigned int)sublayerIndexForAxis:(CPTAxis * _Nonnull)axis layerType:(CPTGraphLayerType)layerType;
        [Export("sublayerIndexForAxis:layerType:")]
        uint SublayerIndexForAxis(CPTAxis axis, CPTGraphLayerType layerType);
    }

    // @interface CPTGridLines
    [BaseType(typeof(CPTLayer))]
    interface CPTGridLines
    {
        // @property (readwrite, nonatomic) CPTAxis * axis;
        [Export("axis", ArgumentSemantic.Assign)]
        CPTAxis Axis { get; set; }

        // @property (readwrite, nonatomic) int major;
        [Export("major")]
        int Major { get; set; }
    }

    // @interface CPTGraphHostingView : UIView <NSCoding, NSSecureCoding>
    [BaseType(typeof(UIView))]
    interface CPTGraphHostingView : INSCoding, INSSecureCoding
    {
        // @property (readwrite, nonatomic, strong) CPTGraph * _Nullable hostedGraph;
        [NullAllowed, Export("hostedGraph", ArgumentSemantic.Strong)]
        CPTGraph HostedGraph { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL collapsesLayers;
        [Export("collapsesLayers")]
        bool CollapsesLayers { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL allowPinchScaling;
        [Export("allowPinchScaling")]
        bool AllowPinchScaling { get; set; }
    }

    // @interface CPTGradient : NSObject <NSCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTGradient : INSCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; }

        // @property (readonly, nonatomic) CPTGradientBlendingMode blendingMode;
        [Export("blendingMode")]
        CPTGradientBlendingMode BlendingMode { get; }

        // @property (assign, readwrite, nonatomic) CPTGradientType gradientType;
        [Export("gradientType", ArgumentSemantic.Assign)]
        CPTGradientType GradientType { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat angle;
        [Export("angle")]
        nfloat Angle { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint startAnchor;
        [Export("startAnchor", ArgumentSemantic.Assign)]
        CGPoint StartAnchor { get; set; }

        // @property (assign, readwrite, nonatomic) CGPoint endAnchor;
        [Export("endAnchor", ArgumentSemantic.Assign)]
        CGPoint EndAnchor { get; set; }

        // +(instancetype _Nonnull)gradientWithBeginningColor:(CPTColor * _Nonnull)begin endingColor:(CPTColor * _Nonnull)end;
        [Static]
        [Export("gradientWithBeginningColor:endingColor:")]
        CPTGradient GradientWithBeginningColor(CPTColor begin, CPTColor end);

        // +(instancetype _Nonnull)gradientWithBeginningColor:(CPTColor * _Nonnull)begin endingColor:(CPTColor * _Nonnull)end beginningPosition:(CGFloat)beginningPosition endingPosition:(CGFloat)endingPosition;
        [Static]
        [Export("gradientWithBeginningColor:endingColor:beginningPosition:endingPosition:")]
        CPTGradient GradientWithBeginningColor(CPTColor begin, CPTColor end, nfloat beginningPosition, nfloat endingPosition);

        // +(instancetype _Nonnull)aquaSelectedGradient;
        [Static]
        [Export("aquaSelectedGradient")]
        CPTGradient AquaSelectedGradient();

        // +(instancetype _Nonnull)aquaNormalGradient;
        [Static]
        [Export("aquaNormalGradient")]
        CPTGradient AquaNormalGradient();

        // +(instancetype _Nonnull)aquaPressedGradient;
        [Static]
        [Export("aquaPressedGradient")]
        CPTGradient AquaPressedGradient();

        // +(instancetype _Nonnull)unifiedSelectedGradient;
        [Static]
        [Export("unifiedSelectedGradient")]
        CPTGradient UnifiedSelectedGradient();

        // +(instancetype _Nonnull)unifiedNormalGradient;
        [Static]
        [Export("unifiedNormalGradient")]
        CPTGradient UnifiedNormalGradient();

        // +(instancetype _Nonnull)unifiedPressedGradient;
        [Static]
        [Export("unifiedPressedGradient")]
        CPTGradient UnifiedPressedGradient();

        // +(instancetype _Nonnull)unifiedDarkGradient;
        [Static]
        [Export("unifiedDarkGradient")]
        CPTGradient UnifiedDarkGradient();

        // +(instancetype _Nonnull)sourceListSelectedGradient;
        [Static]
        [Export("sourceListSelectedGradient")]
        CPTGradient SourceListSelectedGradient();

        // +(instancetype _Nonnull)sourceListUnselectedGradient;
        [Static]
        [Export("sourceListUnselectedGradient")]
        CPTGradient SourceListUnselectedGradient();

        // +(instancetype _Nonnull)rainbowGradient;
        [Static]
        [Export("rainbowGradient")]
        CPTGradient RainbowGradient();

        // +(instancetype _Nonnull)hydrogenSpectrumGradient;
        [Static]
        [Export("hydrogenSpectrumGradient")]
        CPTGradient HydrogenSpectrumGradient();

        // -(CPTGradient * _Nonnull)gradientWithAlphaComponent:(CGFloat)alpha;
        [Export("gradientWithAlphaComponent:")]
        CPTGradient GradientWithAlphaComponent(nfloat alpha);

        // -(CPTGradient * _Nonnull)gradientWithBlendingMode:(CPTGradientBlendingMode)mode;
        [Export("gradientWithBlendingMode:")]
        CPTGradient GradientWithBlendingMode(CPTGradientBlendingMode mode);

        // -(CPTGradient * _Nonnull)addColorStop:(CPTColor * _Nonnull)color atPosition:(CGFloat)position;
        [Export("addColorStop:atPosition:")]
        CPTGradient AddColorStop(CPTColor color, nfloat position);

        // -(CPTGradient * _Nonnull)removeColorStopAtIndex:(NSUInteger)idx;
        [Export("removeColorStopAtIndex:")]
        CPTGradient RemoveColorStopAtIndex(nuint idx);

        // -(CPTGradient * _Nonnull)removeColorStopAtPosition:(CGFloat)position;
        [Export("removeColorStopAtPosition:")]
        CPTGradient RemoveColorStopAtPosition(nfloat position);

        // -(CGColorRef _Nullable)newColorStopAtIndex:(NSUInteger)idx __attribute__((cf_returns_retained));
        [Export("newColorStopAtIndex:")]
        [return: NullAllowed]
        CGColor NewColorStopAtIndex(nuint idx);

        // -(CGColorRef _Nonnull)newColorAtPosition:(CGFloat)position __attribute__((cf_returns_retained));
        [Export("newColorAtPosition:")]
        CGColor NewColorAtPosition(nfloat position);

        // -(void)drawSwatchInRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("drawSwatchInRect:inContext:")]
        unsafe void DrawSwatchInRect(CGRect rect, CGContext context);

        // -(void)fillRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("fillRect:inContext:")]
        unsafe void FillRect(CGRect rect, CGContext context);

        // -(void)fillPathInContext:(CGContextRef _Nonnull)context;
        [Export("fillPathInContext:")]
        unsafe void FillPathInContext(CGContext context);
    }

    // @interface CPTPlotAreaFrame : CPTBorderedLayer
    [BaseType(typeof(CPTBorderedLayer))]
    interface CPTPlotAreaFrame
    {
        // @property (readonly, nonatomic) CPTPlotArea * _Nullable plotArea;
        [NullAllowed, Export("plotArea")]
        CPTPlotArea PlotArea { get; }

        // @property (readwrite, nonatomic, strong) CPTAxisSet * _Nullable axisSet;
        [NullAllowed, Export("axisSet", ArgumentSemantic.Strong)]
        CPTAxisSet AxisSet { get; set; }

        // @property (readwrite, nonatomic, strong) CPTPlotGroup * _Nullable plotGroup;
        [NullAllowed, Export("plotGroup", ArgumentSemantic.Strong)]
        CPTPlotGroup PlotGroup { get; set; }
    }

    //[Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTLegendNotification  _Nonnull const CPTLegendNeedsRedrawForPlotNotification;
        [Field("CPTLegendNeedsRedrawForPlotNotification", "__Internal")]
        NSString CPTLegendNeedsRedrawForPlotNotification { get; }

        // extern CPTLegendNotification  _Nonnull const CPTLegendNeedsLayoutForPlotNotification;
        [Field("CPTLegendNeedsLayoutForPlotNotification", "__Internal")]
        NSString CPTLegendNeedsLayoutForPlotNotification { get; }

        // extern CPTLegendNotification  _Nonnull const CPTLegendNeedsReloadEntriesForPlotNotification;
        [Field("CPTLegendNeedsReloadEntriesForPlotNotification", "__Internal")]
        NSString CPTLegendNeedsReloadEntriesForPlotNotification { get; }
    }

    // @protocol CPTLegendDelegate <CPTLayerDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTLegendDelegate : CPTLayerDelegate
    {
        // @optional -(CPTFill * _Nullable)legend:(CPTLegend * _Nonnull)legend fillForEntryAtIndex:(NSUInteger)idx forPlot:(CPTPlot * _Nonnull)plot;
        [Export("legend:fillForEntryAtIndex:forPlot:")]
        [return: NullAllowed]
        CPTFill FillForEntry(CPTLegend legend, nuint idx, CPTPlot plot);

        // @optional -(CPTLineStyle * _Nullable)legend:(CPTLegend * _Nonnull)legend lineStyleForEntryAtIndex:(NSUInteger)idx forPlot:(CPTPlot * _Nonnull)plot;
        [Export("legend:lineStyleForEntryAtIndex:forPlot:")]
        [return: NullAllowed]
        CPTLineStyle LineStyle(CPTLegend legend, nuint idx, CPTPlot plot);

        // @optional -(CPTFill * _Nullable)legend:(CPTLegend * _Nonnull)legend fillForSwatchAtIndex:(NSUInteger)idx forPlot:(CPTPlot * _Nonnull)plot;
        [Export("legend:fillForSwatchAtIndex:forPlot:")]
        [return: NullAllowed]
        CPTFill FillForSwatch(CPTLegend legend, nuint idx, CPTPlot plot);

        // @optional -(CPTLineStyle * _Nullable)legend:(CPTLegend * _Nonnull)legend lineStyleForSwatchAtIndex:(NSUInteger)idx forPlot:(CPTPlot * _Nonnull)plot;
        [Export("legend:lineStyleForSwatchAtIndex:forPlot:")]
        [return: NullAllowed]
        CPTLineStyle LineStyleForSwatch(CPTLegend legend, nuint idx, CPTPlot plot);

        // @optional -(BOOL)legend:(CPTLegend * _Nonnull)legend shouldDrawSwatchAtIndex:(NSUInteger)idx forPlot:(CPTPlot * _Nonnull)plot inRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("legend:shouldDrawSwatchAtIndex:forPlot:inRect:inContext:")]
        unsafe bool ShouldDrawSwatch(CPTLegend legend, nuint idx, CPTPlot plot, CGRect rect, CGContext context);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot wasSelectedAtIndex:(NSUInteger)idx;
        [Export("legend:legendEntryForPlot:wasSelectedAtIndex:")]
        void LegendEntryForPlotWasSelectedAtIndex(CPTLegend legend, CPTPlot plot, nuint idx);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot wasSelectedAtIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("legend:legendEntryForPlot:wasSelectedAtIndex:withEvent:")]
        void LegendEntryForPlotWasSelectedAtIndex(CPTLegend legend, CPTPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot touchDownAtIndex:(NSUInteger)idx;
        [Export("legend:legendEntryForPlot:touchDownAtIndex:")]
        void LegendEntryForPlotTouchDownAtIndex(CPTLegend legend, CPTPlot plot, nuint idx);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot touchDownAtIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("legend:legendEntryForPlot:touchDownAtIndex:withEvent:")]
        void LegendEntryForPlotTouchDownAtIndex(CPTLegend legend, CPTPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot touchUpAtIndex:(NSUInteger)idx;
        [Export("legend:legendEntryForPlot:touchUpAtIndex:")]
        void LegendEntryForPlotTouchUpAtIndex(CPTLegend legend, CPTPlot plot, nuint idx);

        // @optional -(void)legend:(CPTLegend * _Nonnull)legend legendEntryForPlot:(CPTPlot * _Nonnull)plot touchUpAtIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("legend:legendEntryForPlot:touchUpAtIndex:withEvent:")]
        void LegendEntryForPlotTouchUpAtIndex(CPTLegend legend, CPTPlot plot, nuint idx, UIEvent @event);
    }

    // @interface CPTLegend : CPTBorderedLayer
    [BaseType(typeof(CPTBorderedLayer))]
    interface CPTLegend
    {
        // @property (readwrite, copy, nonatomic) CPTTextStyle * _Nullable textStyle;
        [NullAllowed, Export("textStyle", ArgumentSemantic.Copy)]
        CPTTextStyle TextStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CGSize swatchSize;
        [Export("swatchSize", ArgumentSemantic.Assign)]
        CGSize SwatchSize { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable swatchBorderLineStyle;
        [NullAllowed, Export("swatchBorderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle SwatchBorderLineStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat swatchCornerRadius;
        [Export("swatchCornerRadius")]
        nfloat SwatchCornerRadius { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable swatchFill;
        [NullAllowed, Export("swatchFill", ArgumentSemantic.Copy)]
        CPTFill SwatchFill { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable entryBorderLineStyle;
        [NullAllowed, Export("entryBorderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle EntryBorderLineStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat entryCornerRadius;
        [Export("entryCornerRadius")]
        nfloat EntryCornerRadius { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable entryFill;
        [NullAllowed, Export("entryFill", ArgumentSemantic.Copy)]
        CPTFill EntryFill { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat entryPaddingLeft;
        [Export("entryPaddingLeft")]
        nfloat EntryPaddingLeft { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat entryPaddingTop;
        [Export("entryPaddingTop")]
        nfloat EntryPaddingTop { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat entryPaddingRight;
        [Export("entryPaddingRight")]
        nfloat EntryPaddingRight { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat entryPaddingBottom;
        [Export("entryPaddingBottom")]
        nfloat EntryPaddingBottom { get; set; }

        // @property (readonly, nonatomic) BOOL layoutChanged;
        [Export("layoutChanged")]
        bool LayoutChanged { get; }

        // @property (assign, readwrite, nonatomic) NSUInteger numberOfRows;
        [Export("numberOfRows")]
        nuint NumberOfRows { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger numberOfColumns;
        [Export("numberOfColumns")]
        nuint NumberOfColumns { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL equalRows;
        [Export("equalRows")]
        bool EqualRows { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL equalColumns;
        [Export("equalColumns")]
        bool EqualColumns { get; set; }

        // @property (readwrite, copy, nonatomic) CPTNumberArray * _Nullable rowHeights;
        [NullAllowed, Export("rowHeights", ArgumentSemantic.Copy)]
        NSNumber[] RowHeights { get; set; }

        // @property (readonly, nonatomic) CPTNumberArray * _Nullable rowHeightsThatFit;
        [NullAllowed, Export("rowHeightsThatFit")]
        NSNumber[] RowHeightsThatFit { get; }

        // @property (readwrite, copy, nonatomic) CPTNumberArray * _Nullable columnWidths;
        [NullAllowed, Export("columnWidths", ArgumentSemantic.Copy)]
        NSNumber[] ColumnWidths { get; set; }

        // @property (readonly, nonatomic) CPTNumberArray * _Nullable columnWidthsThatFit;
        [NullAllowed, Export("columnWidthsThatFit")]
        NSNumber[] ColumnWidthsThatFit { get; }

        // @property (assign, readwrite, nonatomic) CGFloat columnMargin;
        [Export("columnMargin")]
        nfloat ColumnMargin { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat rowMargin;
        [Export("rowMargin")]
        nfloat RowMargin { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat titleOffset;
        [Export("titleOffset")]
        nfloat TitleOffset { get; set; }

        // @property (assign, readwrite, nonatomic) CPTLegendSwatchLayout swatchLayout;
        [Export("swatchLayout", ArgumentSemantic.Assign)]
        CPTLegendSwatchLayout SwatchLayout { get; set; }

        // +(instancetype _Nonnull)legendWithPlots:(CPTPlotArray * _Nullable)newPlots;
        [Static]
        [Export("legendWithPlots:")]
        CPTLegend LegendWithPlots([NullAllowed] CPTPlot[] newPlots);

        // +(instancetype _Nonnull)legendWithGraph:(__kindof CPTGraph * _Nullable)graph;
        [Static]
        [Export("legendWithGraph:")]
        CPTLegend LegendWithGraph(CPTGraph graph);

        // -(instancetype _Nonnull)initWithPlots:(CPTPlotArray * _Nullable)newPlots;
        [Export("initWithPlots:")]
        IntPtr Constructor([NullAllowed] CPTPlot[] newPlots);

        // -(instancetype _Nonnull)initWithGraph:(__kindof CPTGraph * _Nullable)graph;
        [Export("initWithGraph:")]
        IntPtr Constructor(CPTGraph graph);

        // -(CPTPlotArray * _Nonnull)allPlots;
        [Export("allPlots")]
        // [Verify(MethodToProperty)]
        CPTPlot[] AllPlots { get; }

        // -(CPTPlot * _Nullable)plotAtIndex:(NSUInteger)idx;
        [Export("plotAtIndex:")]
        [return: NullAllowed]
        CPTPlot PlotAtIndex(nuint idx);

        // -(CPTPlot * _Nullable)plotWithIdentifier:(id<NSCopying> _Nullable)identifier;
        [Export("plotWithIdentifier:")]
        [return: NullAllowed]
        CPTPlot PlotWithIdentifier([NullAllowed] NSCopying identifier);

        // -(void)addPlot:(CPTPlot * _Nonnull)plot;
        [Export("addPlot:")]
        void AddPlot(CPTPlot plot);

        // -(void)insertPlot:(CPTPlot * _Nonnull)plot atIndex:(NSUInteger)idx;
        [Export("insertPlot:atIndex:")]
        void InsertPlot(CPTPlot plot, nuint idx);

        // -(void)removePlot:(CPTPlot * _Nonnull)plot;
        [Export("removePlot:")]
        void RemovePlot(CPTPlot plot);

        // -(void)removePlotWithIdentifier:(id<NSCopying> _Nullable)identifier;
        [Export("removePlotWithIdentifier:")]
        void RemovePlotWithIdentifier([NullAllowed] NSCopying identifier);

        // -(void)setLayoutChanged;
        [Export("setLayoutChanged")]
        void SetLayoutChanged();
    }

    // @interface CPTTheme : NSObject <NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTTheme : INSCoding, INSSecureCoding
    {
        // extern CPTThemeName  _Nonnull const kCPTDarkGradientTheme;
        [Field("kCPTDarkGradientTheme", "__Internal")]
        NSString DarkGradientTheme { get; }

        // extern CPTThemeName  _Nonnull const kCPTPlainBlackTheme;
        [Field("kCPTPlainBlackTheme", "__Internal")]
        NSString PlainBlackTheme { get; }

        // extern CPTThemeName  _Nonnull const kCPTPlainWhiteTheme;
        [Field("kCPTPlainWhiteTheme", "__Internal")]
        NSString PlainWhiteTheme { get; }

        // extern CPTThemeName  _Nonnull const kCPTSlateTheme;
        [Field("kCPTSlateTheme", "__Internal")]
        NSString SlateTheme { get; }

        // extern CPTThemeName  _Nonnull const kCPTStocksTheme;
        [Field("kCPTStocksTheme", "__Internal")]
        NSString StocksTheme { get; }

        // @property (readwrite, nonatomic, strong) Class _Nullable graphClass;
        [NullAllowed, Export("graphClass", ArgumentSemantic.Strong)]
        Class GraphClass { get; set; }

        // +(void)registerTheme:(Class _Nonnull)themeClass;
        [Static]
        [Export("registerTheme:")]
        void RegisterTheme(Class themeClass);

        // +(NSArray<Class> * _Nullable)themeClasses;
        [Static]
        [NullAllowed, Export("themeClasses")]
        // [Verify(MethodToProperty)]
        Class[] ThemeClasses { get; }

        // +(instancetype _Nullable)themeNamed:(CPTThemeName _Nullable)themeName;
        [Static]
        [Export("themeNamed:")]
        [return: NullAllowed]
        CPTTheme ThemeNamed([NullAllowed] string themeName);

        // +(CPTThemeName _Nonnull)name;
        [Static]
        [Export("name")]
        // [Verify(MethodToProperty)]
        string Name { get; }

        // -(void)applyThemeToGraph:(CPTGraph * _Nonnull)graph;
        [Export("applyThemeToGraph:")]
        void ApplyThemeToGraph(CPTGraph graph);

        // -(id _Nullable)newGraph;
        [NullAllowed, Export("newGraph")]
        // [Verify(MethodToProperty)]
        NSObject NewGraph { get; }

        // -(void)applyThemeToBackground:(CPTGraph * _Nonnull)graph;
        [Export("applyThemeToBackground:")]
        void ApplyThemeToBackground(CPTGraph graph);

        // -(void)applyThemeToPlotArea:(CPTPlotAreaFrame * _Nonnull)plotAreaFrame;
        [Export("applyThemeToPlotArea:")]
        void ApplyThemeToPlotArea(CPTPlotAreaFrame plotAreaFrame);

        // -(void)applyThemeToAxisSet:(CPTAxisSet * _Nonnull)axisSet;
        [Export("applyThemeToAxisSet:")]
        void ApplyThemeToAxisSet(CPTAxisSet axisSet);
    }

    // @interface AbstractMethods (CPTTheme)
    /*
    [Category]
    [BaseType(typeof(CPTTheme))]
    interface CPTTheme_AbstractMethods
    {
        // -(id _Nullable)newGraph;
        [NullAllowed, Export("newGraph")]
        // [Verify(MethodToProperty)]
        NSObject NewGraph { get; }

        // -(void)applyThemeToBackground:(CPTGraph * _Nonnull)graph;
        [Export("applyThemeToBackground:")]
        void ApplyThemeToBackground(CPTGraph graph);

        // -(void)applyThemeToPlotArea:(CPTPlotAreaFrame * _Nonnull)plotAreaFrame;
        [Export("applyThemeToPlotArea:")]
        void ApplyThemeToPlotArea(CPTPlotAreaFrame plotAreaFrame);

        // -(void)applyThemeToAxisSet:(CPTAxisSet * _Nonnull)axisSet;
        [Export("applyThemeToAxisSet:")]
        void ApplyThemeToAxisSet(CPTAxisSet axisSet);
    }
    */

    // @interface CPTImage : NSObject <NSCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTImage : INSCopying, INSCoding, INSSecureCoding
    {
        // @property (readwrite, copy, nonatomic) CPTNativeImage * _Nullable nativeImage;
        [NullAllowed, Export("nativeImage", ArgumentSemantic.Copy)]
        UIImage NativeImage { get; set; }

        // @property (assign, readwrite, nonatomic) CGImageRef _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Assign)]
        CGImage Image { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat scale;
        [Export("scale")]
        nfloat Scale { get; set; }

        // @property (getter = isTiled, assign, readwrite, nonatomic) BOOL tiled;
        [Export("tiled")]
        bool Tiled { [Bind("isTiled")] get; set; }

        // @property (assign, readwrite, nonatomic) CPTEdgeInsets edgeInsets;
        [Export("edgeInsets", ArgumentSemantic.Assign)]
        CPTEdgeInsets EdgeInsets { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL tileAnchoredToContext;
        [Export("tileAnchoredToContext")]
        bool TileAnchoredToContext { get; set; }

        // @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; }

        // +(instancetype _Nonnull)imageNamed:(NSString * _Nonnull)name;
        [Static]
        [Export("imageNamed:")]
        CPTImage ImageNamed(string name);

        // +(instancetype _Nonnull)imageWithNativeImage:(CPTNativeImage * _Nullable)anImage;
        [Static]
        [Export("imageWithNativeImage:")]
        CPTImage ImageWithNativeImage([NullAllowed] UIImage anImage);

        // +(instancetype _Nonnull)imageWithContentsOfFile:(NSString * _Nonnull)path;
        [Static]
        [Export("imageWithContentsOfFile:")]
        CPTImage ImageWithContentsOfFile(string path);

        // +(instancetype _Nonnull)imageWithCGImage:(CGImageRef _Nullable)anImage scale:(CGFloat)newScale;
        [Static]
        [Export("imageWithCGImage:scale:")]
        unsafe CPTImage ImageWithCGImage([NullAllowed] CGImage anImage, nfloat newScale);

        // +(instancetype _Nonnull)imageWithCGImage:(CGImageRef _Nullable)anImage;
        [Static]
        [Export("imageWithCGImage:")]
        unsafe CPTImage ImageWithCGImage([NullAllowed] CGImage anImage);

        // +(instancetype _Nonnull)imageForPNGFile:(NSString * _Nonnull)path;
        [Static]
        [Export("imageForPNGFile:")]
        CPTImage ImageForPNGFile(string path);

        // -(instancetype _Nonnull)initWithContentsOfFile:(NSString * _Nonnull)path;
        [Export("initWithContentsOfFile:")]
        IntPtr Constructor(string path);

        // -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nullable)anImage scale:(CGFloat)newScale __attribute__((objc_designated_initializer));
        [Export("initWithCGImage:scale:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] CGImage anImage, nfloat newScale);

        // -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nullable)anImage;
        [Export("initWithCGImage:")]
        IntPtr Constructor([NullAllowed] CGImage anImage);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // -(void)drawInRect:(CGRect)rect inContext:(CGContextRef _Nonnull)context;
        [Export("drawInRect:inContext:")]
        void DrawInRect(CGRect rect, CGContext context);

        // -(instancetype _Nonnull)initWithNativeImage:(CPTNativeImage * _Nullable)anImage;
        [Export("initWithNativeImage:")]
        IntPtr Constructor([NullAllowed] UIImage anImage);
    }

    // @interface CPTPlatformSpecificImageExtensions (CPTImage)
    //[Category]
    //[BaseType(typeof(CPTImage))]
    //interface CPTImage_CPTPlatformSpecificImageExtensions
    //{
    //    // -(instancetype _Nonnull)initWithNativeImage:(CPTNativeImage * _Nullable)anImage;
    //    [Export("initWithNativeImage:")]
    //    IntPtr Constructor([NullAllowed] UIImage anImage);

    //    // -(instancetype _Nonnull)initForPNGFile:(NSString * _Nonnull)path;
    //    [Export("initForPNGFile:")]
    //    IntPtr Constructor(string path);
    //}

    // @interface CPTNumericData : NSObject <NSCopying, NSMutableCopying, NSCoding, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface CPTNumericData : INSCopying, INSMutableCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSData * _Nonnull data;
        [Export("data", ArgumentSemantic.Copy)]
        NSData Data { get; }

        // @property (readonly, nonatomic) const void * _Nonnull bytes;
        [Export("bytes")]
        IntPtr Bytes { get; }

        // @property (readonly, nonatomic) NSUInteger length;
        [Export("length")]
        nuint Length { get; }

        // @property (readonly, nonatomic) CPTNumericDataType dataType;
        [Export("dataType")]
        CPTNumericDataType DataType { get; }

        // @property (readonly, nonatomic) CPTDataTypeFormat dataTypeFormat;
        [Export("dataTypeFormat")]
        CPTDataTypeFormat DataTypeFormat { get; }

        // @property (readonly, nonatomic) size_t sampleBytes;
        [Export("sampleBytes")]
        nuint SampleBytes { get; }

        // @property (readonly, nonatomic) CFByteOrder byteOrder;
        [Export("byteOrder")]
        nint ByteOrder { get; }

        // @property (readonly, copy, nonatomic) CPTNumberArray * _Nonnull shape;
        [Export("shape", ArgumentSemantic.Copy)]
        NSNumber[] Shape { get; }

        // @property (readonly, nonatomic) NSUInteger numberOfDimensions;
        [Export("numberOfDimensions")]
        nuint NumberOfDimensions { get; }

        // @property (readonly, nonatomic) NSUInteger numberOfSamples;
        [Export("numberOfSamples")]
        nuint NumberOfSamples { get; }

        // @property (readonly, nonatomic) CPTDataOrder dataOrder;
        [Export("dataOrder")]
        CPTDataOrder DataOrder { get; }

        // +(instancetype _Nonnull)numericDataWithData:(NSData * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray;
        [Static]
        [Export("numericDataWithData:dataType:shape:")]
        CPTNumericData NumericDataWithData(NSData newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray);

        // +(instancetype _Nonnull)numericDataWithData:(NSData * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray;
        [Static]
        [Export("numericDataWithData:dataTypeString:shape:")]
        CPTNumericData NumericDataWithData(NSData newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray);

        // +(instancetype _Nonnull)numericDataWithArray:(CPTNumberArray * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray;
        [Static]
        [Export("numericDataWithArray:dataType:shape:")]
        CPTNumericData NumericDataWithArray(NSNumber[] newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray);

        // +(instancetype _Nonnull)numericDataWithArray:(CPTNumberArray * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray;
        [Static]
        [Export("numericDataWithArray:dataTypeString:shape:")]
        CPTNumericData NumericDataWithArray(NSNumber[] newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray);

        // +(instancetype _Nonnull)numericDataWithData:(NSData * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Static]
        [Export("numericDataWithData:dataType:shape:dataOrder:")]
        CPTNumericData NumericDataWithData(NSData newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // +(instancetype _Nonnull)numericDataWithData:(NSData * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Static]
        [Export("numericDataWithData:dataTypeString:shape:dataOrder:")]
        CPTNumericData NumericDataWithData(NSData newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // +(instancetype _Nonnull)numericDataWithArray:(CPTNumberArray * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Static]
        [Export("numericDataWithArray:dataType:shape:dataOrder:")]
        CPTNumericData NumericDataWithArray(NSNumber[] newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // +(instancetype _Nonnull)numericDataWithArray:(CPTNumberArray * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Static]
        [Export("numericDataWithArray:dataTypeString:shape:dataOrder:")]
        CPTNumericData NumericDataWithArray(NSNumber[] newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray;
        [Export("initWithData:dataType:shape:")]
        IntPtr Constructor(NSData newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray);

        // -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray;
        [Export("initWithData:dataTypeString:shape:")]
        IntPtr Constructor(NSData newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray);

        // -(instancetype _Nonnull)initWithArray:(CPTNumberArray * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray;
        [Export("initWithArray:dataType:shape:")]
        IntPtr Constructor(NSNumber[] newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray);

        // -(instancetype _Nonnull)initWithArray:(CPTNumberArray * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray;
        [Export("initWithArray:dataTypeString:shape:")]
        IntPtr Constructor(NSNumber[] newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray);

        // -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order __attribute__((objc_designated_initializer));
        [Export("initWithData:dataType:shape:dataOrder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSData newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Export("initWithData:dataTypeString:shape:dataOrder:")]
        IntPtr Constructor(NSData newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // -(instancetype _Nonnull)initWithArray:(CPTNumberArray * _Nonnull)newData dataType:(CPTNumericDataType)newDataType shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Export("initWithArray:dataType:shape:dataOrder:")]
        IntPtr Constructor(NSNumber[] newData, CPTNumericDataType newDataType, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // -(instancetype _Nonnull)initWithArray:(CPTNumberArray * _Nonnull)newData dataTypeString:(NSString * _Nonnull)newDataTypeString shape:(CPTNumberArray * _Nullable)shapeArray dataOrder:(CPTDataOrder)order;
        [Export("initWithArray:dataTypeString:shape:dataOrder:")]
        IntPtr Constructor(NSNumber[] newData, string newDataTypeString, [NullAllowed] NSNumber[] shapeArray, CPTDataOrder order);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(NSUInteger)sampleIndex:(NSUInteger)idx, ...;
        [Internal]
        [Export("sampleIndex:", IsVariadic = true)]
        nuint SampleIndex(nuint idx, IntPtr varArgs);

        // -(const void * _Nullable)samplePointer:(NSUInteger)sample __attribute__((objc_returns_inner_pointer));
        [Export("samplePointer:")]
        [return: NullAllowed]
        IntPtr SamplePointer(nuint sample);

        // -(const void * _Nullable)samplePointerAtIndex:(NSUInteger)idx, ... __attribute__((objc_returns_inner_pointer));
        [Internal]
        [Export("samplePointerAtIndex:", IsVariadic = true)]
        [return: NullAllowed]
        IntPtr SamplePointerAtIndex(nuint idx, IntPtr varArgs);

        // -(NSNumber * _Nullable)sampleValue:(NSUInteger)sample;
        [Export("sampleValue:")]
        [return: NullAllowed]
        NSNumber SampleValue(nuint sample);

        // -(NSNumber * _Nullable)sampleValueAtIndex:(NSUInteger)idx, ...;
        [Internal]
        [Export("sampleValueAtIndex:", IsVariadic = true)]
        [return: NullAllowed]
        NSNumber SampleValueAtIndex(nuint idx, IntPtr varArgs);

        // -(CPTNumberArray * _Nonnull)sampleArray;
        [Export("sampleArray")]
        // [Verify(MethodToProperty)]
        NSNumber[] SampleArray { get; }
    }

    // @interface CPTMutableNumericData : CPTNumericData
    [BaseType(typeof(CPTNumericData))]
    interface CPTMutableNumericData
    {
        // @property (readonly, nonatomic) void * _Nonnull mutableBytes;
        [Export("mutableBytes")]
        //IntPtr MutableBytes { get; }
        IntPtr MutableBytes { get; }

        // @property (readwrite, copy, nonatomic) CPTNumberArray * _Nonnull shape;
        [Export("shape", ArgumentSemantic.Copy)]
        [New]
        NSNumber[] Shape { get; set; }

        // -(void * _Nullable)mutableSamplePointer:(NSUInteger)sample __attribute__((objc_returns_inner_pointer));
        [Export("mutableSamplePointer:")]
        [return: NullAllowed]
        IntPtr MutableSamplePointer(nuint sample);

        // -(void * _Nullable)mutableSamplePointerAtIndex:(NSUInteger)idx, ... __attribute__((objc_returns_inner_pointer));
        [Internal]
        [Export("mutableSamplePointerAtIndex:", IsVariadic = true)]
        [return: NullAllowed]
        IntPtr MutableSamplePointerAtIndex(nuint idx, IntPtr varArgs);
    }

    // @interface CPTPlotSpaceAnnotation : CPTAnnotation
    [BaseType(typeof(CPTAnnotation))]
    interface CPTPlotSpaceAnnotation
    {
        // @property (readwrite, copy, nonatomic) CPTNumberArray * _Nullable anchorPlotPoint;
        [NullAllowed, Export("anchorPlotPoint", ArgumentSemantic.Copy)]
        NSNumber[] AnchorPlotPoint { get; set; }

        // @property (readonly, nonatomic) CPTPlotSpace * _Nonnull plotSpace;
        [Export("plotSpace")]
        CPTPlotSpace PlotSpace { get; }

        // -(instancetype _Nonnull)initWithPlotSpace:(CPTPlotSpace * _Nonnull)space anchorPlotPoint:(CPTNumberArray * _Nullable)plotPoint __attribute__((objc_designated_initializer));
        [Export("initWithPlotSpace:anchorPlotPoint:")]
        [DesignatedInitializer]
        IntPtr Constructor(CPTPlotSpace space, [NullAllowed] NSNumber[] plotPoint);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface CPTGridLineGroup
    [BaseType(typeof(CPTLayer))]
    interface CPTGridLineGroup
    {
        // @property (readwrite, nonatomic) CPTPlotArea * plotArea;
        [Export("plotArea", ArgumentSemantic.Assign)]
        CPTPlotArea PlotArea { get; set; }

        // @property (readwrite, nonatomic) int major;
        [Export("major")]
        int Major { get; set; }
    }

    // @interface CPTPlotGroup
    [BaseType(typeof(CPTLayer))]
    interface CPTPlotGroup
    {
        // -(void)addPlot:(CPTPlot * _Nonnull)plot;
        [Export("addPlot:")]
        void AddPlot(CPTPlot plot);

        // -(void)removePlot:(CPTPlot * _Nullable)plot;
        [Export("removePlot:")]
        void RemovePlot([NullAllowed] CPTPlot plot);

        // -(void)insertPlot:(CPTPlot * _Nonnull)plot atIndex:(id)idx;
        [Export("insertPlot:atIndex:")]
        void InsertPlot(CPTPlot plot, NSObject idx);
    }

    // @interface CPTAxisLabelGroup
    [BaseType(typeof(CPTLayer))]
    interface CPTAxisLabelGroup
    {
    }

    // @interface CPTXYGraph : CPTGraph
    [BaseType(typeof(CPTGraph))]
    interface CPTXYGraph
    {
        //-(nonnull instancetype) initWithFrame:(CGRect) newFrame NS_DESIGNATED_INITIALIZER;
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect newFrame);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)newFrame xScaleType:(CPTScaleType)newXScaleType yScaleType:(CPTScaleType)newYScaleType __attribute__((objc_designated_initializer));
        [Export("initWithFrame:xScaleType:yScaleType:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect newFrame, CPTScaleType newXScaleType, CPTScaleType newYScaleType);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject layer);
    }

    // @interface CPTMutableLineStyle : CPTLineStyle
    [BaseType(typeof(CPTLineStyle))]
    interface CPTMutableLineStyle
    {
        // @property (assign, readwrite, nonatomic) CGLineCap lineCap;
        [Export("lineCap", ArgumentSemantic.Assign)]
        [New]
        CGLineCap LineCap { get; set; }

        // @property (assign, readwrite, nonatomic) CGLineJoin lineJoin;
        [Export("lineJoin", ArgumentSemantic.Assign)]
        [New]
        CGLineJoin LineJoin { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat miterLimit;
        [Export("miterLimit")]
        [New]
        nfloat MiterLimit { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        [New]
        nfloat LineWidth { get; set; }

        // @property (readwrite, nonatomic, strong) CPTNumberArray * _Nullable dashPattern;
        [NullAllowed, Export("dashPattern", ArgumentSemantic.Strong)]
        [New]
        NSNumber[] DashPattern { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat patternPhase;
        [Export("patternPhase")]
        [New]
        nfloat PatternPhase { get; set; }

        // @property (readwrite, nonatomic, strong) CPTColor * _Nullable lineColor;
        [NullAllowed, Export("lineColor", ArgumentSemantic.Strong)]
        [New]
        CPTColor LineColor { get; set; }

        // @property (readwrite, nonatomic, strong) CPTFill * _Nullable lineFill;
        [NullAllowed, Export("lineFill", ArgumentSemantic.Strong)]
        [New]
        CPTFill LineFill { get; set; }

        // @property (readwrite, nonatomic, strong) CPTGradient * _Nullable lineGradient;
        [NullAllowed, Export("lineGradient", ArgumentSemantic.Strong)]
        [New]
        CPTGradient LineGradient { get; set; }
    }

    // @interface CPTMutablePlotRange : CPTPlotRange
    [BaseType(typeof(CPTPlotRange))]
    interface CPTMutablePlotRange
    {
        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull location;
        [Export("location", ArgumentSemantic.Strong)]
        [New]
        NSNumber Location { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull length;
        [Export("length", ArgumentSemantic.Strong)]
        [New]
        NSNumber Length { get; set; }

        // @property (readwrite, nonatomic) NSDecimal locationDecimal;
        [Export("locationDecimal", ArgumentSemantic.Assign)]
        [New]
        NSDecimal LocationDecimal { get; set; }

        // @property (readwrite, nonatomic) NSDecimal lengthDecimal;
        [Export("lengthDecimal", ArgumentSemantic.Assign)]
        [New]
        NSDecimal LengthDecimal { get; set; }

        // @property (readwrite, nonatomic) double locationDouble;
        [Export("locationDouble")]
        [New]
        double LocationDouble { get; set; }

        // @property (readwrite, nonatomic) double lengthDouble;
        [Export("lengthDouble")]
        [New]
        double LengthDouble { get; set; }

        // -(void)unionPlotRange:(CPTPlotRange * _Nullable)otherRange;
        [Export("unionPlotRange:")]
        void UnionPlotRange([NullAllowed] CPTPlotRange otherRange);

        // -(void)intersectionPlotRange:(CPTPlotRange * _Nullable)otherRange;
        [Export("intersectionPlotRange:")]
        void IntersectionPlotRange([NullAllowed] CPTPlotRange otherRange);

        // -(void)shiftLocationToFitInRange:(CPTPlotRange * _Nonnull)otherRange;
        [Export("shiftLocationToFitInRange:")]
        void ShiftLocationToFitInRange(CPTPlotRange otherRange);

        // -(void)shiftEndToFitInRange:(CPTPlotRange * _Nonnull)otherRange;
        [Export("shiftEndToFitInRange:")]
        void ShiftEndToFitInRange(CPTPlotRange otherRange);

        // -(void)expandRangeByFactor:(NSNumber * _Nonnull)factor;
        [Export("expandRangeByFactor:")]
        void ExpandRangeByFactor(NSNumber factor);
    }

    // @interface CPTMutableShadow : CPTShadow
    [BaseType(typeof(CPTShadow))]
    interface CPTMutableShadow
    {
        // @property (assign, readwrite, nonatomic) int shadowOffset;
        [Export("shadowOffset")]
        [New]
        int ShadowOffset { get; set; }

        // @property (assign, readwrite, nonatomic) int shadowBlurRadius;
        [Export("shadowBlurRadius")]
        [New]
        int ShadowBlurRadius { get; set; }

        // @property (readwrite, nonatomic, strong) CPTColor * _Nullable shadowColor;
        [NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
        [New]
        CPTColor ShadowColor { get; set; }
    }

    // @interface CPTMutableTextStyle : CPTTextStyle
    [BaseType(typeof(CPTTextStyle))]
    interface CPTMutableTextStyle
    {
        // @property (readwrite, copy, nonatomic) NSString * _Nullable fontName;
        [NullAllowed, Export("fontName")]
        [New]
        string FontName { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat fontSize;
        [Export("fontSize")]
        [New]
        nfloat FontSize { get; set; }

        // @property (readwrite, copy, nonatomic) CPTColor * _Nullable color;
        [NullAllowed, Export("color", ArgumentSemantic.Copy)]
        [New]
        CPTColor Color { get; set; }

        // @property (assign, readwrite, nonatomic) CPTTextAlignment textAlignment;
        [Export("textAlignment", ArgumentSemantic.Assign)]
        [New]
        CPTTextAlignment TextAlignment { get; set; }

        // @property (assign, readwrite, nonatomic) NSLineBreakMode lineBreakMode;
        [Export("lineBreakMode", ArgumentSemantic.Assign)]
        [New]
        UILineBreakMode LineBreakMode { get; set; }
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingXValues;
        [Field("CPTRangePlotBindingXValues", "__Internal")]
        NSString CPTRangePlotBindingXValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingYValues;
        [Field("CPTRangePlotBindingYValues", "__Internal")]
        NSString CPTRangePlotBindingYValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingHighValues;
        [Field("CPTRangePlotBindingHighValues", "__Internal")]
        NSString CPTRangePlotBindingHighValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingLowValues;
        [Field("CPTRangePlotBindingLowValues", "__Internal")]
        NSString CPTRangePlotBindingLowValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingLeftValues;
        [Field("CPTRangePlotBindingLeftValues", "__Internal")]
        NSString CPTRangePlotBindingLeftValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingRightValues;
        [Field("CPTRangePlotBindingRightValues", "__Internal")]
        NSString CPTRangePlotBindingRightValues { get; }

        // extern CPTRangePlotBinding  _Nonnull const CPTRangePlotBindingBarLineStyles;
        [Field("CPTRangePlotBindingBarLineStyles", "__Internal")]
        NSString CPTRangePlotBindingBarLineStyles { get; }
    }

    interface ICPTRangePlotDataSource
    { }

    // @protocol CPTRangePlotDataSource <CPTPlotDataSource>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTRangePlotDataSource : CPTPlotDataSource
    {
        // @optional -(CPTLineStyleArray * _Nullable)barLineStylesForRangePlot:(CPTRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("barLineStylesForRangePlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLineStyle[] BarLineStyles (CPTRangePlot plot, NSRange indexRange);

        // @optional -(CPTLineStyle * _Nullable)barLineStyleForRangePlot:(CPTRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("barLineStyleForRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTLineStyle BarLineStyle (CPTRangePlot plot, nuint idx);
    }

    // @protocol CPTRangePlotDelegate <CPTPlotDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTRangePlotDelegate : CPTPlotDelegate
    {
        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("rangePlot:rangeWasSelectedAtRecordIndex:")]
        void RangeWasSelected (CPTRangePlot plot, nuint idx);

        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("rangePlot:rangeWasSelectedAtRecordIndex:withEvent:")]
        void RangeWasSelected (CPTRangePlot plot, nuint idx, UIEvent @event);

        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("rangePlot:rangeTouchDownAtRecordIndex:")]
        void RangeTouchDown (CPTRangePlot plot, nuint idx);

        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("rangePlot:rangeTouchDownAtRecordIndex:withEvent:")]
        void RangeTouchDown (CPTRangePlot plot, nuint idx, UIEvent @event);

        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("rangePlot:rangeTouchUpAtRecordIndex:")]
        void RangeTouchUp (CPTRangePlot plot, nuint idx);

        // @optional -(void)rangePlot:(CPTRangePlot * _Nonnull)plot rangeTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("rangePlot:rangeTouchUpAtRecordIndex:withEvent:")]
        void RangeTouchUp (CPTRangePlot plot, nuint idx, UIEvent @event);
    }

    // @interface CPTRangePlot : CPTPlot
    [BaseType(typeof(CPTPlot))]
    interface CPTRangePlot
    {
        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable barLineStyle;
        [NullAllowed, Export("barLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle BarLineStyle { get; set; }

        // @property (readwrite, nonatomic) CGFloat barWidth;
        [Export("barWidth")]
        nfloat BarWidth { get; set; }

        // @property (readwrite, nonatomic) CGFloat gapHeight;
        [Export("gapHeight")]
        nfloat GapHeight { get; set; }

        // @property (readwrite, nonatomic) CGFloat gapWidth;
        [Export("gapWidth")]
        nfloat GapWidth { get; set; }

        // @property (copy, nonatomic) CPTFill * _Nullable areaFill;
        [NullAllowed, Export("areaFill", ArgumentSemantic.Copy)]
        CPTFill AreaFill { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable areaBorderLineStyle;
        [NullAllowed, Export("areaBorderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle AreaBorderLineStyle { get; set; }

        // -(void)reloadBarLineStyles;
        [Export("reloadBarLineStyles")]
        void ReloadBarLineStyles();

        // -(void)reloadBarLineStylesInIndexRange:(NSRange)indexRange;
        [Export("reloadBarLineStylesInIndexRange:")]
        void ReloadBarLineStylesInIndexRange(NSRange indexRange);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTBarPlotBinding  _Nonnull const CPTBarPlotBindingBarLocations;
        [Field("CPTBarPlotBindingBarLocations", "__Internal")]
        NSString CPTBarPlotBindingBarLocations { get; }

        // extern CPTBarPlotBinding  _Nonnull const CPTBarPlotBindingBarTips;
        [Field("CPTBarPlotBindingBarTips", "__Internal")]
        NSString CPTBarPlotBindingBarTips { get; }

        // extern CPTBarPlotBinding  _Nonnull const CPTBarPlotBindingBarBases;
        [Field("CPTBarPlotBindingBarBases", "__Internal")]
        NSString CPTBarPlotBindingBarBases { get; }

        // extern CPTBarPlotBinding  _Nonnull const CPTBarPlotBindingBarFills;
        [Field("CPTBarPlotBindingBarFills", "__Internal")]
        NSString CPTBarPlotBindingBarFills { get; }

        // extern CPTBarPlotBinding  _Nonnull const CPTBarPlotBindingBarLineStyles;
        [Field("CPTBarPlotBindingBarLineStyles", "__Internal")]
        NSString CPTBarPlotBindingBarLineStyles { get; }
    }

    // @protocol CPTBarPlotDataSource <CPTPlotDataSource>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTBarPlotDataSource : CPTPlotDataSource
    {
        // @optional -(CPTFillArray * _Nullable)barFillsForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndexRange:(NSRange)indexRange;
        [Export("barFillsForBarPlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTFill[] BarFills (CPTBarPlot barPlot, NSRange indexRange);

        // @optional -(CPTFill * _Nullable)barFillForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndex:(NSUInteger)idx;
        [Export("barFillForBarPlot:recordIndex:")]
        [return: NullAllowed]
        CPTFill BarFill (CPTBarPlot barPlot, nuint idx);

        // @optional -(CPTLineStyleArray * _Nullable)barLineStylesForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndexRange:(NSRange)indexRange;
        [Export("barLineStylesForBarPlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLineStyle[] BarLineStyles (CPTBarPlot barPlot, NSRange indexRange);

        // @optional -(CPTLineStyle * _Nullable)barLineStyleForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndex:(NSUInteger)idx;
        [Export("barLineStyleForBarPlot:recordIndex:")]
        [return: NullAllowed]
        CPTLineStyle BarLineStyle (CPTBarPlot barPlot, nuint idx);

        // @optional -(NSString * _Nullable)legendTitleForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndex:(NSUInteger)idx;
        [Export("legendTitleForBarPlot:recordIndex:")]
        [return: NullAllowed]
        string LegendTitle (CPTBarPlot barPlot, nuint idx);

        // @optional -(NSAttributedString * _Nullable)attributedLegendTitleForBarPlot:(CPTBarPlot * _Nonnull)barPlot recordIndex:(NSUInteger)idx;
        [Export("attributedLegendTitleForBarPlot:recordIndex:")]
        [return: NullAllowed]
        NSAttributedString AttributedLegendTitle (CPTBarPlot barPlot, nuint idx);
    }

    // @protocol CPTBarPlotDelegate <CPTPlotDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTBarPlotDelegate : CPTPlotDelegate
    {
        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("barPlot:barWasSelectedAtRecordIndex:")]
        void BarWasSelected (CPTBarPlot plot, nuint idx);

        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("barPlot:barWasSelectedAtRecordIndex:withEvent:")]
        void BarWasSelected (CPTBarPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("barPlot:barTouchDownAtRecordIndex:")]
        void BarTouchDown (CPTBarPlot plot, nuint idx);

        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("barPlot:barTouchDownAtRecordIndex:withEvent:")]
        void BarTouchDown (CPTBarPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("barPlot:barTouchUpAtRecordIndex:")]
        void BarTouchUp (CPTBarPlot plot, nuint idx);

        // @optional -(void)barPlot:(CPTBarPlot * _Nonnull)plot barTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("barPlot:barTouchUpAtRecordIndex:withEvent:")]
        void BarTouchUp (CPTBarPlot plot, nuint idx, UIEvent @event);
    }

    // @interface CPTBarPlot : CPTPlot
    [BaseType(typeof(CPTPlot))]
    interface CPTBarPlot
    {
        // @property (assign, readwrite, nonatomic) BOOL barWidthsAreInViewCoordinates;
        [Export("barWidthsAreInViewCoordinates")]
        bool BarWidthsAreInViewCoordinates { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull barWidth;
        [Export("barWidth", ArgumentSemantic.Strong)]
        NSNumber BarWidth { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull barOffset;
        [Export("barOffset", ArgumentSemantic.Strong)]
        NSNumber BarOffset { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat barCornerRadius;
        [Export("barCornerRadius")]
        nfloat BarCornerRadius { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat barBaseCornerRadius;
        [Export("barBaseCornerRadius")]
        nfloat BarBaseCornerRadius { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL barsAreHorizontal;
        [Export("barsAreHorizontal")]
        bool BarsAreHorizontal { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull baseValue;
        [Export("baseValue", ArgumentSemantic.Strong)]
        NSNumber BaseValue { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL barBasesVary;
        [Export("barBasesVary")]
        bool BarBasesVary { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable plotRange;
        [NullAllowed, Export("plotRange", ArgumentSemantic.Copy)]
        CPTPlotRange PlotRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable lineStyle;
        [NullAllowed, Export("lineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle LineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Copy)]
        CPTFill Fill { get; set; }

        // +(instancetype _Nonnull)tubularBarPlotWithColor:(CPTColor * _Nonnull)color horizontalBars:(BOOL)horizontal;
        [Static]
        [Export("tubularBarPlotWithColor:horizontalBars:")]
        CPTBarPlot TubularBarPlotWithColor(CPTColor color, bool horizontal);

        // -(CPTPlotRange * _Nullable)plotRangeEnclosingBars;
        [NullAllowed, Export("plotRangeEnclosingBars")]
        //[Verify(MethodToProperty)]
        CPTPlotRange PlotRangeEnclosingBars { get; }

        // -(void)reloadBarFills;
        [Export("reloadBarFills")]
        void ReloadBarFills();

        // -(void)reloadBarFillsInIndexRange:(NSRange)indexRange;
        [Export("reloadBarFillsInIndexRange:")]
        void ReloadBarFillsInIndexRange(NSRange indexRange);

        // -(void)reloadBarLineStyles;
        [Export("reloadBarLineStyles")]
        void ReloadBarLineStyles();

        // -(void)reloadBarLineStylesInIndexRange:(NSRange)indexRange;
        [Export("reloadBarLineStylesInIndexRange:")]
        void ReloadBarLineStylesInIndexRange(NSRange indexRange);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTPieChartBinding  _Nonnull const CPTPieChartBindingPieSliceWidthValues;
        [Field("CPTPieChartBindingPieSliceWidthValues", "__Internal")]
        NSString CPTPieChartBindingPieSliceWidthValues { get; }

        // extern CPTPieChartBinding  _Nonnull const CPTPieChartBindingPieSliceFills;
        [Field("CPTPieChartBindingPieSliceFills", "__Internal")]
        NSString CPTPieChartBindingPieSliceFills { get; }

        // extern CPTPieChartBinding  _Nonnull const CPTPieChartBindingPieSliceRadialOffsets;
        [Field("CPTPieChartBindingPieSliceRadialOffsets", "__Internal")]
        NSString CPTPieChartBindingPieSliceRadialOffsets { get; }
    }

    // @protocol CPTPieChartDataSource <CPTPlotDataSource>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTPieChartDataSource : CPTPlotDataSource
    {
        // @optional -(CPTFillArray * _Nullable)sliceFillsForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndexRange:(NSRange)indexRange;
        [Export("sliceFillsForPieChart:recordIndexRange:")]
        [return: NullAllowed]
		CPTFill[] SliceFills(CPTPieChart pieChart, NSRange indexRange);

        // @optional -(CPTFill * _Nullable)sliceFillForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndex:(NSUInteger)idx;
        [Export("sliceFillForPieChart:recordIndex:")]
        [return: NullAllowed]
		CPTFill SliceFill(CPTPieChart pieChart, nuint idx);

        // @optional -(CPTNumberArray * _Nullable)radialOffsetsForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndexRange:(NSRange)indexRange;
        [Export("radialOffsetsForPieChart:recordIndexRange:")]
        [return: NullAllowed]
		NSNumber[] RaidlOffsets(CPTPieChart pieChart, NSRange indexRange);

        // @optional -(CGFloat)radialOffsetForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndex:(NSUInteger)idx;
        [Export("radialOffsetForPieChart:recordIndex:")]
		nfloat RaidlOffset(CPTPieChart pieChart, nuint idx);

        // @optional -(NSString * _Nullable)legendTitleForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndex:(NSUInteger)idx;
        [Export("legendTitleForPieChart:recordIndex:")]
        [return: NullAllowed]
		string LegendTitle(CPTPieChart pieChart, nuint idx);

        // @optional -(NSAttributedString * _Nullable)attributedLegendTitleForPieChart:(CPTPieChart * _Nonnull)pieChart recordIndex:(NSUInteger)idx;
        [Export("attributedLegendTitleForPieChart:recordIndex:")]
        [return: NullAllowed]
		NSAttributedString AttributedLegendTitle(CPTPieChart pieChart, nuint idx);
    }

    // @protocol CPTPieChartDelegate <CPTPlotDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTPieChartDelegate : CPTPlotDelegate
    {
        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("pieChart:sliceWasSelectedAtRecordIndex:")]
        void SliceWasSelected (CPTPieChart plot, nuint idx);

        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("pieChart:sliceWasSelectedAtRecordIndex:withEvent:")]
        void SliceWasSelected (CPTPieChart plot, nuint idx, UIEvent @event);

        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("pieChart:sliceTouchDownAtRecordIndex:")]
        void SliceTouchDown (CPTPieChart plot, nuint idx);

        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("pieChart:sliceTouchDownAtRecordIndex:withEvent:")]
        void SliceTouchDown (CPTPieChart plot, nuint idx, UIEvent @event);

        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("pieChart:sliceTouchUpAtRecordIndex:")]
        void SliceTouchUp (CPTPieChart plot, nuint idx);

        // @optional -(void)pieChart:(CPTPieChart * _Nonnull)plot sliceTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("pieChart:sliceTouchUpAtRecordIndex:withEvent:")]
        void SliceTouchUp (CPTPieChart plot, nuint idx, UIEvent @event);
    }

    // @interface CPTPieChart : CPTPlot
    [BaseType(typeof(CPTPlot))]
    interface CPTPieChart
    {
        // @property (readwrite, nonatomic) CGFloat pieRadius;
        [Export("pieRadius")]
        nfloat PieRadius { get; set; }

        // @property (readwrite, nonatomic) CGFloat pieInnerRadius;
        [Export("pieInnerRadius")]
        nfloat PieInnerRadius { get; set; }

        // @property (readwrite, nonatomic) CGFloat startAngle;
        [Export("startAngle")]
        nfloat StartAngle { get; set; }

        // @property (readwrite, nonatomic) CGFloat endAngle;
        [Export("endAngle")]
        nfloat EndAngle { get; set; }

        // @property (readwrite, nonatomic) CPTPieDirection sliceDirection;
        [Export("sliceDirection", ArgumentSemantic.Assign)]
        CPTPieDirection SliceDirection { get; set; }

        // @property (readwrite, nonatomic) CGPoint centerAnchor;
        [Export("centerAnchor", ArgumentSemantic.Assign)]
        CGPoint CenterAnchor { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable borderLineStyle;
        [NullAllowed, Export("borderLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle BorderLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable overlayFill;
        [NullAllowed, Export("overlayFill", ArgumentSemantic.Copy)]
        CPTFill OverlayFill { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL labelRotationRelativeToRadius;
        [Export("labelRotationRelativeToRadius")]
        bool LabelRotationRelativeToRadius { get; set; }

        // -(void)reloadSliceFills;
        [Export("reloadSliceFills")]
        void ReloadSliceFills();

        // -(void)reloadSliceFillsInIndexRange:(NSRange)indexRange;
        [Export("reloadSliceFillsInIndexRange:")]
        void ReloadSliceFillsInIndexRange(NSRange indexRange);

        // -(void)reloadRadialOffsets;
        [Export("reloadRadialOffsets")]
        void ReloadRadialOffsets();

        // -(void)reloadRadialOffsetsInIndexRange:(NSRange)indexRange;
        [Export("reloadRadialOffsetsInIndexRange:")]
        void ReloadRadialOffsetsInIndexRange(NSRange indexRange);

        // -(NSUInteger)pieSliceIndexAtAngle:(CGFloat)angle;
        [Export("pieSliceIndexAtAngle:")]
        nuint PieSliceIndexAtAngle(nfloat angle);

        // -(CGFloat)medianAngleForPieSliceIndex:(NSUInteger)idx;
        [Export("medianAngleForPieSliceIndex:")]
        nfloat MedianAngleForPieSliceIndex(nuint idx);

        // +(CPTColor * _Nonnull)defaultPieSliceColorForIndex:(NSUInteger)pieSliceIndex;
        [Static]
        [Export("defaultPieSliceColorForIndex:")]
        CPTColor DefaultPieSliceColorForIndex(nuint pieSliceIndex);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTScatterPlotBinding  _Nonnull const CPTScatterPlotBindingXValues;
        [Field("CPTScatterPlotBindingXValues", "__Internal")]
        NSString CPTScatterPlotBindingXValues { get; }

        // extern CPTScatterPlotBinding  _Nonnull const CPTScatterPlotBindingYValues;
        [Field("CPTScatterPlotBindingYValues", "__Internal")]
        NSString CPTScatterPlotBindingYValues { get; }

        // extern CPTScatterPlotBinding  _Nonnull const CPTScatterPlotBindingPlotSymbols;
        [Field("CPTScatterPlotBindingPlotSymbols", "__Internal")]
        NSString CPTScatterPlotBindingPlotSymbols { get; }
    }

    // @protocol CPTScatterPlotDataSource <CPTPlotDataSource>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTScatterPlotDataSource : CPTPlotDataSource
    {
        // @optional -(CPTPlotSymbolArray * _Nullable)symbolsForScatterPlot:(CPTScatterPlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("symbolsForScatterPlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTPlotSymbol[] Symbols(CPTScatterPlot plot, NSRange indexRange);

        // @optional -(CPTPlotSymbol * _Nullable)symbolForScatterPlot:(CPTScatterPlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("symbolForScatterPlot:recordIndex:")]
        [return: NullAllowed]
        CPTPlotSymbol Symbols(CPTScatterPlot plot, nuint idx);
    }

    // @protocol CPTScatterPlotDelegate <CPTPlotDelegate>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
	interface CPTScatterPlotDelegate : CPTPlotDelegate
    {
        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("scatterPlot:plotSymbolWasSelectedAtRecordIndex:")]
        void PlotSymbolWasSelected (CPTScatterPlot plot, nuint idx);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:plotSymbolWasSelectedAtRecordIndex:withEvent:")]
        void PlotSymbolWasSelected (CPTScatterPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("scatterPlot:plotSymbolTouchDownAtRecordIndex:")]
        void PlotSymbolTouchDown (CPTScatterPlot plot, nuint idx);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:plotSymbolTouchDownAtRecordIndex:withEvent:")]
        void PlotSymbolTouchDown (CPTScatterPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("scatterPlot:plotSymbolTouchUpAtRecordIndex:")]
        void PlotSymbolTouchUp (CPTScatterPlot plot, nuint idx);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot plotSymbolTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:plotSymbolTouchUpAtRecordIndex:withEvent:")]
        void PlotSymbolTouchUp (CPTScatterPlot plot, nuint idx, UIEvent @event);

        // @optional -(void)scatterPlotDataLineWasSelected:(CPTScatterPlot * _Nonnull)plot;
        [Export("scatterPlotDataLineWasSelected:")]
        void ScatterPlotDataLineWasSelected(CPTScatterPlot plot);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot dataLineWasSelectedWithEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:dataLineWasSelectedWithEvent:")]
        void ScatterPlot(CPTScatterPlot plot, UIEvent @event);

        // @optional -(void)scatterPlotDataLineTouchDown:(CPTScatterPlot * _Nonnull)plot;
        [Export("scatterPlotDataLineTouchDown:")]
        void ScatterPlotDataLineTouchDown(CPTScatterPlot plot);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot dataLineTouchDownWithEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:dataLineTouchDownWithEvent:")]
        void DataLineTouchDownWithEvent(CPTScatterPlot plot, UIEvent @event);

        // @optional -(void)scatterPlotDataLineTouchUp:(CPTScatterPlot * _Nonnull)plot;
        [Export("scatterPlotDataLineTouchUp:")]
        void ScatterPlotDataLineTouchUp(CPTScatterPlot plot);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot dataLineTouchUpWithEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("scatterPlot:dataLineTouchUpWithEvent:")]
        void DataLineTouchUpWithEvent(CPTScatterPlot plot, UIEvent @event);

        // @optional -(void)scatterPlot:(CPTScatterPlot * _Nonnull)plot prepareForDrawingPlotLine:(CGPathRef _Nonnull)dataLinePath inContext:(CGContextRef _Nonnull)context;
        [Export("scatterPlot:prepareForDrawingPlotLine:inContext:")]
        unsafe void PrepareForDrawingPlotLine(CPTScatterPlot plot, CGPath dataLinePath, CGContext context);
    }

    // @interface CPTScatterPlot : CPTPlot
    [BaseType(typeof(CPTPlot))]
    interface CPTScatterPlot
    {
        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable areaBaseValue;
        [NullAllowed, Export("areaBaseValue", ArgumentSemantic.Strong)]
        NSNumber AreaBaseValue { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable areaBaseValue2;
        [NullAllowed, Export("areaBaseValue2", ArgumentSemantic.Strong)]
        NSNumber AreaBaseValue2 { get; set; }

        // @property (assign, readwrite, nonatomic) CPTScatterPlotInterpolation interpolation;
        [Export("interpolation", ArgumentSemantic.Assign)]
        CPTScatterPlotInterpolation Interpolation { get; set; }

        // @property (assign, readwrite, nonatomic) CPTScatterPlotHistogramOption histogramOption;
        [Export("histogramOption", ArgumentSemantic.Assign)]
        CPTScatterPlotHistogramOption HistogramOption { get; set; }

        // @property (assign, readwrite, nonatomic) CPTScatterPlotCurvedInterpolationOption curvedInterpolationOption;
        [Export("curvedInterpolationOption", ArgumentSemantic.Assign)]
        CPTScatterPlotCurvedInterpolationOption CurvedInterpolationOption { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat curvedInterpolationCustomAlpha;
        [Export("curvedInterpolationCustomAlpha")]
        nfloat CurvedInterpolationCustomAlpha { get; set; }

        // @property (readonly, nonatomic) CPTLimitBandArray * _Nullable areaFillBands;
        [NullAllowed, Export("areaFillBands")]
        CPTLimitBand[] AreaFillBands { get; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable dataLineStyle;
        [NullAllowed, Export("dataLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle DataLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotSymbol * _Nullable plotSymbol;
        [NullAllowed, Export("plotSymbol", ArgumentSemantic.Copy)]
        CPTPlotSymbol PlotSymbol { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable areaFill;
        [NullAllowed, Export("areaFill", ArgumentSemantic.Copy)]
        CPTFill AreaFill { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable areaFill2;
        [NullAllowed, Export("areaFill2", ArgumentSemantic.Copy)]
        CPTFill AreaFill2 { get; set; }

        // @property (readonly, nonatomic) CGPathRef _Nonnull newDataLinePath;
        [Export("newDataLinePath")]
        CGPath NewDataLinePath { get; }

        // @property (assign, readwrite, nonatomic) CGFloat plotSymbolMarginForHitDetection;
        [Export("plotSymbolMarginForHitDetection")]
        nfloat PlotSymbolMarginForHitDetection { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat plotLineMarginForHitDetection;
        [Export("plotLineMarginForHitDetection")]
        nfloat PlotLineMarginForHitDetection { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL allowSimultaneousSymbolAndPlotSelection;
        [Export("allowSimultaneousSymbolAndPlotSelection")]
        bool AllowSimultaneousSymbolAndPlotSelection { get; set; }

        // -(NSUInteger)indexOfVisiblePointClosestToPlotAreaPoint:(CGPoint)viewPoint;
        [Export("indexOfVisiblePointClosestToPlotAreaPoint:")]
        nuint IndexOfVisiblePointClosestToPlotAreaPoint(CGPoint viewPoint);

        // -(CGPoint)plotAreaPointOfVisiblePointAtIndex:(NSUInteger)idx;
        [Export("plotAreaPointOfVisiblePointAtIndex:")]
        CGPoint PlotAreaPointOfVisiblePointAtIndex(nuint idx);

        // -(CPTPlotSymbol * _Nullable)plotSymbolForRecordIndex:(NSUInteger)idx;
        [Export("plotSymbolForRecordIndex:")]
        [return: NullAllowed]
        CPTPlotSymbol PlotSymbolForRecordIndex(nuint idx);

        // -(void)reloadPlotSymbols;
        [Export("reloadPlotSymbols")]
        void ReloadPlotSymbols();

        // -(void)reloadPlotSymbolsInIndexRange:(NSRange)indexRange;
        [Export("reloadPlotSymbolsInIndexRange:")]
        void ReloadPlotSymbolsInIndexRange(NSRange indexRange);

        // -(void)addAreaFillBand:(CPTLimitBand * _Nullable)limitBand;
        [Export("addAreaFillBand:")]
        void AddAreaFillBand([NullAllowed] CPTLimitBand limitBand);

        // -(void)removeAreaFillBand:(CPTLimitBand * _Nullable)limitBand;
        [Export("removeAreaFillBand:")]
        void RemoveAreaFillBand([NullAllowed] CPTLimitBand limitBand);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat kCPTTextLayerMarginWidth;
        [Field("kCPTTextLayerMarginWidth", "__Internal")]
        nfloat kCPTTextLayerMarginWidth { get; }
    }

    // @interface CPTTextLayer : CPTBorderedLayer
    [BaseType(typeof(CPTBorderedLayer))]
    interface CPTTextLayer
    {
        // @property (readwrite, copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (readwrite, nonatomic, strong) CPTTextStyle * _Nullable textStyle;
        [NullAllowed, Export("textStyle", ArgumentSemantic.Strong)]
        CPTTextStyle TextStyle { get; set; }

        // @property (readwrite, copy, nonatomic) NSAttributedString * _Nullable attributedText;
        [NullAllowed, Export("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @property (readwrite, nonatomic) CGSize maximumSize;
        [Export("maximumSize", ArgumentSemantic.Assign)]
        CGSize MaximumSize { get; set; }

        // -(instancetype _Nonnull)initWithText:(NSString * _Nullable)newText;
        [Export("initWithText:")]
        IntPtr Constructor([NullAllowed] string newText);

        // -(instancetype _Nonnull)initWithText:(NSString * _Nullable)newText style:(CPTTextStyle * _Nullable)newStyle __attribute__((objc_designated_initializer));
        [Export("initWithText:style:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string newText, [NullAllowed] CPTTextStyle newStyle);

        // -(instancetype _Nonnull)initWithAttributedText:(NSAttributedString * _Nullable)newText;
        [Export("initWithAttributedText:")]
        IntPtr Constructor([NullAllowed] NSAttributedString newText);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject layer);

        // -(CGSize)sizeThatFits;
        [Export("sizeThatFits")]
        //[Verify(MethodToProperty)]
        CGSize SizeThatFits { get; }

        // -(void)sizeToFit;
        [Export("sizeToFit")]
        void SizeToFit();
    }

    // @interface CPTTimeFormatter
    [BaseType(typeof(NSNumberFormatter))]
    interface CPTTimeFormatter
    {
        // @property (readwrite, nonatomic, strong) int * _Nullable dateFormatter;
        [NullAllowed, Export("dateFormatter", ArgumentSemantic.Strong)]
        NSDateFormatter DateFormatter { get; set; }

        // @property (readwrite, copy, nonatomic) int * _Nullable referenceDate;
        [NullAllowed, Export("referenceDate", ArgumentSemantic.Copy)]
        NSDate ReferenceDate { get; set; }

        // -(instancetype _Nonnull)initWithDateFormatter:(id)aDateFormatter;
        [Export("initWithDateFormatter:")]
        IntPtr Constructor(NSObject aDateFormatter);

        // -(instancetype _Nullable)initWithCoder:(id)decoder;
        //[Export("initWithCoder:")]
        //IntPtr Constructor(NSObject decoder);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingXValues;
        [Field("CPTTradingRangePlotBindingXValues", "__Internal")]
        NSString CPTTradingRangePlotBindingXValues { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingOpenValues;
        [Field("CPTTradingRangePlotBindingOpenValues", "__Internal")]
        NSString CPTTradingRangePlotBindingOpenValues { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingHighValues;
        [Field("CPTTradingRangePlotBindingHighValues", "__Internal")]
        NSString CPTTradingRangePlotBindingHighValues { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingLowValues;
        [Field("CPTTradingRangePlotBindingLowValues", "__Internal")]
        NSString CPTTradingRangePlotBindingLowValues { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingCloseValues;
        [Field("CPTTradingRangePlotBindingCloseValues", "__Internal")]
        NSString CPTTradingRangePlotBindingCloseValues { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingIncreaseFills;
        [Field("CPTTradingRangePlotBindingIncreaseFills", "__Internal")]
        NSString CPTTradingRangePlotBindingIncreaseFills { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingDecreaseFills;
        [Field("CPTTradingRangePlotBindingDecreaseFills", "__Internal")]
        NSString CPTTradingRangePlotBindingDecreaseFills { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingLineStyles;
        [Field("CPTTradingRangePlotBindingLineStyles", "__Internal")]
        NSString CPTTradingRangePlotBindingLineStyles { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingIncreaseLineStyles;
        [Field("CPTTradingRangePlotBindingIncreaseLineStyles", "__Internal")]
        NSString CPTTradingRangePlotBindingIncreaseLineStyles { get; }

        // extern CPTTradingRangePlotBinding  _Nonnull const CPTTradingRangePlotBindingDecreaseLineStyles;
        [Field("CPTTradingRangePlotBindingDecreaseLineStyles", "__Internal")]
        NSString CPTTradingRangePlotBindingDecreaseLineStyles { get; }
    }

    // @protocol CPTTradingRangePlotDataSource <CPTPlotDataSource>
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface CPTTradingRangePlotDataSource : CPTPlotDataSource
    {
        // @optional -(CPTFillArray * _Nullable)increaseFillsForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("increaseFillsForTradingRangePlot:recordIndexRange:")]
        [return: NullAllowed]
		CPTFill[] IncreaseFills(CPTTradingRangePlot plot, NSRange indexRange);

        // @optional -(CPTFill * _Nullable)increaseFillForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("increaseFillForTradingRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTFill IncreaseFill (CPTTradingRangePlot plot, nuint idx);

        // @optional -(CPTFillArray * _Nullable)decreaseFillsForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("decreaseFillsForTradingRangePlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTFill[] DecreaseFills (CPTTradingRangePlot plot, NSRange indexRange);

        // @optional -(CPTFill * _Nullable)decreaseFillForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("decreaseFillForTradingRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTFill DecreaseFill (CPTTradingRangePlot plot, nuint idx);

        // @optional -(CPTLineStyleArray * _Nullable)lineStylesForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("lineStylesForTradingRangePlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLineStyle[] LineStyles (CPTTradingRangePlot plot, NSRange indexRange);

        // @optional -(CPTLineStyle * _Nullable)lineStyleForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("lineStyleForTradingRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTLineStyle LineStyle (CPTTradingRangePlot plot, nuint idx);

        // @optional -(CPTLineStyleArray * _Nullable)increaseLineStylesForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("increaseLineStylesForTradingRangePlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLineStyle[] IncreaseLineStyles (CPTTradingRangePlot plot, NSRange indexRange);

        // @optional -(CPTLineStyle * _Nullable)increaseLineStyleForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("increaseLineStyleForTradingRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTLineStyle IncreaseLineStyle (CPTTradingRangePlot plot, nuint idx);

        // @optional -(CPTLineStyleArray * _Nullable)decreaseLineStylesForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndexRange:(NSRange)indexRange;
        [Export("decreaseLineStylesForTradingRangePlot:recordIndexRange:")]
        [return: NullAllowed]
        CPTLineStyle[] DecreaseLineStyles (CPTTradingRangePlot plot, NSRange indexRange);

        // @optional -(CPTLineStyle * _Nullable)decreaseLineStyleForTradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot recordIndex:(NSUInteger)idx;
        [Export("decreaseLineStyleForTradingRangePlot:recordIndex:")]
        [return: NullAllowed]
        CPTLineStyle DecreaseLineStyle (CPTTradingRangePlot plot, nuint idx);
    }

	// @protocol CPTTradingRangePlotDelegate <CPTPlotDelegate>
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface CPTTradingRangePlotDelegate : CPTPlotDelegate
    {
        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barWasSelectedAtRecordIndex:(NSUInteger)idx;
        [Export("tradingRangePlot:barWasSelectedAtRecordIndex:")]
        void BarWasSelected (CPTTradingRangePlot plot, nuint idx);

        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barWasSelectedAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("tradingRangePlot:barWasSelectedAtRecordIndex:withEvent:")]
        void BarWasSelected (CPTTradingRangePlot plot, nuint idx, UIEvent @event);

        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barTouchDownAtRecordIndex:(NSUInteger)idx;
        [Export("tradingRangePlot:barTouchDownAtRecordIndex:")]
        void BarTouchDown (CPTTradingRangePlot plot, nuint idx);

        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barTouchDownAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("tradingRangePlot:barTouchDownAtRecordIndex:withEvent:")]
        void BarTouchDown (CPTTradingRangePlot plot, nuint idx, UIEvent @event);

        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barTouchUpAtRecordIndex:(NSUInteger)idx;
        [Export("tradingRangePlot:barTouchUpAtRecordIndex:")]
        void BarTouchUp (CPTTradingRangePlot plot, nuint idx);

        // @optional -(void)tradingRangePlot:(CPTTradingRangePlot * _Nonnull)plot barTouchUpAtRecordIndex:(NSUInteger)idx withEvent:(CPTNativeEvent * _Nonnull)event;
        [Export("tradingRangePlot:barTouchUpAtRecordIndex:withEvent:")]
        void BarTouchUp (CPTTradingRangePlot plot, nuint idx, UIEvent @event);
    }

    // @interface CPTTradingRangePlot : CPTPlot
    [BaseType(typeof(CPTPlot))]
    interface CPTTradingRangePlot
    {
        // @property (assign, readwrite, nonatomic) CPTTradingRangePlotStyle plotStyle;
        [Export("plotStyle", ArgumentSemantic.Assign)]
        CPTTradingRangePlotStyle PlotStyle { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat barWidth;
        [Export("barWidth")]
        nfloat BarWidth { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat stickLength;
        [Export("stickLength")]
        nfloat StickLength { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat barCornerRadius;
        [Export("barCornerRadius")]
        nfloat BarCornerRadius { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL showBarBorder;
        [Export("showBarBorder")]
        bool ShowBarBorder { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable lineStyle;
        [NullAllowed, Export("lineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle LineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable increaseLineStyle;
        [NullAllowed, Export("increaseLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle IncreaseLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTLineStyle * _Nullable decreaseLineStyle;
        [NullAllowed, Export("decreaseLineStyle", ArgumentSemantic.Copy)]
        CPTLineStyle DecreaseLineStyle { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable increaseFill;
        [NullAllowed, Export("increaseFill", ArgumentSemantic.Copy)]
        CPTFill IncreaseFill { get; set; }

        // @property (readwrite, copy, nonatomic) CPTFill * _Nullable decreaseFill;
        [NullAllowed, Export("decreaseFill", ArgumentSemantic.Copy)]
        CPTFill DecreaseFill { get; set; }

        // -(void)reloadBarFills;
        [Export("reloadBarFills")]
        void ReloadBarFills();

        // -(void)reloadBarFillsInIndexRange:(NSRange)indexRange;
        [Export("reloadBarFillsInIndexRange:")]
        void ReloadBarFillsInIndexRange(NSRange indexRange);

        // -(void)reloadBarLineStyles;
        [Export("reloadBarLineStyles")]
        void ReloadBarLineStyles();

        // -(void)reloadBarLineStylesInIndexRange:(NSRange)indexRange;
        [Export("reloadBarLineStylesInIndexRange:")]
        void ReloadBarLineStylesInIndexRange(NSRange indexRange);
    }

    // @interface CPTXYAxis : CPTAxis
    [BaseType(typeof(CPTAxis))]
    interface CPTXYAxis
    {
        // @property (readwrite, nonatomic, strong) NSNumber * _Nullable orthogonalPosition;
        [NullAllowed, Export("orthogonalPosition", ArgumentSemantic.Strong)]
        NSNumber OrthogonalPosition { get; set; }

        // @property (readwrite, nonatomic, strong) CPTConstraints * _Nullable axisConstraints;
        [NullAllowed, Export("axisConstraints", ArgumentSemantic.Strong)]
        CPTConstraints AxisConstraints { get; set; }
    }

    // @interface CPTConstraints
    [BaseType(typeof(NSObject))]
    interface CPTConstraints
    {
        // +(instancetype _Nonnull)constraintWithLowerOffset:(id)newOffset;
        [Static]
        [Export("constraintWithLowerOffset:")]
		CPTConstraints FromLowerOffset(nfloat newOffset);

        // +(instancetype _Nonnull)constraintWithUpperOffset:(id)newOffset;
        [Static]
        [Export("constraintWithUpperOffset:")]
		CPTConstraints FromUpperOffset(nfloat newOffset);

        // +(instancetype _Nonnull)constraintWithRelativeOffset:(id)newOffset;
        [Static]
        [Export("constraintWithRelativeOffset:")]
		CPTConstraints FromRelativeOffset(nfloat newOffset);

        // -(instancetype _Nonnull)initWithLowerOffset:(id)newOffset;
        [Export("initWithLowerOffset:")]
		IntPtr Constructor(nfloat newOffset);

        // -(instancetype _Nonnull)initWithUpperOffset:(id)newOffset;
        //[Export("initWithUpperOffset:")]
        //IntPtr Constructor(NSObject newOffset);

        // -(instancetype _Nonnull)initWithRelativeOffset:(id)newOffset;
        //[Export("initWithRelativeOffset:")]
        //IntPtr Constructor(NSObject newOffset);
    }

    // @interface AbstractMethods (CPTConstraints)
    [Category]
    [BaseType(typeof(CPTConstraints))]
    interface CPTConstraints_AbstractMethods
    {
        // -(id)isEqualToConstraint:(CPTConstraints * _Nullable)otherConstraint;
        [Export("isEqualToConstraint:")]
        NSObject IsEqualToConstraint([NullAllowed] CPTConstraints otherConstraint);

        // -(id)positionForLowerBound:(id)lowerBound upperBound:(id)upperBound;
        [Export("positionForLowerBound:upperBound:")]
        NSObject PositionForLowerBound(NSObject lowerBound, NSObject upperBound);
    }

    // @interface CPTXYAxisSet : CPTAxisSet
    [BaseType(typeof(CPTAxisSet))]
    interface CPTXYAxisSet
    {
        // @property (readonly, nonatomic) CPTXYAxis * _Nullable xAxis;
        [NullAllowed, Export("xAxis")]
        CPTXYAxis XAxis { get; }

        // @property (readonly, nonatomic) CPTXYAxis * _Nullable yAxis;
        [NullAllowed, Export("yAxis")]
        CPTXYAxis YAxis { get; }
    }

    // @interface CPTXYPlotSpace : CPTPlotSpace <CPTAnimationDelegate>
    [BaseType(typeof(CPTPlotSpace))]
    interface CPTXYPlotSpace : ICPTAnimationDelegate
    {
        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nonnull xRange;
        [Export("xRange", ArgumentSemantic.Copy)]
        CPTPlotRange XRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nonnull yRange;
        [Export("yRange", ArgumentSemantic.Copy)]
        CPTPlotRange YRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable globalXRange;
        [NullAllowed, Export("globalXRange", ArgumentSemantic.Copy)]
        CPTPlotRange GlobalXRange { get; set; }

        // @property (readwrite, copy, nonatomic) CPTPlotRange * _Nullable globalYRange;
        [NullAllowed, Export("globalYRange", ArgumentSemantic.Copy)]
        CPTPlotRange GlobalYRange { get; set; }

        // @property (assign, readwrite, nonatomic) CPTScaleType xScaleType;
        [Export("xScaleType", ArgumentSemantic.Assign)]
        CPTScaleType XScaleType { get; set; }

        // @property (assign, readwrite, nonatomic) CPTScaleType yScaleType;
        [Export("yScaleType", ArgumentSemantic.Assign)]
        CPTScaleType YScaleType { get; set; }

        // @property (readwrite, nonatomic) BOOL allowsMomentum;
        [Export("allowsMomentum")]
        bool AllowsMomentum { get; set; }

        // @property (readwrite, nonatomic) BOOL allowsMomentumX;
        [Export("allowsMomentumX")]
        bool AllowsMomentumX { get; set; }

        // @property (readwrite, nonatomic) BOOL allowsMomentumY;
        [Export("allowsMomentumY")]
        bool AllowsMomentumY { get; set; }

        // @property (readwrite, nonatomic) CPTAnimationCurve momentumAnimationCurve;
        [Export("momentumAnimationCurve", ArgumentSemantic.Assign)]
        CPTAnimationCurve MomentumAnimationCurve { get; set; }

        // @property (readwrite, nonatomic) CPTAnimationCurve bounceAnimationCurve;
        [Export("bounceAnimationCurve", ArgumentSemantic.Assign)]
        CPTAnimationCurve BounceAnimationCurve { get; set; }

        // @property (readwrite, nonatomic) CGFloat momentumAcceleration;
        [Export("momentumAcceleration")]
        nfloat MomentumAcceleration { get; set; }

        // @property (readwrite, nonatomic) CGFloat bounceAcceleration;
        [Export("bounceAcceleration")]
        nfloat BounceAcceleration { get; set; }

        // @property (readwrite, nonatomic) CGFloat minimumDisplacementToDrag;
        [Export("minimumDisplacementToDrag")]
        nfloat MinimumDisplacementToDrag { get; set; }

        // -(void)cancelAnimations;
        [Export("cancelAnimations")]
        void CancelAnimations();
    }
}