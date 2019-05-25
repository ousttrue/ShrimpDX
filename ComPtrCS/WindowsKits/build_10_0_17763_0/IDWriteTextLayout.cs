/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=39)]
public class IDWriteTextLayout: IDWriteTextFormat {

    static /*readonly*/ Guid s_uuid = new Guid("53737037-6d14-410b-9bfe-0b182bb70961");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
