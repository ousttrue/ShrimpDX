/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class ID3D11AuthenticatedChannel: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3015a308-dcbd-47aa-a747-192486d14d4a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11AuthenticatedChannel>.Value;
    public HRESULT GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetCertificateSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateSizeFunc));
        return callback(Self, ref pCertificateSize);
    }
    delegate HRESULT GetCertificateSizeFunc(IntPtr self, ref UInt32 pCertificateSize);
    public HRESULT GetCertificate(
        /// CertificateSize: (UINT)
        UInt32 CertificateSize
        /// pCertificate: (*(BYTE))
        , ref Byte pCertificate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
        return callback(Self, CertificateSize, ref pCertificate);
    }
    delegate HRESULT GetCertificateFunc(IntPtr self, UInt32 CertificateSize, ref Byte pCertificate);
    public void GetChannelHandle(
        /// pChannelHandle: (*(HANDLE))
        ref IntPtr pChannelHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetChannelHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetChannelHandleFunc));
        callback(Self, ref pChannelHandle);
    }
    delegate void GetChannelHandleFunc(IntPtr self, ref IntPtr pChannelHandle);
}
}
