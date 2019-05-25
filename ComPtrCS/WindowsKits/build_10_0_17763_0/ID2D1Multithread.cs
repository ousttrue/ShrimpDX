/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID2D1Multithread : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Multithread>.Value;
    public Int32 GetMultithreadProtected(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetMultithreadProtectedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMultithreadProtectedFunc));
        return callback(Self);
    }
    delegate Int32 GetMultithreadProtectedFunc(IntPtr self);
    public void Enter(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (EnterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnterFunc));
        callback(Self);
    }
    delegate void EnterFunc(IntPtr self);
    public void Leave(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (LeaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LeaveFunc));
        callback(Self);
    }
    delegate void LeaveFunc(IntPtr self);
}
}
