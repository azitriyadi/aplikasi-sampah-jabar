using System;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class RegisterForm : Form
    {
        public RegisterForm() => InitializeComponent();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }
            MessageBox.Show("Registrasi Berhasil! Silakan Login.");
            this.Hide();
            new LoginForm().Show();
        }

        private void lblLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void lblKeLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}