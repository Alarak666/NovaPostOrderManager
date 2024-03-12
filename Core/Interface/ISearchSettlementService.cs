using Core.Dto.Settlements.SearchSettlementStreet.Response;

namespace Core.Interface;

public interface ISearchSettlementService
{
    Task<SearchSettlementResponse> GetCityData(string cityName);
}