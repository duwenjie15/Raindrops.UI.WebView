using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class WebSocketDataEventArgs : EventArgs
    {
        [Map(Name = "webView")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "channel")]
        public mbWebSocketChannel Channel { get; set; }
        [Map(Name = "opCpodem")]
        public int OpCpodem { get; set; }
        [Map(Name = "isContinue")]
        public bool IsContinue { get; set; }
        private IntPtr buf { get; set; }
        private int len { get; set; }
        public byte[] GetBuffer()
        {
            if(buf != default && len >= 0)
            {
                byte[] buffer = new byte[len];
                Marshal.Copy(buf, buffer, 0, len);
                return buffer;
            }
            return null;
        }
    }
}
