/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1DrawingStateBlock1: ID2D1DrawingStateBlock {

    static /*readonly*/ Guid s_uuid = new Guid("689f1f85-c72e-4e33-8f19-85754efd5ace");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1DrawingStateBlock1>.Value;
    public void GetDescription(
        /// stateDescription: (*(D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void GetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
    public void SetDescription(
        /// stateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void SetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
}
}
