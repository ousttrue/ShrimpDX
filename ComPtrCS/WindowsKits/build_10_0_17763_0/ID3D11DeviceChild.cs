/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID3D11DeviceChild : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11DeviceChild>.Value;
    public void GetDevice(
        /// ppDevice: (*(*(ID3D11Device)))
        ref IntPtr ppDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
        callback(Self, ref ppDevice);
    }
    delegate void GetDeviceFunc(IntPtr self, ref IntPtr ppDevice);
    public HRESULT GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref guid, ref pDataSize, pData);
    }
    delegate HRESULT GetPrivateDataFunc(IntPtr self, ref Guid guid, ref UInt32 pDataSize, IntPtr pData);
    public HRESULT SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate HRESULT SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public HRESULT SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate HRESULT SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
}
}
