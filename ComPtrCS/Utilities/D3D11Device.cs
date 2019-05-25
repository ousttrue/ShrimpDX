using System;
using System.Runtime.InteropServices;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace ComPtrCS.Utilities
{
    public class D3D11Device : IDisposable
    {
        public readonly ID3D11Device Device = new ID3D11Device();

        public readonly ID3D11DeviceContext Context = new ID3D11DeviceContext();


        public void Dispose()
        {
            Device.Dispose();
            Context.Dispose();
        }

        public D3D11Device()
        {
            Span<D3D_FEATURE_LEVEL> levels = stackalloc D3D_FEATURE_LEVEL[]
            {
                D3D_FEATURE_LEVEL._11_1,
                D3D_FEATURE_LEVEL._11_0,
                D3D_FEATURE_LEVEL._10_1,
                D3D_FEATURE_LEVEL._10_0,
                D3D_FEATURE_LEVEL._9_3,
                D3D_FEATURE_LEVEL._9_2,
                D3D_FEATURE_LEVEL._9_1
            };
            var level = default(D3D_FEATURE_LEVEL);

            var flags = D3D11_CREATE_DEVICE_FLAG.BGRA_SUPPORT | D3D11_CREATE_DEVICE_FLAG.DEBUG;

            D3D11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                D3D11.D3D11_SDK_VERSION,
                ref Device.PtrForNew,
                ref level,
                ref Context.PtrForNew).ThrowIfFailed();
        }
    }
}