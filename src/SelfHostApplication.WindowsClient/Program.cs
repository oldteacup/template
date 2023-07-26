// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Serilog.Events;
using Serilog;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.Windows;
using System.Runtime.InteropServices;

namespace SelfHostApplication.WindowsClient
{
    public class Program
    {
        private static System.Threading.Mutex _mutex;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        [STAThread]
        public static void Main(string[] args)
        {
            string name = nameof(SelfHostApplication.WindowsClient);

            _mutex = new System.Threading.Mutex(true, name);

            if (!_mutex.WaitOne(0, false))
            {
                IntPtr handle = FindWindow(null, name);
                if (handle != IntPtr.Zero)
                {
                    ShowWindow(handle, SW_RESTORE);
                    SetForegroundWindow(handle);
                }
                return;
            }

            

            SelfHostApplication.WindowsClient.App app = new SelfHostApplication.WindowsClient.App();
            app.InitializeComponent();
            app.Run();

            _mutex.ReleaseMutex();
        }


    }
}
