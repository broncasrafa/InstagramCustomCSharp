using System;
using System.Web;
using Instagram.Core.API;
using Instagram.Core.API.Builder;
using Instagram.Core.Classes;

namespace ConsoleApp.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Inicio do processo em {DateTime.Now}.....");

            Execute();

            Console.WriteLine($"\nFim do processo em {DateTime.Now}.....");
            Console.WriteLine("\n\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


        private static IInstagramCustomApi _InstagramCustomApi;
        private static void Execute()
        {
            _InstagramCustomApi = InstagramCustomApiBuilder.CreateBuilder()
                                                            .SetUser(new UserSessionData { Username = "YOUR-USERNAME", Password = "YOUR-PASSWORD" })
                                                            .Build();

            TestClass testClass = new TestClass(_InstagramCustomApi);

            var IsAuthenticated = testClass.ExecuteLoginTest();

            if (!IsAuthenticated)
            {
                return;
            }

            //var userDetails = testClass.GetUserDetailsTest("broncasrafa");
            //var savedUserMedias = testClass.GetSavedUserMediasTest();
            //var taggedUserMedias = testClass.GetTaggedUserMediasTest("764283413");
            //var userActivitySummary = testClass.GetUserActivitySummaryTest();
            //var userActivityFeed = testClass.GetUserActivityFeedTest();
            //var recentsUserStories = testClass.GetRecentsFollowingUsersStoriesTest();
            //var recentsUserStories = testClass.GetRecentsStoriesByUserIdTest("195539792");
            //var destaquesUserStories = testClass.GetFeaturedStoriesByUserIdTest("195539792");
            //string[] ids = new string[] { "17923401550081882", "17913917791111280", "17912649166112677", "17892356038181257", "17902423363117843" };
            //var destaquesUserStories = testClass.GetFeaturedStoriesByHighlightReelIdsTest(ids);
            //var suggestedUsers = testClass.GetSuggestedUsersTest("2036299");
            //var search = testClass.SearchTest("pamela");
            //var discover = testClass.GetWebDiscoverMediaTest();
            //var unlike = testClass.UnlikeTest("2025489851503291996");
            //var like = testClass.LikeTest("2025489851503291996");
            //var hashtagInit = testClass.GetHashtagMediaInitTest("dragon ball");
            //var hashtag = testClass.GetHashtagMediasTest("dragon ball", hashtagInit.EdgeHashtagToMedia.PageInfo.EndCursor, 24);
            //var userInfo = testClass.GetUserInfoTest();
            //var requestDownloadData = testClass.RequestDownloadDataInformationTest("broncasrafa@gmail.com");
            //var timelineMediasInit = testClass.GetUserTimelineMediasTest();
            //var timelineMedias = testClass.GetUserTimelineMediasTest(timelineMediasInit.PageInfo.EndCursor);
            //var follow = testClass.FollowTest("7423808620");
            //var unfollow = testClass.UnfollowTest("7423808620");
            //var comment = testClass.CommentTest("2019605191468686270", "Teste via application 2");
            //var deleteComment = testClass.DeleteCommentTest("2019605191468686270", comment.Id);
            //var likeComment = testClass.LikeCommentTest("17923715968294425");
            //var unlikeComment = testClass.UnlikeCommentTest("17923715968294425");
            // barbralis
            //var saveMedia = testClass.SaveMediaTest("2032829567521156630");
            //var unsaveMedia = testClass.UnSaveMediaTest("2032829567521156630");
            //var mediaLikesInit = testClass.GetMediaLikesTest("BmYffCwltB5");
            //var mediaLikesOthers = testClass.GetMediaLikesTest("BmYffCwltB5", mediaLikesInit.ShortcodeLikesMedia.EdgeLikedBy.PageInfo.EndCursor);
            //var mediaInfoData = testClass.GetMediaInfoDataTest("Bw2OyIAF7-a");
            //var mediaComments = testClass.GetMediaCommentsTest("Bw2OyIAF7-a", mediaInfoData.EdgeMediaToParentComment.PageInfo.EndCursor, 40);
            //var likesFromCommentInit = testClass.GetLikesFromCommentTest("18027039061159084");
            //var likesFromCommentOthers = testClass.GetLikesFromCommentTest("18027039061159084", likesFromCommentInit.EdgeLikedBy.PageInfo.EndCursor, 48);
            //var CommentRepliesInit = testClass.GetCommentRepliesTest("18027039061159084");
            //var CommentRepliesOthers = testClass.GetCommentRepliesTest("18027039061159084", CommentRepliesInit.EdgeThreadedComments.PageInfo.EndCursor, 12);

            //var query = "#CCXP 2018";
            //var encodedString = HttpUtility.UrlEncode(query);
            //Console.WriteLine(encodedString);            

            Console.WriteLine("=================================");
        }
    }
}
