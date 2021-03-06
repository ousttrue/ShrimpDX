// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISwapChain3: IDXGISwapChain2
    {
        static Guid s_uuid = new Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetCurrentBackBufferIndex(
        ){
            var fp = GetFunctionPointer(36);
            if(m_GetCurrentBackBufferIndexFunc==null) m_GetCurrentBackBufferIndexFunc = (GetCurrentBackBufferIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentBackBufferIndexFunc));
            
            return m_GetCurrentBackBufferIndexFunc(m_ptr);
        }
        delegate uint GetCurrentBackBufferIndexFunc(IntPtr self);
        GetCurrentBackBufferIndexFunc m_GetCurrentBackBufferIndexFunc;

        public virtual int CheckColorSpaceSupport(
            DXGI_COLOR_SPACE_TYPE ColorSpace,
            out uint pColorSpaceSupport
        ){
            var fp = GetFunctionPointer(37);
            if(m_CheckColorSpaceSupportFunc==null) m_CheckColorSpaceSupportFunc = (CheckColorSpaceSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckColorSpaceSupportFunc));
            
            return m_CheckColorSpaceSupportFunc(m_ptr, ColorSpace, out pColorSpaceSupport);
        }
        delegate int CheckColorSpaceSupportFunc(IntPtr self, DXGI_COLOR_SPACE_TYPE ColorSpace, out uint pColorSpaceSupport);
        CheckColorSpaceSupportFunc m_CheckColorSpaceSupportFunc;

        public virtual int SetColorSpace1(
            DXGI_COLOR_SPACE_TYPE ColorSpace
        ){
            var fp = GetFunctionPointer(38);
            if(m_SetColorSpace1Func==null) m_SetColorSpace1Func = (SetColorSpace1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetColorSpace1Func));
            
            return m_SetColorSpace1Func(m_ptr, ColorSpace);
        }
        delegate int SetColorSpace1Func(IntPtr self, DXGI_COLOR_SPACE_TYPE ColorSpace);
        SetColorSpace1Func m_SetColorSpace1Func;

        public virtual int ResizeBuffers1(
            uint BufferCount,
            uint Width,
            uint Height,
            DXGI_FORMAT Format,
            uint SwapChainFlags,
            ref uint pCreationNodeMask,
            ref IntPtr ppPresentQueue
        ){
            var fp = GetFunctionPointer(39);
            if(m_ResizeBuffers1Func==null) m_ResizeBuffers1Func = (ResizeBuffers1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBuffers1Func));
            
            return m_ResizeBuffers1Func(m_ptr, BufferCount, Width, Height, Format, SwapChainFlags, ref pCreationNodeMask, ref ppPresentQueue);
        }
        delegate int ResizeBuffers1Func(IntPtr self, uint BufferCount, uint Width, uint Height, DXGI_FORMAT Format, uint SwapChainFlags, ref uint pCreationNodeMask, ref IntPtr ppPresentQueue);
        ResizeBuffers1Func m_ResizeBuffers1Func;

    }
}
