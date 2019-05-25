/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID2D1GeometryGroup: ID2D1Geometry {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a6-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GeometryGroup>.Value;
    public D2D1_FILL_MODE GetFillMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFillModeFunc));
        return callback(Self);
    }
    delegate D2D1_FILL_MODE GetFillModeFunc(IntPtr self);
    public UInt32 GetSourceGeometryCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetSourceGeometryCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometryCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetSourceGeometryCountFunc(IntPtr self);
    public void GetSourceGeometries(
        /// geometries: (*(*(ID2D1Geometry)))
        ref IntPtr geometries
        /// geometriesCount: (UINT32)
        , UInt32 geometriesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSourceGeometriesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometriesFunc));
        callback(Self, ref geometries, geometriesCount);
    }
    delegate void GetSourceGeometriesFunc(IntPtr self, ref IntPtr geometries, UInt32 geometriesCount);
}
}
