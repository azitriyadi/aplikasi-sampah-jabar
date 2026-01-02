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

            // Memastikan Dashboard yang pertama kali muncul
            Application.Run(new Dashboard());
        }
    }
}