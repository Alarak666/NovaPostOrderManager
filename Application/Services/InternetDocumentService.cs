using Core.Dto.InternetDocument;
using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;
using Core.Interface;
using System.Text;
using System.Text.Json;

namespace Application.Services;

public class InternetDocumentService : IInternetDocumentService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "7fc4868a7f41a2aafc3e718ab77a4613";

    public InternetDocumentService(HttpClient httpClient)
    {
        _httpClient = httpClient;

    }

    public async Task<InternetDocumentResponse> CreateInternetDocumentAsync(InternetDocumentRequest request)
    {
        request = new InternetDocumentRequest
        {
            apiKey = _apiKey,
            modelName = "InternetDocument",
            calledMethod = "save",
            methodProperties = new InternetDocumentProperty
            {
                SenderWarehouseIndex = "101/102",
                RecipientWarehouseIndex = "101/102",
                PayerType = PayerType.Recipient,
                PaymentMethod = PaymentMethod.Cash,
                DateTime = DateTime.Now,
                CargoType = "1",
                VolumeGeneral = "1",
                Weight = "1",
                ServiceType = ServiceType.DoorsDoors,
                SeatsAmount = "1",
                Description = "1",
                Cost = "1",
                CitySender = "e718a680-4b33-11e4-ab6d-005056801329",
                Sender = "",
                SenderAddress = "",
                ContactSender = "",
                SendersPhone = "",
                CityRecipient = "e718a680-4b33-11e4-ab6d-005056801329",
                Recipient = "",
                RecipientAddress = "",
                ContactRecipient = "",
                RecipientsPhone = ""
            }
        };
        var jsonRequest = JsonSerializer.Serialize(request);

        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.PostAsync("URL_для_создания_интернет_документа", content);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var responseData = JsonSerializer.Deserialize<InternetDocumentResponse>(jsonResponse);

            return responseData;
        }
        catch (HttpRequestException ex)
        {
            // Обработка ошибок HTTP-запроса
            // В этом месте можно записать ошибку в логи, выполнить повторный запрос и т.д.
            throw new Exception($"HTTP request failed: {ex.Message}");
        }
        catch (JsonException ex)
        {
            // Обработка ошибок десериализации JSON
            throw new Exception($"JSON deserialization failed: {ex.Message}");
        }
    }
}