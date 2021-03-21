using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Raindrops.UI.WebView.Miniblink.PInvoke
{
    public class Utf8Marshaler : ICustomMarshaler
    {
        public static Utf8Marshaler Instance = new Utf8Marshaler();
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return Instance;
        }
        public void CleanUpManagedData(object ManagedObj)
        {
           
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            //对于const utf8应交由miniblink内部回收
            //Marshal.FreeHGlobal(pNativeData);
        }
        public int GetNativeDataSize()
        {
            return -1;
        }
        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is string str)
            {
                var data = Encoding.UTF8.GetBytes(str);
                IntPtr handle = Marshal.AllocHGlobal(data.Length + 1);
                Marshal.Copy(data, 0, handle, data.Length);
                Marshal.WriteByte(handle, data.Length, 0);
                return handle;
            }
            throw new InvalidOperationException();
        }
        private static bool IsWin32Atom(IntPtr ptr)
        {
            long num = (long)ptr;
            return (num & -65536L) == 0L;
        }
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == default || IsWin32Atom(pNativeData))
                return null;
            unsafe
            {
                byte* p = (byte*)pNativeData;
                int len = 0;
                while (*p++ != 0)
                    len++;
                return new string((sbyte*)pNativeData, 0, len, Encoding.UTF8);
            }
        }
    }
}
