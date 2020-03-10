// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12CommandQueue: ID3D12Pageable
    {
        static Guid s_uuid = new Guid("0ec870a6-5d7e-4c22-8cfc-5baae07616ed");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void UpdateTileMappings(
            ID3D12Resource pResource,
            uint NumResourceRegions,
            ref D3D12_TILED_RESOURCE_COORDINATE pResourceRegionStartCoordinates,
            ref D3D12_TILE_REGION_SIZE pResourceRegionSizes,
            ID3D12Heap pHeap,
            uint NumRanges,
            ref D3D12_TILE_RANGE_FLAGS pRangeFlags,
            ref uint pHeapRangeStartOffsets,
            ref uint pRangeTileCounts,
            D3D12_TILE_MAPPING_FLAGS Flags
        ){
            var fp = GetFunctionPointer(8);
            if(m_UpdateTileMappingsFunc==null) m_UpdateTileMappingsFunc = (UpdateTileMappingsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UpdateTileMappingsFunc));
            
            m_UpdateTileMappingsFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero, NumResourceRegions, ref pResourceRegionStartCoordinates, ref pResourceRegionSizes, pHeap!=null ? pHeap.Ptr : IntPtr.Zero, NumRanges, ref pRangeFlags, ref pHeapRangeStartOffsets, ref pRangeTileCounts, Flags);
        }
        delegate void UpdateTileMappingsFunc(IntPtr self, IntPtr pResource, uint NumResourceRegions, ref D3D12_TILED_RESOURCE_COORDINATE pResourceRegionStartCoordinates, ref D3D12_TILE_REGION_SIZE pResourceRegionSizes, IntPtr pHeap, uint NumRanges, ref D3D12_TILE_RANGE_FLAGS pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);
        UpdateTileMappingsFunc m_UpdateTileMappingsFunc;

        public virtual void CopyTileMappings(
            ID3D12Resource pDstResource,
            ref D3D12_TILED_RESOURCE_COORDINATE pDstRegionStartCoordinate,
            ID3D12Resource pSrcResource,
            ref D3D12_TILED_RESOURCE_COORDINATE pSrcRegionStartCoordinate,
            ref D3D12_TILE_REGION_SIZE pRegionSize,
            D3D12_TILE_MAPPING_FLAGS Flags
        ){
            var fp = GetFunctionPointer(9);
            if(m_CopyTileMappingsFunc==null) m_CopyTileMappingsFunc = (CopyTileMappingsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyTileMappingsFunc));
            
            m_CopyTileMappingsFunc(m_ptr, pDstResource!=null ? pDstResource.Ptr : IntPtr.Zero, ref pDstRegionStartCoordinate, pSrcResource!=null ? pSrcResource.Ptr : IntPtr.Zero, ref pSrcRegionStartCoordinate, ref pRegionSize, Flags);
        }
        delegate void CopyTileMappingsFunc(IntPtr self, IntPtr pDstResource, ref D3D12_TILED_RESOURCE_COORDINATE pDstRegionStartCoordinate, IntPtr pSrcResource, ref D3D12_TILED_RESOURCE_COORDINATE pSrcRegionStartCoordinate, ref D3D12_TILE_REGION_SIZE pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);
        CopyTileMappingsFunc m_CopyTileMappingsFunc;

        public virtual void ExecuteCommandLists(
            uint NumCommandLists,
            ref IntPtr ppCommandLists
        ){
            var fp = GetFunctionPointer(10);
            if(m_ExecuteCommandListsFunc==null) m_ExecuteCommandListsFunc = (ExecuteCommandListsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ExecuteCommandListsFunc));
            
            m_ExecuteCommandListsFunc(m_ptr, NumCommandLists, ref ppCommandLists);
        }
        delegate void ExecuteCommandListsFunc(IntPtr self, uint NumCommandLists, ref IntPtr ppCommandLists);
        ExecuteCommandListsFunc m_ExecuteCommandListsFunc;

        public virtual void SetMarker(
            uint Metadata,
            IntPtr pData,
            uint Size
        ){
            var fp = GetFunctionPointer(11);
            if(m_SetMarkerFunc==null) m_SetMarkerFunc = (SetMarkerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMarkerFunc));
            
            m_SetMarkerFunc(m_ptr, Metadata, pData, Size);
        }
        delegate void SetMarkerFunc(IntPtr self, uint Metadata, IntPtr pData, uint Size);
        SetMarkerFunc m_SetMarkerFunc;

        public virtual void BeginEvent(
            uint Metadata,
            IntPtr pData,
            uint Size
        ){
            var fp = GetFunctionPointer(12);
            if(m_BeginEventFunc==null) m_BeginEventFunc = (BeginEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginEventFunc));
            
            m_BeginEventFunc(m_ptr, Metadata, pData, Size);
        }
        delegate void BeginEventFunc(IntPtr self, uint Metadata, IntPtr pData, uint Size);
        BeginEventFunc m_BeginEventFunc;

        public virtual void EndEvent(
        ){
            var fp = GetFunctionPointer(13);
            if(m_EndEventFunc==null) m_EndEventFunc = (EndEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndEventFunc));
            
            m_EndEventFunc(m_ptr);
        }
        delegate void EndEventFunc(IntPtr self);
        EndEventFunc m_EndEventFunc;

        public virtual int Signal(
            ID3D12Fence pFence,
            ulong Value
        ){
            var fp = GetFunctionPointer(14);
            if(m_SignalFunc==null) m_SignalFunc = (SignalFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SignalFunc));
            
            return m_SignalFunc(m_ptr, pFence!=null ? pFence.Ptr : IntPtr.Zero, Value);
        }
        delegate int SignalFunc(IntPtr self, IntPtr pFence, ulong Value);
        SignalFunc m_SignalFunc;

        public virtual int Wait(
            ID3D12Fence pFence,
            ulong Value
        ){
            var fp = GetFunctionPointer(15);
            if(m_WaitFunc==null) m_WaitFunc = (WaitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WaitFunc));
            
            return m_WaitFunc(m_ptr, pFence!=null ? pFence.Ptr : IntPtr.Zero, Value);
        }
        delegate int WaitFunc(IntPtr self, IntPtr pFence, ulong Value);
        WaitFunc m_WaitFunc;

        public virtual int GetTimestampFrequency(
            out ulong pFrequency
        ){
            var fp = GetFunctionPointer(16);
            if(m_GetTimestampFrequencyFunc==null) m_GetTimestampFrequencyFunc = (GetTimestampFrequencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTimestampFrequencyFunc));
            
            return m_GetTimestampFrequencyFunc(m_ptr, out pFrequency);
        }
        delegate int GetTimestampFrequencyFunc(IntPtr self, out ulong pFrequency);
        GetTimestampFrequencyFunc m_GetTimestampFrequencyFunc;

        public virtual int GetClockCalibration(
            out ulong pGpuTimestamp,
            out ulong pCpuTimestamp
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetClockCalibrationFunc==null) m_GetClockCalibrationFunc = (GetClockCalibrationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClockCalibrationFunc));
            
            return m_GetClockCalibrationFunc(m_ptr, out pGpuTimestamp, out pCpuTimestamp);
        }
        delegate int GetClockCalibrationFunc(IntPtr self, out ulong pGpuTimestamp, out ulong pCpuTimestamp);
        GetClockCalibrationFunc m_GetClockCalibrationFunc;

        public virtual D3D12_COMMAND_QUEUE_DESC GetDesc(
        ){
            var fp = GetFunctionPointer(18);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr);
        }
        delegate D3D12_COMMAND_QUEUE_DESC GetDescFunc(IntPtr self);
        GetDescFunc m_GetDescFunc;

    }
}
