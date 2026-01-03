using System;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm()); // TETAP PILIH LOGIN
        }
    }
}