using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Appointments;

public class Appointment
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("shopId")]
    public long ShopId { get; set; }

    [JsonProperty("customerId")]
    public long? CustomerId { get; set; }

    [JsonProperty("vehicleId")]
    public long? VehicleId { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonProperty("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("color")]
    public string? Color { get; set; }

    [JsonProperty("arrived")]
    public bool? Arrived { get; set; }

    [JsonProperty("appointmentStatus")]
    [JsonConverter(typeof(StringEnumConverter))]
    public AppointmentStatus? AppointmentStatus { get; set; }

    [JsonProperty("createdDate")]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("updatedDate")]
    public DateTimeOffset? UpdatedDate { get; set; }

    [JsonProperty("deletedDate")]
    public DateTimeOffset? DeletedDate { get; set; }

    /// <summary>Marketing source for the appointment.</summary>
    [JsonProperty("leadSource")]
    public string? LeadSource { get; set; }

    [JsonProperty("rideOption")]
    public ReferenceCode? RideOption { get; set; }

    [JsonProperty("dropoffTime")]
    public DateTimeOffset? DropoffTime { get; set; }

    [JsonProperty("pickupTime")]
    public DateTimeOffset? PickupTime { get; set; }

    [JsonProperty("appointmentOption")]
    public ReferenceCode? AppointmentOption { get; set; }
}
