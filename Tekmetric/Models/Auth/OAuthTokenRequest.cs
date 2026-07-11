namespace Tekmetric.Models.Auth;

/// <summary>
/// Form (application/x-www-form-urlencoded) body for POST /api/v1/oauth/token.
/// Sent alongside an HTTP Basic Authorization header of Base64(client_id:client_secret).
/// </summary>
public class OAuthTokenRequest
{
    public string GrantType { get; set; } = "client_credentials";
}
