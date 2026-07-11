using Newtonsoft.Json;
using Tekmetric.Models.Common;

namespace Tekmetric.Models.Jobs;

public class Part
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("quantity")]
    public decimal? Quantity { get; set; }

    [JsonProperty("brand")]
    public string? Brand { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("partNumber")]
    public string? PartNumber { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>Cost in cents.</summary>
    [JsonProperty("cost")]
    public int? Cost { get; set; }

    /// <summary>Retail price in cents.</summary>
    [JsonProperty("retail")]
    public int? Retail { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    /// <summary>Tire width. Tire parts only.</summary>
    [JsonProperty("width")]
    public string? Width { get; set; }

    /// <summary>Tire aspect ratio. Tire parts only.</summary>
    [JsonProperty("ratio")]
    public decimal? Ratio { get; set; }

    /// <summary>Tire diameter. Tire parts only.</summary>
    [JsonProperty("diameter")]
    public decimal? Diameter { get; set; }

    [JsonProperty("constructionType")]
    public string? ConstructionType { get; set; }

    [JsonProperty("loadIndex")]
    public string? LoadIndex { get; set; }

    [JsonProperty("speedRating")]
    public string? SpeedRating { get; set; }

    [JsonProperty("partType")]
    public ReferenceCode? PartType { get; set; }

    [JsonProperty("partStatus")]
    public ReferenceCode? PartStatus { get; set; }

    /// <summary>DOT identification numbers. Tire parts only.</summary>
    [JsonProperty("dotNumbers")]
    public List<string>? DotNumbers { get; set; }
}
