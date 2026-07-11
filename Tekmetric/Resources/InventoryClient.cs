using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Inventory;

namespace Tekmetric.Resources;

public sealed class InventoryClient
{
    private readonly TekmetricConnection _connection;

    internal InventoryClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<InventoryPart>> ListAsync(InventoryQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<InventoryPart>>("api/v1/inventory", query, cancellationToken);
}
