using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class DocumentReadyEventArgs : EventArgs
    {
        public DocumentReadyEventArgs()
        {
        }
        [Map(Name = "frameId")]
        public mbWebFrameHandle FrameId { get; set; }
    }
}
