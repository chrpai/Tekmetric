using Tekmetric.Models.Common;

namespace Tekmetric.Models.Vehicles;

public class VehiclesQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    public long? CustomerId { get; set; }

    /// <summary>Search by vehicle year, make, or model.</summary>
    public string? Search { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }

    public DateTime? DeletedDateStart { get; set; }

    public DateTime? DeletedDateEnd { get; set; }
}
