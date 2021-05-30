using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace ProToolsBorderless
{
    internal class ProToolsWindowManager
    {



        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        // This static method is required because Win32 does not support
        // GetWindowLongPtr directly
        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 8)
                return GetWindowLongPtr64(hWnd, nIndex);
            else
                return GetWindowLongPtr32(hWnd, nIndex);
        }

       
        
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        // This static method is required because legacy OSes do not support
        // SetWindowLongPtr directly
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }





        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point Point);

        [DllImport("user32")]
        public static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

        [DllImport("user32")]
        public static extern long GetMenu(IntPtr hwnd);

        [DllImport("user32")]
        public static extern long SetMenu(IntPtr hwnd, long hMenuOld);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetParent", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetParent(IntPtr hWnd);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        //Window Styles
        private static int GWL_STYLE = -16;
        private static long WS_CHILD = 0x40000000; //child window
        private static long WS_BORDER = 0x00800000; //window with border
        private static long WS_DLGFRAME = 0x00400000; //window with double border but no title
        private static long WS_THICKFRAME = 0x00040000; //Thick sizing borders
        private static long WS_CAPTION = WS_BORDER | WS_DLGFRAME; //window with a title bar
        private static long WS_OVERLAPPED = 0x00000000L;
        private static long WS_SYSMENU = 0x00080000L;
        private static long WS_MINIMIZEBOX = 0x00020000L;
        private static long WS_MAXIMIZEBOX = 0x00010000L;
        private static long WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);

        //SetWindowPos Constants
        private static int SWP_FRAMECHANGED = 0x0020;
        private static int SWP_NOMOVE = 0x0002;
        private static int SWP_NOSIZE = 0x0001;
        private static int SWP_NOZORDER = 0x0004;
        private static int SWP_NOOWNERZORDER = 0x0200;

        //Main Window
        private IntPtr mainWindow_hWnd;
        private long mainWindow_menuBar_oldStyle;

        //My Program
        private IntPtr myProgram_hWnd;


        public string GetWindowTitle(IntPtr hWnd)
        {
            var length = GetWindowTextLength(hWnd) + 1;
            var title = new StringBuilder(length);
            GetWindowText(hWnd, title, length);
            return title.ToString();
        }

        public uint GetWindowPID(IntPtr hWnd)
        {
            uint processID;
            GetWindowThreadProcessId(hWnd, out processID);
            return processID;
        }

        //WAITING FOR PRO TOOLS
        public IntPtr LookForTheProTools()
        {
            bool isTheProToolsFound = false;

            while (!isTheProToolsFound)
            {
                Process[] Procs = Process.GetProcesses();
                foreach (Process proc in Procs)
                {
                    if (proc.ProcessName.Equals("ProTools"))
                    {
                        mainWindow_hWnd = proc.MainWindowHandle;
                        if ((int)mainWindow_hWnd != 0)
                        {
                            GetMyProgram_hWnd();
                            SetForegroundWindow(myProgram_hWnd);
                            isTheProToolsFound = true;
                        }
                        break;
                    }
                }
                if (!isTheProToolsFound)
                    System.Threading.Thread.Sleep(2000);
            }

            return mainWindow_hWnd;
        }

        public void GetMyProgram_hWnd()
        {
            Process myProc = Process.GetCurrentProcess();
            myProgram_hWnd = myProc.MainWindowHandle;
        }

        //CHILD WINDOWS
        public object[] CaptureWindowsStyle()
        {
            GetCursorPos(out Point location);

            IntPtr hWnd = WindowFromPoint(location);
            bool isCorrectWindow = false;

            LookForTheProTools();

            if (GetParent(hWnd) == mainWindow_hWnd)
            {
                isCorrectWindow = true;
            }

            return new object[] { hWnd, isCorrectWindow, mainWindow_hWnd };
        }

        public void childWindowsReStyle(IntPtr hWnd)
        {
            long style = (long)GetWindowLongPtr(hWnd, GWL_STYLE);
            style &= ~(WS_CAPTION | WS_THICKFRAME);
            SetWindowLongPtr(hWnd, GWL_STYLE, (IntPtr)style);
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }

        public void RevertChildWindowsStyle(IntPtr hWnd)
        {
            long style = (long)GetWindowLongPtr(hWnd, GWL_STYLE);
            style |= WS_CAPTION | WS_THICKFRAME;
            SetWindowLongPtr(hWnd, GWL_STYLE, (IntPtr)style);
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }


        //MAIN WINDOW
        public void RemoveMainWindowTitleBar()
        {
            long style = (long)GetWindowLongPtr(mainWindow_hWnd, GWL_STYLE);
            style &= ~(WS_CAPTION | WS_THICKFRAME);
            SetWindowLongPtr(mainWindow_hWnd, GWL_STYLE, (IntPtr)style);
            SetWindowPos(mainWindow_hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }

        public void RevertMainWindowTitleBar()
        {
            long style = (long)GetWindowLongPtr(mainWindow_hWnd, GWL_STYLE);
            style |= (WS_CAPTION | WS_THICKFRAME);
            SetWindowLongPtr(mainWindow_hWnd, GWL_STYLE, (IntPtr)style);
            SetWindowPos(mainWindow_hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }

        public void RemoveMainWindowMenuBar()
        {
            mainWindow_menuBar_oldStyle = GetMenu(mainWindow_hWnd);
            SetMenu(mainWindow_hWnd, 0);
            SetWindowPos(mainWindow_hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }

        public void RevertMainWindowMenuBar()
        {
            SetMenu(mainWindow_hWnd, mainWindow_menuBar_oldStyle);
            SetWindowPos(mainWindow_hWnd, 0, 0, 0, 0, 0, SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER);
            SetForegroundWindow(myProgram_hWnd);
        }

    }
}
