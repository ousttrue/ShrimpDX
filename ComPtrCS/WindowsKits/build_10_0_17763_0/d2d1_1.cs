
    using System;
    using System.Runtime.InteropServices;
    using System.Numerics;

    namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class IWICColorContext : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IWICColorContext>.Value;
}

public class IWICImagingFactory : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IWICImagingFactory>.Value;
}

public class IPrintDocumentPackageTarget : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IPrintDocumentPackageTarget>.Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_PROPERTY_BINDING{
}



public enum D2D1_PROPERTY_TYPE {
    UNKNOWN = 0x00000000,
    STRING = 0x00000001,
    BOOL = 0x00000002,
    UINT32 = 0x00000003,
    INT32 = 0x00000004,
    FLOAT = 0x00000005,
    VECTOR2 = 0x00000006,
    VECTOR3 = 0x00000007,
    VECTOR4 = 0x00000008,
    BLOB = 0x00000009,
    IUNKNOWN = 0x0000000a,
    ENUM = 0x0000000b,
    ARRAY = 0x0000000c,
    CLSID = 0x0000000d,
    MATRIX_3X2 = 0x0000000e,
    MATRIX_4X3 = 0x0000000f,
    MATRIX_4X4 = 0x00000010,
    MATRIX_5X4 = 0x00000011,
    COLOR_CONTEXT = 0x00000012,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_PROPERTY {
    CLSID = -0x80000000,
    DISPLAYNAME = -0x7fffffff,
    AUTHOR = -0x7ffffffe,
    CATEGORY = -0x7ffffffd,
    DESCRIPTION = -0x7ffffffc,
    INPUTS = -0x7ffffffb,
    CACHED = -0x7ffffffa,
    PRECISION = -0x7ffffff9,
    MIN_INPUTS = -0x7ffffff8,
    MAX_INPUTS = -0x7ffffff7,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_SUBPROPERTY {
    DISPLAYNAME = -0x80000000,
    ISREADONLY = -0x7fffffff,
    MIN = -0x7ffffffe,
    MAX = -0x7ffffffd,
    DEFAULT = -0x7ffffffc,
    FIELDS = -0x7ffffffb,
    INDEX = -0x7ffffffa,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_BITMAP_OPTIONS {
    NONE = 0x00000000,
    TARGET = 0x00000001,
    CANNOT_DRAW = 0x00000002,
    CPU_READ = 0x00000004,
    GDI_COMPATIBLE = 0x00000008,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_COMPOSITE_MODE {
    SOURCE_OVER = 0x00000000,
    DESTINATION_OVER = 0x00000001,
    SOURCE_IN = 0x00000002,
    DESTINATION_IN = 0x00000003,
    SOURCE_OUT = 0x00000004,
    DESTINATION_OUT = 0x00000005,
    SOURCE_ATOP = 0x00000006,
    DESTINATION_ATOP = 0x00000007,
    XOR = 0x00000008,
    PLUS = 0x00000009,
    SOURCE_COPY = 0x0000000a,
    BOUNDED_SOURCE_COPY = 0x0000000b,
    MASK_INVERT = 0x0000000c,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_BUFFER_PRECISION {
    UNKNOWN = 0x00000000,
    _8BPC_UNORM = 0x00000001,
    _8BPC_UNORM_SRGB = 0x00000002,
    _16BPC_UNORM = 0x00000003,
    _16BPC_FLOAT = 0x00000004,
    _32BPC_FLOAT = 0x00000005,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_MAP_OPTIONS {
    NONE = 0x00000000,
    READ = 0x00000001,
    WRITE = 0x00000002,
    DISCARD = 0x00000004,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_INTERPOLATION_MODE {
    NEAREST_NEIGHBOR = 0x00000000,
    LINEAR = 0x00000001,
    CUBIC = 0x00000002,
    MULTI_SAMPLE_LINEAR = 0x00000003,
    ANISOTROPIC = 0x00000004,
    HIGH_QUALITY_CUBIC = 0x00000005,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_UNIT_MODE {
    DIPS = 0x00000000,
    PIXELS = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_COLOR_SPACE {
    CUSTOM = 0x00000000,
    SRGB = 0x00000001,
    SCRGB = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_DEVICE_CONTEXT_OPTIONS {
    NONE = 0x00000000,
    ENABLE_MULTITHREADED_OPTIMIZATIONS = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_STROKE_TRANSFORM_TYPE {
    NORMAL = 0x00000000,
    FIXED = 0x00000001,
    HAIRLINE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_PRIMITIVE_BLEND {
    SOURCE_OVER = 0x00000000,
    COPY = 0x00000001,
    MIN = 0x00000002,
    ADD = 0x00000003,
    MAX = 0x00000004,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_THREADING_MODE {
    SINGLE_THREADED = 0x00000000,
    MULTI_THREADED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}

public enum D2D1_COLOR_INTERPOLATION_MODE {
    STRAIGHT = 0x00000000,
    PREMULTIPLIED = 0x00000001,
    FORCE_DWORD = -0x0000001,
}




[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_PROPERTIES1{
    /// (D2D1_PIXEL_FORMAT)
    public D2D1_PIXEL_FORMAT pixelFormat;

    /// (FLOAT)
    public Single dpiX;

    /// (FLOAT)
    public Single dpiY;

    /// (D2D1_BITMAP_OPTIONS)
    public D2D1_BITMAP_OPTIONS bitmapOptions;

    /// (*(ID2D1ColorContext))
    public IntPtr colorContext;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_MAPPED_RECT{
    /// (UINT32)
    public UInt32 pitch;

    /// (*(BYTE))
    public IntPtr bits;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RENDERING_CONTROLS{
    /// (D2D1_BUFFER_PRECISION)
    public D2D1_BUFFER_PRECISION bufferPrecision;

    /// (D2D1_SIZE_U)
    public D2D_SIZE_U tileSize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_EFFECT_INPUT_DESCRIPTION{
    /// (*(ID2D1Effect))
    public IntPtr effect;

    /// (UINT32)
    public UInt32 inputIndex;

    /// (D2D1_RECT_F)
    public D2D_RECT_F inputRectangle;

}




[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_POINT_DESCRIPTION{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F unitTangentVector;

    /// (UINT32)
    public UInt32 endSegment;

    /// (UINT32)
    public UInt32 endFigure;

    /// (FLOAT)
    public Single lengthToEndSegment;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_IMAGE_BRUSH_PROPERTIES{
    /// (D2D1_RECT_F)
    public D2D_RECT_F sourceRectangle;

    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeX;

    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeY;

    /// (D2D1_INTERPOLATION_MODE)
    public D2D1_INTERPOLATION_MODE interpolationMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_BRUSH_PROPERTIES1{
    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeX;

    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeY;

    /// (D2D1_INTERPOLATION_MODE)
    public D2D1_INTERPOLATION_MODE interpolationMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_STROKE_STYLE_PROPERTIES1{
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

    /// (D2D1_STROKE_TRANSFORM_TYPE)
    public D2D1_STROKE_TRANSFORM_TYPE transformType;

}

public enum D2D1_LAYER_OPTIONS1 {
    NONE = 0x00000000,
    INITIALIZE_FROM_BACKGROUND = 0x00000001,
    IGNORE_ALPHA = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_LAYER_PARAMETERS1{
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

    /// (D2D1_LAYER_OPTIONS1)
    public D2D1_LAYER_OPTIONS1 layerOptions;

}

public enum D2D1_PRINT_FONT_SUBSET_MODE {
    DEFAULT = 0x00000000,
    EACHPAGE = 0x00000001,
    NONE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_DRAWING_STATE_DESCRIPTION1{
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

    /// (D2D1_PRIMITIVE_BLEND)
    public D2D1_PRIMITIVE_BLEND primitiveBlend;

    /// (D2D1_UNIT_MODE)
    public D2D1_UNIT_MODE unitMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_PRINT_CONTROL_PROPERTIES{
    /// (D2D1_PRINT_FONT_SUBSET_MODE)
    public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;

    /// (FLOAT)
    public Single rasterDPI;

    /// (D2D1_COLOR_SPACE)
    public D2D1_COLOR_SPACE colorSpace;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_CREATION_PROPERTIES{
    /// (D2D1_THREADING_MODE)
    public D2D1_THREADING_MODE threadingMode;

    /// (D2D1_DEBUG_LEVEL)
    public D2D1_DEBUG_LEVEL debugLevel;

    /// (D2D1_DEVICE_CONTEXT_OPTIONS)
    public D2D1_DEVICE_CONTEXT_OPTIONS options;

}

public class ID2D1GdiMetafileSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("82237326-8111-4f7c-bcf4-b5c1175564fe");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1GdiMetafileSink>.Value;
    public HRESULT ProcessRecord(
        /// recordType: (DWORD)
        UInt32 recordType
        /// recordData: (*(const void))
        , IntPtr recordData
        /// recordDataSize: (DWORD)
        , UInt32 recordDataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ProcessRecordFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessRecordFunc));
        return callback(Self, recordType, recordData, recordDataSize);
    }
    delegate HRESULT ProcessRecordFunc(IntPtr self, UInt32 recordType, IntPtr recordData, UInt32 recordDataSize);
}

public class ID2D1GdiMetafile: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1GdiMetafile>.Value;
    public HRESULT Stream(
        /// sink: (*(ID2D1GdiMetafileSink))
        IntPtr sink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, sink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr sink);
    public HRESULT GetBounds(
        /// bounds: (*(D2D1_RECT_F))
        ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoundsFunc));
        return callback(Self, ref bounds);
    }
    delegate HRESULT GetBoundsFunc(IntPtr self, ref D2D_RECT_F bounds);
}

public class ID2D1CommandSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 25;
    int VTableIndexBase => VTableIndexBase<ID2D1CommandSink>.Value;
    public HRESULT BeginDraw(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (BeginDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginDrawFunc));
        return callback(Self);
    }
    delegate HRESULT BeginDrawFunc(IntPtr self);
    public HRESULT EndDraw(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (EndDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndDrawFunc));
        return callback(Self);
    }
    delegate HRESULT EndDrawFunc(IntPtr self);
    public HRESULT SetAntialiasMode(
        /// antialiasMode: (D2D1_ANTIALIAS_MODE)
        D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetAntialiasModeFunc));
        return callback(Self, antialiasMode);
    }
    delegate HRESULT SetAntialiasModeFunc(IntPtr self, D2D1_ANTIALIAS_MODE antialiasMode);
    public HRESULT SetTags(
        /// tag1: (D2D1_TAG)
        D2D1_TAG tag1
        /// tag2: (D2D1_TAG)
        , D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetTagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTagsFunc));
        return callback(Self, tag1, tag2);
    }
    delegate HRESULT SetTagsFunc(IntPtr self, D2D1_TAG tag1, D2D1_TAG tag2);
    public HRESULT SetTextAntialiasMode(
        /// textAntialiasMode: (D2D1_TEXT_ANTIALIAS_MODE)
        D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SetTextAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextAntialiasModeFunc));
        return callback(Self, textAntialiasMode);
    }
    delegate HRESULT SetTextAntialiasModeFunc(IntPtr self, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
    public HRESULT SetTextRenderingParams(
        /// textRenderingParams: (*(IDWriteRenderingParams))
        IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextRenderingParamsFunc));
        return callback(Self, textRenderingParams);
    }
    delegate HRESULT SetTextRenderingParamsFunc(IntPtr self, IntPtr textRenderingParams);
    public HRESULT SetTransform(
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (SetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTransformFunc));
        return callback(Self, ref transform);
    }
    delegate HRESULT SetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
    public HRESULT SetPrimitiveBlend(
        /// primitiveBlend: (D2D1_PRIMITIVE_BLEND)
        D2D1_PRIMITIVE_BLEND primitiveBlend
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetPrimitiveBlendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrimitiveBlendFunc));
        return callback(Self, primitiveBlend);
    }
    delegate HRESULT SetPrimitiveBlendFunc(IntPtr self, D2D1_PRIMITIVE_BLEND primitiveBlend);
    public HRESULT SetUnitMode(
        /// unitMode: (D2D1_UNIT_MODE)
        D2D1_UNIT_MODE unitMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (SetUnitModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetUnitModeFunc));
        return callback(Self, unitMode);
    }
    delegate HRESULT SetUnitModeFunc(IntPtr self, D2D1_UNIT_MODE unitMode);
    public HRESULT Clear(
        /// color: (*(const D2D1_COLOR_F))
        ref Vector4 color
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (ClearFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearFunc));
        return callback(Self, ref color);
    }
    delegate HRESULT ClearFunc(IntPtr self, ref Vector4 color);
    public HRESULT DrawGlyphRun(
        /// baselineOrigin: (D2D1_POINT_2F)
        D2D_POINT_2F baselineOrigin
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// glyphRunDescription: (*(const DWRITE_GLYPH_RUN_DESCRIPTION))
        , ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription
        /// foregroundBrush: (*(ID2D1Brush))
        , IntPtr foregroundBrush
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        return callback(Self, baselineOrigin, ref glyphRun, ref glyphRunDescription, foregroundBrush, measuringMode);
    }
    delegate HRESULT DrawGlyphRunFunc(IntPtr self, D2D_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, IntPtr foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    public HRESULT DrawLine(
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
        return callback(Self, point0, point1, brush, strokeWidth, strokeStyle);
    }
    delegate HRESULT DrawLineFunc(IntPtr self, D2D_POINT_2F point0, D2D_POINT_2F point1, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public HRESULT DrawGeometry(
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
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (DrawGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGeometryFunc));
        return callback(Self, geometry, brush, strokeWidth, strokeStyle);
    }
    delegate HRESULT DrawGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public HRESULT DrawRectangle(
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
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (DrawRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawRectangleFunc));
        return callback(Self, ref rect, brush, strokeWidth, strokeStyle);
    }
    delegate HRESULT DrawRectangleFunc(IntPtr self, ref D2D_RECT_F rect, IntPtr brush, Single strokeWidth, IntPtr strokeStyle);
    public HRESULT DrawBitmap(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// opacity: (FLOAT)
        , Single opacity
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        , D2D1_INTERPOLATION_MODE interpolationMode
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
        /// perspectiveTransform: (*(const D2D1_MATRIX_4X4_F))
        , ref D2D_MATRIX_4X4_F perspectiveTransform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (DrawBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawBitmapFunc));
        return callback(Self, bitmap, ref destinationRectangle, opacity, interpolationMode, ref sourceRectangle, ref perspectiveTransform);
    }
    delegate HRESULT DrawBitmapFunc(IntPtr self, IntPtr bitmap, ref D2D_RECT_F destinationRectangle, Single opacity, D2D1_INTERPOLATION_MODE interpolationMode, ref D2D_RECT_F sourceRectangle, ref D2D_MATRIX_4X4_F perspectiveTransform);
    public HRESULT DrawImage(
        /// image: (*(ID2D1Image))
        IntPtr image
        /// targetOffset: (*(const D2D1_POINT_2F))
        , ref D2D_POINT_2F targetOffset
        /// imageRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F imageRectangle
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        , D2D1_INTERPOLATION_MODE interpolationMode
        /// compositeMode: (D2D1_COMPOSITE_MODE)
        , D2D1_COMPOSITE_MODE compositeMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (DrawImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawImageFunc));
        return callback(Self, image, ref targetOffset, ref imageRectangle, interpolationMode, compositeMode);
    }
    delegate HRESULT DrawImageFunc(IntPtr self, IntPtr image, ref D2D_POINT_2F targetOffset, ref D2D_RECT_F imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
    public HRESULT DrawGdiMetafile(
        /// gdiMetafile: (*(ID2D1GdiMetafile))
        IntPtr gdiMetafile
        /// targetOffset: (*(const D2D1_POINT_2F))
        , ref D2D_POINT_2F targetOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (DrawGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGdiMetafileFunc));
        return callback(Self, gdiMetafile, ref targetOffset);
    }
    delegate HRESULT DrawGdiMetafileFunc(IntPtr self, IntPtr gdiMetafile, ref D2D_POINT_2F targetOffset);
    public HRESULT FillMesh(
        /// mesh: (*(ID2D1Mesh))
        IntPtr mesh
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (FillMeshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillMeshFunc));
        return callback(Self, mesh, brush);
    }
    delegate HRESULT FillMeshFunc(IntPtr self, IntPtr mesh, IntPtr brush);
    public HRESULT FillOpacityMask(
        /// opacityMask: (*(ID2D1Bitmap))
        IntPtr opacityMask
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (FillOpacityMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillOpacityMaskFunc));
        return callback(Self, opacityMask, brush, ref destinationRectangle, ref sourceRectangle);
    }
    delegate HRESULT FillOpacityMaskFunc(IntPtr self, IntPtr opacityMask, IntPtr brush, ref D2D_RECT_F destinationRectangle, ref D2D_RECT_F sourceRectangle);
    public HRESULT FillGeometry(
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
        return callback(Self, geometry, brush, opacityBrush);
    }
    delegate HRESULT FillGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);
    public HRESULT FillRectangle(
        /// rect: (*(const D2D1_RECT_F))
        ref D2D_RECT_F rect
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (FillRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillRectangleFunc));
        return callback(Self, ref rect, brush);
    }
    delegate HRESULT FillRectangleFunc(IntPtr self, ref D2D_RECT_F rect, IntPtr brush);
    public HRESULT PushAxisAlignedClip(
        /// clipRect: (*(const D2D1_RECT_F))
        ref D2D_RECT_F clipRect
        /// antialiasMode: (D2D1_ANTIALIAS_MODE)
        , D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (PushAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushAxisAlignedClipFunc));
        return callback(Self, ref clipRect, antialiasMode);
    }
    delegate HRESULT PushAxisAlignedClipFunc(IntPtr self, ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    public HRESULT PushLayer(
        /// layerParameters1: (*(const D2D1_LAYER_PARAMETERS1))
        ref D2D1_LAYER_PARAMETERS1 layerParameters1
        /// layer: (*(ID2D1Layer))
        , IntPtr layer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (PushLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushLayerFunc));
        return callback(Self, ref layerParameters1, layer);
    }
    delegate HRESULT PushLayerFunc(IntPtr self, ref D2D1_LAYER_PARAMETERS1 layerParameters1, IntPtr layer);
    public HRESULT PopAxisAlignedClip(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (PopAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopAxisAlignedClipFunc));
        return callback(Self);
    }
    delegate HRESULT PopAxisAlignedClipFunc(IntPtr self);
    public HRESULT PopLayer(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (PopLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopLayerFunc));
        return callback(Self);
    }
    delegate HRESULT PopLayerFunc(IntPtr self);
}

