using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Input
    {
        [JsonProperty("rawInputs")]
        public RawInput[] RawInputs { get; set; }

        [JsonProperty("arguments")]
        public Argument[] Arguments { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }
    }
}