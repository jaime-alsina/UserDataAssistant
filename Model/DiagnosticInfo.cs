using Newtonsoft.Json;

namespace Model
{
    public class DiagnosticInfo
    {
        [JsonProperty("end_conversation")]
        public bool EndConversation { get; set; }
    }
}