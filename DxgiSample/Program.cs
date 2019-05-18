using System;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsKits.build_10_0_17763_0;

namespace DxgiSample
{
    class Program
    {
        static Guid uuidof<T>()
        {
            var attr = typeof(T).GetCustomAttributes(true).Select(x => x as GuidAttribute).First(x => x != null);
            return new Guid(attr.Value);
        }

        static void Main(string[] args)
        {
            var p0 = IntPtr.Zero;
            var uuid = uuidof<IDXGIFactory>();
            var ret = dxgi.CreateDXGIFactory(ref uuid, ref p0);
            var o = Marshal.GetObjectForIUnknown(p0);
            var i = (IDXGIFactory)o;

            IDXGIAdapter a = null;
            i.EnumAdapters(0, ref a);
            var desc = default(DXGI_ADAPTER_DESC);
            a.GetDesc(ref desc);

            Console.WriteLine(desc.Description);
        }
    }
}
