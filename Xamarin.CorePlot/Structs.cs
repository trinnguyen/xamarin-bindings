using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace CorePlot
{
    [Native]
    public enum CPTAnimationCurve : long
    {
        Default,
        Linear,
        BackIn,
        BackOut,
        BackInOut,
        BounceIn,
        BounceOut,
        BounceInOut,
        CircularIn,
        CircularOut,
        CircularInOut,
        ElasticIn,
        ElasticOut,
        ElasticInOut,
        ExponentialIn,
        ExponentialOut,
        ExponentialInOut,
        SinusoidalIn,
        SinusoidalOut,
        SinusoidalInOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuadraticIn,
        QuadraticOut,
        QuadraticInOut,
        QuarticIn,
        QuarticOut,
        QuarticInOut,
        QuinticIn,
        QuinticOut,
        QuinticInOut
    }

    [Native]
    public enum CPTTextAlignment : long
    {
        Left = UITextAlignment.Left,
        Center = UITextAlignment.Center,
        Right = UITextAlignment.Right,
        Justified = UITextAlignment.Justified,
        Natural = UITextAlignment.Natural
    }

    [Native]
    public enum CPTAxisLabelingPolicy : long
    {
        None,
        LocationsProvided,
        FixedInterval,
        Automatic,
        EqualDivisions
    }

    [Native]
    public enum CPTGraphLayerType : long
    {
        MinorGridLines,
        MajorGridLines,
        AxisLines,
        Plots,
        AxisLabels,
        AxisTitles
    }

    [Native]
    public enum CPTPlotSymbolType : long
    {
        None,
        Rectangle,
        Ellipse,
        Diamond,
        Triangle,
        Star,
        Pentagon,
        Hexagon,
        Cross,
        Plus,
        Dash,
        Snow,
        Custom
    }

    [Native]
    public enum CPTNumericType  : long
    {
        Integer,
        Float,
        Double
    }

    [Native]
    public enum CPTErrorBarType  : long
    {
        ustom,
        onstantRatio,
        onstantValue
    }

    [Native]
    public enum CPTScaleType  : long
    {
        Linear,
        Log,
        Angular,
        DateTime,
        Category,
        LogModulus
    }

    [Native]
    public enum CPTCoordinate  : long
    {
        X = 0,
        Y = 1,
        Z = 2,
        None = 9223372036854775807L
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CPTRGBAColor
    {
        public nfloat red;

        public nfloat green;

        public nfloat blue;

        public nfloat alpha;
    }

    [Native]
    public enum CPTSign  : long
    {
        None = 0,
        Positive = +1,
        Negative = -1
    }

    [Native]
    public enum CPTRectAnchor  : long
    {
        BottomLeft,
        Bottom,
        BottomRight,
        Left,
        Right,
        TopLeft,
        Top,
        TopRight,
        Center
    }

    [Native]
    public enum CPTAlignment  : long
    {
        Left,
        Center,
        Right,
        Top,
        Middle,
        Bottom
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CPTEdgeInsets
    {
        public nfloat top;

        public nfloat left;

        public nfloat bottom;

        public nfloat right;
    }

    [Native]
    public enum CPTPlotRangeComparisonResult : long
    {
        BelowRange,
        InRange,
        AboveRange
    }

    [Native]
    public enum CPTDataTypeFormat : long
    {
        UndefinedDataType = 0,
        IntegerDataType,
        UnsignedIntegerDataType,
        FloatingPointDataType,
        ComplexFloatingPointDataType,
        DecimalDataType
    }

    [Native]
    public enum CPTDataOrder : long
    {
        RowsFirst,
        ColumnsFirst
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CPTNumericDataType
    {
        public CPTDataTypeFormat dataTypeFormat;

        public nuint sampleBytes;

        public nint byteOrder;
    }

    static class CFunctions
    {
        // extern CPTNumericDataType CPTDataType (CPTDataTypeFormat format, size_t sampleBytes, CFByteOrder byteOrder);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern CPTNumericDataType CPTDataType (CPTDataTypeFormat format, nuint sampleBytes, nint byteOrder);

        // extern CPTNumericDataType CPTDataTypeWithDataTypeString (NSString * _Nonnull dataTypeString);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern CPTNumericDataType CPTDataTypeWithDataTypeString (NSString dataTypeString);

        // extern NSString * _Nonnull CPTDataTypeStringFromDataType (CPTNumericDataType dataType);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern NSString CPTDataTypeStringFromDataType (CPTNumericDataType dataType);

        // extern BOOL CPTDataTypeIsSupported (CPTNumericDataType format);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern bool CPTDataTypeIsSupported (CPTNumericDataType format);

        // extern BOOL CPTDataTypeEqualToDataType (CPTNumericDataType dataType1, CPTNumericDataType dataType2);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern bool CPTDataTypeEqualToDataType (CPTNumericDataType dataType1, CPTNumericDataType dataType2);
    }

    [Native]
    public enum CPTPlotCachePrecision : long
    {
        Auto,
        Double,
        Decimal
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CPTGradientElement
    {
        public CPTRGBAColor color;

        public nfloat position;

        public IntPtr NextElement;
    }

    [Native]
    public enum CPTGradientBlendingMode : long
    {
        LinearBlendingMode,
        ChromaticBlendingMode,
        InverseChromaticBlendingMode
    }

    [Native]
    public enum CPTGradientType : long
    {
        Axial,
        Radial
    }

    [Native]
    public enum CPTLegendSwatchLayout : long
    {
        Left,
        Right
    }

    [Native]
    public enum CPTPieChartField : long
    {
        CPTPieChartFieldSliceWidth,
        Normalized,
        Sum
    }

    [Native]
    public enum CPTPieDirection : long
    {
        Clockwise,
        CounterClockwise
    }

    [Native]
    public enum CPTScatterPlotField : long
    {
        X,
        Y
    }

    [Native]
    public enum CPTScatterPlotInterpolation : long
    {
        Linear,
        Stepped,
        Histogram,
        Curved
    }

    [Native]
    public enum CPTScatterPlotCurvedInterpolationOption : long
    {
        Normal,
        CatmullRomUniform,
        CatmullRomCentripetal,
        CatmullRomChordal,
        CatmullCustomAlpha,
        HermiteCubic
    }

    [Native]
    public enum CPTScatterPlotHistogramOption : long
    {
        Normal,
        SkipFirst,
        SkipSecond,
        OptionCount
    }

    [Native]
    public enum CPTTradingRangePlotStyle : long
    {
        Ohlc,
        CandleStick
    }

    [Native]
    public enum CPTTradingRangePlotField : long
    {
        X,
        Open,
        High,
        Low,
        Close
    }

	[Native]
	public enum CPTBarPlotField : long
    {
        Location,
        Tip,
        Base
    }
}
