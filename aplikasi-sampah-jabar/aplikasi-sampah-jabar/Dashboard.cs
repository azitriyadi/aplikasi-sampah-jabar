using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace aplikasi_sampah_jabar
{
    public partial class Dashboard : Form
    {
        // Variabel UI untuk Label Statistik
        private Label lblTotalBerat;
        private Label lblTotalData;
        private Label lblDominan;

        // Variabel Database
        private IMongoCollection<SampahModel> _collection;

        public Dashboard()
        {
            InitializeComponent();
            this.Text = "Sistem Manajemen Sampah Jabar - Dashboard Utama";

            // 1. SETUP DATABASE
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Database Gagal: " + ex.Message);
            }

            // 2. BANGUN TAMPILAN (Kartu Statistik)
            BuatTampilanDashboard();

            // 3. AUTO-CONNECT TOMBOL SIDEBAR
            PasangEventTombol();

            // 4. LOAD DATA AWAL
            LoadStatistik();
        }

        #region Logika Tampilan & Statistik

        private void BuatTampilanDashboard()
        {
            int startX = 260;
            int startY = 100;
            int gap = 20;

            // KARTU 1 (Hijau) - Total Berat
            Panel pnlBerat = BuatPanel(startX, startY, Color.SeaGreen);
            BuatLabelJudul(pnlBerat, "Total Sampah (Kg)");
            lblTotalBerat = BuatLabelAngka(pnlBerat, "0 Kg");

            // KARTU 2 (Biru) - Total Transaksi
            Panel pnlData = BuatPanel(startX + 260 + gap, startY, Color.RoyalBlue);
            BuatLabelJudul(pnlData, "Total Transaksi");
            lblTotalData = BuatLabelAngka(pnlData, "0 Data");

            // KARTU 3 (Oranye) - Jenis Dominan
            Panel pnlDominan = BuatPanel(startX + (260 + gap) * 2, startY, Color.DarkOrange);
            BuatLabelJudul(pnlDominan, "Jenis Terbanyak");
            lblDominan = BuatLabelAngka(pnlDominan, "-");
        }

        private Panel BuatPanel(int x, int y, Color warna)
        {
            Panel p = new Panel();
            p.Size = new Size(260, 150);
            p.Location = new Point(x, y);
            p.BackColor = warna;
            this.Controls.Add(p);
            p.BringToFront();
            return p;
        }

        private void BuatLabelJudul(Panel parent, string teks)
        {
            Label l = new Label();
            l.Text = teks;
            l.ForeColor = Color.White;
            l.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Regular);
            l.Location = new Point(20, 20);
            l.AutoSize = true;
            parent.Controls.Add(l);
        }

        private Label BuatLabelAngka(Panel parent, string teksAwal)
        {
            Label l = new Label();
            l.Text = teksAwal;
            l.ForeColor = Color.White;
            l.Font = new System.Drawing.Font("Segoe UI", 24, FontStyle.Bold);
            l.Location = new Point(20, 55);
            l.AutoSize = true;
            parent.Controls.Add(l);
            return l;
        }

        private void LoadStatistik()
        {
            if (_collection == null) return;
            try
            {
                long totalData = _collection.CountDocuments(new BsonDocument());
                var semuaData = _collection.Find(new BsonDocument()).ToList();
                double totalBerat = semuaData.Sum(x => x.Berat);

                var organik = semuaData.Count(x => x.Jenis == "Organik");
                var anorganik = semuaData.Count(x => x.Jenis == "Anorganik");
                string dominan = "-";
                if (organik > anorganik) dominan = "Organik";
                else if (anorganik > organik) dominan = "Anorganik";
                else if (totalData > 0) dominan = "Seimbang";

                if (lblTotalData != null) lblTotalData.Text = totalData + " Transaksi";
                if (lblTotalBerat != null) lblTotalBerat.Text = totalBerat.ToString("N2") + " Kg";
                if (lblDominan != null) lblDominan.Text = dominan;
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.Message); }
        }

        #endregion

        #region Navigasi & Cetak PDF

        private void PasangEventTombol()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel && ctrl.Dock == DockStyle.Left)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        if (child is Button btn) btn.Click += Menu_Click;
                    }
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

            if (teks.Contains("dashboard"))
            {
                LoadStatistik();
                MessageBox.Show("Data diperbarui!", "Info");
            }
            else if (teks.Contains("sampah") || teks.Contains("input"))
            {
                new CRUDSampah().ShowDialog();
                LoadStatistik(); // Refresh setelah input
            }
            else if (teks.Contains("wastebot") || teks.Contains("ai"))
            {
                new JabarWasteAI().Show();
            }
            else if (teks.Contains("laporan") || teks.Contains("pdf"))
            {
                CetakLaporanPDF();
            }
            else if (teks.Contains("keluar"))
            {
                if (MessageBox.Show("Keluar?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new LoginForm().Show();
                    this.Close();
                }
            }
        }

        private void CetakLaporanPDF()
        {
            if (_collection == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Laporan_Sampah_Jabar_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = _collection.Find(new BsonDocument()).ToList();

                    Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Header
                    var fontJudul = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    Paragraph judul = new Paragraph("LAPORAN PENGELOLAAN SAMPAH JABAR\n", fontJudul);
                    judul.Alignment = Element.ALIGN_CENTER;
                    doc.Add(judul);
                    doc.Add(new Paragraph("Tanggal Cetak: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm") + "\n\n"));

                    // Tabel
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 25f, 25f, 15f, 20f, 15f });

                    string[] headers = { "Tanggal", "Nama Sampah", "Jenis", "Wilayah", "Berat" };
                    foreach (var h in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(h, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    double totalKeseluruhan = 0;
                    foreach (var item in data)
                    {
                        table.AddCell(new Phrase(item.TanggalInput.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                        table.AddCell(new Phrase(item.Nama ?? "-", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                        table.AddCell(new Phrase(item.Jenis ?? "-", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                        table.AddCell(new Phrase(item.NamaWilayah ?? "-", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                        table.AddCell(new Phrase(item.Berat.ToString() + " Kg", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                        totalKeseluruhan += item.Berat;
                    }

                    doc.Add(table);
                    doc.Add(new Paragraph("\nTotal Berat Seluruhnya: " + totalKeseluruhan.ToString("N2") + " Kg", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));

                    doc.Close();
                    MessageBox.Show("Laporan Berhasil Disimpan!", "Sukses");
                }
                catch (Exception ex) { MessageBox.Show("Gagal: " + ex.Message); }
            }
        }

        #endregion
    }
}