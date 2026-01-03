namespace aplikasi_sampah_jabar
{
    partial class CRUDSampah
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblHeader = new Label();
            pnlInput = new Panel();
            btnHapus = new Button();
            btnSimpan = new Button();
            numBerat = new NumericUpDown();
            lblBerat = new Label();
            cmbJenis = new ComboBox();
            lblJenis = new Label();
            txtNama = new TextBox();
            lblNama = new Label();
            dgvData = new DataGridView();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBerat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.Location = new Point(30, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(327, 45);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "CRUD Sampah Jabar";
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(btnHapus);
            pnlInput.Controls.Add(btnSimpan);
            pnlInput.Controls.Add(numBerat);
            pnlInput.Controls.Add(lblBerat);
            pnlInput.Controls.Add(cmbJenis);
            pnlInput.Controls.Add(lblJenis);
            pnlInput.Controls.Add(txtNama);
            pnlInput.Controls.Add(lblNama);
            pnlInput.Location = new Point(30, 75);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(300, 480);
            pnlInput.TabIndex = 1;
            // 
            // btnHapus
            // 
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.Red;
            btnHapus.Location = new Point(23, 300);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(250, 40);
            btnHapus.TabIndex = 0;
            btnHapus.Text = "Hapus Terpilih";
            btnHapus.Click += btnHapus_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(245, 158, 11);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(23, 250);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(250, 40);
            btnSimpan.TabIndex = 1;
            btnSimpan.Text = "Simpan Data";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // numBerat
            // 
            numBerat.Location = new Point(23, 185);
            numBerat.Name = "numBerat";
            numBerat.Size = new Size(250, 31);
            numBerat.TabIndex = 2;
            // 
            // lblBerat
            // 
            lblBerat.Location = new Point(20, 160);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(100, 23);
            lblBerat.TabIndex = 3;
            lblBerat.Text = "Berat (Kg)";
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Items.AddRange(new object[] { "Plastik", "Kertas", "Logam", "Organik" });
            cmbJenis.Location = new Point(23, 115);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(250, 33);
            cmbJenis.TabIndex = 4;
            // 
            // lblJenis
            // 
            lblJenis.Location = new Point(20, 90);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(100, 23);
            lblJenis.TabIndex = 5;
            lblJenis.Text = "Jenis Sampah";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(23, 45);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 31);
            txtNama.TabIndex = 6;
            // 
            // lblNama
            // 
            lblNama.Location = new Point(20, 20);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(100, 23);
            lblNama.TabIndex = 7;
            lblNama.Text = "Nama Sampah";
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = Color.White;
            dgvData.ColumnHeadersHeight = 34;
            dgvData.Location = new Point(350, 75);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(550, 480);
            dgvData.TabIndex = 0;
            // 
            // CRUDSampah
            // 
            Controls.Add(dgvData);
            Controls.Add(pnlInput);
            Controls.Add(lblHeader);
            Name = "CRUDSampah";
            Size = new Size(940, 600);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBerat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.NumericUpDown numBerat;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvData;
    }
}