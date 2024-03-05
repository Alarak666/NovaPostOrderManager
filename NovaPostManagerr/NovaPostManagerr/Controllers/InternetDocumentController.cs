using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace NovaPostManagerr.Controllers;

[ApiController]
[Route("[controller]")]
public class InternetDocumentController : ControllerBase
{
    private readonly IInternetDocumentService _internetDocumentService;

    public InternetDocumentController(IInternetDocumentService internetDocumentService)
    {
        _internetDocumentService = internetDocumentService;
    }

    [HttpPost]
    public async Task<ActionResult<InternetDocumentResponse>> CreateInternetDocument(InternetDocumentRequest request)
    {
        try
        {
            var response = await _internetDocumentService.CreateInternetDocumentAsync(request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}