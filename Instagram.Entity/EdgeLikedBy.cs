using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeLikedBy
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
