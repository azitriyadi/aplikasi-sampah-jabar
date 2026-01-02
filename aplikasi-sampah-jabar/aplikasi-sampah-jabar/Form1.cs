using System;
using System.Data;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            BuatTabel();
        }

        // ================== BUAT STRUKTUR DATA ==================
        void BuatTabel()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Nama Sampah");
            dt.Columns.Add("Jenis");
            dt.Columns.Add("Berat");

            dgvsSampah.DataSource = dt;

            // agar satu baris terpilih
            dgvsSampah.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsSampah.MultiSelect = false;
            dgvsSampah.ReadOnly = true;

        }

        // ================== TAMBAH DATA ==================
        private void btnTambah_Click_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(
                dt.Rows.Count + 1,
                txtNama.Text,
                txtJenis.Text,
                txtBerat.Text
            );

            Clear();
        }

        // ================== UPDATE DATA ==================
        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            if (dgvsSampah.SelectedRows.Count > 0)
            {
                int index = dgvsSampah.SelectedRows[0].Index;

                dt.Rows[index]["Nama Sampah"] = txtNama.Text;
                dt.Rows[index]["Jenis"] = txtJenis.Text;
                dt.Rows[index]["Berat"] = txtBerat.Text;

                Clear();
            }
        }

        // ================== DELETE DATA ==================
        private void btnHapus_Click_Click(object sender, EventArgs e)
        {
            if (dgvsSampah.SelectedRows.Count > 0)
            {
                int index = dgvsSampah.SelectedRows[0].Index;
                dt.Rows.RemoveAt(index);
                Clear();
            }
        }

        // ================== KLIK CELL ==================
        private void dgvsSampah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsSampah.CurrentRow != null)
            {
                txtNama.Text = dgvsSampah.CurrentRow.Cells["Nama Sampah"].Value.ToString();
                txtJenis.Text = dgvsSampah.CurrentRow.Cells["Jenis"].Value.ToString();
                txtBerat.Text = dgvsSampah.CurrentRow.Cells["Berat"].Value.ToString();
            }
        }


        // ================== CLEAR ==================
        void Clear()
        {
            txtNama.Clear();
            txtJenis.Clear();
            txtBerat.Clear();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
