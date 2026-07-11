using Tekmetric.Models.Common;

namespace Tekmetric.Models.Jobs;

public class JobsQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    public long? VehicleId { get; set; }

    public long? RepairOrderId { get; set; }

    public long? CustomerId { get; set; }

    public bool? Authorized { get; set; }

    public DateTime? AuthorizedDateStart { get; set; }

    public DateTime? AuthorizedDateEnd { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }

    /// <summary>1 Estimate, 2 Work-in-Progress, 3 Complete, 4 Saved for Later, 5 Posted, 6 Accounts Receivable.</summary>
    public List<int>? RepairOrderStatusId { get; set; }
}
