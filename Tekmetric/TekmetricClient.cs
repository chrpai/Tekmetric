using Tekmetric.Internal;
using Tekmetric.Resources;

namespace Tekmetric;

/// <summary>
/// Entry point for calling the Tekmetric shop management API.
/// </summary>
public sealed class TekmetricClient : IDisposable
{
    private readonly TekmetricConnection _connection;

    public TekmetricClient(TekmetricClientOptions options)
    {
        _connection = new TekmetricConnection(options);

        Shops = new ShopsClient(_connection);
        Customers = new CustomersClient(_connection);
        Vehicles = new VehiclesClient(_connection);
        RepairOrders = new RepairOrdersClient(_connection);
        Jobs = new JobsClient(_connection);
        Labor = new LaborClient(_connection);
        CannedJobs = new CannedJobsClient(_connection);
        Appointments = new AppointmentsClient(_connection);
        Employees = new EmployeesClient(_connection);
        Inventory = new InventoryClient(_connection);
    }

    public TekmetricClient(string clientId, string clientSecret, Uri? baseUrl = null)
        : this(new TekmetricClientOptions
        {
            ClientId = clientId,
            ClientSecret = clientSecret,
            BaseUrl = baseUrl ?? TekmetricEnvironment.Sandbox.ToBaseUrl()
        })
    {
    }

    public ShopsClient Shops { get; }
    public CustomersClient Customers { get; }
    public VehiclesClient Vehicles { get; }
    public RepairOrdersClient RepairOrders { get; }
    public JobsClient Jobs { get; }
    public LaborClient Labor { get; }
    public CannedJobsClient CannedJobs { get; }
    public AppointmentsClient Appointments { get; }
    public EmployeesClient Employees { get; }
    public InventoryClient Inventory { get; }

    public void Dispose() => _connection.Dispose();
}
