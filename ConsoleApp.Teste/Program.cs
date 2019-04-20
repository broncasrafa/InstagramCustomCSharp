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
            //var search = testClass.Search("pamela");
            //var discover = testClass.GetWebDiscoverMedia();
            //var unlike = testClass.Unlike("2025489851503291996");
            //var like = testClass.Like("2025489851503291996");
            //var hashtagInit = testClass.GetHashtagMediaInitTest("dragon ball");
            //var hashtag = testClass.GetHashtagMedias("dragon ball", hashtagInit.EdgeHashtagToMedia.PageInfo.EndCursor, 24);
            //var userInfo = testClass.GetUserInfoTest();
            //var requestDownloadData = testClass.RequestDownloadDataInformationTest("broncasrafa@gmail.com");
            //var timelineMediasInit = testClass.GetUserTimelineMediasTest();
            //var timelineMedias = testClass.GetUserTimelineMediasTest(timelineMediasInit.PageInfo.EndCursor);
            // barbralis

            //var query = "#CCXP 2018";
            //var encodedString = HttpUtility.UrlEncode(query);
            //Console.WriteLine(encodedString);            

            Console.WriteLine("=================================");
        }
    }
}
