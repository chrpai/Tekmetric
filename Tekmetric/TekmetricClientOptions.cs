using System.Net.Http;

namespace Tekmetric;

public class TekmetricClientOptions
{
    /// <summary>
    /// OAuth client id issued by Tekmetric for your integration.
    /// </summary>
    public string ClientId { get; set; } = null!;

    /// <summary>
    /// OAuth client secret issued by Tekmetric for your integration.
    /// </summary>
    public string ClientSecret { get; set; } = null!;

    /// <summary>
    /// API base address. Defaults to <see cref="TekmetricEnvironment.Sandbox"/>.
    /// Set this to <see cref="TekmetricEnvironment.Production"/>'s URL to call
    /// the live API, or to a custom <see cref="Uri"/> (e.g. for testing).
    /// </summary>
    public Uri BaseUrl { get; set; } = TekmetricEnvironment.Sandbox.ToBaseUrl();

    /// <summary>
    /// Optional pre-existing HttpClient to use (e.g. from IHttpClientFactory).
    /// When omitted, TekmetricClient creates and owns its own instance.
    /// </summary>
    public HttpClient? HttpClient { get; set; }
}

/// <summary>
/// Known Tekmetric API environments.
/// </summary>
public enum TekmetricEnvironment
{
    Sandbox,
    Production
}

public static class TekmetricEnvironmentExtensions
{
    /// <summary>
    /// Resolves a <see cref="TekmetricEnvironment"/> to its API base address.
    /// </summary>
    public static Uri ToBaseUrl(this TekmetricEnvironment environment) => environment switch
    {
        TekmetricEnvironment.Sandbox => new Uri("https://sandbox.tekmetric.com/"),
        TekmetricEnvironment.Production => new Uri("https://shop.tekmetric.com/"),
        _ => throw new ArgumentOutOfRangeException(nameof(environment), environment, "Unknown Tekmetric environment.")
    };
}
