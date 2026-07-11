using Newtonsoft.Json;

namespace Tekmetric.Models.Jobs;

public class UpdateJobRequest
{
    [JsonProperty("completed")]
    public bool? Completed { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("note")]
    public string? Note { get; set; }

    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    /// <summary>Hours logged on the job by the employee.</summary>
    [JsonProperty("loggedHours")]
    public decimal? LoggedHours { get; set; }
}
