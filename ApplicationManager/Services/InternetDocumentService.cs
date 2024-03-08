using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;
using Core.Interface;

namespace ApplicationManager.Services;
public class InternetDocumentService : IInternetDocumentService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "7fc4868a7f41a2aafc3e718ab77a4613";

    public InternetDocumentService(HttpClient httpClient)
    {
        _httpClient = httpClient;

    }


    public Task<InternetDocumentResponse> CreateInternetDocumentAsync(InternetDocumentRequest request)
    {
        throw new NotImplementedException();
    }
}