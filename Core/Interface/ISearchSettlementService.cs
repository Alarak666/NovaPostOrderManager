using Core.Dto.SearchSettlement.Response;

namespace Core.Interface;

public interface ISearchSettlementService
{
    Task<SearchSettlementResponse> GetCityData(string cityName);
}