/**
 * BookmarkResponseMessage automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Twitter;
public class BookmarkResponseMessage
{
    [JsonPropertyName("bookmarked")]
    public bool? Bookmarked { get; set; }
}