public class ID2D1CommandList: ID2D1Image {

    static /*readonly*/ Guid s_uuid = new Guid("b4f34a19-2383-4d76-94f6-ec343657c3dc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1CommandList>.Value;
    public HRESULT Stream(
        /// sink: (*(ID2D1CommandSink))
        IntPtr sink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, sink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr sink);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}

public class ID2D1PrintControl : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1PrintControl>.Value;
    public HRESULT AddPage(
        /// commandList: (*(ID2D1CommandList))
        IntPtr commandList
        /// pageSize: (D2D_SIZE_F)
        , D2D_SIZE_F pageSize
        /// pagePrintTicketStream: (*(IStream))
        , IntPtr pagePrintTicketStream
        /// tag1: (*(D2D1_TAG))
        , ref D2D1_TAG tag1
        /// tag2: (*(D2D1_TAG))
        , ref D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddPageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddPageFunc));
        return callback(Self, commandList, pageSize, pagePrintTicketStream, ref tag1, ref tag2);
    }
    delegate HRESULT AddPageFunc(IntPtr self, IntPtr commandList, D2D_SIZE_F pageSize, IntPtr pagePrintTicketStream, ref D2D1_TAG tag1, ref D2D1_TAG tag2);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}

public class ID2D1ImageBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 10;
    int VTableIndexBase => VTableIndexBase<ID2D1ImageBrush>.Value;
    public void SetImage(
        /// image: (*(ID2D1Image))
        IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetImageFunc));
        callback(Self, image);
    }
    delegate void SetImageFunc(IntPtr self, IntPtr image);
    public void SetExtendModeX(
        /// extendModeX: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeXFunc));
        callback(Self, extendModeX);
    }
    delegate void SetExtendModeXFunc(IntPtr self, D2D1_EXTEND_MODE extendModeX);
    public void SetExtendModeY(
        /// extendModeY: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeYFunc));
        callback(Self, extendModeY);
    }
    delegate void SetExtendModeYFunc(IntPtr self, D2D1_EXTEND_MODE extendModeY);
    public void SetInterpolationMode(
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        D2D1_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationModeFunc));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationModeFunc(IntPtr self, D2D1_INTERPOLATION_MODE interpolationMode);
    public void SetSourceRectangle(
        /// sourceRectangle: (*(const D2D1_RECT_F))
        ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SetSourceRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSourceRectangleFunc));
        callback(Self, ref sourceRectangle);
    }
    delegate void SetSourceRectangleFunc(IntPtr self, ref D2D_RECT_F sourceRectangle);
    public void GetImage(
        /// image: (*(*(ID2D1Image)))
        ref IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImageFunc));
        callback(Self, ref image);
    }
    delegate void GetImageFunc(IntPtr self, ref IntPtr image);
    public D2D1_EXTEND_MODE GetExtendModeX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeXFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeXFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendModeY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeYFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeYFunc(IntPtr self);
    public D2D1_INTERPOLATION_MODE GetInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_INTERPOLATION_MODE GetInterpolationModeFunc(IntPtr self);
    public void GetSourceRectangle(
        /// sourceRectangle: (*(D2D1_RECT_F))
        ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetSourceRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceRectangleFunc));
        callback(Self, ref sourceRectangle);
    }
    delegate void GetSourceRectangleFunc(IntPtr self, ref D2D_RECT_F sourceRectangle);
}

