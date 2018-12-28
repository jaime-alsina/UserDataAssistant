using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Payload
    {
        [JsonProperty("isInSandbox")]
        public bool IsInSandbox { get; set; }

        [JsonProperty("surface")]
        public Surface Surface { get; set; }

        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        [JsonProperty("inputs")]
        public Input[] Inputs { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("conversation")]
        public Conversation Conversation { get; set; }
    }
}