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
        private Label lblDominan;
        private IMongoCollection<SampahModel> _collection;

        public Dashboard()
        {
            InitializeComponent();

            // Inisialisasi Database
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex) { MessageBox.Show("Error DB: " + ex.Message); }

            BuatTampilanDashboard();
            PasangEventTombol();
            LoadStatistik();
        }

        // --- FUNGSI NAVIGASI MENU ---
        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

            if (teks.Contains("dashboard"))
            {
                LoadStatistik();
                MessageBox.Show("Data di-refresh!");
            }
            else if (teks.Contains("sampah") || teks.Contains("input"))
            {
                new CRUDSampah().ShowDialog();
                LoadStatistik();
            }
            else if (teks.Contains("wastebot") || teks.Contains("ai"))
            {
                new JabarWasteAI().Show();
            }
            // --- LOGIKA PEMANGGILAN PDF SERVICE ---
            else if (teks.Contains("laporan") || teks.Contains("pdf"))
            {
                EksporKePDF();
            }
            else if (teks.Contains("keluar"))
            {
                this.Close();
            }
        }

        private void EksporKePDF()
        {
            // 1. Ambil data terbaru dari Atlas
            List<SampahModel> dataList = _collection.Find(new BsonDocument()).ToList();

            if (dataList.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dilaporkan.");
                return;
            }

            // 2. Munculkan Dialog Simpan File
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Laporan_Sampah_Jabar_" + DateTime.Now.ToString("yyyyMMdd");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Panggil Service PDF yang sudah kita buat
                    PdfService pdfService = new PdfService();
                    pdfService.ExportLaporanSampah(sfd.FileName, dataList);

                    MessageBox.Show("Laporan PDF berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal ekspor: " + ex.Message);
                }
            }
        }

        #region UI Helpers (Tetap Sama)
        private void BuatTampilanDashboard()
        {
            int startX = 260; int startY = 100;
            Panel p1 = BuatPanel(startX, startY, Color.SeaGreen);
            lblTotalBerat = BuatLabelAngka(p1, "0 Kg");
            Panel p2 = BuatPanel(startX + 280, startY, Color.RoyalBlue);
            lblTotalData = BuatLabelAngka(p2, "0 Data");
        }

        private Panel BuatPanel(int x, int y, Color c)
        {
            Panel p = new Panel { Size = new Size(260, 150), Location = new Point(x, y), BackColor = c };
            this.Controls.Add(p); p.BringToFront(); return p;
        }

        private Label BuatLabelAngka(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 22, FontStyle.Bold), Location = new Point(20, 50), AutoSize = true };
            p.Controls.Add(l); return l;
        }

        private void PasangEventTombol()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Dock == DockStyle.Left)
                {
                    foreach (Control b in c.Controls) { if (b is Button) b.Click += Menu_Click; }
                }
            }
        }

        private void LoadStatistik()
        {
            if (_collection == null) return;
            var data = _collection.Find(new BsonDocument()).ToList();
            lblTotalData.Text = data.Count + " Data";
            lblTotalBerat.Text = data.Sum(x => x.Berat).ToString("N2") + " Kg";
        }
        #endregion
    }
}