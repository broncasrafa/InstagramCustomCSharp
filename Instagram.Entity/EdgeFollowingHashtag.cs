﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeFollowingHashtag
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("edges")]
        public List<EdgeFollowingHashtagEdges> Edges { get; set; }
    }

    public class EdgeFollowingHashtagEdges
    {
        [JsonProperty("node")]
        public EdgeFollowingHashtagNode Node { get; set; }
    }

    public class EdgeFollowingHashtagNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }

        [JsonProperty("profile_pic_url")]
        public string ProfilePicUrl { get; set; }

        [JsonProperty("media_count")]
        public int MediaCount { get; set; }
    }
}
