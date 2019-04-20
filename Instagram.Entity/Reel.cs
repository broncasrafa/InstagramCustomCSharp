using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class Reel  
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expiring_at")]
        public int ExpiringAt { get; set; }

        [JsonProperty("latest_reel_media")]
        public int? LatestReelMedia { get; set; }

        [JsonProperty("seen")]
        public int? Seen { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }
    }
}
