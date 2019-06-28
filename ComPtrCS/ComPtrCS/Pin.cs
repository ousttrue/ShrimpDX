using System;
using System.Runtime.InteropServices;

namespace ComPtrCS
{
    public struct PinPtr<T> : IDisposable
    {
        int m_offset;
        readonly GCHandle m_handle;
        public IntPtr Ptr
        {
            get
            {
                if (!m_handle.IsAllocated)
                {
                    return IntPtr.Zero;
                }
                var ptr = m_handle.AddrOfPinnedObject();
                ptr = IntPtr.Add(ptr, m_offset);
                return ptr;
            }
        }

        public void Dispose()
        {
            m_handle.Free();
        }

        public PinPtr(ArraySegment<T> segment)
        {
            m_handle = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
            m_offset = segment.Offset;
        }
    }

    public static class PinPtr
    {
        public static PinPtr<T> Create<T>(ArraySegment<T> array)
        {
            return new PinPtr<T>(array);
        }
        public static PinPtr<T> Create<T>(T[] array)
        {
            return Create(new ArraySegment<T>(array));
        }
    }

    public struct CopyPtr : IDisposable
    {
        public readonly IntPtr Ptr;

        public void Dispose()
        {
            Marshal.FreeHGlobal(Ptr);
        }

        public CopyPtr(byte[] array)
        {
            Ptr = Marshal.AllocHGlobal(array.Length);
            Marshal.Copy(array, 0, Ptr, array.Length);
        }
    }
}
