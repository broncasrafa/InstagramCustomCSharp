using System;
using System.Net;
using System.Web;
using Instagram.Core.API.Services.Interfaces;
using Instagram.Core.Classes;
using Instagram.Core.Classes.Interfaces;
using Instagram.Core.Helpers;
using Instagram.Entity;
using Newtonsoft.Json;

namespace Instagram.Core.API.Services
{
    public class SearchService : ISearchService
    {
        private readonly UserSessionData _user;

        public SearchService(UserSessionData user)
        {
            _user = user;
        }

        public IResult<Search> Search(string query)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.SEARCH_URL, FormattedQuerySearch(query));

                var request = HttpHelper.GetDefaultRequest(uri);
                request.Headers["Cookie"] = _user.UserCookie;

                var response = HttpHelper.GetDefaultResponse(request);
                var json = response.ReadAsString();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return Result.UnExpectedResponse<Search>(response, json);
                }

                var searchData = JsonConvert.DeserializeObject<Search>(json);
                
                return Result.Success(searchData);
            }
            catch (Exception ex)
            {
                return Result.Fail<Search>(ex.Message);
            }
        }


        #region [ Private Methods ]
        private static string FormattedQuerySearch(string query)
        {
            return HttpUtility.UrlEncode(query);
        }
        #endregion
    }
}
