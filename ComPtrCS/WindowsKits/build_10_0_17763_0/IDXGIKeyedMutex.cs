/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGIKeyedMutex: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("9d8e1289-d7b3-465f-8126-250e349af85d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIKeyedMutex>.Value;
    public HRESULT AcquireSync(
        /// Key: (UINT64)
        UInt64 Key
        /// dwMilliseconds: (DWORD)
        , UInt32 dwMilliseconds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AcquireSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireSyncFunc));
        return callback(Self, Key, dwMilliseconds);
    }
    delegate HRESULT AcquireSyncFunc(IntPtr self, UInt64 Key, UInt32 dwMilliseconds);
    public HRESULT ReleaseSync(
        /// Key: (UINT64)
        UInt64 Key
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseSyncFunc));
        return callback(Self, Key);
    }
    delegate HRESULT ReleaseSyncFunc(IntPtr self, UInt64 Key);
}
}
