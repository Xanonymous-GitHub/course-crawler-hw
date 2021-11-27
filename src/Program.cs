using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCrawler
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string appGuid =
            ((GuidAttribute)Assembly.GetExecutingAssembly().
                GetCustomAttributes(typeof(GuidAttribute), false).
                    GetValue(0)).Value.ToString();

            using Mutex mutex = new(false, "Global\\" + appGuid);

            if (!mutex.WaitOne(0, false)) return;

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm());
        }

        // High DPI Display Fix
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
