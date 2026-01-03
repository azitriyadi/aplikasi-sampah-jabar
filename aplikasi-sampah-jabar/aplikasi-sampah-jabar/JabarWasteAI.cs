using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks; // Wajib untuk Async
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class JabarWasteAI : Form
    {
        // --- 1. SETTING API KEY ---
        // Tempel API Key Mistral kamu di dalam tanda kutip di bawah ini!
        private const string API_KEY = "HN62NiPH8oNq5If7f19dZGKFksJ3SwMe";

        // Service penghubung ke AI
        private ChatbotService _aiService;

        // Riwayat Chat (Supaya AI ingat konteks pembicaraan sebelumnya)
        private List<ChatMessage> _chatHistory;

        public JabarWasteAI()
        {
            InitializeComponent();

            // Inisialisasi Service & List
            _aiService = new ChatbotService();
            _chatHistory = new List<ChatMessage>();

            // Setup Pesan Awal (System Prompt)
            // Ini agar AI tahu dia berperan sebagai siapa
            _chatHistory.Add(new ChatMessage
            {
                role = "system",
                content = "Kamu adalah asisten pintar bernama 'Jabar Waste AI'. Tugasmu membantu menjawab pertanyaan seputar pengelolaan sampah, daur ulang, dan lingkungan hidup di Jawa Barat. Jawab dengan ramah, singkat, dan jelas."
            });

            // Sapaan pembuka di layar
            AddMessageBubble("Halo! Saya Jabar Waste AI. Ada yang bisa saya bantu tentang sampah hari ini?", false);
        }

        // --- EVENT KLIK TOMBOL KIRIM ---
        // Perhatikan ada kata 'async' karena kita akan request ke internet
        private async void btnKirim_Click(object sender, EventArgs e)
        {
            string userText = txtInput.Text.Trim();

            // Cek jika kosong
            if (string.IsNullOrWhiteSpace(userText)) return;

            // 1. Tampilkan Pesan User di Layar
            AddMessageBubble(userText, true);
            txtInput.Clear();
            txtInput.Enabled = false; // Kunci input biar gak spam
            btnKirim.Enabled = false;
            btnKirim.Text = "Loading...";

            try
            {
                // 2. Masukkan pesan user ke History
                _chatHistory.Add(new ChatMessage { role = "user", content = userText });

                // 3. KIRIM KE API MISTRAL (Proses Internet)
                // Kita pakai model "open-mistral-7b" karena gratis dan cepat
                string jawabanAI = await _aiService.KirimPesanKeAI(API_KEY, "open-mistral-7b", _chatHistory);

                // 4. Masukkan jawaban AI ke History (Biar dia ingat)
                _chatHistory.Add(new ChatMessage { role = "assistant", content = jawabanAI });

                // 5. Tampilkan Jawaban AI di Layar
                AddMessageBubble(jawabanAI, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message);
                AddMessageBubble("Maaf, saya sedang pusing (Error Koneksi). Coba lagi ya.", false);
            }
            finally
            {
                // Buka kunci input
                txtInput.Enabled = true;
                btnKirim.Enabled = true;
                btnKirim.Text = "Kirim";
                txtInput.Focus();
            }
        }

        // --- FUNGSI MEMBUAT BALON CHAT (UI) ---
        private void AddMessageBubble(string text, bool isUser)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(pnlChatHistory.Width - 50, 0); // Batas lebar biar teks turun ke bawah
            lbl.Padding = new Padding(10);
            lbl.Font = new Font("Segoe UI", 10);
            lbl.Margin = new Padding(0, 0, 0, 10); // Jarak antar chat

            if (isUser)
            {
                // Tampilan User (Oranye, Rata Kanan)
                lbl.BackColor = Color.FromArgb(245, 158, 11);
                lbl.ForeColor = Color.White;
                // Trik rata kanan di FlowLayoutPanel agak tricky, 
                // tapi kita bedakan warnanya saja sudah cukup jelas.
            }
            else
            {
                // Tampilan AI (Abu-abu, Rata Kiri)
                lbl.BackColor = Color.FromArgb(233, 236, 239);
                lbl.ForeColor = Color.Black;
            }

            pnlChatHistory.Controls.Add(lbl);

            // Scroll otomatis ke bawah
            pnlChatHistory.ScrollControlIntoView(lbl);
        }
    }
}