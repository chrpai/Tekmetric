using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Tekmetric.Models.Auth;

namespace Tekmetric.Internal;

/// <summary>
/// Shared HTTP + JSON + authentication plumbing used by every resource client.
/// Not intended for direct use; go through <see cref="TekmetricClient"/>.
/// </summary>
internal sealed class TekmetricConnection : IDisposable
{
    private static readonly HttpMethod Patch = new HttpMethod("PATCH");

    private readonly HttpClient _httpClient;
    private readonly bool _ownsHttpClient;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly SemaphoreSlim _authLock = new SemaphoreSlim(1, 1);
    private string? _accessToken;

    public TekmetricConnection(TekmetricClientOptions options)
    {
        if (options.ClientId is null) throw new ArgumentException("ClientId is required.", nameof(options));
        if (options.ClientSecret is null) throw new ArgumentException("ClientSecret is required.", nameof(options));

        _clientId = options.ClientId;
        _clientSecret = options.ClientSecret;

        _ownsHttpClient = options.HttpClient is null;
        _httpClient = options.HttpClient ?? new HttpClient();
        _httpClient.BaseAddress = new Uri(options.BaseUrl.ToString().TrimEnd('/') + "/");
    }

    public Task<TResponse> GetAsync<TResponse>(string path, object? query, CancellationToken cancellationToken)
        => SendAsync<TResponse>(HttpMethod.Get, path + QueryStringBuilder.Build(query), null, cancellationToken);

    public Task<TResponse> PostAsync<TResponse>(string path, object? body, CancellationToken cancellationToken)
        => SendAsync<TResponse>(HttpMethod.Post, path, body, cancellationToken);

    public Task<TResponse> PatchAsync<TResponse>(string path, object? body, CancellationToken cancellationToken)
        => SendAsync<TResponse>(Patch, path, body, cancellationToken);

    public Task<TResponse> PutAsync<TResponse>(string path, object? body, CancellationToken cancellationToken)
        => SendAsync<TResponse>(HttpMethod.Put, path, body, cancellationToken);

    public Task<TResponse> DeleteAsync<TResponse>(string path, CancellationToken cancellationToken)
        => SendAsync<TResponse>(HttpMethod.Delete, path, null, cancellationToken);

    private async Task<TResponse> SendAsync<TResponse>(HttpMethod method, string path, object? body, CancellationToken cancellationToken)
    {
        var response = await SendCoreAsync(method, path, body, cancellationToken, isRetry: false).ConfigureAwait(false);
        var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        return JsonConvert.DeserializeObject<TResponse>(json)!;
    }

    private async Task<HttpResponseMessage> SendCoreAsync(HttpMethod method, string path, object? body, CancellationToken cancellationToken, bool isRetry)
    {
        await EnsureAuthenticatedAsync(cancellationToken).ConfigureAwait(false);

        var request = new HttpRequestMessage(method, path.TrimStart('/'));
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        if (body is not null)
        {
            var json = JsonConvert.SerializeObject(body);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
        }

        var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized && !isRetry)
        {
            _accessToken = null;
            return await SendCoreAsync(method, path, body, cancellationToken, isRetry: true).ConfigureAwait(false);
        }

        if (!response.IsSuccessStatusCode)
        {
            var errorBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new TekmetricApiException(response.StatusCode, errorBody);
        }

        return response;
    }

    private async Task EnsureAuthenticatedAsync(CancellationToken cancellationToken)
    {
        if (_accessToken is not null)
        {
            return;
        }

        await _authLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_accessToken is not null)
            {
                return;
            }

            var request = new HttpRequestMessage(HttpMethod.Post, "api/v1/oauth/token");
            var basicCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", basicCredentials);
            request.Content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new TekmetricApiException(response.StatusCode, json);
            }

            var token = JsonConvert.DeserializeObject<OAuthTokenResponse>(json);
            _accessToken = token?.AccessToken;
        }
        finally
        {
            _authLock.Release();
        }
    }

    public void Dispose()
    {
        _authLock.Dispose();
        if (_ownsHttpClient)
        {
            _httpClient.Dispose();
        }
    }
}
