using ApplicationManager.Helpers;
using Core.Constants;
using Core.Constants.Enums;
using Core.Dto.Base;
using Core.Dto.InternetDocument;
using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;
using Core.Interface;
using MyLib;
using Newtonsoft.Json;
using System.Data;

namespace ApplicationManager.Services;

public class OrderPostService : IOrderPostService
{
    private readonly SQL remoteSql;
    private readonly HttpClientProvider _httpClientProvider = new ();

    public OrderPostService()
    {
        remoteSql = DBHelper.Init().sql;
    }

    public async Task<DataTable> GetOrders()
    {
        var query = @"
                SELECT oht.[id], oht.[code], oht.[dateTimeCreated], 
                oht.[customerPhone], oht.[createDateTime], oht.[status_1c], 
                oht.[Approve], oht.[delivery], oht.[TTN_1C], oht.[TTN], 
                ort.[DeliveryServiceName], ort.[DeliveryServiceAlias], 
                ort.[FullName], ort.[CityReceiver], ort.[IDWhs], 
                ort.[ReceiverWhs]
                FROM [InternetSaleApteka].[dbo].[OrderHeader_Tabletki] oht
                LEFT JOIN [InternetSaleApteka].[dbo].[OrderDelivery_Tabletki] ort 
                ON oht.id = ort.ID
                WHERE oht.delivery = 1 AND oht.status_1c = 6 AND dateTimeCreated > DATEADD(D, -2,GETDATE())";

        return remoteSql.SelectQuery(query, new LogFile("Log"), "InternetSaleApteka");
    }

    public async Task<AddressResponse> GetAddress(string cityName, string? @ref = null, string? warehouseId= null)
    {
        var request = new AddressRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
            modelName = "Address",
            calledMethod = "getWarehouses",
            methodProperties = new GetAddressProperty
            {
                CityName = cityName,
                Ref = @ref,
                WarehouseId = warehouseId,
                Page = "1",
                Limit = "50",
                Language = "UA"
            }
        };

        return await _httpClientProvider.SendRequestAsync<AddressRequest, AddressResponse>(request);
    }

    public async Task<InternetDocumentResponse> CreateInternetDocumentAsync(InternetDocumentRequest request)
    {
        request = new InternetDocumentRequest
        {
            apiKey = CoreDefaultValues.ApiKey,
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

        var response = await _httpClientProvider.SendRequestAsync<InternetDocumentRequest, InternetDocumentResponse>(request);
        return response;
    }
    //public async Task<CounterpartyResponse> SaveCounterparty(string firstName, string middleName, string lastName, string phone, string email)
    //{
    //    var request = new CounterpartyRequest
    //    {
    //        apiKey = "your_api_key",
    //        modelName = "Counterparty",
    //        calledMethod = "save",
    //        methodProperties = new CounterpartyProperties
    //        {
    //            FirstName = firstName,
    //            MiddleName = middleName,
    //            LastName = lastName,
    //            Phone = phone,
    //            Email = email,
    //            CounterpartyType = "PrivatePerson",
    //            CounterpartyProperty = "Recipient"
    //        }
    //    };

    //    return await _httpClientProvider.SendRequestAsync<CounterpartyRequest, CounterpartyResponse>(request);
    //}
}

public class AddressResponse : BaseResponse<AddressResponseData>
{
}

public class AddressResponseData
{
    public string SiteKey { get; set; }
    public string Description { get; set; }
    public string DescriptionRu { get; set; }
    public string ShortAddress { get; set; }
    public string ShortAddressRu { get; set; }
    public string Phone { get; set; }
    public string TypeOfWarehouse { get; set; }
    public string Ref { get; set; }
    public string Number { get; set; }
    public string CityRef { get; set; }
    public string CityDescription { get; set; }
    public string CityDescriptionRu { get; set; }
    public string SettlementRef { get; set; }
    public string SettlementDescription { get; set; }
    public string SettlementAreaDescription { get; set; }
    public string SettlementRegionsDescription { get; set; }
    public string SettlementTypeDescription { get; set; }
    public string SettlementTypeDescriptionRu { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public string PostFinance { get; set; }
    public string BicycleParking { get; set; }
    public string PaymentAccess { get; set; }
    public string POSTerminal { get; set; }
    public string InternationalShipping { get; set; }
    public string SelfServiceWorkplacesCount { get; set; }
    public string TotalMaxWeightAllowed { get; set; }
    public string PlaceMaxWeightAllowed { get; set; }
    public Dimension SendingLimitationsOnDimensions { get; set; }
    public Dimension ReceivingLimitationsOnDimensions { get; set; }
    public Dictionary<string, string> Reception { get; set; }
    public Dictionary<string, string> Delivery { get; set; }
    public Dictionary<string, string> Schedule { get; set; }
    public string DistrictCode { get; set; }
    public string WarehouseStatus { get; set; }
    public string WarehouseStatusDate { get; set; }
    public string WarehouseIllusha { get; set; }
    public string CategoryOfWarehouse { get; set; }
    public string Direct { get; set; }
    public string RegionCity { get; set; }
    public string WarehouseForAgent { get; set; }
    public string GeneratorEnabled { get; set; }
    public string MaxDeclaredCost { get; set; }
    public string WorkInMobileAwis { get; set; }
    public string DenyToSelect { get; set; }
    public string CanGetMoneyTransfer { get; set; }
    public string HasMirror { get; set; }
    public string HasFittingRoom { get; set; }
    public string OnlyReceivingParcel { get; set; }
    public string PostMachineType { get; set; }
    public string PostalCodeUA { get; set; }
    public string WarehouseIndex { get; set; }
    public string BeaconCode { get; set; }
}

public class Dimension
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
}

public class AddressRequest : BaseRequest<GetAddressProperty>
{

}

public class GetAddressProperty
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string CityName { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Ref { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Page { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Limit { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Language { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? WarehouseId { get; set; }
}

