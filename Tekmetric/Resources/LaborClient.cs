using Tekmetric.Internal;
using Tekmetric.Models.Jobs;

namespace Tekmetric.Resources;

public sealed class LaborClient
{
    private readonly TekmetricConnection _connection;

    internal LaborClient(TekmetricConnection connection) => _connection = connection;

    /// <summary>Updates the technician assigned to a labor line.</summary>
    public Task<UpdateLaborResponse> UpdateAsync(long id, UpdateLaborRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<UpdateLaborResponse>($"api/v1/labor/{id}", request, cancellationToken);
}
