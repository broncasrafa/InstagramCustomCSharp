using Newtonsoft.Json;

namespace Instagram.Core.Classes.Response
{
    public class BadStatusResponse : BaseStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("error_type")]
        public string ErrorType { get; set; }

        [JsonProperty("checkpoint_url")]
        public string CheckPointUrl { get; set; }
    }
}
