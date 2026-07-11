using Newtonsoft.Json;

namespace Tekmetric.Models.Jobs;

public class JobClockRequest
{
    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    /// <summary>Hours logged on the job by the employee.</summary>
    [JsonProperty("loggedHours")]
    public decimal? LoggedHours { get; set; }
}