public class ID2D1BitmapBrush1: ID2D1BitmapBrush {

    static /*readonly*/ Guid s_uuid = new Guid("41343a53-e41a-49a2-91cd-21793bbb62e5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1BitmapBrush1>.Value;
    public void SetInterpolationMode1(
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        D2D1_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationMode1Func));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationMode1Func(IntPtr self, D2D1_INTERPOLATION_MODE interpolationMode);
    public D2D1_INTERPOLATION_MODE GetInterpolationMode1(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationMode1Func));
        return callback(Self);
    }
    delegate D2D1_INTERPOLATION_MODE GetInterpolationMode1Func(IntPtr self);
}

public class ID2D1StrokeStyle1: ID2D1StrokeStyle {

    static /*readonly*/ Guid s_uuid = new Guid("10a72a66-e91c-43f4-993f-ddf4b82b0b4a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1StrokeStyle1>.Value;
    public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetStrokeTransformTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStrokeTransformTypeFunc));
        return callback(Self);
    }
    delegate D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformTypeFunc(IntPtr self);
}

public class ID2D1PathGeometry1: ID2D1PathGeometry {

    static /*readonly*/ Guid s_uuid = new Guid("62baa2d2-ab54-41b7-b872-787e0106a421");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<ID2D1PathGeometry1>.Value;
    public HRESULT ComputePointAndSegmentAtLength(
        /// length: (FLOAT)
        Single length
        /// startSegment: (UINT32)
        , UInt32 startSegment
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// pointDescription: (*(D2D1_POINT_DESCRIPTION))
        , ref D2D1_POINT_DESCRIPTION pointDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ComputePointAndSegmentAtLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputePointAndSegmentAtLengthFunc));
        return callback(Self, length, startSegment, ref worldTransform, flatteningTolerance, ref pointDescription);
    }
    delegate HRESULT ComputePointAndSegmentAtLengthFunc(IntPtr self, Single length, UInt32 startSegment, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D1_POINT_DESCRIPTION pointDescription);
}

