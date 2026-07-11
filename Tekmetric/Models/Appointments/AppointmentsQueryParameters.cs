using Tekmetric.Models.Common;

namespace Tekmetric.Models.Appointments;

public class AppointmentsQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    public long? CustomerId { get; set; }

    public long? VehicleId { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }

    /// <summary>Filter out deleted appointments. Defaults to true.</summary>
    public bool? IncludeDeleted { get; set; }
}
