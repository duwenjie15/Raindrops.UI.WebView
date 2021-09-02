using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbWebView : IEquatable<mbWebView>
    {
        public static bool IsGlobalInitialization = false;
        public static object GlobalRoot = new object();
        public static void Init()
        {
            if (!IsGlobalInitialization)
                lock (GlobalRoot)
                    if (!IsGlobalInitialization)
                    {
                        mbSettings mbSettings = new mbSettings();
                        mbSettings.mask = mbSettingMask.MB_ENABLE_NODEJS | mbSettingMask.MB_ENABLE_DISABLE_H5VIDEO;
                        NativeMethods.mbInit(ref mbSettings);
                        IsGlobalInitialization = true;
                    }
        }
        public static mbWebView Create()
        {
            Init();
            return NativeMethods.mbCreateWebView();
        }
        IntPtr _handle;
        public bool Equals(mbWebView other)
            => other._handle == _handle;
        public static implicit operator mbWebView(IntPtr ptr)
            => new mbWebView() { _handle = ptr };
        public static implicit operator IntPtr(mbWebView value)
            => value._handle;
        public bool HaveValue => _handle != IntPtr.Zero;
        public void SetHandle(IntPtr wnd) => NativeMethods.mbSetHandle(this, wnd);
        public void EditorSelectAll() => NativeMethods.mbEditorSelectAll(this);
        public void EditorCopy() => NativeMethods.mbEditorCopy(this);
        public void EditorCut() => NativeMethods.mbEditorCut(this);
        public void EditorDelete() => NativeMethods.mbEditorDelete(this);
        public void EditorUndo() => NativeMethods.mbEditorUndo(this);
        public bool FireMouseEvent(uint message, int x, int y, uint flags) => NativeMethods.mbFireMouseEvent(this, message, x, y, flags);
        public bool FireContextMenuEvent(int x, int y, uint flags) => NativeMethods.mbFireContextMenuEvent(this, x, y, flags);
        public bool FireMouseWheelEvent(int x, int y, int delta, uint flags) => NativeMethods.mbFireMouseWheelEvent(this, x, y, delta, flags);
        public bool FireKeyUpEvent(uint virtualKeyCode, uint flags, bool systemKey) => NativeMethods.mbFireKeyUpEvent(this, virtualKeyCode, flags, systemKey);
        public bool FireKeyPressEvent(uint virtualKeyCode, uint flags, bool systemKey) => NativeMethods.mbFireKeyPressEvent(this, virtualKeyCode, flags, systemKey);
        public bool FireKeyDownEvent(uint virtualKeyCode, uint flags, bool systemKey) => NativeMethods.mbFireKeyDownEvent(this, virtualKeyCode, flags, systemKey);
        public bool FireWindowsMessage(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam, ref IntPtr result) => NativeMethods.mbFireWindowsMessage(this, hWnd, message, wParam, lParam, ref result);
        public void SetHandleOffset(int x, int y) => NativeMethods.mbSetHandleOffset(this, x, y);
        public void Register() => NativeMethods.mbUtilIsRegistered(AppDomain.CurrentDomain.BaseDirectory);
        public void Wake() => NativeMethods.mbWake(this);
        public mbWebFrameHandle GetMainFrame() => NativeMethods.mbWebFrameGetMainFrame(this);
        public void GetSource(mbGetSourceCallback requestCallback, IntPtr param) => NativeMethods.mbGetSource(this, requestCallback, param);
        public void GetCookie(mbGetCookieCallback requestCallback, IntPtr param) => NativeMethods.mbGetCookie(this, requestCallback, param);
        public string GetTitle() => NativeMethods.mbGetTitle(this);
        public string GetUrl() => NativeMethods.mbGetUrl(this);
        public string GetCookieOnBlinkThread() => NativeMethods.mbGetCookieOnBlinkThread(this);
        public void StopLoading() => NativeMethods.mbStopLoading(this);
        public void Reload() => NativeMethods.mbReload(this);
        public void GoBack() => NativeMethods.mbGoBack(this);
        public void GoForward() => NativeMethods.mbGoForward(this);
        public void SetFocus() => NativeMethods.mbSetFocus(this);
        public void KillFocus() => NativeMethods.mbKillFocus(this);
        public void LoadUrl(string url) => NativeMethods.mbLoadURL(this, url);
        public void LoadHtmlWithBaseUrl(string html, string baseUrl) => NativeMethods.mbLoadHtmlWithBaseUrl(this, html, baseUrl);
        public void SetDebugConfig(string debugString, string param) => NativeMethods.mbSetDebugConfig(this, debugString, param);
        public void Resize(int w, int h) => NativeMethods.mbResize(this, w, h);
        public void Destroy() => NativeMethods.mbDestroyWebView(this);
        public void RunJs(mbWebFrameHandle mbWebFrameHandle, string script, bool isInClosure, mbRunJsCallback mbRunJsCallback, IntPtr param) => NativeMethods.mbRunJs(this, mbWebFrameHandle, script, isInClosure, mbRunJsCallback, param, IntPtr.Zero);
        public void SetUserAgent(string userAgent) => NativeMethods.mbSetUserAgent(this, userAgent);
        public void SetCookie(string url, string cookie) => NativeMethods.mbSetCookie(this, url, cookie);
        public void SetCookieEnabled(bool enable) => NativeMethods.mbSetCookieEnabled(this, enable);
        public void SetCookieJarPath(string path) => NativeMethods.mbSetCookieJarPath(this, path);
        public void SetCookieJarFullPath(string path) => NativeMethods.mbSetCookieJarFullPath(this, path);
        public void ClearCookie() => NativeMethods.mbClearCookie(this);
        public void PerformCookieCommand(mbCookieCommand command) => NativeMethods.mbPerformCookieCommand(this, command);
    }
}
