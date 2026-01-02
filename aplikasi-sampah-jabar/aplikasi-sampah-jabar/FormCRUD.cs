using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class FormCRUD : Form
    {
        public WasteData WasteData { get; private set; }
        private bool isEditMode = false;

        private TextBox txtWilayah;
        private NumericUpDown numOrganik;
        private NumericUpDown numAnorganik;
        private ComboBox cmbStatus;
        private Label lblTotal;
        private Button btnSave;
        private Button btnCancel;

        public FormCRUD(WasteData existingData)
        {
            InitializeCustomComponent();

            if (existingData != null)
            {
                isEditMode = true;
                WasteData = existingData;
                LoadData();
            }
            else
            {
                WasteData = new WasteData();
            }
        }

        private void InitializeCustomComponent()
        {
            this.Text = "Form Data Sampah";
            this.Size = new Size(500, 450);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Header Panel
            Panel pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(46, 204, 113)
            };

            Label lblHeader = new Label
            {
                Text = isEditMode ? "✏️ Edit Data Sampah" : "➕ Tambah Data Sampah",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 25)
            };

            pnlHeader.Controls.Add(lblHeader);
            this.Controls.Add(pnlHeader);

            // Main Panel
            Panel pnlMain = new Panel
            {
                Location = new Point(30, 100),
                Size = new Size(420, 250),
                BackColor = Color.White
            };

            // Wilayah
            Label lblWilayah = new Label
            {
                Text = "Kabupaten/Kota:",
                Location = new Point(20, 20),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 10F)
            };

            txtWilayah = new TextBox
            {
                Location = new Point(180, 20),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 10F)
            };

            // Organik
            Label lblOrganik = new Label
            {
                Text = "Sampah Organik (Ton):",
                Location = new Point(20, 65),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 10F)
            };

            numOrganik = new NumericUpDown
            {
                Location = new Point(180, 65),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 10F),
                Maximum = 10000,
                Minimum = 0
            };
            numOrganik.ValueChanged += (s, e) => UpdateTotal();

            // Anorganik
            Label lblAnorganik = new Label
            {
                Text = "Sampah Anorganik (Ton):",
                Location = new Point(20, 110),
                Size = new Size(160, 25),
                Font = new Font("Segoe UI", 10F)
            };

            numAnorganik = new NumericUpDown
            {
                Location = new Point(180, 110),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 10F),
                Maximum = 10000,
                Minimum = 0
            };
            numAnorganik.ValueChanged += (s, e) => UpdateTotal();

            // Total (Read-only)
            Label lblTotalLabel = new Label
            {
                Text = "Total Sampah:",
                Location = new Point(20, 155),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI Semibold", 10F)
            };

            lblTotal = new Label
            {
                Text = "0 Ton",
                Location = new Point(180, 155),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(46, 204, 113)
            };

            // Status
            Label lblStatus = new Label
            {
                Text = "Status:",
                Location = new Point(20, 195),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 10F)
            };

            cmbStatus = new ComboBox
            {
                Location = new Point(180, 195),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbStatus.Items.AddRange(new object[] {
                "✅ Sangat Baik",
                "✅ Baik",
                "✅ Normal",
                "⚠️ Perlu Perhatian",
                "⚠️ Waspada"
            });
            cmbStatus.SelectedIndex = 0;

            pnlMain.Controls.AddRange(new Control[] {
                lblWilayah, txtWilayah,
                lblOrganik, numOrganik,
                lblAnorganik, numAnorganik,
                lblTotalLabel, lblTotal,
                lblStatus, cmbStatus
            });

            this.Controls.Add(pnlMain);

            // Buttons Panel
            Panel pnlButtons = new Panel
            {
                Location = new Point(30, 360),
                Size = new Size(420, 50)
            };

            btnSave = new Button
            {
                Text = "💾 Simpan",
                Location = new Point(210, 0),
                Size = new Size(100, 40),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            btnCancel = new Button
            {
                Text = "❌ Batal",
                Location = new Point(320, 0),
                Size = new Size(100, 40),
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            pnlButtons.Controls.AddRange(new Control[] { btnSave, btnCancel });
            this.Controls.Add(pnlButtons);
        }

        private void LoadData()
        {
            if (WasteData != null)
            {
                txtWilayah.Text = WasteData.Wilayah;
                numOrganik.Value = WasteData.Organik;
                numAnorganik.Value = WasteData.Anorganik;

                int statusIndex = cmbStatus.Items.IndexOf(WasteData.Status);
                if (statusIndex >= 0)
                    cmbStatus.SelectedIndex = statusIndex;

                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            int total = (int)(numOrganik.Value + numAnorganik.Value);
            lblTotal.Text = $"{total} Ton";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtWilayah.Text))
            {
                MessageBox.Show("Nama Kabupaten/Kota harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWilayah.Focus();
                return;
            }

            if (numOrganik.Value == 0 && numAnorganik.Value == 0)
            {
                MessageBox.Show("Minimal salah satu jenis sampah harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save data
            if (isEditMode)
            {
                WasteData.Wilayah = txtWilayah.Text.Trim();
            }
            else
            {
                WasteData = new WasteData();
                WasteData.Wilayah = txtWilayah.Text.Trim();
            }

            WasteData.Organik = (int)numOrganik.Value;
            WasteData.Anorganik = (int)numAnorganik.Value;
            WasteData.Total = WasteData.Organik + WasteData.Anorganik;
            WasteData.Status = cmbStatus.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}