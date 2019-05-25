/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11CommandList: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("a24bc4d1-769e-43f7-8013-98ff566c18e2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11CommandList>.Value;
    public UInt32 GetContextFlags(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetContextFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContextFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetContextFlagsFunc(IntPtr self);
}
}
