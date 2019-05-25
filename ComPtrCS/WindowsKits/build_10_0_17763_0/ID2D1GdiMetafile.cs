/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1GdiMetafile: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GdiMetafile>.Value;
    public HRESULT Stream(
        /// sink: (*(ID2D1GdiMetafileSink))
        IntPtr sink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, sink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr sink);
    public HRESULT GetBounds(
        /// bounds: (*(D2D1_RECT_F))
        ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoundsFunc));
        return callback(Self, ref bounds);
    }
    delegate HRESULT GetBoundsFunc(IntPtr self, ref D2D_RECT_F bounds);
}
}
