using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tekmetric.Models.Appointments;

public class UpdateAppointmentRequest
{
    [JsonProperty("shopId")]
    public long ShopId { get; set; }

    /// <summary>Not required unless vehicleId is set; must belong to shopId.</summary>
    [JsonProperty("customerId")]
    public long? CustomerId { get; set; }

    /// <summary>Not required unless customerId is set; must belong to customerId (or a customer of the shop if customerId is omitted).</summary>
    [JsonProperty("vehicleId")]
    public long? VehicleId { get; set; }

    [JsonProperty("startTime")]
    public DateTimeOffset StartTime { get; set; }

    [JsonProperty("endTime")]
    public DateTimeOffset EndTime { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; } = null!;

    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>One of: red, pink, yellow, orange, "light green", green, blue, navy, lavender, purple. Defaults to navy.</summary>
    [JsonProperty("color")]
    public string? Color { get; set; }

    [JsonProperty("dropoffTime")]
    public DateTimeOffset? DropoffTime { get; set; }

    [JsonProperty("pickupTime")]
    public DateTimeOffset? PickupTime { get; set; }

    [JsonProperty("rideOption")]
    [JsonConverter(typeof(StringEnumConverter))]
    public AppointmentRideOption? RideOption { get; set; }

    [JsonProperty("status")]
    [JsonConverter(typeof(StringEnumConverter))]
    public AppointmentStatus? Status { get; set; }

    /// <summary>Must be one of the values configured in Shop Settings - Marketing.</summary>
    [JsonProperty("leadSource")]
    public string? LeadSource { get; set; }
}
