/**
 * TweetCreate automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Twitter;
public class TweetCreate
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}