using Newtonsoft.Json;

namespace Instagram.Core.Classes.Response
{
    public class BaseStatusResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        public bool IsOk()
        {
            return !string.IsNullOrEmpty(Status) && Status.ToLower() == "ok";
        }

        public bool IsFail()
        {
            return !string.IsNullOrEmpty(Status) && Status.ToLower() == "fail";
        }
    }
}
