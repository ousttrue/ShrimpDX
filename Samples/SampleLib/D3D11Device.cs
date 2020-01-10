using System;
using System.Runtime.InteropServices;
using ShrimpDX;

namespace SampleLib
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

            var flags = D3D11_CREATE_DEVICE_FLAG._BGRA_SUPPORT | D3D11_CREATE_DEVICE_FLAG._DEBUG;

            d3d11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE._HARDWARE,
                IntPtr.Zero,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                Constants.D3D11_SDK_VERSION,
                out Device,
                out level,
                out Context).ThrowIfFailed();
        }
    }
}