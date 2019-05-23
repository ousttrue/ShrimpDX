
    using System;
    using System.Runtime.InteropServices;
    using System.Numerics;

    namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DWRITE_FONT_FILE_TYPE {
    UNKNOWN = 0x00000000,
    CFF = 0x00000001,
    TRUETYPE = 0x00000002,
    OPENTYPE_COLLECTION = 0x00000003,
    TYPE1_PFM = 0x00000004,
    TYPE1_PFB = 0x00000005,
    VECTOR = 0x00000006,
    BITMAP = 0x00000007,
    TRUETYPE_COLLECTION = 0x00000003,
}

public enum DWRITE_FONT_FACE_TYPE {
    CFF = 0x00000000,
    TRUETYPE = 0x00000001,
    OPENTYPE_COLLECTION = 0x00000002,
    TYPE1 = 0x00000003,
    VECTOR = 0x00000004,
    BITMAP = 0x00000005,
    UNKNOWN = 0x00000006,
    RAW_CFF = 0x00000007,
    TRUETYPE_COLLECTION = 0x00000002,
}

public enum DWRITE_FONT_SIMULATIONS {
    NONE = 0x00000000,
    BOLD = 0x00000001,
    OBLIQUE = 0x00000002,
}

public enum DWRITE_FONT_WEIGHT {
    THIN = 0x00000064,
    EXTRA_LIGHT = 0x000000c8,
    ULTRA_LIGHT = 0x000000c8,
    LIGHT = 0x0000012c,
    SEMI_LIGHT = 0x0000015e,
    NORMAL = 0x00000190,
    REGULAR = 0x00000190,
    MEDIUM = 0x000001f4,
    DEMI_BOLD = 0x00000258,
    SEMI_BOLD = 0x00000258,
    BOLD = 0x000002bc,
    EXTRA_BOLD = 0x00000320,
    ULTRA_BOLD = 0x00000320,
    BLACK = 0x00000384,
    HEAVY = 0x00000384,
    EXTRA_BLACK = 0x000003b6,
    ULTRA_BLACK = 0x000003b6,
}

public enum DWRITE_FONT_STRETCH {
    UNDEFINED = 0x00000000,
    ULTRA_CONDENSED = 0x00000001,
    EXTRA_CONDENSED = 0x00000002,
    CONDENSED = 0x00000003,
    SEMI_CONDENSED = 0x00000004,
    NORMAL = 0x00000005,
    MEDIUM = 0x00000005,
    SEMI_EXPANDED = 0x00000006,
    EXPANDED = 0x00000007,
    EXTRA_EXPANDED = 0x00000008,
    ULTRA_EXPANDED = 0x00000009,
}

public enum DWRITE_FONT_STYLE {
    NORMAL = 0x00000000,
    OBLIQUE = 0x00000001,
    ITALIC = 0x00000002,
}

public enum DWRITE_INFORMATIONAL_STRING_ID {
    DWRITE_INFORMATIONAL_STRING_NONE = 0x00000000,
    DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE = 0x00000001,
    DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS = 0x00000002,
    DWRITE_INFORMATIONAL_STRING_TRADEMARK = 0x00000003,
    DWRITE_INFORMATIONAL_STRING_MANUFACTURER = 0x00000004,
    DWRITE_INFORMATIONAL_STRING_DESIGNER = 0x00000005,
    DWRITE_INFORMATIONAL_STRING_DESIGNER_URL = 0x00000006,
    DWRITE_INFORMATIONAL_STRING_DESCRIPTION = 0x00000007,
    DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL = 0x00000008,
    DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION = 0x00000009,
    DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL = 0x0000000a,
    DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES = 0x0000000b,
    DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES = 0x0000000c,
    DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES = 0x0000000d,
    DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES = 0x0000000e,
    DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT = 0x0000000f,
    DWRITE_INFORMATIONAL_STRING_FULL_NAME = 0x00000010,
    DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME = 0x00000011,
    DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME = 0x00000012,
    DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME = 0x00000013,
    DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG = 0x00000014,
    DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG = 0x00000015,
    DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES = 0x0000000d,
    DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES = 0x0000000e,
    DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME = 0x00000013,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_FONT_METRICS{
    /// (UINT16)
    public UInt16 designUnitsPerEm;

    /// (UINT16)
    public UInt16 ascent;

    /// (UINT16)
    public UInt16 descent;

    /// (INT16)
    public Int16 lineGap;

    /// (UINT16)
    public UInt16 capHeight;

    /// (UINT16)
    public UInt16 xHeight;

    /// (INT16)
    public Int16 underlinePosition;

    /// (UINT16)
    public UInt16 underlineThickness;

    /// (INT16)
    public Int16 strikethroughPosition;

    /// (UINT16)
    public UInt16 strikethroughThickness;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_METRICS{
    /// (INT32)
    public Int32 leftSideBearing;

    /// (UINT32)
    public UInt32 advanceWidth;

    /// (INT32)
    public Int32 rightSideBearing;

    /// (INT32)
    public Int32 topSideBearing;

    /// (UINT32)
    public UInt32 advanceHeight;

    /// (INT32)
    public Int32 bottomSideBearing;

    /// (INT32)
    public Int32 verticalOriginY;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_OFFSET{
    /// (FLOAT)
    public Single advanceOffset;

    /// (FLOAT)
    public Single ascenderOffset;

}

public enum DWRITE_FACTORY_TYPE {
    SHARED = 0x00000000,
    ISOLATED = 0x00000001,
}

public class IDWriteFontFileLoader : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<IDWriteFontFileLoader>.Value;
    public HRESULT CreateStreamFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// fontFileStream: (*(*(IDWriteFontFileStream)))
        , ref IntPtr fontFileStream
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateStreamFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStreamFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileStream);
    }
    delegate HRESULT CreateStreamFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref IntPtr fontFileStream);
}

public class IDWriteLocalFontFileLoader: IDWriteFontFileLoader {

    static /*readonly*/ Guid s_uuid = new Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteLocalFontFileLoader>.Value;
    public HRESULT GetFilePathLengthFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// filePathLength: (*(UINT32))
        , ref UInt32 filePathLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFilePathLengthFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathLengthFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref filePathLength);
    }
    delegate HRESULT GetFilePathLengthFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref UInt32 filePathLength);
    public HRESULT GetFilePathFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// filePath: (*(WCHAR))
        , ref Char filePath
        /// filePathSize: (UINT32)
        , UInt32 filePathSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFilePathFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref filePath, filePathSize);
    }
    delegate HRESULT GetFilePathFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref Char filePath, UInt32 filePathSize);
    public HRESULT GetLastWriteTimeFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// lastWriteTime: (*(FILETIME))
        , ref FILETIME lastWriteTime
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetLastWriteTimeFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref lastWriteTime);
    }
    delegate HRESULT GetLastWriteTimeFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref FILETIME lastWriteTime);
}

public class IDWriteFontFileStream : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDWriteFontFileStream>.Value;
    public HRESULT ReadFileFragment(
        /// fragmentStart: (*(*(const void)))
        ref IntPtr fragmentStart
        /// fileOffset: (UINT64)
        , UInt64 fileOffset
        /// fragmentSize: (UINT64)
        , UInt64 fragmentSize
        /// fragmentContext: (*(*(void)))
        , ref IntPtr fragmentContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ReadFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFileFragmentFunc));
        return callback(Self, ref fragmentStart, fileOffset, fragmentSize, ref fragmentContext);
    }
    delegate HRESULT ReadFileFragmentFunc(IntPtr self, ref IntPtr fragmentStart, UInt64 fileOffset, UInt64 fragmentSize, ref IntPtr fragmentContext);
    public void ReleaseFileFragment(
        /// fragmentContext: (*(void))
        IntPtr fragmentContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFileFragmentFunc));
        callback(Self, fragmentContext);
    }
    delegate void ReleaseFileFragmentFunc(IntPtr self, IntPtr fragmentContext);
    public HRESULT GetFileSize(
        /// fileSize: (*(UINT64))
        ref UInt64 fileSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFileSizeFunc));
        return callback(Self, ref fileSize);
    }
    delegate HRESULT GetFileSizeFunc(IntPtr self, ref UInt64 fileSize);
    public HRESULT GetLastWriteTime(
        /// lastWriteTime: (*(UINT64))
        ref UInt64 lastWriteTime
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLastWriteTimeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFunc));
        return callback(Self, ref lastWriteTime);
    }
    delegate HRESULT GetLastWriteTimeFunc(IntPtr self, ref UInt64 lastWriteTime);
}

public class IDWriteFontFile : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteFontFile>.Value;
    public HRESULT GetReferenceKey(
        /// fontFileReferenceKey: (*(*(const void)))
        ref IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (*(UINT32))
        , ref UInt32 fontFileReferenceKeySize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetReferenceKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetReferenceKeyFunc));
        return callback(Self, ref fontFileReferenceKey, ref fontFileReferenceKeySize);
    }
    delegate HRESULT GetReferenceKeyFunc(IntPtr self, ref IntPtr fontFileReferenceKey, ref UInt32 fontFileReferenceKeySize);
    public HRESULT GetLoader(
        /// fontFileLoader: (*(*(IDWriteFontFileLoader)))
        ref IntPtr fontFileLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLoaderFunc));
        return callback(Self, ref fontFileLoader);
    }
    delegate HRESULT GetLoaderFunc(IntPtr self, ref IntPtr fontFileLoader);
    public HRESULT Analyze(
        /// isSupportedFontType: (*(BOOL))
        IntPtr isSupportedFontType
        /// fontFileType: (*(DWRITE_FONT_FILE_TYPE))
        , ref DWRITE_FONT_FILE_TYPE fontFileType
        /// fontFaceType: (*(DWRITE_FONT_FACE_TYPE))
        , ref DWRITE_FONT_FACE_TYPE fontFaceType
        /// numberOfFaces: (*(UINT32))
        , ref UInt32 numberOfFaces
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (AnalyzeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeFunc));
        return callback(Self, isSupportedFontType, ref fontFileType, ref fontFaceType, ref numberOfFaces);
    }
    delegate HRESULT AnalyzeFunc(IntPtr self, IntPtr isSupportedFontType, ref DWRITE_FONT_FILE_TYPE fontFileType, ref DWRITE_FONT_FACE_TYPE fontFaceType, ref UInt32 numberOfFaces);
}

