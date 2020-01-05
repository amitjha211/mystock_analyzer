using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;


namespace mystock_win
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ui.appServerRootPath = ConfigurationManager.AppSettings["appServiceFolder"] + "\\appServer";

            ui.appName = "mystock";
            ui.initApp();
            
            Application.Run(new frmMain());

        }
    }
}
