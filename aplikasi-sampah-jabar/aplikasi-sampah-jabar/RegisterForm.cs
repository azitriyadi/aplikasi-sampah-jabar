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

            // Hover effect tombol daftar
            btnReg.MouseEnter += (s, e) =>
            {
                btnReg.BackColor = Color.FromArgb(4, 120, 87);
            };

            btnReg.MouseLeave += (s, e) =>
            {
                btnReg.BackColor = Color.FromArgb(16, 185, 129);
            };

            // Percantik textbox
            SetupTextBox(txtUser);
            SetupTextBox(txtPass);
            SetupTextBox(txtConfirm);
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

        private void lblKeLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // balik ke login
        }
    }
}
