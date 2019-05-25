/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDWriteFontFileLoader : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
