/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDXGIDeviceSubObject: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIDeviceSubObject>.Value;
    public HRESULT GetDevice(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppDevice: (*(*(void)))
        , ref IntPtr ppDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
        return callback(Self, ref riid, ref ppDevice);
    }
    delegate HRESULT GetDeviceFunc(IntPtr self, ref Guid riid, ref IntPtr ppDevice);
}
}
