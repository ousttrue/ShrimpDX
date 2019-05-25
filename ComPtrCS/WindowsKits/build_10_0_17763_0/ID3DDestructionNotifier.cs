/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3DDestructionNotifier : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3DDestructionNotifier>.Value;
    public HRESULT RegisterDestructionCallback(
        /// callbackFn: (PFN_DESTRUCTION_CALLBACK)
        PFN_DESTRUCTION_CALLBACK callbackFn
        /// pData: (*(void))
        , IntPtr pData
        /// pCallbackID: (*(UINT))
        , ref UInt32 pCallbackID
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (RegisterDestructionCallbackFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterDestructionCallbackFunc));
        return callback(Self, callbackFn, pData, ref pCallbackID);
    }
    delegate HRESULT RegisterDestructionCallbackFunc(IntPtr self, PFN_DESTRUCTION_CALLBACK callbackFn, IntPtr pData, ref UInt32 pCallbackID);
    public HRESULT UnregisterDestructionCallback(
        /// callbackID: (UINT)
        UInt32 callbackID
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (UnregisterDestructionCallbackFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterDestructionCallbackFunc));
        return callback(Self, callbackID);
    }
    delegate HRESULT UnregisterDestructionCallbackFunc(IntPtr self, UInt32 callbackID);
}
}
