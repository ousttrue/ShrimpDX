/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDXGISurface2: IDXGISurface1 {

    static /*readonly*/ Guid s_uuid = new Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGISurface2>.Value;
    public HRESULT GetResource(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppParentResource: (*(*(void)))
        , ref IntPtr ppParentResource
        /// pSubresourceIndex: (*(UINT))
        , ref UInt32 pSubresourceIndex
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
        return callback(Self, ref riid, ref ppParentResource, ref pSubresourceIndex);
    }
    delegate HRESULT GetResourceFunc(IntPtr self, ref Guid riid, ref IntPtr ppParentResource, ref UInt32 pSubresourceIndex);
}
}
