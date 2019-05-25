/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1PathGeometry1: ID2D1PathGeometry {

    static /*readonly*/ Guid s_uuid = new Guid("62baa2d2-ab54-41b7-b872-787e0106a421");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1PathGeometry1>.Value;
    public HRESULT ComputePointAndSegmentAtLength(
        /// length: (FLOAT)
        Single length
        /// startSegment: (UINT32)
        , UInt32 startSegment
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// pointDescription: (*(D2D1_POINT_DESCRIPTION))
        , ref D2D1_POINT_DESCRIPTION pointDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ComputePointAndSegmentAtLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputePointAndSegmentAtLengthFunc));
        return callback(Self, length, startSegment, ref worldTransform, flatteningTolerance, ref pointDescription);
    }
    delegate HRESULT ComputePointAndSegmentAtLengthFunc(IntPtr self, Single length, UInt32 startSegment, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D1_POINT_DESCRIPTION pointDescription);
}
}
