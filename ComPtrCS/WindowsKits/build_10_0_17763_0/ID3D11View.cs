/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11View: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11View>.Value;
    public void GetResource(
        /// ppResource: (*(*(ID3D11Resource)))
        ref IntPtr ppResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
        callback(Self, ref ppResource);
    }
    delegate void GetResourceFunc(IntPtr self, ref IntPtr ppResource);
}
}
