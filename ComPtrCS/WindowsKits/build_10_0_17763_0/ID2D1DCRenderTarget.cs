/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1DCRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("1c51bc64-de61-46fd-9899-63a5d8f03950");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1DCRenderTarget>.Value;
    public HRESULT BindDC(
        /// hDC: (const HDC)
        IntPtr hDC
        /// pSubRect: (*(const RECT))
        , ref RECT pSubRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (BindDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindDCFunc));
        return callback(Self, hDC, ref pSubRect);
    }
    delegate HRESULT BindDCFunc(IntPtr self, IntPtr hDC, ref RECT pSubRect);
}
}
