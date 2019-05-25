/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID3D11ClassInstance: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11ClassInstance>.Value;
    public void GetClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref IntPtr ppLinkage
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetClassLinkageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassLinkageFunc));
        callback(Self, ref ppLinkage);
    }
    delegate void GetClassLinkageFunc(IntPtr self, ref IntPtr ppLinkage);
    public void GetDesc(
        /// pDesc: (*(D3D11_CLASS_INSTANCE_DESC))
        ref D3D11_CLASS_INSTANCE_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_CLASS_INSTANCE_DESC pDesc);
    public void GetInstanceName(
        /// pInstanceName: (LPSTR)
        IntPtr pInstanceName
        /// pBufferLength: (*(SIZE_T))
        , ref UIntPtr pBufferLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetInstanceNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInstanceNameFunc));
        callback(Self, pInstanceName, ref pBufferLength);
    }
    delegate void GetInstanceNameFunc(IntPtr self, IntPtr pInstanceName, ref UIntPtr pBufferLength);
    public void GetTypeName(
        /// pTypeName: (LPSTR)
        IntPtr pTypeName
        /// pBufferLength: (*(SIZE_T))
        , ref UIntPtr pBufferLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTypeNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeNameFunc));
        callback(Self, pTypeName, ref pBufferLength);
    }
    delegate void GetTypeNameFunc(IntPtr self, IntPtr pTypeName, ref UIntPtr pBufferLength);
}
}
