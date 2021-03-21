using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbNetJob : IEquatable<mbNetJob>
    {
        IntPtr _handle;
        public bool Equals(mbNetJob other)
            => other._handle == _handle;
        public static implicit operator mbNetJob(IntPtr ptr)
            => new mbNetJob() { _handle = ptr };
        public static implicit operator IntPtr(mbNetJob value)
            => value._handle;
        public void CancelRequest() => NativeMethods.mbNetCancelRequest(this);
        public void HoldJobToAsynCommit() => NativeMethods.mbNetHoldJobToAsynCommit(this);
        public void HookRequest() => NativeMethods.mbNetHookRequest(this);
        public void ChangeRequestUrl(string url) => NativeMethods.mbNetChangeRequestUrl(this, url);
        public void ContinueJob() => NativeMethods.mbNetContinueJob(this);
        public IEnumerable<mbSlist> GetRawResponseHeadInBlinkThread()
        {
            unsafe
            {
                mbSlist* next = NativeMethods.mbNetGetRawResponseHeadInBlinkThread(this);
                List<mbSlist> mbSlists = new List<mbSlist>();
                while (next != default)
                {
                    mbSlist mbSlist = *next;
                    mbSlists.Add(mbSlist);
                    next = (mbSlist*)mbSlist.next;
                }
                return mbSlists;
            }
        }
        public IEnumerable<mbSlist> GetRawHttpHeadInBlinkThread()
        {
            unsafe
            {
                mbSlist* next = NativeMethods.mbNetGetRawHttpHeadInBlinkThread(this);
                List<mbSlist> mbSlists = new List<mbSlist>();
                while (next != default)
                {
                    mbSlist mbSlist = *next;
                    mbSlists.Add(mbSlist);
                    next = (mbSlist*)mbSlist.next;
                }
                return mbSlists;
            }
        }
        public void SetData(byte[] data, int len) => NativeMethods.mbNetSetData(this, data, len);
        public void SetData(byte[] data) => NativeMethods.mbNetSetData(this, data, data.Length);
        public mbPostBodyElements GetPostBody()
        {
            unsafe
            {
                IntPtr ptr = NativeMethods.mbNetGetPostBody(this);
                if (ptr != default)
                {
                    mbPostBodyElements mbPostBodyElements = *(mbPostBodyElements*)ptr;
                    return mbPostBodyElements;
                }
                return default;
            }
        }
    }
}
