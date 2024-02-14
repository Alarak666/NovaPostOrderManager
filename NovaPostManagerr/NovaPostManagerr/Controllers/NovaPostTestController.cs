using System.Text.Json;
using Core.Dto;
using Microsoft.AspNetCore.Mvc;

namespace NovaPostManagerr.Controllers
{///
    [ApiController]
    [Route("[controller]")]
    public class NovaPostTestController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public NovaPostTestController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("GetMisto")]
        public async Task<ActionResult<NovaPostResponse>> GetMistoAsync()
        {
            var requestContent = new NovaPostRequest
            {
                apiKey = "7fc4868a7f41a2aafc3e718ab77a4613",
                modelName = "Address",
                calledMethod = "searchSettlements",
                methodProperties = new NovaPostRequestProperties
                {
                    CityName = "київ",
                    Limit = "50",
                    Page = "1"
                }
            };

            var httpContent = new StringContent(JsonSerializer.Serialize(requestContent), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://api.novaposhta.ua/v2.0/json/", httpContent);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var novaPostResponse = JsonSerializer.Deserialize<NovaPostResponse>(responseString);
                // Теперь у вас есть десериализованный объект ответа, который можно использовать в коде.
                return Ok(novaPostResponse);
            }

            return StatusCode((int)response.StatusCode, "Ошибка запроса к API Новой Почты");
        }
    }
}

