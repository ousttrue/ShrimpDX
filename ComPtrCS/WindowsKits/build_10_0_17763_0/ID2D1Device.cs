/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1Device: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("47dd575d-ac05-4cdd-8049-9b02cd16f44c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Device>.Value;
    public HRESULT CreateDeviceContext(
        /// options: (D2D1_DEVICE_CONTEXT_OPTIONS)
        D2D1_DEVICE_CONTEXT_OPTIONS options
        /// deviceContext: (*(*(ID2D1DeviceContext)))
        , ref IntPtr deviceContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateDeviceContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeviceContextFunc));
        return callback(Self, options, ref deviceContext);
    }
    delegate HRESULT CreateDeviceContextFunc(IntPtr self, D2D1_DEVICE_CONTEXT_OPTIONS options, ref IntPtr deviceContext);
    public HRESULT CreatePrintControl(
        /// wicFactory: (*(IWICImagingFactory))
        IntPtr wicFactory
        /// documentTarget: (*(IPrintDocumentPackageTarget))
        , IntPtr documentTarget
        /// printControlProperties: (*(const D2D1_PRINT_CONTROL_PROPERTIES))
        , ref D2D1_PRINT_CONTROL_PROPERTIES printControlProperties
        /// printControl: (*(*(ID2D1PrintControl)))
        , ref IntPtr printControl
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreatePrintControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePrintControlFunc));
        return callback(Self, wicFactory, documentTarget, ref printControlProperties, ref printControl);
    }
    delegate HRESULT CreatePrintControlFunc(IntPtr self, IntPtr wicFactory, IntPtr documentTarget, ref D2D1_PRINT_CONTROL_PROPERTIES printControlProperties, ref IntPtr printControl);
    public void SetMaximumTextureMemory(
        /// maximumInBytes: (UINT64)
        UInt64 maximumInBytes
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetMaximumTextureMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumTextureMemoryFunc));
        callback(Self, maximumInBytes);
    }
    delegate void SetMaximumTextureMemoryFunc(IntPtr self, UInt64 maximumInBytes);
    public UInt64 GetMaximumTextureMemory(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetMaximumTextureMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumTextureMemoryFunc));
        return callback(Self);
    }
    delegate UInt64 GetMaximumTextureMemoryFunc(IntPtr self);
    public void ClearResources(
        /// millisecondsSinceUse: (UINT32)
        UInt32 millisecondsSinceUse
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (ClearResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearResourcesFunc));
        callback(Self, millisecondsSinceUse);
    }
    delegate void ClearResourcesFunc(IntPtr self, UInt32 millisecondsSinceUse);
}
}
