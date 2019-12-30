using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using System.Windows.Forms;

namespace ERBA_Manager
{
    static class Program
    {
        public static Gebruiker HuidigeGebruiker;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppMain ());
        }
    }
}
