using Tekmetric.Models.Common;

namespace Tekmetric.Models.Inventory;

public class InventoryQueryParameters : PagedQueryParameters
{
    /// <summary>Required.</summary>
    public long? Shop { get; set; }

    /// <summary>Required. 1 Part, 2 Tire, 5 Battery.</summary>
    public int? PartTypeId { get; set; }

    /// <summary>Exact match only.</summary>
    public List<string>? PartNumbers { get; set; }

    /// <summary>Tire parts only.</summary>
    public string? Width { get; set; }

    /// <summary>Tire parts only.</summary>
    public decimal? Ratio { get; set; }

    /// <summary>Tire parts only.</summary>
    public decimal? Diameter { get; set; }

    /// <summary>Concatenation of width, ratio, and diameter. Tire parts only.</summary>
    public string? TireSize { get; set; }
}
