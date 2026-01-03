using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace aplikasi_sampah_jabar
{
    public partial class Dashboard : Form
    {
        private Label lblTotalBerat;
        private Label lblTotalData;
        private IMongoCollection<SampahModel> _collection;

        public Dashboard()
        {
            InitializeComponent();

            // 1. SETUP DATABASE
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex) { MessageBox.Show("Error DB: " + ex.Message); }

            // 2. TAMPILKAN STATISTIK DI AWAL (Masuk ke pnlMain)
            TampilkanStatistikUtama();

            // Note: Event tombol sudah dipasang di Designer (this.Menu_Click)
            // Jadi kita tinggal isi logika di fungsi Menu_Click saja.
        }

        // --- FUNGSI NAVIGASI: Memasukkan Form ke dalam pnlMain ---
        private void BukaHalaman(Form frmAnak)
        {
            // Bersihkan isi pnlMain
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.Clear();

            // Pengaturan Form Anak
            frmAnak.TopLevel = false;
            frmAnak.FormBorderStyle = FormBorderStyle.None;
            frmAnak.Dock = DockStyle.Fill;

            // Tambahkan ke pnlMain
            this.pnlMain.Controls.Add(frmAnak);
            this.pnlMain.Tag = frmAnak;
            frmAnak.Show();
        }

        private void TampilkanStatistikUtama()
        {
            this.pnlMain.Controls.Clear();
            this.lblTitle.Text = "Dashboard Overview";

            // Buat Kartu Statistik secara Coding
            int startX = 40;
            int startY = 40;

            // KARTU 1 (Hijau)
            Panel p1 = BuatPanelStatistik(this.pnlMain, startX, startY, Color.SeaGreen);
            BuatLabelInfo(p1, "Total Sampah Terkumpul");
            lblTotalBerat = BuatLabelNilai(p1, "0 Kg");

            // KARTU 2 (Biru)
            Panel p2 = BuatPanelStatistik(this.pnlMain, startX + 300, startY, Color.RoyalBlue);
            BuatLabelInfo(p2, "Jumlah Transaksi");
            lblTotalData = BuatLabelNilai(p2, "0 Data");

            LoadStatistik();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

            // Reset warna semua tombol (opsional agar user tahu tombol mana yang aktif)
            foreach (Control c in pnlSidebar.Controls)
            {
                if (c is Button) c.ForeColor = Color.Gray;
            }
            btn.ForeColor = Color.FromArgb(245, 158, 11); // Warna aktif (Oranye)

            // Logika Navigasi
            if (teks.Contains("dashboard"))
            {
                TampilkanStatistikUtama();
            }
            else if (teks.Contains("manajemen") || teks.Contains("sampah"))
            {
                this.lblTitle.Text = "Manajemen Data Sampah";
                BukaHalaman(new CRUDSampah());
            }
            else if (teks.Contains("wastebot") || teks.Contains("ai"))
            {
                this.lblTitle.Text = "Jabar Waste AI Assistant";
                BukaHalaman(new JabarWasteAI());
            }
            else if (teks.Contains("laporan") || teks.Contains("pdf"))
            {
                EksporKePDF();
            }
        }

        private void LoadStatistik()
        {
            if (_collection == null) return;
            try
            {
                var data = _collection.Find(new BsonDocument()).ToList();
                if (lblTotalData != null) lblTotalData.Text = data.Count + " Data";
                if (lblTotalBerat != null) lblTotalBerat.Text = data.Sum(x => x.Berat).ToString("N2") + " Kg";
            }
            catch { }
        }

        private void EksporKePDF()
        {
            List<SampahModel> dataList = _collection.Find(new BsonDocument()).ToList();
            if (dataList.Count == 0) { MessageBox.Show("Data kosong!"); return; }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF File|*.pdf", FileName = "Laporan_" + DateTime.Now.ToString("yyyyMMdd") };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfService pdfService = new PdfService();
                    pdfService.ExportLaporanSampah(sfd.FileName, dataList);
                    MessageBox.Show("PDF Berhasil Disimpan!");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        #region UI Helpers
        private Panel BuatPanelStatistik(Control parent, int x, int y, Color c)
        {
            Panel p = new Panel { Size = new Size(260, 150), Location = new Point(x, y), BackColor = c };
            parent.Controls.Add(p);
            return p;
        }

        private void BuatLabelInfo(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 11), Location = new Point(20, 20), AutoSize = true };
            p.Controls.Add(l);
        }

        private Label BuatLabelNilai(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 24, FontStyle.Bold), Location = new Point(20, 55), AutoSize = true };
            p.Controls.Add(l);
            return l;
        }
        #endregion
    }
}