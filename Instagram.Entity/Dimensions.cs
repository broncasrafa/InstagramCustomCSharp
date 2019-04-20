using Newtonsoft.Json;
namespace Instagram.Entity
{
    public class Dimensions
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
