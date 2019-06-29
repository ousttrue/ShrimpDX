using System;
using System.Runtime.InteropServices;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace ComPtrCS.Utilities
{
    public class D3D11ConstantBuffer<T> : IDisposable
    where T : struct
    {
        ID3D11Buffer m_constantBuffer = new ID3D11Buffer();

        T[] m_constants = new T[1];
        public ref T Value
        {
            get
            {
                return ref m_constants[0];
            }
        }

        uint m_slot;

        public D3D11ConstantBuffer(uint slot)
        {
            m_slot = slot;
        }

        public void Dispose()
        {
            ((IDisposable)m_constantBuffer).Dispose();
        }

        public void Set(ID3D11Device device, ID3D11DeviceContext context)
        {
            // create
            if (!m_constantBuffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)Marshal.SizeOf(typeof(T)),
                    Usage = D3D11_USAGE.DEFAULT,
                    BindFlags = (uint)D3D11_BIND_FLAG.CONSTANT_BUFFER,
                };
                using (var pin = PinPtr.Create(m_constants))
                {
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr,
                    };
                    device.CreateBuffer(ref desc, ref data, ref m_constantBuffer.PtrForNew).ThrowIfFailed();
                }
            }

            // update
            using (var pin = PinPtr.Create(m_constants))
            {
                var box = new D3D11_BOX
                {
                };
                context.UpdateSubresource(m_constantBuffer.Ptr, 0, IntPtr.Zero, pin.Ptr, 0, 0);
            }

            Span<IntPtr> buffers = stackalloc IntPtr[]
            {
                m_constantBuffer.Ptr,
            };
            context.VSSetConstantBuffers(m_slot, (uint)buffers.Length, ref MemoryMarshal.GetReference(buffers));
        }
    }
}