public enum DWRITE_PIXEL_GEOMETRY {
    FLAT = 0x00000000,
    RGB = 0x00000001,
    BGR = 0x00000002,
}

public enum DWRITE_RENDERING_MODE {
    DEFAULT = 0x00000000,
    ALIASED = 0x00000001,
    GDI_CLASSIC = 0x00000002,
    GDI_NATURAL = 0x00000003,
    NATURAL = 0x00000004,
    NATURAL_SYMMETRIC = 0x00000005,
    OUTLINE = 0x00000006,
    CLEARTYPE_GDI_CLASSIC = 0x00000002,
    CLEARTYPE_GDI_NATURAL = 0x00000003,
    CLEARTYPE_NATURAL = 0x00000004,
    CLEARTYPE_NATURAL_SYMMETRIC = 0x00000005,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_MATRIX{
    /// (FLOAT)
    public Single m11;

    /// (FLOAT)
    public Single m12;

    /// (FLOAT)
    public Single m21;

    /// (FLOAT)
    public Single m22;

    /// (FLOAT)
    public Single dx;

    /// (FLOAT)
    public Single dy;

}

public class IDWriteRenderingParams : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<IDWriteRenderingParams>.Value;
    public Single GetGamma(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGammaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaFunc));
        return callback(Self);
    }
    delegate Single GetGammaFunc(IntPtr self);
    public Single GetEnhancedContrast(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetEnhancedContrastFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEnhancedContrastFunc));
        return callback(Self);
    }
    delegate Single GetEnhancedContrastFunc(IntPtr self);
    public Single GetClearTypeLevel(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetClearTypeLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClearTypeLevelFunc));
        return callback(Self);
    }
    delegate Single GetClearTypeLevelFunc(IntPtr self);
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetPixelGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelGeometryFunc));
        return callback(Self);
    }
    delegate DWRITE_PIXEL_GEOMETRY GetPixelGeometryFunc(IntPtr self);
    public DWRITE_RENDERING_MODE GetRenderingMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetRenderingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRenderingModeFunc));
        return callback(Self);
    }
    delegate DWRITE_RENDERING_MODE GetRenderingModeFunc(IntPtr self);
}

public class IDWriteFontFace : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5f49804d-7024-4d43-bfa9-d25984f53849");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 15;
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

public class IDWriteFontCollectionLoader : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<IDWriteFontCollectionLoader>.Value;
    public HRESULT CreateEnumeratorFromKey(
        /// factory: (*(IDWriteFactory))
        IntPtr factory
        /// collectionKey: (*(const void))
        , IntPtr collectionKey
        /// collectionKeySize: (UINT32)
        , UInt32 collectionKeySize
        /// fontFileEnumerator: (*(*(IDWriteFontFileEnumerator)))
        , ref IntPtr fontFileEnumerator
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateEnumeratorFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateEnumeratorFromKeyFunc));
        return callback(Self, factory, collectionKey, collectionKeySize, ref fontFileEnumerator);
    }
    delegate HRESULT CreateEnumeratorFromKeyFunc(IntPtr self, IntPtr factory, IntPtr collectionKey, UInt32 collectionKeySize, ref IntPtr fontFileEnumerator);
}

public class IDWriteFontFileEnumerator : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("72755049-5ff7-435d-8348-4be97cfa6c7c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<IDWriteFontFileEnumerator>.Value;
    public HRESULT MoveNext(
        /// hasCurrentFile: (*(BOOL))
        IntPtr hasCurrentFile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (MoveNextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MoveNextFunc));
        return callback(Self, hasCurrentFile);
    }
    delegate HRESULT MoveNextFunc(IntPtr self, IntPtr hasCurrentFile);
    public HRESULT GetCurrentFontFile(
        /// fontFile: (*(*(IDWriteFontFile)))
        ref IntPtr fontFile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetCurrentFontFileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentFontFileFunc));
        return callback(Self, ref fontFile);
    }
    delegate HRESULT GetCurrentFontFileFunc(IntPtr self, ref IntPtr fontFile);
}

public class IDWriteLocalizedStrings : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("08256209-099a-4b34-b86d-c22b110e7771");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 6;
    int VTableIndexBase => VTableIndexBase<IDWriteLocalizedStrings>.Value;
    public UInt32 GetCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetCountFunc(IntPtr self);
    public HRESULT FindLocaleName(
        /// localeName: (*(const WCHAR))
        ref Char localeName
        /// index: (*(UINT32))
        , ref UInt32 index
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (FindLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindLocaleNameFunc));
        return callback(Self, ref localeName, ref index, exists);
    }
    delegate HRESULT FindLocaleNameFunc(IntPtr self, ref Char localeName, ref UInt32 index, IntPtr exists);
    public HRESULT GetLocaleNameLength(
        /// index: (UINT32)
        UInt32 index
        /// length: (*(UINT32))
        , ref UInt32 length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetLocaleNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameLengthFunc));
        return callback(Self, index, ref length);
    }
    delegate HRESULT GetLocaleNameLengthFunc(IntPtr self, UInt32 index, ref UInt32 length);
    public HRESULT GetLocaleName(
        /// index: (UINT32)
        UInt32 index
        /// localeName: (*(WCHAR))
        , ref Char localeName
        /// size: (UINT32)
        , UInt32 size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, index, ref localeName, size);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, UInt32 index, ref Char localeName, UInt32 size);
    public HRESULT GetStringLength(
        /// index: (UINT32)
        UInt32 index
        /// length: (*(UINT32))
        , ref UInt32 length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetStringLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringLengthFunc));
        return callback(Self, index, ref length);
    }
    delegate HRESULT GetStringLengthFunc(IntPtr self, UInt32 index, ref UInt32 length);
    public HRESULT GetString(
        /// index: (UINT32)
        UInt32 index
        /// stringBuffer: (*(WCHAR))
        , ref Char stringBuffer
        /// size: (UINT32)
        , UInt32 size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringFunc));
        return callback(Self, index, ref stringBuffer, size);
    }
    delegate HRESULT GetStringFunc(IntPtr self, UInt32 index, ref Char stringBuffer, UInt32 size);
}

public class IDWriteFontCollection : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDWriteFontCollection>.Value;
    public UInt32 GetFontFamilyCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFontFamilyCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontFamilyCountFunc(IntPtr self);
    public HRESULT GetFontFamily(
        /// index: (UINT32)
        UInt32 index
        /// fontFamily: (*(*(IDWriteFontFamily)))
        , ref IntPtr fontFamily
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFontFamilyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyFunc));
        return callback(Self, index, ref fontFamily);
    }
    delegate HRESULT GetFontFamilyFunc(IntPtr self, UInt32 index, ref IntPtr fontFamily);
    public HRESULT FindFamilyName(
        /// familyName: (*(const WCHAR))
        ref Char familyName
        /// index: (*(UINT32))
        , ref UInt32 index
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (FindFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindFamilyNameFunc));
        return callback(Self, ref familyName, ref index, exists);
    }
    delegate HRESULT FindFamilyNameFunc(IntPtr self, ref Char familyName, ref UInt32 index, IntPtr exists);
    public HRESULT GetFontFromFontFace(
        /// fontFace: (*(IDWriteFontFace))
        IntPtr fontFace
        /// font: (*(*(IDWriteFont)))
        , ref IntPtr font
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFontFromFontFaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFromFontFaceFunc));
        return callback(Self, fontFace, ref font);
    }
    delegate HRESULT GetFontFromFontFaceFunc(IntPtr self, IntPtr fontFace, ref IntPtr font);
}

public class IDWriteFontList : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("1a0d8438-1d97-4ec1-aef9-a2fb86ed6acb");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteFontList>.Value;
    public HRESULT GetFontCollection(
        /// fontCollection: (*(*(IDWriteFontCollection)))
        ref IntPtr fontCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontCollectionFunc));
        return callback(Self, ref fontCollection);
    }
    delegate HRESULT GetFontCollectionFunc(IntPtr self, ref IntPtr fontCollection);
    public UInt32 GetFontCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFontCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontCountFunc(IntPtr self);
    public HRESULT GetFont(
        /// index: (UINT32)
        UInt32 index
        /// font: (*(*(IDWriteFont)))
        , ref IntPtr font
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFontFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFunc));
        return callback(Self, index, ref font);
    }
    delegate HRESULT GetFontFunc(IntPtr self, UInt32 index, ref IntPtr font);
}

public class IDWriteFontFamily: IDWriteFontList {

    static /*readonly*/ Guid s_uuid = new Guid("da20d8ef-812a-4c43-9802-62ec4abd7add");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteFontFamily>.Value;
    public HRESULT GetFamilyNames(
        /// names: (*(*(IDWriteLocalizedStrings)))
        ref IntPtr names
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFamilyNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFamilyNamesFunc));
        return callback(Self, ref names);
    }
    delegate HRESULT GetFamilyNamesFunc(IntPtr self, ref IntPtr names);
    public HRESULT GetFirstMatchingFont(
        /// weight: (DWRITE_FONT_WEIGHT)
        DWRITE_FONT_WEIGHT weight
        /// stretch: (DWRITE_FONT_STRETCH)
        , DWRITE_FONT_STRETCH stretch
        /// style: (DWRITE_FONT_STYLE)
        , DWRITE_FONT_STYLE style
        /// matchingFont: (*(*(IDWriteFont)))
        , ref IntPtr matchingFont
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFirstMatchingFontFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFirstMatchingFontFunc));
        return callback(Self, weight, stretch, style, ref matchingFont);
    }
    delegate HRESULT GetFirstMatchingFontFunc(IntPtr self, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, ref IntPtr matchingFont);
    public HRESULT GetMatchingFonts(
        /// weight: (DWRITE_FONT_WEIGHT)
        DWRITE_FONT_WEIGHT weight
        /// stretch: (DWRITE_FONT_STRETCH)
        , DWRITE_FONT_STRETCH stretch
        /// style: (DWRITE_FONT_STYLE)
        , DWRITE_FONT_STYLE style
        /// matchingFonts: (*(*(IDWriteFontList)))
        , ref IntPtr matchingFonts
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetMatchingFontsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMatchingFontsFunc));
        return callback(Self, weight, stretch, style, ref matchingFonts);
    }
    delegate HRESULT GetMatchingFontsFunc(IntPtr self, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, ref IntPtr matchingFonts);
}

