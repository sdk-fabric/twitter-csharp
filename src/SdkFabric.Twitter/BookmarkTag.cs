/**
 * BookmarkTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Twitter;

public class BookmarkTag : TagAbstract {
    public BookmarkTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Allows you to get an authenticated user&#039;s 800 most recent bookmarked Tweets.
     */
    public async Task<TweetCollection> GetAll(string userId, string expansions, string paginationToken, Fields fields)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);

        Dictionary<string, object> queryParams = new();
        queryParams.Add("expansions", expansions);
        queryParams.Add("pagination_token", paginationToken);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add("fields");

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/bookmarks", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<TweetCollection>(response.Content);
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

    public async Task<BookmarkResponse> Create(string userId, SingleTweet payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/bookmarks", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BookmarkResponse>(response.Content);
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

    public async Task<BookmarkResponse> Delete(string userId, string tweetId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/bookmarks/:tweet_id", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BookmarkResponse>(response.Content);
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
