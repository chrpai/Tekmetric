using Newtonsoft.Json;

namespace Tekmetric.Models.Jobs;

public class Labor
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>Rate in cents.</summary>
    [JsonProperty("rate")]
    public int? Rate { get; set; }

    [JsonProperty("hours")]
    public decimal? Hours { get; set; }

    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    [JsonProperty("complete")]
    public bool? Complete { get; set; }
}