public class IDWriteFont : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 11;
    int VTableIndexBase => VTableIndexBase<IDWriteFont>.Value;
    public HRESULT GetFontFamily(
        /// fontFamily: (*(*(IDWriteFontFamily)))
        ref IntPtr fontFamily
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFontFamilyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyFunc));
        return callback(Self, ref fontFamily);
    }
    delegate HRESULT GetFontFamilyFunc(IntPtr self, ref IntPtr fontFamily);
    public DWRITE_FONT_WEIGHT GetWeight(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetWeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWeightFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_WEIGHT GetWeightFunc(IntPtr self);
    public DWRITE_FONT_STRETCH GetStretch(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetStretchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStretchFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_STRETCH GetStretchFunc(IntPtr self);
    public DWRITE_FONT_STYLE GetStyle(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStyleFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_STYLE GetStyleFunc(IntPtr self);
    public Int32 IsSymbolFont(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (IsSymbolFontFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsSymbolFontFunc));
        return callback(Self);
    }
    delegate Int32 IsSymbolFontFunc(IntPtr self);
    public HRESULT GetFaceNames(
        /// names: (*(*(IDWriteLocalizedStrings)))
        ref IntPtr names
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetFaceNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFaceNamesFunc));
        return callback(Self, ref names);
    }
    delegate HRESULT GetFaceNamesFunc(IntPtr self, ref IntPtr names);
    public HRESULT GetInformationalStrings(
        /// informationalStringID: (DWRITE_INFORMATIONAL_STRING_ID)
        DWRITE_INFORMATIONAL_STRING_ID informationalStringID
        /// informationalStrings: (*(*(IDWriteLocalizedStrings)))
        , ref IntPtr informationalStrings
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetInformationalStringsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInformationalStringsFunc));
        return callback(Self, informationalStringID, ref informationalStrings, exists);
    }
    delegate HRESULT GetInformationalStringsFunc(IntPtr self, DWRITE_INFORMATIONAL_STRING_ID informationalStringID, ref IntPtr informationalStrings, IntPtr exists);
    public DWRITE_FONT_SIMULATIONS GetSimulations(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetSimulationsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSimulationsFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_SIMULATIONS GetSimulationsFunc(IntPtr self);
    public void GetMetrics(
        /// fontMetrics: (*(DWRITE_FONT_METRICS))
        ref DWRITE_FONT_METRICS fontMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetricsFunc));
        callback(Self, ref fontMetrics);
    }
    delegate void GetMetricsFunc(IntPtr self, ref DWRITE_FONT_METRICS fontMetrics);
    public HRESULT HasCharacter(
        /// unicodeValue: (UINT32)
        UInt32 unicodeValue
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (HasCharacterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HasCharacterFunc));
        return callback(Self, unicodeValue, exists);
    }
    delegate HRESULT HasCharacterFunc(IntPtr self, UInt32 unicodeValue, IntPtr exists);
    public HRESULT CreateFontFace(
        /// fontFace: (*(*(IDWriteFontFace)))
        ref IntPtr fontFace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateFontFaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFaceFunc));
        return callback(Self, ref fontFace);
    }
    delegate HRESULT CreateFontFaceFunc(IntPtr self, ref IntPtr fontFace);
}

public enum DWRITE_READING_DIRECTION {
    LEFT_TO_RIGHT = 0x00000000,
    RIGHT_TO_LEFT = 0x00000001,
    TOP_TO_BOTTOM = 0x00000002,
    BOTTOM_TO_TOP = 0x00000003,
}

public enum DWRITE_FLOW_DIRECTION {
    TOP_TO_BOTTOM = 0x00000000,
    BOTTOM_TO_TOP = 0x00000001,
    LEFT_TO_RIGHT = 0x00000002,
    RIGHT_TO_LEFT = 0x00000003,
}

public enum DWRITE_TEXT_ALIGNMENT {
    LEADING = 0x00000000,
    TRAILING = 0x00000001,
    CENTER = 0x00000002,
    JUSTIFIED = 0x00000003,
}

public enum DWRITE_PARAGRAPH_ALIGNMENT {
    NEAR = 0x00000000,
    FAR = 0x00000001,
    CENTER = 0x00000002,
}

public enum DWRITE_WORD_WRAPPING {
    WRAP = 0x00000000,
    NO_WRAP = 0x00000001,
    EMERGENCY_BREAK = 0x00000002,
    WHOLE_WORD = 0x00000003,
    CHARACTER = 0x00000004,
}

public enum DWRITE_LINE_SPACING_METHOD {
    DEFAULT = 0x00000000,
    UNIFORM = 0x00000001,
    PROPORTIONAL = 0x00000002,
}

public enum DWRITE_TRIMMING_GRANULARITY {
    NONE = 0x00000000,
    CHARACTER = 0x00000001,
    WORD = 0x00000002,
}

