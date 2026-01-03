using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver; // <--- WAJIB: Pastikan ini tidak error (merah)
using MongoDB.Bson;

namespace aplikasi_sampah_jabar
{
    // Ubah 'internal' jadi 'public' agar bisa dipanggil dari Form manapun
    public class MongoHelper
    {
        // --- BAGIAN INI YANG HARUS KAMU ISI ---

        // CONTOH YANG BENAR (Perhatikan tidak ada tanda < >)
        private static string connectionString = "mongodb+srv://azi_admin:JabarJuara123@himatif-db.wtbpb32.mongodb.net/?appName=himatif-db";

        // Nama database (bebas, kalau belum ada nanti otomatis dibuatkan oleh MongoDB)
        private static string databaseName = "db_sampah_jabar";

        // --- FUNGSI PEMANGGIL ---
        public static IMongoDatabase GetDatabase()
        {
            try
            {
                // Membuat klien (supir) untuk menyetir koneksi
                var client = new MongoClient(connectionString);

                // Mengambil database spesifik
                return client.GetDatabase(databaseName);
            }
            catch (Exception ex)
            {
                // Kalau error, lempar pesan errornya biar ketahuan
                throw new Exception("Gagal terhubung ke MongoDB: " + ex.Message);
            }
        }
    }
}