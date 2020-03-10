// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12PipelineLibrary1: ID3D12PipelineLibrary
    {
        static Guid s_uuid = new Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int LoadPipeline(
            ref ushort pName,
            ref D3D12_PIPELINE_STATE_STREAM_DESC pDesc,
            ref Guid riid,
            out IntPtr ppPipelineState
        ){
            var fp = GetFunctionPointer(13);
            if(m_LoadPipelineFunc==null) m_LoadPipelineFunc = (LoadPipelineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadPipelineFunc));
            
            return m_LoadPipelineFunc(m_ptr, ref pName, ref pDesc, ref riid, out ppPipelineState);
        }
        delegate int LoadPipelineFunc(IntPtr self, ref ushort pName, ref D3D12_PIPELINE_STATE_STREAM_DESC pDesc, ref Guid riid, out IntPtr ppPipelineState);
        LoadPipelineFunc m_LoadPipelineFunc;

    }
}
