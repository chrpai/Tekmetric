using Tekmetric.Models.Common;

namespace Tekmetric.Models.Customers;

public class CustomersQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    /// <summary>Search by customer name, email, or phone number.</summary>
    public string? Search { get; set; }

    public bool? EligibleForAccountsReceivable { get; set; }

    public bool? OkForMarketing { get; set; }

    public DateTime? UpdatedDateStart { get; set; }

    public DateTime? UpdatedDateEnd { get; set; }

    public DateTime? DeletedDateStart { get; set; }

    public DateTime? DeletedDateEnd { get; set; }

    /// <summary>1 for Customer (Person), 2 for Business.</summary>
    public int? CustomerTypeId { get; set; }
}
