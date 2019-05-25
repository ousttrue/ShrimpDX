/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGIResource1: IDXGIResource {

    static /*readonly*/ Guid s_uuid = new Guid("30961379-4609-4a41-998e-54fe567ee0c1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIResource1>.Value;
    public HRESULT CreateSubresourceSurface(
        /// index: (UINT)
        UInt32 index
        /// ppSurface: (*(*(IDXGISurface2)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateSubresourceSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSubresourceSurfaceFunc));
        return callback(Self, index, ref ppSurface);
    }
    delegate HRESULT CreateSubresourceSurfaceFunc(IntPtr self, UInt32 index, ref IntPtr ppSurface);
    public HRESULT CreateSharedHandle(
        /// pAttributes: (*(const SECURITY_ATTRIBUTES))
        ref SECURITY_ATTRIBUTES pAttributes
        /// dwAccess: (DWORD)
        , UInt32 dwAccess
        /// lpName: (LPCWSTR)
        , IntPtr lpName
        /// pHandle: (*(HANDLE))
        , ref IntPtr pHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSharedHandleFunc));
        return callback(Self, ref pAttributes, dwAccess, lpName, ref pHandle);
    }
    delegate HRESULT CreateSharedHandleFunc(IntPtr self, ref SECURITY_ATTRIBUTES pAttributes, UInt32 dwAccess, IntPtr lpName, ref IntPtr pHandle);
}
}
