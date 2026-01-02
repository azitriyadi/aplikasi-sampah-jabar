namespace aplikasi_sampah_jabar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMenuItems = new System.Windows.Forms.Panel();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlChatbot = new System.Windows.Forms.Panel();
            this.rtbChatLog = new System.Windows.Forms.RichTextBox();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.lblChatHeader = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvDataSampah = new System.Windows.Forms.DataGridView();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlSidebar.SuspendLayout();
            this.pnlMenuItems.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlChatbot.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSampah)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.pnlSidebar.Controls.Add(this.pnlMenuItems);
            this.pnlSidebar.Controls.Add(this.pnlProfile);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 750);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Controls.Add(this.lblSubtitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlLogo.Size = new System.Drawing.Size(260, 120);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 45);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🌿 JABAR SMART";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(220, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Waste Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.Controls.Add(this.btnAnalytics);
            this.pnlMenuItems.Controls.Add(this.btnReports);
            this.pnlMenuItems.Controls.Add(this.btnDashboard);
            this.pnlMenuItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuItems.Location = new System.Drawing.Point(0, 120);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Padding = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.pnlMenuItems.Size = new System.Drawing.Size(260, 200);
            this.pnlMenuItems.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(15, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   🏠  Dashboard Overview";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReports.Location = new System.Drawing.Point(15, 70);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(230, 50);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "   📊  Laporan && Statistik";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAnalytics.Location = new System.Drawing.Point(15, 120);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAnalytics.Size = new System.Drawing.Size(230, 50);
            this.btnAnalytics.TabIndex = 2;
            this.btnAnalytics.Text = "   📈  Data Analytics";
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.btnExport);
            this.pnlProfile.Controls.Add(this.lblUserRole);
            this.pnlProfile.Controls.Add(this.lblUserName);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProfile.Location = new System.Drawing.Point(0, 550);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfile.Size = new System.Drawing.Size(260, 200);
            this.pnlProfile.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(20, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(220, 30);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "👤 Admin DLHK";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblUserRole.Location = new System.Drawing.Point(20, 50);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(220, 25);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Dinas Lingkungan Hidup";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(20, 130);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(220, 50);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "📄  Export Data PDF";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(260, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.pnlHeader.Size = new System.Drawing.Size(800, 90);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(487, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Pengelolaan Sampah";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(35, 58);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(320, 17);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "📅 " + System.DateTime.Now.ToString("dddd, dd MMMM yyyy");
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.dgvDataSampah);
            this.pnlContent.Controls.Add(this.lblTableTitle);
            this.pnlContent.Controls.Add(this.pnlCards);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 90);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.pnlContent.Size = new System.Drawing.Size(800, 660);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(20, 15);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(760, 160);
            this.pnlCards.TabIndex = 0;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTableTitle.Location = new System.Drawing.Point(20, 175);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTableTitle.Size = new System.Drawing.Size(760, 50);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "📋  Data Sampah Per Wilayah";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDataSampah
            // 
            this.dgvDataSampah.AllowUserToAddRows = false;
            this.dgvDataSampah.AllowUserToDeleteRows = false;
            this.dgvDataSampah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataSampah.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataSampah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataSampah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSampah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSampah.Location = new System.Drawing.Point(20, 225);
            this.dgvDataSampah.Name = "dgvDataSampah";
            this.dgvDataSampah.ReadOnly = true;
            this.dgvDataSampah.RowHeadersVisible = false;
            this.dgvDataSampah.Size = new System.Drawing.Size(760, 415);
            this.dgvDataSampah.TabIndex = 2;
            // 
            // pnlChatbot
            // 
            this.pnlChatbot.BackColor = System.Drawing.Color.White;
            this.pnlChatbot.Controls.Add(this.rtbChatLog);
            this.pnlChatbot.Controls.Add(this.lblChatHeader);
            this.pnlChatbot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChatbot.Location = new System.Drawing.Point(1060, 0);
            this.pnlChatbot.Name = "pnlChatbot";
            this.pnlChatbot.Size = new System.Drawing.Size(340, 750);
            this.pnlChatbot.TabIndex = 3;
            // 
            // lblChatHeader
            // 
            this.lblChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.lblChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChatHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatHeader.ForeColor = System.Drawing.Color.White;
            this.lblChatHeader.Location = new System.Drawing.Point(0, 0);
            this.lblChatHeader.Name = "lblChatHeader";
            this.lblChatHeader.Size = new System.Drawing.Size(340, 60);
            this.lblChatHeader.TabIndex = 0;
            this.lblChatHeader.Text = "🤖 AI Eco-Assistant";
            this.lblChatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbChatLog
            // 
            this.rtbChatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChatLog.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatLog.Location = new System.Drawing.Point(0, 60);
            this.rtbChatLog.Name = "rtbChatLog";
            this.rtbChatLog.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.rtbChatLog.Size = new System.Drawing.Size(340, 690);
            this.rtbChatLog.TabIndex = 1;
            this.rtbChatLog.Text = "";
            // 
            // txtChatInput
            // 
            this.txtChatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChatInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatInput.Location = new System.Drawing.Point(0, 0);
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(290, 27);
            this.txtChatInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlChatbot);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jabar Smart Waste Management - Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenuItems.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlChatbot.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSampah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMenuItems;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlChatbot;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblChatHeader;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.RichTextBox rtbChatLog;
        private System.Windows.Forms.DataGridView dgvDataSampah;
    }
}