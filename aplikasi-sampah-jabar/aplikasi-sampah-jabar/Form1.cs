using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;

namespace aplikasi_sampah_jabar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDashboardTheme();
            CreateStatCards();
            InitializeChartPreview();
            LoadTableData();

            // Welcome Message Chatbot
            AppendBotMessage("?? Selamat datang di Jabar Smart Waste!\n\nSaya siap membantu Anda dengan informasi seputar pengelolaan sampah di Jawa Barat.");
        }

        private void SetupDashboardTheme()
        {
            // Background Utama
            this.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);

            // Styling Tabel (DataGridView)
            dgvDataSampah.BackgroundColor = Color.White;
            dgvDataSampah.BorderStyle = BorderStyle.None;
            dgvDataSampah.EnableHeadersVisualStyles = false;
            dgvDataSampah.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgvDataSampah.ColumnHeadersHeight = 45;
            dgvDataSampah.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 248, 245);
            dgvDataSampah.DefaultCellStyle.SelectionForeColor = Color.FromArgb(46, 204, 113);
            dgvDataSampah.RowTemplate.Height = 40;
        }

        private void CreateStatCards()
        {
            pnlCards.Controls.Clear();
            // Menambahkan 4 kartu utama
            AddStatCard("Total Sampah Terkumpul", "4,320", "Ton", "? 5.2%", Color.FromArgb(52, 152, 219), "??");
            AddStatCard("Tingkat Daur Ulang", "68.5", "%", "? 12%", Color.FromArgb(46, 204, 113), "??");
            AddStatCard("Wilayah Terdata", "27", "Wilayah", "100%", Color.FromArgb(155, 89, 182), "???");
            AddStatCard("Bank Sampah Aktif", "142", "Unit", "? 8.3%", Color.FromArgb(230, 126, 34), "??");
        }

        private void AddStatCard(string title, string value, string unit, string trend, Color theme, string icon)
        {
            Panel card = new Panel
            {
                Width = 240,
                Height = 150,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 20, 20),
                Padding = new Padding(15)
            };

            // Efek border bawah tipis berwarna sesuai tema
            card.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    theme, 4, ButtonBorderStyle.Solid);
            };

            Label lblIcon = new Label { Text = icon, ForeColor = theme, Font = new Font("Segoe UI", 20), AutoSize = true, Location = new Point(15, 15) };
            Label lblVal = new Label { Text = value, Font = new Font("Segoe UI Bold", 22), ForeColor = Color.FromArgb(30, 41, 59), Location = new Point(65, 10), AutoSize = true };
            Label lblTit = new Label { Text = title, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(100, 116, 139), Location = new Point(15, 75), AutoSize = true };
            Label lblTrn = new Label { Text = trend, Font = new Font("Segoe UI Semibold", 9), ForeColor = Color.FromArgb(46, 204, 113), Location = new Point(15, 105), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblIcon, lblVal, lblTit, lblTrn });
            pnlCards.Controls.Add(card);
        }

        private void InitializeChartPreview()
        {
            Panel pnlChart = new Panel
            {
                Dock = DockStyle.Top,
                Height = 220,
                BackColor = Color.White,
                Margin = new Padding(20),
                Padding = new Padding(15)
            };

            Label lblChartTitle = new Label
            {
                Text = "?? Grafik Trend Sampah (7 Hari Terakhir)",
                Font = new Font("Segoe UI Semibold", 11F),
                Dock = DockStyle.Top,
                Height = 30
            };

            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Paint += (s, e) => {
                // Gambar Bar Chart Sederhana
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int[] vals = { 60, 80, 50, 90, 100, 70, 85 };
                string[] days = { "Sen", "Sel", "Rab", "Kam", "Jum", "Sab", "Min" };

                for (int i = 0; i < vals.Length; i++)
                {
                    int h = vals[i];
                    Rectangle rect = new Rectangle(50 + (i * 90), 180 - h, 60, h);
                    using (SolidBrush b = new SolidBrush(Color.FromArgb(46, 204, 113)))
                    {
                        g.FillRectangle(b, rect);
                    }
                    g.DrawString(days[i], new Font("Segoe UI", 8), Brushes.Gray, 65 + (i * 90), 185);
                }
            };

            // Memasukkan ke pnlContent di atas tabel
            pnlContent.Controls.Add(pnlChart);
            pnlChart.BringToFront();
            lblTableTitle.BringToFront(); // Pastikan judul tabel tetap di bawah chart
            dgvDataSampah.BringToFront();
        }

        private void LoadTableData()
        {
            dgvDataSampah.Rows.Clear();
            dgvDataSampah.Columns.Clear();

            dgvDataSampah.Columns.Add("id", "ID");
            dgvDataSampah.Columns.Add("wilayah", "Kabupaten/Kota");
            dgvDataSampah.Columns.Add("organik", "Organik (Ton)");
            dgvDataSampah.Columns.Add("anorganik", "Anorganik (Ton)");
            dgvDataSampah.Columns.Add("total", "Total (Ton)");
            dgvDataSampah.Columns.Add("status", "Status");

            dgvDataSampah.Rows.Add("JB-005", "Kab. Bandung", "680", "420", "1100", "?? Perlu Perhatian");
            dgvDataSampah.Rows.Add("JB-006", "Kota Cimahi", "180", "95", "275", "?? Sangat Baik");
            dgvDataSampah.Rows.Add("JB-007", "Kab. Garut", "290", "165", "455", "?? Baik");
            dgvDataSampah.Rows.Add("JB-008", "Kota Tasikmalaya", "240", "140", "380", "?? Normal");
        }

        // --- Logika Chatbot Sederhana ---
        private void AppendBotMessage(string message)
        {
            rtbChatLog.SelectionStart = rtbChatLog.TextLength;
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9, FontStyle.Bold);
            rtbChatLog.SelectionColor = Color.FromArgb(46, 204, 113);
            rtbChatLog.AppendText("?? AI Assistant\n");
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9);
            rtbChatLog.SelectionColor = Color.Black;
            rtbChatLog.AppendText(message + "\n\n");
        }
    }
}