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
        [Map(Name = "data")]
        private byte[] _data;
        public byte[] Data
        {
            get
            {
                lock (this)
                {
                    if (Buffer == IntPtr.Zero || Len <= 0)
                        return null;
                    if (_data != null)
                        return _data;
                    _data = new byte[Len];
                    Marshal.Copy(Buffer, _data, 0, Len);
                    return _data;
                }
            }
        }
    }
}
