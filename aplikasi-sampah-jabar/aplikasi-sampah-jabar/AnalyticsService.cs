using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikasi_sampah_jabar
{
    public class AnalyticsService
    {
        // Koleksi (Tabel) MongoDB yang akan diolah
        private readonly IMongoCollection<SampahModel> _koleksiSampah;

        public AnalyticsService()
        {
            // Menghubungkan ke database via MongoHelper
            var database = Mo.GetDatabase();
            _koleksiSampah = database.GetCollection<SampahModel>("data_sampah_jabar");
        }

        // --- FUNGSI 1: AMBIL SEMUA DATA (READ) ---
        // Teman FE bisa pakai ini untuk menampilkan tabel/list
        public List<SampahModel> AmbilSemuaData()
        {
            // Mengambil semua dokumen dari MongoDB -> dijadikan List
            return _koleksiSampah.Find(data => true).ToList();
        }

        // --- FUNGSI 2: HITUNG TOTAL SAMPAH (SUM) ---
        // Mengembalikan angka total volume sampah se-Jabar
        public double HitungTotalVolume()
        {
            var semuaData = AmbilSemuaData();
            if (semuaData.Count == 0) return 0;

            // Logika penjumlahan
            return semuaData.Sum(x => x.VolumeSampah);
        }

        // --- FUNGSI 3: HITUNG RATA-RATA (AVERAGE) ---
        public double HitungRataRata()
        {
            var semuaData = AmbilSemuaData();
            if (semuaData.Count == 0) return 0;

            return semuaData.Average(x => x.VolumeSampah);
        }

        // --- FUNGSI 4: CARI KOTA TERKOTOR (MAX) ---
        // Mengembalikan objek 'SampahModel' yang volumenya paling besar
        public SampahModel CariWilayahTertinggi()
        {
            var semuaData = AmbilSemuaData();

            // Mengurutkan dari besar ke kecil (Descending), ambil yang pertama
            return semuaData.OrderByDescending(x => x.VolumeSampah).FirstOrDefault();
        }

        // --- FUNGSI 5: HITUNG JUMLAH DATA MASUK (COUNT) ---
        public int HitungJumlahData()
        {
            return (int)_koleksiSampah.CountDocuments(data => true);
        }
    }
}