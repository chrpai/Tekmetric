using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Shops;

public class Shop
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("nickname")]
    public string? Nickname { get; set; }

    [JsonProperty("phone")]
    public string? Phone { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("website")]
    public string? Website { get; set; }

    [JsonProperty("address")]
    public Address? Address { get; set; }

    [JsonProperty("roCustomLabelEnabled")]
    public bool? RoCustomLabelEnabled { get; set; }
}
