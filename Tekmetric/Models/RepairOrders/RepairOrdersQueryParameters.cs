using Tekmetric.Models.Common;

namespace Tekmetric.Models.RepairOrders;

public class RepairOrdersQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    /// <summary>Filter by Repair Orders created after this date.</summary>
    public DateTime? Start { get; set; }

    /// <summary>Filter by Repair Orders created before this date.</summary>
    public DateTime? End { get; set; }

    public DateTime? PostedDateStart { get; set; }

    public DateTime? PostedDateEnd { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }

    public DateTime? DeletedDateStart { get; set; }

    public DateTime? DeletedDateEnd { get; set; }

    public int? RepairOrderNumber { get; set; }

    /// <summary>1 Estimate, 2 Work-in-Progress, 3 Complete, 4 Saved for Later, 5 Posted, 6 Accounts Receivable, 7 Deleted.</summary>
    public List<int>? RepairOrderStatusId { get; set; }

    public long? CustomerId { get; set; }

    public long? VehicleId { get; set; }

    /// <summary>Search by RO #, customer name, and vehicle info.</summary>
    public string? Search { get; set; }
}
