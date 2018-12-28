using Newtonsoft.Json;

namespace Model.Response
{
    // [JsonObject("simpleResponse")]


    public class SimpleResponse
    {
        [JsonProperty("textToSpeech")]
        public string TextToSpeech { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        public override string ToString()
        {
            return "{'simpleResponse': {'textToSpeech': " + this.TextToSpeech + " }}";

        }
    }
}
