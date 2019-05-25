/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1EllipseGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a4-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1EllipseGeometry>.Value;
    public void GetEllipse(
        /// ellipse: (*(D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetEllipseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEllipseFunc));
        callback(Self, ref ellipse);
    }
    delegate void GetEllipseFunc(IntPtr self, ref D2D1_ELLIPSE ellipse);
}
}
