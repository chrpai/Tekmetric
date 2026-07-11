using Newtonsoft.Json;

namespace Tekmetric.Models.Common;

public class Phone
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("number")]
    public string? Number { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("primary")]
    public bool? Primary { get; set; }
}
