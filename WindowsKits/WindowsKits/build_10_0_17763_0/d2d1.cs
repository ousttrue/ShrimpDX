
    using System;
    using System.Runtime.InteropServices;
    using System.Numerics;

    namespace WindowsKits.build_10_0_17763_0 {

public class IDWriteTextFormat : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IDWriteTextFormat>.Value;
}

public class IDWriteTextLayout : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IDWriteTextLayout>.Value;
}

public class IDWriteRenderingParams : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IDWriteRenderingParams>.Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_RUN{
}

public enum D2D1_INTERPOLATION_MODE_DEFINITION {
    NEAREST_NEIGHBOR = 0x00000000,
    LINEAR = 0x00000001,
    CUBIC = 0x00000002,
    MULTI_SAMPLE_LINEAR = 0x00000003,
    ANISOTROPIC = 0x00000004,
    HIGH_QUALITY_CUBIC = 0x00000005,
    FANT = 0x00000006,
    MIPMAP_LINEAR = 0x00000007,
}

public enum D2D1_GAMMA {
    _2_2 = 0x00000000,
    _1_0 = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_OPACITY_MASK_CONTENT {
    GRAPHICS = 0x00000000,
    TEXT_NATURAL = 0x00000001,
    TEXT_GDI_COMPATIBLE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_EXTEND_MODE {
    CLAMP = 0x00000000,
    WRAP = 0x00000001,
    MIRROR = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_ANTIALIAS_MODE {
    PER_PRIMITIVE = 0x00000000,
    ALIASED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_TEXT_ANTIALIAS_MODE {
    DEFAULT = 0x00000000,
    CLEARTYPE = 0x00000001,
    GRAYSCALE = 0x00000002,
    ALIASED = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_BITMAP_INTERPOLATION_MODE {
    NEAREST_NEIGHBOR = 0x00000000,
    LINEAR = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_DRAW_TEXT_OPTIONS {
    NO_SNAP = 0x00000001,
    CLIP = 0x00000002,
    ENABLE_COLOR_FONT = 0x00000004,
    DISABLE_COLOR_BITMAP_SNAPPING = 0x00000008,
    NONE = 0x00000000,
    FORCE_DWORD = -0x0000001,
}









[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_TAG{
    public UInt64 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_PROPERTIES{
    /// (D2D1_PIXEL_FORMAT)
    public D2D1_PIXEL_FORMAT pixelFormat;

    /// (FLOAT)
    public Single dpiX;

    /// (FLOAT)
    public Single dpiY;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_GRADIENT_STOP{
    /// (FLOAT)
    public Single position;

    /// (D2D1_COLOR_F)
    public Vector4 color;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BRUSH_PROPERTIES{
    /// (FLOAT)
    public Single opacity;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F transform;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_BRUSH_PROPERTIES{
    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeX;

    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeY;

    /// (D2D1_BITMAP_INTERPOLATION_MODE)
    public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F startPoint;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F endPoint;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F center;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F gradientOriginOffset;

    /// (FLOAT)
    public Single radiusX;

    /// (FLOAT)
    public Single radiusY;

}

public enum D2D1_ARC_SIZE {
    SMALL = 0x00000000,
    LARGE = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_CAP_STYLE {
    FLAT = 0x00000000,
    SQUARE = 0x00000001,
    ROUND = 0x00000002,
    TRIANGLE = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_DASH_STYLE {
    SOLID = 0x00000000,
    DASH = 0x00000001,
    DOT = 0x00000002,
    DASH_DOT = 0x00000003,
    DASH_DOT_DOT = 0x00000004,
    CUSTOM = 0x00000005,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_LINE_JOIN {
    MITER = 0x00000000,
    BEVEL = 0x00000001,
    ROUND = 0x00000002,
    MITER_OR_BEVEL = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_COMBINE_MODE {
    UNION = 0x00000000,
    INTERSECT = 0x00000001,
    XOR = 0x00000002,
    EXCLUDE = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_GEOMETRY_RELATION {
    UNKNOWN = 0x00000000,
    DISJOINT = 0x00000001,
    IS_CONTAINED = 0x00000002,
    CONTAINS = 0x00000003,
    OVERLAP = 0x00000004,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_GEOMETRY_SIMPLIFICATION_OPTION {
    CUBICS_AND_LINES = 0x00000000,
    LINES = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_FIGURE_BEGIN {
    FILLED = 0x00000000,
    HOLLOW = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_FIGURE_END {
    OPEN = 0x00000000,
    CLOSED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BEZIER_SEGMENT{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point1;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point2;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point3;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_TRIANGLE{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point1;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point2;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point3;

}

public enum D2D1_PATH_SEGMENT {
    NONE = 0x00000000,
    FORCE_UNSTROKED = 0x00000001,
    FORCE_ROUND_LINE_JOIN = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_SWEEP_DIRECTION {
    COUNTER_CLOCKWISE = 0x00000000,
    CLOCKWISE = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_FILL_MODE {
    ALTERNATE = 0x00000000,
    WINDING = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_ARC_SEGMENT{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point;

    /// (D2D1_SIZE_F)
    public D2D_SIZE_F size;

    /// (FLOAT)
    public Single rotationAngle;

    /// (D2D1_SWEEP_DIRECTION)
    public D2D1_SWEEP_DIRECTION sweepDirection;

    /// (D2D1_ARC_SIZE)
    public D2D1_ARC_SIZE arcSize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_QUADRATIC_BEZIER_SEGMENT{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point1;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point2;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_ELLIPSE{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point;

    /// (FLOAT)
    public Single radiusX;

    /// (FLOAT)
    public Single radiusY;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_ROUNDED_RECT{
    /// (D2D1_RECT_F)
    public D2D_RECT_F rect;

    /// (FLOAT)
    public Single radiusX;

    /// (FLOAT)
    public Single radiusY;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_STROKE_STYLE_PROPERTIES{
    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE startCap;

    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE endCap;

    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE dashCap;

    /// (D2D1_LINE_JOIN)
    public D2D1_LINE_JOIN lineJoin;

    /// (FLOAT)
    public Single miterLimit;

    /// (D2D1_DASH_STYLE)
    public D2D1_DASH_STYLE dashStyle;

    /// (FLOAT)
    public Single dashOffset;

}

public enum D2D1_LAYER_OPTIONS {
    NONE = 0x00000000,
    INITIALIZE_FOR_CLEARTYPE = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_LAYER_PARAMETERS{
    /// (D2D1_RECT_F)
    public D2D_RECT_F contentBounds;

    /// (*(ID2D1Geometry))
    public IntPtr geometricMask;

    /// (D2D1_ANTIALIAS_MODE)
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F maskTransform;

    /// (FLOAT)
    public Single opacity;

    /// (*(ID2D1Brush))
    public IntPtr opacityBrush;

    /// (D2D1_LAYER_OPTIONS)
    public D2D1_LAYER_OPTIONS layerOptions;

}

public enum D2D1_WINDOW_STATE {
    NONE = 0x00000000,
    OCCLUDED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_RENDER_TARGET_TYPE {
    DEFAULT = 0x00000000,
    SOFTWARE = 0x00000001,
    HARDWARE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_FEATURE_LEVEL {
    DEFAULT = 0x00000000,
    _9 = 0x00009100,
    _10 = 0x0000a000,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_RENDER_TARGET_USAGE {
    NONE = 0x00000000,
    FORCE_BITMAP_REMOTING = 0x00000001,
    GDI_COMPATIBLE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_PRESENT_OPTIONS {
    NONE = 0x00000000,
    RETAIN_CONTENTS = 0x00000001,
    IMMEDIATELY = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RENDER_TARGET_PROPERTIES{
    /// (D2D1_RENDER_TARGET_TYPE)
    public D2D1_RENDER_TARGET_TYPE type;

    /// (D2D1_PIXEL_FORMAT)
    public D2D1_PIXEL_FORMAT pixelFormat;

    /// (FLOAT)
    public Single dpiX;

    /// (FLOAT)
    public Single dpiY;

    /// (D2D1_RENDER_TARGET_USAGE)
    public D2D1_RENDER_TARGET_USAGE usage;

    /// (D2D1_FEATURE_LEVEL)
    public D2D1_FEATURE_LEVEL minLevel;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_HWND_RENDER_TARGET_PROPERTIES{
    /// (HWND)
    public IntPtr hwnd;

    /// (D2D1_SIZE_U)
    public D2D_SIZE_U pixelSize;

    /// (D2D1_PRESENT_OPTIONS)
    public D2D1_PRESENT_OPTIONS presentOptions;

}

public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS {
    NONE = 0x00000000,
    GDI_COMPATIBLE = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_DRAWING_STATE_DESCRIPTION{
    /// (D2D1_ANTIALIAS_MODE)
    public D2D1_ANTIALIAS_MODE antialiasMode;

    /// (D2D1_TEXT_ANTIALIAS_MODE)
    public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;

    /// (D2D1_TAG)
    public D2D1_TAG tag1;

    /// (D2D1_TAG)
    public D2D1_TAG tag2;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F transform;

}

public enum D2D1_DC_INITIALIZE_MODE {
    COPY = 0x00000000,
    CLEAR = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_DEBUG_LEVEL {
    NONE = 0x00000000,
    ERROR = 0x00000001,
    WARNING = 0x00000002,
    INFORMATION = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_FACTORY_TYPE {
    SINGLE_THREADED = 0x00000000,
    MULTI_THREADED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_FACTORY_OPTIONS{
    /// (D2D1_DEBUG_LEVEL)
    public D2D1_DEBUG_LEVEL debugLevel;

}

public class ID2D1Resource : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd90691-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1Resource>.Value;
    public void GetFactory(
        /// factory: (*(*(ID2D1Factory)))
        ref IntPtr factory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFactoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFactoryFunc));
        callback(Self, ref factory);
    }
    delegate void GetFactoryFunc(IntPtr self, ref IntPtr factory);
}

public class ID2D1Image: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("65019f75-8da2-497c-b32c-dfa34e48ede6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<ID2D1Image>.Value;
}

public class ID2D1Bitmap: ID2D1Image {

    static /*readonly*/ Guid s_uuid = new Guid("a2296057-ea42-4099-983b-539fb6505426");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 7;
    int VTableIndexBase => VTableIndexBase<ID2D1Bitmap>.Value;
    public D2D_SIZE_F GetSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_F GetSizeFunc(IntPtr self);
    public D2D_SIZE_U GetPixelSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPixelSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_U GetPixelSizeFunc(IntPtr self);
    public D2D1_PIXEL_FORMAT GetPixelFormat(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPixelFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelFormatFunc));
        return callback(Self);
    }
    delegate D2D1_PIXEL_FORMAT GetPixelFormatFunc(IntPtr self);
    public void GetDpi(
        /// dpiX: (*(FLOAT))
        ref Single dpiX
        /// dpiY: (*(FLOAT))
        , ref Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDpiFunc));
        callback(Self, ref dpiX, ref dpiY);
    }
    delegate void GetDpiFunc(IntPtr self, ref Single dpiX, ref Single dpiY);
    public HRESULT CopyFromBitmap(
        /// destPoint: (*(const D2D1_POINT_2U))
        ref D2D_POINT_2U destPoint
        /// bitmap: (*(ID2D1Bitmap))
        , IntPtr bitmap
        /// srcRect: (*(const D2D1_RECT_U))
        , ref D2D_RECT_U srcRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CopyFromBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromBitmapFunc));
        return callback(Self, ref destPoint, bitmap, ref srcRect);
    }
    delegate HRESULT CopyFromBitmapFunc(IntPtr self, ref D2D_POINT_2U destPoint, IntPtr bitmap, ref D2D_RECT_U srcRect);
    public HRESULT CopyFromRenderTarget(
        /// destPoint: (*(const D2D1_POINT_2U))
        ref D2D_POINT_2U destPoint
        /// renderTarget: (*(ID2D1RenderTarget))
        , IntPtr renderTarget
        /// srcRect: (*(const D2D1_RECT_U))
        , ref D2D_RECT_U srcRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CopyFromRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromRenderTargetFunc));
        return callback(Self, ref destPoint, renderTarget, ref srcRect);
    }
    delegate HRESULT CopyFromRenderTargetFunc(IntPtr self, ref D2D_POINT_2U destPoint, IntPtr renderTarget, ref D2D_RECT_U srcRect);
    public HRESULT CopyFromMemory(
        /// dstRect: (*(const D2D1_RECT_U))
        ref D2D_RECT_U dstRect
        /// srcData: (*(const void))
        , IntPtr srcData
        /// pitch: (UINT32)
        , UInt32 pitch
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CopyFromMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromMemoryFunc));
        return callback(Self, ref dstRect, srcData, pitch);
    }
    delegate HRESULT CopyFromMemoryFunc(IntPtr self, ref D2D_RECT_U dstRect, IntPtr srcData, UInt32 pitch);
}

public class ID2D1GradientStopCollection: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a7-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<ID2D1GradientStopCollection>.Value;
    public UInt32 GetGradientStopCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGradientStopCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetGradientStopCountFunc(IntPtr self);
    public void GetGradientStops(
        /// gradientStops: (*(D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP gradientStops
        /// gradientStopsCount: (UINT32)
        , UInt32 gradientStopsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetGradientStopsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopsFunc));
        callback(Self, ref gradientStops, gradientStopsCount);
    }
    delegate void GetGradientStopsFunc(IntPtr self, ref D2D1_GRADIENT_STOP gradientStops, UInt32 gradientStopsCount);
    public D2D1_GAMMA GetColorInterpolationGamma(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetColorInterpolationGammaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorInterpolationGammaFunc));
        return callback(Self);
    }
    delegate D2D1_GAMMA GetColorInterpolationGammaFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetExtendModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeFunc(IntPtr self);
}

public class ID2D1Brush: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a8-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<ID2D1Brush>.Value;
    public void SetOpacity(
        /// opacity: (FLOAT)
        Single opacity
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetOpacityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetOpacityFunc));
        callback(Self, opacity);
    }
    delegate void SetOpacityFunc(IntPtr self, Single opacity);
    public void SetTransform(
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void SetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
    public Single GetOpacity(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetOpacityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOpacityFunc));
        return callback(Self);
    }
    delegate Single GetOpacityFunc(IntPtr self);
    public void GetTransform(
        /// transform: (*(D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void GetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
}

public class ID2D1BitmapBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906aa-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 8;
    int VTableIndexBase => VTableIndexBase<ID2D1BitmapBrush>.Value;
    public void SetExtendModeX(
        /// extendModeX: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeXFunc));
        callback(Self, extendModeX);
    }
    delegate void SetExtendModeXFunc(IntPtr self, D2D1_EXTEND_MODE extendModeX);
    public void SetExtendModeY(
        /// extendModeY: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeYFunc));
        callback(Self, extendModeY);
    }
    delegate void SetExtendModeYFunc(IntPtr self, D2D1_EXTEND_MODE extendModeY);
    public void SetInterpolationMode(
        /// interpolationMode: (D2D1_BITMAP_INTERPOLATION_MODE)
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationModeFunc));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationModeFunc(IntPtr self, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
    public void SetBitmap(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBitmapFunc));
        callback(Self, bitmap);
    }
    delegate void SetBitmapFunc(IntPtr self, IntPtr bitmap);
    public D2D1_EXTEND_MODE GetExtendModeX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeXFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeXFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendModeY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeYFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeYFunc(IntPtr self);
    public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationModeFunc(IntPtr self);
    public void GetBitmap(
        /// bitmap: (*(*(ID2D1Bitmap)))
        ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBitmapFunc));
        callback(Self, ref bitmap);
    }
    delegate void GetBitmapFunc(IntPtr self, ref IntPtr bitmap);
}

public class ID2D1SolidColorBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a9-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1SolidColorBrush>.Value;
    public void SetColor(
        /// color: (*(const D2D1_COLOR_F))
        ref Vector4 color
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetColorFunc));
        callback(Self, ref color);
    }
    delegate void SetColorFunc(IntPtr self, ref Vector4 color);
    public Vector4 GetColor(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorFunc));
        return callback(Self);
    }
    delegate Vector4 GetColorFunc(IntPtr self);
}

public class ID2D1LinearGradientBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906ab-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1LinearGradientBrush>.Value;
    public void SetStartPoint(
        /// startPoint: (D2D1_POINT_2F)
        D2D_POINT_2F startPoint
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetStartPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStartPointFunc));
        callback(Self, startPoint);
    }
    delegate void SetStartPointFunc(IntPtr self, D2D_POINT_2F startPoint);
    public void SetEndPoint(
        /// endPoint: (D2D1_POINT_2F)
        D2D_POINT_2F endPoint
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetEndPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEndPointFunc));
        callback(Self, endPoint);
    }
    delegate void SetEndPointFunc(IntPtr self, D2D_POINT_2F endPoint);
    public D2D_POINT_2F GetStartPoint(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetStartPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStartPointFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetStartPointFunc(IntPtr self);
    public D2D_POINT_2F GetEndPoint(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetEndPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEndPointFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetEndPointFunc(IntPtr self);
    public void GetGradientStopCollection(
        /// gradientStopCollection: (*(*(ID2D1GradientStopCollection)))
        ref IntPtr gradientStopCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCollectionFunc));
        callback(Self, ref gradientStopCollection);
    }
    delegate void GetGradientStopCollectionFunc(IntPtr self, ref IntPtr gradientStopCollection);
}

public class ID2D1RadialGradientBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906ac-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 9;
    int VTableIndexBase => VTableIndexBase<ID2D1RadialGradientBrush>.Value;
    public void SetCenter(
        /// center: (D2D1_POINT_2F)
        D2D_POINT_2F center
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetCenterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCenterFunc));
        callback(Self, center);
    }
    delegate void SetCenterFunc(IntPtr self, D2D_POINT_2F center);
    public void SetGradientOriginOffset(
        /// gradientOriginOffset: (D2D1_POINT_2F)
        D2D_POINT_2F gradientOriginOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetGradientOriginOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGradientOriginOffsetFunc));
        callback(Self, gradientOriginOffset);
    }
    delegate void SetGradientOriginOffsetFunc(IntPtr self, D2D_POINT_2F gradientOriginOffset);
    public void SetRadiusX(
        /// radiusX: (FLOAT)
        Single radiusX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetRadiusXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRadiusXFunc));
        callback(Self, radiusX);
    }
    delegate void SetRadiusXFunc(IntPtr self, Single radiusX);
    public void SetRadiusY(
        /// radiusY: (FLOAT)
        Single radiusY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetRadiusYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRadiusYFunc));
        callback(Self, radiusY);
    }
    delegate void SetRadiusYFunc(IntPtr self, Single radiusY);
    public D2D_POINT_2F GetCenter(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetCenterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCenterFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetCenterFunc(IntPtr self);
    public D2D_POINT_2F GetGradientOriginOffset(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetGradientOriginOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientOriginOffsetFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetGradientOriginOffsetFunc(IntPtr self);
    public Single GetRadiusX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetRadiusXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRadiusXFunc));
        return callback(Self);
    }
    delegate Single GetRadiusXFunc(IntPtr self);
    public Single GetRadiusY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetRadiusYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRadiusYFunc));
        return callback(Self);
    }
    delegate Single GetRadiusYFunc(IntPtr self);
    public void GetGradientStopCollection(
        /// gradientStopCollection: (*(*(ID2D1GradientStopCollection)))
        ref IntPtr gradientStopCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCollectionFunc));
        callback(Self, ref gradientStopCollection);
    }
    delegate void GetGradientStopCollectionFunc(IntPtr self, ref IntPtr gradientStopCollection);
}

