using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using ShrimpDX;

namespace SampleLib
{
    public class VertexBuffer : IDisposable
    {
        Memory<byte> m_bytes;
        public readonly int Stride;

        D3D11_BIND_FLAG m_bind;

        ID3D11Buffer m_buffer = new ID3D11Buffer();

        public ID3D11Buffer Buffer => m_buffer;

        public IntPtr GetPtr(ID3D11Device device)
        {
            if (!m_buffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)m_bytes.Length,
                    Usage = D3D11_USAGE._DEFAULT,
                    BindFlags = (uint)m_bind,
                };
                if (MemoryMarshal.TryGetArray(m_bytes, out ArraySegment<byte> bytes))
                {
                    using (var pin = PinPtr.Create(bytes))
                    {
                        var data = new D3D11_SUBRESOURCE_DATA
                        {
                            pSysMem = pin.Ptr
                        };
                        device.CreateBuffer(ref desc, ref data,
                            out m_buffer).ThrowIfFailed();
                    }
                }
            }
            return m_buffer.Ptr;
        }

        public VertexBuffer(Memory<byte> bytes, int stride, D3D11_BIND_FLAG bind)
        {
            m_bytes = bytes;
            Stride = stride;
            m_bind = bind;
        }

        public void Dispose()
        {
            ((IDisposable)m_buffer).Dispose();
        }
    }

    public class D3D11Mesh : IDisposable
    {
        Dictionary<Semantics, VertexBuffer> m_vertexBufferMap = new Dictionary<Semantics, VertexBuffer>();
        int m_vertexCount;
        VertexBuffer m_indexBuffer;
        int m_indexCount;
        DXGI_FORMAT m_indexFormat;

        public void Dispose()
        {
            foreach (var kv in m_vertexBufferMap)
            {
                kv.Value.Dispose();
            }
            m_vertexBufferMap.Clear();
            m_indexBuffer.Dispose();
            m_indexBuffer = null;
        }

        public void SetVertexAttribute(Semantics semantic, Memory<byte> bytes, int stride)
        {
            if (m_vertexCount == 0)
            {
                m_vertexCount = bytes.Length / stride;
            }
            else
            {
                if (m_vertexCount != bytes.Length / stride)
                {
                    throw new Exception("different vertex count");
                }
            }
            m_vertexBufferMap[semantic] = new VertexBuffer(bytes, stride, D3D11_BIND_FLAG._VERTEX_BUFFER);
        }

        public void UpdateVertexAttribute(ID3D11Device device, ID3D11DeviceContext context, Semantics semantic, Memory<byte> bytes)
        {
            var buffer = m_vertexBufferMap[semantic];

            if (MemoryMarshal.TryGetArray(bytes, out ArraySegment<byte> segment))
            {
                using (var pin = PinPtr.Create(segment))
                {
                    var box = new D3D11_BOX
                    {
                    };
                    context.UpdateSubresource(buffer.Buffer, 0, ref box, pin.Ptr, 0, 0);
                }
            }
        }

        public void SetIndices(Memory<byte> bytes, int stride)
        {
            if (m_indexBuffer != null)
            {
                throw new Exception("duplicate index buffer");
            }
            m_indexBuffer = new VertexBuffer(bytes, stride, D3D11_BIND_FLAG._INDEX_BUFFER);
            m_indexCount = bytes.Length / stride;
            switch (stride)
            {
                case 2:
                    m_indexFormat = DXGI_FORMAT._R16_UINT;
                    break;

                case 4:
                    m_indexFormat = DXGI_FORMAT._R32_UINT;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }


        public void Draw(ID3D11Device device, ID3D11DeviceContext context, Span<VertexAttribute> layout)
        {
            Span<IntPtr> buffers = stackalloc IntPtr[layout.Length];
            Span<uint> strides = stackalloc uint[layout.Length];
            Span<uint> offsets = stackalloc uint[layout.Length];
            for (int i = 0; i < layout.Length; ++i)
            {
                var va = layout[i];
                if (m_vertexBufferMap.TryGetValue(va.Semantic, out VertexBuffer vb))
                {
                    buffers[i] = vb.GetPtr(device);
                    strides[i] = (uint)vb.Stride;
                }
            }
            context.IASetVertexBuffers(0, (uint)layout.Length,
                ref MemoryMarshal.GetReference(buffers),
                ref MemoryMarshal.GetReference(strides),
                ref MemoryMarshal.GetReference(offsets));

            context.IASetIndexBuffer(m_indexBuffer.Buffer, m_indexFormat, 0);
            context.IASetPrimitiveTopology(D3D10_PRIMITIVE_TOPOLOGY._TRIANGLELIST);
            context.DrawIndexed((uint)m_indexCount, 0, 0);
        }
        public static D3D11Mesh CreateTriangle()
        {
            var model = new D3D11Mesh();

            var positions = new Vector3[]{
                new Vector3(0.0f, 0.0f, 0.0f),
                new Vector3(0.5f, 0.5f, 0.0f),
                new Vector3(0.5f, -0.5f, 0.0f),
            };
            var positionSpan = MemoryMarshal.Cast<Vector3, byte>(positions.AsSpan());
            model.SetVertexAttribute(Semantics.POSITION,
                positionSpan.ToArray().AsMemory(),
                Marshal.SizeOf(positions[0].GetType()));

            var colors = new Vector4[]{
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
            };
            var colorSpan = MemoryMarshal.Cast<Vector4, byte>(colors.AsSpan());
            model.SetVertexAttribute(Semantics.COLOR,
                colorSpan.ToArray().AsMemory(),
                Marshal.SizeOf(colors[0].GetType()));

            Span<int> indices = stackalloc int[]
            {
                0,
                1,
                2
            };
            var indexSpan = MemoryMarshal.Cast<int, byte>(indices);
            model.SetIndices(indexSpan.ToArray(), 4);

            return model;
        }
    }
}
