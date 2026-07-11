using Tekmetric.Models.Common;

namespace Tekmetric.Models.CannedJobs;

public class CannedJobsQueryParameters : PagedQueryParameters
{
    public long? Shop { get; set; }

    /// <summary>Filter by job name.</summary>
    public string? Search { get; set; }

    /// <summary>Filter by job category codes. Use "Unassigned" for jobs with no category.</summary>
    public List<string>? Categories { get; set; }

    /// <summary>Filter by labor rates, in cents. Use "None" for jobs with no labor.</summary>
    public List<string>? Rates { get; set; }
}
