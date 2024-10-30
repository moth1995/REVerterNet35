using System;
using System.Windows.Forms;
using REVerterNet35.Verter;

namespace REVerterNet35
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVerter());
        }
    }
}
