using System.Net;

namespace Tekmetric;

/// <summary>
/// Thrown when the Tekmetric API returns a non-success status code.
/// </summary>
public class TekmetricApiException : Exception
{
    public HttpStatusCode StatusCode { get; }

    /// <summary>Raw response body, if any, for diagnostics.</summary>
    public string? ResponseBody { get; }

    public TekmetricApiException(HttpStatusCode statusCode, string? responseBody)
        : base($"Tekmetric API request failed with status {(int)statusCode} ({statusCode}).{(string.IsNullOrEmpty(responseBody) ? string.Empty : " " + responseBody)}")
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
    }
}
