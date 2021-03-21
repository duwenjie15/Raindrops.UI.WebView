using System;
using System.Runtime.InteropServices;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class LoadUrlEndEventArgs : EventArgs
    {
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "job")]
        public mbNetJob Job { get; set; }
        [Map(Name = "buf")]
        public IntPtr Buffer { get; set; }
        [Map(Name = "len")]
        public int Len { get; set; }
        private byte[] data;
        public byte[] Data
        {
            get
            {
                lock (this)
                {
                    if (Buffer == IntPtr.Zero && Len > 0)
                        return null;
                    if (data != null)
                        return data;
                    data = new byte[Len];
                    Marshal.Copy(Buffer, data, 0, Len);
                    return data;
                }
            }
        }
    }
}
