using Newtonsoft.Json;

namespace Model
{
    public class Capability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}