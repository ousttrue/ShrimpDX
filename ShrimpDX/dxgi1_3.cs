// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public static partial class Constants {
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_MATRIX_3X2_F // 1
    {
        public float _11;
        public float _12;
        public float _21;
        public float _22;
        public float _31;
        public float _32;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_DECODE_SWAP_CHAIN_DESC // 1
    {
        public uint Flags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_FRAME_STATISTICS_MEDIA // 1
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public _LARGE_INTEGER SyncQPCTime;
        public _LARGE_INTEGER SyncGPUTime;
        public DXGI_FRAME_PRESENTATION_MODE CompositionMode;
        public uint ApprovedPresentDuration;
    }
    public static class dxgi1_3 {
        [DllImport("dxgi1_3.dll")]
        public static extern int CreateDXGIFactory2(
            uint Flags,
            ref Guid riid,
            out IntPtr ppFactory
        );
        [DllImport("dxgi1_3.dll")]
        public static extern int DXGIGetDebugInterface1(
            uint Flags,
            ref Guid riid,
            out IntPtr pDebug
        );
    }
}
