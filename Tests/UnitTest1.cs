using System;
using System.Linq;
using System.Runtime.InteropServices;
using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        Type[] Ignore = new[]{
                typeof(D2D1_PROPERTY_BINDING),
                typeof(D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT),
                typeof(D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT),
                typeof(D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC),
                typeof(D3D11_VIDEO_PROCESSOR_COLOR_SPACE),
                typeof(DWRITE_CLUSTER_METRICS),
                typeof(DWRITE_LINE_BREAKPOINT),
                typeof(DWRITE_SHAPING_GLYPH_PROPERTIES),
                typeof(DWRITE_SHAPING_TEXT_PROPERTIES),
                typeof(DXGI_ADAPTER_DESC1),
                typeof(DXGI_ADAPTER_DESC),
                typeof(DXGI_ADAPTER_DESC2),
            };

        [Fact]
        public void Test1()
        {
            var dll = typeof(ID3D11Device).Assembly;
            foreach (var x in dll.GetTypes())
            {
                if (!x.IsValueType)
                {
                    continue;
                }
                if (Ignore.Contains(x))
                {
                    continue;
                }
                var attr = x.GetCustomAttributes(true).Select(x => x as AnnotationAttribute).FirstOrDefault(x => x != null);
                if (attr != null)
                {
                    Console.WriteLine($"{x.Name}: {attr.Size} == {Marshal.SizeOf(x)}");
                    Assert.Equal(attr.Size, Marshal.SizeOf(x));
                }
            }
        }
    }
}
