# aplikasi-sampah-jabar
## 🌟 Fitur Unggulan (Key Features)

Aplikasi ini dirancang dengan arsitektur **Front-End** dan **Back-End** yang terpisah untuk memastikan modularitas dan kemudahan pengembangan. Berikut adalah fitur utamanya:

### 1. 📡 Integrasi Open Data Jabar (API Consumption)
*(Terkait Branch: `feature/be-crud-sampah` & `feature/be-data-analytics`)*
Aplikasi ini terhubung langsung dengan **API Publik Pemerintah Provinsi Jawa Barat** untuk mendapatkan data real-time mengenai:
* Volume produksi sampah harian per Kabupaten/Kota.
* Statistik jenis sampah (Organik/Anorganik).
* Data ini diambil secara otomatis untuk memastikan pengguna melihat informasi terkini tanpa input manual.

### 2. 📊 Dashboard & Analisis Data
*(Terkait Branch: `feature/fe-ui-dashboard` & `feature/be-data-analytics`)*
Menyajikan data mentah menjadi informasi visual yang mudah dipahami:
* **Grafik Tren:** Visualisasi kenaikan/penurunan volume sampah.
* **Kartu Statistik:** Ringkasan total sampah harian dan rata-rata bulanan.
* Membantu pengambil keputusan untuk melihat wilayah mana yang kritis.

### 3. 🗺️ Pemetaan Geografis (GIS Visualization)
*(Terkait Branch: `feature/fe-map-visual`)*
Visualisasi data berbasis lokasi (peta) untuk wilayah Jawa Barat:
* **Zonasi Warna:** Menampilkan peta Jabar dengan indikator warna (Merah = Volume Sampah Tinggi, Hijau = Rendah).
* Interaktif: Klik pada wilayah peta untuk melihat detail data kota tersebut.

### 4. 🤖 Smart Chatbot Assistant
*(Terkait Branch: `feature/be-chatbot-logic` & `feature/fe-ui-chatbot`)*
Asisten virtual cerdas yang membantu pengguna:
* Menjawab pertanyaan seputar regulasi sampah di Jawa Barat.
* Memberikan tips pemilahan sampah.
* Navigasi cepat ke menu aplikasi melalui percakapan teks.

### 5. 📝 Manajemen Data Sampah (CRUD Local)
*(Terkait Branch: `feature/be-crud-sampah` & `feature/fe-ui-forms`)*
Selain data API, Admin dapat mengelola data internal:
* **Input Manual:** Menambahkan data sampah dari sumber lokal (RT/RW) yang belum terekam di API provinsi.
* **Edit & Delete:** Mengelola validitas data dalam database MongoDB.

### 6. 📄 Pelaporan Otomatis (PDF Export)
*(Terkait Branch: `feature/fe-pdf-layout`)*
Fitur untuk kebutuhan administrasi dan laporan resmi:
* Mencetak laporan volume sampah harian/bulanan ke dalam format **PDF**.
* Layout laporan yang rapi dan siap cetak untuk diserahkan ke dinas terkait.

### 7. 🔐 Sistem Otentikasi Aman
*(Terkait Branch: `feature/be-auth-logic`)*
* Login dan Registrasi untuk membatasi akses aplikasi hanya kepada petugas berwenang.
* Keamanan data user tersimpan di MongoDB.

---
