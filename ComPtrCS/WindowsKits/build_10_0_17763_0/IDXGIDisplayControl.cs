/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGIDisplayControl : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIDisplayControl>.Value;
    public Int32 IsStereoEnabled(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsStereoEnabledFunc));
        return callback(Self);
    }
    delegate Int32 IsStereoEnabledFunc(IntPtr self);
    public void SetStereoEnabled(
        /// enabled: (BOOL)
        Int32 enabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStereoEnabledFunc));
        callback(Self, enabled);
    }
    delegate void SetStereoEnabledFunc(IntPtr self, Int32 enabled);
}
}
