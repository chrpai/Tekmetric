using Newtonsoft.Json;

namespace Tekmetric.Models.Customers;

public class UpdateCustomerRequest
{
    /// <summary>1 for PERSON (default), 2 for BUSINESS.</summary>
    [JsonProperty("customerTypeId")]
    public int? CustomerTypeId { get; set; }

    [JsonProperty("firstName")]
    public string? FirstName { get; set; }

    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    [JsonProperty("email")]
    public List<string>? Email { get; set; }

    [JsonProperty("notes")]
    public string? Notes { get; set; }

    [JsonProperty("phones")]
    public List<PhoneRequest>? Phones { get; set; }

    [JsonProperty("address")]
    public AddressRequest? Address { get; set; }

    [JsonProperty("eligibleForAccountsReceivable")]
    public bool? EligibleForAccountsReceivable { get; set; }

    [JsonProperty("creditLimit")]
    public int? CreditLimit { get; set; }

    [JsonProperty("okForMarketing")]
    public bool? OkForMarketing { get; set; }
}
