using System;
using System.Windows.Forms;

namespace PPYC
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
           // OtherTestMethods.GetStudentInfo();
            Application.Run(new FormMain());
        }
    }
}
