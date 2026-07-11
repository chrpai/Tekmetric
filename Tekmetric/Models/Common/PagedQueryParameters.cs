namespace Tekmetric.Models.Common;

/// <summary>
/// Sort/pagination query parameters shared by every list (GET collection) endpoint.
/// </summary>
public abstract class PagedQueryParameters
{
    /// <summary>Property to sort on. Some endpoints accept multiple, comma-separated.</summary>
    public string? Sort { get; set; }

    public SortDirection? SortDirection { get; set; }

    /// <summary>Max results per page. Values above 100 are capped to 100 by the API.</summary>
    public int? Size { get; set; }

    /// <summary>Zero-based page index.</summary>
    public int? Page { get; set; }
}

public enum SortDirection
{
    ASC,
    DESC
}
