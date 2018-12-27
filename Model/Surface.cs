using Newtonsoft.Json;

namespace Model
{
    public class Surface
    {
        [JsonProperty("capabilities")]
        public Capability[] Capabilities { get; set; }
    }
}