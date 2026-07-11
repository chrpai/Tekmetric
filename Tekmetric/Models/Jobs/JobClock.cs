using Newtonsoft.Json;
using Tekmetric.Models.Employees;

namespace Tekmetric.Models.Jobs;

public class JobClockResponse
{
    [JsonProperty("content")]
    public List<JobClockEntry>? Content { get; set; }
}

public class JobClockEntry
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("job")]
    public Job? Job { get; set; }

    [JsonProperty("technician")]
    public Employee? Technician { get; set; }

    [JsonProperty("loggedTime")]
    public decimal? LoggedTime { get; set; }

    [JsonProperty("loggedTimeEdited")]
    public bool? LoggedTimeEdited { get; set; }

    [JsonProperty("lastStartTime")]
    public DateTimeOffset? LastStartTime { get; set; }

    [JsonProperty("serverTime")]
    public DateTimeOffset? ServerTime { get; set; }
}
