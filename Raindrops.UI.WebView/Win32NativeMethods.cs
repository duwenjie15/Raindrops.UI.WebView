#pragma warning disable IDE1006 // 命名样式
namespace Raindrops.UI.WebView
{
    public partial class Win32NativeMethods
    {
		public const int BITMAPINFO_MAX_COLORSIZE = 0x100;

		public const int PAGE_READWRITE = 4;

		public const int FILE_MAP_READ = 4;

		public const int APPCOMMAND_BROWSER_BACKWARD = 1;

		public const int APPCOMMAND_BROWSER_FORWARD = 2;

		public const int APPCOMMAND_BROWSER_REFRESH = 3;

		public const int APPCOMMAND_BROWSER_STOP = 4;

		public const int APPCOMMAND_BROWSER_SEARCH = 5;

		public const int APPCOMMAND_BROWSER_FAVORITES = 6;

		public const int APPCOMMAND_BROWSER_HOME = 7;

		public const int APPCOMMAND_VOLUME_MUTE = 8;

		public const int APPCOMMAND_VOLUME_DOWN = 9;

		public const int APPCOMMAND_VOLUME_UP = 0xA;

		public const int APPCOMMAND_MEDIA_NEXTTRACK = 0xB;

		public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 0xC;

		public const int APPCOMMAND_MEDIA_STOP = 0xD;

		public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 0xE;

		public const int APPCOMMAND_LAUNCH_MAIL = 0xF;

		public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 0x10;

		public const int APPCOMMAND_LAUNCH_APP1 = 0x11;

		public const int APPCOMMAND_LAUNCH_APP2 = 0x12;

		public const int APPCOMMAND_BASS_DOWN = 0x13;

		public const int APPCOMMAND_BASS_BOOST = 0x14;

		public const int APPCOMMAND_BASS_UP = 0x15;

		public const int APPCOMMAND_TREBLE_DOWN = 0x16;

		public const int APPCOMMAND_TREBLE_UP = 0x17;

		public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 0x18;

		public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 0x19;

		public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 0x1A;

		public const int APPCOMMAND_HELP = 0x1B;

		public const int APPCOMMAND_FIND = 0x1C;

		public const int APPCOMMAND_NEW = 0x1D;

		public const int APPCOMMAND_OPEN = 0x1E;

		public const int APPCOMMAND_CLOSE = 0x1F;

		public const int APPCOMMAND_SAVE = 0x20;

		public const int APPCOMMAND_PRINT = 0x21;

		public const int APPCOMMAND_UNDO = 0x22;

		public const int APPCOMMAND_REDO = 0x23;

		public const int APPCOMMAND_COPY = 0x24;

		public const int APPCOMMAND_CUT = 0x25;

		public const int APPCOMMAND_PASTE = 0x26;

		public const int APPCOMMAND_REPLY_TO_MAIL = 0x27;

		public const int APPCOMMAND_FORWARD_MAIL = 0x28;

		public const int APPCOMMAND_SEND_MAIL = 0x29;

		public const int APPCOMMAND_SPELL_CHECK = 0x2A;

		public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 0x2B;

		public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 0x2C;

		public const int APPCOMMAND_CORRECTION_LIST = 0x2D;

		public const int APPCOMMAND_MEDIA_PLAY = 0x2E;

		public const int APPCOMMAND_MEDIA_PAUSE = 0x2F;

		public const int APPCOMMAND_MEDIA_RECORD = 0x30;

		public const int APPCOMMAND_MEDIA_FAST_FORWARD = 0x31;

		public const int APPCOMMAND_MEDIA_REWIND = 0x32;

		public const int APPCOMMAND_MEDIA_CHANNEL_UP = 0x33;

		public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 0x34;

		public const int FAPPCOMMAND_MOUSE = 0x8000;

		public const int FAPPCOMMAND_KEY = 0;

		public const int FAPPCOMMAND_OEM = 0x1000;

		public const int FAPPCOMMAND_MASK = 0xF000;

		public const int BI_RGB = 0;

		public const int BITSPIXEL = 0xC;

		public const int cmb4 = 0x473;

		public const int CS_DBLCLKS = 8;

		public const int CS_DROPSHADOW = 0x20000;

		public const int CS_SAVEBITS = 0x800;

		public const int CF_TEXT = 1;

		public const int CF_BITMAP = 2;

		public const int CF_METAFILEPICT = 3;

		public const int CF_SYLK = 4;

		public const int CF_DIF = 5;

		public const int CF_TIFF = 6;

		public const int CF_OEMTEXT = 7;

		public const int CF_DIB = 8;

		public const int CF_PALETTE = 9;

		public const int CF_PENDATA = 0xA;

		public const int CF_RIFF = 0xB;

		public const int CF_WAVE = 0xC;

		public const int CF_UNICODETEXT = 0xD;

		public const int CF_ENHMETAFILE = 0xE;

		public const int CF_HDROP = 0xF;

		public const int CF_LOCALE = 0x10;

		public const int CLSCTX_INPROC_SERVER = 1;

		public const int CLSCTX_LOCAL_SERVER = 4;

		public const int CW_USEDEFAULT = -0x80000000;

		public const int CWP_SKIPINVISIBLE = 1;

		public const int COLOR_WINDOW = 5;

		public const int CB_ERR = -1;

		public const int CBN_SELCHANGE = 1;

		public const int CBN_DBLCLK = 2;

		public const int CBN_EDITCHANGE = 5;

		public const int CBN_EDITUPDATE = 6;

		public const int CBN_DROPDOWN = 7;

		public const int CBN_CLOSEUP = 8;

		public const int CBN_SELENDOK = 9;

		public const int CBS_SIMPLE = 1;

		public const int CBS_DROPDOWN = 2;

		public const int CBS_DROPDOWNLIST = 3;

		public const int CBS_OWNERDRAWFIXED = 0x10;

		public const int CBS_OWNERDRAWVARIABLE = 0x20;

		public const int CBS_AUTOHSCROLL = 0x40;

		public const int CBS_HASSTRINGS = 0x200;

		public const int CBS_NOINTEGRALHEIGHT = 0x400;

		public const int CB_GETEDITSEL = 0x140;

		public const int CB_LIMITTEXT = 0x141;

		public const int CB_SETEDITSEL = 0x142;

		public const int CB_ADDSTRING = 0x143;

		public const int CB_DELETESTRING = 0x144;

		public const int CB_GETCURSEL = 0x147;

		public const int CB_GETLBTEXT = 0x148;

		public const int CB_GETLBTEXTLEN = 0x149;

		public const int CB_INSERTSTRING = 0x14A;

		public const int CB_RESETCONTENT = 0x14B;

		public const int CB_FINDSTRING = 0x14C;

		public const int CB_SETCURSEL = 0x14E;

		public const int CB_SHOWDROPDOWN = 0x14F;

		public const int CB_GETITEMDATA = 0x150;

		public const int CB_SETITEMHEIGHT = 0x153;

		public const int CB_GETITEMHEIGHT = 0x154;

		public const int CB_GETDROPPEDSTATE = 0x157;

		public const int CB_FINDSTRINGEXACT = 0x158;

		public const int CB_SETDROPPEDWIDTH = 0x160;

		public const int CDRF_DODEFAULT = 0;

		public const int CDRF_NEWFONT = 2;

		public const int CDRF_SKIPDEFAULT = 4;

		public const int CDRF_NOTIFYPOSTPAINT = 0x10;

		public const int CDRF_NOTIFYITEMDRAW = 0x20;

		public const int CDRF_NOTIFYSUBITEMDRAW = 0x20;

		public const int CDDS_PREPAINT = 1;

		public const int CDDS_POSTPAINT = 2;

		public const int CDDS_ITEM = 0x10000;

		public const int CDDS_SUBITEM = 0x20000;

		public const int CDDS_ITEMPREPAINT = 0x10001;

		public const int CDDS_ITEMPOSTPAINT = 0x10002;

		public const int CDIS_SELECTED = 1;

		public const int CDIS_GRAYED = 2;

		public const int CDIS_DISABLED = 4;

		public const int CDIS_CHECKED = 8;

		public const int CDIS_FOCUS = 0x10;

		public const int CDIS_DEFAULT = 0x20;

		public const int CDIS_HOT = 0x40;

		public const int CDIS_MARKED = 0x80;

		public const int CDIS_INDETERMINATE = 0x100;

		public const int CDIS_SHOWKEYBOARDCUES = 0x200;

		public const int CLR_NONE = -1;

		public const int CLR_DEFAULT = -0x1000000;

		public const int CCM_SETVERSION = 0x2007;

		public const int CCM_GETVERSION = 0x2008;

		public const int CCS_NORESIZE = 4;

		public const int CCS_NOPARENTALIGN = 8;

		public const int CCS_NODIVIDER = 0x40;

		public const int CBEM_INSERTITEMA = 0x401;

		public const int CBEM_GETITEMA = 0x404;

		public const int CBEM_SETITEMA = 0x405;

		public const int CBEM_INSERTITEMW = 0x40B;

		public const int CBEM_SETITEMW = 0x40C;

		public const int CBEM_GETITEMW = 0x40D;

		public const int CBEN_ENDEDITA = -0x325;

		public const int CBEN_ENDEDITW = -0x326;

		public const int CONNECT_E_NOCONNECTION = -0x7FFBFE00;

		public const int CONNECT_E_CANNOTCONNECT = -0x7FFBFDFE;

		public const int CTRLINFO_EATS_RETURN = 1;

		public const int CTRLINFO_EATS_ESCAPE = 2;

		public const int CSIDL_DESKTOP = 0;

		public const int CSIDL_INTERNET = 1;

		public const int CSIDL_PROGRAMS = 2;

		public const int CSIDL_PERSONAL = 5;

		public const int CSIDL_FAVORITES = 6;

		public const int CSIDL_STARTUP = 7;

		public const int CSIDL_RECENT = 8;

		public const int CSIDL_SENDTO = 9;

		public const int CSIDL_STARTMENU = 0xB;

		public const int CSIDL_DESKTOPDIRECTORY = 0x10;

		public const int CSIDL_TEMPLATES = 0x15;

		public const int CSIDL_APPDATA = 0x1A;

		public const int CSIDL_LOCAL_APPDATA = 0x1C;

		public const int CSIDL_INTERNET_CACHE = 0x20;

		public const int CSIDL_COOKIES = 0x21;

		public const int CSIDL_HISTORY = 0x22;

		public const int CSIDL_COMMON_APPDATA = 0x23;

		public const int CSIDL_SYSTEM = 0x25;

		public const int CSIDL_PROGRAM_FILES = 0x26;

		public const int CSIDL_PROGRAM_FILES_COMMON = 0x2B;

		public const int DUPLICATE = 6;

		public const int DISPID_UNKNOWN = -1;

		public const int DISPID_PROPERTYPUT = -3;

		public const int DISPATCH_METHOD = 1;

		public const int DISPATCH_PROPERTYGET = 2;

		public const int DISPATCH_PROPERTYPUT = 4;

		public const int DV_E_DVASPECT = -0x7FFBFF95;

		public const int DISP_E_MEMBERNOTFOUND = -0x7FFDFFFD;

		public const int DISP_E_PARAMNOTFOUND = -0x7FFDFFFC;

		public const int DISP_E_EXCEPTION = -0x7FFDFFF7;

		public const int DEFAULT_GUI_FONT = 0x11;

		public const int DIB_RGB_COLORS = 0;

		public const int DRAGDROP_E_NOTREGISTERED = -0x7FFBFF00;

		public const int DRAGDROP_E_ALREADYREGISTERED = -0x7FFBFEFF;

		public const int DUPLICATE_SAME_ACCESS = 2;

		public const int DFC_CAPTION = 1;

		public const int DFC_MENU = 2;

		public const int DFC_SCROLL = 3;

		public const int DFC_BUTTON = 4;

		public const int DFCS_CAPTIONCLOSE = 0;

		public const int DFCS_CAPTIONMIN = 1;

		public const int DFCS_CAPTIONMAX = 2;

		public const int DFCS_CAPTIONRESTORE = 3;

		public const int DFCS_CAPTIONHELP = 4;

		public const int DFCS_MENUARROW = 0;

		public const int DFCS_MENUCHECK = 1;

		public const int DFCS_MENUBULLET = 2;

		public const int DFCS_SCROLLUP = 0;

		public const int DFCS_SCROLLDOWN = 1;

		public const int DFCS_SCROLLLEFT = 2;

		public const int DFCS_SCROLLRIGHT = 3;

		public const int DFCS_SCROLLCOMBOBOX = 5;

		public const int DFCS_BUTTONCHECK = 0;

		public const int DFCS_BUTTONRADIO = 4;

		public const int DFCS_BUTTON3STATE = 8;

		public const int DFCS_BUTTONPUSH = 0x10;

		public const int DFCS_INACTIVE = 0x100;

		public const int DFCS_PUSHED = 0x200;

		public const int DFCS_CHECKED = 0x400;

		public const int DFCS_FLAT = 0x4000;

		public const int DT_LEFT = 0;

		public const int DT_RIGHT = 2;

		public const int DT_VCENTER = 4;

		public const int DT_SINGLELINE = 0x20;

		public const int DT_NOCLIP = 0x100;

		public const int DT_CALCRECT = 0x400;

		public const int DT_NOPREFIX = 0x800;

		public const int DT_EDITCONTROL = 0x2000;

		public const int DT_EXPANDTABS = 0x40;

		public const int DT_END_ELLIPSIS = 0x8000;

		public const int DT_RTLREADING = 0x20000;

		public const int DT_WORDBREAK = 0x10;

		public const int DCX_WINDOW = 1;

		public const int DCX_CACHE = 2;

		public const int DCX_LOCKWINDOWUPDATE = 0x400;

		public const int DI_NORMAL = 3;

		public const int DLGC_WANTARROWS = 1;

		public const int DLGC_WANTTAB = 2;

		public const int DLGC_WANTALLKEYS = 4;

		public const int DLGC_WANTCHARS = 0x80;

		public const int DTM_GETSYSTEMTIME = 0x1001;

		public const int DTM_SETSYSTEMTIME = 0x1002;

		public const int DTM_SETRANGE = 0x1004;

		public const int DTM_SETFORMATA = 0x1005;

		public const int DTM_SETFORMATW = 0x1032;

		public const int DTM_SETMCCOLOR = 0x1006;

