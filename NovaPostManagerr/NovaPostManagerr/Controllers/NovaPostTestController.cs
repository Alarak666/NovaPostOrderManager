using System.Text.Json;
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

    public class NovaPostRequest
    {
        public string apiKey { get; set; }
        public string modelName { get; set; }
        public string calledMethod { get; set; }
        public NovaPostRequestProperties methodProperties { get; set; }
    }

    public class NovaPostRequestProperties
    {
        public string CityName { get; set; }
        public string Limit { get; set; }
        public string Page { get; set; }
    }





    public class NovaPostResponse
    {
        public bool success { get; set; }
        public List<NovaPostData> data { get; set; }
        public List<object> errors { get; set; }
        public List<object> warnings { get; set; }
        public List<object> info { get; set; }
        public List<object> messageCodes { get; set; }
        public List<object> errorCodes { get; set; }
        public List<object> warningCodes { get; set; }
        public List<object> infoCodes { get; set; }
    }

    public class NovaPostData
    {
        public int TotalCount { get; set; } // Изменено с string на int
        public List<NovaPostAddress> Addresses { get; set; }
        public string Warehouses { get; set; }
        public string MainDescription { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string SettlementTypeCode { get; set; }
        public string Ref { get; set; }
        public string DeliveryCity { get; set; }
    }

    public class NovaPostAddress
    {
        public int Warehouses { get; set; } // Предполагаем, что это тоже должно быть числом, исправлено с string на int
        public string MainDescription { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string SettlementTypeCode { get; set; }
        public string Ref { get; set; }
        public string DeliveryCity { get; set; }
    }
}

