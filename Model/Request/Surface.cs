using Newtonsoft.Json;

namespace Model.Request
{
    public class Surface
    {
        [JsonProperty("capabilities")]
        public Capability[] Capabilities { get; set; }
    }
}