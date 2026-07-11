using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Shops;

namespace Tekmetric.Resources;

public sealed class ShopsClient
{
    private readonly TekmetricConnection _connection;

    internal ShopsClient(TekmetricConnection connection) => _connection = connection;

    /// <summary>Returns the shops your token has been granted access to.</summary>
    public Task<List<Shop>> ListAsync(CancellationToken cancellationToken = default)
        => _connection.GetAsync<List<Shop>>("api/v1/shops", null, cancellationToken);

    public Task<Shop> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Shop>($"api/v1/shops/{id}", null, cancellationToken);

    /// <summary>Disconnects the shop with the given id from the token's scope.</summary>
    public Task<ApiResponse<long>> DisconnectAsync(long id, CancellationToken cancellationToken = default)
        => _connection.DeleteAsync<ApiResponse<long>>($"api/v1/shops/{id}/scope", cancellationToken);
}
