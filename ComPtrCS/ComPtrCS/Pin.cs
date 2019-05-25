using System;
using System.Runtime.InteropServices;

namespace ComPtrCS
{
    public struct PinPtr<T> : IDisposable
    {
        readonly GCHandle m_handle;
        public IntPtr Ptr => m_handle.AddrOfPinnedObject();

        public void Dispose()
        {
            m_handle.Free();
        }

        public PinPtr(T[] array)
        {
            m_handle = GCHandle.Alloc(array, GCHandleType.Pinned);
        }
    }

    public static class PinPtr
    {
        public static PinPtr<T> Create<T>(T[] array)
        {
            return new PinPtr<T>(array);
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
