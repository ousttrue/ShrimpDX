/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=35)]
public class ID2D1DeviceContext: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("e8f7fe7a-191c-466d-ad95-975678bda998");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
