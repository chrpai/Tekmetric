using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Customers;

public class Customer
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("firstName")]
    public string? FirstName { get; set; }

    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("phone")]
    public List<Phone>? Phone { get; set; }

    [JsonProperty("customerType")]
    public ReferenceCode? CustomerType { get; set; }

    [JsonProperty("contactFirstName")]
    public string? ContactFirstName { get; set; }

    [JsonProperty("contactLastName")]
    public string? ContactLastName { get; set; }

    [JsonProperty("address")]
    public Address? Address { get; set; }

    [JsonProperty("notes")]
    public string? Notes { get; set; }

    [JsonProperty("shopId")]
    public long ShopId { get; set; }

    [JsonProperty("eligibleForAccountsReceivable")]
    public bool? EligibleForAccountsReceivable { get; set; }

    [JsonProperty("creditLimit")]
    public int? CreditLimit { get; set; }

    [JsonProperty("okForMarketing")]
    public bool? OkForMarketing { get; set; }

    [JsonProperty("birthday")]
    public DateTimeOffset? Birthday { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("deletedDate")]
    public DateTimeOffset? DeletedDate { get; set; }
}
