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

            // Hover effect tombol login
            btnLogin.MouseEnter += (s, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(234, 88, 12);
            };

            btnLogin.MouseLeave += (s, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(249, 115, 22);
            };

            // Percantik textbox
            SetupTextBox(txtUser);
            SetupTextBox(txtPass);
        }

        private void SetupTextBox(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(241, 245, 249);
            txt.BorderStyle = BorderStyle.FixedSingle;

            txt.GotFocus += (s, e) =>
            {
                txt.BackColor = Color.White;
            };

            txt.LostFocus += (s, e) =>
            {
                txt.BackColor = Color.FromArgb(241, 245, 249);
            };
        }

        // =========================
        // LINK KE REGISTER (FIX)
        // =========================
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

            // Saat register ditutup ? balik ke login
            registerForm.FormClosed += (s, args) =>
            {
                this.Show();
                this.BringToFront();
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
