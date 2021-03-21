using System;
using Raindrops.UI.WebView.Miniblink;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class ConfirmBoxEventArgs : EventArgs
    {
        [Map(Name = "msg")]
        public string Message { get; set; }
        [Map(IsRet = true)]
        public bool Result { get; set; }
    }
}
