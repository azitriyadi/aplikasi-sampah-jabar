using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace aplikasi_sampah_jabar
{
    public class SampahModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nama_sampah")]
        public string? Nama { get; set; }

        [BsonElement("jenis_sampah")]
        public string? Jenis { get; set; } // Organik / Anorganik

        // --- INI YANG HILANG DAN MENYEBABKAN ERROR ---
        [BsonElement("berat_kg")]
        public double Berat { get; set; }
        // ---------------------------------------------

        [BsonElement("volume_m3")]
        public double VolumeSampah { get; set; } // Dibutuhkan Chatbot/Analytics

        [BsonElement("nama_wilayah")]
        public string? NamaWilayah { get; set; } // Dibutuhkan Chatbot/Analytics

        [BsonElement("tanggal_input")]
        public DateTime TanggalInput { get; set; }
    }
}