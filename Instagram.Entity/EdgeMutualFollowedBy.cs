using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Entity
{
    public class EdgeMutualFollowedBy
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("edges")]
        public List<EdgeMutualFollowedByEdges> Edges { get; set; }
    }

    public class EdgeMutualFollowedByEdges
    {
        [JsonProperty("node")]
        public EdgeMutualFollowedByNode Node { get; set; }
    }

    public class EdgeMutualFollowedByNode
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