		public const int DTM_SETMCFONT = 0x1009;

		public const int DTS_UPDOWN = 1;

		public const int DTS_SHOWNONE = 2;

		public const int DTS_LONGDATEFORMAT = 4;

		public const int DTS_TIMEFORMAT = 9;

		public const int DTS_RIGHTALIGN = 0x20;

		public const int DTN_DATETIMECHANGE = -0x2F7;

		public const int DTN_USERSTRINGA = -0x2F6;

		public const int DTN_USERSTRINGW = -0x2E9;

		public const int DTN_WMKEYDOWNA = -0x2F5;

		public const int DTN_WMKEYDOWNW = -0x2E8;

		public const int DTN_FORMATA = -0x2F4;

		public const int DTN_FORMATW = -0x2E7;

		public const int DTN_FORMATQUERYA = -0x2F3;

		public const int DTN_FORMATQUERYW = -0x2E6;

		public const int DTN_DROPDOWN = -0x2F2;

		public const int DTN_CLOSEUP = -0x2F1;

		public const int DVASPECT_CONTENT = 1;

		public const int DVASPECT_TRANSPARENT = 0x20;

		public const int DVASPECT_OPAQUE = 0x10;

		public const int E_NOTIMPL = -0x7FFFBFFF;

		public const int E_OUTOFMEMORY = -0x7FF8FFF2;

		public const int E_INVALIDARG = -0x7FF8FFA9;

		public const int E_NOINTERFACE = -0x7FFFBFFE;

		public const int E_FAIL = -0x7FFFBFFB;

		public const int E_ABORT = -0x7FFFBFFC;

		public const int E_UNEXPECTED = -0x7FFF0001;

		public const int INET_E_DEFAULT_ACTION = -0x7FF3FFEF;

		public const int ETO_OPAQUE = 2;

		public const int ETO_CLIPPED = 4;

		public const int EMR_POLYTEXTOUTA = 0x60;

		public const int EMR_POLYTEXTOUTW = 0x61;

		public const int EDGE_RAISED = 5;

		public const int EDGE_SUNKEN = 0xA;

		public const int EDGE_ETCHED = 6;

		public const int EDGE_BUMP = 9;

		public const int ES_LEFT = 0;

		public const int ES_CENTER = 1;

		public const int ES_RIGHT = 2;

		public const int ES_MULTILINE = 4;

		public const int ES_UPPERCASE = 8;

		public const int ES_LOWERCASE = 0x10;

		public const int ES_AUTOVSCROLL = 0x40;

		public const int ES_AUTOHSCROLL = 0x80;

		public const int ES_NOHIDESEL = 0x100;

		public const int ES_READONLY = 0x800;

		public const int ES_PASSWORD = 0x20;

		public const int EN_CHANGE = 0x300;

		public const int EN_UPDATE = 0x400;

		public const int EN_HSCROLL = 0x601;

		public const int EN_VSCROLL = 0x602;

		public const int EN_ALIGN_LTR_EC = 0x700;

		public const int EN_ALIGN_RTL_EC = 0x701;

		public const int EC_LEFTMARGIN = 1;

		public const int EC_RIGHTMARGIN = 2;

		public const int EM_GETSEL = 0xB0;

		public const int EM_SETSEL = 0xB1;

		public const int EM_SCROLL = 0xB5;

		public const int EM_SCROLLCARET = 0xB7;

		public const int EM_GETMODIFY = 0xB8;

		public const int EM_SETMODIFY = 0xB9;

		public const int EM_GETLINECOUNT = 0xBA;

		public const int EM_REPLACESEL = 0xC2;

		public const int EM_GETLINE = 0xC4;

		public const int EM_LIMITTEXT = 0xC5;

		public const int EM_CANUNDO = 0xC6;

		public const int EM_UNDO = 0xC7;

		public const int EM_SETPASSWORDCHAR = 0xCC;

		public const int EM_GETPASSWORDCHAR = 0xD2;

		public const int EM_EMPTYUNDOBUFFER = 0xCD;

		public const int EM_SETREADONLY = 0xCF;

		public const int EM_SETMARGINS = 0xD3;

		public const int EM_POSFROMCHAR = 0xD6;

		public const int EM_CHARFROMPOS = 0xD7;

		public const int EM_LINEFROMCHAR = 0xC9;

		public const int EM_LINEINDEX = 0xBB;

		public const int FNERR_SUBCLASSFAILURE = 0x3001;

		public const int FNERR_INVALIDFILENAME = 0x3002;

		public const int FNERR_BUFFERTOOSMALL = 0x3003;

		public const int GMEM_MOVEABLE = 2;

		public const int GMEM_ZEROINIT = 0x40;

		public const int GMEM_DDESHARE = 0x2000;

		public const int GCL_WNDPROC = -0x18;

		public const int GWL_WNDPROC = -4;

		public const int GWL_HWNDPARENT = -8;

		public const int GWL_STYLE = -0x10;

		public const int GWL_EXSTYLE = -0x14;

		public const int GWL_ID = -0xC;

		public const int GW_HWNDFIRST = 0;

		public const int GW_HWNDLAST = 1;

		public const int GW_HWNDNEXT = 2;

		public const int GW_HWNDPREV = 3;

		public const int GW_CHILD = 5;

		public const int GMR_VISIBLE = 0;

		public const int GMR_DAYSTATE = 1;

		public const int GDI_ERROR = -1;

		public const int GDTR_MIN = 1;

		public const int GDTR_MAX = 2;

		public const int GDT_VALID = 0;

		public const int GDT_NONE = 1;

		public const int GA_PARENT = 1;

		public const int GA_ROOT = 2;

		public const int GCS_COMPREADSTR = 1;

		public const int GCS_COMPREADATTR = 2;

		public const int GCS_COMPREADCLAUSE = 4;

		public const int GCS_COMPSTR = 8;

		public const int GCS_COMPATTR = 0x10;

		public const int GCS_COMPCLAUSE = 0x20;

		public const int GCS_CURSORPOS = 0x80;

		public const int GCS_DELTASTART = 0x100;

		public const int GCS_RESULTREADSTR = 0x200;

		public const int GCS_RESULTREADCLAUSE = 0x400;

		public const int GCS_RESULTSTR = 0x800;

		public const int GCS_RESULTCLAUSE = 0x1000;

		public const int ATTR_INPUT = 0;

		public const int ATTR_TARGET_CONVERTED = 1;

		public const int ATTR_CONVERTED = 2;

		public const int ATTR_TARGET_NOTCONVERTED = 3;

		public const int ATTR_INPUT_ERROR = 4;

		public const int ATTR_FIXEDCONVERTED = 5;

		public const int NI_COMPOSITIONSTR = 0x15;

		public const int IMN_CLOSESTATUSWINDOW = 1;

		public const int IMN_OPENSTATUSWINDOW = 2;

		public const int IMN_CHANGECANDIDATE = 3;

		public const int IMN_CLOSECANDIDATE = 4;

		public const int IMN_OPENCANDIDATE = 5;

		public const int IMN_SETCONVERSIONMODE = 6;

		public const int IMN_SETSENTENCEMODE = 7;

		public const int IMN_SETOPENSTATUS = 8;

		public const int IMN_SETCANDIDATEPOS = 9;

		public const int IMN_SETCOMPOSITIONFONT = 0xA;

		public const int IMN_SETCOMPOSITIONWINDOW = 0xB;

		public const int IMN_SETSTATUSWINDOWPOS = 0xC;

		public const int IMN_GUIDELINE = 0xD;

		public const int IMN_PRIVATE = 0xE;

		public const int CPS_COMPLETE = 1;

		public const int CPS_CANCEL = 4;

		public const int CFS_DEFAULT = 0;

		public const int CFS_RECT = 1;

		public const int CFS_POINT = 2;

		public const int CFS_FORCE_POSITION = 0x20;

		public const int CFS_CANDIDATEPOS = 0x40;

		public const int CFS_EXCLUDE = 0x80;

		public const int IME_CMODE_ALPHANUMERIC = 0;

		public const int IME_CMODE_NATIVE = 1;

		public const int IME_CMODE_CHINESE = 1;

		public const int IME_CMODE_HANGEUL = 1;

		public const int IME_CMODE_HANGUL = 1;

		public const int IME_CMODE_JAPANESE = 1;

		public const int IME_CMODE_KATAKANA = 2;

		public const int IME_CMODE_LANGUAGE = 3;

		public const int IME_CMODE_FULLSHAPE = 8;

		public const int IME_CMODE_ROMAN = 0x10;

		public const int IME_CMODE_CHARCODE = 0x20;

		public const int IME_CMODE_HANJACONVERT = 0x40;

		public const int IME_CMODE_SOFTKBD = 0x80;

		public const int IME_CMODE_NOCONVERSION = 0x100;

		public const int IME_CMODE_EUDC = 0x200;

		public const int IME_CMODE_SYMBOL = 0x400;

		public const int IME_CMODE_FIXED = 0x800;

		public const int IME_CMODE_RESERVED = -0x10000000;

		public const int IME_SMODE_NONE = 0;

		public const int IME_SMODE_PLAURALCLAUSE = 1;

		public const int IME_SMODE_SINGLECONVERT = 2;

		public const int IME_SMODE_AUTOMATIC = 4;

		public const int IME_SMODE_PHRASEPREDICT = 8;

		public const int IME_SMODE_CONVERSATION = 0x10;

		public const int IME_SMODE_RESERVED = 0xF000;

		public const int IME_CAND_UNKNOWN = 0;

		public const int IME_CAND_READ = 1;

		public const int IME_CAND_CODE = 2;

		public const int IME_CAND_MEANING = 3;

		public const int IME_CAND_RADICAL = 4;

		public const int IME_CAND_STROKE = 5;

		public const int IMR_COMPOSITIONWINDOW = 1;

		public const int IMR_CANDIDATEWINDOW = 2;

		public const int IMR_COMPOSITIONFONT = 3;

		public const int IMR_RECONVERTSTRING = 4;

		public const int IMR_CONFIRMRECONVERTSTRING = 5;

		public const int IMR_QUERYCHARPOSITION = 6;

		public const int IMR_DOCUMENTFEED = 7;

		public const int IME_CONFIG_GENERAL = 1;

		public const int IME_CONFIG_REGISTERWORD = 2;

		public const int IME_CONFIG_SELECTDICTIONARY = 3;

		public const int IGP_GETIMEVERSION = -4;

		public const int IGP_PROPERTY = 4;

		public const int IGP_CONVERSION = 8;

		public const int IGP_SENTENCE = 0xC;

		public const int IGP_UI = 0x10;

		public const int IGP_SETCOMPSTR = 0x14;

		public const int IGP_SELECT = 0x18;

		public const int IME_PROP_AT_CARET = 0x10000;

		public const int IME_PROP_SPECIAL_UI = 0x20000;

		public const int IME_PROP_CANDLIST_START_FROM_1 = 0x40000;

		public const int IME_PROP_UNICODE = 0x80000;

		public const int IME_PROP_COMPLETE_ON_UNSELECT = 0x100000;

		public const int HC_ACTION = 0;

		public const int HC_GETNEXT = 1;

		public const int HC_SKIP = 2;

		public const int HTNOWHERE = 0;

		public const int HTCLIENT = 1;

		public const int HTBOTTOM = 0xF;

		public const int HTTRANSPARENT = -1;

		public const int HTBOTTOMLEFT = 0x10;

		public const int HTBOTTOMRIGHT = 0x11;

		public const int HELPINFO_WINDOW = 1;

		public const int HCF_HIGHCONTRASTON = 1;

		public const int HDI_ORDER = 0x80;

		public const int HDI_WIDTH = 1;

		public const int HDM_GETITEMCOUNT = 0x1200;

		public const int HDM_INSERTITEMA = 0x1201;

		public const int HDM_INSERTITEMW = 0x120A;

		public const int HDM_GETITEMA = 0x1203;

		public const int HDM_GETITEMW = 0x120B;

		public const int HDM_SETITEMA = 0x1204;

		public const int HDM_SETITEMW = 0x120C;

		public const int HDN_ITEMCHANGINGA = -0x12C;

		public const int HDN_ITEMCHANGINGW = -0x140;

		public const int HDN_ITEMCHANGEDA = -0x12D;

		public const int HDN_ITEMCHANGEDW = -0x141;

		public const int HDN_ITEMCLICKA = -0x12E;

		public const int HDN_ITEMCLICKW = -0x142;

		public const int HDN_ITEMDBLCLICKA = -0x12F;

		public const int HDN_ITEMDBLCLICKW = -0x143;

		public const int HDN_DIVIDERDBLCLICKA = -0x131;

		public const int HDN_DIVIDERDBLCLICKW = -0x145;

		public const int HDN_BEGINTDRAG = -0x136;

		public const int HDN_BEGINTRACKA = -0x132;

		public const int HDN_BEGINTRACKW = -0x146;

		public const int HDN_ENDDRAG = -0x137;

		public const int HDN_ENDTRACKA = -0x133;

		public const int HDN_ENDTRACKW = -0x147;

		public const int HDN_TRACKA = -0x134;

		public const int HDN_TRACKW = -0x148;

		public const int HDN_GETDISPINFOA = -0x135;

		public const int HDN_GETDISPINFOW = -0x149;

		public const int INPLACE_E_NOTOOLSPACE = -0x7FFBFE5F;

		public const int ICON_SMALL = 0;

		public const int ICON_BIG = 1;

		public const int IDC_ARROW = 0x7F00;

		public const int IDC_IBEAM = 0x7F01;

		public const int IDC_WAIT = 0x7F02;

		public const int IDC_CROSS = 0x7F03;

		public const int IDC_SIZEALL = 0x7F86;

		public const int IDC_SIZENWSE = 0x7F82;

		public const int IDC_SIZENESW = 0x7F83;

		public const int IDC_SIZEWE = 0x7F84;

		public const int IDC_SIZENS = 0x7F85;

		public const int IDC_UPARROW = 0x7F04;

		public const int IDC_NO = 0x7F88;

		public const int IDC_APPSTARTING = 0x7F8A;

		public const int IDC_HELP = 0x7F8B;

		public const int IMAGE_ICON = 1;

		public const int IMAGE_CURSOR = 2;

		public const int ICC_LISTVIEW_CLASSES = 1;

		public const int ICC_TREEVIEW_CLASSES = 2;

		public const int ICC_BAR_CLASSES = 4;

