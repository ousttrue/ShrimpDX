/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteFontFamily: IDWriteFontList {

    static /*readonly*/ Guid s_uuid = new Guid("da20d8ef-812a-4c43-9802-62ec4abd7add");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
