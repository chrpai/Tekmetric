using Newtonsoft.Json;

namespace Tekmetric.Models.Vehicles;

public class UpdateVehicleRequest
{
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

    [JsonProperty("notes")]
    public string? Notes { get; set; }

    [JsonProperty("unitNumber")]
    public string? UnitNumber { get; set; }
}
