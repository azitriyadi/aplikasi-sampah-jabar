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

            // KITA PILIH LOGIN FORM SEBAGAI PINTU MASUK UTAMA
            Application.Run(new LoginForm());
        }
    }
}