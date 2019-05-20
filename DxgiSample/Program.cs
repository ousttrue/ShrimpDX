using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsKits.build_10_0_17763_0;

namespace DxgiSample
{
    class Program
    {
        static int Call(IntPtr self, int index, out IntPtr out0)
        {
            throw new NotImplementedException();
        }

        delegate int CallDelegate<A0>(A0 a0, out IntPtr out0);

        static int Call<A0>(IntPtr self, int index, Type t, A0 a0, out IntPtr out0)
        {
            //throw new NotImplementedException();
            var vTable = Marshal.ReadIntPtr(self);

            var entry = Marshal.ReadIntPtr(vTable, index * Marshal.SizeOf(typeof(IntPtr)));

            var callback = (CallDelegate<A0>)Marshal.GetDelegateForFunctionPointer(entry, t);

            return callback(a0, out out0);
        }

        static int Call<A0, A1>(IntPtr self, int index, A0 a0, A1 a1, out IntPtr out0)
        {
            throw new NotImplementedException();
        }

        static int Call<A0, A1>(IntPtr self, int index, A0 a0, A1 a1)
        {
            throw new NotImplementedException();
        }


        class DXGIFactory
        {
            // IUnknown + IDxgiObject
            const int c_base = 3 + 4;

            #region IDXGIFactory
            public Int32 EnumAdapters(
                /// Adapter: (UINT)
                UInt32 Adapter,
                /// ppAdapter: (*(*(IDXGIAdapter)))
                out IntPtr ppAdapter
            )
            {
                //return Call(Ptr, c_base + 0, typeof(EnumAdaptersFunc), Adapter, out ppAdapter);
                //throw new NotImplementedException();
                var vTable = Marshal.ReadIntPtr(Ptr);
                var entry = new IntPtr(vTable.ToInt64() + (c_base + 0) * Marshal.SizeOf(typeof(IntPtr)));

                var fp = Marshal.ReadIntPtr(entry);

                var callback = (EnumAdaptersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdaptersFunc));

                return callback(Ptr, Adapter, out ppAdapter);
            }
            delegate int EnumAdaptersFunc(IntPtr self, UInt32 Adapter, out IntPtr ppAdapter);

            public Int32 MakeWindowAssociation(
                /// WindowHandle: (HWND)
                IntPtr WindowHandle,
                /// Flags: (UINT)
                UInt32 Flags
            )
            {
                return Call(Ptr, c_base + 1, WindowHandle, Flags);
            }
            public Int32 GetWindowAssociation(
                /// pWindowHandle: (*(HWND))
                out IntPtr pWindowHandle
            )
            {
                return Call(Ptr, c_base + 2, out pWindowHandle);
            }

            public Int32 CreateSwapChain(
                /// pDevice: (*(IUnknown))
                IntPtr pDevice,
                /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
                ref DXGI_SWAP_CHAIN_DESC pDesc,
                /// ppSwapChain: (*(*(IDXGISwapChain)))
                out IntPtr ppSwapChain
            )
            {
                var handle = GCHandle.Alloc(pDesc, GCHandleType.Pinned);
                IntPtr ptr = handle.AddrOfPinnedObject();
                try
                {
                    return Call(Ptr, c_base + 3, pDevice, ptr, out ppSwapChain);
                }
                finally
                {
                    handle.Free();
                }
            }

            public Int32 CreateSoftwareAdapter(
                /// Module: (HMODULE)
                IntPtr Module,
                /// ppAdapter: (*(*(IDXGIAdapter)))
                out IntPtr ppAdapter
            )
            {
                return Call(Ptr, c_base + 4, typeof(object), Module, out ppAdapter);
            }
            #endregion

            public Guid Uuid;

            static readonly Guid s_uuid = new Guid(
                typeof(IDXGIFactory).GetCustomAttributes(true)
                .Select(x => x as GuidAttribute).First(x => x != null).Value);

            public DXGIFactory()
            {
                Uuid = s_uuid;
            }

            public IntPtr Ptr;

            public int RefCount
            {
                get
                {
                    if (Ptr == IntPtr.Zero)
                    {
                        throw new InvalidOperationException();
                    }
                    Marshal.AddRef(Ptr);
                    return Marshal.Release(Ptr);
                }
            }
        }

        static void Main(string[] args)
        {
            var factory = new DXGIFactory();
            var ret = dxgi.CreateDXGIFactory(ref factory.Uuid, ref factory.Ptr);
            var before = factory.RefCount;

            IntPtr p;
            factory.EnumAdapters(0, out p);
            var desc = default(DXGI_ADAPTER_DESC);
            var a = (IDXGIAdapter)Marshal.GetObjectForIUnknown(p);
            a.GetDesc(ref desc);

            var after = factory.RefCount;

            Console.WriteLine(desc.Description);
        }
    }
}
