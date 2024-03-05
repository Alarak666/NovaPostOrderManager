using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;

namespace Core.Interface;

public interface IInternetDocumentService
{
    Task<InternetDocumentResponse> CreateInternetDocumentAsync(InternetDocumentRequest request);
}