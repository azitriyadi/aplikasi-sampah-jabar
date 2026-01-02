using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class FormDataSampah : Form
    {
        // DataTable static agar tersambung ke Dashboard Utama
        public static DataTable dtMaster;

        public FormDataSampah()
        {
            InitializeComponent();
            SetupData();

            // Event Handlers
            btnSimpan.Click += btnSimpan_Click;
            btnHapus.Click += btnHapus_Click;
            dgvData.CellClick += dgvData_CellClick;
        }

        private void SetupData()
        {
            if (dtMaster == null)
            {
                dtMaster = new DataTable();
                dtMaster.Columns.Add("ID");
                dtMaster.Columns.Add("Nama Sampah");
                dtMaster.Columns.Add("Jenis");
                dtMaster.Columns.Add("Berat (Kg)");
                dtMaster.Columns.Add("Tentang");

                // Data Dummy Awal
                dtMaster.Rows.Add("S-001", "Plastik PET", "Anorganik", "25", "Hasil pengepulan bank sampah");
            }
            dgvData.DataSource = dtMaster;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbJenis.Items.AddRange(new string[] { "Organik", "Anorganik", "B3 (Bahaya)", "Kertas" });
            cmbJenis.SelectedIndex = 0;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "UPDATE DATA")
            {
                int i = dgvData.SelectedRows[0].Index;
                dtMaster.Rows[i]["Nama Sampah"] = txtNama.Text;
                dtMaster.Rows[i]["Jenis"] = cmbJenis.Text;
                dtMaster.Rows[i]["Berat (Kg)"] = txtBerat.Text;
                dtMaster.Rows[i]["Tentang"] = txtKet.Text;
                MessageBox.Show("Data Berhasil Diperbarui!");
            }
            else
            {
                string id = "S-" + (dtMaster.Rows.Count + 1).ToString("D3");
                dtMaster.Rows.Add(id, txtNama.Text, cmbJenis.Text, txtBerat.Text, txtKet.Text);
                MessageBox.Show("Data Berhasil Disimpan!");
            }
            ResetForm();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtNama.Text = row.Cells[1].Value.ToString();
                cmbJenis.Text = row.Cells[2].Value.ToString();
                txtBerat.Text = row.Cells[3].Value.ToString();
                txtKet.Text = row.Cells[4].Value.ToString();

                btnSimpan.Text = "UPDATE DATA";
                btnSimpan.BackColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                dtMaster.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                ResetForm();
            }
        }

        private void ResetForm()
        {
            txtNama.Clear(); txtBerat.Clear(); txtKet.Clear();
            cmbJenis.SelectedIndex = 0;
            btnSimpan.Text = "SIMPAN DATA";
            btnSimpan.BackColor = Color.FromArgb(46, 204, 113);
        }
    }
}