public class ID2D1StrokeStyle: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069d-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 9;
    int VTableIndexBase => VTableIndexBase<ID2D1StrokeStyle>.Value;
    public D2D1_CAP_STYLE GetStartCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetStartCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStartCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetStartCapFunc(IntPtr self);
    public D2D1_CAP_STYLE GetEndCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetEndCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEndCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetEndCapFunc(IntPtr self);
    public D2D1_CAP_STYLE GetDashCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetDashCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetDashCapFunc(IntPtr self);
    public Single GetMiterLimit(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetMiterLimitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMiterLimitFunc));
        return callback(Self);
    }
    delegate Single GetMiterLimitFunc(IntPtr self);
    public D2D1_LINE_JOIN GetLineJoin(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetLineJoinFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLineJoinFunc));
        return callback(Self);
    }
    delegate D2D1_LINE_JOIN GetLineJoinFunc(IntPtr self);
    public Single GetDashOffset(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetDashOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashOffsetFunc));
        return callback(Self);
    }
    delegate Single GetDashOffsetFunc(IntPtr self);
    public D2D1_DASH_STYLE GetDashStyle(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetDashStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashStyleFunc));
        return callback(Self);
    }
    delegate D2D1_DASH_STYLE GetDashStyleFunc(IntPtr self);
    public UInt32 GetDashesCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetDashesCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashesCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetDashesCountFunc(IntPtr self);
    public void GetDashes(
        /// dashes: (*(FLOAT))
        ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetDashesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashesFunc));
        callback(Self, ref dashes, dashesCount);
    }
    delegate void GetDashesFunc(IntPtr self, ref Single dashes, UInt32 dashesCount);
}

