/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=7)]
public class IDWriteTextAnalyzer : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteTextAnalyzer>.Value;
    public HRESULT AnalyzeScript(
        /// analysisSource: (*(IDWriteTextAnalysisSource))
        IntPtr analysisSource
        /// textPosition: (UINT32)
        , UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// analysisSink: (*(IDWriteTextAnalysisSink))
        , IntPtr analysisSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AnalyzeScriptFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeScriptFunc));
        return callback(Self, analysisSource, textPosition, textLength, analysisSink);
    }
    delegate HRESULT AnalyzeScriptFunc(IntPtr self, IntPtr analysisSource, UInt32 textPosition, UInt32 textLength, IntPtr analysisSink);
    public HRESULT AnalyzeBidi(
        /// analysisSource: (*(IDWriteTextAnalysisSource))
        IntPtr analysisSource
        /// textPosition: (UINT32)
        , UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// analysisSink: (*(IDWriteTextAnalysisSink))
        , IntPtr analysisSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (AnalyzeBidiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeBidiFunc));
        return callback(Self, analysisSource, textPosition, textLength, analysisSink);
    }
    delegate HRESULT AnalyzeBidiFunc(IntPtr self, IntPtr analysisSource, UInt32 textPosition, UInt32 textLength, IntPtr analysisSink);
    public HRESULT AnalyzeNumberSubstitution(
        /// analysisSource: (*(IDWriteTextAnalysisSource))
        IntPtr analysisSource
        /// textPosition: (UINT32)
        , UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// analysisSink: (*(IDWriteTextAnalysisSink))
        , IntPtr analysisSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (AnalyzeNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeNumberSubstitutionFunc));
        return callback(Self, analysisSource, textPosition, textLength, analysisSink);
    }
    delegate HRESULT AnalyzeNumberSubstitutionFunc(IntPtr self, IntPtr analysisSource, UInt32 textPosition, UInt32 textLength, IntPtr analysisSink);
    public HRESULT AnalyzeLineBreakpoints(
        /// analysisSource: (*(IDWriteTextAnalysisSource))
        IntPtr analysisSource
        /// textPosition: (UINT32)
        , UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// analysisSink: (*(IDWriteTextAnalysisSink))
        , IntPtr analysisSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (AnalyzeLineBreakpointsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeLineBreakpointsFunc));
        return callback(Self, analysisSource, textPosition, textLength, analysisSink);
    }
    delegate HRESULT AnalyzeLineBreakpointsFunc(IntPtr self, IntPtr analysisSource, UInt32 textPosition, UInt32 textLength, IntPtr analysisSink);
    public HRESULT GetGlyphs(
        /// textString: (*(const WCHAR))
        ref Char textString
        /// textLength: (UINT32)
        , UInt32 textLength
        /// fontFace: (*(IDWriteFontFace))
        , IntPtr fontFace
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// scriptAnalysis: (*(const DWRITE_SCRIPT_ANALYSIS))
        , ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis
        /// localeName: (*(const WCHAR))
        , ref Char localeName
        /// numberSubstitution: (*(IDWriteNumberSubstitution))
        , IntPtr numberSubstitution
        /// features: (*(*(const DWRITE_TYPOGRAPHIC_FEATURES)))
        , ref IntPtr features
        /// featureRangeLengths: (*(const UINT32))
        , ref UInt32 featureRangeLengths
        /// featureRanges: (UINT32)
        , UInt32 featureRanges
        /// maxGlyphCount: (UINT32)
        , UInt32 maxGlyphCount
        /// clusterMap: (*(UINT16))
        , ref UInt16 clusterMap
        /// textProps: (*(DWRITE_SHAPING_TEXT_PROPERTIES))
        , ref DWRITE_SHAPING_TEXT_PROPERTIES textProps
        /// glyphIndices: (*(UINT16))
        , ref UInt16 glyphIndices
        /// glyphProps: (*(DWRITE_SHAPING_GLYPH_PROPERTIES))
        , ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps
        /// actualGlyphCount: (*(UINT32))
        , ref UInt32 actualGlyphCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetGlyphsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphsFunc));
        return callback(Self, ref textString, textLength, fontFace, isSideways, isRightToLeft, ref scriptAnalysis, ref localeName, numberSubstitution, ref features, ref featureRangeLengths, featureRanges, maxGlyphCount, ref clusterMap, ref textProps, ref glyphIndices, ref glyphProps, ref actualGlyphCount);
    }
    delegate HRESULT GetGlyphsFunc(IntPtr self, ref Char textString, UInt32 textLength, IntPtr fontFace, Int32 isSideways, Int32 isRightToLeft, ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, ref Char localeName, IntPtr numberSubstitution, ref IntPtr features, ref UInt32 featureRangeLengths, UInt32 featureRanges, UInt32 maxGlyphCount, ref UInt16 clusterMap, ref DWRITE_SHAPING_TEXT_PROPERTIES textProps, ref UInt16 glyphIndices, ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, ref UInt32 actualGlyphCount);
    public HRESULT GetGlyphPlacements(
        /// textString: (*(const WCHAR))
        ref Char textString
        /// clusterMap: (*(const UINT16))
        , ref UInt16 clusterMap
        /// textProps: (*(DWRITE_SHAPING_TEXT_PROPERTIES))
        , ref DWRITE_SHAPING_TEXT_PROPERTIES textProps
        /// textLength: (UINT32)
        , UInt32 textLength
        /// glyphIndices: (*(const UINT16))
        , ref UInt16 glyphIndices
        /// glyphProps: (*(const DWRITE_SHAPING_GLYPH_PROPERTIES))
        , ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps
        /// glyphCount: (UINT32)
        , UInt32 glyphCount
        /// fontFace: (*(IDWriteFontFace))
        , IntPtr fontFace
        /// fontEmSize: (FLOAT)
        , Single fontEmSize
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// scriptAnalysis: (*(const DWRITE_SCRIPT_ANALYSIS))
        , ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis
        /// localeName: (*(const WCHAR))
        , ref Char localeName
        /// features: (*(*(const DWRITE_TYPOGRAPHIC_FEATURES)))
        , ref IntPtr features
        /// featureRangeLengths: (*(const UINT32))
        , ref UInt32 featureRangeLengths
        /// featureRanges: (UINT32)
        , UInt32 featureRanges
        /// glyphAdvances: (*(FLOAT))
        , ref Single glyphAdvances
        /// glyphOffsets: (*(DWRITE_GLYPH_OFFSET))
        , ref DWRITE_GLYPH_OFFSET glyphOffsets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetGlyphPlacementsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGlyphPlacementsFunc));
        return callback(Self, ref textString, ref clusterMap, ref textProps, textLength, ref glyphIndices, ref glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, ref scriptAnalysis, ref localeName, ref features, ref featureRangeLengths, featureRanges, ref glyphAdvances, ref glyphOffsets);
    }
    delegate HRESULT GetGlyphPlacementsFunc(IntPtr self, ref Char textString, ref UInt16 clusterMap, ref DWRITE_SHAPING_TEXT_PROPERTIES textProps, UInt32 textLength, ref UInt16 glyphIndices, ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, UInt32 glyphCount, IntPtr fontFace, Single fontEmSize, Int32 isSideways, Int32 isRightToLeft, ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, ref Char localeName, ref IntPtr features, ref UInt32 featureRangeLengths, UInt32 featureRanges, ref Single glyphAdvances, ref DWRITE_GLYPH_OFFSET glyphOffsets);
    public HRESULT GetGdiCompatibleGlyphPlacements(
        /// textString: (*(const WCHAR))
        ref Char textString
        /// clusterMap: (*(const UINT16))
        , ref UInt16 clusterMap
        /// textProps: (*(DWRITE_SHAPING_TEXT_PROPERTIES))
        , ref DWRITE_SHAPING_TEXT_PROPERTIES textProps
        /// textLength: (UINT32)
        , UInt32 textLength
        /// glyphIndices: (*(const UINT16))
        , ref UInt16 glyphIndices
        /// glyphProps: (*(const DWRITE_SHAPING_GLYPH_PROPERTIES))
        , ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps
        /// glyphCount: (UINT32)
        , UInt32 glyphCount
        /// fontFace: (*(IDWriteFontFace))
        , IntPtr fontFace
        /// fontEmSize: (FLOAT)
        , Single fontEmSize
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// transform: (*(const DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
        /// useGdiNatural: (BOOL)
        , Int32 useGdiNatural
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// scriptAnalysis: (*(const DWRITE_SCRIPT_ANALYSIS))
        , ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis
        /// localeName: (*(const WCHAR))
        , ref Char localeName
        /// features: (*(*(const DWRITE_TYPOGRAPHIC_FEATURES)))
        , ref IntPtr features
        /// featureRangeLengths: (*(const UINT32))
        , ref UInt32 featureRangeLengths
        /// featureRanges: (UINT32)
        , UInt32 featureRanges
        /// glyphAdvances: (*(FLOAT))
        , ref Single glyphAdvances
        /// glyphOffsets: (*(DWRITE_GLYPH_OFFSET))
        , ref DWRITE_GLYPH_OFFSET glyphOffsets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetGdiCompatibleGlyphPlacementsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGdiCompatibleGlyphPlacementsFunc));
        return callback(Self, ref textString, ref clusterMap, ref textProps, textLength, ref glyphIndices, ref glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, ref transform, useGdiNatural, isSideways, isRightToLeft, ref scriptAnalysis, ref localeName, ref features, ref featureRangeLengths, featureRanges, ref glyphAdvances, ref glyphOffsets);
    }
    delegate HRESULT GetGdiCompatibleGlyphPlacementsFunc(IntPtr self, ref Char textString, ref UInt16 clusterMap, ref DWRITE_SHAPING_TEXT_PROPERTIES textProps, UInt32 textLength, ref UInt16 glyphIndices, ref DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, UInt32 glyphCount, IntPtr fontFace, Single fontEmSize, Single pixelsPerDip, ref DWRITE_MATRIX transform, Int32 useGdiNatural, Int32 isSideways, Int32 isRightToLeft, ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, ref Char localeName, ref IntPtr features, ref UInt32 featureRangeLengths, UInt32 featureRanges, ref Single glyphAdvances, ref DWRITE_GLYPH_OFFSET glyphOffsets);
}
}
