using Core.Constants.DefaultValues;
using Core.Dto.Settlements.GetWarehouses;
using Core.Dto.Settlements.GetWarehouses.Request;
using Core.Dto.Settlements.GetWarehouses.Response;
using Core.Dto.Settlements.GetWarehouseTypes;
using Core.Dto.Settlements.GetWarehouseTypes.Request;
using Core.Dto.Settlements.GetWarehouseTypes.Response;
using Core.Dto.Settlements.SearchSettlement;
using Core.Dto.Settlements.SearchSettlement.Request;
using Core.Dto.Settlements.SearchSettlementStreet;
using Core.Dto.Settlements.SearchSettlementStreet.Request;
using Core.Dto.Settlements.SearchSettlementStreet.Response;

namespace ApplicationManager.Services.NovaPostService;

public class SearchSettlementService
{
    private readonly HttpClientProvider httpClientProvider = new HttpClientProvider();
    public async Task<SearchSettlementResponse> GetCityForValidData()
    {
        var request = new SearchSettlementRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Address",
            calledMethod = "searchSettlements",
            methodProperties = new SearchSettlementProperty()
            {
                CityName = "Київ",
                Limit = "1",
                Page = "1"
            }
        };

        var response = await httpClientProvider.SendRequestAsync<SearchSettlementRequest, SearchSettlementResponse>(request);

        return response;
    }
    public async Task<SearchSettlementResponse> GetCityData(string cityName)
    {
        var request = new SearchSettlementRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
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
    public async Task<SearchSettlementResponse> GetStreetData(string streetName, string settlementRef)
    {
        var request = new SearchSettlementStreetRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Address",
            calledMethod = "searchSettlementStreets",
            methodProperties = new SearchSettlementStreetProperty()
            {
                StreetName = streetName,
                SettlementRef = settlementRef,
                Limit = "10"
            }
        };

        var response = await httpClientProvider.SendRequestAsync<SearchSettlementStreetRequest, SearchSettlementResponse>(request);

        return response;
    }
    public async Task<GetWarehouseResponse> GetAddress(string? cityName = null, string? @ref = null, string? warehouseId = null)
    {
        var request = new GetWarehouseRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Address",
            calledMethod = "getWarehouses",
            methodProperties = new GetWarehouseProperty
            {
                CityName = cityName,
                Ref = @ref,
                WarehouseId = warehouseId,
                Page = "1",
                Limit = "50",
                Language = "UA"
            }
        };

        return await httpClientProvider.SendRequestAsync<GetWarehouseRequest, GetWarehouseResponse>(request);
    }
    public async Task<GetWarehouseTypeResponse> GetWarehouseTypes()
    {
        var request = new GetWarehouseTypeRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Address",
            calledMethod = "getWarehouseTypes",
            methodProperties = new GetWarehouseTypeProperty()

        };

        return await httpClientProvider.SendRequestAsync<GetWarehouseTypeRequest, GetWarehouseTypeResponse>(request);
    }
}