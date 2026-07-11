using Newtonsoft.Json;

namespace Tekmetric.Models.RepairOrders;

public class Sublet
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("vendor")]
    public Vendor? Vendor { get; set; }

    [JsonProperty("authorized")]
    public bool? Authorized { get; set; }

    [JsonProperty("authorizedDate")]
    public DateTimeOffset? AuthorizedDate { get; set; }

    [JsonProperty("selected")]
    public bool? Selected { get; set; }

    [JsonProperty("note")]
    public string? Note { get; set; }

    [JsonProperty("items")]
    public List<SubletItem>? Items { get; set; }

    /// <summary>Price in cents.</summary>
    [JsonProperty("price")]
    public int? Price { get; set; }

    /// <summary>Cost in cents.</summary>
    [JsonProperty("cost")]
    public int? Cost { get; set; }
}

public class SubletItem
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>Cost in cents.</summary>
    [JsonProperty("cost")]
    public int? Cost { get; set; }

    /// <summary>Price in cents.</summary>
    [JsonProperty("price")]
    public int? Price { get; set; }

    [JsonProperty("complete")]
    public bool? Complete { get; set; }
}