public class ID2D1Geometry: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a1-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 13;
    int VTableIndexBase => VTableIndexBase<ID2D1Geometry>.Value;
    public HRESULT GetBounds(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// bounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoundsFunc));
        return callback(Self, ref worldTransform, ref bounds);
    }
    delegate HRESULT GetBoundsFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, ref D2D_RECT_F bounds);
    public HRESULT GetWidenedBounds(
        /// strokeWidth: (FLOAT)
        Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// bounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetWidenedBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWidenedBoundsFunc));
        return callback(Self, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, ref bounds);
    }
    delegate HRESULT GetWidenedBoundsFunc(IntPtr self, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D_RECT_F bounds);
    public HRESULT StrokeContainsPoint(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// contains: (*(BOOL))
        , IntPtr contains
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (StrokeContainsPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StrokeContainsPointFunc));
        return callback(Self, point, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, contains);
    }
    delegate HRESULT StrokeContainsPointFunc(IntPtr self, D2D_POINT_2F point, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr contains);
    public HRESULT FillContainsPoint(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// contains: (*(BOOL))
        , IntPtr contains
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (FillContainsPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillContainsPointFunc));
        return callback(Self, point, ref worldTransform, flatteningTolerance, contains);
    }
    delegate HRESULT FillContainsPointFunc(IntPtr self, D2D_POINT_2F point, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr contains);
    public HRESULT CompareWithGeometry(
        /// inputGeometry: (*(ID2D1Geometry))
        IntPtr inputGeometry
        /// inputGeometryTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F inputGeometryTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// relation: (*(D2D1_GEOMETRY_RELATION))
        , ref D2D1_GEOMETRY_RELATION relation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CompareWithGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CompareWithGeometryFunc));
        return callback(Self, inputGeometry, ref inputGeometryTransform, flatteningTolerance, ref relation);
    }
    delegate HRESULT CompareWithGeometryFunc(IntPtr self, IntPtr inputGeometry, ref D2D_MATRIX_3X2_F inputGeometryTransform, Single flatteningTolerance, ref D2D1_GEOMETRY_RELATION relation);
    public HRESULT Simplify(
        /// simplificationOption: (D2D1_GEOMETRY_SIMPLIFICATION_OPTION)
        D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SimplifyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SimplifyFunc));
        return callback(Self, simplificationOption, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT SimplifyFunc(IntPtr self, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT Tessellate(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// tessellationSink: (*(ID2D1TessellationSink))
        , IntPtr tessellationSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (TessellateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TessellateFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, tessellationSink);
    }
    delegate HRESULT TessellateFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr tessellationSink);
    public HRESULT CombineWithGeometry(
        /// inputGeometry: (*(ID2D1Geometry))
        IntPtr inputGeometry
        /// combineMode: (D2D1_COMBINE_MODE)
        , D2D1_COMBINE_MODE combineMode
        /// inputGeometryTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F inputGeometryTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CombineWithGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CombineWithGeometryFunc));
        return callback(Self, inputGeometry, combineMode, ref inputGeometryTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT CombineWithGeometryFunc(IntPtr self, IntPtr inputGeometry, D2D1_COMBINE_MODE combineMode, ref D2D_MATRIX_3X2_F inputGeometryTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT Outline(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (OutlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OutlineFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT OutlineFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT ComputeArea(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// area: (*(FLOAT))
        , ref Single area
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (ComputeAreaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputeAreaFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, ref area);
    }
    delegate HRESULT ComputeAreaFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref Single area);
    public HRESULT ComputeLength(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// length: (*(FLOAT))
        , ref Single length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (ComputeLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputeLengthFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, ref length);
    }
    delegate HRESULT ComputeLengthFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref Single length);
    public HRESULT ComputePointAtLength(
        /// length: (FLOAT)
        Single length
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// point: (*(D2D1_POINT_2F))
        , ref D2D_POINT_2F point
        /// unitTangentVector: (*(D2D1_POINT_2F))
        , ref D2D_POINT_2F unitTangentVector
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (ComputePointAtLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputePointAtLengthFunc));
        return callback(Self, length, ref worldTransform, flatteningTolerance, ref point, ref unitTangentVector);
    }
    delegate HRESULT ComputePointAtLengthFunc(IntPtr self, Single length, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D_POINT_2F point, ref D2D_POINT_2F unitTangentVector);
    public HRESULT Widen(
        /// strokeWidth: (FLOAT)
        Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (WidenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WidenFunc));
        return callback(Self, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT WidenFunc(IntPtr self, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
}

public class ID2D1RectangleGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a2-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1RectangleGeometry>.Value;
    public void GetRect(
        /// rect: (*(D2D1_RECT_F))
        ref D2D_RECT_F rect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRectFunc));
        callback(Self, ref rect);
    }
    delegate void GetRectFunc(IntPtr self, ref D2D_RECT_F rect);
}

public class ID2D1RoundedRectangleGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a3-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1RoundedRectangleGeometry>.Value;
    public void GetRoundedRect(
        /// roundedRect: (*(D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetRoundedRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRoundedRectFunc));
        callback(Self, ref roundedRect);
    }
    delegate void GetRoundedRectFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRect);
}

