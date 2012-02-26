using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrendWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Nhibernate Setup
            
            SessionConfig.BeginNhProfiler();
            //SessionConfig.CreateDatabaseFromMappings();

            //Form Setup
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParentMasterPage());
        }






    }
}
