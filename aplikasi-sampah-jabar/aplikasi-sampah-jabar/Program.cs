using System;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Kita pakai inisialisasi modern (sesuai versi kamu/HEAD)
            ApplicationConfiguration.Initialize();

            // PENTING: Jalankan LoginForm sebagai pintu masuk utama
            Application.Run(new LoginForm());
        }
    }
}