namespace aplikasi_sampah_jabar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Panggil class MongoHelper
                var db = MongoHelper.GetDatabase();

                // 2. Ambil nama database untuk membuktikan koneksi
                string namaDatabase = db.DatabaseNamespace.DatabaseName;

                // 3. Tampilkan pesan sukses
                MessageBox.Show("ALHAMDULILLAH! \nKoneksi Sukses ke: " + namaDatabase, "Info Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Jika gagal, tampilkan pesan error
                MessageBox.Show("GAGAL KONEK: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
