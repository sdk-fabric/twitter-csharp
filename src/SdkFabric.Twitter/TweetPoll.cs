/**
 * TweetPoll automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Twitter;
public class TweetPoll
{
    [JsonPropertyName("duration_minutes")]
    public int? DurationMinutes { get; set; }
    [JsonPropertyName("options")]
    public System.Collections.Generic.List<string>? Options { get; set; }
}
