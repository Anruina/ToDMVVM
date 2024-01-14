using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ToDMVVM.MVVM.Models;

namespace ToDMVVM.Data.APIService
{
    public class MemeService
    {
        private HttpClient _httpClient;
        private JsonSerializerOptions _jsonSerializerOptions;

        public MemeService()
        {
            _httpClient = new HttpClient(new HttpClientHandler());
            _httpClient.BaseAddress = new Uri("https://meme-api.com/gimme/ProgrammerHumor");

            _jsonSerializerOptions = new JsonSerializerOptions
            {

                ReferenceHandler = ReferenceHandler.Preserve,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true

            };
        }
        public async Task<string> GetMeme()
        {
            HttpResponseMessage Response = await _httpClient.GetAsync("");

            if (Response.IsSuccessStatusCode)
            {
                string Content = await Response.Content.ReadAsStringAsync();
                MemeResponseModel? Meme = System.Text.Json.JsonSerializer.Deserialize<MemeResponseModel>(Content, _jsonSerializerOptions);
                return Meme.URL;
            }

            return "";

        }
    }
}
