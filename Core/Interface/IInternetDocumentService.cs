using Core.Dto.InternetDocuments.CreateInternetDocument.Request;
using Core.Dto.InternetDocuments.CreateInternetDocument.Response;

namespace Core.Interface;

public interface IInternetDocumentService
{
    Task<CreateInternetDocumentResponse> CreateInternetDocumentAsync(InternetDocumentRequest request);
}