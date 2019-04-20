using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class Place
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }      

        [JsonProperty("header_media")]
        public HeaderMedia HeaderMedia { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
