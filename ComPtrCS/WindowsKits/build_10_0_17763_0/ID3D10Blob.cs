/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3D10Blob : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D10Blob>.Value;
    public IntPtr GetBufferPointer(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetBufferPointerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferPointerFunc));
        return callback(Self);
    }
    delegate IntPtr GetBufferPointerFunc(IntPtr self);
    public UIntPtr GetBufferSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetBufferSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferSizeFunc));
        return callback(Self);
    }
    delegate UIntPtr GetBufferSizeFunc(IntPtr self);
}
}
