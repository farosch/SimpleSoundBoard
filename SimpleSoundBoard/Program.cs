using System;
using System.Windows.Forms;

namespace SimpleSoundBoard
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
            FrmMain frmMain = new FrmMain();
            Application.Run();
        }
    }
}
