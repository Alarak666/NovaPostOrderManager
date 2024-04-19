using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;
using System.Text;
using System.Text.Json;

namespace ApplicationManager.Services.NovaPostService
{
    public class HttpClientProvider
    {
        private readonly HttpClient _httpClient;

        public HttpClientProvider(string url = "https://api.novaposhta.ua/v2.0/json/")
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }
        public async Task<HttpResponseMessage> Post(string url, HttpContent content)
        {
            return await _httpClient.PostAsync(url, content);
        }
        public async Task<T> DownloadAsync<T>(string relativeUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(relativeUrl);
            response.EnsureSuccessStatusCode(); // Гарантируем успешный ответ

            // Читаем содержимое ответа и десериализуем его в объект
            string jsonString = await response.Content.ReadAsStringAsync();
            T deserializedObject = JsonConvert.DeserializeObject<T>(jsonString);
            return deserializedObject;
        }
        public async Task<TResult> SendRequestAsync<TData, TResult>(TData request)
        {
            try
            {
                var json = JsonConvert.SerializeObject(request);
                var requestContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("", requestContent);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    Log.Information("Помилка HTTP запиту. Статус код: {StatusCode}. Відповідь: {Response}", response.StatusCode, responseContent);
                    Console.WriteLine("Помилка при виконанні запиту. Перевірте деталі в логах.");
                    return default;
                }

                return JsonConvert.DeserializeObject<TResult>(responseContent);
            }
            catch (HttpRequestException e) when (e.InnerException is System.Security.Authentication.AuthenticationException)
            {
                Log.Information(e, "Помилка SSL з'єднання. Деталі: {0}", e.InnerException?.Message);
                Console.WriteLine("Будь ласка, перевірте інтернет з'єднання.");
                throw;
            }
            catch (Exception e)
            {
                Log.Information(e, "Виникла непередбачена помилка при обробці запиту.");
                Console.WriteLine("Критична помилка: " + e.Message);
                throw;
            }

        }
    }
}