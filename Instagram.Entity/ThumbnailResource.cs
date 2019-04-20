using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class ThumbnailResource
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("config_width")]
        public int ConfigWidth { get; set; }

        [JsonProperty("config_height")]
        public int ConfigHeight { get; set; }
    }
}
