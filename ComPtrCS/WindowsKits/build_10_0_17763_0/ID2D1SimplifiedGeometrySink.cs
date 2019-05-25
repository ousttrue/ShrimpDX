/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=7)]
public class ID2D1SimplifiedGeometrySink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069e-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1SimplifiedGeometrySink>.Value;
    public void SetFillMode(
        /// fillMode: (D2D1_FILL_MODE)
        D2D1_FILL_MODE fillMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFillModeFunc));
        callback(Self, fillMode);
    }
    delegate void SetFillModeFunc(IntPtr self, D2D1_FILL_MODE fillMode);
    public void SetSegmentFlags(
        /// vertexFlags: (D2D1_PATH_SEGMENT)
        D2D1_PATH_SEGMENT vertexFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetSegmentFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSegmentFlagsFunc));
        callback(Self, vertexFlags);
    }
    delegate void SetSegmentFlagsFunc(IntPtr self, D2D1_PATH_SEGMENT vertexFlags);
    public void BeginFigure(
        /// startPoint: (D2D1_POINT_2F)
        D2D_POINT_2F startPoint
        /// figureBegin: (D2D1_FIGURE_BEGIN)
        , D2D1_FIGURE_BEGIN figureBegin
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (BeginFigureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginFigureFunc));
        callback(Self, startPoint, figureBegin);
    }
    delegate void BeginFigureFunc(IntPtr self, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
    public void AddLines(
        /// points: (*(const D2D1_POINT_2F))
        ref D2D_POINT_2F points
        /// pointsCount: (UINT32)
        , UInt32 pointsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (AddLinesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddLinesFunc));
        callback(Self, ref points, pointsCount);
    }
    delegate void AddLinesFunc(IntPtr self, ref D2D_POINT_2F points, UInt32 pointsCount);
    public void AddBeziers(
        /// beziers: (*(const D2D1_BEZIER_SEGMENT))
        ref D2D1_BEZIER_SEGMENT beziers
        /// beziersCount: (UINT32)
        , UInt32 beziersCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (AddBeziersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddBeziersFunc));
        callback(Self, ref beziers, beziersCount);
    }
    delegate void AddBeziersFunc(IntPtr self, ref D2D1_BEZIER_SEGMENT beziers, UInt32 beziersCount);
    public void EndFigure(
        /// figureEnd: (D2D1_FIGURE_END)
        D2D1_FIGURE_END figureEnd
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (EndFigureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndFigureFunc));
        callback(Self, figureEnd);
    }
    delegate void EndFigureFunc(IntPtr self, D2D1_FIGURE_END figureEnd);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}
}
