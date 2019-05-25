/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=25)]
public class IDWriteTextFormat : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("9c906818-31d7-4fd3-a151-7c5e225db55a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
        [MarshalAs(UnmanagedType.LPWStr)]string fontFamilyName
        /// nameSize: (UINT32)
        , UInt32 nameSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (GetFontFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyNameFunc));
        return callback(Self, fontFamilyName, nameSize);
    }
    delegate HRESULT GetFontFamilyNameFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string fontFamilyName, UInt32 nameSize);
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
        [MarshalAs(UnmanagedType.LPWStr)]string localeName
        /// nameSize: (UINT32)
        , UInt32 nameSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, localeName, nameSize);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string localeName, UInt32 nameSize);
}
}
