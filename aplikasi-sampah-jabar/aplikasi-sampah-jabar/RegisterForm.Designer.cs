namespace aplikasi_sampah_jabar
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpUtama = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblKeLogin = new System.Windows.Forms.LinkLabel();
            this.tlpUtama.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // tlpUtama
            this.tlpUtama.ColumnCount = 3;
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.Controls.Add(this.pnlCard, 1, 1);
            this.tlpUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUtama.RowCount = 3;
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            // pnlCard
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.txtUser);
            this.pnlCard.Controls.Add(this.txtPass);
            this.pnlCard.Controls.Add(this.txtConfirm);
            this.pnlCard.Controls.Add(this.btnReg);
            this.pnlCard.Controls.Add(this.lblKeLogin);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Size = new System.Drawing.Size(400, 60);
            this.lblTitle.Text = "Buat Akun";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtUser
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.Location = new System.Drawing.Point(50, 110);
            this.txtUser.Size = new System.Drawing.Size(300, 35);
            this.txtUser.PlaceholderText = "Username Baru";

            // txtPass
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(50, 170);
            this.txtPass.Size = new System.Drawing.Size(300, 35);
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.UseSystemPasswordChar = true;

            // txtConfirm
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(50, 230);
            this.txtConfirm.Size = new System.Drawing.Size(300, 35);
            this.txtConfirm.PlaceholderText = "Konfirmasi Password";
            this.txtConfirm.UseSystemPasswordChar = true;

            // btnReg
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(50, 310);
            this.btnReg.Size = new System.Drawing.Size(300, 50);
            this.btnReg.Text = "DAFTAR";

            // lblKeLogin
            this.lblKeLogin.Location = new System.Drawing.Point(50, 380);
            this.lblKeLogin.Size = new System.Drawing.Size(300, 30);
            this.lblKeLogin.Text = "Sudah punya akun? Masuk";
            this.lblKeLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKeLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKeLogin_LinkClicked);

            // Form Settings
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tlpUtama);
            this.Text = "Register - Sampah Jabar";
            this.tlpUtama.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpUtama;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.LinkLabel lblKeLogin;
    }
}