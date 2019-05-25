/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGISurface1: IDXGISurface {

    static /*readonly*/ Guid s_uuid = new Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGISurface1>.Value;
    public HRESULT GetDC(
        /// Discard: (BOOL)
        Int32 Discard
        /// phdc: (*(HDC))
        , ref IntPtr phdc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
        return callback(Self, Discard, ref phdc);
    }
    delegate HRESULT GetDCFunc(IntPtr self, Int32 Discard, ref IntPtr phdc);
    public HRESULT ReleaseDC(
        /// pDirtyRect: (*(RECT))
        ref RECT pDirtyRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
        return callback(Self, ref pDirtyRect);
    }
    delegate HRESULT ReleaseDCFunc(IntPtr self, ref RECT pDirtyRect);
}
}
