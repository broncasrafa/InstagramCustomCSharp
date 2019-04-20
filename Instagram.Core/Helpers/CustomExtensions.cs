using System;
using System.IO;
using System.Net;

namespace Instagram.Core.Helpers
{
    public static class CustomExtensions
    {
        public static string[] SplitString(this string value, string separator)
        {
            return value.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ReadAsString(this HttpWebResponse response)
        {
            using(Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
