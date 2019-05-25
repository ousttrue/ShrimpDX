/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1RoundedRectangleGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a3-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1RoundedRectangleGeometry>.Value;
    public void GetRoundedRect(
        /// roundedRect: (*(D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetRoundedRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRoundedRectFunc));
        callback(Self, ref roundedRect);
    }
    delegate void GetRoundedRectFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRect);
}
}
