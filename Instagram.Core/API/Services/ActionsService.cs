using System;
using System.Net;
using System.IO;
using Instagram.Core.API.Services.Interfaces;
using Instagram.Core.Classes.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram.Core.Classes;


namespace Instagram.Core.API.Services
{
    public class ActionsService : IActionsService
    {
        private readonly UserSessionData _user;

        public ActionsService(UserSessionData user)
        {
            _user = user;
        }
        public IResult<string> Like(string mediaId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.LIKE_URL, mediaId);

                var data = Encoding.ASCII.GetBytes(string.Empty);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Headers["x-csrftoken"] = _user.CsrfToken;
                request.Headers["Cookie"] = _user.UserCookie;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.UserAgent = InstagramCustomApiConstants.USER_AGENT;
                request.Accept = "*/*";

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return Result.Success(responseString);
            }
            catch (Exception ex)
            {
                return Result.Fail<string>(ex.Message);
            }
        }

        public IResult<string> Unlike(string mediaId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.UNLIKE_URL, mediaId);

                var data = Encoding.ASCII.GetBytes(string.Empty);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Headers["x-csrftoken"] = _user.CsrfToken;
                request.Headers["Cookie"] = _user.UserCookie;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.UserAgent = InstagramCustomApiConstants.USER_AGENT;
                request.Accept = "*/*";

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return Result.Success(responseString);
            }
            catch (Exception ex)
            {
                return Result.Fail<string>(ex.Message);
            }
        }
    }
}
