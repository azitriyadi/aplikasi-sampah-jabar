using System;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Login berhasil (sementara)");
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void lblKeRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }
    }
}
