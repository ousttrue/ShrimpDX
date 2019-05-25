/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID3D11CryptoSession: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11CryptoSession>.Value;
    public void GetCryptoType(
        /// pCryptoType: (*(GUID))
        ref Guid pCryptoType
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetCryptoTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoTypeFunc));
        callback(Self, ref pCryptoType);
    }
    delegate void GetCryptoTypeFunc(IntPtr self, ref Guid pCryptoType);
    public void GetDecoderProfile(
        /// pDecoderProfile: (*(GUID))
        ref Guid pDecoderProfile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderProfileFunc));
        callback(Self, ref pDecoderProfile);
    }
    delegate void GetDecoderProfileFunc(IntPtr self, ref Guid pDecoderProfile);
    public HRESULT GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
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
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
        return callback(Self, CertificateSize, ref pCertificate);
    }
    delegate HRESULT GetCertificateFunc(IntPtr self, UInt32 CertificateSize, ref Byte pCertificate);
    public void GetCryptoSessionHandle(
        /// pCryptoSessionHandle: (*(HANDLE))
        ref IntPtr pCryptoSessionHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetCryptoSessionHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoSessionHandleFunc));
        callback(Self, ref pCryptoSessionHandle);
    }
    delegate void GetCryptoSessionHandleFunc(IntPtr self, ref IntPtr pCryptoSessionHandle);
}
}
