// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1ResourceTexture: IUnknown
    {
        static Guid s_uuid = new Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Update(
            ref uint minimumExtents,
            ref uint maximimumExtents,
            ref uint strides,
            uint dimensions,
            ref byte data,
            uint dataCount
        ){
            var fp = GetFunctionPointer(3);
            if(m_UpdateFunc==null) m_UpdateFunc = (UpdateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UpdateFunc));
            
            return m_UpdateFunc(m_ptr, ref minimumExtents, ref maximimumExtents, ref strides, dimensions, ref data, dataCount);
        }
        delegate int UpdateFunc(IntPtr self, ref uint minimumExtents, ref uint maximimumExtents, ref uint strides, uint dimensions, ref byte data, uint dataCount);
        UpdateFunc m_UpdateFunc;

    }
}