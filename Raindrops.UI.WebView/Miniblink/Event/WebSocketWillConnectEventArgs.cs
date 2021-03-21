using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class WebSocketWillConnectEventArgs : EventArgs
    {

        [Map(Name = "webView")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "channel")]
        public mbWebSocketChannel Channel { get; set; }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "needHook",IsRef = true)]
        public bool NeedHook { get; set; }
        [Map(IsRet = true)]
        public mbStringPtr mbStringPtr { get; set; }
    }
}
