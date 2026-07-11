using Newtonsoft.Json;

namespace Tekmetric.Models.Common;

/// <summary>
/// Spring-style page envelope returned by every list (GET collection) endpoint.
/// </summary>
public class PagedResponse<TItem>
{
    [JsonProperty("content")]
    public List<TItem>? Content { get; set; }

    [JsonProperty("pageable")]
    public Pageable? Pageable { get; set; }

    [JsonProperty("totalPages")]
    public int? TotalPages { get; set; }

    [JsonProperty("totalElements")]
    public long? TotalElements { get; set; }

    [JsonProperty("last")]
    public bool? Last { get; set; }

    [JsonProperty("first")]
    public bool? First { get; set; }

    [JsonProperty("size")]
    public int? Size { get; set; }

    [JsonProperty("number")]
    public int? Number { get; set; }

    [JsonProperty("numberOfElements")]
    public int? NumberOfElements { get; set; }

    [JsonProperty("sort")]
    public SortInfo? Sort { get; set; }

    [JsonProperty("empty")]
    public bool? Empty { get; set; }
}

public class Pageable
{
    [JsonProperty("sort")]
    public SortInfo? Sort { get; set; }

    [JsonProperty("offset")]
    public long? Offset { get; set; }

    [JsonProperty("pageNumber")]
    public int? PageNumber { get; set; }

    [JsonProperty("pageSize")]
    public int? PageSize { get; set; }

    [JsonProperty("paged")]
    public bool? Paged { get; set; }

    [JsonProperty("unpaged")]
    public bool? Unpaged { get; set; }
}

public class SortInfo
{
    [JsonProperty("sorted")]
    public bool? Sorted { get; set; }

    [JsonProperty("unsorted")]
    public bool? Unsorted { get; set; }

    [JsonProperty("empty")]
    public bool? Empty { get; set; }
}
