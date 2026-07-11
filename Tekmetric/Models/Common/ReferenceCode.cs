using Newtonsoft.Json;

namespace Tekmetric.Models.Common;

/// <summary>
/// Shared shape for small lookup/enum-like entities returned inline on many
/// resources (e.g. customerType, partType, rideOption, employeeRole).
/// </summary>
public class ReferenceCode
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("code")]
    public string? Code { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}
