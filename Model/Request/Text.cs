using Newtonsoft.Json;

namespace Model.Request
{
    public class Text
    {
        [JsonProperty("text")]
        public string[] TextText { get; set; }
    }
}