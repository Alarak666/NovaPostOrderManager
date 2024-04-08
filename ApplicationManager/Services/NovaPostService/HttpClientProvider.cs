﻿using Newtonsoft.Json;
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
            var responseContent = "";
            try
            {

                var json = JsonConvert.SerializeObject(request);
                var requestContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("", requestContent);
                responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TResult>(responseContent);
            }
            catch (Exception e)
            {
                Log.Information(e, responseContent);
                Console.WriteLine(e);
                throw;
            }
            //finally
            //{
            //    #if DEBUG
            //    var options = new JsonSerializerOptions { WriteIndented = true };
            //    Log.Information(
            //        JsonConvert.SerializeObject(new
            //        {
            //            message = !string.IsNullOrWhiteSpace(responseContent) ? responseContent : "Впав не доходячи до response"
            //        }), options);
            //    #endif
            //}
        }
    }
}