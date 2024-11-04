using System.Text.Json;

namespace ADI.Services.Extensions;

public static class JsonExtensions
{
    private static readonly JsonSerializerOptions DefaultOptions = new() { PropertyNameCaseInsensitive = true };
    public static T JsonDeserialize<T>(this string json)
    {
        return JsonSerializer.Deserialize<T>(json, DefaultOptions);
    }
}