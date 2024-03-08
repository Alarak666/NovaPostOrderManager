using Newtonsoft.Json;
using System.Text;

namespace ApplicationManager.Services
{
    public class HttpClientProvider
    {
        private readonly HttpClient _httpClient;

        public HttpClientProvider()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.novaposhta.ua/v2.0/json/");
        }
        public async Task<HttpResponseMessage> Post(string url, HttpContent content)
        {
            return await _httpClient.PostAsync(url, content);
        }

        public async Task<TResult> SendRequestAsync<TData, TResult>(TData request)
        {
            try
            {
                var json = JsonConvert.SerializeObject(request);
                var requestContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("", requestContent);

                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(responseContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
    }
}