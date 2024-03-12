using Newtonsoft.Json;

namespace Core.Dto.Settlements.GetWarehouses;

public class GetWarehouseProperty
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? CityName { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Page { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Limit { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Language { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? WarehouseId { get; set; }
}