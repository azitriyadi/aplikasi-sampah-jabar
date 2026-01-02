using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class JabarWasteAI : Form
    {
        public JabarWasteAI()
        {
            InitializeComponent();
            // Pesan sambutan otomatis
            AddMessage("Halo! Saya Jabar Waste AI. Ada yang bisa saya bantu terkait pengelolaan sampah hari ini?", false);
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                // Tampilkan pesan user
                AddMessage(txtInput.Text, true);

                // Logika respon bot sederhana
                string userText = txtInput.Text.ToLower();
                txtInput.Clear();

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // Delay 1 detik seolah bot berpikir
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    string respon = GetBotResponse(userText);
                    AddMessage(respon, false);
                };
                timer.Start();
            }
        }

        private string GetBotResponse(string input)
        {
            if (input.Contains("jadwal")) return "Jadwal pengangkutan sampah di wilayah Jabar biasanya dilakukan setiap hari Selasa dan Jumat.";
            if (input.Contains("plastik")) return "Sampah plastik sebaiknya dipisahkan dan dibersihkan sebelum disetor ke Bank Sampah.";
            if (input.Contains("lokasi")) return "Anda bisa melihat lokasi Bank Sampah terdekat melalui menu 'Map' di sidebar.";
            return "Maaf, saya masih belajar. Bisa Anda tanyakan hal lain mengenai sampah organik, plastik, atau jadwal angkut?";
        }

        private void AddMessage(string text, bool isUser)
        {
            Label lbl = new Label();
            lbl.Text = (isUser ? "Anda: " : "AI: ") + text;
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(pnlChatHistory.Width - 40, 0);
            lbl.Padding = new Padding(10);
            lbl.Margin = new Padding(0, 5, 0, 5);

            if (isUser)
            {
                lbl.BackColor = Color.FromArgb(245, 158, 11); // Oranye (User)
                lbl.ForeColor = Color.White;
            }
            else
            {
                lbl.BackColor = Color.FromArgb(233, 236, 239); // Abu-abu (Bot)
                lbl.ForeColor = Color.Black;
            }

            pnlChatHistory.Controls.Add(lbl);
            pnlChatHistory.ScrollControlIntoView(lbl);
        }

        private void pnlChatHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}