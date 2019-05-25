/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1GdiMetafileSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("82237326-8111-4f7c-bcf4-b5c1175564fe");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GdiMetafileSink>.Value;
    public HRESULT ProcessRecord(
        /// recordType: (DWORD)
        UInt32 recordType
        /// recordData: (*(const void))
        , IntPtr recordData
        /// recordDataSize: (DWORD)
        , UInt32 recordDataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ProcessRecordFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessRecordFunc));
        return callback(Self, recordType, recordData, recordDataSize);
    }
    delegate HRESULT ProcessRecordFunc(IntPtr self, UInt32 recordType, IntPtr recordData, UInt32 recordDataSize);
}
}
