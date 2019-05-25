/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGIFactory1: IDXGIFactory {

    static /*readonly*/ Guid s_uuid = new Guid("770aae78-f26f-4dba-a829-253c83d1b387");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIFactory1>.Value;
    public HRESULT EnumAdapters1(
        /// Adapter: (UINT)
        UInt32 Adapter
        /// ppAdapter: (*(*(IDXGIAdapter1)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (EnumAdapters1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdapters1Func));
        return callback(Self, Adapter, ref ppAdapter);
    }
    delegate HRESULT EnumAdapters1Func(IntPtr self, UInt32 Adapter, ref IntPtr ppAdapter);
    public Int32 IsCurrent(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (IsCurrentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsCurrentFunc));
        return callback(Self);
    }
    delegate Int32 IsCurrentFunc(IntPtr self);
}
}
