using Newtonsoft.Json;

namespace Tekmetric.Models.RepairOrders;

/// <summary>
/// "data" payload of the ApiResponse returned by
/// POST /api/v1/repair-orders/{id}/canned-jobs.
/// </summary>
public class AddCannedJobsToRepairOrderResponseData
{
    /// <summary>IDs of the jobs created from the canned jobs.</summary>
    [JsonProperty("jobs")]
    public List<long>? Jobs { get; set; }
}
