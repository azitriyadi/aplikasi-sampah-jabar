using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aplikasi_sampah_jabar // SESUAIKAN NAMESPACE
{
    // --- MODEL DATA (DTO) ---
    public class ChatMessage
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    public class MistralApiResponse
    {
        public List<Choice> choices { get; set; }
    }

    public class Choice
    {
        public ChatMessage message { get; set; }
    }

    // --- SERVICE UTAMA ---
    public class ChatbotService
    {
        private readonly HttpClient _httpClient;
        private const string MistralApiUrl = "https://api.mistral.ai/v1/chat/completions";

        // Mapping nama model di UI ke nama model asli API
        private readonly Dictionary<string, string> _modelMap = new Dictionary<string, string>
        {
            { "mistral-tiny", "open-mistral-7b" },
            { "mistral-small", "open-mixtral-8x7b" },
            { "mistral-medium", "mistral-large-latest" },
            { "open-mistral-7b", "open-mistral-7b" },
            { "open-mixtral-8x7b", "open-mixtral-8x7b" }
        };

        public ChatbotService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> KirimPesanKeAI(string apiKey, string modelUiName, List<ChatMessage> history)
        {
            // 1. Tentukan Model Asli
            string realModel = _modelMap.ContainsKey(modelUiName) ? _modelMap[modelUiName] : "mistral-large-latest";

            // 2. Siapkan Body Request
            var body = new
            {
                model = realModel,
                messages = history,
                max_tokens = 512,
                temperature = 0.7
            };

            string json = JsonConvert.SerializeObject(body);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            // 3. Setup Header Authorization
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            // 4. Kirim Request
            HttpResponseMessage response = await _httpClient.PostAsync(MistralApiUrl, content);
            string responseText = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Gagal Konek API: {response.StatusCode}\n{responseText}");
            }

            // 5. Baca Hasil
            var apiResponse = JsonConvert.DeserializeObject<MistralApiResponse>(responseText);

            if (apiResponse?.choices != null && apiResponse.choices.Count > 0)
            {
                return apiResponse.choices[0].message?.content ?? "Balasan kosong.";
            }

            return "Tidak ada respons dari AI.";
        }
    }
}