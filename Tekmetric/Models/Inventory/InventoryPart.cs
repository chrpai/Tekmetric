using Newtonsoft.Json;

namespace Tekmetric.Models.Inventory;

public class InventoryPart
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("partNumber")]
    public string? PartNumber { get; set; }

    [JsonProperty("position")]
    public string? Position { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>Cost in cents.</summary>
    [JsonProperty("cost")]
    public int? Cost { get; set; }

    /// <summary>Retail price in cents.</summary>
    [JsonProperty("retail")]
    public int? Retail { get; set; }

    [JsonProperty("brand")]
    public string? Brand { get; set; }

    [JsonProperty("ordered")]
    public decimal? Ordered { get; set; }

    [JsonProperty("min")]
    public decimal? Min { get; set; }

    [JsonProperty("max")]
    public decimal? Max { get; set; }

    [JsonProperty("shopId")]
    public long? ShopId { get; set; }

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

    /// <summary>1 Part, 2 Tire, 5 Battery.</summary>
    [JsonProperty("partTypeId")]
    public int? PartTypeId { get; set; }

    [JsonProperty("oemPartNumber")]
    public string? OemPartNumber { get; set; }

    [JsonProperty("alternatePartNumber")]
    public string? AlternatePartNumber { get; set; }

    [JsonProperty("binNumber")]
    public string? BinNumber { get; set; }

    [JsonProperty("deletedDate")]
    public DateTimeOffset? DeletedDate { get; set; }

    [JsonProperty("lastUsedDate")]
    public DateTimeOffset? LastUsedDate { get; set; }

    [JsonProperty("inStock")]
    public decimal? InStock { get; set; }

    /// <summary>Quantity currently allocated to work in progress.</summary>
    [JsonProperty("wip")]
    public decimal? Wip { get; set; }

    [JsonProperty("available")]
    public decimal? Available { get; set; }

    /// <summary>Total value of inventory on hand, in cents.</summary>
    [JsonProperty("totalValue")]
    public int? TotalValue { get; set; }

    [JsonProperty("net")]
    public decimal? Net { get; set; }

    [JsonProperty("aboveStock")]
    public decimal? AboveStock { get; set; }

    [JsonProperty("belowStock")]
    public decimal? BelowStock { get; set; }

    [JsonProperty("needed")]
    public decimal? Needed { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("tireType")]
    public string? TireType { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("mileageWarranty")]
    public string? MileageWarranty { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("loadRange")]
    public string? LoadRange { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("tireCategory")]
    public string? TireCategory { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("runFlat")]
    public bool? RunFlat { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("sideWallStyle")]
    public string? SideWallStyle { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("treadwear")]
    public string? Treadwear { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("traction")]
    public string? Traction { get; set; }

    /// <summary>Tire parts only.</summary>
    [JsonProperty("temperature")]
    public string? Temperature { get; set; }
}
