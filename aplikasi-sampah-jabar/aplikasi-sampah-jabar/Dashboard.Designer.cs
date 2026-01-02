namespace aplikasi_sampah_jabar
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLaporan = new Button();
            btnChatbot = new Button();
            btnManajemen = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnLaporan);
            pnlSidebar.Controls.Add(btnChatbot);
            pnlSidebar.Controls.Add(btnManajemen);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(325, 1050);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLaporan
            // 
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Segoe UI Semibold", 10F);
            btnLaporan.ForeColor = Color.Gray;
            btnLaporan.Location = new Point(0, 414);
            btnLaporan.Margin = new Padding(4, 5, 4, 5);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(325, 86);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "   📄  Laporan PDF";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += Menu_Click;
            // 
            // btnChatbot
            // 
            btnChatbot.Dock = DockStyle.Top;
            btnChatbot.FlatAppearance.BorderSize = 0;
            btnChatbot.FlatStyle = FlatStyle.Flat;
            btnChatbot.Font = new Font("Segoe UI Semibold", 10F);
            btnChatbot.ForeColor = Color.Gray;
            btnChatbot.Location = new Point(0, 328);
            btnChatbot.Margin = new Padding(4, 5, 4, 5);
            btnChatbot.Name = "btnChatbot";
            btnChatbot.Size = new Size(325, 86);
            btnChatbot.TabIndex = 3;
            btnChatbot.Text = "   🤖  Chat Bot AI";
            btnChatbot.TextAlign = ContentAlignment.MiddleLeft;
            btnChatbot.UseVisualStyleBackColor = true;
            btnChatbot.Click += Menu_Click;
            // 
            // btnManajemen
            // 
            btnManajemen.Dock = DockStyle.Top;
            btnManajemen.FlatAppearance.BorderSize = 0;
            btnManajemen.FlatStyle = FlatStyle.Flat;
            btnManajemen.Font = new Font("Segoe UI Semibold", 10F);
            btnManajemen.ForeColor = Color.Gray;
            btnManajemen.Location = new Point(0, 242);
            btnManajemen.Margin = new Padding(4, 5, 4, 5);
            btnManajemen.Name = "btnManajemen";
            btnManajemen.Size = new Size(325, 86);
            btnManajemen.TabIndex = 2;
            btnManajemen.Text = "   ♻️  Manajemen Sampah";
            btnManajemen.TextAlign = ContentAlignment.MiddleLeft;
            btnManajemen.UseVisualStyleBackColor = true;
            btnManajemen.Click += Menu_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F);
            btnDashboard.ForeColor = Color.Gray;
            btnDashboard.Location = new Point(0, 156);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(325, 86);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "   🏠  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += Menu_Click;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(245, 158, 11);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(325, 156);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SAMPAH JABAR";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(325, 0);
            pnlTop.Margin = new Padding(4, 5, 4, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1175, 94);
            pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(25, 28);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(245, 246, 250);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(325, 94);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1175, 956);
            pnlMain.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1050);
            Controls.Add(pnlMain);
            Controls.Add(pnlTop);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            pnlSidebar.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManajemen;
        private System.Windows.Forms.Button btnChatbot;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
    }
}