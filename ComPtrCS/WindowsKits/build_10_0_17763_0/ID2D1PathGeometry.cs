/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID2D1PathGeometry: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a5-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1PathGeometry>.Value;
    public HRESULT Open(
        /// geometrySink: (*(*(ID2D1GeometrySink)))
        ref IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
        return callback(Self, ref geometrySink);
    }
    delegate HRESULT OpenFunc(IntPtr self, ref IntPtr geometrySink);
    public HRESULT Stream(
        /// geometrySink: (*(ID2D1GeometrySink))
        IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
        return callback(Self, geometrySink);
    }
    delegate HRESULT StreamFunc(IntPtr self, IntPtr geometrySink);
    public HRESULT GetSegmentCount(
        /// count: (*(UINT32))
        ref UInt32 count
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSegmentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSegmentCountFunc));
        return callback(Self, ref count);
    }
    delegate HRESULT GetSegmentCountFunc(IntPtr self, ref UInt32 count);
    public HRESULT GetFigureCount(
        /// count: (*(UINT32))
        ref UInt32 count
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFigureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFigureCountFunc));
        return callback(Self, ref count);
    }
    delegate HRESULT GetFigureCountFunc(IntPtr self, ref UInt32 count);
}
}
