using Core.Constants.DefaultValues;
using Core.Dto.AdditionalServices.CheckPossibilityCreateReturns;
using Core.Dto.AdditionalServices.CheckPossibilityCreateReturns.Request;
using Core.Dto.AdditionalServices.CheckPossibilityCreateReturns.Response;
using Core.Dto.AdditionalServices.GetReturnReasons;
using Core.Dto.AdditionalServices.GetReturnReasons.Request;
using Core.Dto.AdditionalServices.GetReturnReasons.Response;
using Core.Dto.AdditionalServices.GetReturnReasonsSubtypes;
using Core.Dto.AdditionalServices.GetReturnReasonsSubtypes.Request;
using Core.Dto.AdditionalServices.GetReturnReasonsSubtypes.Response;
using Core.Dto.AdditionalServices.Saves;
using Core.Dto.AdditionalServices.Saves.Request;
using Core.Dto.AdditionalServices.Saves.Response;

namespace ApplicationManager.Services.NovaPostService
{
    public class AdditionalServiceService
    {
        private readonly HttpClientProvider _httpClientProvider = new();

        public async Task<SaveResponse> Save(SaveProperty property)
        {
            var request = new SaveRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "AdditionalService",
                calledMethod = "save",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<SaveRequest, SaveResponse>(request);
            return response;
        }

        public async Task<CheckPossibilityCreateReturnResponse> CheckPossibilityCreateReturn(CheckPossibilityCreateReturnProperty property)
        {
            var request = new CheckPossibilityCreateReturnRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "AdditionalService",
                calledMethod = "CheckPossibilityCreateReturn",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<CheckPossibilityCreateReturnRequest, CheckPossibilityCreateReturnResponse>(request);
            return response;
        }

        public async Task<GetReturnReasonsSubtypeResponse> GetReturnReasonsSubtype(GetReturnReasonsSubtypeProperty property)
        {
            var request = new GetReturnReasonsSubtypeRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "AdditionalService",
                calledMethod = "getReturnReasonsSubtypes",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<GetReturnReasonsSubtypeRequest, GetReturnReasonsSubtypeResponse>(request);
            return response;
        }

        public async Task<GetReturnReasonResponse> GetReturnReason(GetReturnReasonProperty property)
        {
            var request = new GetReturnReasonRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "AdditionalService",
                calledMethod = "getReturnReasons",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<GetReturnReasonRequest, GetReturnReasonResponse>(request);
            return response;
        }

    }
}
