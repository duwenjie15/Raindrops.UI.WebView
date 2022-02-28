using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class WebSocketConnectedEventArgs : EventArgs
    {
        [Map(Name = "webView")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "channel")]
        public mbWebSocketChannel Channel { get; set; }
        [Map(IsRet = true)]
        public bool Result { get; set; }
    }
}