		public const int ICC_TAB_CLASSES = 8;

		public const int ICC_PROGRESS_CLASS = 0x20;

		public const int ICC_DATE_CLASSES = 0x100;

		public const int ILC_MASK = 1;

		public const int ILC_COLOR = 0;

		public const int ILC_COLOR4 = 4;

		public const int ILC_COLOR8 = 8;

		public const int ILC_COLOR16 = 0x10;

		public const int ILC_COLOR24 = 0x18;

		public const int ILC_COLOR32 = 0x20;

		public const int ILC_MIRROR = 0x2000;

		public const int ILD_NORMAL = 0;

		public const int ILD_TRANSPARENT = 1;

		public const int ILD_MASK = 0x10;

		public const int ILD_ROP = 0x40;

		public const int ILP_NORMAL = 0;

		public const int ILP_DOWNLEVEL = 1;

		public const int ILS_NORMAL = 0;

		public const int ILS_GLOW = 1;

		public const int ILS_SHADOW = 2;

		public const int ILS_SATURATE = 4;

		public const int ILS_ALPHA = 8;

		public const int CSC_NAVIGATEFORWARD = 1;

		public const int CSC_NAVIGATEBACK = 2;

		public const int STG_E_CANTSAVE = -0x7FFCFEFD;

		public const int LOGPIXELSX = 0x58;

		public const int LOGPIXELSY = 0x5A;

		public const int LB_ERR = -1;

		public const int LB_ERRSPACE = -2;

		public const int LBN_SELCHANGE = 1;

		public const int LBN_DBLCLK = 2;

		public const int LB_ADDSTRING = 0x180;

		public const int LB_INSERTSTRING = 0x181;

		public const int LB_DELETESTRING = 0x182;

		public const int LB_RESETCONTENT = 0x184;

		public const int LB_SETSEL = 0x185;

		public const int LB_SETCURSEL = 0x186;

		public const int LB_GETSEL = 0x187;

		public const int LB_GETCARETINDEX = 0x19F;

		public const int LB_GETCURSEL = 0x188;

		public const int LB_GETTEXT = 0x189;

		public const int LB_GETTEXTLEN = 0x18A;

		public const int LB_GETTOPINDEX = 0x18E;

		public const int LB_FINDSTRING = 0x18F;

		public const int LB_GETSELCOUNT = 0x190;

		public const int LB_GETSELITEMS = 0x191;

		public const int LB_SETTABSTOPS = 0x192;

		public const int LB_SETHORIZONTALEXTENT = 0x194;

		public const int LB_SETCOLUMNWIDTH = 0x195;

		public const int LB_SETTOPINDEX = 0x197;

		public const int LB_GETITEMRECT = 0x198;

		public const int LB_SETITEMHEIGHT = 0x1A0;

		public const int LB_GETITEMHEIGHT = 0x1A1;

		public const int LB_FINDSTRINGEXACT = 0x1A2;

		public const int LB_ITEMFROMPOINT = 0x1A9;

		public const int LB_SETLOCALE = 0x1A5;

		public const int LWA_ALPHA = 2;

		public const int MEMBERID_NIL = -1;

		public const int MAX_PATH = 0x104;

		public const int MA_ACTIVATE = 1;

		public const int MA_ACTIVATEANDEAT = 2;

		public const int MA_NOACTIVATE = 3;

		public const int MA_NOACTIVATEANDEAT = 4;

		public const int MM_TEXT = 1;

		public const int MM_ANISOTROPIC = 8;

		public const int MK_LBUTTON = 1;

		public const int MK_RBUTTON = 2;

		public const int MK_SHIFT = 4;

		public const int MK_CONTROL = 8;

		public const int MK_MBUTTON = 0x10;

		public const int MNC_EXECUTE = 2;

		public const int MNC_SELECT = 3;

		public const int MIIM_STATE = 1;

		public const int MIIM_ID = 2;

		public const int MIIM_SUBMENU = 4;

		public const int MIIM_TYPE = 0x10;

		public const int MIIM_DATA = 0x20;

		public const int MIIM_STRING = 0x40;

		public const int MIIM_BITMAP = 0x80;

		public const int MIIM_FTYPE = 0x100;

		public const int MB_OK = 0;

		public const int MF_BYCOMMAND = 0;

		public const int MF_BYPOSITION = 0x400;

		public const int MF_ENABLED = 0;

		public const int MF_GRAYED = 1;

		public const int MF_POPUP = 0x10;

		public const int MF_SYSMENU = 0x2000;

		public const int MFS_DISABLED = 3;

		public const int MFT_MENUBREAK = 0x40;

		public const int MFT_SEPARATOR = 0x800;

		public const int MFT_RIGHTORDER = 0x2000;

		public const int MFT_RIGHTJUSTIFY = 0x4000;

		public const int MDIS_ALLCHILDSTYLES = 1;

		public const int MDITILE_VERTICAL = 0;

		public const int MDITILE_HORIZONTAL = 1;

		public const int MDITILE_SKIPDISABLED = 2;

		public const int MCM_SETMAXSELCOUNT = 0x1004;

		public const int MCM_SETSELRANGE = 0x1006;

		public const int MCM_GETMONTHRANGE = 0x1007;

		public const int MCM_GETMINREQRECT = 0x1009;

		public const int MCM_SETCOLOR = 0x100A;

		public const int MCM_SETTODAY = 0x100C;

		public const int MCM_GETTODAY = 0x100D;

		public const int MCM_HITTEST = 0x100E;

		public const int MCM_SETFIRSTDAYOFWEEK = 0x100F;

		public const int MCM_SETRANGE = 0x1012;

		public const int MCM_SETMONTHDELTA = 0x1014;

		public const int MCM_GETMAXTODAYWIDTH = 0x1015;

		public const int MCHT_TITLE = 0x10000;

		public const int MCHT_CALENDAR = 0x20000;

		public const int MCHT_TODAYLINK = 0x30000;

		public const int MCHT_TITLEBK = 0x10000;

		public const int MCHT_TITLEMONTH = 0x10001;

		public const int MCHT_TITLEYEAR = 0x10002;

		public const int MCHT_TITLEBTNNEXT = 0x1010003;

		public const int MCHT_TITLEBTNPREV = 0x2010003;

		public const int MCHT_CALENDARBK = 0x20000;

		public const int MCHT_CALENDARDATE = 0x20001;

		public const int MCHT_CALENDARDATENEXT = 0x1020001;

		public const int MCHT_CALENDARDATEPREV = 0x2020001;

		public const int MCHT_CALENDARDAY = 0x20002;

		public const int MCHT_CALENDARWEEKNUM = 0x20003;

		public const int MCSC_TEXT = 1;

		public const int MCSC_TITLEBK = 2;

		public const int MCSC_TITLETEXT = 3;

		public const int MCSC_MONTHBK = 4;

		public const int MCSC_TRAILINGTEXT = 5;

		public const int MCN_SELCHANGE = -0x2ED;

		public const int MCN_GETDAYSTATE = -0x2EB;

		public const int MCN_SELECT = -0x2EA;

		public const int MCS_DAYSTATE = 1;

		public const int MCS_MULTISELECT = 2;

		public const int MCS_WEEKNUMBERS = 4;

		public const int MCS_NOTODAYCIRCLE = 8;

		public const int MCS_NOTODAY = 0x10;

		public const int MSAA_MENU_SIG = -0x55F20FF3;

		public const int OLECONTF_EMBEDDINGS = 1;

		public const int OLECONTF_LINKS = 2;

		public const int OLECONTF_OTHERS = 4;

		public const int OLECONTF_ONLYUSER = 8;

		public const int OLECONTF_ONLYIFRUNNING = 0x10;

		public const int OLEMISC_RECOMPOSEONRESIZE = 1;

		public const int OLEMISC_INSIDEOUT = 0x80;

		public const int OLEMISC_ACTIVATEWHENVISIBLE = 0x100;

		public const int OLEMISC_ACTSLIKEBUTTON = 0x1000;

		public const int OLEMISC_SETCLIENTSITEFIRST = 0x20000;

		public const int OLEIVERB_PRIMARY = 0;

		public const int OLEIVERB_SHOW = -1;

		public const int OLEIVERB_HIDE = -3;

		public const int OLEIVERB_UIACTIVATE = -4;

		public const int OLEIVERB_INPLACEACTIVATE = -5;

		public const int OLEIVERB_DISCARDUNDOSTATE = -6;

		public const int OLEIVERB_PROPERTIES = -7;

		public const int XFORMCOORDS_POSITION = 1;

		public const int XFORMCOORDS_SIZE = 2;

		public const int XFORMCOORDS_HIMETRICTOCONTAINER = 4;

		public const int XFORMCOORDS_CONTAINERTOHIMETRIC = 8;

		public const int OFN_READONLY = 1;

		public const int OFN_OVERWRITEPROMPT = 2;

		public const int OFN_HIDEREADONLY = 4;

		public const int OFN_NOCHANGEDIR = 8;

		public const int OFN_ENABLEHOOK = 0x20;

		public const int OFN_NOVALIDATE = 0x100;

		public const int OFN_ALLOWMULTISELECT = 0x200;

		public const int OFN_PATHMUSTEXIST = 0x800;

		public const int OFN_FILEMUSTEXIST = 0x1000;

		public const int OFN_CREATEPROMPT = 0x2000;

		public const int OFN_EXPLORER = 0x80000;

		public const int OFN_NODEREFERENCELINKS = 0x100000;

		public const int OFN_ENABLESIZING = 0x800000;

		public const int OFN_USESHELLITEM = 0x1000000;

		public const int PDERR_SETUPFAILURE = 0x1001;

		public const int PDERR_PARSEFAILURE = 0x1002;

		public const int PDERR_RETDEFFAILURE = 0x1003;

		public const int PDERR_LOADDRVFAILURE = 0x1004;

		public const int PDERR_GETDEVMODEFAIL = 0x1005;

		public const int PDERR_INITFAILURE = 0x1006;

		public const int PDERR_NODEVICES = 0x1007;

		public const int PDERR_NODEFAULTPRN = 0x1008;

		public const int PDERR_DNDMMISMATCH = 0x1009;

		public const int PDERR_CREATEICFAILURE = 0x100A;

		public const int PDERR_PRINTERNOTFOUND = 0x100B;

		public const int PDERR_DEFAULTDIFFERENT = 0x100C;

		public const int PD_ALLPAGES = 0;

		public const int PD_SELECTION = 1;

		public const int PD_PAGENUMS = 2;

		public const int PD_NOSELECTION = 4;

		public const int PD_NOPAGENUMS = 8;

		public const int PD_COLLATE = 0x10;

		public const int PD_PRINTTOFILE = 0x20;

		public const int PD_PRINTSETUP = 0x40;

		public const int PD_NOWARNING = 0x80;

		public const int PD_RETURNDC = 0x100;

		public const int PD_RETURNIC = 0x200;

		public const int PD_RETURNDEFAULT = 0x400;

		public const int PD_SHOWHELP = 0x800;

		public const int PD_ENABLEPRINTHOOK = 0x1000;

		public const int PD_ENABLESETUPHOOK = 0x2000;

		public const int PD_ENABLEPRINTTEMPLATE = 0x4000;

		public const int PD_ENABLESETUPTEMPLATE = 0x8000;

		public const int PD_ENABLEPRINTTEMPLATEHANDLE = 0x10000;

		public const int PD_ENABLESETUPTEMPLATEHANDLE = 0x20000;

		public const int PD_USEDEVMODECOPIES = 0x40000;

		public const int PD_USEDEVMODECOPIESANDCOLLATE = 0x40000;

		public const int PD_DISABLEPRINTTOFILE = 0x80000;

		public const int PD_HIDEPRINTTOFILE = 0x100000;

		public const int PD_NONETWORKBUTTON = 0x200000;

		public const int PD_CURRENTPAGE = 0x400000;

		public const int PD_NOCURRENTPAGE = 0x800000;

		public const int PD_EXCLUSIONFLAGS = 0x1000000;

		public const int PD_USELARGETEMPLATE = 0x10000000;

		public const int PSD_MINMARGINS = 1;

		public const int PSD_MARGINS = 2;

		public const int PSD_INHUNDREDTHSOFMILLIMETERS = 8;

		public const int PSD_DISABLEMARGINS = 0x10;

		public const int PSD_DISABLEPRINTER = 0x20;

		public const int PSD_DISABLEORIENTATION = 0x100;

		public const int PSD_DISABLEPAPER = 0x200;

		public const int PSD_SHOWHELP = 0x800;

		public const int PSD_ENABLEPAGESETUPHOOK = 0x2000;

		public const int PSD_NONETWORKBUTTON = 0x200000;

		public const int PS_SOLID = 0;

		public const int PS_DOT = 2;

		public const int PLANES = 0xE;

		public const int PRF_CHECKVISIBLE = 1;

		public const int PRF_NONCLIENT = 2;

		public const int PRF_CLIENT = 4;

		public const int PRF_ERASEBKGND = 8;

		public const int PRF_CHILDREN = 0x10;

		public const int PM_NOREMOVE = 0;

		public const int PM_REMOVE = 1;

		public const int PM_NOYIELD = 2;

		public const int PBM_SETRANGE = 0x401;

		public const int PBM_SETPOS = 0x402;

		public const int PBM_SETSTEP = 0x404;

		public const int PBM_SETRANGE32 = 0x406;

		public const int PBM_SETBARCOLOR = 0x409;

		public const int PBM_SETBKCOLOR = 0x2001;

		public const int PSM_SETTITLEA = 0x46F;

		public const int PSM_SETTITLEW = 0x478;

		public const int PSM_SETFINISHTEXTA = 0x473;

		public const int PSM_SETFINISHTEXTW = 0x479;

		public const int PATCOPY = 0xF00021;

		public const int PATINVERT = 0x5A0049;

		public const int QS_KEY = 1;

		public const int QS_MOUSEMOVE = 2;

		public const int QS_MOUSEBUTTON = 4;

		public const int QS_POSTMESSAGE = 8;

		public const int QS_TIMER = 0x10;

		public const int QS_PAINT = 0x20;

		public const int QS_SENDMESSAGE = 0x40;

		public const int QS_HOTKEY = 0x80;

		public const int QS_ALLPOSTMESSAGE = 0x100;

		public const int QS_MOUSE = 6;

		public const int QS_INPUT = 7;

		public const int QS_ALLEVENTS = 0xBF;

