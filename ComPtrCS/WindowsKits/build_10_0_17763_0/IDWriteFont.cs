/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=11)]
public class IDWriteFont : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
