/**
 * TweetReply automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Twitter;
public class TweetReply
{
    [JsonPropertyName("exclude_reply_user_ids")]
    public List<string>? ExcludeReplyUserIds { get; set; }
    [JsonPropertyName("in_reply_to_tweet_id")]
    public string? InReplyToTweetId { get; set; }
}
