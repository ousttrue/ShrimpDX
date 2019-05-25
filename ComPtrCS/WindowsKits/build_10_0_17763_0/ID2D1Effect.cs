/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1Effect: ID2D1Properties {

    static /*readonly*/ Guid s_uuid = new Guid("28211a43-7d89-476f-8181-2d6159b220ad");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Effect>.Value;
    public void SetInput(
        /// index: (UINT32)
        UInt32 index
        /// input: (*(ID2D1Image))
        , IntPtr input
        /// invalidate: (BOOL)
        , Int32 invalidate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputFunc));
        callback(Self, index, input, invalidate);
    }
    delegate void SetInputFunc(IntPtr self, UInt32 index, IntPtr input, Int32 invalidate);
    public HRESULT SetInputCount(
        /// inputCount: (UINT32)
        UInt32 inputCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputCountFunc));
        return callback(Self, inputCount);
    }
    delegate HRESULT SetInputCountFunc(IntPtr self, UInt32 inputCount);
    public void GetInput(
        /// index: (UINT32)
        UInt32 index
        /// input: (*(*(ID2D1Image)))
        , ref IntPtr input
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputFunc));
        callback(Self, index, ref input);
    }
    delegate void GetInputFunc(IntPtr self, UInt32 index, ref IntPtr input);
    public UInt32 GetInputCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetInputCountFunc(IntPtr self);
    public void GetOutput(
        /// outputImage: (*(*(ID2D1Image)))
        ref IntPtr outputImage
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOutputFunc));
        callback(Self, ref outputImage);
    }
    delegate void GetOutputFunc(IntPtr self, ref IntPtr outputImage);
}
}
