/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID3D11Resource: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Resource>.Value;
    public void GetType(
        /// pResourceDimension: (*(D3D11_RESOURCE_DIMENSION))
        ref D3D11_RESOURCE_DIMENSION pResourceDimension
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        callback(Self, ref pResourceDimension);
    }
    delegate void GetTypeFunc(IntPtr self, ref D3D11_RESOURCE_DIMENSION pResourceDimension);
    public void SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
        callback(Self, EvictionPriority);
    }
    delegate void SetEvictionPriorityFunc(IntPtr self, UInt32 EvictionPriority);
    public UInt32 GetEvictionPriority(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
        return callback(Self);
    }
    delegate UInt32 GetEvictionPriorityFunc(IntPtr self);
}
}
