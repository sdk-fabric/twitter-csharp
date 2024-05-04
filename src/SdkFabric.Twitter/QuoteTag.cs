/**
 * QuoteTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Twitter;

public class QuoteTag : TagAbstract {
    public QuoteTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns Quote Tweets for a Tweet specified by the requested Tweet ID.
     */
    public async Task<TweetCollectionResponse> GetAll(string tweetId, string exclude, string expansions, int maxResults, string paginationToken, Fields fields)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();
        queryParams.Add("exclude", exclude);
        queryParams.Add("expansions", expansions);
        queryParams.Add("max_results", maxResults);
        queryParams.Add("pagination_token", paginationToken);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add('fields'),

        RestRequest request = new(this.Parser.Url("/2/tweets/:tweet_id/quote_tweets", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<TweetCollectionResponse>(response.Content);
        }

        if (response.ErrorException != null)
        {
            throw new ClientException("An unknown error occurred: " + response.ErrorException.Message, response.ErrorException);
        }

        throw (int) response.StatusCode switch
        {
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}