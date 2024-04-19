using ApplicationManager.Services.NovaPostService;
using Core.CustomException;

namespace ApplicationManager.Helpers;

public static class CheckValidApiKey
{
    public static async Task IsValidApiKey()
    {
        await Task.Delay(100);
        var _searchSettlementService = new SearchSettlementService();
        var response = await _searchSettlementService.GetCityForValidData();
        
        if (!response.success)
            throw new CustomException(@"Неправильний ApiKey, за вами виїхала поліція Shrug смайлов ¯\_(ツ)_/¯");
    }
}