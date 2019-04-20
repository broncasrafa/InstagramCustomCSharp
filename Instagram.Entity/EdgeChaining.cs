using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeChaining
    {
        [JsonProperty("edges")]
        public List<EdgeChainingEdges> Edges { get; set; }
    }

    public class EdgeChainingEdges
    {
        [JsonProperty("node")]
        public EdgeChainingNode Node { get; set; }
    }

    public class EdgeChainingNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("blocked_by_viewer")]
        public bool BlockedByViewer { get; set; }

        [JsonProperty("followed_by_viewer")]
        public bool FollowedByViewer { get; set; }

        [JsonProperty("follows_viewer")]
        public bool FollowsViewer { get; set; }

        [JsonProperty("full_name")]
        public string Fullname { get; set; }

        [JsonProperty("has_blocked_viewer")]
        public bool HasBlockedViewer { get; set; }

        [JsonProperty("has_requested_viewer")]
        public bool HasRequestedViewer { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("profile_pic_url")]
        public string ProfilePicUrl { get; set; }

        [JsonProperty("requested_by_viewer")]
        public bool RequestedByViewer { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
