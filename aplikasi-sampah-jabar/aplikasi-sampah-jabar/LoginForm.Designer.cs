namespace aplikasi_sampah_jabar
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpOuter = new TableLayoutPanel();
            pnlCard = new Panel();
            pnlInnerContent = new TableLayoutPanel();
            lblWelcome = new Label();
            lblSubText = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblRegister = new LinkLabel();
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
            tlpOuter.ColumnCount = 3;
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 643F));
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOuter.Controls.Add(pnlCard, 1, 1);
            tlpOuter.Dock = DockStyle.Fill;
            tlpOuter.Location = new Point(0, 0);
            tlpOuter.Margin = new Padding(4, 5, 4, 5);
            tlpOuter.Name = "tlpOuter";
            tlpOuter.RowCount = 3;
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Absolute, 867F));
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOuter.Size = new Size(1286, 1050);
            tlpOuter.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(pnlInnerContent);
            pnlCard.Controls.Add(pnlTopBar);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(325, 96);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(635, 857);
            pnlCard.TabIndex = 0;
            // 
            // pnlInnerContent
            // 
            pnlInnerContent.ColumnCount = 1;
            pnlInnerContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlInnerContent.Controls.Add(lblWelcome, 0, 0);
            pnlInnerContent.Controls.Add(lblSubText, 0, 1);
            pnlInnerContent.Controls.Add(txtUser, 0, 2);
            pnlInnerContent.Controls.Add(txtPass, 0, 3);
            pnlInnerContent.Controls.Add(btnLogin, 0, 4);
            pnlInnerContent.Controls.Add(lblRegister, 0, 5);
            pnlInnerContent.Dock = DockStyle.Fill;
            pnlInnerContent.Location = new Point(0, 83);
            pnlInnerContent.Margin = new Padding(4, 5, 4, 5);
            pnlInnerContent.Name = "pnlInnerContent";
            pnlInnerContent.Padding = new Padding(57, 50, 57, 50);
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInnerContent.Size = new Size(633, 772);
            pnlInnerContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.Location = new Point(61, 50);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(511, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubText
            // 
            lblSubText.Dock = DockStyle.Top;
            lblSubText.Font = new Font("Segoe UI", 10F);
            lblSubText.ForeColor = Color.Gray;
            lblSubText.Location = new Point(61, 70);
            lblSubText.Margin = new Padding(4, 0, 4, 0);
            lblSubText.Name = "lblSubText";
            lblSubText.Size = new Size(511, 20);
            lblSubText.TabIndex = 1;
            lblSubText.Text = "Masukkan kredensial Anda untuk mengakses sistem pengelolaan sampah.";
            lblSubText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(236, 95);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(161, 39);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(236, 115);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(161, 39);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(245, 158, 11);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(235, 135);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 10);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Masuk Sekarang";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.Font = new Font("Segoe UI", 9F);
            lblRegister.LinkColor = Color.FromArgb(245, 158, 11);
            lblRegister.Location = new Point(235, 411);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(163, 50);
            lblRegister.TabIndex = 5;
            lblRegister.TabStop = true;
            lblRegister.Text = "Belum punya akun? Daftar di sini";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(252, 252, 252);
            pnlTopBar.Controls.Add(lblHeaderTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Margin = new Padding(4, 5, 4, 5);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(633, 83);
            pnlTopBar.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 9F);
            lblHeaderTitle.ForeColor = Color.DimGray;
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Padding = new Padding(21, 0, 0, 0);
            lblHeaderTitle.Size = new Size(633, 83);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Aplikasi Sampah Jabar - Login";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1286, 1050);
            Controls.Add(tlpOuter);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tlpOuter.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlInnerContent.ResumeLayout(false);
            pnlInnerContent.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TableLayoutPanel pnlInnerContent;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
    }
}