/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1GeometrySink: ID2D1SimplifiedGeometrySink {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069f-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GeometrySink>.Value;
    public void AddLine(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddLineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddLineFunc));
        callback(Self, point);
    }
    delegate void AddLineFunc(IntPtr self, D2D_POINT_2F point);
    public void AddBezier(
        /// bezier: (*(const D2D1_BEZIER_SEGMENT))
        ref D2D1_BEZIER_SEGMENT bezier
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (AddBezierFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddBezierFunc));
        callback(Self, ref bezier);
    }
    delegate void AddBezierFunc(IntPtr self, ref D2D1_BEZIER_SEGMENT bezier);
    public void AddQuadraticBezier(
        /// bezier: (*(const D2D1_QUADRATIC_BEZIER_SEGMENT))
        ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (AddQuadraticBezierFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddQuadraticBezierFunc));
        callback(Self, ref bezier);
    }
    delegate void AddQuadraticBezierFunc(IntPtr self, ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier);
    public void AddQuadraticBeziers(
        /// beziers: (*(const D2D1_QUADRATIC_BEZIER_SEGMENT))
        ref D2D1_QUADRATIC_BEZIER_SEGMENT beziers
        /// beziersCount: (UINT32)
        , UInt32 beziersCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (AddQuadraticBeziersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddQuadraticBeziersFunc));
        callback(Self, ref beziers, beziersCount);
    }
    delegate void AddQuadraticBeziersFunc(IntPtr self, ref D2D1_QUADRATIC_BEZIER_SEGMENT beziers, UInt32 beziersCount);
    public void AddArc(
        /// arc: (*(const D2D1_ARC_SEGMENT))
        ref D2D1_ARC_SEGMENT arc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (AddArcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddArcFunc));
        callback(Self, ref arc);
    }
    delegate void AddArcFunc(IntPtr self, ref D2D1_ARC_SEGMENT arc);
}
}
