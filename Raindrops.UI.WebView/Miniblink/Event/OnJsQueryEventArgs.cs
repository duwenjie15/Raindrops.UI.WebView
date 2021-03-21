using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class OnJsQueryEventArgs : EventArgs
    {
        [Map(Name = "webView")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "es")]
        public mbJsExecState JsExecState { get; set; }
        [Map(Name = "queryId")]
        public long QueryId { get; set; }
        [Map(Name = "customMsg")]
        public int CustomMsg { get; set; }
        [Map(Name = "request")]
        public string Request { get; set; }
    }
}
