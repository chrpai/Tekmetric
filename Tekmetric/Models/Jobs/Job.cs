using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Jobs;

public class Job
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("repairOrderId")]
    public long RepairOrderId { get; set; }

    [JsonProperty("vehicleId")]
    public long? VehicleId { get; set; }

    [JsonProperty("customerId")]
    public long? CustomerId { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("authorized")]
    public bool? Authorized { get; set; }

    [JsonProperty("authorizedDate")]
    public DateTimeOffset? AuthorizedDate { get; set; }

    /// <summary>Whether the job was presented to the customer for authorization.</summary>
    [JsonProperty("selected")]
    public bool? Selected { get; set; }

    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    [JsonProperty("note")]
    public string? Note { get; set; }

    [JsonProperty("jobCategoryName")]
    public string? JobCategoryName { get; set; }

    /// <summary>Total parts sales in cents. Taxes and discounts not included.</summary>
    [JsonProperty("partsTotal")]
    public int? PartsTotal { get; set; }

    /// <summary>Total labor sales in cents. Taxes and discounts not included.</summary>
    [JsonProperty("laborTotal")]
    public int? LaborTotal { get; set; }

    /// <summary>Total discounts in cents.</summary>
    [JsonProperty("discountTotal")]
    public int? DiscountTotal { get; set; }

    /// <summary>Total fees in cents. Taxes and discounts not included.</summary>
    [JsonProperty("feeTotal")]
    public int? FeeTotal { get; set; }

    [JsonProperty("subtotal")]
    public int? Subtotal { get; set; }

    /// <summary>Whether the job was declined and marked as archived (non-marketable).</summary>
    [JsonProperty("archived")]
    public bool? Archived { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("completedDate")]
    public DateTimeOffset? CompletedDate { get; set; }

    [JsonProperty("labor")]
    public List<Labor>? Labor { get; set; }

    [JsonProperty("parts")]
    public List<Part>? Parts { get; set; }

    [JsonProperty("fees")]
    public List<Fee>? Fees { get; set; }

    [JsonProperty("discounts")]
    public List<Discount>? Discounts { get; set; }

    [JsonProperty("laborHours")]
    public decimal? LaborHours { get; set; }

    [JsonProperty("loggedHours")]
    public decimal? LoggedHours { get; set; }

    [JsonProperty("sort")]
    public int? Sort { get; set; }
}
