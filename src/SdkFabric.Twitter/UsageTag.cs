/**
 * UsageTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Twitter;

public class UsageTag : TagAbstract {
    public UsageTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * The Usage API in the Twitter API v2 allows developers to programmatically retrieve their project usage. Using thie endpoint, developers can keep a track and monitor of the number of Tweets they have pulled for a given billing cycle.
     */
    public async Task<TweetUsageResponse> GetTweets()
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/usage/tweets", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<TweetUsageResponse>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }


}
