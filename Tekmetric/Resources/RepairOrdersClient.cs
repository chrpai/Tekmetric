using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.RepairOrders;

namespace Tekmetric.Resources;

public sealed class RepairOrdersClient
{
    private readonly TekmetricConnection _connection;

    internal RepairOrdersClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<RepairOrder>> ListAsync(RepairOrdersQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<RepairOrder>>("api/v1/repair-orders", query, cancellationToken);

    public Task<RepairOrder> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<RepairOrder>($"api/v1/repair-orders/{id}", null, cancellationToken);

    public Task<ApiResponse<RepairOrder>> UpdateAsync(long id, UpdateRepairOrderRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<RepairOrder>>($"api/v1/repair-orders/{id}", request, cancellationToken);

    /// <summary>Shares a Repair Order's estimate, invoice, or inspection.</summary>
    public Task<ApiResponse<RepairOrder>> ShareAsync(long id, ShareRepairOrderRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<RepairOrder>>($"api/v1/repair-orders/{id}/share-link", request, cancellationToken);

    /// <summary>Adds the given canned jobs to the repair order.</summary>
    public Task<ApiResponse<AddCannedJobsToRepairOrderResponseData>> AddCannedJobsAsync(long id, IEnumerable<long> cannedJobIds, CancellationToken cancellationToken = default)
        => _connection.PostAsync<ApiResponse<AddCannedJobsToRepairOrderResponseData>>($"api/v1/repair-orders/{id}/canned-jobs", cannedJobIds.ToList(), cancellationToken);
}