public enum DWRITE_FONT_FEATURE_TAG {
    ALTERNATIVE_FRACTIONS = 0x63726661,
    PETITE_CAPITALS_FROM_CAPITALS = 0x63703263,
    SMALL_CAPITALS_FROM_CAPITALS = 0x63733263,
    CONTEXTUAL_ALTERNATES = 0x746c6163,
    CASE_SENSITIVE_FORMS = 0x65736163,
    GLYPH_COMPOSITION_DECOMPOSITION = 0x706d6363,
    CONTEXTUAL_LIGATURES = 0x67696c63,
    CAPITAL_SPACING = 0x70737063,
    CONTEXTUAL_SWASH = 0x68777363,
    CURSIVE_POSITIONING = 0x73727563,
    DEFAULT = 0x746c6664,
    DISCRETIONARY_LIGATURES = 0x67696c64,
    EXPERT_FORMS = 0x74707865,
    FRACTIONS = 0x63617266,
    FULL_WIDTH = 0x64697766,
    HALF_FORMS = 0x666c6168,
    HALANT_FORMS = 0x6e6c6168,
    ALTERNATE_HALF_WIDTH = 0x746c6168,
    HISTORICAL_FORMS = 0x74736968,
    HORIZONTAL_KANA_ALTERNATES = 0x616e6b68,
    HISTORICAL_LIGATURES = 0x67696c68,
    HALF_WIDTH = 0x64697768,
    HOJO_KANJI_FORMS = 0x6f6a6f68,
    JIS04_FORMS = 0x3430706a,
    JIS78_FORMS = 0x3837706a,
    JIS83_FORMS = 0x3338706a,
    JIS90_FORMS = 0x3039706a,
    KERNING = 0x6e72656b,
    STANDARD_LIGATURES = 0x6167696c,
    LINING_FIGURES = 0x6d756e6c,
    LOCALIZED_FORMS = 0x6c636f6c,
    MARK_POSITIONING = 0x6b72616d,
    MATHEMATICAL_GREEK = 0x6b72676d,
    MARK_TO_MARK_POSITIONING = 0x6b6d6b6d,
    ALTERNATE_ANNOTATION_FORMS = 0x746c616e,
    NLC_KANJI_FORMS = 0x6b636c6e,
    OLD_STYLE_FIGURES = 0x6d756e6f,
    ORDINALS = 0x6e64726f,
    PROPORTIONAL_ALTERNATE_WIDTH = 0x746c6170,
    PETITE_CAPITALS = 0x70616370,
    PROPORTIONAL_FIGURES = 0x6d756e70,
    PROPORTIONAL_WIDTHS = 0x64697770,
    QUARTER_WIDTHS = 0x64697771,
    REQUIRED_LIGATURES = 0x67696c72,
    RUBY_NOTATION_FORMS = 0x79627572,
    STYLISTIC_ALTERNATES = 0x746c6173,
    SCIENTIFIC_INFERIORS = 0x666e6973,
    SMALL_CAPITALS = 0x70636d73,
    SIMPLIFIED_FORMS = 0x6c706d73,
    STYLISTIC_SET_1 = 0x31307373,
    STYLISTIC_SET_2 = 0x32307373,
    STYLISTIC_SET_3 = 0x33307373,
    STYLISTIC_SET_4 = 0x34307373,
    STYLISTIC_SET_5 = 0x35307373,
    STYLISTIC_SET_6 = 0x36307373,
    STYLISTIC_SET_7 = 0x37307373,
    STYLISTIC_SET_8 = 0x38307373,
    STYLISTIC_SET_9 = 0x39307373,
    STYLISTIC_SET_10 = 0x30317373,
    STYLISTIC_SET_11 = 0x31317373,
    STYLISTIC_SET_12 = 0x32317373,
    STYLISTIC_SET_13 = 0x33317373,
    STYLISTIC_SET_14 = 0x34317373,
    STYLISTIC_SET_15 = 0x35317373,
    STYLISTIC_SET_16 = 0x36317373,
    STYLISTIC_SET_17 = 0x37317373,
    STYLISTIC_SET_18 = 0x38317373,
    STYLISTIC_SET_19 = 0x39317373,
    STYLISTIC_SET_20 = 0x30327373,
    SUBSCRIPT = 0x73627573,
    SUPERSCRIPT = 0x73707573,
    SWASH = 0x68737773,
    TITLING = 0x6c746974,
    TRADITIONAL_NAME_FORMS = 0x6d616e74,
    TABULAR_FIGURES = 0x6d756e74,
    TRADITIONAL_FORMS = 0x64617274,
    THIRD_WIDTHS = 0x64697774,
    UNICASE = 0x63696e75,
    VERTICAL_WRITING = 0x74726576,
    VERTICAL_ALTERNATES_AND_ROTATION = 0x32747276,
    SLASHED_ZERO = 0x6f72657a,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TEXT_RANGE{
    /// (UINT32)
    public UInt32 startPosition;

    /// (UINT32)
    public UInt32 length;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_FONT_FEATURE{
    /// (DWRITE_FONT_FEATURE_TAG)
    public DWRITE_FONT_FEATURE_TAG nameTag;

    /// (UINT32)
    public UInt32 parameter;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TYPOGRAPHIC_FEATURES{
    /// (*(DWRITE_FONT_FEATURE))
    public IntPtr features;

    /// (UINT32)
    public UInt32 featureCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TRIMMING{
    /// (DWRITE_TRIMMING_GRANULARITY)
    public DWRITE_TRIMMING_GRANULARITY granularity;

    /// (UINT32)
    public UInt32 delimiter;

    /// (UINT32)
    public UInt32 delimiterCount;

}

public class IDWriteTextFormat : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("9c906818-31d7-4fd3-a151-7c5e225db55a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 25;
    int VTableIndexBase => VTableIndexBase<IDWriteTextFormat>.Value;
    public HRESULT SetTextAlignment(
        /// textAlignment: (DWRITE_TEXT_ALIGNMENT)
        DWRITE_TEXT_ALIGNMENT textAlignment
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetTextAlignmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextAlignmentFunc));
        return callback(Self, textAlignment);
    }
    delegate HRESULT SetTextAlignmentFunc(IntPtr self, DWRITE_TEXT_ALIGNMENT textAlignment);
    public HRESULT SetParagraphAlignment(
        /// paragraphAlignment: (DWRITE_PARAGRAPH_ALIGNMENT)
        DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetParagraphAlignmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetParagraphAlignmentFunc));
        return callback(Self, paragraphAlignment);
    }
    delegate HRESULT SetParagraphAlignmentFunc(IntPtr self, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);
    public HRESULT SetWordWrapping(
        /// wordWrapping: (DWRITE_WORD_WRAPPING)
        DWRITE_WORD_WRAPPING wordWrapping
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetWordWrappingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetWordWrappingFunc));
        return callback(Self, wordWrapping);
    }
    delegate HRESULT SetWordWrappingFunc(IntPtr self, DWRITE_WORD_WRAPPING wordWrapping);
    public HRESULT SetReadingDirection(
        /// readingDirection: (DWRITE_READING_DIRECTION)
        DWRITE_READING_DIRECTION readingDirection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetReadingDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetReadingDirectionFunc));
        return callback(Self, readingDirection);
    }
    delegate HRESULT SetReadingDirectionFunc(IntPtr self, DWRITE_READING_DIRECTION readingDirection);
    public HRESULT SetFlowDirection(
        /// flowDirection: (DWRITE_FLOW_DIRECTION)
        DWRITE_FLOW_DIRECTION flowDirection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SetFlowDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFlowDirectionFunc));
        return callback(Self, flowDirection);
    }
    delegate HRESULT SetFlowDirectionFunc(IntPtr self, DWRITE_FLOW_DIRECTION flowDirection);
    public HRESULT SetIncrementalTabStop(
        /// incrementalTabStop: (FLOAT)
        Single incrementalTabStop
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetIncrementalTabStopFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIncrementalTabStopFunc));
        return callback(Self, incrementalTabStop);
    }
    delegate HRESULT SetIncrementalTabStopFunc(IntPtr self, Single incrementalTabStop);
    public HRESULT SetTrimming(
        /// trimmingOptions: (*(const DWRITE_TRIMMING))
        ref DWRITE_TRIMMING trimmingOptions
        /// trimmingSign: (*(IDWriteInlineObject))
        , IntPtr trimmingSign
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (SetTrimmingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTrimmingFunc));
        return callback(Self, ref trimmingOptions, trimmingSign);
    }
    delegate HRESULT SetTrimmingFunc(IntPtr self, ref DWRITE_TRIMMING trimmingOptions, IntPtr trimmingSign);
    public HRESULT SetLineSpacing(
        /// lineSpacingMethod: (DWRITE_LINE_SPACING_METHOD)
        DWRITE_LINE_SPACING_METHOD lineSpacingMethod
        /// lineSpacing: (FLOAT)
        , Single lineSpacing
        /// baseline: (FLOAT)
        , Single baseline
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetLineSpacingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLineSpacingFunc));
        return callback(Self, lineSpacingMethod, lineSpacing, baseline);
    }
    delegate HRESULT SetLineSpacingFunc(IntPtr self, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, Single lineSpacing, Single baseline);
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetTextAlignmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextAlignmentFunc));
        return callback(Self);
    }
    delegate DWRITE_TEXT_ALIGNMENT GetTextAlignmentFunc(IntPtr self);
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetParagraphAlignmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParagraphAlignmentFunc));
        return callback(Self);
    }
    delegate DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignmentFunc(IntPtr self);
    public DWRITE_WORD_WRAPPING GetWordWrapping(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetWordWrappingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWordWrappingFunc));
        return callback(Self);
    }
    delegate DWRITE_WORD_WRAPPING GetWordWrappingFunc(IntPtr self);
    public DWRITE_READING_DIRECTION GetReadingDirection(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (GetReadingDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetReadingDirectionFunc));
        return callback(Self);
    }
    delegate DWRITE_READING_DIRECTION GetReadingDirectionFunc(IntPtr self);
    public DWRITE_FLOW_DIRECTION GetFlowDirection(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (GetFlowDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFlowDirectionFunc));
        return callback(Self);
    }
    delegate DWRITE_FLOW_DIRECTION GetFlowDirectionFunc(IntPtr self);
    public Single GetIncrementalTabStop(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (GetIncrementalTabStopFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIncrementalTabStopFunc));
        return callback(Self);
    }
    delegate Single GetIncrementalTabStopFunc(IntPtr self);
    public HRESULT GetTrimming(
        /// trimmingOptions: (*(DWRITE_TRIMMING))
        ref DWRITE_TRIMMING trimmingOptions
        /// trimmingSign: (*(*(IDWriteInlineObject)))
        , ref IntPtr trimmingSign
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (GetTrimmingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTrimmingFunc));
        return callback(Self, ref trimmingOptions, ref trimmingSign);
    }
    delegate HRESULT GetTrimmingFunc(IntPtr self, ref DWRITE_TRIMMING trimmingOptions, ref IntPtr trimmingSign);
    public HRESULT GetLineSpacing(
        /// lineSpacingMethod: (*(DWRITE_LINE_SPACING_METHOD))
        ref DWRITE_LINE_SPACING_METHOD lineSpacingMethod
        /// lineSpacing: (*(FLOAT))
        , ref Single lineSpacing
        /// baseline: (*(FLOAT))
        , ref Single baseline
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (GetLineSpacingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLineSpacingFunc));
        return callback(Self, ref lineSpacingMethod, ref lineSpacing, ref baseline);
    }
    delegate HRESULT GetLineSpacingFunc(IntPtr self, ref DWRITE_LINE_SPACING_METHOD lineSpacingMethod, ref Single lineSpacing, ref Single baseline);
    public HRESULT GetFontCollection(
        /// fontCollection: (*(*(IDWriteFontCollection)))
        ref IntPtr fontCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (GetFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontCollectionFunc));
        return callback(Self, ref fontCollection);
    }
    delegate HRESULT GetFontCollectionFunc(IntPtr self, ref IntPtr fontCollection);
    public UInt32 GetFontFamilyNameLength(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (GetFontFamilyNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyNameLengthFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontFamilyNameLengthFunc(IntPtr self);
    public HRESULT GetFontFamilyName(
        /// fontFamilyName: (*(WCHAR))
        ref Char fontFamilyName
        /// nameSize: (UINT32)
        , UInt32 nameSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (GetFontFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyNameFunc));
        return callback(Self, ref fontFamilyName, nameSize);
    }
    delegate HRESULT GetFontFamilyNameFunc(IntPtr self, ref Char fontFamilyName, UInt32 nameSize);
    public DWRITE_FONT_WEIGHT GetFontWeight(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (GetFontWeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontWeightFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_WEIGHT GetFontWeightFunc(IntPtr self);
    public DWRITE_FONT_STYLE GetFontStyle(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (GetFontStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontStyleFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_STYLE GetFontStyleFunc(IntPtr self);
    public DWRITE_FONT_STRETCH GetFontStretch(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (GetFontStretchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontStretchFunc));
        return callback(Self);
    }
    delegate DWRITE_FONT_STRETCH GetFontStretchFunc(IntPtr self);
    public Single GetFontSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (GetFontSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontSizeFunc));
        return callback(Self);
    }
    delegate Single GetFontSizeFunc(IntPtr self);
    public UInt32 GetLocaleNameLength(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (GetLocaleNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameLengthFunc));
        return callback(Self);
    }
    delegate UInt32 GetLocaleNameLengthFunc(IntPtr self);
    public HRESULT GetLocaleName(
        /// localeName: (*(WCHAR))
        ref Char localeName
        /// nameSize: (UINT32)
        , UInt32 nameSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, ref localeName, nameSize);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, ref Char localeName, UInt32 nameSize);
}