		public const int QS_ALLINPUT = 0xFF;

		public const int RDW_INVALIDATE = 1;

		public const int RDW_ALLCHILDREN = 0x80;

        public const int stc4 = 0x443;

        public const int SHGFP_TYPE_CURRENT = 0;

		public const int STGM_READ = 0;

		public const int STGM_WRITE = 1;

		public const int STGM_READWRITE = 2;

		public const int STGM_SHARE_EXCLUSIVE = 0x10;

		public const int STGM_CREATE = 0x1000;

		public const int STGM_TRANSACTED = 0x10000;

		public const int STGM_CONVERT = 0x20000;

		public const int STGM_DELETEONRELEASE = 0x4000000;

		public const int STGTY_STORAGE = 1;

		public const int STGTY_STREAM = 2;

		public const int STGTY_LOCKBYTES = 3;

		public const int STGTY_PROPERTY = 4;

		public const int STARTF_USESHOWWINDOW = 1;

		public const int SB_HORZ = 0;

		public const int SB_VERT = 1;

		public const int SB_CTL = 2;

		public const int SB_LINEUP = 0;

		public const int SB_LINELEFT = 0;

		public const int SB_LINEDOWN = 1;

		public const int SB_LINERIGHT = 1;

		public const int SB_PAGEUP = 2;

		public const int SB_PAGELEFT = 2;

		public const int SB_PAGEDOWN = 3;

		public const int SB_PAGERIGHT = 3;

		public const int SB_THUMBPOSITION = 4;

		public const int SB_THUMBTRACK = 5;

		public const int SB_LEFT = 6;

		public const int SB_RIGHT = 7;

		public const int SB_ENDSCROLL = 8;

		public const int SB_TOP = 6;

		public const int SB_BOTTOM = 7;

		public const int SIZE_MAXIMIZED = 2;

		public const int ESB_ENABLE_BOTH = 0;

		public const int ESB_DISABLE_BOTH = 3;

		public const int SORT_DEFAULT = 0;

		public const int SUBLANG_DEFAULT = 1;

		public const int SW_HIDE = 0;

		public const int SW_NORMAL = 1;

		public const int SW_SHOWMINIMIZED = 2;

		public const int SW_SHOWMAXIMIZED = 3;

		public const int SW_MAXIMIZE = 3;

		public const int SW_SHOWNOACTIVATE = 4;

		public const int SW_SHOW = 5;

		public const int SW_MINIMIZE = 6;

		public const int SW_SHOWMINNOACTIVE = 7;

		public const int SW_SHOWNA = 8;

		public const int SW_RESTORE = 9;

		public const int SW_MAX = 0xA;

		public const int SWP_NOSIZE = 1;

		public const int SWP_NOMOVE = 2;

		public const int SWP_NOZORDER = 4;

		public const int SWP_NOACTIVATE = 0x10;

		public const int SWP_SHOWWINDOW = 0x40;

		public const int SWP_HIDEWINDOW = 0x80;

		public const int SWP_DRAWFRAME = 0x20;

		public const int SM_CXSCREEN = 0;

		public const int SM_CYSCREEN = 1;

		public const int SM_CXVSCROLL = 2;

		public const int SM_CYHSCROLL = 3;

		public const int SM_CYCAPTION = 4;

		public const int SM_CXBORDER = 5;

		public const int SM_CYBORDER = 6;

		public const int SM_CYVTHUMB = 9;

		public const int SM_CXHTHUMB = 0xA;

		public const int SM_CXICON = 0xB;

		public const int SM_CYICON = 0xC;

		public const int SM_CXCURSOR = 0xD;

		public const int SM_CYCURSOR = 0xE;

		public const int SM_CYMENU = 0xF;

		public const int SM_CYKANJIWINDOW = 0x12;

		public const int SM_MOUSEPRESENT = 0x13;

		public const int SM_CYVSCROLL = 0x14;

		public const int SM_CXHSCROLL = 0x15;

		public const int SM_DEBUG = 0x16;

		public const int SM_SWAPBUTTON = 0x17;

		public const int SM_CXMIN = 0x1C;

		public const int SM_CYMIN = 0x1D;

		public const int SM_CXSIZE = 0x1E;

		public const int SM_CYSIZE = 0x1F;

		public const int SM_CXFRAME = 0x20;

		public const int SM_CYFRAME = 0x21;

		public const int SM_CXMINTRACK = 0x22;

		public const int SM_CYMINTRACK = 0x23;

		public const int SM_CXDOUBLECLK = 0x24;

		public const int SM_CYDOUBLECLK = 0x25;

		public const int SM_CXICONSPACING = 0x26;

		public const int SM_CYICONSPACING = 0x27;

		public const int SM_MENUDROPALIGNMENT = 0x28;

		public const int SM_PENWINDOWS = 0x29;

		public const int SM_DBCSENABLED = 0x2A;

		public const int SM_CMOUSEBUTTONS = 0x2B;

		public const int SM_CXFIXEDFRAME = 7;

		public const int SM_CYFIXEDFRAME = 8;

		public const int SM_SECURE = 0x2C;

		public const int SM_CXEDGE = 0x2D;

		public const int SM_CYEDGE = 0x2E;

		public const int SM_CXMINSPACING = 0x2F;

		public const int SM_CYMINSPACING = 0x30;

		public const int SM_CXSMICON = 0x31;

		public const int SM_CYSMICON = 0x32;

		public const int SM_CYSMCAPTION = 0x33;

		public const int SM_CXSMSIZE = 0x34;

		public const int SM_CYSMSIZE = 0x35;

		public const int SM_CXMENUSIZE = 0x36;

		public const int SM_CYMENUSIZE = 0x37;

		public const int SM_ARRANGE = 0x38;

		public const int SM_CXMINIMIZED = 0x39;

		public const int SM_CYMINIMIZED = 0x3A;

		public const int SM_CXMAXTRACK = 0x3B;

		public const int SM_CYMAXTRACK = 0x3C;

		public const int SM_CXMAXIMIZED = 0x3D;

		public const int SM_CYMAXIMIZED = 0x3E;

		public const int SM_NETWORK = 0x3F;

		public const int SM_CLEANBOOT = 0x43;

		public const int SM_CXDRAG = 0x44;

		public const int SM_CYDRAG = 0x45;

		public const int SM_SHOWSOUNDS = 0x46;

		public const int SM_CXMENUCHECK = 0x47;

		public const int SM_CYMENUCHECK = 0x48;

		public const int SM_MIDEASTENABLED = 0x4A;

		public const int SM_MOUSEWHEELPRESENT = 0x4B;

		public const int SM_XVIRTUALSCREEN = 0x4C;

		public const int SM_YVIRTUALSCREEN = 0x4D;

		public const int SM_CXVIRTUALSCREEN = 0x4E;

		public const int SM_CYVIRTUALSCREEN = 0x4F;

		public const int SM_CMONITORS = 0x50;

		public const int SM_SAMEDISPLAYFORMAT = 0x51;

		public const int SM_IMMENABLED = 0x52;

		public const int SM_REMOTESESSION = 0x1000;

		public const int MB_ICONHAND = 0x10;

		public const int MB_ICONQUESTION = 0x20;

		public const int MB_ICONEXCLAMATION = 0x30;

		public const int MB_ICONASTERISK = 0x40;

		public const int SW_SCROLLCHILDREN = 1;

		public const int SW_INVALIDATE = 2;

		public const int SW_ERASE = 4;

		public const int SW_SMOOTHSCROLL = 0x10;

		public const int SC_SIZE = 0xF000;

		public const int SC_MINIMIZE = 0xF020;

		public const int SC_MAXIMIZE = 0xF030;

		public const int SC_CLOSE = 0xF060;

		public const int SC_KEYMENU = 0xF100;

		public const int SC_RESTORE = 0xF120;

		public const int SC_MOVE = 0xF010;

		public const int SS_LEFT = 0;

		public const int SS_CENTER = 1;

		public const int SS_RIGHT = 2;

		public const int SS_OWNERDRAW = 0xD;

		public const int SS_NOPREFIX = 0x80;

		public const int SS_SUNKEN = 0x1000;

		public const int SBS_HORZ = 0;

		public const int SBS_VERT = 1;

		public const int SIF_RANGE = 1;

		public const int SIF_PAGE = 2;

		public const int SIF_POS = 4;

		public const int SIF_TRACKPOS = 0x10;

		public const int SIF_ALL = 0x17;

		public const int SPI_GETFONTSMOOTHING = 0x4A;

		public const int SPI_GETDROPSHADOW = 0x1024;

		public const int SPI_GETFLATMENU = 0x1022;

		public const int SPI_GETFONTSMOOTHINGTYPE = 0x200A;

		public const int SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;

		public const int SPI_ICONHORIZONTALSPACING = 0xD;

		public const int SPI_ICONVERTICALSPACING = 0x18;

		public const int SPI_GETICONMETRICS = 0x2D;

		public const int SPI_GETICONTITLEWRAP = 0x19;

		public const int SPI_GETICONTITLELOGFONT = 0x1F;

		public const int SPI_GETKEYBOARDCUES = 0x100A;

		public const int SPI_GETKEYBOARDDELAY = 0x16;

		public const int SPI_GETKEYBOARDPREF = 0x44;

		public const int SPI_GETKEYBOARDSPEED = 0xA;

		public const int SPI_GETMOUSEHOVERWIDTH = 0x62;

		public const int SPI_GETMOUSEHOVERHEIGHT = 0x64;

		public const int SPI_GETMOUSEHOVERTIME = 0x66;

		public const int SPI_GETMOUSESPEED = 0x70;

		public const int SPI_GETMENUDROPALIGNMENT = 0x1B;

		public const int SPI_GETMENUFADE = 0x1012;

		public const int SPI_GETMENUSHOWDELAY = 0x6A;

		public const int SPI_GETCOMBOBOXANIMATION = 0x1004;

		public const int SPI_GETCLIENTAREAANIMATION = 0x1042;

		public const int SPI_GETGRADIENTCAPTIONS = 0x1008;

		public const int SPI_GETHOTTRACKING = 0x100E;

		public const int SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;

		public const int SPI_GETMENUANIMATION = 0x1002;

		public const int SPI_GETSELECTIONFADE = 0x1014;

		public const int SPI_GETTOOLTIPANIMATION = 0x1016;

		public const int SPI_GETUIEFFECTS = 0x103E;

		public const int SPI_GETACTIVEWINDOWTRACKING = 0x1000;

		public const int SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;

		public const int SPI_GETANIMATION = 0x48;

		public const int SPI_GETBORDER = 5;

		public const int SPI_GETCARETWIDTH = 0x2006;

		public const int SPI_GETMOUSEVANISH = 0x1020;

		public const int SM_CYFOCUSBORDER = 0x54;

		public const int SM_CXFOCUSBORDER = 0x53;

		public const int SM_CYSIZEFRAME = 0x21;

		public const int SM_CXSIZEFRAME = 0x20;

		public const int SPI_GETDRAGFULLWINDOWS = 0x26;

		public const int SPI_GETNONCLIENTMETRICS = 0x29;

		public const int SPI_GETWORKAREA = 0x30;

		public const int SPI_GETHIGHCONTRAST = 0x42;

		public const int SPI_GETDEFAULTINPUTLANG = 0x59;

		public const int SPI_GETSNAPTODEFBUTTON = 0x5F;

		public const int SPI_GETWHEELSCROLLLINES = 0x68;

		public const int SBARS_SIZEGRIP = 0x100;

		public const int SB_SETTEXTA = 0x401;

		public const int SB_SETTEXTW = 0x40B;

		public const int SB_GETTEXTA = 0x402;

		public const int SB_GETTEXTW = 0x40D;

		public const int SB_GETTEXTLENGTHA = 0x403;

		public const int SB_GETTEXTLENGTHW = 0x40C;

		public const int SB_SETPARTS = 0x404;

		public const int SB_SIMPLE = 0x409;

		public const int SB_GETRECT = 0x40A;

		public const int SB_SETICON = 0x40F;

		public const int SB_SETTIPTEXTA = 0x410;

		public const int SB_SETTIPTEXTW = 0x411;

		public const int SB_GETTIPTEXTA = 0x412;

		public const int SB_GETTIPTEXTW = 0x413;

		public const int SBT_OWNERDRAW = 0x1000;

		public const int SBT_NOBORDERS = 0x100;

		public const int SBT_POPOUT = 0x200;

		public const int SBT_RTLREADING = 0x400;

		public const int SRCCOPY = 0xCC0020;

		public const int SRCAND = 0x8800C6;

		public const int SRCPAINT = 0xEE0086;

		public const int NOTSRCCOPY = 0x330008;

		public const int STATFLAG_DEFAULT = 0;

		public const int STATFLAG_NONAME = 1;

		public const int STATFLAG_NOOPEN = 2;

		public const int STGC_DEFAULT = 0;

		public const int STGC_OVERWRITE = 1;

		public const int STGC_ONLYIFCURRENT = 2;

		public const int STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4;

		public const int STREAM_SEEK_SET = 0;

		public const int STREAM_SEEK_CUR = 1;

		public const int STREAM_SEEK_END = 2;

		public const int S_OK = 0;

		public const int S_FALSE = 1;

		public const int TRANSPARENT = 1;

		public const int OPAQUE = 2;

		public const int TME_HOVER = 1;

		public const int TME_LEAVE = 2;

		public const int TPM_LEFTBUTTON = 0;

		public const int TPM_RIGHTBUTTON = 2;

		public const int TPM_LEFTALIGN = 0;

		public const int TPM_RIGHTALIGN = 8;

		public const int TPM_VERTICAL = 0x40;

		public const int TV_FIRST = 0x1100;

		public const int TBSTATE_CHECKED = 1;

		public const int TBSTATE_ENABLED = 4;

		public const int TBSTATE_HIDDEN = 8;

		public const int TBSTATE_INDETERMINATE = 0x10;

		public const int TBSTYLE_BUTTON = 0;

		public const int TBSTYLE_SEP = 1;

		public const int TBSTYLE_CHECK = 2;

		public const int TBSTYLE_DROPDOWN = 8;

		public const int TBSTYLE_TOOLTIPS = 0x100;

		public const int TBSTYLE_FLAT = 0x800;

		public const int TBSTYLE_LIST = 0x1000;

		public const int TBSTYLE_EX_DRAWDDARROWS = 1;

