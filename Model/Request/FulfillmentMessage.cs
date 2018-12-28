using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class FulfillmentMessage
    {
        [JsonProperty("text")]
        public Text Text { get; set; }
    }
}