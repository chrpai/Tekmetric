using Newtonsoft.Json;

namespace Tekmetric.Models.RepairOrders;

public class UpdateRepairOrderRequest
{
    [JsonProperty("keyTag")]
    public string? KeyTag { get; set; }

    [JsonProperty("milesIn")]
    public decimal? MilesIn { get; set; }

    [JsonProperty("milesOut")]
    public decimal? MilesOut { get; set; }

    /// <summary>Sets the default Technician on the Repair Order by employeeId.</summary>
    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    /// <summary>Sets the Service Writer on the Repair Order by employeeId.</summary>
    [JsonProperty("serviceWriterId")]
    public long? ServiceWriterId { get; set; }

    /// <summary>Sets the Promise Time on the Repair Order.</summary>
    [JsonProperty("customerTimeOut")]
    public DateTimeOffset? CustomerTimeOut { get; set; }
}
