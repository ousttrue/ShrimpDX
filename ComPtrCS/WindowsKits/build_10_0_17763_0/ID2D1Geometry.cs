/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=13)]
public class ID2D1Geometry: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a1-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Geometry>.Value;
    public HRESULT GetBounds(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// bounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoundsFunc));
        return callback(Self, ref worldTransform, ref bounds);
    }
    delegate HRESULT GetBoundsFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, ref D2D_RECT_F bounds);
    public HRESULT GetWidenedBounds(
        /// strokeWidth: (FLOAT)
        Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// bounds: (*(D2D1_RECT_F))
        , ref D2D_RECT_F bounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetWidenedBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWidenedBoundsFunc));
        return callback(Self, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, ref bounds);
    }
    delegate HRESULT GetWidenedBoundsFunc(IntPtr self, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D_RECT_F bounds);
    public HRESULT StrokeContainsPoint(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
        /// strokeWidth: (FLOAT)
        , Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// contains: (*(BOOL))
        , IntPtr contains
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (StrokeContainsPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StrokeContainsPointFunc));
        return callback(Self, point, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, contains);
    }
    delegate HRESULT StrokeContainsPointFunc(IntPtr self, D2D_POINT_2F point, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr contains);
    public HRESULT FillContainsPoint(
        /// point: (D2D1_POINT_2F)
        D2D_POINT_2F point
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// contains: (*(BOOL))
        , IntPtr contains
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (FillContainsPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillContainsPointFunc));
        return callback(Self, point, ref worldTransform, flatteningTolerance, contains);
    }
    delegate HRESULT FillContainsPointFunc(IntPtr self, D2D_POINT_2F point, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr contains);
    public HRESULT CompareWithGeometry(
        /// inputGeometry: (*(ID2D1Geometry))
        IntPtr inputGeometry
        /// inputGeometryTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F inputGeometryTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// relation: (*(D2D1_GEOMETRY_RELATION))
        , ref D2D1_GEOMETRY_RELATION relation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CompareWithGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CompareWithGeometryFunc));
        return callback(Self, inputGeometry, ref inputGeometryTransform, flatteningTolerance, ref relation);
    }
    delegate HRESULT CompareWithGeometryFunc(IntPtr self, IntPtr inputGeometry, ref D2D_MATRIX_3X2_F inputGeometryTransform, Single flatteningTolerance, ref D2D1_GEOMETRY_RELATION relation);
    public HRESULT Simplify(
        /// simplificationOption: (D2D1_GEOMETRY_SIMPLIFICATION_OPTION)
        D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SimplifyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SimplifyFunc));
        return callback(Self, simplificationOption, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT SimplifyFunc(IntPtr self, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT Tessellate(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// tessellationSink: (*(ID2D1TessellationSink))
        , IntPtr tessellationSink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (TessellateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TessellateFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, tessellationSink);
    }
    delegate HRESULT TessellateFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr tessellationSink);
    public HRESULT CombineWithGeometry(
        /// inputGeometry: (*(ID2D1Geometry))
        IntPtr inputGeometry
        /// combineMode: (D2D1_COMBINE_MODE)
        , D2D1_COMBINE_MODE combineMode
        /// inputGeometryTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F inputGeometryTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CombineWithGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CombineWithGeometryFunc));
        return callback(Self, inputGeometry, combineMode, ref inputGeometryTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT CombineWithGeometryFunc(IntPtr self, IntPtr inputGeometry, D2D1_COMBINE_MODE combineMode, ref D2D_MATRIX_3X2_F inputGeometryTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT Outline(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (OutlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OutlineFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT OutlineFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
    public HRESULT ComputeArea(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// area: (*(FLOAT))
        , ref Single area
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (ComputeAreaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputeAreaFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, ref area);
    }
    delegate HRESULT ComputeAreaFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref Single area);
    public HRESULT ComputeLength(
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// length: (*(FLOAT))
        , ref Single length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (ComputeLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputeLengthFunc));
        return callback(Self, ref worldTransform, flatteningTolerance, ref length);
    }
    delegate HRESULT ComputeLengthFunc(IntPtr self, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref Single length);
    public HRESULT ComputePointAtLength(
        /// length: (FLOAT)
        Single length
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// point: (*(D2D1_POINT_2F))
        , ref D2D_POINT_2F point
        /// unitTangentVector: (*(D2D1_POINT_2F))
        , ref D2D_POINT_2F unitTangentVector
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (ComputePointAtLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ComputePointAtLengthFunc));
        return callback(Self, length, ref worldTransform, flatteningTolerance, ref point, ref unitTangentVector);
    }
    delegate HRESULT ComputePointAtLengthFunc(IntPtr self, Single length, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, ref D2D_POINT_2F point, ref D2D_POINT_2F unitTangentVector);
    public HRESULT Widen(
        /// strokeWidth: (FLOAT)
        Single strokeWidth
        /// strokeStyle: (*(ID2D1StrokeStyle))
        , IntPtr strokeStyle
        /// worldTransform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F worldTransform
        /// flatteningTolerance: (FLOAT)
        , Single flatteningTolerance
        /// geometrySink: (*(ID2D1SimplifiedGeometrySink))
        , IntPtr geometrySink
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (WidenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WidenFunc));
        return callback(Self, strokeWidth, strokeStyle, ref worldTransform, flatteningTolerance, geometrySink);
    }
    delegate HRESULT WidenFunc(IntPtr self, Single strokeWidth, IntPtr strokeStyle, ref D2D_MATRIX_3X2_F worldTransform, Single flatteningTolerance, IntPtr geometrySink);
}
}
