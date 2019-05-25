/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDWriteFontFileEnumerator : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("72755049-5ff7-435d-8348-4be97cfa6c7c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