public class ID2D1Properties : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 11;
    int VTableIndexBase => VTableIndexBase<ID2D1Properties>.Value;
    public UInt32 GetPropertyCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetPropertyCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetPropertyCountFunc(IntPtr self);
    public HRESULT GetPropertyName(
        /// index: (UINT32)
        UInt32 index
        /// name: (PWSTR)
        , IntPtr name
        /// nameCount: (UINT32)
        , UInt32 nameCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPropertyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyNameFunc));
        return callback(Self, index, name, nameCount);
    }
    delegate HRESULT GetPropertyNameFunc(IntPtr self, UInt32 index, IntPtr name, UInt32 nameCount);
    public UInt32 GetPropertyNameLength(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPropertyNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyNameLengthFunc));
        return callback(Self, index);
    }
    delegate UInt32 GetPropertyNameLengthFunc(IntPtr self, UInt32 index);
    public D2D1_PROPERTY_TYPE GetType(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        return callback(Self, index);
    }
    delegate D2D1_PROPERTY_TYPE GetTypeFunc(IntPtr self, UInt32 index);
    public UInt32 GetPropertyIndex(
        /// name: (PCWSTR)
        IntPtr name
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetPropertyIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyIndexFunc));
        return callback(Self, name);
    }
    delegate UInt32 GetPropertyIndexFunc(IntPtr self, IntPtr name);
    public HRESULT SetValueByName(
        /// name: (PCWSTR)
        IntPtr name
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(const BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetValueByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetValueByNameFunc));
        return callback(Self, name, type, ref data, dataSize);
    }
    delegate HRESULT SetValueByNameFunc(IntPtr self, IntPtr name, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT SetValue(
        /// index: (UINT32)
        UInt32 index
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(const BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (SetValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetValueFunc));
        return callback(Self, index, type, ref data, dataSize);
    }
    delegate HRESULT SetValueFunc(IntPtr self, UInt32 index, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT GetValueByName(
        /// name: (PCWSTR)
        IntPtr name
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetValueByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueByNameFunc));
        return callback(Self, name, type, ref data, dataSize);
    }
    delegate HRESULT GetValueByNameFunc(IntPtr self, IntPtr name, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT GetValue(
        /// index: (UINT32)
        UInt32 index
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueFunc));
        return callback(Self, index, type, ref data, dataSize);
    }
    delegate HRESULT GetValueFunc(IntPtr self, UInt32 index, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public UInt32 GetValueSize(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetValueSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueSizeFunc));
        return callback(Self, index);
    }
    delegate UInt32 GetValueSizeFunc(IntPtr self, UInt32 index);
    public HRESULT GetSubProperties(
        /// index: (UINT32)
        UInt32 index
        /// subProperties: (*(*(ID2D1Properties)))
        , ref IntPtr subProperties
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetSubPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSubPropertiesFunc));
        return callback(Self, index, ref subProperties);
    }
    delegate HRESULT GetSubPropertiesFunc(IntPtr self, UInt32 index, ref IntPtr subProperties);
}

public class ID2D1Effect: ID2D1Properties {

    static /*readonly*/ Guid s_uuid = new Guid("28211a43-7d89-476f-8181-2d6159b220ad");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1Effect>.Value;
    public void SetInput(
        /// index: (UINT32)
        UInt32 index
        /// input: (*(ID2D1Image))
        , IntPtr input
        /// invalidate: (BOOL)
        , Int32 invalidate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputFunc));
        callback(Self, index, input, invalidate);
    }
    delegate void SetInputFunc(IntPtr self, UInt32 index, IntPtr input, Int32 invalidate);
    public HRESULT SetInputCount(
        /// inputCount: (UINT32)
        UInt32 inputCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputCountFunc));
        return callback(Self, inputCount);
    }
    delegate HRESULT SetInputCountFunc(IntPtr self, UInt32 inputCount);
    public void GetInput(
        /// index: (UINT32)
        UInt32 index
        /// input: (*(*(ID2D1Image)))
        , ref IntPtr input
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputFunc));
        callback(Self, index, ref input);
    }
    delegate void GetInputFunc(IntPtr self, UInt32 index, ref IntPtr input);
    public UInt32 GetInputCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetInputCountFunc(IntPtr self);
    public void GetOutput(
        /// outputImage: (*(*(ID2D1Image)))
        ref IntPtr outputImage
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOutputFunc));
        callback(Self, ref outputImage);
    }
    delegate void GetOutputFunc(IntPtr self, ref IntPtr outputImage);
}

public class ID2D1Bitmap1: ID2D1Bitmap {

    static /*readonly*/ Guid s_uuid = new Guid("a898a84c-3873-4588-b08b-ebbf978df041");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1Bitmap1>.Value;
    public void GetColorContext(
        /// colorContext: (*(*(ID2D1ColorContext)))
        ref IntPtr colorContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetColorContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorContextFunc));
        callback(Self, ref colorContext);
    }
    delegate void GetColorContextFunc(IntPtr self, ref IntPtr colorContext);
    public D2D1_BITMAP_OPTIONS GetOptions(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOptionsFunc));
        return callback(Self);
    }
    delegate D2D1_BITMAP_OPTIONS GetOptionsFunc(IntPtr self);
    public HRESULT GetSurface(
        /// dxgiSurface: (*(*(IDXGISurface)))
        ref IntPtr dxgiSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSurfaceFunc));
        return callback(Self, ref dxgiSurface);
    }
    delegate HRESULT GetSurfaceFunc(IntPtr self, ref IntPtr dxgiSurface);
    public HRESULT Map(
        /// options: (D2D1_MAP_OPTIONS)
        D2D1_MAP_OPTIONS options
        /// mappedRect: (*(D2D1_MAPPED_RECT))
        , ref D2D1_MAPPED_RECT mappedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, options, ref mappedRect);
    }
    delegate HRESULT MapFunc(IntPtr self, D2D1_MAP_OPTIONS options, ref D2D1_MAPPED_RECT mappedRect);
    public HRESULT Unmap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        return callback(Self);
    }
    delegate HRESULT UnmapFunc(IntPtr self);
}

public class ID2D1ColorContext: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<ID2D1ColorContext>.Value;
    public D2D1_COLOR_SPACE GetColorSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetColorSpaceFunc(IntPtr self);
    public UInt32 GetProfileSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetProfileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileSizeFunc));
        return callback(Self);
    }
    delegate UInt32 GetProfileSizeFunc(IntPtr self);
    public HRESULT GetProfile(
        /// profile: (*(BYTE))
        ref Byte profile
        /// profileSize: (UINT32)
        , UInt32 profileSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileFunc));
        return callback(Self, ref profile, profileSize);
    }
    delegate HRESULT GetProfileFunc(IntPtr self, ref Byte profile, UInt32 profileSize);
}

public class ID2D1GradientStopCollection1: ID2D1GradientStopCollection {

