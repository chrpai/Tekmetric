using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Vehicles;

namespace Tekmetric.Resources;

public sealed class VehiclesClient
{
    private readonly TekmetricConnection _connection;

    internal VehiclesClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<Vehicle>> ListAsync(VehiclesQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<Vehicle>>("api/v1/vehicles", query, cancellationToken);

    public Task<Vehicle> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Vehicle>($"api/v1/vehicles/{id}", null, cancellationToken);

    public Task<ApiResponse<Vehicle>> CreateAsync(CreateVehicleRequest request, CancellationToken cancellationToken = default)
        => _connection.PostAsync<ApiResponse<Vehicle>>("api/v1/vehicles", request, cancellationToken);

    public Task<ApiResponse<Vehicle>> UpdateAsync(long id, UpdateVehicleRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<Vehicle>>($"api/v1/vehicles/{id}", request, cancellationToken);
}
