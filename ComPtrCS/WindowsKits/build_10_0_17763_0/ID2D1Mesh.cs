/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1Mesh: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906c2-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Mesh>.Value;
    public HRESULT Open(
        /// tessellationSink: (*(*(ID2D1TessellationSink)))
        ref IntPtr tessellationSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
        return callback(Self, ref tessellationSink);
    }
    delegate HRESULT OpenFunc(IntPtr self, ref IntPtr tessellationSink);
}
}
