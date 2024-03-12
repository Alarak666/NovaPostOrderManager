using Core.Constants.DefaultValues;
using Core.Dto.Commons.GetCargoTypes;
using Core.Dto.Commons.GetCargoTypes.Request;
using Core.Dto.Commons.GetCargoTypes.Response;

namespace ApplicationManager.Services
{
    public class CommonService
    {
        private readonly HttpClientProvider _httpClientProvider = new();

        public async Task<GetCargoTypeResponse> GetCargoType()
        {
            var request = new GetCargoTypeRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "Common",
                calledMethod = "getCargoTypes",
                methodProperties = new GetCargoTypeProperty()
            };

            var response = await _httpClientProvider.SendRequestAsync<GetCargoTypeRequest, GetCargoTypeResponse>(request);
            return response;
        }
    }
}
