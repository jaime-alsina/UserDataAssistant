using Newtonsoft.Json;

namespace Model
{
    public class ResponseBasic
    {
        [JsonProperty("fulfillmentText")]
        public string FulfillmentText { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}