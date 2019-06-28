using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace ComPtrCS.Utilities
{
    public class D3D11Mesh : IDisposable
    {
        ID3D11Buffer m_vertexBuffer = new ID3D11Buffer();
        ID3D11Buffer m_indexBuffer = new ID3D11Buffer();

        public void Dispose()
        {
            m_indexBuffer.Dispose();
            m_vertexBuffer.Dispose();
        }

        Byte[] m_vertices;
        int m_vertexSize;
        Byte[] m_indices;
        DXGI_FORMAT m_indexFormat;
        int m_indexCount;

        public void SetVertices<T>(Span<T> vertices) where T : struct
        {
            m_vertices = MemoryMarshal.Cast<T, byte>(vertices).ToArray();
            m_vertexSize = Marshal.SizeOf(typeof(T));
        }

        public void SetIndices<T>(Span<T> indices) where T : struct
        {
            m_indices = MemoryMarshal.Cast<T, byte>(indices).ToArray();
            m_indexCount = indices.Length;
            switch (Marshal.SizeOf(typeof(T)))
            {
                case 2:
                    m_indexFormat = DXGI_FORMAT.R16_UINT;
                    break;

                case 4:
                    m_indexFormat = DXGI_FORMAT.R32_UINT;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }


        public void Draw(ID3D11Device device, ID3D11DeviceContext context, Span<D3D11_INPUT_ELEMENT_DESC> _layout)
        {
            if (!m_vertexBuffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)m_vertices.Length,
                    Usage = D3D11_USAGE.DEFAULT,
                    BindFlags = (uint)D3D11_BIND_FLAG.VERTEX_BUFFER,
                };
                using (var pin = PinPtr.Create(m_vertices))
                {
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr
                    };
                    device.CreateBuffer(ref desc, ref data,
                        ref m_vertexBuffer.PtrForNew).ThrowIfFailed();
                }
            }
            Span<IntPtr> pBufferTbl = stackalloc IntPtr[] { m_vertexBuffer.Ptr };
            Span<uint> SizeTbl = stackalloc uint[] { (uint)m_vertexSize };
            Span<uint> OffsetTbl = stackalloc uint[] { 0 };
            context.IASetVertexBuffers(0, 1,
                ref MemoryMarshal.GetReference(pBufferTbl),
                ref MemoryMarshal.GetReference(SizeTbl),
                ref MemoryMarshal.GetReference(OffsetTbl));

            if (!m_indexBuffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)m_indices.Length,
                    Usage = D3D11_USAGE.DEFAULT,
                    BindFlags = (uint)D3D11_BIND_FLAG.INDEX_BUFFER,
                };
                using (var pin = PinPtr.Create(m_indices))
                {
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr
                    };
                    device.CreateBuffer(ref desc, ref data,
                        ref m_indexBuffer.PtrForNew).ThrowIfFailed();
                }
            }
            context.IASetIndexBuffer(m_indexBuffer.Ptr, m_indexFormat, 0);
            context.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.TRIANGLELIST);
            context.DrawIndexed((uint)m_indexCount, 0, 0);
        }
    }
}
