using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Core.Dto;
using Core.Dto.Base;
using Core.Dto.SearchSettlement;
using Core.Dto.SearchSettlement.Request;
using Core.Dto.SearchSettlement.Response;
using Core.Interface;

namespace ApplicationManager.Services;

public class SearchSettlementService : ISearchSettlementService
{
    private readonly string _apiKey = "7a5eeeea20a44a230cf0f4d97d1beba4";
    private readonly HttpClientProvider httpClientProvider = new HttpClientProvider();
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

        var response = await httpClientProvider.SendRequestAsync<SearchSettlementRequest, SearchSettlementResponse>(request);
       
        return response;
    }
}