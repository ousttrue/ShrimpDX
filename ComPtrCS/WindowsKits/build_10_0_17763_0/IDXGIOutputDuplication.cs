/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=8)]
public class IDXGIOutputDuplication: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("191cfac3-a341-470d-b26e-a864f428319c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIOutputDuplication>.Value;
    public void GetDesc(
        /// pDesc: (*(DXGI_OUTDUPL_DESC))
        ref DXGI_OUTDUPL_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref DXGI_OUTDUPL_DESC pDesc);
    public HRESULT AcquireNextFrame(
        /// TimeoutInMilliseconds: (UINT)
        UInt32 TimeoutInMilliseconds
        /// pFrameInfo: (*(DXGI_OUTDUPL_FRAME_INFO))
        , ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo
        /// ppDesktopResource: (*(*(IDXGIResource)))
        , ref IntPtr ppDesktopResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (AcquireNextFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireNextFrameFunc));
        return callback(Self, TimeoutInMilliseconds, ref pFrameInfo, ref ppDesktopResource);
    }
    delegate HRESULT AcquireNextFrameFunc(IntPtr self, UInt32 TimeoutInMilliseconds, ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo, ref IntPtr ppDesktopResource);
    public HRESULT GetFrameDirtyRects(
        /// DirtyRectsBufferSize: (UINT)
        UInt32 DirtyRectsBufferSize
        /// pDirtyRectsBuffer: (*(RECT))
        , ref RECT pDirtyRectsBuffer
        /// pDirtyRectsBufferSizeRequired: (*(UINT))
        , ref UInt32 pDirtyRectsBufferSizeRequired
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFrameDirtyRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameDirtyRectsFunc));
        return callback(Self, DirtyRectsBufferSize, ref pDirtyRectsBuffer, ref pDirtyRectsBufferSizeRequired);
    }
    delegate HRESULT GetFrameDirtyRectsFunc(IntPtr self, UInt32 DirtyRectsBufferSize, ref RECT pDirtyRectsBuffer, ref UInt32 pDirtyRectsBufferSizeRequired);
    public HRESULT GetFrameMoveRects(
        /// MoveRectsBufferSize: (UINT)
        UInt32 MoveRectsBufferSize
        /// pMoveRectBuffer: (*(DXGI_OUTDUPL_MOVE_RECT))
        , ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer
        /// pMoveRectsBufferSizeRequired: (*(UINT))
        , ref UInt32 pMoveRectsBufferSizeRequired
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFrameMoveRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameMoveRectsFunc));
        return callback(Self, MoveRectsBufferSize, ref pMoveRectBuffer, ref pMoveRectsBufferSizeRequired);
    }
    delegate HRESULT GetFrameMoveRectsFunc(IntPtr self, UInt32 MoveRectsBufferSize, ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer, ref UInt32 pMoveRectsBufferSizeRequired);
    public HRESULT GetFramePointerShape(
        /// PointerShapeBufferSize: (UINT)
        UInt32 PointerShapeBufferSize
        /// pPointerShapeBuffer: (*(void))
        , IntPtr pPointerShapeBuffer
        /// pPointerShapeBufferSizeRequired: (*(UINT))
        , ref UInt32 pPointerShapeBufferSizeRequired
        /// pPointerShapeInfo: (*(DXGI_OUTDUPL_POINTER_SHAPE_INFO))
        , ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetFramePointerShapeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFramePointerShapeFunc));
        return callback(Self, PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired, ref pPointerShapeInfo);
    }
    delegate HRESULT GetFramePointerShapeFunc(IntPtr self, UInt32 PointerShapeBufferSize, IntPtr pPointerShapeBuffer, ref UInt32 pPointerShapeBufferSizeRequired, ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);
    public HRESULT MapDesktopSurface(
        /// pLockedRect: (*(DXGI_MAPPED_RECT))
        ref DXGI_MAPPED_RECT pLockedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (MapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapDesktopSurfaceFunc));
        return callback(Self, ref pLockedRect);
    }
    delegate HRESULT MapDesktopSurfaceFunc(IntPtr self, ref DXGI_MAPPED_RECT pLockedRect);
    public HRESULT UnMapDesktopSurface(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (UnMapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnMapDesktopSurfaceFunc));
        return callback(Self);
    }
    delegate HRESULT UnMapDesktopSurfaceFunc(IntPtr self);
    public HRESULT ReleaseFrame(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (ReleaseFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFrameFunc));
        return callback(Self);
    }
    delegate HRESULT ReleaseFrameFunc(IntPtr self);
}
}
