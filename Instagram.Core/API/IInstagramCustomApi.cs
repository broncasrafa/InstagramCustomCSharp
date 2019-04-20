using Instagram.Core.Classes;
using Instagram.Core.Classes.Interfaces;
using Instagram.Entity;

namespace Instagram.Core.API
{
    public interface IInstagramCustomApi
    {
        bool IsUserAuthenticated { get; }
        string Cookie { get; }

        AuthenticatedLogin Login(); // Arrumar para atender ao IResult
        
        IResult<EdgeOwnerToTimelineMediaNode> GetShortcodeMedia(string shortcode);

        IResult<UserInfo> GetUserInfo();
        IResult<User> GetUser(string username);
        IResult<User> GetUserDetails(string username);
        IResult<EdgeActivityCount> GetUserActivitySummary();
        IResult<ActivityFeed> GetUserActivityFeed();
        IResult<EdgeOwnerToTimelineMedia> GetUserMedias(string userid, string endCursor, int limitPerPage = 12);
        IResult<EdgeOwnerToTimelineMedia> GetAllUserMedias(string username, int limitPerPage = 12);
        IResult<EdgeSavedMedia> GetSavedUserMedias(int limitPerPage = 12);
        IResult<EdgeWebFeedTimeline> GetUserTimelineMedias(string endCursor = null);

        IResult<User> GetWebDiscoverMedia(int limitPerPage = 24, int endCursor = 0);


        IResult<Search> Search(string query);


        IResult<EdgeUserToPhotosOfYou> GetTaggedUserMedias(string userId, int limitPerPage = 12);


        IResult<EdgeFollowedBy> GetUserFollowers(string userId, int limitPerPage = 12);


        IResult<EdgeFollow> GetUserFollowing(string userId, int limitPerPage = 12);
        IResult<EdgeFollowingHashtag> GetUserHashtagFollowing(string userId);


        IResult<FeedReelsTray> GetRecentsFollowingUsersStories();
        IResult<DataStoryMedia> GetRecentsStoriesByUserId(string userId);
        IResult<DataStoryMedia> GetFeaturedStoriesByUserId(string userId);
        IResult<DataStoryMedia> GetFeaturedStoriesByHighlightReelIds(string[] highlight_reel_ids);
        IResult<DataStoryMedia> GetStoryByUserIds(string[] userIds);


        IResult<DataStoryMedia> GetSuggestedUsers(string userId);


        IResult<string> Like(string mediaId);
        IResult<string> Unlike(string mediaId);
        IResult<string> RequestDownloadDataInformation(string email);


        IResult<Hashtag> GetHashtag(string hashtag);
        IResult<EdgeHashtagToMedia> GetHashtagMedias(string hashtag, string endCursor, int limitPerPage = 12);
        IResult<ShortcodeHashtagMedia> GetShortcodeHashtagMedia(string shortcode);
    }
}

// GetUserDetails  ********************************
// GetSavedUserMedias *****************************
// GetTaggedUserMedias ****************************
// GetUserActivity ********************************
// GetUserFollowers *******************************
// GetUserFollowing *******************************
// GetUserHashtagFollowing ************************
// GetUserStories   *******************************
// GetUserFeaturedStories *************************
// GetUserFeaturedStoriesIds **********************
// GetSuggestedUsers = edge_suggested_users *******