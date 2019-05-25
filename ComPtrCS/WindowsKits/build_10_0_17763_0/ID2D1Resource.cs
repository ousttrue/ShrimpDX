/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1Resource : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd90691-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Resource>.Value;
    public void GetFactory(
        /// factory: (*(*(ID2D1Factory)))
        ref IntPtr factory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFactoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFactoryFunc));
        callback(Self, ref factory);
    }
    delegate void GetFactoryFunc(IntPtr self, ref IntPtr factory);
}
}
