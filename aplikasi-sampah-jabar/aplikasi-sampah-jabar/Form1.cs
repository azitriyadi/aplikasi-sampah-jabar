using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace aplikasi_sampah_jabar
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int animationProgress = 0;
        private Panel selectedMenu = null;
        private List<WasteData> wasteDataList = new List<WasteData>();
        private int nextId = 9;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyPremiumStyle();
            CreateEnhancedStatCards();
            LoadDataWithAnimation();
            InitializeChartPreview();
            SetupAnimations();
            SetupCRUDButtons();
        }

        private void ApplyPremiumStyle()
        {
            // Form Styling
            this.BackColor = Color.FromArgb(245, 247, 250);

            // DataGridView Premium Styling
            dgvDataSampah.EnableHeadersVisualStyles = false;
            dgvDataSampah.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDataSampah.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDataSampah.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dgvDataSampah.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataSampah.ColumnHeadersHeight = 50;
            dgvDataSampah.RowTemplate.Height = 45;
            dgvDataSampah.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataSampah.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 245, 230);
            dgvDataSampah.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dgvDataSampah.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvDataSampah.GridColor = Color.FromArgb(230, 235, 240);
            dgvDataSampah.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 254);
            dgvDataSampah.BorderStyle = BorderStyle.None;
            dgvDataSampah.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Chatbot Styling with Shadow Effect
            pnlChatbot.Paint += (s, pe) => DrawShadow(pe.Graphics, pnlChatbot.ClientRectangle);

            // Chat Input Enhancement
            txtChatInput.Height = 45;
            txtChatInput.Font = new Font("Segoe UI", 11F);
            txtChatInput.BorderStyle = BorderStyle.FixedSingle;

            // Button untuk Send Message
            Button btnSend = new Button
            {
                Text = "?",
                Font = new Font("Segoe UI", 14F),
                Size = new Size(50, 45),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Right
            };
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.Click += (s, e) => SendChatMessage();

            Panel chatInputPanel = new Panel { Dock = DockStyle.Bottom, Height = 45, Padding = new Padding(10, 0, 10, 10) };
            chatInputPanel.Controls.Add(txtChatInput);
            chatInputPanel.Controls.Add(btnSend);
            txtChatInput.Dock = DockStyle.Fill;

            pnlChatbot.Controls.Remove(txtChatInput);
            pnlChatbot.Controls.Add(chatInputPanel);

            txtChatInput.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    SendChatMessage();
                    e.SuppressKeyPress = true;
                }
            };

            // Rich Text Chat Log Styling
            rtbChatLog.BorderStyle = BorderStyle.None;
            rtbChatLog.BackColor = Color.FromArgb(250, 252, 254);
            rtbChatLog.Font = new Font("Segoe UI", 9.5F);
            rtbChatLog.ReadOnly = true;

            // Welcome Message
            AppendBotMessage("?? Selamat datang di Jabar Smart Waste!\n\nSaya siap membantu Anda dengan informasi seputar pengelolaan sampah di Jawa Barat. Silakan tanyakan apapun!");
        }

        private void SetupCRUDButtons()
        {
            // Panel untuk CRUD Buttons
            Panel pnlCRUD = new Panel
            {
                Height = 70,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                Padding = new Padding(20, 15, 20, 15)
            };

            // Create Button
            Button btnCreate = CreateCRUDButton("? Tambah Data", Color.FromArgb(46, 204, 113), 0);
            btnCreate.Click += BtnCreate_Click;

            // Update Button
            Button btnUpdate = CreateCRUDButton("?? Edit Data", Color.FromArgb(52, 152, 219), 1);
            btnUpdate.Click += BtnUpdate_Click;

            // Delete Button
            Button btnDelete = CreateCRUDButton("??? Hapus Data", Color.FromArgb(231, 76, 60), 2);
            btnDelete.Click += BtnDelete_Click;

            // Refresh Button
            Button btnRefresh = CreateCRUDButton("?? Refresh", Color.FromArgb(155, 89, 182), 3);
            btnRefresh.Click += (s, e) => RefreshStats();

            pnlCRUD.Controls.AddRange(new Control[] { btnCreate, btnUpdate, btnDelete, btnRefresh });
            pnlContent.Controls.Add(pnlCRUD);
            pnlCRUD.BringToFront();
        }

        private Button CreateCRUDButton(string text, Color bgColor, int position)
        {
            Button btn = new Button
            {
                Text = text,
                Width = 150,
                Height = 40,
                Left = 10 + (position * 160),
                Top = 10,
                FlatStyle = FlatStyle.Flat,
                BackColor = bgColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;

            // Hover effects
            btn.MouseEnter += (s, e) => {
                btn.BackColor = ControlPaint.Light(bgColor, 0.1f);
                btn.Top -= 2;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = bgColor;
                btn.Top += 2;
            };

            return btn;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FormCRUD formCRUD = new FormCRUD(null);
            if (formCRUD.ShowDialog() == DialogResult.OK)
            {
                WasteData newData = formCRUD.WasteData;
                newData.Id = $"JB-{nextId:D3}";
                nextId++;
                wasteDataList.Add(newData);
                RefreshDataGrid();
                RefreshStats();
                AppendBotMessage($"? Data berhasil ditambahkan!\n\n?? {newData.Wilayah}\n?? Total: {newData.Total} ton");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDataSampah.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diedit!", "Perhatian",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dgvDataSampah.SelectedRows[0].Index;
            WasteData selectedData = wasteDataList[rowIndex];

            FormCRUD formCRUD = new FormCRUD(selectedData);
            if (formCRUD.ShowDialog() == DialogResult.OK)
            {
                wasteDataList[rowIndex] = formCRUD.WasteData;
                RefreshDataGrid();
                RefreshStats();
                AppendBotMessage($"? Data berhasil diperbarui!\n\n?? {formCRUD.WasteData.Wilayah}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataSampah.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Perhatian",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvDataSampah.SelectedRows[0].Index;
                string wilayah = wasteDataList[rowIndex].Wilayah;
                wasteDataList.RemoveAt(rowIndex);
                RefreshDataGrid();
                RefreshStats();
                AppendBotMessage($"??? Data {wilayah} berhasil dihapus!");
            }
        }

        private void RefreshDataGrid()
        {
            dgvDataSampah.Rows.Clear();

            foreach (var data in wasteDataList)
            {
                dgvDataSampah.Rows.Add(
                    data.Id,
                    data.Wilayah,
                    data.Organik,
                    data.Anorganik,
                    data.Total,
                    data.Status
                );
            }

            // Apply styling
            foreach (DataGridViewRow row in dgvDataSampah.Rows)
            {
                if (row.Cells[5].Value?.ToString().Contains("Waspada") == true ||
                    row.Cells[5].Value?.ToString().Contains("Perhatian") == true)
                {
                    row.Cells[5].Style.BackColor = Color.FromArgb(255, 243, 224);
                    row.Cells[5].Style.ForeColor = Color.FromArgb(230, 126, 34);
                }
                else
                {
                    row.Cells[5].Style.BackColor = Color.FromArgb(232, 248, 245);
                    row.Cells[5].Style.ForeColor = Color.FromArgb(46, 204, 113);
                }
            }
        }

        private void RefreshStats()
        {
            // Recalculate statistics
            int totalSampah = wasteDataList.Sum(d => d.Total);
            int totalWilayah = wasteDataList.Count;
            double avgRecycle = wasteDataList.Count > 0 ?
                wasteDataList.Average(d => (double)d.Organik / d.Total * 100) : 0;

            // Update cards (simplified - you may want to recreate them)
            pnlCards.Controls.Clear();
            AddEnhancedCard("Total Sampah Terkumpul", totalSampah.ToString(), "Ton", "? 5.2%",
                Color.FromArgb(52, 152, 219), "??");
            AddEnhancedCard("Tingkat Daur Ulang", avgRecycle.ToString("F1"), "%", "? 12%",
                Color.FromArgb(46, 204, 113), "??");
            AddEnhancedCard("Wilayah Terdata", totalWilayah.ToString(), "Kota/Kab", "100%",
                Color.FromArgb(155, 89, 182), "???");
            AddEnhancedCard("Bank Sampah Aktif", "142", "Unit", "? 8.3%",
                Color.FromArgb(230, 126, 34), "??");
        }

        private void SendChatMessage()
        {
            string userMsg = txtChatInput.Text.Trim();
            if (string.IsNullOrEmpty(userMsg)) return;

            AppendUserMessage(userMsg);
            ProcessBotResponse(userMsg);
            txtChatInput.Clear();
        }

        private void AppendUserMessage(string message)
        {
            rtbChatLog.SelectionAlignment = HorizontalAlignment.Right;
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            rtbChatLog.SelectionColor = Color.FromArgb(52, 152, 219);
            rtbChatLog.AppendText("Anda\n");

            rtbChatLog.SelectionFont = new Font("Segoe UI", 9.5F);
            rtbChatLog.SelectionColor = Color.FromArgb(44, 62, 80);
            rtbChatLog.AppendText(message + "\n\n");
        }

        private void AppendBotMessage(string message)
        {
            rtbChatLog.SelectionAlignment = HorizontalAlignment.Left;
            rtbChatLog.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            rtbChatLog.SelectionColor = Color.FromArgb(46, 204, 113);
            rtbChatLog.AppendText("?? AI Assistant\n");

            rtbChatLog.SelectionFont = new Font("Segoe UI", 9.5F);
            rtbChatLog.SelectionColor = Color.FromArgb(44, 62, 80);
            rtbChatLog.AppendText(message + "\n\n");
            rtbChatLog.ScrollToCaret();
        }

        private void CreateEnhancedStatCards()
        {
            pnlCards.Padding = new Padding(0, 10, 0, 10);

            AddEnhancedCard("Total Sampah Terkumpul", "4,320", "Ton", "? 5.2%", Color.FromArgb(52, 152, 219), "??");
            AddEnhancedCard("Tingkat Daur Ulang", "68.5", "%", "? 12%", Color.FromArgb(46, 204, 113), "??");
            AddEnhancedCard("Wilayah Terdata", "27", "Kota/Kab", "100%", Color.FromArgb(155, 89, 182), "???");
            AddEnhancedCard("Bank Sampah Aktif", "142", "Unit", "? 8.3%", Color.FromArgb(230, 126, 34), "??");
        }

        private void AddEnhancedCard(string title, string value, string unit, string trend, Color theme, string icon)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 140,
                BackColor = Color.White,
                Margin = new Padding(10, 5, 10, 5),
                Cursor = Cursors.Hand
            };

            card.Paint += (s, e) =>
            {
                Rectangle rect = card.ClientRectangle;
                using (GraphicsPath path = CreateRoundedRectangle(rect, 12))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
            };

            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 28F),
                ForeColor = theme,
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(90, 20),
                AutoSize = true
            };

            Label lblUnit = new Label
            {
                Text = unit,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(90, 55),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(20, 85),
                AutoSize = true
            };

            Label lblTrend = new Label
            {
                Text = trend,
                Font = new Font("Segoe UI Semibold", 9F),
                ForeColor = trend.StartsWith("?") ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60),
                Location = new Point(20, 110),
                AutoSize = true
            };

            Panel accentBar = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 5,
                BackColor = theme
            };

            card.Controls.AddRange(new Control[] { lblIcon, lblValue, lblUnit, lblTitle, lblTrend, accentBar });

            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(248, 250, 252);
                card.Top -= 3;
            };
            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
                card.Top += 3;
            };

            pnlCards.Controls.Add(card);
        }

        private void LoadDataWithAnimation()
        {
            dgvDataSampah.ColumnCount = 6;
            dgvDataSampah.Columns[0].Name = "ID";
            dgvDataSampah.Columns[0].Width = 80;
            dgvDataSampah.Columns[1].Name = "Kabupaten/Kota";
            dgvDataSampah.Columns[1].Width = 150;
            dgvDataSampah.Columns[2].Name = "Organik (Ton)";
            dgvDataSampah.Columns[3].Name = "Anorganik (Ton)";
            dgvDataSampah.Columns[4].Name = "Total (Ton)";
            dgvDataSampah.Columns[5].Name = "Status";
            dgvDataSampah.Columns[5].Width = 120;

            // Initialize data list
            wasteDataList = new List<WasteData>
            {
                new WasteData { Id = "JB-001", Wilayah = "Kota Bandung", Organik = 450, Anorganik = 280, Total = 730, Status = "? Sangat Baik" },
                new WasteData { Id = "JB-002", Wilayah = "Kota Bekasi", Organik = 890, Anorganik = 510, Total = 1400, Status = "?? Waspada" },
                new WasteData { Id = "JB-003", Wilayah = "Kota Bogor", Organik = 320, Anorganik = 215, Total = 535, Status = "? Normal" },
                new WasteData { Id = "JB-004", Wilayah = "Kota Depok", Organik = 410, Anorganik = 190, Total = 600, Status = "? Baik" },
                new WasteData { Id = "JB-005", Wilayah = "Kab. Bandung", Organik = 680, Anorganik = 420, Total = 1100, Status = "?? Perlu Perhatian" },
                new WasteData { Id = "JB-006", Wilayah = "Kota Cimahi", Organik = 180, Anorganik = 95, Total = 275, Status = "? Sangat Baik" },
                new WasteData { Id = "JB-007", Wilayah = "Kab. Garut", Organik = 290, Anorganik = 165, Total = 455, Status = "? Baik" },
                new WasteData { Id = "JB-008", Wilayah = "Kota Tasikmalaya", Organik = 240, Anorganik = 140, Total = 380, Status = "? Normal" }
            };

            RefreshDataGrid();
        }

        private void InitializeChartPreview()
        {
            Panel chartPanel = new Panel
            {
                Height = 200,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                Margin = new Padding(10)
            };

            Label lblChart = new Label
            {
                Text = "?? Grafik Trend Sampah (7 Hari Terakhir)",
                Font = new Font("Segoe UI Semibold", 11F),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(20, 15),
                AutoSize = true
            };

            chartPanel.Controls.Add(lblChart);
            chartPanel.Paint += DrawMiniChart;

            pnlContent.Controls.Add(chartPanel);
            chartPanel.BringToFront();
        }

        private void DrawMiniChart(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int[] dataPoints = { 420, 450, 430, 480, 510, 490, 520 };
            string[] labels = { "Sen", "Sel", "Rab", "Kam", "Jum", "Sab", "Min" };

            int startX = 30;
            int startY = 150;
            int width = 140;
            int maxHeight = 80;

            for (int i = 0; i < dataPoints.Length; i++)
            {
                int barHeight = (int)((double)dataPoints[i] / 520 * maxHeight);
                int x = startX + (i * (width + 15));
                int y = startY - barHeight;

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(x, y, width, barHeight),
                    Color.FromArgb(46, 204, 113),
                    Color.FromArgb(39, 174, 96),
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, x, y, width, barHeight);
                }

                g.DrawString(labels[i], new Font("Segoe UI", 8F), Brushes.Gray, x + width / 2 - 10, startY + 5);
            }
        }

        private void ProcessBotResponse(string msg)
        {
            string response = "Maaf, saya belum memahami pertanyaan Anda. Coba tanyakan tentang:\n• Data sampah wilayah\n• Statistik daur ulang\n• Bank sampah\n• Tips pengelolaan\n• Cara tambah/edit/hapus data";

            msg = msg.ToLower();

            if (msg.Contains("tambah") || msg.Contains("create") || msg.Contains("input"))
                response = "?? Untuk menambah data baru:\n\n1. Klik tombol '? Tambah Data'\n2. Isi form yang muncul\n3. Klik 'Simpan'\n\nData akan otomatis tersimpan dan statistik akan diperbarui!";
            else if (msg.Contains("edit") || msg.Contains("update") || msg.Contains("ubah"))
                response = "?? Untuk mengedit data:\n\n1. Pilih baris data di tabel\n2. Klik tombol '?? Edit Data'\n3. Ubah data yang diperlukan\n4. Klik 'Simpan'\n\nData akan langsung diperbarui!";
            else if (msg.Contains("hapus") || msg.Contains("delete"))
                response = "??? Untuk menghapus data:\n\n1. Pilih baris data di tabel\n2. Klik tombol '??? Hapus Data'\n3. Konfirmasi penghapusan\n\nHati-hati! Data yang dihapus tidak dapat dikembalikan.";
            else if (msg.Contains("bandung"))
                response = "?? Kota Bandung:\n• Total sampah: 730 ton\n• Organik: 450 ton (61.6%)\n• Anorganik: 280 ton (38.4%)\n• Tingkat daur ulang: 72%\n• Status: Sangat Baik ?";
            else if (msg.Contains("bekasi"))
                response = "?? Kota Bekasi:\n• Total sampah: 1,400 ton\n• Organik: 890 ton (63.6%)\n• Anorganik: 510 ton (36.4%)\n• Status: Waspada ??\n\n?? Volume sampah tinggi, perlu optimasi!";
            else if (msg.Contains("total") || msg.Contains("keseluruhan") || msg.Contains("statistik"))
                response = $"?? Statistik Jawa Barat:\n• Total sampah: {wasteDataList.Sum(d => d.Total)} ton\n• Wilayah terdata: {wasteDataList.Count}\n• Tingkat daur ulang: 68.5%\n• 142 bank sampah aktif";
            else if (msg.Contains("daur ulang") || msg.Contains("recycle"))
                response = "?? Tingkat Daur Ulang:\n• Rata-rata: 68.5%\n• Tertinggi: Bandung (72%)\n• Target tahun ini: 75%\n\nTren positif naik 12% YoY!";
            else if (msg.Contains("bank sampah"))
                response = "?? Bank Sampah Jabar:\n• Total: 142 unit aktif\n• Nasabah: 28,450 orang\n• Transaksi/bulan: Rp 1.2M\n• Naik 8.3% dari bulan lalu\n\nKunjungi banksampah.id untuk info!";
            else if (msg.Contains("tips") || msg.Contains("saran"))
                response = "?? Tips Kelola Sampah:\n\n1. Pisahkan organik & anorganik\n2. Kompos sampah dapur\n3. Manfaatkan bank sampah\n4. Kurangi plastik sekali pakai\n5. Donasi barang layak pakai\n\nMulai dari hal kecil! ??";
            else if (msg.Contains("hai") || msg.Contains("halo") || msg.Contains("hi"))
                response = "?? Halo! Ada yang bisa saya bantu? Saya bisa memberikan informasi tentang:\n\n• Data sampah per wilayah\n• Statistik & trend\n• Bank sampah\n• Tips pengelolaan\n• Cara menggunakan fitur CRUD\n\nSilakan tanyakan!";

            AppendBotMessage(response);
        }

        private void SetupAnimations()
        {
            animationTimer = new System.Windows.Forms.Timer { Interval = 30 };
            animationTimer.Tick += (s, e) =>
            {
                animationProgress++;
                if (animationProgress > 100)
                {
                    animationTimer.Stop();
                    animationProgress = 0;
                }
                this.Invalidate();
            };
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void DrawShadow(Graphics g, Rectangle bounds)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(new Rectangle(bounds.X + 3, bounds.Y + 3, bounds.Width, bounds.Height));
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(20, 0, 0, 0);
                    brush.SurroundColors = new[] { Color.Transparent };
                }
            }
        }
    }

    // Data Model Class
    public class WasteData
    {
        public string Id { get; set; }
        public string Wilayah { get; set; }
        public int Organik { get; set; }
        public int Anorganik { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
    }
}