		public const int TB_ENABLEBUTTON = 0x401;

		public const int TB_ISBUTTONCHECKED = 0x40A;

		public const int TB_ISBUTTONINDETERMINATE = 0x40D;

		public const int TB_ADDBUTTONSA = 0x414;

		public const int TB_ADDBUTTONSW = 0x444;

		public const int TB_INSERTBUTTONA = 0x415;

		public const int TB_INSERTBUTTONW = 0x443;

		public const int TB_DELETEBUTTON = 0x416;

		public const int TB_GETBUTTON = 0x417;

		public const int TB_SAVERESTOREA = 0x41A;

		public const int TB_SAVERESTOREW = 0x44C;

		public const int TB_ADDSTRINGA = 0x41C;

		public const int TB_ADDSTRINGW = 0x44D;

		public const int TB_BUTTONSTRUCTSIZE = 0x41E;

		public const int TB_SETBUTTONSIZE = 0x41F;

		public const int TB_AUTOSIZE = 0x421;

		public const int TB_GETROWS = 0x428;

		public const int TB_GETBUTTONTEXTA = 0x42D;

		public const int TB_GETBUTTONTEXTW = 0x44B;

		public const int TB_SETIMAGELIST = 0x430;

		public const int TB_GETRECT = 0x433;

		public const int TB_GETBUTTONSIZE = 0x43A;

		public const int TB_GETBUTTONINFOW = 0x43F;

		public const int TB_SETBUTTONINFOW = 0x440;

		public const int TB_GETBUTTONINFOA = 0x441;

		public const int TB_SETBUTTONINFOA = 0x442;

		public const int TB_MAPACCELERATORA = 0x44E;

		public const int TB_SETEXTENDEDSTYLE = 0x454;

		public const int TB_MAPACCELERATORW = 0x45A;

		public const int TB_GETTOOLTIPS = 0x423;

		public const int TB_SETTOOLTIPS = 0x424;

		public const int TBIF_IMAGE = 1;

		public const int TBIF_TEXT = 2;

		public const int TBIF_STATE = 4;

		public const int TBIF_STYLE = 8;

		public const int TBIF_COMMAND = 0x20;

		public const int TBIF_SIZE = 0x40;

		public const int TBN_GETBUTTONINFOA = -0x2BC;

		public const int TBN_GETBUTTONINFOW = -0x2D0;

		public const int TBN_QUERYINSERT = -0x2C2;

		public const int TBN_DROPDOWN = -0x2C6;

		public const int TBN_HOTITEMCHANGE = -0x2C9;

		public const int TBN_GETDISPINFOA = -0x2CC;

		public const int TBN_GETDISPINFOW = -0x2CD;

		public const int TBN_GETINFOTIPA = -0x2CE;

		public const int TBN_GETINFOTIPW = -0x2CF;

		public const int TTS_ALWAYSTIP = 1;

		public const int TTS_NOPREFIX = 2;

		public const int TTS_NOANIMATE = 0x10;

		public const int TTS_NOFADE = 0x20;

		public const int TTS_BALLOON = 0x40;

		public const int TTI_WARNING = 2;

		public const int TTF_IDISHWND = 1;

		public const int TTF_RTLREADING = 4;

		public const int TTF_TRACK = 0x20;

		public const int TTF_CENTERTIP = 2;

		public const int TTF_SUBCLASS = 0x10;

		public const int TTF_TRANSPARENT = 0x100;

		public const int TTF_ABSOLUTE = 0x80;

		public const int TTDT_AUTOMATIC = 0;

		public const int TTDT_RESHOW = 1;

		public const int TTDT_AUTOPOP = 2;

		public const int TTDT_INITIAL = 3;

		public const int TTM_TRACKACTIVATE = 0x411;

		public const int TTM_TRACKPOSITION = 0x412;

		public const int TTM_ACTIVATE = 0x401;

		public const int TTM_POP = 0x41C;

		public const int TTM_ADJUSTRECT = 0x41F;

		public const int TTM_SETDELAYTIME = 0x403;

		public const int TTM_SETTITLEA = 0x420;

		public const int TTM_SETTITLEW = 0x421;

		public const int TTM_ADDTOOLA = 0x404;

		public const int TTM_ADDTOOLW = 0x432;

		public const int TTM_DELTOOLA = 0x405;

		public const int TTM_DELTOOLW = 0x433;

		public const int TTM_NEWTOOLRECTA = 0x406;

		public const int TTM_NEWTOOLRECTW = 0x434;

		public const int TTM_RELAYEVENT = 0x407;

		public const int TTM_GETTIPBKCOLOR = 0x416;

		public const int TTM_SETTIPBKCOLOR = 0x413;

		public const int TTM_SETTIPTEXTCOLOR = 0x414;

		public const int TTM_GETTIPTEXTCOLOR = 0x417;

		public const int TTM_GETTOOLINFOA = 0x408;

		public const int TTM_GETTOOLINFOW = 0x435;

		public const int TTM_SETTOOLINFOA = 0x409;

		public const int TTM_SETTOOLINFOW = 0x436;

		public const int TTM_HITTESTA = 0x40A;

		public const int TTM_HITTESTW = 0x437;

		public const int TTM_GETTEXTA = 0x40B;

		public const int TTM_GETTEXTW = 0x438;

		public const int TTM_UPDATE = 0x41D;

		public const int TTM_UPDATETIPTEXTA = 0x40C;

		public const int TTM_UPDATETIPTEXTW = 0x439;

		public const int TTM_ENUMTOOLSA = 0x40E;

		public const int TTM_ENUMTOOLSW = 0x43A;

		public const int TTM_GETCURRENTTOOLA = 0x40F;

		public const int TTM_GETCURRENTTOOLW = 0x43B;

		public const int TTM_WINDOWFROMPOINT = 0x410;

		public const int TTM_GETDELAYTIME = 0x415;

		public const int TTM_SETMAXTIPWIDTH = 0x418;

		public const int TTN_GETDISPINFOA = -0x208;

		public const int TTN_GETDISPINFOW = -0x212;

		public const int TTN_SHOW = -0x209;

		public const int TTN_POP = -0x20A;

		public const int TTN_NEEDTEXTA = -0x208;

		public const int TTN_NEEDTEXTW = -0x212;

		public const int TBS_AUTOTICKS = 1;

		public const int TBS_VERT = 2;

		public const int TBS_TOP = 4;

		public const int TBS_BOTTOM = 0;

		public const int TBS_BOTH = 8;

		public const int TBS_NOTICKS = 0x10;

		public const int TBM_GETPOS = 0x400;

		public const int TBM_SETTIC = 0x404;

		public const int TBM_SETPOS = 0x405;

		public const int TBM_SETRANGE = 0x406;

		public const int TBM_SETRANGEMIN = 0x407;

		public const int TBM_SETRANGEMAX = 0x408;

		public const int TBM_SETTICFREQ = 0x414;

		public const int TBM_SETPAGESIZE = 0x415;

		public const int TBM_SETLINESIZE = 0x417;

		public const int TB_LINEUP = 0;

		public const int TB_LINEDOWN = 1;

		public const int TB_PAGEUP = 2;

		public const int TB_PAGEDOWN = 3;

		public const int TB_THUMBPOSITION = 4;

		public const int TB_THUMBTRACK = 5;

		public const int TB_TOP = 6;

		public const int TB_BOTTOM = 7;

		public const int TB_ENDTRACK = 8;

		public const int TVS_HASBUTTONS = 1;

		public const int TVS_HASLINES = 2;

		public const int TVS_LINESATROOT = 4;

		public const int TVS_EDITLABELS = 8;

		public const int TVS_SHOWSELALWAYS = 0x20;

		public const int TVS_RTLREADING = 0x40;

		public const int TVS_CHECKBOXES = 0x100;

		public const int TVS_TRACKSELECT = 0x200;

		public const int TVS_FULLROWSELECT = 0x1000;

		public const int TVS_NONEVENHEIGHT = 0x4000;

		public const int TVS_INFOTIP = 0x800;

		public const int TVS_NOTOOLTIPS = 0x80;

		public const int TVIF_TEXT = 1;

		public const int TVIF_IMAGE = 2;

		public const int TVIF_PARAM = 4;

		public const int TVIF_STATE = 8;

		public const int TVIF_HANDLE = 0x10;

		public const int TVIF_SELECTEDIMAGE = 0x20;

		public const int TVIS_SELECTED = 2;

		public const int TVIS_EXPANDED = 0x20;

		public const int TVIS_EXPANDEDONCE = 0x40;

		public const int TVIS_STATEIMAGEMASK = 0xF000;

		public const int TVI_ROOT = -0x10000;

		public const int TVI_FIRST = -0xFFFF;

		public const int TVM_INSERTITEMA = 0x1100;

		public const int TVM_INSERTITEMW = 0x1132;

		public const int TVM_DELETEITEM = 0x1101;

		public const int TVM_EXPAND = 0x1102;

		public const int TVE_COLLAPSE = 1;

		public const int TVE_EXPAND = 2;

		public const int TVM_GETITEMRECT = 0x1104;

		public const int TVM_GETINDENT = 0x1106;

		public const int TVM_SETINDENT = 0x1107;

		public const int TVM_SETIMAGELIST = 0x1109;

		public const int TVM_GETNEXTITEM = 0x110A;

		public const int TVGN_NEXT = 1;

		public const int TVGN_PREVIOUS = 2;

		public const int TVGN_FIRSTVISIBLE = 5;

		public const int TVGN_NEXTVISIBLE = 6;

		public const int TVGN_PREVIOUSVISIBLE = 7;

		public const int TVGN_CARET = 9;

		public const int TVM_SELECTITEM = 0x110B;

		public const int TVM_GETITEMA = 0x110C;

		public const int TVM_GETITEMW = 0x113E;

		public const int TVM_SETITEMA = 0x110D;

		public const int TVM_SETITEMW = 0x113F;

		public const int TVM_EDITLABELA = 0x110E;

		public const int TVM_EDITLABELW = 0x1141;

		public const int TVM_GETEDITCONTROL = 0x110F;

		public const int TVM_GETVISIBLECOUNT = 0x1110;

		public const int TVM_HITTEST = 0x1111;

		public const int TVM_ENSUREVISIBLE = 0x1114;

		public const int TVM_ENDEDITLABELNOW = 0x1116;

		public const int TVM_GETISEARCHSTRINGA = 0x1117;

		public const int TVM_GETISEARCHSTRINGW = 0x1140;

		public const int TVM_SETITEMHEIGHT = 0x111B;

		public const int TVM_GETITEMHEIGHT = 0x111C;

		public const int TVN_SELCHANGINGA = -0x191;

		public const int TVN_SELCHANGINGW = -0x1C2;

		public const int TVN_GETINFOTIPA = -0x19D;

		public const int TVN_GETINFOTIPW = -0x19E;

		public const int TVN_SELCHANGEDA = -0x192;

		public const int TVN_SELCHANGEDW = -0x1C3;

		public const int TVC_UNKNOWN = 0;

		public const int TVC_BYMOUSE = 1;

		public const int TVC_BYKEYBOARD = 2;

		public const int TVN_GETDISPINFOA = -0x193;

		public const int TVN_GETDISPINFOW = -0x1C4;

		public const int TVN_SETDISPINFOA = -0x194;

		public const int TVN_SETDISPINFOW = -0x1C5;

		public const int TVN_ITEMEXPANDINGA = -0x195;

		public const int TVN_ITEMEXPANDINGW = -0x1C6;

		public const int TVN_ITEMEXPANDEDA = -0x196;

		public const int TVN_ITEMEXPANDEDW = -0x1C7;

		public const int TVN_BEGINDRAGA = -0x197;

		public const int TVN_BEGINDRAGW = -0x1C8;

		public const int TVN_BEGINRDRAGA = -0x198;

		public const int TVN_BEGINRDRAGW = -0x1C9;

		public const int TVN_BEGINLABELEDITA = -0x19A;

		public const int TVN_BEGINLABELEDITW = -0x1CB;

		public const int TVN_ENDLABELEDITA = -0x19B;

		public const int TVN_ENDLABELEDITW = -0x1CC;

		public const int TCS_BOTTOM = 2;

		public const int TCS_RIGHT = 2;

		public const int TCS_FLATBUTTONS = 8;

		public const int TCS_HOTTRACK = 0x40;

		public const int TCS_VERTICAL = 0x80;

		public const int TCS_TABS = 0;

		public const int TCS_BUTTONS = 0x100;

		public const int TCS_MULTILINE = 0x200;

		public const int TCS_RIGHTJUSTIFY = 0;

		public const int TCS_FIXEDWIDTH = 0x400;

		public const int TCS_RAGGEDRIGHT = 0x800;

		public const int TCS_OWNERDRAWFIXED = 0x2000;

		public const int TCS_TOOLTIPS = 0x4000;

		public const int TCM_SETIMAGELIST = 0x1303;

		public const int TCIF_TEXT = 1;

		public const int TCIF_IMAGE = 2;

		public const int TCM_GETITEMA = 0x1305;

		public const int TCM_GETITEMW = 0x133C;

		public const int TCM_SETITEMA = 0x1306;

		public const int TCM_SETITEMW = 0x133D;

		public const int TCM_INSERTITEMA = 0x1307;

		public const int TCM_INSERTITEMW = 0x133E;

		public const int TCM_DELETEITEM = 0x1308;

		public const int TCM_DELETEALLITEMS = 0x1309;

		public const int TCM_GETITEMRECT = 0x130A;

		public const int TCM_GETCURSEL = 0x130B;

		public const int TCM_SETCURSEL = 0x130C;

		public const int TCM_ADJUSTRECT = 0x1328;

		public const int TCM_SETITEMSIZE = 0x1329;

		public const int TCM_SETPADDING = 0x132B;

		public const int TCM_GETROWCOUNT = 0x132C;

		public const int TCM_GETTOOLTIPS = 0x132D;

		public const int TCM_SETTOOLTIPS = 0x132E;

		public const int TCN_SELCHANGE = -0x227;

		public const int TCN_SELCHANGING = -0x228;

		public const int TBSTYLE_WRAPPABLE = 0x200;

		public const int TVM_SETBKCOLOR = 0x111D;

		public const int TVM_SETTEXTCOLOR = 0x111E;

		public const int TYMED_NULL = 0;

		public const int TVM_GETLINECOLOR = 0x1129;

