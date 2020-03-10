// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Heap: ID3D12Pageable
    {
        static Guid s_uuid = new Guid("6b3b2502-6e51-45b3-90ee-9884265e8df3");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual D3D12_HEAP_DESC GetDesc(
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr);
        }
        delegate D3D12_HEAP_DESC GetDescFunc(IntPtr self);
        GetDescFunc m_GetDescFunc;

    }
}
