using Raindrops.UI.WebView;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.Event;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Raindrops.UI.WebView.TestWinForm
{
    public partial class Browser : UserControl, IMiniblinkProxy
    {
        private readonly mbPaintBitUpdatedCallback _mbPaintBitUpdatedCallback;
        private mbWebsocketHookCallbacks _mbWebsocketHookCallbacks;
        private Bitmap _image;
        private Size _drawSize;
        private bool _disposed;

        public EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback> LoadUrlBegin;
        public EventAdapter<TitleChangeEventArgs, mbTitleChangedCallback> TitleChanged;
        public EventAdapter<UrlChangeEventArgs, mbURLChangedCallback> UrlChanged;
        public EventAdapter<NewWindowEventArgs, mbCreateViewCallback> NewWindow;
        public EventAdapter<WebSocketWillConnectEventArgs, onWillConnect> WebSocketOnWillConnect;
        public EventAdapter<WebSocketConnectedEventArgs, onConnected> WebSocketOnConnect;
        public EventAdapter<WebSocketDataEventArgs, onReceive> WebSocketOnReceive;
        public EventAdapter<WebSocketDataEventArgs, onSend> WebSocketOnSend;
        public EventAdapter<WebSocketErrorEventArgs, onError> WebSocketOnError;
        public EventAdapter<LoadUrlEndEventArgs, mbLoadUrlEndCallback> LoadUrlEnd;
        public EventAdapter<DocumentReadyEventArgs, mbDocumentReadyCallback> DocumentReady;
        public EventAdapter<OnJsQueryEventArgs, mbJsQueryCallback> JsQuery;
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
            LoadUrlEnd = new EventAdapter<LoadUrlEndEventArgs, mbLoadUrlEndCallback>(this, NativeMethods.mbOnLoadUrlEnd);
            DocumentReady = new EventAdapter<DocumentReadyEventArgs, mbDocumentReadyCallback>(this, NativeMethods.mbOnDocumentReady);
            JsQuery = new EventAdapter<OnJsQueryEventArgs, mbJsQueryCallback>(this, NativeMethods.mbOnJsQuery);

            if (!IsHandleCreated) CreateHandle();
            NativeMethods.mbSetAutoDrawToHwnd(WebView, false);
            _mbPaintBitUpdatedCallback = new mbPaintBitUpdatedCallback(mbPaintBitUpdated);
            NativeMethods.mbOnPaintBitUpdated(WebView, _mbPaintBitUpdatedCallback, IntPtr.Zero);
            WebView.SetHandle(Handle);
            ImeContext.SetImeStatus(ImeMode.NoControl, Handle);
            ImeMode = ImeMode.Off;
            Disposed += Browser_Disposed;
            DoubleBuffered = true;
        }
        public void mbPaintBitUpdated(mbWebView webview, IntPtr param, IntPtr buffer, ref mbRect r, int width, int height)
        {
            if (_image == null || _image.Width < width || _image.Height < height)
            {
                lock (this)
                    _image = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            }
            _drawSize = new Size(width, height);
            //计算更新区域
            var rect = new Rectangle
            {
                X = r.x >= width ? width - 1 : r.x,
                Y = r.y >= height ? height - 1 : r.y
            };
            rect.Width = rect.X + r.w > width ? width - rect.X : r.w;
            rect.Height = rect.Y + r.h > height ? height - rect.Y : r.h;

            BitmapData bitmapData = _image.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            IntPtr ptr = bitmapData.Scan0;
            unsafe
            {
                int targetStride = _image.Width;
                int sourceStride = width;
                int* target = (int*)ptr;
                int* source = (int*)buffer;
                int targetPix;
                int sourcePix;
                for (int h = 0; h < rect.Height; h++)
                {
                    for (int w = 0; w < rect.Width; w++)
                    {
                        targetPix = targetStride * h + w;
                        sourcePix = sourceStride * (rect.Y + h) + (rect.X + w);
                        *(target + targetPix) = *(source + sourcePix);
                    }
                }
            }
            _image.UnlockBits(bitmapData);


            Invalidate();
        }
        private void Browser_Disposed(object sender, EventArgs e)
        {
            Close();
        }

        private void Close()
        {
            if (!_disposed)
                lock (this)
                {
                    if (!_disposed)
                    {
                        _disposed = true;
                        NativeMethods.mbOnPaintBitUpdated(WebView, null, Handle);
                        WebView.SetHandle(IntPtr.Zero);
                        WebView.Destroy();
                    }
                }
        }
        public bool Simulate { get; set; }
        public mbWebView WebView { get; private set; }
        public bool IsDesignMode
        {
            get
            {
                string processName = Process.GetCurrentProcess().ProcessName;
                return DesignMode || processName.Contains("devenv") || processName.Contains("DesignToolsServer");
            }
        }
        public void OnPaintUpdate(mbWebView webview, IntPtr param, IntPtr hdc, int x, int y, int cx, int cy)
        {
            if (!IsDisposed)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    IntPtr ptr = graphics.GetHdc();
                    try
                    {
                        BitBlt(ptr, x, y, cx, cy, hdc, x, y, 0xcc0020);
                    }
                    finally
                    {
                        graphics.ReleaseHdc(ptr);
                    }
                }
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
        public bool RegSocketOnWillConnect(mbWebView mbWebView, onWillConnect onWillConnect, IntPtr param)
        {
            _mbWebsocketHookCallbacks.onWillConnect = onWillConnect;
            return RegWebsocketHookCallbacks(mbWebView, ref _mbWebsocketHookCallbacks, param);
        }
        public bool RegWebsocketHookCallbacks(mbWebView mbWebView, ref mbWebsocketHookCallbacks mbWebsocketHookCallbacks, IntPtr param)
        {
            if (mbWebsocketHookCallbacks.CanUse)
                NativeMethods.mbNetSetWebsocketCallback(mbWebView, ref mbWebsocketHookCallbacks, param);
            return true;
        }
        public bool RegSocketOnConnected(mbWebView mbWebView, onConnected onConnected, IntPtr param)
        {
            _mbWebsocketHookCallbacks.onConnected = onConnected;
            return RegWebsocketHookCallbacks(mbWebView, ref _mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnReceive(mbWebView mbWebView, onReceive onReceive, IntPtr param)
        {
            _mbWebsocketHookCallbacks.onReceive = onReceive;
            return RegWebsocketHookCallbacks(mbWebView, ref _mbWebsocketHookCallbacks, param); ;
        }
        public bool RegSocketOnSend(mbWebView mbWebView, onSend onSend, IntPtr param)
        {
            _mbWebsocketHookCallbacks.onSend = onSend;
            return RegWebsocketHookCallbacks(mbWebView, ref _mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnError(mbWebView mbWebView, onError onError, IntPtr param)
        {
            _mbWebsocketHookCallbacks.onError = onError;
            return RegWebsocketHookCallbacks(mbWebView, ref _mbWebsocketHookCallbacks, param);
        }
        protected override void OnResize(EventArgs e)
        {
            if (WebView.HaveValue)
                WebView.Resize(Size.Width, Size.Height);
            base.OnResize(e);
        }
        protected void DrawString(Graphics graphics, string message)
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            graphics.DrawString(message, drawFont, drawBrush, new Point(0, 0));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsDesignMode)
            {
                DrawString(e.Graphics, nameof(Browser));
            }
            else if (Simulate)
            {
                DrawString(e.Graphics, "SimulateMode");
            }
            if (_image != default)
            {
                lock (this)
                {
                    e.Graphics.DrawImage(_image, 0, 0);
                }
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
            if (WebView.HaveValue && !Simulate)
                WebView.FireMouseEvent(msg, e.X, e.Y, flags);
            base.OnMouseDown(e);
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
            if (WebView.HaveValue && !Simulate)
            {
                WebView.FireMouseEvent(msg, e.X, e.Y, flags);
            }
            base.OnMouseUp(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                uint flags = GetMouseFlags(e);
                WebView.FireMouseEvent(0x200, e.X, e.Y, flags);
            }
            base.OnMouseMove(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.FireKeyDownEvent((uint)e.KeyValue, 0, false);
            }
            base.OnKeyDown(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.FireKeyUpEvent((uint)e.KeyValue, 0, false);
            }
            base.OnKeyUp(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                e.Handled = true;
                WebView.FireKeyPressEvent((uint)e.KeyChar, 0, false);
            }
            base.OnKeyPress(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                uint flags = GetMouseFlags(e);
                WebView.FireMouseWheelEvent(e.X, e.Y, e.Delta, flags);
            }
            base.OnMouseWheel(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.KillFocus();
            }
            base.OnLostFocus(e);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.SetFocus();
            }
            base.OnGotFocus(e);
        }
        protected override void OnImeModeChanged(EventArgs e)
        {
            if (WebView.HaveValue)
            {
                ImeContext.SetImeStatus(ImeMode, Handle);
            }
            base.OnImeModeChanged(e);
        }
        protected override void WndProc(ref Message m)
        {
            IntPtr result = IntPtr.Zero;

            switch (m.Msg)
            {
                case Win32NativeMethods.WM_ERASEBKGND:
                    m.Result = ((IntPtr)1);
                    break;
                case Win32NativeMethods.WM_CONTEXTMENU:
                    int x = m.LParam.ToInt32() & 65535;
                    int y = m.LParam.ToInt32() >> 16;
                    if (x != -1 && y != -1)
                    {
                        Point p = PointToClient(new Point(x, y));
                        WebView.FireContextMenuEvent(p.X, p.Y, (uint)m.WParam);
                    }
                    break;
                case Win32NativeMethods.APPCOMMAND_SAVE:
                case Win32NativeMethods.WM_IME_SETCONTEXT:
                case Win32NativeMethods.WM_IME_STARTCOMPOSITION:
                case Win32NativeMethods.WM_IME_ENDCOMPOSITION:
                    if (WebView.HaveValue && WebView.FireWindowsMessage(m.HWnd, (uint)m.Msg, m.WParam, m.LParam, ref result))
                        m.Result = result;
                    return;
            }
            base.WndProc(ref m);
        }
        //~Browser()
        //{
        //    WebView.SetHandle(IntPtr.Zero);
        //    WebView.Destroy();
        //}
    }
}
