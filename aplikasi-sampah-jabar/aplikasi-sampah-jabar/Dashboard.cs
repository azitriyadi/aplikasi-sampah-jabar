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
        public static string NamaUserAktif = "Admin";

        private Label lblTotalBerat;
        private Label lblTotalData;
        private IMongoCollection<SampahModel> _collection;

        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set label nama user (Pastikan lblNamaUser ada di Designer)
            if (this.lblNamaUser != null)
                this.lblNamaUser.Text = "Login sebagai: " + NamaUserAktif;

            // Setup DB
            try
            {
                var database = MongoHelper.GetDatabase();
                _collection = database.GetCollection<SampahModel>("data_sampah");
            }
            catch (Exception ex) { MessageBox.Show("Error DB: " + ex.Message); }

            TampilkanStatistikUtama();
        }

        private void BukaHalaman(Form frmAnak)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.Clear();

            frmAnak.TopLevel = false;
            frmAnak.FormBorderStyle = FormBorderStyle.None;
            frmAnak.Dock = DockStyle.Fill;

            this.pnlMain.Controls.Add(frmAnak);
            frmAnak.Show();
        }

        private void TampilkanStatistikUtama()
        {
            this.pnlMain.Controls.Clear();
            this.lblTitle.Text = "Dashboard Overview";

            Panel p1 = BuatPanelStatistik(this.pnlMain, 40, 40, Color.SeaGreen);
            BuatLabelInfo(p1, "Total Sampah Terkumpul");
            lblTotalBerat = BuatLabelNilai(p1, "0 Kg");

            Panel p2 = BuatPanelStatistik(this.pnlMain, 340, 40, Color.RoyalBlue);
            BuatLabelInfo(p2, "Jumlah Transaksi");
            lblTotalData = BuatLabelNilai(p2, "0 Data");

            LoadStatistik();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string teks = btn.Text.ToLower();

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
                this.lblTitle.Text = "WasteBot AI Assistant";
                BukaHalaman(new JabarWasteAI());
            }
            else if (teks.Contains("laporan") || teks.Contains("pdf"))
            {
                // SEKARANG AKAN MUNCUL POP-UP
                EksporKePDF();
            }
            else if (teks.Contains("logout"))
            {
                AksiLogout();
            }
        }

        private void AksiLogout()
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                // Pastikan LoginForm ada di project kamu
                LoginForm login = new LoginForm();
                login.Show();
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
            catch { }
        }

        private void EksporKePDF()
        {
            // Cek data dulu sebelum munculkan pop-up
            if (_collection == null) return;
            var dataList = _collection.Find(new BsonDocument()).ToList();

            if (dataList.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!");
                return;
            }

            // POP-UP UNTUK SIMPAN FILE
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Laporan_Sampah_" + DateTime.Now.ToString("yyyyMMdd");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Panggil Service PDF
                    PdfService pdf = new PdfService();
                    pdf.ExportLaporanSampah(sfd.FileName, dataList);
                    MessageBox.Show("Laporan PDF berhasil disimpan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal ekspor: " + ex.Message);
                }
            }
        }

        // Helper UI
        private Panel BuatPanelStatistik(Control pnt, int x, int y, Color c)
        {
            Panel p = new Panel { Size = new Size(260, 150), Location = new Point(x, y), BackColor = c };
            pnt.Controls.Add(p); return p;
        }
        private void BuatLabelInfo(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true };
            p.Controls.Add(l);
        }
        private Label BuatLabelNilai(Panel p, string t)
        {
            Label l = new Label { Text = t, ForeColor = Color.White, Font = new Font("Segoe UI", 22, FontStyle.Bold), Location = new Point(20, 50), AutoSize = true };
            p.Controls.Add(l); return l;
        }
    }
}