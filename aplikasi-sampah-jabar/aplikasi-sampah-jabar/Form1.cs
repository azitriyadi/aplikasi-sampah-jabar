using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;

namespace aplikasi_sampah_jabar
{
    public partial class Form1 : Form
    {
        // Variabel untuk Dashboard
        private System.Windows.Forms.Timer animationTimer;
        private int animationProgress = 0;

        public Form1()
        {
            InitializeComponent();
            // Menghubungkan Event Click
            this.Load += Form1_Load;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupCustomTheme();
            CreateStatCards();
            InitializeChartPreview();
            LoadSampleData();

            // Set Tanggal Real-time
            lblDateTime.Text = "?? " + DateTime.Now.ToString("dddd, dd MMMM yyyy");

            // Pesan Pembuka Chatbot
            AppendBotMessage("Selamat datang di Panel Jabar Smart Waste! Gunakan menu 'Data Analytics' untuk mengelola data sampah.");
        }

        // --- THEME & STYLING ---
        private void SetupCustomTheme()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Styling DataGridView (Tabel)
            dgvDataSampah.BorderStyle = BorderStyle.None;
            dgvDataSampah.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDataSampah.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDataSampah.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 248, 245);
            dgvDataSampah.DefaultCellStyle.SelectionForeColor = Color.FromArgb(46, 204, 113);

            // Header Tabel
            dgvDataSampah.EnableHeadersVisualStyles = false;
            dgvDataSampah.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgvDataSampah.ColumnHeadersHeight = 45;
        }

        // --- DASHBOARD CONTENT ---
        private void CreateStatCards()
        {
            pnlCards.Controls.Clear();
            // Parameter: Judul, Nilai, Satuan, Trend, Warna Aksen, Icon
            AddCard("Total Sampah", "4.320", "Ton", "? 5.2%", Color.FromArgb(52, 152, 219), "??");
            AddCard("Daur Ulang", "68.5", "%", "? 12%", Color.FromArgb(46, 204, 113), "??");
            AddCard("Wilayah", "27", "Kota", "100%", Color.FromArgb(155, 89, 182), "??");
            AddCard("Bank Sampah", "142", "Unit", "? 8.3%", Color.FromArgb(230, 126, 34), "??");
        }

        private void AddCard(string title, string value, string unit, string trend, Color accent, string icon)
        {
            Panel card = new Panel
            {
                Width = 180,
                Height = 140,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 15, 15),
                Padding = new Padding(15)
            };

            // Paint Event untuk garis aksen di bawah kartu
            card.Paint += (s, e) => {
                using (Pen p = new Pen(accent, 5))
                {
                    e.Graphics.DrawLine(p, 0, card.Height - 1, card.Width, card.Height - 1);
                }
            };

            Label lblIco = new Label { Text = icon, Font = new Font("Segoe UI", 18), Location = new Point(12, 10), AutoSize = true };
            Label lblVal = new Label { Text = value, Font = new Font("Segoe UI Bold", 18), ForeColor = Color.FromArgb(30, 41, 59), Location = new Point(12, 45), AutoSize = true };
            Label lblTit = new Label { Text = title, Font = new Font("Segoe UI", 8), ForeColor = Color.Gray, Location = new Point(15, 85), AutoSize = true };
            Label lblTrn = new Label { Text = trend, Font = new Font("Segoe UI Semibold", 8), ForeColor = Color.FromArgb(46, 204, 113), Location = new Point(15, 105), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblIco, lblVal, lblTit, lblTrn });
            pnlCards.Controls.Add(card);
        }

        private void InitializeChartPreview()
        {
            Panel pnlChart = new Panel
            {
                Dock = DockStyle.Top,
                Height = 200,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 20)
            };

            pnlChart.Paint += (s, e) => {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                // Gambar grafik batang sederhana (Dummy)
                int[] data = { 40, 70, 50, 90, 65, 85, 100 };
                for (int i = 0; i < data.Length; i++)
                {
                    int barHeight = data[i];
                    Rectangle rect = new Rectangle(60 + (i * 80), 160 - barHeight, 40, barHeight);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(46, 204, 113)), rect);
                }
            };

            pnlContent.Controls.Add(pnlChart);
            pnlChart.BringToFront();
            lblTableTitle.BringToFront();
            dgvDataSampah.BringToFront();
        }

        private void LoadSampleData()
        {
            dgvDataSampah.Rows.Clear();
            if (dgvDataSampah.Columns.Count == 0)
            {
                dgvDataSampah.Columns.Add("id", "ID");
                dgvDataSampah.Columns.Add("kota", "Kabupaten/Kota");
                dgvDataSampah.Columns.Add("org", "Organik");
                dgvDataSampah.Columns.Add("anorg", "Anorganik");
                dgvDataSampah.Columns.Add("stat", "Status");
            }

            dgvDataSampah.Rows.Add("JB01", "Kota Bandung", "1.200 Ton", "800 Ton", "? Terkendali");
            dgvDataSampah.Rows.Add("JB02", "Kab. Bandung", "950 Ton", "600 Ton", "?? Tinggi");
            dgvDataSampah.Rows.Add("JB03", "Kota Bekasi", "1.500 Ton", "1.100 Ton", "?? Kritis");
        }

        // --- NAVIGATION ---
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            // Saat diklik, membuka Form Manajemen (CRUD)
            FormManajemen frmCrud = new FormManajemen();
            frmCrud.ShowDialog();

            // Setelah kembali dari CRUD, refresh data di dashboard
            LoadSampleData();
        }

        // --- CHATBOT LOGIC ---
        private void AppendBotMessage(string message)
        {
            rtbChatLog.SelectionStart = rtbChatLog.TextLength;
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9, FontStyle.Bold);
            rtbChatLog.SelectionColor = Color.FromArgb(46, 204, 113);
            rtbChatLog.AppendText("AI: ");
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            rtbChatLog.SelectionColor = Color.Black;
            rtbChatLog.AppendText(message + "\n\n");
            rtbChatLog.ScrollToCaret();
        }
    }
}