    static /*readonly*/ Guid s_uuid = new Guid("ae1572f4-5dd0-4777-998b-9279472ae63b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1GradientStopCollection1>.Value;
    public void GetGradientStops1(
        /// gradientStops: (*(D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP gradientStops
        /// gradientStopsCount: (UINT32)
        , UInt32 gradientStopsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGradientStops1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStops1Func));
        callback(Self, ref gradientStops, gradientStopsCount);
    }
    delegate void GetGradientStops1Func(IntPtr self, ref D2D1_GRADIENT_STOP gradientStops, UInt32 gradientStopsCount);
    public D2D1_COLOR_SPACE GetPreInterpolationSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPreInterpolationSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPreInterpolationSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetPreInterpolationSpaceFunc(IntPtr self);
    public D2D1_COLOR_SPACE GetPostInterpolationSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPostInterpolationSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPostInterpolationSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetPostInterpolationSpaceFunc(IntPtr self);
    public D2D1_BUFFER_PRECISION GetBufferPrecision(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetBufferPrecisionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferPrecisionFunc));
        return callback(Self);
    }
    delegate D2D1_BUFFER_PRECISION GetBufferPrecisionFunc(IntPtr self);
    public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetColorInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationModeFunc(IntPtr self);
}

public class ID2D1DrawingStateBlock1: ID2D1DrawingStateBlock {

