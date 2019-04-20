using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class Hashtag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("media_count")]
        public int MediaCount { get; set; }

        [JsonProperty("search_result_subtitle")]
        public string SearchResultSubtitle { get; set; }
    }
}
