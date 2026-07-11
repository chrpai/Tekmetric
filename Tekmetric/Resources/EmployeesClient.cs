using Tekmetric.Internal;
using Tekmetric.Models.Common;
using Tekmetric.Models.Employees;

namespace Tekmetric.Resources;

public sealed class EmployeesClient
{
    private readonly TekmetricConnection _connection;

    internal EmployeesClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<Employee>> ListAsync(EmployeesQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<Employee>>("api/v1/employees", query, cancellationToken);

    public Task<Employee> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Employee>($"api/v1/employees/{id}", null, cancellationToken);
}
