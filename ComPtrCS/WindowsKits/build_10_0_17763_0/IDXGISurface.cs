/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDXGISurface: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGISurface>.Value;
    public HRESULT GetDesc(
        /// pDesc: (*(DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDescFunc(IntPtr self, ref DXGI_SURFACE_DESC pDesc);
    public HRESULT Map(
        /// pLockedRect: (*(DXGI_MAPPED_RECT))
        ref DXGI_MAPPED_RECT pLockedRect
        /// MapFlags: (UINT)
        , UInt32 MapFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, ref pLockedRect, MapFlags);
    }
    delegate HRESULT MapFunc(IntPtr self, ref DXGI_MAPPED_RECT pLockedRect, UInt32 MapFlags);
    public HRESULT Unmap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        return callback(Self);
    }
    delegate HRESULT UnmapFunc(IntPtr self);
}
}
