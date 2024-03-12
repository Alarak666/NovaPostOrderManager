using Core.Constants.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core.Dto.InternetDocuments.CreateInternetDocument;

public class CreateInternetDocumentProperty
{
    public string SenderWarehouseIndex { get; set; }
    public string RecipientWarehouseIndex { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public PayerType PayerType { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public PaymentMethod PaymentMethod { get; set; }
    public string DateTime { get; set; }
    public string CargoType { get; set; }
    public string VolumeGeneral { get; set; }
    public string Weight { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public ServiceType ServiceType { get; set; }
    public string SeatsAmount { get; set; }
    public string Description { get; set; }
    public string Cost { get; set; }
    public string CitySender { get; set; }
    public string Sender { get; set; }
    public string SenderAddress { get; set; }
    public string ContactSender { get; set; }
    public string SendersPhone { get; set; }
    public string CityRecipient { get; set; }
    public string Recipient { get; set; }
    public string RecipientAddress { get; set; }
    public string ContactRecipient { get; set; }
    public string RecipientsPhone { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OptionsSeat>? OptionsSeat { get; set; }
    public string AfterpaymentOnGoodsCost { get; set; }

}