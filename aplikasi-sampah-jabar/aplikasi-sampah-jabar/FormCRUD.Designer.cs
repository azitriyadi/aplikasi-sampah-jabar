namespace aplikasi_sampah_jabar
{
    partial class FormCRUD
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

        private void InitializeComponent()
        {
            this.txtWilayah = new System.Windows.Forms.TextBox();
            this.numOrganik = new System.Windows.Forms.NumericUpDown();
            this.numAnorganik = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOrganik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnorganik)).BeginInit();
            this.SuspendLayout();

            // 
            // Form Header
            // 
            System.Windows.Forms.Panel pnlHeader = new System.Windows.Forms.Panel();
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);

            System.Windows.Forms.Label lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = isEditMode ? "✏️ Edit Data Sampah" : "➕ Tambah Data Sampah";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Location = new System.Drawing.Point(30, 25);
            lblHeader.AutoSize = true;
            pnlHeader.Controls.Add(lblHeader);

            // 
            // Main Panel (White Card)
            // 
            System.Windows.Forms.Panel pnlMain = new System.Windows.Forms.Panel();
            pnlMain.Location = new System.Drawing.Point(30, 100);
            pnlMain.Size = new System.Drawing.Size(420, 250);
            pnlMain.BackColor = System.Drawing.Color.White;

            // Labels
            System.Windows.Forms.Label lblWilayah = CreateLabel("Kabupaten/Kota:", 20, 20);
            System.Windows.Forms.Label lblOrganik = CreateLabel("Sampah Organik (Ton):", 20, 65);
            System.Windows.Forms.Label lblAnorganik = CreateLabel("Sampah Anorganik (Ton):", 20, 110);
            System.Windows.Forms.Label lblTotalLabel = CreateLabel("Total Sampah:", 20, 155);
            lblTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            System.Windows.Forms.Label lblStatusLabel = CreateLabel("Status:", 20, 195);

            // Inputs Configuration
            ConfigureInput(this.txtWilayah, 180, 20);
            ConfigureNumeric(this.numOrganik, 180, 65);
            ConfigureNumeric(this.numAnorganik, 180, 110);

            this.lblTotal.Location = new System.Drawing.Point(180, 155);
            this.lblTotal.Size = new System.Drawing.Size(220, 30);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblTotal.Text = "0 Ton";

            this.cmbStatus.Location = new System.Drawing.Point(180, 195);
            this.cmbStatus.Size = new System.Drawing.Size(220, 30);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "✅ Sangat Baik", "✅ Baik", "✅ Normal", "⚠️ Perlu Perhatian", "⚠️ Waspada" });

            pnlMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblWilayah, this.txtWilayah, lblOrganik, this.numOrganik,
                lblAnorganik, this.numAnorganik, lblTotalLabel, this.lblTotal,
                lblStatusLabel, this.cmbStatus
            });

            // 
            // Buttons
            // 
            this.btnSave.Text = "💾 Simpan";
            this.btnSave.Location = new System.Drawing.Point(240, 365);
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;

            this.btnCancel.Text = "❌ Batal";
            this.btnCancel.Location = new System.Drawing.Point(350, 365);
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;

            // 
            // Form Setup
            // 
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { pnlHeader, pnlMain, this.btnSave, this.btnCancel });
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Data Sampah";

            ((System.ComponentModel.ISupportInitialize)(this.numOrganik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnorganik)).EndInit();
            this.ResumeLayout(false);
        }

        // Helper methods for cleaner design code
        private System.Windows.Forms.Label CreateLabel(string text, int x, int y)
        {
            return new System.Windows.Forms.Label { Text = text, Location = new System.Drawing.Point(x, y), Size = new System.Drawing.Size(155, 25), Font = new System.Drawing.Font("Segoe UI", 10F) };
        }

        private void ConfigureInput(System.Windows.Forms.Control ctrl, int x, int y)
        {
            ctrl.Location = new System.Drawing.Point(x, y);
            ctrl.Size = new System.Drawing.Size(220, 30);
            ctrl.Font = new System.Drawing.Font("Segoe UI", 10F);
        }

        private void ConfigureNumeric(System.Windows.Forms.NumericUpDown num, int x, int y)
        {
            ConfigureInput(num, x, y);
            num.Maximum = 10000;
        }
    }
}