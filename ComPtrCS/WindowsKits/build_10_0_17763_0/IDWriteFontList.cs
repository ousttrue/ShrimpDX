/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteFontList : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("1a0d8438-1d97-4ec1-aef9-a2fb86ed6acb");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
