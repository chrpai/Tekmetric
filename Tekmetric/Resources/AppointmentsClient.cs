using Tekmetric.Internal;
using Tekmetric.Models.Appointments;
using Tekmetric.Models.Common;

namespace Tekmetric.Resources;

public sealed class AppointmentsClient
{
    private readonly TekmetricConnection _connection;

    internal AppointmentsClient(TekmetricConnection connection) => _connection = connection;

    public Task<PagedResponse<Appointment>> ListAsync(AppointmentsQueryParameters? query = null, CancellationToken cancellationToken = default)
        => _connection.GetAsync<PagedResponse<Appointment>>("api/v1/appointments", query, cancellationToken);

    public Task<Appointment> GetAsync(long id, CancellationToken cancellationToken = default)
        => _connection.GetAsync<Appointment>($"api/v1/appointments/{id}", null, cancellationToken);

    /// <summary>Creates an appointment. The response data is the id of the new appointment.</summary>
    public Task<ApiResponse<long>> CreateAsync(CreateAppointmentRequest request, CancellationToken cancellationToken = default)
        => _connection.PostAsync<ApiResponse<long>>("api/v1/appointments", request, cancellationToken);

    public Task<ApiResponse<Appointment>> UpdateAsync(long id, UpdateAppointmentRequest request, CancellationToken cancellationToken = default)
        => _connection.PatchAsync<ApiResponse<Appointment>>($"api/v1/appointments/{id}", request, cancellationToken);

    public Task<ApiResponse<long>> DeleteAsync(long id, CancellationToken cancellationToken = default)
        => _connection.DeleteAsync<ApiResponse<long>>($"api/v1/appointments/{id}", cancellationToken);
}