		public const int TVM_SETLINECOLOR = 0x1128;

		public const int TVM_SETTOOLTIPS = 0x1118;

		public const int TVSIL_STATE = 2;

		public const int TVM_SORTCHILDRENCB = 0x1115;

		public const int UIS_SET = 1;

		public const int UIS_CLEAR = 2;

		public const int UIS_INITIALIZE = 3;

		public const int UISF_HIDEFOCUS = 1;

		public const int UISF_HIDEACCEL = 2;

		public const int UISF_ACTIVE = 4;

		public const int VK_TAB = 9;

		public const int VK_SHIFT = 0x10;

		public const int VK_CONTROL = 0x11;

		public const int VK_MENU = 0x12;

		public const int WH_JOURNALPLAYBACK = 1;

		public const int WH_GETMESSAGE = 3;

		public const int WH_MOUSE = 7;

		public const int WSF_VISIBLE = 1;

		public const int WM_NULL = 0;

		public const int WM_CREATE = 1;

		public const int WM_DELETEITEM = 0x2D;

		public const int WM_DESTROY = 2;

		public const int WM_MOVE = 3;

		public const int WM_SIZE = 5;

		public const int WM_ACTIVATE = 6;

		public const int WA_INACTIVE = 0;

		public const int WA_ACTIVE = 1;

		public const int WA_CLICKACTIVE = 2;

		public const int WM_SETFOCUS = 7;

		public const int WM_KILLFOCUS = 8;

		public const int WM_ENABLE = 0xA;

		public const int WM_SETREDRAW = 0xB;

		public const int WM_SETTEXT = 0xC;

		public const int WM_GETTEXT = 0xD;

		public const int WM_GETTEXTLENGTH = 0xE;

		public const int WM_PAINT = 0xF;

		public const int WM_CLOSE = 0x10;

		public const int WM_QUERYENDSESSION = 0x11;

		public const int WM_QUIT = 0x12;

		public const int WM_QUERYOPEN = 0x13;

		public const int WM_ERASEBKGND = 0x14;

		public const int WM_SYSCOLORCHANGE = 0x15;

		public const int WM_ENDSESSION = 0x16;

		public const int WM_SHOWWINDOW = 0x18;

		public const int WM_WININICHANGE = 0x1A;

		public const int WM_SETTINGCHANGE = 0x1A;

		public const int WM_DEVMODECHANGE = 0x1B;

		public const int WM_ACTIVATEAPP = 0x1C;

		public const int WM_FONTCHANGE = 0x1D;

		public const int WM_TIMECHANGE = 0x1E;

		public const int WM_CANCELMODE = 0x1F;

		public const int WM_SETCURSOR = 0x20;

		public const int WM_MOUSEACTIVATE = 0x21;

		public const int WM_CHILDACTIVATE = 0x22;

		public const int WM_QUEUESYNC = 0x23;

		public const int WM_GETMINMAXINFO = 0x24;

		public const int WM_PAINTICON = 0x26;

		public const int WM_ICONERASEBKGND = 0x27;

		public const int WM_NEXTDLGCTL = 0x28;

		public const int WM_SPOOLERSTATUS = 0x2A;

		public const int WM_DRAWITEM = 0x2B;

		public const int WM_MEASUREITEM = 0x2C;

		public const int WM_VKEYTOITEM = 0x2E;

		public const int WM_CHARTOITEM = 0x2F;

		public const int WM_SETFONT = 0x30;

		public const int WM_GETFONT = 0x31;

		public const int WM_SETHOTKEY = 0x32;

		public const int WM_GETHOTKEY = 0x33;

		public const int WM_QUERYDRAGICON = 0x37;

		public const int WM_COMPAREITEM = 0x39;

		public const int WM_GETOBJECT = 0x3D;

		public const int WM_COMPACTING = 0x41;

		public const int WM_COMMNOTIFY = 0x44;

		public const int WM_WINDOWPOSCHANGING = 0x46;

		public const int WM_WINDOWPOSCHANGED = 0x47;

		public const int WM_POWER = 0x48;

		public const int WM_COPYDATA = 0x4A;

		public const int WM_CANCELJOURNAL = 0x4B;

		public const int WM_NOTIFY = 0x4E;

		public const int WM_INPUTLANGCHANGEREQUEST = 0x50;

		public const int WM_INPUTLANGCHANGE = 0x51;

		public const int WM_TCARD = 0x52;

		public const int WM_HELP = 0x53;

		public const int WM_USERCHANGED = 0x54;

		public const int WM_NOTIFYFORMAT = 0x55;

		public const int WM_CONTEXTMENU = 0x7B;

		public const int WM_STYLECHANGING = 0x7C;

		public const int WM_STYLECHANGED = 0x7D;

		public const int WM_DISPLAYCHANGE = 0x7E;

		public const int WM_GETICON = 0x7F;

		public const int WM_SETICON = 0x80;

		public const int WM_NCCREATE = 0x81;

		public const int WM_NCDESTROY = 0x82;

		public const int WM_NCCALCSIZE = 0x83;

		public const int WM_NCHITTEST = 0x84;

		public const int WM_NCPAINT = 0x85;

		public const int WM_NCACTIVATE = 0x86;

		public const int WM_GETDLGCODE = 0x87;

		public const int WM_NCMOUSEMOVE = 0xA0;

		public const int WM_NCMOUSELEAVE = 0x2A2;

		public const int WM_NCLBUTTONDOWN = 0xA1;

		public const int WM_NCLBUTTONUP = 0xA2;

		public const int WM_NCLBUTTONDBLCLK = 0xA3;

		public const int WM_NCRBUTTONDOWN = 0xA4;

		public const int WM_NCRBUTTONUP = 0xA5;

		public const int WM_NCRBUTTONDBLCLK = 0xA6;

		public const int WM_NCMBUTTONDOWN = 0xA7;

		public const int WM_NCMBUTTONUP = 0xA8;

		public const int WM_NCMBUTTONDBLCLK = 0xA9;

		public const int WM_NCXBUTTONDOWN = 0xAB;

		public const int WM_NCXBUTTONUP = 0xAC;

		public const int WM_NCXBUTTONDBLCLK = 0xAD;

		public const int WM_INPUT = 0xFF;

		public const int WM_KEYFIRST = 0x100;

		public const int WM_KEYDOWN = 0x100;

		public const int WM_KEYUP = 0x101;

		public const int WM_CHAR = 0x102;

		public const int WM_DEADCHAR = 0x103;

		public const int WM_CTLCOLOR = 0x19;

		public const int WM_SYSKEYDOWN = 0x104;

		public const int WM_SYSKEYUP = 0x105;

		public const int WM_SYSCHAR = 0x106;

		public const int WM_SYSDEADCHAR = 0x107;

		public const int WM_KEYLAST = 0x108;

		public const int WM_IME_STARTCOMPOSITION = 0x10D;

		public const int WM_IME_ENDCOMPOSITION = 0x10E;

		public const int WM_IME_COMPOSITION = 0x10F;

		public const int WM_IME_KEYLAST = 0x10F;

		public const int WM_INITDIALOG = 0x110;

		public const int WM_COMMAND = 0x111;

		public const int WM_SYSCOMMAND = 0x112;

		public const int WM_TIMER = 0x113;

		public const int WM_HSCROLL = 0x114;

		public const int WM_VSCROLL = 0x115;

		public const int WM_INITMENU = 0x116;

		public const int WM_INITMENUPOPUP = 0x117;

		public const int WM_MENUSELECT = 0x11F;

		public const int WM_MENUCHAR = 0x120;

		public const int WM_ENTERIDLE = 0x121;

		public const int WM_UNINITMENUPOPUP = 0x125;

		public const int WM_CHANGEUISTATE = 0x127;

		public const int WM_UPDATEUISTATE = 0x128;

		public const int WM_QUERYUISTATE = 0x129;

		public const int WM_CTLCOLORMSGBOX = 0x132;

		public const int WM_CTLCOLOREDIT = 0x133;

		public const int WM_CTLCOLORLISTBOX = 0x134;

		public const int WM_CTLCOLORBTN = 0x135;

		public const int WM_CTLCOLORDLG = 0x136;

		public const int WM_CTLCOLORSCROLLBAR = 0x137;

		public const int WM_CTLCOLORSTATIC = 0x138;

		public const int WM_MOUSEFIRST = 0x200;

		public const int WM_MOUSEMOVE = 0x200;

		public const int WM_LBUTTONDOWN = 0x201;

		public const int WM_LBUTTONUP = 0x202;

		public const int WM_LBUTTONDBLCLK = 0x203;

		public const int WM_RBUTTONDOWN = 0x204;

		public const int WM_RBUTTONUP = 0x205;

		public const int WM_RBUTTONDBLCLK = 0x206;

		public const int WM_MBUTTONDOWN = 0x207;

		public const int WM_MBUTTONUP = 0x208;

		public const int WM_MBUTTONDBLCLK = 0x209;

		public const int WM_XBUTTONDOWN = 0x20B;

		public const int WM_XBUTTONUP = 0x20C;

		public const int WM_XBUTTONDBLCLK = 0x20D;

		public const int WM_MOUSEWHEEL = 0x20A;

		public const int WM_MOUSELAST = 0x20A;

		public const int WHEEL_DELTA = 0x78;

		public const int WM_PARENTNOTIFY = 0x210;

		public const int WM_ENTERMENULOOP = 0x211;

		public const int WM_EXITMENULOOP = 0x212;

		public const int WM_NEXTMENU = 0x213;

		public const int WM_SIZING = 0x214;

		public const int WM_CAPTURECHANGED = 0x215;

		public const int WM_MOVING = 0x216;

		public const int WM_POWERBROADCAST = 0x218;

		public const int WM_DEVICECHANGE = 0x219;

		public const int WM_IME_SETCONTEXT = 0x281;

		public const int WM_IME_NOTIFY = 0x282;

		public const int WM_IME_CONTROL = 0x283;

		public const int WM_IME_COMPOSITIONFULL = 0x284;

		public const int WM_IME_SELECT = 0x285;

		public const int WM_IME_CHAR = 0x286;

		public const int WM_IME_REQUEST = 0x288;

		public const int WM_IME_KEYDOWN = 0x290;

		public const int WM_IME_KEYUP = 0x291;

		public const int WM_MDICREATE = 0x220;

		public const int WM_MDIDESTROY = 0x221;

		public const int WM_MDIACTIVATE = 0x222;

		public const int WM_MDIRESTORE = 0x223;

		public const int WM_MDINEXT = 0x224;

		public const int WM_MDIMAXIMIZE = 0x225;

		public const int WM_MDITILE = 0x226;

		public const int WM_MDICASCADE = 0x227;

		public const int WM_MDIICONARRANGE = 0x228;

		public const int WM_MDIGETACTIVE = 0x229;

		public const int WM_MDISETMENU = 0x230;

		public const int WM_ENTERSIZEMOVE = 0x231;

		public const int WM_EXITSIZEMOVE = 0x232;

		public const int WM_DROPFILES = 0x233;

		public const int WM_MDIREFRESHMENU = 0x234;

		public const int WM_MOUSEHOVER = 0x2A1;

		public const int WM_MOUSELEAVE = 0x2A3;

		public const int WM_CUT = 0x300;

		public const int WM_COPY = 0x301;

		public const int WM_PASTE = 0x302;

		public const int WM_CLEAR = 0x303;

		public const int WM_UNDO = 0x304;

		public const int WM_RENDERFORMAT = 0x305;

		public const int WM_RENDERALLFORMATS = 0x306;

		public const int WM_DESTROYCLIPBOARD = 0x307;

		public const int WM_DRAWCLIPBOARD = 0x308;

		public const int WM_PAINTCLIPBOARD = 0x309;

		public const int WM_VSCROLLCLIPBOARD = 0x30A;

		public const int WM_SIZECLIPBOARD = 0x30B;

		public const int WM_ASKCBFORMATNAME = 0x30C;

		public const int WM_CHANGECBCHAIN = 0x30D;

		public const int WM_HSCROLLCLIPBOARD = 0x30E;

		public const int WM_QUERYNEWPALETTE = 0x30F;

		public const int WM_PALETTEISCHANGING = 0x310;

		public const int WM_PALETTECHANGED = 0x311;

		public const int WM_HOTKEY = 0x312;

		public const int WM_PRINT = 0x317;

		public const int WM_PRINTCLIENT = 0x318;

		public const int WM_APPCOMMAND = 0x319;

		public const int WM_DWMCOMPOSITIONCHANGED = 0x31E;

		public const int WM_HANDHELDFIRST = 0x358;

		public const int WM_HANDHELDLAST = 0x35F;

		public const int WM_AFXFIRST = 0x360;

		public const int WM_AFXLAST = 0x37F;

		public const int WM_PENWINFIRST = 0x380;

		public const int WM_PENWINLAST = 0x38F;

		public const int WM_APP = 0x8000;

		public const int WM_USER = 0x400;

		public const int WM_REFLECT = 0x2000;

		public const int WS_OVERLAPPED = 0;

		public const int WS_POPUP = -0x80000000;

		public const int WS_CHILD = 0x40000000;

		public const int WS_MINIMIZE = 0x20000000;

		public const int WS_VISIBLE = 0x10000000;

		public const int WS_DISABLED = 0x8000000;

		public const int WS_CLIPSIBLINGS = 0x4000000;

		public const int WS_CLIPCHILDREN = 0x2000000;

		public const int WS_MAXIMIZE = 0x1000000;

		public const int WS_CAPTION = 0xC00000;

		public const int WS_BORDER = 0x800000;

		public const int WS_DLGFRAME = 0x400000;

		public const int WS_VSCROLL = 0x200000;

		public const int WS_HSCROLL = 0x100000;

		public const int WS_SYSMENU = 0x80000;

		public const int WS_THICKFRAME = 0x40000;

		public const int WS_TABSTOP = 0x10000;

		public const int WS_MINIMIZEBOX = 0x20000;

		public const int WS_MAXIMIZEBOX = 0x10000;

		public const int WS_EX_DLGMODALFRAME = 1;

		public const int WS_EX_TRANSPARENT = 0x20;

		public const int WS_EX_MDICHILD = 0x40;

		public const int WS_EX_TOOLWINDOW = 0x80;

		public const int WS_EX_WINDOWEDGE = 0x100;

		public const int WS_EX_CLIENTEDGE = 0x200;

		public const int WS_EX_CONTEXTHELP = 0x400;