public class ID2D1EllipseGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a4-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1EllipseGeometry>.Value;
    public void GetEllipse(
        /// ellipse: (*(D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetEllipseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEllipseFunc));
        callback(Self, ref ellipse);
    }
    delegate void GetEllipseFunc(IntPtr self, ref D2D1_ELLIPSE ellipse);
}

public class ID2D1GeometryGroup: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a6-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<ID2D1GeometryGroup>.Value;
    public D2D1_FILL_MODE GetFillMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFillModeFunc));
        return callback(Self);
    }
    delegate D2D1_FILL_MODE GetFillModeFunc(IntPtr self);
    public UInt32 GetSourceGeometryCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetSourceGeometryCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometryCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetSourceGeometryCountFunc(IntPtr self);
    public void GetSourceGeometries(
        /// geometries: (*(*(ID2D1Geometry)))
        ref IntPtr geometries
        /// geometriesCount: (UINT32)
        , UInt32 geometriesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSourceGeometriesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometriesFunc));
        callback(Self, ref geometries, geometriesCount);
    }
    delegate void GetSourceGeometriesFunc(IntPtr self, ref IntPtr geometries, UInt32 geometriesCount);
}

public class ID2D1TransformedGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906bb-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1TransformedGeometry>.Value;
    public void GetSourceGeometry(
        /// sourceGeometry: (*(*(ID2D1Geometry)))
        ref IntPtr sourceGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSourceGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometryFunc));
        callback(Self, ref sourceGeometry);
    }
    delegate void GetSourceGeometryFunc(IntPtr self, ref IntPtr sourceGeometry);
    public void GetTransform(
        /// transform: (*(D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void GetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
}

public class ID2D1SimplifiedGeometrySink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069e-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 7;
    int VTableIndexBase => VTableIndexBase<ID2D1SimplifiedGeometrySink>.Value;
    public void SetFillMode(
        /// fillMode: (D2D1_FILL_MODE)
        D2D1_FILL_MODE fillMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFillModeFunc));
        callback(Self, fillMode);
    }
    delegate void SetFillModeFunc(IntPtr self, D2D1_FILL_MODE fillMode);
    public void SetSegmentFlags(
        /// vertexFlags: (D2D1_PATH_SEGMENT)
        D2D1_PATH_SEGMENT vertexFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetSegmentFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSegmentFlagsFunc));
        callback(Self, vertexFlags);
    }
    delegate void SetSegmentFlagsFunc(IntPtr self, D2D1_PATH_SEGMENT vertexFlags);
    public void BeginFigure(
        /// startPoint: (D2D1_POINT_2F)
        D2D_POINT_2F startPoint
        /// figureBegin: (D2D1_FIGURE_BEGIN)
        , D2D1_FIGURE_BEGIN figureBegin
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (BeginFigureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginFigureFunc));
        callback(Self, startPoint, figureBegin);
    }
    delegate void BeginFigureFunc(IntPtr self, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
    public void AddLines(
        /// points: (*(const D2D1_POINT_2F))
        ref D2D_POINT_2F points
        /// pointsCount: (UINT32)
        , UInt32 pointsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (AddLinesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddLinesFunc));
        callback(Self, ref points, pointsCount);
    }
    delegate void AddLinesFunc(IntPtr self, ref D2D_POINT_2F points, UInt32 pointsCount);
    public void AddBeziers(
        /// beziers: (*(const D2D1_BEZIER_SEGMENT))
        ref D2D1_BEZIER_SEGMENT beziers
        /// beziersCount: (UINT32)
        , UInt32 beziersCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (AddBeziersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddBeziersFunc));
        callback(Self, ref beziers, beziersCount);
    }
    delegate void AddBeziersFunc(IntPtr self, ref D2D1_BEZIER_SEGMENT beziers, UInt32 beziersCount);
    public void EndFigure(
        /// figureEnd: (D2D1_FIGURE_END)
        D2D1_FIGURE_END figureEnd
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (EndFigureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndFigureFunc));
        callback(Self, figureEnd);
    }
    delegate void EndFigureFunc(IntPtr self, D2D1_FIGURE_END figureEnd);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}

public class ID2D1GeometrySink: ID2D1SimplifiedGeometrySink {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069f-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1GeometrySink>.Value;
    public void AddLine(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddLineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddLineFunc));
        callback(Self, point);
    }
    delegate void AddLineFunc(IntPtr self, D2D_POINT_2F point);
    public void AddBezier(
        /// bezier: (*(const D2D1_BEZIER_SEGMENT))
        ref D2D1_BEZIER_SEGMENT bezier
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (AddBezierFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddBezierFunc));
        callback(Self, ref bezier);
    }
    delegate void AddBezierFunc(IntPtr self, ref D2D1_BEZIER_SEGMENT bezier);
    public void AddQuadraticBezier(
        /// bezier: (*(const D2D1_QUADRATIC_BEZIER_SEGMENT))
        ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (AddQuadraticBezierFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddQuadraticBezierFunc));
        callback(Self, ref bezier);
    }
    delegate void AddQuadraticBezierFunc(IntPtr self, ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier);
    public void AddQuadraticBeziers(
        /// beziers: (*(const D2D1_QUADRATIC_BEZIER_SEGMENT))
        ref D2D1_QUADRATIC_BEZIER_SEGMENT beziers
        /// beziersCount: (UINT32)
        , UInt32 beziersCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (AddQuadraticBeziersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddQuadraticBeziersFunc));
        callback(Self, ref beziers, beziersCount);
    }
    delegate void AddQuadraticBeziersFunc(IntPtr self, ref D2D1_QUADRATIC_BEZIER_SEGMENT beziers, UInt32 beziersCount);
    public void AddArc(
        /// arc: (*(const D2D1_ARC_SEGMENT))
        ref D2D1_ARC_SEGMENT arc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (AddArcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddArcFunc));
        callback(Self, ref arc);
    }
    delegate void AddArcFunc(IntPtr self, ref D2D1_ARC_SEGMENT arc);
}

public class ID2D1TessellationSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd906c1-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1TessellationSink>.Value;
    public void AddTriangles(
        /// triangles: (*(const D2D1_TRIANGLE))
        ref D2D1_TRIANGLE triangles
        /// trianglesCount: (UINT32)
        , UInt32 trianglesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddTrianglesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddTrianglesFunc));
        callback(Self, ref triangles, trianglesCount);
    }
    delegate void AddTrianglesFunc(IntPtr self, ref D2D1_TRIANGLE triangles, UInt32 trianglesCount);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}

public class ID2D1PathGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a5-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<ID2D1PathGeometry>.Value;
    public HRESULT Open(
        /// geometrySink: (*(*(ID2D1GeometrySink)))
        ref IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
        return callback(Self, ref geometrySink);
    }
    delegate HRESULT OpenFunc(IntPtr self, ref IntPtr geometrySink);
    public HRESULT Stream(
        /// geometrySink: (*(ID2D1GeometrySink))
        IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, geometrySink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr geometrySink);
    public HRESULT GetSegmentCount(
        /// count: (*(UINT32))
        ref UInt32 count
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSegmentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSegmentCountFunc));
        return callback(Self, ref count);
    }
    delegate HRESULT GetSegmentCountFunc(IntPtr self, ref UInt32 count);
    public HRESULT GetFigureCount(
        /// count: (*(UINT32))
        ref UInt32 count
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFigureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFigureCountFunc));
        return callback(Self, ref count);
    }
    delegate HRESULT GetFigureCountFunc(IntPtr self, ref UInt32 count);
}

