using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsKits;
using WindowsKits.build_10_0_17763_0;

namespace DxgiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new IDXGIFactory();
            var ret = dxgi.CreateDXGIFactory(ref factory.IID, ref factory.PtrForNew);
            var before = factory.RefCount;

            var desc = default(DXGI_ADAPTER_DESC);
            using (var adapter = new IDXGIAdapter())
            {
                factory.EnumAdapters(0, ref adapter.PtrForNew);
                adapter.GetDesc(ref desc);
            }

            var after = factory.RefCount;
            Console.WriteLine(desc.Description);
        }
    }
}