		public const int WS_EX_RIGHT = 0x1000;

		public const int WS_EX_LEFT = 0;

		public const int WS_EX_RTLREADING = 0x2000;

		public const int WS_EX_LEFTSCROLLBAR = 0x4000;

		public const int WS_EX_CONTROLPARENT = 0x10000;

		public const int WS_EX_STATICEDGE = 0x20000;

		public const int WS_EX_APPWINDOW = 0x40000;

		public const int WS_EX_LAYERED = 0x80000;

		public const int WS_EX_TOPMOST = 8;

		public const int WS_EX_LAYOUTRTL = 0x400000;

		public const int WS_EX_NOINHERITLAYOUT = 0x100000;

		public const int WS_EX_COMPOSITED = 0x2000000;

		public const int WPF_SETMINPOSITION = 1;

		public const int WPF_RESTORETOMAXIMIZED = 2;

		public const int WM_CHOOSEFONT_GETLOGFONT = 0x401;

		public const int WHITE_BRUSH = 0;

		public const int NULL_BRUSH = 5;

		public const int XBUTTON1 = 1;

		public const int XBUTTON2 = 2;

		public const int CDN_FIRST = -0x259;

		public const int CDN_INITDONE = -0x259;

		public const int CDN_SELCHANGE = -0x25A;

		public const int CDN_SHAREVIOLATION = -0x25C;

		public const int CDN_FILEOK = -0x25E;

		public const int CDM_FIRST = 0x464;

		public const int CDM_GETSPEC = 0x464;

		public const int CDM_GETFILEPATH = 0x465;

		public const int DWL_MSGRESULT = 0;

		public const int PBT_APMPOWERSTATUSCHANGE = 0xA;

		public const int EVENT_SYSTEM_MOVESIZESTART = 0xA;

		public const int EVENT_SYSTEM_MOVESIZEEND = 0xB;

		public const int EVENT_OBJECT_STATECHANGE = 0x800A;

		public const int EVENT_OBJECT_FOCUS = 0x8005;

		public const int OBJID_CLIENT = -4;

		public const int WINEVENT_OUTOFCONTEXT = 0;

		public const uint RIDI_DEVICEINFO = 0x2000000BU;

		public const uint RIM_TYPEHID = 2U;

		public const ushort HID_USAGE_PAGE_DIGITIZER = 0xD;

		public const ushort HID_USAGE_DIGITIZER_DIGITIZER = 1;

		public const ushort HID_USAGE_DIGITIZER_PEN = 2;

		public const ushort HID_USAGE_DIGITIZER_LIGHTPEN = 3;

		public const ushort HID_USAGE_DIGITIZER_TOUCHSCREEN = 4;

		public const int WM_TABLET_ADDED = 0x2C8;

		public const int WM_TABLET_REMOVED = 0x2C9;

		public const int WM_QUERYSYSTEMGESTURESTATUS = 0x2CC;

		public const int WM_FLICK = 0x2CB;

		public const int AC_SRC_OVER = 0;

		public const int ULW_COLORKEY = 1;

		public const int ULW_ALPHA = 2;

		public const int ULW_OPAQUE = 4;

		public const int FEATURE_OBJECT_CACHING = 0;

		public const int FEATURE_ZONE_ELEVATION = 1;

		public const int FEATURE_MIME_HANDLING = 2;

		public const int FEATURE_MIME_SNIFFING = 3;

		public const int FEATURE_WINDOW_RESTRICTIONS = 4;

		public const int FEATURE_WEBOC_POPUPMANAGEMENT = 5;

		public const int FEATURE_BEHAVIORS = 6;

		public const int FEATURE_DISABLE_MK_PROTOCOL = 7;

		public const int FEATURE_LOCALMACHINE_LOCKDOWN = 8;

		public const int FEATURE_SECURITYBAND = 9;

		public const int FEATURE_RESTRICT_ACTIVEXINSTALL = 0xA;

		public const int FEATURE_VALIDATE_NAVIGATE_URL = 0xB;

		public const int FEATURE_RESTRICT_FILEDOWNLOAD = 0xC;

		public const int FEATURE_ADDON_MANAGEMENT = 0xD;

		public const int FEATURE_PROTOCOL_LOCKDOWN = 0xE;

		public const int FEATURE_HTTP_USERNAME_PASSWORD_DISABLE = 0xF;

		public const int FEATURE_SAFE_BINDTOOBJECT = 0x10;

		public const int FEATURE_UNC_SAVEDFILECHECK = 0x11;

		public const int FEATURE_GET_URL_DOM_FILEPATH_UNENCODED = 0x12;

		public const int GET_FEATURE_FROM_PROCESS = 2;

		public const int SET_FEATURE_ON_PROCESS = 2;

		public const int URLZONE_LOCAL_MACHINE = 0;

		public const int URLZONE_INTRANET = 1;

		public const int URLZONE_TRUSTED = 2;

		public const int URLZONE_INTERNET = 3;

		public const int URLZONE_UNTRUSTED = 4;

		public const byte URLPOLICY_ALLOW = 0;

		public const byte URLPOLICY_QUERY = 1;

		public const byte URLPOLICY_DISALLOW = 3;

		public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x2101;

		public const int PUAF_NOUI = 1;

		public const int MUTZ_NOSAVEDFILECHECK = 1;

		public const int SIZE_RESTORED = 0;

		public const int SIZE_MINIMIZED = 1;

		public const int WS_EX_NOACTIVATE = 0x8000000;

		public const int VK_LSHIFT = 0xA0;

		public const int VK_RMENU = 0xA5;

		public const int VK_LMENU = 0xA4;

		public const int VK_LCONTROL = 0xA2;

		public const int VK_RCONTROL = 0xA3;

		public const int VK_LBUTTON = 1;

		public const int VK_RBUTTON = 2;

		public const int VK_MBUTTON = 4;

		public const int VK_XBUTTON1 = 5;

		public const int VK_XBUTTON2 = 6;

		public const int PM_QS_SENDMESSAGE = 0x400000;

		public const int PM_QS_POSTMESSAGE = 0x980000;

		public const int MWMO_WAITALL = 1;

		public const int MWMO_ALERTABLE = 2;

		public const int MWMO_INPUTAVAILABLE = 4;

		internal const uint DELETE = 0x10000U;

		internal const uint READ_CONTROL = 0x20000U;

		internal const uint WRITE_DAC = 0x40000U;

		internal const uint WRITE_OWNER = 0x80000U;

		internal const uint SYNCHRONIZE = 0x100000U;

		internal const uint STANDARD_RIGHTS_REQUIRED = 0xF0000U;

		internal const uint STANDARD_RIGHTS_READ = 0x20000U;

		internal const uint STANDARD_RIGHTS_WRITE = 0x20000U;

		internal const uint STANDARD_RIGHTS_EXECUTE = 0x20000U;

		internal const uint STANDARD_RIGHTS_ALL = 0x1F0000U;

		internal const uint SPECIFIC_RIGHTS_ALL = 0xFFFFU;

		internal const uint ACCESS_SYSTEM_SECURITY = 0x1000000U;

		internal const uint MAXIMUM_ALLOWED = 0x2000000U;

		internal const uint GENERIC_READ = 0x80000000U;

		internal const uint GENERIC_WRITE = 0x40000000U;

		internal const uint GENERIC_EXECUTE = 0x20000000U;

		internal const uint GENERIC_ALL = 0x10000000U;

		internal const uint FILE_READ_DATA = 1U;

		internal const uint FILE_LIST_DIRECTORY = 1U;

		internal const uint FILE_WRITE_DATA = 2U;

		internal const uint FILE_ADD_FILE = 2U;

		internal const uint FILE_APPEND_DATA = 4U;

		internal const uint FILE_ADD_SUBDIRECTORY = 4U;

		internal const uint FILE_CREATE_PIPE_INSTANCE = 4U;

		internal const uint FILE_READ_EA = 8U;

		internal const uint FILE_WRITE_EA = 0x10U;

		internal const uint FILE_EXECUTE = 0x20U;

		internal const uint FILE_TRAVERSE = 0x20U;

		internal const uint FILE_DELETE_CHILD = 0x40U;

		internal const uint FILE_READ_ATTRIBUTES = 0x80U;

		internal const uint FILE_WRITE_ATTRIBUTES = 0x100U;

		internal const uint FILE_ALL_ACCESS = 0x1F01FFU;

		internal const uint FILE_GENERIC_READ = 0x120089U;

		internal const uint FILE_GENERIC_WRITE = 0x120116U;

		internal const uint FILE_GENERIC_EXECUTE = 0x1200A0U;

		internal const uint FILE_SHARE_READ = 1U;

		internal const uint FILE_SHARE_WRITE = 2U;

		internal const uint FILE_SHARE_DELETE = 4U;

		internal const int ERROR_ALREADY_EXISTS = 0xB7;

		internal const int OPEN_EXISTING = 3;

		internal const int PAGE_READONLY = 2;

		internal const int SECTION_MAP_READ = 4;

		internal const int FILE_ATTRIBUTE_NORMAL = 0x80;

		internal const int FILE_ATTRIBUTE_TEMPORARY = 0x100;

		internal const int FILE_FLAG_DELETE_ON_CLOSE = 0x4000000;

		internal const int CREATE_ALWAYS = 2;

		public const int QS_EVENT = 0x2000;

		public const int VK_CANCEL = 3;

		public const int VK_BACK = 8;

		public const int VK_CLEAR = 0xC;

		public const int VK_RETURN = 0xD;

		public const int VK_PAUSE = 0x13;

		public const int VK_CAPITAL = 0x14;

		public const int VK_KANA = 0x15;

		public const int VK_HANGEUL = 0x15;

		public const int VK_HANGUL = 0x15;

		public const int VK_JUNJA = 0x17;

		public const int VK_FINAL = 0x18;

		public const int VK_HANJA = 0x19;

		public const int VK_KANJI = 0x19;

		public const int VK_ESCAPE = 0x1B;

		public const int VK_CONVERT = 0x1C;

		public const int VK_NONCONVERT = 0x1D;

		public const int VK_ACCEPT = 0x1E;

		public const int VK_MODECHANGE = 0x1F;

		public const int VK_SPACE = 0x20;

		public const int VK_PRIOR = 0x21;

		public const int VK_NEXT = 0x22;

		public const int VK_END = 0x23;

		public const int VK_HOME = 0x24;

		public const int VK_LEFT = 0x25;

		public const int VK_UP = 0x26;

		public const int VK_RIGHT = 0x27;

		public const int VK_DOWN = 0x28;

		public const int VK_SELECT = 0x29;

		public const int VK_PRINT = 0x2A;

		public const int VK_EXECUTE = 0x2B;

		public const int VK_SNAPSHOT = 0x2C;

		public const int VK_INSERT = 0x2D;

		public const int VK_DELETE = 0x2E;

		public const int VK_HELP = 0x2F;

		public const int VK_0 = 0x30;

		public const int VK_1 = 0x31;

		public const int VK_2 = 0x32;

		public const int VK_3 = 0x33;

		public const int VK_4 = 0x34;

		public const int VK_5 = 0x35;

		public const int VK_6 = 0x36;

		public const int VK_7 = 0x37;

		public const int VK_8 = 0x38;

		public const int VK_9 = 0x39;

		public const int VK_A = 0x41;

		public const int VK_B = 0x42;

		public const int VK_C = 0x43;

		public const int VK_D = 0x44;

		public const int VK_E = 0x45;

		public const int VK_F = 0x46;

		public const int VK_G = 0x47;

		public const int VK_H = 0x48;

		public const int VK_I = 0x49;

		public const int VK_J = 0x4A;

		public const int VK_K = 0x4B;

		public const int VK_L = 0x4C;

		public const int VK_M = 0x4D;

		public const int VK_N = 0x4E;

		public const int VK_O = 0x4F;

		public const int VK_P = 0x50;

		public const int VK_Q = 0x51;

		public const int VK_R = 0x52;

		public const int VK_S = 0x53;

		public const int VK_T = 0x54;

		public const int VK_U = 0x55;

		public const int VK_V = 0x56;

		public const int VK_W = 0x57;

		public const int VK_X = 0x58;

		public const int VK_Y = 0x59;

		public const int VK_Z = 0x5A;

		public const int VK_LWIN = 0x5B;

		public const int VK_RWIN = 0x5C;

		public const int VK_APPS = 0x5D;

		public const int VK_POWER = 0x5E;

		public const int VK_SLEEP = 0x5F;

		public const int VK_NUMPAD0 = 0x60;

		public const int VK_NUMPAD1 = 0x61;

		public const int VK_NUMPAD2 = 0x62;

		public const int VK_NUMPAD3 = 0x63;

		public const int VK_NUMPAD4 = 0x64;

		public const int VK_NUMPAD5 = 0x65;

		public const int VK_NUMPAD6 = 0x66;

		public const int VK_NUMPAD7 = 0x67;

		public const int VK_NUMPAD8 = 0x68;

		public const int VK_NUMPAD9 = 0x69;

		public const int VK_MULTIPLY = 0x6A;

		public const int VK_ADD = 0x6B;

		public const int VK_SEPARATOR = 0x6C;

		public const int VK_SUBTRACT = 0x6D;

		public const int VK_DECIMAL = 0x6E;

		public const int VK_DIVIDE = 0x6F;

		public const int VK_F1 = 0x70;

		public const int VK_F2 = 0x71;

		public const int VK_F3 = 0x72;

		public const int VK_F4 = 0x73;

		public const int VK_F5 = 0x74;

		public const int VK_F6 = 0x75;

		public const int VK_F7 = 0x76;

		public const int VK_F8 = 0x77;

		public const int VK_F9 = 0x78;

		public const int VK_F10 = 0x79;

		public const int VK_F11 = 0x7A;

		public const int VK_F12 = 0x7B;

		public const int VK_F13 = 0x7C;

		public const int VK_F14 = 0x7D;

		public const int VK_F15 = 0x7E;

		public const int VK_F16 = 0x7F;

		public const int VK_F17 = 0x80;

		public const int VK_F18 = 0x81;

		public const int VK_F19 = 0x82;

		public const int VK_F20 = 0x83;

		public const int VK_F21 = 0x84;

		public const int VK_F22 = 0x85;

		public const int VK_F23 = 0x86;

		public const int VK_F24 = 0x87;

		public const int VK_NUMLOCK = 0x90;

