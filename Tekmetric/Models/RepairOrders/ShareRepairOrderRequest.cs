using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tekmetric.Models.RepairOrders;

public class ShareRepairOrderRequest
{
    [JsonProperty("shareDate")]
    public DateTimeOffset ShareDate { get; set; }

    [JsonProperty("shareItem")]
    [JsonConverter(typeof(StringEnumConverter))]
    public ShareItem ShareItem { get; set; }
}

public enum ShareItem
{
    ESTIMATE,
    INSPECTION,
    INVOICE
}
