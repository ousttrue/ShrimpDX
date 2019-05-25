/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1TransformedGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906bb-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1TransformedGeometry>.Value;
    public void GetSourceGeometry(
        /// sourceGeometry: (*(*(ID2D1Geometry)))
        ref IntPtr sourceGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSourceGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometryFunc));
        callback(Self, ref sourceGeometry);
    }
    delegate void GetSourceGeometryFunc(IntPtr self, ref IntPtr sourceGeometry);
    public void GetTransform(
        /// transform: (*(D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void GetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
}
}
