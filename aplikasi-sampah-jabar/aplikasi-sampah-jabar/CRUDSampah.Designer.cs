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
            lblHeader = new System.Windows.Forms.Label();
            pnlInput = new System.Windows.Forms.Panel();

            // Tombol
            btnClear = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            btnSimpan = new System.Windows.Forms.Button();

            // Wilayah
            txtWilayah = new System.Windows.Forms.TextBox();
            lblWilayah = new System.Windows.Forms.Label();

            // Volume
            txtVolume = new System.Windows.Forms.TextBox();
            lblVolume = new System.Windows.Forms.Label();

            // Berat (Ubah dari NumericUpDown jadi TextBox biar fleksibel)
            txtBerat = new System.Windows.Forms.TextBox();
            lblBerat = new System.Windows.Forms.Label();

            // Jenis
            cmbJenis = new System.Windows.Forms.ComboBox();
            lblJenis = new System.Windows.Forms.Label();

            // Nama
            txtNama = new System.Windows.Forms.TextBox();
            lblNama = new System.Windows.Forms.Label();

            // Tabel
            dgvData = new System.Windows.Forms.DataGridView();

            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();

            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.Location = new System.Drawing.Point(30, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(327, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Manajemen Sampah";

            // 
            // pnlInput
            // 
            pnlInput.BackColor = System.Drawing.Color.White;
            pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Masukkan semua kontrol ke panel
            pnlInput.Controls.Add(btnClear);
            pnlInput.Controls.Add(btnHapus);
            pnlInput.Controls.Add(btnSimpan);
            pnlInput.Controls.Add(txtWilayah);
            pnlInput.Controls.Add(lblWilayah);
            pnlInput.Controls.Add(txtVolume);
            pnlInput.Controls.Add(lblVolume);
            pnlInput.Controls.Add(txtBerat);
            pnlInput.Controls.Add(lblBerat);
            pnlInput.Controls.Add(cmbJenis);
            pnlInput.Controls.Add(lblJenis);
            pnlInput.Controls.Add(txtNama);
            pnlInput.Controls.Add(lblNama);

            pnlInput.Location = new System.Drawing.Point(30, 75);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new System.Drawing.Size(300, 560); // Diperpanjang biar muat
            pnlInput.TabIndex = 1;

            // --- LAYOUT FORM INPUT ---

            // 1. Nama
            lblNama.Location = new System.Drawing.Point(20, 20);
            lblNama.Text = "Nama Sampah";
            lblNama.Size = new System.Drawing.Size(200, 23);

            txtNama.Location = new System.Drawing.Point(23, 45);
            txtNama.Size = new System.Drawing.Size(250, 31);

            // 2. Jenis
            lblJenis.Location = new System.Drawing.Point(20, 85);
            lblJenis.Text = "Jenis Sampah";
            lblJenis.Size = new System.Drawing.Size(200, 23);

            cmbJenis.Location = new System.Drawing.Point(23, 110);
            cmbJenis.Size = new System.Drawing.Size(250, 33);
            cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbJenis.Items.AddRange(new object[] { "Organik", "Anorganik" }); // Sesuaikan dgn Backend

            // 3. Berat
            lblBerat.Location = new System.Drawing.Point(20, 150);
            lblBerat.Text = "Berat (Kg)";
            lblBerat.Size = new System.Drawing.Size(200, 23);

            txtBerat.Location = new System.Drawing.Point(23, 175);
            txtBerat.Size = new System.Drawing.Size(250, 31);
            txtBerat.Name = "txtBerat"; // Nama variabel penting!

            // 4. Volume (BARU)
            lblVolume.Location = new System.Drawing.Point(20, 215);
            lblVolume.Text = "Volume (m3)";
            lblVolume.Size = new System.Drawing.Size(200, 23);

            txtVolume.Location = new System.Drawing.Point(23, 240);
            txtVolume.Size = new System.Drawing.Size(250, 31);
            txtVolume.Name = "txtVolume";

            // 5. Wilayah (BARU)
            lblWilayah.Location = new System.Drawing.Point(20, 280);
            lblWilayah.Text = "Nama Wilayah";
            lblWilayah.Size = new System.Drawing.Size(200, 23);

            txtWilayah.Location = new System.Drawing.Point(23, 305);
            txtWilayah.Size = new System.Drawing.Size(250, 31);
            txtWilayah.Name = "txtWilayah";

            // --- TOMBOL ---

            // Simpan
            btnSimpan.Text = "Simpan Data";
            btnSimpan.BackColor = System.Drawing.Color.SeaGreen;
            btnSimpan.ForeColor = System.Drawing.Color.White;
            btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSimpan.Location = new System.Drawing.Point(23, 360);
            btnSimpan.Size = new System.Drawing.Size(250, 40);
            btnSimpan.Name = "btnSimpan";

            // Hapus
            btnHapus.Text = "Hapus Data";
            btnHapus.BackColor = System.Drawing.Color.IndianRed;
            btnHapus.ForeColor = System.Drawing.Color.White;
            btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHapus.Location = new System.Drawing.Point(23, 410);
            btnHapus.Size = new System.Drawing.Size(250, 40);
            btnHapus.Name = "btnHapus";

            // Clear (BARU)
            btnClear.Text = "Reset Form";
            btnClear.BackColor = System.Drawing.Color.Gray;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Location = new System.Drawing.Point(23, 460);
            btnClear.Size = new System.Drawing.Size(250, 40);
            btnClear.Name = "btnClear";

            // 
            // dgvData
            // 
            dgvData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvData.ColumnHeadersHeight = 34;
            dgvData.Location = new System.Drawing.Point(350, 75);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new System.Drawing.Size(600, 560);
            dgvData.TabIndex = 2;
            dgvData.ReadOnly = true; // Biar user gak edit langsung di tabel
            dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 
            // CRUDSampah (FORM SETTINGS)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 660); // Ukuran Form
            this.Controls.Add(dgvData);
            this.Controls.Add(pnlInput);
            this.Controls.Add(lblHeader);
            this.Name = "CRUDSampah";
            this.Text = "Manajemen Data Sampah";

            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Variabel harus publik/private di sini agar dikenali di CRUDSampah.cs
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlInput;

        public System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;

        public System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblJenis;

        // Ganti NumericUpDown jadi TextBox
        public System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label lblBerat;

        // Tambahan Baru
        public System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;

        public System.Windows.Forms.TextBox txtWilayah;
        private System.Windows.Forms.Label lblWilayah;

        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnClear;

        public System.Windows.Forms.DataGridView dgvData;
    }
}