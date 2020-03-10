// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Resource: ID3D12Pageable
    {
        static Guid s_uuid = new Guid("696442be-a72e-4059-bc79-5b5c98040fad");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Map(
            uint Subresource,
            ref D3D12_RANGE pReadRange,
            out IntPtr ppData
        ){
            var fp = GetFunctionPointer(8);
            if(m_MapFunc==null) m_MapFunc = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
            
            return m_MapFunc(m_ptr, Subresource, ref pReadRange, out ppData);
        }
        delegate int MapFunc(IntPtr self, uint Subresource, ref D3D12_RANGE pReadRange, out IntPtr ppData);
        MapFunc m_MapFunc;

        public virtual void Unmap(
            uint Subresource,
            ref D3D12_RANGE pWrittenRange
        ){
            var fp = GetFunctionPointer(9);
            if(m_UnmapFunc==null) m_UnmapFunc = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
            
            m_UnmapFunc(m_ptr, Subresource, ref pWrittenRange);
        }
        delegate void UnmapFunc(IntPtr self, uint Subresource, ref D3D12_RANGE pWrittenRange);
        UnmapFunc m_UnmapFunc;

        public virtual D3D12_RESOURCE_DESC GetDesc(
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr);
        }
        delegate D3D12_RESOURCE_DESC GetDescFunc(IntPtr self);
        GetDescFunc m_GetDescFunc;

        public virtual ulong GetGPUVirtualAddress(
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetGPUVirtualAddressFunc==null) m_GetGPUVirtualAddressFunc = (GetGPUVirtualAddressFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGPUVirtualAddressFunc));
            
            return m_GetGPUVirtualAddressFunc(m_ptr);
        }
        delegate ulong GetGPUVirtualAddressFunc(IntPtr self);
        GetGPUVirtualAddressFunc m_GetGPUVirtualAddressFunc;

        public virtual int WriteToSubresource(
            uint DstSubresource,
            ref D3D12_BOX pDstBox,
            IntPtr pSrcData,
            uint SrcRowPitch,
            uint SrcDepthPitch
        ){
            var fp = GetFunctionPointer(12);
            if(m_WriteToSubresourceFunc==null) m_WriteToSubresourceFunc = (WriteToSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteToSubresourceFunc));
            
            return m_WriteToSubresourceFunc(m_ptr, DstSubresource, ref pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
        delegate int WriteToSubresourceFunc(IntPtr self, uint DstSubresource, ref D3D12_BOX pDstBox, IntPtr pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
        WriteToSubresourceFunc m_WriteToSubresourceFunc;

        public virtual int ReadFromSubresource(
            IntPtr pDstData,
            uint DstRowPitch,
            uint DstDepthPitch,
            uint SrcSubresource,
            ref D3D12_BOX pSrcBox
        ){
            var fp = GetFunctionPointer(13);
            if(m_ReadFromSubresourceFunc==null) m_ReadFromSubresourceFunc = (ReadFromSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFromSubresourceFunc));
            
            return m_ReadFromSubresourceFunc(m_ptr, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, ref pSrcBox);
        }
        delegate int ReadFromSubresourceFunc(IntPtr self, IntPtr pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, ref D3D12_BOX pSrcBox);
        ReadFromSubresourceFunc m_ReadFromSubresourceFunc;

        public virtual int GetHeapProperties(
            out D3D12_HEAP_PROPERTIES pHeapProperties,
            out D3D12_HEAP_FLAGS pHeapFlags
        ){
            var fp = GetFunctionPointer(14);
            if(m_GetHeapPropertiesFunc==null) m_GetHeapPropertiesFunc = (GetHeapPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHeapPropertiesFunc));
            
            return m_GetHeapPropertiesFunc(m_ptr, out pHeapProperties, out pHeapFlags);
        }
        delegate int GetHeapPropertiesFunc(IntPtr self, out D3D12_HEAP_PROPERTIES pHeapProperties, out D3D12_HEAP_FLAGS pHeapFlags);
        GetHeapPropertiesFunc m_GetHeapPropertiesFunc;

    }
}
