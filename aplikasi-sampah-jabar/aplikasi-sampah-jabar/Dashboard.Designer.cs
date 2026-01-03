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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNamaUser = new System.Windows.Forms.Label();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.btnManajemen = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnLaporan);
            this.pnlSidebar.Controls.Add(this.btnChatbot);
            this.pnlSidebar.Controls.Add(this.btnManajemen);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblNamaUser); // Label Nama di bawah
            this.pnlSidebar.Controls.Add(this.btnLogout);   // Tombol Logout di paling bawah
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 700);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 100);
            this.lblLogo.Text = "Sampah Jabar";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Tombol-tombol Menu (Dock Top)
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Text = "   🏠  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Size = new System.Drawing.Size(260, 55);
            this.btnDashboard.Click += new System.EventHandler(this.Menu_Click);

            this.btnManajemen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManajemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemen.FlatAppearance.BorderSize = 0;
            this.btnManajemen.Text = "   ♻️  Manajemen Sampah";
            this.btnManajemen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemen.Size = new System.Drawing.Size(260, 55);
            this.btnManajemen.Click += new System.EventHandler(this.Menu_Click);

            this.btnChatbot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatbot.FlatAppearance.BorderSize = 0;
            this.btnChatbot.Text = "   🤖  WasteBot AI";
            this.btnChatbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChatbot.Size = new System.Drawing.Size(260, 55);
            this.btnChatbot.Click += new System.EventHandler(this.Menu_Click);

            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.Text = "   📄  Laporan PDF";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Size = new System.Drawing.Size(260, 55);
            this.btnLaporan.Click += new System.EventHandler(this.Menu_Click);

            // lblNamaUser (Dock Bottom - Akan berada di atas tombol logout)
            this.lblNamaUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNamaUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNamaUser.ForeColor = System.Drawing.Color.Gray;
            this.lblNamaUser.Size = new System.Drawing.Size(260, 40);
            this.lblNamaUser.Text = "Login sebagai: Admin";
            this.lblNamaUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnLogout (Dock Bottom - Paling bawah)
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Text = "   🚪  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Size = new System.Drawing.Size(260, 55);
            this.btnLogout.Click += new System.EventHandler(this.Menu_Click);

            // pnlTop & pnlMain (Sesuai kode sebelumnya)
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(940, 60);
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);

            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
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
        private System.Windows.Forms.Label lblNamaUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
    }
}