/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11Asynchronous: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Asynchronous>.Value;
    public UInt32 GetDataSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDataSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataSizeFunc));
        return callback(Self);
    }
    delegate UInt32 GetDataSizeFunc(IntPtr self);
}
}
