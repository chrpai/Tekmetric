using Newtonsoft.Json;
using Tekmetric.Models.Common;
using Tekmetric.Models.Jobs;

namespace Tekmetric.Models.RepairOrders;

public class RepairOrder
{
    [JsonProperty("id")]
    public long Id { get; set; }

    /// <summary>Repair Order identifier, unique per shop.</summary>
    [JsonProperty("repairOrderNumber")]
    public int? RepairOrderNumber { get; set; }

    [JsonProperty("shopId")]
    public long ShopId { get; set; }

    [JsonProperty("repairOrderStatus")]
    public ReferenceCode? RepairOrderStatus { get; set; }

    [JsonProperty("repairOrderLabel")]
    public RepairOrderLabel? RepairOrderLabel { get; set; }

    [JsonProperty("repairOrderCustomLabel")]
    public RepairOrderCustomLabel? RepairOrderCustomLabel { get; set; }

    [JsonProperty("color")]
    public string? Color { get; set; }

    [JsonProperty("appointmentStartTime")]
    public DateTimeOffset? AppointmentStartTime { get; set; }

    [JsonProperty("customerId")]
    public long? CustomerId { get; set; }

    [JsonProperty("technicianId")]
    public long? TechnicianId { get; set; }

    [JsonProperty("serviceWriterId")]
    public long? ServiceWriterId { get; set; }

    [JsonProperty("vehicleId")]
    public long? VehicleId { get; set; }

    [JsonProperty("milesIn")]
    public decimal? MilesIn { get; set; }

    [JsonProperty("milesOut")]
    public decimal? MilesOut { get; set; }

    [JsonProperty("keytag")]
    public string? Keytag { get; set; }

    [JsonProperty("completedDate")]
    public DateTimeOffset? CompletedDate { get; set; }

    [JsonProperty("postedDate")]
    public DateTimeOffset? PostedDate { get; set; }

    /// <summary>Total labor sales in cents. Taxes and discounts not included.</summary>
    [JsonProperty("laborSales")]
    public int? LaborSales { get; set; }

    /// <summary>Total parts sales in cents. Taxes and discounts not included.</summary>
    [JsonProperty("partsSales")]
    public int? PartsSales { get; set; }

    /// <summary>Total sublet sales in cents. Taxes and discounts not included.</summary>
    [JsonProperty("subletSales")]
    public int? SubletSales { get; set; }

    /// <summary>Total discounts in cents.</summary>
    [JsonProperty("discountTotal")]
    public int? DiscountTotal { get; set; }

    /// <summary>Total fees in cents. Taxes and discounts not included.</summary>
    [JsonProperty("feeTotal")]
    public int? FeeTotal { get; set; }

    [JsonProperty("taxes")]
    public int? Taxes { get; set; }

    /// <summary>Total amount paid by the customer.</summary>
    [JsonProperty("amountPaid")]
    public int? AmountPaid { get; set; }

    [JsonProperty("totalSales")]
    public int? TotalSales { get; set; }

    [JsonProperty("jobs")]
    public List<Job>? Jobs { get; set; }

    [JsonProperty("sublets")]
    public List<Sublet>? Sublets { get; set; }

    [JsonProperty("fees")]
    public List<Fee>? Fees { get; set; }

    [JsonProperty("discounts")]
    public List<Discount>? Discounts { get; set; }

    [JsonProperty("customerConcerns")]
    public List<CustomerConcern>? CustomerConcerns { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("estimateShareDate")]
    public DateTimeOffset? EstimateShareDate { get; set; }

    [JsonProperty("inspectionShareDate")]
    public DateTimeOffset? InspectionShareDate { get; set; }

    [JsonProperty("invoiceShareDate")]
    public DateTimeOffset? InvoiceShareDate { get; set; }

    [JsonProperty("deletedDate")]
    public DateTimeOffset? DeletedDate { get; set; }
}
