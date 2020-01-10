using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using ShrimpDX;

namespace DxgiSample
{
    class Program
    {
        static void Main(string[] _)
        {
            var factory = new IDXGIFactory();
            dxgi.CreateDXGIFactory(ref IDXGIFactory.IID, out factory.PtrForNew).ThrowIfFailed();

            {
                for (uint i = 0; true; ++i)
                {
                    if (factory.EnumAdapters(i, out IDXGIAdapter adapter).Failed())
                    {
                        break;
                    }
                    adapter.GetDesc(out DXGI_ADAPTER_DESC desc);
                    Console.WriteLine($"{i}: {desc.Description.ToMutableString()}");
                }
            }
        }
    }
}
