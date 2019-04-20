using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class EdgeMediaToCaption
    {
        [JsonProperty("edges")]
        public List<EdgeMediaToCaptionEdges> Edges { get; set; }
    }

    public class EdgeMediaToCaptionEdges
    {
        [JsonProperty("node")]
        public EdgeMediaToCaptionNode Node { get; set; }
    }

    public class EdgeMediaToCaptionNode
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }    
}
