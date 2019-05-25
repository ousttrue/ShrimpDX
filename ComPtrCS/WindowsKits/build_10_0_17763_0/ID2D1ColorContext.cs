/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID2D1ColorContext: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1ColorContext>.Value;
    public D2D1_COLOR_SPACE GetColorSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetColorSpaceFunc(IntPtr self);
    public UInt32 GetProfileSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetProfileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileSizeFunc));
        return callback(Self);
    }
    delegate UInt32 GetProfileSizeFunc(IntPtr self);
    public HRESULT GetProfile(
        /// profile: (*(BYTE))
        ref Byte profile
        /// profileSize: (UINT32)
        , UInt32 profileSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileFunc));
        return callback(Self, ref profile, profileSize);
    }
    delegate HRESULT GetProfileFunc(IntPtr self, ref Byte profile, UInt32 profileSize);
}
}
