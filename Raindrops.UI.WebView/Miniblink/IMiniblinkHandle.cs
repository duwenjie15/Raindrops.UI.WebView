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
        internal static int seed = 0;
        internal static ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>> _runJsCallbackDict = new ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>>();
        internal static ConcurrentDictionary<IntPtr, TaskCompletionSource<string>> _getCookieCallbackDict = new ConcurrentDictionary<IntPtr, TaskCompletionSource<string>>();
        internal static readonly mbRunJsCallback _mbRunJsCallback = new mbRunJsCallback(RunJsCallback);
        internal static readonly mbGetCookieCallback _mbGetCookieCallback = new mbGetCookieCallback(GetCookieCallback);
        internal static IntPtr CreateToken()
        {
            return (IntPtr)Interlocked.Increment(ref seed);
        }
        internal static void RunJsCallback(mbWebView webview, IntPtr token, mbJsExecState es, mbJsValue v)
        {
            RetValue retValue = new RetValue(webview, token, es, v);
            if (_runJsCallbackDict.TryRemove(token, out var taskCompletionSource))
            {
                taskCompletionSource.SetResult(retValue);
            }
        }
        public static Task<RetValue> RunJs(this IMiniblinkProxy miniblinkProxy, string js, bool isInClosure)
        {
            mbWebView mbWebView = miniblinkProxy.WebView;
            return RunJs(mbWebView, mbWebView.GetMainFrame(), js, isInClosure);
        }

        public static Task<RetValue> RunJs(mbWebView mbWebView, mbWebFrameHandle mbWebFrameHandle, string js, bool isInClosure)
        {
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<RetValue>();
            _runJsCallbackDict.TryAdd(token, taskSource);
            mbWebView.RunJs(mbWebFrameHandle, js, isInClosure, _mbRunJsCallback, token);
            return taskSource.Task;
        }
        internal static void GetCookieCallback(mbWebView webview, IntPtr token, MbAsynRequestState state, string cookie)
        {
            if (_getCookieCallbackDict.TryRemove(token, out var taskCompletionSource))
            {
                taskCompletionSource.SetResult(state == MbAsynRequestState.kMbAsynRequestStateOk ? cookie : null);
            }
        }
        public static Task<string> GetCookie(this IMiniblinkProxy miniblinkProxy)
        {
            mbWebView mbWebView = miniblinkProxy.WebView;
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<string>();
            _getCookieCallbackDict.TryAdd(token, taskSource);
            mbWebView.GetCookie(_mbGetCookieCallback, token);
            return taskSource.Task;
        }
    }
}