		public const int VK_SCROLL = 0x91;

		public const int VK_RSHIFT = 0xA1;

		public const int VK_BROWSER_BACK = 0xA6;

		public const int VK_BROWSER_FORWARD = 0xA7;

		public const int VK_BROWSER_REFRESH = 0xA8;

		public const int VK_BROWSER_STOP = 0xA9;

		public const int VK_BROWSER_SEARCH = 0xAA;

		public const int VK_BROWSER_FAVORITES = 0xAB;

		public const int VK_BROWSER_HOME = 0xAC;

		public const int VK_VOLUME_MUTE = 0xAD;

		public const int VK_VOLUME_DOWN = 0xAE;

		public const int VK_VOLUME_UP = 0xAF;

		public const int VK_MEDIA_NEXT_TRACK = 0xB0;

		public const int VK_MEDIA_PREV_TRACK = 0xB1;

		public const int VK_MEDIA_STOP = 0xB2;

		public const int VK_MEDIA_PLAY_PAUSE = 0xB3;

		public const int VK_LAUNCH_MAIL = 0xB4;

		public const int VK_LAUNCH_MEDIA_SELECT = 0xB5;

		public const int VK_LAUNCH_APP1 = 0xB6;

		public const int VK_LAUNCH_APP2 = 0xB7;

		public const int VK_PROCESSKEY = 0xE5;

		public const int VK_PACKET = 0xE7;

		public const int VK_ATTN = 0xF6;

		public const int VK_CRSEL = 0xF7;

		public const int VK_EXSEL = 0xF8;

		public const int VK_EREOF = 0xF9;

		public const int VK_PLAY = 0xFA;

		public const int VK_ZOOM = 0xFB;

		public const int VK_NONAME = 0xFC;

		public const int VK_PA1 = 0xFD;

		public const int VK_OEM_CLEAR = 0xFE;

		internal const int ENDSESSION_LOGOFF = -0x80000000;

		internal const int ERROR_SUCCESS = 0;

		public const int LOCALE_FONTSIGNATURE = 0x58;

		public const int SM_CXFULLSCREEN = 0x10;

		public const int SM_CYFULLSCREEN = 0x11;

		public const int SM_SLOWMACHINE = 0x49;

		public const int SM_TABLETPC = 0x56;

		public const int SM_MEDIACENTER = 0x57;

		public const int SM_REMOTECONTROL = 0x2001;

		public const int SWP_NOREDRAW = 8;

		public const int SWP_FRAMECHANGED = 0x20;

		public const int SWP_NOCOPYBITS = 0x100;

		public const int SWP_NOOWNERZORDER = 0x200;

		public const int SWP_NOSENDCHANGING = 0x400;

		public const int SWP_NOREPOSITION = 0x200;

		public const int SWP_DEFERERASE = 0x2000;

		public const int SWP_ASYNCWINDOWPOS = 0x4000;

		public const int SPI_GETCURSORSHADOW = 0x101A;

		public const int SPI_SETCURSORSHADOW = 0x101B;

		public const int SPI_GETFOCUSBORDERWIDTH = 0x200E;

		public const int SPI_SETFOCUSBORDERWIDTH = 0x200F;

		public const int SPI_GETFOCUSBORDERHEIGHT = 0x2010;

		public const int SPI_SETFOCUSBORDERHEIGHT = 0x2011;

		public const int SPI_GETSTYLUSHOTTRACKING = 0x1010;

		public const int SPI_SETSTYLUSHOTTRACKING = 0x1011;

		public const int SPI_GETTOOLTIPFADE = 0x1018;

		public const int SPI_SETTOOLTIPFADE = 0x1019;

		public const int SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;

		public const int SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;

		public const int SPI_SETCARETWIDTH = 0x2007;

		public const int SPI_SETMOUSEVANISH = 0x1021;

		public const int SPI_SETHIGHCONTRAST = 0x43;

		public const int SPI_SETKEYBOARDPREF = 0x45;

		public const int SPI_SETFLATMENU = 0x1023;

		public const int SPI_SETDROPSHADOW = 0x1025;

		public const int SPI_SETWORKAREA = 0x2F;

		public const int SPI_SETICONMETRICS = 0x2E;

		public const int SPI_SETDRAGWIDTH = 0x4C;

		public const int SPI_SETDRAGHEIGHT = 0x4D;

		public const int SPI_SETPENWINDOWS = 0x31;

		public const int SPI_SETMOUSEBUTTONSWAP = 0x21;

		public const int SPI_SETSHOWSOUNDS = 0x39;

		public const int SPI_SETKEYBOARDCUES = 0x100B;

		public const int SPI_SETKEYBOARDDELAY = 0x17;

		public const int SPI_SETSNAPTODEFBUTTON = 0x60;

		public const int SPI_SETWHEELSCROLLLINES = 0x69;

		public const int SPI_SETMOUSEHOVERWIDTH = 0x63;

		public const int SPI_SETMOUSEHOVERHEIGHT = 0x65;

		public const int SPI_SETMOUSEHOVERTIME = 0x67;

		public const int SPI_SETMENUDROPALIGNMENT = 0x1C;

		public const int SPI_SETMENUFADE = 0x1013;

		public const int SPI_SETMENUSHOWDELAY = 0x6B;

		public const int SPI_SETCOMBOBOXANIMATION = 0x1005;

		public const int SPI_SETCLIENTAREAANIMATION = 0x1043;

		public const int SPI_SETGRADIENTCAPTIONS = 0x1009;

		public const int SPI_SETHOTTRACKING = 0x100F;

		public const int SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;

		public const int SPI_SETMENUANIMATION = 0x1003;

		public const int SPI_SETSELECTIONFADE = 0x1015;

		public const int SPI_SETTOOLTIPANIMATION = 0x1017;

		public const int SPI_SETUIEFFECTS = 0x103F;

		public const int SPI_SETANIMATION = 0x49;

		public const int SPI_SETDRAGFULLWINDOWS = 0x25;

		public const int SPI_SETBORDER = 6;

		public const int SPI_SETNONCLIENTMETRICS = 0x2A;

		public const int LANG_KOREAN = 0x12;

		public const int MB_YESNO = 4;

		public const int MB_SYSTEMMODAL = 0x1000;

		public const int IDYES = 6;

		public const int PM_QS_INPUT = 0x70000;

		public const int PM_QS_PAINT = 0x200000;

		public const int SW_PARENTCLOSING = 1;

		public const int SW_PARENTOPENING = 3;

		public const int SC_MOUSEMOVE = 0xF012;

		public const int SPI_SETKEYBOARDSPEED = 0xB;

		internal const int TYMED_HGLOBAL = 1;

		internal const int TYMED_FILE = 2;

		internal const int TYMED_ISTREAM = 4;

		internal const int TYMED_ISTORAGE = 8;

		internal const int TYMED_GDI = 0x10;

		internal const int TYMED_MFPICT = 0x20;

		internal const int TYMED_ENHMF = 0x40;

		public const int WS_OVERLAPPEDWINDOW = 0xCF0000;

		public const int WM_THEMECHANGED = 0x31A;

		public const int KEYEVENTF_EXTENDEDKEY = 1;

		public const int KEYEVENTF_KEYUP = 2;

		public const int KEYEVENTF_UNICODE = 4;

		public const int KEYEVENTF_SCANCODE = 8;

		public const int MOUSEEVENTF_MOVE = 1;

		public const int MOUSEEVENTF_LEFTDOWN = 2;

		public const int MOUSEEVENTF_LEFTUP = 4;

		public const int MOUSEEVENTF_RIGHTDOWN = 8;

		public const int MOUSEEVENTF_RIGHTUP = 0x10;

		public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;

		public const int MOUSEEVENTF_MIDDLEUP = 0x40;

		public const int MOUSEEVENTF_XDOWN = 0x80;

		public const int MOUSEEVENTF_XUP = 0x100;

		public const int MOUSEEVENTF_WHEEL = 0x800;

		public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;

		public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

		public const int MOUSEEVENTF_ACTUAL = 0x10000;

		public const int GWL_HINSTANCE = -6;

		public const int GWL_USERDATA = -0x15;

		public const int GCL_MENUNAME = -8;

		public const int GCL_HBRBACKGROUND = -0xA;

		public const int GCL_HCURSOR = -0xC;

		public const int GCL_HICON = -0xE;

		public const int GCL_HMODULE = -0x10;

		public const int GCL_CBWNDEXTRA = -0x12;

		public const int GCL_CBCLSEXTRA = -0x14;

		public const int GCL_STYLE = -0x1A;

		public const int GCW_ATOM = -0x20;

		public const int GCL_HICONSM = -0x22;

		public const int MONITOR_DEFAULTTONULL = 0;

		public const int MONITOR_DEFAULTTOPRIMARY = 1;

		public const int MONITOR_DEFAULTTONEAREST = 2;

		public const uint WTNCA_NODRAWCAPTION = 1U;

		public const uint WTNCA_NODRAWICON = 2U;

		public const uint WTNCA_NOSYSMENU = 4U;

		public const uint WTNCA_VALIDBITS = 7U;

		internal const int NO_ERROR = 0;

		public const int VK_OEM_1 = 0xBA;

		public const int VK_OEM_PLUS = 0xBB;

		public const int VK_OEM_COMMA = 0xBC;

		public const int VK_OEM_MINUS = 0xBD;

		public const int VK_OEM_PERIOD = 0xBE;

		public const int VK_OEM_2 = 0xBF;

		public const int VK_OEM_3 = 0xC0;

		public const int VK_C1 = 0xC1;

		public const int VK_C2 = 0xC2;

		public const int VK_OEM_4 = 0xDB;

		public const int VK_OEM_5 = 0xDC;

		public const int VK_OEM_6 = 0xDD;

		public const int VK_OEM_7 = 0xDE;

		public const int VK_OEM_8 = 0xDF;

		public const int VK_OEM_AX = 0xE1;

		public const int VK_OEM_102 = 0xE2;

		public const int VK_OEM_RESET = 0xE9;

		public const int VK_OEM_JUMP = 0xEA;

		public const int VK_OEM_PA1 = 0xEB;

		public const int VK_OEM_PA2 = 0xEC;

		public const int VK_OEM_PA3 = 0xED;

		public const int VK_OEM_WSCTRL = 0xEE;

		public const int VK_OEM_CUSEL = 0xEF;

		public const int VK_OEM_ATTN = 0xF0;

		public const int VK_OEM_FINISH = 0xF1;

		public const int VK_OEM_COPY = 0xF2;

		public const int VK_OEM_AUTO = 0xF3;

		public const int VK_OEM_ENLW = 0xF4;

		public const int VK_OEM_BACKTAB = 0xF5;

		public const int DRAGDROP_S_DROP = 0x40100;

		public const int DRAGDROP_S_CANCEL = 0x40101;

		public const int DRAGDROP_S_USEDEFAULTCURSORS = 0x40102;

		public const int WM_MOUSEQUERY = 0x9B;

		public const int TME_CANCEL = -0x80000000;

		public const int IDC_HAND = 0x7F89;

		public const int DM_ORIENTATION = 1;

		public const int DM_PAPERSIZE = 2;

		public const int DM_PAPERLENGTH = 4;

		public const int DM_PAPERWIDTH = 8;

		public const int DM_PRINTQUALITY = 0x400;

		public const int DM_YRESOLUTION = 0x2000;

		public const int MM_ISOTROPIC = 7;

		public const int DM_OUT_BUFFER = 2;

		public const int E_HANDLE = -0x7FF8FFFA;

		public const int SPI_SETFONTSMOOTHING = 0x4B;

		public const int SPI_SETFONTSMOOTHINGTYPE = 0x200B;

		public const int SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;

		public const int SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;

		public const int SPI_SETDISPLAYPIXELSTRUCTURE = 0x2015;

		public const int SPI_SETDISPLAYGAMMA = 0x2017;

		public const int SPI_SETDISPLAYCLEARTYPELEVEL = 0x2019;

		public const int SPI_SETDISPLAYTEXTCONTRASTLEVEL = 0x201B;

		public const int GMMP_USE_DISPLAY_POINTS = 1;

		public const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;

		public const int ERROR_FILE_NOT_FOUND = 2;

		public const int ERROR_PATH_NOT_FOUND = 3;

		public const int ERROR_ACCESS_DENIED = 5;

		public const int ERROR_INVALID_DRIVE = 0xF;

		public const int ERROR_SHARING_VIOLATION = 0x20;

		public const int ERROR_FILE_EXISTS = 0x50;

		public const int ERROR_INVALID_PARAMETER = 0x57;

		public const int ERROR_FILENAME_EXCED_RANGE = 0xCE;

		public const int ERROR_NO_MORE_ITEMS = 0x103;

		public const int ERROR_OPERATION_ABORTED = 0x3E3;

		public const int LR_DEFAULTCOLOR = 0;

		public const int LR_MONOCHROME = 1;

		public const int LR_COLOR = 2;

		public const int LR_COPYRETURNORG = 4;

		public const int LR_COPYDELETEORG = 8;

		public const int LR_LOADFROMFILE = 0x10;

		public const int LR_LOADTRANSPARENT = 0x20;

		public const int LR_DEFAULTSIZE = 0x40;

		public const int LR_VGACOLOR = 0x80;

		public const int LR_LOADMAP3DCOLORS = 0x1000;

		public const int LR_CREATEDIBSECTION = 0x2000;

		public const int LR_COPYFROMRESOURCE = 0x4000;

		public const int LR_SHARED = 0x8000;

		public const int WM_WTSSESSION_CHANGE = 0x2B1;

		public const int WTS_CONSOLE_CONNECT = 1;

		public const int WTS_CONSOLE_DISCONNECT = 2;

		public const int WTS_REMOTE_CONNECT = 3;

		public const int WTS_REMOTE_DISCONNECT = 4;

		public const int WTS_SESSION_LOCK = 7;

		public const int WTS_SESSION_UNLOCK = 8;

		public const uint NOTIFY_FOR_THIS_SESSION = 0U;

		public const int PBT_APMSUSPEND = 4;

		public const int PBT_APMRESUMECRITICAL = 6;

		public const int PBT_APMRESUMESUSPEND = 7;

		public const int PBT_APMRESUMEAUTOMATIC = 0x12;

		public const int PBT_POWERSETTINGCHANGE = 0x8013;
	}
}
#pragma warning restore IDE1006 // 命名样式
