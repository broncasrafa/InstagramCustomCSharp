using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class DashInfo
    {
        [JsonProperty("is_dash_eligible")]
        public bool IsDashEligible { get; set; }

        [JsonProperty("video_dash_manifest")]
        public object VideoDashManifest { get; set; }

        [JsonProperty("number_of_qualities")]
        public int NumberOfQualities { get; set; }
    }
}