    static /*readonly*/ Guid s_uuid = new Guid("689f1f85-c72e-4e33-8f19-85754efd5ace");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<ID2D1DrawingStateBlock1>.Value;
    public void GetDescription(
        /// stateDescription: (*(D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void GetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
    public void SetDescription(
        /// stateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void SetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
}

public class ID2D1DeviceContext: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("e8f7fe7a-191c-466d-ad95-975678bda998");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 35;
    int VTableIndexBase => VTableIndexBase<ID2D1DeviceContext>.Value;
    public HRESULT CreateBitmap(
        /// size: (D2D1_SIZE_U)
        D2D_SIZE_U size
        /// sourceData: (*(const void))
        , IntPtr sourceData
        /// pitch: (UINT32)
        , UInt32 pitch
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES1))
        , ref D2D1_BITMAP_PROPERTIES1 bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap1)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapFunc));
        return callback(Self, size, sourceData, pitch, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateBitmapFunc(IntPtr self, D2D_SIZE_U size, IntPtr sourceData, UInt32 pitch, ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateBitmapFromWicBitmap(
        /// wicBitmapSource: (*(IWICBitmapSource))
        IntPtr wicBitmapSource
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES1))
        , ref D2D1_BITMAP_PROPERTIES1 bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap1)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateBitmapFromWicBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapFromWicBitmapFunc));
        return callback(Self, wicBitmapSource, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateBitmapFromWicBitmapFunc(IntPtr self, IntPtr wicBitmapSource, ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateColorContext(
        /// space: (D2D1_COLOR_SPACE)
        D2D1_COLOR_SPACE space
        /// profile: (*(const BYTE))
        , ref Byte profile
        /// profileSize: (UINT32)
        , UInt32 profileSize
        /// colorContext: (*(*(ID2D1ColorContext)))
        , ref IntPtr colorContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateColorContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateColorContextFunc));
        return callback(Self, space, ref profile, profileSize, ref colorContext);
    }
    delegate HRESULT CreateColorContextFunc(IntPtr self, D2D1_COLOR_SPACE space, ref Byte profile, UInt32 profileSize, ref IntPtr colorContext);
    public HRESULT CreateColorContextFromFilename(
        /// filename: (PCWSTR)
        IntPtr filename
        /// colorContext: (*(*(ID2D1ColorContext)))
        , ref IntPtr colorContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateColorContextFromFilenameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateColorContextFromFilenameFunc));
        return callback(Self, filename, ref colorContext);
    }
    delegate HRESULT CreateColorContextFromFilenameFunc(IntPtr self, IntPtr filename, ref IntPtr colorContext);
    public HRESULT CreateColorContextFromWicColorContext(
        /// wicColorContext: (*(IWICColorContext))
        IntPtr wicColorContext
        /// colorContext: (*(*(ID2D1ColorContext)))
        , ref IntPtr colorContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateColorContextFromWicColorContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateColorContextFromWicColorContextFunc));
        return callback(Self, wicColorContext, ref colorContext);
    }
    delegate HRESULT CreateColorContextFromWicColorContextFunc(IntPtr self, IntPtr wicColorContext, ref IntPtr colorContext);
    public HRESULT CreateBitmapFromDxgiSurface(
        /// surface: (*(IDXGISurface))
        IntPtr surface
        /// bitmapProperties: (*(const D2D1_BITMAP_PROPERTIES1))
        , ref D2D1_BITMAP_PROPERTIES1 bitmapProperties
        /// bitmap: (*(*(ID2D1Bitmap1)))
        , ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateBitmapFromDxgiSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapFromDxgiSurfaceFunc));
        return callback(Self, surface, ref bitmapProperties, ref bitmap);
    }
    delegate HRESULT CreateBitmapFromDxgiSurfaceFunc(IntPtr self, IntPtr surface, ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, ref IntPtr bitmap);
    public HRESULT CreateEffect(
        /// effectId: (&(const IID))
        ref Guid effectId
        /// effect: (*(*(ID2D1Effect)))
        , ref IntPtr effect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateEffectFunc));
        return callback(Self, ref effectId, ref effect);
    }
    delegate HRESULT CreateEffectFunc(IntPtr self, ref Guid effectId, ref IntPtr effect);
    public HRESULT CreateGradientStopCollection(
        /// straightAlphaGradientStops: (*(const D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP straightAlphaGradientStops
        /// straightAlphaGradientStopsCount: (UINT32)
        , UInt32 straightAlphaGradientStopsCount
        /// preInterpolationSpace: (D2D1_COLOR_SPACE)
        , D2D1_COLOR_SPACE preInterpolationSpace
        /// postInterpolationSpace: (D2D1_COLOR_SPACE)
        , D2D1_COLOR_SPACE postInterpolationSpace
        /// bufferPrecision: (D2D1_BUFFER_PRECISION)
        , D2D1_BUFFER_PRECISION bufferPrecision
        /// extendMode: (D2D1_EXTEND_MODE)
        , D2D1_EXTEND_MODE extendMode
        /// colorInterpolationMode: (D2D1_COLOR_INTERPOLATION_MODE)
        , D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode
        /// gradientStopCollection1: (*(*(ID2D1GradientStopCollection1)))
        , ref IntPtr gradientStopCollection1
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreateGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGradientStopCollectionFunc));
        return callback(Self, ref straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, ref gradientStopCollection1);
    }
    delegate HRESULT CreateGradientStopCollectionFunc(IntPtr self, ref D2D1_GRADIENT_STOP straightAlphaGradientStops, UInt32 straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, ref IntPtr gradientStopCollection1);
    public HRESULT CreateImageBrush(
        /// image: (*(ID2D1Image))
        IntPtr image
        /// imageBrushProperties: (*(const D2D1_IMAGE_BRUSH_PROPERTIES))
        , ref D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// imageBrush: (*(*(ID2D1ImageBrush)))
        , ref IntPtr imageBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateImageBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateImageBrushFunc));
        return callback(Self, image, ref imageBrushProperties, ref brushProperties, ref imageBrush);
    }
    delegate HRESULT CreateImageBrushFunc(IntPtr self, IntPtr image, ref D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, ref IntPtr imageBrush);
    public HRESULT CreateBitmapBrush(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
        /// bitmapBrushProperties: (*(const D2D1_BITMAP_BRUSH_PROPERTIES1))
        , ref D2D1_BITMAP_BRUSH_PROPERTIES1 bitmapBrushProperties
        /// brushProperties: (*(const D2D1_BRUSH_PROPERTIES))
        , ref D2D1_BRUSH_PROPERTIES brushProperties
        /// bitmapBrush: (*(*(ID2D1BitmapBrush1)))
        , ref IntPtr bitmapBrush
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateBitmapBrushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapBrushFunc));
        return callback(Self, bitmap, ref bitmapBrushProperties, ref brushProperties, ref bitmapBrush);
    }
    delegate HRESULT CreateBitmapBrushFunc(IntPtr self, IntPtr bitmap, ref D2D1_BITMAP_BRUSH_PROPERTIES1 bitmapBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, ref IntPtr bitmapBrush);
    public HRESULT CreateCommandList(
        /// commandList: (*(*(ID2D1CommandList)))
        ref IntPtr commandList
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommandListFunc));
        return callback(Self, ref commandList);
    }
    delegate HRESULT CreateCommandListFunc(IntPtr self, ref IntPtr commandList);
    public Int32 IsDxgiFormatSupported(
        /// format: (DXGI_FORMAT)
        DXGI_FORMAT format
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (IsDxgiFormatSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsDxgiFormatSupportedFunc));
        return callback(Self, format);
    }
    delegate Int32 IsDxgiFormatSupportedFunc(IntPtr self, DXGI_FORMAT format);
    public Int32 IsBufferPrecisionSupported(
        /// bufferPrecision: (D2D1_BUFFER_PRECISION)
        D2D1_BUFFER_PRECISION bufferPrecision
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (IsBufferPrecisionSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsBufferPrecisionSupportedFunc));
        return callback(Self, bufferPrecision);
    }
    delegate Int32 IsBufferPrecisionSupportedFunc(IntPtr self, D2D1_BUFFER_PRECISION bufferPrecision);
    public HRESULT GetImageLocalBounds(
        /// image: (*(ID2D1Image))
        IntPtr image
        /// localBounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F localBounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (GetImageLocalBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImageLocalBoundsFunc));
        return callback(Self, image, ref localBounds);
    }
    delegate HRESULT GetImageLocalBoundsFunc(IntPtr self, IntPtr image, ref D2D_RECT_F localBounds);
    public HRESULT GetImageWorldBounds(
        /// image: (*(ID2D1Image))
        IntPtr image
        /// worldBounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F worldBounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (GetImageWorldBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImageWorldBoundsFunc));
        return callback(Self, image, ref worldBounds);
    }
    delegate HRESULT GetImageWorldBoundsFunc(IntPtr self, IntPtr image, ref D2D_RECT_F worldBounds);
    public HRESULT GetGlyphRunWorldBounds(
        /// baselineOrigin: (D2D1_POINT_2F)
        D2D_POINT_2F baselineOrigin
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// bounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (GetGlyphRunWorldBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphRunWorldBoundsFunc));
        return callback(Self, baselineOrigin, ref glyphRun, measuringMode, ref bounds);
    }
    delegate HRESULT GetGlyphRunWorldBoundsFunc(IntPtr self, D2D_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, ref D2D_RECT_F bounds);
    public void GetDevice(
        /// device: (*(*(ID2D1Device)))
        ref IntPtr device
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
        callback(Self, ref device);
    }
    delegate void GetDeviceFunc(IntPtr self, ref IntPtr device);
    public void SetTarget(
        /// image: (*(ID2D1Image))
        IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (SetTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTargetFunc));
        callback(Self, image);
    }
    delegate void SetTargetFunc(IntPtr self, IntPtr image);
    public void GetTarget(
        /// image: (*(*(ID2D1Image)))
        ref IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (GetTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTargetFunc));
        callback(Self, ref image);
    }
    delegate void GetTargetFunc(IntPtr self, ref IntPtr image);
    public void SetRenderingControls(
        /// renderingControls: (*(const D2D1_RENDERING_CONTROLS))
        ref D2D1_RENDERING_CONTROLS renderingControls
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (SetRenderingControlsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRenderingControlsFunc));
        callback(Self, ref renderingControls);
    }
    delegate void SetRenderingControlsFunc(IntPtr self, ref D2D1_RENDERING_CONTROLS renderingControls);
    public void GetRenderingControls(
        /// renderingControls: (*(D2D1_RENDERING_CONTROLS))
        ref D2D1_RENDERING_CONTROLS renderingControls
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (GetRenderingControlsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRenderingControlsFunc));
        callback(Self, ref renderingControls);
    }
    delegate void GetRenderingControlsFunc(IntPtr self, ref D2D1_RENDERING_CONTROLS renderingControls);
    public void SetPrimitiveBlend(
        /// primitiveBlend: (D2D1_PRIMITIVE_BLEND)
        D2D1_PRIMITIVE_BLEND primitiveBlend
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (SetPrimitiveBlendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrimitiveBlendFunc));
        callback(Self, primitiveBlend);
    }
    delegate void SetPrimitiveBlendFunc(IntPtr self, D2D1_PRIMITIVE_BLEND primitiveBlend);
    public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (GetPrimitiveBlendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrimitiveBlendFunc));
        return callback(Self);
    }
    delegate D2D1_PRIMITIVE_BLEND GetPrimitiveBlendFunc(IntPtr self);
    public void SetUnitMode(
        /// unitMode: (D2D1_UNIT_MODE)
        D2D1_UNIT_MODE unitMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (SetUnitModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetUnitModeFunc));
        callback(Self, unitMode);
    }
    delegate void SetUnitModeFunc(IntPtr self, D2D1_UNIT_MODE unitMode);
    public D2D1_UNIT_MODE GetUnitMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (GetUnitModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUnitModeFunc));
        return callback(Self);
    }
    delegate D2D1_UNIT_MODE GetUnitModeFunc(IntPtr self);
    public void DrawGlyphRun(
        /// baselineOrigin: (D2D1_POINT_2F)
        D2D_POINT_2F baselineOrigin
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// glyphRunDescription: (*(const DWRITE_GLYPH_RUN_DESCRIPTION))
        , ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription
        /// foregroundBrush: (*(ID2D1Brush))
        , IntPtr foregroundBrush
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        callback(Self, baselineOrigin, ref glyphRun, ref glyphRunDescription, foregroundBrush, measuringMode);
    }
    delegate void DrawGlyphRunFunc(IntPtr self, D2D_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, IntPtr foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    public void DrawImage(
        /// image: (*(ID2D1Image))
        IntPtr image
        /// targetOffset: (*(const D2D1_POINT_2F))
        , ref D2D_POINT_2F targetOffset
        /// imageRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F imageRectangle
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        , D2D1_INTERPOLATION_MODE interpolationMode
        /// compositeMode: (D2D1_COMPOSITE_MODE)
        , D2D1_COMPOSITE_MODE compositeMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (DrawImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawImageFunc));
        callback(Self, image, ref targetOffset, ref imageRectangle, interpolationMode, compositeMode);
    }
    delegate void DrawImageFunc(IntPtr self, IntPtr image, ref D2D_POINT_2F targetOffset, ref D2D_RECT_F imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
    public void DrawGdiMetafile(
        /// gdiMetafile: (*(ID2D1GdiMetafile))
        IntPtr gdiMetafile
        /// targetOffset: (*(const D2D1_POINT_2F))
        , ref D2D_POINT_2F targetOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (DrawGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGdiMetafileFunc));
        callback(Self, gdiMetafile, ref targetOffset);
    }
    delegate void DrawGdiMetafileFunc(IntPtr self, IntPtr gdiMetafile, ref D2D_POINT_2F targetOffset);
    public void DrawBitmap(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// opacity: (FLOAT)
        , Single opacity
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        , D2D1_INTERPOLATION_MODE interpolationMode
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
        /// perspectiveTransform: (*(const D2D1_MATRIX_4X4_F))
        , ref D2D_MATRIX_4X4_F perspectiveTransform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (DrawBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawBitmapFunc));
        callback(Self, bitmap, ref destinationRectangle, opacity, interpolationMode, ref sourceRectangle, ref perspectiveTransform);
    }
    delegate void DrawBitmapFunc(IntPtr self, IntPtr bitmap, ref D2D_RECT_F destinationRectangle, Single opacity, D2D1_INTERPOLATION_MODE interpolationMode, ref D2D_RECT_F sourceRectangle, ref D2D_MATRIX_4X4_F perspectiveTransform);
    public void PushLayer(
        /// layerParameters: (*(const D2D1_LAYER_PARAMETERS1))
        ref D2D1_LAYER_PARAMETERS1 layerParameters
        /// layer: (*(ID2D1Layer))
        , IntPtr layer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (PushLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushLayerFunc));
        callback(Self, ref layerParameters, layer);
    }
    delegate void PushLayerFunc(IntPtr self, ref D2D1_LAYER_PARAMETERS1 layerParameters, IntPtr layer);
    public HRESULT InvalidateEffectInputRectangle(
        /// effect: (*(ID2D1Effect))
        IntPtr effect
        /// input: (UINT32)
        , UInt32 input
        /// inputRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F inputRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (InvalidateEffectInputRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvalidateEffectInputRectangleFunc));
        return callback(Self, effect, input, ref inputRectangle);
    }
    delegate HRESULT InvalidateEffectInputRectangleFunc(IntPtr self, IntPtr effect, UInt32 input, ref D2D_RECT_F inputRectangle);
    public HRESULT GetEffectInvalidRectangleCount(
        /// effect: (*(ID2D1Effect))
        IntPtr effect
        /// rectangleCount: (*(UINT32))
        , ref UInt32 rectangleCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (GetEffectInvalidRectangleCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectInvalidRectangleCountFunc));
        return callback(Self, effect, ref rectangleCount);
    }
    delegate HRESULT GetEffectInvalidRectangleCountFunc(IntPtr self, IntPtr effect, ref UInt32 rectangleCount);
    public HRESULT GetEffectInvalidRectangles(
        /// effect: (*(ID2D1Effect))
        IntPtr effect
        /// rectangles: (*(D2D1_RECT_F))
        , ref D2D_RECT_F rectangles
        /// rectanglesCount: (UINT32)
        , UInt32 rectanglesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (GetEffectInvalidRectanglesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectInvalidRectanglesFunc));
        return callback(Self, effect, ref rectangles, rectanglesCount);
    }
    delegate HRESULT GetEffectInvalidRectanglesFunc(IntPtr self, IntPtr effect, ref D2D_RECT_F rectangles, UInt32 rectanglesCount);
    public HRESULT GetEffectRequiredInputRectangles(
        /// renderEffect: (*(ID2D1Effect))
        IntPtr renderEffect
        /// renderImageRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F renderImageRectangle
        /// inputDescriptions: (*(const D2D1_EFFECT_INPUT_DESCRIPTION))
        , ref D2D1_EFFECT_INPUT_DESCRIPTION inputDescriptions
        /// requiredInputRects: (*(D2D1_RECT_F))
        , ref D2D_RECT_F requiredInputRects
        /// inputCount: (UINT32)
        , UInt32 inputCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (GetEffectRequiredInputRectanglesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectRequiredInputRectanglesFunc));
        return callback(Self, renderEffect, ref renderImageRectangle, ref inputDescriptions, ref requiredInputRects, inputCount);
    }
    delegate HRESULT GetEffectRequiredInputRectanglesFunc(IntPtr self, IntPtr renderEffect, ref D2D_RECT_F renderImageRectangle, ref D2D1_EFFECT_INPUT_DESCRIPTION inputDescriptions, ref D2D_RECT_F requiredInputRects, UInt32 inputCount);
    public void FillOpacityMask(
        /// opacityMask: (*(ID2D1Bitmap))
        IntPtr opacityMask
        /// brush: (*(ID2D1Brush))
        , IntPtr brush
        /// destinationRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F destinationRectangle
        /// sourceRectangle: (*(const D2D1_RECT_F))
        , ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (FillOpacityMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillOpacityMaskFunc));
        callback(Self, opacityMask, brush, ref destinationRectangle, ref sourceRectangle);
    }
    delegate void FillOpacityMaskFunc(IntPtr self, IntPtr opacityMask, IntPtr brush, ref D2D_RECT_F destinationRectangle, ref D2D_RECT_F sourceRectangle);
}

