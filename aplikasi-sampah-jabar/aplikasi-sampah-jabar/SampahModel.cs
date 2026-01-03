using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace aplikasi_sampah_jabar
{
    // UBAH 'internal' JADI 'public' 👇
    public class SampahModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nama_sampah")]
        public string Nama { get; set; }

        [BsonElement("jenis_sampah")]
        public string Jenis { get; set; } // Organik / Anorganik

        [BsonElement("berat_kg")]
        public double Berat { get; set; }

        [BsonElement("tanggal_input")]
        public DateTime Tanggal { get; set; }
    }
}