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

        public EdgeSavedMedia GetSavedUserMediasTest()
        {
            return _InstagramCustomApi.GetSavedUserMedias().Data;
        }

        public EdgeUserToPhotosOfYou GetTaggedUserMediasTest(string userId)
        {
            return _InstagramCustomApi.GetTaggedUserMedias(userId).Data;
        }

        public EdgeActivityCount GetUserActivityTest()
        {
            return _InstagramCustomApi.GetUserActivity().Data;
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

        public Search Search(string query)
        {
            return _InstagramCustomApi.Search(query).Data;
        }

        public User GetWebDiscoverMedia(int limitPerPage = 24, int endCursor = 0)
        {
            return _InstagramCustomApi.GetWebDiscoverMedia(limitPerPage, endCursor).Data;
        }

        public string Like(string mediaId)
        {
            return _InstagramCustomApi.Like(mediaId).Data;
        }

        public string Unlike(string mediaId)
        {
            return _InstagramCustomApi.Unlike(mediaId).Data;
        }
    }
}
