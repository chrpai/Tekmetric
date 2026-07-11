using Newtonsoft.Json;

namespace Tekmetric.Models.Vehicles;

public class Vehicle
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("customerId")]
    public long? CustomerId { get; set; }

    [JsonProperty("year")]
    public int? Year { get; set; }

    [JsonProperty("make")]
    public string? Make { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("subModel")]
    public string? SubModel { get; set; }

    [JsonProperty("engine")]
    public string? Engine { get; set; }

    [JsonProperty("color")]
    public string? Color { get; set; }

    [JsonProperty("licensePlate")]
    public string? LicensePlate { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("vin")]
    public string? Vin { get; set; }

    [JsonProperty("driveType")]
    public string? DriveType { get; set; }

    [JsonProperty("transmission")]
    public string? Transmission { get; set; }

    [JsonProperty("bodyType")]
    public string? BodyType { get; set; }

    [JsonProperty("notes")]
    public string? Notes { get; set; }

    [JsonProperty("unitNumber")]
    public string? UnitNumber { get; set; }

    [JsonProperty("productionDate")]
    public DateTimeOffset? ProductionDate { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("deletedDate")]
    public DateTimeOffset? DeletedDate { get; set; }
}