public class ID2D1Device: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("47dd575d-ac05-4cdd-8049-9b02cd16f44c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<ID2D1Device>.Value;
    public HRESULT CreateDeviceContext(
        /// options: (D2D1_DEVICE_CONTEXT_OPTIONS)
        D2D1_DEVICE_CONTEXT_OPTIONS options
        /// deviceContext: (*(*(ID2D1DeviceContext)))
        , ref IntPtr deviceContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateDeviceContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeviceContextFunc));
        return callback(Self, options, ref deviceContext);
    }
    delegate HRESULT CreateDeviceContextFunc(IntPtr self, D2D1_DEVICE_CONTEXT_OPTIONS options, ref IntPtr deviceContext);
    public HRESULT CreatePrintControl(
        /// wicFactory: (*(IWICImagingFactory))
        IntPtr wicFactory
        /// documentTarget: (*(IPrintDocumentPackageTarget))
        , IntPtr documentTarget
        /// printControlProperties: (*(const D2D1_PRINT_CONTROL_PROPERTIES))
        , ref D2D1_PRINT_CONTROL_PROPERTIES printControlProperties
        /// printControl: (*(*(ID2D1PrintControl)))
        , ref IntPtr printControl
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreatePrintControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePrintControlFunc));
        return callback(Self, wicFactory, documentTarget, ref printControlProperties, ref printControl);
    }
    delegate HRESULT CreatePrintControlFunc(IntPtr self, IntPtr wicFactory, IntPtr documentTarget, ref D2D1_PRINT_CONTROL_PROPERTIES printControlProperties, ref IntPtr printControl);
    public void SetMaximumTextureMemory(
        /// maximumInBytes: (UINT64)
        UInt64 maximumInBytes
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetMaximumTextureMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumTextureMemoryFunc));
        callback(Self, maximumInBytes);
    }
    delegate void SetMaximumTextureMemoryFunc(IntPtr self, UInt64 maximumInBytes);
    public UInt64 GetMaximumTextureMemory(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetMaximumTextureMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumTextureMemoryFunc));
        return callback(Self);
    }
    delegate UInt64 GetMaximumTextureMemoryFunc(IntPtr self);
    public void ClearResources(
        /// millisecondsSinceUse: (UINT32)
        UInt32 millisecondsSinceUse
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (ClearResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearResourcesFunc));
        callback(Self, millisecondsSinceUse);
    }
    delegate void ClearResourcesFunc(IntPtr self, UInt32 millisecondsSinceUse);
}

public class ID2D1Factory1: ID2D1Factory {

