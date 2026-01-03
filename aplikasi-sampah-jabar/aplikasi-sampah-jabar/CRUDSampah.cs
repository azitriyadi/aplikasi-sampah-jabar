using System;
using System.Data;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class CRUDSampah : UserControl
    {
        private DataTable dtSampah = new DataTable();

        public CRUDSampah()
        {
            InitializeComponent();
            SetupTable();
        }

        private void SetupTable()
        {
            if (dtSampah.Columns.Count == 0)
            {
                dtSampah.Columns.Add("Nama Sampah");
                dtSampah.Columns.Add("Jenis");
                dtSampah.Columns.Add("Berat (Kg)");
            }
            dgvData.DataSource = dtSampah;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || cmbJenis.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon lengkapi data!");
                return;
            }

            dtSampah.Rows.Add(txtNama.Text, cmbJenis.Text, numBerat.Value);
            txtNama.Clear();
            cmbJenis.SelectedIndex = -1;
            numBerat.Value = 0;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.SelectedRows)
                {
                    if (!row.IsNewRow) dgvData.Rows.Remove(row);
                }
            }
        }
    }
}