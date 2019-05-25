/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3DInclude : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3DInclude>.Value;
    public HRESULT Open(
        /// IncludeType: (D3D_INCLUDE_TYPE)
        D3D_INCLUDE_TYPE IncludeType
        /// pFileName: (LPCSTR)
        , IntPtr pFileName
        /// pParentData: (LPCVOID)
        , IntPtr pParentData
        /// ppData: (*(LPCVOID))
        , ref IntPtr ppData
        /// pBytes: (*(UINT))
        , ref UInt32 pBytes
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
        return callback(Self, IncludeType, pFileName, pParentData, ref ppData, ref pBytes);
    }
    delegate HRESULT OpenFunc(IntPtr self, D3D_INCLUDE_TYPE IncludeType, IntPtr pFileName, IntPtr pParentData, ref IntPtr ppData, ref UInt32 pBytes);
    public HRESULT Close(
        /// pData: (LPCVOID)
        IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
        return callback(Self, pData);
    }
    delegate HRESULT CloseFunc(IntPtr self, IntPtr pData);
}
}