public class IDWriteTypography : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("55f1112b-1dc2-4b3c-9541-f46894ed85b6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteTypography>.Value;
    public HRESULT AddFontFeature(
        /// fontFeature: (DWRITE_FONT_FEATURE)
        DWRITE_FONT_FEATURE fontFeature
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddFontFeatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddFontFeatureFunc));
        return callback(Self, fontFeature);
    }
    delegate HRESULT AddFontFeatureFunc(IntPtr self, DWRITE_FONT_FEATURE fontFeature);
    public UInt32 GetFontFeatureCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFontFeatureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFeatureCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontFeatureCountFunc(IntPtr self);
    public HRESULT GetFontFeature(
        /// fontFeatureIndex: (UINT32)
        UInt32 fontFeatureIndex
        /// fontFeature: (*(DWRITE_FONT_FEATURE))
        , ref DWRITE_FONT_FEATURE fontFeature
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFontFeatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFeatureFunc));
        return callback(Self, fontFeatureIndex, ref fontFeature);
    }
    delegate HRESULT GetFontFeatureFunc(IntPtr self, UInt32 fontFeatureIndex, ref DWRITE_FONT_FEATURE fontFeature);
}

public enum DWRITE_SCRIPT_SHAPES {
    DEFAULT = 0x00000000,
    NO_VISUAL = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SCRIPT_ANALYSIS{
    /// (UINT16)
    public UInt16 script;

    /// (DWRITE_SCRIPT_SHAPES)
    public DWRITE_SCRIPT_SHAPES shapes;

}

public enum DWRITE_BREAK_CONDITION {
    NEUTRAL = 0x00000000,
    CAN_BREAK = 0x00000001,
    MAY_NOT_BREAK = 0x00000002,
    MUST_BREAK = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_LINE_BREAKPOINT{
    /// (UINT8)
    public Byte breakConditionBefore;

    /// (UINT8)
    public Byte breakConditionAfter;

    /// (UINT8)
    public Byte isWhitespace;

    /// (UINT8)
    public Byte isSoftHyphen;

    /// (UINT8)
    public Byte padding;

}

public enum DWRITE_NUMBER_SUBSTITUTION_METHOD {
    FROM_CULTURE = 0x00000000,
    CONTEXTUAL = 0x00000001,
    NONE = 0x00000002,
    NATIONAL = 0x00000003,
    TRADITIONAL = 0x00000004,
}

public class IDWriteNumberSubstitution : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("14885cc9-bab0-4f90-b6ed-5c366a2cd03d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
    int VTableIndexBase => VTableIndexBase<IDWriteNumberSubstitution>.Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SHAPING_TEXT_PROPERTIES{
    /// (UINT16)
    public UInt16 isShapedAlone;

    /// (UINT16)
    public UInt16 reserved1;

    /// (UINT16)
    public UInt16 canBreakShapingAfter;

    /// (UINT16)
    public UInt16 reserved;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SHAPING_GLYPH_PROPERTIES{
    /// (UINT16)
    public UInt16 justification;

    /// (UINT16)
    public UInt16 isClusterStart;

    /// (UINT16)
    public UInt16 isDiacritic;

    /// (UINT16)
    public UInt16 isZeroWidthSpace;

    /// (UINT16)
    public UInt16 reserved;

}

public class IDWriteTextAnalysisSource : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("688e1a58-5094-47c8-adc8-fbcea60ae92b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<IDWriteTextAnalysisSource>.Value;
    public HRESULT GetTextAtPosition(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textString: (*(*(const WCHAR)))
        , ref IntPtr textString
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetTextAtPositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextAtPositionFunc));
        return callback(Self, textPosition, ref textString, ref textLength);
    }
    delegate HRESULT GetTextAtPositionFunc(IntPtr self, UInt32 textPosition, ref IntPtr textString, ref UInt32 textLength);
    public HRESULT GetTextBeforePosition(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textString: (*(*(const WCHAR)))
        , ref IntPtr textString
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetTextBeforePositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextBeforePositionFunc));
        return callback(Self, textPosition, ref textString, ref textLength);
    }
    delegate HRESULT GetTextBeforePositionFunc(IntPtr self, UInt32 textPosition, ref IntPtr textString, ref UInt32 textLength);
    public DWRITE_READING_DIRECTION GetParagraphReadingDirection(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetParagraphReadingDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParagraphReadingDirectionFunc));
        return callback(Self);
    }
    delegate DWRITE_READING_DIRECTION GetParagraphReadingDirectionFunc(IntPtr self);
    public HRESULT GetLocaleName(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
        /// localeName: (*(*(const WCHAR)))
        , ref IntPtr localeName
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, textPosition, ref textLength, ref localeName);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, UInt32 textPosition, ref UInt32 textLength, ref IntPtr localeName);
    public HRESULT GetNumberSubstitution(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
        /// numberSubstitution: (*(*(IDWriteNumberSubstitution)))
        , ref IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNumberSubstitutionFunc));
        return callback(Self, textPosition, ref textLength, ref numberSubstitution);
    }
    delegate HRESULT GetNumberSubstitutionFunc(IntPtr self, UInt32 textPosition, ref UInt32 textLength, ref IntPtr numberSubstitution);
}

public class IDWriteTextAnalysisSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDWriteTextAnalysisSink>.Value;
    public HRESULT SetScriptAnalysis(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// scriptAnalysis: (*(const DWRITE_SCRIPT_ANALYSIS))
        , ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetScriptAnalysisFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetScriptAnalysisFunc));
        return callback(Self, textPosition, textLength, ref scriptAnalysis);
    }
    delegate HRESULT SetScriptAnalysisFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis);
    public HRESULT SetLineBreakpoints(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// lineBreakpoints: (*(const DWRITE_LINE_BREAKPOINT))
        , ref DWRITE_LINE_BREAKPOINT lineBreakpoints
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetLineBreakpointsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLineBreakpointsFunc));
        return callback(Self, textPosition, textLength, ref lineBreakpoints);
    }
    delegate HRESULT SetLineBreakpointsFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, ref DWRITE_LINE_BREAKPOINT lineBreakpoints);
    public HRESULT SetBidiLevel(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// explicitLevel: (UINT8)
        , Byte explicitLevel
        /// resolvedLevel: (UINT8)
        , Byte resolvedLevel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetBidiLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBidiLevelFunc));
        return callback(Self, textPosition, textLength, explicitLevel, resolvedLevel);
    }
    delegate HRESULT SetBidiLevelFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, Byte explicitLevel, Byte resolvedLevel);
    public HRESULT SetNumberSubstitution(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// numberSubstitution: (*(IDWriteNumberSubstitution))
        , IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetNumberSubstitutionFunc));
        return callback(Self, textPosition, textLength, numberSubstitution);
    }
    delegate HRESULT SetNumberSubstitutionFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, IntPtr numberSubstitution);
}

