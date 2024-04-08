using System.Diagnostics;
using Core.Constants.DefaultValues;
using Core.Constants.Enums;
using Core.CustomException;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using Core.Dto.InternetDocuments.CreateInternetDocument.Request;
using Core.Dto.InternetDocuments.CreateInternetDocument.Response;
using Core.Dto.InternetDocuments.GetDocumentList;
using Core.Dto.InternetDocuments.GetDocumentList.Request;
using Core.Dto.InternetDocuments.GetDocumentList.Response;
using Serilog;

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
        public async Task PrinterDocument(string? documentNumber)
        {
            string apiKey = CoreDefaultValues.ApiKey;

            if (string.IsNullOrWhiteSpace(documentNumber) || string.IsNullOrWhiteSpace(apiKey))
                throw new CustomException("Не вдалось роздрукувати: відсутній номер документа або API ключ.");

            string url = $"https://my.novaposhta.ua/orders/printMarking85x85/orders[]/{documentNumber}/type/pdf8/apiKey/{apiKey}";

            try
            {

                var psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {url}",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "PrintError");
                throw new CustomException("Не вдалось роздрукувати");
            }
        }
    }
}
