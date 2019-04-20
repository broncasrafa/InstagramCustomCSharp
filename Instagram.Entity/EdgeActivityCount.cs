using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeActivityCount
    {
        [JsonProperty("edges")]
        public List<EdgeActivityCountEdges> Edges { get; set; }
    }

    public class EdgeActivityCountEdges
    {
        [JsonProperty("node")]
        public EdgeActivityCountEdgesNode Node { get; set; }
    }

    public class EdgeActivityCountEdgesNode
    {
        [JsonProperty("comment_likes")]
        public int CommentLikes { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("relationships")]
        public int Relationships { get; set; }

        [JsonProperty("usertags")]
        public int Usertags { get; set; }
    }
}
