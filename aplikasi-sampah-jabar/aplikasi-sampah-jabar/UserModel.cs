using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace aplikasi_sampah_jabar
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; } // Disimpan dalam bentuk ter-enkripsi (Hash)

        [BsonElement("role")]
        public string Role { get; set; } // Contoh: "admin", "petugas"

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}