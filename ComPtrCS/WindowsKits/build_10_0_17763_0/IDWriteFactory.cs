/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=21)]
public class IDWriteFactory : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteFactory>.Value;
    public HRESULT GetSystemFontCollection(
        /// fontCollection: (*(*(IDWriteFontCollection)))
        ref IntPtr fontCollection
        /// checkForUpdates: (BOOL)
        , Int32 checkForUpdates
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSystemFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSystemFontCollectionFunc));
        return callback(Self, ref fontCollection, checkForUpdates);
    }
    delegate HRESULT GetSystemFontCollectionFunc(IntPtr self, ref IntPtr fontCollection, Int32 checkForUpdates);
    public HRESULT CreateCustomFontCollection(
        /// collectionLoader: (*(IDWriteFontCollectionLoader))
        IntPtr collectionLoader
        /// collectionKey: (*(const void))
        , IntPtr collectionKey
        /// collectionKeySize: (UINT32)
        , UInt32 collectionKeySize
        /// fontCollection: (*(*(IDWriteFontCollection)))
        , ref IntPtr fontCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateCustomFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCustomFontCollectionFunc));
        return callback(Self, collectionLoader, collectionKey, collectionKeySize, ref fontCollection);
    }
    delegate HRESULT CreateCustomFontCollectionFunc(IntPtr self, IntPtr collectionLoader, IntPtr collectionKey, UInt32 collectionKeySize, ref IntPtr fontCollection);
    public HRESULT RegisterFontCollectionLoader(
        /// fontCollectionLoader: (*(IDWriteFontCollectionLoader))
        IntPtr fontCollectionLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (RegisterFontCollectionLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterFontCollectionLoaderFunc));
        return callback(Self, fontCollectionLoader);
    }
    delegate HRESULT RegisterFontCollectionLoaderFunc(IntPtr self, IntPtr fontCollectionLoader);
    public HRESULT UnregisterFontCollectionLoader(
        /// fontCollectionLoader: (*(IDWriteFontCollectionLoader))
        IntPtr fontCollectionLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (UnregisterFontCollectionLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterFontCollectionLoaderFunc));
        return callback(Self, fontCollectionLoader);
    }
    delegate HRESULT UnregisterFontCollectionLoaderFunc(IntPtr self, IntPtr fontCollectionLoader);
    public HRESULT CreateFontFileReference(
        /// filePath: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string filePath
        /// lastWriteTime: (*(const FILETIME))
        , ref FILETIME lastWriteTime
        /// fontFile: (*(*(IDWriteFontFile)))
        , ref IntPtr fontFile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateFontFileReferenceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFileReferenceFunc));
        return callback(Self, filePath, ref lastWriteTime, ref fontFile);
    }
    delegate HRESULT CreateFontFileReferenceFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string filePath, ref FILETIME lastWriteTime, ref IntPtr fontFile);
    public HRESULT CreateCustomFontFileReference(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// fontFileLoader: (*(IDWriteFontFileLoader))
        , IntPtr fontFileLoader
        /// fontFile: (*(*(IDWriteFontFile)))
        , ref IntPtr fontFile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateCustomFontFileReferenceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCustomFontFileReferenceFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, ref fontFile);
    }
    delegate HRESULT CreateCustomFontFileReferenceFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, IntPtr fontFileLoader, ref IntPtr fontFile);
    public HRESULT CreateFontFace(
        /// fontFaceType: (DWRITE_FONT_FACE_TYPE)
        DWRITE_FONT_FACE_TYPE fontFaceType
        /// numberOfFiles: (UINT32)
        , UInt32 numberOfFiles
        /// fontFiles: (*(const *(IDWriteFontFile)))
        , ref IntPtr fontFiles
        /// faceIndex: (UINT32)
        , UInt32 faceIndex
        /// fontFaceSimulationFlags: (DWRITE_FONT_SIMULATIONS)
        , DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags
        /// fontFace: (*(*(IDWriteFontFace)))
        , ref IntPtr fontFace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateFontFaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFaceFunc));
        return callback(Self, fontFaceType, numberOfFiles, ref fontFiles, faceIndex, fontFaceSimulationFlags, ref fontFace);
    }
    delegate HRESULT CreateFontFaceFunc(IntPtr self, DWRITE_FONT_FACE_TYPE fontFaceType, UInt32 numberOfFiles, ref IntPtr fontFiles, UInt32 faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, ref IntPtr fontFace);
    public HRESULT CreateRenderingParams(
        /// renderingParams: (*(*(IDWriteRenderingParams)))
        ref IntPtr renderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreateRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRenderingParamsFunc));
        return callback(Self, ref renderingParams);
    }
    delegate HRESULT CreateRenderingParamsFunc(IntPtr self, ref IntPtr renderingParams);
    public HRESULT CreateMonitorRenderingParams(
        /// monitor: (HMONITOR)
        IntPtr monitor
        /// renderingParams: (*(*(IDWriteRenderingParams)))
        , ref IntPtr renderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateMonitorRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateMonitorRenderingParamsFunc));
        return callback(Self, monitor, ref renderingParams);
    }
    delegate HRESULT CreateMonitorRenderingParamsFunc(IntPtr self, IntPtr monitor, ref IntPtr renderingParams);
    public HRESULT CreateCustomRenderingParams(
        /// gamma: (FLOAT)
        Single gamma
        /// enhancedContrast: (FLOAT)
        , Single enhancedContrast
        /// clearTypeLevel: (FLOAT)
        , Single clearTypeLevel
        /// pixelGeometry: (DWRITE_PIXEL_GEOMETRY)
        , DWRITE_PIXEL_GEOMETRY pixelGeometry
        /// renderingMode: (DWRITE_RENDERING_MODE)
        , DWRITE_RENDERING_MODE renderingMode
        /// renderingParams: (*(*(IDWriteRenderingParams)))
        , ref IntPtr renderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateCustomRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCustomRenderingParamsFunc));
        return callback(Self, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, ref renderingParams);
    }
    delegate HRESULT CreateCustomRenderingParamsFunc(IntPtr self, Single gamma, Single enhancedContrast, Single clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, ref IntPtr renderingParams);
    public HRESULT RegisterFontFileLoader(
        /// fontFileLoader: (*(IDWriteFontFileLoader))
        IntPtr fontFileLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (RegisterFontFileLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterFontFileLoaderFunc));
        return callback(Self, fontFileLoader);
    }
    delegate HRESULT RegisterFontFileLoaderFunc(IntPtr self, IntPtr fontFileLoader);
    public HRESULT UnregisterFontFileLoader(
        /// fontFileLoader: (*(IDWriteFontFileLoader))
        IntPtr fontFileLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (UnregisterFontFileLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterFontFileLoaderFunc));
        return callback(Self, fontFileLoader);
    }
    delegate HRESULT UnregisterFontFileLoaderFunc(IntPtr self, IntPtr fontFileLoader);
    public HRESULT CreateTextFormat(
        /// fontFamilyName: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string fontFamilyName
        /// fontCollection: (*(IDWriteFontCollection))
        , IntPtr fontCollection
        /// fontWeight: (DWRITE_FONT_WEIGHT)
        , DWRITE_FONT_WEIGHT fontWeight
        /// fontStyle: (DWRITE_FONT_STYLE)
        , DWRITE_FONT_STYLE fontStyle
        /// fontStretch: (DWRITE_FONT_STRETCH)
        , DWRITE_FONT_STRETCH fontStretch
        /// fontSize: (FLOAT)
        , Single fontSize
        /// localeName: (*(const WCHAR))
        , [MarshalAs(UnmanagedType.LPWStr)]string localeName
        /// textFormat: (*(*(IDWriteTextFormat)))
        , ref IntPtr textFormat
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (CreateTextFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTextFormatFunc));
        return callback(Self, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }
    delegate HRESULT CreateTextFormatFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string fontFamilyName, IntPtr fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, Single fontSize, [MarshalAs(UnmanagedType.LPWStr)]string localeName, ref IntPtr textFormat);
    public HRESULT CreateTypography(
        /// typography: (*(*(IDWriteTypography)))
        ref IntPtr typography
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (CreateTypographyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTypographyFunc));
        return callback(Self, ref typography);
    }
    delegate HRESULT CreateTypographyFunc(IntPtr self, ref IntPtr typography);
    public HRESULT GetGdiInterop(
        /// gdiInterop: (*(*(IDWriteGdiInterop)))
        ref IntPtr gdiInterop
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (GetGdiInteropFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGdiInteropFunc));
        return callback(Self, ref gdiInterop);
    }
    delegate HRESULT GetGdiInteropFunc(IntPtr self, ref IntPtr gdiInterop);
    public HRESULT CreateTextLayout(
        /// string: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string str
        /// stringLength: (UINT32)
        , UInt32 stringLength
        /// textFormat: (*(IDWriteTextFormat))
        , IntPtr textFormat
        /// maxWidth: (FLOAT)
        , Single maxWidth
        /// maxHeight: (FLOAT)
        , Single maxHeight
        /// textLayout: (*(*(IDWriteTextLayout)))
        , ref IntPtr textLayout
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (CreateTextLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTextLayoutFunc));
        return callback(Self, str, stringLength, textFormat, maxWidth, maxHeight, ref textLayout);
    }
    delegate HRESULT CreateTextLayoutFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string str, UInt32 stringLength, IntPtr textFormat, Single maxWidth, Single maxHeight, ref IntPtr textLayout);
    public HRESULT CreateGdiCompatibleTextLayout(
        /// string: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string str
        /// stringLength: (UINT32)
        , UInt32 stringLength
        /// textFormat: (*(IDWriteTextFormat))
        , IntPtr textFormat
        /// layoutWidth: (FLOAT)
        , Single layoutWidth
        /// layoutHeight: (FLOAT)
        , Single layoutHeight
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// transform: (*(const DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
        /// useGdiNatural: (BOOL)
        , Int32 useGdiNatural
        /// textLayout: (*(*(IDWriteTextLayout)))
        , ref IntPtr textLayout
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (CreateGdiCompatibleTextLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGdiCompatibleTextLayoutFunc));
        return callback(Self, str, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, ref transform, useGdiNatural, ref textLayout);
    }
    delegate HRESULT CreateGdiCompatibleTextLayoutFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string str, UInt32 stringLength, IntPtr textFormat, Single layoutWidth, Single layoutHeight, Single pixelsPerDip, ref DWRITE_MATRIX transform, Int32 useGdiNatural, ref IntPtr textLayout);
    public HRESULT CreateEllipsisTrimmingSign(
        /// textFormat: (*(IDWriteTextFormat))
        IntPtr textFormat
        /// trimmingSign: (*(*(IDWriteInlineObject)))
        , ref IntPtr trimmingSign
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (CreateEllipsisTrimmingSignFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateEllipsisTrimmingSignFunc));
        return callback(Self, textFormat, ref trimmingSign);
    }
    delegate HRESULT CreateEllipsisTrimmingSignFunc(IntPtr self, IntPtr textFormat, ref IntPtr trimmingSign);
    public HRESULT CreateTextAnalyzer(
        /// textAnalyzer: (*(*(IDWriteTextAnalyzer)))
        ref IntPtr textAnalyzer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (CreateTextAnalyzerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTextAnalyzerFunc));
        return callback(Self, ref textAnalyzer);
    }
    delegate HRESULT CreateTextAnalyzerFunc(IntPtr self, ref IntPtr textAnalyzer);
    public HRESULT CreateNumberSubstitution(
        /// substitutionMethod: (DWRITE_NUMBER_SUBSTITUTION_METHOD)
        DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod
        /// localeName: (*(const WCHAR))
        , [MarshalAs(UnmanagedType.LPWStr)]string localeName
        /// ignoreUserOverride: (BOOL)
        , Int32 ignoreUserOverride
        /// numberSubstitution: (*(*(IDWriteNumberSubstitution)))
        , ref IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (CreateNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateNumberSubstitutionFunc));
        return callback(Self, substitutionMethod, localeName, ignoreUserOverride, ref numberSubstitution);
    }
    delegate HRESULT CreateNumberSubstitutionFunc(IntPtr self, DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [MarshalAs(UnmanagedType.LPWStr)]string localeName, Int32 ignoreUserOverride, ref IntPtr numberSubstitution);
    public HRESULT CreateGlyphRunAnalysis(
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        ref DWRITE_GLYPH_RUN glyphRun
        /// pixelsPerDip: (FLOAT)
        , Single pixelsPerDip
        /// transform: (*(const DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
        /// renderingMode: (DWRITE_RENDERING_MODE)
        , DWRITE_RENDERING_MODE renderingMode
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// glyphRunAnalysis: (*(*(IDWriteGlyphRunAnalysis)))
        , ref IntPtr glyphRunAnalysis
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (CreateGlyphRunAnalysisFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGlyphRunAnalysisFunc));
        return callback(Self, ref glyphRun, pixelsPerDip, ref transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, ref glyphRunAnalysis);
    }
    delegate HRESULT CreateGlyphRunAnalysisFunc(IntPtr self, ref DWRITE_GLYPH_RUN glyphRun, Single pixelsPerDip, ref DWRITE_MATRIX transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, Single baselineOriginX, Single baselineOriginY, ref IntPtr glyphRunAnalysis);
}
}
