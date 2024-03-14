using Core.Constants.DefaultValues;
using Core.Constants.Enums;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using Core.Dto.InternetDocuments.CreateInternetDocument.Request;
using Core.Dto.InternetDocuments.CreateInternetDocument.Response;
using Core.Dto.InternetDocuments.GetDocumentList;
using Core.Dto.InternetDocuments.GetDocumentList.Request;
using Core.Dto.InternetDocuments.GetDocumentList.Response;

namespace ApplicationManager.Services.NovaPostService
{
    public class InternetDocumentService
    {
        private readonly HttpClientProvider _httpClientProvider = new();

        public async Task<CreateInternetDocumentResponse> CreateInternetDocument(CreateInternetDocumentProperty property)
        {
            var request = new InternetDocumentRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "InternetDocument",
                calledMethod = "save",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<InternetDocumentRequest, CreateInternetDocumentResponse>(request);
            return response;
        }
        public async Task<GetDocumentListResponse> GetDocumentList(GetDocumentListProperty property)
        {
            var request = new GetDocumentListRequest
            {
                apiKey = CoreDefaultValues.ApiKey,
                modelName = "InternetDocument",
                calledMethod = "getDocumentList",
                methodProperties = property
            };

            var response = await _httpClientProvider.SendRequestAsync<GetDocumentListRequest, GetDocumentListResponse>(request);
            return response;
        }

    }
}
