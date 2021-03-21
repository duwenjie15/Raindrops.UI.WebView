using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.Event;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.TestWinForm
{
    public partial class Browser : UserControl, IMiniblinkProxy
    {
        public EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback> LoadUrlBegin;
        public EventAdapter<TitleChangeEventArgs, mbTitleChangedCallback> TitleChanged;
        public EventAdapter<UrlChangeEventArgs, mbURLChangedCallback> UrlChanged;
        public EventAdapter<NewWindowEventArgs, mbCreateViewCallback> NewWindow;
        public EventAdapter<WebSocketWillConnectEventArgs, onWillConnect> WebSocketOnWillConnect;
        public EventAdapter<WebSocketConnectedEventArgs, onConnected> WebSocketOnConnect;
        public EventAdapter<WebSocketDataEventArgs, onReceive> WebSocketOnReceive;
        public EventAdapter<WebSocketDataEventArgs, onSend> WebSocketOnSend;
        public EventAdapter<WebSocketErrorEventArgs, onError> WebSocketOnError;
        public Browser()
        {
            InitializeComponent();
            if (IsDesignMode) return;
            WebView = mbWebView.Create();
            if (!IsHandleCreated) CreateHandle();

            TitleChanged = new EventAdapter<TitleChangeEventArgs, mbTitleChangedCallback>(this, NativeMethods.mbOnTitleChanged);
            UrlChanged = new EventAdapter<UrlChangeEventArgs, mbURLChangedCallback>(this, NativeMethods.mbOnURLChanged);
            NewWindow = new EventAdapter<NewWindowEventArgs, mbCreateViewCallback>(this, NativeMethods.mbOnCreateView);
            LoadUrlBegin = new EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback>(this, NativeMethods.mbOnLoadUrlBegin);
            WebSocketOnWillConnect = new EventAdapter<WebSocketWillConnectEventArgs, onWillConnect>(this, RegSocketOnWillConnect);
            WebSocketOnConnect = new EventAdapter<WebSocketConnectedEventArgs, onConnected>(this, RegSocketOnConnected);
            WebSocketOnReceive = new EventAdapter<WebSocketDataEventArgs, onReceive>(this, RegSocketOnReceive);
            WebSocketOnSend = new EventAdapter<WebSocketDataEventArgs, onSend>(this, RegSocketOnSend);
            WebSocketOnError = new EventAdapter<WebSocketErrorEventArgs, onError>(this, RegSocketOnError);

        }

        private mbWebsocketHookCallbacks mbWebsocketHookCallbacks;
        public bool RegSocketOnWillConnect(mbWebView mbWebView, onWillConnect onWillConnect, IntPtr param)
        {
            mbWebsocketHookCallbacks.onWillConnect = onWillConnect;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegWebsocketHookCallbacks(mbWebView mbWebView, ref mbWebsocketHookCallbacks mbWebsocketHookCallbacks, IntPtr param)
        {
            if (mbWebsocketHookCallbacks.CanUse)
                NativeMethods.mbNetSetWebsocketCallback(mbWebView, ref mbWebsocketHookCallbacks, param);
            return true;
        }
        public bool RegSocketOnConnected(mbWebView mbWebView, onConnected onConnected, IntPtr param)
        {
            mbWebsocketHookCallbacks.onConnected = onConnected;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnReceive(mbWebView mbWebView, onReceive onReceive, IntPtr param)
        {
            mbWebsocketHookCallbacks.onReceive = onReceive;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param); ;
        }
        public bool RegSocketOnSend(mbWebView mbWebView, onSend onSend, IntPtr param)
        {
            mbWebsocketHookCallbacks.onSend = onSend;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnError(mbWebView mbWebView, onError onError, IntPtr param)
        {
            mbWebsocketHookCallbacks.onError = onError;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        protected override void OnResize(EventArgs e)
        {
            if (WebView.HaveValue)
                WebView.Resize(Size.Width, Size.Height);
            base.OnResize(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsDesignMode)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString(nameof(Browser), drawFont, drawBrush, new Point(0, 0));
                base.OnPaint(e);
                return;
            }
            else
            {
                if (WebView.HaveValue)
                {
                    IntPtr src = NativeMethods.mbGetLockedViewDC(WebView);
                    if (src != IntPtr.Zero)
                    {
                        try
                        {
                            IntPtr hdc = e.Graphics.GetHdc();
                            BitBlt(hdc, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height, src, e.ClipRectangle.X, e.ClipRectangle.Y, 0xcc0020);
                            e.Graphics.ReleaseHdc(hdc);
                        }
                        finally
                        {
                            NativeMethods.mbUnlockViewDC(WebView);
                        }
                    }
                }
                else
                    base.OnPaint(e);
            }
        }
        [DllImport("gdi32.dll")]
        private static extern int BitBlt(
            IntPtr hdcDest,     // handle to destination DC (device context)
            int nXDest,         // x-coord of destination upper-left corner
            int nYDest,         // y-coord of destination upper-left corner
            int nWidth,         // width of destination rectangle
            int nHeight,        // height of destination rectangle
            IntPtr hdcSrc,      // handle to source DC
            int nXSrc,          // x-coordinate of source upper-left corner
            int nYSrc,          // y-coordinate of source upper-left corner
            int dwRop  // raster operation code
            );

        public mbWebView WebView { get; private set; }
        public bool IsDesignMode
        {
            get
            {
                string processName = Process.GetCurrentProcess().ProcessName;
                return DesignMode || processName.Contains("devenv") || processName.Contains("DesignToolsServer");
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            uint msg = 0;
            if (e.Button == MouseButtons.Left)
            {
                msg = (uint)mbMouseMsg.MB_MSG_LBUTTONDOWN;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                msg = (uint)mbMouseMsg.MB_MSG_MBUTTONDOWN;
            }
            else if (e.Button == MouseButtons.Right)
            {
                msg = (uint)mbMouseMsg.MB_MSG_RBUTTONDOWN;
            }
            uint flags = GetMouseFlags(e);
            if (WebView.HaveValue)
                WebView.FireMouseEvent(msg, e.X, e.Y, flags);
        }
        private static uint GetMouseFlags(MouseEventArgs e)
        {
            uint flags = 0;
            if (e.Button == MouseButtons.Left)
            {
                flags |= (uint)mbMouseFlags.MB_LBUTTON;
            }
            if (e.Button == MouseButtons.Middle)
            {
                flags |= (uint)mbMouseFlags.MB_MBUTTON;
            }
            if (e.Button == MouseButtons.Right)
            {
                flags |= (uint)mbMouseFlags.MB_RBUTTON;
            }
            if (Control.ModifierKeys == Keys.Control)
            {
                flags |= (uint)mbMouseFlags.MB_CONTROL;
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                flags |= (uint)mbMouseFlags.MB_SHIFT;
            }
            return flags;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            uint msg = 0;
            if (e.Button == MouseButtons.Left)
            {
                msg = (uint)mbMouseMsg.MB_MSG_LBUTTONUP;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                msg = (uint)mbMouseMsg.MB_MSG_MBUTTONUP;
            }
            else if (e.Button == MouseButtons.Right)
            {
                msg = (uint)mbMouseMsg.MB_MSG_RBUTTONUP;
            }
            uint flags = GetMouseFlags(e);
            if (WebView.HaveValue)
            {
                WebView.FireMouseEvent(msg, e.X, e.Y, flags);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (WebView.HaveValue)
            {
                uint flags = GetMouseFlags(e);
                WebView.FireMouseEvent(0x200, e.X, e.Y, flags);
                Update();
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (WebView.HaveValue)
            {
                WebView.FireKeyDownEvent((uint)e.KeyValue, 0, false);
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (WebView.HaveValue)
            {
                WebView.FireKeyUpEvent((uint)e.KeyValue, 0, false);
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (WebView.HaveValue)
            {
                e.Handled = true;
                WebView.FireKeyPressEvent((uint)e.KeyChar, 0, false);
            }
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (WebView.HaveValue)
            {
                uint flags = GetMouseFlags(e);
                WebView.FireMouseWheelEvent(e.X, e.Y, e.Delta, flags);
            }

        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (WebView.HaveValue)
            {
                WebView.KillFocus();
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            if (WebView.HaveValue)
            {
                WebView.SetFocus();
            }
        }
        protected override void OnImeModeChanged(EventArgs e)
        {
            if (WebView.HaveValue)
            {
                ImeContext.SetImeStatus(ImeMode, Handle);
            }
        }
        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
        }
        protected override void WndProc(ref Message m)
        {
            IntPtr result = IntPtr.Zero;
            switch (m.Msg)
            {
                case 32:
                case 269:
                case 270:
                    {
                        if (WebView.HaveValue && WebView.FireWindowsMessage(m.HWnd, (uint)m.Msg, m.WParam, m.LParam, ref result))
                            m.Result = result;
                        return;
                    }
            }
            base.WndProc(ref m);
        }
        ~Browser()
        {
            WebView.Destroy();
  
        }
        internal static int seed = 0;
        internal static IntPtr CreateToken()
        {
            return (IntPtr)Interlocked.Increment(ref seed);
        }
        internal static ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>> CallbackDict = new ConcurrentDictionary<IntPtr, TaskCompletionSource<RetValue>>();
        internal static void RunJsCallback(mbWebView webview, IntPtr token, mbJsExecState es, mbJsValue v)
        {
            RetValue retValue = new RetValue(webview, token, es, v);
            if (CallbackDict.TryRemove(token, out var taskCompletionSource))
            {
                taskCompletionSource.SetResult(retValue);
            }
        }
        public virtual Task<RetValue> RunJs(string js, bool isInClosure)
        {
            IntPtr token = CreateToken();
            var taskSource = new TaskCompletionSource<RetValue>();
            CallbackDict.TryAdd(token, taskSource);
            WebView.RunJs(WebView.GetMainFrame(), js, isInClosure, RunJsCallback, token);
            return taskSource.Task;
        }
    }
}
