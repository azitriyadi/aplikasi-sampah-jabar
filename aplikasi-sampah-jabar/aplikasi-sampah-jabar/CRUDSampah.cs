using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Drawing; // Tambahan jika butuh warna
using System.Linq;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    // PENTING: Ubah 'UserControl' menjadi 'Form'
    public partial class CRUDSampah : Form
    {
        private IMongoCollection<SampahModel> _collection;
        private string _selectedId = ""; // Menyimpan ID saat baris diklik

        public CRUDSampah()
        {
            InitializeComponent();
            this.Text = "Manajemen Data Sampah (Terhubung ke Atlas)";
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. SETUP KONEKSI DATABASE
            try
            {
                var db = MongoHelper.GetDatabase();
                _collection = db.GetCollection<SampahModel>("data_sampah");

                // 2. LOAD DATA DARI MONGODB
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal konek database: " + ex.Message);
            }

            // 3. PASANG EVENT (Agar tombol berfungsi)
            // Pastikan nama tombol di Designer: btnSimpan, btnHapus, btnClear
            btnSimpan.Click += BtnSimpan_Click;
            btnHapus.Click += BtnHapus_Click;

            // Event klik tabel
            dgvData.CellClick += DgvData_CellClick;
        }

        // --- FUNGSI TAMPILKAN DATA ---
        private void LoadData()
        {
            try
            {
                // Ambil semua data dari Atlas
                var data = _collection.Find(new BsonDocument()).ToList();
                dgvData.DataSource = data;

                // Sembunyikan kolom ID yang panjang (Opsional)
                if (dgvData.Columns["Id"] != null) dgvData.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        // --- TOMBOL SIMPAN / UPDATE ---
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input sederhana
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtBerat.Text))
            {
                MessageBox.Show("Nama Sampah dan Berat wajib diisi!");
                return;
            }

            try
            {
                // Siapkan objek data
                var dataBaru = new SampahModel
                {
                    Nama = txtNama.Text,
                    Jenis = cmbJenis.Text, // Pastikan ada combobox di designer

                    // Konversi string ke angka (Handle error jika user input huruf)
                    Berat = double.TryParse(txtBerat.Text, out double b) ? b : 0,
                    VolumeSampah = double.TryParse(txtVolume.Text, out double v) ? v : 0,
                    NamaWilayah = txtWilayah.Text,

                    TanggalInput = DateTime.Now // Atau gunakan dtpTanggal.Value jika ada datetimepicker
                };

                if (string.IsNullOrEmpty(_selectedId))
                {
                    // MODE INSERT (Tambah Baru)
                    _collection.InsertOne(dataBaru);
                    MessageBox.Show("Data berhasil disimpan ke Cloud!");
                }
                else
                {
                    // MODE UPDATE (Edit yang sudah ada)
                    dataBaru.Id = _selectedId; // Pasang ID lama
                    _collection.ReplaceOne(x => x.Id == _selectedId, dataBaru);
                    MessageBox.Show("Data berhasil diperbarui!");
                }

                ResetForm();
                LoadData(); // Refresh tabel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Simpan: " + ex.Message);
            }
        }

        // --- TOMBOL HAPUS ---
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Klik dulu baris di tabel yang mau dihapus!");
                return;
            }

            if (MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _collection.DeleteOne(x => x.Id == _selectedId);
                    MessageBox.Show("Data terhapus.");
                    ResetForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }
        }

        // --- SAAT TABEL DIKLIK (ISI INPUTAN OTOMATIS) ---
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvData.Rows[e.RowIndex];

                // Ambil ID (Penting untuk Edit/Hapus)
                _selectedId = row.Cells["Id"].Value.ToString();

                // Masukkan data ke kotak input
                txtNama.Text = row.Cells["Nama"].Value?.ToString();
                cmbJenis.Text = row.Cells["Jenis"].Value?.ToString();
                txtBerat.Text = row.Cells["Berat"].Value?.ToString();
                txtVolume.Text = row.Cells["VolumeSampah"].Value?.ToString(); // Pastikan kolom ini ada di Model
                txtWilayah.Text = row.Cells["NamaWilayah"].Value?.ToString();
            }
        }

        private void ResetForm()
        {
            txtNama.Clear();
            txtBerat.Clear();
            txtVolume.Clear();
            txtWilayah.Clear();
            cmbJenis.SelectedIndex = -1;
            _selectedId = ""; // Reset status ID
            txtNama.Focus();
        }
    }
}