using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Introduction_To_Programming_11_2008
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
            Application.Run(new unlu_uyumu());
        }
    }
}
