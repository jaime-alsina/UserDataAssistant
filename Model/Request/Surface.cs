using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Surface
    {
        [JsonProperty("capabilities")]
        public Capability[] Capabilities { get; set; }
    }
}