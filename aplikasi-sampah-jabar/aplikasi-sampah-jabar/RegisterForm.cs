using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Hover effect
            btnReg.MouseEnter += (s, e) => btnReg.BackColor = Color.FromArgb(4, 120, 87);
            btnReg.MouseLeave += (s, e) => btnReg.BackColor = Color.FromArgb(16, 185, 129);

            // Setup Textbox
            SetupTextBox(txtUser);
            SetupTextBox(txtPass);
            SetupTextBox(txtConfirm);

            // --- EVENT KLIK TOMBOL DAFTAR (PENTING!) ---
            // Pastikan di Designer, tombol kamu bernama 'btnReg'
            // Dan event Click-nya mengarah ke fungsi btnReg_Click
            btnReg.Click += btnReg_Click;
        }

        // --- LOGIKA REGISTER ---
        private void btnReg_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi Konfirmasi Password
            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 3. Panggil AuthService
                AuthService auth = new AuthService();

                // Default role kita set "admin" dulu agar bisa tes masuk
                bool berhasil = auth.Register(txtUser.Text, txtPass.Text, "admin");

                if (berhasil)
                {
                    MessageBox.Show("Registrasi Berhasil! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Tutup form register, balik ke login
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Daftar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupTextBox(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(241, 245, 249);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.GotFocus += (s, e) => txt.BackColor = Color.White;
            txt.LostFocus += (s, e) => txt.BackColor = Color.FromArgb(241, 245, 249);
        }

        private void lblKeLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}