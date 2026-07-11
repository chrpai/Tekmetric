using Newtonsoft.Json;

namespace Tekmetric.Models.Jobs;

public class UpdateLaborResponse
{
    [JsonProperty("content")]
    public Labor? Content { get; set; }
}
