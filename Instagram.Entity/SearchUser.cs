using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class Search
    {
        [JsonProperty("users")]
        public List<UserSearch> Users { get; set; }

        [JsonProperty("places")]
        public List<PlaceSearch> Places { get; set; }

        [JsonProperty("hashtags")]
        public List<HashtagSearch> Hashtags { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("rank_token")]
        public string RankToken { get; set; }

        [JsonProperty("clear_client_cache")]
        public bool ClearClientCache { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UserSearch
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class PlaceSearch
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }
    }

    public class HashtagSearch
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("hashtag")]
        public Hashtag Hashtag { get; set; }
    }
}
