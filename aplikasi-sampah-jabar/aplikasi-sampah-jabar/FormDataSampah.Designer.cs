namespace aplikasi_sampah_jabar
{
    partial class FormDataSampah
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSideInput = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.txtKet = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.pnlSideInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();

            // Panel Input (Tema Gelap sesuai Sidebar)
            this.pnlSideInput.BackColor = System.Drawing.Color.FromArgb(15, 25, 35);
            this.pnlSideInput.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lbl1, this.txtNama, this.lbl2, this.cmbJenis,
                this.lbl3, this.txtBerat, this.lbl4, this.txtKet, this.btnSimpan, this.btnHapus
            });
            this.pnlSideInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideInput.Size = new System.Drawing.Size(320, 600);

            // Styling Judul & Label
            this.lblTitle.Text = "MANAJEMEN DATA";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 14F);
            this.lblTitle.Location = new System.Drawing.Point(25, 30);
            this.lblTitle.Size = new System.Drawing.Size(270, 40);

            this.lbl1.Text = "Nama Sampah"; this.lbl1.ForeColor = System.Drawing.Color.LightGray; this.lbl1.Location = new System.Drawing.Point(25, 80);
            this.txtNama.Location = new System.Drawing.Point(25, 105); this.txtNama.Size = new System.Drawing.Size(260, 25);

            this.lbl2.Text = "Jenis Sampah"; this.lbl2.ForeColor = System.Drawing.Color.LightGray; this.lbl2.Location = new System.Drawing.Point(25, 150);
            this.cmbJenis.Location = new System.Drawing.Point(25, 175); this.cmbJenis.Size = new System.Drawing.Size(260, 25);
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lbl3.Text = "Berat (Kg)"; this.lbl3.ForeColor = System.Drawing.Color.LightGray; this.lbl3.Location = new System.Drawing.Point(25, 220);
            this.txtBerat.Location = new System.Drawing.Point(25, 245); this.txtBerat.Size = new System.Drawing.Size(260, 25);

            this.lbl4.Text = "Tentang Sampah (Ket)"; this.lbl4.ForeColor = System.Drawing.Color.LightGray; this.lbl4.Location = new System.Drawing.Point(25, 290);
            this.txtKet.Location = new System.Drawing.Point(25, 315); this.txtKet.Size = new System.Drawing.Size(260, 80);

            // Tombol Simpan (Fleksibel: Tambah/Update)
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Text = "SIMPAN DATA";
            this.btnSimpan.Location = new System.Drawing.Point(25, 420);
            this.btnSimpan.Size = new System.Drawing.Size(260, 40);

            // Tombol Hapus
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Text = "HAPUS DATA";
            this.btnHapus.Location = new System.Drawing.Point(25, 470);
            this.btnHapus.Size = new System.Drawing.Size(260, 40);

            // DataGridView (Sisi Kanan)
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.Location = new System.Drawing.Point(320, 0);

            // Form Setup
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlSideInput);
            this.Text = "Manajemen Sampah Terintegrasi";
            this.pnlSideInput.ResumeLayout(false);
            this.pnlSideInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSideInput;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtNama, txtBerat;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.RichTextBox txtKet;
        private System.Windows.Forms.Button btnSimpan, btnHapus;
        private System.Windows.Forms.Label lblTitle, lbl1, lbl2, lbl3, lbl4;
    }
}