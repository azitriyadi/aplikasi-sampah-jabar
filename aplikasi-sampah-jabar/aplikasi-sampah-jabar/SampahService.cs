using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace aplikasi_sampah_jabar
{
    public class SampahService
    {
        private readonly IMongoCollection<SampahModel> _koleksi;

        public SampahService()
        {
            var db = MongoHelper.GetDatabase();
            _koleksi = db.GetCollection<SampahModel>("data_sampah");
        }

        // 1. CREATE (Tambah Data)
        public void TambahSampah(string nama, string jenis, double berat)
        {
            var dataBaru = new SampahModel
            {
                // Id otomatis dibuat MongoDB
                NamaWilayah = nama, // Asumsi form ini input Nama Wilayah/Sampah
                Jenis = jenis,     // Pastikan di SampahModel ada properti 'Jenis'
                VolumeSampah = berat,
                TanggalInput = DateTime.Now
            };
            _koleksi.InsertOne(dataBaru);
        }

        // 2. READ (Ambil Semua Data)
        public List<SampahModel> AmbilSemuaData()
        {
            return _koleksi.Find(s => true).ToList();
        }

        // 3. UPDATE (Edit Data)
        public void UpdateSampah(string id, string nama, string jenis, double berat)
        {
            var filter = Builders<SampahModel>.Filter.Eq(s => s.Id, id);
            var update = Builders<SampahModel>.Update
                .Set(s => s.NamaWilayah, nama)
                .Set(s => s.Jenis, jenis)
                .Set(s => s.VolumeSampah, berat);

            _koleksi.UpdateOne(filter, update);
        }

        // 4. DELETE (Hapus Data)
        public void HapusSampah(string id)
        {
            var filter = Builders<SampahModel>.Filter.Eq(s => s.Id, id);
            _koleksi.DeleteOne(filter);
        }
    }
}