/**
 * TweetTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Twitter;

public class TweetTag : TagAbstract {
    public TweetTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a variety of information about the Tweet specified by the requested ID or list of IDs.
     */
    public async Task<TweetCollection> GetAll(string ids, string expansions, Fields fields)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("ids", ids);
        queryParams.Add("expansions", expansions);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add('fields');

        RestRequest request = new(this.Parser.Url("/2/tweets", pathParams), Method.Get);
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

    /**
     * Returns a variety of information about a single Tweet specified by the requested ID.
     */
    public async Task<TweetEntity> Get(string tweetId, string expansions, Fields fields)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();
        queryParams.Add("expansions", expansions);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add('fields');

        RestRequest request = new(this.Parser.Url("/2/tweets/:tweet_id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<TweetEntity>(response.Content);
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

    /**
     * Creates a Tweet on behalf of an authenticated user.
     */
    public async Task<TweetCreateResponse> Create(Tweet payload)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/tweets", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<TweetCreateResponse>(response.Content);
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

    /**
     * Allows a user or authenticated user ID to delete a Tweet.
     */
    public async Task<TweetDeleteResponse> Delete(string tweetId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/tweets/:tweet_id", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<TweetDeleteResponse>(response.Content);
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

    /**
     * Hides or unhides a reply to a Tweet.
     */
    public async Task<HideReplyResponse> HideReply(string tweetId, HideReply payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/tweets/:tweet_id/hidden", pathParams), Method.Put);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<HideReplyResponse>(response.Content);
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
