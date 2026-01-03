using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            // Mengatur judul window aplikasi
            this.Text = "Sistem Manajemen Sampah Jabar";
        }

        // Fungsi klik menu untuk mengubah tampilan aktif
        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 1. Ubah Tampilan Tombol (Visual)
            ResetMenuColors();
            btn.BackColor = Color.FromArgb(245, 158, 11); // Warna Oranye
            btn.ForeColor = Color.White;

            // 2. Ubah Judul Header
            // (Asumsi text tombol ada emoji di depan, misal "🗑️ Input Sampah")
            if (btn.Text.Length > 3)
                lblTitle.Text = btn.Text.Substring(3).Trim();
            else
                lblTitle.Text = btn.Text;

            // 3. LOGIKA NAVIGASI (Membuka Form Lain)
            // Sesuaikan "btnInput" dan "btnChatbot" dengan Nama Variable tombol di Designer kamu

            if (btn.Name == "btnInput" || btn.Text.Contains("Input"))
            {
                // Buka Form Input Sampah (CRUDSampah)
                CRUDSampah formInput = new CRUDSampah();
                formInput.Show();
            }
            else if (btn.Name == "btnChatbot" || btn.Text.Contains("AI"))
            {
                // Buka Form Chatbot (JabarWasteAI)
                JabarWasteAI formChat = new JabarWasteAI();
                formChat.Show();
            }
            else if (btn.Name == "btnLogout" || btn.Text.Contains("Keluar"))
            {
                // Logout kembali ke Login
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void ResetMenuColors()
        {
            // Pastikan pnlSidebar adalah nama Panel tempat tombol berada
            // Jika error, cek nama panel di Form Designer (biasanya panel1 atau sidebarPanel)
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.Gray;
                }
            }
        }
    }
}