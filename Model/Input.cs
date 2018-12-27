using Newtonsoft.Json;

namespace Model
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