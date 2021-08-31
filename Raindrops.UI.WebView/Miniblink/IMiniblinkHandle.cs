using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Raindrops.UI.WebView.Miniblink
{
    public interface IMiniblinkProxy
    {
        mbWebView WebView { get; }
    }
    public static class IMiniblinkProxyExtension
    {
        //Ex
        internal static int s_seed = 0;
        internal static ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>> s_runJsCallbackDict = new ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>>();
        internal static ConcurrentDictionary<IntPtr, TaskCompletionSource<string>> s_getStringCallbackDict = new ConcurrentDictionary<IntPtr, TaskCompletionSource<string>>();
        internal static readonly mbRunJsCallback s_mbRunJsCallback = new mbRunJsCallback(RunJsCallback);
        internal static readonly mbGetCookieCallback s_mbGetCookieCallback = new mbGetCookieCallback(GetCookieCallback);
        internal static readonly mbGetSourceCallback s_mbGetSourceCallback = new mbGetSourceCallback(GetSourceCallback);
        internal static IntPtr CreateToken()
        {
            return (IntPtr)Interlocked.Increment(ref s_seed);
        }
        internal static void RunJsCallback(mbWebView webview, IntPtr token, mbJsExecState es, mbJsValue v)
        {
            RetValue retValue = new RetValue(webview, token, es, v);
            if (s_runJsCallbackDict.TryRemove(token, out TaskCompletionSource<RetValue> taskCompletionSource))
            {
                taskCompletionSource.SetResult(retValue);
            }
        }
        public static Task<RetValue> RunJs(this IMiniblinkProxy miniblinkProxy, string js, bool isInClosure)
        {
            mbWebView mbWebView = miniblinkProxy.WebView;
            return RunJs(miniblinkProxy, mbWebView.GetMainFrame(), js, isInClosure);
        }

        public static Task<RetValue> RunJs(this IMiniblinkProxy miniblinkProxy, mbWebFrameHandle mbWebFrameHandle, string js, bool isInClosure)
        {
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<RetValue>();
            s_runJsCallbackDict.TryAdd(token, taskSource);
            miniblinkProxy.WebView.RunJs(mbWebFrameHandle, js, isInClosure, s_mbRunJsCallback, token);
            return taskSource.Task;
        }
        internal static void GetCookieCallback(mbWebView webview, IntPtr token, MbAsynRequestState state, string cookie)
        {
            if (s_getStringCallbackDict.TryRemove(token, out TaskCompletionSource<string> taskCompletionSource))
            {
                taskCompletionSource.SetResult(state == MbAsynRequestState.kMbAsynRequestStateOk ? cookie : null);
            }
        }
        public static Task<string> GetCookie(this IMiniblinkProxy miniblinkProxy)
        {
            mbWebView mbWebView = miniblinkProxy.WebView;
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<string>();
            s_getStringCallbackDict.TryAdd(token, taskSource);
            mbWebView.GetCookie(s_mbGetCookieCallback, token);
            return taskSource.Task;
        }
        internal static void GetSourceCallback(mbWebView webview, IntPtr token, string mhtml)
        {
            if (s_getStringCallbackDict.TryRemove(token, out TaskCompletionSource<string> taskCompletionSource))
            {
                taskCompletionSource.SetResult(mhtml);
            }
        }
        public static Task<string> GetSource(this IMiniblinkProxy miniblinkProxy)
        {
            mbWebView mbWebView = miniblinkProxy.WebView;
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<string>();
            s_getStringCallbackDict.TryAdd(token, taskSource);
            mbWebView.GetSource(s_mbGetSourceCallback, token);
            return taskSource.Task;
        }
    }
}
