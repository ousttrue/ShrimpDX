/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=25)]
public class ID2D1CommandSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
