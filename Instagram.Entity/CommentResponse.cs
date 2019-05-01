using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class CommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_time")]
        public int CreatedTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class From
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string Fullname { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }
    }
}
