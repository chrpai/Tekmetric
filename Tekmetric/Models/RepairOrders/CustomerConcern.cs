using Newtonsoft.Json;

namespace Tekmetric.Models.RepairOrders;

public class CustomerConcern
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("concern")]
    public string? Concern { get; set; }

    [JsonProperty("techComment")]
    public string? TechComment { get; set; }
}
