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
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. SETUP DATABASE
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex) { MessageBox.Show("Error DB: " + ex.Message); }

            // 2. BANGUN TAMPILAN (Hanya dipanggil sekali di Constructor)
            BuatTampilanDashboard();

            // 3. EVENT TOMBOL
            PasangEventTombol();

            // 4. LOAD DATA
            LoadStatistik();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

            if (teks.Contains("dashboard"))
            {
                LoadStatistik();
                MessageBox.Show("Data diperbarui!");
            }
            else if (teks.Contains("sampah") || teks.Contains("input"))
            {
                // Menggunakan ShowDialog agar user fokus ke satu form
                using (CRUDSampah frm = new CRUDSampah())
                {
                    frm.ShowDialog();
                }
                LoadStatistik(); // Refresh angka setelah form ditutup
            }
            else if (teks.Contains("wastebot") || teks.Contains("ai"))
            {
                using (JabarWasteAI frm = new JabarWasteAI())
                {
                    frm.ShowDialog();
                }
            }
            else if (teks.Contains("laporan") || teks.Contains("pdf"))
            {
                EksporKePDF();
            }
            else if (teks.Contains("keluar"))
            {
                this.Close();
            }
        }

        private void BuatTampilanDashboard()
        {
            // CEK: Jika sudah ada panel statistik, jangan buat lagi (Cegah Double)
            if (this.Controls.ContainsKey("pnlStatistikContainer")) return;

            // Kita buat panel transparan sebagai wadah agar mudah dikelola
            Panel container = new Panel();
            container.Name = "pnlStatistikContainer";
            container.Dock = DockStyle.Fill;
            container.BackColor = Color.Transparent;
            this.Controls.Add(container);
            container.SendToBack(); // Supaya tidak menutupi sidebar

            int startX = 280;
            int startY = 100;

            // KARTU 1 (Hijau)
            Panel p1 = BuatPanel(container, startX, startY, Color.SeaGreen);
            BuatLabelJudul(p1, "Total Sampah");
            lblTotalBerat = BuatLabelAngka(p1, "0 Kg");

            // KARTU 2 (Biru)
            Panel p2 = BuatPanel(container, startX + 280, startY, Color.RoyalBlue);
            BuatLabelJudul(p2, "Total Transaksi");
            lblTotalData = BuatLabelAngka(p2, "0 Data");
        }

        // Helper Panel diperbaiki agar masuk ke parent tertentu
        private Panel BuatPanel(Control parent, int x, int y, Color c)
        {
            Panel p = new Panel
            {
                Size = new Size(260, 150),
                Location = new Point(x, y),
                BackColor = c
            };
            parent.Controls.Add(p);
            p.BringToFront();
            return p;
        }

        private void BuatLabelJudul(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 12), Location = new Point(20, 20), AutoSize = true };
            p.Controls.Add(l);
        }

        private Label BuatLabelAngka(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 22, FontStyle.Bold), Location = new Point(20, 55), AutoSize = true };
            p.Controls.Add(l); return l;
        }

        private void PasangEventTombol()
        {
            // Cari Sidebar (Panel yang Dock Left)
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Dock == DockStyle.Left)
                {
                    foreach (Control b in c.Controls)
                    {
                        if (b is Button btn)
                        {
                            // Lepas event lama dulu (jika ada) baru pasang yang baru
                            btn.Click -= Menu_Click;
                            btn.Click += Menu_Click;
                        }
                    }
                }
            }
        }

        private void LoadStatistik()
        {
            if (_collection == null) return;
            try
            {
                var data = _collection.Find(new BsonDocument()).ToList();
                lblTotalData.Text = data.Count + " Data";
                lblTotalBerat.Text = data.Sum(x => x.Berat).ToString("N2") + " Kg";
            }
            catch { /* Silent error */ }
        }

        private void EksporKePDF()
        {
            List<SampahModel> dataList = _collection.Find(new BsonDocument()).ToList();
            if (dataList.Count == 0) { MessageBox.Show("Tidak ada data."); return; }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF File|*.pdf", FileName = "Laporan_Jabar_" + DateTime.Now.ToString("yyyyMMdd") };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfService pdfService = new PdfService();
                    pdfService.ExportLaporanSampah(sfd.FileName, dataList);
                    MessageBox.Show("Sukses simpan PDF!");
                }
                catch (Exception ex) { MessageBox.Show("Gagal: " + ex.Message); }
            }
        }
    }
}