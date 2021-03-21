using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class LoadingFinishEventArgs : EventArgs
    {
        [Map(Name = "failedReason")]
        public string FailedReason { get; set; }
        [Map(Name = "result")]
        public mbLoadingResult LoadingResult { get; set; }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "frameId")]
        public mbWebFrameHandle FrameId { get; set; }
    }

}