public class ID2D1Mesh: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906c2-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1Mesh>.Value;
    public HRESULT Open(
        /// tessellationSink: (*(*(ID2D1TessellationSink)))
        ref IntPtr tessellationSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
        return callback(Self, ref tessellationSink);
    }
    delegate HRESULT OpenFunc(IntPtr self, ref IntPtr tessellationSink);
}

public class ID2D1Layer: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069b-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1Layer>.Value;
    public D2D_SIZE_F GetSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_F GetSizeFunc(IntPtr self);
}

public class ID2D1DrawingStateBlock: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("28506e39-ebf6-46a1-bb47-fd85565ab957");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<ID2D1DrawingStateBlock>.Value;
    public void GetDescription(
        /// stateDescription: (*(D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void GetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    public void SetDescription(
        /// stateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void SetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    public void SetTextRenderingParams(
        /// textRenderingParams: (*(IDWriteRenderingParams))
        IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextRenderingParamsFunc));
        callback(Self, textRenderingParams);
    }
    delegate void SetTextRenderingParamsFunc(IntPtr self, IntPtr textRenderingParams);
    public void GetTextRenderingParams(
        /// textRenderingParams: (*(*(IDWriteRenderingParams)))
        ref IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextRenderingParamsFunc));
        callback(Self, ref textRenderingParams);
    }
    delegate void GetTextRenderingParamsFunc(IntPtr self, ref IntPtr textRenderingParams);
}

