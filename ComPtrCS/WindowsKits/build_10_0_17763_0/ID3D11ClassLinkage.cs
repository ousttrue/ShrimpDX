/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3D11ClassLinkage: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11ClassLinkage>.Value;
    public HRESULT GetClassInstance(
        /// pClassInstanceName: (LPCSTR)
        IntPtr pClassInstanceName
        /// InstanceIndex: (UINT)
        , UInt32 InstanceIndex
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppInstance
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassInstanceFunc));
        return callback(Self, pClassInstanceName, InstanceIndex, ref ppInstance);
    }
    delegate HRESULT GetClassInstanceFunc(IntPtr self, IntPtr pClassInstanceName, UInt32 InstanceIndex, ref IntPtr ppInstance);
    public HRESULT CreateClassInstance(
        /// pClassTypeName: (LPCSTR)
        IntPtr pClassTypeName
        /// ConstantBufferOffset: (UINT)
        , UInt32 ConstantBufferOffset
        /// ConstantVectorOffset: (UINT)
        , UInt32 ConstantVectorOffset
        /// TextureOffset: (UINT)
        , UInt32 TextureOffset
        /// SamplerOffset: (UINT)
        , UInt32 SamplerOffset
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppInstance
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassInstanceFunc));
        return callback(Self, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ref ppInstance);
    }
    delegate HRESULT CreateClassInstanceFunc(IntPtr self, IntPtr pClassTypeName, UInt32 ConstantBufferOffset, UInt32 ConstantVectorOffset, UInt32 TextureOffset, UInt32 SamplerOffset, ref IntPtr ppInstance);
}
}
