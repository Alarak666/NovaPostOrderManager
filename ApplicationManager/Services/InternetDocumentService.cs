using Core.Constants.DefaultValues;
using Core.Constants.Enums;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using Core.Dto.InternetDocuments.CreateInternetDocument.Request;
using Core.Dto.InternetDocuments.CreateInternetDocument.Response;

namespace ApplicationManager.Services
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
    }
}
