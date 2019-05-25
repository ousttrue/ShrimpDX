/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWritePixelSnapping : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWritePixelSnapping>.Value;
    public HRESULT IsPixelSnappingDisabled(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// isDisabled: (*(BOOL))
        , IntPtr isDisabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsPixelSnappingDisabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsPixelSnappingDisabledFunc));
        return callback(Self, clientDrawingContext, isDisabled);
    }
    delegate HRESULT IsPixelSnappingDisabledFunc(IntPtr self, IntPtr clientDrawingContext, IntPtr isDisabled);
    public HRESULT GetCurrentTransform(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// transform: (*(DWRITE_MATRIX))
        , ref DWRITE_MATRIX transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentTransformFunc));
        return callback(Self, clientDrawingContext, ref transform);
    }
    delegate HRESULT GetCurrentTransformFunc(IntPtr self, IntPtr clientDrawingContext, ref DWRITE_MATRIX transform);
    public HRESULT GetPixelsPerDip(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// pixelsPerDip: (*(FLOAT))
        , ref Single pixelsPerDip
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelsPerDipFunc));
        return callback(Self, clientDrawingContext, ref pixelsPerDip);
    }
    delegate HRESULT GetPixelsPerDipFunc(IntPtr self, IntPtr clientDrawingContext, ref Single pixelsPerDip);
}
}
