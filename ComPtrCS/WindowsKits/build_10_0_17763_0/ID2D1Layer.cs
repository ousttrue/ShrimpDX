/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1Layer: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069b-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Layer>.Value;
    public D2D_SIZE_F GetSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_F GetSizeFunc(IntPtr self);
}
}
