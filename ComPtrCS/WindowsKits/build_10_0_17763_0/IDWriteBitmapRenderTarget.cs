/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=8)]
public class IDWriteBitmapRenderTarget : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteBitmapRenderTarget>.Value;
    public HRESULT DrawGlyphRun(
        /// baselineOriginX: (FLOAT)
        Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// renderingParams: (*(IDWriteRenderingParams))
        , IntPtr renderingParams
        /// textColor: (COLORREF)
        , UInt32 textColor
        /// blackBoxRect: (*(RECT))
        , ref RECT blackBoxRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        return callback(Self, baselineOriginX, baselineOriginY, measuringMode, ref glyphRun, renderingParams, textColor, ref blackBoxRect);
    }
    delegate HRESULT DrawGlyphRunFunc(IntPtr self, Single baselineOriginX, Single baselineOriginY, DWRITE_MEASURING_MODE measuringMode, ref DWRITE_GLYPH_RUN glyphRun, IntPtr renderingParams, UInt32 textColor, ref RECT blackBoxRect);
    public IntPtr GetMemoryDC(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetMemoryDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemoryDCFunc));
        return callback(Self);
    }
    delegate IntPtr GetMemoryDCFunc(IntPtr self);
    public Single GetPixelsPerDip(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelsPerDipFunc));
        return callback(Self);
    }
    delegate Single GetPixelsPerDipFunc(IntPtr self);
    public HRESULT SetPixelsPerDip(
        /// pixelsPerDip: (FLOAT)
        Single pixelsPerDip
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPixelsPerDipFunc));
        return callback(Self, pixelsPerDip);
    }
    delegate HRESULT SetPixelsPerDipFunc(IntPtr self, Single pixelsPerDip);
    public HRESULT GetCurrentTransform(
        /// transform: (*(DWRITE_MATRIX))
        ref DWRITE_MATRIX transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentTransformFunc));
        return callback(Self, ref transform);
    }
    delegate HRESULT GetCurrentTransformFunc(IntPtr self, ref DWRITE_MATRIX transform);
    public HRESULT SetCurrentTransform(
        /// transform: (*(const DWRITE_MATRIX))
        ref DWRITE_MATRIX transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCurrentTransformFunc));
        return callback(Self, ref transform);
    }
    delegate HRESULT SetCurrentTransformFunc(IntPtr self, ref DWRITE_MATRIX transform);
    public HRESULT GetSize(
        /// size: (*(SIZE))
        ref SIZE size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self, ref size);
    }
    delegate HRESULT GetSizeFunc(IntPtr self, ref SIZE size);
    public HRESULT Resize(
        /// width: (UINT32)
        UInt32 width
        /// height: (UINT32)
        , UInt32 height
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (ResizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeFunc));
        return callback(Self, width, height);
    }
    delegate HRESULT ResizeFunc(IntPtr self, UInt32 width, UInt32 height);
}
}
