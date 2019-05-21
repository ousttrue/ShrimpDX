using System;
using System.Runtime.InteropServices;
using WindowsKits;
using WindowsKits.build_10_0_17763_0;

namespace D2DSample
{
    class D2DApp : IDisposable
    {
        ID3D11Device m_device = new ID3D11Device();
        ID3D11DeviceContext m_context = new ID3D11DeviceContext();

        bool m_disposed;
        public void Dispose()
        {
            m_device.Dispose();
            m_context.Dispose();
            m_disposed = true;
        }

        void EnsureDevice()
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
            var flags =
            D3D11_CREATE_DEVICE_FLAG.DEBUG |
            D3D11_CREATE_DEVICE_FLAG.BGRA_SUPPORT;
            var level = default(D3D_FEATURE_LEVEL);

            if (d3d11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                d3d11.D3D11_SDK_VERSION,
                ref m_device.PtrForNew,
                ref level,
                ref m_context.PtrForNew) != 0)
            {
                throw new Exception();
            }

            // D2D
            using (var dxgiDevice = new IDXGIDevice())
            {
                if (m_device.QueryInterface(dxgiDevice) != 0)
                {
                    throw new Exception();
                }
                //using (var factory = new )

            }

            /*
            D2DDevice = new SharpDX.Direct2D1.Device(DXGIDevice);
            D2DDeviceContext = new SharpDX.Direct2D1.DeviceContext(D2DDevice,
                SharpDX.Direct2D1.DeviceContextOptions.None);

            using (var factroy = new SharpDX.Direct2D1.Factory(SharpDX.Direct2D1.FactoryType.SingleThreaded))
            {
                Dpi = factroy.DesktopDpi;
            }
            */
        }

        public void Resize(HWND hWnd, int w, int h)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice();

        }

        public void Draw(HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var window = Window.Create();
            if (window == null)
            {
                throw new Exception("fail to create window");
            }

            using (var d3d = new D2DApp())
            {
                window.OnResize += (w, h) =>
                {
                    d3d.Resize(window.WindowHandle, w, h);
                };

                MessageLoop.Run(() =>
                {

                    d3d.Draw(window.WindowHandle);

                }, 30);
            }
        }
    }
}
