using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Intent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}