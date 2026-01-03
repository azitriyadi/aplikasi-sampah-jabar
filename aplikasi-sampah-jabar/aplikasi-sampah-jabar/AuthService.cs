using MongoDB.Driver;
using System;
using System.Text;
using System.Security.Cryptography; // Untuk bikin password aman (Hashing)
using System.Linq;

namespace aplikasi_sampah_jabar
{
    public class AuthService
    {
        private readonly IMongoCollection<UserModel> _users;

        public AuthService()
        {
            var database = MongoHelper.GetDatabase();
            _users = database.GetCollection<UserModel>("users");
        }

        // --- FUNGSI 1: REGISTER (DAFTAR BARU) ---
        public bool Register(string username, string password, string role)
        {
            // 1. Cek apakah username sudah ada?
            var userAda = _users.Find(u => u.Username == username).FirstOrDefault();
            if (userAda != null)
            {
                throw new Exception("Username sudah terpakai!");
            }

            // 2. Enkripsi password sebelum disimpan
            string passwordHash = HashPassword(password);

            // 3. Simpan ke database
            var newUser = new UserModel
            {
                Username = username,
                Password = passwordHash,
                Role = role,
                CreatedAt = DateTime.Now
            };

            _users.InsertOne(newUser);
            return true;
        }

        // --- FUNGSI 2: LOGIN (MASUK) ---
        public UserModel Login(string username, string password)
        {
            // 1. Cari user berdasarkan username
            var user = _users.Find(u => u.Username == username).FirstOrDefault();

            if (user == null)
            {
                // User tidak ditemukan
                return null;
            }

            // 2. Cek Password:
            // Kita hash password inputan, lalu bandingkan dengan hash di database
            string inputHash = HashPassword(password);

            if (user.Password == inputHash)
            {
                return user; // Login Sukses! Kembalikan data user
            }
            else
            {
                return null; // Password Salah
            }
        }

        // --- FUNGSI RAHASIA: ENKRIPSI PASSWORD (SHA256) ---
        private string HashPassword(string rawPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Mengubah string jadi byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawPassword));

                // Mengubah byte array jadi string kembali
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}