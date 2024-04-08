using Core.Constants.Enums;
using Core.Dto.Base;
using System.Net.NetworkInformation;

namespace Core.Model;

public class InternetDocumentModel 
{
    public string CityRecipient { get; set; }
    public string Recipient { get; set; }
    public decimal Cost { get; set; }
    public string RecipientAddress { get; set; }
    public string RecipientsPhone { get; set; }
}