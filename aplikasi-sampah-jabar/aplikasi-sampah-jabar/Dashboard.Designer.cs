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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManajemen = new System.Windows.Forms.Button();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar (Navigasi Kiri)
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnLaporan);
            this.pnlSidebar.Controls.Add(this.btnChatbot);
            this.pnlSidebar.Controls.Add(this.btnManajemen);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 700);
            this.pnlSidebar.TabIndex = 0;

            // Branding: Sampah Jabar
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 100);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Sampah Jabar";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Tombol Menu
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gray;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(260, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   🏠  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.Menu_Click);

            this.btnManajemen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManajemen.FlatAppearance.BorderSize = 0;
            this.btnManajemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnManajemen.ForeColor = System.Drawing.Color.Gray;
            this.btnManajemen.Location = new System.Drawing.Point(0, 155);
            this.btnManajemen.Name = "btnManajemen";
            this.btnManajemen.Size = new System.Drawing.Size(260, 55);
            this.btnManajemen.TabIndex = 2;
            this.btnManajemen.Text = "   ♻️  Manajemen Sampah";
            this.btnManajemen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemen.UseVisualStyleBackColor = true;
            this.btnManajemen.Click += new System.EventHandler(this.Menu_Click);

            this.btnChatbot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChatbot.FlatAppearance.BorderSize = 0;
            this.btnChatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatbot.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnChatbot.ForeColor = System.Drawing.Color.Gray;
            this.btnChatbot.Location = new System.Drawing.Point(0, 210);
            this.btnChatbot.Name = "btnChatbot";
            this.btnChatbot.Size = new System.Drawing.Size(260, 55);
            this.btnChatbot.TabIndex = 3;
            this.btnChatbot.Text = "   🤖  WasteBot AI";
            this.btnChatbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChatbot.UseVisualStyleBackColor = true;
            this.btnChatbot.Click += new System.EventHandler(this.Menu_Click);

            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLaporan.ForeColor = System.Drawing.Color.Gray;
            this.btnLaporan.Location = new System.Drawing.Point(0, 265);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(260, 55);
            this.btnLaporan.TabIndex = 4;
            this.btnLaporan.Text = "   📄  Laporan PDF";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.Menu_Click);

            // 
            // pnlTop (Header)
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(260, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 60);
            this.pnlTop.TabIndex = 1;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";

            // 
            // pnlMain (Area Konten Kosong)
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(260, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(940, 640);
            this.pnlMain.TabIndex = 2;

            // 
            // Dashboard Form Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Mencegah resize berlebih
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
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