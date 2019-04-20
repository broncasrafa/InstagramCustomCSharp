using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class FeedReelsTray
    {
        [JsonProperty("edge_reels_tray_to_reel")]
        public EdgeReelsTrayToReel EdgeReelsTrayToReel { get; set; }
    }
}
