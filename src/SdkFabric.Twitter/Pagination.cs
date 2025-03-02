/**
 * Pagination automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Twitter;

public class Pagination
{
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    [JsonPropertyName("since_id")]
    public string? SinceId { get; set; }

    [JsonPropertyName("until_id")]
    public string? UntilId { get; set; }

    [JsonPropertyName("max_results")]
    public int? MaxResults { get; set; }

    [JsonPropertyName("pagination_token")]
    public string? PaginationToken { get; set; }

}

