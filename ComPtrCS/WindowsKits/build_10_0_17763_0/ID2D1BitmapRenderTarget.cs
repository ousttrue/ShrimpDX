/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1BitmapRenderTarget: ID2D1RenderTarget {

    static /*readonly*/ Guid s_uuid = new Guid("2cd90695-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1BitmapRenderTarget>.Value;
    public HRESULT GetBitmap(
        /// bitmap: (*(*(ID2D1Bitmap)))
        ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBitmapFunc));
        return callback(Self, ref bitmap);
    }
    delegate HRESULT GetBitmapFunc(IntPtr self, ref IntPtr bitmap);
}
}
