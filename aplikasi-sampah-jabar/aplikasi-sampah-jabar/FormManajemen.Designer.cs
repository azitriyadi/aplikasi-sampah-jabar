namespace aplikasi_sampah_jabar
{
    partial class FormManajemen
    {
        private System.ComponentModel.IContainer components = null;
        // Definisi Kontrol
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.RichTextBox txtKet;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4, lblTitle;

        private void InitializeComponent()
        {
            this.pnlInput = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.txtKet = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();

            // Desain Panel Samping (Dark Slate)
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Width = 320;
            this.pnlInput.Padding = new System.Windows.Forms.Padding(20);

            // Title
            this.lblTitle.Text = "ENTRY DATA SAMPAH";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI Bold", 14F);
            this.lblTitle.Location = new Point(20, 30);
            this.lblTitle.Size = new Size(280, 40);

            // Nama Sampah
            this.lbl1.Text = "Nama Sampah";
            this.lbl1.ForeColor = Color.LightGray;
            this.lbl1.Location = new Point(20, 80);
            this.txtNama.Location = new Point(20, 105);
            this.txtNama.Width = 260;

            // Jenis Sampah
            this.lbl2.Text = "Jenis Sampah";
            this.lbl2.ForeColor = Color.LightGray;
            this.lbl2.Location = new Point(20, 150);
            this.cmbJenis.Location = new Point(20, 175);
            this.cmbJenis.Width = 260;
            this.cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;

            // Berat
            this.lbl3.Text = "Berat (Kg)";
            this.lbl3.ForeColor = Color.LightGray;
            this.lbl3.Location = new Point(20, 220);
            this.txtBerat.Location = new Point(20, 245);
            this.txtBerat.Width = 260;

            // Keterangan
            this.lbl4.Text = "Tentang Sampah (Ket)";
            this.lbl4.ForeColor = Color.LightGray;
            this.lbl4.Location = new Point(20, 290);
            this.txtKet.Location = new Point(20, 315);
            this.txtKet.Size = new Size(260, 80);

            // Tombol Simpan (Green)
            this.btnSimpan.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSimpan.FlatStyle = FlatStyle.Flat;
            this.btnSimpan.ForeColor = Color.White;
            this.btnSimpan.Text = "SIMPAN DATA";
            this.btnSimpan.Location = new Point(20, 420);
            this.btnSimpan.Size = new Size(260, 45);
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            // Tombol Hapus (Red)
            this.btnHapus.BackColor = Color.FromArgb(231, 76, 60);
            this.btnHapus.FlatStyle = FlatStyle.Flat;
            this.btnHapus.ForeColor = Color.White;
            this.btnHapus.Text = "HAPUS DATA";
            this.btnHapus.Location = new Point(20, 475);
            this.btnHapus.Size = new Size(260, 45);
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // Grid (Sisi Kanan)
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.BorderStyle = BorderStyle.None;
            this.dgvData.BackgroundColor = Color.White;

            // Form Setup
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlInput);
            this.pnlInput.Controls.AddRange(new Control[] { lblTitle, lbl1, txtNama, lbl2, cmbJenis, lbl3, txtBerat, lbl4, txtKet, btnSimpan, btnHapus });
        }
    }
}