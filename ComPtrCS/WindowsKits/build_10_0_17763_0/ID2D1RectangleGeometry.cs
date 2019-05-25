/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1RectangleGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a2-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1RectangleGeometry>.Value;
    public void GetRect(
        /// rect: (*(D2D1_RECT_F))
        ref D2D_RECT_F rect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRectFunc));
        callback(Self, ref rect);
    }
    delegate void GetRectFunc(IntPtr self, ref D2D_RECT_F rect);
}
}
