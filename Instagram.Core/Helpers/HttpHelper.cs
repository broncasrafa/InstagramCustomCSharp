using Instagram.Core.API;
using Instagram.Core.Classes.Interfaces;
using System.IO;
using System.Net;

namespace Instagram.Core.Helpers
{
    internal class HttpHelper
    {
        public static string GetRequestString(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.UserAgent = InstagramCustomApiConstants.USER_AGENT;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static HttpWebRequest GetDefaultRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.UserAgent = InstagramCustomApiConstants.USER_AGENT;
            return request;
        }
        public static HttpWebResponse GetDefaultResponse(HttpWebRequest request)
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response;
        }
    }
}
