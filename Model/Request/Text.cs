using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class Text
    {
        [JsonProperty("text")]
        public string[] TextText { get; set; }
    }
}