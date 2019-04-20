using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Core.Classes
{
    public class AuthenticatedLogin
    {
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("oneTapPrompt")]
        public bool OneTapPrompt { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        public string Cookie { get; set; }
    }
}
