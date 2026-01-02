namespace aplikasi_sampah_jabar
{
    partial class LaporanJabar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpUtama = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblStatusLoading = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.tlpKontenCard = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeaderSmall = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.tlpUtama.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            this.tlpKontenCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();

            // 
            // tlpUtama (Grid Luar agar Card selalu di Tengah)
            // 
            this.tlpUtama.ColumnCount = 3;
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tlpUtama.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.Controls.Add(this.pnlCard, 1, 1);
            this.tlpUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUtama.Location = new System.Drawing.Point(0, 0);
            this.tlpUtama.RowCount = 3;
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tlpUtama.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUtama.Size = new System.Drawing.Size(940, 700);

            // 
            // pnlCard (Kartu Putih)
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.pnlLoading);
            this.pnlCard.Controls.Add(this.tlpKontenCard);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // pnlLoading (Panel Overlay saat download)
            // 
            this.pnlLoading.Controls.Add(this.lblStatusLoading);
            this.pnlLoading.Controls.Add(this.pbLoading);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(498, 548);
            this.pnlLoading.Visible = false;

            // lblStatusLoading
            this.lblStatusLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusLoading.Location = new System.Drawing.Point(50, 280);
            this.lblStatusLoading.Size = new System.Drawing.Size(400, 30);
            this.lblStatusLoading.Text = "Menyiapkan Laporan PDF...";
            this.lblStatusLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pbLoading
            this.pbLoading.Location = new System.Drawing.Point(100, 240);
            this.pbLoading.Size = new System.Drawing.Size(300, 23);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;

            // 
            // tlpKontenCard (Isi Konten Card)
            // 
            this.tlpKontenCard.ColumnCount = 1;
            this.tlpKontenCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKontenCard.Controls.Add(this.lblHeaderSmall, 0, 0);
            this.tlpKontenCard.Controls.Add(this.picIcon, 0, 1);
            this.tlpKontenCard.Controls.Add(this.lblJudul, 0, 2);
            this.tlpKontenCard.Controls.Add(this.lblDeskripsi, 0, 3);
            this.tlpKontenCard.Controls.Add(this.btnDownload, 0, 4);
            this.tlpKontenCard.Controls.Add(this.btnPreview, 0, 5);
            this.tlpKontenCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKontenCard.Padding = new System.Windows.Forms.Padding(20);

            // lblHeaderSmall
            this.lblHeaderSmall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSmall.ForeColor = System.Drawing.Color.Gray;
            this.lblHeaderSmall.Text = "Kelola Laporan Sistem";
            this.lblHeaderSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // picIcon
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIcon.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.picIcon.Size = new System.Drawing.Size(120, 120);
            this.picIcon.BorderStyle = BorderStyle.None;
            // Tips: Anda bisa memasukkan gambar PDF lewat Properties picIcon di Designer

            // lblJudul
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Text = "Siap untuk Laporan Anda?";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJudul.Size = new System.Drawing.Size(400, 40);

            // lblDeskripsi
            this.lblDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeskripsi.Text = "Dengan sekali klik, semua data sampah akan terintegrasi menjadi laporan PDF yang rapi.";
            this.lblDeskripsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeskripsi.Size = new System.Drawing.Size(400, 60);

            // btnDownload
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Size = new System.Drawing.Size(300, 45);
            this.btnDownload.Text = "Unduh Laporan PDF";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);

            // btnPreview
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnPreview.Size = new System.Drawing.Size(300, 45);
            this.btnPreview.Text = "Lihat Preview Data";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);

            // LaporanJabar Main Settings
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Controls.Add(this.tlpUtama);
            this.Name = "LaporanJabar";
            this.Size = new System.Drawing.Size(940, 700);
            this.tlpUtama.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlLoading.ResumeLayout(false);
            this.tlpKontenCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpUtama;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TableLayoutPanel tlpKontenCard;
        private System.Windows.Forms.Label lblHeaderSmall;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label lblStatusLoading;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}