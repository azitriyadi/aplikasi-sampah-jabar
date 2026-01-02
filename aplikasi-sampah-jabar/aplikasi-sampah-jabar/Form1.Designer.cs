namespace aplikasi_sampah_jabar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTambah_Click = new Button();
            btnUpdate_Click = new Button();
            btnHapus_Click = new Button();
            dgvsSampah = new DataGridView();
            txtNama = new TextBox();
            txtJenis = new TextBox();
            txtBerat = new TextBox();
            label1 = new Label();
            Jenis = new Label();
            label2 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvsSampah).BeginInit();
            SuspendLayout();
            // 
            // btnTambah_Click
            // 
            btnTambah_Click.Location = new Point(78, 290);
            btnTambah_Click.Name = "btnTambah_Click";
            btnTambah_Click.Size = new Size(112, 34);
            btnTambah_Click.TabIndex = 0;
            btnTambah_Click.Text = "Tambah";
            btnTambah_Click.UseVisualStyleBackColor = true;
            btnTambah_Click.Click += btnTambah_Click_Click;
            // 
            // btnUpdate_Click
            // 
            btnUpdate_Click.Location = new Point(196, 290);
            btnUpdate_Click.Name = "btnUpdate_Click";
            btnUpdate_Click.Size = new Size(112, 34);
            btnUpdate_Click.TabIndex = 1;
            btnUpdate_Click.Text = "Update";
            btnUpdate_Click.UseVisualStyleBackColor = true;
            btnUpdate_Click.Click += btnUpdate_Click_Click;
            // 
            // btnHapus_Click
            // 
            btnHapus_Click.Location = new Point(78, 330);
            btnHapus_Click.Name = "btnHapus_Click";
            btnHapus_Click.Size = new Size(230, 34);
            btnHapus_Click.TabIndex = 2;
            btnHapus_Click.Text = "Hapus";
            btnHapus_Click.UseVisualStyleBackColor = true;
            btnHapus_Click.Click += btnHapus_Click_Click;
            // 
            // dgvsSampah
            // 
            dgvsSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsSampah.Location = new Point(385, 12);
            dgvsSampah.Name = "dgvsSampah";
            dgvsSampah.RowHeadersWidth = 62;
            dgvsSampah.Size = new Size(403, 396);
            dgvsSampah.TabIndex = 3;
            dgvsSampah.CellClick += dgvsSampah_CellClick;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(51, 92);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(282, 31);
            txtNama.TabIndex = 4;
            // 
            // txtJenis
            // 
            txtJenis.Location = new Point(51, 154);
            txtJenis.Name = "txtJenis";
            txtJenis.Size = new Size(282, 31);
            txtJenis.TabIndex = 5;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(51, 216);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(282, 31);
            txtBerat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "Nama";
            // 
            // Jenis
            // 
            Jenis.AutoSize = true;
            Jenis.Location = new Point(51, 126);
            Jenis.Name = "Jenis";
            Jenis.Size = new Size(49, 25);
            Jenis.TabIndex = 8;
            Jenis.Text = "Jenis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 188);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 9;
            label2.Text = "Berat";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(76, 374);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(232, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(Jenis);
            Controls.Add(label1);
            Controls.Add(txtBerat);
            Controls.Add(txtJenis);
            Controls.Add(txtNama);
            Controls.Add(dgvsSampah);
            Controls.Add(btnHapus_Click);
            Controls.Add(btnUpdate_Click);
            Controls.Add(btnTambah_Click);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvsSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah_Click;
        private Button btnUpdate_Click;
        private Button btnHapus_Click;
        private DataGridView dgvsSampah;
        private TextBox txtNama;
        private TextBox txtJenis;
        private TextBox txtBerat;
        private Label label1;
        private Label Jenis;
        private Label label2;
        private Button btnClear;
    }
}
