using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Capability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}