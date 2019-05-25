/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDWriteTextAnalysisSink : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteTextAnalysisSink>.Value;
    public HRESULT SetScriptAnalysis(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// scriptAnalysis: (*(const DWRITE_SCRIPT_ANALYSIS))
        , ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetScriptAnalysisFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetScriptAnalysisFunc));
        return callback(Self, textPosition, textLength, ref scriptAnalysis);
    }
    delegate HRESULT SetScriptAnalysisFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis);
    public HRESULT SetLineBreakpoints(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// lineBreakpoints: (*(const DWRITE_LINE_BREAKPOINT))
        , ref DWRITE_LINE_BREAKPOINT lineBreakpoints
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetLineBreakpointsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLineBreakpointsFunc));
        return callback(Self, textPosition, textLength, ref lineBreakpoints);
    }
    delegate HRESULT SetLineBreakpointsFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, ref DWRITE_LINE_BREAKPOINT lineBreakpoints);
    public HRESULT SetBidiLevel(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// explicitLevel: (UINT8)
        , Byte explicitLevel
        /// resolvedLevel: (UINT8)
        , Byte resolvedLevel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetBidiLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBidiLevelFunc));
        return callback(Self, textPosition, textLength, explicitLevel, resolvedLevel);
    }
    delegate HRESULT SetBidiLevelFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, Byte explicitLevel, Byte resolvedLevel);
    public HRESULT SetNumberSubstitution(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (UINT32)
        , UInt32 textLength
        /// numberSubstitution: (*(IDWriteNumberSubstitution))
        , IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetNumberSubstitutionFunc));
        return callback(Self, textPosition, textLength, numberSubstitution);
    }
    delegate HRESULT SetNumberSubstitutionFunc(IntPtr self, UInt32 textPosition, UInt32 textLength, IntPtr numberSubstitution);
}
}
