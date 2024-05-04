/**
 * UserTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Twitter;

public class UserTag : TagAbstract {
    public UserTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<TweetCollectionResponse> GetTimeline(string userId, string startTime, string endTime, string sinceId, string untilId, string exclude, string expansions, int maxResults, string paginationToken, Fields fields)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);

        Dictionary<string, object> queryParams = new();
        queryParams.Add("start_time", startTime);
        queryParams.Add("end_time", endTime);
        queryParams.Add("since_id", sinceId);
        queryParams.Add("until_id", untilId);
        queryParams.Add("exclude", exclude);
        queryParams.Add("expansions", expansions);
        queryParams.Add("max_results", maxResults);
        queryParams.Add("pagination_token", paginationToken);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add('fields'),

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/timelines/reverse_chronological", pathParams), Method.Get);
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

    /**
     * Tweets liked by a user
     */
    public async Task<TweetCollectionResponse> GetLikedTweets(string userId, string expansions, int maxResults, string paginationToken, Fields fields)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);

        Dictionary<string, object> queryParams = new();
        queryParams.Add("expansions", expansions);
        queryParams.Add("max_results", maxResults);
        queryParams.Add("pagination_token", paginationToken);
        queryParams.Add("fields", fields);

        List<string> queryStructNames = new();
        queryStructNames.Add('fields'),

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/liked_tweets", pathParams), Method.Get);
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

    public async Task<LikeResponse> RemoveLike(string userId, string tweetId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);
        pathParams.Add("tweet_id", tweetId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/likes/:tweet_id", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<LikeResponse>(response.Content);
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

    public async Task<LikeResponse> CreateLike(string userId, SingleTweet payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user_id", userId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/2/users/:user_id/likes", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<LikeResponse>(response.Content);
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
