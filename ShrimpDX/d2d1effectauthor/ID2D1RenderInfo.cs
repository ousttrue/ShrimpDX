// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1RenderInfo: IUnknown
    {
        static Guid s_uuid = new Guid("519ae1bd-d19a-420d-b849-364f594776b7");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int SetInputDescription(
            uint inputIndex,
            D2D1_INPUT_DESCRIPTION inputDescription
        ){
            var fp = GetFunctionPointer(3);
            if(m_SetInputDescriptionFunc==null) m_SetInputDescriptionFunc = (SetInputDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputDescriptionFunc));
            
            return m_SetInputDescriptionFunc(m_ptr, inputIndex, inputDescription);
        }
        delegate int SetInputDescriptionFunc(IntPtr self, uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);
        SetInputDescriptionFunc m_SetInputDescriptionFunc;

        public virtual int SetOutputBuffer(
            D2D1_BUFFER_PRECISION bufferPrecision,
            D2D1_CHANNEL_DEPTH channelDepth
        ){
            var fp = GetFunctionPointer(4);
            if(m_SetOutputBufferFunc==null) m_SetOutputBufferFunc = (SetOutputBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetOutputBufferFunc));
            
            return m_SetOutputBufferFunc(m_ptr, bufferPrecision, channelDepth);
        }
        delegate int SetOutputBufferFunc(IntPtr self, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        SetOutputBufferFunc m_SetOutputBufferFunc;

        public virtual void SetCached(
            int isCached
        ){
            var fp = GetFunctionPointer(5);
            if(m_SetCachedFunc==null) m_SetCachedFunc = (SetCachedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCachedFunc));
            
            m_SetCachedFunc(m_ptr, isCached);
        }
        delegate void SetCachedFunc(IntPtr self, int isCached);
        SetCachedFunc m_SetCachedFunc;

        public virtual void SetInstructionCountHint(
            uint instructionCount
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetInstructionCountHintFunc==null) m_SetInstructionCountHintFunc = (SetInstructionCountHintFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInstructionCountHintFunc));
            
            m_SetInstructionCountHintFunc(m_ptr, instructionCount);
        }
        delegate void SetInstructionCountHintFunc(IntPtr self, uint instructionCount);
        SetInstructionCountHintFunc m_SetInstructionCountHintFunc;

    }
}
