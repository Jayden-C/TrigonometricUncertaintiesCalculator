using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrigonometricUncertaintiesCalculator
{
    static class Program
    {
        internal static MainForm MainWindowForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindowForm = new MainForm();
            Application.Run(MainWindowForm);
        }
    }
}
