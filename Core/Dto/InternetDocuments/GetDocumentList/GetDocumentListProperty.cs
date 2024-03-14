using Core.Constants.Enums;
using Newtonsoft.Json;

namespace Core.Dto.InternetDocuments.GetDocumentList;

public class GetDocumentListProperty
{
    public string DateTimeFrom { get; set; }
    public string DateTimeTo { get; set; }
    public string GetFullList { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Page { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? DateTime { get; set; }
}