using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class LaporanJabar : Form
    {
        public LaporanJabar()
        {
            InitializeComponent();
            // Pastikan panel loading tersembunyi saat pertama kali muncul
            pnlLoading.Visible = false;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            // 1. Tampilkan Tampilan Loading
            pnlLoading.Visible = true;
            pnlLoading.BringToFront();
            tlpKontenCard.Enabled = false; // Mencegah klik ganda

            // 2. Simulasi Proses Pembuatan PDF (3 detik)
            // Di sini Anda bisa memasukkan kode iText7 nantinya
            await Task.Delay(3000);

            // 3. Sembunyikan kembali Loading
            pnlLoading.Visible = false;
            tlpKontenCard.Enabled = true;

            // 4. Beri notifikasi ke user
            MessageBox.Show("Laporan PDF Sampah Jabar berhasil disiapkan dan diunduh!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menampilkan preview data sebelum dicetak...", "Preview");
        }
    }
}