using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;

namespace ExcelViewer
{
    public partial class ExcelViewer : Control
    {
        private Excel.Application application;
        private Process process;
        public IntPtr excelHandle;
        private bool initialized = false;
        private Excel.Workbooks workbooks;
        private Excel.Workbook workbook;
        private CultureInfo threadCulture;

        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_DRAWFRAME = 0x20;
        private const int SWP_NOMOVE = 0x2;
        private const int SWP_NOSIZE = 0x1;
        private const int SWP_NOZORDER = 0x4;
        private const int GWL_STYLE = (-16);
        private const int WS_CAPTION = 0xC00000;
        private const int WS_THICKFRAME = 0x40000;
        private const int WS_SIZEBOX = WS_THICKFRAME;
        private const int WS_SYSMENU = 0x00080000;
        private const int WS_MINIMIZEBOX = 0x00020000;
        private const int WS_MAXIMIZEBOX = 0x00010000;

        private enum GWL : int
        {
            EXSTYLE = -20,
            HINSTANCE = -6,
            ID = -12,
            STYLE = -16,
            USERDATA = -21,
            WNDPROC = -4
        }


        private const int SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("User32", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        public bool Saved
        {
            get { return workbook.Saved; }
        }

        public Excel.Application Application
        {
            get { return application; }
        }

        public ExcelViewer()
        {
            this.Resize += new EventHandler(ExcelViewer_Resize);
            this.HandleDestroyed += new EventHandler(ExcelViewer_HandleDestroyed);
        }
        void ExcelViewer_HandleDestroyed(object sender, EventArgs e)
        {
            CloseExcel();
        }

        public void OpenFile(string filename)
        {
            if (workbook != null)
                closeExcel();
            if (!initialized)
                Init(true);
            workbooks = application.Workbooks;
            try
            {
                workbook = workbooks.Open(filename);
                SendKeys.SendWait("1{BACKSPACE}{ESC}");
            }
            catch (Exception)
            {
                try
                {
                    if (workbook != null)
                        Marshal.ReleaseComObject(workbook);
                    workbook = workbooks.Open(filename, CorruptLoad: Excel.XlCorruptLoad.xlRepairFile);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void Init()
        {
            threadCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            application = new Excel.Application();
            application.WindowState = Excel.XlWindowState.xlNormal;

            application.Visible = true;

            excelHandle = new IntPtr(application.Hwnd);
            //showInControl();

            int pid = 0;
            GetWindowThreadProcessId(excelHandle, out pid);
            process = Process.GetProcessById(pid);
            initialized = true;
        }

        public void Init(bool showInControl)
        {
            Init();
            if (showInControl)
                this.ShowInControl();
        }

        public void ShowInControl()
        {
            application.WindowState = Excel.XlWindowState.xlNormal;
            SetParent(excelHandle, this.Handle);
            //application.WindowState = Excel.XlWindowState.xlMaximized;
            int lngStyle = GetWindowLong(excelHandle, (int)GWL.STYLE);
            lngStyle = lngStyle & ~WS_CAPTION;
            lngStyle = lngStyle & ~WS_SIZEBOX;
            lngStyle = lngStyle & ~WS_SYSMENU;
            lngStyle = lngStyle & ~WS_MINIMIZEBOX;
            lngStyle = lngStyle & ~WS_MAXIMIZEBOX;
            lngStyle = lngStyle & ~WS_THICKFRAME;
            SetWindowLong(excelHandle, (int)GWL.STYLE, lngStyle);
            SetWindowPos(excelHandle, new IntPtr(0), 0, 0, this.Width, this.Height, SWP_FRAMECHANGED);
            SendKeys.SendWait("1{BACKSPACE}{ESC}");
        }

        public void ShowOutOfControl()
        {
            SetParent(excelHandle, IntPtr.Zero);
            int lngStyle = GetWindowLong(excelHandle, (int)GWL.STYLE);
            lngStyle = lngStyle | WS_CAPTION;
            lngStyle = lngStyle | WS_SIZEBOX;
            lngStyle = lngStyle | WS_SYSMENU;
            lngStyle = lngStyle | WS_MINIMIZEBOX;
            lngStyle = lngStyle | WS_MAXIMIZEBOX;
            lngStyle = lngStyle | WS_THICKFRAME;
            SetWindowLong(excelHandle, (int)GWL.STYLE, lngStyle);
        }

        //void application_WorkbookBeforeClose(Excel.Workbook Wb, ref bool Cancel)
        //{
        //    if (WorkbookBeforeClose != null)
        //    {
        //        ExcelCloseEventArgs args = new ExcelCloseEventArgs();
        //        WorkbookBeforeClose(this, args);
        //        Cancel = args.Cancel;
        //    }
        //    else
        //        Cancel = false;
        //}

        public void CloseExcel()
        {
            closeExcel();
        }

        private void closeExcel()
        {
            try
            {
                if (workbook != null)
                {
                    workbook.Close();
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (workbooks != null)
                    Marshal.ReleaseComObject(workbooks);
                if (workbook != null)
                    Marshal.ReleaseComObject(workbook);
            }

            try
            {
                if (application != null)
                {
                    application.Quit();
                    Marshal.ReleaseComObject(application);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    process.WaitForExit(100);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally
            { }

            workbook = null;
            workbooks = null;
            application = null;
            if (process != null && !process.HasExited)
                process.Kill();
            if (threadCulture != null)
                Thread.CurrentThread.CurrentCulture = threadCulture;
            initialized = false;
        }

        public void KillExcel()
        {
            if (process != null)
                process.Kill();
        }

        public void SaveActiveWorkbook()
        {
            workbook.Save();
        }

        public void SaveActiveWorkbookAs(string filename)
        {
            workbook.SaveAs(filename);
        }

        public void SaveCopyOfActiveWorksheetAs(string filename)
        {
            workbook.SaveCopyAs(filename);
        }

        private void ExcelViewer_Resize(object sender, EventArgs e)
        {
            if (excelHandle != IntPtr.Zero)
            {
                SetWindowPos(excelHandle, new IntPtr(0), 0, 0, this.Width, this.Height, SWP_NOACTIVATE);

                //NativeMethods.ShowWindowAsync((IntPtr)application.Hwnd, TosanIDM.Windows.Forms.Native.WindowState.SW_SHOWNORMAL);
                //NativeMethods.ShowWindowAsync((IntPtr)application.Hwnd, TosanIDM.Windows.Forms.Native.WindowState.SW_SHOWMAXIMIZED);
            }
        }

        //private void removeCloseButton(IntPtr handle)
        //{
        //    IntPtr hMenu;
        //    int n;
        //    hMenu = NativeMethods.GetSystemMenu(handle, false);
        //    if (hMenu != IntPtr.Zero)
        //    {
        //        n = NativeMethods.GetMenuItemCount(hMenu);
        //        if (n > 0)
        //        {
        //            NativeMethods.RemoveMenu(hMenu, (uint)(n - 1), Consts.MF_BYPOSITION | Consts.MF_REMOVE);
        //            NativeMethods.RemoveMenu(hMenu, (uint)(n - 2), Consts.MF_BYPOSITION | Consts.MF_REMOVE);
        //            NativeMethods.DrawMenuBar(handle);
        //        }
        //    }
        //}

        //[DllImport("user32.dll", EntryPoint="GetSystemMenu")]
        //static extern Int32 GetSystemMenu( Int32 hWnd, bool bRevert );

        //[DllImport("user32.dll")]
        //public static extern int FindWindow(string strclassName, string strWindowName);

        //[DllImport("user32.dll")]
        //public static extern int EnableMenuItem(int hMenu, int nIDEnableItem, int nEnable);

        //public WordApplication( WordState state )
        //{
        //      _wordApp.Application.CommandBars["File"].Controls["Exit"].Enabled = false;
        //        int wnd = FindWindow("OpusApp", _wordApp.Caption );
        //        int menu = GetSystemMenu( wnd, false );
        //        EnableMenuItem(menu, 0xF060, 0x001 | 0x000);

        //}

    }
}
