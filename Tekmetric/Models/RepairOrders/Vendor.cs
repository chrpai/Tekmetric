using Newtonsoft.Json;

namespace Tekmetric.Models.RepairOrders;

public class Vendor
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("nickname")]
    public string? Nickname { get; set; }

    [JsonProperty("website")]
    public string? Website { get; set; }

    [JsonProperty("phone")]
    public string? Phone { get; set; }
}
