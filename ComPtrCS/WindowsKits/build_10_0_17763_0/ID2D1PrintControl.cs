/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1PrintControl : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1PrintControl>.Value;
    public HRESULT AddPage(
        /// commandList: (*(ID2D1CommandList))
        IntPtr commandList
        /// pageSize: (D2D_SIZE_F)
        , D2D_SIZE_F pageSize
        /// pagePrintTicketStream: (*(IStream))
        , IntPtr pagePrintTicketStream
        /// tag1: (*(D2D1_TAG))
        , ref D2D1_TAG tag1
        /// tag2: (*(D2D1_TAG))
        , ref D2D1_TAG tag2
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddPageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddPageFunc));
        return callback(Self, commandList, pageSize, pagePrintTicketStream, ref tag1, ref tag2);
    }
    delegate HRESULT AddPageFunc(IntPtr self, IntPtr commandList, D2D_SIZE_F pageSize, IntPtr pagePrintTicketStream, ref D2D1_TAG tag1, ref D2D1_TAG tag2);
    public HRESULT Close(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self);
    }
    delegate HRESULT CloseFunc(IntPtr self);
}
}
