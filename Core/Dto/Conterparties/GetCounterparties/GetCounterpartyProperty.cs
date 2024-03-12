using Newtonsoft.Json;

namespace Core.Dto.Conterparties.GetCounterparties;

public class GetCounterpartyProperty
{
    public string CounterpartyProperty { get; set; }
    public string Page { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string FindByString { get; set; }
}