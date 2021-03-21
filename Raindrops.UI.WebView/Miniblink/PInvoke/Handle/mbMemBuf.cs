using System.Runtime.InteropServices;
using size_t = System.UIntPtr;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct mbMemBuf
    {
        public int size;
        public byte* data;
        public size_t length;
        public byte[] ToArray()
        {
            int len = (int)length;
            byte[] buffer = new byte[len];
            if (len > 0)
            {
                unsafe
                {
                    fixed (byte* pDst = &buffer[0])
                    {
                        byte* ps = data;
                        byte* pd = pDst;
                        int round = len / 4;
                        for (int n = 0; n < round; n++)
                        {
                            *((int*)pd) = *((int*)ps);
                            pd += 4;
                            ps += 4;
                        }
                        round = len % 4;
                        for (int n = 0; n < round; n++)
                            *pd++ = *ps++;
                    }
                }
            }
            return buffer;
        }
    }
}