public class ID2D1RenderTarget: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90694-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 53;
    int VTableIndexBase => VTableIndexBase<ID2D1RenderTarget>.Value;
    public HRESULT CreateBitmap(
        /// size: (D2D1_SIZE_U)
        D2D_SIZE_U size
        /// srcData: (*(const void))
        , IntPtr srcData
        /// pitch: (UINT32)
        , UInt32 pitch
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES))
        , ref D2D1_BITMAP_PROPERTIES bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapFunc));
        return callback(Self, size, srcData, pitch, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateBitmapFunc(IntPtr self, D2D_SIZE_U size, IntPtr srcData, UInt32 pitch, ref D2D1_BITMAP_PROPERTIES bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateBitmapFromWicBitmap(
        /// wicBitmapSource: (*(IWICBitmapSource))
        IntPtr wicBitmapSource
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES))
        , ref D2D1_BITMAP_PROPERTIES bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateBitmapFromWicBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapFromWicBitmapFunc));
        return callback(Self, wicBitmapSource, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateBitmapFromWicBitmapFunc(IntPtr self, IntPtr wicBitmapSource, ref D2D1_BITMAP_PROPERTIES bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateSharedBitmap(
        /// riid: (&(const IID))
        ref Guid riid
        /// data: (*(void))
        , IntPtr data
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES))
        , ref D2D1_BITMAP_PROPERTIES bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateSharedBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSharedBitmapFunc));
        return callback(Self, ref riid, data, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateSharedBitmapFunc(IntPtr self, ref Guid riid, IntPtr data, ref D2D1_BITMAP_PROPERTIES bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateBitmapBrush(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
        /// bitmapBrushProperties: (*(const D2D1_BITMAP_BRUSH_PROPERTIES))
        , ref D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// bitmapBrush: (*(*(ID2D1BitmapBrush)))
        , ref IntPtr bitmapBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateBitmapBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapBrushFunc));
        return callback(Self, bitmap, ref bitmapBrushProperties, ref brushProperties, ref bitmapBrush);
    }
    delegate HRESULT CreateBitmapBrushFunc(IntPtr self, IntPtr bitmap, ref D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, ref IntPtr bitmapBrush);
    public HRESULT CreateSolidColorBrush(
        /// color: (*(const D2D1_COLOR_F))
        ref Vector4 color
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// solidColorBrush: (*(*(ID2D1SolidColorBrush)))
        , ref IntPtr solidColorBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateSolidColorBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSolidColorBrushFunc));
        return callback(Self, ref color, ref brushProperties, ref solidColorBrush);
    }
    delegate HRESULT CreateSolidColorBrushFunc(IntPtr self, ref Vector4 color, ref D2D1_BRUSH_PROPERTIES brushProperties, ref IntPtr solidColorBrush);
    public HRESULT CreateGradientStopCollection(
        /// gradientStops: (*(const D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP gradientStops
        /// gradientStopsCount: (UINT32)
        , UInt32 gradientStopsCount
        /// colorInterpolationGamma: (D2D1_GAMMA)
        , D2D1_GAMMA colorInterpolationGamma
        /// extendMode: (D2D1_EXTEND_MODE)
        , D2D1_EXTEND_MODE extendMode
        /// gradientStopCollection: (*(*(ID2D1GradientStopCollection)))
        , ref IntPtr gradientStopCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGradientStopCollectionFunc));
        return callback(Self, ref gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, ref gradientStopCollection);
    }
    delegate HRESULT CreateGradientStopCollectionFunc(IntPtr self, ref D2D1_GRADIENT_STOP gradientStops, UInt32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ref IntPtr gradientStopCollection);
    public HRESULT CreateLinearGradientBrush(
        /// linearGradientBrushProperties: (*(const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES))
        ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// gradientStopCollection: (*(ID2D1GradientStopCollection))
        , IntPtr gradientStopCollection
        /// linearGradientBrush: (*(*(ID2D1LinearGradientBrush)))
        , ref IntPtr linearGradientBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateLinearGradientBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateLinearGradientBrushFunc));
        return callback(Self, ref linearGradientBrushProperties, ref brushProperties, gradientStopCollection, ref linearGradientBrush);
    }
    delegate HRESULT CreateLinearGradientBrushFunc(IntPtr self, ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, IntPtr gradientStopCollection, ref IntPtr linearGradientBrush);
    public HRESULT CreateRadialGradientBrush(
        /// radialGradientBrushProperties: (*(const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES))
        ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// gradientStopCollection: (*(ID2D1GradientStopCollection))
        , IntPtr gradientStopCollection
        /// radialGradientBrush: (*(*(ID2D1RadialGradientBrush)))
        , ref IntPtr radialGradientBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreateRadialGradientBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRadialGradientBrushFunc));
        return callback(Self, ref radialGradientBrushProperties, ref brushProperties, gradientStopCollection, ref radialGradientBrush);
    }
    delegate HRESULT CreateRadialGradientBrushFunc(IntPtr self, ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, IntPtr gradientStopCollection, ref IntPtr radialGradientBrush);
    public HRESULT CreateCompatibleRenderTarget(
        /// desiredSize: (*(const D2D1_SIZE_F))
        ref D2D_SIZE_F desiredSize
        /// desiredPixelSize: (*(const D2D1_SIZE_U))
        , ref D2D_SIZE_U desiredPixelSize
        /// desiredFormat: (*(const D2D1_PIXEL_FORMAT))
        , ref D2D1_PIXEL_FORMAT desiredFormat
        /// options: (D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS)
        , D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options
        /// bitmapRenderTarget: (*(*(ID2D1BitmapRenderTarget)))
        , ref IntPtr bitmapRenderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateCompatibleRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCompatibleRenderTargetFunc));
        return callback(Self, ref desiredSize, ref desiredPixelSize, ref desiredFormat, options, ref bitmapRenderTarget);
    }
    delegate HRESULT CreateCompatibleRenderTargetFunc(IntPtr self, ref D2D_SIZE_F desiredSize, ref D2D_SIZE_U desiredPixelSize, ref D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ref IntPtr bitmapRenderTarget);
    public HRESULT CreateLayer(
        /// size: (*(const D2D1_SIZE_F))
        ref D2D_SIZE_F size
        /// layer: (*(*(ID2D1Layer)))
        , ref IntPtr layer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateLayerFunc));
        return callback(Self, ref size, ref layer);
    }
    delegate HRESULT CreateLayerFunc(IntPtr self, ref D2D_SIZE_F size, ref IntPtr layer);
    public HRESULT CreateMesh(
        /// mesh: (*(*(ID2D1Mesh)))
        ref IntPtr mesh
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateMeshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateMeshFunc));
        return callback(Self, ref mesh);
    }
    delegate HRESULT CreateMeshFunc(IntPtr self, ref IntPtr mesh);
    public void DrawLine(
        /// point0: (D2D1_POINT_2F)
        D2D_POINT_2F point0
        /// point1: (D2D1_POINT_2F)
        , D2D_POINT_2F point1
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (DrawLineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawLineFunc));
        callback(Self, point0, point1, brush, strokeWidth, strokeStyle);
    }
    delegate void DrawLineFunc(IntPtr self, D2D_POINT_2F point0, D2D_POINT_2F point1, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public void DrawRectangle(
        /// rect: (*(const D2D1_RECT_F))
        ref D2D_RECT_F rect
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (DrawRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawRectangleFunc));
        callback(Self, ref rect, brush, strokeWidth, strokeStyle);
    }
    delegate void DrawRectangleFunc(IntPtr self, ref D2D_RECT_F rect, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public void FillRectangle(
        /// rect: (*(const D2D1_RECT_F))
        ref D2D_RECT_F rect
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (FillRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillRectangleFunc));
        callback(Self, ref rect, brush);
    }
    delegate void FillRectangleFunc(IntPtr self, ref D2D_RECT_F rect, IntPtr brush);
    public void DrawRoundedRectangle(
        /// roundedRect: (*(const D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRect
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (DrawRoundedRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawRoundedRectangleFunc));
        callback(Self, ref roundedRect, brush, strokeWidth, strokeStyle);
    }
    delegate void DrawRoundedRectangleFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRect, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public void FillRoundedRectangle(
        /// roundedRect: (*(const D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRect
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (FillRoundedRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillRoundedRectangleFunc));
        callback(Self, ref roundedRect, brush);
    }
    delegate void FillRoundedRectangleFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRect, IntPtr brush);
    public void DrawEllipse(
        /// ellipse: (*(const D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (DrawEllipseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawEllipseFunc));
        callback(Self, ref ellipse, brush, strokeWidth, strokeStyle);
    }
    delegate void DrawEllipseFunc(IntPtr self, ref D2D1_ELLIPSE ellipse, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public void FillEllipse(
        /// ellipse: (*(const D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (FillEllipseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillEllipseFunc));
        callback(Self, ref ellipse, brush);
    }
    delegate void FillEllipseFunc(IntPtr self, ref D2D1_ELLIPSE ellipse, IntPtr brush);
    public void DrawGeometry(
        /// geometry: (*(ID2D1Geometry))
        IntPtr geometry
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (DrawGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGeometryFunc));
        callback(Self, geometry, brush, strokeWidth, strokeStyle);
    }
    delegate void DrawGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public void FillGeometry(
        /// geometry: (*(ID2D1Geometry))
        IntPtr geometry
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// opacityBrush: (*(ID2D1Brush))
        , IntPtr opacityBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (FillGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillGeometryFunc));
        callback(Self, geometry, brush, opacityBrush);
    }
    delegate void FillGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);
    public void FillMesh(
        /// mesh: (*(ID2D1Mesh))
        IntPtr mesh
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (FillMeshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillMeshFunc));
        callback(Self, mesh, brush);
    }
    delegate void FillMeshFunc(IntPtr self, IntPtr mesh, IntPtr brush);
    public void FillOpacityMask(
        /// opacityMask: (*(ID2D1Bitmap))
        IntPtr opacityMask
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// content: (D2D1_OPACITY_MASK_CONTENT)
        , D2D1_OPACITY_MASK_CONTENT content
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (FillOpacityMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillOpacityMaskFunc));
        callback(Self, opacityMask, brush, content, ref destinationRectangle, ref sourceRectangle);
    }
    delegate void FillOpacityMaskFunc(IntPtr self, IntPtr opacityMask, IntPtr brush, D2D1_OPACITY_MASK_CONTENT content, ref D2D_RECT_F destinationRectangle, ref D2D_RECT_F sourceRectangle);
    public void DrawBitmap(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// opacity: (FLOAT)
        , Single opacity
        /// interpolationMode: (D2D1_BITMAP_INTERPOLATION_MODE)
        , D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (DrawBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawBitmapFunc));
        callback(Self, bitmap, ref destinationRectangle, opacity, interpolationMode, ref sourceRectangle);
    }
    delegate void DrawBitmapFunc(IntPtr self, IntPtr bitmap, ref D2D_RECT_F destinationRectangle, Single opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, ref D2D_RECT_F sourceRectangle);
    public void DrawTextA(
        /// string: (*(const WCHAR))
        ref Char str
        /// stringLength: (UINT32)
        , UInt32 stringLength
        /// textFormat: (*(IDWriteTextFormat))
        , IntPtr textFormat
        /// layoutRect: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F layoutRect
        /// defaultFillBrush: (*(ID2D1Brush))
        , IntPtr defaultFillBrush
        /// options: (D2D1_DRAW_TEXT_OPTIONS)
        , D2D1_DRAW_TEXT_OPTIONS options
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (DrawTextAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawTextAFunc));
        callback(Self, ref str, stringLength, textFormat, ref layoutRect, defaultFillBrush, options, measuringMode);
    }
    delegate void DrawTextAFunc(IntPtr self, ref Char str, UInt32 stringLength, IntPtr textFormat, ref D2D_RECT_F layoutRect, IntPtr defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
    public void DrawTextLayout(
        /// origin: (D2D1_POINT_2F)
        D2D_POINT_2F origin
        /// textLayout: (*(IDWriteTextLayout))
        , IntPtr textLayout
        /// defaultFillBrush: (*(ID2D1Brush))
        , IntPtr defaultFillBrush
        /// options: (D2D1_DRAW_TEXT_OPTIONS)
        , D2D1_DRAW_TEXT_OPTIONS options
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (DrawTextLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawTextLayoutFunc));
        callback(Self, origin, textLayout, defaultFillBrush, options);
    }
    delegate void DrawTextLayoutFunc(IntPtr self, D2D_POINT_2F origin, IntPtr textLayout, IntPtr defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options);
    public void DrawGlyphRun(
        /// baselineOrigin: (D2D1_POINT_2F)
        D2D_POINT_2F baselineOrigin
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// foregroundBrush: (*(ID2D1Brush))
        , IntPtr foregroundBrush
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        callback(Self, baselineOrigin, ref glyphRun, foregroundBrush, measuringMode);
    }
    delegate void DrawGlyphRunFunc(IntPtr self, D2D_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, IntPtr foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    public void SetTransform(
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (SetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void SetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
    public void GetTransform(
        /// transform: (*(D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void GetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
    public void SetAntialiasMode(
        /// antialiasMode: (D2D1_ANTIALIAS_MODE)
        D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (SetAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetAntialiasModeFunc));
        callback(Self, antialiasMode);
    }
    delegate void SetAntialiasModeFunc(IntPtr self, D2D1_ANTIALIAS_MODE antialiasMode);
    public D2D1_ANTIALIAS_MODE GetAntialiasMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (GetAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAntialiasModeFunc));
        return callback(Self);
    }
    delegate D2D1_ANTIALIAS_MODE GetAntialiasModeFunc(IntPtr self);
    public void SetTextAntialiasMode(
        /// textAntialiasMode: (D2D1_TEXT_ANTIALIAS_MODE)
        D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (SetTextAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextAntialiasModeFunc));
        callback(Self, textAntialiasMode);
    }
    delegate void SetTextAntialiasModeFunc(IntPtr self, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
    public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (GetTextAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextAntialiasModeFunc));
        return callback(Self);
    }
    delegate D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasModeFunc(IntPtr self);
    public void SetTextRenderingParams(
        /// textRenderingParams: (*(IDWriteRenderingParams))
        IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (SetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextRenderingParamsFunc));
        callback(Self, textRenderingParams);
    }
    delegate void SetTextRenderingParamsFunc(IntPtr self, IntPtr textRenderingParams);
    public void GetTextRenderingParams(
        /// textRenderingParams: (*(*(IDWriteRenderingParams)))
        ref IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (GetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextRenderingParamsFunc));
        callback(Self, ref textRenderingParams);
    }
    delegate void GetTextRenderingParamsFunc(IntPtr self, ref IntPtr textRenderingParams);
    public void SetTags(
        /// tag1: (D2D1_TAG)
        D2D1_TAG tag1
        /// tag2: (D2D1_TAG)
        , D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (SetTagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTagsFunc));
        callback(Self, tag1, tag2);
    }
    delegate void SetTagsFunc(IntPtr self, D2D1_TAG tag1, D2D1_TAG tag2);
    public void GetTags(
        /// tag1: (*(D2D1_TAG))
        ref D2D1_TAG tag1
        /// tag2: (*(D2D1_TAG))
        , ref D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 35);
        var callback = (GetTagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTagsFunc));
        callback(Self, ref tag1, ref tag2);
    }
    delegate void GetTagsFunc(IntPtr self, ref D2D1_TAG tag1, ref D2D1_TAG tag2);
    public void PushLayer(
        /// layerParameters: (*(const D2D1_LAYER_PARAMETERS))
        ref D2D1_LAYER_PARAMETERS layerParameters
        /// layer: (*(ID2D1Layer))
        , IntPtr layer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 36);
        var callback = (PushLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushLayerFunc));
        callback(Self, ref layerParameters, layer);
    }
    delegate void PushLayerFunc(IntPtr self, ref D2D1_LAYER_PARAMETERS layerParameters, IntPtr layer);
    public void PopLayer(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 37);
        var callback = (PopLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopLayerFunc));
        callback(Self);
    }
    delegate void PopLayerFunc(IntPtr self);
    public HRESULT Flush(
        /// tag1: (*(D2D1_TAG))
        ref D2D1_TAG tag1
        /// tag2: (*(D2D1_TAG))
        , ref D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 38);
        var callback = (FlushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FlushFunc));
        return callback(Self, ref tag1, ref tag2);
    }
    delegate HRESULT FlushFunc(IntPtr self, ref D2D1_TAG tag1, ref D2D1_TAG tag2);
    public void SaveDrawingState(
        /// drawingStateBlock: (*(ID2D1DrawingStateBlock))
        IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 39);
        var callback = (SaveDrawingStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveDrawingStateFunc));
        callback(Self, drawingStateBlock);
    }
    delegate void SaveDrawingStateFunc(IntPtr self, IntPtr drawingStateBlock);
    public void RestoreDrawingState(
        /// drawingStateBlock: (*(ID2D1DrawingStateBlock))
        IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 40);
        var callback = (RestoreDrawingStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RestoreDrawingStateFunc));
        callback(Self, drawingStateBlock);
    }
    delegate void RestoreDrawingStateFunc(IntPtr self, IntPtr drawingStateBlock);
    public void PushAxisAlignedClip(
        /// clipRect: (*(const D2D1_RECT_F))
        ref D2D_RECT_F clipRect
        /// antialiasMode: (D2D1_ANTIALIAS_MODE)
        , D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 41);
        var callback = (PushAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushAxisAlignedClipFunc));
        callback(Self, ref clipRect, antialiasMode);
    }
    delegate void PushAxisAlignedClipFunc(IntPtr self, ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    public void PopAxisAlignedClip(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 42);
        var callback = (PopAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopAxisAlignedClipFunc));
        callback(Self);
    }
    delegate void PopAxisAlignedClipFunc(IntPtr self);
    public void Clear(
        /// clearColor: (*(const D2D1_COLOR_F))
        ref Vector4 clearColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 43);
        var callback = (ClearFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearFunc));
        callback(Self, ref clearColor);
    }
    delegate void ClearFunc(IntPtr self, ref Vector4 clearColor);
    public void BeginDraw(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 44);
        var callback = (BeginDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginDrawFunc));
        callback(Self);
    }
    delegate void BeginDrawFunc(IntPtr self);
    public HRESULT EndDraw(
        /// tag1: (*(D2D1_TAG))
        ref D2D1_TAG tag1
        /// tag2: (*(D2D1_TAG))
        , ref D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 45);
        var callback = (EndDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndDrawFunc));
        return callback(Self, ref tag1, ref tag2);
    }
    delegate HRESULT EndDrawFunc(IntPtr self, ref D2D1_TAG tag1, ref D2D1_TAG tag2);
    public D2D1_PIXEL_FORMAT GetPixelFormat(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 46);
        var callback = (GetPixelFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelFormatFunc));
        return callback(Self);
    }
    delegate D2D1_PIXEL_FORMAT GetPixelFormatFunc(IntPtr self);
    public void SetDpi(
        /// dpiX: (FLOAT)
        Single dpiX
        /// dpiY: (FLOAT)
        , Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 47);
        var callback = (SetDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDpiFunc));
        callback(Self, dpiX, dpiY);
    }
    delegate void SetDpiFunc(IntPtr self, Single dpiX, Single dpiY);
    public void GetDpi(
        /// dpiX: (*(FLOAT))
        ref Single dpiX
        /// dpiY: (*(FLOAT))
        , ref Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 48);
        var callback = (GetDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDpiFunc));
        callback(Self, ref dpiX, ref dpiY);
    }
    delegate void GetDpiFunc(IntPtr self, ref Single dpiX, ref Single dpiY);
    public D2D_SIZE_F GetSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 49);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_F GetSizeFunc(IntPtr self);
    public D2D_SIZE_U GetPixelSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 50);
        var callback = (GetPixelSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_U GetPixelSizeFunc(IntPtr self);
    public UInt32 GetMaximumBitmapSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 51);
        var callback = (GetMaximumBitmapSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumBitmapSizeFunc));
        return callback(Self);
    }
    delegate UInt32 GetMaximumBitmapSizeFunc(IntPtr self);
    public Int32 IsSupported(
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 52);
        var callback = (IsSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsSupportedFunc));
        return callback(Self, ref renderTargetProperties);
    }
    delegate Int32 IsSupportedFunc(IntPtr self, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties);
}

