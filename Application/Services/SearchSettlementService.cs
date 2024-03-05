using System.Net.Http.Json;
using System.Text.Json;
using Core.Dto;
using Core.Dto.Base;
using Core.Dto.SearchSettlement;
using Core.Dto.SearchSettlement.Request;
using Core.Dto.SearchSettlement.Response;
using Core.Interface;

namespace Application.Services;

public class SearchSettlementService : ISearchSettlementService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "7fc4868a7f41a2aafc3e718ab77a4613";

    public SearchSettlementService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<SearchSettlementResponse> GetCityData(string cityName)
    {
        var request = new SearchSettlementRequest
        {
            apiKey = _apiKey,
            modelName = "Address",
            calledMethod = "searchSettlements",
            methodProperties = new SearchSettlementProperty()
            {
                CityName = cityName,
                Limit = "10",
                Page = "1"
            }
        };

        var httpContent = new StringContent(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("https://api.novaposhta.ua/v2.0/json/", httpContent);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true, // Если имена свойств в JSON не совпадают по регистру
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        };
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<SearchSettlementResponse>(responseString, options);
            return result;
        }
        return null;
    }
}