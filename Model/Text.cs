using Newtonsoft.Json;

namespace Model
{
    public class Text
    {
        [JsonProperty("text")]
        public string[] TextText { get; set; }
    }
}