using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class ActivityFeed
    {
        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("edge_web_activity_feed")]
        public EdgeWebActivityFeed EdgeWebActivityFeed { get; set; }
    }
}
