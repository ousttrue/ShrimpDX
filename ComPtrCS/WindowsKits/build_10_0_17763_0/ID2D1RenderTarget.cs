/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=53)]
public class ID2D1RenderTarget: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90694-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
    public void DrawTextW(
        /// string: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string str
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
        var callback = (DrawTextWFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawTextWFunc));
        callback(Self, str, stringLength, textFormat, ref layoutRect, defaultFillBrush, options, measuringMode);
    }
    delegate void DrawTextWFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string str, UInt32 stringLength, IntPtr textFormat, ref D2D_RECT_F layoutRect, IntPtr defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
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
}
