using Core.Constants.Enums;

namespace Core.Dto.InternetDocuments.GetDocumentList;

public class GetDocumentListData
{
    public string IntDocNumber { get; set; }
    public string InfoRegClientBarcodes { get; set; }
    public string StateName { get; set; }
    public string DateTime { get; set; }
    public string Cost { get; set; }
    public string CostOnSite { get; set; }
    public string Weight { get; set; }
    public string Description { get; set; }
    public string SenderContactPerson { get; set; }
    public string SenderAddressDescription { get; set; }
    public string SendersPhone { get; set; }
    public string AfterpaymentOnGoodsCost { get; set; }
    public string RecipientContactPerson { get; set; }
    public string RecipientsPhone { get; set; }
    public string CityRecipientDescription { get; set; }
    public string RecipientAddressDescription { get; set; }
    public int StateId { get; set; }
}