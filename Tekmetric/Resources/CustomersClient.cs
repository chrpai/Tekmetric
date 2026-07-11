using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Customers;

namespace Tekmetric.Resources;

public sealed class CustomersClient
{
    private readonly TekmetricConnection _connection;

    internal CustomersClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<Customer>> ListAsync(CustomersQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<Customer>>("api/v1/customers", query, cancellationToken);

    public Task<Customer> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Customer>($"api/v1/customers/{id}", null, cancellationToken);

    public Task<ApiResponse<Customer>> CreateAsync(CreateCustomerRequest request, CancellationToken cancellationToken = default)
        => _connection.PostAsync<ApiResponse<Customer>>("api/v1/customers", request, cancellationToken);

    public Task<ApiResponse<Customer>> UpdateAsync(long id, UpdateCustomerRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<Customer>>($"api/v1/customers/{id}", request, cancellationToken);
}
