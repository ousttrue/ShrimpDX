/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_FRAME_STATISTICS{
    /// (UINT)
    public UInt32 PresentCount;

    /// (UINT)
    public UInt32 PresentRefreshCount;

    /// (UINT)
    public UInt32 SyncRefreshCount;

    /// (LARGE_INTEGER)
    public Int64 SyncQPCTime;

    /// (LARGE_INTEGER)
    public Int64 SyncGPUTime;

}
}
