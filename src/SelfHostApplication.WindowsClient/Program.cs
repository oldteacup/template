// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace SelfHostApplication.WindowsClient
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SelfHostApplication.WindowsClient.App app = new SelfHostApplication.WindowsClient.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
