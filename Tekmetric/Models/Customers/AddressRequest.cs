using Newtonsoft.Json;

namespace Tekmetric.Models.Customers;

public class AddressRequest
{
    [JsonProperty("address1")]
    public string? Address1 { get; set; }

    [JsonProperty("address2")]
    public string? Address2 { get; set; }

    [JsonProperty("city")]
    public string? City { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("zip")]
    public string? Zip { get; set; }
}
