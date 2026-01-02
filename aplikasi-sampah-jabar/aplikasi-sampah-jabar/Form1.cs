using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MistralChatbot
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private readonly List<ChatMessage> _conversationHistory;

        private const string MistralApiUrl = "https://api.mistral.ai/v1/chat/completions";

        // ===============================
        // MODEL UI (SESUAI DOSEN)
        // ===============================
        private readonly string[] _uiModels =
        {
            "mistral-tiny",
            "mistral-small",
            "mistral-medium",
            "open-mistral-7b",
            "open-mixtral-8x7b"
        };

        // ===============================
        // MODEL MAPPING (UNTUK API)
        // ===============================
        private readonly Dictionary<string, string> _modelMap = new()
        {
            { "mistral-tiny", "open-mistral-7b" },
            { "mistral-small", "open-mixtral-8x7b" },
            { "mistral-medium", "mistral-large-latest" },
            { "open-mistral-7b", "open-mistral-7b" },
            { "open-mixtral-8x7b", "open-mixtral-8x7b" }
        };

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _conversationHistory = new List<ChatMessage>();

            InitializeConversation();
            InitializeModelDropdown();
        }

        // ===============================
        // INIT
        // ===============================
        private void InitializeModelDropdown()
        {
            cmbModel.Items.Clear();
            cmbModel.Items.AddRange(_uiModels);
            cmbModel.SelectedIndex = 0;
        }

        private void InitializeConversation()
        {
            _conversationHistory.Add(new ChatMessage
            {
                role = "system",
                content = "Anda adalah Mistral AI, asisten AI yang membantu dan ramah."
            });

            UpdateConversationDisplay();
        }

        // ===============================
        // EVENTS
        // ===============================
        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        private async void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !ModifierKeys.HasFlag(Keys.Shift))
            {
                e.Handled = true;
                await SendMessage();
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem is string selected)
                lblModelInfo.Text = $"Model: {selected}";
        }

        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
            txtApiKey.BackColor =
                txtApiKey.Text.Length > 10 ? Color.LightGreen : Color.White;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _conversationHistory.Clear();
            InitializeConversation();
            lblStatus.Text = "Percakapan dibersihkan";
        }

        // ===============================
        // CHAT LOGIC
        // ===============================
        private async Task SendMessage()
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Pesan tidak boleh kosong");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApiKey.Text))
            {
                MessageBox.Show("API Key belum diisi");
                return;
            }

            _conversationHistory.Add(new ChatMessage
            {
                role = "user",
                content = txtMessage.Text.Trim()
            });

            txtMessage.Clear();
            UpdateConversationDisplay();

            try
            {
                string response = await GetMistralResponse();

                _conversationHistory.Add(new ChatMessage
                {
                    role = "assistant",
                    content = response
                });

                UpdateConversationDisplay();
                lblStatus.Text = "Siap";
            }
            catch (Exception ex)
            {
                _conversationHistory.Add(new ChatMessage
                {
                    role = "assistant",
                    content = $"? ERROR:\n{ex.Message}"
                });

                UpdateConversationDisplay();
                lblStatus.Text = "Error";
            }
        }

        // ===============================
        // API CALL (AMAN)
        // ===============================
        private async Task<string> GetMistralResponse()
        {
            lblStatus.Text = "Menghubungi Mistral...";

            var body = new
            {
                model = GetSelectedModel(),
                messages = _conversationHistory,
                max_tokens = 512,
                temperature = 0.7
            };

            string json = JsonConvert.SerializeObject(body);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add(
                "Authorization",
                $"Bearer {txtApiKey.Text.Trim()}"
            );
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage response =
                await _httpClient.PostAsync(MistralApiUrl, content);

            string responseText = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"HTTP {(int)response.StatusCode}\n{responseText}");

            var apiResponse =
                JsonConvert.DeserializeObject<MistralApiResponse>(responseText);

            return apiResponse?.choices != null && apiResponse.choices.Count > 0
                ? apiResponse.choices[0].message?.content ?? "Respons kosong"
                : "Tidak ada respons";
        }

        private string GetSelectedModel()
        {
            if (cmbModel.SelectedItem is not string selected)
                return "mistral-large-latest";

            // Mapping UI -> model valid API
            return _modelMap.TryGetValue(selected, out var realModel)
                ? realModel
                : "mistral-large-latest";
        }

        // ===============================
        // UI
        // ===============================
        private void UpdateConversationDisplay()
        {
            txtConversation.Clear();

            foreach (var m in _conversationHistory)
            {
                if (m.role == "system") continue;

                txtConversation.SelectionColor =
                    m.role == "user" ? Color.DarkBlue : Color.DarkGreen;

                txtConversation.AppendText(
                    $"{(m.role == "user" ? "?? Anda: " : "?? Mistral: ")}{m.content}\n\n"
                );
            }

            txtConversation.ScrollToCaret();
        }

        // ===============================
        // DTO
        // ===============================
        public class ChatMessage
        {
            public string? role { get; set; }
            public string? content { get; set; }
        }

        public class MistralApiResponse
        {
            public List<Choice>? choices { get; set; }
        }

        public class Choice
        {
            public ChatMessage? message { get; set; }
        }
    }
}
