using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Tekmetric.Internal;

/// <summary>
/// Reflects over a query-parameters object's public properties and builds a
/// URL query string, skipping nulls and repeating the key for list values.
/// </summary>
internal static class QueryStringBuilder
{
    public static string Build(object? queryParameters)
    {
        if (queryParameters is null)
        {
            return string.Empty;
        }

        var pairs = new List<string>();

        foreach (var property in queryParameters.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var value = property.GetValue(queryParameters);
            if (value is null)
            {
                continue;
            }

            var key = ToCamelCase(property.Name);

            if (value is string stringValue)
            {
                if (stringValue.Length > 0)
                {
                    pairs.Add(Format(key, stringValue));
                }
                continue;
            }

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (item is null)
                    {
                        continue;
                    }
                    pairs.Add(Format(key, FormatValue(item)));
                }
                continue;
            }

            pairs.Add(Format(key, FormatValue(value)));
        }

        return pairs.Count == 0 ? string.Empty : "?" + string.Join("&", pairs);
    }

    private static string FormatValue(object value)
    {
        switch (value)
        {
            case bool b:
                return b ? "true" : "false";
            case DateTime dt:
                return dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            case DateTimeOffset dto:
                return dto.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            case IFormattable formattable:
                return formattable.ToString(null, CultureInfo.InvariantCulture);
            default:
                return value.ToString() ?? string.Empty;
        }
    }

    private static string Format(string key, string value)
        => $"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value)}";

    private static string ToCamelCase(string propertyName)
        => propertyName.Length == 0
            ? propertyName
            : char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);
}
