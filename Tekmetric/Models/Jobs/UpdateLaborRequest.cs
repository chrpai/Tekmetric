using Newtonsoft.Json;

namespace Tekmetric.Models.Jobs;

public class UpdateLaborRequest
{
    /// <summary>EmployeeId of the technician.</summary>
    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }
}
