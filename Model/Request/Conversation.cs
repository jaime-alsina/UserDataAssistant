using Newtonsoft.Json;

namespace Model.Request
{
    public class Conversation
    {
        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("conversationToken")]
        public string ConversationToken { get; set; }
    }
}