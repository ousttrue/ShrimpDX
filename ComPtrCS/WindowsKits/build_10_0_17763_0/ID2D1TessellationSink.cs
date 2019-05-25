/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1TessellationSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd906c1-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1TessellationSink>.Value;
    public void AddTriangles(
        /// triangles: (*(const D2D1_TRIANGLE))
        ref D2D1_TRIANGLE triangles
        /// trianglesCount: (UINT32)
        , UInt32 trianglesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddTrianglesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddTrianglesFunc));
        callback(Self, ref triangles, trianglesCount);
    }
    delegate void AddTrianglesFunc(IntPtr self, ref D2D1_TRIANGLE triangles, UInt32 trianglesCount);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}
}
