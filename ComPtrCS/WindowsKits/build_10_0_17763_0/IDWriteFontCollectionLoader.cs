/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDWriteFontCollectionLoader : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

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
}
