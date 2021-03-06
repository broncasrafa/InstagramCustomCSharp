﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeMediaToComment
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public List<EdgeMediaToCommentEdges> Edges { get; set; }
    }

    public class EdgeMediaToCommentEdges
    {
        [JsonProperty("node")]
        public EdgeMediaToCommentNode Node { get; set; }
    }

    public class EdgeMediaToCommentNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("did_report_as_spam")]
        public bool DidReportAsSpam { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("viewer_has_liked")]
        public bool ViewerHasLiked { get; set; }
    }    
}
