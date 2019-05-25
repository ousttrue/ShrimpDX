/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1CommandList: ID2D1Image {

    static /*readonly*/ Guid s_uuid = new Guid("b4f34a19-2383-4d76-94f6-ec343657c3dc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1CommandList>.Value;
    public HRESULT Stream(
        /// sink: (*(ID2D1CommandSink))
        IntPtr sink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, sink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr sink);
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
