using System;
using System.Windows.Forms;

namespace RentalMobil
{
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

            // 🔐 Buka login dulu
            Application.Run(new FormLogin());
        }
    }
}