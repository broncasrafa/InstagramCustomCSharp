using System;
using System.Net;
using System.IO;
using System.Web;
using System.Text;
using Instagram.Core.API.Services.Interfaces;
using Instagram.Core.Classes.Interfaces;
using Instagram.Core.Classes;
using Instagram.Entity;
using Newtonsoft.Json;

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
        public IResult<string> RequestDownloadDataInformation(string email)
        {
            try
            {
                var uri = InstagramCustomApiConstants.REQUEST_DOWNLOAD_DATA_URL;

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString.Add("email", email);
                queryString.Add("password", _user.Password);

                var formData = queryString.ToString();
                var data = Encoding.ASCII.GetBytes(formData);

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
        public IResult<string> Follow(string userId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.FOLLOW_URL, userId);

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
        public IResult<string> Unfollow(string userId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.UNFOLLOW_URL, userId);

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
        public IResult<CommentResponse> Comment(string mediaId, string text)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.COMMENT_URL, mediaId);

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString.Add("comment_text", text);
                queryString.Add("replied_to_comment_id", string.Empty);

                var formData = queryString.ToString();
                var data = Encoding.ASCII.GetBytes(formData);

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
                var objRetorno = JsonConvert.DeserializeObject<CommentResponse>(responseString);

                return Result.Success(objRetorno);
            }
            catch (Exception ex)
            {
                return Result.Fail<CommentResponse>(ex.Message);
            }
        }
        public IResult<string> DeleteComment(string mediaId, string commentId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.DELETE_COMMENT_URL, mediaId, commentId);

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
        public IResult<string> LikeComment(string commentId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.LIKE_COMMENT_URL, commentId);

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
        public IResult<string> UnlikeComment(string commentId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.UNLIKE_COMMENT_URL, commentId);

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
        public IResult<string> SaveMedia(string mediaId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.SAVE_MEDIA_URL, mediaId);

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
        public IResult<string> UnsaveMedia(string mediaId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.UNSAVE_MEDIA_URL, mediaId);

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
        public IResult<CommentResponse> ReplyComment(string mediaId, string comment_id, string text)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.COMMENT_URL, mediaId);

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString.Add("comment_text", text);
                queryString.Add("replied_to_comment_id", comment_id);

                var formData = queryString.ToString();
                var data = Encoding.ASCII.GetBytes(formData);

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
                var objRetorno = JsonConvert.DeserializeObject<CommentResponse>(responseString);

                return Result.Success(objRetorno);
            }
            catch (Exception ex)
            {
                return Result.Fail<CommentResponse>(ex.Message);
            }
        }
        public IResult<string> DeleteReplyComment(string mediaId, string repliedId)
        {
            try
            {
                var uri = string.Format(InstagramCustomApiConstants.DELETE_COMMENT_URL, mediaId, repliedId);

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
