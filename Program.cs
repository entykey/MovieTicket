﻿namespace MovieTicket
{
    using System;
    using System.Windows.Forms;


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin()); // Nếu đặt = Home => User = NULL => Cảnh báo NULL
        }
    }
}
