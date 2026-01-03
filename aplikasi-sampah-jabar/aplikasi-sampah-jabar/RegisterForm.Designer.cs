namespace aplikasi_sampah_jabar
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpOuter = new TableLayoutPanel();
            pnlCard = new Panel();
            pnlContent = new Panel();
            lblKeLogin = new LinkLabel();
            btnReg = new Button();
            txtConfirm = new TextBox();
            lblConfirmLabel = new Label();
            txtPass = new TextBox();
            lblPassLabel = new Label();
            txtUser = new TextBox();
            lblUserLabel = new Label();
            lblSubtext = new Label();
            lblTitle = new Label();
            pnlTopBar = new Panel();
            lblHeaderTitle = new Label();
            tlpOuter.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpOuter
            // 
            tlpOuter.BackColor = Color.FromArgb(15, 23, 42);
            tlpOuter.ColumnCount = 3;
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpOuter.Controls.Add(pnlCard, 1, 1);
            tlpOuter.Dock = DockStyle.Fill;
            tlpOuter.Location = new Point(0, 0);
            tlpOuter.Name = "tlpOuter";
            tlpOuter.RowCount = 3;
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpOuter.Size = new Size(1500, 938);
            tlpOuter.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(pnlContent);
            pnlCard.Controls.Add(pnlTopBar);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(303, 96);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(894, 744);
            pnlCard.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightYellow;
            pnlContent.Controls.Add(lblKeLogin);
            pnlContent.Controls.Add(btnReg);
            pnlContent.Controls.Add(txtConfirm);
            pnlContent.Controls.Add(lblConfirmLabel);
            pnlContent.Controls.Add(txtPass);
            pnlContent.Controls.Add(lblPassLabel);
            pnlContent.Controls.Add(txtUser);
            pnlContent.Controls.Add(lblUserLabel);
            pnlContent.Controls.Add(lblSubtext);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(100, 40, 100, 40);
            pnlContent.Size = new Size(894, 624);
            pnlContent.TabIndex = 0;
            // 
            // lblKeLogin
            // 
            lblKeLogin.BackColor = Color.White;
            lblKeLogin.Font = new Font("Segoe UI", 10F);
            lblKeLogin.LinkColor = Color.Green;
            lblKeLogin.Location = new Point(100, 570);
            lblKeLogin.Name = "lblKeLogin";
            lblKeLogin.Size = new Size(700, 30);
            lblKeLogin.TabIndex = 0;
            lblKeLogin.TabStop = true;
            lblKeLogin.Text = "Sudah punya akun? Masuk di sini";
            lblKeLogin.TextAlign = ContentAlignment.MiddleCenter;
            lblKeLogin.LinkClicked += lblKeLogin_LinkClicked;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.Green;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(100, 500);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(700, 60);
            btnReg.TabIndex = 1;
            btnReg.Text = "DAFTAR";
            btnReg.UseVisualStyleBackColor = false;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 11F);
            txtConfirm.Location = new Point(100, 430);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(700, 37);
            txtConfirm.TabIndex = 2;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.AutoSize = true;
            lblConfirmLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConfirmLabel.ForeColor = Color.FromArgb(51, 65, 85);
            lblConfirmLabel.Location = new Point(100, 400);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new Size(229, 30);
            lblConfirmLabel.TabIndex = 3;
            lblConfirmLabel.Text = "Konfirmasi Password";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(100, 340);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(700, 37);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblPassLabel
            // 
            lblPassLabel.AutoSize = true;
            lblPassLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassLabel.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassLabel.Location = new Point(100, 310);
            lblPassLabel.Name = "lblPassLabel";
            lblPassLabel.Size = new Size(112, 30);
            lblPassLabel.TabIndex = 5;
            lblPassLabel.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Location = new Point(100, 250);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(700, 37);
            txtUser.TabIndex = 6;
            // 
            // lblUserLabel
            // 
            lblUserLabel.AutoSize = true;
            lblUserLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUserLabel.ForeColor = Color.FromArgb(51, 65, 85);
            lblUserLabel.Location = new Point(100, 220);
            lblUserLabel.Name = "lblUserLabel";
            lblUserLabel.Size = new Size(117, 30);
            lblUserLabel.TabIndex = 7;
            lblUserLabel.Text = "Username";
            // 
            // lblSubtext
            // 
            lblSubtext.Dock = DockStyle.Top;
            lblSubtext.Font = new Font("Segoe UI", 10.5F);
            lblSubtext.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtext.Location = new Point(100, 120);
            lblSubtext.Name = "lblSubtext";
            lblSubtext.Size = new Size(694, 60);
            lblSubtext.TabIndex = 8;
            lblSubtext.Text = "Daftarkan akun untuk mengakses\nSistem Pengelolaan Sampah Jawa Barat";
            lblSubtext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(100, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(694, 80);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Buat Akun Baru";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(16, 185, 129);
            pnlTopBar.Controls.Add(lblHeaderTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(894, 120);
            pnlTopBar.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.BackColor = Color.MediumSeaGreen;
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(894, 120);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "🗑️ PENGELOLAAN SAMPAH JABAR";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 938);
            Controls.Add(tlpOuter);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - Sampah Jabar";
            tlpOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tlpOuter;
        private Panel pnlCard;
        private Panel pnlTopBar;
        private Panel pnlContent;
        private Label lblHeaderTitle;
        private Label lblTitle;
        private Label lblSubtext;
        private Label lblUserLabel;
        private TextBox txtUser;
        private Label lblPassLabel;
        private TextBox txtPass;
        private Label lblConfirmLabel;
        private TextBox txtConfirm;
        private Button btnReg;
        private LinkLabel lblKeLogin;
    }
}
