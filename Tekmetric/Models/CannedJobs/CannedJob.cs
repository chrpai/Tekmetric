using Newtonsoft.Json;
using Tekmetric.Models.Common;
using Tekmetric.Models.Jobs;

namespace Tekmetric.Models.CannedJobs;

public class CannedJob
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("note")]
    public string? Note { get; set; }

    /// <summary>Total cost of the job in cents.</summary>
    [JsonProperty("totalCost")]
    public int? TotalCost { get; set; }

    [JsonProperty("jobTemplateType")]
    public string? JobTemplateType { get; set; }

    [JsonProperty("jobCategoryCode")]
    public string? JobCategoryCode { get; set; }

    /// <summary>Unique labor rates for the job, in cents.</summary>
    [JsonProperty("laborRates")]
    public List<int>? LaborRates { get; set; }

    [JsonProperty("labor")]
    public List<Labor>? Labor { get; set; }

    [JsonProperty("parts")]
    public List<Part>? Parts { get; set; }

    [JsonProperty("discounts")]
    public List<Discount>? Discounts { get; set; }

    [JsonProperty("fees")]
    public List<Fee>? Fees { get; set; }

    [JsonProperty("packagePrice")]
    public bool? PackagePrice { get; set; }
}
