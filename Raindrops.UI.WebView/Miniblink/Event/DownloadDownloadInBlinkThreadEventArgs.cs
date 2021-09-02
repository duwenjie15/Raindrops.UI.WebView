using System;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class DownloadDownloadInBlinkThreadEventArg : EventArgs
    {
        public DownloadDownloadInBlinkThreadEventArg()
        {

        }
        [Map(Name = "webview")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "expectedContentLength")]
        public UIntPtr ExpectedContentLength { get; set; }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "mime")]
        public string Mime { get; set; }
        [Map(Name = "disposition")]
        public string Disposition { get; set; }
        [Map(Name = "job")]
        public mbNetJob Job { get; set; }
        [Map(Name = "dataBind")]
        public IntPtr DataBind { get; set; }
        [Map(IsRet = true)]
        public mbDownloadOpt mbDownloadOpt { get; set; }
    }
}