public class IDWriteTextAnalyzer : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 7;
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_RUN{
    /// (*(IDWriteFontFace))
    public IntPtr fontFace;

    /// (FLOAT)
    public Single fontEmSize;

    /// (UINT32)
    public UInt32 glyphCount;

    /// (*(const UINT16))
    public IntPtr glyphIndices;

    /// (*(const FLOAT))
    public IntPtr glyphAdvances;

    /// (*(const DWRITE_GLYPH_OFFSET))
    public IntPtr glyphOffsets;

    /// (BOOL)
    public Int32 isSideways;

    /// (UINT32)
    public UInt32 bidiLevel;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_RUN_DESCRIPTION{
    /// (*(const WCHAR))
    public IntPtr localeName;

    /// (*(const WCHAR))
    public IntPtr str;

    /// (UINT32)
    public UInt32 stringLength;

    /// (*(const UINT16))
    public IntPtr clusterMap;

    /// (UINT32)
    public UInt32 textPosition;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_UNDERLINE{
    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single thickness;

    /// (FLOAT)
    public Single offset;

    /// (FLOAT)
    public Single runHeight;

    /// (DWRITE_READING_DIRECTION)
    public DWRITE_READING_DIRECTION readingDirection;

    /// (DWRITE_FLOW_DIRECTION)
    public DWRITE_FLOW_DIRECTION flowDirection;

    /// (*(const WCHAR))
    public IntPtr localeName;

    /// (DWRITE_MEASURING_MODE)
    public DWRITE_MEASURING_MODE measuringMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_STRIKETHROUGH{
    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single thickness;

    /// (FLOAT)
    public Single offset;

    /// (DWRITE_READING_DIRECTION)
    public DWRITE_READING_DIRECTION readingDirection;

    /// (DWRITE_FLOW_DIRECTION)
    public DWRITE_FLOW_DIRECTION flowDirection;

    /// (*(const WCHAR))
    public IntPtr localeName;

    /// (DWRITE_MEASURING_MODE)
    public DWRITE_MEASURING_MODE measuringMode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_LINE_METRICS{
    /// (UINT32)
    public UInt32 length;

    /// (UINT32)
    public UInt32 trailingWhitespaceLength;

    /// (UINT32)
    public UInt32 newlineLength;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single baseline;

    /// (BOOL)
    public Int32 isTrimmed;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_CLUSTER_METRICS{
    /// (FLOAT)
    public Single width;

    /// (UINT16)
    public UInt16 length;

    /// (UINT16)
    public UInt16 canWrapLineAfter;

    /// (UINT16)
    public UInt16 isWhitespace;

    /// (UINT16)
    public UInt16 isNewline;

    /// (UINT16)
    public UInt16 isSoftHyphen;

    /// (UINT16)
    public UInt16 isRightToLeft;

    /// (UINT16)
    public UInt16 padding;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TEXT_METRICS{
    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single widthIncludingTrailingWhitespace;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single layoutWidth;

    /// (FLOAT)
    public Single layoutHeight;

    /// (UINT32)
    public UInt32 maxBidiReorderingDepth;

    /// (UINT32)
    public UInt32 lineCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_INLINE_OBJECT_METRICS{
    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single baseline;

    /// (BOOL)
    public Int32 supportsSideways;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_OVERHANG_METRICS{
    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single right;

    /// (FLOAT)
    public Single bottom;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_HIT_TEST_METRICS{
    /// (UINT32)
    public UInt32 textPosition;

    /// (UINT32)
    public UInt32 length;

    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single height;

    /// (UINT32)
    public UInt32 bidiLevel;

    /// (BOOL)
    public Int32 isText;

    /// (BOOL)
    public Int32 isTrimmed;

}

public class IDWriteInlineObject : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("8339fde3-106f-47ab-8373-1c6295eb10b3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDWriteInlineObject>.Value;
    public HRESULT Draw(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// renderer: (*(IDWriteTextRenderer))
        , IntPtr renderer
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
        return callback(Self, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }
    delegate HRESULT DrawFunc(IntPtr self, IntPtr clientDrawingContext, IntPtr renderer, Single originX, Single originY, Int32 isSideways, Int32 isRightToLeft, IntPtr clientDrawingEffect);
    public HRESULT GetMetrics(
        /// metrics: (*(DWRITE_INLINE_OBJECT_METRICS))
        ref DWRITE_INLINE_OBJECT_METRICS metrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetricsFunc));
        return callback(Self, ref metrics);
    }
    delegate HRESULT GetMetricsFunc(IntPtr self, ref DWRITE_INLINE_OBJECT_METRICS metrics);
    public HRESULT GetOverhangMetrics(
        /// overhangs: (*(DWRITE_OVERHANG_METRICS))
        ref DWRITE_OVERHANG_METRICS overhangs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetOverhangMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOverhangMetricsFunc));
        return callback(Self, ref overhangs);
    }
    delegate HRESULT GetOverhangMetricsFunc(IntPtr self, ref DWRITE_OVERHANG_METRICS overhangs);
    public HRESULT GetBreakConditions(
        /// breakConditionBefore: (*(DWRITE_BREAK_CONDITION))
        ref DWRITE_BREAK_CONDITION breakConditionBefore
        /// breakConditionAfter: (*(DWRITE_BREAK_CONDITION))
        , ref DWRITE_BREAK_CONDITION breakConditionAfter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetBreakConditionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBreakConditionsFunc));
        return callback(Self, ref breakConditionBefore, ref breakConditionAfter);
    }
    delegate HRESULT GetBreakConditionsFunc(IntPtr self, ref DWRITE_BREAK_CONDITION breakConditionBefore, ref DWRITE_BREAK_CONDITION breakConditionAfter);
}

public class IDWritePixelSnapping : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWritePixelSnapping>.Value;
    public HRESULT IsPixelSnappingDisabled(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// isDisabled: (*(BOOL))
        , IntPtr isDisabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsPixelSnappingDisabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsPixelSnappingDisabledFunc));
        return callback(Self, clientDrawingContext, isDisabled);
    }
    delegate HRESULT IsPixelSnappingDisabledFunc(IntPtr self, IntPtr clientDrawingContext, IntPtr isDisabled);
    public HRESULT GetCurrentTransform(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// transform: (*(DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentTransformFunc));
        return callback(Self, clientDrawingContext, ref transform);
    }
    delegate HRESULT GetCurrentTransformFunc(IntPtr self, IntPtr clientDrawingContext, ref DWRITE_MATRIX transform);
    public HRESULT GetPixelsPerDip(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// pixelsPerDip: (*(FLOAT))
        , ref Single pixelsPerDip
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelsPerDipFunc));
        return callback(Self, clientDrawingContext, ref pixelsPerDip);
    }
    delegate HRESULT GetPixelsPerDipFunc(IntPtr self, IntPtr clientDrawingContext, ref Single pixelsPerDip);
}

public class IDWriteTextRenderer: IDWritePixelSnapping {

    static /*readonly*/ Guid s_uuid = new Guid("ef8a8135-5cc6-45fe-8825-c5a0724eb819");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDWriteTextRenderer>.Value;
    public HRESULT DrawGlyphRun(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// glyphRunDescription: (*(const DWRITE_GLYPH_RUN_DESCRIPTION))
        , ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, ref glyphRun, ref glyphRunDescription, clientDrawingEffect);
    }
    delegate HRESULT DrawGlyphRunFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, DWRITE_MEASURING_MODE measuringMode, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, IntPtr clientDrawingEffect);
    public HRESULT DrawUnderline(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// underline: (*(const DWRITE_UNDERLINE))
        , ref DWRITE_UNDERLINE underline
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (DrawUnderlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawUnderlineFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, ref underline, clientDrawingEffect);
    }
    delegate HRESULT DrawUnderlineFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, ref DWRITE_UNDERLINE underline, IntPtr clientDrawingEffect);
    public HRESULT DrawStrikethrough(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// strikethrough: (*(const DWRITE_STRIKETHROUGH))
        , ref DWRITE_STRIKETHROUGH strikethrough
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (DrawStrikethroughFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawStrikethroughFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, ref strikethrough, clientDrawingEffect);
    }
    delegate HRESULT DrawStrikethroughFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, ref DWRITE_STRIKETHROUGH strikethrough, IntPtr clientDrawingEffect);
    public HRESULT DrawInlineObject(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
        /// inlineObject: (*(IDWriteInlineObject))
        , IntPtr inlineObject
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (DrawInlineObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInlineObjectFunc));
        return callback(Self, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
    }
    delegate HRESULT DrawInlineObjectFunc(IntPtr self, IntPtr clientDrawingContext, Single originX, Single originY, IntPtr inlineObject, Int32 isSideways, Int32 isRightToLeft, IntPtr clientDrawingEffect);
}

public class IDWriteTextLayout: IDWriteTextFormat {

