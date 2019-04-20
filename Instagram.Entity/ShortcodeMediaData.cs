using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class ShortcodeMediaData
    {
        [JsonProperty("graphql")]
        public ShortcodeMediaGraphql Graphql { get; set; }
    }
    public class ShortcodeMediaGraphql
    {
        [JsonProperty("shortcode_media")]
        public EdgeOwnerToTimelineMediaNode ShortcodeMedia { get; set; }
    }



    public class ShortcodeSavedMediaData
    {
        [JsonProperty("graphql")]
        public ShortcodeSavedMediaGraphql Graphql { get; set; }
    }
    public class ShortcodeSavedMediaGraphql
    {
        [JsonProperty("shortcode_media")]
        public EdgeSavedMediaNode ShortcodeSavedMedia { get; set; }
    }



    public class ShortcodeTaggedMediaData
    {
        [JsonProperty("graphql")]
        public ShortcodeTaggedMediaGraphql Graphql { get; set; }
    }
    public class ShortcodeTaggedMediaGraphql
    {
        [JsonProperty("shortcode_media")]
        public EdgeUserToPhotosOfYouNode ShortcodeTaggedMedia { get; set; }
    }
}
