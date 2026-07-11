using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Employees;

public class Employee
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("firstName")]
    public string? FirstName { get; set; }

    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    [JsonProperty("address")]
    public Address? Address { get; set; }

    [JsonProperty("employeeRole")]
    public ReferenceCode? EmployeeRole { get; set; }

    [JsonProperty("canPerformWork")]
    public bool? CanPerformWork { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("certificationNumber")]
    public string? CertificationNumber { get; set; }
}
