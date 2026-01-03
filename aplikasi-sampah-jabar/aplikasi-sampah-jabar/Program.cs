using System;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // KITA PILIH LOGIN FORM SEBAGAI PINTU MASUK
            Application.Run(new LoginForm());
        }
    }
}