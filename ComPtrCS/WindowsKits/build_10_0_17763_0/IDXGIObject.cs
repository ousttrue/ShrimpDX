/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDXGIObject : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIObject>.Value;
    public HRESULT SetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref Name, DataSize, pData);
    }
    delegate HRESULT SetPrivateDataFunc(IntPtr self, ref Guid Name, UInt32 DataSize, IntPtr pData);
    public HRESULT SetPrivateDataInterface(
        /// Name: (&(const GUID))
        ref Guid Name
        /// pUnknown: (*(const IUnknown))
        , IntPtr pUnknown
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref Name, pUnknown);
    }
    delegate HRESULT SetPrivateDataInterfaceFunc(IntPtr self, ref Guid Name, IntPtr pUnknown);
    public HRESULT GetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref Name, ref pDataSize, pData);
    }
    delegate HRESULT GetPrivateDataFunc(IntPtr self, ref Guid Name, ref UInt32 pDataSize, IntPtr pData);
    public HRESULT GetParent(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppParent: (*(*(void)))
        , ref IntPtr ppParent
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetParentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentFunc));
        return callback(Self, ref riid, ref ppParent);
    }
    delegate HRESULT GetParentFunc(IntPtr self, ref Guid riid, ref IntPtr ppParent);
}
}
