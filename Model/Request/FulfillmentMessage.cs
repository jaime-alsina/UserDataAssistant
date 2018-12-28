using Newtonsoft.Json;

namespace Model.Request
{
    public class FulfillmentMessage
    {
        [JsonProperty("text")]
        public Text Text { get; set; }
    }
}