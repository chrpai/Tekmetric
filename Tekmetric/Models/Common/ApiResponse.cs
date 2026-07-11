using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tekmetric.Models.Common;

/// <summary>
/// Envelope returned by create/update/delete style endpoints, e.g.
/// { "type": "SUCCESS", "message": "Customer created", "data": {...}, "details": {} }.
/// </summary>
public class ApiResponse<TData>
{
    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("data")]
    public TData? Data { get; set; }

    [JsonProperty("details")]
    public JObject? Details { get; set; }
}
