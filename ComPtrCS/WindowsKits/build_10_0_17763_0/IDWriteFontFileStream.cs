/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDWriteFontFileStream : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteFontFileStream>.Value;
    public HRESULT ReadFileFragment(
        /// fragmentStart: (*(*(const void)))
        ref IntPtr fragmentStart
        /// fileOffset: (UINT64)
        , UInt64 fileOffset
        /// fragmentSize: (UINT64)
        , UInt64 fragmentSize
        /// fragmentContext: (*(*(void)))
        , ref IntPtr fragmentContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ReadFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFileFragmentFunc));
        return callback(Self, ref fragmentStart, fileOffset, fragmentSize, ref fragmentContext);
    }
    delegate HRESULT ReadFileFragmentFunc(IntPtr self, ref IntPtr fragmentStart, UInt64 fileOffset, UInt64 fragmentSize, ref IntPtr fragmentContext);
    public void ReleaseFileFragment(
        /// fragmentContext: (*(void))
        IntPtr fragmentContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFileFragmentFunc));
        callback(Self, fragmentContext);
    }
    delegate void ReleaseFileFragmentFunc(IntPtr self, IntPtr fragmentContext);
    public HRESULT GetFileSize(
        /// fileSize: (*(UINT64))
        ref UInt64 fileSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFileSizeFunc));
        return callback(Self, ref fileSize);
    }
    delegate HRESULT GetFileSizeFunc(IntPtr self, ref UInt64 fileSize);
    public HRESULT GetLastWriteTime(
        /// lastWriteTime: (*(UINT64))
        ref UInt64 lastWriteTime
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLastWriteTimeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFunc));
        return callback(Self, ref lastWriteTime);
    }
    delegate HRESULT GetLastWriteTimeFunc(IntPtr self, ref UInt64 lastWriteTime);
}
}
