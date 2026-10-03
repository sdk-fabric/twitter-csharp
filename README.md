
# twitter-csharp

This [SDK](https://github.com/sdk-fabric/twitter-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/twitter

## Usage

```csharp
using SdkFabric.Twitter.Client;

Client client = Client.Build("[access_token]")

// Returns a variety of information about the Tweet specified by the requested ID or list of IDs.
Tweet_Collection response = client.Tweet().getAll("ids", "expansions", default(Fields));

// Returns a variety of information about a single Tweet specified by the requested ID.
Tweet_Entity response = client.Tweet().get("tweet_id", "expansions", default(Fields));

// Creates a Tweet on behalf of an authenticated user.
Tweet_Create_Response response = client.Tweet().create(new Tweet());

// Allows a user or authenticated user ID to delete a Tweet.
Tweet_Delete_Response response = client.Tweet().delete("tweet_id");

// Hides or unhides a reply to a Tweet.
HideReply_Response response = client.Tweet().hideReply("tweet_id", new HideReply());

// Allows you to get information about a Tweet’s liking users.
User_Collection response = client.Tweet().getLikingUsers("tweet_id", "expansions", 1, "pagination_token");

// The Usage API in the Twitter API v2 allows developers to programmatically retrieve their project usage.
Tweet_Usage_Response response = client.Usage().getTweets();

// Returns a variety of information about one or more users specified by the requested IDs.
User_Collection response = client.User().getAll("ids", "expansions", default(Fields));

// Returns a variety of information about a single user specified by the requested ID.
User response = client.User().get("user_id", "expansions", default(Fields));

// Allows you to retrieve a collection of the most recent Tweets and Retweets posted by you and users you follow.
Tweet_Collection response = client.User().getTimeline("user_id", "exclude", "expansions", default(Pagination), default(Fields));

// Tweets liked by a user.
Tweet_Collection response = client.User().getLikedTweets("user_id", "expansions", 1, "pagination_token", default(Fields));

// Allows a user or authenticated user ID to unlike a Tweet.
Like_Response response = client.User().removeLike("user_id", "tweet_id");

// Causes the user ID identified in the path parameter to Like the target Tweet.
Like_Response response = client.User().createLike("user_id", new Single_Tweet());

// Returns a variety of information about one or more users specified by their usernames.
User_Collection response = client.User().findByName("usernames", "expansions", default(Fields));

// Returns information about an authorized user.
User response = client.User().getMe("expansions", "fields");

// Allows you to get an authenticated user's 800 most recent bookmarked Tweets.
Tweet_Collection response = client.Bookmark().getAll("user_id", "expansions", "pagination_token", default(Fields));

Bookmark_Response response = client.Bookmark().create("user_id", new Single_Tweet());

Bookmark_Response response = client.Bookmark().delete("user_id", "tweet_id");

Tweet_Collection response = client.Search().getRecent("query", "sort_order", "expansions", default(Pagination), default(Fields));

// Returns Quote Tweets for a Tweet specified by the requested Tweet ID.
Tweet_Collection response = client.Quote().getAll("tweet_id", "exclude", "expansions", 1, "pagination_token", default(Fields));

// The Trends lookup endpoint allow developers to get the Trends for a location, specified using the where-on-earth id (WOEID).
Trend_Collection response = client.Trends().getByWoeid("woeid");

// Returns the Retweets for a given Tweet ID.
Tweet_Collection response = client.Retweet().getAll("tweet_id", "expansions", 1, default(Fields));
```
