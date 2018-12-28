using Newtonsoft.Json;

namespace Model.Response
{
    // [JsonObject("simpleResponse")]


    public class SimpleResponse
    {
        [JsonProperty("fulfillmentText")]
        public string FulfillmentText { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        //[JsonProperty("textToSpeech")]
        //public string TextToSpeech { get; set; }

        //[JsonProperty("displayText")]
        //public string DisplayText { get; set; }

        //public override string ToString()
        //{
        //    return "{'simpleResponse': {'textToSpeech': " + this.TextToSpeech + " }}";

        //}
    }
}
