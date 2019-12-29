using System;
using System.Runtime.InteropServices;

namespace ShrimpDX
{
    /// <summary>
    /// COMの virtual function table を自前で呼び出すヘルパークラス。
    /// </summary>
    public abstract class ComPtr : IDisposable
    {
        /// <summay>
        /// IUnknown を継承した interface(ID3D11Deviceなど) に対するポインター。
        /// このポインターの指す領域の先頭に virtual function table へのポインタが格納されている。
        /// <summay>
        IntPtr m_ptr;

        protected IntPtr Self => m_ptr;

        public ref IntPtr PtrForNew
        {
            get
            {
                if (m_ptr != IntPtr.Zero)
                {
                    Marshal.Release(m_ptr);
                }
                return ref m_ptr;
            }
        }

        public /*readonly*/ ref IntPtr Ptr => ref m_ptr;

        public static implicit operator bool(ComPtr i)
        {
            return i.m_ptr != IntPtr.Zero;
        }

        IntPtr VTable => Marshal.ReadIntPtr(m_ptr);

        static readonly int IntPtrSize = Marshal.SizeOf(typeof(IntPtr));

        protected IntPtr GetFunctionPointer(int index)
        {
            return Marshal.ReadIntPtr(VTable, index * IntPtrSize);
        }

        abstract public ref /*readonly*/ Guid IID { get; }

        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。
                if (m_ptr != IntPtr.Zero)
                {
                    Marshal.Release(m_ptr);
                    m_ptr = IntPtr.Zero;
                }

                disposedValue = true;
            }
        }

        ~ComPtr()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(false);
        }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    class CustomMarshaler<T> : ICustomMarshaler
    where T : ComPtr, new()
    {
        public void CleanUpManagedData(object ManagedObj)
        {
            throw new NotImplementedException();
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            throw new NotImplementedException();
        }

        public int GetNativeDataSize()
        {
            throw new NotImplementedException();
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            throw new NotImplementedException();
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            // var count = Marshal.AddRef(pNativeData);
            // Marshal.Release(pNativeData);

            var t = new T();
            t.PtrForNew = pNativeData;

            if (t is ID3D11Device d)
            {
                var s = Marshal.GetStartComSlot(typeof(T));
                var flags = d.GetCreationFlags();
                D3D_FEATURE_LEVEL l = d.GetFeatureLevel();
                var a = 0;
            }
            if (t is IDXGISwapChain sc)
            {
            }

            return t;
        }

        public static ICustomMarshaler GetInstance(string src)
        {
            return new CustomMarshaler<T>();
        }
    }
}
