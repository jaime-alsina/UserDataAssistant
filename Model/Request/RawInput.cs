using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class RawInput
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("inputType")]
        public string InputType { get; set; }
    }
}