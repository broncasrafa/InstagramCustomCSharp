using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram.Core.API;
using Instagram.Core.Classes;
using Instagram.Entity;

namespace ConsoleApp.Teste
{
    public class TestClass
    {
        private static IInstagramCustomApi _InstagramCustomApi;

        public TestClass(IInstagramCustomApi IInstagramCustomApi)
        {
            _InstagramCustomApi = IInstagramCustomApi;
        }

        public bool ExecuteLoginTest()
        {
            var loginResult = _InstagramCustomApi.Login();

            if (!loginResult.Authenticated)
            {
                Console.WriteLine("Não autenticado");
                return false;
            }

            Console.WriteLine("Usuário autenticado");

            return true;
        }

        public User GetUserTest(string username)
        {
            return _InstagramCustomApi.GetUser(username).Data;
        }

        public User GetUserDetailsTest(string username)
        {
            return _InstagramCustomApi.GetUserDetails(username).Data;
        }

        public EdgeWebFeedTimeline GetUserTimelineMediasTest(string endCursor = null)
        {
            return _InstagramCustomApi.GetUserTimelineMedias(endCursor).Data;
        }

        public EdgeSavedMedia GetSavedUserMediasTest()
        {
            return _InstagramCustomApi.GetSavedUserMedias().Data;
        }

        public EdgeUserToPhotosOfYou GetTaggedUserMediasTest(string userId)
        {
            return _InstagramCustomApi.GetTaggedUserMedias(userId).Data;
        }

        public EdgeActivityCount GetUserActivitySummaryTest()
        {
            return _InstagramCustomApi.GetUserActivitySummary().Data;
        }

        public ActivityFeed GetUserActivityFeedTest()
        {
            return _InstagramCustomApi.GetUserActivityFeed().Data;
        }

        public FeedReelsTray GetRecentsFollowingUsersStoriesTest()
        {
            return _InstagramCustomApi.GetRecentsFollowingUsersStories().Data;
        }

        public DataStoryMedia GetStoryByUserIdsTest(string[] userIds)
        {
            return _InstagramCustomApi.GetStoryByUserIds(userIds).Data;
        }

        public DataStoryMedia GetRecentsStoriesByUserIdTest(string userId)
        {
            return _InstagramCustomApi.GetRecentsStoriesByUserId(userId).Data;
        }

        public DataStoryMedia GetFeaturedStoriesByUserIdTest(string userId)
        {
            return _InstagramCustomApi.GetFeaturedStoriesByUserId(userId).Data;
        }

        public DataStoryMedia GetFeaturedStoriesByHighlightReelIdsTest(string[] highlight_reel_ids)
        {
            return _InstagramCustomApi.GetFeaturedStoriesByHighlightReelIds(highlight_reel_ids).Data;
        }

        public DataStoryMedia GetSuggestedUsersTest(string userId)
        {
            return _InstagramCustomApi.GetSuggestedUsers(userId).Data;
        }

        public Search SearchTest(string query)
        {
            return _InstagramCustomApi.Search(query).Data;
        }

        public User GetWebDiscoverMediaTest(int limitPerPage = 24, int endCursor = 0)
        {
            return _InstagramCustomApi.GetWebDiscoverMedia(limitPerPage, endCursor).Data;
        }

        public string LikeTest(string mediaId)
        {
            return _InstagramCustomApi.Like(mediaId).Data;
        }

        public string UnlikeTest(string mediaId)
        {
            return _InstagramCustomApi.Unlike(mediaId).Data;
        }

        public string FollowTest(string userId)
        {
            return _InstagramCustomApi.Follow(userId).Data;
        }

        public string UnfollowTest(string userId)
        {
            return _InstagramCustomApi.Unfollow(userId).Data;
        }

        public CommentResponse CommentTest(string mediaId, string text)
        {
            return _InstagramCustomApi.Comment(mediaId, text).Data;
        }

        public string DeleteCommentTest(string mediaId, string commentId)
        {
            return _InstagramCustomApi.DeleteComment(mediaId, commentId).Data;
        }
        public string LikeCommentTest(string commentId)
        {
            return _InstagramCustomApi.LikeComment(commentId).Data;
        }
        public string UnlikeCommentTest(string commentId)
        {
            return _InstagramCustomApi.UnlikeComment(commentId).Data;
        }

        public string SaveMediaTest(string mediaId)
        {
            return _InstagramCustomApi.SaveMedia(mediaId).Data;
        }

        public string UnSaveMediaTest(string mediaId)
        {
            return _InstagramCustomApi.UnsaveMedia(mediaId).Data;
        }

        public string RequestDownloadDataInformationTest(string email)
        {
            return _InstagramCustomApi.RequestDownloadDataInformation(email).Data;
        }

        public Hashtag GetHashtagMediaInitTest(string hashtag)
        {
            return _InstagramCustomApi.GetHashtag(hashtag).Data;
        }

        public EdgeHashtagToMedia GetHashtagMediasTest(string hashtag, string endCursor, int limitPerPage = 12)
        {
            return _InstagramCustomApi.GetHashtagMedias(hashtag, endCursor, limitPerPage).Data;
        }

        public UserInfo GetUserInfoTest()
        {
            return _InstagramCustomApi.GetUserInfo().Data;
        }

        public ShortcodeMediaLikes GetMediaLikesTest(string shortcode, string endCursor = null, int limitPerPage = 24)
        {
            return _InstagramCustomApi.GetMediaLikes(shortcode, endCursor, limitPerPage).Data;
        }

        public ShortcodeMedia GetMediaInfoDataTest(string shortcode)
        {
            return _InstagramCustomApi.GetMediaInfoData(shortcode).Data;
        }

        public EdgeMediaToParentComment GetMediaCommentsTest(string shortcode, string endCursor, int limitPerPage = 12)
        {
            return _InstagramCustomApi.GetMediaComments(shortcode, endCursor, limitPerPage).Data;
        }

        public Comment GetLikesFromCommentTest(string comment_id, string endCursor = null, int limitPerPage = 48)
        {
            return _InstagramCustomApi.GetLikesFromComment(comment_id, endCursor, limitPerPage).Data;
        }

        public Comment GetCommentRepliesTest(string comment_id, string endCursor = null, int limitPerPage = 48)
        {
            return _InstagramCustomApi.GetCommentReplies(comment_id, endCursor, limitPerPage).Data;
        }
        
    }
}
