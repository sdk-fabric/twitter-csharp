/**
 * Fields automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Twitter;

public class Fields
{
    [JsonPropertyName("media.fields")]
    public string? MediaFields { get; set; }

    [JsonPropertyName("place.fields")]
    public string? PlaceFields { get; set; }

    [JsonPropertyName("poll.fields")]
    public string? PollFields { get; set; }

    [JsonPropertyName("tweet.fields")]
    public string? TweetFields { get; set; }

    [JsonPropertyName("user.fields")]
    public string? UserFields { get; set; }

}

