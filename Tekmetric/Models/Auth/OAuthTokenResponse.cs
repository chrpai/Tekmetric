using Newtonsoft.Json;

namespace Tekmetric.Models.Auth;

/// <summary>
/// Response from POST /api/v1/oauth/token. Sent as HTTP Basic auth
/// (Base64 client_id:client_secret) with a client_credentials grant.
/// </summary>
public class OAuthTokenResponse
{
    [JsonProperty("access_token")]
    public string? AccessToken { get; set; }

    [JsonProperty("token_type")]
    public string? TokenType { get; set; }

    /// <summary>Space-separated list of Shop IDs the token has access to.</summary>
    [JsonProperty("scope")]
    public string? Scope { get; set; }
}
