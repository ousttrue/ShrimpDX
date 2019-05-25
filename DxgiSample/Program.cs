using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace DxgiSample
{
    class Program
    {
        static void Main(string[] _)
        {
            var factory = new IDXGIFactory();
            DXGI.CreateDXGIFactory(ref factory.IID, ref factory.PtrForNew).ThrowIfFailed();

            using (var adapter = new IDXGIAdapter())
            {
                for (uint i = 0; true; ++i)
                {
                    if (factory.EnumAdapters(i, ref adapter.PtrForNew).Failed)
                    {
                        break;
                    }
                    var desc = default(DXGI_ADAPTER_DESC);
                    adapter.GetDesc(ref desc);
                    Console.WriteLine($"{i}: {desc.Description}");
                }
            }
        }
    }
}
