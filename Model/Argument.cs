using Newtonsoft.Json;

namespace Model
{
    public class Argument
    {
        [JsonProperty("rawText")]
        public string RawText { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}