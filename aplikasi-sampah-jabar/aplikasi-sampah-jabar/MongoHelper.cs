using MongoDB.Driver;
using System;

namespace aplikasi_sampah_jabar
{
    public class MongoHelper
    {
        // GANTI BAGIAN INI DENGAN YANG KAMU COPY DARI ATLAS
        // 1. Pastikan username: admin_sampah
        // 2. Pastikan password: Password yang kamu buat untuk admin_sampah
        // 3. Pastikan alamat cluster benar (sesuai tombol Connect)

        private static string connectionString = "mongodb+srv://admin_sampah:admin123@himatif-db.wtbpb32.mongodb.net/?appName=himatif-db";

        private static string databaseName = "db_sampah_jabar";

        public static IMongoDatabase GetDatabase()
        {
            try
            {
                var settings = MongoClientSettings.FromConnectionString(connectionString);
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                var client = new MongoClient(settings);
                return client.GetDatabase(databaseName);
            }
            catch (Exception ex)
            {
                // Ini biar kita tahu errornya apa kalau gagal konek
                throw new Exception("Gagal Konek ke Atlas. Cek Password & IP Whitelist! Error: " + ex.Message);
            }
        }
    }
}