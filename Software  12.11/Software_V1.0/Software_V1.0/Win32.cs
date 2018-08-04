using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Software_V1._0 
{
    public static class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);


        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, nCmdShow nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int W, int H, uint uFlags);

        public const int GWL_STYLE = -16;

        public enum nCmdShow : int
        {
            SW_HIDE = 0,
            SW_MAXIMIZE = 3,
            SW_MINIMIZE = 6,
            SW_RESTORE = 9,
            SW_SHOW = 5,
            SW_SHOWDEFAULT = 10,
            SW_SHOWMAXIMIZED = 3,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOWNORMAL = 1
        };

        public enum WS : int
        {
            WS_BORDER = 0x00800000,

            WS_CAPTION = 0x00C00000,

            WS_CHILD = 0x40000000,

            WS_CHILDWINDOW = 0x40000000,

            WS_CLIPCHILDREN = 0x02000000,

            WS_CLIPSIBLINGS = 0x04000000,

            WS_DISABLED = 0x08000000,

            WS_DLGFRAME = 0x00400000,

            WS_GROUP = 0x00020000,

            WS_HSCROLL = 0x00100000,

            WS_ICONIC = 0x20000000,

            WS_MAXIMIZE = 0x01000000,

            WS_MAXIMIZEBOX = 0x00010000,

            WS_MINIMIZE = 0x20000000,

            WS_MINIMIZEBOX = 0x00020000,

            WS_OVERLAPPED = 0x00000000,

            WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,

            WS_POPUP = unchecked((int)0x80000000),

            WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU,

            WS_SIZEBOX = 0x00040000,

            WS_SYSMENU = 0x00080000,

            WS_TABSTOP = 0x00010000,

            WS_THICKFRAME = 0x00040000,

            WS_TILED = 0x00000000,

            WS_TILEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,

            WS_VISIBLE = 0x10000000,

            WS_VSCROLL = 0x00200000,

            WS_EX_ACCEPTFILES = 0x00000010,

            WS_EX_APPWINDOW = 0x00040000,

            WS_EX_CLIENTEDGE = 0x00000200,

            WS_EX_COMPOSITED = 0x02000000,

            WS_EX_CONTEXTHELP = 0x00000400,

            WS_EX_CONTROLPARENT = 0x00010000,

            WS_EX_DLGMODALFRAME = 0x00000001,

            WS_EX_LAYERED = 0x00080000,

            WS_EX_LAYOUTRTL = 0x00400000,

            WS_EX_LEFT = 0x00000000,

            WS_EX_LEFTSCROLLBAR = 0x00004000,

            WS_EX_LTRREADING = 0x00000000,

            WS_EX_MDICHILD = 0x00000040,

            WS_EX_NOACTIVATE = 0x08000000,

            WS_EX_NOINHERITLAYOUT = 0x00100000,

            WS_EX_NOPARENTNOTIFY = 0x00000004,

            WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,

            WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,

            WS_EX_RIGHT = 0x00001000,

            WS_EX_RIGHTSCROLLBAR = 0x00000000,

            WS_EX_RTLREADING = 0x00002000,

            WS_EX_STATICEDGE = 0x00020000,

            WS_EX_TOOLWINDOW = 0x00000080,

            WS_EX_TOPMOST = 0x00000008,

            WS_EX_TRANSPARENT = 0x00000020,

            WS_EX_WINDOWEDGE = 0x00000100
        };

        public enum SWPF : uint
        {
            NOSIZE = 0x0001,

            NOMOVE = 0x0002,

            NOZORDER = 0x0004,

            NOREDRAW = 0x0008,

            NOACTIVATE = 0x0010,

            DRAWFRAME = 0x0020,

            FRAMECHANGED = 0x0020,

            SHOWWINDOW = 0x0040,

            HIDEWINDOW = 0x0080,

            NOCOPYBITS = 0x0100,

            NOOWNERZORDER = 0x0200,

            NOREPOSITION = 0x0200,

            NOSENDCHANGING = 0x0400,

            DEFERERASE = 0x2000,

            ASYNCWINDOWPOS = 0x4000
        };
    }
}