    static /*readonly*/ Guid s_uuid = new Guid("53737037-6d14-410b-9bfe-0b182bb70961");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 39;
    int VTableIndexBase => VTableIndexBase<IDWriteTextLayout>.Value;
    public HRESULT SetMaxWidth(
        /// maxWidth: (FLOAT)
        Single maxWidth
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetMaxWidthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaxWidthFunc));
        return callback(Self, maxWidth);
    }
    delegate HRESULT SetMaxWidthFunc(IntPtr self, Single maxWidth);
    public HRESULT SetMaxHeight(
        /// maxHeight: (FLOAT)
        Single maxHeight
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetMaxHeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaxHeightFunc));
        return callback(Self, maxHeight);
    }
    delegate HRESULT SetMaxHeightFunc(IntPtr self, Single maxHeight);
    public HRESULT SetFontCollection(
        /// fontCollection: (*(IDWriteFontCollection))
        IntPtr fontCollection
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontCollectionFunc));
        return callback(Self, fontCollection, textRange);
    }
    delegate HRESULT SetFontCollectionFunc(IntPtr self, IntPtr fontCollection, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetFontFamilyName(
        /// fontFamilyName: (*(const WCHAR))
        ref Char fontFamilyName
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetFontFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontFamilyNameFunc));
        return callback(Self, ref fontFamilyName, textRange);
    }
    delegate HRESULT SetFontFamilyNameFunc(IntPtr self, ref Char fontFamilyName, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetFontWeight(
        /// fontWeight: (DWRITE_FONT_WEIGHT)
        DWRITE_FONT_WEIGHT fontWeight
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SetFontWeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontWeightFunc));
        return callback(Self, fontWeight, textRange);
    }
    delegate HRESULT SetFontWeightFunc(IntPtr self, DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetFontStyle(
        /// fontStyle: (DWRITE_FONT_STYLE)
        DWRITE_FONT_STYLE fontStyle
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetFontStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontStyleFunc));
        return callback(Self, fontStyle, textRange);
    }
    delegate HRESULT SetFontStyleFunc(IntPtr self, DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetFontStretch(
        /// fontStretch: (DWRITE_FONT_STRETCH)
        DWRITE_FONT_STRETCH fontStretch
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (SetFontStretchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontStretchFunc));
        return callback(Self, fontStretch, textRange);
    }
    delegate HRESULT SetFontStretchFunc(IntPtr self, DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetFontSize(
        /// fontSize: (FLOAT)
        Single fontSize
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetFontSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFontSizeFunc));
        return callback(Self, fontSize, textRange);
    }
    delegate HRESULT SetFontSizeFunc(IntPtr self, Single fontSize, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetUnderline(
        /// hasUnderline: (BOOL)
        Int32 hasUnderline
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (SetUnderlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetUnderlineFunc));
        return callback(Self, hasUnderline, textRange);
    }
    delegate HRESULT SetUnderlineFunc(IntPtr self, Int32 hasUnderline, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetStrikethrough(
        /// hasStrikethrough: (BOOL)
        Int32 hasStrikethrough
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (SetStrikethroughFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStrikethroughFunc));
        return callback(Self, hasStrikethrough, textRange);
    }
    delegate HRESULT SetStrikethroughFunc(IntPtr self, Int32 hasStrikethrough, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetDrawingEffect(
        /// drawingEffect: (*(IUnknown))
        IntPtr drawingEffect
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (SetDrawingEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDrawingEffectFunc));
        return callback(Self, drawingEffect, textRange);
    }
    delegate HRESULT SetDrawingEffectFunc(IntPtr self, IntPtr drawingEffect, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetInlineObject(
        /// inlineObject: (*(IDWriteInlineObject))
        IntPtr inlineObject
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (SetInlineObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInlineObjectFunc));
        return callback(Self, inlineObject, textRange);
    }
    delegate HRESULT SetInlineObjectFunc(IntPtr self, IntPtr inlineObject, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetTypography(
        /// typography: (*(IDWriteTypography))
        IntPtr typography
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (SetTypographyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTypographyFunc));
        return callback(Self, typography, textRange);
    }
    delegate HRESULT SetTypographyFunc(IntPtr self, IntPtr typography, DWRITE_TEXT_RANGE textRange);
    public HRESULT SetLocaleName(
        /// localeName: (*(const WCHAR))
        ref Char localeName
        /// textRange: (DWRITE_TEXT_RANGE)
        , DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (SetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLocaleNameFunc));
        return callback(Self, ref localeName, textRange);
    }
    delegate HRESULT SetLocaleNameFunc(IntPtr self, ref Char localeName, DWRITE_TEXT_RANGE textRange);
    public Single GetMaxWidth(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (GetMaxWidthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaxWidthFunc));
        return callback(Self);
    }
    delegate Single GetMaxWidthFunc(IntPtr self);
    public Single GetMaxHeight(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (GetMaxHeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaxHeightFunc));
        return callback(Self);
    }
    delegate Single GetMaxHeightFunc(IntPtr self);
    public HRESULT GetFontCollection(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontCollection: (*(*(IDWriteFontCollection)))
        , ref IntPtr fontCollection
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (GetFontCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontCollectionFunc));
        return callback(Self, currentPosition, ref fontCollection, ref textRange);
    }
    delegate HRESULT GetFontCollectionFunc(IntPtr self, UInt32 currentPosition, ref IntPtr fontCollection, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontFamilyNameLength(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// nameLength: (*(UINT32))
        , ref UInt32 nameLength
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (GetFontFamilyNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyNameLengthFunc));
        return callback(Self, currentPosition, ref nameLength, ref textRange);
    }
    delegate HRESULT GetFontFamilyNameLengthFunc(IntPtr self, UInt32 currentPosition, ref UInt32 nameLength, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontFamilyName(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontFamilyName: (*(WCHAR))
        , ref Char fontFamilyName
        /// nameSize: (UINT32)
        , UInt32 nameSize
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (GetFontFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyNameFunc));
        return callback(Self, currentPosition, ref fontFamilyName, nameSize, ref textRange);
    }
    delegate HRESULT GetFontFamilyNameFunc(IntPtr self, UInt32 currentPosition, ref Char fontFamilyName, UInt32 nameSize, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontWeight(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontWeight: (*(DWRITE_FONT_WEIGHT))
        , ref DWRITE_FONT_WEIGHT fontWeight
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (GetFontWeightFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontWeightFunc));
        return callback(Self, currentPosition, ref fontWeight, ref textRange);
    }
    delegate HRESULT GetFontWeightFunc(IntPtr self, UInt32 currentPosition, ref DWRITE_FONT_WEIGHT fontWeight, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontStyle(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontStyle: (*(DWRITE_FONT_STYLE))
        , ref DWRITE_FONT_STYLE fontStyle
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (GetFontStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontStyleFunc));
        return callback(Self, currentPosition, ref fontStyle, ref textRange);
    }
    delegate HRESULT GetFontStyleFunc(IntPtr self, UInt32 currentPosition, ref DWRITE_FONT_STYLE fontStyle, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontStretch(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontStretch: (*(DWRITE_FONT_STRETCH))
        , ref DWRITE_FONT_STRETCH fontStretch
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (GetFontStretchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontStretchFunc));
        return callback(Self, currentPosition, ref fontStretch, ref textRange);
    }
    delegate HRESULT GetFontStretchFunc(IntPtr self, UInt32 currentPosition, ref DWRITE_FONT_STRETCH fontStretch, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetFontSize(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// fontSize: (*(FLOAT))
        , ref Single fontSize
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (GetFontSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontSizeFunc));
        return callback(Self, currentPosition, ref fontSize, ref textRange);
    }
    delegate HRESULT GetFontSizeFunc(IntPtr self, UInt32 currentPosition, ref Single fontSize, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetUnderline(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// hasUnderline: (*(BOOL))
        , IntPtr hasUnderline
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (GetUnderlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUnderlineFunc));
        return callback(Self, currentPosition, hasUnderline, ref textRange);
    }
    delegate HRESULT GetUnderlineFunc(IntPtr self, UInt32 currentPosition, IntPtr hasUnderline, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetStrikethrough(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// hasStrikethrough: (*(BOOL))
        , IntPtr hasStrikethrough
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (GetStrikethroughFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStrikethroughFunc));
        return callback(Self, currentPosition, hasStrikethrough, ref textRange);
    }
    delegate HRESULT GetStrikethroughFunc(IntPtr self, UInt32 currentPosition, IntPtr hasStrikethrough, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetDrawingEffect(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// drawingEffect: (*(*(IUnknown)))
        , ref IntPtr drawingEffect
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (GetDrawingEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDrawingEffectFunc));
        return callback(Self, currentPosition, ref drawingEffect, ref textRange);
    }
    delegate HRESULT GetDrawingEffectFunc(IntPtr self, UInt32 currentPosition, ref IntPtr drawingEffect, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetInlineObject(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// inlineObject: (*(*(IDWriteInlineObject)))
        , ref IntPtr inlineObject
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (GetInlineObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInlineObjectFunc));
        return callback(Self, currentPosition, ref inlineObject, ref textRange);
    }
    delegate HRESULT GetInlineObjectFunc(IntPtr self, UInt32 currentPosition, ref IntPtr inlineObject, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetTypography(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// typography: (*(*(IDWriteTypography)))
        , ref IntPtr typography
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (GetTypographyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypographyFunc));
        return callback(Self, currentPosition, ref typography, ref textRange);
    }
    delegate HRESULT GetTypographyFunc(IntPtr self, UInt32 currentPosition, ref IntPtr typography, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetLocaleNameLength(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// nameLength: (*(UINT32))
        , ref UInt32 nameLength
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (GetLocaleNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameLengthFunc));
        return callback(Self, currentPosition, ref nameLength, ref textRange);
    }
    delegate HRESULT GetLocaleNameLengthFunc(IntPtr self, UInt32 currentPosition, ref UInt32 nameLength, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT GetLocaleName(
        /// currentPosition: (UINT32)
        UInt32 currentPosition
        /// localeName: (*(WCHAR))
        , ref Char localeName
        /// nameSize: (UINT32)
        , UInt32 nameSize
        /// textRange: (*(DWRITE_TEXT_RANGE))
        , ref DWRITE_TEXT_RANGE textRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, currentPosition, ref localeName, nameSize, ref textRange);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, UInt32 currentPosition, ref Char localeName, UInt32 nameSize, ref DWRITE_TEXT_RANGE textRange);
    public HRESULT Draw(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// renderer: (*(IDWriteTextRenderer))
        , IntPtr renderer
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
        return callback(Self, clientDrawingContext, renderer, originX, originY);
    }
    delegate HRESULT DrawFunc(IntPtr self, IntPtr clientDrawingContext, IntPtr renderer, Single originX, Single originY);
    public HRESULT GetLineMetrics(
        /// lineMetrics: (*(DWRITE_LINE_METRICS))
        ref DWRITE_LINE_METRICS lineMetrics
        /// maxLineCount: (UINT32)
        , UInt32 maxLineCount
        /// actualLineCount: (*(UINT32))
        , ref UInt32 actualLineCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (GetLineMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLineMetricsFunc));
        return callback(Self, ref lineMetrics, maxLineCount, ref actualLineCount);
    }
    delegate HRESULT GetLineMetricsFunc(IntPtr self, ref DWRITE_LINE_METRICS lineMetrics, UInt32 maxLineCount, ref UInt32 actualLineCount);
    public HRESULT GetMetrics(
        /// textMetrics: (*(DWRITE_TEXT_METRICS))
        ref DWRITE_TEXT_METRICS textMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (GetMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetricsFunc));
        return callback(Self, ref textMetrics);
    }
    delegate HRESULT GetMetricsFunc(IntPtr self, ref DWRITE_TEXT_METRICS textMetrics);
    public HRESULT GetOverhangMetrics(
        /// overhangs: (*(DWRITE_OVERHANG_METRICS))
        ref DWRITE_OVERHANG_METRICS overhangs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (GetOverhangMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOverhangMetricsFunc));
        return callback(Self, ref overhangs);
    }
    delegate HRESULT GetOverhangMetricsFunc(IntPtr self, ref DWRITE_OVERHANG_METRICS overhangs);
    public HRESULT GetClusterMetrics(
        /// clusterMetrics: (*(DWRITE_CLUSTER_METRICS))
        ref DWRITE_CLUSTER_METRICS clusterMetrics
        /// maxClusterCount: (UINT32)
        , UInt32 maxClusterCount
        /// actualClusterCount: (*(UINT32))
        , ref UInt32 actualClusterCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (GetClusterMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClusterMetricsFunc));
        return callback(Self, ref clusterMetrics, maxClusterCount, ref actualClusterCount);
    }
    delegate HRESULT GetClusterMetricsFunc(IntPtr self, ref DWRITE_CLUSTER_METRICS clusterMetrics, UInt32 maxClusterCount, ref UInt32 actualClusterCount);
    public HRESULT DetermineMinWidth(
        /// minWidth: (*(FLOAT))
        ref Single minWidth
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 35);
        var callback = (DetermineMinWidthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DetermineMinWidthFunc));
        return callback(Self, ref minWidth);
    }
    delegate HRESULT DetermineMinWidthFunc(IntPtr self, ref Single minWidth);
    public HRESULT HitTestPoint(
        /// pointX: (FLOAT)
        Single pointX
        /// pointY: (FLOAT)
        , Single pointY
        /// isTrailingHit: (*(BOOL))
        , IntPtr isTrailingHit
        /// isInside: (*(BOOL))
        , IntPtr isInside
        /// hitTestMetrics: (*(DWRITE_HIT_TEST_METRICS))
        , ref DWRITE_HIT_TEST_METRICS hitTestMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 36);
        var callback = (HitTestPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HitTestPointFunc));
        return callback(Self, pointX, pointY, isTrailingHit, isInside, ref hitTestMetrics);
    }
    delegate HRESULT HitTestPointFunc(IntPtr self, Single pointX, Single pointY, IntPtr isTrailingHit, IntPtr isInside, ref DWRITE_HIT_TEST_METRICS hitTestMetrics);
    public HRESULT HitTestTextPosition(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// isTrailingHit: (BOOL)
        , Int32 isTrailingHit
        /// pointX: (*(FLOAT))
        , ref Single pointX
        /// pointY: (*(FLOAT))
        , ref Single pointY
        /// hitTestMetrics: (*(DWRITE_HIT_TEST_METRICS))
        , ref DWRITE_HIT_TEST_METRICS hitTestMetrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 37);
        var callback = (HitTestTextPositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HitTestTextPositionFunc));
        return callback(Self, textPosition, isTrailingHit, ref pointX, ref pointY, ref hitTestMetrics);
    }
    delegate HRESULT HitTestTextPositionFunc(IntPtr self, UInt32 textPosition, Int32 isTrailingHit, ref Single pointX, ref Single pointY, ref DWRITE_HIT_TEST_METRICS hitTestMetrics);
    public HRESULT HitTestTextRange(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
        /// hitTestMetrics: (*(DWRITE_HIT_TEST_METRICS))
        , ref DWRITE_HIT_TEST_METRICS hitTestMetrics
        /// maxHitTestMetricsCount: (UINT32)
        , UInt32 maxHitTestMetricsCount
        /// actualHitTestMetricsCount: (*(UINT32))
        , ref UInt32 actualHitTestMetricsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 38);
        var callback = (HitTestTextRangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HitTestTextRangeFunc));
        return callback(Self, textPosition, textLength, originX, originY, ref hitTestMetrics, maxHitTestMetricsCount, ref actualHitTestMetricsCount);
    }
    delegate HRESULT HitTestTextRangeFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, Single originX, Single originY, ref DWRITE_HIT_TEST_METRICS hitTestMetrics, UInt32 maxHitTestMetricsCount, ref UInt32 actualHitTestMetricsCount);
}

