/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=15)]
public class IDWriteFontFace : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5f49804d-7024-4d43-bfa9-d25984f53849");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteFontFace>.Value;
    public DWRITE_FONT_FACE_TYPE GetType(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_FACE_TYPE GetTypeFunc(IntPtr self);
    public HRESULT GetFiles(
        /// numberOfFiles: (*(UINT32))
        ref UInt32 numberOfFiles
        /// fontFiles: (*(*(IDWriteFontFile)))
        , ref IntPtr fontFiles
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFilesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilesFunc));
        return callback(Self, ref numberOfFiles, ref fontFiles);
    }
    delegate HRESULT GetFilesFunc(IntPtr self, ref UInt32 numberOfFiles, ref IntPtr fontFiles);
    public UInt32 GetIndex(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIndexFunc));
        return callback(Self);
    }
    delegate UInt32 GetIndexFunc(IntPtr self);
    public DWRITE_FONT_SIMULATIONS GetSimulations(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetSimulationsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSimulationsFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_SIMULATIONS GetSimulationsFunc(IntPtr self);
    public Int32 IsSymbolFont(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (IsSymbolFontFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsSymbolFontFunc));
        return callback(Self);
    }
    delegate Int32 IsSymbolFontFunc(IntPtr self);
    public void GetMetrics(
        /// fontFaceMetrics: (*(DWRITE_FONT_METRICS))
        ref DWRITE_FONT_METRICS fontFaceMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetricsFunc));
        callback(Self, ref fontFaceMetrics);
    }
    delegate void GetMetricsFunc(IntPtr self, ref DWRITE_FONT_METRICS fontFaceMetrics);
    public UInt16 GetGlyphCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetGlyphCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphCountFunc));
        return callback(Self);
    }
    delegate UInt16 GetGlyphCountFunc(IntPtr self);
    public HRESULT GetDesignGlyphMetrics(
        /// glyphIndices: (*(const UINT16))
        ref UInt16 glyphIndices
        /// glyphCount: (UINT32)
        , UInt32 glyphCount
        /// glyphMetrics: (*(DWRITE_GLYPH_METRICS))
        , ref DWRITE_GLYPH_METRICS glyphMetrics
        /// isSideways: (BOOL)
        , Int32 isSideways
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetDesignGlyphMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesignGlyphMetricsFunc));
        return callback(Self, ref glyphIndices, glyphCount, ref glyphMetrics, isSideways);
    }
    delegate HRESULT GetDesignGlyphMetricsFunc(IntPtr self, ref UInt16 glyphIndices, UInt32 glyphCount, ref DWRITE_GLYPH_METRICS glyphMetrics, Int32 isSideways);
    public HRESULT GetGlyphIndicesW(
        /// codePoints: (*(const UINT32))
        ref UInt32 codePoints
        /// codePointCount: (UINT32)
        , UInt32 codePointCount
        /// glyphIndices: (*(UINT16))
        , ref UInt16 glyphIndices
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetGlyphIndicesWFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphIndicesWFunc));
        return callback(Self, ref codePoints, codePointCount, ref glyphIndices);
    }
    delegate HRESULT GetGlyphIndicesWFunc(IntPtr self, ref UInt32 codePoints, UInt32 codePointCount, ref UInt16 glyphIndices);
    public HRESULT TryGetFontTable(
        /// openTypeTableTag: (UINT32)
        UInt32 openTypeTableTag
        /// tableData: (*(*(const void)))
        , ref IntPtr tableData
        /// tableSize: (*(UINT32))
        , ref UInt32 tableSize
        /// tableContext: (*(*(void)))
        , ref IntPtr tableContext
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (TryGetFontTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TryGetFontTableFunc));
        return callback(Self, openTypeTableTag, ref tableData, ref tableSize, ref tableContext, exists);
    }
    delegate HRESULT TryGetFontTableFunc(IntPtr self, UInt32 openTypeTableTag, ref IntPtr tableData, ref UInt32 tableSize, ref IntPtr tableContext, IntPtr exists);
    public void ReleaseFontTable(
        /// tableContext: (*(void))
        IntPtr tableContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (ReleaseFontTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFontTableFunc));
        callback(Self, tableContext);
    }
    delegate void ReleaseFontTableFunc(IntPtr self, IntPtr tableContext);
    public HRESULT GetGlyphRunOutline(
        /// emSize: (FLOAT)
        Single emSize
        /// glyphIndices: (*(const UINT16))
        , ref UInt16 glyphIndices
        /// glyphAdvances: (*(const FLOAT))
        , ref Single glyphAdvances
        /// glyphOffsets: (*(const DWRITE_GLYPH_OFFSET))
        , ref DWRITE_GLYPH_OFFSET glyphOffsets
        /// glyphCount: (UINT32)
        , UInt32 glyphCount
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// geometrySink: (*(IDWriteGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (GetGlyphRunOutlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphRunOutlineFunc));
        return callback(Self, emSize, ref glyphIndices, ref glyphAdvances, ref glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }
    delegate HRESULT GetGlyphRunOutlineFunc(IntPtr self, Single emSize, ref UInt16 glyphIndices, ref Single glyphAdvances, ref DWRITE_GLYPH_OFFSET glyphOffsets, UInt32 glyphCount, Int32 isSideways, Int32 isRightToLeft, IntPtr geometrySink);
    public HRESULT GetRecommendedRenderingMode(
        /// emSize: (FLOAT)
        Single emSize
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// renderingParams: (*(IDWriteRenderingParams))
        , IntPtr renderingParams
        /// renderingMode: (*(DWRITE_RENDERING_MODE))
        , ref DWRITE_RENDERING_MODE renderingMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (GetRecommendedRenderingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRecommendedRenderingModeFunc));
        return callback(Self, emSize, pixelsPerDip, measuringMode, renderingParams, ref renderingMode);
    }
    delegate HRESULT GetRecommendedRenderingModeFunc(IntPtr self, Single emSize, Single pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IntPtr renderingParams, ref DWRITE_RENDERING_MODE renderingMode);
    public HRESULT GetGdiCompatibleMetrics(
        /// emSize: (FLOAT)
        Single emSize
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// transform: (*(const DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
        /// fontFaceMetrics: (*(DWRITE_FONT_METRICS))
        , ref DWRITE_FONT_METRICS fontFaceMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (GetGdiCompatibleMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGdiCompatibleMetricsFunc));
        return callback(Self, emSize, pixelsPerDip, ref transform, ref fontFaceMetrics);
    }
    delegate HRESULT GetGdiCompatibleMetricsFunc(IntPtr self, Single emSize, Single pixelsPerDip, ref DWRITE_MATRIX transform, ref DWRITE_FONT_METRICS fontFaceMetrics);
    public HRESULT GetGdiCompatibleGlyphMetrics(
        /// emSize: (FLOAT)
        Single emSize
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// transform: (*(const DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
        /// useGdiNatural: (BOOL)
        , Int32 useGdiNatural
        /// glyphIndices: (*(const UINT16))
        , ref UInt16 glyphIndices
        /// glyphCount: (UINT32)
        , UInt32 glyphCount
        /// glyphMetrics: (*(DWRITE_GLYPH_METRICS))
        , ref DWRITE_GLYPH_METRICS glyphMetrics
        /// isSideways: (BOOL)
        , Int32 isSideways
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (GetGdiCompatibleGlyphMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGdiCompatibleGlyphMetricsFunc));
        return callback(Self, emSize, pixelsPerDip, ref transform, useGdiNatural, ref glyphIndices, glyphCount, ref glyphMetrics, isSideways);
    }
    delegate HRESULT GetGdiCompatibleGlyphMetricsFunc(IntPtr self, Single emSize, Single pixelsPerDip, ref DWRITE_MATRIX transform, Int32 useGdiNatural, ref UInt16 glyphIndices, UInt32 glyphCount, ref DWRITE_GLYPH_METRICS glyphMetrics, Int32 isSideways);
}
}
