using System.Runtime.InteropServices;
using size_t = System.UIntPtr;
using System.Collections.Generic;
using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct mbPostBodyElement
    {
        public int size;
        public mbHttBodyElementType type;
        /// <summary>
        /// mbMemBuf*
        /// </summary>
        public mbMemBuf* data;
        /// <summary>
        /// mbStringPtr
        /// </summary>
        public mbStringPtr filePath;
        public long fileStart;
        public long fileLength;
        public mbMemBuf GetData()
        {
            return (IntPtr)data == IntPtr.Zero ? default : *data;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct mbPostBodyElements
    {
        public int size;
        public mbPostBodyElement** element;
        public size_t elementSize;
        public bool isDirty;
        public IEnumerable<mbPostBodyElement> GetElements()
        {
            int len = (int)elementSize;
            List<mbPostBodyElement> mbPostBodyElements = new List<mbPostBodyElement>(len);
            mbPostBodyElement* ptr = *element;
            int step = IntPtr.Size;
            for (int i = 0; i < len; i++)
            {
                mbPostBodyElements.Add(*ptr);
                ptr += step;
            }
            return mbPostBodyElements;
        }
    }
}
