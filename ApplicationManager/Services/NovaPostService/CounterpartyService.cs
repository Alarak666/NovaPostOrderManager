using Core.Constants.DefaultValues;
using Core.Dto.Conterparties.CreateCounterparties;
using Core.Dto.Conterparties.CreateCounterparties.Request;
using Core.Dto.Conterparties.CreateCounterparties.Response;
using Core.Dto.Conterparties.GetCounterparties;
using Core.Dto.Conterparties.GetCounterparties.Request;
using Core.Dto.Conterparties.GetCounterparties.Response;
using Core.Dto.Conterparties.GetCounterpartyAddresses;
using Core.Dto.Conterparties.GetCounterpartyAddresses.Request;
using Core.Dto.Conterparties.GetCounterpartyAddresses.Response;
using Core.Dto.Conterparties.GetCounterpartyContactPersons;
using Core.Dto.Conterparties.GetCounterpartyContactPersons.Request;
using Core.Dto.Conterparties.GetCounterpartyContactPersons.Response;

namespace ApplicationManager.Services.NovaPostService;

public class CounterpartyService
{
    private readonly HttpClientProvider _httpClientProvider = new();

    public async Task<GetCounterpartyResponse> GetCounterparty(string counterpartyProperty, string? findByString = null)
    {
        var request = new GetCounterpartyRequest()
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Counterparty",
            calledMethod = "getCounterparties",
            methodProperties = new GetCounterpartyProperty()
            {
                CounterpartyProperty = counterpartyProperty,
                FindByString = findByString,
                Page = "1",
            }
        };

        return await _httpClientProvider.SendRequestAsync<GetCounterpartyRequest, GetCounterpartyResponse>(request);
    }
    public async Task<GetCounterpartyAddressesResponse> GetCounterpartyAddresses(string counterpartyProperty, string @ref)
    {
        var request = new GetCounterpartyAddressesRequest()
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Counterparty",
            calledMethod = "getCounterpartyAddresses",
            methodProperties = new GetCounterpartyAddressesProperty()
            {
                CounterpartyProperty = counterpartyProperty,
                Ref = @ref
            }
        };

        return await _httpClientProvider.SendRequestAsync<GetCounterpartyAddressesRequest, GetCounterpartyAddressesResponse>(request);
    }
    public async Task<GetCounterpartyContactPersonsResponse> GetCounterpartyContactPersons(string @ref)
    {
        var request = new GetCounterpartyContactPersonsRequest()
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Counterparty",
            calledMethod = "getCounterpartyContactPersons",
            methodProperties = new GetCounterpartyContactPersonsProperty()
            {
                Ref = @ref,
                Page = 1.ToString()
            }
        };

        return await _httpClientProvider.SendRequestAsync<GetCounterpartyContactPersonsRequest, GetCounterpartyContactPersonsResponse>(request);
    }
    public async Task<CreateCounterpartyResponse> CreateCounterparty(CreateCounterpartyProperty createCounterpartyProperty)
    {
        var request = new CreateCounterpartyRequest()
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Counterparty",
            calledMethod = "save",
            methodProperties = new CreateCounterpartyProperty
            {
                FirstName = createCounterpartyProperty.FirstName,
                MiddleName = createCounterpartyProperty.MiddleName,
                LastName = createCounterpartyProperty.LastName,
                Phone = createCounterpartyProperty.Phone,
                Email = createCounterpartyProperty.Email,
                CounterpartyType = createCounterpartyProperty.CounterpartyType,
                CounterpartyProperty = createCounterpartyProperty.CounterpartyProperty
            }
        };

        return await _httpClientProvider.SendRequestAsync<CreateCounterpartyRequest, CreateCounterpartyResponse>(request);
    }
}