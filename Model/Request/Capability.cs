using Newtonsoft.Json;

namespace Model.Request
{
    public class Capability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}