﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048Game
{
    static class Program
    {
        // 下载于www.mycodes.net
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
