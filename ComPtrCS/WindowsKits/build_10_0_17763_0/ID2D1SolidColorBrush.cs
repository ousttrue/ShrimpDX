/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1SolidColorBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a9-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1SolidColorBrush>.Value;
    public void SetColor(
        /// color: (*(const D2D1_COLOR_F))
        ref Vector4 color
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetColorFunc));
        callback(Self, ref color);
    }
    delegate void SetColorFunc(IntPtr self, ref Vector4 color);
    public Vector4 GetColor(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorFunc));
        return callback(Self);
    }
    delegate Vector4 GetColorFunc(IntPtr self);
}
}
