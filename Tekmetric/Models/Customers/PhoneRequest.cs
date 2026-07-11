using Newtonsoft.Json;

namespace Tekmetric.Models.Customers;

public class PhoneRequest
{
    [JsonProperty("number")]
    public string? Number { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("primary")]
    public bool? Primary { get; set; }
}
