namespace aplikasi_sampah_jabar
{
    partial class LoginForm
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
            pnlInnerContent = new Panel();
            lblRegister = new LinkLabel();
            btnLogin = new Button();
            txtPass = new TextBox();
            lblPassLabel = new Label();
            txtUser = new TextBox();
            lblUserLabel = new Label();
            lblSubText = new Label();
            lblWelcome = new Label();
            pnlTopBar = new Panel();
            lblHeaderTitle = new Label();
            tlpOuter.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlInnerContent.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpOuter
            // 
            tlpOuter.BackColor = Color.FromArgb(15, 23, 42);
            tlpOuter.ColumnCount = 3;
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
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
            pnlCard.Controls.Add(pnlInnerContent);
            pnlCard.Controls.Add(pnlTopBar);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(228, 96);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(1044, 744);
            pnlCard.TabIndex = 0;
            // 
            // pnlInnerContent
            // 
            pnlInnerContent.BackColor = Color.Bisque;
            pnlInnerContent.Controls.Add(lblRegister);
            pnlInnerContent.Controls.Add(btnLogin);
            pnlInnerContent.Controls.Add(txtPass);
            pnlInnerContent.Controls.Add(lblPassLabel);
            pnlInnerContent.Controls.Add(txtUser);
            pnlInnerContent.Controls.Add(lblUserLabel);
            pnlInnerContent.Controls.Add(lblSubText);
            pnlInnerContent.Controls.Add(lblWelcome);
            pnlInnerContent.Dock = DockStyle.Fill;
            pnlInnerContent.Location = new Point(0, 120);
            pnlInnerContent.Name = "pnlInnerContent";
            pnlInnerContent.Padding = new Padding(100, 50, 100, 50);
            pnlInnerContent.Size = new Size(1044, 624);
            pnlInnerContent.TabIndex = 0;
            // 
            // lblRegister
            // 
            lblRegister.Font = new Font("Segoe UI", 10F);
            lblRegister.LinkColor = Color.FromArgb(249, 115, 22);
            lblRegister.Location = new Point(100, 510);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(844, 30);
            lblRegister.TabIndex = 0;
            lblRegister.TabStop = true;
            lblRegister.Text = "Belum punya akun? Daftar di sini";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(249, 115, 22);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 430);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(844, 60);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "MASUK KE SISTEM";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(100, 350);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(844, 37);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblPassLabel
            // 
            lblPassLabel.AutoSize = true;
            lblPassLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassLabel.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassLabel.Location = new Point(100, 320);
            lblPassLabel.Name = "lblPassLabel";
            lblPassLabel.Size = new Size(112, 30);
            lblPassLabel.TabIndex = 3;
            lblPassLabel.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Location = new Point(100, 260);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(844, 37);
            txtUser.TabIndex = 4;
            // 
            // lblUserLabel
            // 
            lblUserLabel.AutoSize = true;
            lblUserLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUserLabel.ForeColor = Color.FromArgb(51, 65, 85);
            lblUserLabel.Location = new Point(100, 230);
            lblUserLabel.Name = "lblUserLabel";
            lblUserLabel.Size = new Size(117, 30);
            lblUserLabel.TabIndex = 5;
            lblUserLabel.Text = "Username";
            // 
            // lblSubText
            // 
            lblSubText.Dock = DockStyle.Top;
            lblSubText.Font = new Font("Segoe UI", 11F);
            lblSubText.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubText.Location = new Point(100, 130);
            lblSubText.Name = "lblSubText";
            lblSubText.Size = new Size(844, 50);
            lblSubText.TabIndex = 6;
            lblSubText.Text = "Sistem Pengelolaan Sampah Terpadu Jawa Barat";
            lblSubText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Tahoma", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(15, 23, 42);
            lblWelcome.Location = new Point(100, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(844, 80);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "SELAMAT DATANG";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(249, 115, 22);
            pnlTopBar.Controls.Add(lblHeaderTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1044, 120);
            pnlTopBar.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(1044, 120);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "♻️ PENGELOLAAN SAMPAH JABAR";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 938);
            Controls.Add(tlpOuter);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sampah Jabar";
            tlpOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlInnerContent.ResumeLayout(false);
            pnlInnerContent.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tlpOuter;
        private Panel pnlCard;
        private Panel pnlTopBar;
        private Panel pnlInnerContent;
        private Label lblHeaderTitle;
        private Label lblWelcome;
        private Label lblSubText;
        private Label lblUserLabel;
        private TextBox txtUser;
        private Label lblPassLabel;
        private TextBox txtPass;
        private Button btnLogin;
        private LinkLabel lblRegister;
    }
}
