namespace Core.Dto.InternetDocument;

public class InternetDocumentProperty
{
    public string SenderWarehouseIndex { get; set; }
    public string RecipientWarehouseIndex { get; set; }
    public PayerType PayerType { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime DateTime { get; set; }
    public string CargoType { get; set; }
    public string VolumeGeneral { get; set; }
    public string Weight { get; set; }
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
}

public enum ServiceType
{
    DoorsDoors, 
    DoorsWarehouse,
    WarehouseWarehouse, 
    WarehouseDoors
}

public enum PaymentMethod
{
    Cash,
    NonCash
}

public enum PayerType
{
    Sender,
    Recipient, 
    ThirdPerson
}