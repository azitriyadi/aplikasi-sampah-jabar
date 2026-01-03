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

            // Jangan langsung jalankan LoginForm
            // Buat instance dan kontrol secara manual
            Application.Run(new LoginForm());
        }
    }
}