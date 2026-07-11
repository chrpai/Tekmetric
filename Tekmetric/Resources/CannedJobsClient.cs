using Tekmetric.Internal;
using Tekmetric.Models.CannedJobs;
using Tekmetric.Models.Common;

namespace Tekmetric.Resources;

public sealed class CannedJobsClient
{
    private readonly TekmetricConnection _connection;

    internal CannedJobsClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<CannedJob>> ListAsync(CannedJobsQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<CannedJob>>("api/v1/canned-jobs", query, cancellationToken);
}
