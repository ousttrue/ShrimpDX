/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1GdiInteropRenderTarget : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GdiInteropRenderTarget>.Value;
    public HRESULT GetDC(
        /// mode: (D2D1_DC_INITIALIZE_MODE)
        D2D1_DC_INITIALIZE_MODE mode
        /// hdc: (*(HDC))
        , ref IntPtr hdc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
        return callback(Self, mode, ref hdc);
    }
    delegate HRESULT GetDCFunc(IntPtr self, D2D1_DC_INITIALIZE_MODE mode, ref IntPtr hdc);
    public HRESULT ReleaseDC(
        /// update: (*(const RECT))
        ref RECT update
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
        return callback(Self, ref update);
    }
    delegate HRESULT ReleaseDCFunc(IntPtr self, ref RECT update);
}
}
