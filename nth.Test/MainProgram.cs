using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nth.Test
{
    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new nF_Main());
        }
    }
}