public class ID2D1BitmapRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90695-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1BitmapRenderTarget>.Value;
    public HRESULT GetBitmap(
        /// bitmap: (*(*(ID2D1Bitmap)))
        ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBitmapFunc));
        return callback(Self, ref bitmap);
    }
    delegate HRESULT GetBitmapFunc(IntPtr self, ref IntPtr bitmap);
}

public class ID2D1HwndRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90698-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<ID2D1HwndRenderTarget>.Value;
    public D2D1_WINDOW_STATE CheckWindowState(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CheckWindowStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckWindowStateFunc));
        return callback(Self);
    }
    delegate D2D1_WINDOW_STATE CheckWindowStateFunc(IntPtr self);
    public HRESULT Resize(
        /// pixelSize: (*(const D2D1_SIZE_U))
        ref D2D_SIZE_U pixelSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ResizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeFunc));
        return callback(Self, ref pixelSize);
    }
    delegate HRESULT ResizeFunc(IntPtr self, ref D2D_SIZE_U pixelSize);
    public IntPtr GetHwnd(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
        return callback(Self);
    }
    delegate IntPtr GetHwndFunc(IntPtr self);
}

public class ID2D1GdiInteropRenderTarget : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1GdiInteropRenderTarget>.Value;
    public HRESULT GetDC(
        /// mode: (D2D1_DC_INITIALIZE_MODE)
        D2D1_DC_INITIALIZE_MODE mode
        /// hdc: (*(HDC))
        , ref IntPtr hdc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
        return callback(Self, mode, ref hdc);
    }
    delegate HRESULT GetDCFunc(IntPtr self, D2D1_DC_INITIALIZE_MODE mode, ref IntPtr hdc);
    public HRESULT ReleaseDC(
        /// update: (*(const RECT))
        ref RECT update
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
        return callback(Self, ref update);
    }
    delegate HRESULT ReleaseDCFunc(IntPtr self, ref RECT update);
}

public class ID2D1DCRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("1c51bc64-de61-46fd-9899-63a5d8f03950");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1DCRenderTarget>.Value;
    public HRESULT BindDC(
        /// hDC: (const HDC)
        IntPtr hDC
        /// pSubRect: (*(const RECT))
        , ref RECT pSubRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (BindDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindDCFunc));
        return callback(Self, hDC, ref pSubRect);
    }
    delegate HRESULT BindDCFunc(IntPtr self, IntPtr hDC, ref RECT pSubRect);
}

