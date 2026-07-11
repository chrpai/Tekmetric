using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.RepairOrders;

public class RepairOrderLabel
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("code")]
    public string? Code { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("status")]
    public ReferenceCode? Status { get; set; }
}

public class RepairOrderCustomLabel
{
    [JsonProperty("name")]
    public string? Name { get; set; }
}