public class IDWriteBitmapRenderTarget : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 8;
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

public class IDWriteGdiInterop : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("1edd9491-9853-4299-898f-6432983b6f3a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    int VTableIndexBase => VTableIndexBase<IDWriteGdiInterop>.Value;
    public HRESULT CreateFontFromLOGFONT(
        /// logFont: (*(const LOGFONTW))
        ref LOGFONTW logFont
        /// font: (*(*(IDWriteFont)))
        , ref IntPtr font
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateFontFromLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFromLOGFONTFunc));
        return callback(Self, ref logFont, ref font);
    }
    delegate HRESULT CreateFontFromLOGFONTFunc(IntPtr self, ref LOGFONTW logFont, ref IntPtr font);
    public HRESULT ConvertFontToLOGFONT(
        /// font: (*(IDWriteFont))
        IntPtr font
        /// logFont: (*(LOGFONTW))
        , ref LOGFONTW logFont
        /// isSystemFont: (*(BOOL))
        , IntPtr isSystemFont
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ConvertFontToLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConvertFontToLOGFONTFunc));
        return callback(Self, font, ref logFont, isSystemFont);
    }
    delegate HRESULT ConvertFontToLOGFONTFunc(IntPtr self, IntPtr font, ref LOGFONTW logFont, IntPtr isSystemFont);
    public HRESULT ConvertFontFaceToLOGFONT(
        /// font: (*(IDWriteFontFace))
        IntPtr font
        /// logFont: (*(LOGFONTW))
        , ref LOGFONTW logFont
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (ConvertFontFaceToLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConvertFontFaceToLOGFONTFunc));
        return callback(Self, font, ref logFont);
    }
    delegate HRESULT ConvertFontFaceToLOGFONTFunc(IntPtr self, IntPtr font, ref LOGFONTW logFont);
    public HRESULT CreateFontFaceFromHdc(
        /// hdc: (HDC)
        IntPtr hdc
        /// fontFace: (*(*(IDWriteFontFace)))
        , ref IntPtr fontFace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateFontFaceFromHdcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFaceFromHdcFunc));
        return callback(Self, hdc, ref fontFace);
    }
    delegate HRESULT CreateFontFaceFromHdcFunc(IntPtr self, IntPtr hdc, ref IntPtr fontFace);
    public HRESULT CreateBitmapRenderTarget(
        /// hdc: (HDC)
        IntPtr hdc
        /// width: (UINT32)
        , UInt32 width
        /// height: (UINT32)
        , UInt32 height
        /// renderTarget: (*(*(IDWriteBitmapRenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateBitmapRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapRenderTargetFunc));
        return callback(Self, hdc, width, height, ref renderTarget);
    }
    delegate HRESULT CreateBitmapRenderTargetFunc(IntPtr self, IntPtr hdc, UInt32 width, UInt32 height, ref IntPtr renderTarget);
}

public enum DWRITE_TEXTURE_TYPE {
    DWRITE_TEXTURE_ALIASED_1x1 = 0x00000000,
    DWRITE_TEXTURE_CLEARTYPE_3x1 = 0x00000001,
}

public class IDWriteGlyphRunAnalysis : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("7d97dbf7-e085-42d4-81e3-6a883bded118");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDWriteGlyphRunAnalysis>.Value;
    public HRESULT GetAlphaTextureBounds(
        /// textureType: (DWRITE_TEXTURE_TYPE)
        DWRITE_TEXTURE_TYPE textureType
        /// textureBounds: (*(RECT))
        , ref RECT textureBounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetAlphaTextureBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaTextureBoundsFunc));
        return callback(Self, textureType, ref textureBounds);
    }
    delegate HRESULT GetAlphaTextureBoundsFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, ref RECT textureBounds);
    public HRESULT CreateAlphaTexture(
        /// textureType: (DWRITE_TEXTURE_TYPE)
        DWRITE_TEXTURE_TYPE textureType
        /// textureBounds: (*(const RECT))
        , ref RECT textureBounds
        /// alphaValues: (*(BYTE))
        , ref Byte alphaValues
        /// bufferSize: (UINT32)
        , UInt32 bufferSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateAlphaTextureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateAlphaTextureFunc));
        return callback(Self, textureType, ref textureBounds, ref alphaValues, bufferSize);
    }
    delegate HRESULT CreateAlphaTextureFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, ref RECT textureBounds, ref Byte alphaValues, UInt32 bufferSize);
    public HRESULT GetAlphaBlendParams(
        /// renderingParams: (*(IDWriteRenderingParams))
        IntPtr renderingParams
        /// blendGamma: (*(FLOAT))
        , ref Single blendGamma
        /// blendEnhancedContrast: (*(FLOAT))
        , ref Single blendEnhancedContrast
        /// blendClearTypeLevel: (*(FLOAT))
        , ref Single blendClearTypeLevel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetAlphaBlendParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaBlendParamsFunc));
        return callback(Self, renderingParams, ref blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
    }
    delegate HRESULT GetAlphaBlendParamsFunc(IntPtr self, IntPtr renderingParams, ref Single blendGamma, ref Single blendEnhancedContrast, ref Single blendClearTypeLevel);
}

public class IDWriteFactory : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 21;
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
        ref Char filePath
        /// lastWriteTime: (*(const FILETIME))
        , ref FILETIME lastWriteTime
        /// fontFile: (*(*(IDWriteFontFile)))
        , ref IntPtr fontFile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateFontFileReferenceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFileReferenceFunc));
        return callback(Self, ref filePath, ref lastWriteTime, ref fontFile);
    }
    delegate HRESULT CreateFontFileReferenceFunc(IntPtr self, ref Char filePath, ref FILETIME lastWriteTime, ref IntPtr fontFile);
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
        ref Char fontFamilyName
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
        , ref Char localeName
        /// textFormat: (*(*(IDWriteTextFormat)))
        , ref IntPtr textFormat
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (CreateTextFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTextFormatFunc));
        return callback(Self, ref fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, ref localeName, ref textFormat);
    }
    delegate HRESULT CreateTextFormatFunc(IntPtr self, ref Char fontFamilyName, IntPtr fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, Single fontSize, ref Char localeName, ref IntPtr textFormat);
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
        ref Char str
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
        return callback(Self, ref str, stringLength, textFormat, maxWidth, maxHeight, ref textLayout);
    }
    delegate HRESULT CreateTextLayoutFunc(IntPtr self, ref Char str, UInt32 stringLength, IntPtr textFormat, Single maxWidth, Single maxHeight, ref IntPtr textLayout);
    public HRESULT CreateGdiCompatibleTextLayout(
        /// string: (*(const WCHAR))
        ref Char str
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
        return callback(Self, ref str, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, ref transform, useGdiNatural, ref textLayout);
    }
    delegate HRESULT CreateGdiCompatibleTextLayoutFunc(IntPtr self, ref Char str, UInt32 stringLength, IntPtr textFormat, Single layoutWidth, Single layoutHeight, Single pixelsPerDip, ref DWRITE_MATRIX transform, Int32 useGdiNatural, ref IntPtr textLayout);
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
        , ref Char localeName
        /// ignoreUserOverride: (BOOL)
        , Int32 ignoreUserOverride
        /// numberSubstitution: (*(*(IDWriteNumberSubstitution)))
        , ref IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (CreateNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateNumberSubstitutionFunc));
        return callback(Self, substitutionMethod, ref localeName, ignoreUserOverride, ref numberSubstitution);
    }
    delegate HRESULT CreateNumberSubstitutionFunc(IntPtr self, DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, ref Char localeName, Int32 ignoreUserOverride, ref IntPtr numberSubstitution);
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

public static class dwrite{
public const int DWRITE_ALPHA_MAX = unchecked((int)255);
public const int FACILITY_DWRITE = unchecked((int)0x898);
public const int DWRITE_ERR_BASE = unchecked((int)0x5000);
[DllImport("Dwrite.dll")]
public static extern HRESULT DWriteCreateFactory(
    /// factoryType: (DWRITE_FACTORY_TYPE)
    DWRITE_FACTORY_TYPE factoryType
    /// iid: (&(const IID))
    , ref Guid iid
    /// factory: (*(*(IUnknown)))
    , ref IntPtr factory
);

}
}
