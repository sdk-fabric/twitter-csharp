
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
TweetCollection response = client.Tweet().Getall("ids", "expansions", default(Fields));

// Returns a variety of information about a single Tweet specified by the requested ID.
TweetEntity response = client.Tweet().Get("tweet_id", "expansions", default(Fields));

// Creates a Tweet on behalf of an authenticated user.
TweetCreateResponse response = client.Tweet().Create(new Tweet());

// Allows a user or authenticated user ID to delete a Tweet.
TweetDeleteResponse response = client.Tweet().Delete("tweet_id");

// Hides or unhides a reply to a Tweet.
HidereplyResponse response = client.Tweet().Hidereply("tweet_id", new Hidereply());

// Allows you to get information about a Tweet’s liking users.
UserCollection response = client.Tweet().Getlikingusers("tweet_id", "expansions", 1, "pagination_token");

// The Usage API in the Twitter API v2 allows developers to programmatically retrieve their project usage.
TweetUsageResponse response = client.Usage().Gettweets();

// Returns a variety of information about one or more users specified by the requested IDs.
UserCollection response = client.User().Getall("ids", "expansions", default(Fields));

// Returns a variety of information about a single user specified by the requested ID.
User response = client.User().Get("user_id", "expansions", default(Fields));

// Allows you to retrieve a collection of the most recent Tweets and Retweets posted by you and users you follow.
TweetCollection response = client.User().Gettimeline("user_id", "exclude", "expansions", default(Pagination), default(Fields));

// Tweets liked by a user.
TweetCollection response = client.User().Getlikedtweets("user_id", "expansions", 1, "pagination_token", default(Fields));

// Allows a user or authenticated user ID to unlike a Tweet.
LikeResponse response = client.User().Removelike("user_id", "tweet_id");

// Causes the user ID identified in the path parameter to Like the target Tweet.
LikeResponse response = client.User().Createlike("user_id", new SingleTweet());

// Returns a variety of information about one or more users specified by their usernames.
UserCollection response = client.User().Findbyname("usernames", "expansions", default(Fields));

// Returns information about an authorized user.
User response = client.User().Getme("expansions", "fields");

// Allows you to get an authenticated user's 800 most recent bookmarked Tweets.
TweetCollection response = client.Bookmark().Getall("user_id", "expansions", "pagination_token", default(Fields));

BookmarkResponse response = client.Bookmark().Create("user_id", new SingleTweet());

BookmarkResponse response = client.Bookmark().Delete("user_id", "tweet_id");

TweetCollection response = client.Search().Getrecent("query", "sort_order", "expansions", default(Pagination), default(Fields));

// Returns Quote Tweets for a Tweet specified by the requested Tweet ID.
TweetCollection response = client.Quote().Getall("tweet_id", "exclude", "expansions", 1, "pagination_token", default(Fields));

// The Trends lookup endpoint allow developers to get the Trends for a location, specified using the where-on-earth id (WOEID).
TrendCollection response = client.Trends().Getbywoeid("woeid");

// Returns the Retweets for a given Tweet ID.
TweetCollection response = client.Retweet().Getall("tweet_id", "expansions", 1, default(Fields));
```
