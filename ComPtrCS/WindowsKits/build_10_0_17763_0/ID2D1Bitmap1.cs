/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1Bitmap1: ID2D1Bitmap {

    static /*readonly*/ Guid s_uuid = new Guid("a898a84c-3873-4588-b08b-ebbf978df041");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Bitmap1>.Value;
    public void GetColorContext(
        /// colorContext: (*(*(ID2D1ColorContext)))
        ref IntPtr colorContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetColorContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorContextFunc));
        callback(Self, ref colorContext);
    }
    delegate void GetColorContextFunc(IntPtr self, ref IntPtr colorContext);
    public D2D1_BITMAP_OPTIONS GetOptions(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOptionsFunc));
        return callback(Self);
    }
    delegate D2D1_BITMAP_OPTIONS GetOptionsFunc(IntPtr self);
    public HRESULT GetSurface(
        /// dxgiSurface: (*(*(IDXGISurface)))
        ref IntPtr dxgiSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSurfaceFunc));
        return callback(Self, ref dxgiSurface);
    }
    delegate HRESULT GetSurfaceFunc(IntPtr self, ref IntPtr dxgiSurface);
    public HRESULT Map(
        /// options: (D2D1_MAP_OPTIONS)
        D2D1_MAP_OPTIONS options
        /// mappedRect: (*(D2D1_MAPPED_RECT))
        , ref D2D1_MAPPED_RECT mappedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, options, ref mappedRect);
    }
    delegate HRESULT MapFunc(IntPtr self, D2D1_MAP_OPTIONS options, ref D2D1_MAPPED_RECT mappedRect);
    public HRESULT Unmap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        return callback(Self);
    }
    delegate HRESULT UnmapFunc(IntPtr self);
}
}
