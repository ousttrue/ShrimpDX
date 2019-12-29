using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ComPtrCS;
using ComPtrCS.Utilities;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace D3D11TriangleSample
{
    class D3DApp : IDisposable
    {
        readonly D3D11Device m_d3d11 = new D3D11Device();

        readonly DXGISwapChainForHWND m_swapchain = new DXGISwapChainForHWND();

        bool m_disposed;
        readonly D3D11Shader m_shader = D3D11Shader.CreateSampleShader();

        readonly D3D11Model m_model = D3D11Model.CreateTriangle();

        public void Dispose()
        {
            m_disposed = true;
            m_model.Dispose();
            m_d3d11.Dispose();
            m_swapchain.Dispose();
        }

        public D3DApp()
        {
        }

        public void Resize(HWND _, int w, int h)
        {
            m_swapchain.Resize(w, h);
        }

        ID3D11RenderTargetView Begin(HWND hWnd, out float width, out float height)
        {
            using (var texture = m_swapchain.GetBackbuffer(m_d3d11.Device, hWnd.Value))
            {
                var desc = new D3D11_TEXTURE2D_DESC();
                texture.GetDesc(ref desc);
                width = (float)desc.Width;
                height = (float)desc.Height;

                var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    Format = desc.Format,
                    ViewDimension = D3D11_RTV_DIMENSION.TEXTURE2D
                };
                var rtv = new ID3D11RenderTargetView();
                m_d3d11.Device.CreateRenderTargetView(texture.Ptr, ref rtv_desc, ref rtv.PtrForNew).ThrowIfFailed();
                return rtv;
            }
        }

        void End()
        {
            m_d3d11.Context.Flush();
            m_swapchain.Present();
        }

        public void Draw(HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }

            using (var rtv = Begin(hWnd, out float width, out float height))
            {
                // clear
                var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                m_d3d11.Context.ClearRenderTargetView(rtv.Ptr, ref clearColor);

                // draw pipeline
                m_d3d11.Context.OMSetRenderTargets(1, ref rtv.Ptr, IntPtr.Zero);
                var vp = new D3D11_VIEWPORT
                {
                    Width = width,
                    Height = height,
                    MinDepth = 0.0f,
                    MaxDepth = 1.0f,
                };
                m_d3d11.Context.RSSetViewports(1, ref vp);

                m_shader.Setup(m_d3d11.Device, m_d3d11.Context);

                // m_model.Draw(m_d3d11.Device, m_d3d11.Context, m_shader.Layout.AsSpan());

                // flush
                End();
            }
        }
    }

    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LRESULT WNDPROC(HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam);

        static void Main(string[] _)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var window = Window.Create();
            if (window == null)
            {
                throw new Exception("fail to create window");
            }

            using (var d3d = new D3DApp())
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