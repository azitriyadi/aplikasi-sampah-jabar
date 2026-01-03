using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

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
            this.Text = "Sistem Manajemen Sampah Jabar";

            // 1. SETUP DATABASE
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex) { MessageBox.Show("Error DB: " + ex.Message); }

            // 2. BANGUN TAMPILAN
            BuatTampilanDashboard();

            // 3. EVENT TOMBOL
            PasangEventTombol();

            // 4. LOAD DATA
            LoadStatistik();
        }

        private void BuatTampilanDashboard()
        {
            // KOORDINAT: Silakan ubah startX ini jika kartu tertutup sidebar
            // Coba ganti 250 jadi 300 atau 350 kalau masih ketutupan sidebar
            int startX = 260;
            int startY = 100;
            int gap = 20;

            // KARTU 1 (Hijau)
            Panel pnlBerat = BuatPanel(startX, startY, Color.SeaGreen);
            BuatLabelJudul(pnlBerat, "Total Sampah (Kg)");
            lblTotalBerat = BuatLabelAngka(pnlBerat, "0 Kg");

            // KARTU 2 (Biru)
            Panel pnlData = BuatPanel(startX + 260 + gap, startY, Color.RoyalBlue);
            BuatLabelJudul(pnlData, "Total Transaksi");
            lblTotalData = BuatLabelAngka(pnlData, "0 Data");

            // KARTU 3 (Oranye)
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

            // --- REVISI: LANGSUNG ADD & BRING TO FRONT ---
            this.Controls.Add(p);
            p.BringToFront(); // Mantra agar muncul di paling depan!
            return p;
        }

        private void BuatLabelJudul(Panel parent, string teks)
        {
            Label l = new Label();
            l.Text = teks;
            l.ForeColor = Color.White;
            l.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            l.Location = new Point(20, 20);
            l.AutoSize = true;
            parent.Controls.Add(l);
        }

        private Label BuatLabelAngka(Panel parent, string teksAwal)
        {
            Label l = new Label();
            l.Text = teksAwal;
            l.ForeColor = Color.White;
            l.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            l.Location = new Point(20, 55);
            l.AutoSize = true;
            parent.Controls.Add(l);
            return l;
        }

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

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

            if (teks.Contains("dashboard"))
            {
                LoadStatistik();
                MessageBox.Show("Data di-refresh!", "Info");
            }
            else if (teks.Contains("sampah") || teks.Contains("input")) new CRUDSampah().Show();
            else if (teks.Contains("wastebot") || teks.Contains("ai")) new JabarWasteAI().Show();
            else if (teks.Contains("keluar"))
            {
                if (MessageBox.Show("Keluar?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new LoginForm().Show();
                    this.Close();
                }
            }
            else MessageBox.Show("Fitur belum tersedia.");
        }
    }
}