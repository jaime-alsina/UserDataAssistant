using Newtonsoft.Json;

namespace Model.Request
{
    public class DiagnosticInfo
    {
        [JsonProperty("end_conversation")]
        public bool EndConversation { get; set; }
    }
}