using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Hover effect
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(234, 88, 12);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(249, 115, 22);

            SetupTextBox(txtUser);
            SetupTextBox(txtPass);

            // --- EVENT KLIK TOMBOL LOGIN (PENTING!) ---
            btnLogin.Click += btnLogin_Click;
        }

        // --- LOGIKA LOGIN ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Panggil AuthService
                AuthService auth = new AuthService();
                var user = auth.Login(txtUser.Text, txtPass.Text);

                if (user != null)
                {
                    // 2. Jika Sukses
                    MessageBox.Show($"Selamat datang, {user.Username}!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    // Sembunyikan Login Form (jangan di-close total biar aplikasi gak mati)
                    this.Hide();
                }
                else
                {
                    // 3. Jika Gagal
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupTextBox(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(241, 245, 249);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.GotFocus += (s, e) => txt.BackColor = Color.White;
            txt.LostFocus += (s, e) => txt.BackColor = Color.FromArgb(241, 245, 249);
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            // Trik agar saat Register ditutup, Login muncul lagi
            this.Hide();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}