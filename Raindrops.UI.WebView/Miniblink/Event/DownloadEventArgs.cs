using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class DownloadEventArgs : EventArgs
    {
        public DownloadEventArgs()
        {

        }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "frameId")]
        public mbWebFrameHandle FrameId { get; set; }
        [Map(Name = "downloadJob")]
        public IntPtr DownloadJob { get; set; }
        [Map(IsRet = true)]
        public bool Handled { get; set; }
    }
}