public class ID2D1Factory : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("06152247-6f50-465a-9245-118bfd3b6007");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 14;
    int VTableIndexBase => VTableIndexBase<ID2D1Factory>.Value;
    public HRESULT ReloadSystemMetrics(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ReloadSystemMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReloadSystemMetricsFunc));
        return callback(Self);
    }
    delegate HRESULT ReloadSystemMetricsFunc(IntPtr self);
    public void GetDesktopDpi(
        /// dpiX: (*(FLOAT))
        ref Single dpiX
        /// dpiY: (*(FLOAT))
        , ref Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDesktopDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesktopDpiFunc));
        callback(Self, ref dpiX, ref dpiY);
    }
    delegate void GetDesktopDpiFunc(IntPtr self, ref Single dpiX, ref Single dpiY);
    public HRESULT CreateRectangleGeometry(
        /// rectangle: (*(const D2D1_RECT_F))
        ref D2D_RECT_F rectangle
        /// rectangleGeometry: (*(*(ID2D1RectangleGeometry)))
        , ref IntPtr rectangleGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateRectangleGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRectangleGeometryFunc));
        return callback(Self, ref rectangle, ref rectangleGeometry);
    }
    delegate HRESULT CreateRectangleGeometryFunc(IntPtr self, ref D2D_RECT_F rectangle, ref IntPtr rectangleGeometry);
    public HRESULT CreateRoundedRectangleGeometry(
        /// roundedRectangle: (*(const D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRectangle
        /// roundedRectangleGeometry: (*(*(ID2D1RoundedRectangleGeometry)))
        , ref IntPtr roundedRectangleGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateRoundedRectangleGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRoundedRectangleGeometryFunc));
        return callback(Self, ref roundedRectangle, ref roundedRectangleGeometry);
    }
    delegate HRESULT CreateRoundedRectangleGeometryFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRectangle, ref IntPtr roundedRectangleGeometry);
    public HRESULT CreateEllipseGeometry(
        /// ellipse: (*(const D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
        /// ellipseGeometry: (*(*(ID2D1EllipseGeometry)))
        , ref IntPtr ellipseGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateEllipseGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateEllipseGeometryFunc));
        return callback(Self, ref ellipse, ref ellipseGeometry);
    }
    delegate HRESULT CreateEllipseGeometryFunc(IntPtr self, ref D2D1_ELLIPSE ellipse, ref IntPtr ellipseGeometry);
    public HRESULT CreateGeometryGroup(
        /// fillMode: (D2D1_FILL_MODE)
        D2D1_FILL_MODE fillMode
        /// geometries: (*(*(ID2D1Geometry)))
        , ref IntPtr geometries
        /// geometriesCount: (UINT32)
        , UInt32 geometriesCount
        /// geometryGroup: (*(*(ID2D1GeometryGroup)))
        , ref IntPtr geometryGroup
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateGeometryGroupFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryGroupFunc));
        return callback(Self, fillMode, ref geometries, geometriesCount, ref geometryGroup);
    }
    delegate HRESULT CreateGeometryGroupFunc(IntPtr self, D2D1_FILL_MODE fillMode, ref IntPtr geometries, UInt32 geometriesCount, ref IntPtr geometryGroup);
    public HRESULT CreateTransformedGeometry(
        /// sourceGeometry: (*(ID2D1Geometry))
        IntPtr sourceGeometry
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F transform
        /// transformedGeometry: (*(*(ID2D1TransformedGeometry)))
        , ref IntPtr transformedGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateTransformedGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTransformedGeometryFunc));
        return callback(Self, sourceGeometry, ref transform, ref transformedGeometry);
    }
    delegate HRESULT CreateTransformedGeometryFunc(IntPtr self, IntPtr sourceGeometry, ref D2D_MATRIX_3X2_F transform, ref IntPtr transformedGeometry);
    public HRESULT CreatePathGeometry(
        /// pathGeometry: (*(*(ID2D1PathGeometry)))
        ref IntPtr pathGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreatePathGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePathGeometryFunc));
        return callback(Self, ref pathGeometry);
    }
    delegate HRESULT CreatePathGeometryFunc(IntPtr self, ref IntPtr pathGeometry);
    public HRESULT CreateStrokeStyle(
        /// strokeStyleProperties: (*(const D2D1_STROKE_STYLE_PROPERTIES))
        ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties
        /// dashes: (*(const FLOAT))
        , ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
        /// strokeStyle: (*(*(ID2D1StrokeStyle)))
        , ref IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateStrokeStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStrokeStyleFunc));
        return callback(Self, ref strokeStyleProperties, ref dashes, dashesCount, ref strokeStyle);
    }
    delegate HRESULT CreateStrokeStyleFunc(IntPtr self, ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, ref Single dashes, UInt32 dashesCount, ref IntPtr strokeStyle);
    public HRESULT CreateDrawingStateBlock(
        /// drawingStateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription
        /// textRenderingParams: (*(IDWriteRenderingParams))
        , IntPtr textRenderingParams
        /// drawingStateBlock: (*(*(ID2D1DrawingStateBlock)))
        , ref IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateDrawingStateBlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDrawingStateBlockFunc));
        return callback(Self, ref drawingStateDescription, textRenderingParams, ref drawingStateBlock);
    }
    delegate HRESULT CreateDrawingStateBlockFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription, IntPtr textRenderingParams, ref IntPtr drawingStateBlock);
    public HRESULT CreateWicBitmapRenderTarget(
        /// target: (*(IWICBitmap))
        IntPtr target
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        , ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// renderTarget: (*(*(ID2D1RenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateWicBitmapRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateWicBitmapRenderTargetFunc));
        return callback(Self, target, ref renderTargetProperties, ref renderTarget);
    }
    delegate HRESULT CreateWicBitmapRenderTargetFunc(IntPtr self, IntPtr target, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr renderTarget);
    public HRESULT CreateHwndRenderTarget(
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// hwndRenderTargetProperties: (*(const D2D1_HWND_RENDER_TARGET_PROPERTIES))
        , ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties
        /// hwndRenderTarget: (*(*(ID2D1HwndRenderTarget)))
        , ref IntPtr hwndRenderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (CreateHwndRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateHwndRenderTargetFunc));
        return callback(Self, ref renderTargetProperties, ref hwndRenderTargetProperties, ref hwndRenderTarget);
    }
    delegate HRESULT CreateHwndRenderTargetFunc(IntPtr self, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, ref IntPtr hwndRenderTarget);
    public HRESULT CreateDxgiSurfaceRenderTarget(
        /// dxgiSurface: (*(IDXGISurface))
        IntPtr dxgiSurface
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        , ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// renderTarget: (*(*(ID2D1RenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (CreateDxgiSurfaceRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDxgiSurfaceRenderTargetFunc));
        return callback(Self, dxgiSurface, ref renderTargetProperties, ref renderTarget);
    }
    delegate HRESULT CreateDxgiSurfaceRenderTargetFunc(IntPtr self, IntPtr dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr renderTarget);
    public HRESULT CreateDCRenderTarget(
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// dcRenderTarget: (*(*(ID2D1DCRenderTarget)))
        , ref IntPtr dcRenderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (CreateDCRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDCRenderTargetFunc));
        return callback(Self, ref renderTargetProperties, ref dcRenderTarget);
    }
    delegate HRESULT CreateDCRenderTargetFunc(IntPtr self, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr dcRenderTarget);
}

public static class d2d1{
public const int D2D1_DEFAULT_FLATTENING_TOLERANCE = unchecked((int)( 0.25f ));
[DllImport("D2D1.dll")]
public static extern HRESULT D2D1CreateFactory(
    /// factoryType: (D2D1_FACTORY_TYPE)
    D2D1_FACTORY_TYPE factoryType
    /// riid: (&(const IID))
    , ref Guid riid
    /// pFactoryOptions: (*(const D2D1_FACTORY_OPTIONS))
    , ref D2D1_FACTORY_OPTIONS pFactoryOptions
    /// ppIFactory: (*(*(void)))
    , ref IntPtr ppIFactory
);

[DllImport("D2D1.dll")]
public static extern void D2D1MakeRotateMatrix(
    /// angle: (FLOAT)
    Single angle
    /// center: (D2D1_POINT_2F)
    , D2D_POINT_2F center
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    , ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll")]
public static extern void D2D1MakeSkewMatrix(
    /// angleX: (FLOAT)
    Single angleX
    /// angleY: (FLOAT)
    , Single angleY
    /// center: (D2D1_POINT_2F)
    , D2D_POINT_2F center
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    , ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll")]
public static extern Int32 D2D1IsMatrixInvertible(
    /// matrix: (*(const D2D1_MATRIX_3X2_F))
    ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll")]
public static extern Int32 D2D1InvertMatrix(
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    ref D2D_MATRIX_3X2_F matrix
);

}
}
