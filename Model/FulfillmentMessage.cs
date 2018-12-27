using Newtonsoft.Json;

namespace Model
{
    public class FulfillmentMessage
    {
        [JsonProperty("text")]
        public Text Text { get; set; }
    }
}