    static /*readonly*/ Guid s_uuid = new Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 10;
    int VTableIndexBase => VTableIndexBase<ID2D1Factory1>.Value;
    public HRESULT CreateDevice(
        /// dxgiDevice: (*(IDXGIDevice))
        IntPtr dxgiDevice
        /// d2dDevice: (*(*(ID2D1Device)))
        , ref IntPtr d2dDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeviceFunc));
        return callback(Self, dxgiDevice, ref d2dDevice);
    }
    delegate HRESULT CreateDeviceFunc(IntPtr self, IntPtr dxgiDevice, ref IntPtr d2dDevice);
    public HRESULT CreateStrokeStyle(
        /// strokeStyleProperties: (*(const D2D1_STROKE_STYLE_PROPERTIES1))
        ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties
        /// dashes: (*(const FLOAT))
        , ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
        /// strokeStyle: (*(*(ID2D1StrokeStyle1)))
        , ref IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateStrokeStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStrokeStyleFunc));
        return callback(Self, ref strokeStyleProperties, ref dashes, dashesCount, ref strokeStyle);
    }
    delegate HRESULT CreateStrokeStyleFunc(IntPtr self, ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, ref Single dashes, UInt32 dashesCount, ref IntPtr strokeStyle);
    public HRESULT CreatePathGeometry(
        /// pathGeometry: (*(*(ID2D1PathGeometry1)))
        ref IntPtr pathGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreatePathGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePathGeometryFunc));
        return callback(Self, ref pathGeometry);
    }
    delegate HRESULT CreatePathGeometryFunc(IntPtr self, ref IntPtr pathGeometry);
    public HRESULT CreateDrawingStateBlock(
        /// drawingStateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription
        /// textRenderingParams: (*(IDWriteRenderingParams))
        , IntPtr textRenderingParams
        /// drawingStateBlock: (*(*(ID2D1DrawingStateBlock1)))
        , ref IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateDrawingStateBlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDrawingStateBlockFunc));
        return callback(Self, ref drawingStateDescription, textRenderingParams, ref drawingStateBlock);
    }
    delegate HRESULT CreateDrawingStateBlockFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription, IntPtr textRenderingParams, ref IntPtr drawingStateBlock);
    public HRESULT CreateGdiMetafile(
        /// metafileStream: (*(IStream))
        IntPtr metafileStream
        /// metafile: (*(*(ID2D1GdiMetafile)))
        , ref IntPtr metafile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGdiMetafileFunc));
        return callback(Self, metafileStream, ref metafile);
    }
    delegate HRESULT CreateGdiMetafileFunc(IntPtr self, IntPtr metafileStream, ref IntPtr metafile);
    public HRESULT RegisterEffectFromStream(
        /// classId: (&(const IID))
        ref Guid classId
        /// propertyXml: (*(IStream))
        , IntPtr propertyXml
        /// bindings: (*(const D2D1_PROPERTY_BINDING))
        , ref D2D1_PROPERTY_BINDING bindings
        /// bindingsCount: (UINT32)
        , UInt32 bindingsCount
        /// effectFactory: (const PD2D1_EFFECT_FACTORY)
        , IntPtr effectFactory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (RegisterEffectFromStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStreamFunc));
        return callback(Self, ref classId, propertyXml, ref bindings, bindingsCount, effectFactory);
    }
    delegate HRESULT RegisterEffectFromStreamFunc(IntPtr self, ref Guid classId, IntPtr propertyXml, ref D2D1_PROPERTY_BINDING bindings, UInt32 bindingsCount, IntPtr effectFactory);
    public HRESULT RegisterEffectFromString(
        /// classId: (&(const IID))
        ref Guid classId
        /// propertyXml: (PCWSTR)
        , IntPtr propertyXml
        /// bindings: (*(const D2D1_PROPERTY_BINDING))
        , ref D2D1_PROPERTY_BINDING bindings
        /// bindingsCount: (UINT32)
        , UInt32 bindingsCount
        /// effectFactory: (const PD2D1_EFFECT_FACTORY)
        , IntPtr effectFactory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (RegisterEffectFromStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStringFunc));
        return callback(Self, ref classId, propertyXml, ref bindings, bindingsCount, effectFactory);
    }
    delegate HRESULT RegisterEffectFromStringFunc(IntPtr self, ref Guid classId, IntPtr propertyXml, ref D2D1_PROPERTY_BINDING bindings, UInt32 bindingsCount, IntPtr effectFactory);
    public HRESULT UnregisterEffect(
        /// classId: (&(const IID))
        ref Guid classId
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (UnregisterEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterEffectFunc));
        return callback(Self, ref classId);
    }
    delegate HRESULT UnregisterEffectFunc(IntPtr self, ref Guid classId);
    public HRESULT GetRegisteredEffects(
        /// effects: (*(CLSID))
        ref Guid effects
        /// effectsCount: (UINT32)
        , UInt32 effectsCount
        /// effectsReturned: (*(UINT32))
        , ref UInt32 effectsReturned
        /// effectsRegistered: (*(UINT32))
        , ref UInt32 effectsRegistered
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetRegisteredEffectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRegisteredEffectsFunc));
        return callback(Self, ref effects, effectsCount, ref effectsReturned, ref effectsRegistered);
    }
    delegate HRESULT GetRegisteredEffectsFunc(IntPtr self, ref Guid effects, UInt32 effectsCount, ref UInt32 effectsReturned, ref UInt32 effectsRegistered);
    public HRESULT GetEffectProperties(
        /// effectId: (&(const IID))
        ref Guid effectId
        /// properties: (*(*(ID2D1Properties)))
        , ref IntPtr properties
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetEffectPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectPropertiesFunc));
        return callback(Self, ref effectId, ref properties);
    }
    delegate HRESULT GetEffectPropertiesFunc(IntPtr self, ref Guid effectId, ref IntPtr properties);
}

public class ID2D1Multithread : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<ID2D1Multithread>.Value;
    public Int32 GetMultithreadProtected(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetMultithreadProtectedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMultithreadProtectedFunc));
        return callback(Self);
    }
    delegate Int32 GetMultithreadProtectedFunc(IntPtr self);
    public void Enter(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (EnterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnterFunc));
        callback(Self);
    }
    delegate void EnterFunc(IntPtr self);
    public void Leave(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (LeaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LeaveFunc));
        callback(Self);
    }
    delegate void LeaveFunc(IntPtr self);
}

public static class d2d1_1{
public const int D2D1_INVALID_PROPERTY_INDEX = unchecked((int)UInt32.MaxValue);
[DllImport("D2D1.dll")]
public static extern HRESULT D2D1CreateDevice(
    /// dxgiDevice: (*(IDXGIDevice))
    IntPtr dxgiDevice
    /// creationProperties: (*(const D2D1_CREATION_PROPERTIES))
    , ref D2D1_CREATION_PROPERTIES creationProperties
    /// d2dDevice: (*(*(ID2D1Device)))
    , ref IntPtr d2dDevice
);

[DllImport("D2D1.dll")]
public static extern HRESULT D2D1CreateDeviceContext(
    /// dxgiSurface: (*(IDXGISurface))
    IntPtr dxgiSurface
    /// creationProperties: (*(const D2D1_CREATION_PROPERTIES))
    , ref D2D1_CREATION_PROPERTIES creationProperties
    /// d2dDeviceContext: (*(*(ID2D1DeviceContext)))
    , ref IntPtr d2dDeviceContext
);

[DllImport("D2D1.dll")]
public static extern Vector4 D2D1ConvertColorSpace(
    /// sourceColorSpace: (D2D1_COLOR_SPACE)
    D2D1_COLOR_SPACE sourceColorSpace
    /// destinationColorSpace: (D2D1_COLOR_SPACE)
    , D2D1_COLOR_SPACE destinationColorSpace
    /// color: (*(const D2D1_COLOR_F))
    , ref Vector4 color
);

[DllImport("D2D1.dll")]
public static extern void D2D1SinCos(
    /// angle: (FLOAT)
    Single angle
    /// s: (*(FLOAT))
    , ref Single s
    /// c: (*(FLOAT))
    , ref Single c
);

[DllImport("D2D1.dll")]
public static extern Single D2D1Tan(
    /// angle: (FLOAT)
    Single angle
);

[DllImport("D2D1.dll")]
public static extern Single D2D1Vec3Length(
    /// x: (FLOAT)
    Single x
    /// y: (FLOAT)
    , Single y
    /// z: (FLOAT)
    , Single z
);

}
}
