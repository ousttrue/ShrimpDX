/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID2D1HwndRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90698-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1HwndRenderTarget>.Value;
    public D2D1_WINDOW_STATE CheckWindowState(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CheckWindowStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckWindowStateFunc));
        return callback(Self);
    }
    delegate D2D1_WINDOW_STATE CheckWindowStateFunc(IntPtr self);
    public HRESULT Resize(
        /// pixelSize: (*(const D2D1_SIZE_U))
        ref D2D_SIZE_U pixelSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ResizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeFunc));
        return callback(Self, ref pixelSize);
    }
    delegate HRESULT ResizeFunc(IntPtr self, ref D2D_SIZE_U pixelSize);
    public IntPtr GetHwnd(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
        return callback(Self);
    }
    delegate IntPtr GetHwndFunc(IntPtr self);
}
}
