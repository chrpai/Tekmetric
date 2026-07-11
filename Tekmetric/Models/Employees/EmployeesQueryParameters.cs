using Tekmetric.Models.Common;

namespace Tekmetric.Models.Employees;

public class EmployeesQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    /// <summary>Search by employee name.</summary>
    public string? Search { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }
}
