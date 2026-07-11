using Newtonsoft.Json;

namespace Tekmetric.Models.Common;

public class Discount
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("total")]
    public int? Total { get; set; }
}
