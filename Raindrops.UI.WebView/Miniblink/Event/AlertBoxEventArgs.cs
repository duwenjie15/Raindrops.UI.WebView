using System;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class ReadDataEventArgs : EventArgs
    {
        public ReadDataEventArgs()
        {

        }

        public string Url { get; set; }
        public byte[] Data { get; set; }
        public bool CancelRequest { get; set; }
    }
}
