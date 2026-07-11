using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Jobs;

namespace Tekmetric.Resources;

public sealed class JobsClient
{
    private readonly TekmetricConnection _connection;

    internal JobsClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<Job>> ListAsync(JobsQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<Job>>("api/v1/jobs", query, cancellationToken);

    public Task<Job> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Job>($"api/v1/jobs/{id}", null, cancellationToken);

    public Task<ApiResponse<Job>> UpdateAsync(long id, UpdateJobRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<Job>>($"api/v1/jobs/{id}", request, cancellationToken);

    /// <summary>Updates the job clock logged time of a technician.</summary>
    public Task<JobClockResponse> UpdateClockAsync(long id, JobClockRequest request, CancellationToken cancellationToken = default)
        => _connection.PutAsync<JobClockResponse>($"api/v1/jobs/{id}/job-clock", request, cancellationToken);
}
