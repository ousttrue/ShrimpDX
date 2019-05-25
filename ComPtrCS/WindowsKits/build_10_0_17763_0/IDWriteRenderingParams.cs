/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class IDWriteRenderingParams : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteRenderingParams>.Value;
    public Single GetGamma(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGammaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaFunc));
        return callback(Self);
    }
    delegate Single GetGammaFunc(IntPtr self);
    public Single GetEnhancedContrast(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetEnhancedContrastFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEnhancedContrastFunc));
        return callback(Self);
    }
    delegate Single GetEnhancedContrastFunc(IntPtr self);
    public Single GetClearTypeLevel(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetClearTypeLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClearTypeLevelFunc));
        return callback(Self);
    }
    delegate Single GetClearTypeLevelFunc(IntPtr self);
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetPixelGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelGeometryFunc));
        return callback(Self);
    }
    delegate DWRITE_PIXEL_GEOMETRY GetPixelGeometryFunc(IntPtr self);
    public DWRITE_RENDERING_MODE GetRenderingMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetRenderingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRenderingModeFunc));
        return callback(Self);
    }
    delegate DWRITE_RENDERING_MODE GetRenderingModeFunc(IntPtr self);
}
}
