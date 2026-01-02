using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class FormManajemen : Form
    {
        // DataTable static agar bisa diakses oleh Form1 tanpa loading ulang
        public static DataTable dtSampah;

        public FormManajemen()
        {
            InitializeComponent();
            InitializeData();
            SetupStyle();
        }

        private void InitializeData()
        {
            if (dtSampah == null)
            {
                dtSampah = new DataTable();
                dtSampah.Columns.Add("ID");
                dtSampah.Columns.Add("Nama Sampah");
                dtSampah.Columns.Add("Jenis");
                dtSampah.Columns.Add("Berat (Kg)");
                dtSampah.Columns.Add("Keterangan");

                // Data Awal (Dummy)
                dtSampah.Rows.Add("S-001", "Botol Plastik PET", "Anorganik", "15.5", "Bank Sampah Unit A");
                dtSampah.Rows.Add("S-002", "Sisa Sayuran", "Organik", "40.0", "Limbah Rumah Tangga");
            }
            dgvData.DataSource = dtSampah;
        }

        private void SetupStyle()
        {
            // Styling Tabel
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.RowTemplate.Height = 35;

            // Pilihan Jenis
            cmbJenis.Items.AddRange(new string[] { "Organik", "Anorganik", "B3", "Kertas" });
            cmbJenis.SelectedIndex = 0;
        }

        // FUNGSI SIMPAN & UPDATE FLEKSIBEL
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) return;

            if (btnSimpan.Text == "UPDATE DATA" && dgvData.SelectedRows.Count > 0)
            {
                // Logika Update
                int index = dgvData.SelectedRows[0].Index;
                dtSampah.Rows[index]["Nama Sampah"] = txtNama.Text;
                dtSampah.Rows[index]["Jenis"] = cmbJenis.Text;
                dtSampah.Rows[index]["Berat (Kg)"] = txtBerat.Text;
                dtSampah.Rows[index]["Keterangan"] = txtKet.Text;
                MessageBox.Show("Data berhasil diperbarui!");
            }
            else
            {
                // Logika Tambah Baru
                string newID = "S-" + (dtSampah.Rows.Count + 1).ToString("D3");
                dtSampah.Rows.Add(newID, txtNama.Text, cmbJenis.Text, txtBerat.Text, txtKet.Text);
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            ClearInput();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow row = dtSampah.Rows[e.RowIndex];
                txtNama.Text = row["Nama Sampah"].ToString();
                cmbJenis.Text = row["Jenis"].ToString();
                txtBerat.Text = row["Berat (Kg)"].ToString();
                txtKet.Text = row["Keterangan"].ToString();
                btnSimpan.Text = "UPDATE DATA";
                btnSimpan.BackColor = Color.FromArgb(52, 152, 219); // Ubah warna jadi Biru saat mode Edit
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                dtSampah.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                ClearInput();
            }
        }

        private void ClearInput()
        {
            txtNama.Clear();
            txtBerat.Clear();
            txtKet.Clear();
            cmbJenis.SelectedIndex = 0;
            btnSimpan.Text = "SIMPAN DATA";
            btnSimpan.BackColor = Color.FromArgb(46, 204, 113);
        }
    }
}